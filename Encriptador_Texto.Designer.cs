
namespace EnceiptadoNet
{
    partial class Encriptador_Texto
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMNICript = new System.Windows.Forms.RadioButton();
            this.rbMD5 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new Encriptador.Botones.ButtonPers1();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.btnEnviar = new Encriptador.Botones.ButtonPers1();
            this.rbDesencriptar = new System.Windows.Forms.RadioButton();
            this.rbEncriptar = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCopiar = new Encriptador.Botones.ButtonPers1();
            this.lstvwResultados = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encriptador Texto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMNICript);
            this.groupBox1.Controls.Add(this.rbMD5);
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algoritmo";
            // 
            // rbMNICript
            // 
            this.rbMNICript.AutoSize = true;
            this.rbMNICript.Location = new System.Drawing.Point(635, 40);
            this.rbMNICript.Name = "rbMNICript";
            this.rbMNICript.Size = new System.Drawing.Size(96, 24);
            this.rbMNICript.TabIndex = 0;
            this.rbMNICript.TabStop = true;
            this.rbMNICript.Text = "MNICript";
            this.rbMNICript.UseVisualStyleBackColor = true;
            // 
            // rbMD5
            // 
            this.rbMD5.AutoSize = true;
            this.rbMD5.Location = new System.Drawing.Point(479, 40);
            this.rbMD5.Name = "rbMD5";
            this.rbMD5.Size = new System.Drawing.Size(68, 24);
            this.rbMD5.TabIndex = 0;
            this.rbMD5.TabStop = true;
            this.rbMD5.Text = "MD5";
            this.rbMD5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBorrar);
            this.groupBox2.Controls.Add(this.txtCadena);
            this.groupBox2.Controls.Add(this.btnEnviar);
            this.groupBox2.Controls.Add(this.rbDesencriptar);
            this.groupBox2.Controls.Add(this.rbEncriptar);
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(791, 130);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Texto";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBorrar.BackGroundColor = System.Drawing.Color.RoyalBlue;
            this.btnBorrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBorrar.BorderRadius = 40;
            this.btnBorrar.BorderSize = 0;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(635, 25);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(128, 34);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextColor = System.Drawing.Color.White;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(15, 33);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(476, 26);
            this.txtCadena.TabIndex = 4;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEnviar.BackGroundColor = System.Drawing.Color.RoyalBlue;
            this.btnEnviar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEnviar.BorderRadius = 40;
            this.btnEnviar.BorderSize = 0;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(501, 25);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(128, 34);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextColor = System.Drawing.Color.White;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // rbDesencriptar
            // 
            this.rbDesencriptar.AutoSize = true;
            this.rbDesencriptar.Location = new System.Drawing.Point(173, 88);
            this.rbDesencriptar.Name = "rbDesencriptar";
            this.rbDesencriptar.Size = new System.Drawing.Size(125, 24);
            this.rbDesencriptar.TabIndex = 0;
            this.rbDesencriptar.TabStop = true;
            this.rbDesencriptar.Text = "Desencriptar";
            this.rbDesencriptar.UseVisualStyleBackColor = true;
            this.rbDesencriptar.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbEncriptar
            // 
            this.rbEncriptar.AutoSize = true;
            this.rbEncriptar.Location = new System.Drawing.Point(18, 88);
            this.rbEncriptar.Name = "rbEncriptar";
            this.rbEncriptar.Size = new System.Drawing.Size(98, 24);
            this.rbEncriptar.TabIndex = 0;
            this.rbEncriptar.TabStop = true;
            this.rbEncriptar.Text = "Encriptar";
            this.rbEncriptar.UseVisualStyleBackColor = true;
            this.rbEncriptar.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(115, 372);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(460, 26);
            this.txtResultado.TabIndex = 4;
            // 
            // btnCopiar
            // 
            this.btnCopiar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCopiar.BackGroundColor = System.Drawing.Color.RoyalBlue;
            this.btnCopiar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCopiar.BorderRadius = 40;
            this.btnCopiar.BorderSize = 0;
            this.btnCopiar.FlatAppearance.BorderSize = 0;
            this.btnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiar.ForeColor = System.Drawing.Color.White;
            this.btnCopiar.Location = new System.Drawing.Point(615, 368);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(128, 34);
            this.btnCopiar.TabIndex = 1;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.TextColor = System.Drawing.Color.White;
            this.btnCopiar.UseVisualStyleBackColor = false;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // lstvwResultados
            // 
            this.lstvwResultados.FormattingEnabled = true;
            this.lstvwResultados.ItemHeight = 20;
            this.lstvwResultados.Location = new System.Drawing.Point(12, 434);
            this.lstvwResultados.Name = "lstvwResultados";
            this.lstvwResultados.Size = new System.Drawing.Size(791, 264);
            this.lstvwResultados.TabIndex = 5;
            // 
            // Encriptador_Texto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(815, 708);
            this.ControlBox = false;
            this.Controls.Add(this.lstvwResultados);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Encriptador_Texto";
            this.Text = "Encriptador Texto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMNICript;
        private System.Windows.Forms.RadioButton rbMD5;
        private System.Windows.Forms.GroupBox groupBox2;
        private Encriptador.Botones.ButtonPers1 btnBorrar;
        private Encriptador.Botones.ButtonPers1 btnEnviar;
        private System.Windows.Forms.RadioButton rbDesencriptar;
        private System.Windows.Forms.RadioButton rbEncriptar;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultado;
        private Encriptador.Botones.ButtonPers1 btnCopiar;
        private System.Windows.Forms.ListBox lstvwResultados;
    }
}