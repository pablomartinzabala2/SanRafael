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
    public partial class FrmAbmBici : FormBase 
    {
        cFunciones fun;
        public FrmAbmBici()
        {
            InitializeComponent();
        }

        private void Botonera(int Jugada)
        {
            switch (Jugada)
            {
                //estado inicial
                case 1:
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnAceptar.Enabled = false;
                    btnCancelar.Enabled = false;
                    break;
                case 2:
                    Grupo.Enabled = true;
                    btnNuevo.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnAceptar.Enabled = true;
                    btnCancelar.Enabled = true;
                    break;
                case 3:
                    //viene del buscador
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnAceptar.Enabled = false;
                    btnCancelar.Enabled = false;
                    break;
            }


        }

        private void FrmAbmBici_Load(object sender, EventArgs e)
        {
            Botonera(1);
            Grupo.Enabled = false;
            fun = new Clases.cFunciones();
            CargarMarcas();
        }

        private void CargarMarcas()
        {
            cBici bici = new Clases.cBici();
            DataTable trdo = bici.GetMarcaBici();
            fun.LlenarComboDatatable(cmb_CodMarca, trdo, "Nombre", "CodMarca");
        }

        private void btnAltaMarca_Click(object sender, EventArgs e)
        {
            Principal.CampoIdSecundario = "CodMarca";
            Principal.CampoNombreSecundario = "Nombre";
            Principal.NombreTablaSecundario = "Marca";
            Principal.CampoIdSecundarioGenerado = "";
            FrmAltaBasica form = new FrmAltaBasica();
            form.FormClosing += new FormClosingEventHandler(form_FormClosing);
            form.ShowDialog();
        }

        private void form_FormClosing(object sender, FormClosingEventArgs e)
        {
            //CargarJugador(Convert.ToInt32(PRINCIPAL.CDOGIO_JUGADOR));
            if (Principal.CampoIdSecundarioGenerado != null)
            {
                if (Principal.CampoIdSecundarioGenerado != "")
                {
                    cBici bici = new cBici();
                    Int32 CodMarca = Convert.ToInt32(Principal.CampoIdSecundarioGenerado);
                    bici.ActulizarMarcaBici(CodMarca);
                    Botonera(3);
                    CargarMarcas();
                    cmb_CodMarca.SelectedValue = CodMarca.ToString();               
                }
            }

            if (Principal.CodigoPrincipalAbm != null)
            {
                if (Principal.CodigoPrincipalAbm != "")
                {
                    Botonera(3);
                    txtCodigo.Text = Principal.CodigoPrincipalAbm.ToString();
                    if (Principal.CodigoPrincipalAbm != "")
                        fun.CargarControles(this, "Bicicleta", "CodBici", txtCodigo.Text);
                    Grupo.Enabled = false;
                    return;
                }

            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Botonera(2);
            fun.LimpiarGenerico(this);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar() == true)
            {
                //se usa por las dudas ingreso ya exista el deni
                //y no grabe repetido el documento
                
                if (txtCodigo.Text == "")
                    fun.GuardarNuevoGenerico(this, "Bicicleta");
                else
                    fun.ModificarGenerico(this, "Bicicleta", "CodBici", txtCodigo.Text);
                MessageBox.Show("Datos grabados Correctamente", Clases.cMensaje.Mensaje());
                Botonera(1);
                fun.LimpiarGenerico(this);
                txtCodigo.Text = "";
            }
        }

        public Boolean Validar()
        {
            Boolean op = true;
            if (cmb_CodMarca.SelectedIndex <1)
            {
                MessageBox.Show("Debe seleccionar una marca", Clases.cMensaje.Mensaje());
                return false;
            }

            if (txt_Talle.Text =="")
            {
                MessageBox.Show("Debe  seleccionar un talle", Clases.cMensaje.Mensaje());
                return false;
            }

            return op;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Principal.OpcionesdeBusqueda = "Talle";
            Principal.OpcionesdeBusqueda = "Color";
            Principal.TablaPrincipal = "Bicicleta";
            Principal.OpcionesColumnasGrilla = "CodBici;Talle;Color;NumeroCuadro";
            Principal.ColumnasVisibles = "0;1;1;1";
            Principal.ColumnasAncho = "0;200;190;190";
            FrmBuscadorGenerico form = new FrmBuscadorGenerico();
            form.FormClosing += new FormClosingEventHandler(form_FormClosing);
            form.ShowDialog();
        }
    }
}
