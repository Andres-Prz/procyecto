using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gruposInvestigacion
{
    internal class dbConnection
    {
        static public SqlConnection establecerConexion()
        {            
            string servidor = ConfigurationManager.AppSettings["Servidor"];
            string bd = ConfigurationManager.AppSettings["BaseDatos"];
            string usuario = ConfigurationManager.AppSettings["Usuario"];
            string password = ConfigurationManager.AppSettings["Password"];
            string puerto = ConfigurationManager.AppSettings["Puerto"];

            string cadenaConexion = $"Data Source={servidor},{puerto};Initial Catalog={bd};User ID={usuario};Password={password};TrustServerCertificate=true";

            SqlConnection conex = new SqlConnection();

            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
            }
            catch (SqlException e)
            {
                MessageBox.Show("No se logró conectar a la Base de Datos" + e.ToString());
            }

            return conex;
        }
    }
}