using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prototype
{
    public partial class wfInsertarComputadora : System.Web.UI.Page
    {
        private static int ultimoId = 0;

        private static List<Entidades.Computadoras> Computadoras { get; set; } = new List<Entidades.Computadoras>();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Computadoras nuevaComputadora = new Computadoras
                {
                    Marca = txtMarca.Text,
                    Modelo = txtModelo.Text,
                    Procesador = txtProcesador.Text,
                    MemoriaRam = Convert.ToInt32(txtMemoriaRam.Text),
                    Almacenamiento = Convert.ToInt32(txtAlmacenamiento.Text),
                    SistemaOperativo = txtSistemaOperativo.Text
                };

                DataAccess.AgregarComputadora(nuevaComputadora);
                Computadoras.Add(nuevaComputadora);
                BindGrid();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Computadoras computadoraEditada = new Computadoras
            {
                Id = Convert.ToInt32(txtId.Text),
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                Procesador = txtProcesador.Text,
                MemoriaRam = Convert.ToInt32(txtMemoriaRam.Text),
                Almacenamiento = Convert.ToInt32(txtAlmacenamiento.Text),
                SistemaOperativo = txtSistemaOperativo.Text
            };

            DataAccess.EditarComputadora(computadoraEditada);
            BindGrid();
            LimpiarFormulario();    
        }

        //ESTE ES EL LADO DEL CLIENTE, OBTIENE UNA INSTANCIA DE COMPUTADORA Y UTILIZA
        //EL METODO CLONE PARA CREAR UNA COPIA DE ESA INSTANCIA
        protected void btnClonar_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32((sender as Button).CommandArgument);
                Computadoras computadoraOriginal = Computadoras[index];

                if (computadoraOriginal != null)
                {
                    // Utiliza el método Clone() de la interfaz IPrototype y realiza un casting explícito a Computadoras
                    Computadoras computadoraClonada = (Computadoras)computadoraOriginal.Clone();
                    computadoraClonada.Id = ++ultimoId;

                    DataAccess.AgregarComputadora(computadoraClonada);
                    Computadoras.Add(computadoraClonada);
                    BindGrid();
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32((sender as Button).CommandArgument);
                Computadoras computadoraAEliminar = Computadoras[index];

                if (computadoraAEliminar != null)
                {
                    DataAccess.EliminarComputadora(computadoraAEliminar.Id);
                    Computadoras.RemoveAt(index);
                    LimpiarFormulario();
                    gvComputadoras.DataSource = Computadoras;
                    gvComputadoras.DataBind();
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Button btnSeleccionar = (Button)sender;
            int index = Convert.ToInt32(btnSeleccionar.CommandArgument);
            GridViewRow row = gvComputadoras.Rows[index];

            txtId.Text = row.Cells[1].Text;
            txtMarca.Text = row.Cells[2].Text;
            txtModelo.Text = row.Cells[3].Text;
            txtProcesador.Text = row.Cells[4].Text;
            txtMemoriaRam.Text = row.Cells[5].Text;
            txtAlmacenamiento.Text = row.Cells[6].Text;
            txtSistemaOperativo.Text = row.Cells[7].Text;
        }

        private void BindGrid()
        {
            Computadoras = DataAccess.GetComputadoras();
            gvComputadoras.DataSource = Computadoras;
            gvComputadoras.DataBind();
        }

        private void LimpiarFormulario()
        {
            hfId.Value = string.Empty;
            txtMarca.Text = string.Empty;
            txtModelo.Text = string.Empty;
            txtProcesador.Text = string.Empty;
            txtMemoriaRam.Text = string.Empty;
            txtAlmacenamiento.Text = string.Empty;
            txtSistemaOperativo.Text = string.Empty;
        }
    }
}