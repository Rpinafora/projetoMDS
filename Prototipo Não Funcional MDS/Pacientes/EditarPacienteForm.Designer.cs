namespace Prototipo_Não_Funcional_MDS
{
    partial class EditarPacienteForm
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
            this.comboBox_tipoSanguineo = new System.Windows.Forms.ComboBox();
            this.label_altura = new System.Windows.Forms.Label();
            this.label_peso = new System.Windows.Forms.Label();
            this.numericUpDown_peso = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_altura = new System.Windows.Forms.NumericUpDown();
            this.button_editar = new System.Windows.Forms.Button();
            this.dateTimePicker_dataNascimento = new System.Windows.Forms.DateTimePicker();
            this.textBox_nif = new System.Windows.Forms.TextBox();
            this.textBox_numTelefone = new System.Windows.Forms.TextBox();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_peso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_altura)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "Tipo Sanguineo";
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
            this.comboBox_tipoSanguineo.Location = new System.Drawing.Point(148, 196);
            this.comboBox_tipoSanguineo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_tipoSanguineo.Name = "comboBox_tipoSanguineo";
            this.comboBox_tipoSanguineo.Size = new System.Drawing.Size(85, 24);
            this.comboBox_tipoSanguineo.TabIndex = 56;
            // 
            // label_altura
            // 
            this.label_altura.AutoSize = true;
            this.label_altura.Location = new System.Drawing.Point(212, 158);
            this.label_altura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_altura.Name = "label_altura";
            this.label_altura.Size = new System.Drawing.Size(45, 17);
            this.label_altura.TabIndex = 55;
            this.label_altura.Text = "Altura";
            // 
            // label_peso
            // 
            this.label_peso.AutoSize = true;
            this.label_peso.Location = new System.Drawing.Point(17, 158);
            this.label_peso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_peso.Name = "label_peso";
            this.label_peso.Size = new System.Drawing.Size(40, 17);
            this.label_peso.TabIndex = 54;
            this.label_peso.Text = "Peso";
            // 
            // numericUpDown_peso
            // 
            this.numericUpDown_peso.Location = new System.Drawing.Point(67, 155);
            this.numericUpDown_peso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown_peso.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_peso.Name = "numericUpDown_peso";
            this.numericUpDown_peso.Size = new System.Drawing.Size(100, 22);
            this.numericUpDown_peso.TabIndex = 53;
            // 
            // numericUpDown_altura
            // 
            this.numericUpDown_altura.Location = new System.Drawing.Point(261, 155);
            this.numericUpDown_altura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown_altura.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown_altura.Name = "numericUpDown_altura";
            this.numericUpDown_altura.Size = new System.Drawing.Size(100, 22);
            this.numericUpDown_altura.TabIndex = 52;
            // 
            // button_editar
            // 
            this.button_editar.Location = new System.Drawing.Point(261, 193);
            this.button_editar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(100, 28);
            this.button_editar.TabIndex = 51;
            this.button_editar.Text = "Editar";
            this.button_editar.UseVisualStyleBackColor = true;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // dateTimePicker_dataNascimento
            // 
            this.dateTimePicker_dataNascimento.Location = new System.Drawing.Point(148, 114);
            this.dateTimePicker_dataNascimento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_dataNascimento.Name = "dateTimePicker_dataNascimento";
            this.dateTimePicker_dataNascimento.Size = new System.Drawing.Size(212, 22);
            this.dateTimePicker_dataNascimento.TabIndex = 50;
            // 
            // textBox_nif
            // 
            this.textBox_nif.Location = new System.Drawing.Point(148, 82);
            this.textBox_nif.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_nif.Name = "textBox_nif";
            this.textBox_nif.Size = new System.Drawing.Size(212, 22);
            this.textBox_nif.TabIndex = 49;
            // 
            // textBox_numTelefone
            // 
            this.textBox_numTelefone.Location = new System.Drawing.Point(148, 50);
            this.textBox_numTelefone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_numTelefone.Name = "textBox_numTelefone";
            this.textBox_numTelefone.Size = new System.Drawing.Size(212, 22);
            this.textBox_numTelefone.TabIndex = 48;
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(148, 18);
            this.textBox_nome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(212, 22);
            this.textBox_nome.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "Data Nascimento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 86);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "NIF:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 54);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 17);
            this.label10.TabIndex = 44;
            this.label10.Text = "Numero Telefone";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 22);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 43;
            this.label11.Text = "Nome:";
            // 
            // EditarPacienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 239);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_tipoSanguineo);
            this.Controls.Add(this.label_altura);
            this.Controls.Add(this.label_peso);
            this.Controls.Add(this.numericUpDown_peso);
            this.Controls.Add(this.numericUpDown_altura);
            this.Controls.Add(this.button_editar);
            this.Controls.Add(this.dateTimePicker_dataNascimento);
            this.Controls.Add(this.textBox_nif);
            this.Controls.Add(this.textBox_numTelefone);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditarPacienteForm";
            this.Text = "EditarPacienteForm";
            this.Load += new System.EventHandler(this.EditarPacienteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_peso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_altura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_tipoSanguineo;
        private System.Windows.Forms.Label label_altura;
        private System.Windows.Forms.Label label_peso;
        private System.Windows.Forms.NumericUpDown numericUpDown_peso;
        private System.Windows.Forms.NumericUpDown numericUpDown_altura;
        private System.Windows.Forms.Button button_editar;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dataNascimento;
        private System.Windows.Forms.TextBox textBox_nif;
        private System.Windows.Forms.TextBox textBox_numTelefone;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}