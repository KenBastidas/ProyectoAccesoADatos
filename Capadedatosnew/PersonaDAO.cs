using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class PersonaDAO
    {
        private static String cadenaConexion = @"server=LAPTOP-KEN\SQLEXPRESS ; database=Estudiantes; integrated security=true";

        public static int crear(Persona persona)
        {
            //
            //
            //
            //String cadenaConexion = @"server=LAPTOP-KEN\SQLEXPRESS ; database=Estudiantes; integrated security=true";

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
            //String cadenaConexion = @"Server=LAPTOP-KEN\SQLEXPRESS ;database = Estudiantes; integrated security=true";

            //definir un obejto tipo conexion para coenctarnos al servidor
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            //2. Deinfir la operaciona  relizar en el servidor
            //operacio: obetener todos lso resgistros.
            //sql(lenguaje estruturadod e conulstas)
            string sql = "select cedula as Cédula, upper(apellidos +' '+ nombres) as Estudiante, case when sexo= 'M' then 'Masculino' else 'Femenino' end as Sexo, fechaNacimiento, correo as Correo, estatura as Estatura, peso as Peso "
                +"from personas order by apellidos, nombres";

            //definir un adaptador de datos: es un puerte que permite pasar los datos de la BDD hacia el datatable
            SqlDataAdapter ad = new SqlDataAdapter(sql, conexion);

            //3. recuperamos lso datos
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public static Persona GetPersona(String cedula)
        {
            //1. difinir y configurar la conexion con el mtoor de BDD
            //String cadenaConexion = @"Server=LAPTOP-KEN\SQLEXPRESS ;database = Estudiantes; user id = sa; pwd = isa";

            //cadena de conmexion tulizando el suahrio de windows
            //String cadenaConexion = @"Server=LAPTOP-KEN\SQLEXPRESS ;database = Estudiantes; integrated security=true";

            //definir un obejto tipo conexion para coenctarnos al servidor
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            //2. Deinfir la operaciona  relizar en el servidor
            //operacio: obetener todos lso resgistros.
            //sql(lenguaje estruturadod e conulstas)
            string sql = "select cedula as Cédula,apellidos ,nombres, sexo, fechaNacimiento, correo, estatura, peso " +
                "from personas " +
                "where cedula=@cedula";

            //definir un adaptador de datos: es un puerte que permite pasar los datos de la BDD hacia el datatable
            SqlDataAdapter ad = new SqlDataAdapter(sql, conexion);
            //pasar el parametro
            ad.SelectCommand.Parameters.AddWithValue("@cedula", cedula);
            //3. recuperamos lso datos
            DataTable dt = new DataTable();
            ad.Fill(dt);
            Persona p = new Persona();
            //recorrer el datatable
            foreach(DataRow fila in dt.Rows)
            {
                p.Cedula = fila["cedula"].ToString();
                p.Apellidos = fila["apellidos"].ToString();
                p.Nombres= fila["nombres"].ToString();
                p.Sexo= fila["sexo"].ToString();
                p.Correo =fila["correo"].ToString();
                p.Estatura = int.Parse(fila["estatura"].ToString());
                p.Peso = decimal.Parse(fila["peso"].ToString());
                p.FEchaNacimiento = Convert.ToDateTime(fila["fechaNacimiento"].ToString());
                break;
            }
            return p;
        }

    }
}
