namespace Prototipo_Não_Funcional_MDS
{
    partial class EditarConsultaForm
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
            this.label_hora = new System.Windows.Forms.Label();
            this.dateTimePicker_hora = new System.Windows.Forms.DateTimePicker();
            this.textBox_sintomas = new System.Windows.Forms.TextBox();
            this.label_sintomas = new System.Windows.Forms.Label();
            this.button_editar = new System.Windows.Forms.Button();
            this.comboBox_doutoresDisponiveis = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_dataConsulta = new System.Windows.Forms.DateTimePicker();
            this.comboBox_especializacao = new System.Windows.Forms.ComboBox();
            this.textBox_dadosPaciente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_hora
            // 
            this.label_hora.AutoSize = true;
            this.label_hora.Location = new System.Drawing.Point(181, 116);
            this.label_hora.Name = "label_hora";
            this.label_hora.Size = new System.Drawing.Size(33, 13);
            this.label_hora.TabIndex = 24;
            this.label_hora.Text = "Hora:";
            // 
            // dateTimePicker_hora
            // 
            this.dateTimePicker_hora.AllowDrop = true;
            this.dateTimePicker_hora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_hora.Location = new System.Drawing.Point(223, 110);
            this.dateTimePicker_hora.Name = "dateTimePicker_hora";
            this.dateTimePicker_hora.ShowUpDown = true;
            this.dateTimePicker_hora.Size = new System.Drawing.Size(91, 20);
            this.dateTimePicker_hora.TabIndex = 23;
            // 
            // textBox_sintomas
            // 
            this.textBox_sintomas.Location = new System.Drawing.Point(13, 155);
            this.textBox_sintomas.Multiline = true;
            this.textBox_sintomas.Name = "textBox_sintomas";
            this.textBox_sintomas.Size = new System.Drawing.Size(301, 90);
            this.textBox_sintomas.TabIndex = 22;
            // 
            // label_sintomas
            // 
            this.label_sintomas.AutoSize = true;
            this.label_sintomas.Location = new System.Drawing.Point(10, 139);
            this.label_sintomas.Name = "label_sintomas";
            this.label_sintomas.Size = new System.Drawing.Size(50, 13);
            this.label_sintomas.TabIndex = 21;
            this.label_sintomas.Text = "Sintomas";
            // 
            // button_editar
            // 
            this.button_editar.Location = new System.Drawing.Point(229, 308);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(85, 23);
            this.button_editar.TabIndex = 20;
            this.button_editar.Text = "Editar";
            this.button_editar.UseVisualStyleBackColor = true;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // comboBox_doutoresDisponiveis
            // 
            this.comboBox_doutoresDisponiveis.FormattingEnabled = true;
            this.comboBox_doutoresDisponiveis.Location = new System.Drawing.Point(193, 281);
            this.comboBox_doutoresDisponiveis.Name = "comboBox_doutoresDisponiveis";
            this.comboBox_doutoresDisponiveis.Size = new System.Drawing.Size(121, 21);
            this.comboBox_doutoresDisponiveis.TabIndex = 19;
            this.comboBox_doutoresDisponiveis.SelectedIndexChanged += new System.EventHandler(this.comboBox_doutoresDisponiveis_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Doutores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Especialização:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Data:";
            // 
            // dateTimePicker_dataConsulta
            // 
            this.dateTimePicker_dataConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_dataConsulta.Location = new System.Drawing.Point(49, 110);
            this.dateTimePicker_dataConsulta.Name = "dateTimePicker_dataConsulta";
            this.dateTimePicker_dataConsulta.Size = new System.Drawing.Size(91, 20);
            this.dateTimePicker_dataConsulta.TabIndex = 15;
            // 
            // comboBox_especializacao
            // 
            this.comboBox_especializacao.FormattingEnabled = true;
            this.comboBox_especializacao.Location = new System.Drawing.Point(193, 254);
            this.comboBox_especializacao.Name = "comboBox_especializacao";
            this.comboBox_especializacao.Size = new System.Drawing.Size(121, 21);
            this.comboBox_especializacao.TabIndex = 14;
            // 
            // textBox_dadosPaciente
            // 
            this.textBox_dadosPaciente.Enabled = false;
            this.textBox_dadosPaciente.Location = new System.Drawing.Point(13, 13);
            this.textBox_dadosPaciente.Multiline = true;
            this.textBox_dadosPaciente.Name = "textBox_dadosPaciente";
            this.textBox_dadosPaciente.Size = new System.Drawing.Size(301, 91);
            this.textBox_dadosPaciente.TabIndex = 13;
            // 
            // EditarConsultaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 344);
            this.Controls.Add(this.label_hora);
            this.Controls.Add(this.dateTimePicker_hora);
            this.Controls.Add(this.textBox_sintomas);
            this.Controls.Add(this.label_sintomas);
            this.Controls.Add(this.button_editar);
            this.Controls.Add(this.comboBox_doutoresDisponiveis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_dataConsulta);
            this.Controls.Add(this.comboBox_especializacao);
            this.Controls.Add(this.textBox_dadosPaciente);
            this.Name = "EditarConsultaForm";
            this.Text = "EditarConsultaForm";
            this.Load += new System.EventHandler(this.EditarConsultaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_hora;
        private System.Windows.Forms.DateTimePicker dateTimePicker_hora;
        private System.Windows.Forms.TextBox textBox_sintomas;
        private System.Windows.Forms.Label label_sintomas;
        private System.Windows.Forms.Button button_editar;
        private System.Windows.Forms.ComboBox comboBox_doutoresDisponiveis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dataConsulta;
        private System.Windows.Forms.ComboBox comboBox_especializacao;
        private System.Windows.Forms.TextBox textBox_dadosPaciente;
    }
}