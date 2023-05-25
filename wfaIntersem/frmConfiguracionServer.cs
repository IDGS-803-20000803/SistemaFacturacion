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
    public partial class frmConfiguracionServer : XtraForm
    {
        private bool cambioConexion;
        private string strRuta;
        private DataTable dtDatos;

        public frmConfiguracionServer()
        {
            InitializeComponent();
        }

        private void frmCatalogoDetalle_Load(object sender, EventArgs e)
        {
            string strDirectorio = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\facturacion";
            strRuta = $@"{strDirectorio}\config.xml";

            if (!System.IO.Directory.Exists(strDirectorio))
            {
                System.IO.Directory.CreateDirectory(strDirectorio);
                return;
            }

            try
            {
                dtDatos = new DataTable();
                dtDatos.ReadXml(strRuta);
                DataRow rowDatos = dtDatos.Rows[0];
                txtBaseDatos.Text = rowDatos["basedatos"].ToString();
                txtContraseña.Text = rowDatos["contra"].ToString();
                txtServidor.Text = rowDatos["servidor"].ToString();
                txtUsuario.Text = rowDatos["usuario"].ToString();
            }
            catch (Exception ex)
            {
                Modulo.ShowCatch(ex);
                Close();
            }
        }

        private void mnuSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void mnuGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (!dxValidacion.Validate()) return;

                string baseDatos = txtBaseDatos.Text,
                    contra = txtContraseña.Text,
                    servidor = txtServidor.Text,
                    usuario = txtUsuario.Text;

                DataTable dtDatos = new DataTable("config");
                dtDatos.Columns.Add("basedatos", typeof(string));
                dtDatos.Columns.Add("contra", typeof(string));
                dtDatos.Columns.Add("servidor", typeof(string));
                dtDatos.Columns.Add("usuario", typeof(string));

                DataRow dtRow = dtDatos.NewRow();
                dtRow["basedatos"] = baseDatos;
                dtRow["contra"] = contra;
                dtRow["servidor"] = servidor;
                dtRow["usuario"] = usuario;
                dtDatos.Rows.Add(dtRow);

                dtDatos.WriteXml(strRuta, XmlWriteMode.WriteSchema);

                cambioConexion = ConexionCambio(baseDatos, contra, servidor, usuario);

                Close();
            }
            catch (Exception ex)
            {
                Modulo.ShowCatch(ex);
            }
        }

        public bool EstablecerConexion()
        {
            ShowDialog();
            if (dtDatos is null) return false;
            else return cambioConexion;
        }

        private void TextEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            mnuGuardar.PerformClick();
        }

        private bool ConexionCambio(string baseDatos, string contra, string servidor, string usuario)
        {
            if (dtDatos is null) return false;

            DataRow rowDatos = dtDatos.Rows[0];
            
            string dtBaseDatos = rowDatos["basedatos"].ToString(),
                dtContra = rowDatos["contra"].ToString(),
                dtServidor = rowDatos["servidor"].ToString(),
                dtUsuario = rowDatos["usuario"].ToString();

            return !dtBaseDatos.Equals(baseDatos) 
                || !dtContra.Equals(contra)
                || !dtServidor.Equals(servidor)
                || !dtUsuario.Equals(usuario);
        }
    }

}