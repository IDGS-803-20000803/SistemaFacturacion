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
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Controls;



namespace wfaIntersem
{
    public partial class frmLoginP : XtraForm
    {
        private bool cambioConexionServidor = false;

        public frmLoginP()
        {
            InitializeComponent();
            InitializeButton();
        }

        private void InitializeButton()
        {
            cmdAceptar.BorderStyle = BorderStyles.UltraFlat;
            cmdAceptar.Appearance.ForeColor = Color.White;
            cmdAceptar.Appearance.BackColor = Color.Transparent;
            cmdAceptar.Appearance.BackColor2 = Color.Transparent;
            cmdAceptar.Appearance.BorderColor = Color.Transparent;
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text,
                    contrasenia = Modulo.HashPassword(txtContra.Text);

                DataTable dtDatos = Modulo.GetDataTable($"CALL SP_LOGIN_SELECCIONAR('{usuario}', '{contrasenia}')", cambioConexionServidor);

                if (dtDatos.Rows.Count == 0)
                {
                    Modulo.ShowError("Usuario o Contraseña incorrectos");
                    return;
                }

                DataRow row = dtDatos.Rows[0];

                Modulo.IdUsuario = Modulo.objUsuario.id_usuario = Convert.ToInt32(row["id"]);
                //Modulo.IdUsuario = int.Parse(dtDatos.Rows[0]["id"].ToString());
                //Modulo.objUsuario.id_usuario = Modulo.IdUsuario;

                Modulo.objUsuario.temaUsuario = row["tema"].ToString();
                //Modulo.objUsuario.id_host = int.Parse(Modulo.GetDataTable("SP_HOSTS_SELECCIONAR('" + System.Net.Dns.GetHostName().ToString() + "')").Rows[0]["id_host"].ToString());
                ConfiguracionUsuario();
                Close();

                //MessageBox.Show("Usuario o Contraseña incorrectos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                if (ex is TypeInitializationException)
                {
                    Modulo.ShowError("Falta definir la conexión al servidor.\n" +
                        "Si ya fue definida, reinicia la aplicación.");
                    return;
                }

                if (ex.Message.Equals("Unable to connect to any of the specified MySQL hosts."))
                {
                    Modulo.ShowError("No se pudo establecer conexión con el servidor.\n" +
                        "Revisa la conexión y reinicia la aplicación sí es necesario.");
                    return;
                }

                Modulo.ShowCatch(ex);
            }
        }

        private void cmdBase_Click(object sender, EventArgs e)
        {
            cambioConexionServidor = new frmConfiguracionServer().EstablecerConexion();
        }

        void ConfiguracionUsuario()
        {
            string directorio = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\facturacion",
                ruta = $@"{directorio}\user.xml";
            DataTable dtConfig = new DataTable("user");

            dtConfig.Columns.Add("recordarme", typeof(string));
            dtConfig.Columns.Add("usuario", typeof(string));

            DataRow dtRow = dtConfig.NewRow();
            dtRow["recordarme"] = chkRecordar.CheckState == CheckState.Checked ? "SI" : "NO";
            dtRow["usuario"] = txtUsuario.Text;
            dtConfig.Rows.Add(dtRow);

            dtConfig.WriteXml(ruta, XmlWriteMode.WriteSchema);

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Modulo.IdUsuario = 0;
            Close();
        }

        private void frmLoginP_Load(object sender, EventArgs e)
        {
            GetConfiguracion();
        }

        void GetConfiguracion()
        {
            string archivo = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\facturacion\user.xml";

            if (!System.IO.File.Exists(archivo)) return;

            try
            {
                DataTable dtDatos = new DataTable();
                dtDatos.ReadXml(archivo);
                DataRow rowDatos = dtDatos.Rows[0];
                if (rowDatos["recordarme"].ToString().Equals("SI"))
                {
                    txtUsuario.Text = rowDatos["usuario"].ToString();
                    chkRecordar.CheckState = CheckState.Checked;
                }
            }
            catch (Exception ex)
            {
                Modulo.ShowCatch(ex);
            }

        }

        private void TextEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            cmdAceptar.PerformClick();
        }
    }

    public class MyButton : SimpleButton
    {
        protected override BaseStyleControlViewInfo CreateViewInfo()
        {
            return new MyButtonViewInfo(this);
        }
    }

    public class MyButtonViewInfo : SimpleButtonViewInfo
    {
        public MyButtonViewInfo(MyButton owner)
            : base(owner)
        {
        }
        protected override EditorButtonPainter GetButtonPainter()
        {
            return new MyEditorButtonPainter(new MyUltraFlatButtonObjectPainter());
        }
    }

    public class MyEditorButtonPainter : EditorButtonPainter
    {
        public MyEditorButtonPainter(ObjectPainter painter)
            : base(painter)
        {
        }

    }

    public class MyUltraFlatButtonObjectPainter : UltraFlatButtonObjectPainter
    {
        //public override void DrawCaption(ObjectInfoArgs e, string caption, Font font, Brush brush, Rectangle bounds, StringFormat format)
        //{
        //    base.DrawCaption(e, caption, font, brush, bounds, format);
        //}


        //public override void DrawObject(ObjectInfoArgs e)
        //{
        //    AppearanceObject style = GetStyle(e);
        //    bool drawn = false;
        //    if (IsPressed(e))
        //    {
        //        //  DrawPressed(e, style);
        //        drawn = true;
        //    }
        //    if (!drawn && (e.State & ObjectState.Hot) != 0)
        //    {
        //        //DrawHot(e, style);
        //        drawn = true;
        //    }
        //    if (!drawn)
        //        DrawNormal(e, style);
        //    if ((e.State & ObjectState.Selected) != 0)
        //    {
        //        //  DrawSelectedFrame(e);
        //    }
        //}
    }

}