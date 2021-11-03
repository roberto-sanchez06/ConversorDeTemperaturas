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

        public void Create(TemperaturaConversion temp)
        {
            temperaturaRepository.Create(temp);
        }

        public ICollection<TemperaturaConversion> FindAll()
        {
            return temperaturaRepository.FindAll();
        }

        public ICollection<TemperaturaConversion> FindAll(Predicate<TemperaturaConversion> predicate)
        {
            return temperaturaRepository.FindAll(predicate);
        }

        public TemperaturaConversion FindAny(Predicate<TemperaturaConversion> predicate)
        {
            return temperaturaRepository.FindAny(predicate);
        }

        public int GetLastId()
        {
            return temperaturaRepository.GetLastId();
        }
    }
}
