using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace wfaIntersem
{
    public partial class frmFirmasD : DevExpress.XtraEditors.XtraForm
    {
        int intModo;
        int intPermiso;
        bool blnRespuesta;
        int intId;
       

        public frmFirmasD()
        {
            InitializeComponent();
        }
       
        private void frmCatalogoDetalle_Load(object sender, EventArgs e)
        {
            if (intModo == 0)
            {
                backwDatos.RunWorkerAsync(2);
                Permiso();
            }
            else if (intModo == 1)
            {
                Desactiva();
                txtResponsable.Focus();
                StatusMenu();
                backwDatos.RunWorkerAsync(1);
            }
            else
            {
                backwDatos.RunWorkerAsync(2);
                Permiso();
                
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
            txtResponsable.Text = "";
            txtCorreo.Text = "";
            txtPuesto.Text = "";
            //chkDefault.Checked = false;
        }

        private void Desactiva()
        {
            imgFirma.Enabled = !imgFirma.Enabled;

            txtResponsable.Enabled = !txtResponsable.Enabled;
            txtCorreo.Enabled = !txtCorreo.Enabled;
            txtPuesto.Enabled = !txtPuesto.Enabled;
            //layoutControlItem1.Enabled = !layoutControlItem1.Enabled;
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
                DataTable dtResponsable = Modulo.cBP.Seleccionar("CALL SP_FIRMAS_SELECCIONAR(" + intId + ")");
                txtResponsable.Text = dtResponsable.Rows[0]["responsable"].ToString();
                txtCorreo.Text = dtResponsable.Rows[0]["correo"].ToString();
                txtPuesto.Text = dtResponsable.Rows[0]["puesto"].ToString();
              //  chkDefault.Checked = (Modulo.ConvertInt(dtEmpleado.Rows[0]["default"].ToString()) == 0) ? false : true;
                if (dtResponsable.Rows[0]["foto"] != DBNull.Value)
                {
                    Image imagen = Modulo.ByteToImage(dtResponsable.Rows[0]["foto"] as byte[]);
                    imgFirma.Image = imagen;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        #endregion

        private void mnuEditar1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            intModo = 2;
            StatusMenu();
            Desactiva();
            txtResponsable.Focus();
        }

        private void mnuNuevo1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Limpia();
            intModo = 1;
            StatusMenu();
            Desactiva();
            txtResponsable.Focus();

        }

        private void frmCatalogoDetalle_Activated(object sender, EventArgs e)
        {
            //Combos();
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

        private void GuardarInformacion()
        {
            try
            {
                if (dxValidacion.Validate() == true)
                {
                    BE.FirmasBE objDatosBE = new BE.FirmasBE();
                    BP.FirmasBP ObjDatosBP = new BP.FirmasBP();
                    objDatosBE.Descripcion = txtResponsable.Text.ToString();
                    objDatosBE.Correo = txtCorreo.Text.ToString();
                    objDatosBE.Puesto = txtPuesto.Text.ToString();
                    objDatosBE.IdUsuario = Modulo.IdUsuario;
                    objDatosBE.foto = (imgFirma.Image == null ) ? null : Modulo.ImageToByte(imgFirma.Image);
                    switch (intModo)
                    {
                        case 1:
                            ObjDatosBP.Insertar(objDatosBE);     
                            Modulo.Alertar.MuestraAlerta(1, this);
                            break;
                        case 2:
                            if (intId == 0)
                            {
                                DataTable dtConsulta = Modulo.cBP.Seleccionar("CALL SP_FIRMAS_LAST()");
                                intId = Convert.ToInt32(dtConsulta.Rows[0]["id"].ToString());
                                objDatosBE.Id = intId;
                                ObjDatosBP.Modificar(objDatosBE);
                                Modulo.Alertar.MuestraAlertaModificar(this);
                            }
                            else { 
                            objDatosBE.Id = intId;
                            ObjDatosBP.Modificar(objDatosBE);
                            Modulo.Alertar.MuestraAlertaModificar(this);
                            }
                            break;
                    }
                    intModo = 0;
                    Desactiva();
                    StatusMenu();
                    blnRespuesta = true;
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void Informacion()
        {
            MuestraDatos();
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
            txtResponsable.Focus();
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
            txtResponsable.Focus();

        }

        private void mnuEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            intModo = 2;
            StatusMenu();
            Desactiva();
            txtResponsable.Focus();
        }

        private void pictureEdit1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Fotografias |*.jpeg;*.jpg;*.png";
            file.ShowDialog();
            if (file.FileName != string.Empty)
            {
                imgFirma.Image = Image.FromFile(file.FileName);
            }
        }


      

     

    }

}