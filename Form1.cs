using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnceiptadoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPers11_Click(object sender, EventArgs e)
        {
            AbrirFormEncriptadorTxt(new Encriptador_Texto());
        }
        private void AbrirFormEncriptadorTxt(object FrmEncriptadorTxt)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = FrmEncriptadorTxt as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }

        private void buttonPers12_Click(object sender, EventArgs e)
        {
            AbrirFormEncriptadorTxt(new Encriptador_Archivos());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
