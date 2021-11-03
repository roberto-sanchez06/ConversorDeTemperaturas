using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace AppCore.Services
{
    public class TemperaturaService : ITemperaturaService
    {
        private ITemperaturaRepository temperaturaRepository;

        public TemperaturaService(ITemperaturaRepository temperaturaRepository)
        {
            this.temperaturaRepository = temperaturaRepository;
        }

        public void Create(Temperatura temp)
        {
            temperaturaRepository.Create(temp);
        }

        public ICollection<Temperatura> FindAll()
        {
            return temperaturaRepository.FindAll();
        }

        public ICollection<Temperatura> FindAll(Predicate<Temperatura> predicate)
        {
            return temperaturaRepository.FindAll(predicate);
        }

        public Temperatura FindAny(Predicate<Temperatura> predicate)
        {
            return temperaturaRepository.FindAny(predicate);
        }
    }
}
