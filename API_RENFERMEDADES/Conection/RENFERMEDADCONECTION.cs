using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_RENFERMEDADES.Conection
{
    public class RENFERMEDADCONECTION
    {
        static string connectionString = @"Server=LAPTOP-FGSQM91F\SQLEXPRESS;Database=APIRENFERMEDADES;Trusted_Connection=True;";

        public static List<registro_enfermedad> registro_Enfermedads;

        public static List<registro_enfermedad> obtenerregistro()
            using (Sqlconnection connection = new sqlconnection))
        ¨{
            Sqlcommand sqlcommand = new Sqlcommand()
         
         }
    
    }
}
