/*
 * Created by SharpDevelop.
 * User: fallt
 * Date: 18/08/2023
 * Time: 21:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Gestion_restaurant
{
	partial class MainForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.LoginTextBox = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.seconnecterButton = new System.Windows.Forms.Button();
			this.quitterButton = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(182, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "CONNEXION";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(105, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Login";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(105, 150);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Password";
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(203, 140);
			this.passwordTextBox.Multiline = true;
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '*';
			this.passwordTextBox.Size = new System.Drawing.Size(204, 35);
			this.passwordTextBox.TabIndex = 3;
			this.passwordTextBox.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// LoginTextBox
			// 
			this.LoginTextBox.Location = new System.Drawing.Point(203, 72);
			this.LoginTextBox.Multiline = true;
			this.LoginTextBox.Name = "LoginTextBox";
			this.LoginTextBox.Size = new System.Drawing.Size(204, 35);
			this.LoginTextBox.TabIndex = 4;
			this.LoginTextBox.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Turquoise;
			this.panel1.Controls.Add(this.seconnecterButton);
			this.panel1.Controls.Add(this.quitterButton);
			this.panel1.Controls.Add(this.LoginTextBox);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.passwordTextBox);
			this.panel1.Controls.Add(this.label2);
			this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(486, 308);
			this.panel1.TabIndex = 5;
			// 
			// seconnecterButton
			// 
			this.seconnecterButton.BackColor = System.Drawing.Color.Tomato;
			this.seconnecterButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.seconnecterButton.Location = new System.Drawing.Point(281, 219);
			this.seconnecterButton.Name = "seconnecterButton";
			this.seconnecterButton.Size = new System.Drawing.Size(126, 38);
			this.seconnecterButton.TabIndex = 6;
			this.seconnecterButton.Text = "Se Connecter";
			this.seconnecterButton.UseVisualStyleBackColor = false;
			this.seconnecterButton.Click += new System.EventHandler(this.SeconnecterButtonClick);
			// 
			// quitterButton
			// 
			this.quitterButton.BackColor = System.Drawing.Color.Tomato;
			this.quitterButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quitterButton.Location = new System.Drawing.Point(141, 219);
			this.quitterButton.Name = "quitterButton";
			this.quitterButton.Size = new System.Drawing.Size(126, 38);
			this.quitterButton.TabIndex = 5;
			this.quitterButton.Text = "Quitter";
			this.quitterButton.UseVisualStyleBackColor = false;
			this.quitterButton.Click += new System.EventHandler(this.QuitterButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tomato;
			this.ClientSize = new System.Drawing.Size(510, 332);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.Text = "Gestion_restaurant";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button quitterButton;
		private System.Windows.Forms.Button seconnecterButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox LoginTextBox;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}








