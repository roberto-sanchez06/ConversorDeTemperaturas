﻿
namespace ConvertirTemperaturas
{
    partial class FrmTemperaturas
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbUniTemp = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 0;
            // 
            // cmbUniTemp
            // 
            this.cmbUniTemp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUniTemp.FormattingEnabled = true;
            this.cmbUniTemp.Location = new System.Drawing.Point(271, 10);
            this.cmbUniTemp.Name = "cmbUniTemp";
            this.cmbUniTemp.Size = new System.Drawing.Size(230, 21);
            this.cmbUniTemp.TabIndex = 1;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(552, 8);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(130, 23);
            this.btnConvertir.TabIndex = 2;
            this.btnConvertir.Text = "Convetitr";
            this.btnConvertir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.cmbUniTemp);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbUniTemp;
        private System.Windows.Forms.Button btnConvertir;
    }
}

