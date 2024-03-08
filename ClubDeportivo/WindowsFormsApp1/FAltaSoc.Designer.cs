namespace WindowsFormsApp1
{
    partial class FAltaSoc
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNomb = new System.Windows.Forms.TextBox();
            this.maskedTextBoxDNI = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxTipoSocio = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCuotaSocioClub = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro de DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre y Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Socio";
            // 
            // textBoxNomb
            // 
            this.textBoxNomb.Location = new System.Drawing.Point(205, 91);
            this.textBoxNomb.Name = "textBoxNomb";
            this.textBoxNomb.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomb.TabIndex = 3;
            // 
            // maskedTextBoxDNI
            // 
            this.maskedTextBoxDNI.Location = new System.Drawing.Point(205, 58);
            this.maskedTextBoxDNI.Name = "maskedTextBoxDNI";
            this.maskedTextBoxDNI.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxDNI.TabIndex = 4;
            // 
            // comboBoxTipoSocio
            // 
            this.comboBoxTipoSocio.FormattingEnabled = true;
            this.comboBoxTipoSocio.Items.AddRange(new object[] {
            "Club",
            "Actividades"});
            this.comboBoxTipoSocio.Location = new System.Drawing.Point(205, 132);
            this.comboBoxTipoSocio.Name = "comboBoxTipoSocio";
            this.comboBoxTipoSocio.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoSocio.TabIndex = 5;
            this.comboBoxTipoSocio.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoSocio_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cuota mensual $";
            this.label4.Visible = false;
            // 
            // textBoxCuotaSocioClub
            // 
            this.textBoxCuotaSocioClub.Location = new System.Drawing.Point(205, 190);
            this.textBoxCuotaSocioClub.Name = "textBoxCuotaSocioClub";
            this.textBoxCuotaSocioClub.Size = new System.Drawing.Size(100, 20);
            this.textBoxCuotaSocioClub.TabIndex = 7;
            this.textBoxCuotaSocioClub.Visible = false;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(229, 360);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 8;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(410, 360);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FAltaSoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxCuotaSocioClub);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxTipoSocio);
            this.Controls.Add(this.maskedTextBoxDNI);
            this.Controls.Add(this.textBoxNomb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FAltaSoc";
            this.Text = "Alta de Socio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNomb;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDNI;
        private System.Windows.Forms.ComboBox comboBoxTipoSocio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCuotaSocioClub;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}