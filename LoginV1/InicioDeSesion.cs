using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginV1
{
    public partial class FrmInicioDeSesion : Form
    {
        int Contador = 0;


        public FrmInicioDeSesion()
        {
            InitializeComponent();
        }

        public void btnContinuar_Click(object sender, EventArgs e)
        {
            if (Contador < 3)
            {
                lblIntentos.Text = "Intentos restantes: " + (2 - Contador).ToString();

                if ((txtUsuario.Text == "JuanEchavarria" && txtContrasena.Text == "1234")||(txtUsuario.Text == "Jgaleano" && txtContrasena.Text == "1234"))
                {

                    MessageBox.Show("¡Login exitoso!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmBienvenido frmBienvenido = new frmBienvenido();
                    frmBienvenido.lblBienvenida.Text = "Bienvenido " + txtUsuario.Text;
                    frmBienvenido.Show();
                    this.Hide();



                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Contador++;
                }
            }
            else
            {

                MessageBox.Show("Demasiados intentos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Estás seguro de que quieres salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtContrasena.Focus();
                e.Handled = true;
            }

        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnContinuar.PerformClick();
                e.Handled = true;

            }
        }
    }
}
