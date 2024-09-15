namespace Ejercicio_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnTirarDados = new System.Windows.Forms.Button();
            this.lblDado1 = new System.Windows.Forms.Label();
            this.lblDado2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTirarDados
            // 
            this.btnTirarDados.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTirarDados.Image = global::Ejercicio_1.Properties.Resources.dado;
            this.btnTirarDados.Location = new System.Drawing.Point(91, 118);
            this.btnTirarDados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTirarDados.Name = "btnTirarDados";
            this.btnTirarDados.Size = new System.Drawing.Size(61, 42);
            this.btnTirarDados.TabIndex = 0;
            this.btnTirarDados.UseVisualStyleBackColor = true;
            this.btnTirarDados.Click += new System.EventHandler(this.btnTirarDados_Click);
            // 
            // lblDado1
            // 
            this.lblDado1.AutoSize = true;
            this.lblDado1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDado1.Location = new System.Drawing.Point(51, 49);
            this.lblDado1.Name = "lblDado1";
            this.lblDado1.Size = new System.Drawing.Size(48, 15);
            this.lblDado1.TabIndex = 1;
            this.lblDado1.Text = "Dado 1:";
            // 
            // lblDado2
            // 
            this.lblDado2.AutoSize = true;
            this.lblDado2.ForeColor = System.Drawing.Color.Black;
            this.lblDado2.Location = new System.Drawing.Point(134, 49);
            this.lblDado2.Name = "lblDado2";
            this.lblDado2.Size = new System.Drawing.Size(48, 15);
            this.lblDado2.TabIndex = 2;
            this.lblDado2.Text = "Dado 2:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(88, 86);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(64, 15);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Resultado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lanzar dados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 231);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblDado2);
            this.Controls.Add(this.lblDado1);
            this.Controls.Add(this.btnTirarDados);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Girar Dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTirarDados;
        private System.Windows.Forms.Label lblDado1;
        private System.Windows.Forms.Label lblDado2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label4;
    }
}

