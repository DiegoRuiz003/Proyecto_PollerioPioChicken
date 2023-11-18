using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatNotaIngreso
    {
        #region sigleton
        private static readonly DatNotaIngreso _instancia = new DatNotaIngreso();
        public static DatNotaIngreso Instancia
        {
            get
            {
                return DatNotaIngreso._instancia;
            }
        }
        #endregion singleton
    }
}
