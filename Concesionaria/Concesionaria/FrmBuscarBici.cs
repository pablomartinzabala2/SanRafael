using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Concesionaria.Clases;
namespace Concesionaria
{
    public partial class FrmBuscarBici : FormBase 
    {
        cFunciones fun;
        public FrmBuscarBici()
        {
            InitializeComponent();
        }

        private void FrmBuscarBici_Load(object sender, EventArgs e)
        {
            fun = new Clases.cFunciones();
            Buscar();
        }

        private void Buscar()
        {
            cBici bici = new Clases.cBici();
            DataTable trdo = bici.GetBicicletas();
            string col = "0;40;20;20;20";
            Grilla.DataSource = trdo;
            fun.AnchoColumnas(Grilla, col);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Grilla.CurrentRow ==null)
            {
                MessageBox.Show("Debe seleccionar un elemento", "Sistema");
                return;
            }
            Principal.CodigoPrincipalAbm = Grilla.CurrentRow.Cells[0].Value.ToString();
            this.Close(); 
        }
    }
}
