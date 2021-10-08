using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Concesionaria.Clases
{
    public class cMarca
    {
        public Boolean PuedeBorrar(Int32 CodMarca)
        {
            Boolean Borra = true;
            string sql = "select * from auto where CodMarca =" + CodMarca.ToString();
            DataTable trdo = cDb.ExecuteDataTable(sql);
            if (trdo.Rows.Count > 0)
                if (trdo.Rows[0]["CodMarca"].ToString() != "")
                    Borra = false;
            return Borra;
        }

        public DataTable GetMarcas()
        {
            string sql = "select * from Marca";
            return cDb.ExecuteDataTable(sql);
        }

        public DataTable GetMarcaAuto()
        {
            string sql = "select * from Marca where auto = 1";
            return cDb.ExecuteDataTable(sql);
        }

        public void ActualizarMarcaAuto(Int32 CodMarca)
        {
            string sql = "update Marca set Auto = 1";
            sql = sql + " where CodMarca=" + CodMarca.ToString();
            cDb.ExecutarNonQuery(sql);
        }

    }
}
