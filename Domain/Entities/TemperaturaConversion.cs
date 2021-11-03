using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;

namespace Domain.Entities
{
    public class TemperaturaConversion
    {
        public int Id { get; set; }
        public decimal GradosTemperaturaOrigen { get; set; }
        public UnidadTemperatura UnidadTemperaturaOrigen { get; set; }
        public decimal GradosTemperaturaConvertida { get; set; }
        public UnidadTemperatura UnidadTemperaturaConvertida { get; set; }
    }
}
