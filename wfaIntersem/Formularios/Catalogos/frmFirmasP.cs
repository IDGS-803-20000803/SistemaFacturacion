using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace wfaIntersem
{
    public partial class frmFirmasP : DevExpress.XtraEditors.XtraForm
    {
        int intPermiso = 7;
        public frmFirmasP()
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
            dtDatos = Modulo.GetDataTable("CALL SP_FIRMAS_SELECCIONAR(null)");
            grdDetalle.DataSource = dtDatos;
            grvDetalle.BestFitColumns();
        }

        private void mnuSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void backwDatos_DoWork(object sender, DoWorkEventArgs e)
        {
            switch (e.Argument.ToString())
            {
                case "1":
                    backwDatos.ReportProgress(1);
                    break;
            }

        }

        private void backwDatos_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch (e.ProgressPercentage)
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
            frmFirmasD fDetalle = new frmFirmasD();
            if (fDetalle.NuevoDetalle(7) == true)
            {
                backwDatos.RunWorkerAsync(1);
            }
        }

        private void grvDetalle_DoubleClick(object sender, EventArgs e)
        {
            frmFirmasD fDetalle = new frmFirmasD();
            if (fDetalle.ConsultarDetalle(int.Parse(grvDetalle.GetRowCellValue(grvDetalle.FocusedRowHandle, cId).ToString()), 7))
                backwDatos.RunWorkerAsync(1);
        }

        private void mnuImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.ImprimirCuadriculaGrid(grdDetalle, "Listado de Firmas", 0);
        }

        private void cmdAcciones_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Tag.ToString())
            {

                case "1":
                    frmFirmasD fDetalle = new frmFirmasD();
                    if (fDetalle.EditarDetalle(int.Parse(grvDetalle.GetRowCellValue(grvDetalle.FocusedRowHandle, cId).ToString()), intPermiso) == true)
                        backwDatos.RunWorkerAsync(1);
                    break;
                case "2":
                    if (MessageBox.Show("¿Esta seguro de eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int intResultado;
                        BE.FirmasBE objBE = new BE.FirmasBE();
                        BP.FirmasBP objBP = new BP.FirmasBP();
                        objBE.Id = int.Parse(grvDetalle.GetRowCellValue(grvDetalle.FocusedRowHandle, cId).ToString());
                        objBE.IdUsuario = Modulo.IdUsuario;
                        intResultado = objBP.Eliminar(objBE);
                        if (intResultado > 0)
                        {
                            grvDetalle.DeleteRow(grvDetalle.FocusedRowHandle);
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error, contacta al personal de sistema", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    break;
            }

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void grdDetalle_Click(object sender, EventArgs e)
        {

        }
    }
}