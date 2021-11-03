using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;

namespace AppCore.Interfaces
{
    public interface ITemperaturaService
    {
        int GetLastId();
        void Create(TemperaturaConversion temp);
        ICollection<TemperaturaConversion> FindAll();
        ICollection<TemperaturaConversion> FindAll(Predicate<TemperaturaConversion> predicate);
        TemperaturaConversion FindAny(Predicate<TemperaturaConversion> predicate);
    }
}
