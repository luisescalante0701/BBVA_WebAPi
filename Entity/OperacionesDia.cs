using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class OperacionesDia
    {
        public string codigo { get; set; }
        public string usuario { get; set; }
        public string emailConfirmacion { get; set; }
        public int formato { get; set; }
        public bool enviado { get; set; }
        public bool envioExitoso { get; set; }
        public string password { get; set; }
        public string NombreOperador { get; set; }
        public bool isOrdenes { get; set; }

        public List<OperacionesDiaDetalle> oLista { get; set; }

    }
}
