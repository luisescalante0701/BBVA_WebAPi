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
        [Route("mListaFiltroRentaFija/{sTipoRenta}/{sNemonico}")]
        public object mListaFiltroRentaFija(string sTipoRenta, string sNemonico)
        {
            object objResult = null;

            Model modeloRpta = new Model();
           // Bolsa mBolsa = new Bolsa();

            object obj = new object();

            try
            {
                object objRpta = new Bolsa().mListaFiltroRentaFija(this.ConfigWeb_, sTipoRenta,  sNemonico);
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
