﻿namespace Prototipo_Não_Funcional_MDS
{
    partial class GestaoEspecializacoesForm
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_adicionarEspecializacao = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(138, 214);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Gestão de Doutores";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(138, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Editar Especialização";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button_adicionarEspecializacao
            // 
            this.button_adicionarEspecializacao.Location = new System.Drawing.Point(138, 23);
            this.button_adicionarEspecializacao.Name = "button_adicionarEspecializacao";
            this.button_adicionarEspecializacao.Size = new System.Drawing.Size(134, 23);
            this.button_adicionarEspecializacao.TabIndex = 24;
            this.button_adicionarEspecializacao.Text = "Adicionar Especialização";
            this.button_adicionarEspecializacao.UseVisualStyleBackColor = true;
            this.button_adicionarEspecializacao.Click += new System.EventHandler(this.button_adicionarEspecializacao_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Eliminar Especialização";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "Procurar Especialização";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Especialização 1",
            "Especialização 2",
            "Especialização 3",
            "Especialização 4",
            "Especialização 5",
            "Especialização 6"});
            this.listBox1.Location = new System.Drawing.Point(12, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 186);
            this.listBox1.TabIndex = 21;
            // 
            // GestaoEspecializacoesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_adicionarEspecializacao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "GestaoEspecializacoesForm";
            this.Text = "GestaoEspecializacoes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_adicionarEspecializacao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}