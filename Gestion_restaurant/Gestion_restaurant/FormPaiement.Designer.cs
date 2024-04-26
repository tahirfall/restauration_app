/*
 * Created by SharpDevelop.
 * User: fallt
 * Date: 22/08/2023
 * Time: 12:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Gestion_restaurant
{
	partial class FormPaiement
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
			this.payerButton = new System.Windows.Forms.Button();
			this.saisiCommandePanel = new System.Windows.Forms.Panel();
			this.prixTotalTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.validerButton = new System.Windows.Forms.Button();
			this.annulerButton = new System.Windows.Forms.Button();
			this.quantiteTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.intitulesTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.etatComboBox = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.listPanel.SuspendLayout();
			this.saisiCommandePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(7, 87);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(651, 415);
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
			this.listPanel.Controls.Add(this.payerButton);
			this.listPanel.Controls.Add(this.rechercheTextBox);
			this.listPanel.Controls.Add(this.retourButton);
			this.listPanel.Controls.Add(this.dataGridView1);
			this.listPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.listPanel.Location = new System.Drawing.Point(0, 0);
			this.listPanel.Name = "listPanel";
			this.listPanel.Size = new System.Drawing.Size(664, 555);
			this.listPanel.TabIndex = 26;
			// 
			// payerButton
			// 
			this.payerButton.BackColor = System.Drawing.Color.Goldenrod;
			this.payerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.payerButton.Location = new System.Drawing.Point(518, 49);
			this.payerButton.Name = "payerButton";
			this.payerButton.Size = new System.Drawing.Size(82, 34);
			this.payerButton.TabIndex = 27;
			this.payerButton.Text = "Payer";
			this.payerButton.UseVisualStyleBackColor = false;
			this.payerButton.Click += new System.EventHandler(this.PayerButtonClick);
			// 
			// saisiCommandePanel
			// 
			this.saisiCommandePanel.BackColor = System.Drawing.Color.Turquoise;
			this.saisiCommandePanel.Controls.Add(this.etatComboBox);
			this.saisiCommandePanel.Controls.Add(this.prixTotalTextBox);
			this.saisiCommandePanel.Controls.Add(this.label5);
			this.saisiCommandePanel.Controls.Add(this.label4);
			this.saisiCommandePanel.Controls.Add(this.validerButton);
			this.saisiCommandePanel.Controls.Add(this.annulerButton);
			this.saisiCommandePanel.Controls.Add(this.quantiteTextBox);
			this.saisiCommandePanel.Controls.Add(this.label3);
			this.saisiCommandePanel.Controls.Add(this.intitulesTextBox);
			this.saisiCommandePanel.Controls.Add(this.label2);
			this.saisiCommandePanel.Controls.Add(this.label1);
			this.saisiCommandePanel.Location = new System.Drawing.Point(664, 0);
			this.saisiCommandePanel.Name = "saisiCommandePanel";
			this.saisiCommandePanel.Size = new System.Drawing.Size(450, 555);
			this.saisiCommandePanel.TabIndex = 27;
			// 
			// prixTotalTextBox
			// 
			this.prixTotalTextBox.Location = new System.Drawing.Point(350, 157);
			this.prixTotalTextBox.Multiline = true;
			this.prixTotalTextBox.Name = "prixTotalTextBox";
			this.prixTotalTextBox.Size = new System.Drawing.Size(90, 30);
			this.prixTotalTextBox.TabIndex = 26;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label5.Location = new System.Drawing.Point(230, 210);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 24);
			this.label5.TabIndex = 23;
			this.label5.Text = "Etat";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label4.Location = new System.Drawing.Point(350, 130);
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
			this.validerButton.Location = new System.Drawing.Point(242, 330);
			this.validerButton.Name = "validerButton";
			this.validerButton.Size = new System.Drawing.Size(120, 50);
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
			this.annulerButton.Location = new System.Drawing.Point(116, 330);
			this.annulerButton.Name = "annulerButton";
			this.annulerButton.Size = new System.Drawing.Size(120, 50);
			this.annulerButton.TabIndex = 20;
			this.annulerButton.Text = "Annuler";
			this.annulerButton.UseVisualStyleBackColor = false;
			this.annulerButton.Click += new System.EventHandler(this.AnnulerButtonClick);
			// 
			// quantiteTextBox
			// 
			this.quantiteTextBox.Location = new System.Drawing.Point(265, 157);
			this.quantiteTextBox.Multiline = true;
			this.quantiteTextBox.Name = "quantiteTextBox";
			this.quantiteTextBox.Size = new System.Drawing.Size(70, 30);
			this.quantiteTextBox.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label3.Location = new System.Drawing.Point(259, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 24);
			this.label3.TabIndex = 3;
			this.label3.Text = "Quantite";
			// 
			// intitulesTextBox
			// 
			this.intitulesTextBox.Location = new System.Drawing.Point(6, 157);
			this.intitulesTextBox.Multiline = true;
			this.intitulesTextBox.Name = "intitulesTextBox";
			this.intitulesTextBox.Size = new System.Drawing.Size(234, 30);
			this.intitulesTextBox.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(51, 130);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(140, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Intitules Produits";
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
			// etatComboBox
			// 
			this.etatComboBox.FormattingEnabled = true;
			this.etatComboBox.Items.AddRange(new object[] {
									"PAYE",
									"NON PAYE"});
			this.etatComboBox.Location = new System.Drawing.Point(200, 240);
			this.etatComboBox.Name = "etatComboBox";
			this.etatComboBox.Size = new System.Drawing.Size(110, 21);
			this.etatComboBox.TabIndex = 27;
			// 
			// FormPaiement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(1114, 554);
			this.Controls.Add(this.saisiCommandePanel);
			this.Controls.Add(this.listPanel);
			this.Name = "FormPaiement";
			this.Text = "FormPaiement";
			this.Load += new System.EventHandler(this.FormCommanderLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.listPanel.ResumeLayout(false);
			this.listPanel.PerformLayout();
			this.saisiCommandePanel.ResumeLayout(false);
			this.saisiCommandePanel.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ComboBox etatComboBox;
		private System.Windows.Forms.TextBox prixTotalTextBox;
		private System.Windows.Forms.Button payerButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox intitulesTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox quantiteTextBox;
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
