using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;
using AppCore.Processes;
using Domain.Entities;
using Domain.Enums;

namespace AppCore.Factory
{
    public static class FactoryTemperatura
    {
        public static IConversor CrearInstancia(TemperaturaConversion temperaturaConversion)
        {
            if (temperaturaConversion is null)
            {
                throw new ArgumentNullException(nameof(temperaturaConversion));
            }
            switch (temperaturaConversion.UnidadTemperaturaOrigen)
            {
                case UnidadTemperatura.Celsius:
                    if(temperaturaConversion.UnidadTemperaturaConvertida == UnidadTemperatura.Fahrenheit)
                    {
                        return new ConvertirCelsiusFahrenheit();
                    }
                    else if (temperaturaConversion.UnidadTemperaturaConvertida == UnidadTemperatura.Kelvin)
                    {
                        return new ConvertirCelsiusKelvin();
                    }
                    break;
                case UnidadTemperatura.Fahrenheit:
                    if (temperaturaConversion.UnidadTemperaturaConvertida == UnidadTemperatura.Celsius)
                    {
                        return new ConvertirFahrenheitCelsius();
                    }
                    else if (temperaturaConversion.UnidadTemperaturaConvertida == UnidadTemperatura.Kelvin)
                    {
                        return new ConvertirFahrenheitKelvin();
                    }
                    break;
                case UnidadTemperatura.Kelvin:
                    if (temperaturaConversion.UnidadTemperaturaConvertida == UnidadTemperatura.Fahrenheit)
                    {
                        return new ConvertirKelvinFahrenheit();
                    }
                    else if (temperaturaConversion.UnidadTemperaturaConvertida == UnidadTemperatura.Celsius)
                    {
                        return new ConvertirKelvinCelsius();
                    }
                    break;
                default:
                    return null;
            }
            return null;
        }
    }
}
