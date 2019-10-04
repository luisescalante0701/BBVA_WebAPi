using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class BolsaController : ControllerBase
    { 
        static int sCodErrorControllerAPi = 20190000;//-- CODIGO ERROR GENERAL PARA IDENTIFICAR EL ERROR EN LA CAPA LOGICA

        IConfiguration _myConfiguration;
        ConfigWeb ConfigWeb_;
           
        public BolsaController(IConfiguration myConfiguration)
        {
            _myConfiguration = myConfiguration;

            ConfigWeb_ = new ConfigWeb();


            _myConfiguration.GetSection("ConfigWeb").Bind(ConfigWeb_);

            ConnectionStringsX ConnectionStrings_ = new ConnectionStringsX();
            _myConfiguration.GetSection("ConnectionStringsX").Bind(ConnectionStrings_);
            ConfigWeb_.ConnectionStrings_ = ConnectionStrings_;

            AppSettings AppSettings_ = new AppSettings();
            _myConfiguration.GetSection("AppSettings").Bind(AppSettings_);
            ConfigWeb_.AppSettings_ = AppSettings_;
        }


        #region MaestroDA
        [HttpGet]
        [Route("mGetCriterio")]
        public object mGetCriterio()
        {
            object objResult = null;

            Model modeloRpta = new Model();
            Bolsa mBolsa = new Bolsa();

            object obj = new object();

            try
            {
                object objRpta = mBolsa.mGetCriterio(this.ConfigWeb_);
                modeloRpta = (Model)objRpta;

                objResult = modeloRpta;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorControllerAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "BolsaController", ex.StackTrace, ex.Message);// ex.Message.ToString();
                modeloRpta.obj = obj;
                objResult = modeloRpta;
                
               // JsonConvert
            }

            return JsonConvert.SerializeObject(objResult);
        }

        [HttpGet]
        [Route("mGetTipoNegociacion/{iCodigoOpcion}")]
        public object mGetTipoNegociacion(int iCodigoOpcion)
        {
            object objResult = null;

            Model modeloRpta = new Model();
            Bolsa mBolsa = new Bolsa();

            object obj = new object();

            try
            {
                object objRpta = mBolsa.mGetTipoNegociacion(this.ConfigWeb_, iCodigoOpcion);
                modeloRpta = (Model)objRpta;

                objResult = modeloRpta;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorControllerAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "BolsaController", ex.StackTrace, ex.Message);// ex.Message.ToString();
                modeloRpta.obj = obj;
                objResult = modeloRpta;

                // JsonConvert
            }

            return JsonConvert.SerializeObject(objResult);
        }

        [HttpGet]
        [Route("mGetTipoOrden/{iCodigoOpcion}")]
        public object mGetTipoOrden(int iCodigoOpcion)
        {
            object objResult = null;

            Model modeloRpta = new Model();
            Bolsa mBolsa = new Bolsa();

            object obj = new object();

            try
            {
                object objRpta = mBolsa.mGetTipoOrden(this.ConfigWeb_, iCodigoOpcion);
                modeloRpta = (Model)objRpta;

                objResult = modeloRpta;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorControllerAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "BolsaController", ex.StackTrace, ex.Message);// ex.Message.ToString();
                modeloRpta.obj = obj;
                objResult = modeloRpta;

                // JsonConvert
            }

            return JsonConvert.SerializeObject(objResult);
        }

        [HttpGet]
        [Route("mGetOrden/{iCodigoOpcion}")]
        public object mGetOrden(int iCodigoOpcion)
        {
            object objResult = null;

            Model modeloRpta = new Model();
            Bolsa mBolsa = new Bolsa();

            object obj = new object();

            try
            {
                object objRpta = mBolsa.mGetOrden(this.ConfigWeb_, iCodigoOpcion);
                modeloRpta = (Model)objRpta;

                objResult = modeloRpta;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorControllerAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "BolsaController", ex.StackTrace, ex.Message);// ex.Message.ToString();
                modeloRpta.obj = obj;
                objResult = modeloRpta;

                // JsonConvert
            }

            return JsonConvert.SerializeObject(objResult);
        }

        [HttpGet]
        [Route("mGetTipoComision")]
        public object mGetTipoComision()
        {
            object objResult = null;

            Model modeloRpta = new Model();
            Bolsa mBolsa = new Bolsa();

            object obj = new object();

            try
            {
                object objRpta = mBolsa.mGetTipoComision(this.ConfigWeb_);
                modeloRpta = (Model)objRpta;

                objResult = modeloRpta;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorControllerAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "BolsaController", ex.StackTrace, ex.Message);// ex.Message.ToString();
                modeloRpta.obj = obj;
                objResult = modeloRpta;

                // JsonConvert
            }

            return JsonConvert.SerializeObject(objResult);
        }

        [HttpGet]
        [Route("mGetTipoPrecio")]
        public object mGetTipoPrecio()
        {
            object objResult = null;

            Model modeloRpta = new Model();
            Bolsa mBolsa = new Bolsa();

            object obj = new object();

            try
            {
                object objRpta = mBolsa.mGetTipoPrecio(this.ConfigWeb_);
                modeloRpta = (Model)objRpta;

                objResult = modeloRpta;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorControllerAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "BolsaController", ex.StackTrace, ex.Message);// ex.Message.ToString();
                modeloRpta.obj = obj;
                objResult = modeloRpta;

                // JsonConvert
            }

            return JsonConvert.SerializeObject(objResult);
        }

        [HttpGet]
        [Route("mGetMoneda")]
        public object mGetMoneda()
        {
            object objResult = null;

            Model modeloRpta = new Model();
            Bolsa mBolsa = new Bolsa();

            object obj = new object();

            try
            {
                object objRpta = mBolsa.mGetMoneda(this.ConfigWeb_);
                modeloRpta = (Model)objRpta;

                objResult = modeloRpta;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorControllerAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "BolsaController", ex.StackTrace, ex.Message);// ex.Message.ToString();
                modeloRpta.obj = obj;
                objResult = modeloRpta;

                // JsonConvert
            }

            return JsonConvert.SerializeObject(objResult);
        }

        [HttpGet]
        [Route("mListarRutaCarpeta")]
        public object mListarRutaCarpeta()
        {
            object objResult = null;

            Model modeloRpta = new Model();
            Bolsa mBolsa = new Bolsa();

            object obj = new object();

            try
            {
                object objRpta = mBolsa.mListarRutaCarpeta(this.ConfigWeb_);
                modeloRpta = (Model)objRpta;

                objResult = modeloRpta;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorControllerAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "BolsaController", ex.StackTrace, ex.Message);// ex.Message.ToString();
                modeloRpta.obj = obj;
                objResult = modeloRpta;

                // JsonConvert
            }

            return JsonConvert.SerializeObject(objResult);
        }

        [HttpGet]
        [Route("mNombreTipoOrden/{strCodigo}")]
        public object mNombreTipoOrden(string strCodigo)
        {
            object objResult = null;

            Model modeloRpta = new Model();
            Bolsa mBolsa = new Bolsa();

            object obj = new object();

            try
            {
                object objRpta = mBolsa.mNombreTipoOrden(this.ConfigWeb_, strCodigo);
                modeloRpta = (Model)objRpta;

                objResult = modeloRpta;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorControllerAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "BolsaController", ex.StackTrace, ex.Message);// ex.Message.ToString();
                modeloRpta.obj = obj;
                objResult = modeloRpta;

                // JsonConvert
            }

            return JsonConvert.SerializeObject(objResult);
        }

        [HttpGet]
        [Route("mDescripcionMoneda/{strCodigo}")]
        public object mDescripcionMoneda(string strCodigo)
        {
            object objResult = null;

            Model modeloRpta = new Model();
            Bolsa mBolsa = new Bolsa();

            object obj = new object();

            try
            {
                object objRpta = mBolsa.mDescripcionMoneda(this.ConfigWeb_, strCodigo);
                modeloRpta = (Model)objRpta;

                objResult = modeloRpta;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorControllerAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "BolsaController", ex.StackTrace, ex.Message);// ex.Message.ToString();
                modeloRpta.obj = obj;
                objResult = modeloRpta;

                // JsonConvert
            }

            return JsonConvert.SerializeObject(objResult);
        }

        [HttpGet]
        [Route("mNombreTipoComision/{strCodigo}")]
        public object mNombreTipoComision(string strCodigo)
        {
            object objResult = null;

            Model modeloRpta = new Model();
            Bolsa mBolsa = new Bolsa();

            object obj = new object();

            try
            {
                object objRpta = mBolsa.mNombreTipoComision(this.ConfigWeb_, strCodigo);
                modeloRpta = (Model)objRpta;

                objResult = modeloRpta;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorControllerAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "BolsaController", ex.StackTrace, ex.Message);// ex.Message.ToString();
                modeloRpta.obj = obj;
                objResult = modeloRpta;

                // JsonConvert
            }

            return JsonConvert.SerializeObject(objResult);
        }

        [HttpGet]
        [Route("mGuardarLogTrafico/{strTipo}/{strIp}/{strConError}/{strMensaje}")]
        public object mGuardarLogTrafico(string strTipo, string strIp, string strConError, string strMensaje)
        {
            object objResult = null;

            Model modeloRpta = new Model();
            Bolsa mBolsa = new Bolsa();

            object obj = new object();

            try
            {
                object objRpta = mBolsa.mGuardarLogTrafico(this.ConfigWeb_, strTipo, strIp, strConError, strMensaje);
                modeloRpta = (Model)objRpta;

                objResult = modeloRpta;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorControllerAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "BolsaController", ex.StackTrace, ex.Message);// ex.Message.ToString();
                modeloRpta.obj = obj;
                objResult = modeloRpta;

                // JsonConvert
            }

            return JsonConvert.SerializeObject(objResult);
        }
        #endregion

        #region Nemonico
        // POST: api/Bolsa
        [HttpPost]
        public object mListarN(string strNemotico, Nemonico Nemonico_)
        {
            object objResult = null;

            Model modeloRpta = new Model();
            Bolsa mBolsa = new Bolsa();

            object obj = new object();

            try
            {
                object objRpta = mBolsa.mListarN(this.ConfigWeb_, strNemotico, Nemonico_);
                modeloRpta = (Model)objRpta;

                objResult = modeloRpta;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorControllerAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "BolsaController", ex.StackTrace, ex.Message);// ex.Message.ToString();
                modeloRpta.obj = obj;
                objResult = modeloRpta;

                // JsonConvert
            }

            return JsonConvert.SerializeObject(objResult);
        }

        // POST: api/Bolsa
        [HttpPost]
        public object mListarTodoN(string strNemotico, Nemonico Nemonico_)
        {
            object objResult = null;

            Model modeloRpta = new Model();
            Bolsa mBolsa = new Bolsa();

            object obj = new object();

            try
            {
                object objRpta = mBolsa.mListarTodoN(this.ConfigWeb_, strNemotico, Nemonico_);
                modeloRpta = (Model)objRpta;

                objResult = modeloRpta;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorControllerAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "BolsaController", ex.StackTrace, ex.Message);// ex.Message.ToString();
                modeloRpta.obj = obj;
                objResult = modeloRpta;

                // JsonConvert
            }

            return JsonConvert.SerializeObject(objResult);
        }

        // POST: api/Bolsa
        [HttpPost]
        public object mInsertarN(string strNemotico, Nemonico Nemonico_)
        {
            object objResult = null;

            Model modeloRpta = new Model();
            Bolsa mBolsa = new Bolsa();

            object obj = new object();

            try
            {
                object objRpta = mBolsa.mInsertarN(this.ConfigWeb_, Nemonico_);
                modeloRpta = (Model)objRpta;

                objResult = modeloRpta;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorControllerAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "BolsaController", ex.StackTrace, ex.Message);// ex.Message.ToString();
                modeloRpta.obj = obj;
                objResult = modeloRpta;

                // JsonConvert
            }

            return JsonConvert.SerializeObject(objResult);
        }

        [HttpGet]
        [Route("mEliminarTodoN")]
        public object mEliminarTodoN()
        {
            object objResult = null;

            Model modeloRpta = new Model();
            Bolsa mBolsa = new Bolsa();

            object obj = new object();

            try
            {
                object objRpta = mBolsa.mEliminarTodoN(this.ConfigWeb_);
                modeloRpta = (Model)objRpta;

                objResult = modeloRpta;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorControllerAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "BolsaController", ex.StackTrace, ex.Message);// ex.Message.ToString();
                modeloRpta.obj = obj;
                objResult = modeloRpta;

                // JsonConvert
            }

            return JsonConvert.SerializeObject(objResult);
        }

        [HttpGet]
        [Route("mTipoRentaN/{strNemonico}")]
        public object mTipoRentaN(string strNemonico)
        {
            object objResult = null;

            Model modeloRpta = new Model();
            Bolsa mBolsa = new Bolsa();

            object obj = new object();

            try
            {
                object objRpta = mBolsa.mTipoRentaN(this.ConfigWeb_, strNemonico);
                modeloRpta = (Model)objRpta;

                objResult = modeloRpta;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorControllerAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "BolsaController", ex.StackTrace, ex.Message);// ex.Message.ToString();
                modeloRpta.obj = obj;
                objResult = modeloRpta;

                // JsonConvert
            }

            return JsonConvert.SerializeObject(objResult);
        }
        #endregion

        #region CorreoDA

        [HttpGet]
        [Route("mSeleccionarCorreo/{intCodigoCorreo}")]
        public object mSeleccionarCorreo(int intCodigoCorreo)
        {
            object objResult = null;

            Model modeloRpta = new Model();
            Bolsa mBolsa = new Bolsa();

            object obj = new object();

            try
            {
                object objRpta = mBolsa.mSeleccionarCorreo(this.ConfigWeb_, intCodigoCorreo);
                modeloRpta = (Model)objRpta;

                objResult = modeloRpta;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorControllerAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "BolsaController", ex.StackTrace, ex.Message);// ex.Message.ToString();
                modeloRpta.obj = obj;
                objResult = modeloRpta;

                // JsonConvert
            }

            return JsonConvert.SerializeObject(objResult);
        }

        [HttpGet]
        [Route("mTraerCorreo")]
        public object mTraerCorreo()
        {
            object objResult = null;

            Model modeloRpta = new Model();
            Bolsa mBolsa = new Bolsa();

            object obj = new object();

            try
            {
                object objRpta = mBolsa.mTraerCorreo(this.ConfigWeb_);
                modeloRpta = (Model)objRpta;

                objResult = modeloRpta;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorControllerAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "BolsaController", ex.StackTrace, ex.Message);// ex.Message.ToString();
                modeloRpta.obj = obj;
                objResult = modeloRpta;

                // JsonConvert
            }

            return JsonConvert.SerializeObject(objResult);
        }

        [HttpGet]
        [Route("mListarParaAsignaciones/{Fecha}, {TipoOperacion} , {Valor}, {Referencia}")]
        public object mListarParaAsignaciones(DateTime Fecha, string TipoOperacion, string Valor, string Referencia)
        {
            object objResult = null;

            Model modeloRpta = new Model();
            Bolsa mBolsa = new Bolsa();

            object obj = new object();

            try
            {
                object objRpta = mBolsa.mListarParaAsignaciones(this.ConfigWeb_, Fecha, TipoOperacion, Valor, Referencia);
                modeloRpta = (Model)objRpta;

                objResult = modeloRpta;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorControllerAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "BolsaController", ex.StackTrace, ex.Message);// ex.Message.ToString();
                modeloRpta.obj = obj;
                objResult = modeloRpta;

                // JsonConvert
            }

            return JsonConvert.SerializeObject(objResult);
        }

        // POST: api/Bolsa
        [HttpPost]
        public object mOperacionesNoEnviadas([FromBody] bool booOrdenes, OperacionesDia OperacionesDia_)
        {
            object objResult = null;

            Model modeloRpta = new Model();
            Bolsa mBolsa = new Bolsa();

            object obj = new object();

            try
            {
                object objRpta = mBolsa.mOperacionesNoEnviadas(this.ConfigWeb_,booOrdenes, OperacionesDia_);
                modeloRpta = (Model)objRpta;

                objResult = modeloRpta;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorControllerAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "BolsaController", ex.StackTrace, ex.Message);// ex.Message.ToString();
                modeloRpta.obj = obj;
                objResult = modeloRpta;

                // JsonConvert
            }

            return JsonConvert.SerializeObject(objResult);
        }
        #endregion

        #region PolizaDelDiaDA
        [HttpPost]
        public object mPolizaDiaInsertar([FromBody] PolizaDia PolizaDia_)
        {
            object objResult = null;

            Model modeloRpta = new Model();
            Bolsa mBolsa = new Bolsa();

            object obj = new object();

            try
            {
                object objRpta = mBolsa.mPolizaDiaInsertar(this.ConfigWeb_, PolizaDia_);
                modeloRpta = (Model)objRpta;

                objResult = modeloRpta;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorControllerAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "BolsaController", ex.StackTrace, ex.Message);// ex.Message.ToString();
                modeloRpta.obj = obj;
                objResult = modeloRpta;

                // JsonConvert
            }

            return JsonConvert.SerializeObject(objResult);
        }

        [HttpPost]
        public object mPolizasDiaNoEnviadas([FromBody] PolizaDia PolizaDia_)
        {
            object objResult = null;

            Model modeloRpta = new Model();
            Bolsa mBolsa = new Bolsa();

            object obj = new object();

            try
            {
                object objRpta = mBolsa.mPolizasDiaNoEnviadas(this.ConfigWeb_, PolizaDia_);
                modeloRpta = (Model)objRpta;

                objResult = modeloRpta;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorControllerAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "BolsaController", ex.StackTrace, ex.Message);// ex.Message.ToString();
                modeloRpta.obj = obj;
                objResult = modeloRpta;

                // JsonConvert
            }

            return JsonConvert.SerializeObject(objResult);
        }

        [HttpGet]
        [Route("mModificarEstadoEnvioPD/{strCodigoPolizaDia}, {booEnvioExitoso}, {strDescripcion}")]
        public object mModificarEstadoEnvioPD(string strCodigoPolizaDia, bool booEnvioExitoso, string strDescripcion)
        {
            object objResult = null;

            Model modeloRpta = new Model();
            Bolsa mBolsa = new Bolsa();

            object obj = new object();

            try
            {
                object objRpta = mBolsa.mModificarEstadoEnvioPD(this.ConfigWeb_, strCodigoPolizaDia, booEnvioExitoso, strDescripcion);
                modeloRpta = (Model)objRpta;

                objResult = modeloRpta;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorControllerAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "BolsaController", ex.StackTrace, ex.Message);// ex.Message.ToString();
                modeloRpta.obj = obj;
                objResult = modeloRpta;

                // JsonConvert
            }
        }
        #endregion

        #region OperacionesDelDiaDA
        // POST: api/Bolsa
        [HttpPost]
        public object mInsertarOD([FromBody] OperacionesDia operacionesDia_)
        {
            object objResult = null;

            Model modeloRpta = new Model();
            Bolsa mBolsa = new Bolsa();

            object obj = new object();

            try
            {
                object objRpta = mBolsa.mInsertarOD(this.ConfigWeb_, operacionesDia_);
                modeloRpta = (Model)objRpta;

                objResult = modeloRpta;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorControllerAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "BolsaController", ex.StackTrace, ex.Message);// ex.Message.ToString();
                modeloRpta.obj = obj;
                objResult = modeloRpta;

                // JsonConvert
            }

            return JsonConvert.SerializeObject(objResult);
        }

        [HttpGet]
        [Route("mModificarEstadoEnvio/{strCodigoOperacion}, {booEnvioExitoso}, {strDescripcion}")]
        public object mModificarEstadoEnvioOD(string strCodigoOperacion, bool booEnvioExitoso, string strDescripcion)
        {
            object objResult = null;

            Model modeloRpta = new Model();
            Bolsa mBolsa = new Bolsa();

            object obj = new object();

            try
            {
                object objRpta = mBolsa.mModificarEstadoEnvioOD(this.ConfigWeb_, strCodigoOperacion, booEnvioExitoso, strDescripcion);
                modeloRpta = (Model)objRpta;

                objResult = modeloRpta;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorControllerAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "BolsaController", ex.StackTrace, ex.Message);// ex.Message.ToString();
                modeloRpta.obj = obj;
                objResult = modeloRpta;

                // JsonConvert
            }
        }
        #endregion

        #region TipoCuentaDA
        [HttpGet]
        [Route("mTipoCuenta, {_CodigoTipoCuenta}")]
        public object mTipoCuenta(string _CodigoTipoCuenta)
        {
            object objResult = null;

            Model modeloRpta = new Model();
            Bolsa mBolsa = new Bolsa();

            object obj = new object();

            try
            {
                object objRpta = mBolsa.mTipoCuenta(this.ConfigWeb_, _CodigoTipoCuenta);
                modeloRpta = (Model)objRpta;

                objResult = modeloRpta;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorControllerAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "BolsaController", ex.StackTrace, ex.Message);// ex.Message.ToString();
                modeloRpta.obj = obj;
                objResult = modeloRpta;

                // JsonConvert
            }

            return JsonConvert.SerializeObject(objResult);
        }
        #endregion

        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::



        // GET: api/Bolsa
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Bolsa/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Bolsa
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Bolsa/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
