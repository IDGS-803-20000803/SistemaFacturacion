using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;

namespace wfaIntersem
{
    public partial class plantilla_facturacion : DevExpress.XtraReports.UI.XtraReport
    {
        public plantilla_facturacion()
        {
            InitializeComponent();
        }

        private void TopMargin_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void plantilla_facturacion_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void qr_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void xrPictureBox2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            string value = GetCurrentColumnValue("qr").ToString();
            MemoryStream stream = new MemoryStream(Convert.FromBase64String(value));
            (sender as XRPictureBox).Image = Image.FromStream(stream);
        }

        private void totLetra_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            string value = GetCurrentColumnValue("total").ToString();
            string totaletra = Modulo.NumeroALetras(Modulo.ConvertDecimal(value));
            (sender as XRLabel).Text = totaletra;

        }
    }
}
