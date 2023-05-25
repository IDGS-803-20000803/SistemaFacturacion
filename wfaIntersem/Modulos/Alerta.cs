using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaIntersem.Modulos
{
    public class Alerta
    {
        /// <summary>
        /// Muestra una alerta de guardado.
        /// </summary>
        /// <param name="intTipo">recibe un dato de tipo entero</param>
        /// <param name="frmForma">instanciar el formulario(this)</param>
        public void MuestraAlerta(int intTipo, DevExpress.XtraEditors.XtraForm frmForma)
        {
            DevExpress.XtraBars.Alerter.AlertControl Alerta = new DevExpress.XtraBars.Alerter.AlertControl();
            DevExpress.XtraBars.Alerter.AlertInfo Info;
            string strRuta = Application.StartupPath;
            Info = new DevExpress.XtraBars.Alerter.AlertInfo("Guardar", "Registro(s) guardados(s) correctamente", "", Image.FromFile(strRuta + "\\Completed_32x32.png"));
            Alerta.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.SlideHorizontal;
            Alerta.BeforeFormShow += new DevExpress.XtraBars.Alerter.AlertFormEventHandler(Alerta_BeforeFormShow);
            Alerta.AutoFormDelay = 6000;
            Alerta.ShowPinButton = false;
            Alerta.Show(frmForma, Info);
        }

        public void MuestraAlertaCorreo(DevExpress.XtraEditors.XtraForm frmForma)
        {
            DevExpress.XtraBars.Alerter.AlertControl Alerta = new DevExpress.XtraBars.Alerter.AlertControl();
            DevExpress.XtraBars.Alerter.AlertInfo Info;
            string strRuta = Application.StartupPath;
            Info = new DevExpress.XtraBars.Alerter.AlertInfo("Correo Enviado", "se ha enviado correctamente el correo", "", Image.FromFile(strRuta + "\\Completed_32x32.png"));
            Alerta.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.SlideHorizontal;
            Alerta.BeforeFormShow += new DevExpress.XtraBars.Alerter.AlertFormEventHandler(Alerta_BeforeFormShow);
            Alerta.AutoFormDelay = 6000;
            Alerta.ShowPinButton = false;
            Alerta.Show(frmForma, Info);
        }

        public void MuestraAlertaModificar(DevExpress.XtraEditors.XtraForm frmForma)
        {
            DevExpress.XtraBars.Alerter.AlertControl Alerta = new DevExpress.XtraBars.Alerter.AlertControl();
            DevExpress.XtraBars.Alerter.AlertInfo Info;
            string strRuta = Application.StartupPath;
            Info = new DevExpress.XtraBars.Alerter.AlertInfo("Modificar", "Registro(s) Modificado(s) correctamente", "", Image.FromFile(strRuta + "\\Completed_32x32.png"));
            Alerta.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.SlideHorizontal;
            Alerta.BeforeFormShow += new DevExpress.XtraBars.Alerter.AlertFormEventHandler(Alerta_BeforeFormShow);
            Alerta.AutoFormDelay = 6000;
            Alerta.ShowPinButton = false;
            Alerta.Show(frmForma, Info);
        }

        public void MuestraAlera(int intTipo, DevExpress.XtraEditors.XtraForm frmForma, string titulo, string mensaje)
        {
            DevExpress.XtraBars.Alerter.AlertControl Alerta = new DevExpress.XtraBars.Alerter.AlertControl();
            DevExpress.XtraBars.Alerter.AlertInfo Info;
            string strRuta = Application.StartupPath;
            Info = new DevExpress.XtraBars.Alerter.AlertInfo(titulo, mensaje, "", Image.FromFile(strRuta + "\\Completed_32x32.png"));
            Alerta.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.SlideHorizontal;
            Alerta.BeforeFormShow += new DevExpress.XtraBars.Alerter.AlertFormEventHandler(Alerta_BeforeFormShow);
            Alerta.AutoFormDelay = 6000;
            Alerta.ShowPinButton = false;
            Alerta.Show(frmForma, Info);
        }

        private void Alerta_BeforeFormShow(object sender, DevExpress.XtraBars.Alerter.AlertFormEventArgs e)
        {
            e.AlertForm.Width = 230;
            e.AlertForm.Height = 80;
        }

    }
}
