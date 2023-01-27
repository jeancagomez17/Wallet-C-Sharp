using MySql.Data.MySqlClient;
using System.Configuration;


namespace Wallet.Conexion
{

    internal class conexion
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString;
        private MySqlConnection connection;
        public conexion()
        {
            connection = new MySqlConnection();
            connection.ConnectionString = connectionString;


        }

        public void Conectar()
        {
            try
            {
                connection.Open();
                if (connection.Ping())
                {
                    Console.WriteLine("Conexión exitosa");
                    // Aquí va el código para ejecutar la consulta
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

        public void Desconectar()
        {
            connection.Close();
        }

        public MySqlConnection ObtenerConexion()
        {
            return connection;
        }



    }
}
