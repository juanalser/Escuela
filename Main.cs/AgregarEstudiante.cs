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
    public partial class AgregarEstudiante : Form
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
        public AgregarEstudiante()
        {
            InitializeComponent();
            adm = new Entidad_Administrador();
            _entidad = new Entidad_Estudiantes();
            _entidadPagos = new Entidad_Pagos();
            _entidadFacturas = new Entidad_Facturas();
            _negocio = new N_Estudiantes();
            _pagos = new N_Pagos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(editar == false)
                {
                    if (txtNombre.Text != "" && txtPadre.Text != "" || txtMadre.Text != "" && txtMov.Text != "" || txtTel.Text != "")
                    {
                        _entidad.Nombre = txtNombre.Text;
                        if (radioMasculino.Checked)
                        {
                            _entidad.Sexo = radioMasculino.Text;
                        }
                        else if (radioFemenino.Checked)
                        {
                            _entidad.Sexo = radioFemenino.Text;
                        }
                        _entidad.Padre = txtPadre.Text;
                        _entidad.Madre = txtMadre.Text;
                        _entidad.Tutor = txtTutor.Text;
                        _entidad.Telefono = txtTel.Text;
                        _entidad.Movil = txtMov.Text;
                        _entidad.Año = dtpAno.Value.ToString();
                        _entidad.Servicio = comboServicio.Text;
                        _entidad.Curso = comboCurso.Text;
                        
                        DataGridViewRow row = dtgMontos.Rows[0];
                        _entidad.IDAdministrador = int.Parse(row.Cells["IDAdministrador"].Value.ToString());
                        _entidadPagos.Inscripcion = int.Parse(row.Cells["Inscripcion"].Value.ToString());
                        _entidadPagos.Mensualidad = int.Parse(row.Cells["Mensualidad"].Value.ToString());
                        _entidadPagos.IDEstudiante = _entidad.IDEstudiante;
                        _entidadFacturas.MesesPagos = 0;
                        _entidadFacturas.IDEstudiante = IDEstudiante;
                        _entidadFacturas.IDPagos = IDPagos;
                        _entidadPagos.FechaPago = dtpAno.Value.ToString();
                        _entidadPagos.IDPagos = IDPagos;    
                        _entidadFacturas.IDFacturas = IDFacturas;
                        _negocio.InsertarEst(_entidad, _entidadPagos, _entidadFacturas);
                        Mostrar();
                        MessageBox.Show("Estudiante Agregado");
                        Limpiar();

                    }

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
            try
            {
                if(editar == true)
                {
                    if(txtNombre.Text != "" && txtPadre.Text != "" || txtMadre.Text != "" && txtMov.Text != "" || txtTel.Text != "")
                    {
                        _entidad.Nombre = txtNombre.Text;
                        if (radioMasculino.Checked)
                        {
                            _entidad.Sexo = radioMasculino.Text;
                        }
                        else if (radioFemenino.Checked)
                        {
                            _entidad.Sexo = radioFemenino.Text;
                        }
                        _entidad.Padre = txtPadre.Text;
                        _entidad.Madre = txtMadre.Text;
                        _entidad.Tutor = txtTutor.Text;
                        _entidad.Telefono = txtTel.Text;
                        _entidad.Movil = txtMov.Text;
                        _entidad.Año = dtpAno.Value.ToString();
                        _entidad.Servicio = comboServicio.Text;
                        _entidad.Curso = comboCurso.Text;

                        _entidad.IDEstudiante = IDEstudiante;
                        _negocio.EditarEst(_entidad);
                        Mostrar();
                        MessageBox.Show("Estudiante Actualizado");
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Faltan campos importantes por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main _main = new Main();
            _main.Show();
            this.Close();
        }
        #region Metodos Privados
        public DataTable Mostrar()
        {
            DataTable dt = _negocio.Mostrar(_entidad);
            dtgTablaAgregarEstudiante.DataSource = dt;

            return dt;

        }

        public DataTable MostrarInvisible()
        {
            DataTable dt2 = _pagos.MostrarAdmin(adm);
            dtgMontos.DataSource = dt2;
            return dt2;
        }
        private void Limpiar()
        {
            txtNombre.Text = "";
            txtPadre.Text = "";

            txtMadre.Text = "";

            txtTutor.Text = "";

            txtTel.Text = "";

            txtMov.Text = "";

            dtpAno.Text = "";

            comboCurso.Text = "Ninguno";

        }
        #endregion

        private void AgregarEstudiante_Load(object sender, EventArgs e)
        {
            Mostrar();
            MostrarInvisible();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar = true;
            if(dtgTablaAgregarEstudiante.Rows.Count > 0)
            {
                txtNombre.Text = dtgTablaAgregarEstudiante.CurrentRow.Cells["Nombre"].Value.ToString();
                string valorRadioButton = dtgTablaAgregarEstudiante.CurrentRow.Cells["Sexo"].Value.ToString();

                if (valorRadioButton == "M")
                {
                    radioMasculino.Checked = true;
                }
                else if (valorRadioButton == "F")
                {
                    radioFemenino.Checked = true;
                }
                txtPadre.Text = dtgTablaAgregarEstudiante.CurrentRow.Cells["Padre"].Value.ToString(); 
                txtMadre.Text = dtgTablaAgregarEstudiante.CurrentRow.Cells["Madre"].Value.ToString();
                txtTutor.Text = dtgTablaAgregarEstudiante.CurrentRow.Cells["Tutor"].Value.ToString();
                txtTel.Text = dtgTablaAgregarEstudiante.CurrentRow.Cells["Telefono"].Value.ToString();
                txtMov.Text = dtgTablaAgregarEstudiante.CurrentRow.Cells["Movil"].Value.ToString();
                dtpAno.Text = dtgTablaAgregarEstudiante.CurrentRow.Cells["Año"].Value.ToString();
                comboServicio.Text = dtgTablaAgregarEstudiante.CurrentRow.Cells["Servicio"].Value.ToString();
                comboCurso.Text = dtgTablaAgregarEstudiante.CurrentRow.Cells["Curso"].Value.ToString();
               
                IDEstudiante = int.Parse(dtgTablaAgregarEstudiante.CurrentRow.Cells["Id"].Value.ToString());
            }
        }


        public Entidad_Estudiantes EnviarDatos()
        {
            _entidad.Nombre = dtgTablaAgregarEstudiante.CurrentRow.Cells["Nombre"].Value.ToString();
            string valorRadioButton = dtgTablaAgregarEstudiante.CurrentRow.Cells["Sexo"].Value.ToString();

            if (valorRadioButton == "M")
            {
                _entidad.Sexo = valorRadioButton;
            }
            else if (valorRadioButton == "F")
            {
                _entidad.Sexo = valorRadioButton;
            }
            _entidad.Padre = dtgTablaAgregarEstudiante.CurrentRow.Cells["Padre"].Value.ToString();
            _entidad.Madre = dtgTablaAgregarEstudiante.CurrentRow.Cells["Madre"].Value.ToString();
            _entidad.Tutor = dtgTablaAgregarEstudiante.CurrentRow.Cells["Tutor"].Value.ToString();
            _entidad.Telefono = dtgTablaAgregarEstudiante.CurrentRow.Cells["Telefono"].Value.ToString();
            _entidad.Movil = dtgTablaAgregarEstudiante.CurrentRow.Cells["Movil"].Value.ToString();
            _entidad.Año = dtgTablaAgregarEstudiante.CurrentRow.Cells["Año"].Value.ToString();
            _entidad.Servicio = dtgTablaAgregarEstudiante.CurrentRow.Cells["Servicio"].Value.ToString();
            _entidad.Curso = dtgTablaAgregarEstudiante.CurrentRow.Cells["Curso"].Value.ToString();

            _entidad.IDEstudiante = int.Parse(dtgTablaAgregarEstudiante.CurrentRow.Cells["Id"].Value.ToString());

            return _entidad;

        }

        private void dtgTablaAgregarEstudiante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarEstudiante estudiante = new MostrarEstudiante();
            Entidad_Estudiantes datosEstudiante = EnviarDatos();
            estudiante.DatosEstudiante(datosEstudiante);
            this.Close();
            estudiante.Show();
        }

        private void comboServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboCurso.Enabled = true;
            if (comboServicio.Text == "")
            {
                comboCurso.Text = "";
            }
            else if (comboServicio.SelectedIndex == 0)
            {
                comboCurso.Items.Clear();
                comboCurso.Items.Add("Parvulo");
                comboCurso.Items.Add("Pre-Kinder");
                comboCurso.Items.Add("Kinder");
                comboCurso.Items.Add("Pre-Primario");
            }
            else if (comboServicio.SelectedIndex == 1)
            {
                comboCurso.Items.Clear();
                comboCurso.Items.Add("1ero Basica");
                comboCurso.Items.Add("2do Basica");
                comboCurso.Items.Add("3ero Basica");
                comboCurso.Items.Add("4to Basica");
                comboCurso.Items.Add("5to Basica");
                comboCurso.Items.Add("6to Basica");

            }
            else if (comboServicio.SelectedIndex == 2)
            {
                comboCurso.Items.Clear();
                comboCurso.Items.Add("1ero Secundaria");
                comboCurso.Items.Add("2do Secundaria");
            }
        }
    }
}
