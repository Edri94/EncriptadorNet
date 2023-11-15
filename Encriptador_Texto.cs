using Encriptador.Helpers;
using MNICript;
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
    public partial class Encriptador_Texto : Form
    {
        public Encriptador_Texto()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (rbMD5.Checked == false && rbMNICript.Checked == false)
            {
                MessageBox.Show("Debe seleccionar el algoritmo de encriptacion.", "Error", MessageBoxButtons.OK);
                
            }
            else if (rbEncriptar.Checked == false && rbDesencriptar.Checked == false)
            {
                MessageBox.Show("Debe seleccionar si va Encriptar o Desencriptar.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                if (rbMD5.Checked)
                {
                    Encriptacion encriptacion = new Encriptacion();

                    if (txtCadena.Text != String.Empty)
                    {
                        if (rbEncriptar.Checked == true)
                        {
                            txtResultado.Text = encriptacion.Encrypt(txtCadena.Text);
                        }
                        if (rbDesencriptar.Checked == true)
                        {
                            txtResultado.Text = encriptacion.Decrypt(txtCadena.Text);
                        }
                    }
                }
                else if(rbMNICript.Checked)
                {
                    clsEncripta crpt = new clsEncripta();
                    if (txtCadena.Text != String.Empty)
                    {
                        if (rbEncriptar.Checked == true)
                        {
                            txtResultado.Text = crpt.VerificaClaves(1,txtCadena.Text);
                        }
                        if (rbDesencriptar.Checked == true)
                        {
                            txtResultado.Text = crpt.VerificaClaves(2, txtCadena.Text);
                        }
                    }
                }

                string accion = (rbEncriptar.Checked) ? "Encriptado" : "Desencriptado";
                string algoritmo = (rbMD5.Checked) ? "MD5" : "MNICript";

                lstvwResultados.Items.Add($"[Original: {txtCadena.Text}] [{accion}: {txtResultado.Text}] [Algoritmo: {algoritmo}]");

                //Add items in the listview
                string[] arr = new string[3];
                ListViewItem item;

                //Add first item
                arr[0] = txtCadena.Text;
                arr[1] = txtResultado.Text;

                item = new ListViewItem(arr);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = String.Empty;
            txtCadena.Text = String.Empty;
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtResultado.Text, true);
        }
    }
}
