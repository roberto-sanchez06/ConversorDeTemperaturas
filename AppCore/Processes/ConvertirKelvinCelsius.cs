using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;

namespace AppCore.Processes
{
    public class ConvertirKelvinCelsius : IConversor
    {
        public decimal ConvertirTemperatura(decimal temperatura)
        {
            return temperatura - 273.15M;
        }
    }
}
