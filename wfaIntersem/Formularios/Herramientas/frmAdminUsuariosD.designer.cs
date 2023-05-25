namespace wfaIntersem
{
    partial class frmAdminPerfiles
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkConsultSelectAll = new DevExpress.XtraEditors.CheckEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.mnuImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSalir = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.chkEditSelectAll = new DevExpress.XtraEditors.CheckEdit();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnIdMenu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnIdMenuUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnConsultar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumnEditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.cCheckout = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.cPreciosServicios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.cModificarPorcentajes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.barMenu = new DevExpress.XtraBars.Bar();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkConsultSelectAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEditSelectAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit5)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(282, 48);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.MaxLength = 40;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(322, 31);
            this.txtNombre.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label3.Location = new System.Drawing.Point(281, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(630, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(633, 48);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(248, 31);
            this.txtUsuario.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1513, 91);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(7, 48);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.MaxLength = 40;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(248, 31);
            this.txtID.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(7, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Id:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkConsultSelectAll);
            this.groupBox3.Controls.Add(this.chkEditSelectAll);
            this.groupBox3.Controls.Add(this.grid);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 126);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(1513, 706);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Menús";
            // 
            // chkConsultSelectAll
            // 
            this.chkConsultSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkConsultSelectAll.Location = new System.Drawing.Point(567, 63);
            this.chkConsultSelectAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkConsultSelectAll.MenuManager = this.barManager1;
            this.chkConsultSelectAll.Name = "chkConsultSelectAll";
            this.chkConsultSelectAll.Properties.Caption = "checkEdit1";
            this.chkConsultSelectAll.Size = new System.Drawing.Size(23, 24);
            this.chkConsultSelectAll.TabIndex = 27;
            this.chkConsultSelectAll.CheckedChanged += new System.EventHandler(this.chkConsultSelectAll_CheckedChanged);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mnuImprimir,
            this.mnuSalir});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Menú principal";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuImprimir),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSalir, true)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Menú principal";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1513, 35);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 832);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1513, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 35);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 797);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1513, 35);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 797);
            // 
            // chkEditSelectAll
            // 
            this.chkEditSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkEditSelectAll.Location = new System.Drawing.Point(853, 63);
            this.chkEditSelectAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkEditSelectAll.MenuManager = this.barManager1;
            this.chkEditSelectAll.Name = "chkEditSelectAll";
            this.chkEditSelectAll.Properties.Caption = "checkEdit1";
            this.chkEditSelectAll.Size = new System.Drawing.Size(23, 24);
            this.chkEditSelectAll.TabIndex = 26;
            this.chkEditSelectAll.CheckedChanged += new System.EventHandler(this.chkEditSelectAll_CheckedChanged);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grid.Location = new System.Drawing.Point(3, 20);
            this.grid.MainView = this.gridView1;
            this.grid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2,
            this.repositoryItemCheckEdit3,
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit4,
            this.repositoryItemCheckEdit5});
            this.grid.Size = new System.Drawing.Size(1507, 682);
            this.grid.TabIndex = 1;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightBlue;
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnIdMenu,
            this.gridColumnIdMenuUsuario,
            this.gridColumnDescripcion,
            this.gridColumnConsultar,
            this.gridColumnEditar,
            this.cCheckout,
            this.cPreciosServicios,
            this.cModificarPorcentajes});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.grid;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumnIdMenu
            // 
            this.gridColumnIdMenu.Caption = "IdMenu";
            this.gridColumnIdMenu.FieldName = "idmenu";
            this.gridColumnIdMenu.MinWidth = 23;
            this.gridColumnIdMenu.Name = "gridColumnIdMenu";
            this.gridColumnIdMenu.Width = 87;
            // 
            // gridColumnIdMenuUsuario
            // 
            this.gridColumnIdMenuUsuario.Caption = "Id";
            this.gridColumnIdMenuUsuario.FieldName = "IdMenuUsuario";
            this.gridColumnIdMenuUsuario.MinWidth = 23;
            this.gridColumnIdMenuUsuario.Name = "gridColumnIdMenuUsuario";
            this.gridColumnIdMenuUsuario.Width = 87;
            // 
            // gridColumnDescripcion
            // 
            this.gridColumnDescripcion.Caption = "Menú";
            this.gridColumnDescripcion.FieldName = "descripcion";
            this.gridColumnDescripcion.MinWidth = 23;
            this.gridColumnDescripcion.Name = "gridColumnDescripcion";
            this.gridColumnDescripcion.OptionsColumn.AllowEdit = false;
            this.gridColumnDescripcion.Visible = true;
            this.gridColumnDescripcion.VisibleIndex = 0;
            this.gridColumnDescripcion.Width = 237;
            // 
            // gridColumnConsultar
            // 
            this.gridColumnConsultar.Caption = "Consultar";
            this.gridColumnConsultar.ColumnEdit = this.repositoryItemCheckEdit2;
            this.gridColumnConsultar.FieldName = "Consultar";
            this.gridColumnConsultar.MinWidth = 23;
            this.gridColumnConsultar.Name = "gridColumnConsultar";
            this.gridColumnConsultar.Visible = true;
            this.gridColumnConsultar.VisibleIndex = 1;
            this.gridColumnConsultar.Width = 182;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.Appearance.Options.UseTextOptions = true;
            this.repositoryItemCheckEdit2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.ValueChecked = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repositoryItemCheckEdit2.ValueUnchecked = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.repositoryItemCheckEdit2.CheckedChanged += new System.EventHandler(this.repositoryItemCheckEdit2_CheckedChanged);
            // 
            // gridColumnEditar
            // 
            this.gridColumnEditar.Caption = "Editar";
            this.gridColumnEditar.ColumnEdit = this.repositoryItemCheckEdit3;
            this.gridColumnEditar.FieldName = "Editar";
            this.gridColumnEditar.MinWidth = 23;
            this.gridColumnEditar.Name = "gridColumnEditar";
            this.gridColumnEditar.Visible = true;
            this.gridColumnEditar.VisibleIndex = 2;
            this.gridColumnEditar.Width = 159;
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.Appearance.Options.UseTextOptions = true;
            this.repositoryItemCheckEdit3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            this.repositoryItemCheckEdit3.ValueChecked = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repositoryItemCheckEdit3.ValueUnchecked = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.repositoryItemCheckEdit3.CheckedChanged += new System.EventHandler(this.repositoryItemCheckEdit3_CheckedChanged);
            // 
            // cCheckout
            // 
            this.cCheckout.Caption = "Checkout";
            this.cCheckout.ColumnEdit = this.repositoryItemCheckEdit1;
            this.cCheckout.FieldName = "Checkout";
            this.cCheckout.MinWidth = 23;
            this.cCheckout.Name = "cCheckout";
            this.cCheckout.Width = 215;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemCheckEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repositoryItemCheckEdit1.ValueUnchecked = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.repositoryItemCheckEdit1.CheckedChanged += new System.EventHandler(this.repositoryItemCheckEdit1_CheckedChanged);
            // 
            // cPreciosServicios
            // 
            this.cPreciosServicios.Caption = "Precios de Servicio";
            this.cPreciosServicios.ColumnEdit = this.repositoryItemCheckEdit4;
            this.cPreciosServicios.FieldName = "PreciosServicios";
            this.cPreciosServicios.MinWidth = 23;
            this.cPreciosServicios.Name = "cPreciosServicios";
            this.cPreciosServicios.Width = 87;
            // 
            // repositoryItemCheckEdit4
            // 
            this.repositoryItemCheckEdit4.Appearance.Options.UseTextOptions = true;
            this.repositoryItemCheckEdit4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.repositoryItemCheckEdit4.AutoHeight = false;
            this.repositoryItemCheckEdit4.Name = "repositoryItemCheckEdit4";
            this.repositoryItemCheckEdit4.ValueChecked = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repositoryItemCheckEdit4.ValueUnchecked = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.repositoryItemCheckEdit4.CheckedChanged += new System.EventHandler(this.repositoryItemCheckEdit4_CheckedChanged);
            // 
            // cModificarPorcentajes
            // 
            this.cModificarPorcentajes.Caption = "Modificar Porcentajes";
            this.cModificarPorcentajes.ColumnEdit = this.repositoryItemCheckEdit5;
            this.cModificarPorcentajes.FieldName = "PorcentajesVentas";
            this.cModificarPorcentajes.MinWidth = 23;
            this.cModificarPorcentajes.Name = "cModificarPorcentajes";
            this.cModificarPorcentajes.Width = 87;
            // 
            // repositoryItemCheckEdit5
            // 
            this.repositoryItemCheckEdit5.Appearance.Options.UseTextOptions = true;
            this.repositoryItemCheckEdit5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.repositoryItemCheckEdit5.AutoHeight = false;
            this.repositoryItemCheckEdit5.Name = "repositoryItemCheckEdit5";
            this.repositoryItemCheckEdit5.ValueChecked = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repositoryItemCheckEdit5.ValueUnchecked = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.repositoryItemCheckEdit5.CheckedChanged += new System.EventHandler(this.repositoryItemCheckEdit5_CheckedChanged);
            // 
            // barMenu
            // 
            this.barMenu.BarName = "Menú principal";
            this.barMenu.DockCol = 0;
            this.barMenu.DockRow = 0;
            this.barMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barMenu.OptionsBar.MultiLine = true;
            this.barMenu.OptionsBar.UseWholeRow = true;
            this.barMenu.Text = "Menú principal";
            // 
            // frmAdminPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 832);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAdminPerfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administración de Menús";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUsuarioEditar_Load);
            this.Resize += new System.EventHandler(this.frmUsuarioEditar_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkConsultSelectAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEditSelectAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtID;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIdMenuUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnConsultar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEditar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private DevExpress.XtraBars.Bar barMenu;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem mnuImprimir;
        private DevExpress.XtraBars.BarButtonItem mnuSalir;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIdMenu;
        private DevExpress.XtraEditors.CheckEdit chkEditSelectAll;
        private DevExpress.XtraEditors.CheckEdit chkConsultSelectAll;
        private DevExpress.XtraGrid.Columns.GridColumn cCheckout;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn cPreciosServicios;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit4;
        private DevExpress.XtraGrid.Columns.GridColumn cModificarPorcentajes;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit5;
    }
}