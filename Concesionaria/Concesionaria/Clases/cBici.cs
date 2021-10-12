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

        public DataTable GetBicicletas()
        {
            string sql = "select b.CodBici";
            sql = sql + ",m.Nombre ";
            sql = sql + ",b.Talle,b.Color,b.NumeroCuadro";
            sql = sql + " from Bicicleta b, Marca m";
            sql = sql + " where b.CodMarca = m.CodMarca ";
            sql = sql + " order by m.Nombre ";
            return cDb.ExecuteDataTable(sql);
        }

        public DataTable GetBicixCodigo(Int32 CodBici)
        {
            string sql = "select * from Bicicleta ";
            sql = sql + " where CodBici=" + CodBici.ToString();
            return cDb.ExecuteDataTable(sql);
        }

    }
}
