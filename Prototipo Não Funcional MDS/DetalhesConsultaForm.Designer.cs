﻿namespace Prototipo_Não_Funcional_MDS
{
    partial class DetalhesConsultaForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_sintomas = new System.Windows.Forms.TextBox();
            this.tbx_diagn_medico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_obs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbx_detalhes_paciente = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 426);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(328, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Finalizar Consulta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Data:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(87, 27);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sintomas: ";
            // 
            // tbx_sintomas
            // 
            this.tbx_sintomas.Location = new System.Drawing.Point(25, 156);
            this.tbx_sintomas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_sintomas.Multiline = true;
            this.tbx_sintomas.Name = "tbx_sintomas";
            this.tbx_sintomas.Size = new System.Drawing.Size(327, 62);
            this.tbx_sintomas.TabIndex = 14;
            this.tbx_sintomas.Text = "\r\n";
            // 
            // tbx_diagn_medico
            // 
            this.tbx_diagn_medico.Location = new System.Drawing.Point(25, 254);
            this.tbx_diagn_medico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_diagn_medico.Multiline = true;
            this.tbx_diagn_medico.Name = "tbx_diagn_medico";
            this.tbx_diagn_medico.Size = new System.Drawing.Size(327, 62);
            this.tbx_diagn_medico.TabIndex = 16;
            this.tbx_diagn_medico.Text = "\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Diagnostico Médico:";
            // 
            // tbx_obs
            // 
            this.tbx_obs.Location = new System.Drawing.Point(25, 342);
            this.tbx_obs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_obs.Multiline = true;
            this.tbx_obs.Name = "tbx_obs";
            this.tbx_obs.Size = new System.Drawing.Size(327, 62);
            this.tbx_obs.TabIndex = 18;
            this.tbx_obs.Text = "\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 322);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Observações Adicionais:";
            // 
            // lbx_detalhes_paciente
            // 
            this.lbx_detalhes_paciente.FormattingEnabled = true;
            this.lbx_detalhes_paciente.ItemHeight = 16;
            this.lbx_detalhes_paciente.Location = new System.Drawing.Point(24, 56);
            this.lbx_detalhes_paciente.Name = "lbx_detalhes_paciente";
            this.lbx_detalhes_paciente.Size = new System.Drawing.Size(329, 68);
            this.lbx_detalhes_paciente.TabIndex = 19;
            // 
            // DetalhesConsultaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 481);
            this.Controls.Add(this.lbx_detalhes_paciente);
            this.Controls.Add(this.tbx_obs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_diagn_medico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_sintomas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DetalhesConsultaForm";
            this.Text = "DetalhesConsulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_sintomas;
        private System.Windows.Forms.TextBox tbx_diagn_medico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_obs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbx_detalhes_paciente;
    }
}