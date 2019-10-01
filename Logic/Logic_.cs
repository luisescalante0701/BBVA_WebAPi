using Common;
using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
   public class Logic_
    {
        static int sCodErrorLogicAPi = 20190001;//-- CODIGO ERROR GENERAL PARA IDENTIFICAR EL ERROR EN LA CAPA LOGICA

        public Model mGetCriterio(ConfigWeb ConfigWeb_)
        {
            Model modeloRpta = new Model();

            try
            {
                string sCMD = "EXEC SAB_TipoBusqueda_Listar";
                modeloRpta = new Data_().mExceBD_SQL(ConfigWeb_, sCMD);
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorLogicAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "Logic_", ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }

            return modeloRpta;
        }

        public Model mGetTipoNegociacion(ConfigWeb ConfigWeb_, int iCodigoOpcion)
        {
            Model modeloRpta = new Model();

            try
            {
                string sCMD = "EXEC [SAB_TipoNegociacion_Listar] '" + iCodigoOpcion + "' ";
                modeloRpta = new Data_().mExceBD_SQL(ConfigWeb_, sCMD);
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorLogicAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "Logic_", ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }

            return modeloRpta;
        }

        public Model mGetTipoOrden(ConfigWeb ConfigWeb_, int iCodigoOpcion)
        {
            Model modeloRpta = new Model();

            try
            {
                string sCMD = "EXEC [SAB_TipoOrden_Listar] '" + iCodigoOpcion + "' ";                
                modeloRpta = new Data_().mExceBD_SQL(ConfigWeb_, sCMD);
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorLogicAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "Logic_", ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }

            return modeloRpta;
        }

        public Model mGetOrden(ConfigWeb ConfigWeb_, int iCodigoOpcion)
        {
            Model modeloRpta = new Model();

            try
            {
                string sCMD = "EXEC [SAB_Orden_Listar] '" + iCodigoOpcion + "' ";
                modeloRpta = new Data_().mExceBD_SQL(ConfigWeb_, sCMD);
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorLogicAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "Logic_", ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }

            return modeloRpta;
        }

        public Model mGetTipoComision(ConfigWeb ConfigWeb_)
        {
            Model modeloRpta = new Model();

            try
            {
                string sCMD = "EXEC SAB_TipoComision_Listar ";
                modeloRpta = new Data_().mExceBD_SQL(ConfigWeb_, sCMD);
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorLogicAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "Logic_", ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }

            return modeloRpta;
        }

        public Model mGetTipoPrecio(ConfigWeb ConfigWeb_)
        {
            Model modeloRpta = new Model();

            try
            {
                string sCMD = "EXEC SAB_TipoPrecio_Listar ";
                modeloRpta = new Data_().mExceBD_SQL(ConfigWeb_, sCMD);
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorLogicAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "Logic_", ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }

            return modeloRpta;
        }

        public Model mGetMoneda(ConfigWeb ConfigWeb_)
        {
            Model modeloRpta = new Model();

            try
            {
                string sCMD = "EXEC SAB_Moneda_Listar ";
                modeloRpta = new Data_().mExceBD_SQL(ConfigWeb_, sCMD);
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorLogicAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "Logic_", ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }

            return modeloRpta;
        }

        public Model mSeleccionarCorreo(ConfigWeb ConfigWeb_)
        {
            Model modeloRpta = new Model();

            try
            {
                string sCMD = "EXEC [SAB_Correo_Seleccionar]";
                modeloRpta = new Data_().mExceBD_SQL(ConfigWeb_, sCMD);
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorLogicAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "Logic_", ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }

            return modeloRpta;
        }

         
        public Model mTraerCorreo(ConfigWeb ConfigWeb_)
        {
            Model modeloRpta = new Model();

            try
            {
                string sCMD = "EXEC [SUA_Correo_Traer]";
                modeloRpta = new Data_().mExceBD_SQL(ConfigWeb_, sCMD);
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorLogicAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "Logic_", ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }

            return modeloRpta;
        }
    }
}
