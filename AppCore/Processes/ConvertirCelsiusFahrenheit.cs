using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;

namespace AppCore.Processes
{
    public class ConvertirCelsiusFahrenheit : IConversor
    {
        public decimal ConvertirTemperatura(decimal temperatura)
        {
            return (9 / 5) * temperatura + 32;
        }
    }
}
