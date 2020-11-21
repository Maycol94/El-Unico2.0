using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace El_Unico_Grupo3
{
    class ConexionDataBase
    {
        MySqlConnection conexion = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=Pa55w0rd3366;database=el_unico;Sslmode = none;");
        private MySqlCommand cmd;
        private MySqlDataReader verificar;
      //  private MySqlCommandBuilder cmBuilder;
        private MySqlDataAdapter da;
        //private DataSet ds;
        private DataTable dt;

        public bool Conectar()
        {
            bool conectado = false;
            try
            {
                conexion.Open();
                conectado = true;
            }
            catch
            {
                conectado = false;
            }
            finally
            {
                conexion.Close();
            }
            return conectado;
        }

        public bool Login(string consulta)
        {
            bool encontrado = false;
            cmd = new MySqlCommand(consulta, conexion);
            cmd.CommandTimeout = 60;
            conexion.Open();
            verificar = cmd.ExecuteReader();
            if (verificar.HasRows)
            {
                while (verificar.Read())
                {
                    string[] row = { verificar.GetString(0), verificar.GetString(1), verificar.GetString(2) };
                }
                encontrado = true;
               
            }
            else
            {
                conexion.Close();

            }

            return encontrado;
        }
        public bool Insertar(string consulta)
        {
            bool Agregado = false;
            int rows = 0;
            conexion.Open();
            cmd = new MySqlCommand(consulta, conexion);
            rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                Agregado = true;
            }
            conexion.Close();
            return Agregado;
        }

        public bool Eliminar(string consulta)
        {
            bool Eliminado = false;
            int rows = 0;

            conexion.Open();
            cmd = new MySqlCommand(consulta, conexion);
            rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                Eliminado = true;
            }
            conexion.Close();
            return Eliminado;
        }

        public bool Actualizar(string consulta)
        {
            bool Actualizado = false;
            int rows = 0;

            conexion.Open();
            cmd = new MySqlCommand(consulta, conexion);
            rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                Actualizado = true;
            }
            conexion.Close();
            return Actualizado;
        }

        public DataTable LlenarGrid(string consulta)
        {
            conexion.Open();
            cmd = new MySqlCommand(consulta, conexion);
            da = new MySqlDataAdapter(cmd);

            dt = new DataTable();
            da.Fill(dt);
            conexion.Close();

            return dt;
        }
        public DataTable BuscarPorID(string consulta)
        {
            conexion.Open();
            cmd = new MySqlCommand(consulta, conexion);
            da = new MySqlDataAdapter(cmd);

            dt = new DataTable();
            da.Fill(dt);
            conexion.Close();

            return dt;
        }

    }
}
