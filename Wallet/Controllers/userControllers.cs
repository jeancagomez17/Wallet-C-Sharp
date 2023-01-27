using Wallet.Models;
using Wallet.Conexion;
using MySql.Data.MySqlClient;
using System.Xml.Linq;

namespace Wallet.Controllers
{
    internal class userControllers
    {
        private conexion Conexion;

        public userControllers()
        {
            Conexion = new conexion(); // constructor, al atributp private le digo que va ser del objeto Conexion
        }

        public List<Users> findAll() {
            List<Users> listaUsers = new List<Users>();
            Conexion.Conectar();
            MySqlCommand comando = Conexion.ObtenerConexion().CreateCommand();
            comando.CommandText = "SELECT * FROM users";
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Users user = new Users();
                user.name = reader["nameUser"].ToString();
                user.lastname = reader["lastnameUser"].ToString();
                user.email = reader["emailUser"].ToString();
                user.phone = reader["telefonoUser"].ToString();
                listaUsers.Add(user);
            }
            Conexion.Desconectar();
            return listaUsers;
        }

        public Boolean SignIn(string email, string pass) {
            Conexion.Conectar();
            MySqlCommand comando = Conexion.ObtenerConexion().CreateCommand();
            comando.CommandText = $"SELECT emailUser FROM users WHERE emailUser='{email}' and passwordUser = '{pass}'";
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            return false;
        }
    }
}
