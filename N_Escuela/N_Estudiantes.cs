using Ent_Escuela;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D_Escuela;
using System.Data;

namespace N_Escuela
{
    public class N_Estudiantes
    {
        D_Estudiantes _datos = new D_Estudiantes();
        public void InsertarEst(Entidad_Estudiantes estudiantes, Entidad_Pagos pagos, Entidad_Facturas facturas)
        {
            _datos.Insertar(estudiantes, pagos, facturas);
        }
        public void EditarEst(Entidad_Estudiantes estudiantes)
        {
            _datos.Editar(estudiantes);
        }
        public void EliminarEst(int ID)
        {
            _datos.Eliminar(ID);
        }
        public DataTable Mostrar(Entidad_Estudiantes Estudiante)
        {
            DataTable dt = _datos.Mostrar(Estudiante);
            return dt;
        } 
        public DataTable Buscar(string buscar)
        {
            return _datos.Buscar(buscar);
        }
        public void CopiarRegistros()
        {
            _datos.CopiarEstudiantes();
        }
        public DataTable MostrarAlmacen(Entidad_Estudiantes Estudiante)
        {
            DataTable dt = _datos.MostrarAlmacen(Estudiante);
            return dt;
        }
        public string TrasladoAlmacen(Entidad_Estudiantes Estudiante)
        {
            string Mensaje = _datos.CompararAlmacen(Estudiante);
            Estudiante.Mensaje = Mensaje;
            return Estudiante.Mensaje;
            
        }
    }
}
