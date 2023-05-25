using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAACCESS
{
    public class AnexosDA
    {
        public int Insertar(BE.AnexosBE objDatosBE)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_ANEXOS_INSERTAR";
                    cmd.Parameters.Add("pFolio", MySqlDbType.VarChar, 50).Value = objDatosBE.folio;
                    cmd.Parameters.Add("pFecha", MySqlDbType.DateTime).Value = objDatosBE.fecha.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters.Add("pCliente", MySqlDbType.Int32).Value = objDatosBE.id_cliente;
                    cmd.Parameters.Add("pClues", MySqlDbType.VarChar, 255).Value = objDatosBE.clues;
                    cmd.Parameters.Add("pCentro", MySqlDbType.VarChar, 255).Value = objDatosBE.centro_coste;
                    cmd.Parameters.Add("pUnidad", MySqlDbType.VarChar, 255).Value = objDatosBE.nombre_unidad;
                    cmd.Parameters.Add("pProveedor", MySqlDbType.VarChar, 255).Value = objDatosBE.id_padron_proveedor;
                    cmd.Parameters.Add("pEmpresa", MySqlDbType.VarChar, 100).Value = objDatosBE.nombre_empresa;
                    cmd.Parameters.Add("pTipo", MySqlDbType.Int32).Value = objDatosBE.tipo_servicio;
                    cmd.Parameters.Add("pCosto1", MySqlDbType.Decimal).Value = objDatosBE.costo_1;
                    cmd.Parameters.Add("pCosto2", MySqlDbType.Decimal).Value = objDatosBE.costo_2;
                    cmd.Parameters.Add("pCostoTotal", MySqlDbType.Decimal).Value = objDatosBE.costo_total;
                    cmd.Parameters.Add("pEstatus", MySqlDbType.Int32).Value = objDatosBE.estatus;
                    cmd.Parameters.Add("pUsuario", MySqlDbType.Int32).Value = objDatosBE.usuario;
                    cmd.Parameters.Add("pFechaModificacion", MySqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters.Add("pPlataforma", MySqlDbType.LongText).Value = objDatosBE.id_plataforma;
                    cmd.Parameters.Add("pMarca", MySqlDbType.LongText).Value = objDatosBE.id_marca;
                    cmd.Parameters.Add("pModelo", MySqlDbType.LongText).Value = objDatosBE.id_modelo;
                    cmd.Parameters.Add("pEquipo", MySqlDbType.LongText).Value = objDatosBE.id_equipo;
                    cmd.Parameters.Add("pRutina", MySqlDbType.LongText).Value = objDatosBE.id_rutina;
                    cmd.Parameters.Add("pCabms", MySqlDbType.LongText).Value = objDatosBE.cabms;
                    cmd.Parameters.Add("pSerie", MySqlDbType.LongText).Value = objDatosBE.serie;
                    cmd.Parameters.Add("pFecha_m1", MySqlDbType.LongText).Value = objDatosBE.fecha_m1;
                    cmd.Parameters.Add("pCosto1D", MySqlDbType.LongText).Value = objDatosBE.costo1;
                    cmd.Parameters.Add("pFecha_m2", MySqlDbType.LongText).Value = objDatosBE.fecha_m2;
                    cmd.Parameters.Add("pCosto2D", MySqlDbType.LongText).Value = objDatosBE.costo2;
                    cmd.Parameters.Add("pTotal", MySqlDbType.LongText).Value = objDatosBE.total;
                    cmd.Parameters.Add("pPartidas", MySqlDbType.Int32).Value = objDatosBE.pPartidas;
                    cmd.Parameters.Add("pDClues", MySqlDbType.LongText).Value = objDatosBE.dClues;
                    cmd.Parameters.Add("pDUnidad", MySqlDbType.LongText).Value = objDatosBE.dunidad;
                    cmd.Parameters.Add("pDCeco", MySqlDbType.LongText).Value = objDatosBE.dceco;
                    cmd.Parameters.Add("pOrigen", MySqlDbType.Int32).Value = objDatosBE.idOrigen;

                    cmd.Parameters.Add("pPartidasEquiposInsertar", MySqlDbType.Int32).Value = objDatosBE.pPartidasEquiposInsertar;
                    cmd.Parameters.Add("pPartidasMarcasInsertar", MySqlDbType.Int32).Value = objDatosBE.pPartidasMarcasInsertar;
                    cmd.Parameters.Add("pPartidasModelosInsertar", MySqlDbType.Int32).Value = objDatosBE.pPartidasModelosInsertar;
                    cmd.Parameters.Add("pPartidasRutinasInsertar", MySqlDbType.Int32).Value = objDatosBE.pPartidasRutinasInsertar;

                    cmd.Parameters.Add("pEquiposInsertar", MySqlDbType.LongText).Value = objDatosBE.EquiposInsertar;
                    cmd.Parameters.Add("pEquiposMarcasInsertar", MySqlDbType.LongText).Value = objDatosBE.EquiposMarcasInsertar;
                    cmd.Parameters.Add("pEquiposModelosInsertar", MySqlDbType.LongText).Value = objDatosBE.EquiposModelosInsertar;


                    cmd.Parameters.Add("pModelosInsertar", MySqlDbType.LongText).Value = objDatosBE.ModelosInsertar;
                    cmd.Parameters.Add("pModelosMarcasInsertar", MySqlDbType.LongText).Value = objDatosBE.ModelosMarcasInsertar;


                    cmd.Parameters.Add("pMarcasInsertar", MySqlDbType.LongText).Value = objDatosBE.MarcasInsertar;
                    cmd.Parameters.Add("pFormatoImprecion", MySqlDbType.Int32).Value = objDatosBE.formato_imprecion;

                    cmd.Parameters.Add("pRutinasInsertar", MySqlDbType.LongText).Value = objDatosBE.RutinasInsertar;

                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.id;
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;
                    try
                    {
                        General.oDatos.Ejecutar(cmd);

                        intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString());
                        if (intResultado > 0)
                            return intResultado;
                        else
                            throw new Exception("Ha ocurrido un error al guardar");
                    }
                    catch (MySqlException mx)
                    {
                        throw;
                    }                    
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int InsertarJurisdiccion(BE.AnexosBE objDatosBE)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_ANEXOS_JURISDICCION_INSERTAR";
                    cmd.Parameters.Add("pFolio", MySqlDbType.VarChar, 50).Value = objDatosBE.folio;
                    cmd.Parameters.Add("pFecha", MySqlDbType.DateTime).Value = objDatosBE.fecha.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters.Add("pCliente", MySqlDbType.Int32).Value = objDatosBE.id_cliente;
                    cmd.Parameters.Add("pClues", MySqlDbType.VarChar, 255).Value = objDatosBE.clues;
                    cmd.Parameters.Add("pCentro", MySqlDbType.VarChar, 255).Value = objDatosBE.centro_coste;
                    cmd.Parameters.Add("pUnidad", MySqlDbType.VarChar, 255).Value = objDatosBE.nombre_unidad;
                    cmd.Parameters.Add("pProveedor", MySqlDbType.VarChar, 255).Value = objDatosBE.id_padron_proveedor;
                    cmd.Parameters.Add("pEmpresa", MySqlDbType.VarChar, 100).Value = objDatosBE.nombre_empresa;
                    cmd.Parameters.Add("pTipo", MySqlDbType.Int32).Value = objDatosBE.tipo_servicio;
                    cmd.Parameters.Add("pCosto1", MySqlDbType.Decimal).Value = objDatosBE.costo_1;
                    cmd.Parameters.Add("pCosto2", MySqlDbType.Decimal).Value = objDatosBE.costo_2;
                    cmd.Parameters.Add("pCostoTotal", MySqlDbType.Decimal).Value = objDatosBE.costo_total;
                    cmd.Parameters.Add("pEstatus", MySqlDbType.Int32).Value = objDatosBE.estatus;
                    cmd.Parameters.Add("pUsuario", MySqlDbType.Int32).Value = objDatosBE.usuario;
                    cmd.Parameters.Add("pFechaModificacion", MySqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters.Add("pPlataforma", MySqlDbType.LongText).Value = objDatosBE.id_plataforma;
                    cmd.Parameters.Add("pMarca", MySqlDbType.LongText).Value = objDatosBE.id_marca;
                    cmd.Parameters.Add("pModelo", MySqlDbType.LongText).Value = objDatosBE.id_modelo;
                    cmd.Parameters.Add("pEquipo", MySqlDbType.LongText).Value = objDatosBE.id_equipo;
                    cmd.Parameters.Add("pRutina", MySqlDbType.LongText).Value = objDatosBE.id_rutina;
                    cmd.Parameters.Add("pCabms", MySqlDbType.LongText).Value = objDatosBE.cabms;
                    cmd.Parameters.Add("pSerie", MySqlDbType.LongText).Value = objDatosBE.serie;
                    cmd.Parameters.Add("pFecha_m1", MySqlDbType.LongText).Value = objDatosBE.fecha_m1;
                    cmd.Parameters.Add("pCosto1D", MySqlDbType.LongText).Value = objDatosBE.costo1;
                    cmd.Parameters.Add("pFecha_m2", MySqlDbType.LongText).Value = objDatosBE.fecha_m2;
                    cmd.Parameters.Add("pCosto2D", MySqlDbType.LongText).Value = objDatosBE.costo2;
                    cmd.Parameters.Add("pTotal", MySqlDbType.LongText).Value = objDatosBE.total;
                    cmd.Parameters.Add("pPartidas", MySqlDbType.Int32).Value = objDatosBE.pPartidas;
                    cmd.Parameters.Add("pDClues", MySqlDbType.LongText).Value = objDatosBE.dClues;
                    cmd.Parameters.Add("pDUnidad", MySqlDbType.LongText).Value = objDatosBE.dunidad;
                    cmd.Parameters.Add("pDCeco", MySqlDbType.LongText).Value = objDatosBE.dceco;
                    cmd.Parameters.Add("pOrigen", MySqlDbType.Int32).Value = objDatosBE.idOrigen;

                    cmd.Parameters.Add("pPartidasEquiposInsertar", MySqlDbType.Int32).Value = objDatosBE.pPartidasEquiposInsertar;
                    cmd.Parameters.Add("pPartidasMarcasInsertar", MySqlDbType.Int32).Value = objDatosBE.pPartidasMarcasInsertar;
                    cmd.Parameters.Add("pPartidasModelosInsertar", MySqlDbType.Int32).Value = objDatosBE.pPartidasModelosInsertar;
                    cmd.Parameters.Add("pPartidasRutinasInsertar", MySqlDbType.Int32).Value = objDatosBE.pPartidasRutinasInsertar;

                    cmd.Parameters.Add("pEquiposInsertar", MySqlDbType.LongText).Value = objDatosBE.EquiposInsertar;
                    cmd.Parameters.Add("pEquiposMarcasInsertar", MySqlDbType.LongText).Value = objDatosBE.EquiposMarcasInsertar;
                    cmd.Parameters.Add("pEquiposModelosInsertar", MySqlDbType.LongText).Value = objDatosBE.EquiposModelosInsertar;


                    cmd.Parameters.Add("pModelosInsertar", MySqlDbType.LongText).Value = objDatosBE.ModelosInsertar;
                    cmd.Parameters.Add("pModelosMarcasInsertar", MySqlDbType.LongText).Value = objDatosBE.ModelosMarcasInsertar;


                    cmd.Parameters.Add("pMarcasInsertar", MySqlDbType.LongText).Value = objDatosBE.MarcasInsertar;
                    cmd.Parameters.Add("pFormatoImprecion", MySqlDbType.Int32).Value = objDatosBE.formato_imprecion;
                    
                    cmd.Parameters.Add("pRutinasInsertar", MySqlDbType.LongText).Value = objDatosBE.RutinasInsertar;

                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.id;
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;
                    try
                    {
                        General.oDatos.Ejecutar(cmd);

                        intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString());
                        if (intResultado > 0)
                            return intResultado;
                        else
                            throw new Exception("Ha ocurrido un error al guardar");
                    }
                    catch (MySqlException mx)
                    {
                        throw;
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Modificar(BE.AnexosBE objDatosBE)
        {
            try
             {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_ANEXOS_MODIFICAR";
                    cmd.Parameters.Add("pFolio", MySqlDbType.VarChar, 50).Value = objDatosBE.folio;
                    cmd.Parameters.Add("pFecha", MySqlDbType.DateTime).Value = objDatosBE.fecha.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters.Add("pCliente", MySqlDbType.Int32).Value = objDatosBE.id_cliente;
                    cmd.Parameters.Add("pClues", MySqlDbType.VarChar, 255).Value = objDatosBE.clues;
                    cmd.Parameters.Add("pCentro", MySqlDbType.VarChar, 255).Value = objDatosBE.centro_coste;
                    cmd.Parameters.Add("pUnidad", MySqlDbType.VarChar, 255).Value = objDatosBE.nombre_unidad;
                    cmd.Parameters.Add("pProveedor", MySqlDbType.VarChar, 255).Value = objDatosBE.id_padron_proveedor;
                    cmd.Parameters.Add("pEmpresa", MySqlDbType.VarChar, 100).Value = objDatosBE.nombre_empresa;
                    cmd.Parameters.Add("pTipo", MySqlDbType.Int32).Value = objDatosBE.tipo_servicio;
                    cmd.Parameters.Add("pCosto1", MySqlDbType.Decimal).Value = objDatosBE.costo_1;
                    cmd.Parameters.Add("pCosto2", MySqlDbType.Decimal).Value = objDatosBE.costo_2;
                    cmd.Parameters.Add("pCostoTotal", MySqlDbType.Decimal).Value = objDatosBE.costo_total;
                    cmd.Parameters.Add("pEstatus", MySqlDbType.Int32).Value = objDatosBE.estatus;
                    cmd.Parameters.Add("pUsuario", MySqlDbType.Int32).Value = objDatosBE.usuario;
                    cmd.Parameters.Add("pFechaModificacion", MySqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters.Add("pPlataforma", MySqlDbType.LongText).Value = objDatosBE.id_plataforma;
                    cmd.Parameters.Add("pMarca", MySqlDbType.LongText).Value = objDatosBE.id_marca;
                    cmd.Parameters.Add("pModelo", MySqlDbType.LongText).Value = objDatosBE.id_modelo;
                    cmd.Parameters.Add("pEquipo", MySqlDbType.LongText).Value = objDatosBE.id_equipo;
                    cmd.Parameters.Add("pRutina", MySqlDbType.LongText).Value = objDatosBE.id_rutina;
                    cmd.Parameters.Add("pCabms", MySqlDbType.LongText).Value = objDatosBE.cabms;
                    cmd.Parameters.Add("pSerie", MySqlDbType.LongText).Value = objDatosBE.serie;
                    cmd.Parameters.Add("pFecha_m1", MySqlDbType.LongText).Value = objDatosBE.fecha_m1;
                    cmd.Parameters.Add("pCosto1D", MySqlDbType.LongText).Value = objDatosBE.costo1;
                    cmd.Parameters.Add("pFecha_m2", MySqlDbType.LongText).Value = objDatosBE.fecha_m2;
                    cmd.Parameters.Add("pCosto2D", MySqlDbType.LongText).Value = objDatosBE.costo2;
                    cmd.Parameters.Add("pTotal", MySqlDbType.LongText).Value = objDatosBE.total;
                    cmd.Parameters.Add("pPartidas", MySqlDbType.Int32).Value = objDatosBE.pPartidas;
                    cmd.Parameters.Add("pDClues", MySqlDbType.LongText).Value = objDatosBE.dClues;
                    cmd.Parameters.Add("pDUnidad", MySqlDbType.LongText).Value = objDatosBE.dunidad;
                    cmd.Parameters.Add("pDCeco", MySqlDbType.LongText).Value = objDatosBE.dceco;
                    cmd.Parameters.Add("pOrigen", MySqlDbType.Int32).Value = objDatosBE.idOrigen;

                    cmd.Parameters.Add("pPartidasEquiposInsertar", MySqlDbType.Int32).Value = objDatosBE.pPartidasEquiposInsertar;
                    cmd.Parameters.Add("pPartidasMarcasInsertar", MySqlDbType.Int32).Value = objDatosBE.pPartidasMarcasInsertar;
                    cmd.Parameters.Add("pPartidasModelosInsertar", MySqlDbType.Int32).Value = objDatosBE.pPartidasModelosInsertar;
                    cmd.Parameters.Add("pPartidasRutinasInsertar", MySqlDbType.Int32).Value = objDatosBE.pPartidasRutinasInsertar;

                    cmd.Parameters.Add("pEquiposInsertar", MySqlDbType.LongText).Value = objDatosBE.EquiposInsertar;
                    cmd.Parameters.Add("pEquiposMarcasInsertar", MySqlDbType.LongText).Value = objDatosBE.EquiposMarcasInsertar;
                    cmd.Parameters.Add("pEquiposModelosInsertar", MySqlDbType.LongText).Value = objDatosBE.EquiposModelosInsertar;


                    cmd.Parameters.Add("pModelosInsertar", MySqlDbType.LongText).Value = objDatosBE.ModelosInsertar;
                    cmd.Parameters.Add("pModelosMarcasInsertar", MySqlDbType.LongText).Value = objDatosBE.ModelosMarcasInsertar;


                    cmd.Parameters.Add("pMarcasInsertar", MySqlDbType.LongText).Value = objDatosBE.MarcasInsertar;
                    cmd.Parameters.Add("pFormatoImprecion", MySqlDbType.Int32).Value = objDatosBE.formato_imprecion;

                    cmd.Parameters.Add("pRutinasInsertar", MySqlDbType.LongText).Value = objDatosBE.RutinasInsertar;

                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.id;
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;
                    General.oDatos.Ejecutar(cmd);
                    intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString());
                    
                    if (intResultado > 0)
                        return intResultado;
                    else if (intResultado == -1)
                        throw new Exception("El caise ya se encuentra registrado");
                    else
                        throw new Exception("Ha ocurrido un error al guardar");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int ModificarJurisdiccion(BE.AnexosBE objDatosBE)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_ANEXOS_JURISDICCION_MODIFICAR";
                    cmd.Parameters.Add("pFolio", MySqlDbType.VarChar, 50).Value = objDatosBE.folio;
                    cmd.Parameters.Add("pFecha", MySqlDbType.DateTime).Value = objDatosBE.fecha.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters.Add("pCliente", MySqlDbType.Int32).Value = objDatosBE.id_cliente;
                    cmd.Parameters.Add("pClues", MySqlDbType.VarChar, 255).Value = objDatosBE.clues;
                    cmd.Parameters.Add("pCentro", MySqlDbType.VarChar, 255).Value = objDatosBE.centro_coste;
                    cmd.Parameters.Add("pUnidad", MySqlDbType.VarChar, 255).Value = objDatosBE.nombre_unidad;
                    cmd.Parameters.Add("pProveedor", MySqlDbType.VarChar, 255).Value = objDatosBE.id_padron_proveedor;
                    cmd.Parameters.Add("pEmpresa", MySqlDbType.VarChar, 100).Value = objDatosBE.nombre_empresa;
                    cmd.Parameters.Add("pTipo", MySqlDbType.Int32).Value = objDatosBE.tipo_servicio;
                    cmd.Parameters.Add("pCosto1", MySqlDbType.Decimal).Value = objDatosBE.costo_1;
                    cmd.Parameters.Add("pCosto2", MySqlDbType.Decimal).Value = objDatosBE.costo_2;
                    cmd.Parameters.Add("pCostoTotal", MySqlDbType.Decimal).Value = objDatosBE.costo_total;
                    cmd.Parameters.Add("pEstatus", MySqlDbType.Int32).Value = objDatosBE.estatus;
                    cmd.Parameters.Add("pUsuario", MySqlDbType.Int32).Value = objDatosBE.usuario;
                    cmd.Parameters.Add("pFechaModificacion", MySqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    cmd.Parameters.Add("pPlataforma", MySqlDbType.LongText).Value = objDatosBE.id_plataforma;
                    cmd.Parameters.Add("pMarca", MySqlDbType.LongText).Value = objDatosBE.id_marca;
                    cmd.Parameters.Add("pModelo", MySqlDbType.LongText).Value = objDatosBE.id_modelo;
                    cmd.Parameters.Add("pEquipo", MySqlDbType.LongText).Value = objDatosBE.id_equipo;
                    cmd.Parameters.Add("pRutina", MySqlDbType.LongText).Value = objDatosBE.id_rutina;
                    cmd.Parameters.Add("pCabms", MySqlDbType.LongText).Value = objDatosBE.cabms;
                    cmd.Parameters.Add("pSerie", MySqlDbType.LongText).Value = objDatosBE.serie;
                    cmd.Parameters.Add("pFecha_m1", MySqlDbType.LongText).Value = objDatosBE.fecha_m1;
                    cmd.Parameters.Add("pCosto1D", MySqlDbType.LongText).Value = objDatosBE.costo1;
                    cmd.Parameters.Add("pFecha_m2", MySqlDbType.LongText).Value = objDatosBE.fecha_m2;
                    cmd.Parameters.Add("pCosto2D", MySqlDbType.LongText).Value = objDatosBE.costo2;
                    cmd.Parameters.Add("pTotal", MySqlDbType.LongText).Value = objDatosBE.total;
                    cmd.Parameters.Add("pPartidas", MySqlDbType.Int32).Value = objDatosBE.pPartidas;
                    cmd.Parameters.Add("pDClues", MySqlDbType.LongText).Value = objDatosBE.dClues;
                    cmd.Parameters.Add("pDUnidad", MySqlDbType.LongText).Value = objDatosBE.dunidad;
                    cmd.Parameters.Add("pDCeco", MySqlDbType.LongText).Value = objDatosBE.dceco;
                    cmd.Parameters.Add("pOrigen", MySqlDbType.Int32).Value = objDatosBE.idOrigen;

                    cmd.Parameters.Add("pPartidasEquiposInsertar", MySqlDbType.Int32).Value = objDatosBE.pPartidasEquiposInsertar;
                    cmd.Parameters.Add("pPartidasMarcasInsertar", MySqlDbType.Int32).Value = objDatosBE.pPartidasMarcasInsertar;
                    cmd.Parameters.Add("pPartidasModelosInsertar", MySqlDbType.Int32).Value = objDatosBE.pPartidasModelosInsertar;
                    cmd.Parameters.Add("pPartidasRutinasInsertar", MySqlDbType.Int32).Value = objDatosBE.pPartidasRutinasInsertar;

                    cmd.Parameters.Add("pEquiposInsertar", MySqlDbType.LongText).Value = objDatosBE.EquiposInsertar;
                    cmd.Parameters.Add("pEquiposMarcasInsertar", MySqlDbType.LongText).Value = objDatosBE.EquiposMarcasInsertar;
                    cmd.Parameters.Add("pEquiposModelosInsertar", MySqlDbType.LongText).Value = objDatosBE.EquiposModelosInsertar;


                    cmd.Parameters.Add("pModelosInsertar", MySqlDbType.LongText).Value = objDatosBE.ModelosInsertar;
                    cmd.Parameters.Add("pModelosMarcasInsertar", MySqlDbType.LongText).Value = objDatosBE.ModelosMarcasInsertar;


                    cmd.Parameters.Add("pMarcasInsertar", MySqlDbType.LongText).Value = objDatosBE.MarcasInsertar;
                    cmd.Parameters.Add("pFormatoImprecion", MySqlDbType.Int32).Value = objDatosBE.formato_imprecion;

                    cmd.Parameters.Add("pRutinasInsertar", MySqlDbType.LongText).Value = objDatosBE.RutinasInsertar;

                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.id;
                    cmd.Parameters["pId"].Direction = System.Data.ParameterDirection.InputOutput;
                    General.oDatos.Ejecutar(cmd);
                    intResultado = int.Parse(cmd.Parameters["pId"].Value.ToString());

                    if (intResultado > 0)
                        return intResultado;
                    else if (intResultado == -1)
                        throw new Exception("El caise ya se encuentra registrado");
                    else
                        throw new Exception("Ha ocurrido un error al guardar");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Eliminar(BE.AnexosBE objDatosBE)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_ANEXOS_ELIMINAR";
                    cmd.Parameters.Add("pId", MySqlDbType.Int32).Value = objDatosBE.id;
                    cmd.Parameters.Add("pUsuario", MySqlDbType.Int32).Value = objDatosBE.usuario;
                    cmd.Parameters.Add("pFecha", MySqlDbType.Datetime).Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
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

        public int Finalizar(BE.AnexosBE objDatosBE)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    int intResultado;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "SP_ANEXOS_FINALIZAR";
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
