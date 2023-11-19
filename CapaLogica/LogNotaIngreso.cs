using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaLogica
{
    public class LogNotaIngreso
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogNotaIngreso _instancia = new LogNotaIngreso();
        //privado para evitar la instanciación directa
        public static LogNotaIngreso Instancia
        {
            get
            {
                return LogNotaIngreso._instancia;
            }
        }
        #endregion singleton

        #region metodos

        //LISTAR
        public List<EntNotaIngreso> ListarNotaIngreso()
        {
            return DatNotaIngreso.Instancia.ListarNotaIngreso();
        }
        //INSERTAR
        public void InsertarNotaIngreso(EntNotaIngreso ni)
        {
            DatNotaIngreso.Instancia.InsertarNotaIngreso(ni);
        }

        //EDITARR
        /*
        public void EditarNotaIngreso(EntNotaIngreso ni)
        {
            DatNotaIngreso.Instancia.EditarNotaIngreso(ni);
        }*/

        //ELIMINAR
        public void AnularNotaIngreso(EntNotaIngreso ni)
        {
            DatNotaIngreso.Instancia.AnularNotaIngreso(ni);
        }

        //LEER
        public List<EntNotaIngreso> LeerNotaIngreso()
        {
            return DatNotaIngreso.Instancia.LeerNotaIngreso();
        }
        #endregion metodos;
    }
}
