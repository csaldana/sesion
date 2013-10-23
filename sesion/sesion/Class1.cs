/*
 * Created by SharpDevelop.
 * User: jonathan
 * Date: 22/10/2013
 * Time: 08:32 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sesion
{
    class Usuarios
    {
        public string login = "jonathan";
        public string contrasena = "123";
        

        public void revisar(string loginForma, string contrasenaForma) 
        {
            DialogResult result;
            if(loginForma == this.login)
            {
                if (contrasenaForma == this.contrasena) 
                {
                    result = MessageBox.Show("BIENVENIDO");
                }
                else
                {
                    result = MessageBox.Show("Contraseña incorrecta");
                }
            }
            else
            {
                result = MessageBox.Show("Usuario incorrecto");
            }
        }

    }
}

