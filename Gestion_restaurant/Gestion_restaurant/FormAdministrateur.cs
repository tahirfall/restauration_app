/*
 * Created by SharpDevelop.
 * User: fallt
 * Date: 18/08/2023
 * Time: 22:48
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
	/// Description of FormAdministrateur.
	/// </summary>
	public partial class FormAdministrateur : Form
	{
		private MySqlConnection connection;
		private MySqlDataAdapter dataAdapter;
		private MySqlCommand command;
		private DataSet dataSet;
		
		
		
		public FormAdministrateur()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			formulairePanel.Hide();
			InitializeDatabaseConnection();
			LoadUsers();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private int utilisateurId = -1;

		// Constructeur pour l'ajout d'un nouvel utilisateur
		
		// Constructeur pour la modification d'un utilisateur existant
		
		
		private void fillChamps (int utilisateurId)
		{
			//InitializeComponent();
			InitializeDatabaseConnection();
			this.utilisateurId = utilisateurId;
			
			//LoadUsers();

			// Récupérer les informations de l'étudiant depuis la base de données en utilisant etudiantId
			try
			{
				connection.Open();

				string query = "SELECT * FROM utilisateurs WHERE ID = @UtilisateurId";
				command.CommandText = query;
				command.Parameters.AddWithValue("@UtilisateurId", utilisateurId);

				using (MySqlDataReader reader = command.ExecuteReader())
				{
					if (reader.Read())
					{
						nomTextBox.Text = reader["Nom"].ToString();
						prenomTextBox.Text = reader["Prenom"].ToString();
						roleComboBox.Text = reader["Role"].ToString();
						LoginTextBox.Text = reader["Login"].ToString();
						passwordTextBox.Text = reader["Password"].ToString();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Une erreur est survenue lors de la récupération des informations de l'utilisateur : " + ex.Message);
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
		
		private void LoadUsers()
		{
			try
			{
				connection.Open();

				
				string query = "SELECT * FROM utilisateurs ORDER BY id";

				dataAdapter = new MySqlDataAdapter(query, connection);
				dataSet = new DataSet();

				
				dataAdapter.Fill(dataSet, "utilisateurs");

				
				dataGridView1.DataSource = dataSet.Tables["utilisateurs"];

				
				dataGridView1.Columns["id"].Visible = true;
				dataGridView1.Columns["password"].Visible = false;
				dataGridView1.Columns["login"].Visible = false;
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
			//confimerButton.Visible = false;
		}
		
		
		void ValiderButtonClick(object sender, EventArgs e)
		{
			if (ValidateFields())
			{
				try
				{
					connection.Open();
					
					if (utilisateurId != -1)
					{
						// Si l'ID de l'utilisateur est défini, effectuez la mise à jour des données
						string query = "UPDATE utilisateurs SET Nom = @Nom, Prenom = @Prenom, Role = @Role," +
							"Login = @Login, Password = @Password WHERE ID = @UtilisateurId";
						command.CommandText = query;
					}
					else
					{
						// Sinon, effectuez l'insertion des données
						string query = "INSERT INTO utilisateurs (Nom, Prenom, Role, Login, Password) " +
							"VALUES (@Nom, @Prenom, @Role, @Login, @Password)";
						command.CommandText = query;
						
						command.Parameters.Clear();
						// Ajoutez le paramètre pour l'ID de l'utilisateur seulement lors de l'insertion
						command.Parameters.AddWithValue("@UtilisateurId", utilisateurId);
					}
					
					// Ajoutez les autres paramètres pour les données
					
					command.Parameters.AddWithValue("@Nom", nomTextBox.Text);
					command.Parameters.AddWithValue("@Prenom", prenomTextBox.Text);
					command.Parameters.AddWithValue("@Role", roleComboBox.Text);
					command.Parameters.AddWithValue("@Login", LoginTextBox.Text);
					command.Parameters.AddWithValue("@Password", passwordTextBox.Text);
					
					command.ExecuteNonQuery();
					
					if (utilisateurId == -1)
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
				
				LoadUsers();
				formulairePanel.Hide();
			}
		}
		
		
		public int GetUtilisateurIdFromDatabase(string nom, string prenom, string role, string login, string password)
		{
			utilisateurId = -1;
			
			try
			{
				connection.Open();
				
				string query = "SELECT ID FROM utilisateurs WHERE Nom = @Nom AND Prenom = @Prenom AND Role = @Role AND Login = @Login AND Password = @Password";
				
				MySqlCommand command = new MySqlCommand(query, connection);
				command.Parameters.AddWithValue("@Nom", nom);
				command.Parameters.AddWithValue("@Prenom", prenom);
				command.Parameters.AddWithValue("@Role", role);
				command.Parameters.AddWithValue("@Login", login);
				command.Parameters.AddWithValue("@Password", password);
				
				object result = command.ExecuteScalar();
				if (result != null)
				{
					utilisateurId = Convert.ToInt32(result);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Une erreur est survenue lors de la recherche de l'ID de l'utilisateur : " + ex.Message);
			}
			finally
			{
				connection.Close();
			}
			
			return utilisateurId;
		}


		void ModifierButtonClick(object sender, EventArgs e)
		{
			// Vérifier si un étudiant est sélectionné dans le DataGridView
			if (dataGridView1.SelectedRows.Count > 0)
			{
		
				// Récupérer les informations uniques de l'étudiant sélectionné dans le DataGridView
				string nom = dataGridView1.SelectedRows[0].Cells["Nom"].Value.ToString();
				string prenom = dataGridView1.SelectedRows[0].Cells["Prenom"].Value.ToString();
				string role = dataGridView1.SelectedRows[0].Cells["Role"].Value.ToString();
				string login = dataGridView1.SelectedRows[0].Cells["Login"].Value.ToString();
				string password = dataGridView1.SelectedRows[0].Cells["Password"].Value.ToString();
				
				// Rechercher l'ID de l'étudiant en fonction des informations uniques
				utilisateurId = GetUtilisateurIdFromDatabase(nom, prenom, role, login, password);
				
				if (utilisateurId != -1)
				{

					
					
					// Afficher le formulaire de modification en mode d'édition
					formulairePanel.Show();
					fillChamps(utilisateurId);
					
					// Rafraîchir la liste des étudiants après la modification
					LoadUsers();
					
				}
				else
				{
					MessageBox.Show("Impossible de trouver l'ID de l'utilisateur correspondant.");
				}
			}
		}
		
		private bool ValidateFields()
		{
			// Vérifier si les champs obligatoires sont remplis
			if (string.IsNullOrWhiteSpace(nomTextBox.Text) ||
			    string.IsNullOrWhiteSpace(prenomTextBox.Text) ||
			    string.IsNullOrWhiteSpace(roleComboBox.Text) ||
			    string.IsNullOrWhiteSpace(LoginTextBox.Text) ||
			    string.IsNullOrWhiteSpace(passwordTextBox.Text))
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
				int utilisateurId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
				
				try
				{
					connection.Open();
					
					// Créer la requête DELETE pour supprimer l'étudiant avec l'ID correspondant
					string query = "DELETE FROM utilisateurs WHERE ID = @utilisateurId";
					
					MySqlCommand deleteCommand = new MySqlCommand(query, connection);
					deleteCommand.Parameters.AddWithValue("@UtilisateurId", utilisateurId);
					deleteCommand.ExecuteNonQuery();
					
					// Afficher un message de confirmation après la suppression réussie
					MessageBox.Show("Utilisateur supprimé avec succès !");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Une erreur est survenue : " + ex.Message);
				}
				finally
				{
					connection.Close();
					LoadUsers(); // Rafraîchir la liste des étudiants après la suppression
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
				LoadUsers();
			}
			else
			{
				DataView dataView = dataSet.Tables["utilisateurs"].DefaultView;

				string searchTerm = rechercheTextBox.Text.ToLower(); // Convertir en minuscules pour une recherche insensible à la casse

				// Créer une condition pour les colonnes texte avec correspondance du terme
				string textFilter = "Nom LIKE '%" + searchTerm + "%' OR Prenom LIKE '%" + searchTerm + "%' OR Role LIKE '%" + searchTerm + "%' OR Login LIKE '%" + searchTerm + "%'";

				dataView.RowFilter = textFilter;
				dataGridView1.DataSource = dataView;

				// Masquer la colonne du mot de passe
				dataGridView1.Columns["Password"].Visible = false;
			}
		}

		
		
		
		
		void AnnulerButtonClick(object sender, EventArgs e)
		{
			ClearFields();
			formulairePanel.Hide();
		}
		
		
		private void ClearFields()
		{
			nomTextBox.Clear();
			prenomTextBox.Clear();
			roleComboBox.SelectedIndex = -1;
			LoginTextBox.Clear();
			passwordTextBox.Clear();
		}

		void DataGridView1CellContentClick(object sender, EventArgs e)
		{
			
		}
		
		void PrimeLabelClick(object sender, EventArgs e)
		{
			
		}
		
		void TextBox6TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TextBox5TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void FormAdministrateurLoad(object sender, EventArgs e)
		{
			
		}
		
		
	}
}


