using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ent_Escuela;
using N_Escuela;
namespace Main.cs
{
    public partial class Admin : Form
    {
        private bool editar = false;
        private int IDAdministrador;
        Entidad_Administrador _entidad;
        N_Pagos _negocio;
        public Admin()
        {
            _negocio = new N_Pagos();
            _entidad = new Entidad_Administrador();
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (editar == false)
                {
                    _entidad.Inscripcion = int.Parse(txtInscripcion.Text);
                    _entidad.Mensualidad = int.Parse(txtMensualidad.Text);

                    _entidad.IDAdministrador = IDAdministrador;
                    _negocio.InsertarAdmin(_entidad);
                    Mostrar();
                    MessageBox.Show("Estudiante Agregado");
                    Limpiar();

                }
            }
            catch (Exception)
            {

                throw;
            }
            try
            {
                if (editar == true)
                {
                    _entidad.Inscripcion = int.Parse(txtInscripcion.Text);
                    _entidad.Mensualidad = int.Parse(txtMensualidad.Text);

                    _entidad.IDAdministrador = IDAdministrador;
                    _negocio.EditarAdmin(_entidad);
                    Mostrar();
                    MessageBox.Show("Estudiante Actualizado");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Faltan campos importantes por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public DataTable Mostrar()
        {
            DataTable dt = _negocio.MostrarAdmin(_entidad);
            dtgAdmin.DataSource = dt;
            return dt;

        }
        private void Limpiar()
        {
            txtInscripcion.Text = "";

            txtMensualidad.Text = "";

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            Mostrar();
            if (dtgAdmin.Rows.Count > 0)
            {
                editar = true;
                txtInscripcion.Text = dtgAdmin.CurrentRow.Cells["Inscripcion"].Value.ToString();
                txtMensualidad.Text = dtgAdmin.CurrentRow.Cells["Mensualidad"].Value.ToString();
                IDAdministrador = int.Parse(dtgAdmin.CurrentRow.Cells["IDAdministrador"].Value.ToString());
            }

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
