using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntNotaSalida
    {
        public int IdInsumo { get; set; }
        public string Insumo { get; set; }
        public int Cantidad { get; set; }
        public DateTime FecRegSolicitud { get; set; }
        public Boolean Estado { get; set; }
    }
}
