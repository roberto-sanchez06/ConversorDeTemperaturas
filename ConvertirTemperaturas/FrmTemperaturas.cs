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
            cmbUniTemp.Items.AddRange(Enum.GetValues(typeof(UnidadTemperatura)).Cast<object>().ToArray());
        }
    }
}
