using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IRepositoryAsync<T> : IRepositoryBase<T> where T : class
    {

    }
    public interface IReadRepositoryAsync<T> : IReadRepositoryBase<T> where T : class
    {

    }
}
