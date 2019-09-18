using Common;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

//using System.Data.SqlClient;

namespace Data
{
   public class Data_
    {
        static int sCodErrorDataAPi = 20190002;//-- CODIGO ERROR GENERAL PARA IDENTIFICAR EL ERROR EN LA CAPA DATA - DATAACCES


        public Data_()
        {

        }
        
        public Model mExceBD_SQL(ConfigWeb ConfigWeb_, string sCMD)
        {
             SqlConnection Conn = new SqlConnection();
            Model modeloRpta = new Model();
            DataTable dtData = new DataTable("DATA");
            
            string sCadCon = ConfigWeb_.ConnectionStrings_.connectionString_SQL;

            try
            {
                Conn = new SqlConnection(sCadCon);
                Conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sCMD, Conn);
                sda.Fill(dtData);

                modeloRpta.bEstado = true;
                modeloRpta.iCodigo = 0;
                modeloRpta.sRpta = "OK";
                modeloRpta.obj = dtData;
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.iCodigo = sCodErrorDataAPi;
                modeloRpta.sRpta = String.Format("Class: {0} > StackTrace: {1} - Message: {2} ", "WebAPi/Data_", ex.StackTrace, ex.Message);
                modeloRpta.obj = null;
            }
            finally
            {
                Conn.Close();
            }

            return modeloRpta;
        }





    }
}
