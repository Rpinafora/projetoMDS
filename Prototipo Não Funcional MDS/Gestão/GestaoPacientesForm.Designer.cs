﻿namespace Prototipo_Não_Funcional_MDS
{
    partial class GestaoPacientesForm
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
            this.button_editarPaciente = new System.Windows.Forms.Button();
            this.button_adicionarPaciente = new System.Windows.Forms.Button();
            this.button_eliminarPaciente = new System.Windows.Forms.Button();
            this.textBox_paciente = new System.Windows.Forms.TextBox();
            this.listBox_pacientes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_editarPaciente
            // 
            this.button_editarPaciente.Location = new System.Drawing.Point(138, 52);
            this.button_editarPaciente.Name = "button_editarPaciente";
            this.button_editarPaciente.Size = new System.Drawing.Size(134, 23);
            this.button_editarPaciente.TabIndex = 14;
            this.button_editarPaciente.Text = "Editar Paciente";
            this.button_editarPaciente.UseVisualStyleBackColor = true;
            this.button_editarPaciente.Click += new System.EventHandler(this.button_editarPaciente_Click);
            // 
            // button_adicionarPaciente
            // 
            this.button_adicionarPaciente.Location = new System.Drawing.Point(138, 23);
            this.button_adicionarPaciente.Name = "button_adicionarPaciente";
            this.button_adicionarPaciente.Size = new System.Drawing.Size(134, 23);
            this.button_adicionarPaciente.TabIndex = 13;
            this.button_adicionarPaciente.Text = "Adicionar Paciente";
            this.button_adicionarPaciente.UseVisualStyleBackColor = true;
            this.button_adicionarPaciente.Click += new System.EventHandler(this.button_adicionarPaciente_Click);
            // 
            // button_eliminarPaciente
            // 
            this.button_eliminarPaciente.Location = new System.Drawing.Point(138, 81);
            this.button_eliminarPaciente.Name = "button_eliminarPaciente";
            this.button_eliminarPaciente.Size = new System.Drawing.Size(134, 23);
            this.button_eliminarPaciente.TabIndex = 12;
            this.button_eliminarPaciente.Text = "Eliminar Paciente";
            this.button_eliminarPaciente.UseVisualStyleBackColor = true;
            this.button_eliminarPaciente.Click += new System.EventHandler(this.button_eliminarPaciente_Click);
            // 
            // textBox_paciente
            // 
            this.textBox_paciente.Location = new System.Drawing.Point(12, 25);
            this.textBox_paciente.Name = "textBox_paciente";
            this.textBox_paciente.Size = new System.Drawing.Size(120, 20);
            this.textBox_paciente.TabIndex = 11;
            this.textBox_paciente.Text = "Procurar Paciente";
            // 
            // listBox_pacientes
            // 
            this.listBox_pacientes.FormattingEnabled = true;
            this.listBox_pacientes.Items.AddRange(new object[] {
            "Paciente 1",
            "Paciente 2",
            "Paciente 3",
            "Paciente 4",
            "Paciente 5",
            "Paciente 6"});
            this.listBox_pacientes.Location = new System.Drawing.Point(12, 51);
            this.listBox_pacientes.Name = "listBox_pacientes";
            this.listBox_pacientes.Size = new System.Drawing.Size(120, 186);
            this.listBox_pacientes.TabIndex = 10;
            this.listBox_pacientes.SelectedIndexChanged += new System.EventHandler(this.listBox_pacientes_SelectedIndexChanged);
            // 
            // GestaoPacientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_editarPaciente);
            this.Controls.Add(this.button_adicionarPaciente);
            this.Controls.Add(this.button_eliminarPaciente);
            this.Controls.Add(this.textBox_paciente);
            this.Controls.Add(this.listBox_pacientes);
            this.Name = "GestaoPacientesForm";
            this.Text = "GestaoPacientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_editarPaciente;
        private System.Windows.Forms.Button button_adicionarPaciente;
        private System.Windows.Forms.Button button_eliminarPaciente;
        private System.Windows.Forms.TextBox textBox_paciente;
        private System.Windows.Forms.ListBox listBox_pacientes;
    }
}