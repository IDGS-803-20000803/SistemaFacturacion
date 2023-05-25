using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;

using InputKey;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace wfaIntersem
{
    public partial class frmFacturacionP : DevExpress.XtraEditors.XtraForm
    {
        #region VariablesGlobales
        int SelectedRow = 0;
        int _mes;
        DataTable dtDetalle = new DataTable();
        #endregion

        #region Eventos
        #region Eventos al abrir pantalla
        private void frmCatalogoP_Load(object sender, EventArgs e)
        {

            DocumentosAños();
            InformacionMeses();
            mnuNuevo.Enabled = false;
            MostrarFacturaciones();

            if (DateTime.Now.Month == 1)
                backwDatos.RunWorkerAsync(1);
            else
                xTabMeses.SelectedTabPageIndex = DateTime.Now.Month - 1;
        }
        #endregion
        #region Eventos de Menu superior
        private void mnuNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFacturacionD frm = new frmFacturacionD();
            bool intResultado = frm.NuevoDetalle();

            if (intResultado)
            {

                InformacionMeses();
                mnuNuevo.Enabled = false;
                barProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                backwDatos.RunWorkerAsync(xTabMeses.SelectedTabPageIndex + 1);
                xTabMeses.Enabled = false;

            }

        }

        private void mnuExportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.ExportarExcel(grvFacturacion);
        }

        private void mnuImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.ImprimirCuadriculaGrid(grdDetalle, "Listado de Facturas", 1);

        }

        private void mnuSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Eventos para recargar informacion de la grid
        private void cmbAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            InformacionMeses();
            barProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            backwDatos.RunWorkerAsync(xTabMeses.SelectedTabPageIndex + 1);
            cmbAño.Enabled = false;
            xTabMeses.Enabled = false;
        }

        private void xTabMeses_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (!backwDatos.IsBusy)
            {
                barProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                backwDatos.RunWorkerAsync(xTabMeses.SelectedTabPageIndex + 1);
                xTabMeses.Enabled = false;
                cmbAño.Enabled = false;
            }
        }

        #endregion
        #region Eventos de la grid
        private void cmdAcciones_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult resultado;
            switch (e.Button.Tag.ToString())
            {
                //Imprimir
                case "3":
                    try
                    {

                        int _id = Modulo.ConvertInt(grvFacturacion.GetRowCellValue(grvFacturacion.FocusedRowHandle, cId).ToString());
                        DataTable dtDatos = Modulo.GetDataTable($"CALL SP_FACTURACION_IMPRIMIR({_id})");
                        XtraReport plantilla_facturacion = new plantilla_facturacion
                        {
                            DataSource = dtDatos,
                            ShowPrintMarginsWarning = false
                        };
                        plantilla_facturacion.ShowPreview();
                    }
                    catch (Exception ex)
                    {
                        Modulo.ShowCatch(ex);
                    }
                    break;
                //Eliminar
                case "2":
                    XtraInputBoxArgs args = CrearXtraInputDialogCancelar();
                    int tipoCancelacionSat = Convert.ToInt32(XtraInputBox.Show(args));

                    if (tipoCancelacionSat == 0) return;

                    int idCancelacion = Convert.ToInt32(grvFacturacion.GetFocusedRowCellValue(cId));
                        //observacionCancelacion = Modulo.ConvertInt(InputDialog.mostrar("Observaciones de cancelación"));

                    Modulo.GetDataTable($"CALL SP_FACTURAS_CANCELAR({idCancelacion}, {tipoCancelacionSat})");
                    MostrarFacturaciones();
                    break;
                //Editar
                case "4":
                    if (grvFacturacion.DataRowCount <= 0) return;

                    frmFacturacionD fDetalle = new frmFacturacionD();

                    if (fDetalle.ConsultarDetalle(int.Parse(grvFacturacion.GetRowCellValue(grvFacturacion.FocusedRowHandle, cId).ToString())))
                        backwDatos.RunWorkerAsync(xTabMeses.SelectedTabPageIndex + 1);

                    break;
                case "5":
                    resultado = XtraMessageBox.Show(new XtraMessageBoxArgs()
                    {
                        Caption = "Confirmar",
                        Text = "¿Eliminar esta factura de forma definitiva?\n" +
                        "Esta acción es irreversible.",
                        Buttons = new DialogResult[] { DialogResult.Yes, DialogResult.No },
                        Icon = SystemIcons.Warning,
                        MessageBeepSound = MessageBeepSound.Warning
                    });
                    if (resultado != DialogResult.Yes) return;

                    int idborrar = int.Parse(grvFacturacion.GetRowCellValue(grvFacturacion.FocusedRowHandle, cId).ToString());
                    Modulo.cBP.Seleccionar($"CALL SP_FACTURAS_ELIMINAR({idborrar})");
                    MostrarFacturaciones();
                    break;
            }
        }

        private void grdDetalle_DoubleClick(object sender, EventArgs e)
        {
            if (grvFacturacion.DataRowCount > 0)
            {
                frmFacturacionD fDetalle = new frmFacturacionD();


                if (fDetalle.ConsultarDetalle(int.Parse(grvFacturacion.GetRowCellValue(grvFacturacion.FocusedRowHandle, cId).ToString())))
                    backwDatos.RunWorkerAsync(xTabMeses.SelectedTabPageIndex + 1);
            }
        }
        #endregion
        #region Eventos de Hilos
        private void backwDatos_DoWork(object sender, DoWorkEventArgs e)
        {
            CargarInformacion(int.Parse(e.Argument.ToString()));
        }

        private void backwDatos_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch (e.ProgressPercentage)
            {
                case 101:

                    CargarGrid(e.UserState as DataTable);
                    break;
            }
        }

        private void backwDatos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            mnuNuevo.Enabled = true;
            barProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            grdDetalle.Enabled = true;
            xTabMeses.Enabled = true;
            cmbAño.Enabled = true;
        }
        #endregion
        #endregion


        #region Funciones Privadas
        #region Funciones Previas para cargar informacion en grid
        private void DocumentosAños()
        {
            try
            {
                DataTable dtDatos = new DataTable();
                dtDatos = Modulo.GetDataTable("CALL SP_FACTURAS_ANIOS_SELECCIONAR()");
                if (dtDatos.Rows.Count > 0)
                {
                    if (dtDatos.Rows[0][0] != DBNull.Value)
                    {
                        for (int intCuenta = int.Parse(dtDatos.Rows[0]["minimo"].ToString()); intCuenta <= int.Parse(dtDatos.Rows[0]["maximo"].ToString()); intCuenta++)
                        {
                            cmbAño.Properties.Items.Add(intCuenta);
                        }
                    }
                }
                cmbAño.Text = DateTime.Now.Year.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void InformacionMeses()
        {
            try
            {
                DataTable dtDatos = new DataTable();
                dtDatos = Modulo.GetDataTable("CALL SP_FACTURAS_MESES_SELECCIONAR(" + cmbAño.Text + ")");
                for (int i = 0; i < xTabMeses.TabPages.Count; i++)
                {
                    xTabMeses.TabPages[i].Appearance.Header.Font = new Font(xTabMeses.TabPages[i].Appearance.Header.Font, FontStyle.Regular);
                }
                for (int i = 0; i < dtDatos.Rows.Count; i++)
                {
                    xTabMeses.TabPages[int.Parse(dtDatos.Rows[i]["mes"].ToString()) - 1].Appearance.Header.Font = new Font(xTabMeses.TabPages[int.Parse(dtDatos.Rows[i]["mes"].ToString()) - 1].Appearance.Header.Font, FontStyle.Bold);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Funciones para cargar informacion en grid
        private void CargarInformacion(int intMes)
        {
            try
            {
                _mes = intMes;
                DataTable dtDatos = new DataTable();
                dtDetalle = new DataTable();
                dtDatos = Modulo.cBP.Seleccionar("CALL SP_FACTURAS_P_SELECCIONAR(" + intMes + "," + int.Parse(cmbAño.Text) + ", " + Modulo.ConvertInt(xTabEstatus.SelectedTabPage.Tag.ToString()) + ")");
                //  dtDetalle = Modulo.cBP.Seleccionar("CALL SP_COTIZACIONES_D_SELECCIONAR(" + intMes + "," + int.Parse(cmbAño.Text) + ", " + Modulo.ConvertInt(xTabEstatus.SelectedTabPage.Tag.ToString()) + ", null, null)");



                /*DataSet dtsVentas = new DataSet();
                dtsVentas.Tables.Add(dtDatos);
                dtsVentas.Tables.Add(dtDetalle);

                dtsVentas.Relations.Add("detalle", dtsVentas.Tables[0].Columns["id"], dtsVentas.Tables[1].Columns["id_cotizacion"]);
                backwDatos.ReportProgress(101,dtDatos);*/

                backwDatos.ReportProgress(101, dtDatos);
            }
            catch (Exception Ex)
            {
                Modulo.ShowCatch(Ex);
            }
        }

        private void CargarGrid(DataTable dtsDatos)
        {
            grdDetalle.DataSource = dtsDatos;
            grvFacturacion.BestFitColumns();
            grvFacturacion.FocusedRowHandle = SelectedRow;

        }

        private void MostrarFacturaciones()
        {
            int anio = Convert.ToInt32(cmbAño.EditValue),
                estatusTab = Convert.ToInt32(xTabEstatus.SelectedTabPage.Tag);


            grdDetalle.DataSource = null;
            DataTable dtDatos = Modulo.GetDataTable($"CALL SP_FACTURAS_P_SELECCIONAR({_mes}, {anio}, {estatusTab})");
            //DataTable dtDatos = Modulo.GetDataTable($"CALL SP_FACTURAS_P_SELECCIONAR({_mes}," + int.Parse(cmbAño.Text) + "," + Modulo.ConvertInt(xTabEstatus.SelectedTabPage.Tag.ToString())+")");

            grdDetalle.DataSource = dtDatos;

            grvFacturacion.BestFitColumns();
            grvFacturacion.FocusedRowHandle = SelectedRow;
            //cabiar los botones de acuerdo con el estatus de la pagina.
            //int estatus = Modulo.ConvertInt(xTabEstatus.SelectedTabPage.Tag.ToString());
            int estatus = Convert.ToInt32(xTabEstatus.SelectedTabPage.Tag);
            switch (estatus)
            {
                case 0:
                    cmdAcciones.Buttons[2].Visible = false;
                    cmdAcciones.Buttons[0].Visible = true;
                    cmdAcciones.Buttons[1].Visible = true;
                    cmdAcciones.Buttons[3].Visible = false;
                    break;
                case 2:
                    cmdAcciones.Buttons[0].Visible = false;
                    cmdAcciones.Buttons[1].Visible = false;
                    cmdAcciones.Buttons[2].Visible = true;
                    cmdAcciones.Buttons[3].Visible = false;
                    break;
                case 1:
                    cmdAcciones.Buttons[0].Visible = false;
                    cmdAcciones.Buttons[1].Visible = false;
                    cmdAcciones.Buttons[2].Visible = false;
                    cmdAcciones.Buttons[3].Visible = true;
                    break;
            }
        }
        #endregion
        #endregion

        #region Funciones Publicas
        #region Constructores
        public frmFacturacionP()
        {
            InitializeComponent();
        }
        #endregion

        #endregion

        private void xTabEstatus_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            MostrarFacturaciones();
        }

        private XtraInputBoxArgs CrearXtraInputDialogCancelar()
        {
            DataTable dtTipoCancelacionSat = Modulo.GetDataTable("CALL SP_FACTURAS_TIPO_CANCELACION_SAT_SELECCIONAR(NULL)");

            LookUpEdit lookUpEditTipoCancelacionSat = new LookUpEdit();
            lookUpEditTipoCancelacionSat.Properties.DisplayMember = "tipo_cancelacion";
            lookUpEditTipoCancelacionSat.Properties.ValueMember = "id";
            lookUpEditTipoCancelacionSat.Properties.NullText = "— SELECCIONAR —";
            lookUpEditTipoCancelacionSat.Properties.DataSource = dtTipoCancelacionSat;

            LookUpColumnInfo columnInfoTipoCancelacionSat = new LookUpColumnInfo()
            {
                FieldName = "tipo_cancelacion",
                Caption = "Tipo de cancelación",
            };

            lookUpEditTipoCancelacionSat.Properties.Columns.Add(columnInfoTipoCancelacionSat);

            return new XtraInputBoxArgs
            {
                Caption = "Cancelar factura",
                Prompt = "Motivo cancelación:",
                Editor = lookUpEditTipoCancelacionSat,
                DefaultResponse = null,
            };
        }
    }
}