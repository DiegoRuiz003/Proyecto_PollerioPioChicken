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
    public partial class MantenedorInsumo : Form
    {
        public MantenedorInsumo()
        {
            InitializeComponent();
            ListarTipoInsumo();
            ListarInsumo();
            gbDatos.Enabled = false;
        }

        public void ListarTipoInsumo()
        {
            cbbTipoInsumo.DataSource = LogInsumo.Instancia.ListarTipoInsumo();
        }

        public void ListarInsumo()
        {
            dgvInsumo.DataSource = LogInsumo.Instancia.ListarInsumo();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            btnAgregar.Visible = true;
            LimpiarVariables();
            btnModificar.Visible = false;
        }

        private void LimpiarVariables()
        {
            txtId.Text = "";
            txtNombre.Text = " ";
            cbbTipoInsumo.SelectedIndex = -1;
            nudCantidad.Value = 0;
            cbEstado.Checked = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                EntInsumo insumo = new EntInsumo();
                insumo.id = txtId.Text;
                insumo.nombre = txtNombre.Text;
                insumo.idtipoinsumo= cbbTipoInsumo.SelectedItem.ToString();
                insumo.cantidad = Convert.ToInt16(nudCantidad.Value);
                insumo.estado = cbEstado.Checked;
                LogInsumo.Instancia.InsertarInsumo(insumo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatos.Enabled = false;
            ListarInsumo();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                EntInsumo insumo = new EntInsumo();
                insumo.id = txtId.Text;
                insumo.nombre = txtNombre.Text;
                insumo.idtipoinsumo = cbbTipoInsumo.SelectedItem.ToString();
                insumo.cantidad = Convert.ToInt16(nudCantidad.Value);
                insumo.estado = cbEstado.Checked;
                LogInsumo.Instancia.EditarInsumo(insumo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatos.Enabled = false;
            ListarInsumo();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbDatos.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;

        }

        private void dgvTipoPlato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvInsumo.Rows[e.RowIndex]; //
            txtId.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            cbbTipoInsumo.Text = filaActual.Cells[2].Value.ToString();
            nudCantidad.Value = Convert.ToInt16(filaActual.Cells[3].Value);
            cbEstado.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                EntInsumo insumo = new EntInsumo();
                insumo.id = txtId.Text;
                LogInsumo.Instancia.DeshabilitarInsumo(insumo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gbDatos.Enabled = false;
            ListarInsumo();

        }
    }
}
