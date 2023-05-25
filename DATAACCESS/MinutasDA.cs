using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAACCESS
{
    public class MinutasDA
    {
        public int Insertar(BE.MinutasBE objDatosBE)
        {
            try
            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_MINUTAS_INSERTAR";
                    cmd.Parameters.Add("pCampo1", MySqlDbType.Text).Value = objDatosBE.campo_1;
                    cmd.Parameters.Add("pCampo2", MySqlDbType.Text).Value = objDatosBE.campo_2;
                    cmd.Parameters.Add("pCampo3", MySqlDbType.Text).Value = objDatosBE.campo_3;
                    cmd.Parameters.Add("pCampo4", MySqlDbType.Text).Value = objDatosBE.campo_4;
                    cmd.Parameters.Add("pCampo5", MySqlDbType.Text).Value = objDatosBE.campo_5;
                    cmd.Parameters.Add("pNoContrato", MySqlDbType.Int32).Value = objDatosBE.no_contrato;
                    cmd.Parameters.Add("pReferencia", MySqlDbType.VarChar,255).Value = objDatosBE.referencia;
                    cmd.Parameters.Add("pHoraInicio", MySqlDbType.VarChar, 255).Value = objDatosBE.hora_inicio;
                    cmd.Parameters.Add("pHoraTermino", MySqlDbType.VarChar, 255).Value = objDatosBE.hora_termino;
                    cmd.Parameters.Add("pUnidad", MySqlDbType.VarChar, 255).Value = objDatosBE.unidad;
                    cmd.Parameters.Add("pProveedor", MySqlDbType.VarChar, 255).Value = objDatosBE.proveedor;
                    cmd.Parameters.Add("pNombreEmpresa1", MySqlDbType.VarChar, 255).Value = objDatosBE.nombre_empresa_1;
                    cmd.Parameters.Add("pOcupacionEmpresa1", MySqlDbType.VarChar, 255).Value = objDatosBE.ocupacion_empresa_1;
                    cmd.Parameters.Add("pNombreEmpresa2", MySqlDbType.VarChar, 255).Value = objDatosBE.nombre_empresa_2;
                    cmd.Parameters.Add("pOcupacionEmpresa2", MySqlDbType.VarChar, 255).Value = objDatosBE.ocupacion_empresa_2;  
                    cmd.Parameters.Add("pNombreIsapeg1", MySqlDbType.VarChar, 255).Value = objDatosBE.nombre_isapeg_1;
                    cmd.Parameters.Add("pOcupacionIsapeg1", MySqlDbType.VarChar, 255).Value = objDatosBE.ocupacion_isapeg_1;
                    cmd.Parameters.Add("pNombreIsapeg2", MySqlDbType.VarChar, 255).Value = objDatosBE.nombre_isapeg_2;
                    cmd.Parameters.Add("pOcupacionIsapeg2", MySqlDbType.VarChar, 255).Value = objDatosBE.ocupacion_isapeg_2;
                    cmd.Parameters.Add("pIdAnexo", MySqlDbType.Int32).Value = objDatosBE.id_anexo;
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.id;
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;
                    General.oDatos.Ejecutar(cmd);


                    intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString());
                    if (intResultado > 0)
                        return intResultado;
                    else if (intResultado == -1)
                        throw new Exception("La marca ya se encuentra registrada");
                    else
                        throw new Exception("Ha ocurrido un error al guardar");

                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public int Modificar(BE.MinutasBE objDatosBE)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_MARCAS_MODIFICAR";
                    cmd.Parameters.Add("pCampo1", MySqlDbType.Text).Value = objDatosBE.campo_1;
                    cmd.Parameters.Add("pCampo2", MySqlDbType.Text).Value = objDatosBE.campo_2;
                    cmd.Parameters.Add("pCampo3", MySqlDbType.Text).Value = objDatosBE.campo_3;
                    cmd.Parameters.Add("pCampo4", MySqlDbType.Text).Value = objDatosBE.campo_4;
                    cmd.Parameters.Add("pCampo5", MySqlDbType.Text).Value = objDatosBE.campo_5;
                    cmd.Parameters.Add("pNoContrato", MySqlDbType.Int32).Value = objDatosBE.no_contrato;
                    cmd.Parameters.Add("pReferencia", MySqlDbType.VarChar, 255).Value = objDatosBE.referencia;
                    cmd.Parameters.Add("pHoraInicio", MySqlDbType.VarChar, 255).Value = objDatosBE.hora_inicio;
                    cmd.Parameters.Add("pHoraTermino", MySqlDbType.VarChar, 255).Value = objDatosBE.hora_termino;
                    cmd.Parameters.Add("pUnidad", MySqlDbType.VarChar, 255).Value = objDatosBE.unidad;
                    cmd.Parameters.Add("pProveedor", MySqlDbType.VarChar, 255).Value = objDatosBE.proveedor;
                    cmd.Parameters.Add("pNombreEmpresa1", MySqlDbType.VarChar, 255).Value = objDatosBE.nombre_empresa_1;
                    cmd.Parameters.Add("pOcupacionEmpresa1", MySqlDbType.VarChar, 255).Value = objDatosBE.ocupacion_empresa_1;
                    cmd.Parameters.Add("pNombreEmpresa2", MySqlDbType.VarChar, 255).Value = objDatosBE.nombre_empresa_2;
                    cmd.Parameters.Add("pOcupacionEmpresa2", MySqlDbType.VarChar, 255).Value = objDatosBE.ocupacion_empresa_2;
                    cmd.Parameters.Add("pNombreIsapeg1", MySqlDbType.VarChar, 255).Value = objDatosBE.nombre_isapeg_1;
                    cmd.Parameters.Add("pOcupacionIsapeg1", MySqlDbType.VarChar, 255).Value = objDatosBE.ocupacion_isapeg_1;
                    cmd.Parameters.Add("pNombreIsapeg2", MySqlDbType.VarChar, 255).Value = objDatosBE.nombre_isapeg_2;
                    cmd.Parameters.Add("pOcupacionIsapeg2", MySqlDbType.VarChar, 255).Value = objDatosBE.ocupacion_isapeg_2;
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.id;
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;
                    General.oDatos.Ejecutar(cmd);
                    intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString());
                    //throw new Exception("Error");
                    if (intResultado > 0)
                        return intResultado;
                    else if (intResultado == -1)
                        throw new Exception("La marca ya se encuentra registrada");
                    else
                        throw new Exception("Ha ocurrido un error al guardar");

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int Eliminar(BE.MinutasBE objDatosBE)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_MINUTAS_ELIMINAR";
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
