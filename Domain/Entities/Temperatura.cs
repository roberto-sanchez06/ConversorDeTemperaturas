using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;

namespace Domain.Entities
{
    public class Temperatura
    {
        public decimal Grados { get; set; }
        public UnidadTemperatura UnidadTemperatura { get; set; }
    }
}
