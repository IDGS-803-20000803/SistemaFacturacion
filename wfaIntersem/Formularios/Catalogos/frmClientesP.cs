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
    public partial class frmClientesP : DevExpress.XtraEditors.XtraForm
    {
        int intPermiso = 7;
        public frmClientesP()
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
            dtDatos = Modulo.cBP.Seleccionar("CALL SP_CLIENTES_SELECCIONAR(null, null)");
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
            grvDetalle.BestFitColumns();
        }

        private void mnuNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmClientesD fDetalle = new frmClientesD();
            if (fDetalle.NuevoDetalle(7) == true)
            {
                backwDatos.RunWorkerAsync(1);
            }

        }

        private void grvDetalle_DoubleClick(object sender, EventArgs e)
        {
            if (grvDetalle.DataRowCount > 0)
            {
                frmClientesD fDetalle = new frmClientesD();
                if (fDetalle.ConsultarDetalle(int.Parse(grvDetalle.GetRowCellValue(grvDetalle.FocusedRowHandle, cIdDetalle).ToString(), Modulo.culture), 7))
                    backwDatos.RunWorkerAsync(1);
            }
        }

        private void mnuImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.ImprimirCuadriculaGrid(grdDetalle, "Listado de Clientes", 0);
        }

        

        private void cmdAcciones_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Tag.ToString())
            {

                case "1":
                    frmClientesD fDetalle = new frmClientesD();
                    if (fDetalle.EditarDetalle(int.Parse(grvDetalle.GetRowCellValue(grvDetalle.FocusedRowHandle, cIdDetalle).ToString(), Modulo.culture), intPermiso) == true)
                        backwDatos.RunWorkerAsync(1);
                    break;
                case "2":
                    if (MessageBox.Show("¿Esta seguro de eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        
                            int intResultado;
                            BE.ClientesBE objDatosBE = new BE.ClientesBE();
                            BP.ClientesBP objDatosBP = new BP.ClientesBP();

                            objDatosBE.Id = int.Parse(grvDetalle.GetRowCellValue(grvDetalle.FocusedRowHandle, cIdDetalle).ToString(), Modulo.culture);
                            objDatosBE.Id_usuario = Modulo.IdUsuario;

                            intResultado = objDatosBP.Eliminar(objDatosBE);

                            if (intResultado > 0)
                            {
                                CargarGrid();
                            }
                         
                    }
                    break;
            }

        }

        private void grvDetalle_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            
        }
        

        private void btnColores_Click(object sender, EventArgs e)
        {
            /*frmConfiguracionColoresP frm = new frmConfiguracionColoresP();
            frm.ShowDialog();
            dtColores = Modulo.cBP.Seleccionar("CALL SP_COLORES_CLIENTES_SELECCIONAR(0)");
            grvDetalle.Focus();*/
        }
    }
}