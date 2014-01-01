namespace Calorias
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_Restaurar = new System.Windows.Forms.Button();
            this.TextBox_Peso = new System.Windows.Forms.TextBox();
            this.TextBox_Edad = new System.Windows.Forms.TextBox();
            this.TextBox_Altura = new System.Windows.Forms.TextBox();
            this.RadioButton_M = new System.Windows.Forms.RadioButton();
            this.RadioButton_F = new System.Windows.Forms.RadioButton();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ComboBox_Actividades = new System.Windows.Forms.ComboBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label_Calorias = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Button_Calcular = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Restaurar
            // 
            this.Button_Restaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Restaurar.Location = new System.Drawing.Point(174, 256);
            this.Button_Restaurar.Name = "Button_Restaurar";
            this.Button_Restaurar.Size = new System.Drawing.Size(94, 23);
            this.Button_Restaurar.TabIndex = 10;
            this.Button_Restaurar.Text = "Restaurar";
            this.Button_Restaurar.UseVisualStyleBackColor = true;
            this.Button_Restaurar.Click += new System.EventHandler(this.Button_Restaurar_Click);
            // 
            // TextBox_Peso
            // 
            this.TextBox_Peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Peso.Location = new System.Drawing.Point(60, 113);
            this.TextBox_Peso.Name = "TextBox_Peso";
            this.TextBox_Peso.Size = new System.Drawing.Size(84, 21);
            this.TextBox_Peso.TabIndex = 23;
            // 
            // TextBox_Edad
            // 
            this.TextBox_Edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Edad.Location = new System.Drawing.Point(63, 68);
            this.TextBox_Edad.Name = "TextBox_Edad";
            this.TextBox_Edad.Size = new System.Drawing.Size(82, 21);
            this.TextBox_Edad.TabIndex = 22;
            // 
            // TextBox_Altura
            // 
            this.TextBox_Altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Altura.Location = new System.Drawing.Point(65, 26);
            this.TextBox_Altura.Name = "TextBox_Altura";
            this.TextBox_Altura.Size = new System.Drawing.Size(81, 21);
            this.TextBox_Altura.TabIndex = 21;
            // 
            // RadioButton_M
            // 
            this.RadioButton_M.AutoSize = true;
            this.RadioButton_M.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton_M.Location = new System.Drawing.Point(237, 30);
            this.RadioButton_M.Name = "RadioButton_M";
            this.RadioButton_M.Size = new System.Drawing.Size(38, 20);
            this.RadioButton_M.TabIndex = 20;
            this.RadioButton_M.TabStop = true;
            this.RadioButton_M.Text = "M";
            this.RadioButton_M.UseVisualStyleBackColor = true;
            // 
            // RadioButton_F
            // 
            this.RadioButton_F.AutoSize = true;
            this.RadioButton_F.Checked = true;
            this.RadioButton_F.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButton_F.Location = new System.Drawing.Point(175, 29);
            this.RadioButton_F.Name = "RadioButton_F";
            this.RadioButton_F.Size = new System.Drawing.Size(35, 20);
            this.RadioButton_F.TabIndex = 19;
            this.RadioButton_F.TabStop = true;
            this.RadioButton_F.Text = "F";
            this.RadioButton_F.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(13, 113);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(44, 16);
            this.Label4.TabIndex = 18;
            this.Label4.Text = "Peso";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(13, 71);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(45, 16);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "Edad";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(13, 29);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(48, 16);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "Altura";
            // 
            // ComboBox_Actividades
            // 
            this.ComboBox_Actividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Actividades.FormattingEnabled = true;
            this.ComboBox_Actividades.Items.AddRange(new object[] {
            "Actividades",
            "Sedentaria",
            "Ligera",
            "Moderada",
            "Dinamica",
            "Muy dinamica"});
            this.ComboBox_Actividades.Location = new System.Drawing.Point(165, 68);
            this.ComboBox_Actividades.Name = "ComboBox_Actividades";
            this.ComboBox_Actividades.Size = new System.Drawing.Size(108, 23);
            this.ComboBox_Actividades.TabIndex = 15;
            this.ComboBox_Actividades.Text = "Actividades";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.TextBox_Peso);
            this.GroupBox1.Controls.Add(this.TextBox_Edad);
            this.GroupBox1.Controls.Add(this.TextBox_Altura);
            this.GroupBox1.Controls.Add(this.RadioButton_M);
            this.GroupBox1.Controls.Add(this.RadioButton_F);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.ComboBox_Actividades);
            this.GroupBox1.Location = new System.Drawing.Point(12, 17);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(288, 160);
            this.GroupBox1.TabIndex = 15;
            this.GroupBox1.TabStop = false;
            // 
            // Label_Calorias
            // 
            this.Label_Calorias.AutoSize = true;
            this.Label_Calorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Calorias.Location = new System.Drawing.Point(101, 214);
            this.Label_Calorias.Name = "Label_Calorias";
            this.Label_Calorias.Size = new System.Drawing.Size(16, 16);
            this.Label_Calorias.TabIndex = 14;
            this.Label_Calorias.Text = "0";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(30, 180);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(118, 16);
            this.Label5.TabIndex = 13;
            this.Label5.Text = "Calorias diarias";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(30, 214);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(70, 16);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Calorias:";
            // 
            // Button_Calcular
            // 
            this.Button_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Calcular.Location = new System.Drawing.Point(33, 256);
            this.Button_Calcular.Name = "Button_Calcular";
            this.Button_Calcular.Size = new System.Drawing.Size(75, 23);
            this.Button_Calcular.TabIndex = 11;
            this.Button_Calcular.Text = "Calcular";
            this.Button_Calcular.UseVisualStyleBackColor = true;
            this.Button_Calcular.Click += new System.EventHandler(this.Button_Calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(312, 296);
            this.Controls.Add(this.Button_Restaurar);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label_Calorias);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Button_Calcular);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calorias";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button_Restaurar;
        internal System.Windows.Forms.TextBox TextBox_Peso;
        internal System.Windows.Forms.TextBox TextBox_Edad;
        internal System.Windows.Forms.TextBox TextBox_Altura;
        internal System.Windows.Forms.RadioButton RadioButton_M;
        internal System.Windows.Forms.RadioButton RadioButton_F;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox ComboBox_Actividades;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label_Calorias;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button Button_Calcular;
    }
}

