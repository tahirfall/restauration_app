/*
 * Created by SharpDevelop.
 * User: fallt
 * Date: 22/08/2023
 * Time: 12:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Gestion_restaurant
{
	/// <summary>
	/// Description of FormPaiement.
	/// </summary>
	public partial class FormPaiement : Form
	{
		
		private MySqlConnection connection;
		private MySqlDataAdapter dataAdapter;
		private MySqlCommand command;
		private DataSet dataSet;
		
		public FormPaiement()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			InitializeDatabaseConnection();
			
			LoadCommandesNonPayes();
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private int commandeId = -1;
		
		private void InitializeDatabaseConnection()
		{
			string connectionString = "Server=localhost;Database=restaurant;Uid=root;Pwd=";
			connection = new MySqlConnection(connectionString);
			
			command = connection.CreateCommand(); // Initialiser la commande MySqlCommand avec la connexion
		}
		
		private void LoadCommandesNonPayes()
		{
			try
			{
				connection.Open();

				
				string query = "SELECT * FROM commandes WHERE Etat='Non Paye' ORDER BY id";

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
		
		private void fillChamps (int commandeId)
		{
			
			InitializeDatabaseConnection();
			this.commandeId = commandeId;
			
			

			// Récupérer les informations de l'étudiant depuis la base de données en utilisant etudiantId
			try
			{
				connection.Open();

				string query = "SELECT * FROM commandes WHERE ID = @CommandeId";
				command.CommandText = query;
				command.Parameters.AddWithValue("@CommandeId", commandeId);

				using (MySqlDataReader reader = command.ExecuteReader())
				{
					if (reader.Read())
					{
						intitulesTextBox.Text = reader["IntitulesProduits"].ToString();
						quantiteTextBox.Text = reader["Quantite"].ToString();
						prixTotalTextBox.Text = reader["PrixTotal"].ToString();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Une erreur est survenue lors de la récupération des informations de la commande : " + ex.Message);
			}
			finally
			{
				connection.Close();
			}
		}
		
		public int GetCommandeIdFromDatabase(string intitulesProduits, int quantite, double prixTotal, string etat)
		{
			commandeId = -1;
			
			try
			{
				connection.Open();
				
				string query = "SELECT ID FROM commandes WHERE IntitulesProduits = @IntitulesProduits AND Quantite = @Quantite AND PrixTotal = @PrixTotal AND Etat = @Etat";
				
				MySqlCommand command = new MySqlCommand(query, connection);
				command.Parameters.AddWithValue("@IntitulesProduits", intitulesProduits);
				command.Parameters.AddWithValue("@PrixTotal", prixTotal);
				command.Parameters.AddWithValue("@Quantite", quantite);
				command.Parameters.AddWithValue("@Etat", etat);
				
				object result = command.ExecuteScalar();
				if (result != null)
				{
					commandeId = Convert.ToInt32(result);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Une erreur est survenue lors de la recherche de l'ID de la commande : " + ex.Message);
			}
			finally
			{
				connection.Close();
			}
			
			return commandeId;
		}
		
		void PayerButtonClick(object sender, System.EventArgs e)
		{
			// Vérifier si une commande est sélectionnée dans le DataGridView
			if (dataGridView1.SelectedRows.Count > 0)
			{
				
				// Récupérer les informations uniques de l'étudiant sélectionné dans le DataGridView
				string intitules = dataGridView1.SelectedRows[0].Cells["IntitulesProduits"].Value.ToString();
				double prixTotal = Convert.ToSingle(dataGridView1.SelectedRows[0].Cells["PrixTotal"].Value);
				int quantite = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Quantite"].Value);
				string etat = dataGridView1.SelectedRows[0].Cells["Etat"].Value.ToString();
				
				// Rechercher l'ID de l'étudiant en fonction des informations uniques
				commandeId = GetCommandeIdFromDatabase(intitules, quantite, prixTotal, etat);
				
				
				if (commandeId != -1)
				{
					
					
					// Afficher le formulaire de modification en mode d'édition
					//formulairePanel.Show();
					fillChamps(commandeId);
					intitulesTextBox.Enabled = false;
					quantiteTextBox.Enabled = false;
					prixTotalTextBox.Enabled = false;
					// Rafraîchir la liste des produits après la modification
					//LoadProduits();
					
				}
				else
				{
					MessageBox.Show("Impossible de trouver l'ID de la commande correspondant.");
				}
			}
		}
		
		void ValiderButtonClick(object sender, System.EventArgs e)
		{
			if(ValidateFields())
			{
				try {
					connection.Open();
					
					string intitules = intitulesTextBox.Text;
					int quantite = int.Parse(quantiteTextBox.Text);
					double prixTotal = Convert.ToDouble(prixTotalTextBox.Text);
					string etat = etatComboBox.Text;
					//int jour = int.Parse(jourComboBox.Text);
					//int mois = int.Parse(moisComboBox.Text);
					//int annee = int.Parse(anneComboBox.Text);
					//Date dateCommande =  new Date(jour, mois, annee);
					
					if (commandeId != -1)
					{
						// Si l'ID du produit est défini, effectuez la mise à jour des données
						string query = "UPDATE commandes SET Etat = @Etat WHERE ID = @CommandeID";
						command.CommandText = query;
					}
					
					// Ajoutez les autres paramètres pour les données
					//command.Parameters.AddWithValue("@IntitulesProduits", intitules);
					//command.Parameters.AddWithValue("@Quantite", quantites);
					//command.Parameters.AddWithValue("@PrixTotal", prixTot);
					command.Parameters.AddWithValue("@Etat", etat);

					//command.Parameters.AddWithValue("@DateCommande", dateCommande);
					
					command.ExecuteNonQuery();
					
					if (commandeId != -1)
					{
						MessageBox.Show("Commande payée avec succès !");
					}
					
					this.DialogResult = DialogResult.OK;
					
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
			ClearFields();
			LoadCommandesNonPayes();
			
		}
		
		void AnnulerButtonClick(object sender, System.EventArgs e)
		{
			ClearFields();
		}
		void RetourButtonClick(object sender, System.EventArgs e)
		{
			FormRestaurateur formRest = new FormRestaurateur();
			formRest.Show();
			
			
			this.Hide();
		}
		
		private bool ValidateFields()
		{
			// Vérifier si les champs obligatoires sont remplis
			if (string.IsNullOrWhiteSpace(intitulesTextBox.Text) ||
			    string.IsNullOrWhiteSpace(prixTotalTextBox.Text) ||
			    string.IsNullOrWhiteSpace(quantiteTextBox.Text) ||
			    string.IsNullOrWhiteSpace(etatComboBox.Text))
			{
				MessageBox.Show("Veuillez remplir tous les champs obligatoires.");
				return false;
			}
			
			return true;
		}
		
		private void ClearFields()
		{
			intitulesTextBox.Clear();
			prixTotalTextBox.Clear();
			quantiteTextBox.Clear();
			etatComboBox.SelectedIndex = -1;
		}
		
		void rechercheTextBoxChanged(object sender, System.EventArgs e)
		{
			// Vérifier si la recherche est vide
			if (string.IsNullOrEmpty(rechercheTextBox.Text))
			{
				// Si la recherche est vide, afficher la liste complète des commmandes
				LoadCommandesNonPayes();
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
		
		void FormCommanderLoad(object sender, System.EventArgs e)
		{
			
		}
		
		void Label3Click(object sender, System.EventArgs e)
		{
			
		}
		
		void TextBox3TextChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void DataGridView1CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			
		}
		
		void TextBox1TextChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void Label8Click(object sender, System.EventArgs e)
		{
			
		}
		
		void Label6Click(object sender, EventArgs e)
		{
			
		}
	}
}





