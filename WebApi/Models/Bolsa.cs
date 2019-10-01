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

        public Model mSeleccionarCorreo(ConfigWeb ConfigWeb_)
        {
            return new Logic_().mSeleccionarCorreo(ConfigWeb_);
        }

        public Model mTraerCorreo(ConfigWeb ConfigWeb_)
        {
            return new Logic_().mTraerCorreo(ConfigWeb_);
        }



    }
}
