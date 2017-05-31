namespace Prototipo_Não_Funcional_MDS
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
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.txt_procurar = new System.Windows.Forms.TextBox();
            this.lbx_especializacoes = new System.Windows.Forms.ListBox();
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
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(138, 52);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(134, 23);
            this.btn_editar.TabIndex = 25;
            this.btn_editar.Text = "Editar Especialização";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.EventoEditarEspecializacao);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(138, 23);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(134, 23);
            this.btn_adicionar.TabIndex = 24;
            this.btn_adicionar.Text = "Adicionar Especialização";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.EventoAdicionarEspecializacao);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(138, 81);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(134, 23);
            this.btn_eliminar.TabIndex = 23;
            this.btn_eliminar.Text = "Eliminar Especialização";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.EventoEliminarEspecializacao);
            // 
            // txt_procurar
            // 
            this.txt_procurar.Location = new System.Drawing.Point(12, 25);
            this.txt_procurar.Name = "txt_procurar";
            this.txt_procurar.Size = new System.Drawing.Size(120, 20);
            this.txt_procurar.TabIndex = 22;
            this.txt_procurar.TextChanged += new System.EventHandler(this.txt_procurar_TextChanged);
            // 
            // lbx_especializacoes
            // 
            this.lbx_especializacoes.FormattingEnabled = true;
            this.lbx_especializacoes.Items.AddRange(new object[] {
            "Especialização 1",
            "Especialização 2",
            "Especialização 3",
            "Especialização 4",
            "Especialização 5",
            "Especialização 6"});
            this.lbx_especializacoes.Location = new System.Drawing.Point(12, 51);
            this.lbx_especializacoes.Name = "lbx_especializacoes";
            this.lbx_especializacoes.Size = new System.Drawing.Size(120, 186);
            this.lbx_especializacoes.TabIndex = 21;
            this.lbx_especializacoes.SelectedIndexChanged += new System.EventHandler(this.lbx_especializacoes_SelectedIndexChanged);
            // 
            // GestaoEspecializacoesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.txt_procurar);
            this.Controls.Add(this.lbx_especializacoes);
            this.Name = "GestaoEspecializacoesForm";
            this.Text = "GestaoEspecializacoes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.TextBox txt_procurar;
        private System.Windows.Forms.ListBox lbx_especializacoes;
    }
}