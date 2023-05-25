using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using System;
using System.Data;


namespace wfaIntersem
{
    public partial class frmPoliticas : XtraForm
    {

        string politicas = null;

        DataTable dtPoliticas;

        public frmPoliticas()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            e.Result = e.Argument;

            switch (e.Argument.ToString())
            {
                case "inicializar":
                    ObtenerPoliticas();
                    break;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                Modulo.ShowCatch(e.Error);
            }

            switch (e.Result.ToString())
            {
                case "inicializar":
                    ColocarPoliticas();
                    ActivarComponentens();
                    break;
            }
        }

        private void ActivarComponentens()
        {
            txtPoliticas.Enabled = !txtPoliticas.Enabled;
            btnGuardarPolitica.Enabled = !btnGuardarPolitica.Enabled;
        }

        private void ObtenerPoliticas()
        {
            dtPoliticas = Modulo.GetDataTable("CALL SP_EMPRESA_POLITICAS_SELECCIONAR()");
        }

        public void ColocarPoliticas()
        {
            txtPoliticas.EditValue = dtPoliticas.Rows[0]["politicas"].ToString();

            //if (pol == null)
            //{
            //    DataTable dtDatosEmpresa = Modulo.GetDataTable("CALL SP_EMPRESA_SELECCIONAR()");

            //    if (dtDatosEmpresa.Rows.Count > 0)
            //    {
            //        txtPoliticas.Text = dtDatosEmpresa.Rows[0]["politicas"].ToString();
            //    }
            //    else
            //    {
            //        txtPoliticas.Text = "Actualmente No hay Politicas";
            //    }
            //}
            //else
            //{
            //    txtPoliticas.Text = pol;
            //}
        }

        public string ConsultarDetallePolitica(string poli)
        {
            politicas = poli;
            this.ShowDialog();
            return politicas;
        }

        private void frmPoliticas_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(politicas))
            {
                txtPoliticas.EditValue = politicas;
                ActivarComponentens();
            }
            else
            {
                backgroundWorker1.RunWorkerAsync("inicializar");
            }
        }

        private void btnGuardarPolitica_Click(object sender, EventArgs e)
        {
            ActivarComponentens();
            politicas = txtPoliticas.EditValue.ToString();
            Close();
        }


    }
}