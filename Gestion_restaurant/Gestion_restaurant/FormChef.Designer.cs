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
	partial class FormChef
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
			this.quantiteTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.validerButton = new System.Windows.Forms.Button();
			this.annulerButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.descriptionLabel = new System.Windows.Forms.Label();
			this.descriptionTextBox = new System.Windows.Forms.TextBox();
			this.prixLabel = new System.Windows.Forms.Label();
			this.intituleLabel = new System.Windows.Forms.Label();
			this.prixTextBox = new System.Windows.Forms.TextBox();
			this.intituleTextBox = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ajouterButton = new System.Windows.Forms.Button();
			this.supprimerButton = new System.Windows.Forms.Button();
			this.modifierButton = new System.Windows.Forms.Button();
			this.retourButton = new System.Windows.Forms.Button();
			this.rechercheTextBox = new System.Windows.Forms.TextBox();
			this.listPanel = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.formulairePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.listPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// formulairePanel
			// 
			this.formulairePanel.BackColor = System.Drawing.Color.DarkTurquoise;
			this.formulairePanel.Controls.Add(this.quantiteTextBox);
			this.formulairePanel.Controls.Add(this.label3);
			this.formulairePanel.Controls.Add(this.validerButton);
			this.formulairePanel.Controls.Add(this.annulerButton);
			this.formulairePanel.Controls.Add(this.label2);
			this.formulairePanel.Controls.Add(this.descriptionLabel);
			this.formulairePanel.Controls.Add(this.descriptionTextBox);
			this.formulairePanel.Controls.Add(this.prixLabel);
			this.formulairePanel.Controls.Add(this.intituleLabel);
			this.formulairePanel.Controls.Add(this.prixTextBox);
			this.formulairePanel.Controls.Add(this.intituleTextBox);
			this.formulairePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.formulairePanel.ForeColor = System.Drawing.Color.Transparent;
			this.formulairePanel.Location = new System.Drawing.Point(12, 0);
			this.formulairePanel.Name = "formulairePanel";
			this.formulairePanel.Size = new System.Drawing.Size(319, 555);
			this.formulairePanel.TabIndex = 0;
			// 
			// quantiteTextBox
			// 
			this.quantiteTextBox.Location = new System.Drawing.Point(104, 269);
			this.quantiteTextBox.Multiline = true;
			this.quantiteTextBox.Name = "quantiteTextBox";
			this.quantiteTextBox.Size = new System.Drawing.Size(202, 25);
			this.quantiteTextBox.TabIndex = 21;
			this.quantiteTextBox.TextChanged += new System.EventHandler(this.QuantiteTextBoxTextChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(3, 278);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 16);
			this.label3.TabIndex = 20;
			this.label3.Text = "QUANTITE";
			// 
			// validerButton
			// 
			this.validerButton.BackColor = System.Drawing.Color.Gold;
			this.validerButton.ForeColor = System.Drawing.Color.Black;
			this.validerButton.Location = new System.Drawing.Point(172, 460);
			this.validerButton.Name = "validerButton";
			this.validerButton.Size = new System.Drawing.Size(83, 31);
			this.validerButton.TabIndex = 19;
			this.validerButton.Text = "Valider";
			this.validerButton.UseVisualStyleBackColor = false;
			this.validerButton.Click += new System.EventHandler(this.ValiderButtonClick);
			// 
			// annulerButton
			// 
			this.annulerButton.BackColor = System.Drawing.Color.Gold;
			this.annulerButton.ForeColor = System.Drawing.Color.Black;
			this.annulerButton.Location = new System.Drawing.Point(69, 460);
			this.annulerButton.Name = "annulerButton";
			this.annulerButton.Size = new System.Drawing.Size(83, 31);
			this.annulerButton.TabIndex = 18;
			this.annulerButton.Text = "Annuler";
			this.annulerButton.UseVisualStyleBackColor = false;
			this.annulerButton.Click += new System.EventHandler(this.AnnulerButtonClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(56, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(199, 24);
			this.label2.TabIndex = 17;
			this.label2.Text = "Création produit";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// descriptionLabel
			// 
			this.descriptionLabel.Location = new System.Drawing.Point(0, 381);
			this.descriptionLabel.Name = "descriptionLabel";
			this.descriptionLabel.Size = new System.Drawing.Size(93, 23);
			this.descriptionLabel.TabIndex = 10;
			this.descriptionLabel.Text = "DESCRIPTION";
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.Location = new System.Drawing.Point(104, 358);
			this.descriptionTextBox.Multiline = true;
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.Size = new System.Drawing.Size(202, 60);
			this.descriptionTextBox.TabIndex = 9;
			this.descriptionTextBox.TextChanged += new System.EventHandler(this.DescriptionTextBoxTextChanged);
			// 
			// prixLabel
			// 
			this.prixLabel.Location = new System.Drawing.Point(3, 192);
			this.prixLabel.Name = "prixLabel";
			this.prixLabel.Size = new System.Drawing.Size(77, 22);
			this.prixLabel.TabIndex = 8;
			this.prixLabel.Text = "PRIX";
			this.prixLabel.Click += new System.EventHandler(this.PrixLabelClick);
			// 
			// intituleLabel
			// 
			this.intituleLabel.Location = new System.Drawing.Point(3, 107);
			this.intituleLabel.Name = "intituleLabel";
			this.intituleLabel.Size = new System.Drawing.Size(77, 16);
			this.intituleLabel.TabIndex = 6;
			this.intituleLabel.Text = "INTITULE";
			// 
			// prixTextBox
			// 
			this.prixTextBox.Location = new System.Drawing.Point(104, 189);
			this.prixTextBox.Multiline = true;
			this.prixTextBox.Name = "prixTextBox";
			this.prixTextBox.Size = new System.Drawing.Size(202, 25);
			this.prixTextBox.TabIndex = 2;
			this.prixTextBox.TextChanged += new System.EventHandler(this.PrixTextBoxTextChanged);
			// 
			// intituleTextBox
			// 
			this.intituleTextBox.Location = new System.Drawing.Point(104, 98);
			this.intituleTextBox.Multiline = true;
			this.intituleTextBox.Name = "intituleTextBox";
			this.intituleTextBox.Size = new System.Drawing.Size(202, 25);
			this.intituleTextBox.TabIndex = 1;
			this.intituleTextBox.TextChanged += new System.EventHandler(this.IntituleTextBoxTextChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(7, 87);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(739, 402);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// ajouterButton
			// 
			this.ajouterButton.BackColor = System.Drawing.Color.Goldenrod;
			this.ajouterButton.Location = new System.Drawing.Point(7, 47);
			this.ajouterButton.Name = "ajouterButton";
			this.ajouterButton.Size = new System.Drawing.Size(82, 34);
			this.ajouterButton.TabIndex = 20;
			this.ajouterButton.Text = "Ajouter";
			this.ajouterButton.UseVisualStyleBackColor = false;
			this.ajouterButton.Click += new System.EventHandler(this.AjouterButtonClick);
			// 
			// supprimerButton
			// 
			this.supprimerButton.BackColor = System.Drawing.Color.Goldenrod;
			this.supprimerButton.Location = new System.Drawing.Point(215, 47);
			this.supprimerButton.Name = "supprimerButton";
			this.supprimerButton.Size = new System.Drawing.Size(82, 34);
			this.supprimerButton.TabIndex = 21;
			this.supprimerButton.Text = "Supprimer";
			this.supprimerButton.UseVisualStyleBackColor = false;
			this.supprimerButton.Click += new System.EventHandler(this.SupprimerButtonClick);
			// 
			// modifierButton
			// 
			this.modifierButton.BackColor = System.Drawing.Color.Goldenrod;
			this.modifierButton.Location = new System.Drawing.Point(109, 47);
			this.modifierButton.Name = "modifierButton";
			this.modifierButton.Size = new System.Drawing.Size(82, 34);
			this.modifierButton.TabIndex = 22;
			this.modifierButton.Text = "Modifier";
			this.modifierButton.UseVisualStyleBackColor = false;
			this.modifierButton.Click += new System.EventHandler(this.ModifierButtonClick);
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
			// rechercheTextBox
			// 
			this.rechercheTextBox.Location = new System.Drawing.Point(598, 47);
			this.rechercheTextBox.Multiline = true;
			this.rechercheTextBox.Name = "rechercheTextBox";
			this.rechercheTextBox.Size = new System.Drawing.Size(148, 32);
			this.rechercheTextBox.TabIndex = 25;
			this.rechercheTextBox.TextChanged += new System.EventHandler(this.rechercheTextBoxChanged);
			// 
			// listPanel
			// 
			this.listPanel.BackColor = System.Drawing.Color.MediumSpringGreen;
			this.listPanel.Controls.Add(this.label1);
			this.listPanel.Controls.Add(this.rechercheTextBox);
			this.listPanel.Controls.Add(this.supprimerButton);
			this.listPanel.Controls.Add(this.modifierButton);
			this.listPanel.Controls.Add(this.retourButton);
			this.listPanel.Controls.Add(this.ajouterButton);
			this.listPanel.Controls.Add(this.dataGridView1);
			this.listPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.listPanel.Location = new System.Drawing.Point(330, 0);
			this.listPanel.Name = "listPanel";
			this.listPanel.Size = new System.Drawing.Size(760, 555);
			this.listPanel.TabIndex = 26;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(391, 26);
			this.label1.TabIndex = 26;
			this.label1.Text = "LISTES DES PRODUITS";
			// 
			// FormChef
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(1102, 554);
			this.Controls.Add(this.listPanel);
			this.Controls.Add(this.formulairePanel);
			this.Name = "FormChef";
			this.Text = "FormChef";
			this.Load += new System.EventHandler(this.FormChefLoad);
			this.formulairePanel.ResumeLayout(false);
			this.formulairePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.listPanel.ResumeLayout(false);
			this.listPanel.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox quantiteTextBox;
		private System.Windows.Forms.Button validerButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel listPanel;
		private System.Windows.Forms.TextBox rechercheTextBox;
		private System.Windows.Forms.Button retourButton;
		private System.Windows.Forms.Button modifierButton;
		private System.Windows.Forms.Button supprimerButton;
		private System.Windows.Forms.Button ajouterButton;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button annulerButton;
		//private System.Windows.Forms.Button validerButton;
		private System.Windows.Forms.Label descriptionLabel;
		private System.Windows.Forms.Label intituleLabel;
		private System.Windows.Forms.Label prixLabel;
		private System.Windows.Forms.TextBox descriptionTextBox;
		private System.Windows.Forms.TextBox prixTextBox;
		private System.Windows.Forms.TextBox intituleTextBox;
		private System.Windows.Forms.Panel formulairePanel;
		
		
		
	}
}





