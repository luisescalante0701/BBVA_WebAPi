using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class OperacionesDiaDetalle
    {
        public string codigo { get; set; }
        public string nroOrden { get; set; }
        public string fecha { get; set; }
        public string codigoCliente { get; set; }
        public string cliente { get; set; }
        public string codigoValor { get; set; }
        public string t_I { get; set; }
        public string rut { get; set; }
        public string c_V { get; set; }
        public string tipo_negociacion { get; set; }
        //private string tipo_importe { get; set; }
        public string email { get; set; }
        public string situacion { get; set; }
        public string lugarNegociacion { get; set; }
        public string titulosImporte { get; set; }
        public bool envioExitoso { get; set; }

    }
}
