namespace WindowsFormsApp1
{
    partial class FInscripcion
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
            this.maskedTextBoxDni = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.Label();
            this.TipoS = new System.Windows.Forms.Label();
            this.listBoxActSinCargo = new System.Windows.Forms.ListBox();
            this.listBoxActExcedentes = new System.Windows.Forms.ListBox();
            this.listBoxActividadesSocio = new System.Windows.Forms.ListBox();
            this.listBoxActividadesInscripcion = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº DNI Socix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Socix";
            this.label2.Visible = false;
            // 
            // maskedTextBoxDni
            // 
            this.maskedTextBoxDni.Location = new System.Drawing.Point(165, 50);
            this.maskedTextBoxDni.Mask = "00000000";
            this.maskedTextBoxDni.Name = "maskedTextBoxDni";
            this.maskedTextBoxDni.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxDni.TabIndex = 2;
            this.maskedTextBoxDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Actividades sin cargo";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(589, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Actividades excedentes";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Actividades inscriptas";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "Seleccione la actividad deseada";
            this.label7.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(467, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(165, 103);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(0, 13);
            this.Nombre.TabIndex = 11;
            this.Nombre.Visible = false;
            // 
            // TipoS
            // 
            this.TipoS.AutoSize = true;
            this.TipoS.Location = new System.Drawing.Point(171, 141);
            this.TipoS.Name = "TipoS";
            this.TipoS.Size = new System.Drawing.Size(0, 13);
            this.TipoS.TabIndex = 12;
            this.TipoS.Visible = false;
            // 
            // listBoxActSinCargo
            // 
            this.listBoxActSinCargo.FormattingEnabled = true;
            this.listBoxActSinCargo.Location = new System.Drawing.Point(417, 157);
            this.listBoxActSinCargo.Name = "listBoxActSinCargo";
            this.listBoxActSinCargo.Size = new System.Drawing.Size(145, 95);
            this.listBoxActSinCargo.TabIndex = 13;
            this.listBoxActSinCargo.Visible = false;
            // 
            // listBoxActExcedentes
            // 
            this.listBoxActExcedentes.FormattingEnabled = true;
            this.listBoxActExcedentes.Location = new System.Drawing.Point(636, 157);
            this.listBoxActExcedentes.Name = "listBoxActExcedentes";
            this.listBoxActExcedentes.Size = new System.Drawing.Size(152, 95);
            this.listBoxActExcedentes.TabIndex = 14;
            this.listBoxActExcedentes.Visible = false;
            // 
            // listBoxActividadesSocio
            // 
            this.listBoxActividadesSocio.FormattingEnabled = true;
            this.listBoxActividadesSocio.Location = new System.Drawing.Point(201, 178);
            this.listBoxActividadesSocio.Name = "listBoxActividadesSocio";
            this.listBoxActividadesSocio.Size = new System.Drawing.Size(165, 95);
            this.listBoxActividadesSocio.TabIndex = 15;
            this.listBoxActividadesSocio.Visible = false;
            // 
            // listBoxActividadesInscripcion
            // 
            this.listBoxActividadesInscripcion.FormattingEnabled = true;
            this.listBoxActividadesInscripcion.Location = new System.Drawing.Point(339, 290);
            this.listBoxActividadesInscripcion.Name = "listBoxActividadesInscripcion";
            this.listBoxActividadesInscripcion.Size = new System.Drawing.Size(223, 95);
            this.listBoxActividadesInscripcion.TabIndex = 16;
            this.listBoxActividadesInscripcion.Visible = false;
            // 
            // FInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxActividadesInscripcion);
            this.Controls.Add(this.listBoxActividadesSocio);
            this.Controls.Add(this.listBoxActExcedentes);
            this.Controls.Add(this.listBoxActSinCargo);
            this.Controls.Add(this.TipoS);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBoxDni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FInscripcion";
            this.Text = "FInscripcion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDni;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label TipoS;
        private System.Windows.Forms.ListBox listBoxActSinCargo;
        private System.Windows.Forms.ListBox listBoxActExcedentes;
        private System.Windows.Forms.ListBox listBoxActividadesSocio;
        private System.Windows.Forms.ListBox listBoxActividadesInscripcion;
    }
}