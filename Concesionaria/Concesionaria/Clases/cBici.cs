using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace Concesionaria.Clases
{
    public class cBici
    {
        public DataTable GetMarcaBici()
        {
            string sql = "select * from marca where bici =1";
            return cDb.ExecuteDataTable(sql);
        }

        public void ActulizarMarcaBici(Int32 CodMarca)
        {
            string sql = "update Marca set Bici = 1";
            sql = sql + " where CodMarca=" + CodMarca.ToString();
            cDb.ExecutarNonQuery(sql);
        }

    }
}
