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
    public partial class MostrarEstudiante : Form
    {
        N_Estudiantes _negocio;
        int ID;
        Entidad_Estudiantes _entidad;
        public MostrarEstudiante()
        {
            _entidad = new Entidad_Estudiantes();
            _negocio = new N_Estudiantes();
            InitializeComponent();
        }


        private void MostrarEstudiante_Load(object sender, EventArgs e)
        {
            lbNombre.Text = _entidad.Nombre;
            lbPadre.Text = _entidad.Padre;
            lbMadre.Text = _entidad.Madre;
            lbTutor.Text = _entidad.Tutor;
            lbTelefono.Text = _entidad.Telefono;
            lbMovil.Text = _entidad.Movil;
            lbAño.Text = _entidad.Año.ToString();
            lbCurso.Text = _entidad.Curso;
            lbSexo.Text = _entidad.Sexo;
            lbServicio.Text = _entidad.Servicio;
        }

        public void DatosEstudiante(Entidad_Estudiantes estudiante)
        {
            _entidad.Nombre = estudiante.Nombre;
            _entidad.Padre = estudiante.Padre;
            _entidad.Madre = estudiante.Madre;
            _entidad.Tutor = estudiante.Tutor;
            _entidad.Telefono = estudiante.Telefono;
            _entidad.Movil = estudiante.Movil;
            _entidad.Año = estudiante.Año;
            _entidad.Curso = estudiante.Curso;
            _entidad.Servicio = estudiante.Servicio;
            _entidad.Sexo = estudiante.Sexo;
            ID = estudiante.IDEstudiante;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
      
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarEstudiante estudiante = new AgregarEstudiante();
            estudiante.Show();
            this.Close();
 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea eliminar a " + _entidad.Nombre + " definitivamente?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _negocio.EliminarEst(ID);
                this.Close();

            }
            else
            {

            }
        }
    }
}
