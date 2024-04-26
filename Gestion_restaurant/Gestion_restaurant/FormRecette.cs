/*
 * Created by SharpDevelop.
 * User: fallt
 * Date: 23/08/2023
 * Time: 21:40
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
	/// Description of FormRecette.
	/// </summary>
	public partial class FormRecette : Form
	{
		private MySqlConnection connection;
		private MySqlCommand command;
		
		public FormRecette()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			InitializeDatabaseConnection();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void InitializeDatabaseConnection()
		{
			string connectionString = "Server=localhost;Database=restaurant;Uid=root;Pwd=";
			connection = new MySqlConnection(connectionString);
			
			command = connection.CreateCommand(); // Initialiser la commande MySqlCommand avec la connexion
		}
		
		
		private void afficherJournaliere()
		{
			try
			{
				connection.Open();
				string query = "SELECT SUM(PrixTotal) AS RecetteJournaliere, SUM(Quantite) AS QuantiteTotale FROM commandes WHERE DateCommande = DATE_FORMAT(CURDATE(), '%d/%c/%Y')";

				command.CommandText = query;

				using (MySqlDataReader reader = command.ExecuteReader())
				{
					if (reader.Read())
					{
						if (!reader.IsDBNull(reader.GetOrdinal("RecetteJournaliere")))
						{
							double recetteJournaliere = Convert.ToDouble(reader["RecetteJournaliere"]);
							montantTotalTextBox.Text = recetteJournaliere.ToString(); // Afficher en tant que devise
							//MessageBox.Show("Recette journalière (raw): " + reader["RecetteJournaliere"]);
							//MessageBox.Show("Recette journalière (parsed): " + recetteJournaliere);
						}

						if (!reader.IsDBNull(reader.GetOrdinal("QuantiteTotale")))
						{
							double quantiteTotale = Convert.ToDouble(reader["QuantiteTotale"]);
							totalProduitsVenduTextBox.Text = quantiteTotale.ToString();
							//MessageBox.Show("Quantité totale (raw): " + reader["QuantiteTotale"]);
							//MessageBox.Show("Quantité totale (parsed): " + quantiteTotale);
						}
					}
					else
					{
						MessageBox.Show("Aucune donnée récupérée.");
					}
				}

				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Une erreur est survenue lors de l'affichage de la recette journalière : " + ex.Message);
				connection.Close();
			}
		}
		
		
		
		
		private void afficherHebdomadaire()
		{
			try
			{
				connection.Open();
				
				DateTime now = DateTime.Now;
				DateTime startOfWeek = now.AddDays(-(int)now.DayOfWeek).Date;
				DateTime endOfWeek = startOfWeek.AddDays(6);
				
				string query = "SELECT SUM(PrixTotal) AS RecetteHebdomadaire, SUM(Quantite) AS QuantiteTotale FROM commandes WHERE DateCommande BETWEEN '" + startOfWeek.ToString("dd/MM/yyyy") + "' AND '" + endOfWeek.ToString("dd/MM/yyyy") + "'";

				
				command.CommandText = query;

				using (MySqlDataReader reader = command.ExecuteReader())
				{
					if (reader.Read())
					{
						if (!reader.IsDBNull(reader.GetOrdinal("RecetteHebdomadaire")))
						{
							double recetteHebdomadaire = Convert.ToDouble(reader["RecetteHebdomadaire"]);
							montantTotalTextBox.Text = recetteHebdomadaire.ToString();
						}

						if (!reader.IsDBNull(reader.GetOrdinal("QuantiteTotale")))
						{
							double quantiteTotale = Convert.ToDouble(reader["QuantiteTotale"]);
							totalProduitsVenduTextBox.Text = quantiteTotale.ToString();
						}
					}
				}

				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Une erreur est survenue lors de l'affichage de la recette hebdomadaire : " + ex.Message);
				connection.Close();
			}
		}
		
		
		private void afficherMensuelle()
		{
			try
			{
				connection.Open();
				
				DateTime now = DateTime.Now;
				DateTime firstDayOfMonth = new DateTime(now.Year, now.Month, 1);
				DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

				string query = "SELECT SUM(PrixTotal) AS RecetteMensuelle, SUM(Quantite) AS QuantiteTotale FROM commandes WHERE DateCommande BETWEEN '" + firstDayOfMonth.ToString("dd/MM/yyyy") + "' AND '" + lastDayOfMonth.ToString("dd/MM/yyyy") + "'";


				command.CommandText = query;

				using (MySqlDataReader reader = command.ExecuteReader())
				{
					if (reader.Read())
					{
						if (!reader.IsDBNull(reader.GetOrdinal("RecetteMensuelle")))
						{
							double recetteMensuelle = Convert.ToDouble(reader["RecetteMensuelle"]);
							montantTotalTextBox.Text = recetteMensuelle.ToString();
						}

						if (!reader.IsDBNull(reader.GetOrdinal("QuantiteTotale")))
						{
							double quantiteTotale = Convert.ToDouble(reader["QuantiteTotale"]);
							totalProduitsVenduTextBox.Text = quantiteTotale.ToString();
						}
					}
				}

				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Une erreur est survenue lors de l'affichage de la recette mensuelle : " + ex.Message);
				connection.Close();
			}
		}


		
		
		/*
		private void afficherProduitPlusVendu()
		{
			try
			{
				connection.Open();
				
				string query = "SELECT IntitulesProduits, SUM(Quantite) AS QuantiteTotale FROM commandes GROUP BY IntitulesProduits ORDER BY QuantiteTotale DESC LIMIT 1";
				command.CommandText = query;

				using (MySqlDataReader reader = command.ExecuteReader())
				{
					if (reader.Read())
					{
						string produitPlusVendu = reader["IntitulesProduits"].ToString();
						double quantiteVendue = Convert.ToDouble(reader["QuantiteTotale"]);
						
						produitPlusVendulTextBox.Text = produitPlusVendu;
						totalProduitsVenduTextBox.Text = quantiteVendue.ToString();
					}
				}

				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Une erreur est survenue lors de l'affichage du produit le plus vendu : " + ex.Message);
				connection.Close();
			}
		}

		 */
		
		void JournaliereButtonClick(object sender, System.EventArgs e)
		{
			ClearChamps();
			afficherHebdomadaire();
		}
		
		
		void HebdomadaireButtonClick(object sender, System.EventArgs e)
		{
			ClearChamps();
			afficherHebdomadaire();
		}
		
		void MensuelleButtonClick(object sender, System.EventArgs e)
		{
			ClearChamps();
			afficherMensuelle();
		}
		
		void RetourButtonClick(object sender, System.EventArgs e)
		{
			FormRestaurateur formRest = new FormRestaurateur();
			formRest.Show();
			
			this.Hide();
		}
		
		private void ClearChamps()
		{
			montantTotalTextBox.Clear();
			totalProduitsVenduTextBox.Clear();
		}
		
		void FormRecetteLoad(object sender, System.EventArgs e)
		{
			
		}
	}
}




