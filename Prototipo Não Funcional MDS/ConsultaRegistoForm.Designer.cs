﻿namespace Prototipo_Não_Funcional_MDS
{
    partial class ConsultaRegistoForm
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
            this.textBox_dadosPaciente = new System.Windows.Forms.TextBox();
            this.comboBox_especializacao = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_dataConsulta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_doutoresDisponiveis = new System.Windows.Forms.ComboBox();
            this.button_registar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_dadosPaciente
            // 
            this.textBox_dadosPaciente.Enabled = false;
            this.textBox_dadosPaciente.Location = new System.Drawing.Point(12, 12);
            this.textBox_dadosPaciente.Multiline = true;
            this.textBox_dadosPaciente.Name = "textBox_dadosPaciente";
            this.textBox_dadosPaciente.Size = new System.Drawing.Size(246, 36);
            this.textBox_dadosPaciente.TabIndex = 1;
            this.textBox_dadosPaciente.Text = "Nome: Carlos Pedroso\r\nIdade: 18\r\nNúmero de Consultas Feitas: 8";
            // 
            // comboBox_especializacao
            // 
            this.comboBox_especializacao.FormattingEnabled = true;
            this.comboBox_especializacao.Items.AddRange(new object[] {
            "Especialização 1",
            "Especialização 2",
            "Especialização 3",
            "Especialização 4"});
            this.comboBox_especializacao.Location = new System.Drawing.Point(137, 80);
            this.comboBox_especializacao.Name = "comboBox_especializacao";
            this.comboBox_especializacao.Size = new System.Drawing.Size(121, 21);
            this.comboBox_especializacao.TabIndex = 2;
            this.comboBox_especializacao.Text = "Especialização 1";
            // 
            // dateTimePicker_dataConsulta
            // 
            this.dateTimePicker_dataConsulta.Location = new System.Drawing.Point(58, 54);
            this.dateTimePicker_dataConsulta.Name = "dateTimePicker_dataConsulta";
            this.dateTimePicker_dataConsulta.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_dataConsulta.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Especialização:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Doutores";
            // 
            // comboBox_doutoresDisponiveis
            // 
            this.comboBox_doutoresDisponiveis.FormattingEnabled = true;
            this.comboBox_doutoresDisponiveis.Location = new System.Drawing.Point(137, 118);
            this.comboBox_doutoresDisponiveis.Name = "comboBox_doutoresDisponiveis";
            this.comboBox_doutoresDisponiveis.Size = new System.Drawing.Size(121, 21);
            this.comboBox_doutoresDisponiveis.TabIndex = 7;
            // 
            // button_registar
            // 
            this.button_registar.Location = new System.Drawing.Point(173, 149);
            this.button_registar.Name = "button_registar";
            this.button_registar.Size = new System.Drawing.Size(85, 23);
            this.button_registar.TabIndex = 8;
            this.button_registar.Text = "Registar";
            this.button_registar.UseVisualStyleBackColor = true;
            this.button_registar.Click += new System.EventHandler(this.button_registar_Click);
            // 
            // ConsultaRegistoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 182);
            this.Controls.Add(this.button_registar);
            this.Controls.Add(this.comboBox_doutoresDisponiveis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_dataConsulta);
            this.Controls.Add(this.comboBox_especializacao);
            this.Controls.Add(this.textBox_dadosPaciente);
            this.Name = "ConsultaRegistoForm";
            this.Text = "ConsultaRegistoForm";
            this.Load += new System.EventHandler(this.ConsultaRegistoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_dadosPaciente;
        private System.Windows.Forms.ComboBox comboBox_especializacao;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dataConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_doutoresDisponiveis;
        private System.Windows.Forms.Button button_registar;
    }
}