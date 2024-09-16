using System.Windows.Forms;
using System;

namespace Ejercicio_3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtProducto;
        private TextBox txtVendedor;
        private TextBox txtMonto;
        private Button btnRegistrarVenta;
        private Button btnMostrarResultados;
        private DataGridView dataGridViewResultados;

        private void InitializeComponent()
        {
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.btnMostrarResultados = new System.Windows.Forms.Button();
            this.dataGridViewResultados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(9, 10);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(76, 20);
            this.txtProducto.TabIndex = 0;
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(9, 32);
            this.txtVendedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(76, 20);
            this.txtVendedor.TabIndex = 1;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(9, 55);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(76, 20);
            this.txtMonto.TabIndex = 2;
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Location = new System.Drawing.Point(9, 78);
            this.btnRegistrarVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(99, 27);
            this.btnRegistrarVenta.TabIndex = 3;
            this.btnRegistrarVenta.Text = "Registrar Venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // btnMostrarResultados
            // 
            this.btnMostrarResultados.Location = new System.Drawing.Point(9, 109);
            this.btnMostrarResultados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMostrarResultados.Name = "btnMostrarResultados";
            this.btnMostrarResultados.Size = new System.Drawing.Size(115, 28);
            this.btnMostrarResultados.TabIndex = 4;
            this.btnMostrarResultados.Text = "Mostrar Resultados";
            this.btnMostrarResultados.UseVisualStyleBackColor = true;
            this.btnMostrarResultados.Click += new System.EventHandler(this.btnMostrarResultados_Click);
            // 
            // dataGridViewResultados
            // 
            this.dataGridViewResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultados.Location = new System.Drawing.Point(153, 11);
            this.dataGridViewResultados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewResultados.Name = "dataGridViewResultados";
            this.dataGridViewResultados.RowHeadersWidth = 51;
            this.dataGridViewResultados.RowTemplate.Height = 24;
            this.dataGridViewResultados.Size = new System.Drawing.Size(409, 324);
            this.dataGridViewResultados.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dataGridViewResultados);
            this.Controls.Add(this.btnMostrarResultados);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.txtProducto);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Sistema de Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}