using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;

namespace wfaIntersem
{
    partial class frmCotizacionesD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCotizacionesD));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnAgregarEquipos = new DevExpress.XtraEditors.SimpleButton();
            this.btnPoliticas = new DevExpress.XtraEditors.SimpleButton();
            this.txtDescripcion = new DevExpress.XtraEditors.MemoEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.mnuNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.mnuGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.mnuEditar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEnviarCorreo = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSalir = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.prgProgreso = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemMarqueeProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.mnuGenerarServicio = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnArchivosAuxiliares = new DevExpress.XtraBars.BarButtonItem();
            this.txtPorcentaje = new DevExpress.XtraEditors.TextEdit();
            this.txtPrecio = new DevExpress.XtraEditors.TextEdit();
            this.txtCantidad = new DevExpress.XtraEditors.TextEdit();
            this.cmbContacto = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id_contacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nombreContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.apellido_PContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.apellido_mContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nombre_completo_contacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cCorreoC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.cmbCliente = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id_cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cCiudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.txtDomicilio = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalNeto = new DevExpress.XtraEditors.TextEdit();
            this.txtIva = new DevExpress.XtraEditors.TextEdit();
            this.txtSubtotal = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtObservaciones = new DevExpress.XtraEditors.MemoEdit();
            this.grdDetalle = new DevExpress.XtraGrid.GridControl();
            this.grvDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cImporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cAcciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdAcciones = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cTiempo_Entrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cPartidas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtAcuerdos = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.dtFecha = new DevExpress.XtraEditors.DateEdit();
            this.dtVigencia = new DevExpress.XtraEditors.DateEdit();
            this.cmbResponsable = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdResponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cNombreResponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cPuestoResponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtVersion = new DevExpress.XtraEditors.TextEdit();
            this.txtTiempoEntrega = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem13 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lytResponsable = new DevExpress.XtraLayout.LayoutControlItem();
            this.lytCliente = new DevExpress.XtraLayout.LayoutControlItem();
            this.lytContacto = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lytDomicilio = new DevExpress.XtraLayout.LayoutControlItem();
            this.lytFecha = new DevExpress.XtraLayout.LayoutControlItem();
            this.lytVigencia = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lytCorreo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lytTelefono = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem12 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lytVersion = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem11 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lytCantidad = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lytPrecio = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem10 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lytDescuento = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem28 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutCotrolGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidacion = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblTitulo = new DevExpress.XtraEditors.LabelControl();
            this.backwDatos = new System.ComponentModel.BackgroundWorker();
            this.cIdMarcaC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cMarcaC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.emptySpaceItem18 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem19 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem20 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem21 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem22 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentaje.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbContacto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDomicilio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalNeto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIva.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAcciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAcuerdos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVigencia.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVigencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbResponsable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVersion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTiempoEntrega.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytResponsable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytDomicilio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytVigencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutCotrolGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem22)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnAgregarEquipos);
            this.layoutControl1.Controls.Add(this.btnPoliticas);
            this.layoutControl1.Controls.Add(this.txtDescripcion);
            this.layoutControl1.Controls.Add(this.txtPorcentaje);
            this.layoutControl1.Controls.Add(this.txtPrecio);
            this.layoutControl1.Controls.Add(this.txtCantidad);
            this.layoutControl1.Controls.Add(this.cmbContacto);
            this.layoutControl1.Controls.Add(this.txtTelefono);
            this.layoutControl1.Controls.Add(this.cmbCliente);
            this.layoutControl1.Controls.Add(this.splitterControl1);
            this.layoutControl1.Controls.Add(this.txtDomicilio);
            this.layoutControl1.Controls.Add(this.txtTotalNeto);
            this.layoutControl1.Controls.Add(this.txtIva);
            this.layoutControl1.Controls.Add(this.txtSubtotal);
            this.layoutControl1.Controls.Add(this.txtEmail);
            this.layoutControl1.Controls.Add(this.txtObservaciones);
            this.layoutControl1.Controls.Add(this.grdDetalle);
            this.layoutControl1.Controls.Add(this.dtFecha);
            this.layoutControl1.Controls.Add(this.dtVigencia);
            this.layoutControl1.Controls.Add(this.cmbResponsable);
            this.layoutControl1.Controls.Add(this.txtVersion);
            this.layoutControl1.Controls.Add(this.txtTiempoEntrega);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 62);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(312, 336, 450, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1107, 532);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnAgregarEquipos
            // 
            this.btnAgregarEquipos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarEquipos.ImageOptions.Image")));
            this.btnAgregarEquipos.Location = new System.Drawing.Point(718, 181);
            this.btnAgregarEquipos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarEquipos.Name = "btnAgregarEquipos";
            this.btnAgregarEquipos.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAgregarEquipos.Size = new System.Drawing.Size(370, 36);
            this.btnAgregarEquipos.StyleController = this.layoutControl1;
            this.btnAgregarEquipos.TabIndex = 82;
            this.btnAgregarEquipos.Text = "Agregar";
            this.btnAgregarEquipos.Click += new System.EventHandler(this.btnAgregarEquipos_Click);
            // 
            // btnPoliticas
            // 
            this.btnPoliticas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPoliticas.ImageOptions.Image")));
            this.btnPoliticas.Location = new System.Drawing.Point(604, 448);
            this.btnPoliticas.Margin = new System.Windows.Forms.Padding(2);
            this.btnPoliticas.Name = "btnPoliticas";
            this.btnPoliticas.Size = new System.Drawing.Size(184, 36);
            this.btnPoliticas.StyleController = this.layoutControl1;
            this.btnPoliticas.TabIndex = 81;
            this.btnPoliticas.Text = "Politicas";
            this.btnPoliticas.Click += new System.EventHandler(this.btnPoliticas_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.EditValue = "";
            this.txtDescripcion.Location = new System.Drawing.Point(120, 181);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.MenuManager = this.barManager1;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(594, 36);
            this.txtDescripcion.StyleController = this.layoutControl1;
            this.txtDescripcion.TabIndex = 76;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mnuSalir,
            this.prgProgreso,
            this.mnuGenerarServicio,
            this.mnuGuardar,
            this.barButtonItem1,
            this.mnuEditar,
            this.mnuNuevo,
            this.btnArchivosAuxiliares,
            this.btnEnviarCorreo});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 21;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMarqueeProgressBar1});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.mnuNuevo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.mnuGuardar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.mnuEditar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEnviarCorreo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSalir, true)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // mnuNuevo
            // 
            this.mnuNuevo.Caption = "Nuevo";
            this.mnuNuevo.Id = 18;
            this.mnuNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuNuevo.ImageOptions.Image")));
            this.mnuNuevo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mnuNuevo.ImageOptions.LargeImage")));
            this.mnuNuevo.Name = "mnuNuevo";
            this.mnuNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuNuevo_ItemClick);
            // 
            // mnuGuardar
            // 
            this.mnuGuardar.Caption = "Guardar";
            this.mnuGuardar.Id = 15;
            this.mnuGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuGuardar.ImageOptions.Image")));
            this.mnuGuardar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mnuGuardar.ImageOptions.LargeImage")));
            this.mnuGuardar.Name = "mnuGuardar";
            this.mnuGuardar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.mnuGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuGuardar_ItemClick);
            // 
            // mnuEditar
            // 
            this.mnuEditar.Caption = "Editar";
            this.mnuEditar.Id = 17;
            this.mnuEditar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuEditar.ImageOptions.Image")));
            this.mnuEditar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mnuEditar.ImageOptions.LargeImage")));
            this.mnuEditar.Name = "mnuEditar";
            this.mnuEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuEditar_ItemClick);
            // 
            // btnEnviarCorreo
            // 
            this.btnEnviarCorreo.Caption = "Enviar por correo";
            this.btnEnviarCorreo.Id = 20;
            this.btnEnviarCorreo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviarCorreo.ImageOptions.Image")));
            this.btnEnviarCorreo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEnviarCorreo.ImageOptions.LargeImage")));
            this.btnEnviarCorreo.Name = "btnEnviarCorreo";
            this.btnEnviarCorreo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEnviarCorreo_ItemClick);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.mnuSalir.Caption = "Salir";
            this.mnuSalir.Id = 3;
            this.mnuSalir.ImageOptions.Image = global::wfaIntersem.Properties.Resources.close_20x20;
            this.mnuSalir.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q));
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.mnuSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSalir_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Barra de estado";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.prgProgreso)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Barra de estado";
            // 
            // prgProgreso
            // 
            this.prgProgreso.Caption = "barEditItem1";
            this.prgProgreso.Edit = this.repositoryItemMarqueeProgressBar1;
            this.prgProgreso.EditValue = "Procesando...";
            this.prgProgreso.EditWidth = 150;
            this.prgProgreso.Id = 9;
            this.prgProgreso.Name = "prgProgreso";
            this.prgProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // repositoryItemMarqueeProgressBar1
            // 
            this.repositoryItemMarqueeProgressBar1.Name = "repositoryItemMarqueeProgressBar1";
            this.repositoryItemMarqueeProgressBar1.ShowTitle = true;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1107, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 594);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1107, 19);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 563);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1107, 31);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 563);
            // 
            // mnuGenerarServicio
            // 
            this.mnuGenerarServicio.Caption = "Generar Servicio";
            this.mnuGenerarServicio.Id = 11;
            this.mnuGenerarServicio.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuGenerarServicio.ImageOptions.Image")));
            this.mnuGenerarServicio.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mnuGenerarServicio.ImageOptions.LargeImage")));
            this.mnuGenerarServicio.Name = "mnuGenerarServicio";
            this.mnuGenerarServicio.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Editar";
            this.barButtonItem1.Id = 16;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnArchivosAuxiliares
            // 
            this.btnArchivosAuxiliares.Caption = "Archivos auxiliares";
            this.btnArchivosAuxiliares.Id = 19;
            this.btnArchivosAuxiliares.Name = "btnArchivosAuxiliares";
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(600, 157);
            this.txtPorcentaje.MenuManager = this.barManager1;
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPorcentaje.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPorcentaje.Properties.MaskSettings.Set("mask", "p");
            this.txtPorcentaje.Size = new System.Drawing.Size(98, 20);
            this.txtPorcentaje.StyleController = this.layoutControl1;
            this.txtPorcentaje.TabIndex = 66;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(367, 157);
            this.txtPrecio.MenuManager = this.barManager1;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPrecio.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPrecio.Properties.MaskSettings.Set("mask", "c");
            this.txtPrecio.Size = new System.Drawing.Size(115, 20);
            this.txtPrecio.StyleController = this.layoutControl1;
            this.txtPrecio.TabIndex = 65;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(120, 157);
            this.txtCantidad.MenuManager = this.barManager1;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCantidad.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtCantidad.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtCantidad.Properties.MaskSettings.Set("mask", "n0");
            this.txtCantidad.Size = new System.Drawing.Size(119, 20);
            this.txtCantidad.StyleController = this.layoutControl1;
            this.txtCantidad.TabIndex = 63;
            // 
            // cmbContacto
            // 
            this.cmbContacto.EditValue = "";
            this.cmbContacto.Location = new System.Drawing.Point(120, 88);
            this.cmbContacto.MenuManager = this.barManager1;
            this.cmbContacto.Name = "cmbContacto";
            this.cmbContacto.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.cmbContacto.Properties.Appearance.Options.UseBackColor = true;
            this.cmbContacto.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Window;
            this.cmbContacto.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.cmbContacto.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Window;
            this.cmbContacto.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.cmbContacto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbContacto.Properties.DisplayMember = "nombre_completo";
            this.cmbContacto.Properties.NullText = "";
            this.cmbContacto.Properties.PopupView = this.gridView1;
            this.cmbContacto.Properties.ValueMember = "id_contacto";
            this.cmbContacto.Size = new System.Drawing.Size(162, 20);
            this.cmbContacto.StyleController = this.layoutControl1;
            this.cmbContacto.TabIndex = 57;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidacion.SetValidationRule(this.cmbContacto, conditionValidationRule1);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id_contacto,
            this.nombreContacto,
            this.apellido_PContacto,
            this.apellido_mContacto,
            this.nombre_completo_contacto,
            this.cCorreoC});
            this.gridView1.DetailHeight = 284;
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // id_contacto
            // 
            this.id_contacto.Caption = "id_contacto";
            this.id_contacto.FieldName = "id_contacto";
            this.id_contacto.MinWidth = 17;
            this.id_contacto.Name = "id_contacto";
            this.id_contacto.Width = 64;
            // 
            // nombreContacto
            // 
            this.nombreContacto.Caption = "Nombre";
            this.nombreContacto.FieldName = "nombre";
            this.nombreContacto.MinWidth = 17;
            this.nombreContacto.Name = "nombreContacto";
            this.nombreContacto.Visible = true;
            this.nombreContacto.VisibleIndex = 0;
            this.nombreContacto.Width = 64;
            // 
            // apellido_PContacto
            // 
            this.apellido_PContacto.Caption = "Apellido Paterno";
            this.apellido_PContacto.FieldName = "apellido_p";
            this.apellido_PContacto.MinWidth = 17;
            this.apellido_PContacto.Name = "apellido_PContacto";
            this.apellido_PContacto.Visible = true;
            this.apellido_PContacto.VisibleIndex = 1;
            this.apellido_PContacto.Width = 64;
            // 
            // apellido_mContacto
            // 
            this.apellido_mContacto.Caption = "Apellido Materno";
            this.apellido_mContacto.FieldName = "apellido_m";
            this.apellido_mContacto.MinWidth = 17;
            this.apellido_mContacto.Name = "apellido_mContacto";
            this.apellido_mContacto.Visible = true;
            this.apellido_mContacto.VisibleIndex = 2;
            this.apellido_mContacto.Width = 64;
            // 
            // nombre_completo_contacto
            // 
            this.nombre_completo_contacto.Caption = "nombre_completo";
            this.nombre_completo_contacto.FieldName = "nombre_completo";
            this.nombre_completo_contacto.MinWidth = 17;
            this.nombre_completo_contacto.Name = "nombre_completo_contacto";
            this.nombre_completo_contacto.Width = 64;
            // 
            // cCorreoC
            // 
            this.cCorreoC.Caption = "Correo";
            this.cCorreoC.FieldName = "correo_contacto";
            this.cCorreoC.MinWidth = 17;
            this.cCorreoC.Name = "cCorreoC";
            this.cCorreoC.Visible = true;
            this.cCorreoC.VisibleIndex = 3;
            this.cCorreoC.Width = 64;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(823, 64);
            this.txtTelefono.MenuManager = this.barManager1;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtTelefono.Properties.Appearance.Options.UseBackColor = true;
            this.txtTelefono.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Window;
            this.txtTelefono.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtTelefono.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Window;
            this.txtTelefono.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtTelefono.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Properties.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(137, 20);
            this.txtTelefono.StyleController = this.layoutControl1;
            this.txtTelefono.TabIndex = 56;
            // 
            // cmbCliente
            // 
            this.cmbCliente.EditValue = "";
            this.cmbCliente.Location = new System.Drawing.Point(120, 64);
            this.cmbCliente.MenuManager = this.barManager1;
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.cmbCliente.Properties.Appearance.Options.UseBackColor = true;
            this.cmbCliente.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Window;
            this.cmbCliente.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.cmbCliente.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Window;
            this.cmbCliente.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.cmbCliente.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cmbCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCliente.Properties.DisplayMember = "razon_social";
            this.cmbCliente.Properties.NullText = "";
            this.cmbCliente.Properties.PopupView = this.searchLookUpEdit1View;
            this.cmbCliente.Properties.ValueMember = "id_cliente";
            this.cmbCliente.Size = new System.Drawing.Size(162, 20);
            this.cmbCliente.StyleController = this.layoutControl1;
            this.cmbCliente.TabIndex = 55;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.dxValidacion.SetValidationRule(this.cmbCliente, conditionValidationRule2);
            this.cmbCliente.EditValueChanged += new System.EventHandler(this.cmbCliente_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id_cliente,
            this.cRazonSocial,
            this.cCiudad});
            this.searchLookUpEdit1View.DetailHeight = 284;
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // id_cliente
            // 
            this.id_cliente.Caption = "Id";
            this.id_cliente.FieldName = "id_cliente";
            this.id_cliente.MinWidth = 17;
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.OptionsColumn.AllowEdit = false;
            this.id_cliente.OptionsColumn.ReadOnly = true;
            this.id_cliente.Width = 64;
            // 
            // cRazonSocial
            // 
            this.cRazonSocial.Caption = "Cliente";
            this.cRazonSocial.FieldName = "razon_social";
            this.cRazonSocial.MinWidth = 17;
            this.cRazonSocial.Name = "cRazonSocial";
            this.cRazonSocial.Visible = true;
            this.cRazonSocial.VisibleIndex = 0;
            this.cRazonSocial.Width = 64;
            // 
            // cCiudad
            // 
            this.cCiudad.Caption = "Ciudad";
            this.cCiudad.FieldName = "municipio";
            this.cCiudad.MinWidth = 17;
            this.cCiudad.Name = "cCiudad";
            this.cCiudad.Visible = true;
            this.cCiudad.VisibleIndex = 1;
            this.cCiudad.Width = 64;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(38, 304);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(10, 3);
            this.splitterControl1.TabIndex = 50;
            this.splitterControl1.TabStop = false;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Enabled = false;
            this.txtDomicilio.Location = new System.Drawing.Point(456, 64);
            this.txtDomicilio.MenuManager = this.barManager1;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.txtDomicilio.Properties.Appearance.Options.UseBackColor = true;
            this.txtDomicilio.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Window;
            this.txtDomicilio.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtDomicilio.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Window;
            this.txtDomicilio.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtDomicilio.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDomicilio.Properties.ReadOnly = true;
            this.txtDomicilio.Properties.UseReadOnlyAppearance = false;
            this.txtDomicilio.Size = new System.Drawing.Size(207, 20);
            this.txtDomicilio.StyleController = this.layoutControl1;
            this.txtDomicilio.TabIndex = 46;
            this.txtDomicilio.Tag = "CheckOut";
            // 
            // txtTotalNeto
            // 
            this.txtTotalNeto.EditValue = "$0.00";
            this.txtTotalNeto.Location = new System.Drawing.Point(927, 481);
            this.txtTotalNeto.MenuManager = this.barManager1;
            this.txtTotalNeto.Name = "txtTotalNeto";
            this.txtTotalNeto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtTotalNeto.Properties.Appearance.Options.UseFont = true;
            this.txtTotalNeto.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotalNeto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotalNeto.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtTotalNeto.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtTotalNeto.Properties.AppearanceDisabled.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.txtTotalNeto.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtTotalNeto.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtTotalNeto.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtTotalNeto.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtTotalNeto.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txtTotalNeto.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotalNeto.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTotalNeto.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtTotalNeto.Properties.AppearanceReadOnly.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.txtTotalNeto.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black;
            this.txtTotalNeto.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtTotalNeto.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtTotalNeto.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtTotalNeto.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtTotalNeto.Properties.DisplayFormat.FormatString = "c2";
            this.txtTotalNeto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTotalNeto.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtTotalNeto.Properties.MaskSettings.Set("mask", "c");
            this.txtTotalNeto.Properties.NullText = "0";
            this.txtTotalNeto.Properties.ReadOnly = true;
            this.txtTotalNeto.Size = new System.Drawing.Size(161, 22);
            this.txtTotalNeto.StyleController = this.layoutControl1;
            this.txtTotalNeto.TabIndex = 33;
            // 
            // txtIva
            // 
            this.txtIva.EditValue = "";
            this.txtIva.Location = new System.Drawing.Point(927, 455);
            this.txtIva.MenuManager = this.barManager1;
            this.txtIva.Name = "txtIva";
            this.txtIva.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtIva.Properties.Appearance.Options.UseFont = true;
            this.txtIva.Properties.Appearance.Options.UseTextOptions = true;
            this.txtIva.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtIva.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtIva.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtIva.Properties.AppearanceDisabled.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.txtIva.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtIva.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtIva.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtIva.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtIva.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txtIva.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtIva.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtIva.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtIva.Properties.AppearanceReadOnly.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.txtIva.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black;
            this.txtIva.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtIva.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtIva.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtIva.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtIva.Properties.DisplayFormat.FormatString = "c2";
            this.txtIva.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtIva.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtIva.Properties.MaskSettings.Set("mask", "c");
            this.txtIva.Properties.NullText = "0";
            this.txtIva.Properties.ReadOnly = true;
            this.txtIva.Properties.UseMaskAsDisplayFormat = true;
            this.txtIva.Properties.UseReadOnlyAppearance = false;
            this.txtIva.Size = new System.Drawing.Size(161, 22);
            this.txtIva.StyleController = this.layoutControl1;
            this.txtIva.TabIndex = 31;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.EditValue = "";
            this.txtSubtotal.Location = new System.Drawing.Point(927, 429);
            this.txtSubtotal.MenuManager = this.barManager1;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtSubtotal.Properties.Appearance.Options.UseFont = true;
            this.txtSubtotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSubtotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSubtotal.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtSubtotal.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtSubtotal.Properties.AppearanceDisabled.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.txtSubtotal.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtSubtotal.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtSubtotal.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtSubtotal.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtSubtotal.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txtSubtotal.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSubtotal.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtSubtotal.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtSubtotal.Properties.AppearanceReadOnly.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.txtSubtotal.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black;
            this.txtSubtotal.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtSubtotal.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtSubtotal.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txtSubtotal.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtSubtotal.Properties.DisplayFormat.FormatString = "c2";
            this.txtSubtotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSubtotal.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtSubtotal.Properties.MaskSettings.Set("mask", "c");
            this.txtSubtotal.Properties.NullText = "0";
            this.txtSubtotal.Properties.ReadOnly = true;
            this.txtSubtotal.Properties.UseMaskAsDisplayFormat = true;
            this.txtSubtotal.Properties.UseReadOnlyAppearance = false;
            this.txtSubtotal.Size = new System.Drawing.Size(161, 22);
            this.txtSubtotal.StyleController = this.layoutControl1;
            this.txtSubtotal.TabIndex = 28;
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.No;
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(456, 88);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtEmail.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtEmail.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtEmail.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtEmail.Properties.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(207, 20);
            this.txtEmail.StyleController = this.layoutControl1;
            this.txtEmail.TabIndex = 27;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(120, 429);
            this.txtObservaciones.MenuManager = this.barManager1;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(480, 74);
            this.txtObservaciones.StyleController = this.layoutControl1;
            this.txtObservaciones.TabIndex = 11;
            // 
            // grdDetalle
            // 
            this.grdDetalle.Location = new System.Drawing.Point(15, 262);
            this.grdDetalle.MainView = this.grvDetalle;
            this.grdDetalle.MenuManager = this.barManager1;
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdAcciones,
            this.txtAcuerdos});
            this.grdDetalle.Size = new System.Drawing.Size(1077, 122);
            this.grdDetalle.TabIndex = 10;
            this.grdDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDetalle});
            // 
            // grvDetalle
            // 
            this.grvDetalle.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 6F);
            this.grvDetalle.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.grvDetalle.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightBlue;
            this.grvDetalle.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.grvDetalle.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grvDetalle.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grvDetalle.Appearance.FooterPanel.Options.UseFont = true;
            this.grvDetalle.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grvDetalle.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvDetalle.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.grvDetalle.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grvDetalle.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.grvDetalle.Appearance.Row.Options.UseTextOptions = true;
            this.grvDetalle.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grvDetalle.AutoFillColumn = this.cDescripcion;
            this.grvDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cCantidad,
            this.cPrecio,
            this.cDescuento,
            this.cImporte,
            this.cAcciones,
            this.cTiempo_Entrega,
            this.cPartidas,
            this.cDescripcion});
            this.grvDetalle.CustomizationFormBounds = new System.Drawing.Rectangle(977, 350, 260, 232);
            this.grvDetalle.GridControl = this.grdDetalle;
            this.grvDetalle.Name = "grvDetalle";
            this.grvDetalle.OptionsCustomization.AllowGroup = false;
            this.grvDetalle.OptionsCustomization.AllowSort = false;
            this.grvDetalle.OptionsNavigation.EnterMoveNextColumn = true;
            this.grvDetalle.OptionsNavigation.UseTabKey = false;
            this.grvDetalle.OptionsPrint.AutoWidth = false;
            this.grvDetalle.OptionsPrint.PrintFilterInfo = true;
            this.grvDetalle.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
            this.grvDetalle.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Fast;
            this.grvDetalle.OptionsView.EnableAppearanceEvenRow = true;
            this.grvDetalle.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            this.grvDetalle.OptionsView.ShowFooter = true;
            this.grvDetalle.OptionsView.ShowGroupPanel = false;
            this.grvDetalle.OptionsView.ShowViewCaption = true;
            this.grvDetalle.ViewCaption = "Detalle";
            this.grvDetalle.ShownEditor += new System.EventHandler(this.grvDetalle_ShownEditor);
            this.grvDetalle.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grvDetalle_CellValueChanged);
            // 
            // cDescripcion
            // 
            this.cDescripcion.Caption = "Descripción";
            this.cDescripcion.FieldName = "descripcion";
            this.cDescripcion.Name = "cDescripcion";
            this.cDescripcion.Visible = true;
            this.cDescripcion.VisibleIndex = 1;
            // 
            // cCantidad
            // 
            this.cCantidad.Caption = "Cantidad";
            this.cCantidad.FieldName = "cantidad";
            this.cCantidad.Name = "cCantidad";
            this.cCantidad.Visible = true;
            this.cCantidad.VisibleIndex = 2;
            this.cCantidad.Width = 71;
            // 
            // cPrecio
            // 
            this.cPrecio.AppearanceCell.Options.UseTextOptions = true;
            this.cPrecio.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cPrecio.Caption = "Precio";
            this.cPrecio.DisplayFormat.FormatString = "$ ##,##0.00";
            this.cPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cPrecio.FieldName = "precio";
            this.cPrecio.Name = "cPrecio";
            this.cPrecio.Visible = true;
            this.cPrecio.VisibleIndex = 3;
            this.cPrecio.Width = 68;
            // 
            // cDescuento
            // 
            this.cDescuento.Caption = "Descuento";
            this.cDescuento.DisplayFormat.FormatString = "p";
            this.cDescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cDescuento.FieldName = "descuento";
            this.cDescuento.Name = "cDescuento";
            this.cDescuento.Visible = true;
            this.cDescuento.VisibleIndex = 4;
            this.cDescuento.Width = 74;
            // 
            // cImporte
            // 
            this.cImporte.Caption = "Importe";
            this.cImporte.DisplayFormat.FormatString = "$ ##,##0.00";
            this.cImporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cImporte.FieldName = "importe";
            this.cImporte.Name = "cImporte";
            this.cImporte.OptionsColumn.AllowEdit = false;
            this.cImporte.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "importe", "Total importe: ${0:##,##0.00}")});
            this.cImporte.Visible = true;
            this.cImporte.VisibleIndex = 5;
            this.cImporte.Width = 102;
            // 
            // cAcciones
            // 
            this.cAcciones.Caption = "Acciones";
            this.cAcciones.ColumnEdit = this.cmdAcciones;
            this.cAcciones.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.cAcciones.Name = "cAcciones";
            this.cAcciones.Visible = true;
            this.cAcciones.VisibleIndex = 7;
            this.cAcciones.Width = 102;
            // 
            // cmdAcciones
            // 
            this.cmdAcciones.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            toolTipTitleItem1.Text = "Eliminar";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Eliminar registro de partida";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.cmdAcciones.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", 1, superToolTip1, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, false, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdAcciones.Name = "cmdAcciones";
            this.cmdAcciones.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdAcciones.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdAcciones_ButtonPressed);
            // 
            // cTiempo_Entrega
            // 
            this.cTiempo_Entrega.Caption = "Tiempo Entrega";
            this.cTiempo_Entrega.FieldName = "tiempo_entrega";
            this.cTiempo_Entrega.Name = "cTiempo_Entrega";
            this.cTiempo_Entrega.Visible = true;
            this.cTiempo_Entrega.VisibleIndex = 6;
            this.cTiempo_Entrega.Width = 68;
            // 
            // cPartidas
            // 
            this.cPartidas.Caption = "Partidas";
            this.cPartidas.FieldName = "partida";
            this.cPartidas.Name = "cPartidas";
            this.cPartidas.OptionsColumn.AllowEdit = false;
            this.cPartidas.Visible = true;
            this.cPartidas.VisibleIndex = 0;
            // 
            // txtAcuerdos
            // 
            this.txtAcuerdos.AutoHeight = false;
            this.txtAcuerdos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtAcuerdos.Name = "txtAcuerdos";
            // 
            // dtFecha
            // 
            this.dtFecha.EditValue = null;
            this.dtFecha.Enabled = false;
            this.dtFecha.Location = new System.Drawing.Point(530, 40);
            this.dtFecha.MaximumSize = new System.Drawing.Size(80, 0);
            this.dtFecha.MenuManager = this.barManager1;
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dtFecha.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Properties.Appearance.Options.UseFont = true;
            this.dtFecha.Properties.AppearanceCalendar.Header.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Properties.AppearanceCalendar.Header.Options.UseFont = true;
            this.dtFecha.Properties.AppearanceCalendar.HeaderHighlighted.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Properties.AppearanceCalendar.HeaderHighlighted.Options.UseFont = true;
            this.dtFecha.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Window;
            this.dtFecha.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.dtFecha.Properties.AppearanceDisabled.Options.UseFont = true;
            this.dtFecha.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Properties.AppearanceDropDown.Options.UseFont = true;
            this.dtFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Properties.MaskSettings.Set("mask", "d");
            this.dtFecha.Size = new System.Drawing.Size(80, 20);
            this.dtFecha.StyleController = this.layoutControl1;
            this.dtFecha.TabIndex = 2;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            this.dxValidacion.SetValidationRule(this.dtFecha, conditionValidationRule3);
            // 
            // dtVigencia
            // 
            this.dtVigencia.EditValue = null;
            this.dtVigencia.Location = new System.Drawing.Point(768, 40);
            this.dtVigencia.MaximumSize = new System.Drawing.Size(80, 0);
            this.dtVigencia.Name = "dtVigencia";
            this.dtVigencia.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dtVigencia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtVigencia.Properties.Appearance.Options.UseFont = true;
            this.dtVigencia.Properties.AppearanceCalendar.Header.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtVigencia.Properties.AppearanceCalendar.Header.Options.UseFont = true;
            this.dtVigencia.Properties.AppearanceCalendar.HeaderHighlighted.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtVigencia.Properties.AppearanceCalendar.HeaderHighlighted.Options.UseFont = true;
            this.dtVigencia.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Window;
            this.dtVigencia.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtVigencia.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.dtVigencia.Properties.AppearanceDisabled.Options.UseFont = true;
            this.dtVigencia.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtVigencia.Properties.AppearanceDropDown.Options.UseFont = true;
            this.dtVigencia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtVigencia.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtVigencia.Properties.MaskSettings.Set("mask", "d");
            this.dtVigencia.Size = new System.Drawing.Size(80, 20);
            this.dtVigencia.StyleController = this.layoutControl1;
            this.dtVigencia.TabIndex = 2;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "This value is not valid";
            this.dxValidacion.SetValidationRule(this.dtVigencia, conditionValidationRule4);
            // 
            // cmbResponsable
            // 
            this.cmbResponsable.EditValue = "";
            this.cmbResponsable.Location = new System.Drawing.Point(120, 40);
            this.cmbResponsable.MaximumSize = new System.Drawing.Size(300, 0);
            this.cmbResponsable.Name = "cmbResponsable";
            this.cmbResponsable.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.cmbResponsable.Properties.Appearance.Options.UseBackColor = true;
            this.cmbResponsable.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Window;
            this.cmbResponsable.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.cmbResponsable.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Window;
            this.cmbResponsable.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.cmbResponsable.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cmbResponsable.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbResponsable.Properties.DisplayMember = "responsable";
            this.cmbResponsable.Properties.NullText = "";
            this.cmbResponsable.Properties.PopupView = this.searchLookUpEdit1View1;
            this.cmbResponsable.Properties.ValueMember = "id";
            this.cmbResponsable.Size = new System.Drawing.Size(162, 20);
            this.cmbResponsable.StyleController = this.layoutControl1;
            this.cmbResponsable.TabIndex = 55;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "This value is not valid";
            this.dxValidacion.SetValidationRule(this.cmbResponsable, conditionValidationRule5);
            // 
            // searchLookUpEdit1View1
            // 
            this.searchLookUpEdit1View1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdResponsable,
            this.cNombreResponsable,
            this.cPuestoResponsable});
            this.searchLookUpEdit1View1.DetailHeight = 284;
            this.searchLookUpEdit1View1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View1.Name = "searchLookUpEdit1View1";
            this.searchLookUpEdit1View1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View1.OptionsView.ShowGroupPanel = false;
            // 
            // IdResponsable
            // 
            this.IdResponsable.Caption = "Id";
            this.IdResponsable.FieldName = "id";
            this.IdResponsable.MinWidth = 17;
            this.IdResponsable.Name = "IdResponsable";
            this.IdResponsable.OptionsColumn.AllowEdit = false;
            this.IdResponsable.OptionsColumn.ReadOnly = true;
            this.IdResponsable.Width = 64;
            // 
            // cNombreResponsable
            // 
            this.cNombreResponsable.Caption = "Responsable";
            this.cNombreResponsable.FieldName = "responsable";
            this.cNombreResponsable.MinWidth = 17;
            this.cNombreResponsable.Name = "cNombreResponsable";
            this.cNombreResponsable.OptionsColumn.AllowEdit = false;
            this.cNombreResponsable.Visible = true;
            this.cNombreResponsable.VisibleIndex = 0;
            this.cNombreResponsable.Width = 64;
            // 
            // cPuestoResponsable
            // 
            this.cPuestoResponsable.Caption = "Puesto";
            this.cPuestoResponsable.FieldName = "puesto";
            this.cPuestoResponsable.MinWidth = 17;
            this.cPuestoResponsable.Name = "cPuestoResponsable";
            this.cPuestoResponsable.OptionsColumn.AllowEdit = false;
            this.cPuestoResponsable.Visible = true;
            this.cPuestoResponsable.VisibleIndex = 1;
            this.cPuestoResponsable.Width = 64;
            // 
            // txtVersion
            // 
            this.txtVersion.Enabled = false;
            this.txtVersion.Location = new System.Drawing.Point(990, 40);
            this.txtVersion.Margin = new System.Windows.Forms.Padding(2);
            this.txtVersion.MenuManager = this.barManager1;
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtVersion.Properties.Appearance.Options.UseFont = true;
            this.txtVersion.Size = new System.Drawing.Size(98, 20);
            this.txtVersion.StyleController = this.layoutControl1;
            this.txtVersion.TabIndex = 83;
            // 
            // txtTiempoEntrega
            // 
            this.txtTiempoEntrega.Location = new System.Drawing.Point(812, 157);
            this.txtTiempoEntrega.Margin = new System.Windows.Forms.Padding(2);
            this.txtTiempoEntrega.MenuManager = this.barManager1;
            this.txtTiempoEntrega.Name = "txtTiempoEntrega";
            this.txtTiempoEntrega.Size = new System.Drawing.Size(276, 20);
            this.txtTiempoEntrega.StyleController = this.layoutControl1;
            this.txtTiempoEntrega.TabIndex = 73;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.emptySpaceItem9,
            this.emptySpaceItem13,
            this.layoutControlGroup3,
            this.layoutControlGroup4,
            this.layoutControlGroup5,
            this.emptySpaceItem28,
            this.layoutCotrolGroup6});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1107, 532);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup2.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 226);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroup2.Size = new System.Drawing.Size(1097, 163);
            this.layoutControlGroup2.Text = "Detalle de cotizacion";
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.grdDetalle;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(1081, 126);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem9
            // 
            this.emptySpaceItem9.AllowHotTrack = false;
            this.emptySpaceItem9.Location = new System.Drawing.Point(365, 512);
            this.emptySpaceItem9.Name = "emptySpaceItem9";
            this.emptySpaceItem9.Size = new System.Drawing.Size(732, 10);
            this.emptySpaceItem9.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem13
            // 
            this.emptySpaceItem13.AllowHotTrack = false;
            this.emptySpaceItem13.Location = new System.Drawing.Point(0, 512);
            this.emptySpaceItem13.Name = "emptySpaceItem13";
            this.emptySpaceItem13.Size = new System.Drawing.Size(365, 10);
            this.emptySpaceItem13.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lytResponsable,
            this.lytCliente,
            this.lytContacto,
            this.emptySpaceItem4,
            this.emptySpaceItem3,
            this.lytDomicilio,
            this.lytFecha,
            this.lytVigencia,
            this.emptySpaceItem7,
            this.emptySpaceItem2,
            this.lytCorreo,
            this.lytTelefono,
            this.emptySpaceItem6,
            this.emptySpaceItem12,
            this.lytVersion,
            this.emptySpaceItem5,
            this.emptySpaceItem11});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1097, 117);
            this.layoutControlGroup3.Text = "Datos Generales";
            // 
            // lytResponsable
            // 
            this.lytResponsable.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lytResponsable.AppearanceItemCaption.Options.UseFont = true;
            this.lytResponsable.Control = this.cmbResponsable;
            this.lytResponsable.CustomizationFormText = "Cliente";
            this.lytResponsable.Location = new System.Drawing.Point(0, 0);
            this.lytResponsable.Name = "lytResponsable";
            this.lytResponsable.Size = new System.Drawing.Size(267, 24);
            this.lytResponsable.Text = "Responsable";
            this.lytResponsable.TextSize = new System.Drawing.Size(89, 13);
            // 
            // lytCliente
            // 
            this.lytCliente.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lytCliente.AppearanceItemCaption.Options.UseFont = true;
            this.lytCliente.Control = this.cmbCliente;
            this.lytCliente.Location = new System.Drawing.Point(0, 24);
            this.lytCliente.Name = "lytCliente";
            this.lytCliente.Size = new System.Drawing.Size(267, 24);
            this.lytCliente.Text = "Cliente";
            this.lytCliente.TextSize = new System.Drawing.Size(89, 13);
            // 
            // lytContacto
            // 
            this.lytContacto.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lytContacto.AppearanceItemCaption.Options.UseFont = true;
            this.lytContacto.Control = this.cmbContacto;
            this.lytContacto.Location = new System.Drawing.Point(0, 48);
            this.lytContacto.Name = "lytContacto";
            this.lytContacto.Size = new System.Drawing.Size(267, 24);
            this.lytContacto.Text = "Contacto";
            this.lytContacto.TextSize = new System.Drawing.Size(89, 13);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(267, 0);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(143, 24);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(267, 24);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(69, 24);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lytDomicilio
            // 
            this.lytDomicilio.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lytDomicilio.AppearanceItemCaption.Options.UseFont = true;
            this.lytDomicilio.Control = this.txtDomicilio;
            this.lytDomicilio.Location = new System.Drawing.Point(336, 24);
            this.lytDomicilio.Name = "lytDomicilio";
            this.lytDomicilio.Size = new System.Drawing.Size(312, 24);
            this.lytDomicilio.Text = "Domicilio";
            this.lytDomicilio.TextSize = new System.Drawing.Size(89, 13);
            // 
            // lytFecha
            // 
            this.lytFecha.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lytFecha.AppearanceItemCaption.Options.UseFont = true;
            this.lytFecha.Control = this.dtFecha;
            this.lytFecha.CustomizationFormText = "Fecha";
            this.lytFecha.Enabled = false;
            this.lytFecha.Location = new System.Drawing.Point(410, 0);
            this.lytFecha.Name = "lytFecha";
            this.lytFecha.Size = new System.Drawing.Size(185, 24);
            this.lytFecha.Text = "Fecha";
            this.lytFecha.TextSize = new System.Drawing.Size(89, 13);
            // 
            // lytVigencia
            // 
            this.lytVigencia.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lytVigencia.AppearanceItemCaption.Options.UseFont = true;
            this.lytVigencia.Control = this.dtVigencia;
            this.lytVigencia.CustomizationFormText = "Fecha";
            this.lytVigencia.Location = new System.Drawing.Point(648, 0);
            this.lytVigencia.Name = "lytVigencia";
            this.lytVigencia.Size = new System.Drawing.Size(185, 24);
            this.lytVigencia.Text = "Vigencia";
            this.lytVigencia.TextSize = new System.Drawing.Size(89, 13);
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.Location = new System.Drawing.Point(648, 24);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(88, 24);
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(267, 48);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(69, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lytCorreo
            // 
            this.lytCorreo.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lytCorreo.AppearanceItemCaption.Options.UseFont = true;
            this.lytCorreo.Control = this.txtEmail;
            this.lytCorreo.Location = new System.Drawing.Point(336, 48);
            this.lytCorreo.Name = "lytCorreo";
            this.lytCorreo.Size = new System.Drawing.Size(312, 24);
            this.lytCorreo.Text = "Email";
            this.lytCorreo.TextSize = new System.Drawing.Size(89, 13);
            // 
            // lytTelefono
            // 
            this.lytTelefono.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lytTelefono.AppearanceItemCaption.Options.UseFont = true;
            this.lytTelefono.Control = this.txtTelefono;
            this.lytTelefono.Location = new System.Drawing.Point(736, 24);
            this.lytTelefono.Name = "lytTelefono";
            this.lytTelefono.Size = new System.Drawing.Size(209, 24);
            this.lytTelefono.Text = "Teléfono    ";
            this.lytTelefono.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lytTelefono.TextSize = new System.Drawing.Size(63, 15);
            this.lytTelefono.TextToControlDistance = 5;
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(648, 48);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(425, 24);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem12
            // 
            this.emptySpaceItem12.AllowHotTrack = false;
            this.emptySpaceItem12.Location = new System.Drawing.Point(945, 24);
            this.emptySpaceItem12.Name = "emptySpaceItem12";
            this.emptySpaceItem12.Size = new System.Drawing.Size(128, 24);
            this.emptySpaceItem12.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lytVersion
            // 
            this.lytVersion.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lytVersion.AppearanceItemCaption.Options.UseFont = true;
            this.lytVersion.Control = this.txtVersion;
            this.lytVersion.Location = new System.Drawing.Point(870, 0);
            this.lytVersion.Name = "lytVersion";
            this.lytVersion.Size = new System.Drawing.Size(203, 24);
            this.lytVersion.Text = "Versión";
            this.lytVersion.TextLocation = DevExpress.Utils.Locations.Left;
            this.lytVersion.TextSize = new System.Drawing.Size(89, 13);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(595, 0);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(53, 24);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem11
            // 
            this.emptySpaceItem11.AllowHotTrack = false;
            this.emptySpaceItem11.Location = new System.Drawing.Point(833, 0);
            this.emptySpaceItem11.Name = "emptySpaceItem11";
            this.emptySpaceItem11.Size = new System.Drawing.Size(37, 24);
            this.emptySpaceItem11.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lytCantidad,
            this.emptySpaceItem8,
            this.lytPrecio,
            this.emptySpaceItem10,
            this.lytDescuento,
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlItem9,
            this.layoutControlItem6});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 117);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(1097, 109);
            this.layoutControlGroup4.Text = "Detalle Partida";
            // 
            // lytCantidad
            // 
            this.lytCantidad.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lytCantidad.AppearanceItemCaption.Options.UseFont = true;
            this.lytCantidad.Control = this.txtCantidad;
            this.lytCantidad.Location = new System.Drawing.Point(0, 0);
            this.lytCantidad.Name = "lytCantidad";
            this.lytCantidad.Size = new System.Drawing.Size(224, 24);
            this.lytCantidad.Text = "Cantidad";
            this.lytCantidad.TextSize = new System.Drawing.Size(89, 13);
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.AllowHotTrack = false;
            this.emptySpaceItem8.Location = new System.Drawing.Point(224, 0);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(23, 24);
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lytPrecio
            // 
            this.lytPrecio.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lytPrecio.AppearanceItemCaption.Options.UseFont = true;
            this.lytPrecio.Control = this.txtPrecio;
            this.lytPrecio.Location = new System.Drawing.Point(247, 0);
            this.lytPrecio.Name = "lytPrecio";
            this.lytPrecio.Size = new System.Drawing.Size(220, 24);
            this.lytPrecio.Text = "Precio";
            this.lytPrecio.TextSize = new System.Drawing.Size(89, 13);
            // 
            // emptySpaceItem10
            // 
            this.emptySpaceItem10.AllowHotTrack = false;
            this.emptySpaceItem10.Location = new System.Drawing.Point(467, 0);
            this.emptySpaceItem10.Name = "emptySpaceItem10";
            this.emptySpaceItem10.Size = new System.Drawing.Size(13, 24);
            this.emptySpaceItem10.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lytDescuento
            // 
            this.lytDescuento.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lytDescuento.AppearanceItemCaption.Options.UseFont = true;
            this.lytDescuento.Control = this.txtPorcentaje;
            this.lytDescuento.Location = new System.Drawing.Point(480, 0);
            this.lytDescuento.Name = "lytDescuento";
            this.lytDescuento.Size = new System.Drawing.Size(203, 24);
            this.lytDescuento.Text = "Descuento";
            this.lytDescuento.TextSize = new System.Drawing.Size(89, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(683, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(16, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.txtTiempoEntrega;
            this.layoutControlItem1.Location = new System.Drawing.Point(699, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(374, 24);
            this.layoutControlItem1.Text = "Tiempo Entrega";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(89, 13);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem9.Control = this.txtDescripcion;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(699, 40);
            this.layoutControlItem9.Text = "Descripción";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(89, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnAgregarEquipos;
            this.layoutControlItem6.Location = new System.Drawing.Point(699, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(374, 40);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem16,
            this.layoutControlItem19,
            this.layoutControlItem21});
            this.layoutControlGroup5.Location = new System.Drawing.Point(807, 389);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(290, 123);
            this.layoutControlGroup5.Text = " Totales";
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem16.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.layoutControlItem16.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem16.Control = this.txtSubtotal;
            this.layoutControlItem16.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(266, 26);
            this.layoutControlItem16.Text = "SubTotal";
            this.layoutControlItem16.TextSize = new System.Drawing.Size(89, 18);
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem19.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.layoutControlItem19.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem19.Control = this.txtIva;
            this.layoutControlItem19.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem19.Name = "layoutControlItem19";
            this.layoutControlItem19.Size = new System.Drawing.Size(266, 26);
            this.layoutControlItem19.Text = "IVA";
            this.layoutControlItem19.TextSize = new System.Drawing.Size(89, 18);
            // 
            // layoutControlItem21
            // 
            this.layoutControlItem21.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem21.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.layoutControlItem21.AppearanceItemCaption.ForeColor = System.Drawing.Color.Black;
            this.layoutControlItem21.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem21.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem21.Control = this.txtTotalNeto;
            this.layoutControlItem21.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem21.Name = "layoutControlItem21";
            this.layoutControlItem21.OptionsPrint.AppearanceItem.BackColor = System.Drawing.Color.Black;
            this.layoutControlItem21.OptionsPrint.AppearanceItem.ForeColor = System.Drawing.Color.Black;
            this.layoutControlItem21.OptionsPrint.AppearanceItem.Options.UseBackColor = true;
            this.layoutControlItem21.OptionsPrint.AppearanceItem.Options.UseForeColor = true;
            this.layoutControlItem21.OptionsPrint.AppearanceItem.Options.UseTextOptions = true;
            this.layoutControlItem21.OptionsPrint.AppearanceItem.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem21.Size = new System.Drawing.Size(266, 26);
            this.layoutControlItem21.Text = "Total";
            this.layoutControlItem21.TextSize = new System.Drawing.Size(89, 18);
            // 
            // emptySpaceItem28
            // 
            this.emptySpaceItem28.AllowHotTrack = false;
            this.emptySpaceItem28.Location = new System.Drawing.Point(797, 389);
            this.emptySpaceItem28.Name = "emptySpaceItem28";
            this.emptySpaceItem28.Size = new System.Drawing.Size(10, 123);
            this.emptySpaceItem28.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutCotrolGroup6
            // 
            this.layoutCotrolGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem10,
            this.layoutControlItem8});
            this.layoutCotrolGroup6.Location = new System.Drawing.Point(0, 389);
            this.layoutCotrolGroup6.Name = "layoutCotrolGroup6";
            this.layoutCotrolGroup6.Size = new System.Drawing.Size(797, 123);
            this.layoutCotrolGroup6.Text = " Observaciones y politicas";
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem10.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem10.Control = this.txtObservaciones;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(585, 78);
            this.layoutControlItem10.Text = "Observaciones: ";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(89, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControlItem8.Control = this.btnPoliticas;
            this.layoutControlItem8.Location = new System.Drawing.Point(585, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(188, 78);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblTitulo);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 31);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1107, 31);
            this.panelControl1.TabIndex = 9;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Appearance.Options.UseFont = true;
            this.lblTitulo.Location = new System.Drawing.Point(12, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(78, 18);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cotización";
            // 
            // backwDatos
            // 
            this.backwDatos.WorkerReportsProgress = true;
            this.backwDatos.WorkerSupportsCancellation = true;
            this.backwDatos.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backwDatos_DoWork);
            this.backwDatos.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backwDatos_ProgressChanged);
            this.backwDatos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backwDatos_RunWorkerCompleted);
            // 
            // cIdMarcaC
            // 
            this.cIdMarcaC.Caption = "Id Marca";
            this.cIdMarcaC.FieldName = "id_marca";
            this.cIdMarcaC.Name = "cIdMarcaC";
            // 
            // cMarcaC
            // 
            this.cMarcaC.Caption = "Marca";
            this.cMarcaC.FieldName = "marca";
            this.cMarcaC.Name = "cMarcaC";
            this.cMarcaC.Visible = true;
            this.cMarcaC.VisibleIndex = 0;
            // 
            // emptySpaceItem18
            // 
            this.emptySpaceItem18.AllowHotTrack = false;
            this.emptySpaceItem18.Location = new System.Drawing.Point(984, 66);
            this.emptySpaceItem18.Name = "emptySpaceItem18";
            this.emptySpaceItem18.Size = new System.Drawing.Size(570, 30);
            this.emptySpaceItem18.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem19
            // 
            this.emptySpaceItem19.AllowHotTrack = false;
            this.emptySpaceItem19.Location = new System.Drawing.Point(1554, 34);
            this.emptySpaceItem19.Name = "emptySpaceItem19";
            this.emptySpaceItem19.Size = new System.Drawing.Size(91, 62);
            this.emptySpaceItem19.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem20
            // 
            this.emptySpaceItem20.AllowHotTrack = false;
            this.emptySpaceItem20.Location = new System.Drawing.Point(1174, 258);
            this.emptySpaceItem20.Name = "emptySpaceItem20";
            this.emptySpaceItem20.Size = new System.Drawing.Size(471, 24);
            this.emptySpaceItem20.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem21
            // 
            this.emptySpaceItem21.AllowHotTrack = false;
            this.emptySpaceItem21.Location = new System.Drawing.Point(42, 270);
            this.emptySpaceItem21.Name = "emptySpaceItem21";
            this.emptySpaceItem21.Size = new System.Drawing.Size(1132, 12);
            this.emptySpaceItem21.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem22
            // 
            this.emptySpaceItem22.AllowHotTrack = false;
            this.emptySpaceItem22.Location = new System.Drawing.Point(42, 471);
            this.emptySpaceItem22.Name = "emptySpaceItem22";
            this.emptySpaceItem22.Size = new System.Drawing.Size(1603, 12);
            this.emptySpaceItem22.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmCotizacionesD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 613);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmCotizacionesD.IconOptions.SvgImage")));
            this.Name = "frmCotizacionesD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotizaciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCatalogoDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentaje.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbContacto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDomicilio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalNeto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIva.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAcciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAcuerdos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVigencia.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVigencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbResponsable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVersion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTiempoEntrega.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytResponsable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytDomicilio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytVigencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutCotrolGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem22)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.DateEdit dtFecha;
        private DevExpress.XtraLayout.LayoutControlItem lytFecha;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidacion;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblTitulo;
        private System.ComponentModel.BackgroundWorker backwDatos;
        private DevExpress.XtraGrid.GridControl grdDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn cAcciones;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdAcciones;
        private DevExpress.XtraGrid.Columns.GridColumn cPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn cImporte;
        private DevExpress.XtraEditors.MemoEdit txtObservaciones;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraGrid.Columns.GridColumn cDescuento;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraLayout.LayoutControlItem lytCorreo;
        private DevExpress.XtraEditors.TextEdit txtTotalNeto;
        private DevExpress.XtraEditors.TextEdit txtIva;
        private DevExpress.XtraEditors.TextEdit txtSubtotal;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem19;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem21;
        private DevExpress.XtraEditors.TextEdit txtDomicilio;
        private DevExpress.XtraLayout.LayoutControlItem lytDomicilio;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        //private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem lytCliente;
        private DevExpress.XtraGrid.Columns.GridColumn id_cliente;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraLayout.LayoutControlItem lytTelefono;
        private DevExpress.XtraGrid.Columns.GridColumn cRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn cCiudad;
        private DevExpress.XtraEditors.DateEdit dtVigencia;
        private DevExpress.XtraLayout.LayoutControlItem lytVigencia;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbResponsable;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View1;
        private DevExpress.XtraGrid.Columns.GridColumn IdResponsable;
        private DevExpress.XtraLayout.LayoutControlItem lytResponsable;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbContacto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem lytContacto;
        private DevExpress.XtraGrid.Columns.GridColumn id_contacto;
        private DevExpress.XtraGrid.Columns.GridColumn nombreContacto;
        private DevExpress.XtraGrid.Columns.GridColumn apellido_PContacto;
        private DevExpress.XtraGrid.Columns.GridColumn apellido_mContacto;
        private DevExpress.XtraGrid.Columns.GridColumn nombre_completo_contacto;
        private TextEdit txtPorcentaje;
        private TextEdit txtPrecio;
        private TextEdit txtCantidad;
        private LayoutControlItem layoutControlItem7;
        private LayoutControlItem lytCantidad;
        private LayoutControlItem lytDescuento;
        private LayoutControlItem lytPrecio;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem mnuGenerarServicio;
        private DevExpress.XtraBars.BarButtonItem mnuSalir;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarEditItem prgProgreso;
        private DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem mnuGuardar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem mnuEditar;
        private DevExpress.XtraBars.BarButtonItem mnuNuevo;
        private DevExpress.XtraGrid.Columns.GridColumn cIdMarcaC;
        private DevExpress.XtraGrid.Columns.GridColumn cMarcaC;
        private DevExpress.XtraBars.BarButtonItem btnArchivosAuxiliares;
        private DevExpress.XtraGrid.Columns.GridColumn cCorreoC;
        private DevExpress.XtraBars.BarButtonItem btnEnviarCorreo;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit txtAcuerdos;
        private DevExpress.XtraGrid.Columns.GridColumn cNombreResponsable;
        private DevExpress.XtraGrid.Columns.GridColumn cPuestoResponsable;
        private LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn cTiempo_Entrega;
        private DevExpress.XtraGrid.Columns.GridColumn cCantidad;
        private MemoEdit txtDescripcion;
        private LayoutControlItem layoutControlItem9;
        private DevExpress.XtraGrid.Columns.GridColumn cPartidas;
        private DevExpress.XtraGrid.Columns.GridColumn cDescripcion;
        private EmptySpaceItem emptySpaceItem18;
        private EmptySpaceItem emptySpaceItem19;
        private EmptySpaceItem emptySpaceItem20;
        private EmptySpaceItem emptySpaceItem21;
        private EmptySpaceItem emptySpaceItem22;
        private EmptySpaceItem emptySpaceItem4;
        private EmptySpaceItem emptySpaceItem1;
        private EmptySpaceItem emptySpaceItem9;
        private EmptySpaceItem emptySpaceItem13;
        private SimpleButton btnPoliticas;
        private LayoutControlItem layoutControlItem8;
        private LayoutControlGroup layoutControlGroup3;
        private EmptySpaceItem emptySpaceItem3;
        private EmptySpaceItem emptySpaceItem6;
        private LayoutControlGroup layoutControlGroup4;
        private EmptySpaceItem emptySpaceItem2;
        private SimpleButton btnAgregarEquipos;
        private EmptySpaceItem emptySpaceItem7;
        private EmptySpaceItem emptySpaceItem8;
        private EmptySpaceItem emptySpaceItem10;
        private LayoutControlItem layoutControlItem6;
        private TextEdit txtVersion;
        private LayoutControlItem lytVersion;
        private EmptySpaceItem emptySpaceItem12;
        private LayoutControlGroup layoutControlGroup5;
        private EmptySpaceItem emptySpaceItem28;
        private TextEdit txtTiempoEntrega;
        private LayoutControlGroup layoutCotrolGroup6;
        private EmptySpaceItem emptySpaceItem5;
        private EmptySpaceItem emptySpaceItem11;
    }
}