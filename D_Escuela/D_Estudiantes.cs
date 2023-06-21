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
    public class D_Estudiantes
    {
        string mensaje;
        
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs_Escuela"].ConnectionString);

        public void Insertar(Entidad_Estudiantes entidad, Entidad_Pagos pagos, Entidad_Facturas facturas)
        {
            SqlCommand com = new SqlCommand("sp_InsertarEstudiante", conn);
            com.CommandType = CommandType.StoredProcedure;
            conn.Open();

            //iNSERTAR ESTUDIANTE
            com.Parameters.AddWithValue("IDAdministrador", entidad.IDAdministrador);
            com.Parameters.AddWithValue("Nombre", entidad.Nombre);
            com.Parameters.AddWithValue("Sexo", entidad.Sexo);
            com.Parameters.AddWithValue("Padre", entidad.Padre);
            com.Parameters.AddWithValue("Madre", entidad.Madre);
            com.Parameters.AddWithValue("Tutor", entidad.Tutor);
            com.Parameters.AddWithValue("Telefono", entidad.Telefono);
            com.Parameters.AddWithValue("Movil", entidad.Movil);
            com.Parameters.AddWithValue("Año", entidad.Año);
            com.Parameters.AddWithValue("Servicio", entidad.Servicio);
            com.Parameters.AddWithValue("Curso", entidad.Curso);


            //INSERTAR PAGO
            com.Parameters.AddWithValue("Inscripcion", pagos.Inscripcion);
            com.Parameters.AddWithValue("Mensualidad", pagos.Mensualidad);
            com.Parameters.AddWithValue("FechaPago", pagos.FechaPago);

            //INSERTAR FACTURAS
            com.Parameters.AddWithValue("MesesPagos", facturas.MesesPagos);
            com.ExecuteNonQuery();
            conn.Close();
        }
        public void CopiarEstudiantes()
        {
            SqlCommand com = new SqlCommand("sp_CopiarRegistros", conn);
            com.CommandType = CommandType.StoredProcedure;
            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();

        }

        public string CompararAlmacen(Entidad_Estudiantes entidad)
        {
            
            SqlCommand com = new SqlCommand("sp_TrasladoEstudiante", conn);
            com.CommandType = CommandType.StoredProcedure;
            conn.Open();
            com.Parameters.AddWithValue("@NombreEstudiante", entidad.Nombre);
            com.Parameters.Add("@Mensaje", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;

            com.ExecuteNonQuery();
            string Mensaje = com.Parameters["@Mensaje"].Value.ToString();

            conn.Close();
            return Mensaje;

        }

        public DataTable MostrarAlmacen(Entidad_Estudiantes entidad)
        {
            SqlCommand com = new SqlCommand("sp_MostrarAlmacen", conn);
            com.CommandType = CommandType.StoredProcedure;
            conn.Open();

            SqlDataReader leer = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(leer);
            conn.Close();
            return dt;

        }
        public void Editar(Entidad_Estudiantes entidad)
        {
            SqlCommand com = new SqlCommand("sp_EditarEstudiante", conn);
            com.CommandType = CommandType.StoredProcedure;
            conn.Open();
            com.Parameters.AddWithValue("ID", entidad.IDEstudiante);
            com.Parameters.AddWithValue("Nombre", entidad.Nombre);
            com.Parameters.AddWithValue("Sexo", entidad.Sexo);
            com.Parameters.AddWithValue("Padre", entidad.Padre);
            com.Parameters.AddWithValue("Madre", entidad.Madre);
            com.Parameters.AddWithValue("Tutor", entidad.Tutor);
            com.Parameters.AddWithValue("Telefono", entidad.Telefono);
            com.Parameters.AddWithValue("Movil", entidad.Movil);
            com.Parameters.AddWithValue("Año", entidad.Año);
            com.Parameters.AddWithValue("Servicio", entidad.Servicio);
            com.Parameters.AddWithValue("Curso", entidad.Curso);

            com.ExecuteNonQuery();
            conn.Close();
        }

        public void Eliminar(int ID)
        {
            SqlCommand com = new SqlCommand("sp_EliminarEstudiante", conn);
            com.CommandType = CommandType.StoredProcedure;
            conn.Open();

            com.Parameters.AddWithValue("ID", ID);
            com.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable Mostrar(Entidad_Estudiantes entidad)
        {
            SqlCommand com = new SqlCommand("sp_MostrarEstudiante", conn);
            com.CommandType = CommandType.StoredProcedure;
            conn.Open();

            SqlDataReader leer = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(leer);
            conn.Close();
            return dt;

        }
        public DataTable Buscar(string buscar)
        {
            SqlCommand com = new SqlCommand("sp_BuscarEstudiante", conn);
            com.CommandType = CommandType.StoredProcedure;
            conn.Open();

            com.Parameters.AddWithValue("@Buscar", buscar);
            SqlDataAdapter ada = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            conn.Close();
            return dt;
        }




    }
}
