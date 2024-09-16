namespace Ejercicio_2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.rdoSmoking = new System.Windows.Forms.RadioButton();
            this.rdoNonSmoking = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblBoardingPass = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Por favor selecciona tu preferencia de asiento:";
            // 
            // rdoSmoking
            // 
            this.rdoSmoking.AutoSize = true;
            this.rdoSmoking.Location = new System.Drawing.Point(80, 49);
            this.rdoSmoking.Margin = new System.Windows.Forms.Padding(2);
            this.rdoSmoking.Name = "rdoSmoking";
            this.rdoSmoking.Size = new System.Drawing.Size(54, 17);
            this.rdoSmoking.TabIndex = 1;
            this.rdoSmoking.TabStop = true;
            this.rdoSmoking.Text = "Fumar";
            this.rdoSmoking.UseVisualStyleBackColor = true;
            // 
            // rdoNonSmoking
            // 
            this.rdoNonSmoking.AutoSize = true;
            this.rdoNonSmoking.Location = new System.Drawing.Point(80, 91);
            this.rdoNonSmoking.Margin = new System.Windows.Forms.Padding(2);
            this.rdoNonSmoking.Name = "rdoNonSmoking";
            this.rdoNonSmoking.Size = new System.Drawing.Size(71, 17);
            this.rdoNonSmoking.TabIndex = 2;
            this.rdoNonSmoking.TabStop = true;
            this.rdoNonSmoking.Text = "No Fumar";
            this.rdoNonSmoking.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(80, 124);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 24);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Asignar Asiento";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblBoardingPass
            // 
            this.lblBoardingPass.AutoSize = true;
            this.lblBoardingPass.Location = new System.Drawing.Point(38, 166);
            this.lblBoardingPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBoardingPass.Name = "lblBoardingPass";
            this.lblBoardingPass.Size = new System.Drawing.Size(0, 13);
            this.lblBoardingPass.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Ejercicio_2.Properties.Resources.Fumar;
            this.pictureBox1.Location = new System.Drawing.Point(38, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 33);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Ejercicio_2.Properties.Resources.No_fumar;
            this.pictureBox2.Location = new System.Drawing.Point(38, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 33);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 219);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBoardingPass);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rdoNonSmoking);
            this.Controls.Add(this.rdoSmoking);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Elegir Asiento";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoSmoking;
        private System.Windows.Forms.RadioButton rdoNonSmoking;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblBoardingPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}