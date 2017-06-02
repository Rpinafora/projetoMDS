namespace Prototipo_Não_Funcional_MDS
{
    partial class GestaoConsultasAgendadasForm
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
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbx_consultas = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(252, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Eliminar Agendamento";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.EventoEliminarConsulta);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Consultas Agendadas:";
            // 
            // lbx_consultas
            // 
            this.lbx_consultas.FormattingEnabled = true;
            this.lbx_consultas.Location = new System.Drawing.Point(12, 47);
            this.lbx_consultas.Name = "lbx_consultas";
            this.lbx_consultas.Size = new System.Drawing.Size(235, 212);
            this.lbx_consultas.TabIndex = 5;
            this.lbx_consultas.DoubleClick += new System.EventHandler(this.EventoDetalhesConsulta);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(252, 236);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Arquivo de Consultas";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(324, 12);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(94, 23);
            this.btn_editar.TabIndex = 11;
            this.btn_editar.Text = "Editar Conta";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // GestaoConsultasAgendadasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 271);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbx_consultas);
            this.Name = "GestaoConsultasAgendadasForm";
            this.Text = "GestaoConsultasAgendadas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbx_consultas;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_editar;
    }
}