using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using N_Escuela;
using Ent_Escuela;
namespace Main.cs
{
    public partial class ListadoEstudiante : Form
    {
        N_Pagos _negocio;
        Entidad_Facturas _facturas;
        Entidad_Pagos _pago;
        Entidad_Estudiantes _estudiante;
        public ListadoEstudiante()
        {
            _negocio = new N_Pagos();
            _facturas = new Entidad_Facturas();
            _pago = new Entidad_Pagos();
            _estudiante = new Entidad_Estudiantes();
            InitializeComponent();
        }

        private void ListadoEstudiante_Load(object sender, EventArgs e)
        {
            Mostrar();
        }
        #region Metodos Privados
        private DataTable Mostrar()
        {
            DataTable dt = _negocio.Mostrar(_pago, _facturas);
            dtgListado.DataSource = dt;
            return dt;
        }
        #endregion

        private void dtgListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {

          

        }
        private void comboServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboCurso.Enabled = true;
            if(comboServicio.Text == "")
            {
                comboCurso.Items.Clear();
                comboCurso.Text = "";
            }
            else if (comboServicio.SelectedIndex == 1)
            {
                comboCurso.Items.Clear();
                comboCurso.Items.Add("Parvulo");
                comboCurso.Items.Add("Pre-Kinder");
                comboCurso.Items.Add("Kinder");
                comboCurso.Items.Add("Pre-Primario");
            }
            else if(comboServicio.SelectedIndex == 2)
            {
                comboCurso.Items.Clear();
                comboCurso.Items.Add("1ero Basica");
                comboCurso.Items.Add("2do Basica");
                comboCurso.Items.Add("3ero Basica");
                comboCurso.Items.Add("4to Basica");
                comboCurso.Items.Add("5to Basica");
                comboCurso.Items.Add("6to Basica");

            }
            else if (comboServicio.SelectedIndex == 3)
            {
                comboCurso.Items.Clear();
                comboCurso.Items.Add("1ero Secundaria");
                comboCurso.Items.Add("2do Secundaria");
            }
            _estudiante.Nombre = txtBuscar.Text;
            _estudiante.Servicio = comboServicio.Text;
            _estudiante.Curso = comboCurso.Text;
            EstudiantesFiltrados();
        }

        private Entidad_Pagos EnviarDatosPago()
        {

            _pago.Inscripcion = int.Parse(dtgListado.CurrentRow.Cells["Inscripcion"].Value.ToString());
            _pago.Mensualidad = int.Parse(dtgListado.CurrentRow.Cells["Mensualidad"].Value.ToString());
            _pago.FechaPago = dtgListado.CurrentRow.Cells["FechaPago"].Value.ToString();
            _pago.IDPagos = int.Parse(dtgListado.CurrentRow.Cells["ID"].Value.ToString());
            return _pago;
        }

        private Entidad_Estudiantes EnviarDatosEstudiante()
        {
            _estudiante.Nombre = dtgListado.CurrentRow.Cells["Nombre"].Value.ToString();
            _estudiante.Servicio = dtgListado.CurrentRow.Cells["Servicio"].Value.ToString();
            _estudiante.Curso = dtgListado.CurrentRow.Cells["Curso"].Value.ToString();
            return _estudiante;
        }
        private Entidad_Facturas EnviarDatosFactura()
        {
            _facturas.MesesPagos = int.Parse(dtgListado.CurrentRow.Cells["MesesPagos"].Value.ToString());
            return _facturas;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
           
         
        }
        private DataTable EstudiantesFiltrados()
        {
            DataTable dt = _negocio.BuscarPago(_estudiante, _facturas);
            dtgListado.DataSource = dt;
            return dt;
        }

        private void comboCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            _estudiante.Nombre = txtBuscar.Text;
            _estudiante.Servicio = comboServicio.Text;
            _estudiante.Curso = comboCurso.Text;
            EstudiantesFiltrados();

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Main _main = new Main();
            _main.Show();
            this.Close();
        }

        private void dtgListado_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
        }

        private void dtgListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarPagos mostrarpagos = new MostrarPagos();
            Entidad_Estudiantes datosEstudiante = EnviarDatosEstudiante();
            Entidad_Facturas datosFactura = EnviarDatosFactura();
            Entidad_Pagos datosPago = EnviarDatosPago();
            mostrarpagos.DatosPago(_estudiante, _facturas, _pago);
            mostrarpagos.Show();
            this.Close();
          
        }

        private void checkDeuda_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private DataTable BuscarNoPago()
        {
            DataTable dt = _negocio.BuscarNoPago(_estudiante);
            dtgListado.DataSource = dt;
            return dt;
        }

        private void dtgListado_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            MostrarPagos mostrarpagos = new MostrarPagos();
            Entidad_Estudiantes datosEstudiante = EnviarDatosEstudiante();
            Entidad_Facturas datosFactura = EnviarDatosFactura();
            Entidad_Pagos datosPago = EnviarDatosPago();
            mostrarpagos.DatosPago(_estudiante, _facturas, _pago);
            mostrarpagos.Show();
        }

        private void comboServicio_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboCurso.Enabled = true;
            if (comboServicio.Text == "")
            {
                comboCurso.Items.Clear();
                comboCurso.Text = "";
            }
            else if (comboServicio.SelectedIndex == 1)
            {
                comboCurso.Items.Clear();
                comboCurso.Items.Add("Parvulo");
                comboCurso.Items.Add("Pre-Kinder");
                comboCurso.Items.Add("Kinder");
                comboCurso.Items.Add("Pre-Primario");
            }
            else if (comboServicio.SelectedIndex == 2)
            {
                comboCurso.Items.Clear();
                comboCurso.Items.Add("1ero Basica");
                comboCurso.Items.Add("2do Basica");
                comboCurso.Items.Add("3ero Basica");
                comboCurso.Items.Add("4to Basica");
                comboCurso.Items.Add("5to Basica");
                comboCurso.Items.Add("6to Basica");

            }
            else if (comboServicio.SelectedIndex == 3)
            {
                comboCurso.Items.Clear();
                comboCurso.Items.Add("1ero Secundaria");
                comboCurso.Items.Add("2do Secundaria");
            }
            _estudiante.Nombre = txtBuscar.Text;
            _estudiante.Servicio = comboServicio.Text;
            _estudiante.Curso = comboCurso.Text;
            _facturas.Deuda = checkDeuda.Checked;
            EstudiantesFiltrados();

        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            _estudiante.Nombre = txtBuscar.Text;
            _estudiante.Servicio = comboServicio.Text;
            _estudiante.Curso = comboCurso.Text;
            _facturas.Deuda = checkDeuda.Checked;
            EstudiantesFiltrados();
        }

        private void checkDeuda_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkDeuda.Checked == true)
            {
                BuscarNoPago();
                EstudiantesFiltrados();

            }
            else if (checkDeuda.Checked == false)
            {
                Mostrar();
                comboServicio.SelectedIndex = 0;
                comboCurso.Enabled = false;
            }
        }

        private void comboCurso_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            _estudiante.Nombre = txtBuscar.Text;
            _estudiante.Servicio = comboServicio.Text;
            _estudiante.Curso = comboCurso.Text;
            EstudiantesFiltrados();
        }
    }
}
