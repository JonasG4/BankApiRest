using Ardalis.Specification;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Specifications
{
    public class PagedClientesSpecification : Specification<Cliente>
    {
        public PagedClientesSpecification(int pageSize, int pageNumber, string nombre, string apellido, string dui, String nit)
        {
            Query.Skip((pageNumber - 1) * pageSize)
                .Take(pageSize);

            if (!string.IsNullOrEmpty(nombre))
                Query.Search(x => x.Nombre, "%" + nombre + "%");

            if (!string.IsNullOrEmpty(apellido))
                Query.Search(x => x.Apellido, "%" + apellido + "%");

            if (!string.IsNullOrEmpty(dui))
                Query.Search(x => x.DUI, "%" + dui + "%");

            if (!string.IsNullOrEmpty(nit))
                Query.Search(x => x.NIT, "%" + nit + "%");
        }
    }
}
