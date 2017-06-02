namespace Prototipo_Não_Funcional_MDS
{
    partial class AdicionarConsultaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarConsultaForm));
            this.listBox_pacientes = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_registarConsulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_pacientes
            // 
            this.listBox_pacientes.FormattingEnabled = true;
            this.listBox_pacientes.Items.AddRange(new object[] {
            resources.GetString("listBox_pacientes.Items"),
            resources.GetString("listBox_pacientes.Items1"),
            resources.GetString("listBox_pacientes.Items2"),
            resources.GetString("listBox_pacientes.Items3"),
            resources.GetString("listBox_pacientes.Items4"),
            resources.GetString("listBox_pacientes.Items5")});
            resources.ApplyResources(this.listBox_pacientes, "listBox_pacientes");
            this.listBox_pacientes.Name = "listBox_pacientes";
            this.listBox_pacientes.SelectedIndexChanged += new System.EventHandler(this.listBox_pacientes_SelectedIndexChanged);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // button_registarConsulta
            // 
            resources.ApplyResources(this.button_registarConsulta, "button_registarConsulta");
            this.button_registarConsulta.Name = "button_registarConsulta";
            this.button_registarConsulta.UseVisualStyleBackColor = true;
            this.button_registarConsulta.Click += new System.EventHandler(this.button_registarConsulta_Click);
            // 
            // AdicionarConsultaForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_registarConsulta);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox_pacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdicionarConsultaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_pacientes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_registarConsulta;
    }
}