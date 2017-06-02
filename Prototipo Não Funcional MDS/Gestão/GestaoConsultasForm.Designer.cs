namespace Prototipo_Não_Funcional_MDS
{
    partial class GestaoConsultasForm
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
            this.listBox_consultas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_registarConsulta = new System.Windows.Forms.Button();
            this.button_editarConsulta = new System.Windows.Forms.Button();
            this.button_eliminarConsulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_consultas
            // 
            this.listBox_consultas.FormattingEnabled = true;
            this.listBox_consultas.Location = new System.Drawing.Point(12, 29);
            this.listBox_consultas.Name = "listBox_consultas";
            this.listBox_consultas.Size = new System.Drawing.Size(222, 212);
            this.listBox_consultas.TabIndex = 0;
            this.listBox_consultas.SelectedIndexChanged += new System.EventHandler(this.listBox_consultas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consultas:";
            // 
            // button_registarConsulta
            // 
            this.button_registarConsulta.Location = new System.Drawing.Point(240, 29);
            this.button_registarConsulta.Name = "button_registarConsulta";
            this.button_registarConsulta.Size = new System.Drawing.Size(165, 23);
            this.button_registarConsulta.TabIndex = 2;
            this.button_registarConsulta.Text = "Registar Nova Consulta";
            this.button_registarConsulta.UseVisualStyleBackColor = true;
            this.button_registarConsulta.Click += new System.EventHandler(this.button_registarConsulta_Click);
            // 
            // button_editarConsulta
            // 
            this.button_editarConsulta.Location = new System.Drawing.Point(240, 58);
            this.button_editarConsulta.Name = "button_editarConsulta";
            this.button_editarConsulta.Size = new System.Drawing.Size(165, 23);
            this.button_editarConsulta.TabIndex = 3;
            this.button_editarConsulta.Text = "Editar Consulta Selecionada";
            this.button_editarConsulta.UseVisualStyleBackColor = true;
            this.button_editarConsulta.Click += new System.EventHandler(this.button_editarConsulta_Click);
            // 
            // button_eliminarConsulta
            // 
            this.button_eliminarConsulta.Location = new System.Drawing.Point(240, 87);
            this.button_eliminarConsulta.Name = "button_eliminarConsulta";
            this.button_eliminarConsulta.Size = new System.Drawing.Size(165, 23);
            this.button_eliminarConsulta.TabIndex = 4;
            this.button_eliminarConsulta.Text = "Eliminar Consulta Selecionada";
            this.button_eliminarConsulta.UseVisualStyleBackColor = true;
            this.button_eliminarConsulta.Click += new System.EventHandler(this.button_eliminarConsulta_Click);
            // 
            // GestaoConsultasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 261);
            this.Controls.Add(this.button_eliminarConsulta);
            this.Controls.Add(this.button_editarConsulta);
            this.Controls.Add(this.button_registarConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_consultas);
            this.Name = "GestaoConsultasForm";
            this.Text = "GestaoConsultasForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_consultas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_registarConsulta;
        private System.Windows.Forms.Button button_editarConsulta;
        private System.Windows.Forms.Button button_eliminarConsulta;
    }
}