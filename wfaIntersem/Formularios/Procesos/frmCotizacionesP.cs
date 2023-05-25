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
using DevExpress.XtraReports.Design;
using InputKey;
using DevExpress.XtraReports.UI;

namespace wfaIntersem
{
    public partial class frmCotizacionesP : DevExpress.XtraEditors.XtraForm
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
            if (DateTime.Now.Month == 1)
                backwDatos.RunWorkerAsync(1);
            else
                xTabMeses.SelectedTabPageIndex = DateTime.Now.Month - 1;

            this.grvCotizaciones.Columns["cAcciones"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
        }
        #endregion
        #region Eventos de Menu superior
        private void mnuNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCotizacionesD frm = new frmCotizacionesD();
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
            Modulo.ExportarExcel(grvCotizaciones);
        }

        private void mnuImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.ImprimirCuadriculaGrid(grdDetalle, "Listado de cotizaciones", 1);
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
        private void xTabEstatus_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            MostrarCotizaciones();
            switch (xTabEstatus.SelectedTabPageIndex)
            {
                case 0:


                    cmdAcciones.Buttons[0].Visible = true; //Editar
                    cmdAcciones.Buttons[1].Visible = true; //Cancelar
                    cmdAcciones.Buttons[2].Visible = true; //Imprimir Cotización
                    cmdAcciones.Buttons[3].Visible = false; //Activar Cotizaciones
                    cAprobar.Visible = true;
                    break;
                //PESTAÑA AUTORIZADAS
                case 1:


                    cmdAcciones.Buttons[0].Visible = false; //Editar
                    cmdAcciones.Buttons[1].Visible = true; //Cancelar
                    cmdAcciones.Buttons[2].Visible = true; //Imprimir Cotización
                    cmdAcciones.Buttons[3].Visible = false; //Activar Cotizaciones


                    cAprobar.Visible = false;

                    break;
                //PESTAÑA CANCELADAS
                case 2:

                    cmdAcciones.Buttons[0].Visible = false; //Editar
                    cmdAcciones.Buttons[1].Visible = true;  //Imprimir Cotización
                    cmdAcciones.Buttons[2].Visible = false; //Cancelar
                    cmdAcciones.Buttons[3].Visible = true; //Activar Cotizaciones
                    break;
            }
            grvCotizaciones.BestFitColumns();
        }
        #endregion
        #region Eventos de la grid
        private void cmdAcciones_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult resultado;

            switch (e.Button.Tag.ToString())
            {
                //Editar
                case "1":
                    try
                    {

                        frmCotizacionesD frm = new frmCotizacionesD();
                        if (frm.EditarDetalle(Modulo.ConvertInt(grvCotizaciones.GetRowCellValue(grvCotizaciones.FocusedRowHandle, cId).ToString()), Modulo.ConvertInt(grvCotizaciones.GetRowCellValue(grvCotizaciones.FocusedRowHandle, cId).ToString())))
                        {
                            Modulo.Alertar.MuestraAlerta(1, this);

                            InformacionMeses();
                            barProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                            backwDatos.RunWorkerAsync(xTabMeses.SelectedTabPageIndex + 1);
                        }
                    }
                    catch (Exception ex)
                    {
                        Modulo.ShowCatch(ex);
                    }
                    break;
                //Eliminar
                case "2":
                    XtraInputBoxArgs args = ConstruirXtraInputObservacionesCancelacion();
                    string observacionesCancelacion = XtraInputBox.Show(args).ToString();

                    if (string.IsNullOrWhiteSpace(observacionesCancelacion)) return;

                    int idCancelacion = int.Parse(grvCotizaciones.GetFocusedRowCellValue(cId).ToString());
                    
                    Modulo.GetDataTable($"CALL SP_COTIZACIONES_CANCELAR({idCancelacion},'{observacionesCancelacion}')");
                    MostrarCotizaciones();
                    break;
                //Imprimir
                case "3":

                    int _id = Modulo.ConvertInt(grvCotizaciones.GetFocusedRowCellValue(cId).ToString());
                    DataTable dtDatos = Modulo.GetDataTable($"CALL SP_COTIZACIONES_SELECCIONAR({_id})");
                    XtraReport plantilla_cotizacion = new plantilla_cotizacion
                    {
                        DataSource = dtDatos,
                        ShowPrintMarginsWarning = false
                    };
                    plantilla_cotizacion.ShowPreview();
                    break;
                //Activar Cotización 
                case "4":
                    resultado = XtraMessageBox.Show(new XtraMessageBoxArgs()
                    {
                        Caption = "Confirmar",
                        Text = "¿Activar esta cotizacion?",
                        Icon = SystemIcons.Question,
                        Buttons = new DialogResult[] { DialogResult.Yes, DialogResult.No },
                        MessageBeepSound = MessageBeepSound.Information,
                    });
                    //confirmacion = MessageBox.Show("¿Desea activar la cotización?", "¡Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning).ToString();

                    if (resultado != DialogResult.Yes) return;

                    int idCotizacion = int.Parse(grvCotizaciones.GetRowCellValue(grvCotizaciones.FocusedRowHandle, cId).ToString());

                    Modulo.cBP.Seleccionar($"CALL SP_COTIZACION_ACTIVAR({idCotizacion})");
                    MostrarCotizaciones();
                    break;


                case "5":
                    resultado = XtraMessageBox.Show(new XtraMessageBoxArgs()
                    {
                        Caption = "Aviso",
                        Text = "¿Generar los servicios de esta cotización?",
                        Icon = SystemIcons.Question,
                        Buttons = new DialogResult[] { DialogResult.Yes, DialogResult.No },
                        MessageBeepSound = MessageBeepSound.Information,
                    });

                    if (resultado != DialogResult.Yes) return;

                    //if (MessageBox.Show("¿Desea generar los servicios de esta cotización?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)



                    splashScreenManager1.ShowWaitForm();
                    splashScreenManager1.SetWaitFormCaption("Generando Servicios");
                    splashScreenManager1.SetWaitFormDescription("Cargando.....");
                    BP.ServiciosBP objBP = new BP.ServiciosBP();
                    int intId = Modulo.ConvertInt(grvCotizaciones.GetFocusedRowCellValue(cId).ToString());


                    if (objBP.Insertar(intId, Modulo.IdUsuario) > 0)
                    {
                        //splashScreenManager1.CloseWaitForm();
                        Modulo.Alertar.MuestraAlerta(1, this);
                        InformacionMeses();
                        barProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        backwDatos.RunWorkerAsync(xTabMeses.SelectedTabPageIndex + 1);
                    }
                    //else
                    //{
                    //    splashScreenManager1.CloseWaitForm();
                    //}

                    splashScreenManager1.CloseWaitForm();

                    break;
                //case "6":
                //    int cotizacion_id = Modulo.ConvertInt(grvCotizaciones.GetFocusedRowCellValue(cId).ToString());
                //    break;
                case "7":
                    frmCotizacionesD frmCotizacionesD = new frmCotizacionesD();
                    if (frmCotizacionesD.ModificarPrecios(Modulo.ConvertInt(grvCotizaciones.GetRowCellValue(grvCotizaciones.FocusedRowHandle, cId).ToString()), Modulo.ConvertInt(grvCotizaciones.GetRowCellValue(grvCotizaciones.FocusedRowHandle, cId).ToString())))
                    {
                        Modulo.Alertar.MuestraAlerta(1, this);

                        InformacionMeses();
                        barProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        backwDatos.RunWorkerAsync(xTabMeses.SelectedTabPageIndex + 1);
                    }
                    break;
            }
        }

        private void grdDetalle_DoubleClick(object sender, EventArgs e)
        {
            /*
            if (xtraTabControl1.SelectedTabPageIndex == 0)
            {

                frmCotizacionesD fDetalle = new frmCotizacionesD();
                SelectedRow = grvDetalle.FocusedRowHandle;
                DataTable dtUso = Modulo.cBP.Seleccionar("CALL SP_CONSULTAR_SI_COTIZACION_ESTA_USANDOSE(" + int.Parse(grvDetalle.GetRowCellValue(SelectedRow, cIdDetalle).ToString()) + ","+Modulo.IdUsuario+")");
                if (dtUso.Rows[0][0].ToString() == "0")
                {
                    if (fDetalle.ConsultarDetalle(int.Parse(grvDetalle.GetRowCellValue(SelectedRow, cIdDetalle).ToString()), 7, int.Parse(grvDetalle.GetRowCellValue(SelectedRow, cStatus).ToString()), this))
                    {
                        grdDetalle.Enabled = false;
                        InformacionMeses();
                        barProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                        mnuNuevo.Enabled = false;
                        xTabMeses.Enabled = false;
                        backwDatos.RunWorkerAsync(xTabMeses.SelectedTabPageIndex + 1);
                    }
                }
                else
                {
                    MessageBox.Show("La venta esta siendo utilizada por otra persona, espera a que termine", "Venta en uso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            */
        }
        #endregion
        #region Eventos de Hilos
        private void backwDatos_DoWork(object sender, DoWorkEventArgs e)
        {
            //backwDatos.ReportProgress(int.Parse(e.Argument.ToString()));
            CargarInformacion(int.Parse(e.Argument.ToString()));
        }

        private void backwDatos_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //CargarInformacion(e.ProgressPercentage);
            switch (e.ProgressPercentage)
            {
                case 101:
                    CargarGrid(e.UserState as DataSet);
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
                dtDatos = Modulo.GetDataTable("CALL SP_COTIZACIONES_ANOS_SELECCIONAR()");
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
                dtDatos = Modulo.GetDataTable("CALL SP_COTIZACIONES_MESES_SELECCIONAR(" + cmbAño.Text + ")");
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
                dtDatos = Modulo.GetDataTable($"CALL SP_COTIZACIONES_P_SELECCIONAR({intMes}, {cmbAño.Text}, {xTabEstatus.SelectedTabPage.Tag}, null,null)");
                dtDetalle = Modulo.GetDataTable($"CALL SP_COTIZACIONES_D_SELECCIONAR({intMes}, {cmbAño.Text}, {xTabEstatus.SelectedTabPage.Tag}, null, null)");

                DataSet dtsVentas = new DataSet();
                dtsVentas.Tables.Add(dtDatos);
                dtsVentas.Tables.Add(dtDetalle);
                
                dtsVentas.Relations.Add("detalle", dtsVentas.Tables[0].Columns["id"], dtsVentas.Tables[1].Columns["id_cotizacion"]);
                backwDatos.ReportProgress(101, dtsVentas);
            }
            catch (Exception Ex)
            {
                Modulo.ShowCatch(Ex);
            }
        }

        private void CargarGrid(DataSet dtsVentas)
        {
            grdDetalle.DataSource = dtsVentas.Tables[0].DefaultView;
            grvCotizaciones.BestFitColumns();

            grvCotizaciones.FocusedRowHandle = SelectedRow;
        }

        private void MostrarCotizaciones()
        {
            grdDetalle.DataSource = null;
            DataTable dtDatos = new DataTable();

            dtDatos = Modulo.cBP.Seleccionar("CALL SP_COTIZACIONES_P_SELECCIONAR(" + _mes + "," + int.Parse(cmbAño.Text) + "," + Modulo.ConvertInt(xTabEstatus.SelectedTabPage.Tag.ToString()) + ", null,null)");
            DataTable dtDetalle = new DataTable();
            dtDetalle = Modulo.cBP.Seleccionar("CALL SP_COTIZACIONES_D_SELECCIONAR(" + _mes + "," + int.Parse(cmbAño.Text) + "," + Modulo.ConvertInt(xTabEstatus.SelectedTabPage.Tag.ToString()) + ", null, null)");

            DataSet dtsVentas = new DataSet();
            dtsVentas.Tables.Add(dtDatos);
            dtsVentas.Tables.Add(dtDetalle);
            dtsVentas.Relations.Add("detalle", dtsVentas.Tables[0].Columns["id"], dtsVentas.Tables[1].Columns["id_cotizacion"]);

            grdDetalle.DataSource = dtsVentas.Tables[0].DefaultView;

            grvCotizaciones.BestFitColumns();
            grvCotizaciones.FocusedRowHandle = SelectedRow;
        }
        #endregion
        #endregion

        #region Funciones Publicas
        #region Constructores
        public frmCotizacionesP()
        {
            InitializeComponent();
        }
        #endregion

        #endregion

        private void chkFacturar_CheckedChanged(object sender, EventArgs e)
        {
            int valor = int.Parse(chkFacturar.ValueChecked.ToString());
            int id = Modulo.ConvertInt(grvCotizaciones.GetRowCellValue(grvCotizaciones.FocusedRowHandle, cId).ToString());
            Modulo.cBP.Seleccionar("CALL SP_FACTURAR_CONFIGURAR(" + valor + "," + id + ")");
            Modulo.Alertar.MuestraAlerta(1, this);
        }

        private void mnuUnir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("¿Desea unir las cotizaciones seleccionadas?", "Unión de cotizaciones", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int[] posicionesGrid = grvCotizaciones.GetSelectedRows();
                int[] cotizacionesSeleccionadas = new int[grvCotizaciones.SelectedRowsCount];
                DataTable dtValidacion = new DataTable();
                dtValidacion.Columns.Add("formato", typeof(int));
                dtValidacion.Columns.Add("cliente", typeof(int));
                dtValidacion.Columns.Add("estatus", typeof(int));

                for (int i = 0; i < posicionesGrid.Length; i++)
                {
                    cotizacionesSeleccionadas[i] = Modulo.ConvertInt(grvCotizaciones.GetRowCellValue(int.Parse(posicionesGrid[i].ToString()), cId).ToString());
                    DataRow _row = dtValidacion.NewRow();
                    _row["cliente"] = Modulo.ConvertInt(grvCotizaciones.GetRowCellValue(int.Parse(posicionesGrid[i].ToString()), cIdCliente).ToString());
                    _row["estatus"] = Modulo.ConvertInt(grvCotizaciones.GetRowCellValue(int.Parse(posicionesGrid[i].ToString()), cEstatus).ToString());
                    dtValidacion.Rows.Add(_row);
                }


                int formato = int.Parse(dtValidacion.Rows[0]["formato"].ToString());
                int cliente = int.Parse(dtValidacion.Rows[0]["cliente"].ToString());
                int estatus = int.Parse(dtValidacion.Rows[0]["estatus"].ToString());

                DataRow[] formatosFound = dtValidacion.Select("formato = " + formato.ToString());
                DataRow[] clientesFound = dtValidacion.Select("cliente = " + cliente.ToString());
                DataRow[] estatusFound = dtValidacion.Select("estatus = " + estatus.ToString());

                if (formatosFound.Length == dtValidacion.Rows.Count && clientesFound.Length == dtValidacion.Rows.Count && estatusFound.Length == dtValidacion.Rows.Count)
                {
                    frmCotizacionesD frm = new frmCotizacionesD();
                    bool respuesta = frm.UnirCotizaciones(cotizacionesSeleccionadas);
                    if (respuesta)
                    {
                        MostrarCotizaciones();
                        Modulo.Alertar.MuestraAlerta(1, this);
                    }
                }
                else
                {
                    MessageBox.Show("PARA PODER UNIR COTIZACIONES ES NECESARIO QUE TENGAN EL MISMO CLIENTE, FORMATO DE IMPRECION Y TENGAN EL MISMO ESTATUS", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            else
            {
                for (int i = 0; i < grvCotizaciones.RowCount; i++)
                {
                    grvCotizaciones.UnselectRow(i);
                }
            }
        }

        private void grvCotizaciones_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "observaciones_seguimiento")
            {
                int cotizacion = Modulo.ConvertInt(grvCotizaciones.GetRowCellValue(e.RowHandle, cId).ToString());
                string cadena = grvCotizaciones.GetRowCellValue(grvCotizaciones.FocusedRowHandle, cObservacionesSeguimiento).ToString();

                Modulo.cBP.Seleccionar("CALL SP_COTIZACIONES_OBSERVACIONES_SEGUIMIENTO_MODIFICAR('" + cadena + "'," + cotizacion + "," + Modulo.IdUsuario + ")");
                Modulo.Alertar.MuestraAlerta(1, this);
            }
        }

        private void chkAprobar_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit edit = sender as CheckEdit;
            if (edit.Checked)
            {
                int idCotizacion = int.Parse(grvCotizaciones.GetRowCellValue(grvCotizaciones.FocusedRowHandle, cId).ToString());

                if (idCotizacion > 0)
                {
                    if (MessageBox.Show("¿Estas seguro de aprobar la cotización ? ", "Validación de cotizacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Modulo.cBP.Seleccionar("CALL SP_COTIZACIONES_APROBAR(" + idCotizacion + "," + Modulo.IdUsuario + ")");
                        MostrarCotizaciones();
                        Modulo.Alertar.MuestraAlerta(1, this);
                    }
                }

            }
        }

        private void grvCotizaciones_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            /*Evaluamos si es de categoria diferente a preventivo
            if (grvCotizaciones.FocusedRowHandle > -1)
            {
                int categoria = Modulo.ConvertInt(grvCotizaciones.GetFocusedRowCellValue(cCategoriaId).ToString());
                if (categoria != 1)
                {
                    cmdAcciones.Buttons[6].Visible = true;
                }
                else
                {
                    cmdAcciones.Buttons[6].Visible = false;
                }
            }*/
        }

        private void grvCotizaciones_DoubleClick_1(object sender, EventArgs e)
        {
            frmCotizacionesD fDetalle = new frmCotizacionesD();
            if (fDetalle.ConsultarDetalle(Convert.ToInt32((grvCotizaciones.GetFocusedRowCellValue(cId)), Modulo.culture), 7))
                backwDatos.RunWorkerAsync(xTabMeses.SelectedTabPageIndex + 1);

        }

        private XtraInputBoxArgs ConstruirXtraInputObservacionesCancelacion()
        {
            MemoEdit memoEditObservacionesCancelacion = new MemoEdit();
            memoEditObservacionesCancelacion.Properties.MaxLength = 255;
            memoEditObservacionesCancelacion.Properties.NullText = "(obligatorio)";

            return new XtraInputBoxArgs()
            {
                Caption = "Cancelar cotización",
                Prompt = "Observaciones",
                Editor = memoEditObservacionesCancelacion,
            };
        }
    }


}