/*
 * Created by SharpDevelop.
 * User: fallt
 * Date: 18/08/2023
 * Time: 21:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Gestion_restaurant
{
	partial class FormRestaurateur
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
			this.formulairePanel = new System.Windows.Forms.Panel();
			this.listProduitButton = new System.Windows.Forms.Button();
			this.recetteButton = new System.Windows.Forms.Button();
			this.paiementButton = new System.Windows.Forms.Button();
			this.listCommandeButton = new System.Windows.Forms.Button();
			this.prendreCommandeButton = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.retourButton = new System.Windows.Forms.Button();
			this.listPanel = new System.Windows.Forms.Panel();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.rechercheTextBox = new System.Windows.Forms.TextBox();
			this.formulairePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.listPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// formulairePanel
			// 
			this.formulairePanel.BackColor = System.Drawing.Color.DarkTurquoise;
			this.formulairePanel.Controls.Add(this.listProduitButton);
			this.formulairePanel.Controls.Add(this.recetteButton);
			this.formulairePanel.Controls.Add(this.paiementButton);
			this.formulairePanel.Controls.Add(this.listCommandeButton);
			this.formulairePanel.Controls.Add(this.prendreCommandeButton);
			this.formulairePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.formulairePanel.ForeColor = System.Drawing.Color.Transparent;
			this.formulairePanel.Location = new System.Drawing.Point(12, 0);
			this.formulairePanel.Name = "formulairePanel";
			this.formulairePanel.Size = new System.Drawing.Size(176, 555);
			this.formulairePanel.TabIndex = 0;
			// 
			// listProduitButton
			// 
			this.listProduitButton.BackColor = System.Drawing.Color.Gold;
			this.listProduitButton.ForeColor = System.Drawing.Color.Black;
			this.listProduitButton.Location = new System.Drawing.Point(25, 353);
			this.listProduitButton.Name = "listProduitButton";
			this.listProduitButton.Size = new System.Drawing.Size(145, 47);
			this.listProduitButton.TabIndex = 22;
			this.listProduitButton.Text = "Lister les produits disponibles";
			this.listProduitButton.UseVisualStyleBackColor = false;
			this.listProduitButton.Click += new System.EventHandler(this.ListeProduitButtonClick);
			// 
			// recetteButton
			// 
			this.recetteButton.BackColor = System.Drawing.Color.Gold;
			this.recetteButton.ForeColor = System.Drawing.Color.Black;
			this.recetteButton.Location = new System.Drawing.Point(25, 288);
			this.recetteButton.Name = "recetteButton";
			this.recetteButton.Size = new System.Drawing.Size(145, 47);
			this.recetteButton.TabIndex = 21;
			this.recetteButton.Text = "Suivre les recettes";
			this.recetteButton.UseVisualStyleBackColor = false;
			this.recetteButton.Click += new System.EventHandler(this.RecetteButtonClick);
			// 
			// paiementButton
			// 
			this.paiementButton.BackColor = System.Drawing.Color.Gold;
			this.paiementButton.ForeColor = System.Drawing.Color.Black;
			this.paiementButton.Location = new System.Drawing.Point(25, 222);
			this.paiementButton.Name = "paiementButton";
			this.paiementButton.Size = new System.Drawing.Size(145, 47);
			this.paiementButton.TabIndex = 20;
			this.paiementButton.Text = "Enregistrer les paiements";
			this.paiementButton.UseVisualStyleBackColor = false;
			this.paiementButton.Click += new System.EventHandler(this.PaiementCommandeButtonClick);
			// 
			// listCommandeButton
			// 
			this.listCommandeButton.BackColor = System.Drawing.Color.Gold;
			this.listCommandeButton.ForeColor = System.Drawing.Color.Black;
			this.listCommandeButton.Location = new System.Drawing.Point(25, 87);
			this.listCommandeButton.Name = "listCommandeButton";
			this.listCommandeButton.Size = new System.Drawing.Size(145, 47);
			this.listCommandeButton.TabIndex = 19;
			this.listCommandeButton.Text = "Lister les commandes";
			this.listCommandeButton.UseVisualStyleBackColor = false;
			this.listCommandeButton.Click += new System.EventHandler(this.ListerCommandesButtonClick);
			// 
			// prendreCommandeButton
			// 
			this.prendreCommandeButton.BackColor = System.Drawing.Color.Gold;
			this.prendreCommandeButton.ForeColor = System.Drawing.Color.Black;
			this.prendreCommandeButton.Location = new System.Drawing.Point(25, 156);
			this.prendreCommandeButton.Name = "prendreCommandeButton";
			this.prendreCommandeButton.Size = new System.Drawing.Size(145, 47);
			this.prendreCommandeButton.TabIndex = 18;
			this.prendreCommandeButton.Text = "Prendre des commandes";
			this.prendreCommandeButton.UseVisualStyleBackColor = false;
			this.prendreCommandeButton.Click += new System.EventHandler(this.PrendreCommandeButtonClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(7, 87);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(682, 415);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// retourButton
			// 
			this.retourButton.BackColor = System.Drawing.Color.Goldenrod;
			this.retourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.retourButton.Location = new System.Drawing.Point(7, 508);
			this.retourButton.Name = "retourButton";
			this.retourButton.Size = new System.Drawing.Size(82, 34);
			this.retourButton.TabIndex = 23;
			this.retourButton.Text = "Retour";
			this.retourButton.UseVisualStyleBackColor = false;
			this.retourButton.Click += new System.EventHandler(this.RetourButtonClick);
			// 
			// listPanel
			// 
			this.listPanel.BackColor = System.Drawing.Color.MediumSpringGreen;
			this.listPanel.Controls.Add(this.dataGridView2);
			this.listPanel.Controls.Add(this.rechercheTextBox);
			this.listPanel.Controls.Add(this.retourButton);
			this.listPanel.Controls.Add(this.dataGridView1);
			this.listPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.listPanel.Location = new System.Drawing.Point(188, 0);
			this.listPanel.Name = "listPanel";
			this.listPanel.Size = new System.Drawing.Size(1000, 555);
			this.listPanel.TabIndex = 26;
			// 
			// dataGridView2
			// 
			this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(7, 87);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(682, 404);
			this.dataGridView2.TabIndex = 26;
			// 
			// rechercheTextBox
			// 
			this.rechercheTextBox.Location = new System.Drawing.Point(193, 49);
			this.rechercheTextBox.Multiline = true;
			this.rechercheTextBox.Name = "rechercheTextBox";
			this.rechercheTextBox.Size = new System.Drawing.Size(148, 32);
			this.rechercheTextBox.TabIndex = 25;
			this.rechercheTextBox.TextChanged += new System.EventHandler(this.rechercheTextBoxChanged);
			// 
			// FormRestaurateur
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(884, 554);
			this.Controls.Add(this.listPanel);
			this.Controls.Add(this.formulairePanel);
			this.Name = "FormRestaurateur";
			this.Text = "FormRestaurateur";
			this.Load += new System.EventHandler(this.FormRestaurateurLoad);
			this.formulairePanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.listPanel.ResumeLayout(false);
			this.listPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Button paiementButton;
		private System.Windows.Forms.Button recetteButton;
		private System.Windows.Forms.Button listProduitButton;
		private System.Windows.Forms.Button listCommandeButton;
		private System.Windows.Forms.Panel listPanel;
		private System.Windows.Forms.TextBox rechercheTextBox;
		private System.Windows.Forms.Button retourButton;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button prendreCommandeButton;
		//private System.Windows.Forms.Button validerButton;
		private System.Windows.Forms.Panel formulairePanel;
		
		
		
	}
}





