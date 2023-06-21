using Ent_Escuela;
using N_Escuela;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.cs
{
    public partial class Almacen : Form
    {
        Entidad_Administrador adm;
        Entidad_Estudiantes _entidad;
        Entidad_Pagos _entidadPagos;
        Entidad_Facturas _entidadFacturas;
        N_Estudiantes _negocio;
        N_Pagos _pagos;
        private bool editar = false;
        private int IDEstudiante;
        private int IDPagos;
        private int IDFacturas;
        public Almacen()
        {
            InitializeComponent();
            adm = new Entidad_Administrador();
            _entidad = new Entidad_Estudiantes();
            _entidadPagos = new Entidad_Pagos();
            _entidadFacturas = new Entidad_Facturas();
            _negocio = new N_Estudiantes();
            _pagos = new N_Pagos();
        }

        private void comboServicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {

        }

        private void Almacen_Load(object sender, EventArgs e)
        {
            Mostrar();
            MostrarPago();
        }
        private DataTable Mostrar()
        {

            DataTable dt = _negocio.MostrarAlmacen(_entidad);
            dtgAlmacen.DataSource = dt;

            return dt;

        }
        private DataTable MostrarPago()
        {

            DataTable dt2 = _pagos.MostrarAdmin(adm);
            dtgMontos.DataSource = dt2;
            return dt2;

        }

        private void dtgAlmacen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgAlmacen_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            _entidad.Nombre = dtgAlmacen.CurrentRow.Cells["Nombre"].Value.ToString();
            _entidad.Sexo = dtgAlmacen.CurrentRow.Cells["Sexo"].Value.ToString();
            _entidad.Padre = dtgAlmacen.CurrentRow.Cells["Padre"].Value.ToString();
            _entidad.Madre = dtgAlmacen.CurrentRow.Cells["Madre"].Value.ToString();
            _entidad.Tutor = dtgAlmacen.CurrentRow.Cells["Tutor"].Value.ToString();
            _entidad.Telefono = dtgAlmacen.CurrentRow.Cells["Telefono"].Value.ToString();
            _entidad.Movil = dtgAlmacen.CurrentRow.Cells["Movil"].Value.ToString();
            _entidad.Año = dtgAlmacen.CurrentRow.Cells["Año"].Value.ToString();
            _entidad.Servicio = dtgAlmacen.CurrentRow.Cells["Servicio"].Value.ToString();
            _entidad.Curso = dtgAlmacen.CurrentRow.Cells["Curso"].Value.ToString();

            DataGridViewRow row = dtgMontos.Rows[0];
            _entidad.IDAdministrador = int.Parse(row.Cells["IDAdministrador"].Value.ToString());
            _entidadPagos.Inscripcion = int.Parse(row.Cells["Inscripcion"].Value.ToString());
            _entidadPagos.Mensualidad = int.Parse(row.Cells["Mensualidad"].Value.ToString());
            _entidadPagos.IDEstudiante = _entidad.IDEstudiante;
            _entidadFacturas.MesesPagos = 0;
            _entidadFacturas.IDEstudiante = IDEstudiante;
            _entidadFacturas.IDPagos = IDPagos;
            _entidadPagos.FechaPago = _entidad.Año;
            _entidadPagos.IDPagos = IDPagos;
            _entidadFacturas.IDFacturas = IDFacturas;

            gunaLabel1.Text = _entidad.Nombre;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            _negocio.TrasladoAlmacen(_entidad);
            string Mensaje = _entidad.Mensaje;
            if (Mensaje == "El estudiante ya existe")
            {
                MessageBox.Show("Este estudiante ya existe", "Advertencia");
            }
            else if (Mensaje == "")
            {
                _negocio.InsertarEst(_entidad, _entidadPagos, _entidadFacturas);

            }
        }
    }
}
