using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_RENFERMEDADES.Modelos
{
    public class FUNCIONARIO
    {
        public int idfuncionario { get; set; }
        public String nombre { get; set; }
        public int edad { get; set; }
        public int rut { get; set; }
        public String tipo_profecional { get; set; }
    }
}
