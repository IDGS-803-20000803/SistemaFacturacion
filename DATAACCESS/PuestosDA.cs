using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAACCESS
{
    public class PuestosDA
    {

        public int Insertar(BE.PuestosBE objDatosBE)
        {
            try
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_PUESTOS_INSERTAR";
                    cmd.Parameters.Add("pPuesto", MySqlDbType.VarChar, 255).Value = objDatosBE.puesto;
                    cmd.Parameters.Add("pDescripcion", MySqlDbType.VarChar, 5000).Value = objDatosBE.descripcion;
                    cmd.Parameters.Add("pIdUsuario", MySqlDbType.Int32).Value = objDatosBE.id_usuario;
                    cmd.Parameters.Add("pFecha", MySqlDbType.Datetime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.id;
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;
                    General.oDatos.Ejecutar(cmd);


                    intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString());
                    if (intResultado > 0)
                        return intResultado;
                    else if (intResultado == -1)
                        throw new Exception("El color ya fue registrado previamente");
                    else
                        throw new Exception("Ha ocurrido un error al guardar");

                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public int Modificar(BE.PuestosBE objDatosBE)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_PUESTOS_MODIFICAR";
                    cmd.Parameters.Add("pPuesto", MySqlDbType.VarChar, 255).Value = objDatosBE.puesto;
                    cmd.Parameters.Add("pDescripcion", MySqlDbType.VarChar, 5000).Value = objDatosBE.descripcion;
                    cmd.Parameters.Add("pIdUsuario", MySqlDbType.Int32).Value = objDatosBE.id_usuario;
                    cmd.Parameters.Add("pFecha", MySqlDbType.Datetime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.id;
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;
                    General.oDatos.Ejecutar(cmd);
                    intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString());
                    //throw new Exception("Error");
                    if (intResultado > 0)
                        return intResultado;
                    else if (intResultado == -1)
                        throw new Exception("El color ya fue registrado previamente");
                    else
                        throw new Exception("Ha ocurrido un error al guardar");

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int Eliminar(BE.PuestosBE objDatosBE)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_PUESTOS_ELIMINAR";
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.id;
                    cmd.Parameters.Add("pIdUsuario", MySqlDbType.Int32).Value = objDatosBE.id_usuario;
                    cmd.Parameters.Add("pFecha", MySqlDbType.Datetime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;
                    General.oDatos.Ejecutar(cmd);
                    intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString());
                    //throw new Exception("Error");
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
