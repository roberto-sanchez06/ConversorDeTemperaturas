using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Domain.Interfaces;

namespace Infraestructure
{
    public class TemperaturaRepository : ITemperaturaRepository
    {
        private List<TemperaturaConversion> temperaturas;
        public TemperaturaRepository()
        {
            temperaturas = new List<TemperaturaConversion>();
        }
        public void Create(TemperaturaConversion temp)
        {
            throw new NotImplementedException();
        }

        public ICollection<TemperaturaConversion> FindAll()
        {
            throw new NotImplementedException();
        }

        public ICollection<TemperaturaConversion> FindAll(Predicate<TemperaturaConversion> predicate)
        {
            throw new NotImplementedException();
        }

        public TemperaturaConversion FindAny(Predicate<TemperaturaConversion> predicate)
        {
            throw new NotImplementedException();
        }

        public int GetLastId()
        {
            return temperaturas.Count;
        }
    }
}
