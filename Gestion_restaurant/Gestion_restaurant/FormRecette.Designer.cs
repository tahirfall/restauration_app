/*
 * Created by SharpDevelop.
 * User: fallt
 * Date: 23/08/2023
 * Time: 21:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Gestion_restaurant
{
	partial class FormRecette
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.saisiCommandePanel = new System.Windows.Forms.Panel();
			this.mensuelleButton = new System.Windows.Forms.Button();
			this.journaliereButton = new System.Windows.Forms.Button();
			this.hebdomadaireButton = new System.Windows.Forms.Button();
			this.retourButton = new System.Windows.Forms.Button();
			this.montantTotalTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.totalProduitsVenduTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.saisiCommandePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// saisiCommandePanel
			// 
			this.saisiCommandePanel.BackColor = System.Drawing.Color.Turquoise;
			this.saisiCommandePanel.Controls.Add(this.mensuelleButton);
			this.saisiCommandePanel.Controls.Add(this.journaliereButton);
			this.saisiCommandePanel.Controls.Add(this.hebdomadaireButton);
			this.saisiCommandePanel.Controls.Add(this.retourButton);
			this.saisiCommandePanel.Controls.Add(this.montantTotalTextBox);
			this.saisiCommandePanel.Controls.Add(this.label3);
			this.saisiCommandePanel.Controls.Add(this.totalProduitsVenduTextBox);
			this.saisiCommandePanel.Controls.Add(this.label2);
			this.saisiCommandePanel.Controls.Add(this.label1);
			this.saisiCommandePanel.Location = new System.Drawing.Point(0, 0);
			this.saisiCommandePanel.Name = "saisiCommandePanel";
			this.saisiCommandePanel.Size = new System.Drawing.Size(685, 555);
			this.saisiCommandePanel.TabIndex = 27;
			// 
			// mensuelleButton
			// 
			this.mensuelleButton.BackColor = System.Drawing.Color.Gold;
			this.mensuelleButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mensuelleButton.ForeColor = System.Drawing.Color.Black;
			this.mensuelleButton.Location = new System.Drawing.Point(420, 100);
			this.mensuelleButton.Name = "mensuelleButton";
			this.mensuelleButton.Size = new System.Drawing.Size(120, 50);
			this.mensuelleButton.TabIndex = 29;
			this.mensuelleButton.Text = "Mensuelle";
			this.mensuelleButton.UseVisualStyleBackColor = false;
			this.mensuelleButton.Click += new System.EventHandler(this.MensuelleButtonClick);
			// 
			// journaliereButton
			// 
			this.journaliereButton.BackColor = System.Drawing.Color.Gold;
			this.journaliereButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.journaliereButton.ForeColor = System.Drawing.Color.Black;
			this.journaliereButton.Location = new System.Drawing.Point(120, 100);
			this.journaliereButton.Name = "journaliereButton";
			this.journaliereButton.Size = new System.Drawing.Size(120, 50);
			this.journaliereButton.TabIndex = 28;
			this.journaliereButton.Text = "Journalière";
			this.journaliereButton.UseVisualStyleBackColor = false;
			this.journaliereButton.Click += new System.EventHandler(this.JournaliereButtonClick);
			// 
			// hebdomadaireButton
			// 
			this.hebdomadaireButton.BackColor = System.Drawing.Color.Gold;
			this.hebdomadaireButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hebdomadaireButton.ForeColor = System.Drawing.Color.Black;
			this.hebdomadaireButton.Location = new System.Drawing.Point(270, 100);
			this.hebdomadaireButton.Name = "hebdomadaireButton";
			this.hebdomadaireButton.Size = new System.Drawing.Size(120, 50);
			this.hebdomadaireButton.TabIndex = 27;
			this.hebdomadaireButton.Text = "Hebdomadaire";
			this.hebdomadaireButton.UseVisualStyleBackColor = false;
			this.hebdomadaireButton.Click += new System.EventHandler(this.HebdomadaireButtonClick);
			// 
			// retourButton
			// 
			this.retourButton.BackColor = System.Drawing.Color.Gold;
			this.retourButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.retourButton.ForeColor = System.Drawing.Color.Black;
			this.retourButton.Location = new System.Drawing.Point(270, 400);
			this.retourButton.Name = "retourButton";
			this.retourButton.Size = new System.Drawing.Size(120, 50);
			this.retourButton.TabIndex = 20;
			this.retourButton.Text = "Retour";
			this.retourButton.UseVisualStyleBackColor = false;
			this.retourButton.Click += new System.EventHandler(this.RetourButtonClick);
			// 
			// montantTotalTextBox
			// 
			this.montantTotalTextBox.Location = new System.Drawing.Point(390, 250);
			this.montantTotalTextBox.Multiline = true;
			this.montantTotalTextBox.Name = "montantTotalTextBox";
			this.montantTotalTextBox.Size = new System.Drawing.Size(100, 30);
			this.montantTotalTextBox.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label3.Location = new System.Drawing.Point(390, 220);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 24);
			this.label3.TabIndex = 3;
			this.label3.Text = "Montant Total";
			// 
			// totalProduitsVenduTextBox
			// 
			this.totalProduitsVenduTextBox.Location = new System.Drawing.Point(170, 250);
			this.totalProduitsVenduTextBox.Multiline = true;
			this.totalProduitsVenduTextBox.Name = "totalProduitsVenduTextBox";
			this.totalProduitsVenduTextBox.Size = new System.Drawing.Size(100, 30);
			this.totalProduitsVenduTextBox.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(170, 220);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(170, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Total Produit vendus";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(250, 9);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(130, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "RECETTES";
			// 
			// FormRecette
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(684, 554);
			this.Controls.Add(this.saisiCommandePanel);
			this.Name = "FormRecette";
			this.Text = "FormRecette";
			this.Load += new System.EventHandler(this.FormRecetteLoad);
			this.saisiCommandePanel.ResumeLayout(false);
			this.saisiCommandePanel.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button hebdomadaireButton;
		private System.Windows.Forms.Button journaliereButton;
		private System.Windows.Forms.Button mensuelleButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox totalProduitsVenduTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox montantTotalTextBox;
		private System.Windows.Forms.Button retourButton;
		private System.Windows.Forms.Panel saisiCommandePanel;
		//private System.Windows.Forms.Button validerButton;
	}
}
