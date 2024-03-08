namespace WindowsFormsApp1
{
    partial class FAltaActiv
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
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNomb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxParticipantes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCosto = new System.Windows.Forms.TextBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.maskedTextBoxHoraI = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxHoraF = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listBoxProfes = new System.Windows.Forms.ListBox();
            this.comboBoxDia = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxCod
            // 
            this.textBoxCod.Location = new System.Drawing.Point(134, 47);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(100, 20);
            this.textBoxCod.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripción";
            // 
            // textBoxNomb
            // 
            this.textBoxNomb.Location = new System.Drawing.Point(134, 92);
            this.textBoxNomb.Name = "textBoxNomb";
            this.textBoxNomb.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomb.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hora Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hora Fin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Día";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cantidad máxima de participantes";
            // 
            // textBoxParticipantes
            // 
            this.textBoxParticipantes.Location = new System.Drawing.Point(454, 180);
            this.textBoxParticipantes.Name = "textBoxParticipantes";
            this.textBoxParticipantes.Size = new System.Drawing.Size(100, 20);
            this.textBoxParticipantes.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Costo: $";
            // 
            // textBoxCosto
            // 
            this.textBoxCosto.Location = new System.Drawing.Point(354, 226);
            this.textBoxCosto.Name = "textBoxCosto";
            this.textBoxCosto.Size = new System.Drawing.Size(100, 20);
            this.textBoxCosto.TabIndex = 12;
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(305, 383);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 14;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(459, 383);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 15;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // maskedTextBoxHoraI
            // 
            this.maskedTextBoxHoraI.Location = new System.Drawing.Point(353, 53);
            this.maskedTextBoxHoraI.Mask = "99999";
            this.maskedTextBoxHoraI.Name = "maskedTextBoxHoraI";
            this.maskedTextBoxHoraI.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxHoraI.TabIndex = 16;
            this.maskedTextBoxHoraI.ValidatingType = typeof(int);
            // 
            // maskedTextBoxHoraF
            // 
            this.maskedTextBoxHoraF.Location = new System.Drawing.Point(353, 88);
            this.maskedTextBoxHoraF.Mask = "99999";
            this.maskedTextBoxHoraF.Name = "maskedTextBoxHoraF";
            this.maskedTextBoxHoraF.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxHoraF.TabIndex = 17;
            this.maskedTextBoxHoraF.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Profesor";
            // 
            // listBoxProfes
            // 
            this.listBoxProfes.FormattingEnabled = true;
            this.listBoxProfes.Location = new System.Drawing.Point(122, 142);
            this.listBoxProfes.Name = "listBoxProfes";
            this.listBoxProfes.Size = new System.Drawing.Size(118, 147);
            this.listBoxProfes.TabIndex = 20;
            // 
            // comboBoxDia
            // 
            this.comboBoxDia.FormattingEnabled = true;
            this.comboBoxDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado"});
            this.comboBoxDia.Location = new System.Drawing.Point(353, 136);
            this.comboBoxDia.Name = "comboBoxDia";
            this.comboBoxDia.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDia.TabIndex = 21;
            // 
            // FAltaActiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxDia);
            this.Controls.Add(this.listBoxProfes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maskedTextBoxHoraF);
            this.Controls.Add(this.maskedTextBoxHoraI);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCosto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxParticipantes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNomb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCod);
            this.Name = "FAltaActiv";
            this.Text = "Alta Actividad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNomb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxParticipantes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCosto;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHoraI;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHoraF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBoxProfes;
        private System.Windows.Forms.ComboBox comboBoxDia;
    }
}