using API_RENFERMEDADES.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace API_RENFERMEDADES.Conection
{
    public class ENFERMEDADCONECTION

    {
        static string connectionString = @"Server=LAPTOP-FGSQM91F\SQLEXPRESS;Database=APIRENFERMEDADES;Trusted_Connection=True;";

        private static List<ENFERMEDAD> Enfermedad;
        private static object dataTableEnfermedades;
        private static object idenfermedad;

        public static List<ENFERMEDAD> ObtenerEnfermedades()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var consultaSql = "select * from ENFERMEDAD";

                var comando = ConsultaSqlEnfermedad(connection, consultaSql);

                var dataTableENFERMEDAD = LlenarDataTable(comando);

                return LLenadoEnfermedades(dataTableEnfermedades);
            }
        }

        private static List<ENFERMEDAD> LLenadoEnfermedades(object dataTableEnfermedades)
        {
            throw new NotImplementedException();
        }

        private static object LlenarDataTable(object comando)
        {
            throw new NotImplementedException();
        }

        internal static ENFERMEDAD ObtenerENFERMEDAD(int idConvertido)
        {
            throw new NotImplementedException();
        }

        internal static ENFERMEDAD ObtenerENFERMEDAD(string eNFERMEDAD)
        {
            throw new NotImplementedException();
        }

        private static object ConsultaSqlEnfermedad(SqlConnection connection, string consultaSql)
        {
            throw new NotImplementedException();
        }

        public static ENFERMEDAD ObtenerENFERMEDADporid(int idenfermedad)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var consultaSql = $"select * from ENFERMEDAD where idenfermedad = {idenfermedad}";

                var comando = ConsultaSqlENFERMEDAD(connection, consultaSql);

                var dataTable = LlenarDataTable(comando);

                return CreacionENFERMEDAD(dataTable);
            }
        }

        private static ENFERMEDAD CreacionENFERMEDAD(object dataTable)
        {
            throw new NotImplementedException();
        }

        private static object ConsultaSqlENFERMEDAD(SqlConnection connection, string consultaSql)
        {
            throw new NotImplementedException();
        }

        public static ENFERMEDAD ObtenerPlantaPorNombre(string nombre_tecnico)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var consultaSql = $"select * from ENFERMEDAD where nombre_tecnico = '{nombre_tecnico}'";

                var comando = ConsultaSqlENFERMEDAD(connection, consultaSql);

                var dataTable = LlenarDataTable(comando);

                return CreacionENFERMEDAD(dataTable);

            }
        }

        public static int AgregarENFERMEDAD(ENFERMEDAD enfermedad)
        {
            int filasAfectadas = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(null, connection);
                sqlCommand.CommandText = "Insert into ENFERMEDAD (idenfermedad,nombre_tecnico) values (@idenfermedad,@nombre_tecnico)";
                sqlCommand.Parameters.AddWithValue("@idenfermedad", enfermedad.idenfermedad;
                SqlParameter sqlParameter = sqlCommand.Parameters.AddWithValue("@nombre_tecnico", enfermedad.nombre_tecnico);

                try
                {
                    connection.Open();
                    filasAfectadas = sqlCommand.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }
            return filasAfectadas;
        }

        public static int AgregarENFERMEDAD(string nombre_tecnico, int idenfermedad)
        {
            int resultado = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(null, connection);
                sqlCommand.CommandText = "Insert into ENFERMEDAD (idenfermedad,nombre_tecnico) values (@idenfermedad,@nombre_tecnico)";
                sqlCommand.Parameters.AddWithValue("@idenfermedad", idenfermedad);
                sqlCommand.Parameters.AddWithValue("@nombre_tecnico", nombre_tecnico);
                try
                {
                    connection.Open();
                    resultado = sqlCommand.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return resultado;
        }

        public static int EliminarPlantaPornombre_tecnico(string nombre_tecnico)
        {
            int resultado = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(null, connection);
                sqlCommand.CommandText = "Delete from ENFERMEDAD where nombre_tecnico = @nombre_tecnico";
                sqlCommand.Parameters.AddWithValue("@nombre_tecnico", nombre_tecnico);

                try
                {
                    connection.Open();
                    resultado = sqlCommand.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return resultado;
            }
        }
}