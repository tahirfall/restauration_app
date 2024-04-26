/*
 * Created by SharpDevelop.
 * User: fallt
 * Date: 18/08/2023
 * Time: 21:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestion_restaurant
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
	    private MySqlConnection connection;

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			string connectionString = "Server=localhost;Database=restaurant;Uid=root;Pwd=";
            connection = new MySqlConnection(connectionString);
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		 void SeconnecterButtonClick(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = passwordTextBox.Text;
            string role;

            if (AuthenticateUser(login, password, out role))
            {
                OpenSpecificForm(role);
                ClearChamps();
            }
            else
            {
                MessageBox.Show("Login or password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string login, string password, out string role)
        {
            role = "";
            bool isAuthenticated = false;

            try
            {
                connection.Open();

                string query = "SELECT role FROM utilisateurs WHERE login = @login AND password = @password";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        role = result.ToString();
                        isAuthenticated = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return isAuthenticated;
        }

        private void OpenSpecificForm(string role)
        {
            switch (role)
            {
                case "ADMINISTRATEUR":
                    FormAdministrateur adminForm = new FormAdministrateur();
                    adminForm.Show();
                    
                    this.Hide();
                    break;

                case "CHEF":
                    FormChef chefForm = new FormChef();
                    chefForm.Show();
                    
                    this.Hide();
                    break;

                case "RESTAURATEUR":
                    FormRestaurateur restaurateurForm = new FormRestaurateur();
                    restaurateurForm.Show();
                    
                    
                    this.Hide();
                    break;

                default:
                    MessageBox.Show("Unknown role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
		
        void QuitterButtonClick(object sender, EventArgs e)
        {     	
			this.Hide();
			Application.Exit();
        }
		
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		private void ClearChamps()
		{
			LoginTextBox.Clear();
			passwordTextBox.Clear();
		}
	}
}





