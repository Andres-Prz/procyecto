using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;


namespace gruposInvestigacion
{
    internal class PersonaDAL
    {
        public static List<OPersona> presentarPersona()
        {
            List<OPersona> list = new List<OPersona>();

            using (SqlConnection conex = dbConnection.establecerConexion())
            {
                string query = "SELECT * FROM persona;";

                try
                {
                    SqlCommand comando = new SqlCommand(query, conex);

                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        OPersona persona = new OPersona();
                        persona.idPersona = reader.GetInt32(0);
                        persona.nombre = reader.GetString(1);
                        persona.edad = reader.GetInt32(2);
                        persona.genero = reader.GetString(3);
                        list.Add(persona);
                    }
                }
                catch (SqlException ex)
                {

                    MessageBox.Show("No se logró conectar a la Base de Datos" + ex.ToString());
                }

                conex.Close();
                return list;
            }
        }


        public static int agregarPersona(OPersona persona)
        {
            int retorno = 0;

            using (SqlConnection conex = dbConnection.establecerConexion())
            {
                string query = "INSERT INTO persona (nombre, edad, genero) VALUES ('" + persona.nombre + "',"+persona.edad+",'" + persona.genero + "');";

                try
                {
                    SqlCommand comando = new SqlCommand(query, conex);
                    retorno = comando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {

                    MessageBox.Show("No se logró hacer el registro" + ex.ToString());
                }

            }
            return retorno;

        }

        public static int modificarPersona(OPersona persona)
        {
            int retorno = 0;

            using (SqlConnection conex = dbConnection.establecerConexion())
            {
                string query = "UPDATE persona SET nombre='" + persona.nombre + "', edad=" + persona.edad + ", genero='"+persona.genero+"' WHERE idPersona=" + persona.idPersona + ";";
                try
                {
                    SqlCommand comando = new SqlCommand(query, conex);
                    retorno = comando.ExecuteNonQuery();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("No se logró hacer el registro" + ex.ToString());
                }
                conex.Close();
            }
            return retorno;
        }

        public static int eliminarPersona(int id)
        {
            int retorno = 0;

            using (SqlConnection conex = dbConnection.establecerConexion())
            {
                string query = "DELETE FROM persona WHERE idPersona=" + id + "";

                try
                {
                    SqlCommand comando = new SqlCommand(query, conex);
                    retorno = comando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {

                    MessageBox.Show("No se logró hacer el registro" + ex.ToString());
                }

            }
            return retorno;

        }

        public static List<OPersona> llenadoIdLider()
        {
            List<OPersona> list = new List<OPersona>();

            using (SqlConnection conex = dbConnection.establecerConexion())
            {
                string query = "SELECT idPersona, nombre FROM persona;";

                try
                {
                    SqlCommand comando = new SqlCommand(query, conex);

                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        OPersona persona = new OPersona();
                        persona.idPersona = reader.GetInt32(0);
                        persona.nombre = reader.GetString(1);
                        list.Add(persona);
                    }
                }
                catch (SqlException ex)
                {

                    MessageBox.Show("No se logró conectar a la Base de Datos" + ex.ToString());
                }

                conex.Close();
                return list;
            }
        }
    }
}