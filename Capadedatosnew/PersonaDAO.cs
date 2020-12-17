using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class PersonaDAO
    {
        public static int crear(Persona persona)
        {
            //
            //
            //
            String cadenaConexion = @"server=LAPTOP-KEN\SQLEXPRESS ; database=Estudiantes; integrated security=true";

            //
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            //

            string sql = "insert into Personas(cedula, apellidos, nombres, sexo, fechaNacimiento, "+
                "correo, estatura, peso) values(@cedula, @apellidos, @nombres, @sexo, @fechaNacimiento, " +
                "@correo, @estatura, @peso) ";

            //
            SqlCommand comando = new SqlCommand(sql, conexion);

            //definir los parametros
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@cedula", persona.Cedula);
            comando.Parameters.AddWithValue("@apellidos", persona.Apellidos);
            comando.Parameters.AddWithValue("@nombres", persona.Nombres);
            comando.Parameters.AddWithValue("@sexo", persona.Sexo);
            comando.Parameters.AddWithValue("@fechaNacimiento", persona.FEchaNacimiento);
            comando.Parameters.AddWithValue("@correo", persona.Correo);
            comando.Parameters.AddWithValue("@estatura", persona.Estatura);
            comando.Parameters.AddWithValue("@peso", persona.Peso);

            //
            conexion.Open();
            int x = comando.ExecuteNonQuery();
            //
            conexion.Close();

            return x;
        }
        public static DataTable getAll()
        {
            //1. difinir y configurar la conexion con el mtoor de BDD
            //String cadenaConexion = @"Server=LAPTOP-KEN\SQLEXPRESS ;database = Estudiantes; user id = sa; pwd = isa";

            //cadena de conmexion tulizando el suahrio de windows
            String cadenaConexion = @"Server=LAPTOP-KEN\SQLEXPRESS ;database = Estudiantes; integrated security=true";

            //definir un obejto tipo conexion para coenctarnos al servidor
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            //2. Deinfir la operaciona  relizar en el servidor
            //operacio: obetener todos lso resgistros.
            //sql(lenguaje estruturadod e conulstas)
            string sql = "select cedula, apellidos, nombres, sexo, fechaNacimiento, estatura, peso "
                +"from personas";

            //definir un adaptador de datos: es un puerte que permite pasar lsod atos de la BDD hacia el datatable
            SqlDataAdapter ad = new SqlDataAdapter(sql, conexion);

            //3. recuperamos lso datos
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
    }
}
