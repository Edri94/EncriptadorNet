using Encriptador.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnceiptadoNet
{
    public partial class Encriptador_Archivos : Form
    {
        Encriptacion encriptacion;
        String texto_encriptado;
        String seleccionado;
        List<string> campos_contrasena;
        System.Configuration.Configuration config;

        public Encriptador_Archivos()
        {
            InitializeComponent();
            encriptacion = new Encriptacion();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ConstuirTreeView()
        {
            campos_contrasena = new List<string>();
            int keys = 0;

            tvConfiguraciones.CheckBoxes = true;

            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
            configFileMap.ExeConfigFilename = openFileDialog1.FileName;

            int i = 0;
            System.Configuration.Configuration config_archivo = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);

            foreach (KeyValueConfigurationElement item in config_archivo.AppSettings.Settings)
            {
                string clave = item.Key.TrimStart().TrimEnd();
                string valor = item.Value.TrimStart().TrimEnd();


                //Quito estas lineas por que realmente no se cuando una cadena esta encriptada, no siempre terminan en "="
                //int tamano_valor = valor.Length;
                //char ultimo_caracter = valor[tamano_valor - 1];


                //if (ultimo_caracter == '=')
                //{
                //    valor = encriptacion.Decrypt(valor) + " (desencriptado)";
                //    contador_encriptados++;
                //}



                if (clave.Contains('.'))
                {
                    string grupo = clave.Split('.')[0];
                    string clave_grupo = clave.Split('.')[1];

                    int index = BuscarNodo(grupo, tvConfiguraciones.Nodes);

                    if (index != -1)
                    {
                        tvConfiguraciones.Nodes[index].Nodes.Add($"{clave_grupo}:{valor}");
                        BuscarCampoPassword(clave);
                        i--;

                    }
                    else
                    {
                        tvConfiguraciones.Nodes.Add($"{grupo}");
                        tvConfiguraciones.Nodes[i].Nodes.Add($"{clave_grupo}:{valor}");
                        BuscarCampoPassword(clave);

                    }
                }
                else
                {
                    tvConfiguraciones.Nodes.Add($"{clave} : {valor}");
                    BuscarCampoPassword(clave);
                }

                i++;
                keys++;
            }

            lblKeys.Text = keys.ToString("D5");
            config.Save();

            DialogResult respuesta;

            if (config.AppSettings.Settings["campos_password"].Value == "True")
            {
                if (campos_contrasena.Count > 0)
                {
                    respuesta = MessageBox.Show($"Hay {campos_contrasena.Count} campo(s) de contraseña, ¿Desea acrualziarlos ahora?", "Campo contraseña", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        foreach (string campo_contrasena in campos_contrasena)
                        {
                            ActualizarNodo(campo_contrasena, tvConfiguraciones.Nodes);
                        }
                    }
                }
            }
        }

        private void ActualizarNodo(string campo_contrasena, TreeNodeCollection nodos, string grupo_param = "")
        {
            bool campo_compuesto = (campo_contrasena.Contains("."));

            string grupo = grupo_param;
            string clave = string.Empty;

            if (campo_compuesto)
            {
                grupo = campo_contrasena.Split('.')[0];
                clave = campo_contrasena.Split('.')[1];
            }
            else
            {
                clave = campo_contrasena;
            }

            foreach (TreeNode node in nodos)
            {
                if (grupo != string.Empty && clave != string.Empty && node.Nodes.Count > 0)
                {
                    if (node.Text.Contains(grupo))
                    {
                        ActualizarNodo(clave, node.Nodes, grupo);
                    }
                }
                else
                {
                    if (node.Text.Split(':')[0].Contains(clave))
                    {
                        //aqui abrir fprmulario de edicion de nodo...
                        string nombre_nodo = node.Text;

                        Frm_EdicionNodo frm_EdicionNodo = new Frm_EdicionNodo();
                        frm_EdicionNodo.EstableceParametros(node, grupo);

                        frm_EdicionNodo.ShowDialog();

                        node.Text = frm_EdicionNodo.valor_nuevo;
                    }
                }
            }
        }

        private void BuscarCampoPassword(string clave)
        {
            if (clave.ToLower().Contains("password") || clave.ToLower().Contains("contrasena") || clave.ToLower().Contains("contraseña") || clave.ToLower().Contains("clave") || clave.ToLower().Contains("pass"))
            {
                campos_contrasena.Add(clave);
            }
        }

        private int BuscarNodo(string grupo, TreeNodeCollection nodes)
        {
            foreach (TreeNode nodo in nodes)
            {
                if (grupo == nodo.Text)
                {
                    return nodo.Index;
                }

            }

            return -1;
        }

        private string GetExtension(string fileName)
        {
            try
            {
                string[] partes = fileName.Split('.');
                int divisiones = partes.Length;

                return partes[divisiones - 1];
            }
            catch (Exception ex)
            {
                MensajeError(ex);
                return null;
            }
        }

        private void MensajeError(Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

        private void ConstruirArchivoConfig(TreeNodeCollection nodes, Configuration config, string clave = "")
        {
            foreach (TreeNode node in nodes)
            {
                string key;
                string value;

                if (node.Text.Contains("C:"))
                {
                    bool bandera_ruta = true;
                }
                if (node.Nodes.Count > 0)
                {
                    key = node.Text;
                    ConstruirArchivoConfig(node.Nodes, config, key);
                }
                else
                {
                    if (clave == "")
                    {
                        key = node.Text.Split(':')[0].TrimStart().TrimEnd();
                    }
                    else
                    {
                        key = clave + "." + node.Text.Split(':')[0].TrimStart().TrimEnd();
                    }
                    value = node.Text.Split(':')[1].TrimStart().TrimEnd();
                    value = GetValueNode(node.Text);

                    config.AppSettings.Settings[key].Value = value;

                }
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

        private void CargarConfiguracionForm()
        {
            string nombre_appconfig = "Encriptador.dll.config";
            string appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string[] appPath_arr = appPath.Split('\\');
            string configFile = System.IO.Path.Combine(appPath, nombre_appconfig);
            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
            configFileMap.ExeConfigFilename = configFile;
            config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
        }

        private void Encriptador_Archivos_Load(object sender, EventArgs e)
        {
            CargarConfiguracionForm();

            foreach (string nombre_configuracion in ConfigurationManager.AppSettings)
            {
                if (nombre_configuracion == "tipos")
                {
                    string tipos = ConfigurationManager.AppSettings[nombre_configuracion];

                    foreach (string tipo in tipos.Split(','))
                    {
                        cboTipos.Items.Add(tipo);
                    }

                }
                else if (nombre_configuracion == "etiquetas")
                {
                    string etiquetas = ConfigurationManager.AppSettings[nombre_configuracion];

                    foreach (string etiqueta in etiquetas.Split(','))
                    {
                        cmbEtiquetas.Items.Add(etiqueta);
                    }
                    cmbEtiquetas.SelectedIndex = 0;
                }
            }
        }

        private void cboTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccionado = cboTipos.SelectedItem.ToString();

            switch (seleccionado)
            {
                case "config":
                    openFileDialog1.Filter = "config files (*.config)|*.config";
                    saveFileDialog1.Filter = "config files (*.config)|*.config";
                    break;
                case "txt":
                    openFileDialog1.Filter = "txt files (*.txt)|*.txt";
                    saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
                    break;
            }
        }

        private void tvConfiguraciones_AfterCheck(object sender, TreeViewEventArgs e)
        {
            string nombre_nodo = e.Node.Text;
            bool checkeado = e.Node.Checked;

            ActualizarNodo(e.Node);

        }

        private void ActualizarNodo(TreeNode node)
        {
            RecorrerTreeView(tvConfiguraciones.Nodes, node);
        }

        private void RecorrerTreeView(TreeNodeCollection nodes, TreeNode nodo_checked)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Nodes.Count > 0)
                {
                    RecorrerTreeView(node.Nodes, nodo_checked);
                }
                else
                {
                    string key = node.Text.Split(':')[0].TrimStart().TrimEnd();
                    string value = node.Text.Split(':')[1].TrimStart().TrimEnd();
                    if (node.Text == nodo_checked.Text && nodo_checked.Checked == true)
                    {
                        node.Text = key + ":" + encriptacion.Encrypt(value);
                    }
                    else if (node.Text == nodo_checked.Text && nodo_checked.Checked == false)
                    {
                        node.Text = key + ":" + encriptacion.Decrypt(value);
                    }
                }

            }
        }

        private void lblArchivo_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //aqui va el codigo para abrir y leer el archivo              
                lblArchivo.Text = openFileDialog1.FileName;
                Log.Escribe("Analizando archivo " + lblArchivo.Text);
                string extension = GetExtension(openFileDialog1.FileName);

                if (seleccionado == "config" && extension == "config")
                {
                    ConstuirTreeView();
                }
                else
                {

                }
                lblArchivo.Select(lblArchivo.Text.Length, 0);
            }
        }

        private void tvConfiguraciones_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Nodes.Count == 0)
            {
                string nombre_nodo = e.Node.Text;
                bool checkeado = e.Node.Checked;

                Frm_EdicionNodo frm_EdicionNodo = new Frm_EdicionNodo();
                frm_EdicionNodo.EstableceParametros(e.Node);

                frm_EdicionNodo.ShowDialog();

                e.Node.Text = frm_EdicionNodo.valor_nuevo;
            }
        }

        private void lblArchivo_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(lblArchivo, "Doble click para escoger el archivo");
        }

        private void buttonPers11_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Guarda el archivo con diferente nombre al original, despues puedes reemplazarlo por el original. Al archivo ya se le agrego la etequita que elegiste anteriormente.", "Instrucciones", MessageBoxButtons.OK, MessageBoxIcon.Information);

                switch (seleccionado)
                {
                    case "config":
                        saveFileDialog1.FileName = lblArchivo.Text.Replace(".exe.config", "_" + cmbEtiquetas.Text + ".exe.config");
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {

                            lblGuardar.Text = saveFileDialog1.FileName;

                            if (lblArchivo.Text == lblGuardar.Text)
                            {
                                MessageBox.Show("No se puede sobrescribir el archivo. Guardelo en otra ubicacion o coloque otro nombre.", "Advertencia de sobrescritura!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                File.Copy(lblArchivo.Text, lblGuardar.Text, false);

                                if (File.Exists(lblGuardar.Text))
                                {
                                    ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
                                    configFileMap.ExeConfigFilename = lblGuardar.Text;
                                    System.Configuration.Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);

                                    ConstruirArchivoConfig(tvConfiguraciones.Nodes, config);
                                    config.Save();
                                }
                            }
                        }
                        break;

                    case "txt":
                        StreamReader sr = new StreamReader(lblArchivo.Text);
                        //Read the first line of text
                        String line = sr.ReadLine();
                        String texto = "";


                        while (line != null)
                        {
                            line = sr.ReadLine();
                            texto += line + Environment.NewLine;
                        }

                        sr.Close();

                        texto_encriptado = encriptacion.Encrypt(texto);

                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            lblGuardar.Text = saveFileDialog1.FileName;

                            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                            sw.Write(texto_encriptado);
                            sw.Close();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblArchivo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
