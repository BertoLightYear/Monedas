using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Presentacion.Models
{
    public class Moneda
    {
        public Guid Id { get; set; }

        public string Nombre { get; set; }

        public decimal Precio { get; set; }

        public decimal Valor { get; set; }

    }
}