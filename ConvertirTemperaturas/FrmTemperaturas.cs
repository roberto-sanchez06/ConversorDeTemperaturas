using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCore.Factory;
using AppCore.Interfaces;
using Domain.Entities;
using Domain.Enums;
using System.Runtime.InteropServices;

namespace ConvertirTemperaturas
{
    public partial class FrmTemperaturas : Form
    {
        private ITemperaturaService temperaturaService;
        public FrmTemperaturas(ITemperaturaService temperaturaService)
        {
            this.temperaturaService = temperaturaService;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbUniTempOrigin.Items.AddRange(Enum.GetValues(typeof(UnidadTemperatura)).Cast<object>().ToArray());
            cmbUniTempConver.Items.AddRange(Enum.GetValues(typeof(UnidadTemperatura)).Cast<object>().ToArray());
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                validaciones();
                if (!decimal.TryParse(txtDe.Text, out decimal grados))
                {
                    throw new ArgumentException($"El dato {txtDe.Text} que usted ingreso no es valido");
                }
                TemperaturaConversion conversion = new TemperaturaConversion()
                {
                    Id=temperaturaService.GetLastId()+1,
                    GradosTemperaturaOrigen = grados,
                    UnidadTemperaturaOrigen = (UnidadTemperatura)cmbUniTempOrigin.SelectedIndex,
                    UnidadTemperaturaConvertida = (UnidadTemperatura)cmbUniTempConver.SelectedIndex
                };
                conversion.GradosTemperaturaConvertida = FactoryTemperatura.CrearInstancia(conversion).ConvertirTemperatura(conversion.GradosTemperaturaOrigen);
                txtA.Text = conversion.GradosTemperaturaConvertida.ToString();
                temperaturaService.Create(conversion);
                List<TemperaturaConversion> temperaturaConversions = temperaturaService.FindAll().ToList();
                //dataGridView1.DataSource = temperaturaConversions;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void validaciones()
        {
            if(string.IsNullOrEmpty(txtDe.Text)||cmbUniTempConver.SelectedIndex==-1|| cmbUniTempOrigin.SelectedIndex == -1)
            {
                throw new ArgumentException("Hay campos vacios");
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbHistorial_Click(object sender, EventArgs e)
        {
            FrmDemos frm = new FrmDemos();
            frm.temperaturaService = temperaturaService;
            frm.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnMaxi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaxi.Visible = false;
            btnRestaurar.Visible = true;
        }
        #region mover
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParams);
        #endregion
        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pbConver_Click(object sender, EventArgs e)
        {

        }
        private void ComprobarIgualdad()
        {
            if ((cmbUniTempConver.SelectedIndex == cmbUniTempOrigin.SelectedIndex)
                && (cmbUniTempOrigin.SelectedIndex != -1 && cmbUniTempConver.SelectedIndex != -1))
            {
                if (cmbUniTempConver.SelectedIndex == 2)
                {
                    cmbUniTempConver.SelectedIndex = 0;
                    return;
                }
                if (cmbUniTempOrigin.SelectedIndex == 2)
                {
                    cmbUniTempOrigin.SelectedIndex = 0;
                    return;
                }
                cmbUniTempOrigin.SelectedIndex = cmbUniTempOrigin.SelectedIndex + 1;
            }
        }
        private void cmbUniTempOrigin_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComprobarIgualdad();
            switch (cmbUniTempOrigin.SelectedIndex)
            {
                case -1:
                    pbCelsius.Visible = false;
                    pbFahrenheit.Visible = false;
                    pbKelvin.Visible = false;
                    pbFlecha.Visible = false;
                    break;
                case 0:
                    pbCelsius.Visible = true;
                    pbFahrenheit.Visible = false;
                    pbKelvin.Visible = false;
                    pbFlecha.Visible = true;
                    break;
                case 1:
                    pbCelsius.Visible = false;
                    pbFahrenheit.Visible = true;
                    pbKelvin.Visible = false;
                    pbFlecha.Visible = true;
                    break;
                case 2:
                    pbCelsius.Visible = false;
                    pbFahrenheit.Visible = false;
                    pbKelvin.Visible = true;
                    pbFlecha.Visible = true;
                    break;
            }
        }

        private void cmbUniTempConver_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComprobarIgualdad();
            switch (cmbUniTempConver.SelectedIndex)
            {
                case -1:
                    pbCelsius2.Visible = false;
                    pbFahrenheit2.Visible = false;
                    pbKelvin2.Visible = false;
                    pbFlecha.Visible = false;
                    break;
                case 0:
                    pbCelsius2.Visible = true;
                    pbFahrenheit2.Visible = false;
                    pbKelvin2.Visible = false;
                    pbFlecha.Visible = true;
                    break;
                case 1:
                    pbCelsius2.Visible = false;
                    pbFahrenheit2.Visible = true;
                    pbKelvin2.Visible = false;
                    pbFlecha.Visible = true;
                    break;
                case 2:
                    pbCelsius2.Visible = false;
                    pbFahrenheit2.Visible = false;
                    pbKelvin2.Visible = true;
                    pbFlecha.Visible = true;
                    break;
            }
        }

        private void pbLimpiar_Click(object sender, EventArgs e)
        {
            cmbUniTempConver.SelectedIndex = -1;
            cmbUniTempOrigin.SelectedIndex = -1;
            txtA.Text = string.Empty;
            txtDe.Text = string.Empty;
        }
        //private void cmbUniTempOrigin_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    switch (cmbUniTempOrigin.SelectedIndex)
        //    {
        //        case 0:
        //            cmbUniTempConver.Items.Clear();
        //            cmbUniTempConver.DataSource = Enum.GetValues(typeof(ElegirCelsius));
        //            //cmbUniTempConver.Items.AddRange(Enum.GetValues(typeof(ElegirCelsius)).Cast<object>().ToArray());
        //            break;
        //        case 1:
        //            cmbUniTempConver.Items.Clear();
        //            cmbUniTempConver.DataSource = Enum.GetValues(typeof(ElegirFarenheit));
        //            //cmbUniTempConver.Items.AddRange(Enum.GetValues(typeof(ElegirFarenheit)).Cast<object>().ToArray());
        //            break;
        //        case 2:
        //            cmbUniTempConver.Items.Clear();
        //            cmbUniTempConver.DataSource = Enum.GetValues(typeof(ElegirKelvin));
        //            //cmbUniTempConver.Items.AddRange(Enum.GetValues(typeof(ElegirKelvin)).Cast<object>().ToArray());
        //            break;
        //    }
        //}
    }
}
