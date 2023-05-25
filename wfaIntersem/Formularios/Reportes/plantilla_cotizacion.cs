using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace wfaIntersem

{
    public partial class plantilla_cotizacion : DevExpress.XtraReports.UI.XtraReport
    {
        public plantilla_cotizacion()
        {
            InitializeComponent();
        }

        private void peImgCliente_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }
    }
}
