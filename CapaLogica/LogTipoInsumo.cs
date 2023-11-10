using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaLogica
{
    public class LogTipoInsumo
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogTipoInsumo _instancia = new LogTipoInsumo();
        //privado para evitar la instanciación directa
        public static LogTipoInsumo Instancia
        {
            get
            {
                return LogTipoInsumo._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ///listado

        public List<EntTipoInsumo> ListarTipoInsumo()
        {
            return DatTipoInsumo.Instancia.ListarTipoInsumo();
        }
        ///inserta
        public void InsertarTipoInsumo(EntTipoInsumo tipoInsumo)
        {
            DatTipoInsumo.Instancia.InsertarTipoInsumo(tipoInsumo);
        }
        //edita
        public void EditarTipoInsumo(EntTipoInsumo tipoInsumo)
        {
            DatTipoInsumo.Instancia.EditarTipoInsumo(tipoInsumo);
        }
        public void DeshabilitarTipoInsumo(EntTipoInsumo tipoInsumo)
        {
            DatTipoInsumo.Instancia.DeshabilitarTipoInsumo(tipoInsumo);
        }
        #endregion metodos


    }
}
