using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Parameters
{
    public class GetAllClientesParameters : RequestParameter
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }
    }
}
