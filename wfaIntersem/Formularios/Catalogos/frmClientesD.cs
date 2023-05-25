using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;


namespace wfaIntersem
{
    public partial class frmClientesD : DevExpress.XtraEditors.XtraForm
    {
        int intModo;
        int intPermiso;
        bool blnRespuesta;
        int intId;
        DataTable dtContactos = new DataTable();
        string ruta_pdf, nombre_pdf, ruta_pdfSeleccionar;
        public frmClientesD()
        {
            InitializeComponent();
        }

        private void frmCatalogoDetalle_Load(object sender, EventArgs e)
        {
            Combos();
            CrearTabla();
            if (intModo == 0)
            {
                backwDatos.RunWorkerAsync(2);
                Permiso();
            }
            else if (intModo == 1)
            {
                Desactiva();
                txtRazonSocial.Focus();
                StatusMenu();
                backwDatos.RunWorkerAsync(1);
            }
            else
            {
                backwDatos.RunWorkerAsync(2);
                Desactiva();
                txtRazonSocial.Focus();
                StatusMenu();
            }


        }


        private void cmbCombo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void mnuSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void mnuSalir1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
            intModo = 1;
            this.ShowDialog();
            return intId;
        }

        public bool EditarDetalle(int intIDP, int intPermisoP)
        {
            intId = intIDP;
            intPermiso = intPermisoP;
            intModo = 2;
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
                    intPermAct -= intTempPermiso;
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
            txtRazonSocial.Text = "";
            txtCalle.Text = "";
            txtNo.Text = "";
            txtNoInt.Text = "";
            txtNombreFiscal.Text = "";
            txtColonia.Text = "";
            cmbEstado.EditValue = null;
            cmbMunicipio.EditValue = null;
            cmbRegimenFiscal.EditValue = null;
            cmbUsoCFDI.EditValue = null;
           
            txtCp.Text = "";
            txtCorreo.Text = "";
            txtRFC.Text = "";
            txtCelular.Text = "";
            txtTelefono.Text = "";
            txtTelExt.Text = "";

            dtContactos.Clear();
        }



        private void Desactiva()
        {
            txtRazonSocial.Enabled = !txtRazonSocial.Enabled;
            txtCalle.Enabled = !txtCalle.Enabled;
            txtColonia.Enabled = !txtColonia.Enabled;
            txtNo.Enabled = !txtNo.Enabled;
            txtNoInt.Enabled = !txtNoInt.Enabled;
            txtNombreFiscal.Enabled = !txtNombreFiscal.Enabled;
            cmbEstado.Enabled = !cmbEstado.Enabled;
            cmbMunicipio.Enabled = !cmbMunicipio.Enabled;
            cmbUsoCFDI.Enabled = !cmbUsoCFDI.Enabled;
            cmbRegimenFiscal.Enabled = !cmbRegimenFiscal.Enabled;
            
            txtCp.Enabled = !txtCp.Enabled;
            txtCorreo.Enabled = !txtCorreo.Enabled;
            
            txtRFC.Enabled = !txtRFC.Enabled;
            txtTelefono.Enabled = !txtTelefono.Enabled;
            txtTelExt.Enabled = !txtTelExt.Enabled;
            txtCelular.Enabled = !txtCelular.Enabled;
            txtObservaciones.Enabled = !txtObservaciones.Enabled;
            peFoto.Enabled = !peFoto.Enabled;
            btnPDF.Enabled = !btnPDF.Enabled;
            grvContactos.OptionsBehavior.ReadOnly = !grvContactos.OptionsBehavior.ReadOnly;
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
                ruta_pdf = null;
                DataTable dtDatos = new DataTable();
                dtDatos = Modulo.cBP.Seleccionar("CALL SP_CLIENTES_SELECCIONAR(" + intId + ", null)");
                DataTable dtDetalle = new DataTable();
                dtDetalle = Modulo.cBP.Seleccionar("CALL SP_CLIENTES_CONTACTOS_SELECCIONAR(" + intId + ", null)");
                if (dtDatos.Rows.Count>0)
                {
                    txtRazonSocial.Text = dtDatos.Rows[0]["razon_social"].ToString();
                    txtCalle.Text = dtDatos.Rows[0]["calle"].ToString();
                    txtColonia.Text = dtDatos.Rows[0]["colonia"].ToString();
                    txtNo.Text = dtDatos.Rows[0]["numero"].ToString();
                    txtNoInt.Text = dtDatos.Rows[0]["numero_int"].ToString();
                    txtNombreFiscal.Text = dtDatos.Rows[0]["nombre_fiscal"].ToString();
                    txtRFC.Text = dtDatos.Rows[0]["rfc"].ToString();
                    cmbEstado.EditValue = dtDatos.Rows[0]["id_estado"];
                    cmbMunicipio.EditValue = int.Parse(dtDatos.Rows[0]["id_municipio"].ToString(), Modulo.culture);
                    cmbRegimenFiscal.EditValue = Modulo.ConvertInt(dtDatos.Rows[0]["regimen_fiscal_id"].ToString());
                    cmbUsoCFDI.EditValue = Modulo.ConvertInt(dtDatos.Rows[0]["uso_cfdi_id"].ToString());
                    


                    if (dtDatos.Rows[0]["fotoEmpresa"] != DBNull.Value)
                    {
                        Image imagen = Modulo.ByteToImage(dtDatos.Rows[0]["fotoEmpresa"] as byte[]);
                        peFoto.Image = imagen;
                    }

                  

                    txtObservaciones.Text = dtDatos.Rows[0]["observaciones"].ToString();
                    txtCp.Text = dtDatos.Rows[0]["cp"].ToString();
                    txtCorreo.Text = dtDatos.Rows[0]["correo"].ToString();
                    txtTelefono.Text = dtDatos.Rows[0]["telefono"].ToString();
                    txtTelExt.Text = dtDatos.Rows[0]["telefono_extension"].ToString();
                    txtCelular.Text = dtDatos.Rows[0]["celular"].ToString();
                    
                    for (int i = 0; i < dtDetalle.Rows.Count; i++)
                    {
                        DataRow row = dtContactos.NewRow();
                        row["id_contacto"] = Modulo.ConvertInt(dtDetalle.Rows[i]["id_contacto"].ToString());
                        row["nombre"] = dtDetalle.Rows[i]["nombre"].ToString();
                        row["apellido_p"] = dtDetalle.Rows[i]["apellido_p"].ToString();
                        row["apellido_m"] = dtDetalle.Rows[i]["apellido_m"].ToString();
                        row["correo"] = dtDetalle.Rows[i]["correo_contacto"].ToString();
                        row["correo_alternativo"] = dtDetalle.Rows[i]["correo_alternativo"].ToString();
                        row["telefono"] = dtDetalle.Rows[i]["telefono_contacto"].ToString();
                        row["extencion"] = dtDetalle.Rows[i]["telefono_extencion_contacto"].ToString();
                        dtContactos.Rows.Add(row);
                    }
                    if (dtDatos.Rows[0]["situacion_fiscal"] == DBNull.Value )
                    {
                        ruta_pdfSeleccionar = "No hay archivo";
                        btnPDF.Text = "No hay archivo almacenado";
                    }
                    else
                    {
                        ruta_pdfSeleccionar = Modulo.BinaryToText((byte[])dtDatos.Rows[0]["situacion_fiscal"]);
                        btnPDF.Text = dtDatos.Rows[0]["pdf_nombre"].ToString();
                    }
                }
                grdContactos.DataSource = dtContactos;
                grvContactos.BestFitColumns();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }


        private void Combos()
        {
          
            cmbEstado.Properties.DataSource = Modulo.GetDataTable("CALL SP_ESTADOS_SELECCIONAR(null)");
            cmbRegimenFiscal.Properties.DataSource = Modulo.GetDataTable("CALL SP_REGIMENES_FISCAL_SELECCIONAR()");

            cmbEstado.EditValue = 1;
            
        }

        private void CrearTabla()
        {
            dtContactos.Columns.Add("id_contacto", typeof(int));
            dtContactos.Columns.Add("nombre", typeof(string));
            dtContactos.Columns.Add("apellido_p", typeof(string));
            dtContactos.Columns.Add("apellido_m", typeof(string));
            dtContactos.Columns.Add("correo", typeof(string));
            dtContactos.Columns.Add("correo_alternativo", typeof(string));
            dtContactos.Columns.Add("telefono", typeof(string));
            dtContactos.Columns.Add("extencion", typeof(string));

            grdContactos.DataSource = dtContactos;
        }


        #endregion


        private void mnuEditar1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            intModo = 2;
            StatusMenu();
            Desactiva();
            txtRazonSocial.Focus();
           
        }

        private void mnuNuevo1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Limpia();
            intModo = 1;
            StatusMenu();
            Desactiva();
            txtRazonSocial.Focus();

        }

        private void frmCatalogoDetalle_Activated(object sender, EventArgs e)
        {
       //     Combos();
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
                dtContactos.AcceptChanges();

                BP.ClientesBP objDatosBp = new BP.ClientesBP();
                BE.ClientesBE objDatosBe = new BE.ClientesBE
                {
                    Nombre = txtRazonSocial.Text,
                    Nombre_Fiscal = txtNombreFiscal.Text,
                    Rfc = txtRFC.Text,
                    Telefono = txtTelefono.Text,
                    Telefono_ext = txtTelExt.Text,

                    Celular = txtCelular.Text,
                    Calle = txtCalle.Text,
                    Numero = txtNo.Text,
                    Numero_int = txtNoInt.Text,
                    Colonia = txtColonia.Text,
                    Codigo_postal = txtCp.Text,
                    Id_estado = Modulo.ConvertInt(cmbEstado.EditValue.ToString()),
                    Id_municipio = Modulo.ConvertInt(cmbMunicipio.EditValue.ToString()),
                    Id_RegimenFiscal = Modulo.ConvertInt(cmbRegimenFiscal.EditValue.ToString()),
                    Id_UsoCFDI = Modulo.ConvertInt(cmbUsoCFDI.EditValue.ToString()),

                    Correo = txtCorreo.Text,

                    Foto = (peFoto.Image == null) ? null : Modulo.ImageToByte(peFoto.Image),

                    Observaciones = txtObservaciones.Text,

                    Situacion_fiscal = (ruta_pdf == null) ? null : Modulo.fileToByte(ruta_pdf),
                    Nombre_pdf = (nombre_pdf != "") ? nombre_pdf : "No hay Situación Fiscal",


                    Partidas = dtContactos.Rows.Count,
                    Id_usuario = Modulo.IdUsuario
                };

                
                for (int i = 0; i < dtContactos.Rows.Count; i++)
                {
                    objDatosBe.Ids_contacto += Modulo.ConvertInt(dtContactos.Rows[i]["id_contacto"].ToString()).ToString() + "¬";
                    objDatosBe.Nombre_contacto += dtContactos.Rows[i]["nombre"].ToString().ToUpper() + "¬";
                    objDatosBe.Apellidop_contacto += dtContactos.Rows[i]["apellido_p"].ToString().ToUpper() + "¬";
                    objDatosBe.Apellidom_contacto += dtContactos.Rows[i]["apellido_m"].ToString().ToUpper() + "¬";
                    objDatosBe.Correo_contacto += dtContactos.Rows[i]["correo"].ToString().ToUpper() + "¬";
                    objDatosBe.Correo_alternativo_contacto += dtContactos.Rows[i]["correo_alternativo"].ToString().ToUpper() + "¬";
                    objDatosBe.Telefono_contacto += dtContactos.Rows[i]["telefono"].ToString() + "¬";
                    objDatosBe.Telefono_extencion_contacto += dtContactos.Rows[i]["extencion"].ToString() + "¬";
                   
                }


                if (intModo == 1)
                {
                    objDatosBe.Id = 0;
                    intId = objDatosBp.Insertar(objDatosBe);
                }
                else 
                {

                    objDatosBe.Id = intId;
                    objDatosBp.Modificar(objDatosBe);
                }
                intModo = 0;
                Desactiva();
                StatusMenu();
                blnRespuesta = true;
                Modulo.Alertar.MuestraAlerta(1, this);
                this.Close();
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
                if (dxValidacion.Validate() == true)
                {
                    prgProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    backwDatos.RunWorkerAsync(3);
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
            txtRazonSocial.Focus();
        }

        private void mnuEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            intModo = 2;
            StatusMenu();
            Desactiva();
            txtRazonSocial.Focus();
        }

        private void cmbEstado_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbEstado.EditValue != null)
            {
                cmbMunicipio.Properties.DataSource = Modulo.GetDataTable("CALL SP_MUNICIPIOS_SELECCIONAR(null,"+cmbEstado.EditValue.ToString()+")");
            }
        }
       

        private void grvContactos_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0) cmbAcciones.Buttons[0].Visible = true;
            else cmbAcciones.Buttons[0].Visible = false;
        }

        private void grvContactos_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            DataRowView drv = (DataRowView)e.Row;

            if (dtContactos.Select("nombre = '" + drv.Row[1].ToString() + "' and apellido_p = '" + drv.Row[2].ToString() + "' and apellido_m = '"+ drv.Row[2].ToString() + "'").Count() > 1)
            {
                MessageBox.Show("El registro ya se encuentra agregado", "Contactos de cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtContactos.Rows.Remove(drv.Row);
            }
        }

        private void grvContactos_ShowingEditor(object sender, CancelEventArgs e)
        {/*
            if (grvContactos.FocusedRowHandle < 0 && grvContactos.FocusedColumn.Name == "cAcciones")
            {
                e.Cancel = true;
            }
            if (grvContactos.FocusedRowHandle > 0 && grvContactos.FocusedColumn.Name == "cAcciones")
            {
                e.Cancel = false;
            }
            else if (grvContactos.FocusedRowHandle > 0 && grvContactos.FocusedColumn.Name != "cAcciones")
            {
                e.Cancel = true;
            }*/
        }

        private void cmbAcciones_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Tag)
            {
                case "1":
                    if (MessageBox.Show("¿Estas seguro que quieres eliminar este Contacto?", "ELIMINAR CONTACTO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int contacto_id= Modulo.ConvertInt(grvContactos.GetFocusedRowCellValue(cIdContacto).ToString());
                        if (contacto_id>0)
                        {
                            Modulo.GetDataTable("CALL SP_CLIENTES_CONTACTOS_ELIMINAR(" + contacto_id+"," + Modulo.IdUsuario+")");

                        }
                        grvContactos.DeleteRow(grvContactos.FocusedRowHandle);

                       
                    }
                break;
                case "2":
                    break;
            }
        }

        private void cmbTipo_EditValueChanged_1(object sender, EventArgs e)
        {
        }
        

        private void cmbPuestos_EditValueChanged(object sender, EventArgs e)
        {
            //int newValor = cmbPuestos
        }

        private void txtRazonSocial_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            //txtNombreFiscal.Text = txtRazonSocial.Text;
        }

        private void cmbRegimenFiscal_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbRegimenFiscal.EditValue != null)
            {
                cmbUsoCFDI.Properties.DataSource = Modulo.GetDataTable("CALL SP_USO_CFDI_SELECCIONAR("+cmbRegimenFiscal.EditValue.ToString()+")");
            }
        }

        private void btnAbrirPDF_Click(object sender, EventArgs e)
        {

            DataTable dtDatos = new DataTable();
            dtDatos = Modulo.cBP.Seleccionar("CALL SP_CLIENTES_SELECCIONAR(" + intId + ", null)");
            ruta_pdfSeleccionar = Modulo.BinaryToText((byte[])dtDatos.Rows[0]["situacion_fiscal"]);


            pdfVisualizar fPdf = new pdfVisualizar();

            fPdf.ShowDialog();

        }

        private void peFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Fotografias |.jpeg;.jpg;*.png";
            file.ShowDialog();
            if (file.FileName != string.Empty)
            {
                peFoto.Image = Image.FromFile(file.FileName);
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            OpenFileDialog pdf = new OpenFileDialog();
            pdf.Filter = "Archivos PDF |*.pdf";
            pdf.ShowDialog();
            btnPDF.Text = pdf.SafeFileName;
            ruta_pdf = pdf.FileName;
            nombre_pdf = pdf.SafeFileName;
        }

     
    }
}