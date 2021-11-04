using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCore.Interfaces;
using Domain.Entities;
using System.Runtime.InteropServices;

namespace ConvertirTemperaturas
{
    public partial class FrmDemos : Form
    {
        public ITemperaturaService temperaturaService { get; set; }
        public FrmDemos()
        {
            InitializeComponent();
        }

        private void FrmDemos_Load(object sender, EventArgs e)
        {
            dtgHistorial.ReadOnly = true;
            dtgHistorial.DataSource = temperaturaService.FindAll();
            //foreach(TemperaturaConversion temp in temperaturaService.FindAll())
            //{
            //    dtgHistorial.Rows.Add(temp.Id, temp.GradosTemperaturaOrigen,temp.UnidadTemperaturaOrigen, temp.GradosTemperaturaConvertida, temp.UnidadTemperaturaConvertida);
            //}
            //poner todas las columnas en readonly
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtgHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaxi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaxi.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaxi.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #region mover
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParams);
        #endregion

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012,0);
        }
    }
}
