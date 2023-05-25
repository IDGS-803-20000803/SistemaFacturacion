using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace wfaIntersem
{
    public partial class frmEmpleadosP : DevExpress.XtraEditors.XtraForm
    {
        int intPermiso = 7;
        public frmEmpleadosP()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.ExportarExcel(grvDetalle);
        }

        private void frmCatalogoP_Load(object sender, EventArgs e)
        {
            backwDatos.RunWorkerAsync(1);
        }

        private void CargarGrid()
        {
            DataTable dtDatos = new DataTable();
            dtDatos = Modulo.cBP.Seleccionar("CALL SP_EMPLEADO_SELECCIONAR(null)");
            grdDetalle.DataSource = dtDatos;
            grvDetalle.BestFitColumns();
        }

        private void mnuSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void backwDatos_DoWork(object sender, DoWorkEventArgs e)
        {
           switch(e.Argument.ToString())
            {
                case "1":
                    backwDatos.ReportProgress(1);
                    break;
            }
        }

        private void backwDatos_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch(e.ProgressPercentage)
            {
                case 1:
                    CargarGrid();
                    break;
            }

        }

        private void backwDatos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            barProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }

        private void mnuNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEmpleadosD fDetalle = new frmEmpleadosD();
            if (fDetalle.NuevoDetalle(7) == true)
            {
                backwDatos.RunWorkerAsync(1);
            }

        }

        private void grvDetalle_DoubleClick(object sender, EventArgs e)
        {
            frmEmpleadosD fDetalle = new frmEmpleadosD();
            if (fDetalle.ConsultarDetalle(int.Parse(grvDetalle.GetRowCellValue(grvDetalle.FocusedRowHandle, cIdDetalle).ToString()), 7))
            {
                backwDatos.RunWorkerAsync(1);
            }

        }

        private void mnuImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.ImprimirCuadriculaGrid(grdDetalle, "Listado de Empleados", 0);
        }

        private void cmdAcciones_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Tag.ToString())
            {

                case "1":
                    frmEmpleadosD fDetalle = new frmEmpleadosD();
                    if (fDetalle.EditarDetalle(int.Parse(grvDetalle.GetRowCellValue(grvDetalle.FocusedRowHandle, cIdDetalle).ToString()), intPermiso) == true)
                        backwDatos.RunWorkerAsync(1);
                    break;
                case "2":
                    if (MessageBox.Show("¿Esta seguro de eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int intResultado;
                        BE.EmpleadosBE objBE = new BE.EmpleadosBE();
                        BP.EmpleadosBP objBP = new BP.EmpleadosBP();
                        objBE.id = int.Parse(grvDetalle.GetRowCellValue(grvDetalle.FocusedRowHandle, cIdDetalle).ToString());
                        objBE.id_usuario = Modulo.IdUsuario;
                        intResultado = objBP.Eliminar(objBE);
                        grvDetalle.DeleteRow(grvDetalle.FocusedRowHandle);
                    }
                    break;
            }

        }

       
    }
}