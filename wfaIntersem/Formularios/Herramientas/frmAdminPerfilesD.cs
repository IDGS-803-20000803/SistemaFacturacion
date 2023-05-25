using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace wfaIntersem
{
    public partial class frmAdminPerfilesD : DevExpress.XtraEditors.XtraForm
    {
        int intPerfil, intId;//, intFormulario = 2, idFormulario, idProceso, idMenu;
        DataTable dtMenus = new DataTable();//, dtMenusAsignados = new DataTable();
        public frmAdminPerfilesD()
        {
            InitializeComponent();
        }

        private void frmUsuarioEditar_Load(object sender, EventArgs e)
        {
            CrearTablas();
            dtMenus = Modulo.cBP.Seleccionar("CALL SP_MENUS_PERFILES_SELECCIONAR(" + intPerfil + ")");
            grdMenu.DataSource = dtMenus;
        }

        public void Combos()
        {
        }

        public void CrearTablas()
        {
            dtMenus.Columns.Add("idMenu", typeof(int));
            dtMenus.Columns.Add("idMenuPerfil", typeof(int));
            dtMenus.Columns.Add("menu", typeof(string));
            dtMenus.Columns.Add("acceso", typeof(int));
        }

        public int EditarPerfil(int id)
        {
            intPerfil = id;
            this.ShowDialog();
            return intId;
        }


        private void mnuSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void grvMenu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
        }

        private void repositoryItemCheckEdit2_CheckedChanged(object sender, EventArgs e)
        {
            dtMenus.Rows[grvMenu.FocusedRowHandle]["acceso"] = (dtMenus.Rows[grvMenu.FocusedRowHandle]["acceso"].ToString() == "1") ? 0 : 1;
            dtMenus.AcceptChanges();
            BE.ADMINMENUSBE objBE = new BE.ADMINMENUSBE();
            objBE.IdMenu = int.Parse(grvMenu.GetRowCellValue(grvMenu.FocusedRowHandle, cIdMenu).ToString());
            objBE.IdPerfil = intPerfil;
            objBE.Acceso = Modulo.ConvertInt(grvMenu.GetRowCellValue(grvMenu.FocusedRowHandle, cAcceso).ToString());
            int resultado = new BP.ADMINMENUSBP().ActualizarMenuPerfil(objBE);
            if (resultado > 0)
            {
                Modulo.Alertar.MuestraAlerta(1, this);
            }
        }
    }
}
