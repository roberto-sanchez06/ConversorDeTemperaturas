
namespace ConvertirTemperaturas
{
    partial class FrmHistorialTemperaturas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadDeTemperaturaOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kelvin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fahrenheit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celsius = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.UnidadDeTemperaturaOrigen,
            this.Kelvin,
            this.Fahrenheit,
            this.Celsius});
            this.dataGridView1.Location = new System.Drawing.Point(102, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 172);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // UnidadDeTemperaturaOrigen
            // 
            this.UnidadDeTemperaturaOrigen.HeaderText = "UnidadDeTemperaturaOrigen";
            this.UnidadDeTemperaturaOrigen.Name = "UnidadDeTemperaturaOrigen";
            this.UnidadDeTemperaturaOrigen.ReadOnly = true;
            this.UnidadDeTemperaturaOrigen.Width = 200;
            // 
            // Kelvin
            // 
            this.Kelvin.HeaderText = "Kelvin";
            this.Kelvin.Name = "Kelvin";
            this.Kelvin.ReadOnly = true;
            // 
            // Fahrenheit
            // 
            this.Fahrenheit.HeaderText = "Fahrenheit";
            this.Fahrenheit.Name = "Fahrenheit";
            this.Fahrenheit.ReadOnly = true;
            // 
            // Celsius
            // 
            this.Celsius.HeaderText = "Celsius";
            this.Celsius.Name = "Celsius";
            this.Celsius.ReadOnly = true;
            // 
            // FrmHistorialTemperaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmHistorialTemperaturas";
            this.Text = "FrmHistorialTemperaturas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadDeTemperaturaOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kelvin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fahrenheit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celsius;
    }
}