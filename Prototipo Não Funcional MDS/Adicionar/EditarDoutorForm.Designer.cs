namespace Prototipo_Não_Funcional_MDS
{
    partial class EditarDoutorForm
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
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.dt_dataNasc = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clbx_especializacoes = new System.Windows.Forms.CheckedListBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.dt_checkout = new System.Windows.Forms.DateTimePicker();
            this.dt_checkin = new System.Windows.Forms.DateTimePicker();
            this.txt_nif = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(110, 142);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(160, 20);
            this.txt_telefone.TabIndex = 61;
            // 
            // dt_dataNasc
            // 
            this.dt_dataNasc.Location = new System.Drawing.Point(110, 168);
            this.dt_dataNasc.Name = "dt_dataNasc";
            this.dt_dataNasc.Size = new System.Drawing.Size(160, 20);
            this.dt_dataNasc.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Data Nascimento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Especializações:";
            // 
            // clbx_especializacoes
            // 
            this.clbx_especializacoes.FormattingEnabled = true;
            this.clbx_especializacoes.Location = new System.Drawing.Point(293, 28);
            this.clbx_especializacoes.Name = "clbx_especializacoes";
            this.clbx_especializacoes.Size = new System.Drawing.Size(146, 154);
            this.clbx_especializacoes.TabIndex = 56;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(364, 198);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 55;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // dt_checkout
            // 
            this.dt_checkout.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_checkout.Location = new System.Drawing.Point(110, 116);
            this.dt_checkout.Name = "dt_checkout";
            this.dt_checkout.ShowUpDown = true;
            this.dt_checkout.Size = new System.Drawing.Size(160, 20);
            this.dt_checkout.TabIndex = 54;
            // 
            // dt_checkin
            // 
            this.dt_checkin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_checkin.Location = new System.Drawing.Point(110, 90);
            this.dt_checkin.Name = "dt_checkin";
            this.dt_checkin.ShowUpDown = true;
            this.dt_checkin.Size = new System.Drawing.Size(160, 20);
            this.dt_checkin.TabIndex = 53;
            // 
            // txt_nif
            // 
            this.txt_nif.Location = new System.Drawing.Point(110, 64);
            this.txt_nif.Name = "txt_nif";
            this.txt_nif.Size = new System.Drawing.Size(160, 20);
            this.txt_nif.TabIndex = 52;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(110, 38);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(160, 20);
            this.txt_email.TabIndex = 51;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(110, 12);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(160, 20);
            this.txt_nome.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Check Out:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Check In:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "NIF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "E-mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Nome:";
            // 
            // EditarDoutorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 232);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.dt_dataNasc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clbx_especializacoes);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.dt_checkout);
            this.Controls.Add(this.dt_checkin);
            this.Controls.Add(this.txt_nif);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditarDoutorForm";
            this.Text = "EditarDoutorForm";
            this.Load += new System.EventHandler(this.EditarDoutorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.DateTimePicker dt_dataNasc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox clbx_especializacoes;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.DateTimePicker dt_checkout;
        private System.Windows.Forms.DateTimePicker dt_checkin;
        private System.Windows.Forms.TextBox txt_nif;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}