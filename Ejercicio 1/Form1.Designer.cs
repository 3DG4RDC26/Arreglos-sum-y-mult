namespace Ejercicio_1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstConteoSumas;
        private System.Windows.Forms.Button btnLanzarDados;
        private System.Windows.Forms.Label lblDado1;
        private System.Windows.Forms.Label lblDado2;
        private System.Windows.Forms.Label lblSuma;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstConteoSumas = new System.Windows.Forms.ListBox();
            this.btnLanzarDados = new System.Windows.Forms.Button();
            this.lblDado1 = new System.Windows.Forms.Label();
            this.lblDado2 = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstConteoSumas
            // 
            this.lstConteoSumas.FormattingEnabled = true;
            this.lstConteoSumas.Location = new System.Drawing.Point(12, 154);
            this.lstConteoSumas.Name = "lstConteoSumas";
            this.lstConteoSumas.Size = new System.Drawing.Size(208, 173);
            this.lstConteoSumas.TabIndex = 1;
            // 
            // btnLanzarDados
            // 
            this.btnLanzarDados.Image = global::Ejercicio_1.Properties.Resources.dado;
            this.btnLanzarDados.Location = new System.Drawing.Point(56, 100);
            this.btnLanzarDados.Name = "btnLanzarDados";
            this.btnLanzarDados.Size = new System.Drawing.Size(101, 35);
            this.btnLanzarDados.TabIndex = 2;
            this.btnLanzarDados.UseVisualStyleBackColor = true;
            this.btnLanzarDados.Click += new System.EventHandler(this.btnLanzarDados_Click);
            // 
            // lblDado1
            // 
            this.lblDado1.AutoSize = true;
            this.lblDado1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDado1.Location = new System.Drawing.Point(27, 35);
            this.lblDado1.Name = "lblDado1";
            this.lblDado1.Size = new System.Drawing.Size(51, 15);
            this.lblDado1.TabIndex = 3;
            this.lblDado1.Text = "Dado 1: ";
            // 
            // lblDado2
            // 
            this.lblDado2.AutoSize = true;
            this.lblDado2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDado2.Location = new System.Drawing.Point(135, 37);
            this.lblDado2.Name = "lblDado2";
            this.lblDado2.Size = new System.Drawing.Size(51, 15);
            this.lblDado2.TabIndex = 4;
            this.lblDado2.Text = "Dado 2: ";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma.Location = new System.Drawing.Point(78, 72);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(67, 15);
            this.lblSuma.TabIndex = 5;
            this.lblSuma.Text = "Resultado: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lanzar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(247, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.lblDado2);
            this.Controls.Add(this.lblDado1);
            this.Controls.Add(this.btnLanzarDados);
            this.Controls.Add(this.lstConteoSumas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Simulador de Dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
    }
}