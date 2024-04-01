using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gruposInvestigacion
{
    internal class GrupoDAL
    {
        public static List<OGrupo> presentarGrupo()
        {
            List<OGrupo> list = new List<OGrupo>();



            using (SqlConnection conex = dbConnection.establecerConexion())
            {
                string query = "SELECT * FROM grupo;";

                try
                {
                    SqlCommand comando = new SqlCommand(query, conex);

                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        OGrupo grupo = new OGrupo();
                        grupo.idGrupo = reader.GetInt32(0);
                        grupo.nombre = reader.GetString(1);
                        grupo.idLider = reader.GetInt32(2);
                        list.Add(grupo);
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


        public static int agregarGrupo(OGrupo grupo)
        {
            int retorno = 0;

            using (SqlConnection conex = dbConnection.establecerConexion())
            {
                string query = "INSERT INTO grupo (nombre, idLider) VALUES ('" + grupo.nombre + "'," + grupo.idLider + ");";

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
         //Aqui nos quedamos
        public static int modificarGrupo(OGrupo grupo)
        {
            int retorno = 0;

            using (SqlConnection conex = dbConnection.establecerConexion())
            {
                string query = "UPDATE grupo SET nombre='" + grupo.nombre + "', idLider=" + grupo.idLider + " WHERE idGrupo=" + grupo.idGrupo + ";";
                try
                {
                    SqlCommand comando = new SqlCommand(query, conex);
                    retorno = comando.ExecuteNonQuery();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("No se logró hacer La modificacion" + ex.ToString());
                }
                conex.Close();
            }
            return retorno;
        }

        public static int eliminarGrupo(int id)
        {
            int retorno = 0;

            using (SqlConnection conex = dbConnection.establecerConexion())
            {
                string query = "DELETE FROM grupo WHERE idGrupo=" + id + "";

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

        
    }
}