using DevExpress.XtraEditors;

namespace wfaIntersem
{
    partial class frmFirmasD
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.mnuNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.mnuEditar = new DevExpress.XtraBars.BarButtonItem();
            this.mnuGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSalir = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.prgProgreso = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemMarqueeProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtResponsable = new DevExpress.XtraEditors.TextEdit();
            this.imgFirma = new DevExpress.XtraEditors.PictureEdit();
            this.txtCorreo = new DevExpress.XtraEditors.TextEdit();
            this.txtPuesto = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lytCorreo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lytPuesto = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidacion = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.backwDatos = new System.ComponentModel.BackgroundWorker();
            this.cIdImpuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cImpuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.cId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cFormato = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResponsable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFirma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytPuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
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
            this.mnuNuevo,
            this.mnuEditar,
            this.mnuGuardar,
            this.mnuSalir,
            this.prgProgreso});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuNuevo),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuEditar),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuGuardar),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSalir, true)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // mnuNuevo
            // 
            this.mnuNuevo.Caption = "Nuevo";
            this.mnuNuevo.Enabled = false;
            this.mnuNuevo.Id = 0;
            this.mnuNuevo.ImageOptions.Image = global::wfaIntersem.Properties.Resources.addfile_20x20;
            this.mnuNuevo.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.mnuNuevo.Name = "mnuNuevo";
            this.mnuNuevo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.mnuNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuNuevo_ItemClick);
            // 
            // mnuEditar
            // 
            this.mnuEditar.Caption = "Editar";
            this.mnuEditar.Enabled = false;
            this.mnuEditar.Id = 1;
            this.mnuEditar.ImageOptions.Image = global::wfaIntersem.Properties.Resources.edit_20x20;
            this.mnuEditar.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M));
            this.mnuEditar.Name = "mnuEditar";
            this.mnuEditar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.mnuEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuEditar_ItemClick);
            // 
            // mnuGuardar
            // 
            this.mnuGuardar.Caption = "Guardar";
            this.mnuGuardar.Enabled = false;
            this.mnuGuardar.Id = 2;
            this.mnuGuardar.ImageOptions.Image = global::wfaIntersem.Properties.Resources.save_20x20;
            this.mnuGuardar.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G));
            this.mnuGuardar.Name = "mnuGuardar";
            this.mnuGuardar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.mnuGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuGuardar_ItemClick);
            // 
            // mnuSalir
            // 
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlTop.Size = new System.Drawing.Size(1373, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 432);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1373, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 392);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1373, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 392);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtResponsable);
            this.layoutControl1.Controls.Add(this.imgFirma);
            this.layoutControl1.Controls.Add(this.txtCorreo);
            this.layoutControl1.Controls.Add(this.txtPuesto);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 95);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1373, 337);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtResponsable
            // 
            this.txtResponsable.Enabled = false;
            this.txtResponsable.Location = new System.Drawing.Point(97, 53);
            this.txtResponsable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResponsable.MenuManager = this.barManager1;
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Window;
            this.txtResponsable.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtResponsable.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtResponsable.Size = new System.Drawing.Size(568, 26);
            this.txtResponsable.StyleController = this.layoutControl1;
            this.txtResponsable.TabIndex = 10;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.dxValidacion.SetValidationRule(this.txtResponsable, conditionValidationRule1);
            // 
            // imgFirma
            // 
            this.imgFirma.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgFirma.Enabled = false;
            this.imgFirma.Location = new System.Drawing.Point(693, 54);
            this.imgFirma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgFirma.MenuManager = this.barManager1;
            this.imgFirma.Name = "imgFirma";
            this.imgFirma.Properties.ShowMenu = false;
            this.imgFirma.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.imgFirma.Properties.ZoomPercent = 50D;
            this.imgFirma.Size = new System.Drawing.Size(658, 262);
            this.imgFirma.StyleController = this.layoutControl1;
            this.imgFirma.TabIndex = 9;
            this.imgFirma.DoubleClick += new System.EventHandler(this.pictureEdit1_DoubleClick);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Location = new System.Drawing.Point(97, 83);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Window;
            this.txtCorreo.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtCorreo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtCorreo.Size = new System.Drawing.Size(568, 26);
            this.txtCorreo.StyleController = this.layoutControl1;
            this.txtCorreo.TabIndex = 10;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.dxValidacion.SetValidationRule(this.txtCorreo, conditionValidationRule2);
            // 
            // txtPuesto
            // 
            this.txtPuesto.Enabled = false;
            this.txtPuesto.Location = new System.Drawing.Point(97, 113);
            this.txtPuesto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Window;
            this.txtPuesto.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtPuesto.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPuesto.Size = new System.Drawing.Size(568, 26);
            this.txtPuesto.StyleController = this.layoutControl1;
            this.txtPuesto.TabIndex = 10;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            this.dxValidacion.SetValidationRule(this.txtPuesto, conditionValidationRule3);
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
            this.tabbedControlGroup1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 7, 7);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1373, 337);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem10,
            this.lytCorreo,
            this.lytPuesto});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(671, 323);
            this.layoutControlGroup2.Text = "Datos Generales";
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.txtResponsable;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(647, 30);
            this.layoutControlItem10.Text = "Nombre";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(63, 23);
            // 
            // lytCorreo
            // 
            this.lytCorreo.Control = this.txtCorreo;
            this.lytCorreo.CustomizationFormText = "Responsable";
            this.lytCorreo.Location = new System.Drawing.Point(0, 30);
            this.lytCorreo.Name = "lytCorreo";
            this.lytCorreo.Size = new System.Drawing.Size(647, 30);
            this.lytCorreo.Text = "Correo";
            this.lytCorreo.TextSize = new System.Drawing.Size(63, 23);
            // 
            // lytPuesto
            // 
            this.lytPuesto.Control = this.txtPuesto;
            this.lytPuesto.CustomizationFormText = "Responsable";
            this.lytPuesto.Location = new System.Drawing.Point(0, 60);
            this.lytPuesto.Name = "lytPuesto";
            this.lytPuesto.Size = new System.Drawing.Size(647, 207);
            this.lytPuesto.Text = "Puesto";
            this.lytPuesto.TextSize = new System.Drawing.Size(63, 23);
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.Location = new System.Drawing.Point(671, 0);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup3;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(686, 323);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3});
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem11});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(662, 266);
            this.layoutControlGroup3.Text = "Firma Electronica";
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem11.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutControlItem11.Control = this.imgFirma;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(662, 266);
            this.layoutControlItem11.Text = "Firma";
            this.layoutControlItem11.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem11.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextToControlDistance = 0;
            this.layoutControlItem11.TextVisible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 40);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1373, 55);
            this.panelControl1.TabIndex = 9;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(18, 12);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(160, 28);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Responsables";
            // 
            // backwDatos
            // 
            this.backwDatos.WorkerReportsProgress = true;
            this.backwDatos.WorkerSupportsCancellation = true;
            this.backwDatos.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backwDatos_DoWork);
            this.backwDatos.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backwDatos_ProgressChanged);
            this.backwDatos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backwDatos_RunWorkerCompleted);
            // 
            // cIdImpuesto
            // 
            this.cIdImpuesto.Caption = "IdImpuesto";
            this.cIdImpuesto.FieldName = "IdImpuesto";
            this.cIdImpuesto.Name = "cIdImpuesto";
            this.cIdImpuesto.OptionsColumn.AllowEdit = false;
            // 
            // cImpuesto
            // 
            this.cImpuesto.Caption = "Impuesto";
            this.cImpuesto.FieldName = "Impuesto";
            this.cImpuesto.Name = "cImpuesto";
            this.cImpuesto.OptionsColumn.AllowEdit = false;
            this.cImpuesto.Visible = true;
            this.cImpuesto.VisibleIndex = 0;
            this.cImpuesto.Width = 173;
            // 
            // cCosto
            // 
            this.cCosto.Caption = "Costo";
            this.cCosto.DisplayFormat.FormatString = "$ ##,##0.00";
            this.cCosto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cCosto.FieldName = "Costo";
            this.cCosto.GroupFormat.FormatString = "c2";
            this.cCosto.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cCosto.Name = "cCosto";
            this.cCosto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Costo", "SUMA={0:c2}")});
            this.cCosto.Visible = true;
            this.cCosto.VisibleIndex = 1;
            this.cCosto.Width = 117;
            // 
            // cId
            // 
            this.cId.Caption = "Id";
            this.cId.FieldName = "id";
            this.cId.MinWidth = 26;
            this.cId.Name = "cId";
            this.cId.Width = 96;
            // 
            // cFormato
            // 
            this.cFormato.Caption = "Formato";
            this.cFormato.FieldName = "formato";
            this.cFormato.MinWidth = 26;
            this.cFormato.Name = "cFormato";
            this.cFormato.Visible = true;
            this.cFormato.VisibleIndex = 0;
            this.cFormato.Width = 96;
            // 
            // frmFirmasD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 454);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFirmasD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frmCatalogoDetalle_Activated);
            this.Load += new System.EventHandler(this.frmCatalogoDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtResponsable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFirma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lytPuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.BarButtonItem mnuNuevo;
        private DevExpress.XtraBars.BarButtonItem mnuEditar;
        private DevExpress.XtraBars.BarButtonItem mnuGuardar;
        private DevExpress.XtraBars.BarButtonItem mnuSalir;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidacion;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.BarEditItem prgProgreso;
        private DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar1;
        private System.ComponentModel.BackgroundWorker backwDatos;
        private DevExpress.XtraEditors.TextEdit txtResponsable;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraGrid.Columns.GridColumn cIdImpuesto;
        private DevExpress.XtraGrid.Columns.GridColumn cImpuesto;
        private DevExpress.XtraGrid.Columns.GridColumn cCosto;
        private TextEdit txtCorreo;
        private TextEdit txtPuesto;
        private DevExpress.XtraLayout.LayoutControlItem lytCorreo;
        private DevExpress.XtraLayout.LayoutControlItem lytPuesto;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private PictureEdit imgFirma;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraGrid.Columns.GridColumn cId;
        private DevExpress.XtraGrid.Columns.GridColumn cFormato;
    }
}