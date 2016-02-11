using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TechnicalServices.DatabaseHandler
{
    class ProducttIndexAccess : ProductAccess
    {
        public string GetpNameString()
        {
            string s = null;
            SqlConnection conn = new SqlConnection(dataBaseAccess);
            SqlCommand cmd;
            SqlDataReader reader;
            cmd = new SqlCommand("GetProtuctNames", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            reader = cmd.ExecuteReader();
            while (reader.HasRows && reader.Read())
            {
                if (s == null)
                {
                    s = reader.GetString(0);
                }
                else
                {
                    s = ";" + s + reader.GetString(0);
                }                
            }
            reader.Close();
            conn.Close();
            conn.Dispose();            
            return s;           
        }
        public string GetpTypeString()
        {            
            return "Discount;Hverdag";
        }
        public string GetpDocumationString()
        {            
            return "Opskrift;Korrespondance";
        }
    }
}
