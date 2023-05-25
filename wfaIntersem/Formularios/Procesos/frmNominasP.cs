using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaIntersem
{
    public partial class frmNominasP : XtraForm
    {
        #region VariablesGlobales
        int SelectedRow = 0;
        int _mes;
        DataTable dtDetalle = new DataTable();
        #endregion
       
        public frmNominasP()
        {
            InitializeComponent();
        }
        #region Eventos
        #region Eventos al abrir pantalla
        private void frmNominasP_Load(object sender, EventArgs e)
        {
            DocumentosAños();
            InformacionMeses();
            mnuNuevo.Enabled = false;
            if (DateTime.Now.Month == 1)
                backwDatos.RunWorkerAsync(1);
            else
                xTabMeses.SelectedTabPageIndex = DateTime.Now.Month - 1;

           this.grvNominas.Columns["cAcciones"].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;

        }
        #endregion

        #endregion
        #region Eventos de Menu superior
        private void mnuNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNominasD frm = new frmNominasD();
            //bool intResultado = frm.NuevoDetalle();
           // if (intResultado)
            //{
                InformacionMeses();
                mnuNuevo.Enabled = false;
                barProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                backwDatos.RunWorkerAsync(xTabMeses.SelectedTabPageIndex + 1);
                xTabMeses.Enabled = false;
           // }
        }
        
        private void mnuImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.ImprimirCuadriculaGrid(grdNominas, "Listado de Nominas", 1);
        }

        private void mnuExportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.ExportarExcel(grvNominas);
        }
       
        private void mnuSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        #endregion

        private void cmbAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            InformacionMeses();
            barProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            backwDatos.RunWorkerAsync(xTabMeses.SelectedTabPageIndex + 1);
            cmbAño.Enabled = false;
            xTabMeses.Enabled = false;
        }

        private void xTabMeses_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (!backwDatos.IsBusy)
            {
                barProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                backwDatos.RunWorkerAsync(xTabMeses.SelectedTabPageIndex + 1);
                xTabMeses.Enabled = false;
                cmbAño.Enabled = false;
            }
        }
        private void DocumentosAños()
        {
            try
            {
                DataTable dtDatos = new DataTable();
                dtDatos = Modulo.GetDataTable("CALL SP_NOMINAS_ANOS_SELECCIONAR()");
                if (dtDatos.Rows.Count > 0)
                {
                    if (dtDatos.Rows[0][0] != DBNull.Value)
                    {
                        for (int intCuenta = int.Parse(dtDatos.Rows[0]["minimo"].ToString()); intCuenta <= int.Parse(dtDatos.Rows[0]["maximo"].ToString()); intCuenta++)
                        {
                            cmbAño.Properties.Items.Add(intCuenta);
                        }
                    }
                }
                cmbAño.Text = DateTime.Now.Year.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void InformacionMeses()
        {
            try
            {
                DataTable dtDatos = new DataTable();
                dtDatos = Modulo.GetDataTable("CALL SP_NOMINAS_MESES_SELECCIONAR(" + cmbAño.Text + ")");
                for (int i = 0; i < xTabMeses.TabPages.Count; i++)
                {
                    xTabMeses.TabPages[i].Appearance.Header.Font = new Font(xTabMeses.TabPages[i].Appearance.Header.Font, FontStyle.Regular);
                }
                for (int i = 0; i < dtDatos.Rows.Count; i++)
                {
                    xTabMeses.TabPages[int.Parse(dtDatos.Rows[i]["mes"].ToString()) - 1].Appearance.Header.Font = new Font(xTabMeses.TabPages[int.Parse(dtDatos.Rows[i]["mes"].ToString()) - 1].Appearance.Header.Font, FontStyle.Bold);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}