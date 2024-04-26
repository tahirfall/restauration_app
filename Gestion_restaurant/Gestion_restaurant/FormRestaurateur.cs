/*
 * Created by SharpDevelop.
 * User: fallt
 * Date: 18/08/2023
 * Time: 21:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Gestion_restaurant
{
	/// <summary>
	/// Description of FormRestaurateur.
	/// </summary>
	public partial class FormRestaurateur : Form
	{
		private MySqlConnection connection;
		private MySqlDataAdapter dataAdapter;
		private MySqlCommand command;
		private DataSet dataSet;
		
		public FormRestaurateur()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			InitializeDatabaseConnection();
			LoadCommandes();
			
			dataGridView2.Visible = false;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		//private int produitId = -1;

		
		
		
		private void InitializeDatabaseConnection()
		{
			string connectionString = "Server=localhost;Database=restaurant;Uid=root;Pwd=";
			connection = new MySqlConnection(connectionString);
			
			command = connection.CreateCommand(); // Initialiser la commande MySqlCommand avec la connexion
		}
		
		private void LoadCommandes()
		{
			try
			{
				connection.Open();

				
				string query = "SELECT * FROM commandes ORDER BY id";

				dataAdapter = new MySqlDataAdapter(query, connection);
				dataSet = new DataSet();

				
				dataAdapter.Fill(dataSet, "commandes");

				
				dataGridView1.DataSource = dataSet.Tables["commandes"];

				
				dataGridView1.Columns["id"].Visible = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Une erreur est survenue : " + ex.Message);
			}
			finally
			{
				connection.Close();
			}
		}
		
		
		private void LoadProduits()
		{
			try
			{
				connection.Open();

				
				string query = "SELECT * FROM produits ORDER BY id";

				dataAdapter = new MySqlDataAdapter(query, connection);
				dataSet = new DataSet();

				
				dataAdapter.Fill(dataSet, "produits");

				
				dataGridView2.DataSource = dataSet.Tables["produits"];

				
				dataGridView1.Columns["id"].Visible = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Une erreur est survenue : " + ex.Message);
			}
			finally
			{
				connection.Close();
			}
		}
		
		
		
		void ListeProduitButtonClick(object sender, System.EventArgs e)
		{
			dataGridView2.Visible = true;
			LoadProduits();
			
			dataGridView1.Visible = false;
			
		}
		
		void PrendreCommandeButtonClick(object sender, System.EventArgs e)
		{
			
			//Créer une instance du formulaire de saisie de commande
			FormCommande1 formCommand = new FormCommande1();
			
			formCommand.Show();
			
			
			this.Hide();

		}
		
		void ListerCommandesButtonClick(object sender, System.EventArgs e)
		{
			
			dataGridView1.Visible = true;
			LoadCommandes();
			
			dataGridView2.Visible = false;
		}
		
		void RecetteButtonClick(object sender, System.EventArgs e)
		{
			FormRecette formRecet = new FormRecette();
			formRecet.Show();
			
			this.Hide();
		}
		
		void PaiementCommandeButtonClick(object sender, System.EventArgs e)
		{
			FormPaiement formPaiem = new FormPaiement();
			formPaiem.Show();
			
			this.Hide();
		}
		
		void rechercheTextBoxChanged(object sender, System.EventArgs e)
		{
			if(dataGridView2.Visible)
			{
				// Vérifier si la recherche est vide
				if (string.IsNullOrEmpty(rechercheTextBox.Text))
				{
					// Si la recherche est vide, afficher la liste complète des produits
					LoadProduits();
				}
				else
				{
					DataView dataView = dataSet.Tables["produits"].DefaultView;

					string searchTerm = rechercheTextBox.Text.ToLower(); // Convertir en minuscules pour une recherche insensible à la casse

					// Créer une condition pour les colonnes texte avec correspondance du terme
					string textFilter = "Intitule LIKE '%" + searchTerm + "%' OR Description LIKE '%" + searchTerm + "%'";
					
					
					// Créer une condition pour la colonne Prix si le terme peut être converti en float
					double prix;
					bool isNumeric = double.TryParse(searchTerm, out prix);
					string prixFilter = isNumeric ? "Prix = " + prix : "";

					int quantite;
					bool isNumericQuantite = int.TryParse(searchTerm, out quantite);
					string quantiteFilter = isNumericQuantite ? "Quantite = " + quantite : "";

					// Combiner les conditions en utilisant OR si nécessaire
					string combinedFilter = textFilter;
					if (!string.IsNullOrEmpty(prixFilter))
					{
						combinedFilter = textFilter + " OR " + prixFilter;
					}
					if (!string.IsNullOrEmpty(quantiteFilter))
					{
						combinedFilter = combinedFilter + " OR " + quantiteFilter;
					}

					dataView.RowFilter = combinedFilter;
					dataGridView2.DataSource = dataView;

				}
			}
			else
			{
				// Vérifier si la recherche est vide
				if (string.IsNullOrEmpty(rechercheTextBox.Text))
				{
					// Si la recherche est vide, afficher la liste complète des commmandes
					LoadCommandes();
				}
				else
				{
					DataView dataView = dataSet.Tables["commandes"].DefaultView;

					string searchTerm = rechercheTextBox.Text.ToLower(); // Convertir en minuscules pour une recherche insensible à la casse

					// Créer une condition pour les colonnes texte avec correspondance du terme
					string textFilter = "IntitulesProduits LIKE '%" + searchTerm + "%' OR Etat LIKE '%" + searchTerm + "%' OR DateCommande LIKE '%" + searchTerm + "%'";
					
					
					// Créer une condition pour la colonne Prix si le terme peut être converti en float
					double prixTotal;
					bool isNumeric = double.TryParse(searchTerm, out prixTotal);
					string prixTotalFilter = isNumeric ? "PrixTotal = " + prixTotal : "";

					int quantite;
					bool isNumericQuantite = int.TryParse(searchTerm, out quantite);
					string quantiteFilter = isNumericQuantite ? "Quantite = " + quantite : "";

					// Combiner les conditions en utilisant OR si nécessaire
					string combinedFilter = textFilter;
					if (!string.IsNullOrEmpty(prixTotalFilter))
					{
						combinedFilter = textFilter + " OR " + prixTotalFilter;
					}
					if (!string.IsNullOrEmpty(quantiteFilter))
					{
						combinedFilter = combinedFilter + " OR " + quantiteFilter;
					}

					dataView.RowFilter = combinedFilter;
					dataGridView1.DataSource = dataView;

				}
			}
		}
		
		void RetourButtonClick(object sender, System.EventArgs e)
		{
			MainForm mainForm = new MainForm();
			mainForm.Show();
			
			this.Hide();
			
		}
		
		void FormRestaurateurLoad(object sender, System.EventArgs e)
		{
			
		}
		
		void DataGridView1CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			
		}
	}
}






