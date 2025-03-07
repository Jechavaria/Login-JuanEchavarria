using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginV1
{
    public partial class frmBienvenido : Form
    {
        public frmBienvenido()
        {
            InitializeComponent();


        }

        public void frmBienvenido_Load(object sender, EventArgs e)
        {

        }

        public void btnSalir_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}

