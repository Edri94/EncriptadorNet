
namespace EnceiptadoNet
{
    partial class Encriptador_Archivos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTipos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblArchivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tvConfiguraciones = new System.Windows.Forms.TreeView();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonPers11 = new Encriptador.Botones.ButtonPers1();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEtiquetas = new System.Windows.Forms.ComboBox();
            this.lblGuardar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.lblKeys = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encriptador Archivos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo Archivo:";
            // 
            // cboTipos
            // 
            this.cboTipos.FormattingEnabled = true;
            this.cboTipos.Location = new System.Drawing.Point(129, 110);
            this.cboTipos.Name = "cboTipos";
            this.cboTipos.Size = new System.Drawing.Size(94, 28);
            this.cboTipos.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ubicacion:";
            // 
            // lblArchivo
            // 
            this.lblArchivo.Location = new System.Drawing.Point(374, 110);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(398, 26);
            this.lblArchivo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Configuraciones:";
            // 
            // tvConfiguraciones
            // 
            this.tvConfiguraciones.Location = new System.Drawing.Point(29, 206);
            this.tvConfiguraciones.Name = "tvConfiguraciones";
            this.tvConfiguraciones.Size = new System.Drawing.Size(743, 293);
            this.tvConfiguraciones.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Click en el elemnto que deseas editar";
            // 
            // buttonPers11
            // 
            this.buttonPers11.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonPers11.BackGroundColor = System.Drawing.Color.RoyalBlue;
            this.buttonPers11.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonPers11.BorderRadius = 40;
            this.buttonPers11.BorderSize = 0;
            this.buttonPers11.FlatAppearance.BorderSize = 0;
            this.buttonPers11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPers11.ForeColor = System.Drawing.Color.White;
            this.buttonPers11.Location = new System.Drawing.Point(520, 576);
            this.buttonPers11.Name = "buttonPers11";
            this.buttonPers11.Size = new System.Drawing.Size(252, 58);
            this.buttonPers11.TabIndex = 6;
            this.buttonPers11.Text = "Encriptar Archivo";
            this.buttonPers11.TextColor = System.Drawing.Color.White;
            this.buttonPers11.UseVisualStyleBackColor = false;
            this.buttonPers11.Click += new System.EventHandler(this.buttonPers11_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 595);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Etiqueta Archivo:";
            // 
            // cmbEtiquetas
            // 
            this.cmbEtiquetas.FormattingEnabled = true;
            this.cmbEtiquetas.Location = new System.Drawing.Point(160, 592);
            this.cmbEtiquetas.Name = "cmbEtiquetas";
            this.cmbEtiquetas.Size = new System.Drawing.Size(84, 28);
            this.cmbEtiquetas.TabIndex = 3;
            // 
            // lblGuardar
            // 
            this.lblGuardar.Location = new System.Drawing.Point(129, 648);
            this.lblGuardar.Name = "lblGuardar";
            this.lblGuardar.Size = new System.Drawing.Size(643, 26);
            this.lblGuardar.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 651);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Guardar en:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 519);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Keys:";
            // 
            // lblKeys
            // 
            this.lblKeys.AutoSize = true;
            this.lblKeys.Location = new System.Drawing.Point(88, 519);
            this.lblKeys.Name = "lblKeys";
            this.lblKeys.Size = new System.Drawing.Size(0, 20);
            this.lblKeys.TabIndex = 9;
            // 
            // Encriptador_Archivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(815, 708);
            this.ControlBox = false;
            this.Controls.Add(this.lblKeys);
            this.Controls.Add(this.lblGuardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonPers11);
            this.Controls.Add(this.tvConfiguraciones);
            this.Controls.Add(this.lblArchivo);
            this.Controls.Add(this.cmbEtiquetas);
            this.Controls.Add(this.cboTipos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Encriptador_Archivos";
            this.Text = "Encriptador Archivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTipos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lblArchivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TreeView tvConfiguraciones;
        private System.Windows.Forms.Label label5;
        private Encriptador.Botones.ButtonPers1 buttonPers11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEtiquetas;
        private System.Windows.Forms.TextBox lblGuardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblKeys;
    }
}