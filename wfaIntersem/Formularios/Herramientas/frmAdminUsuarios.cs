using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wfaIntersem
{
    public partial class frmAdminUsuarios : DevExpress.XtraEditors.XtraForm
    {
        public frmAdminUsuarios()
        {
            InitializeComponent();
        }

        private void ConsultarListaUsuarios()
        {
            grdDetalle.DataSource = Modulo.cBP.Seleccionar("CALL SP_USUARIOS_SELECCIONAR(null);");
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            ConsultarListaUsuarios();
        }        

        private void frmUsuarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                e.Handled = true;
                this.Close();
                this.Dispose();
            }
        }

        private void gridUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.F2)
            {
                e.Handled = true;
                EditarMenus();
            }
        }

        private void gridUsuarios_DoubleClick(object sender, EventArgs e)
        {
            EditarMenus();
        }

        private void frmUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                this.Dispose();
            }
        }

        private void mnuImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.ImprimirCuadriculaGrid(grdDetalle, "Listado de Usuarios", 0);
        }

        private void mnuSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void cmdAcciones_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Tag.ToString())
            {
                case "1":
                    EditarMenus();
                    break;
            }
        }

        private void EditarMenus ()
        {
            if (grvDetalle.SelectedRowsCount == 0) return;
            frmAdminPerfiles EditaUsuario = new frmAdminPerfiles();
            EditaUsuario.txtUsuario.Text = grvDetalle.GetRowCellValue(grvDetalle.FocusedRowHandle, cUsuario).ToString();
            EditaUsuario.txtNombre.Text = grvDetalle.GetRowCellValue(grvDetalle.FocusedRowHandle, cNombre).ToString();
            EditaUsuario.txtID.Text = grvDetalle.GetRowCellValue(grvDetalle.FocusedRowHandle, cIdDetalle).ToString();
            EditaUsuario.ShowDialog();
            
            EditaUsuario.Dispose();
            EditaUsuario = null;
        }
    }
}
