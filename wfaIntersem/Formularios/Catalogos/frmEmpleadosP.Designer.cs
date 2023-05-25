namespace wfaIntersem
{
    partial class frmEmpleadosP
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleadosP));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.mnuNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.mnuImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.mnuExportar = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSalir = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barProgreso = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemMarqueeProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grdDetalle = new DevExpress.XtraGrid.GridControl();
            this.grvDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cNombreCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cIdDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cRfc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cCurp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cJornada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cCelular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cCorreo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cAlergias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cDomicilio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.memoDomicilio = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.cPerfil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cGrupoSanguineo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cAcciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdAcciones = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.backwDatos = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDomicilio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAcciones)).BeginInit();
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
            this.mnuExportar,
            this.mnuImprimir,
            this.mnuSalir,
            this.barProgreso});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
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
            this.bar2.FloatLocation = new System.Drawing.Point(342, 163);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuNuevo),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuImprimir),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuExportar),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSalir, true)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // mnuNuevo
            // 
            this.mnuNuevo.Caption = "Nuevo";
            this.mnuNuevo.Id = 0;
            this.mnuNuevo.ImageOptions.Image = global::wfaIntersem.Properties.Resources.addfile_20x20;
            this.mnuNuevo.Name = "mnuNuevo";
            this.mnuNuevo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.mnuNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuNuevo_ItemClick);
            // 
            // mnuImprimir
            // 
            this.mnuImprimir.Caption = "Imprimir";
            this.mnuImprimir.Id = 2;
            this.mnuImprimir.ImageOptions.Image = global::wfaIntersem.Properties.Resources.print_20x20;
            this.mnuImprimir.Name = "mnuImprimir";
            this.mnuImprimir.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.mnuImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuImprimir_ItemClick);
            // 
            // mnuExportar
            // 
            this.mnuExportar.Caption = "Exportar";
            this.mnuExportar.Id = 1;
            this.mnuExportar.ImageOptions.Image = global::wfaIntersem.Properties.Resources.export_20x20;
            this.mnuExportar.Name = "mnuExportar";
            this.mnuExportar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.mnuExportar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.mnuSalir.Caption = "Salir";
            this.mnuSalir.Id = 3;
            this.mnuSalir.ImageOptions.Image = global::wfaIntersem.Properties.Resources.close_20x20;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barProgreso)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Barra de estado";
            // 
            // barProgreso
            // 
            this.barProgreso.Caption = "barEditItem1";
            this.barProgreso.Edit = this.repositoryItemMarqueeProgressBar1;
            this.barProgreso.EditValue = "Procesando...";
            this.barProgreso.EditWidth = 182;
            this.barProgreso.Id = 4;
            this.barProgreso.Name = "barProgreso";
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
            this.barDockControlTop.Size = new System.Drawing.Size(851, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 427);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(851, 19);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 396);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(851, 31);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 396);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 31);
            this.panelControl1.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(993, 46);
            this.panelControl1.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(21, 10);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Empleados";
            // 
            // grdDetalle
            // 
            this.grdDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDetalle.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.grdDetalle.Location = new System.Drawing.Point(0, 81);
            this.grdDetalle.MainView = this.grvDetalle;
            this.grdDetalle.Margin = new System.Windows.Forms.Padding(5);
            this.grdDetalle.MenuManager = this.barManager1;
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdAcciones,
            this.memoDomicilio});
            this.grdDetalle.Size = new System.Drawing.Size(993, 448);
            this.grdDetalle.TabIndex = 5;
            this.grdDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDetalle});
            // 
            // grvDetalle
            // 
            this.grvDetalle.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightBlue;
            this.grvDetalle.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.grvDetalle.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grvDetalle.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grvDetalle.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grvDetalle.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvDetalle.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.grvDetalle.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grvDetalle.Appearance.Row.Options.UseTextOptions = true;
            this.grvDetalle.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grvDetalle.AutoFillColumn = this.cNombreCompleto;
            this.grvDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cIdDetalle,
            this.cNombreCompleto,
            this.cRfc,
            this.cCurp,
            this.cJornada,
            this.cUsuario,
            this.cCelular,
            this.cCorreo,
            this.cAlergias,
            this.cDomicilio,
            this.cPerfil,
            this.cGrupoSanguineo,
            this.cAcciones});
            this.grvDetalle.DetailHeight = 554;
            this.grvDetalle.GridControl = this.grdDetalle;
            this.grvDetalle.Name = "grvDetalle";
            this.grvDetalle.OptionsFind.AlwaysVisible = true;
            this.grvDetalle.OptionsNavigation.EnterMoveNextColumn = true;
            this.grvDetalle.OptionsNavigation.UseTabKey = false;
            this.grvDetalle.OptionsView.ColumnAutoWidth = false;
            this.grvDetalle.OptionsView.EnableAppearanceEvenRow = true;
            this.grvDetalle.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            this.grvDetalle.OptionsView.ShowFooter = true;
            this.grvDetalle.OptionsView.ShowGroupPanel = false;
            this.grvDetalle.OptionsView.ShowViewCaption = true;
            this.grvDetalle.ViewCaption = "Detalle";
            this.grvDetalle.DoubleClick += new System.EventHandler(this.grvDetalle_DoubleClick);
            // 
            // cNombreCompleto
            // 
            this.cNombreCompleto.Caption = "Nombre";
            this.cNombreCompleto.FieldName = "nombre_completo";
            this.cNombreCompleto.MinWidth = 33;
            this.cNombreCompleto.Name = "cNombreCompleto";
            this.cNombreCompleto.OptionsColumn.ReadOnly = true;
            this.cNombreCompleto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "descripcion", "{0:##,##0}")});
            this.cNombreCompleto.Visible = true;
            this.cNombreCompleto.VisibleIndex = 0;
            this.cNombreCompleto.Width = 196;
            // 
            // cIdDetalle
            // 
            this.cIdDetalle.Caption = "id_detalle";
            this.cIdDetalle.FieldName = "id";
            this.cIdDetalle.MinWidth = 33;
            this.cIdDetalle.Name = "cIdDetalle";
            this.cIdDetalle.OptionsColumn.ReadOnly = true;
            this.cIdDetalle.Width = 125;
            // 
            // cRfc
            // 
            this.cRfc.Caption = "RFC";
            this.cRfc.FieldName = "rfc";
            this.cRfc.MinWidth = 21;
            this.cRfc.Name = "cRfc";
            this.cRfc.OptionsColumn.AllowEdit = false;
            this.cRfc.Visible = true;
            this.cRfc.VisibleIndex = 1;
            this.cRfc.Width = 142;
            // 
            // cCurp
            // 
            this.cCurp.Caption = "CURP";
            this.cCurp.FieldName = "curp";
            this.cCurp.MinWidth = 21;
            this.cCurp.Name = "cCurp";
            this.cCurp.OptionsColumn.AllowEdit = false;
            this.cCurp.Visible = true;
            this.cCurp.VisibleIndex = 2;
            this.cCurp.Width = 157;
            // 
            // cJornada
            // 
            this.cJornada.Caption = "Tipo Jornada";
            this.cJornada.FieldName = "tipo_jornada";
            this.cJornada.MinWidth = 21;
            this.cJornada.Name = "cJornada";
            this.cJornada.OptionsColumn.AllowEdit = false;
            this.cJornada.Visible = true;
            this.cJornada.VisibleIndex = 3;
            this.cJornada.Width = 114;
            // 
            // cUsuario
            // 
            this.cUsuario.Caption = "Usuario";
            this.cUsuario.FieldName = "usuario";
            this.cUsuario.MinWidth = 33;
            this.cUsuario.Name = "cUsuario";
            this.cUsuario.OptionsColumn.ReadOnly = true;
            this.cUsuario.Visible = true;
            this.cUsuario.VisibleIndex = 4;
            this.cUsuario.Width = 129;
            // 
            // cCelular
            // 
            this.cCelular.Caption = "Celular";
            this.cCelular.FieldName = "celular";
            this.cCelular.Name = "cCelular";
            this.cCelular.OptionsColumn.AllowEdit = false;
            this.cCelular.Visible = true;
            this.cCelular.VisibleIndex = 6;
            // 
            // cCorreo
            // 
            this.cCorreo.Caption = "Correo";
            this.cCorreo.FieldName = "correo";
            this.cCorreo.MinWidth = 21;
            this.cCorreo.Name = "cCorreo";
            this.cCorreo.OptionsColumn.ReadOnly = true;
            this.cCorreo.Width = 81;
            // 
            // cAlergias
            // 
            this.cAlergias.Caption = "Alergias";
            this.cAlergias.FieldName = "alergias";
            this.cAlergias.Name = "cAlergias";
            this.cAlergias.OptionsColumn.AllowEdit = false;
            this.cAlergias.Visible = true;
            this.cAlergias.VisibleIndex = 8;
            // 
            // cDomicilio
            // 
            this.cDomicilio.Caption = "Domicilio";
            this.cDomicilio.ColumnEdit = this.memoDomicilio;
            this.cDomicilio.FieldName = "domicilio";
            this.cDomicilio.Name = "cDomicilio";
            this.cDomicilio.OptionsColumn.ReadOnly = true;
            this.cDomicilio.Visible = true;
            this.cDomicilio.VisibleIndex = 9;
            // 
            // memoDomicilio
            // 
            this.memoDomicilio.AutoHeight = false;
            this.memoDomicilio.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.memoDomicilio.Name = "memoDomicilio";
            // 
            // cPerfil
            // 
            this.cPerfil.Caption = "Perfil";
            this.cPerfil.FieldName = "perfil";
            this.cPerfil.Name = "cPerfil";
            this.cPerfil.OptionsColumn.ReadOnly = true;
            this.cPerfil.Visible = true;
            this.cPerfil.VisibleIndex = 5;
            this.cPerfil.Width = 94;
            // 
            // cGrupoSanguineo
            // 
            this.cGrupoSanguineo.AppearanceCell.Options.UseTextOptions = true;
            this.cGrupoSanguineo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cGrupoSanguineo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cGrupoSanguineo.Caption = "Tipo Sangre";
            this.cGrupoSanguineo.FieldName = "tipo_sangre";
            this.cGrupoSanguineo.Name = "cGrupoSanguineo";
            this.cGrupoSanguineo.OptionsColumn.AllowEdit = false;
            this.cGrupoSanguineo.Visible = true;
            this.cGrupoSanguineo.VisibleIndex = 7;
            // 
            // cAcciones
            // 
            this.cAcciones.ColumnEdit = this.cmdAcciones;
            this.cAcciones.FieldName = "Acciones";
            this.cAcciones.MinWidth = 33;
            this.cAcciones.Name = "cAcciones";
            this.cAcciones.Visible = true;
            this.cAcciones.VisibleIndex = 10;
            this.cAcciones.Width = 113;
            // 
            // cmdAcciones
            // 
            this.cmdAcciones.AutoHeight = false;
            editorButtonImageOptions1.Image = global::wfaIntersem.Properties.Resources.edit_16x16;
            toolTipTitleItem1.Appearance.Image = global::wfaIntersem.Properties.Resources.edit_16x16;
            toolTipTitleItem1.Appearance.Options.UseImage = true;
            toolTipTitleItem1.ImageOptions.Image = global::wfaIntersem.Properties.Resources.edit_16x16;
            toolTipTitleItem1.Text = "Editar";
            superToolTip1.Items.Add(toolTipTitleItem1);
            editorButtonImageOptions2.Image = global::wfaIntersem.Properties.Resources.delete_16x16;
            toolTipTitleItem2.Appearance.Image = global::wfaIntersem.Properties.Resources.delete_16x16;
            toolTipTitleItem2.Appearance.Options.UseImage = true;
            toolTipTitleItem2.ImageOptions.Image = global::wfaIntersem.Properties.Resources.delete_16x16;
            toolTipTitleItem2.Text = "Eliminar";
            superToolTip2.Items.Add(toolTipTitleItem2);
            this.cmdAcciones.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", 1, superToolTip1, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", 2, superToolTip2, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdAcciones.Name = "cmdAcciones";
            this.cmdAcciones.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cmdAcciones.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdAcciones_ButtonClick);
            // 
            // backwDatos
            // 
            this.backwDatos.WorkerReportsProgress = true;
            this.backwDatos.WorkerSupportsCancellation = true;
            this.backwDatos.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backwDatos_DoWork);
            this.backwDatos.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backwDatos_ProgressChanged);
            this.backwDatos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backwDatos_RunWorkerCompleted);
            // 
            // frmEmpleadosP
            // 
            this.ActiveGlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 446);
            this.Controls.Add(this.grdDetalle);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmEmpleadosP.IconOptions.SvgImage")));
            this.Name = "frmEmpleadosP";
            this.Text = "Empleados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCatalogoP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDomicilio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAcciones)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem mnuNuevo;
        private DevExpress.XtraBars.BarButtonItem mnuExportar;
        private DevExpress.XtraBars.BarButtonItem mnuImprimir;
        private DevExpress.XtraBars.BarButtonItem mnuSalir;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grdDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn cIdDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn cNombreCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn cAcciones;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdAcciones;
        private DevExpress.XtraBars.BarEditItem barProgreso;
        private DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar1;
        private System.ComponentModel.BackgroundWorker backwDatos;
        private DevExpress.XtraGrid.Columns.GridColumn cUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn cCorreo;
        private DevExpress.XtraGrid.Columns.GridColumn cPerfil;
        private DevExpress.XtraGrid.Columns.GridColumn cCelular;
        private DevExpress.XtraGrid.Columns.GridColumn cGrupoSanguineo;
        private DevExpress.XtraGrid.Columns.GridColumn cAlergias;
        private DevExpress.XtraGrid.Columns.GridColumn cDomicilio;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit memoDomicilio;
        private DevExpress.XtraGrid.Columns.GridColumn cRfc;
        private DevExpress.XtraGrid.Columns.GridColumn cCurp;
        private DevExpress.XtraGrid.Columns.GridColumn cJornada;
    }
}