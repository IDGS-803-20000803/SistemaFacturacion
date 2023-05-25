using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace cPersistencia
{
    public class Datos
    {

        private MySqlConnection _cnn;
        private string _servidor;
        private string _base_datos;
        private string _contraseña;
        private string _usuario;

        public Datos(DataTable dtConfig)
        {
            _servidor = dtConfig.Rows[0]["servidor"].ToString();
            _base_datos = dtConfig.Rows[0]["basedatos"].ToString();
            _contraseña = dtConfig.Rows[0]["contra"].ToString();
            _usuario = dtConfig.Rows[0]["usuario"].ToString();
        }

        public DataTable Tabla (string Sql)
        {
            try
            {
                DataTable dtDatos = new DataTable();
                AbrirConexion();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = Sql;
                    cmd.Connection = _cnn;
                    cmd.CommandTimeout = 400;
                    using (MySqlDataAdapter adp = new MySqlDataAdapter(cmd))
                    {
                        adp.Fill(dtDatos);
                    }
                    CerrarConexion();
                }

                return dtDatos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public int Ejecutar(MySqlCommand cmd)
        {
            try
            {
                int intResultado;
                AbrirConexion();
                cmd.Connection = _cnn;
                cmd.CommandTimeout = 1000;
                intResultado = cmd.ExecuteNonQuery();
                CerrarConexion();
                return intResultado;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int Escalar(MySqlCommand cmd)
        {
            try
            {
                int intResultado;
                AbrirConexion();
                cmd.Connection = _cnn;
                cmd.CommandTimeout = 1000;
                intResultado = int.Parse(cmd.ExecuteScalar().ToString());
                CerrarConexion();
                return intResultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        internal void AbrirConexion()
        {
            string strConexion = $"Server={_servidor};Database={_base_datos};uid={_usuario};Pwd={_contraseña};Connection Timeout=10000;";

            _cnn = new MySqlConnection(strConexion);
            _cnn.Open();
        }
        internal void CerrarConexion()
        {
            _cnn.Close();
            _cnn.Dispose();
            _cnn = null;

        }

        public DataSet ConsultaMultiple(string Sql)
        {
            try
            {
                DataSet dtDatos = new DataSet();
                AbrirConexion();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = Sql;
                    cmd.Connection = _cnn;
                    cmd.CommandTimeout = 400;
                    using (MySqlDataAdapter adp = new MySqlDataAdapter(cmd))
                    {
                        adp.Fill(dtDatos);
                    }
                    CerrarConexion();
                }
                return dtDatos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
