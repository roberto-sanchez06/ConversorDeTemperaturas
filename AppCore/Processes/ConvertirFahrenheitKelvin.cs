using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;

namespace AppCore.Processes
{
    public class ConvertirFahrenheitKelvin : IConversor
    {
        public decimal ConvertirTemperatura(decimal temperatura)
        {
            return (5*(temperatura-32)/9)+273.15M;
        }
    }
}
