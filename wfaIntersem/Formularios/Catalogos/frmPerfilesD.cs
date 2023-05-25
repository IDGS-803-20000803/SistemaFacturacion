using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace wfaIntersem
{
    public partial class frmPerfilesD : DevExpress.XtraEditors.XtraForm
    {
        int intModo;
        int intPermiso;
        bool blnRespuesta;
        int intId;
       

        public frmPerfilesD()
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
                txtPerfil.Focus();
                StatusMenu();
                backwDatos.RunWorkerAsync(1);
            }
            else
            {
                backwDatos.RunWorkerAsync(2);
                Desactiva();
                txtPerfil.Focus();
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
                    intTempPermiso =Modulo.BuscaNumeroBinarioInferiorA(intPermAct);
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
            txtPerfil.Text = "";
        }



        private void Desactiva()
        {
            txtPerfil.Enabled = !txtPerfil.Enabled;
            
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




        private void Combos()
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw;
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
            try
            {
                DataTable dtDatos = new DataTable();
                dtDatos = Modulo.GetDataTable("CALL SP_PERFILES_SELECCIONAR(" + intId + ")");
                if (dtDatos.Rows.Count > 0)
                {
                    txtPerfil.Text = dtDatos.Rows[0]["perfil"].ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void GuardarInformacion()
        {
            try
            {

                BP.PerfilesBP objDatosBp = new BP.PerfilesBP();
                BE.PerfilesBE objDatosBe = new BE.PerfilesBE();

                objDatosBe.perfil = txtPerfil.Text;
                objDatosBe.id_usuario = Modulo.IdUsuario;
                
                if (intModo == 1)
                {
                    objDatosBe.id = 0;
                    intId = objDatosBp.Insertar(objDatosBe);
                    Modulo.Alertar.MuestraAlerta(1, this);
                }
                else
                {
                    objDatosBe.id = intId;
                    objDatosBp.Modificar(objDatosBe);
                    Modulo.Alertar.MuestraAlertaModificar(this);
                }
                intModo = 0;
                Desactiva();
                StatusMenu();
                blnRespuesta = true;
                


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
            txtPerfil.Focus();
        }

        private void mnuEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            intModo = 2;
            StatusMenu();
            Desactiva();
            txtPerfil.Focus();

        }
    }

}