/*
 * Created by SharpDevelop.
 * User: fallt
 * Date: 21/08/2023
 * Time: 16:27
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
	/// Description of FormCommande1.
	/// </summary>
	public partial class FormCommande1 : Form
	{
		private MySqlConnection connection;
		private MySqlDataAdapter dataAdapter;
		private MySqlCommand command;
		private DataSet dataSet;
		
		
		
		public List<Produit> listProduitsCommandes;
		
		public FormCommande1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			InitializeDatabaseConnection();
			LoadProduits();
			
			InitialiseDataGridView2();
			
			listProduitsCommandes = new List<Produit>();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		private int produitId = -1;
		private int commandeId = -1;
		private double prixTotal = 0;

		
		
		private void InitializeDatabaseConnection()
		{
			string connectionString = "Server=localhost;Database=restaurant;Uid=root;Pwd=";
			connection = new MySqlConnection(connectionString);
			
			command = connection.CreateCommand(); // Initialiser la commande MySqlCommand avec la connexion
		}
		
		private void InitialiseDataGridView2()
		{
			
			dataGridView2.Columns.Add("Intitule", "Intitule");
			dataGridView2.Columns.Add("Prix", "Prix");
			dataGridView2.Columns.Add("Quantite", "Quantite");
			dataGridView2.Columns.Add("Description", "Description");
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
		
		public int GetProduitQuantiteFromDatabase(int id)
		{
			produitId = -1;
			int produitQuantite = 0;
			
			try
			{
				connection.Open();
				
				string query = "SELECT Quantite FROM produits WHERE ID = @Id";
				
				MySqlCommand command = new MySqlCommand(query, connection);
				command.Parameters.AddWithValue("@Id", id);
				
				object result = command.ExecuteScalar();
				if (result != null)
				{
					produitQuantite = Convert.ToInt32(result);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Une erreur est survenue lors de la recherche de de la quantite du produit : " + ex.Message);
			}
			finally
			{
				connection.Close();
			}
			
			return produitQuantite;
		}

		
		
		void AjouterButtonClick(object sender, System.EventArgs e)
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
					//formulairePanel.Show();
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
		
		
		void OkButtonClick(object sender, System.EventArgs e)
		{
			
			if(ValidateFields())
			{
				try {
					
					int Quantite = GetProduitQuantiteFromDatabase(produitId);
					
					connection.Open();
					// Récupérer les valeurs des champs du formulaire
					
					string intitule = intituleTextBox.Text;
					double prix = Convert.ToDouble(prixTextBox.Text);
					int quantiteCommande = int.Parse(quantiteCommandeTextBox.Text);

					string description = descriptionTextBox.Text;
					
					//int jour = int.Parse(textBox8.Text);
					//int mois = int.Parse(textBox9.Text);
					//int annee = int.Parse(textBox10.Text);
					//Date dateEmbauche =  new Date(jour, mois, annee);// Remplacez ... par les valeurs appropriées pour la date
					
					if(quantiteCommandeDisponible(quantiteCommande, Quantite))
					{
						
						
						// Créer un nouvel employé permanent
						Produit prod = new Produit(intitule, prix, quantiteCommande, description);
						
						//MessageBox.Show("Quantite Commande: "+quantiteCommande );
						
						listProduitsCommandes.Add(prod);
						//LoadDataIntoDataGridView2();
						
						// Avant d'appeler LoadDataIntoDataGridView2()
						LoadDataIntoDataGridView2(listProduitsCommandes);

						
						prixTotal += (prix * quantiteCommande);
						prixTotalTextBox.Text=prixTotal+"";
						
						
						Quantite -= quantiteCommande;
						
						
						
						
						string query = "UPDATE produits SET Quantite = @Quantite WHERE ID = @ProduitId";
						command.CommandText = query;
						
						//command.Parameters.Clear();
						
						
						command.Parameters.AddWithValue("@Quantite", Quantite);
						
						command.ExecuteNonQuery();

					}
					
				}
				catch (Exception ex)
				{
					MessageBox.Show("Une erreur s'est produite lors de l'ajout du produit sur la commande : " + ex.Message,
					                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					connection.Close();
				}
			}
			
			
			// Effacer les champs du formulaire après l'ajout
			
			LoadProduits();
			ClearFields();
		}
		
		
		
		
		public void LoadDataIntoDataGridView2(List<Produit> lisProd)
		{
			dataGridView2.Rows.Clear(); // Efface toutes les lignes actuelles du DataGridView
			
			foreach (Produit item in lisProd)
			{
				dataGridView2.Rows.Add(item.Intitule, item.Prix, item.Quantite, item.Description);
			}
		}
		
		void ValiderButtonClick(object sender, System.EventArgs e)
		{
			if(ValidateAllFields())
			{
				try {
					connection.Open();
					
					string intitules = getIntitules(listProduitsCommandes);
					int quantites = getQuantites(listProduitsCommandes);
					double prixTot = Convert.ToDouble(prixTotalTextBox.Text);
					string etat = etatComboBox.Text;
					int jour = int.Parse(jourComboBox.Text);
					int mois = int.Parse(moisComboBox.Text);
					int annee = int.Parse(anneComboBox.Text);
					Date dateCommande =  new Date(jour, mois, annee);
					
					if (commandeId == -1)
					{
						
						// Sinon, effectuez l'insertion des données
						string query = "INSERT INTO commandes (IntitulesProduits, Quantite, PrixTotal, Etat, DateCommande) " +
							"VALUES (@IntitulesProduits, @Quantite, @PrixTotal, @Etat, @DateCommande)";
						command.CommandText = query;
						
						
						command.Parameters.Clear();
						// Ajoutez le paramètre pour l'ID de l'étudiant seulement lors de l'insertion
						command.Parameters.AddWithValue("@CommandeID", commandeId);
					}
					
					// Ajoutez les autres paramètres pour les données
					command.Parameters.AddWithValue("@IntitulesProduits", intitules);
					command.Parameters.AddWithValue("@Quantite", quantites);
					command.Parameters.AddWithValue("@PrixTotal", prixTot);
					command.Parameters.AddWithValue("@Etat", etat);
					command.Parameters.AddWithValue("@DateCommande", dateCommande);
					
					command.ExecuteNonQuery();
					
					if (commandeId == -1)
					{
						MessageBox.Show("Commande enregistrée avec succès !");
						listProduitsCommandes = new List<Produit>();
						LoadDataIntoDataGridView2(listProduitsCommandes);
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
			ClearAllFields();
			LoadProduits();
			
		}
		
		void AnnulerButtonClick(object sender, System.EventArgs e)
		{
			//restaurerQuantitesProduits();
			
			ClearAllFields();
			listProduitsCommandes = new List<Produit>();
			
			LoadDataIntoDataGridView2(listProduitsCommandes);
			
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
			if (string.IsNullOrWhiteSpace(intituleTextBox.Text) ||
			    string.IsNullOrWhiteSpace(prixTextBox.Text) ||
			    string.IsNullOrWhiteSpace(quantiteCommandeTextBox.Text) ||
			    string.IsNullOrWhiteSpace(descriptionTextBox.Text))
			{
				MessageBox.Show("Veuillez remplir tous les champs obligatoires.");
				return false;
			}
			
			return true;
		}
		
		private bool ValidateAllFields()
		{
			// Vérifier si les champs obligatoires sont remplis
			if (string.IsNullOrWhiteSpace(prixTotalTextBox.Text) ||
			    string.IsNullOrWhiteSpace(jourComboBox.Text) ||
			    string.IsNullOrWhiteSpace(moisComboBox.Text) ||
			    string.IsNullOrWhiteSpace(anneComboBox.Text))
			{
				MessageBox.Show("Veuillez remplir tous les champs obligatoires.");
				return false;
			}
			
			return true;
		}
		
		
		private void ClearFields()
		{
			intituleTextBox.Clear();
			prixTextBox.Clear();
			quantiteCommandeTextBox.Clear();
			descriptionTextBox.Clear();
		}
		
		private void ClearAllFields()
		{
			ClearFields();
			prixTotalTextBox.Clear();
			jourComboBox.SelectedIndex = -1;
			moisComboBox.SelectedIndex = -1;
			anneComboBox.SelectedIndex = -1;
			etatComboBox.SelectedIndex = -1;
		}
		
		private string getIntitules(List<Produit> listProduit)
		{
			string intitules="";
			foreach(Produit prod in listProduit)
			{
				intitules += prod.Intitule+ ",  ";
			}
			
			return intitules;
		}
		
		private int getQuantites(List<Produit> listProduit)
		{
			int quantite = 0;
			foreach(Produit prod in listProduit)
			{
				quantite += prod.Quantite;
			}
			
			return quantite;
		}
		
		private bool quantiteCommandeDisponible(int qc, int qd)
		{
			
			if(qc > qd)
			{
				MessageBox.Show("La quantite restante est de : "+qd);
				return false;
			}
			
			return true;
		}
		
		/*
		private void restaurerQuantitesProduits()
		{
			try
			{
				connection.Open();
				
				foreach (Produit prod in listProduitsCommandes)
				{
					int currentQuantite = GetProduitQuantiteFromDatabase(prod.Id);
					int newQuantite = currentQuantite + prod.Quantite;
					
					string query = "UPDATE produits SET Quantite = @Quantite WHERE ID = @ProduitId";
					command.CommandText = query;
					
					command.Parameters.Clear(); // Clear any previous parameters
					command.Parameters.AddWithValue("@Quantite", newQuantite);
					command.Parameters.AddWithValue("@ProduitId", prod.Id);
					
					command.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Une erreur s'est produite lors de la restauration des quantités : " + ex.Message,
				                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				connection.Close();
			}
		}

		 */
		
		
		void rechercheTextBoxChanged(object sender, System.EventArgs e)
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
				dataGridView1.DataSource = dataView;

			}
		}
			
			void FormCommander1Load(object sender, System.EventArgs e)
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
			void DataGridView2CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
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




