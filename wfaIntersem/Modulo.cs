using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Security.Cryptography;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Drawing;
using System.Net.Mail;
using System.Net;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using DevExpress.PivotGrid.CriteriaVisitors;

namespace wfaIntersem
{
    public static class Modulo
    {
        public static string gblIdProgramacion;
        public static int gblTotalProgramacion;
        public static Objetos.objUsuarios objUsuario = new Objetos.objUsuarios();
        public static int IdUsuario = 1;
        public static CultureInfo culture = new CultureInfo("es-MX");

        public static Dictionary<string, string> MenuPermisos;

        internal static BP.GeneralBP cBP = new BP.GeneralBP();
        internal static Modulos.Alerta Alertar = new Modulos.Alerta();


        public static DataTable GetDataTable(string strStoreProcedure, bool recargarConfiguracion = false)
        {
            return cBP.Seleccionar(strStoreProcedure, recargarConfiguracion);
        }

        public static int EjecutarFuncionSql(string strFunction)
        {
            return cBP.Escalar(strFunction);
        }

        public static string HashPassword(string texto)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(texto),
                hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            foreach (byte hashI in hash)
            {
                sb.Append(hashI.ToString("X2"));
            }
            //for (int i = 0; i < hash.Length; i++)
            //{
            //    sb.Append(hash[i].ToString("X2"));
            //}
            //Console.WriteLine(sb.ToString());

            return sb.ToString();
        }

        public static string Desencriptar(string textoEncriptado)
        {
            byte[] keyArray;
            byte[] Array_a_Descifrar = Convert.FromBase64String(textoEncriptado);

            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Properties.Settings.Default.Llave));
            hashmd5.Clear();

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider
            {
                Key = keyArray,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            ICryptoTransform cTransform = tdes.CreateDecryptor();

            byte[] resultArray = cTransform.TransformFinalBlock(Array_a_Descifrar, 0, Array_a_Descifrar.Length);

            tdes.Clear();
            return Encoding.UTF8.GetString(resultArray);
        }

        public static void ShowCatch(Exception Ex, string Titulo = "Error")
        {
            //MessageBox.Show("Mensaje:\n\t " + Ex.Message + "\n origen \n\t" + Ex.Source + "\n instancia \n\t" + Ex.InnerException + "\n metodo \n\t" + Ex.TargetSite + "\n pila de errores  \n\t" + Ex.StackTrace, Titulo);
            //if (string.IsNullOrEmpty(Titulo)) Titulo = "Error";

            string instancia = Ex.InnerException is null ? "Ninguna." : Ex.InnerException.ToString(),
                mensajeError = $"Mensaje:\n\t{Ex.Message}\n" +
                $"Origen:\n\t{Ex.Source}\n" +
                $"Instancia:\n\t{instancia}\n" +
                $"Metodo:\n\t{Ex.TargetSite}\n" +
                $"Pila de errores:\n\t{Ex.StackTrace}";
            XtraMessageBox.Show(new XtraMessageBoxArgs()
            {
                Caption = Titulo,
                Text = mensajeError,
                Buttons = new DialogResult[] { DialogResult.OK, },
                Icon = SystemIcons.Error,
                MessageBeepSound = MessageBeepSound.Error,
            });
        }

        public static void ShowError(string mensaje, string titulo = "Error")
        {
            XtraMessageBox.Show(new XtraMessageBoxArgs()
            {
                Caption = titulo,
                Text = mensaje,
                Buttons = new DialogResult[] { DialogResult.OK, },
                Icon = SystemIcons.Error,
                MessageBeepSound = MessageBeepSound.Error,
            });
        }

        public static void ShowAviso(string mensaje, string titulo = "Aviso")
        {
            XtraMessageBox.Show(new XtraMessageBoxArgs()
            {
                Caption = titulo,
                Text = mensaje,
                Buttons = new DialogResult[] { DialogResult.OK, },
                Icon = SystemIcons.Warning,
                MessageBeepSound = MessageBeepSound.Warning,
            });
        }

        public static void EnviarCorreoCotizacion(int intId)
        {
            Attachment attachment;
            string tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            DataTable dtDatos = GetDataTable($"CALL SP_COTIZACIONES_ENVIAR_CORREO({intId})");

            XtraReport plantilla_cotizacion = new plantilla_cotizacion();
            plantilla_cotizacion.DataSource = dtDatos;
            plantilla_cotizacion.ShowPrintMarginsWarning = false;

            plantilla_cotizacion.ExportToPdf(tempDirectory);

            // Create a new message and attach the PDF document.
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("pruebas@sdib.com.mx");
            mail.To.Add(dtDatos.Rows[0]["correo_contacto"].ToString());
            // mail.To.Add("chaipsreyna@gmail.com");
            mail.Subject = "COTIZACIONES SDIB";
            mail.Body = "Estimado(a) " + dtDatos.Rows[0]["nombre"].ToString() + " le hacemos entrega de la cotización " + dtDatos.Rows[0]["folio"].ToString();

            attachment = new System.Net.Mail.Attachment(tempDirectory);
            attachment.Name = dtDatos.Rows[0]["folio"].ToString() + ".pdf"; // set name here

            mail.Attachments.Add(attachment);


            // Specify the SMTP server and send the message.
            string SmtpHost = "www.sdib.com.mx";
            int SmtpPort = 587;
            if (string.IsNullOrEmpty(SmtpHost) || SmtpPort == -1)
            {
                throw new ArgumentException("Please configure the SMTP server settings.");
            }

            string SmtpUserName = "pruebas@sdib.com.mx";
            string SmtpUserPassword = "73-CF-23-69-84-64";
            SmtpClient smtpClient = new SmtpClient(SmtpHost, SmtpPort);
            smtpClient.Credentials = new NetworkCredential(SmtpUserName, SmtpUserPassword);
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = false;
            smtpClient.Send(mail);
            mail = null;
            smtpClient = null;
        }

        public static void LoadForm(XtraForm frmPadre, string formulario, string nombre)
        {
            var formAbierto = frmPadre.MdiChildren.Where(m => m.Name.ToString() == nombre).ToList();

            if (formAbierto.Count > 0)
            {
                formAbierto[0].Focus();
            }
            else
            {
                formulario = "wfaIntersem." + formulario;
                Type FormInstanceType = Type.GetType(formulario);
                XtraForm frmForma = (XtraForm)Activator.CreateInstance(FormInstanceType);
                frmForma.MdiParent = frmPadre;
                frmForma.Show();


            }
        }


        /// <summary>
        /// Funcion que valida los permisos especiales (conocidos como "de checkout")
        /// </summary>
        /// <param name="formHijo"></param>
        /// <param name="formPadre"></param>
        public static void RevisarCheckout(Control formHijo, Control formPadre = null)
        {
            if (formPadre != null && formPadre.GetType().BaseType.FullName == "DevExpress.XtraEditors.XtraForm") return;
            foreach (Control ctrl in formHijo.Controls)
            {
                if (ctrl.Controls.Count > 0) RevisarCheckout(ctrl, null);
                if (ctrl.Name.ToLower().Contains("cmdcheckout"))
                {
                    ctrl.Enabled = false;
                }
                else if (ctrl.Tag != null && ctrl.Tag.ToString().ToLower().Contains("checkout"))
                {
                    ctrl.Enabled = false;
                }

                if (ctrl.GetType().ToString() == "DevExpress.XtraBars.Controls.DockedBarControl")
                {
                    DevExpress.XtraBars.Controls.DockedBarControl padre = (DevExpress.XtraBars.Controls.DockedBarControl)ctrl;
                    foreach (DevExpress.XtraBars.BarItemLink c in padre.Bar.ItemLinks)
                    {
                        if (c.Item.Name.ToLower().Contains("cmdcheckout"))
                        {
                            c.Item.Enabled = false;
                        }
                    }
                }
            }
        }

        public static void RevisarPermisos(Control form)
        {
            if (form.GetType().BaseType.FullName == "DevExpress.XtraEditors.XtraForm" && MenuPermisos[form.Name] == "1") return;
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl.Controls.Count > 0) RevisarPermisos(ctrl);
                if (ctrl.Name.ToLower().Contains("guardar") || ctrl.Name.ToLower().Contains("editar") ||
                    ctrl.Name.ToLower().Contains("nuevo") || ctrl.Text.ToLower().Contains("guardar") ||
                    ctrl.Text.ToLower().Contains("editar") || ctrl.Text.ToLower().Contains("nuevo"))
                {
                    ctrl.Enabled = false;
                }

                if (ctrl.GetType().ToString() == "DevExpress.XtraBars.Controls.DockedBarControl")
                {
                    DevExpress.XtraBars.Controls.DockedBarControl padre = (DevExpress.XtraBars.Controls.DockedBarControl)ctrl;
                    foreach (DevExpress.XtraBars.BarItemLink c in padre.Bar.ItemLinks)
                    {
                        if (c.Item.Name.ToLower().Contains("guardar") || c.Item.Name.ToLower().Contains("editar") ||
                            c.Item.Name.ToLower().Contains("nuevo") || c.Caption.ToLower().Contains("guardar") ||
                            c.Caption.ToLower().Contains("editar") || c.Caption.ToLower().Contains("nuevo"))
                        {
                            c.Item.Enabled = false;
                        }
                    }
                }
            }
        }

        public static int BuscaNumeroBinarioInferiorA(int Permiso)
        {
            try
            {
                bool bandera;
                float control = 0;
                bandera = false;
                while (bandera == false)
                {
                    if ((Math.Pow(2, control)) > Permiso)
                    {
                        bandera = true;
                    }
                    else
                    {
                        control += 1;
                    }
                }
                return Convert.ToInt32(Math.Pow(2, (control - 1)));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void ImprimirCuadriculaGrid(DevExpress.XtraGrid.GridControl grdCuadricula, string strTitulo, int intOrientacion)
        {
            frmImprimir fImprimir = new frmImprimir();
            PageHeaderArea HeaderArea;
            PageHeaderFooter PHF;
            HeaderArea = new PageHeaderArea();

            HeaderArea.Content.AddRange(new string[] { "[Image 1]", strTitulo, "" });
            HeaderArea.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            PHF = new PageHeaderFooter(HeaderArea, null);
            if (strTitulo == "Listado de Pedidos")
            {
                intOrientacion = 1;
                //fImprimir.AutoScaleMode = AutoScaleMode.Font;
            }


            fImprimir.linkReport.PageHeaderFooter = PHF;
            if (intOrientacion == 0)
                fImprimir.linkReport.Landscape = false;
            else
                fImprimir.linkReport.Landscape = true;
            fImprimir.linkReport.Component = grdCuadricula;
            fImprimir.ShowDialog();
        }

        public static void ExportarExcel(DevExpress.XtraGrid.Views.Grid.GridView grvCuadricula)
        {
            SaveFileDialog svfGuardar = new SaveFileDialog
            {
                Filter = "Archivos de Excel|*.xlsx",
                FileName = ""
            };
            svfGuardar.ShowDialog();
            if (svfGuardar.FileName != "")
                grvCuadricula.ExportToXlsx(svfGuardar.FileName);
        }

        public static byte[] ImageToByte(Image imagen)
        {
            Image imag = imagen;
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(imag, typeof(byte[]));
            return xByte;
        }

        public static byte[] fileToByte(string archivo)
        {

            byte[] xByte = System.Text.Encoding.UTF8.GetBytes(archivo);
            return xByte;
        }


        public static string BinaryToText(byte[] data)
        {
            return Encoding.UTF8.GetString(data);
        }

        /*
        public static File ByteToFile(byte[] ByteArray)
        {
            File result = null;
            result = new Bitmap(new MemoryStream(ByteArray));
            return result;
        }*/


        public static Image ByteToImage(byte[] ByteArray)
        {
            Image result = null;
            result = new Bitmap(new MemoryStream(ByteArray));
            return result;
        }

        public static float ConvertFloat(object valor)
        {
            if (valor.ToString().Equals("")) return 0F;

            float miValor = Convert.ToSingle(valor);
            return miValor;
        }
        public static decimal ConvertDecimal(object valor)
        {
            if (valor is string)
            {
                valor = valor.ToString().Replace("$", "").Replace(",", "");
            }

            if (valor.ToString().Equals("")) return 0M;

            decimal miValor = Convert.ToDecimal(valor);
            return miValor;
        }

        public static int ConvertInt(object valor)
        {
            if (valor.ToString().Equals("")) return 0;

            int miValor = Convert.ToInt32(valor);
            return miValor;
        }

        public static void ExportMasterDetail(DevExpress.XtraGrid.Views.Grid.GridView grvCuadricula)
        {
            SaveFileDialog svfGuardar = new SaveFileDialog
            {
                Filter = "Archivos de Excel|*.xls|Documento PDF|*.pdf",
                FileName = ""
            };
            svfGuardar.ShowDialog();
            if (svfGuardar.FileName != "")
            {
                if (System.IO.Path.GetExtension(svfGuardar.FileName).ToUpper() == ".PDF")
                    grvCuadricula.ExportToPdf(svfGuardar.FileName);
                else
                {
                    grvCuadricula.ExportToXls(svfGuardar.FileName, new XlsExportOptionsEx()
                    {
                        ExportType = DevExpress.Export.ExportType.WYSIWYG
                    });
                }
            }
        }

        public static string NumeroALetras(this decimal numberAsString)
        {
            string dec;

            var entero = Convert.ToInt64(Math.Truncate(numberAsString));
            var decimales = Convert.ToInt32(Math.Round((numberAsString - entero) * 100, 2));
            if (decimales > 0)
            {
                //dec = " PESOS CON " + decimales.ToString() + "/100";
                dec = $" PESOS {decimales:0,0} /100";
            }
            //Código agregado por mí
            else
            {
                //dec = " PESOS CON " + decimales.ToString() + "/100";
                dec = $" PESOS {decimales:0,0} /100";
            }
            var res = NumeroALetras(Convert.ToDouble(entero)) + dec;
            return res;
        }

        private static string NumeroALetras(double value)
        {
            string num2Text; value = Math.Truncate(value);
            if (value == 0) num2Text = "CERO";
            else if (value == 1) num2Text = "UNO";
            else if (value == 2) num2Text = "DOS";
            else if (value == 3) num2Text = "TRES";
            else if (value == 4) num2Text = "CUATRO";
            else if (value == 5) num2Text = "CINCO";
            else if (value == 6) num2Text = "SEIS";
            else if (value == 7) num2Text = "SIETE";
            else if (value == 8) num2Text = "OCHO";
            else if (value == 9) num2Text = "NUEVE";
            else if (value == 10) num2Text = "DIEZ";
            else if (value == 11) num2Text = "ONCE";
            else if (value == 12) num2Text = "DOCE";
            else if (value == 13) num2Text = "TRECE";
            else if (value == 14) num2Text = "CATORCE";
            else if (value == 15) num2Text = "QUINCE";
            else if (value < 20) num2Text = "DIECI" + NumeroALetras(value - 10);
            else if (value == 20) num2Text = "VEINTE";
            else if (value < 30) num2Text = "VEINTI" + NumeroALetras(value - 20);
            else if (value == 30) num2Text = "TREINTA";
            else if (value == 40) num2Text = "CUARENTA";
            else if (value == 50) num2Text = "CINCUENTA";
            else if (value == 60) num2Text = "SESENTA";
            else if (value == 70) num2Text = "SETENTA";
            else if (value == 80) num2Text = "OCHENTA";
            else if (value == 90) num2Text = "NOVENTA";
            else if (value < 100) num2Text = NumeroALetras(Math.Truncate(value / 10) * 10) + " Y " + NumeroALetras(value % 10);
            else if (value == 100) num2Text = "CIEN";
            else if (value < 200) num2Text = "CIENTO " + NumeroALetras(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) num2Text = NumeroALetras(Math.Truncate(value / 100)) + "CIENTOS";
            else if (value == 500) num2Text = "QUINIENTOS";
            else if (value == 700) num2Text = "SETECIENTOS";
            else if (value == 900) num2Text = "NOVECIENTOS";
            else if (value < 1000) num2Text = NumeroALetras(Math.Truncate(value / 100) * 100) + " " + NumeroALetras(value % 100);
            else if (value == 1000) num2Text = "MIL";
            else if (value < 2000) num2Text = "MIL " + NumeroALetras(value % 1000);
            else if (value < 1000000)
            {
                num2Text = NumeroALetras(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0)
                {
                    num2Text = num2Text + " " + NumeroALetras(value % 1000);
                }
            }
            else if (value == 1000000)
            {
                num2Text = "UN MILLON";
            }
            else if (value < 2000000)
            {
                num2Text = "UN MILLON " + NumeroALetras(value % 1000000);
            }
            else if (value < 1000000000000)
            {
                num2Text = NumeroALetras(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0)
                {
                    num2Text = num2Text + " " + NumeroALetras(value - Math.Truncate(value / 1000000) * 1000000);
                }
            }
            else if (value == 1000000000000) num2Text = "UN BILLON";
            else if (value < 2000000000000) num2Text = "UN BILLON " + NumeroALetras(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            else
            {
                num2Text = NumeroALetras(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0)
                {
                    num2Text = num2Text + " " + NumeroALetras(value - Math.Truncate(value / 1000000000000) * 1000000000000);
                }
            }
            return num2Text;
        }

        public static string ConvertirImagenBase64(Image imagen)
        {
            Image imag = imagen;
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(imag, typeof(byte[]));
            string base64String = Convert.ToBase64String(xByte, 0, xByte.Length);
            return base64String;
        }

        public static Image ConvertirBase64Imagen(string image_base_64)
        {
            byte[] ByteArray = Convert.FromBase64String(image_base_64);
            Image result = null;
            result = new Bitmap(new MemoryStream(ByteArray));
            return result;
        }

        public static DataSet GetDataSet(string strStoreProcedure)
        {
            return cBP.SeleccionarDataSet(strStoreProcedure);
        }

    }
}
