using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAACCESS
{
    public class ContactosDA
    {
        public int AsignarFormatos(BE.ContactosBE objDatosBE)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_CONTACTOS_FORMATOS_ASIGNAR";
                    cmd.Parameters.Add("pContacto", MySqlDbType.Int32).Value = objDatosBE.id_contacto;
                    cmd.Parameters.Add("pAnio", MySqlDbType.Int32).Value = objDatosBE.anio;
                    cmd.Parameters.Add("pPartidas", MySqlDbType.Int32).Value = objDatosBE.partidas;
                    cmd.Parameters.Add("pFormatos", MySqlDbType.VarChar, 100).Value = objDatosBE.formatos;
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.id;
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;
                    General.oDatos.Ejecutar(cmd);

                    intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString());
                    if (intResultado > 0)
                    {
                        return intResultado;
                    }
                    else if (intResultado == -1)
                    {
                        throw new Exception("No se puede repetir el RFC de un cliente");
                    }
                    else
                    {
                        throw new Exception("Ha ocurrido un error al guardar");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
