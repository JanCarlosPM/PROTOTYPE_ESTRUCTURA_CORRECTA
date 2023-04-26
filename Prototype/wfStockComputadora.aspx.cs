using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Prototype
{
    public partial class wfStockComputadora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Hecho_Click(object sender, EventArgs e)
        {
            try
            {
                computadora nuevaComputadora = new computadora
            {
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                Procesador = txtProcesador.Text,
                MemoriaRam = Convert.ToInt32(txtMemoriaRam.Text),
                Almacenamiento = Convert.ToInt32(txtAlmacenamiento.Text),
                SistemaOperativo = txtSistemaOperativo.Text,
                AltaStock = Int32.Parse(txtAlta.Text),
                BajaStock = Int32.Parse(txtBaja.Text),
                Cantidad = int.Parse(txtCantidadProducto.Text)
            };

            StockAccess.AgregarComputadoraStock(nuevaComputadora);

            }catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }           
        }

        protected void Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                computadora nuevaComputadoraEditada = new computadora
                {
                    Id = Convert.ToInt32(txtId.Text),
                    Marca = txtMarca.Text,
                    Modelo = txtModelo.Text,
                    Procesador = txtProcesador.Text,
                    MemoriaRam = Convert.ToInt32(txtMemoriaRam.Text),
                    Almacenamiento = Convert.ToInt32(txtAlmacenamiento.Text),
                    SistemaOperativo = txtSistemaOperativo.Text,
                    AltaStock = Int32.Parse(txtAlta.Text),
                    BajaStock = Int32.Parse(txtBaja.Text),
                    Cantidad = int.Parse(txtCantidadProducto.Text)
                };
                StockAccess.ActualizarComputadoraStock(nuevaComputadoraEditada);
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }  
    }
 }
