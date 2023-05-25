using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace wfaIntersem
{
    public partial class frmEmpleadosD : DevExpress.XtraEditors.XtraForm
    {
        int intModo;
        int intPermiso;
        bool blnRespuesta;
        int intId;
        bool blnDesdeCombo;
        DataTable dtContactosE = new DataTable();

        public frmEmpleadosD()
        {
            InitializeComponent();
        }

        private void frmCatalogoDetalle_Load(object sender, EventArgs e)
        {
            CrearTabla();
            if (intModo == 0)
            {
                backwDatos.RunWorkerAsync(2);
                Permiso();
            }
            else if (intModo == 1)
            {
                Desactiva();
                txtNombreCompleto.Focus();
                StatusMenu();
                backwDatos.RunWorkerAsync(1);
            }
            else
            {
                backwDatos.RunWorkerAsync(2);
                Desactiva();
                txtUsuario.Focus();
                StatusMenu();
            }

        }

        private void mnuSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        #region FuncionesPublicas

        public bool NuevoDetalle(int intPermisoP)
        {
            intPermiso = intPermisoP;
            intModo = 1;
            this.ShowDialog();
            return blnRespuesta;
        }

        public int NuevoDetalle()
        {
            blnDesdeCombo = true;
            intModo = 1;
            this.ShowDialog();
            return intId;
        }

        public bool EditarDetalle(int intIDP, int intPermisoP)
        {
            intId = intIDP;
            intPermiso = intPermisoP;
            intModo = 0;
            this.ShowDialog();
            return blnRespuesta;
        }



        public bool ConsultarDetalle(int _intId, int _intPermiso)
        {
            intId = _intId;
            intPermiso = _intPermiso;
            intModo = 0;
            this.ShowDialog();
            return blnRespuesta;
        }


        #endregion



        #region FuncionesPrivadas

        private void Permiso()
        {
            int intTempPermiso = 0;
            int intPermAct = intPermiso;
            if (intPermiso > 0)
            {
                while (intPermAct > 0)
                {
                    intTempPermiso = Modulo.BuscaNumeroBinarioInferiorA(intPermAct);
                    intPermAct = intPermAct - intTempPermiso;
                    switch (intTempPermiso)
                    {
                        case 1:
                            mnuNuevo.Enabled = true;
                            break;
                        case 2:
                            mnuEditar.Enabled = true;
                            break;
                        default:
                            break;
                    }
                }
            }

        }


        private void Limpia()
        {
            txtContra.Text = "";
            txtUsuario.Text = "";
            txtCorreo.Text = "";
            cmbPerfil.Text = "";
            txtObservaciones.Text = "";

            txtNombreCompleto.Text = "";
            txtRfc.Text = "";
            txtCurp.Text = "";
            txtCalle.Text = "";
            txtColonia.Text = "";
            txtNoExterior.Text = "";
            txtNoInterior.Text = "";
            txtCP.Text = "";
            cmbMunicipio.Text = "";
            txtCelular.Text = "";
            txtTelefono.Text = "";
            cmbTipoSangre.Text = "";
            txtAlergias.Text = "";
            txtSeguro.Text = "";
            txtNumEmpleado.Text = "";

        }



        private void Desactiva()
        {

            txtUsuario.Enabled = !txtUsuario.Enabled;
            txtContra.Enabled = !txtContra.Enabled;
            txtCorreo.Enabled = !txtCorreo.Enabled;
            cmbPerfil.Enabled = !cmbPerfil.Enabled;
            txtCP.Enabled =!txtCP.Enabled;
            txtColonia.Enabled = !txtColonia.Enabled;
            txtCalle.Enabled = !txtCalle.Enabled;
            txtCelular.Enabled = !txtCelular.Enabled;
            txtAlergias.Enabled = !txtAlergias.Enabled;
            txtNoInterior.Enabled = !txtNoInterior.Enabled;
            txtNoExterior.Enabled = !txtNoExterior.Enabled;
            txtNombreCompleto.Enabled = !txtNombreCompleto.Enabled;
            txtRfc.Enabled = !txtRfc.Enabled;
            txtCurp.Enabled = !txtCurp.Enabled;
            cmbMunicipio.Enabled = !cmbMunicipio.Enabled;

            txtTelefono.Enabled = !txtTelefono.Enabled;
            txtSeguro.Enabled = !txtSeguro.Enabled;
            // txtNumEmpleado.Enabled = !txtNumEmpleado.Enabled;
            cmbTipoJornada.Enabled = !cmbTipoJornada.Enabled;
            txtObservaciones.Enabled = !txtObservaciones.Enabled;
            cmbTipoSangre.Enabled = !cmbTipoSangre.Enabled;
            grvContactosE.OptionsBehavior.ReadOnly = !grvContactosE.OptionsBehavior.ReadOnly;


        }


        private void StatusMenu()
        {
            switch (intModo)
            {
                case 0:
                    mnuNuevo.Enabled = true;
                    mnuGuardar.Enabled = false;
                    mnuEditar.Enabled = true;
                    break;
                case 1:
                    mnuNuevo.Enabled = false;
                    mnuEditar.Enabled = false;
                    mnuGuardar.Enabled = true;
                    break;
                case 2:
                    mnuEditar.Enabled = false;
                    mnuNuevo.Enabled = false;
                    mnuGuardar.Enabled = true;
                    break;
                default:
                    break;
            }
        }


        private void MuestraDatos()
        {
            try
            {
                DataTable dtDatos = new DataTable();
                dtDatos = Modulo.cBP.Seleccionar("CALL SP_EMPLEADO_SELECCIONAR(" + intId + ")");

                DataTable dtDetalle = new DataTable();
                dtDetalle = Modulo.cBP.Seleccionar("CALL SP_EMPLEADOS_CONTACTOS_SELECCIONAR(" + intId + ")");

                if (dtDatos.Rows.Count > 0)
                {

                    txtContra.Text = "CAMBIO CONTRASEÑA";
                    txtCorreo.Text = dtDatos.Rows[0]["correo"].ToString();
                    txtUsuario.Text = dtDatos.Rows[0]["usuario"].ToString();

                    cmbPerfil.EditValue = dtDatos.Rows[0]["id_perfil"].ToString();

                    txtNombreCompleto.Text= dtDatos.Rows[0]["nombre_completo"].ToString();
                    txtRfc.Text = dtDatos.Rows[0]["rfc"].ToString();
                    txtCurp.Text = dtDatos.Rows[0]["curp"].ToString();
                    txtSeguro.Text = dtDatos.Rows[0]["num_seguro_social"].ToString();
                    txtNumEmpleado.Text = dtDatos.Rows[0]["num_empleado"].ToString();
                    txtCalle.Text = dtDatos.Rows[0]["calle"].ToString();
                    txtColonia.Text = dtDatos.Rows[0]["colonia"].ToString();
                    txtNoExterior.Text = dtDatos.Rows[0]["no_exterior"].ToString();
                    txtNoInterior.Text = dtDatos.Rows[0]["no_interior"].ToString();
                    cmbMunicipio.EditValue = dtDatos.Rows[0]["id_municipio"].ToString();
                    txtCP.Text = dtDatos.Rows[0]["codigo_postal"].ToString();
                    txtCelular.Text = dtDatos.Rows[0]["celular"].ToString();
                    txtTelefono.Text = dtDatos.Rows[0]["telefono"].ToString();
                    cmbTipoJornada.EditValue = dtDatos.Rows[0]["id_tipo_jornada"].ToString();
                    cmbTipoSangre.EditValue= dtDatos.Rows[0]["id_tipo_sangre"].ToString();
                    txtObservaciones.Text = dtDatos.Rows[0]["observaciones"].ToString();
                    txtAlergias.Text = dtDatos.Rows[0]["alergias"].ToString();

                    for (int i = 0; i < dtDetalle.Rows.Count; i++)
                    {
                        DataRow row = dtContactosE.NewRow();
                        row["id_contacto"] = Modulo.ConvertInt(dtDetalle.Rows[i]["id_contacto"].ToString());
                        row["nombre"] = dtDetalle.Rows[i]["nombre"].ToString();
                        row["apellido_p"] = dtDetalle.Rows[i]["apellido_p"].ToString();
                        row["apellido_m"] = dtDetalle.Rows[i]["apellido_m"].ToString();
                        row["telefono_contacto"] = dtDetalle.Rows[i]["telefono_contacto"].ToString();
                        row["celular_contacto"] = dtDetalle.Rows[i]["celular_contacto"].ToString();
                       
                        row["id_parentesco"] = Modulo.ConvertInt(dtDetalle.Rows[i]["id_parentesco"].ToString()); 
                        dtContactosE.Rows.Add(row);
                    }

                }
                grdContactosE.DataSource = dtContactosE;
                grvContactosE.BestFitColumns();



            }
            catch (Exception ex)
            {


                throw new Exception(ex.Message);
            }

        }


        private void Combos()
        {
            try
            {

                DataTable dtPerfil = new DataTable();
                dtPerfil = Modulo.GetDataTable("CALL SP_PERFILES_SELECCIONAR(null)");
                cmbPerfil.Properties.DataSource = dtPerfil;

                cmbTipoSangre.Properties.DataSource = Modulo.GetDataTable("CALL SP_TIPOS_SANGRE_SELECCIONAR()");
                cmbParentesco.DataSource = Modulo.GetDataTable("CALL SP_PARENTESCO_SELECCIONAR()");
                cmbMunicipio.Properties.DataSource = Modulo.GetDataTable("CALL SP_MUNICIPIOS_SELECCIONAR(null,null)");
                
                cmbTipoJornada.Properties.DataSource = Modulo.GetDataTable("CALL SP_TIPO_JORNADA_SELECCIONAR()");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


        #endregion
        private void frmCatalogoDetalle_Activated(object sender, EventArgs e)
        {
            Combos();
        }

        private void backwDatos_DoWork(object sender, DoWorkEventArgs e)
        {
            switch (e.Argument.ToString())
            {
                case "1":
                    break;
                case "2":
                    backwDatos.ReportProgress(2);
                    break;
                case "3":
                    backwDatos.ReportProgress(4);
                    break;
            }

        }

        private void Informacion()
        {
            MuestraDatos();
        }

        private void GuardarInformacion()
        {
            try
            {
                grvContactosE.PostEditor();
                BP.EmpleadosBP objDatosBp = new BP.EmpleadosBP();
                BE.EmpleadosBE objDatosBe = new BE.EmpleadosBE();

                objDatosBe.id_usuario = Modulo.IdUsuario;
                objDatosBe.usuario = txtUsuario.Text;
                objDatosBe.email = txtCorreo.Text;
                objDatosBe.contra = Modulo.HashPassword(txtContra.Text).ToLower();
                objDatosBe.id_perfil = Int32.Parse(cmbPerfil.EditValue.ToString());
                objDatosBe.Nombre_Completo = txtNombreCompleto.Text;
                objDatosBe.Rfc = txtRfc.Text;
                objDatosBe.Curp = txtCurp.Text;
                objDatosBe.Calle = txtCalle.Text;
                objDatosBe.Colonia = txtColonia.Text;
                objDatosBe.No_exterior = txtNoExterior.Text;
                objDatosBe.No_Interior = txtNoInterior.Text;
                objDatosBe.Codigo_postal = txtCP.Text;
                objDatosBe.Celular = txtCelular.Text;
                objDatosBe.Telefono = txtTelefono.Text;
                objDatosBe.Observaciones = txtObservaciones.Text;
                objDatosBe.Id_Municipio = Int32.Parse(cmbPerfil.EditValue.ToString());
                objDatosBe.Id_tipoSangre = Modulo.ConvertInt(cmbTipoSangre.EditValue.ToString());
                objDatosBe.Id_Tipo_Jornada = Modulo.ConvertInt(cmbTipoJornada.EditValue.ToString());
                objDatosBe.NumSeguro = txtSeguro.Text;
                objDatosBe.NumEmpleado = txtNumEmpleado.Text;
                objDatosBe.Alergias = txtAlergias.Text;
                objDatosBe.Partidas = dtContactosE.Rows.Count;

                dtContactosE.AcceptChanges();
               
                    for (int i = 0; i < dtContactosE.Rows.Count; i++)
                    {
                        objDatosBe.Ids_contacto += Modulo.ConvertInt(dtContactosE.Rows[i]["id_contacto"].ToString()).ToString() + "¬";
                        objDatosBe.Nombre_contacto += dtContactosE.Rows[i]["nombre"].ToString().ToUpper() + "¬";
                        objDatosBe.Apellidop_contacto += dtContactosE.Rows[i]["apellido_p"].ToString().ToUpper() + "¬";
                        objDatosBe.Apellidom_contacto += dtContactosE.Rows[i]["apellido_m"].ToString().ToUpper() + "¬";
                        objDatosBe.Celular_contacto += dtContactosE.Rows[i]["celular_contacto"].ToString().ToUpper() + "¬";
                        objDatosBe.Telefono_contacto += dtContactosE.Rows[i]["telefono_contacto"].ToString() + "¬";
                        objDatosBe.Id_parentesco += Modulo.ConvertInt(dtContactosE.Rows[i]["id_parentesco"].ToString()).ToString() + "¬";


                    }
                
               
                if (intModo == 1)
                {
                    objDatosBe.id = 0;
                    intId = objDatosBp.Insertar(objDatosBe);
                }
                else
                {
                    
                    objDatosBe.id = intId;
                    if (txtContra.Text != "CAMBIO CONTRASEÑA")
                    {
                        objDatosBe.Actualizar = 1;
                    }
                    else
                    {
                        objDatosBe.Actualizar = 0;
                    }

                    objDatosBp.Modificar(objDatosBe);
                }
                intModo = 0;
                Desactiva();
                StatusMenu();
                blnRespuesta = true;
                Modulo.Alertar.MuestraAlerta(1, this);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }



        }
        private void backwDatos_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                switch (e.ProgressPercentage)
                {
                    case 2:
                        Informacion();
                        break;
                    case 4:
                        GuardarInformacion();
                        break;
                }
            }
            catch (Exception ex)
            {
                prgProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                MessageBox.Show(ex.Message);
            }


        }

        private void backwDatos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            prgProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }

        private void mnuGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (intModo == 1)
                {
                    if (dxValidacion.Validate() == true)
                    {
                        prgProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        backwDatos.RunWorkerAsync(3);
                    }

                }
                else
                {
                    if (cmbPerfil.EditValue != null
                        && !string.IsNullOrEmpty(txtContra.Text.ToString())
                        && !string.IsNullOrEmpty(txtUsuario.Text.ToString())
                        )
                    {
                        prgProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        backwDatos.RunWorkerAsync(3);
                    }
                }

            }
            catch (Exception ex)
            {
                backwDatos.CancelAsync();
                MessageBox.Show(ex.Message);
            }


        }

        private void mnuNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Limpia();
            intModo = 1;
            StatusMenu();
            Desactiva();
            txtUsuario.Focus();

        }

        private void mnuEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            intModo = 2;
            StatusMenu();
            Desactiva();
            txtUsuario.Focus();

        }


        private void CrearTabla()
        {
            dtContactosE.Columns.Add("id_contacto", typeof(int));
            dtContactosE.Columns.Add("nombre", typeof(string));
            dtContactosE.Columns.Add("apellido_p", typeof(string));
            dtContactosE.Columns.Add("apellido_m", typeof(string));
            dtContactosE.Columns.Add("telefono_contacto", typeof(string));
            dtContactosE.Columns.Add("celular_contacto", typeof(string));
            dtContactosE.Columns.Add("id_parentesco", typeof(int));
            grdContactosE.DataSource = dtContactosE;
        }

        private void grvContactosE_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            DataRowView drv = (DataRowView)e.Row;

            if (dtContactosE.Select("nombre = '" + drv.Row[1].ToString() + "' and apellido_p = '" + drv.Row[2].ToString() + "' and apellido_m = '" + drv.Row[2].ToString() + "'").Count() > 1)
            {
                MessageBox.Show("El registro ya se encuentra agregado", "Contactos de Empleado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtContactosE.Rows.Remove(drv.Row);
            }
        }

        private void cmbAcciones_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int contacto_id = Modulo.ConvertInt(grvContactosE.GetFocusedRowCellValue(cIdContacto).ToString());
            if (contacto_id > 0)
            {
                Modulo.GetDataTable("CALL SP_EMPLEADOS_CONTACTOS_ELIMINAR(" + contacto_id + "," + Modulo.IdUsuario + ")");
                grvContactosE.DeleteRow(grvContactosE.FocusedRowHandle);
            }
            else
            {
                MessageBox.Show("Lo sentimos, ocurrio un error al borrar el contacto", "Error");/*, MessageBoxButton.OK, MessageBoxImage.Information);*/
            }
          

        }
    }

}