using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sotfware_PolleriaPioChicken
{
    public partial class RealizaNotadeIngreso : Form
    {
        public RealizaNotadeIngreso()
        {
            InitializeComponent();
            listarNotaIngreso();
            LimpiarVariables();
        }

        public void listarNotaIngreso()
        {
            dgvDetNotInsumo.DataSource = LogNotaIngreso.Instancia.ListarNotaIngreso();
        }
        private void LimpiarVariables()
        {
            txtNomInsumo.Text = "";
            txtNomProveedor.Text = "";
            nudCantidad.Value = nudCantidad.Minimum;
            txtPrecio.Text = "";
            dtPickerRegInsumo.Value = DateTime.Now;
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                EntNotaIngreso ing = new EntNotaIngreso();
                ing.Producto = txtNomInsumo.Text.Trim();
                ing.Proveedor = txtNomProveedor.Text.Trim();
                ing.Cantidad = int.Parse(nudCantidad.Text.Trim());
                ing.Precio = int.Parse(txtPrecio.Text.Trim());
                ing.FecRegInsumo = dtPickerRegInsumo.Value;
                LogNotaIngreso.Instancia.InsertarNotaIngreso(ing);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            //grupBoxDatos.Enabled = false;
            listarNotaIngreso();
        }

        private void dgvDetNotInsumo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvDetNotInsumo.Rows[e.RowIndex];
            //IdProducto.Text = filaActual.Cells[0].Value.ToString();
            txtNomProveedor.Text = filaActual.Cells[1].Value.ToString();
            nudCantidad.Text = filaActual.Cells[2].Value.ToString();
            txtPrecio.Text = filaActual.Cells[3].Value.ToString();
            dtPickerRegInsumo.Text = filaActual.Cells[4].Value.ToString();
            //Estado.Checked=Convert.ToBoolean(filaActual.Cells[5].Value);

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void btnAnular_Click(object sender, EventArgs e)
        {/*
            try
            {
                entProveedor pro = new entProveedor();
                pro.Id = int.Parse(txtIdProducto.Text.Trim());
                Estado.Checked = false;
                pro.Estado = Estado.Checked;
                logProveedor.Instancia.EliminarProveedor(pro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            //grupBoxDatos.Enabled = false;
            listarNotaIngreso();
            */
        }
    }
}
