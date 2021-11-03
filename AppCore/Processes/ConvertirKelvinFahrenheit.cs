using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;

namespace AppCore.Processes
{
    public class ConvertirKelvinFahrenheit : IConversor
    {
        public decimal ConvertirTemperatura(decimal temperatura)
        {
            return ((9*(temperatura-273.15M)) / 5)+32;
        }
    }
}
