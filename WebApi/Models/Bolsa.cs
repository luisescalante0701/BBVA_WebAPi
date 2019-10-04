using Common;
using Entity;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Bolsa
    {
        #region MaestroDA
        public Model mGetCriterio(ConfigWeb ConfigWeb_)
        {
            return new Logic_().mGetCriterio(ConfigWeb_);
        }

        public Model mGetTipoNegociacion(ConfigWeb ConfigWeb_, int iCodigoOpcion)
        {
            return new Logic_().mGetTipoNegociacion(ConfigWeb_, iCodigoOpcion);
        }
        public Model mGetTipoOrden(ConfigWeb ConfigWeb_, int iCodigoOpcion)
        {
            return new Logic_().mGetTipoOrden(ConfigWeb_, iCodigoOpcion);
        }

        public Model mGetOrden(ConfigWeb ConfigWeb_, int iCodigoOpcion)
        {
            return new Logic_().mGetOrden(ConfigWeb_, iCodigoOpcion);
        }

        public Model mGetTipoComision(ConfigWeb ConfigWeb_)
        {
            return new Logic_().mGetTipoComision(ConfigWeb_);
        }

        public Model mGetTipoPrecio(ConfigWeb ConfigWeb_)
        {
            return new Logic_().mGetTipoPrecio(ConfigWeb_);
        }
        public Model mGetMoneda(ConfigWeb ConfigWeb_)
        {
            return new Logic_().mGetMoneda(ConfigWeb_);
        }

        public Model mListarRutaCarpeta(ConfigWeb ConfigWeb_)
        {
            return new Logic_().mListarRutaCarpeta(ConfigWeb_);
        }

        public Model mNombreTipoOrden(ConfigWeb ConfigWeb_, string strCodigo)
        {
            return new Logic_().mNombreTipoOrden(ConfigWeb_, strCodigo);
        }

        public Model mDescripcionMoneda(ConfigWeb ConfigWeb_, string strCodigo)
        {
            return new Logic_().mDescripcionMoneda(ConfigWeb_, strCodigo);
        }

        public Model mNombreTipoComision(ConfigWeb ConfigWeb_, string strCodigo)
        {
            return new Logic_().mNombreTipoComision(ConfigWeb_, strCodigo);
        }

        public Model mGuardarLogTrafico(ConfigWeb ConfigWeb_, string strTipo, string strIp, string strConError, string strMensaje)
        {
            return new Logic_().mGuardarLogTrafico(ConfigWeb_, strTipo, strIp, strConError, strMensaje);
        }
        #endregion

        #region Nemonico
        public Model mListarN(ConfigWeb ConfigWeb_, string strNemotico, Nemonico Nemonico_)
        {
            return new Logic_().mListarN(ConfigWeb_, strNemotico, Nemonico_);
        }
        public Model mListarTodoN(ConfigWeb ConfigWeb_, string strNemotico, Nemonico Nemonico_)
        {
            return new Logic_().mListarTodoN(ConfigWeb_, strNemotico, Nemonico_);
        }
        public Model mInsertarN(ConfigWeb ConfigWeb_, Nemonico Nemonico_)
        {
            return new Logic_().mInsertarN(ConfigWeb_, Nemonico_);
        }
        public Model mEliminarTodoN(ConfigWeb ConfigWeb_)
        {
            return new Logic_().mEliminarTodoN(ConfigWeb_);
        }
        public Model mTipoRentaN(ConfigWeb ConfigWeb_, string strNemonico)
        {
            return new Logic_().mTipoRentaN(ConfigWeb_, strNemonico);
            #endregion

            #region CorreoDA
            public Model mSeleccionarCorreo(ConfigWeb ConfigWeb_, int intCodigoCorreo)
        {
            return new Logic_().mSeleccionarCorreo(ConfigWeb_, intCodigoCorreo);
        }

        public Model mTraerCorreo(ConfigWeb ConfigWeb_)
        {
            return new Logic_().mTraerCorreo(ConfigWeb_);
        }

        public Model mListarParaAsignaciones(ConfigWeb ConfigWeb_, DateTime Fecha, string TipoOperacion, string Valor, string Referencia)
        {
            return new Logic_().mListarParaAsignaciones(ConfigWeb_, Fecha, TipoOperacion, Valor, Referencia);
        }

        public Model mOperacionesNoEnviadas(ConfigWeb ConfigWeb_, bool booOrdenes, OperacionesDia OperacionesDia_)
        {
            return new Logic_().mOperacionesNoEnviadas(ConfigWeb_, booOrdenes, OperacionesDia_);
        }

        #endregion

        #region PolizaDelDiaDA
        public Model mPolizaDiaInsertar(ConfigWeb ConfigWeb_, PolizaDia PolizaDia_)
        {
            return new Logic_().mPolizaDiaInsertar(ConfigWeb_, PolizaDia_);
        }

        public Model mPolizasDiaNoEnviadas(ConfigWeb ConfigWeb_, PolizaDia PolizaDia_)
        {
            return new Logic_().mPolizasDiaNoEnviadas(ConfigWeb_, PolizaDia_);
        }
        public Model mModificarEstadoEnvioPD(ConfigWeb ConfigWeb_, string strCodigoPolizaDia, bool booEnvioExitoso, string strDescripcion)
        {
            return new Logic_().mModificarEstadoEnvioPD(ConfigWeb_, strCodigoPolizaDia, booEnvioExitoso, strDescripcion);
        }
        #endregion

        #region OperacionesDelDiaDA
        public Model mInsertarOD(ConfigWeb ConfigWeb_, OperacionesDia operacionesDia_)
        {
            return new Logic_().mInsertarOD(ConfigWeb_, operacionesDia_);
        }

        public Model mModificarEstadoEnvioOD(ConfigWeb ConfigWeb_, string strCodigoOperacion, bool booEnvioExitoso, string strDescripcion)
        {
            return new Logic_().mModificarEstadoEnvioOD(ConfigWeb_, strCodigoOperacion, booEnvioExitoso, strDescripcion);
        }
        #endregion

        #region TipoCuentaDA
        public Model mTipoCuenta(ConfigWeb ConfigWeb_, String _CodigoTipoCuenta)
        {
            return new Logic_().mTipoCuenta(ConfigWeb_, _CodigoTipoCuenta);
        }
        #endregion
    }
}
