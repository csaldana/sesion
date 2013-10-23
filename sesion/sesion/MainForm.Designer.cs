/*
 * Created by SharpDevelop.
 * User: jonathan
 * Date: 22/10/2013
 * Time: 08:27 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace sesion
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
			this.usuarioForma = new System.Windows.Forms.TextBox();
			this.contrasenaForma = new System.Windows.Forms.MaskedTextBox();
			this.UsuarioEtiqueta = new System.Windows.Forms.Label();
			this.contrasenaEtiqueta = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// usuarioForma
			// 
			this.usuarioForma.Location = new System.Drawing.Point(32, 40);
			this.usuarioForma.Name = "usuarioForma";
			this.usuarioForma.Size = new System.Drawing.Size(100, 20);
			this.usuarioForma.TabIndex = 0;
			// 
			// contrasenaForma
			// 
			this.contrasenaForma.Location = new System.Drawing.Point(32, 96);
			this.contrasenaForma.Name = "contrasenaForma";
			this.contrasenaForma.PasswordChar = '*';
			this.contrasenaForma.Size = new System.Drawing.Size(100, 20);
			this.contrasenaForma.TabIndex = 1;
			this.contrasenaForma.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextBox1MaskInputRejected);
			// 
			// UsuarioEtiqueta
			// 
			this.UsuarioEtiqueta.Location = new System.Drawing.Point(41, 13);
			this.UsuarioEtiqueta.Name = "UsuarioEtiqueta";
			this.UsuarioEtiqueta.Size = new System.Drawing.Size(100, 23);
			this.UsuarioEtiqueta.TabIndex = 2;
			this.UsuarioEtiqueta.Text = "login";
			this.UsuarioEtiqueta.Click += new System.EventHandler(this.Label1Click);
			// 
			// contrasenaEtiqueta
			// 
			this.contrasenaEtiqueta.Location = new System.Drawing.Point(41, 67);
			this.contrasenaEtiqueta.Name = "contrasenaEtiqueta";
			this.contrasenaEtiqueta.Size = new System.Drawing.Size(100, 23);
			this.contrasenaEtiqueta.TabIndex = 3;
			this.contrasenaEtiqueta.Text = "contrasena";
			this.contrasenaEtiqueta.Click += new System.EventHandler(this.ContraseñaClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(32, 122);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "inicio sesion";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.contrasenaEtiqueta);
			this.Controls.Add(this.UsuarioEtiqueta);
			this.Controls.Add(this.contrasenaForma);
			this.Controls.Add(this.usuarioForma);
			this.Name = "MainForm";
			this.Text = "sesion";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label contrasenaEtiqueta;
		private System.Windows.Forms.Label UsuarioEtiqueta;
		private System.Windows.Forms.MaskedTextBox contrasenaForma;
		private System.Windows.Forms.TextBox usuarioForma;
	}
}
