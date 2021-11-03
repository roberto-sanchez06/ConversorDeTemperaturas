using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;

namespace AppCore.Interfaces
{
    public interface ITemperaturaService
    {
        void Create(Temperatura temp);
        ICollection<Temperatura> FindAll();
        ICollection<Temperatura> FindAll(Predicate<Temperatura> predicate);
        Temperatura FindAny(Predicate<Temperatura> predicate);
    }
}
