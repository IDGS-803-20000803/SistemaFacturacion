using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaIntersem
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /* if (System.Net.Dns.GetHostName() == "DESKTOP-N4KP2CN" || System.Net.Dns.GetHostName() == "DESKTOP-BBSMG3O")
             {
                 Modulo.IdUsuario = 3;
                 Modulo.objUsuario.id_usuario = 3;
                 Modulo.objUsuario.nombre = "Desarrollando Ando";
                 //Modulo.objUsuario.id_host = int.Parse(Modulo.GetDataTable("SP_HOSTS_SELECCIONAR('" + System.Net.Dns.GetHostName().ToString() + "')").Rows[0]["id_host"].ToString());
                 //if (Modulo.IdUsuario > 0)
                     Application.Run(new frmPrincipal());
             }
             else
             {*/

                frmLoginP fLogin = new frmLoginP();
                fLogin.ShowDialog();
                if (Modulo.IdUsuario > 0)
                    Application.Run(new frmPrincipal());
            

            // }            
        }
    }
}
