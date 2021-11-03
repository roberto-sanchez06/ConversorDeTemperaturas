
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
            this.txtGradosOrigen = new System.Windows.Forms.TextBox();
            this.cmbUniTempOrigin = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.cmbUniTempConver = new System.Windows.Forms.ComboBox();
            this.txtGradosConvertidos = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGradosOrigen
            // 
            this.txtGradosOrigen.Location = new System.Drawing.Point(3, 51);
            this.txtGradosOrigen.Name = "txtGradosOrigen";
            this.txtGradosOrigen.Size = new System.Drawing.Size(214, 20);
            this.txtGradosOrigen.TabIndex = 0;
            // 
            // cmbUniTempOrigin
            // 
            this.cmbUniTempOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUniTempOrigin.FormattingEnabled = true;
            this.cmbUniTempOrigin.Location = new System.Drawing.Point(245, 50);
            this.cmbUniTempOrigin.Name = "cmbUniTempOrigin";
            this.cmbUniTempOrigin.Size = new System.Drawing.Size(230, 21);
            this.cmbUniTempOrigin.TabIndex = 1;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(517, 49);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(130, 23);
            this.btnConvertir.TabIndex = 2;
            this.btnConvertir.Text = "Convetitr";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // cmbUniTempConver
            // 
            this.cmbUniTempConver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUniTempConver.FormattingEnabled = true;
            this.cmbUniTempConver.Location = new System.Drawing.Point(245, 76);
            this.cmbUniTempConver.Name = "cmbUniTempConver";
            this.cmbUniTempConver.Size = new System.Drawing.Size(230, 21);
            this.cmbUniTempConver.TabIndex = 3;
            // 
            // txtGradosConvertidos
            // 
            this.txtGradosConvertidos.Location = new System.Drawing.Point(3, 77);
            this.txtGradosConvertidos.Name = "txtGradosConvertidos";
            this.txtGradosConvertidos.Size = new System.Drawing.Size(214, 20);
            this.txtGradosConvertidos.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 265);
            this.dataGridView1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtGradosOrigen);
            this.panel1.Controls.Add(this.txtGradosConvertidos);
            this.panel1.Controls.Add(this.cmbUniTempOrigin);
            this.panel1.Controls.Add(this.btnConvertir);
            this.panel1.Controls.Add(this.cmbUniTempConver);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 111);
            this.panel1.TabIndex = 6;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.DodgerBlue;
            this.Header.Controls.Add(this.label1);
            this.Header.Location = new System.Drawing.Point(12, 12);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(776, 45);
            this.Header.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(254, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversor de temperaturas";
            // 
            // FrmTemperaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmTemperaturas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtGradosOrigen;
        private System.Windows.Forms.ComboBox cmbUniTempOrigin;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.ComboBox cmbUniTempConver;
        private System.Windows.Forms.TextBox txtGradosConvertidos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label label1;
    }
}

