
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
            this.cmbUniTempOrigin = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.cmbUniTempConver = new System.Windows.Forms.ComboBox();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMostrarHistorial = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.lblAcciones = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConvertir = new System.Windows.Forms.Label();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.pbHistorial = new System.Windows.Forms.PictureBox();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.pbConver = new System.Windows.Forms.PictureBox();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.gpbDatosConversion = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConver)).BeginInit();
            this.gpbDatosConversion.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbUniTempOrigin
            // 
            this.cmbUniTempOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUniTempOrigin.FormattingEnabled = true;
            this.cmbUniTempOrigin.Location = new System.Drawing.Point(168, 37);
            this.cmbUniTempOrigin.Name = "cmbUniTempOrigin";
            this.cmbUniTempOrigin.Size = new System.Drawing.Size(230, 32);
            this.cmbUniTempOrigin.TabIndex = 1;
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConvertir.Location = new System.Drawing.Point(271, 269);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(130, 31);
            this.btnConvertir.TabIndex = 2;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // cmbUniTempConver
            // 
            this.cmbUniTempConver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUniTempConver.FormattingEnabled = true;
            this.cmbUniTempConver.Location = new System.Drawing.Point(168, 85);
            this.cmbUniTempConver.Name = "cmbUniTempConver";
            this.cmbUniTempConver.Size = new System.Drawing.Size(230, 32);
            this.cmbUniTempConver.TabIndex = 3;
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Franklin Gothic Heavy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEncabezado.Location = new System.Drawing.Point(309, 21);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(363, 34);
            this.lblEncabezado.TabIndex = 0;
            this.lblEncabezado.Text = "Conversor de temperaturas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Convertir de";
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(100, 147);
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(100, 29);
            this.txtDe.TabIndex = 9;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(252, 156);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 29);
            this.txtA.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(236, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(146, 82);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnMostrarHistorial
            // 
            this.btnMostrarHistorial.Location = new System.Drawing.Point(303, 234);
            this.btnMostrarHistorial.Name = "btnMostrarHistorial";
            this.btnMostrarHistorial.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarHistorial.TabIndex = 12;
            this.btnMostrarHistorial.Text = "Ver Historial";
            this.btnMostrarHistorial.UseVisualStyleBackColor = true;
            this.btnMostrarHistorial.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.lblHistorial);
            this.panel2.Controls.Add(this.pbHistorial);
            this.panel2.Controls.Add(this.lblCerrar);
            this.panel2.Controls.Add(this.pbCerrar);
            this.panel2.Controls.Add(this.lblConvertir);
            this.panel2.Controls.Add(this.pnlAcciones);
            this.panel2.Controls.Add(this.pbConver);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 476);
            this.panel2.TabIndex = 14;
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pnlAcciones.Controls.Add(this.label1);
            this.pnlAcciones.Controls.Add(this.lblAcciones);
            this.pnlAcciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAcciones.Location = new System.Drawing.Point(0, 0);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(200, 69);
            this.pnlAcciones.TabIndex = 0;
            // 
            // lblAcciones
            // 
            this.lblAcciones.AutoSize = true;
            this.lblAcciones.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcciones.ForeColor = System.Drawing.Color.White;
            this.lblAcciones.Location = new System.Drawing.Point(44, 19);
            this.lblAcciones.Name = "lblAcciones";
            this.lblAcciones.Size = new System.Drawing.Size(111, 37);
            this.lblAcciones.TabIndex = 15;
            this.lblAcciones.Text = "Acciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Acciones";
            // 
            // lblConvertir
            // 
            this.lblConvertir.AutoSize = true;
            this.lblConvertir.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvertir.ForeColor = System.Drawing.Color.White;
            this.lblConvertir.Location = new System.Drawing.Point(46, 169);
            this.lblConvertir.Name = "lblConvertir";
            this.lblConvertir.Size = new System.Drawing.Size(94, 30);
            this.lblConvertir.TabIndex = 17;
            this.lblConvertir.Text = "Convertir";
            // 
            // lblCerrar
            // 
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrar.ForeColor = System.Drawing.Color.White;
            this.lblCerrar.Location = new System.Drawing.Point(59, 437);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(69, 30);
            this.lblCerrar.TabIndex = 18;
            this.lblCerrar.Text = "Cerrar";
            // 
            // pbHistorial
            // 
            this.pbHistorial.Image = global::ConvertirTemperaturas.Properties.Resources.historial_medico;
            this.pbHistorial.Location = new System.Drawing.Point(31, 222);
            this.pbHistorial.Name = "pbHistorial";
            this.pbHistorial.Size = new System.Drawing.Size(141, 78);
            this.pbHistorial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHistorial.TabIndex = 15;
            this.pbHistorial.TabStop = false;
            this.pbHistorial.Click += new System.EventHandler(this.pbHistorial_Click);
            // 
            // pbCerrar
            // 
            this.pbCerrar.Image = global::ConvertirTemperaturas.Properties.Resources.cerrar__1_;
            this.pbCerrar.Location = new System.Drawing.Point(31, 353);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(125, 81);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCerrar.TabIndex = 15;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // pbConver
            // 
            this.pbConver.Image = global::ConvertirTemperaturas.Properties.Resources.temperatura;
            this.pbConver.Location = new System.Drawing.Point(35, 75);
            this.pbConver.Name = "pbConver";
            this.pbConver.Size = new System.Drawing.Size(106, 91);
            this.pbConver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConver.TabIndex = 13;
            this.pbConver.TabStop = false;
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorial.ForeColor = System.Drawing.Color.White;
            this.lblHistorial.Location = new System.Drawing.Point(39, 311);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(117, 30);
            this.lblHistorial.TabIndex = 19;
            this.lblHistorial.Text = "Ver historial";
            // 
            // gpbDatosConversion
            // 
            this.gpbDatosConversion.BackColor = System.Drawing.Color.SteelBlue;
            this.gpbDatosConversion.Controls.Add(this.cmbUniTempOrigin);
            this.gpbDatosConversion.Controls.Add(this.cmbUniTempConver);
            this.gpbDatosConversion.Controls.Add(this.label3);
            this.gpbDatosConversion.Controls.Add(this.label2);
            this.gpbDatosConversion.Controls.Add(this.txtDe);
            this.gpbDatosConversion.Controls.Add(this.txtA);
            this.gpbDatosConversion.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatosConversion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpbDatosConversion.Location = new System.Drawing.Point(472, 75);
            this.gpbDatosConversion.Name = "gpbDatosConversion";
            this.gpbDatosConversion.Size = new System.Drawing.Size(410, 200);
            this.gpbDatosConversion.TabIndex = 15;
            this.gpbDatosConversion.TabStop = false;
            this.gpbDatosConversion.Text = "Conversor de Temperatura";
            // 
            // FrmTemperaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 476);
            this.Controls.Add(this.gpbDatosConversion);
            this.Controls.Add(this.lblEncabezado);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnMostrarHistorial);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnConvertir);
            this.Name = "FrmTemperaturas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlAcciones.ResumeLayout(false);
            this.pnlAcciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConver)).EndInit();
            this.gpbDatosConversion.ResumeLayout(false);
            this.gpbDatosConversion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbUniTempOrigin;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.ComboBox cmbUniTempConver;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMostrarHistorial;
        private System.Windows.Forms.PictureBox pbConver;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Label lblAcciones;
        private System.Windows.Forms.Label lblConvertir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.PictureBox pbHistorial;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.GroupBox gpbDatosConversion;
    }
}

