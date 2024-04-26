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
	/// Description of FormChef.
	/// </summary>
	public partial class FormChef : Form
	{
		private MySqlConnection connection;
		private MySqlDataAdapter dataAdapter;
		private MySqlCommand command;
		private DataSet dataSet;
		
		public FormChef()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			formulairePanel.Hide();
			InitializeDatabaseConnection();
			LoadProduits();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private int produitId = -1;

		// Constructeur pour l'ajout d'un nouvel utilisateur
		
		// Constructeur pour la modification d'un utilisateur existant
		
		
		private void fillChamps (int produitId)
		{
			//InitializeComponent();
			InitializeDatabaseConnection();
			this.produitId = produitId;
			
			//LoadUsers();

			// Récupérer les informations de l'étudiant depuis la base de données en utilisant etudiantId
			try
			{
				connection.Open();

				string query = "SELECT * FROM produits WHERE ID = @ProduitId";
				command.CommandText = query;
				command.Parameters.AddWithValue("@ProduitId", produitId);

				using (MySqlDataReader reader = command.ExecuteReader())
				{
					if (reader.Read())
					{
						intituleTextBox.Text = reader["Intitule"].ToString();
						prixTextBox.Text = reader["Prix"].ToString();
						quantiteTextBox.Text = reader["Quantite"].ToString();
						descriptionTextBox.Text = reader["Description"].ToString();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Une erreur est survenue lors de la récupération des informations du produit : " + ex.Message);
			}
			finally
			{
				connection.Close();
			}
		}
		
		
		private void InitializeDatabaseConnection()
		{
			string connectionString = "Server=localhost;Database=restaurant;Uid=root;Pwd=";
			connection = new MySqlConnection(connectionString);
			
			command = connection.CreateCommand(); // Initialiser la commande MySqlCommand avec la connexion
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

				
				dataGridView1.DataSource = dataSet.Tables["produits"];

				
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

		
		
		void AjouterButtonClick(object sender, EventArgs e)
		{
			ClearFields();
			formulairePanel.Show();
		}
		
		
		void ValiderButtonClick(object sender, EventArgs e)
		{
			if (ValidateFields())
			{
				try
				{
					connection.Open();
					
					if (produitId != -1)
					{
						// Si l'ID du produit est défini, effectuez la mise à jour des données
						string query = "UPDATE produits SET Intitule = @Intitule, Prix = @Prix," +
							"Quantite = @Quantite, Description = @Description WHERE ID = @ProduitId";
						command.CommandText = query;
					}
					else
					{
						// Sinon, effectuez l'insertion des données
						string query = "INSERT INTO produits (Intitule, Prix, Quantite, Description) " +
							"VALUES (@Intitule, @Prix, @Quantite, @Description)";
						command.CommandText = query;
						
						command.Parameters.Clear();
						
						// Ajoutez le paramètre pour l'ID du produit seulement lors de l'insertion
						command.Parameters.AddWithValue("@ProduitId", produitId);
					}
					
					// Ajoutez les autres paramètres pour les données
					
					command.Parameters.AddWithValue("@Intitule", intituleTextBox.Text);
					command.Parameters.AddWithValue("@Prix", prixTextBox.Text);
					command.Parameters.AddWithValue("@Quantite", quantiteTextBox.Text);
					command.Parameters.AddWithValue("@Description", descriptionTextBox.Text);
					
					command.ExecuteNonQuery();
					
					if (produitId == -1)
					{
						MessageBox.Show("Données enregistrées avec succès !");
					}
					else
					{
						MessageBox.Show("Données mises à jour avec succès !");
					}
					
					this.DialogResult = DialogResult.OK; // Ferme le formulaire après insertion/modification
					
				}
				catch (Exception ex)
				{
					MessageBox.Show("Une erreur est survenue : " + ex.Message);
				}
				finally				    {
					connection.Close();
				}
				
				LoadProduits();
				formulairePanel.Hide();
			}
		}
		
		
		public int GetProduitIdFromDatabase(string intitule, double prix, int quantite, string description)
		{
			produitId = -1;
			
			try
			{
				connection.Open();
				
				string query = "SELECT ID FROM produits WHERE Intitule = @Intitule AND Prix = @Prix AND Quantite = @Quantite AND Description = @Description";
				
				MySqlCommand command = new MySqlCommand(query, connection);
				command.Parameters.AddWithValue("@Intitule", intitule);
				command.Parameters.AddWithValue("@Prix", prix);
				command.Parameters.AddWithValue("@Quantite", quantite);
				command.Parameters.AddWithValue("@Description", description);
				
				object result = command.ExecuteScalar();
				if (result != null)
				{
					produitId = Convert.ToInt32(result);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Une erreur est survenue lors de la recherche de l'ID du produit : " + ex.Message);
			}
			finally
			{
				connection.Close();
			}
			
			return produitId;
		}


		void ModifierButtonClick(object sender, EventArgs e)
		{
			// Vérifier si un étudiant est sélectionné dans le DataGridView
			if (dataGridView1.SelectedRows.Count > 0)
			{
				
				// Récupérer les informations uniques de l'étudiant sélectionné dans le DataGridView
				string intitule = dataGridView1.SelectedRows[0].Cells["Intitule"].Value.ToString();
				double prix = Convert.ToSingle(dataGridView1.SelectedRows[0].Cells["Prix"].Value);
				int quantite = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Quantite"].Value);
				string description = dataGridView1.SelectedRows[0].Cells["Description"].Value.ToString();
				
				// Rechercher l'ID de l'étudiant en fonction des informations uniques
				produitId = GetProduitIdFromDatabase(intitule, prix, quantite, description);
				
				if (produitId != -1)
				{
					
					
					// Afficher le formulaire de modification en mode d'édition
					formulairePanel.Show();
					fillChamps(produitId);
					
					// Rafraîchir la liste des produits après la modification
					//LoadProduits();
					
				}
				else
				{
					MessageBox.Show("Impossible de trouver l'ID du produit correspondant.");
				}
			}
		}
		
		private bool ValidateFields()
		{
			// Vérifier si les champs obligatoires sont remplis
			if (string.IsNullOrWhiteSpace(intituleTextBox.Text) ||
			    string.IsNullOrWhiteSpace(prixTextBox.Text) ||
			    string.IsNullOrWhiteSpace(quantiteTextBox.Text) ||
			    string.IsNullOrWhiteSpace(descriptionTextBox.Text))
			{
				MessageBox.Show("Veuillez remplir tous les champs obligatoires.");
				return false;
			}
			
			return true;
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		
		
		void SupprimerButtonClick(object sender, EventArgs e)
		{
			// Vérifier si une ligne est sélectionnée dans le DataGridView
			if (dataGridView1.SelectedRows.Count > 0)
			{
				// Récupérer l'ID de l'étudiant sélectionné dans le DataGridView
				int produitID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
				
				try
				{
					connection.Open();
					
					// Créer la requête DELETE pour supprimer l'étudiant avec l'ID correspondant
					string query = "DELETE FROM produits WHERE ID = @ProduitID";
					
					MySqlCommand deleteCommand = new MySqlCommand(query, connection);
					deleteCommand.Parameters.AddWithValue("@ProduitID", produitID);
					deleteCommand.ExecuteNonQuery();
					
					// Afficher un message de confirmation après la suppression réussie
					MessageBox.Show("Produit supprimé avec succès !");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Une erreur est survenue : " + ex.Message);
				}
				finally
				{
					connection.Close();
					LoadProduits(); // Rafraîchir la liste des étudiants après la suppression
				}
			}
		}
		
		void RetourButtonClick(object sender, EventArgs e)
		{
			MainForm mainform = new MainForm();
			mainform.Show();
			
			this.Hide();
		}
		
		void rechercheTextBoxChanged(object sender, EventArgs e)
		{
			// Vérifier si la recherche est vide
			if (string.IsNullOrEmpty(rechercheTextBox.Text))
			{
				// Si la recherche est vide, afficher la liste complète des utilisateurs
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
				dataGridView1.DataSource = dataView;

			}
		}

		
		
		
		
		void AnnulerButtonClick(object sender, EventArgs e)
		{
			ClearFields();
			formulairePanel.Hide();
		}
		
		
		private void ClearFields()
		{
			intituleTextBox.Clear();
			prixTextBox.Clear();
			quantiteTextBox.Clear();
			descriptionTextBox.Clear();
		}

		void DataGridView1CellContentClick(object sender, EventArgs e)
		{
			
		}
		
		void PrixLabelClick(object sender, EventArgs e)
		{
			
		}
		
		void PrixTextBoxTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void QuantiteTextBoxTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void IntituleTextBoxTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void DescriptionTextBoxTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void FormChefLoad(object sender, EventArgs e)
		{
			
		}
	}
}



