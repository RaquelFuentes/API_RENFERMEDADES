using API_RENFERMEDADES.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace API_RENFERMEDADES.Conection
{
    public class PACIENTECONNECTION
    {
        static string connectionString = @"Server=LAPTOP-FGSQM91F\SQLEXPRESS;Database=APIRENFERMEDADES;Trusted_Connection=True;";

        private static List<PACIENTE> Pacientes;

        public static List<PACIENTE> ObtenerPacientes()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                var comando = AbrirConexionSqlPACIENTE(sqlConnection);

                var dataTable = LLenadoTabla(comando);

                return ListarPacientes(dataTable);
            }
        }

        private static List<PACIENTE> ListarPacientes(object dataTable)
        {
            throw new NotImplementedException();
        }

        private static object LLenadoTabla(object comando)
        {
            throw new NotImplementedException();
        }

        private static object AbrirConexionSqlPACIENTE(SqlConnection sqlConnection)
        {
            throw new NotImplementedException();
        }

        private static object AbrirConexionSqlPACIENTES(SqlConnection sqlConnection)
        {
            throw new NotImplementedException();
        }

        private static List<PACIENTE> ListarPacientes(DataTable dataTable)
        {
            throw new NotImplementedException();
        }

        public static PACIENTE ObtenerPacientes(string nombre)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                var query = $"select * from PACIENTE where nombre = '{nombre}'";

                var comando = AbrirConexionSqlPACIENTE(sqlConnection, query);

                var dataTable = LLenadoTabla(comando);

                return CreacionPACIENTE(dataTable);

            }
        }

        private static PACIENTE CreacionPACIENTE(DataTable dataTable)
        {
            throw new NotImplementedException();
        }

        public static PACIENTE ObtenerPacientes(int rut)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                var query = $"select * from PACIENTE where rut = '{rut}'";

                var comando = AbrirConexionSqlPACIENTE(sqlConnection, query);

                var dataTable = LLenadoTabla(comando);

                return CreacionPACIENTE(dataTable);

            }
        }

        private static PACIENTE CreacionPACIENTE(object dataTable)
        {
            throw new NotImplementedException();
        }

        private static object AbrirConexionSqlPACIENTE(SqlConnection sqlConnection, string query)
        {
            throw new NotImplementedException();
        }

        public static int Agregarpaciente(PACIENTE Paciente)
        {
            int filasAfectadas = 0;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(null, sqlConnection);
                sqlCommand.CommandText = "Insert into PACIENTE (nombre) values (@nombre)";

                sqlCommand.Parameters.AddWithValue("@nombre", Paciente.nombre);

                try
                {
                    sqlConnection.Open();
                    filasAfectadas = sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return filasAfectadas;
            }
        }
        public static int AgregarPACIENTE(string Pacientes)
        {
            int filasAfectadas = 0;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(null, sqlConnection);
                sqlCommand.CommandText = "Insert into PACIENTE (nombre) values (@nombre)";

                sqlCommand.Parameters.AddWithValue("@nombre", Pacientes);

                try
                {
                    sqlConnection.Open();
                    filasAfectadas = sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return filasAfectadas;
            }

        }
        public static int EliminarPACIENTEPorNombre(string nombre)
        {
            int filasAfectadas = 0;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(null, sqlConnection);
                sqlCommand.CommandText = "Delete from Pacientes where nombre = @nombre";

                sqlCommand.Parameters.AddWithValue("@nombre", nombre);

                try
                {
                    sqlConnection.Open();
                    filasAfectadas = sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return filasAfectadas;
            }
        }

        public static int ActualizarPACIENTEPorrut(PACIENTE Paciente)
        {
            int filasAfectadas = 0;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(null, sqlConnection);
                sqlCommand.CommandText = "Update PACIENTE SET nombre = @nombre where rut = @rut";
                sqlCommand.Parameters.AddWithValue("@nombre", Paciente.nombre);
                sqlCommand.Parameters.AddWithValue("@rut", Paciente.rut);

                try
                {
                    sqlConnection.Open();
                    filasAfectadas = sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return filasAfectadas;
            }
        }

        private static SqlCommand AbrirConexionSqlPACIENTES(SqlConnection sqlConnection, string query)
        {
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            return sqlCommand;
        }
        private static DataTable LLenadoTabla(SqlCommand comando)
        {
            var dataTable = new DataTable();
            var dataAdapter = new SqlDataAdapter(comando);
            dataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}
