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
    public partial class frmAdminPerfiles : DevExpress.XtraEditors.XtraForm
    {
        public frmAdminPerfiles()
        {
            InitializeComponent();
        }

        private void frmUsuarioEditar_Load(object sender, EventArgs e)
        {
            DataTable dtMenu = new DataTable();
            dtMenu = Modulo.cBP.Seleccionar("CALL SP_MENUS_PERMISOS(" + txtID.Text + ")");
            grid.DataSource = dtMenu;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe capturar el nombre del usuario.", "Datos de usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return;
            }
            if (txtUsuario.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe capturar el login del usuario con el que ingresará al sistema.", "Datos de usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Focus();
                return;
            }
            try
            {
                //if (opcion == Operacion.agregar)
                //{
                //    //if (new Model.UsuarioModel().InsertaUsuario(txtUsuario.Text.Trim(), txtPwd1.Text, txtNombre.Text))
                //    //{
                //        //GuardarMenusUsuario();
                //        Guardado = true;
                //        this.Close();
                //    //}
                //    //else
                //        //MessageBox.Show("No se ha podido insertar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //}
                //else if (opcion == Operacion.editar)
                //{
                //    //if (new Model.UsuarioModel().EditaUsuario(int.Parse(txtID.Text), txtUsuario.Text.Trim(), txtPwd1.Text, txtNombre.Text.Trim()))
                //    //{
                //    //    GuardarMenusUsuario();
                //        this.Close();
                //        Guardado = true;
                //    //}
                //    //else
                //    //    MessageBox.Show("No se ha podido insertar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al intentar editar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void GuardarMenusUsuario()
        {
            //Model.UsuarioMenusModel Menus = new Model.UsuarioMenusModel();
            //Menus.BorraMenusUsuario(Int16.Parse(txtID.Text));
            //foreach (string item in chkMenus.CheckedItems)
            //{
            //    Menus.InsertaMenu(Int16.Parse(txtID.Text), item);
            //}
            //Menus = null;
        }

        private void mnuImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.ImprimirCuadriculaGrid(grid, "Listado de Ménús del Usuario " + txtNombre.Text, 0);
        }

        private void mnuSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void repositoryItemCheckEdit2_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarMenu(true, false, false, false, false, gridView1.FocusedRowHandle);
        }

        private void repositoryItemCheckEdit3_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarMenu(false, true, false, false, false, gridView1.FocusedRowHandle);
        }

        private void repositoryItemCheckEdit1_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarMenu(false, false, true, false, false, gridView1.FocusedRowHandle);
        }

        private void repositoryItemCheckEdit4_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarMenu(false, false, false, true, false, gridView1.FocusedRowHandle);
        }

        private void repositoryItemCheckEdit5_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarMenu(false, false, false, false, true, gridView1.FocusedRowHandle);
        }

        private void ActualizarMenu(bool consultar, bool editar, bool checkout, bool preciosServicios, bool porcentajesVentas, int fila, bool preChangeVal = true)
        {
            BE.ADMINMENUSBE objBE = new BE.ADMINMENUSBE();
            objBE.IdMenu = int.Parse(gridView1.GetRowCellValue(fila, gridColumnIdMenu).ToString());
            objBE.IdUsuario = int.Parse(txtID.Text.ToString());
            /*objBE.Consultar = Int16.Parse(gridView1.GetRowCellValue(fila, gridColumnConsultar).ToString());
            objBE.Editar = Int16.Parse(gridView1.GetRowCellValue(fila, gridColumnEditar).ToString());*/
            if (preChangeVal)
            {
                /*if (consultar) objBE.Consultar = objBE.Consultar == 1 ? (Int16)0 : (Int16)1;
                if (editar) objBE.Editar = objBE.Editar == 1 ? (Int16)0 : (Int16)1;*/
            }

            //new BP.ADMINMENUSBP().Actualizar(objBE);
        }

        private void frmUsuarioEditar_Resize(object sender, EventArgs e)
        {
            if(this.WindowState != FormWindowState.Minimized)
            {
                ReposicionarChecksAll();
            }
        }

        private void ReposicionarChecksAll()
        {
            GridViewInfo gridInfo = (GridViewInfo)gridView1.GetViewInfo();
            var columnInfo = gridInfo.ColumnsInfo[gridColumnEditar];

            if (columnInfo != null)
            {
                var bounds = columnInfo.Bounds;

                chkEditSelectAll.Left = bounds.Left + (bounds.Width / 2) - 5;
                chkEditSelectAll.Top = bounds.Top + 17;
            }

            columnInfo = gridInfo.ColumnsInfo[gridColumnConsultar];

            if (columnInfo != null)
            {
                var bounds = columnInfo.Bounds;

                chkConsultSelectAll.Left = bounds.Left + (bounds.Width / 2) - 5;
                chkConsultSelectAll.Top = bounds.Top + 17;
            }
        }

        private void chkConsultSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            int valor = 0;
            if (chkConsultSelectAll.Checked) valor = 1;
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                gridView1.SetRowCellValue(i, gridColumnConsultar, valor);

                ActualizarMenu(true, false, false, false, false, i, false);
            }
        }

        private void chkEditSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            int valor = 0;
            if (chkEditSelectAll.Checked) valor = 1;
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                gridView1.SetRowCellValue(i, gridColumnEditar, valor);

                ActualizarMenu(false, true, false, false, false, i, false);
            }
        }

    }
}
