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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Estudiante_Form_Load(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Llamo el formulario de AgregarEstudiantes y presento su vista, a la vez que oculto esta misma
            AgregarEstudiante agregar = new AgregarEstudiante();
            agregar.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Llamo el formulario de ListadoEstudiante y presento su vista, a la vez que oculto esta misma
            ListadoEstudiante list = new ListadoEstudiante();
            list.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            //Llamo el formulario de Administrador y presento su vista
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            //Llamo el formulario de Administrador y presento su vista
            Gunalb.Text = "Sesion Admin";
            Gunapict.Image = Properties.Resources.png_transparent_computer_icons_management_chief_executive_manager_icon_black_silhouette_business;
            container(new Admin());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Llamo el formulario de AgregarEstudiantes y presento su vista, a la vez que oculto esta misma
            /*  AgregarEstudiante agregar = new AgregarEstudiante();
              agregar.Show();
              this.Hide();*/
            Gunalb.Text = "Agregar Estudiantes";
            Gunapict.Image = Properties.Resources.png_transparent_computer_icons_student_symbol_reading_student;
            container(new AgregarEstudiante());
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            //Llamo el formulario de ListadoEstudiante y presento su vista, a la vez que oculto esta misma
            Gunalb.Text = "Listado de Estudiantes";
            Gunapict.Image = Properties.Resources.listing_option;
            container(new ListadoEstudiante());

        }

        private void Gunabtn_Click(object sender, EventArgs e)
        {
            Gunalb.Text = "Inicio";
            Gunapict.Image = Properties.Resources.download_axO0aVmSI_transformed;
            
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void container(object _form)
        {
            if (gunaPanel2_Container.Controls.Count > 0) gunaPanel2_Container.Controls.Clear();
            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            gunaPanel2_Container.Controls.Add(fm);
            gunaPanel2_Container.Tag = fm;
            fm.Show();
        }

    }
}
