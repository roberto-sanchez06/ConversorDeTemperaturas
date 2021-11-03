using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Domain.Interfaces;

namespace Infraestructure
{
    public class TemperaturaRepository : ITemperaturaRepository
    {
        private List<Temperatura> temperaturas;
        public TemperaturaRepository()
        {
            temperaturas = new List<Temperatura>();
        }
        public void Create(Temperatura temp)
        {
            throw new NotImplementedException();
        }

        public ICollection<Temperatura> FindAll()
        {
            throw new NotImplementedException();
        }

        public ICollection<Temperatura> FindAll(Predicate<Temperatura> predicate)
        {
            throw new NotImplementedException();
        }

        public Temperatura FindAny(Predicate<Temperatura> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
