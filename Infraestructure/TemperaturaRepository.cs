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
            if (temp is null)
            {
                throw new ArgumentNullException(nameof(temp));
            }

            temperaturas.Add(temp);
        }

        public ICollection<TemperaturaConversion> FindAll()
        {
            return temperaturas;
        }

        public ICollection<TemperaturaConversion> FindAll(Predicate<TemperaturaConversion> predicate)
        {
            return temperaturas.FindAll(predicate);
        }

        public TemperaturaConversion FindAny(Predicate<TemperaturaConversion> predicate)
        {
            return temperaturas.Find(predicate);
        }

        public int GetLastId()
        {
            return temperaturas.Count;
        }
    }
}
