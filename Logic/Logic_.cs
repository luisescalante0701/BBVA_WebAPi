using Common;
using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Class1 = Entity.Class1;

namespace Logic
{
   public class Logic_
    {
        static int sCodErrorLogicAPi = 20190001;//-- CODIGO ERROR GENERAL PARA IDENTIFICAR EL ERROR EN LA CAPA LOGICA

        #region MaestroDA
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

        public Model mListarRutaCarpeta(ConfigWeb ConfigWeb_)
        {
            Model modeloRpta = new Model();

            try
            {
                string sCMD = "EXEC SAB_RutaCarpeta_Listar ";
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

        public Model mNombreTipoOrden(ConfigWeb ConfigWeb_, string strCodigo)
        {
            Model modeloRpta = new Model();

            try
            {
                string sCMD = "EXEC [SAB_TipoOrden_RetornaNombre]'" + strCodigo + "'";
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

        public Model mDescripcionMoneda(ConfigWeb ConfigWeb_, string strCodigo)
        {
            Model modeloRpta = new Model();

            try
            {
                string sCMD = "EXEC [SAB_Moneda_RetornaNombre]'" + strCodigo + "'";
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

        public Model mNombreTipoComision(ConfigWeb ConfigWeb_, string strCodigo)
        {
            Model modeloRpta = new Model();

            try
            {
                string sCMD = "EXEC [SAB_TipoComision_RetornaNombre]'" + strCodigo + "'";
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

        public Model mGuardarLogTrafico(ConfigWeb ConfigWeb_, string strTipo, string strIp, string strConError, string strMensaje)
        {
            Model modeloRpta = new Model();

            try
            {
                string sCMD = "EXEC [SAB_LogTrafico_Insertar]'" + strTipo + "''" + strIp + "''" + strConError + "''" + strMensaje + "'";
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
        #endregion

        #region NemonicoDA
        public Model mListarN(ConfigWeb ConfigWeb_, string strNemotico, Nemonico Nemonico_)
        {
            Model modeloRpta = new Model();

            try
            {
                string sCMD = "EXEC [SAB_Nemonico_Listar]'" + strNemotico + "''" + Nemonico_.Codigo + "''" + Nemonico_.NemonicoValor + "''" + Nemonico_.TipoRenta + "''" + Nemonico_.Isin + "'";
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

        public Model mListarTodoN(ConfigWeb ConfigWeb_, string strNemotico, Nemonico Nemonico_)
        {
            Model modeloRpta = new Model();

            try
            {
                string sCMD = "EXEC [SAB_Nemonico_ListarTodo]'" + strNemotico + "''" + Nemonico_.Codigo + "''" + Nemonico_.NemonicoValor + "''" + Nemonico_.Isin + "'";
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

        public Model mInsertarN(ConfigWeb ConfigWeb_, Nemonico Nemonico_)
        {
            Model modeloRpta = new Model();

            try
            {
                string sCMD = "EXEC [SAB_Nemonico_Insertar]'" + Nemonico_.Codigo + "''" + Nemonico_.NemonicoValor + "''" + Nemonico_.Isin + "''" + Nemonico_.TipoRenta + "'";
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

        public Model mEliminarTodoN(ConfigWeb ConfigWeb_)
        {
            Model modeloRpta = new Model();

            try
            {
                string sCMD = "EXEC [SAB_Nemonico_EliminarTodo]";
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

        public Model mTipoRentaN(ConfigWeb ConfigWeb_, string strNemonico)
        {
            Model modeloRpta = new Model();

            try
            {
                string sCMD = "EXEC [SAB_TipoRentaNemonico]'" + strNemonico + "'";
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
        #endregion

        #region CorreoDA

        public Model mSeleccionarCorreo(ConfigWeb ConfigWeb_,int intCodigoCorreo)
        {
            Model modeloRpta = new Model();

            try
            {
                string sCMD = "EXEC [SAB_Correo_Seleccionar]'"+intCodigoCorreo+"'";
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
        
        public Model mOperacionesNoEnviadas(ConfigWeb ConfigWeb_, bool booOrdenes, OperacionesDia OperacionesDia_)
        {
            Model modeloRpta = new Model();

            try
            {
                string sCMD = "EXEC [SAB_OperacionDia_ListarPendientesDeEnvio] '" + booOrdenes + "''" + OperacionesDia_.codigo + "''" + OperacionesDia_.usuario + "''" + OperacionesDia_.emailConfirmacion + "''" + OperacionesDia_.enviado + "''" + OperacionesDia_.formato + "''" + OperacionesDia_.password + "''" + OperacionesDia_.NombreOperador + "'";

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
        #endregion

        #region PolizaDelDiaDA
        public Model mPolizaDiaInsertar(ConfigWeb ConfigWeb_, PolizaDia PolizaDia_)
        {
            Model modeloRpta = new Model();

            try
            {
                string sCMD = "EXEC [SAB_PolizaDia_Insertar] '" + PolizaDia_.Usuario + "','" + PolizaDia_.EmailConfirmacion + "' '" + PolizaDia_.formato + "' ,'" + PolizaDia_.Password + "'";
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

        public Model mPolizasDiaNoEnviadas(ConfigWeb ConfigWeb_, PolizaDia PolizaDia_)
        {
            Model modeloRpta = new Model();

            try
            {
                string sCMD = "EXEC [SAB_PolizaDia_ListarPendientesDeEnvio] '" + PolizaDia_.codigo + "','" + PolizaDia_.Usuario + "''" + PolizaDia_.EmailConfirmacion + "' '" + PolizaDia_.formato + "' ,'" + PolizaDia_.enviado + "', '" + PolizaDia_.Password + "'";
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

        public Model mModificarEstadoEnvioPD(ConfigWeb ConfigWeb_, string strCodigoPolizaDia, bool booEnvioExitoso, string strDescripcion)
        {
            Model modeloRpta = new Model();

            try
            {
                string sCMD = "EXEC [SAB_PolizaDia_ModificarEstadoEnvio] '" + strCodigoPolizaDia + "' '" + booEnvioExitoso + "' '" + strDescripcion + "' ";
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
        #endregion

        #region OperacionesDelDiaDA
        public Model mInsertarOD(ConfigWeb ConfigWeb_, OperacionesDia OperacionesDia_)
        {
            Model modeloRpta = new Model();

            try
            {
                string sCMD = "EXEC [SAB_OperacionDia_Insertar] '" + OperacionesDia_.usuario + "','" + OperacionesDia_.emailConfirmacion + "' '" + OperacionesDia_.formato + "' ,'" + OperacionesDia_.password + "', '" + OperacionesDia_.NombreOperador + "'";
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

        public Model mListarParaAsignaciones(ConfigWeb ConfigWeb_, DateTime Fecha, string TipoOperacion, string Valor, string Referencia)
        {
            Model modeloRpta = new Model();

            try
            {
                string sCMD = "EXEC [ELE_DecargaOperacionHost_ListarParaAsignaciones] '" + Fecha + "''" + TipoOperacion + "''" + Valor + "''" + Referencia + "'";
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

        public Model mModificarEstadoEnvioOD(ConfigWeb ConfigWeb_, string strCodigoOperacion, bool booEnvioExitoso, string strDescripcion)
        {
            Model modeloRpta = new Model();

            try
            {
                string sCMD = "EXEC [SAB_OperacionDia_ModificarEstadoEnvio] '" + strCodigoOperacion + "' '" + booEnvioExitoso + "' '" + strDescripcion + "' ";
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
        #endregion

        #region Tipocuenta
        public Model mTipoCuenta(ConfigWeb ConfigWeb_, String _CodigoTipoCuenta)
        {
            Model modeloRpta = new Model();

            try
            {
                string sCMD = "EXEC [SAB_TipoCuenta_Filtro] '" + _CodigoTipoCuenta + "' ";
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
        #endregion


    }
}
