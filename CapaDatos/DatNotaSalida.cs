using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatNotaSalida
    {
        #region sigleton
        private static readonly DatNotaSalida _instancia = new DatNotaSalida();
        public static DatNotaSalida Instancia
        {
            get
            {
                return DatNotaSalida._instancia;
            }
        }
        #endregion singleton
    }
}
