namespace Prototipo_Não_Funcional_MDS
{
    partial class AdicionarFuncionarioForm
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
            this.tbx_email = new System.Windows.Forms.TextBox();
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_dataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_numTelefo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_nif = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 218);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 25;
            this.button1.Text = "Registar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.EventoAdicionarUtilizador);
            // 
            // tbx_email
            // 
            this.tbx_email.Location = new System.Drawing.Point(141, 80);
            this.tbx_email.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_email.Name = "tbx_email";
            this.tbx_email.Size = new System.Drawing.Size(343, 22);
            this.tbx_email.TabIndex = 21;
            // 
            // tbx_nome
            // 
            this.tbx_nome.Location = new System.Drawing.Point(141, 44);
            this.tbx_nome.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(343, 22);
            this.tbx_nome.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "E-mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(478, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "A password do funcionario é gerada e enviada para o email do funcionário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Data Nascimento:";
            // 
            // dateTimePicker_dataNascimento
            // 
            this.dateTimePicker_dataNascimento.Location = new System.Drawing.Point(143, 126);
            this.dateTimePicker_dataNascimento.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_dataNascimento.Name = "dateTimePicker_dataNascimento";
            this.dateTimePicker_dataNascimento.Size = new System.Drawing.Size(212, 22);
            this.dateTimePicker_dataNascimento.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Numero de telefone:";
            // 
            // textBox_numTelefo
            // 
            this.textBox_numTelefo.Location = new System.Drawing.Point(143, 173);
            this.textBox_numTelefo.Name = "textBox_numTelefo";
            this.textBox_numTelefo.Size = new System.Drawing.Size(132, 22);
            this.textBox_numTelefo.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "NIF:";
            // 
            // textBox_nif
            // 
            this.textBox_nif.Location = new System.Drawing.Point(320, 170);
            this.textBox_nif.Name = "textBox_nif";
            this.textBox_nif.Size = new System.Drawing.Size(132, 22);
            this.textBox_nif.TabIndex = 40;
            // 
            // AdicionarFuncionarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 259);
            this.Controls.Add(this.textBox_nif);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_numTelefo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker_dataNascimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbx_email);
            this.Controls.Add(this.tbx_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdicionarFuncionarioForm";
            this.Text = "AdicionarFuncionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbx_email;
        private System.Windows.Forms.TextBox tbx_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dataNascimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_numTelefo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_nif;
    }
}