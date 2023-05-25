using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraNavBar;
namespace wfaIntersem
{
    public partial class frmPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public string PublishVersion
        {
            get
            {
                if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                {
                    Version ver = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;
                    return string.Format("{0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision);
                }
                else
                    return "Not Published";
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {/*
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("The Bezier");*/
            // UserLookAndFeel.Default.SetSkinMaskColors(Color.FromArgb(100, 23, 108,255), Color.White);
            barVersion.Caption = PublishVersion;
            //ribbon.Minimized = true;
            //DataTable dtMenu = Modulo.cBP.Seleccionar("CALL SP_MENU_SELECCIONAR(" + Modulo.objUsuario.id_usuario + ")");

            brUsuario.Caption = "USUARIO: " + Modulo.objUsuario.nombre;

            defaultLookAndFeel1.LookAndFeel.SkinName = Modulo.objUsuario.temaUsuario;

            //bool blnExpandir = false;
            ////TITULOS
            //DataView dtView = new DataView(dtMenu)
            //{
            //    RowFilter = "id_padre=0"
            //};

            //Modulo.MenuPermisos = new Dictionary<string, string>();
            //for (int intCuenta = 0; intCuenta < dtView.Count; intCuenta++)
            //{
            //    NavBarGroup NavGrupo = new NavBarGroup
            //    {
            //        Caption = dtView[intCuenta]["descripcion"].ToString(),
            //        Tag = dtView[intCuenta]["id"].ToString()
            //    };
            //    navMenu.Groups.Add(NavGrupo);

            //    DataView dtViewM = new DataView(dtMenu)
            //    {
            //        RowFilter = "id_padre=" + NavGrupo.Tag.ToString()
            //    };

            //    for (int intCuenta1 = 0; intCuenta1 < dtViewM.Count; intCuenta1++)
            //    {
            //        NavBarItem NavElemento = new NavBarItem
            //        {
            //            Caption = dtViewM[intCuenta1]["descripcion"].ToString(),
            //            Tag = dtViewM[intCuenta1]["id"].ToString()
            //        };
            //        NavGrupo.ItemLinks.Add(NavElemento);

            //        Modulo.MenuPermisos.Add(dtViewM[intCuenta1]["formulario"].ToString(), dtViewM[intCuenta1]["Editar"].ToString());
            //    }
            //    NavGrupo.Expanded = (!blnExpandir) || true;// blnExpandir;
            //    if (blnExpandir == false)
            //        blnExpandir = true;
            //}
            //documentManager1.View = tabbedView1;
        }

        private void navMenu_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            //Modulo.LoadForm(int.Parse(e.Link.Item.Tag.ToString()), true, this, e.Link.Caption.ToString());
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //            frmColoresNuevos fColoresNuevos = new frmColoresNuevos();
            //           fColoresNuevos.Show();
        }

        private void navMenu_DoubleClick(object sender, EventArgs e)
        {

        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmPasosP", "frmPasosP");
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmTipoClienteP", "frmTipoClienteP");

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmEmpleadosP", "frmEmpleadosP");
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmEquiposP", "frmEquiposP");
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmPerfilesP", "frmPerfilesP");
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmCategoriasP", "frmCategoriasP");
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmClientesP", "frmClientesP");
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmEmpleadosP", "frmEmpleadosP");
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmFirmasP", "frmFirmasP");
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmMarcasP", "frmMarcasP");
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmModelosP", "frmModelosP");
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmMunicipiosP", "frmMunicipiosP");
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmPuestosP", "frmPuestosP");
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmRutinasP", "frmRutinasP");
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmVehiculosP", "frmVehiculosP");
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmTiposUnidadP", "frmTiposUnidadP");
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmImportacionRutinas", "frmImportacionRutinas");
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmArchivosAuxiliares", "frmArchivosAuxiliares");
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmAnexosP", "frmAnexosP");
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmCotizacionesP", "frmCotizacionesP");
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmSolicitudServicio", "frmSolicitudServicio");
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmServiciosP", "frmServiciosP");
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmCuentasPorPagarP", "frmCuentasPorPagarP");
        }

        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmCierreServiciosP", "frmCierreServiciosP");
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmReportesEmpleadoP", "frmReportesEmpleadoP");
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmMinutasP", "frmMinutasP");
        }

        private void barButtonItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmServiciosFiltrado", "frmServiciosFiltrado");
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmAdminPerfilesP", "frmAdminPerfilesP");
        }

        /* private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
         {
             frmFormatoAnexo formato = new frmFormatoAnexo();
             int respuesta = formato.Nuevo();
             if (respuesta == 1)
             {
                 frmImportacionAnexos frm = new frmImportacionAnexos();
                 frm.NuevoDetalle();
             }
             else if (respuesta == 2)
             {
                 frmImportacionesAnexosJurisdiccion frm = new frmImportacionesAnexosJurisdiccion();
                 frm.NuevoDetalle();
             }

         }*/
        /*
         private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
         {
             wfaIntersem.Formularios.Procesos.Servicios.frmCalendarioAsignacionServicios frmCalendarioAsignacionServicios = new Formularios.Procesos.Servicios.frmCalendarioAsignacionServicios();
             frmCalendarioAsignacionServicios.ShowDialog();
         }*/

        private void skinRibbonGalleryBarItem2_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            string tema = e.Item.Caption;

            Modulo.GetDataTable("CALL SP_USUARIOS_TEMAS_GUARDAR('" + tema + "'," + Modulo.IdUsuario + ")");
        }

        private void barButtonItem34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmFacturacionP", "frmFacturacionP");

        }

        private void btnCotizaciones_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmCotizacionesP", "frmCotizacionesP");
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmFirmasP", "frmFirmasP");
        }

        private void btnNomina_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Modulo.LoadForm(this, "frmNominasP", "frmNominasP");
        }
    }
}