using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaDatos
{
    public class PersonaDAO
    {
        public static DataTable getAll()
        {
            //1. difinir y configurar la conexion con el mtoor de BDD
            String cadenaConexion = @"Server= ;database = Estudiantes; user id = sa; pwd = isa";

            //cadena de conmexion tulizando el suahrio de windows
            String cadenaConexion = @"Server= ;database = Estudiantes; integrated security=true";

            //definir un obejto tipo conexion para coenctarnos al servidor
            SqlConnection conexion = new SqlConnection(cadenaConexion);
        }
    }
}
