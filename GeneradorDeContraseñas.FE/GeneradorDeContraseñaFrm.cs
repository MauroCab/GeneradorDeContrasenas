using System;
using GeneradorDeContraseñas.BE;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorDeContraseñas.FE
{
    public partial class Formulario1 : Form
    {
        
        public Formulario1()
        {
            InitializeComponent();
            Configuracion config = new Configuracion();
            chkMayusculas.Checked = config.LeerValorMayus();

            chkNumeros.Checked = config.LeerValorNumeros();

            chkSimbolos.Checked = config.LeerValorSimbolos();

            txtbxLongitud.Text = config.LeerValorLongitud();
        }

        public void btGenerar_Click(object sender, EventArgs e)
        {
            Generador gen = new Generador();

            if (txtbxLongitud.Text == "")
            { 
                lblAst.Text = "*";
                lblAdv.Text = "Campo obligatorio";

            }
            else
            {
                int longitud = Convert.ToInt32(txtbxLongitud.Text);
                bool incluirMayusculas = chkMayusculas.Checked;
                bool incluirNumeros = chkNumeros.Checked;
                bool incluirSimbolos = chkSimbolos.Checked;

                lblAst.Text = " ";
                lblAdv.Text = " ";

                string contraseña = gen.GenerarContraseña(longitud, incluirMayusculas, incluirNumeros, incluirSimbolos);

                txtbxResultado.Text = contraseña;
                txtbxResultado.ForeColor = Color.Black;
            }


            Configuracion config = new Configuracion();
            config.GuardarValorMayus(chkMayusculas.Checked);
            config.GuardarValorNumeros(chkNumeros.Checked);
            config.GuardarValorSimbolos(chkSimbolos.Checked);
            config.GuardarValorLongitud(txtbxLongitud.Text);
        }
      
        private void chkMayusculas_CheckedChanged(object sender, EventArgs e)
        {

            

        }

        private void chkNumeros_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkSimbolos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtbxLongitud_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
