using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAACCESS
{
    public class NotasDA
    {

        public int Insertar(BE.NotasBE objDatosBE)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_NOTAS_INSERTAR";
                    cmd.Parameters.Add("pFecha", MySqlDbType.Datetime).Value = objDatosBE.fecha;
                    cmd.Parameters.Add("pNota", MySqlDbType.VarChar, 5000).Value = objDatosBE.nota;
                    cmd.Parameters.Add("pIdUsuario", MySqlDbType.Int32).Value = objDatosBE.id_usuario;
                    cmd.Parameters.Add("pIdEmpleado", MySqlDbType.Int32).Value = objDatosBE.id_empleado;
                    cmd.Parameters.Add("pIdCliente", MySqlDbType.Int32).Value = objDatosBE.id_cliente;
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.id;
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;
                    General.oDatos.Ejecutar(cmd);


                    intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString());
                    if (intResultado > 0)
                        return intResultado;                    
                    else
                        throw new Exception("Ha ocurrido un error al guardar");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
