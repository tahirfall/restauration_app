/*
 * Created by SharpDevelop.
 * User: fallt
 * Date: 21/08/2023
 * Time: 16:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Gestion_restaurant
{
	partial class FormCommande1
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.retourButton = new System.Windows.Forms.Button();
			this.rechercheTextBox = new System.Windows.Forms.TextBox();
			this.listPanel = new System.Windows.Forms.Panel();
			this.ajouterButton = new System.Windows.Forms.Button();
			this.saisiCommandePanel = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.descriptionTextBox = new System.Windows.Forms.TextBox();
			this.okButton = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.anneComboBox = new System.Windows.Forms.ComboBox();
			this.moisComboBox = new System.Windows.Forms.ComboBox();
			this.jourComboBox = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.prixTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.etatComboBox = new System.Windows.Forms.ComboBox();
			this.prixTotalTextBox = new System.Windows.Forms.TextBox();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.validerButton = new System.Windows.Forms.Button();
			this.annulerButton = new System.Windows.Forms.Button();
			this.quantiteCommandeTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.intituleTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.listPanel.SuspendLayout();
			this.saisiCommandePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(7, 87);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(621, 415);
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
			// rechercheTextBox
			// 
			this.rechercheTextBox.Location = new System.Drawing.Point(193, 49);
			this.rechercheTextBox.Multiline = true;
			this.rechercheTextBox.Name = "rechercheTextBox";
			this.rechercheTextBox.Size = new System.Drawing.Size(148, 32);
			this.rechercheTextBox.TabIndex = 25;
			this.rechercheTextBox.TextChanged += new System.EventHandler(this.rechercheTextBoxChanged);
			// 
			// listPanel
			// 
			this.listPanel.BackColor = System.Drawing.Color.DarkCyan;
			this.listPanel.Controls.Add(this.ajouterButton);
			this.listPanel.Controls.Add(this.rechercheTextBox);
			this.listPanel.Controls.Add(this.retourButton);
			this.listPanel.Controls.Add(this.dataGridView1);
			this.listPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.listPanel.Location = new System.Drawing.Point(0, 0);
			this.listPanel.Name = "listPanel";
			this.listPanel.Size = new System.Drawing.Size(634, 555);
			this.listPanel.TabIndex = 26;
			// 
			// ajouterButton
			// 
			this.ajouterButton.BackColor = System.Drawing.Color.Goldenrod;
			this.ajouterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ajouterButton.Location = new System.Drawing.Point(518, 49);
			this.ajouterButton.Name = "ajouterButton";
			this.ajouterButton.Size = new System.Drawing.Size(82, 34);
			this.ajouterButton.TabIndex = 27;
			this.ajouterButton.Text = "Ajouter";
			this.ajouterButton.UseVisualStyleBackColor = false;
			this.ajouterButton.Click += new System.EventHandler(this.AjouterButtonClick);
			// 
			// saisiCommandePanel
			// 
			this.saisiCommandePanel.BackColor = System.Drawing.Color.Turquoise;
			this.saisiCommandePanel.Controls.Add(this.label7);
			this.saisiCommandePanel.Controls.Add(this.descriptionTextBox);
			this.saisiCommandePanel.Controls.Add(this.okButton);
			this.saisiCommandePanel.Controls.Add(this.label11);
			this.saisiCommandePanel.Controls.Add(this.label10);
			this.saisiCommandePanel.Controls.Add(this.label9);
			this.saisiCommandePanel.Controls.Add(this.anneComboBox);
			this.saisiCommandePanel.Controls.Add(this.moisComboBox);
			this.saisiCommandePanel.Controls.Add(this.jourComboBox);
			this.saisiCommandePanel.Controls.Add(this.label8);
			this.saisiCommandePanel.Controls.Add(this.prixTextBox);
			this.saisiCommandePanel.Controls.Add(this.label6);
			this.saisiCommandePanel.Controls.Add(this.etatComboBox);
			this.saisiCommandePanel.Controls.Add(this.prixTotalTextBox);
			this.saisiCommandePanel.Controls.Add(this.dataGridView2);
			this.saisiCommandePanel.Controls.Add(this.label5);
			this.saisiCommandePanel.Controls.Add(this.label4);
			this.saisiCommandePanel.Controls.Add(this.validerButton);
			this.saisiCommandePanel.Controls.Add(this.annulerButton);
			this.saisiCommandePanel.Controls.Add(this.quantiteCommandeTextBox);
			this.saisiCommandePanel.Controls.Add(this.label3);
			this.saisiCommandePanel.Controls.Add(this.intituleTextBox);
			this.saisiCommandePanel.Controls.Add(this.label2);
			this.saisiCommandePanel.Controls.Add(this.label1);
			this.saisiCommandePanel.Location = new System.Drawing.Point(634, 0);
			this.saisiCommandePanel.Name = "saisiCommandePanel";
			this.saisiCommandePanel.Size = new System.Drawing.Size(600, 555);
			this.saisiCommandePanel.TabIndex = 27;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label7.Location = new System.Drawing.Point(350, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(98, 24);
			this.label7.TabIndex = 40;
			this.label7.Text = "Description";
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.Location = new System.Drawing.Point(341, 76);
			this.descriptionTextBox.Multiline = true;
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.Size = new System.Drawing.Size(130, 60);
			this.descriptionTextBox.TabIndex = 39;
			// 
			// okButton
			// 
			this.okButton.BackColor = System.Drawing.Color.Gold;
			this.okButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.okButton.ForeColor = System.Drawing.Color.Black;
			this.okButton.Location = new System.Drawing.Point(480, 72);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(60, 35);
			this.okButton.TabIndex = 38;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = false;
			this.okButton.Click += new System.EventHandler(this.OkButtonClick);
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label11.Location = new System.Drawing.Point(285, 460);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(40, 24);
			this.label11.TabIndex = 37;
			this.label11.Text = "aaaa";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label10.Location = new System.Drawing.Point(190, 460);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(32, 24);
			this.label10.TabIndex = 36;
			this.label10.Text = "mm";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label9.Location = new System.Drawing.Point(120, 460);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(18, 24);
			this.label9.TabIndex = 35;
			this.label9.Text = "jj";
			// 
			// anneComboBox
			// 
			this.anneComboBox.FormattingEnabled = true;
			this.anneComboBox.Items.AddRange(new object[] {
									"2023",
									"2022",
									"2021",
									"2020",
									"2019",
									"2018",
									"2017",
									"2016",
									"2015",
									"2014",
									"2013",
									"2012",
									"2011",
									"2010"});
			this.anneComboBox.Location = new System.Drawing.Point(330, 460);
			this.anneComboBox.Name = "anneComboBox";
			this.anneComboBox.Size = new System.Drawing.Size(70, 21);
			this.anneComboBox.TabIndex = 34;
			// 
			// moisComboBox
			// 
			this.moisComboBox.FormattingEnabled = true;
			this.moisComboBox.Items.AddRange(new object[] {
									"1",
									"2",
									"3",
									"4",
									"5",
									"6",
									"7",
									"8",
									"9",
									"10",
									"11",
									"12"});
			this.moisComboBox.Location = new System.Drawing.Point(230, 460);
			this.moisComboBox.Name = "moisComboBox";
			this.moisComboBox.Size = new System.Drawing.Size(40, 21);
			this.moisComboBox.TabIndex = 33;
			// 
			// jourComboBox
			// 
			this.jourComboBox.FormattingEnabled = true;
			this.jourComboBox.Items.AddRange(new object[] {
									"1",
									"2",
									"3",
									"4",
									"5",
									"6",
									"7",
									"8",
									"9",
									"10",
									"11",
									"12",
									"13",
									"14",
									"15",
									"16",
									"17",
									"18",
									"19",
									"20",
									"21",
									"22",
									"23",
									"24",
									"25",
									"26",
									"27",
									"28",
									"29",
									"30",
									"31"});
			this.jourComboBox.Location = new System.Drawing.Point(140, 460);
			this.jourComboBox.Name = "jourComboBox";
			this.jourComboBox.Size = new System.Drawing.Size(40, 21);
			this.jourComboBox.TabIndex = 32;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label8.Location = new System.Drawing.Point(240, 426);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(45, 24);
			this.label8.TabIndex = 31;
			this.label8.Text = "Date";
			this.label8.Click += new System.EventHandler(this.Label8Click);
			// 
			// prixTextBox
			// 
			this.prixTextBox.Location = new System.Drawing.Point(170, 76);
			this.prixTextBox.Multiline = true;
			this.prixTextBox.Name = "prixTextBox";
			this.prixTextBox.Size = new System.Drawing.Size(70, 30);
			this.prixTextBox.TabIndex = 29;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label6.Location = new System.Drawing.Point(166, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 24);
			this.label6.TabIndex = 28;
			this.label6.Text = "Prix";
			this.label6.Click += new System.EventHandler(this.Label6Click);
			// 
			// etatComboBox
			// 
			this.etatComboBox.FormattingEnabled = true;
			this.etatComboBox.Items.AddRange(new object[] {
									"PAYE",
									"NON PAYE"});
			this.etatComboBox.Location = new System.Drawing.Point(480, 460);
			this.etatComboBox.Name = "etatComboBox";
			this.etatComboBox.Size = new System.Drawing.Size(100, 21);
			this.etatComboBox.TabIndex = 27;
			// 
			// prixTotalTextBox
			// 
			this.prixTotalTextBox.Location = new System.Drawing.Point(13, 453);
			this.prixTotalTextBox.Multiline = true;
			this.prixTotalTextBox.Name = "prixTotalTextBox";
			this.prixTotalTextBox.Size = new System.Drawing.Size(90, 30);
			this.prixTotalTextBox.TabIndex = 26;
			// 
			// dataGridView2
			// 
			this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(5, 160);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(575, 250);
			this.dataGridView2.TabIndex = 24;
			this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2CellContentClick);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label5.Location = new System.Drawing.Point(440, 460);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 24);
			this.label5.TabIndex = 23;
			this.label5.Text = "Etat";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label4.Location = new System.Drawing.Point(6, 426);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 24);
			this.label4.TabIndex = 22;
			this.label4.Text = "Prix Total";
			// 
			// validerButton
			// 
			this.validerButton.BackColor = System.Drawing.Color.Gold;
			this.validerButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.validerButton.ForeColor = System.Drawing.Color.Black;
			this.validerButton.Location = new System.Drawing.Point(321, 517);
			this.validerButton.Name = "validerButton";
			this.validerButton.Size = new System.Drawing.Size(90, 35);
			this.validerButton.TabIndex = 21;
			this.validerButton.Text = "Valider";
			this.validerButton.UseVisualStyleBackColor = false;
			this.validerButton.Click += new System.EventHandler(this.ValiderButtonClick);
			// 
			// annulerButton
			// 
			this.annulerButton.BackColor = System.Drawing.Color.Gold;
			this.annulerButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.annulerButton.ForeColor = System.Drawing.Color.Black;
			this.annulerButton.Location = new System.Drawing.Point(206, 517);
			this.annulerButton.Name = "annulerButton";
			this.annulerButton.Size = new System.Drawing.Size(90, 35);
			this.annulerButton.TabIndex = 20;
			this.annulerButton.Text = "Annuler";
			this.annulerButton.UseVisualStyleBackColor = false;
			this.annulerButton.Click += new System.EventHandler(this.AnnulerButtonClick);
			// 
			// quantiteCommandeTextBox
			// 
			this.quantiteCommandeTextBox.Location = new System.Drawing.Point(260, 76);
			this.quantiteCommandeTextBox.Multiline = true;
			this.quantiteCommandeTextBox.Name = "quantiteCommandeTextBox";
			this.quantiteCommandeTextBox.Size = new System.Drawing.Size(70, 30);
			this.quantiteCommandeTextBox.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label3.Location = new System.Drawing.Point(260, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 24);
			this.label3.TabIndex = 3;
			this.label3.Text = "Quantite";
			// 
			// intituleTextBox
			// 
			this.intituleTextBox.Location = new System.Drawing.Point(12, 75);
			this.intituleTextBox.Multiline = true;
			this.intituleTextBox.Name = "intituleTextBox";
			this.intituleTextBox.Size = new System.Drawing.Size(140, 30);
			this.intituleTextBox.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(12, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Intitule";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(136, 9);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(211, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "SAISI COMMANDE";
			// 
			// FormCommande1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(1234, 554);
			this.Controls.Add(this.saisiCommandePanel);
			this.Controls.Add(this.listPanel);
			this.Name = "FormCommande1";
			this.Text = "FormCommander";
			this.Load += new System.EventHandler(this.FormCommander1Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.listPanel.ResumeLayout(false);
			this.listPanel.PerformLayout();
			this.saisiCommandePanel.ResumeLayout(false);
			this.saisiCommandePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox descriptionTextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.ComboBox moisComboBox;
		private System.Windows.Forms.ComboBox anneComboBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox jourComboBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox prixTextBox;
		private System.Windows.Forms.ComboBox etatComboBox;
		private System.Windows.Forms.TextBox prixTotalTextBox;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Button ajouterButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox intituleTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox quantiteCommandeTextBox;
		private System.Windows.Forms.Button annulerButton;
		private System.Windows.Forms.Button validerButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel saisiCommandePanel;
		private System.Windows.Forms.Panel listPanel;
		private System.Windows.Forms.TextBox rechercheTextBox;
		private System.Windows.Forms.Button retourButton;
		private System.Windows.Forms.DataGridView dataGridView1;
		//private System.Windows.Forms.Button validerButton;
		
	}
}





