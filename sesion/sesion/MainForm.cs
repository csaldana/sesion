/*
 * Created by SharpDevelop.
 * User: jonathan
 * Date: 22/10/2013
 * Time: 08:27 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace sesion
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Usuarios user = new Usuarios();
			user.revisar(usuarioForma.Text, contrasenaForma.Text);
		}
		
		void MaskedTextBox1MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
			
		}
		
		void ContraseñaClick(object sender, EventArgs e)
		{
			
		}
	}
}
