using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace Concesionaria.Clases
{
    public  class cCostoPostVenta
    {
        public void Insertar(Int32 CodVenta,string Nombre,Double Importe,
            DateTime Fecha,Int32 CodStock)
        {
            
            string sql = "Insert into CostoPostVenta(CodVenta,Nombre";
            sql = sql + ",Importe,Fecha,CodStock)";
            sql = sql + " Values(" + CodVenta.ToString();
            sql = sql + "," + "'" + Nombre + "'";
            sql = sql + "," + Importe.ToString().Replace(",", ".");
            sql = sql + "," + "'" + Fecha.ToShortDateString() + "'";
            sql = sql + "," + CodStock.ToString();
            sql = sql + ")";
            cDb.ExecutarNonQuery(sql);
        }

        public void BorrarCosto(Int32 CodCosto)
        {
            string sql = "delete from CostoPostVenta ";
            sql = sql + " where CodCosto=" + CodCosto.ToString();
            cDb.ExecutarNonQuery(sql);
        }

        public DataTable GetCosto(Int32 CodVenta)
        {
            string sql = "select CodCosto,CodVenta,Nombre,Fecha,Importe ";
            sql = sql + " from  CostoPostVenta";
            sql = sql + " where CodVenta=" + CodVenta.ToString();
            return cDb.ExecuteDataTable(sql); 
        }

        public DataTable GetCostoxCodCosto(Int32 CodCosto)
        {
            string sql = "select CodCosto,CodVenta,Nombre,Fecha,Importe ";
            sql = sql + " from  CostoPostVenta";
            sql = sql + " where CodCosto=" + CodCosto.ToString();
            return cDb.ExecuteDataTable(sql);
        }
    }
}
