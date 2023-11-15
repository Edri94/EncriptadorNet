
namespace EnceiptadoNet
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnSalir = new Encriptador.Botones.ButtonPers1();
            this.buttonPers12 = new Encriptador.Botones.ButtonPers1();
            this.buttonPers11 = new Encriptador.Botones.ButtonPers1();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.buttonPers12);
            this.groupBox1.Controls.Add(this.buttonPers11);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 646);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(519, 12);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(830, 646);
            this.panelContenedor.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalir.BackGroundColor = System.Drawing.Color.RoyalBlue;
            this.btnSalir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSalir.BorderRadius = 40;
            this.btnSalir.BorderSize = 0;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(32, 567);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(430, 53);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // buttonPers12
            // 
            this.buttonPers12.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonPers12.BackGroundColor = System.Drawing.Color.RoyalBlue;
            this.buttonPers12.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonPers12.BorderRadius = 40;
            this.buttonPers12.BorderSize = 0;
            this.buttonPers12.FlatAppearance.BorderSize = 0;
            this.buttonPers12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPers12.ForeColor = System.Drawing.Color.White;
            this.buttonPers12.Location = new System.Drawing.Point(32, 351);
            this.buttonPers12.Name = "buttonPers12";
            this.buttonPers12.Size = new System.Drawing.Size(430, 53);
            this.buttonPers12.TabIndex = 0;
            this.buttonPers12.Text = "Encriptador Archivos";
            this.buttonPers12.TextColor = System.Drawing.Color.White;
            this.buttonPers12.UseVisualStyleBackColor = false;
            this.buttonPers12.Click += new System.EventHandler(this.buttonPers12_Click);
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
            this.buttonPers11.Location = new System.Drawing.Point(32, 292);
            this.buttonPers11.Name = "buttonPers11";
            this.buttonPers11.Size = new System.Drawing.Size(430, 53);
            this.buttonPers11.TabIndex = 0;
            this.buttonPers11.Text = "Encriptador Texto";
            this.buttonPers11.TextColor = System.Drawing.Color.White;
            this.buttonPers11.UseVisualStyleBackColor = false;
            this.buttonPers11.Click += new System.EventHandler(this.buttonPers11_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EnceiptadoNet.Properties.Resources.encriptacion;
            this.pictureBox1.Location = new System.Drawing.Point(59, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1361, 670);
            this.ControlBox = false;
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Encriptador";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Encriptador.Botones.ButtonPers1 btnSalir;
        private Encriptador.Botones.ButtonPers1 buttonPers12;
        private Encriptador.Botones.ButtonPers1 buttonPers11;
        private System.Windows.Forms.Panel panelContenedor;
    }
}

