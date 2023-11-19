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
    public partial class RealizaNotadeSalida : Form
    {
        public RealizaNotadeSalida()
        {
            InitializeComponent();
            listarNotaSalida();
            LimpiarVariables();
        }

        public void listarNotaSalida()
        {
            dgvDetNotSalida.DataSource = LogNotaSalida.Instancia.ListarNotaSalida();
        }
        private void LimpiarVariables()
        {
            txtNomInsumo.Text = "";
            nudCantidad.Value = nudCantidad.Minimum;
            dtPickerRegInsumo.Value = DateTime.Now;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                EntNotaSalida sal = new EntNotaSalida();
                sal.Producto = txtNomInsumo.Text.Trim();
                sal.Cantidad = int.Parse(nudCantidad.Text.Trim());
                sal.FecRegInsumo = dtPickerRegInsumo.Value;
                //ing.Estado
                LogNotaSalida.Instancia.InsertarNotaSalida(sal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            //grupBoxDatos.Enabled = false;
            listarNotaSalida();
        }

        private void dgvDetNotSalida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvDetNotSalida.Rows[e.RowIndex];
            //IdProducto.Text = filaActual.Cells[0].Value.ToString();
            txtNomInsumo.Text = filaActual.Cells[1].Value.ToString();
            nudCantidad.Text = filaActual.Cells[2].Value.ToString();
            dtPickerRegInsumo.Text = filaActual.Cells[3].Value.ToString();
            //Estado.Checked=Convert.ToBoolean(filaActual.Cells[4].Value);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                EntNotaSalida sal = new EntNotaSalida();
                //sal.IdProducto
                sal.Producto = txtNomInsumo.Text.Trim();
                sal.Cantidad = int.Parse(nudCantidad.Text.Trim());
                sal.FecRegInsumo = dtPickerRegInsumo.Value;
                //sal.Estado
                LogNotaSalida.Instancia.InsertarNotaSalida(sal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            //grupBoxDatos.Enabled = false;
            listarNotaSalida();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {/*
            try
            {
                EntNotaSalida sal = new EntNotaSalida();
                ing.Id = int.Parse(txtIdProducto.Text.Trim());
                Estado.Checked = false;
                ing.Estado = Estado.Checked;
                LogNotaSalida.Instancia.AnularNotaSalida(sal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            //grupBoxDatos.Enabled = false;
            listarNotaSalida();
            */
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
