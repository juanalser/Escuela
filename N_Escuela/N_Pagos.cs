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
    public class N_Pagos
    {
        D_Pagos _pagos = new D_Pagos();
        public void Insertar(Entidad_Pagos pago)
        {
            _pagos.InsertarPago(pago);
        }
        public void InsertarFactura(Entidad_Facturas factura)
        {
            _pagos.InsertarFactura(factura);
        }
        public void EditarPagos(Entidad_Pagos pagos, Entidad_Facturas facturas)
        {
            _pagos.EditarPago(pagos, facturas);
        }
        public DataTable Mostrar(Entidad_Pagos pago, Entidad_Facturas facturas)
        {
            DataTable dt = _pagos.MostrarPago(pago, facturas);
            return dt;
        }
        public void InsertarAdmin(Entidad_Administrador admin)
        {
            _pagos.InsertarAdministrador(admin);
        }
        public DataTable MostrarAdmin(Entidad_Administrador admin)
        {
            DataTable dt = _pagos.MostrarAdmin(admin);
            return dt;
        }
        public void EditarAdmin(Entidad_Administrador admin)
        {
            _pagos.EditarAdmin(admin);
        }
        public DataTable BuscarPago(Entidad_Estudiantes estudiantes, Entidad_Facturas facturas)
        {
            DataTable dt = _pagos.BuscarPago(estudiantes, facturas);
            return dt;
        }
        public DataTable BuscarNoPago(Entidad_Estudiantes estudiantes)
        {
            DataTable dt = _pagos.BuscarNoPago(estudiantes);
            return dt;
        }
    }
}
