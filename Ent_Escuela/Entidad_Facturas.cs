using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ent_Escuela
{
    public class Entidad_Facturas
    {
        
            public int IDFacturas { get; set; }
            public int IDPagos { get; set; }
            public int IDEstudiante { get; set; }
            public int MesesPagos { get; set; }
            public int EstadoPago { get; set; }
            public bool Deuda { get; set; }


    }
}
