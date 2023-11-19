﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntNotaIngreso
    {
        public int IdProducto { get; set; }
        public string Producto { get; set; }
        public string Proveedor { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public DateTime FecRegInsumo { get; set; }
        public Boolean Estado { get; set; }
    }
}
