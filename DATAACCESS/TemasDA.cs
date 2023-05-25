using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAACCESS
{
    public class TemasDA
    {
        public int Insertar(BE.TemasBE objDatosBE)
        {
            try
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_TEMAS_INSERTAR";
                    cmd.Parameters.Add("pTema", MySqlDbType.Text).Value = objDatosBE.tema;
                    cmd.Parameters.Add("pCantidad", MySqlDbType.Decimal).Value = objDatosBE.cantidad;
                    cmd.Parameters.Add("pCantidadLetra", MySqlDbType.VarChar, 255).Value = objDatosBE.cantidad_letra;
                    cmd.Parameters.Add("pIdMinuta", MySqlDbType.Int32).Value = objDatosBE.id_minuta;
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.id;
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;
                    General.oDatos.Ejecutar(cmd);

                    intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString());
                    if (intResultado > 0)
                        return intResultado;
                    else if (intResultado == -1)
                        throw new Exception("El tipo de cliente ya se encuentra registrado");
                    else
                        throw new Exception("Ha ocurrido un error al guardar");

                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public int Modificar(BE.TemasBE objDatosBE)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_TEMAS_MODIFICAR";
                    cmd.Parameters.Add("pTema", MySqlDbType.Text).Value = objDatosBE.tema;
                    cmd.Parameters.Add("pCantidad", MySqlDbType.Decimal).Value = objDatosBE.cantidad;
                    cmd.Parameters.Add("pCantidadLetra", MySqlDbType.VarChar, 255).Value = objDatosBE.cantidad_letra;
                    cmd.Parameters.Add("pIdMinuta", MySqlDbType.Int32).Value = objDatosBE.id_minuta;
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.id;
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;
                    General.oDatos.Ejecutar(cmd);
                    intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString());
                    //throw new Exception("Error");
                    if (intResultado > 0)
                        return intResultado;
                    else if (intResultado == -1)
                        throw new Exception("El tipo de cliente ya se encuentra registrado");
                    else
                        throw new Exception("Ha ocurrido un error al guardar");

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int Eliminar(BE.TemasBE objDatosBE)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_TEMAS_ELIMINAR";
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.id;
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
