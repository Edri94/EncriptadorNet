using Encriptador.Helpers;
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
    public partial class Frm_EdicionNodo : Form
    {
        public TreeNode nodo;
        Encriptacion encriptacion;
        public string valor_nuevo;
        public string grupo;

        public Frm_EdicionNodo()
        {
            InitializeComponent();
        }

        private void Frm_EdicionNodo_Load(object sender, EventArgs e)
        {
            try
            {
                encriptacion = new Encriptacion();

                if (this.nodo != null)
                {
                    string key = GetKeyNode(nodo.Text);
                    string value = GetValueNode(nodo.Text);

                    if (grupo == "")
                    {
                        lblNodo.Text = key;
                    }
                    else
                    {
                        lblNodo.Text = grupo + "." + key;
                    }
                    txtValue.Text = value;
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log.Escribe(ex);
            }


        }

        public void EstableceParametros(TreeNode nodo, string grupo = "")
        {
            this.nodo = nodo;
            this.grupo = grupo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txtValue.Text = GetValueNode(nodo.Text);
                rbEncrypt.Checked = false;
                rbDecrypt.Checked = false;
            }
            catch (Exception ex)
            {
                Log.Escribe(ex);
            }

        }

        /// <summary>
        /// Obtiene el valor del nodo sin el key
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private string GetValueNode(string text_node)
        {
            try
            {
                int i = 0;
                string cadena = string.Empty;
                foreach (string texto in text_node.Split(':'))
                {
                    if (i > 0)
                    {
                        cadena += ":" + texto;
                    }
                    i++;
                }
                return cadena.Remove(0, 1);
            }
            catch (Exception ex)
            {
                Log.Escribe(ex);
                return null;
            }
        }

        /// <summary>
        /// Obtiene el key del nodo sin el valor
        /// </summary>
        /// <param name="text_node"></param>
        /// <returns></returns>
        private string GetKeyNode(string text_node)
        {
            try
            {
                return text_node.Split(':')[0];
            }
            catch (Exception ex)
            {
                Log.Escribe(ex);
                return null;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEncrypt.Checked == true)
            {
                rbDecrypt.Checked = false;

                txtValue.Text = encriptacion.Encrypt(txtValue.Text);

            }

        }

        private void rbDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDecrypt.Checked == true)
            {
                rbEncrypt.Checked = false;
                txtValue.Text = encriptacion.Decrypt(txtValue.Text);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtValue.Text != "")
                {
                    string key = GetKeyNode(nodo.Text);
                    valor_nuevo = key + ":" + txtValue.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No puede ir vacio el campo VALUE");
                }
            }
            catch (Exception ex)
            {
                Log.Escribe(ex);
            }

        }

        private void Frm_EdicionNodo_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                rbEncrypt.Checked = false;
                rbDecrypt.Checked = false;

                btnEnviar.PerformClick();
            }
            catch (Exception ex)
            {
                Log.Escribe(ex);
            }
        }
    }
}
