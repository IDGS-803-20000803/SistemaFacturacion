namespace wfaIntersem
{
    partial class frmLoginP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginP));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmdAceptar = new wfaIntersem.MyButton();
            this.cmdCancelar = new wfaIntersem.MyButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.txtContra = new DevExpress.XtraEditors.TextEdit();
            this.chkRecordar = new DevExpress.XtraEditors.CheckEdit();
            this.cmdBase = new wfaIntersem.MyButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRecordar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.cmdAceptar);
            this.panelControl1.Controls.Add(this.cmdCancelar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(329, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(112, 173);
            this.panelControl1.TabIndex = 0;
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdAceptar.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.cmdAceptar.Appearance.BorderColor = System.Drawing.Color.Black;
            this.cmdAceptar.Appearance.ForeColor = System.Drawing.Color.White;
            this.cmdAceptar.Appearance.Options.UseBackColor = true;
            this.cmdAceptar.Appearance.Options.UseBorderColor = true;
            this.cmdAceptar.Appearance.Options.UseForeColor = true;
            this.cmdAceptar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.cmdAceptar.ImageOptions.Image = global::wfaIntersem.Properties.Resources.arrow_28_50;
            this.cmdAceptar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdAceptar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdAceptar.Location = new System.Drawing.Point(25, 35);
            this.cmdAceptar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.cmdAceptar.Size = new System.Drawing.Size(70, 51);
            this.cmdAceptar.TabIndex = 2;
            this.cmdAceptar.TabStop = false;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdCancelar.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.cmdCancelar.Appearance.BorderColor = System.Drawing.Color.Black;
            this.cmdCancelar.Appearance.ForeColor = System.Drawing.Color.White;
            this.cmdCancelar.Appearance.Options.UseBackColor = true;
            this.cmdCancelar.Appearance.Options.UseBorderColor = true;
            this.cmdCancelar.Appearance.Options.UseForeColor = true;
            this.cmdCancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancelar.ImageOptions.Image = global::wfaIntersem.Properties.Resources.x_mark_4_36;
            this.cmdCancelar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdCancelar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdCancelar.Location = new System.Drawing.Point(25, 108);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.cmdCancelar.Size = new System.Drawing.Size(70, 51);
            this.cmdCancelar.TabIndex = 2;
            this.cmdCancelar.TabStop = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 25);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "LOGIN";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(317, 18);
            this.labelControl2.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.LineVisible = true;
            this.labelControl3.Location = new System.Drawing.Point(179, 70);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 14);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Contraseña:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.LineVisible = true;
            this.labelControl4.Location = new System.Drawing.Point(19, 70);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 14);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(19, 92);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Size = new System.Drawing.Size(120, 22);
            this.txtUsuario.TabIndex = 5;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextEdit_KeyDown);
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(179, 92);
            this.txtContra.Name = "txtContra";
            this.txtContra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtContra.Properties.Appearance.Options.UseFont = true;
            this.txtContra.Properties.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(120, 22);
            this.txtContra.TabIndex = 6;
            this.txtContra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextEdit_KeyDown);
            // 
            // chkRecordar
            // 
            this.chkRecordar.Location = new System.Drawing.Point(19, 140);
            this.chkRecordar.Name = "chkRecordar";
            this.chkRecordar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.chkRecordar.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.chkRecordar.Properties.Appearance.Options.UseFont = true;
            this.chkRecordar.Properties.Appearance.Options.UseForeColor = true;
            this.chkRecordar.Properties.Caption = "Recordarme";
            this.chkRecordar.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.chkRecordar.Size = new System.Drawing.Size(120, 20);
            this.chkRecordar.TabIndex = 7;
            // 
            // cmdBase
            // 
            this.cmdBase.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmdBase.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.cmdBase.Appearance.BorderColor = System.Drawing.Color.Black;
            this.cmdBase.Appearance.ForeColor = System.Drawing.Color.White;
            this.cmdBase.Appearance.Options.UseBackColor = true;
            this.cmdBase.Appearance.Options.UseBorderColor = true;
            this.cmdBase.Appearance.Options.UseForeColor = true;
            this.cmdBase.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.cmdBase.ImageOptions.Image = global::wfaIntersem.Properties.Resources.data_configuration1_24;
            this.cmdBase.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.cmdBase.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdBase.Location = new System.Drawing.Point(266, 138);
            this.cmdBase.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.cmdBase.Name = "cmdBase";
            this.cmdBase.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.cmdBase.Size = new System.Drawing.Size(53, 30);
            this.cmdBase.TabIndex = 8;
            this.cmdBase.TabStop = false;
            this.cmdBase.Click += new System.EventHandler(this.cmdBase_Click);
            // 
            // frmLoginP
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 173);
            this.ControlBox = false;
            this.Controls.Add(this.cmdBase);
            this.Controls.Add(this.chkRecordar);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmLoginP.IconOptions.Icon")));
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmLoginP.IconOptions.Image")));
            this.Name = "frmLoginP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLoginP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRecordar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.TextEdit txtContra;
        private MyButton cmdAceptar;
        private MyButton cmdCancelar;
        private DevExpress.XtraEditors.CheckEdit chkRecordar;
        private MyButton cmdBase;
    }
}