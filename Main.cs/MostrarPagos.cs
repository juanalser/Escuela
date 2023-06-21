using Ent_Escuela;
using Guna.UI.WinForms;
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
    public partial class MostrarPagos : Form
    {
        N_Pagos _negocio;
        Entidad_Facturas _facturas;
        Entidad_Pagos _pago;
        Entidad_Estudiantes _estudiante;
        Entidad_Administrador _admin;
        int MesesPagos;
        int ID;
        public MostrarPagos()
        {
            _negocio = new N_Pagos();
            _facturas = new Entidad_Facturas();
            _pago = new Entidad_Pagos();
            _estudiante = new Entidad_Estudiantes();
            _admin = new Entidad_Administrador();
            InitializeComponent();
        }

        private void MostrarPagos_Load(object sender, EventArgs e)
        {
         
            MostrarAdmin();
            Mostrar();
        

        }
        private GunaCheckBox ObtenerCheckBoxPorMes(int mes)
        {
            string nombreCheckBox = "Check" + mes;
            return Controls.Find(nombreCheckBox, true).FirstOrDefault() as GunaCheckBox;
        }

        public void DatosPago(Entidad_Estudiantes estudiante, Entidad_Facturas facturas, Entidad_Pagos pagos)
        {
            _estudiante.Nombre = estudiante.Nombre;
            _estudiante.Curso = estudiante.Curso;
            _pago.Inscripcion = pagos.Inscripcion;
            _pago.Mensualidad = pagos.Mensualidad;
            _pago.FechaPago = pagos.FechaPago;
            _facturas.MesesPagos = facturas.MesesPagos;
            _facturas.IDFacturas = facturas.IDFacturas;
            _pago.IDPagos = pagos.IDPagos;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
           
            
           
        }
        private DataTable MostrarAdmin()
        {
            DataTable dt = _negocio.MostrarAdmin(_admin);
            dtgAdmin.DataSource = dt;
            return dt;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListadoEstudiante listado = new ListadoEstudiante();
            listado.Show();
            this.Close();

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click_1(object sender, EventArgs e)
        {
        
        }

        private void btnPagar_Click_2(object sender, EventArgs e)
        {
            DataGridViewRow row = dtgAdmin.Rows[0];
            int Sustraendo = int.Parse(lbMensualidad.Text);
            DialogResult result = MessageBox.Show("Se ha efectuado un pago de " + txtMonto.Value + " desea confirmar?", "Confirmacion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                _pago.IDPagos = ID;
                _pago.Mensualidad = Sustraendo - Convert.ToInt32(txtMonto.Value);
                _facturas.MesesPagos = MesesPagos;
                _negocio.EditarPagos(_pago, _facturas);
                Mostrar();
                if (_pago.Mensualidad == 0)
                {
                    _pago.Mensualidad = int.Parse(row.Cells["Mensualidad"].Value.ToString());
                    _negocio.EditarPagos(_pago, _facturas);
                    MessageBox.Show("Pago realizado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mostrar();
                    this.Close();
                }

            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Ingrese el pago correcto", "Advertencia", MessageBoxButtons.OK);
            }

        }

        private void Mostrar()
        {
            lbNombre.Text = _estudiante.Nombre;
            lbCurso.Text = _estudiante.Curso;
            lbInscripcion.Text = _pago.Inscripcion.ToString();
            lbMensualidad.Text = _pago.Mensualidad.ToString();
            lbFecha.Text = _pago.FechaPago.ToString();
            MesesPagos = _facturas.MesesPagos;
            for (int i = 0; i < MesesPagos; i++)
            {
                GunaCheckBox gunacheckBox = ObtenerCheckBoxPorMes(i);
                gunacheckBox.Checked = true;
            }

            ID = _pago.IDPagos;
            txtMonto.Maximum = int.Parse(lbMensualidad.Text);
        }
    }
}
