using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using DevExpress.CodeParser;
using DevExpress.Map.Native;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;



namespace wfaIntersem
{
    public partial class frmCotizacionesD : DevExpress.XtraEditors.XtraForm
    {
        #region Variables globales
        int intModo, intId, idOrigen;
        DataTable dtDatos = new DataTable();
        DataTable dtServiciosSinCotizar = new DataTable();
        DataTable dtEquipos = new DataTable();
        readonly decimal porcentajeIva = 0.16M;
        bool blnRespuesta = false;
        int[] cotizacionesSeleccionadas;
        int intPermiso;
        int par = 0;
        string politicas, folioD;

        decimal valorPrevio;

        #endregion

        #region Eventos
        #region Eventos al abrir la pantalla
        private void frmCatalogoDetalle_Load(object sender, EventArgs e)
        {
            //dtFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            //dtVigencia.Text = DateTime.Now.Year.ToString() + "-12-31";
            dtFecha.EditValue = DateTime.Now;
            CrearTabla();
            Combos();

            switch (intModo)
            {
                case 0:
                    //Abrir detalle 
                    //backwDatos.RunWorkerAsync(2);
                    //Desactivar();
                    txtVersion.EditValue = 1;
                    txtTiempoEntrega.EditValue = "3 a 5 Días Hábiles";
                    break;
                case 1:
                    Desactivar();
                    MuestraDetalleDatos();
                    break;

            }
            StatusMenu();
        }
        #endregion
        #region Eventos del menu superior
        private void mnuSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void mnuGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!grvDetalle.PostEditor())
            {
                XtraMessageBox.Show(new XtraMessageBoxArgs()
                {
                    Caption = "Cotización",
                    Text = "Ha ocurrido un error al obtener los datos de la tabla.\n" +
                    "Asegurese de que la información colocada sea la correcta\n" +
                    "e intentelo de nuevo.",
                    Buttons = new DialogResult[] { DialogResult.OK },
                    Icon = SystemIcons.Warning,
                    MessageBeepSound = MessageBeepSound.Warning,
                });
                return;
            }

            if (!dxValidacion.Validate()) return;

            string validar = ValidarGuardado();
            if (!string.IsNullOrEmpty(validar))
            {
                XtraMessageBox.Show(new XtraMessageBoxArgs()
                {
                    Caption = "Cotización",
                    Text = validar,
                    Buttons = new DialogResult[] { DialogResult.OK },
                    Icon = SystemIcons.Warning,
                    MessageBeepSound = MessageBeepSound.Warning,
                });
                return;
            }

            Guardar();

            //if (dxValidacion.Validate())
            //{
            //    bool banderaPreciosCorrectos = true;
            //    bool blnGuardar = true;
            //    for (int i = 0; i < grvDetalle.RowCount; i++)
            //    {
            //        if (decimal.Parse(grvDetalle.GetRowCellValue(i, "importe").ToString(), Modulo.culture) == 0)
            //        {
            //            banderaPreciosCorrectos = false;
            //            break;
            //        }

            //    }
            //    if (blnGuardar == true)
            //    {
            //        if (banderaPreciosCorrectos == true)
            //        {
            //            Guardar();
            //        }
            //        else
            //        {
            //            MessageBox.Show("No es posible guardar la cotización debido a que existe una partida con importe 0");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Es necesario asignar una categoria de rutina a cada partida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
        }

        #endregion
        #region Eventos de formulario

        private void cmdAcciones_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Tag)
            {
                case 1:
                    grvDetalle.DeleteRow(grvDetalle.FocusedRowHandle);
                    CalcularTotales();
                    break;
            }
        }

        private void backwDatos_DoWork(object sender, DoWorkEventArgs e)
        {
            switch (e.Argument.ToString())
            {
                case "1":
                    break;
                case "2":
                    backwDatos.ReportProgress(2);
                    break;
                case "3":
                    backwDatos.ReportProgress(4);
                    break;
            }


        }

        private void backwDatos_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                switch (e.ProgressPercentage)
                {

                    case 2:
                        MuestraDetalleDatos();
                        break;
                    case 4:
                        Guardar();
                        break;
                }
            }
            catch (Exception ex)
            {
                prgProgreso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                //MessageBox.Show(ex.Message);
                Modulo.ShowCatch(ex);
            }


        }

        private void backwDatos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
        #endregion
        #region Eventos de Componentes
        #region Eventos de Funcionalidad
        private void cmbCliente_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbCliente.EditValue is null)
            {
                txtDomicilio.EditValue = null;
                txtTelefono.EditValue = null;
                txtEmail.EditValue = null;

                cmbContacto.Properties.DataSource = null;
            }
            else
            {
                DataRowView rowCliente = (DataRowView)cmbCliente.GetSelectedDataRow();
                txtDomicilio.Text = rowCliente["calle"].ToString() + " " + rowCliente["numero"].ToString() + " col. " + rowCliente["colonia"].ToString() + " C.P." + rowCliente["cp"].ToString() + ", " + rowCliente["municipio"].ToString();
                txtTelefono.Text = (rowCliente["telefono"].ToString() != "") ? rowCliente["celular"].ToString() : rowCliente["telefono"].ToString();
                txtEmail.Text = rowCliente["correo"].ToString();

                cmbContacto.Properties.DataSource = Modulo.GetDataTable($"CALL SP_CLIENTES_CONTACTOS_SELECCIONAR({cmbCliente.EditValue}, NULL)");
            }
        }

        #endregion
        #endregion
        #endregion

        #region Funciones Privadas
        private void Combos()
        {
            //Seleccionar clientes
            cmbCliente.Properties.DataSource = Modulo.cBP.Seleccionar("CALL SP_CLIENTES_SELECCIONAR(null, null)");
            //Seleccionar responsable
            cmbResponsable.Properties.DataSource = Modulo.cBP.Seleccionar("CALL SP_FIRMAS_SELECCIONAR(null)");
            //Detalle de la cotizacion
            grdDetalle.DataSource = Modulo.cBP.Seleccionar($"CALL SP_COTIZACIONES_D_SELECCIONAR(null, null, null, {idOrigen}, null)");
            grvDetalle.BestFitColumns();
        }
        private void CrearTabla()
        {
            dtDatos.Columns.Add("id_cotizacion", typeof(int));
            dtDatos.Columns.Add("id_detalle", typeof(int));
            dtDatos.Columns.Add("partida", typeof(int));
            dtDatos.Columns.Add("precio", typeof(decimal));
            dtDatos.Columns.Add("cantidad", typeof(int));
            dtDatos.Columns.Add("descuento", typeof(decimal));
            dtDatos.Columns.Add("importe", typeof(decimal));
            dtDatos.Columns.Add("descripcion", typeof(string));
            dtDatos.Columns.Add("tiempo_entrega", typeof(string));

            grdDetalle.DataSource = dtDatos;
        }
        private void Desactivar()
        {
            cmbResponsable.Enabled = !cmbResponsable.Enabled;
            dtVigencia.Enabled = !dtVigencia.Enabled;
            cmbCliente.Enabled = !cmbCliente.Enabled;
            cmbContacto.Enabled = !cmbContacto.Enabled;

            txtDescripcion.Enabled = !txtDescripcion.Enabled;
            txtCantidad.Enabled = !txtCantidad.Enabled;
            txtPrecio.Enabled = !txtPrecio.Enabled;
            txtPorcentaje.Enabled = !txtPorcentaje.Enabled;
            txtTiempoEntrega.Enabled = !txtTiempoEntrega.Enabled;
            cmdAcciones.Enabled = !cmdAcciones.Enabled;
            txtSubtotal.Enabled = !txtSubtotal.Enabled;

            txtTotalNeto.Enabled = !txtTotalNeto.Enabled;
            txtIva.Enabled = !txtIva.Enabled;
            txtObservaciones.Enabled = !txtObservaciones.Enabled;

            btnAgregarEquipos.Enabled = !btnAgregarEquipos.Enabled;
            btnPoliticas.Enabled = !btnPoliticas.Enabled;
            grvDetalle.OptionsBehavior.ReadOnly = !grvDetalle.OptionsBehavior.ReadOnly;



            if (intModo == 0 || intModo == 3)
            {
                txtVersion.Enabled = !txtVersion.Enabled;
            }
        }

        #endregion

        #region Funciones Publicas
        #region Constructores
        public frmCotizacionesD()
        {
            InitializeComponent();
        }

        #endregion
        #region Funciones de Inicio

        public bool NuevoDetalle()
        {
            intModo = 0;
            idOrigen = 0;
            this.ShowDialog();
            return blnRespuesta;
        }

        public bool ConsultarDetalle(int _intId, int _intPermiso)
        {
            intId = _intId;
            intPermiso = _intPermiso;
            intModo = 1;
            this.ShowDialog();
            return blnRespuesta;
        }

        public bool UnirCotizaciones(int[] cotizaciones)
        {
            intModo = 5;
            idOrigen = 0;
            cotizacionesSeleccionadas = cotizaciones;
            this.ShowDialog();
            return blnRespuesta;
        }

        public bool EditarDetalle(int intID, int intOrigen)
        {
            intId = intID;
            idOrigen = intOrigen;
            intModo = 1;
            this.ShowDialog();
            return blnRespuesta;
        }

        public bool Versionar(int intID, int intOrigen)
        {

            intId = intID;
            idOrigen = intOrigen;
            intModo = 2;
            this.ShowDialog();
            return blnRespuesta;
        }

        public bool CotizarServicio(DataTable serviciosSinCotizar)
        {
            dtServiciosSinCotizar = serviciosSinCotizar;
            intModo = 3;
            idOrigen = 0;
            this.ShowDialog();
            return blnRespuesta;
        }

        public bool ModificarPrecios(int intID, int intOrigen)
        {
            intId = intID;
            idOrigen = intOrigen;
            intModo = 6;
            this.ShowDialog();
            return blnRespuesta;
        }

        #endregion

        #endregion

        private void Guardar()
        {
            try
            {
                BE.CotizacionesBE objBE = new BE.CotizacionesBE();
                BP.CotizacionesBP objBP = new BP.CotizacionesBP();

                objBE.Version = Modulo.ConvertInt(txtVersion.Text);
                objBE.Responsable = Modulo.ConvertInt(cmbResponsable.EditValue.ToString());
                DateTime fecha = Convert.ToDateTime(dtFecha.DateTime).Date;
                objBE.Fecha = fecha;
                DateTime vigencia = Convert.ToDateTime(dtVigencia.DateTime).Date;
                objBE.Vigencia = vigencia;
                objBE.Cliente = int.Parse(cmbCliente.EditValue.ToString());
                objBE.Contacto = int.Parse(cmbContacto.EditValue.ToString());
                objBE.Observaciones = txtObservaciones.Text;

                objBE.Subtotal = Modulo.ConvertDecimal(txtSubtotal.Text.Substring(1));

                //decimal descuentoVal = Modulo.ConvertDecimal(txtPorcentaje.Text.Replace("%", ""));

                objBE.Iva = Modulo.ConvertDecimal(txtIva.Text.Substring(1));
                objBE.TotalNeto = Modulo.ConvertDecimal(txtTotalNeto.Text);
                //DateTime fechaToday = DateTime.Now;
                //objBE.Fecha = fechaToday;
                objBE.IdUsuario = Modulo.IdUsuario;
                objBE.Partidas = grvDetalle.RowCount;

                //if (politicas == null)
                //{
                //    DataTable dtDatosEmpresa = new DataTable();
                //    dtDatosEmpresa = Modulo.cBP.Seleccionar("CALL SP_EMPRESA_SELECCIONAR()");

                //    if (dtDatosEmpresa.Rows.Count > 0)
                //    {

                //        politicas = dtDatosEmpresa.Rows[0]["politicas"].ToString();
                //    }
                //}
                objBE.Politicas = politicas;
                objBE.Partidas = dtDatos.Rows.Count;

                foreach (DataRow row in dtDatos.Rows)
                {
                    objBE.Precios += $"{row["precio"]}¬";
                    objBE.Descuentos += $"{row["descuento"]}¬";
                    objBE.Importes += $"{row["importe"]}¬";
                    objBE.Cantidad += $"{row["cantidad"]}¬";
                    objBE.Descripcion += $"{row["descripcion"]}¬";
                    objBE.TiempoEntrega += $"{row["tiempo_entrega"]}¬";
                }

                objBE.Precios = string.Empty;
                objBE.Descuentos = string.Empty;
                objBE.Importes = string.Empty;
                objBE.Cantidad = string.Empty;
                objBE.Descripcion = string.Empty;
                objBE.TiempoEntrega = string.Empty;

                for (int i = 0; i < grvDetalle.RowCount; i++)
                {

                    objBE.Precios += grvDetalle.GetRowCellValue(i, "precio").ToString() + "¬";
                    objBE.Descuentos += grvDetalle.GetRowCellValue(i, "descuento").ToString() + "¬";
                    objBE.Importes += grvDetalle.GetRowCellValue(i, "importe").ToString() + "¬";
                    objBE.Cantidad += grvDetalle.GetRowCellValue(i, cCantidad).ToString() + "¬";
                    objBE.Descripcion += grvDetalle.GetRowCellValue(i, cDescripcion).ToString() + "¬";
                    objBE.TiempoEntrega += grvDetalle.GetRowCellValue(i, cTiempo_Entrega).ToString() + "¬";
                }

                //if (vigencia < fechaToday)
                //{
                //    MessageBox.Show("Lo sentimos la fecha de vigencia no puede ser menor a la fecha de la cotización", "Cotización", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                //if (descuentoVal >= Modulo.ConvertDecimal("100.00"))
                //{
                //    MessageBox.Show("Lo sentimos el % de descuento debe ser menor de 100", "Cotización", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                //else
                //{
                if (intModo == 0)
                {
                    objBE.IdCotizacion = 0;
                    objBE.Id_cotizacion_d = 0;
                    intId = objBP.Insertar(objBE);
                }
                else if (intModo == 2)
                {
                    objBE.Version = Modulo.ConvertInt(txtVersion.Text) + 1;
                    objBE.IdCotizacion = intId;
                    objBP.Modificar(objBE);
                }

                intModo = 1;
                Desactivar();
                StatusMenu();
                blnRespuesta = true;
                Modulo.Alertar.MuestraAlerta(1, this);
                //}
            }
            catch (Exception ex)
            {
                Modulo.ShowCatch(ex);
            }
        }

        private void StatusMenu()
        {
            switch (intModo)
            {
                case 0:
                    mnuNuevo.Enabled = false;
                    mnuGuardar.Enabled = true;
                    mnuEditar.Enabled = false;
                    break;
                case 1:
                    mnuNuevo.Enabled = false;
                    mnuEditar.Enabled = true;
                    mnuGuardar.Enabled = false;

                    break;
                case 2:
                    mnuEditar.Enabled = false;
                    mnuNuevo.Enabled = false;
                    mnuGuardar.Enabled = true;
                    txtTiempoEntrega.Text = "3 a 5 Días Hábiles";
                    break;
                case 5:
                    mnuNuevo.Enabled = false;
                    mnuGuardar.Enabled = true;
                    mnuEditar.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void CalcularTotales()
        {
            decimal iva, subtotal, total;

            subtotal = dtDatos.AsEnumerable().Sum(row => row.Field<decimal>("importe"));
            iva = subtotal * porcentajeIva;
            total = subtotal + iva;
            CalcularPartidas();

            txtSubtotal.Text = subtotal.ToString("c2");
            txtIva.Text = iva.ToString("c2");
            txtTotalNeto.Text = total.ToString("c2");
        }

        private void btnEnviarCorreo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if(intId == 0)
                {
                    XtraMessageBox.Show(new XtraMessageBoxArgs()
                    {
                        Caption = "Aviso",
                        Text = "La cotización debe de guardarse antes de poder enviarla.",
                        Icon = SystemIcons.Warning,
                        Buttons = new DialogResult[] { DialogResult.No },
                        MessageBeepSound = MessageBeepSound.Warning,
                    });
                    return;
                }

                if(mnuGuardar.Enabled)
                {
                    XtraMessageBox.Show(new XtraMessageBoxArgs()
                    {
                        Caption = "Aviso",
                        Text = "Primero es necesario guardar los cambios hechos a la cotización.",
                        Icon = SystemIcons.Warning,
                        Buttons = new DialogResult[] { DialogResult.No },
                        MessageBeepSound = MessageBeepSound.Warning,
                    });
                    return;
                }
                
                DialogResult result = XtraMessageBox.Show(new XtraMessageBoxArgs()
                {
                    Caption = "Enviar por correo",
                    Text = "¿Desea enviar la cotización por correo al contacto seleccionado?",
                    Icon = SystemIcons.Question,
                    Buttons = new DialogResult[] { DialogResult.No, DialogResult.Yes},
                    MessageBeepSound = MessageBeepSound.Question,
                });

                if (result != DialogResult.Yes) return;

                Modulo.EnviarCorreoCotizacion(intId);
                Modulo.Alertar.MuestraAlertaCorreo(this);
            }
            catch (Exception ex)
            {
                Modulo.ShowCatch(ex);
            }
            //if (MessageBox.Show("¿Desea enviar la cotización por correo al contacto seleccionado?", "Envio de correos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    try
            //    {
            //        Modulo.EnviarCorreoCotizacion(intId);
            //        Modulo.Alertar.MuestraAlertaCorreo(this);

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(this, "Error sending a report.\n" + ex.ToString());
            //    }
            //}

        }

        private void btnAgregarEquipos_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(txtCantidad.EditValue);
            decimal precio = Convert.ToDecimal(txtPrecio.EditValue),
                porcentajeDescuento = Convert.ToDecimal(txtPorcentaje.EditValue),
                subtotal = precio * cantidad;

            string mensajeValidacion = ValidarAgregarConcepto(cantidad, precio, porcentajeDescuento);
            if (!string.IsNullOrEmpty(mensajeValidacion))
            {
                XtraMessageBox.Show(new XtraMessageBoxArgs()
                {
                    Caption = "Cotización",
                    Text = mensajeValidacion,
                    Buttons = new DialogResult[] { DialogResult.OK },
                    Icon = SystemIcons.Warning,
                    MessageBeepSound = MessageBeepSound.Warning,
                });
                return;
            }

            decimal descuento = porcentajeDescuento * subtotal,
                total = subtotal - descuento;
            //iva = subtotal * porcentajeIva,
            //importe = subtotal + iva;
            //productoIva = total * porcentajeIva,
            //importe = total + productoIva - descuentoTotal;

            DataRow newRow = dtDatos.NewRow();
            newRow["partida"] = par;
            newRow["descripcion"] = txtDescripcion.Text.ToString();
            newRow["precio"] = Modulo.ConvertDecimal(txtPrecio.Text);
            newRow["descuento"] = porcentajeDescuento;
            newRow["importe"] = total;
            newRow["tiempo_entrega"] = txtTiempoEntrega.Text.ToString();
            newRow["cantidad"] = Modulo.ConvertInt(txtCantidad.Text);

            //Agregamos los datos a nuestro grid
            dtDatos.Rows.Add(newRow);

            grdDetalle.DataSource = dtDatos;
            grvDetalle.Focus();
            grvDetalle.MoveLast();

            CalcularTotales();
            //Limpiamos los campos despues de haber insertado
            txtCantidad.EditValue = null;
            txtPrecio.EditValue = null;
            txtPorcentaje.EditValue = null;
            txtTiempoEntrega.EditValue = "3 a 5 Días Hábiles";
            txtDescripcion.EditValue = null;
            txtCantidad.Focus();
            txtCantidad.SelectAll();

            //}
            //else
            //{
            //    MessageBox.Show("Falta algunos datos del Servicio. Revisar Información", "Cotización", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void mnuEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            intModo = 2;
            Desactivar();
            StatusMenu();
        }

        private void btnPoliticas_Click(object sender, EventArgs e)
        {
            frmPoliticas fDetalleP = new frmPoliticas();
            politicas = fDetalleP.ConsultarDetallePolitica(politicas);
        }

        private void grvDetalle_ShownEditor(object sender, EventArgs e)
        {
            GridColumn columna = grvDetalle.FocusedColumn;

            if (columna == cCantidad || columna == cPrecio || columna == cDescuento)
            {
                valorPrevio = Convert.ToDecimal(grvDetalle.GetFocusedRowCellValue(columna));
            }
        }

        private void grvDetalle_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column != cCantidad && e.Column != cPrecio && e.Column != cDescuento) return;

            bool rechazado = false, valorModificado = false;
            decimal valor = Convert.ToDecimal(e.Value);

            if (e.Column != cDescuento && valor <= 0)
            {
                Modulo.ShowError("El valor debe ser mayor a 0.");
                rechazado = true;
            }
            else if (e.Column == cDescuento && valor >= 1)
            {
                valor /= 100;
                if (valor >= 1)
                {
                    Modulo.ShowError("El porcentaje de descuento no puede ser igual o superior a 100%.");
                    rechazado = true;
                }
                else
                {
                    valorModificado = true;
                }
            }

            if (e.Column == cDescuento && valor >= 0.9999M)
            {
                valor = 0.9999M;
                valorModificado = true;
            }

            if (valorModificado)
            {
                grvDetalle.CellValueChanged -= grvDetalle_CellValueChanged;
                try
                {
                    grvDetalle.SetFocusedRowCellValue(e.Column, valor);
                }
                finally
                {
                    grvDetalle.CellValueChanged += grvDetalle_CellValueChanged;
                }
            }

            int cantidad;
            decimal precio, descuentoPorcentaje, importe;

            if (e.Column == cCantidad)
            {
                cantidad = Convert.ToInt32(valor);
                precio = Convert.ToDecimal(grvDetalle.GetFocusedRowCellValue(cPrecio));
                descuentoPorcentaje = Convert.ToDecimal(grvDetalle.GetFocusedRowCellValue(cDescuento));
            }
            else if (e.Column == cPrecio)
            {
                precio = valor;
                cantidad = Convert.ToInt32(grvDetalle.GetFocusedRowCellValue(cCantidad));
                descuentoPorcentaje = Convert.ToDecimal(grvDetalle.GetFocusedRowCellValue(cDescuento));
            }
            else
            {
                descuentoPorcentaje = valor;
                cantidad = Convert.ToInt32(grvDetalle.GetFocusedRowCellValue(cCantidad));
                precio = Convert.ToDecimal(grvDetalle.GetFocusedRowCellValue(cPrecio));
            }

            decimal subtotal = cantidad * precio,
                descuento = descuentoPorcentaje * subtotal;
            importe = subtotal - descuento;


            grvDetalle.CellValueChanged -= grvDetalle_CellValueChanged;
            try
            {
                if (rechazado)
                {
                    grvDetalle.SetFocusedRowCellValue(e.Column, valorPrevio);
                }
                else
                {
                    grvDetalle.SetFocusedRowCellValue(cImporte, importe);
                    CalcularTotales();
                }
            }
            finally
            {
                grvDetalle.CellValueChanged += grvDetalle_CellValueChanged;
            }

            //CalcularTotales();
            //if (e.RowHandle >= 0)
            //{
            //    if (e.Column.Name == "cPrecio" || e.Column.Name == "cDescuento" || e.Column.Name == "cCantidad")
            //    {
            //        decimal descuento = Modulo.ConvertDecimal(grvDetalle.GetRowCellValue(e.RowHandle, cDescuento).ToString());
            //        if (descuento < 100)
            //        {
            //            decimal cantidad = 0, precio = 0, pordesc = 0, importe = 0, importe_total;
            //            cantidad = Modulo.ConvertDecimal(grvDetalle.GetRowCellValue(e.RowHandle, cCantidad).ToString());
            //            precio = Modulo.ConvertDecimal(grvDetalle.GetRowCellValue(e.RowHandle, cPrecio).ToString());
            //            importe = precio * cantidad;
            //            pordesc = Modulo.ConvertDecimal(grvDetalle.GetRowCellValue(e.RowHandle, cDescuento).ToString());
            //            descuento = importe - ((importe * pordesc) / 100);
            //            importe_total = descuento * cantidad;
            //            grvDetalle.SetRowCellValue(e.RowHandle, cImporte, descuento);
            //            CalcularTotales();
            //        }
            //        else
            //        {
            //            grvDetalle.SetRowCellValue(e.RowHandle, cDescuento, 0);
            //            MessageBox.Show("Lo sentimos el % de descuento debe ser menor de 100", "Cotización", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }


            //    }
            //}
        }

        private void mnuNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cmbResponsable.EditValue = null;
            cmbCliente.EditValue = null;    // Esto tambien resetea txtDomiciolio, txtEmail y txtTelefono
            cmbContacto.EditValue = null;

            dtFecha.EditValue = DateTime.Now;
            dtVigencia.EditValue = null;

            txtVersion.EditValue = 1;

            txtCantidad.EditValue = null;
            txtPrecio.EditValue = null;
            txtPorcentaje.EditValue = null;
            txtDescripcion.EditValue = null;

            dtDatos.Clear();

            txtObservaciones.EditValue = null;
            politicas = null;

            CalcularTotales();  // Para resetear totales a $0.00
        }

        private void MuestraDetalleDatos()
        {
            try
            {

                DataTable dtDatosCotizacion = dtDatosCotizacion = Modulo.cBP.Seleccionar($"CALL SP_COTIZACIONES_SELECCIONAR({intId})");

                if (dtDatosCotizacion.Rows.Count > 0)
                {
                    par = Modulo.ConvertInt(dtDatosCotizacion.Rows[0]["partida"].ToString());
                    txtVersion.Text = dtDatosCotizacion.Rows[0]["version"].ToString();
                    cmbResponsable.EditValue = Modulo.ConvertInt(dtDatosCotizacion.Rows[0]["id_responsable"].ToString());
                    dtFecha.Text = dtDatosCotizacion.Rows[0]["fecha"].ToString();
                    dtVigencia.Text = dtDatosCotizacion.Rows[0]["vigencia"].ToString();
                    cmbCliente.EditValue = Modulo.ConvertInt(dtDatosCotizacion.Rows[0]["id_cliente"].ToString());
                    cmbContacto.EditValue = Modulo.ConvertInt(dtDatosCotizacion.Rows[0]["id_contacto"].ToString());
                    txtDomicilio.Text = dtDatosCotizacion.Rows[0]["domicilio_cliente"].ToString();

                    txtObservaciones.Text = dtDatosCotizacion.Rows[0]["observaciones"].ToString();
                    politicas = dtDatosCotizacion.Rows[0]["politicas"].ToString();

                    for (int i = 0; i < dtDatosCotizacion.Rows.Count; i++)
                    {
                        DataRow row = dtDatos.NewRow();
                        row["partida"] = dtDatosCotizacion.Rows[i]["partida"].ToString();
                        row["cantidad"] = dtDatosCotizacion.Rows[i]["cantidad"].ToString();
                        row["precio"] = dtDatosCotizacion.Rows[i]["precio"].ToString();
                        row["descuento"] = dtDatosCotizacion.Rows[i]["descuento"].ToString();
                        row["importe"] = dtDatosCotizacion.Rows[i]["importe"].ToString();
                        row["tiempo_entrega"] = dtDatosCotizacion.Rows[i]["tiempo_entrega"].ToString();
                        row["descripcion"] = dtDatosCotizacion.Rows[i]["descripcion_servicio"].ToString();

                        dtDatos.Rows.Add(row);
                    }
                }
                grdDetalle.DataSource = dtDatos;
                grvDetalle.BestFitColumns();
                CalcularTotales();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private string ValidarAgregarConcepto(int cantidad, decimal precio, decimal porcentajeDescuento)
        {
            if (cantidad <= 0) return "La cantidad debe de ser mayor a 0.";
            if (precio <= 0) return "El precio debe de se mayor a 0";
            if (porcentajeDescuento >= 1) return "El porcentaje de descuento no puede ser igual o superior a 100%.";
            if (string.IsNullOrWhiteSpace(txtTiempoEntrega.Text)) return "Falta especificar el tiempo de entrega.";
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text)) return "Falta la descripción.";
            return null;
        }

        private void CalcularPartidas()
        {
            for (int partida = 1, tamanio = dtDatos.Rows.Count; partida <= tamanio; partida++)
            {
                dtDatos.Rows[partida - 1]["partida"] = partida;
            }
        }

        private string ValidarGuardado()
        {
            //if (dtVigencia.EditValue is null) return "No se registro la fecha de vigencia.";
            if (Convert.ToDateTime(dtVigencia.EditValue).Date < Convert.ToDateTime(dtFecha.EditValue).Date)
                return "La fecha de vigencia no puede ser menor a la fecha de la cotización.";
            if (dtDatos.Rows.Count == 0) return "No se agregaron detalles para cotizar.";
            if (string.IsNullOrEmpty(politicas))
            {
                //DialogResult result = XtraMessageBox.Show(new XtraMessageBoxArgs()
                //{
                //    Caption = "Aviso",
                //    Text = "No se especificaron politicas.\n¿Continuar?",
                //    Icon = SystemIcons.Warning,
                //    Buttons = new DialogResult[] { DialogResult.Yes, DialogResult.No },
                //    MessageBeepSound = MessageBeepSound.Warning,

                //});

                //if (result != DialogResult.Yes) return "Se eligio no continuar";
                return "No se especificaron las politicas.";
            }
            if (dtDatos.AsEnumerable().Sum(row => row.Field<decimal>("importe")) == 0M)
            {
                //DialogResult result = XtraMessageBox.Show(new XtraMessageBoxArgs()
                //{
                //    Caption = "Aviso",
                //    Text = "El importe total es de $0.00.\n¿Continuar?",
                //    Icon = SystemIcons.Warning,
                //    Buttons = new DialogResult[] { DialogResult.Yes, DialogResult.No },
                //    MessageBeepSound = MessageBeepSound.Warning,
                //});

                //if (result != DialogResult.Yes) return "Se eligio no continuar";
                return "El importe es de $0.00";
            }
            return null;
        }
    }
}