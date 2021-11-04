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
                temperaturaService.Create(conversion);
                List<TemperaturaConversion> temperaturaConversions = temperaturaService.FindAll().ToList();
                dataGridView1.DataSource = temperaturaConversions;
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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDemos frm = new FrmDemos();
            frm.temperaturaService = temperaturaService;
            frm.ShowDialog();
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
