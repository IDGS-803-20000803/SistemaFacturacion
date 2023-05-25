using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAACCESS
{
    public class FirmasDA
    {
        public int Insertar(BE.FirmasBE objDatosBE)
        {
            try
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    string msjError = "";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_FIRMAS_INSERTAR";
                    cmd.Parameters.Add("pResponsable", MySqlDbType.VarChar, 255).Value = objDatosBE.Descripcion;
                    cmd.Parameters.Add("pCorreo", MySqlDbType.VarChar, 255).Value = objDatosBE.Correo;
                    cmd.Parameters.Add("pPuesto", MySqlDbType.VarChar, 255).Value = objDatosBE.Puesto;  
                    cmd.Parameters.Add("pIdUsuario", MySqlDbType.Int32).Value = objDatosBE.IdUsuario;
                    cmd.Parameters.Add("pFecha", MySqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters.Add("pFoto", MySqlDbType.LongBlob).Value = objDatosBE.foto;
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.Id;
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;
                    General.oDatos.Ejecutar(cmd);


                    intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString());


                    if (intResultado > 0)
                        return intResultado;
                    else {
                        throw new Exception("Ha ocurrido un error al guardar "+ msjError);
                    }
                }

            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public int Modificar(BE.FirmasBE objDatosBE)
        {
            try
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    string msjError = "";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_FIRMAS_MODIFICAR";
                    cmd.Parameters.Add("pResponsable", MySqlDbType.VarChar, 255).Value = objDatosBE.Descripcion;
                    cmd.Parameters.Add("pCorreo", MySqlDbType.VarChar, 255).Value = objDatosBE.Correo;
                    cmd.Parameters.Add("pPuesto", MySqlDbType.VarChar, 255).Value = objDatosBE.Puesto;                   
                    cmd.Parameters.Add("pIdUsuario", MySqlDbType.Int32).Value = objDatosBE.IdUsuario;
                    cmd.Parameters.Add("pFecha", MySqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters.Add("pFoto", MySqlDbType.LongBlob).Value = objDatosBE.foto;
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.Id;
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;
                    General.oDatos.Ejecutar(cmd);

                    intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString());

                    if (intResultado > 0)
                        return intResultado;
                    else
                    {
                        throw new Exception("Ha ocurrido un error al modificar" + msjError);
                    }
                }

            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public int Eliminar(BE.FirmasBE objDatosBE)
        {
            try
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    string msjError = "";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_FIRMAS_ELIMINAR";
                    cmd.Parameters.Add("pIdUsuario", MySqlDbType.Int32).Value = objDatosBE.IdUsuario;
                    cmd.Parameters.Add("pFecha", MySqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.Id;
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;
                    General.oDatos.Ejecutar(cmd);

                    intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString());

                    if (intResultado > 0)
                        return intResultado;
                    else
                    {
                        throw new Exception("Ha ocurrido un error al eliminar " + msjError);
                    }
                }

            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
