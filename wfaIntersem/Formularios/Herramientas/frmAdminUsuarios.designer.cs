namespace wfaIntersem
{
    partial class frmAdminUsuarios
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barMenu = new DevExpress.XtraBars.Bar();
            this.mnuImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSalir = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.cmdAcciones = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.grvDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cIdDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cAcciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdDetalle = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAcciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(14, 7);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(262, 23);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Administración de Usuarios";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 35);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1445, 48);
            this.panelControl1.TabIndex = 6;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barMenu});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mnuImprimir,
            this.mnuSalir});
            this.barManager1.MainMenu = this.barMenu;
            this.barManager1.MaxItemId = 5;
            // 
            // barMenu
            // 
            this.barMenu.BarName = "Menú principal";
            this.barMenu.DockCol = 0;
            this.barMenu.DockRow = 0;
            this.barMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuImprimir),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSalir, true)});
            this.barMenu.OptionsBar.MultiLine = true;
            this.barMenu.OptionsBar.UseWholeRow = true;
            this.barMenu.Text = "Menú principal";
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
            // mnuSalir
            // 
            this.mnuSalir.Caption = "Salir";
            this.mnuSalir.Id = 3;
            this.mnuSalir.ImageOptions.Image = global::wfaIntersem.Properties.Resources.close_20x20;
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.mnuSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSalir_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1445, 35);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 619);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1445, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 35);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 584);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1445, 35);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 584);
            // 
            // cmdAcciones
            // 
            this.cmdAcciones.AutoHeight = false;
            editorButtonImageOptions1.Image = global::wfaIntersem.Properties.Resources.edit_16x16;
            toolTipTitleItem1.Appearance.Image = global::wfaIntersem.Properties.Resources.edit_16x16;
            toolTipTitleItem1.Appearance.Options.UseImage = true;
            toolTipTitleItem1.ImageOptions.Image = global::wfaIntersem.Properties.Resources.edit_16x16;
            toolTipTitleItem1.Text = "Editar Menús";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.cmdAcciones.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", 1, superToolTip1, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cmdAcciones.Name = "cmdAcciones";
            this.cmdAcciones.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmdAcciones.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cmdAcciones_ButtonClick);
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
            this.grvDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cIdDetalle,
            this.cNombre,
            this.cAcciones,
            this.cUsuario});
            this.grvDetalle.DetailHeight = 431;
            this.grvDetalle.GridControl = this.grdDetalle;
            this.grvDetalle.Name = "grvDetalle";
            this.grvDetalle.OptionsFind.AlwaysVisible = true;
            this.grvDetalle.OptionsNavigation.EnterMoveNextColumn = true;
            this.grvDetalle.OptionsNavigation.UseTabKey = false;
            this.grvDetalle.OptionsView.EnableAppearanceEvenRow = true;
            this.grvDetalle.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            this.grvDetalle.OptionsView.ShowFooter = true;
            this.grvDetalle.OptionsView.ShowGroupPanel = false;
            this.grvDetalle.OptionsView.ShowViewCaption = true;
            this.grvDetalle.ViewCaption = "Detalle";
            // 
            // cIdDetalle
            // 
            this.cIdDetalle.Caption = "id_detalle";
            this.cIdDetalle.FieldName = "id_usuario";
            this.cIdDetalle.MinWidth = 23;
            this.cIdDetalle.Name = "cIdDetalle";
            this.cIdDetalle.OptionsColumn.AllowEdit = false;
            this.cIdDetalle.Width = 87;
            // 
            // cNombre
            // 
            this.cNombre.Caption = "Nombre";
            this.cNombre.FieldName = "nombre";
            this.cNombre.MinWidth = 23;
            this.cNombre.Name = "cNombre";
            this.cNombre.OptionsColumn.AllowEdit = false;
            this.cNombre.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "descripcion", "{0:##,##0}")});
            this.cNombre.Visible = true;
            this.cNombre.VisibleIndex = 0;
            this.cNombre.Width = 317;
            // 
            // cAcciones
            // 
            this.cAcciones.ColumnEdit = this.cmdAcciones;
            this.cAcciones.MinWidth = 23;
            this.cAcciones.Name = "cAcciones";
            this.cAcciones.Visible = true;
            this.cAcciones.VisibleIndex = 2;
            this.cAcciones.Width = 79;
            // 
            // cUsuario
            // 
            this.cUsuario.Caption = "Usuario";
            this.cUsuario.FieldName = "usuario";
            this.cUsuario.MinWidth = 23;
            this.cUsuario.Name = "cUsuario";
            this.cUsuario.OptionsColumn.AllowEdit = false;
            this.cUsuario.Visible = true;
            this.cUsuario.VisibleIndex = 1;
            this.cUsuario.Width = 213;
            // 
            // grdDetalle
            // 
            this.grdDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDetalle.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdDetalle.Location = new System.Drawing.Point(0, 83);
            this.grdDetalle.MainView = this.grvDetalle;
            this.grdDetalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmdAcciones});
            this.grdDetalle.Size = new System.Drawing.Size(1445, 536);
            this.grdDetalle.TabIndex = 7;
            this.grdDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDetalle});
            // 
            // frmAdminUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 619);
            this.Controls.Add(this.grdDetalle);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAdminUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administración de Menús de Usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUsuarios_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmUsuarios_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAcciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar barMenu;
        private DevExpress.XtraBars.BarButtonItem mnuImprimir;
        private DevExpress.XtraBars.BarButtonItem mnuSalir;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl grdDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn cIdDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn cNombre;
        private DevExpress.XtraGrid.Columns.GridColumn cAcciones;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit cmdAcciones;
        private DevExpress.XtraGrid.Columns.GridColumn cUsuario;
    }
}