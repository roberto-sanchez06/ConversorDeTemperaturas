using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ITemperaturaRepository
    {
        void Create(Temperatura temp);
        ICollection<Temperatura> FindAll();
        ICollection<Temperatura> FindAll(Predicate<Temperatura> predicate);
        Temperatura FindAny(Predicate<Temperatura> predicate);
    }
}
