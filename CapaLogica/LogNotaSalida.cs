﻿using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaLogica
{
    public class LogNotaSalida
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogNotaSalida _instancia = new LogNotaSalida();
        //privado para evitar la instanciación directa
        public static LogNotaSalida Instancia
        {
            get
            {
                return LogNotaSalida._instancia;
            }
        }
        #endregion singleton

        #region metodos

        //LISTAR
        public List<EntNotaSalida> ListarNotaSalida()
        {
            return DatNotaSalida.Instancia.ListarNotaSalida();
        }
        //INSERTAR
        public void InsertarNotaSalida(EntNotaSalida ns)
        {
            DatNotaSalida.Instancia.InsertarNotaSalida(ns);
        }

        //EDITAR
        /*
        public void EditarNotaSalida(EntNotaSalida ns)
        {
            DatNotaSalida.Instancia.EditarNotaSalida(ns);
        }*/
        
        //ELIMINAR
        public void AnularNotaSalida(EntNotaSalida ns)
        {
            DatNotaSalida.Instancia.AnularNotaSalida(ns);
        }
        #endregion metodos;
    }
}
