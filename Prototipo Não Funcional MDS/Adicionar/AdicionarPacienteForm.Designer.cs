namespace Prototipo_Não_Funcional_MDS
{
    partial class AdicionarPacienteForm
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
            this.button_registar = new System.Windows.Forms.Button();
            this.dateTimePicker_dataNascimento = new System.Windows.Forms.DateTimePicker();
            this.textBox_nif = new System.Windows.Forms.TextBox();
            this.textBox_numTelefone = new System.Windows.Forms.TextBox();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown_altura = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_peso = new System.Windows.Forms.NumericUpDown();
            this.label_peso = new System.Windows.Forms.Label();
            this.label_altura = new System.Windows.Forms.Label();
            this.comboBox_tipoSanguineo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_altura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_peso)).BeginInit();
            this.SuspendLayout();
            // 
            // button_registar
            // 
            this.button_registar.Location = new System.Drawing.Point(197, 154);
            this.button_registar.Name = "button_registar";
            this.button_registar.Size = new System.Drawing.Size(75, 23);
            this.button_registar.TabIndex = 36;
            this.button_registar.Text = "Registar ";
            this.button_registar.UseVisualStyleBackColor = true;
            this.button_registar.Click += new System.EventHandler(this.button_registar_Click);
            // 
            // dateTimePicker_dataNascimento
            // 
            this.dateTimePicker_dataNascimento.Location = new System.Drawing.Point(112, 90);
            this.dateTimePicker_dataNascimento.Name = "dateTimePicker_dataNascimento";
            this.dateTimePicker_dataNascimento.Size = new System.Drawing.Size(160, 20);
            this.dateTimePicker_dataNascimento.TabIndex = 35;
            // 
            // textBox_nif
            // 
            this.textBox_nif.Location = new System.Drawing.Point(112, 64);
            this.textBox_nif.Name = "textBox_nif";
            this.textBox_nif.Size = new System.Drawing.Size(160, 20);
            this.textBox_nif.TabIndex = 34;
            // 
            // textBox_numTelefone
            // 
            this.textBox_numTelefone.Location = new System.Drawing.Point(112, 38);
            this.textBox_numTelefone.Name = "textBox_numTelefone";
            this.textBox_numTelefone.Size = new System.Drawing.Size(160, 20);
            this.textBox_numTelefone.TabIndex = 33;
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(112, 12);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(160, 20);
            this.textBox_nome.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Data Nascimento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "NIF:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Numero Telefone";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Nome:";
            // 
            // numericUpDown_altura
            // 
            this.numericUpDown_altura.Location = new System.Drawing.Point(197, 123);
            this.numericUpDown_altura.Name = "numericUpDown_altura";
            this.numericUpDown_altura.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_altura.TabIndex = 37;
            // 
            // numericUpDown_peso
            // 
            this.numericUpDown_peso.Location = new System.Drawing.Point(51, 123);
            this.numericUpDown_peso.Name = "numericUpDown_peso";
            this.numericUpDown_peso.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_peso.TabIndex = 38;
            // 
            // label_peso
            // 
            this.label_peso.AutoSize = true;
            this.label_peso.Location = new System.Drawing.Point(14, 125);
            this.label_peso.Name = "label_peso";
            this.label_peso.Size = new System.Drawing.Size(31, 13);
            this.label_peso.TabIndex = 39;
            this.label_peso.Text = "Peso";
            // 
            // label_altura
            // 
            this.label_altura.AutoSize = true;
            this.label_altura.Location = new System.Drawing.Point(160, 125);
            this.label_altura.Name = "label_altura";
            this.label_altura.Size = new System.Drawing.Size(34, 13);
            this.label_altura.TabIndex = 40;
            this.label_altura.Text = "Altura";
            // 
            // comboBox_tipoSanguineo
            // 
            this.comboBox_tipoSanguineo.FormattingEnabled = true;
            this.comboBox_tipoSanguineo.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.comboBox_tipoSanguineo.Location = new System.Drawing.Point(112, 156);
            this.comboBox_tipoSanguineo.Name = "comboBox_tipoSanguineo";
            this.comboBox_tipoSanguineo.Size = new System.Drawing.Size(65, 21);
            this.comboBox_tipoSanguineo.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Tipo Sanguineo";
            // 
            // AdicionarPacienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 194);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_tipoSanguineo);
            this.Controls.Add(this.label_altura);
            this.Controls.Add(this.label_peso);
            this.Controls.Add(this.numericUpDown_peso);
            this.Controls.Add(this.numericUpDown_altura);
            this.Controls.Add(this.button_registar);
            this.Controls.Add(this.dateTimePicker_dataNascimento);
            this.Controls.Add(this.textBox_nif);
            this.Controls.Add(this.textBox_numTelefone);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Name = "AdicionarPacienteForm";
            this.Text = "Registar Paciente";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_altura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_peso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_registar;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dataNascimento;
        private System.Windows.Forms.TextBox textBox_nif;
        private System.Windows.Forms.TextBox textBox_numTelefone;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown_altura;
        private System.Windows.Forms.NumericUpDown numericUpDown_peso;
        private System.Windows.Forms.Label label_peso;
        private System.Windows.Forms.Label label_altura;
        private System.Windows.Forms.ComboBox comboBox_tipoSanguineo;
        private System.Windows.Forms.Label label1;
    }
}