using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ent_Escuela;
namespace D_Escuela
{
    public class D_Pagos
    {
        
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs_Escuela"].ConnectionString);

        public void InsertarPago(Entidad_Pagos pagos)
        {
            SqlCommand com = new SqlCommand("sp_InsertarPago", conn);
            com.CommandType = CommandType.StoredProcedure;
            conn.Open();
            com.Parameters.AddWithValue("Inscripcion", pagos.Inscripcion);
            com.Parameters.AddWithValue("Mensualidad", pagos.Mensualidad);
            com.Parameters.AddWithValue("FechaPago", pagos.FechaPago);

            com.ExecuteNonQuery();
            conn.Close();

        }
        public void InsertarFactura(Entidad_Facturas facturas)
        {
            SqlCommand com = new SqlCommand("sp_InsertarFactura", conn);
            com.CommandType = CommandType.StoredProcedure;
            conn.Open();
            com.Parameters.AddWithValue("MesesPagos", facturas.MesesPagos);

            com.ExecuteNonQuery();
            conn.Close();

        }
        public void EditarPago(Entidad_Pagos pagos, Entidad_Facturas facturas)
        {
            SqlCommand com = new SqlCommand("sp_EditarPago", conn);
            com.CommandType = CommandType.StoredProcedure;
            conn.Open();
            com.Parameters.AddWithValue("IDPago", pagos.IDPagos);
            com.Parameters.AddWithValue("Mensualidad", pagos.Mensualidad);
            com.Parameters.AddWithValue("MesesPagos", facturas.MesesPagos);
            com.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable MostrarPago(Entidad_Pagos pagos, Entidad_Facturas facturas)
        {
            SqlCommand com = new SqlCommand("sp_MostrarPago", conn);
            com.CommandType = CommandType.StoredProcedure;
            conn.Open();

            SqlDataReader leer = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(leer);
            conn.Close();
            return dt;


        }

        #region Administrador
        public DataTable MostrarAdmin(Entidad_Administrador administrador)
        {
            SqlCommand com = new SqlCommand("sp_MostrarAdministrador", conn);
            com.CommandType = CommandType.StoredProcedure;
            conn.Open();

            SqlDataReader leer = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(leer);
            conn.Close();
            return dt;


        }

        public void InsertarAdministrador(Entidad_Administrador admin)
        {
            SqlCommand com = new SqlCommand("sp_InsertarAdmin", conn);
            com.CommandType = CommandType.StoredProcedure;
            conn.Open();
            com.Parameters.AddWithValue("Inscripcion", admin.Inscripcion);
            com.Parameters.AddWithValue("Mensualidad", admin.Mensualidad);

            com.ExecuteNonQuery();
            conn.Close();

        }
        public void EditarAdmin(Entidad_Administrador admin)
        {
            SqlCommand com = new SqlCommand("sp_EditarAdministrador", conn);
            com.CommandType = CommandType.StoredProcedure;
            conn.Open();
            com.Parameters.AddWithValue("ID", admin.IDAdministrador);
            com.Parameters.AddWithValue("Inscripcion", admin.Inscripcion);
            com.Parameters.AddWithValue("Mensualidad", admin.Mensualidad);
            com.ExecuteNonQuery();
            conn.Close();
        }


        #endregion

        public DataTable BuscarPago(Entidad_Estudiantes estudiante, Entidad_Facturas facturas)
        {
            SqlCommand com = new SqlCommand("sp_BuscarEstudiante", conn);
            com.CommandType = CommandType.StoredProcedure;
            conn.Open();

            com.Parameters.AddWithValue("Nombre", estudiante.Nombre);
            com.Parameters.AddWithValue("Servicio", estudiante.Servicio);
            com.Parameters.AddWithValue("Curso", estudiante.Curso);
            com.Parameters.AddWithValue("Deuda", facturas.MesesPagos);
            SqlDataReader leer = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(leer);
            conn.Close();
            return dt;
        }

        public DataTable BuscarNoPago(Entidad_Estudiantes estudiante)
        {
            SqlCommand com = new SqlCommand("sp_BuscarEstudianteNoPago", conn);
            com.CommandType = CommandType.StoredProcedure;
            conn.Open();

      
            SqlDataReader leer = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(leer);
            conn.Close();
            return dt;
        }
    }
}
