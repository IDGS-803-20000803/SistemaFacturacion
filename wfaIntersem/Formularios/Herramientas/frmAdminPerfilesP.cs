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
    public partial class frmAdminPerfilesP : DevExpress.XtraEditors.XtraForm
    {
        public frmAdminPerfilesP()
        {
            InitializeComponent();
        }

        private void ConsultarListaPerfiles()
        {
            grdDetalle.DataSource = Modulo.cBP.Seleccionar("CALL SP_PERFILES_SELECCIONAR(null);");
            grvDetalle.BestFitColumns();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            ConsultarListaPerfiles();
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
            Modulo.ImprimirCuadriculaGrid(grdDetalle, "Listado de Perfiles", 0);
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
            frmAdminPerfilesD EditaUsuario = new frmAdminPerfilesD();
            EditaUsuario.txtPerfil.Text = grvDetalle.GetRowCellValue(grvDetalle.FocusedRowHandle, cPerfil).ToString();
            int intPerfil = Modulo.ConvertInt(grvDetalle.GetRowCellValue(grvDetalle.FocusedRowHandle, cIdDetalle).ToString());
            int intResultado = EditaUsuario.EditarPerfil(intPerfil);
            if (intResultado > 0)
            {
                Modulo.Alertar.MuestraAlerta(1, this);
            }
        }
    }
}
