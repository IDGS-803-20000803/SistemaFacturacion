using BE;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace wfaIntersem
{
    public partial class frmFacturacionD : XtraForm
    {
        private object valorPrevio;
        //Variable para crear la tabla de Conceptos
        DataTable dtDatosConceptos = new DataTable();
        bool blnRespuesta = false;
        int intId, modo = 0, conceptoId, clienteId;
        decimal porcentajeIva = 0.16M;
        private DataTable dtMetodosPago, dtFormasPago, dtTiposComprobante, dtClientes, dtRegimenesFiscales, dtUnidadesMedidas,
            dtProductosServicios, dtDatosFacturacion;
        private DataSet dtsDatos;

        private FacturasBE objBE;

        public frmFacturacionD()
        {
            InitializeComponent();
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            DesactivarBotones();
            Desactivar();
            ActivarBarraProgreso();
            backgroundWorker1.RunWorkerAsync("inicializar");
        }

        private void DesactivarBotones()
        {
            switch (modo)
            {
                case -1:
                    btnGuardar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnGenerarFactura.Enabled = false;
                    break;
                case 0:
                    btnEditar.Enabled = !btnEditar.Enabled;
                    break;
                case 1:
                    btnGuardar.Enabled = !btnGuardar.Enabled;
                    break;
                case 2:
                    btnGuardar.Enabled = !btnGuardar.Enabled;
                    btnEditar.Enabled = !btnEditar.Enabled;
                    break;
            }
        }

        private void Desactivar()
        {
            cmbMetodoPago.Enabled = !cmbMetodoPago.Enabled;
            cmbCliente.Enabled = !cmbCliente.Enabled;
            SimpleButtonEditarCliente.Enabled = !SimpleButtonEditarCliente.Enabled;
            cmbFormaPago.Enabled = !cmbFormaPago.Enabled;
            cmbTipoComprobante.Enabled = !cmbTipoComprobante.Enabled;
            txtObservacion.Enabled = !txtObservacion.Enabled;
            cmbUsoCFDI.Enabled = !cmbUsoCFDI.Enabled;
            grvConceptos.OptionsBehavior.ReadOnly = !grvConceptos.OptionsBehavior.ReadOnly;
        }

        private void cmbCliente_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbCliente.EditValue == null)
            {
                txtRFC.EditValue = null;
                txtCorreo.EditValue = null;
                txtCalle.EditValue = null;
                txtCiudad.EditValue = null;
                txtColonia.EditValue = null;
                txtCP.EditValue = null;
                txtNoExterior.EditValue = null;
                txtNoInterior.EditValue = null;
                txtCPFiscal.EditValue = null;
                cmbRegimenFiscal.EditValue = null;
                return;
            }

            DataRowView drClientesSeleccionado = (DataRowView)cmbCliente.GetSelectedDataRow();
            txtRFC.Text = Regex.Replace(drClientesSeleccionado["rfc"].ToString(), "\\s+", "");
            txtCorreo.Text = Regex.Replace(drClientesSeleccionado["correo"].ToString(), "\\s+", "");
            txtCalle.Text = Regex.Replace(drClientesSeleccionado["calle"].ToString(), @"\s+", " ");
            txtCiudad.Text = Regex.Replace(drClientesSeleccionado["colonia"].ToString(), @"\s+", " ");
            txtColonia.Text = Regex.Replace(drClientesSeleccionado["colonia"].ToString(), @"\s+", " ");
            txtCP.Text = Regex.Replace(drClientesSeleccionado["codigo_postal"].ToString(), "\\s+", "");
            txtNoExterior.Text = Regex.Replace(drClientesSeleccionado["numero"].ToString(), "\\s+", "");
            txtNoInterior.Text = Regex.Replace(drClientesSeleccionado["numero_int"].ToString(), "\\s+", "");
            txtCPFiscal.Text = Regex.Replace(drClientesSeleccionado["codigo_postal"].ToString(), "\\s+", "");
            cmbRegimenFiscal.EditValue = drClientesSeleccionado["regimen_fiscal_id"].ToString();

        }

        private void cmbRegimenFiscal_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbRegimenFiscal.EditValue != null)
            {
                cmbUsoCFDI.Properties.DataSource = Modulo.GetDataTable($"CALL SP_USO_CFDI_SELECCIONAR({cmbRegimenFiscal.EditValue})");
            }

        }

        private void CrearTabla()
        {
            dtDatosConceptos = new DataTable();

            dtDatosConceptos.Columns.Add("id_factura_detalle", typeof(int));
            dtDatosConceptos.Columns.Add("concepto", typeof(string));
            dtDatosConceptos.Columns.Add("clave_producto", typeof(int));
            dtDatosConceptos.Columns.Add("cantidad", typeof(int));
            dtDatosConceptos.Columns.Add("unidad", typeof(int));
            dtDatosConceptos.Columns.Add("precio_unitario", typeof(decimal));
            dtDatosConceptos.Columns.Add("importe", typeof(decimal));
            dtDatosConceptos.Columns.Add("ivaD", typeof(decimal));
            grdConceptos.DataSource = dtDatosConceptos;

        }

        private void cmbAcciones_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (grvConceptos.FocusedRowHandle == GridControl.NewItemRowHandle) return;

            if (grvConceptos.OptionsBehavior.ReadOnly) return;

            DialogResult resultado = XtraMessageBox.Show(new XtraMessageBoxArgs()
            {
                Caption = "Confirmar",
                Text = "¿Eliminar este detalle?",
                Icon = SystemIcons.Question,
                Buttons = new DialogResult[] {DialogResult.Yes,DialogResult.No},
                MessageBeepSound = MessageBeepSound.Question,
            });

            if (resultado != DialogResult.Yes) return;

            conceptoId = Convert.ToInt32(grvConceptos.GetFocusedRowCellValue(cIdConcepto));

            if (conceptoId == 0)
            {
                grvConceptos.DeleteRow(grvConceptos.FocusedRowHandle);
                return;
            }

            DesactivarBotones();
            Desactivar();
            ActivarBarraProgreso();

            backgroundWorker1.RunWorkerAsync("eliminar_detalle");
            
        }

        private void grvConceptos_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            grvConceptos.CellValueChanged -= grvConceptos_CellValueChanged;
            try
            {
                grvConceptos.SetFocusedRowCellValue(cIdConcepto, 0);
                grvConceptos.SetFocusedRowCellValue(cCantidad, 0);
                grvConceptos.SetFocusedRowCellValue(cPrecio, 0);
                grvConceptos.SetFocusedRowCellValue(cImporte, 0);
            }
            finally
            {
                grvConceptos.CellValueChanged += grvConceptos_CellValueChanged;
            }
        }

        private void grvConceptos_ShownEditor(object sender, EventArgs e)
        {
            if (grvConceptos.FocusedColumn != cAcciones)
            {
                valorPrevio = grvConceptos.GetFocusedRowCellValue(grvConceptos.FocusedColumn);
            }
        }

        private void grvConceptos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            grvConceptos.CellValueChanged -= grvConceptos_CellValueChanged;
            try
            {
                if (grvConceptos.FocusedRowHandle == GridControl.NewItemRowHandle && (e.Column == cCantidad || e.Column == cPrecio))
                {
                    if (string.IsNullOrWhiteSpace(e.Value.ToString()))
                    {
                        grvConceptos.SetFocusedRowCellValue(e.Column, 0);
                    }

                    decimal cantidad = Convert.ToDecimal(grvConceptos.GetFocusedRowCellValue(cCantidad)),
                        precio = Convert.ToDecimal(grvConceptos.GetFocusedRowCellValue(cPrecio));

                    grvConceptos.SetFocusedRowCellValue(cImporte, cantidad * precio);

                    return;
                }


                // Use una estructura if... else porque no me dejo usar switch
                if (e.Column == cConcepto)
                {
                    if (string.IsNullOrEmpty(e.Value.ToString()))
                    {
                        Modulo.ShowError("El concepto no puede estar vacio.");
                        grvConceptos.SetFocusedRowCellValue(cConcepto, valorPrevio);
                    }
                }
                else if (e.Column == cClaveProductos || e.Column == cUnidad)
                {
                    if (e.Value is null || e.Value == DBNull.Value)
                    {
                        Modulo.ShowError("Se debe seleccionar un valor de la lista");
                        grvConceptos.SetFocusedRowCellValue(e.Column, valorPrevio);
                    }
                }
                else if (e.Column == cCantidad || e.Column == cPrecio)
                {
                    bool cambioRechazado = false;
                    object valorObject = e.Value;

                    if (valorObject == DBNull.Value) valorObject = -1;

                    decimal valor = Convert.ToDecimal(valorObject),
                        cantidad, precio, iva, importe;

                    if (valor <= 0)
                    {
                        Modulo.ShowError("El valor debe de ser mayor a 0.");
                        cambioRechazado = true;
                    }

                    if (e.Column == cCantidad)
                    {
                        cantidad = valor;
                        precio = Convert.ToDecimal(grvConceptos.GetFocusedRowCellValue(cPrecio));
                    }
                    else
                    {
                        precio = valor;
                        cantidad = Convert.ToDecimal(grvConceptos.GetFocusedRowCellValue(cCantidad));
                    }

                    importe = cantidad * precio;
                    iva = importe * porcentajeIva;

                    if (!cambioRechazado)
                    {
                        grvConceptos.SetFocusedRowCellValue(cImporte, importe);
                        grvConceptos.SetFocusedRowCellValue(cIva, iva);
                        CalcularSubTotal();
                    }
                    else
                    {
                        grvConceptos.SetFocusedRowCellValue(e.Column, valorPrevio);
                    }
                }

            }
            finally
            {
                grvConceptos.CellValueChanged += grvConceptos_CellValueChanged;
            }

            //if (e.Column.Name == cCantidad.Name || e.Column.Name == cPrecio.Name)
            //{
            //    decimal cantidad = Modulo.ConvertDecimal(grvConceptos.GetFocusedRowCellValue(cCantidad).ToString());
            //    decimal precio = Modulo.ConvertDecimal(grvConceptos.GetFocusedRowCellValue(cPrecio).ToString());
            //    decimal importe = cantidad * precio;
            //    decimal iva = importe * Modulo.ConvertDecimal("0.16");
            //    grvConceptos.SetFocusedRowCellValue(cImporte, importe);
            //    grvConceptos.SetFocusedRowCellValue(cIva, iva);
            //    CalcularSubTotal();
            //}

        }

        private void grvConceptos_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (e.RowHandle != GridControl.NewItemRowHandle) return;

            object concepto = grvConceptos.GetFocusedRowCellValue(cConcepto),
                claveProducto = grvConceptos.GetFocusedRowCellValue(cClaveProductos),
                unidad = grvConceptos.GetFocusedRowCellValue(cUnidad),
                cantidad = grvConceptos.GetFocusedRowCellValue(cCantidad),
                precio = grvConceptos.GetFocusedRowCellValue(cPrecio);

            grvConceptos.ClearColumnErrors();

            if (string.IsNullOrWhiteSpace(concepto.ToString()))
            {
                e.Valid = false;
                grvConceptos.SetColumnError(cConcepto, "El concepto no puede estar vacio.");
            }
            if (claveProducto is null || claveProducto == DBNull.Value)
            {
                e.Valid = false;
                grvConceptos.SetColumnError(cClaveProductos, "Se debe seleccionar un valor de la lista");
            }
            if (unidad is null || unidad == DBNull.Value)
            {
                e.Valid = false;
                grvConceptos.SetColumnError(cUnidad, "Se debe seleccionar un valor de la lista");
            }
            if (!int.TryParse(cantidad.ToString(), out int cantidadOut) || cantidadOut <= 0)
            {
                e.Valid = false;
                grvConceptos.SetColumnError(cCantidad, "El valor debe de ser mayor a 0");
            }
            if (!decimal.TryParse(precio.ToString(), out decimal precioOut) || precioOut <= 0)
            {
                e.Valid = false;
                grvConceptos.SetColumnError(cPrecio, "El valor debe de ser mayor a 0");
            }

            if (e.Valid)
            {
                grvConceptos.ClearColumnErrors();
            }
        }

        private void grvConceptos_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void grvConceptos_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            CalcularSubTotal();
        }

        private void mnuSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void CalcularSubTotal()
        {
            decimal subtotal, iva, total;

            subtotal = dtDatosConceptos.AsEnumerable().Sum(row =>
            {
                object valor = row["importe"];
                if (valor is null || valor == DBNull.Value) valor = 0;
                return Convert.ToDecimal(valor);

            });
            iva = subtotal * porcentajeIva;
            total = subtotal + iva;

            //decimal subtotal1 = 0;
            //decimal ivaSubTotal = 0;
            //decimal total = 0;



            //for (int i = 0; i < grvConceptos.RowCount; i++)
            //{
            //    if (grvConceptos.GetRowCellValue(i, cImporte) != null)
            //    {
            //        subtotal1 += Modulo.ConvertDecimal(grvConceptos.GetRowCellValue(i, cImporte).ToString());
            //    }
            //}
            txtSubTotal.Text = subtotal.ToString("c2");

            //ivaSubTotal = subtotal1 * iva;
            txtIva.Text = iva.ToString("c2");

            //total = subtotal1 + ivaSubTotal;
            txtTotal.Text = total.ToString("c2");

        }

        //private void mnuGenerarfactura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    grvConceptos.PostEditor();
        //    DataTable dtDatosFactura = (DataTable)grdConceptos.DataSource;
        //    if (dtDatosFactura.Rows.Count == 0)
        //    {
        //        MessageBox.Show("No hay datos");
        //    }

        //    for (int i = 0; i < dtDatosFactura.Rows.Count; i++)
        //    {
        //        DataRow dr = dtDatosFactura.Rows[i];


        //        string concepto = dr["concepto"].ToString();
        //        if (concepto == "")
        //        {
        //            MessageBox.Show("Error");
        //        }
        //    }
        //}

        public bool NuevoDetalle()
        {
            modo = 0;
            this.ShowDialog();
            return true;
        }

        public bool ConsultarDetalle(int _intId)
        {

            intId = _intId;
            modo = 1;

            this.ShowDialog();
            return blnRespuesta;


        }

        private void Guardar()
        {

            //BP.FacturasBP objBP = new BP.FacturasBP();
            objBE = new FacturasBE
            {
                //no_factura = Modulo.ConvertInt(txtNoFactura.Text.ToString());
                iva = Modulo.ConvertDecimal(txtIva.Text.ToString()),
                idCliente = Modulo.ConvertInt(cmbCliente.EditValue.ToString()),
                id_metodo_pago = Modulo.ConvertInt(cmbMetodoPago.EditValue.ToString()),
                id_forma_pago = Modulo.ConvertInt(cmbFormaPago.EditValue.ToString()),
                id_tipo_comprobante = Modulo.ConvertInt(cmbTipoComprobante.EditValue.ToString()),
                moneda = txtMoneda.Text,
                id_uso_cfdi = Modulo.ConvertInt(cmbUsoCFDI.EditValue.ToString()),
                RegimenFiscalId = Convert.ToInt32(cmbRegimenFiscal.EditValue),
                sub_total = Modulo.ConvertDecimal(txtSubTotal.Text.ToString()),
                total = Modulo.ConvertDecimal(txtTotal.Text.ToString()),
                observaciones = string.IsNullOrWhiteSpace(Convert.ToString(txtObservacion.EditValue)) ? null : txtObservacion.Text,
                partidas = dtDatosConceptos.Rows.Count,

                MetodoPagoTexto = cmbMetodoPago.Text,
                FormaPagoTexto = cmbFormaPago.Text,
                TipoComprobanteTexto = cmbTipoComprobante.Text,
                RazonSocialTexto = cmbCliente.Text,
                RfcTexto = txtRFC.Text,
                RegimenFiscalTexto = cmbRegimenFiscal.Text,
                CfdiTexto = cmbUsoCFDI.Text,
                CalleTexto = txtCalle.Text,
                NoExteriorTexto = txtNoExterior.Text,
                NoInteriorTexto = txtNoInterior.Text,
                ColoniaTexto = txtColonia.Text,
                CodigoPostalTexto = txtCP.Text,
                CodigoPostalFiscalTexto = txtCPFiscal.Text,
                CiudadTexto = txtCiudad.Text,
                CorreoTexto = txtCorreo.Text,

                ProductosServiciosTexto = string.Empty,
                UnidadesTexto = string.Empty
            };

            EnumerableRowCollection<DataRow> rowsProductosServicios = dtProductosServicios.AsEnumerable(),
                rowsUnidadesMedidas = dtUnidadesMedidas.AsEnumerable();

            foreach (DataRow row in dtDatosConceptos.Rows)
            {
                int claveProductoServicio = Convert.ToInt32(row["clave_producto"]),
                    claveUnidad = Convert.ToInt32(row["unidad"]);

                string productoServicios = (
                    from fila in rowsProductosServicios
                    where fila.Field<int>("id") == claveProductoServicio
                    select fila.Field<string>("descripcion")
                    ).FirstOrDefault(),
                    unidad = (
                    from fila in rowsUnidadesMedidas
                    where fila.Field<int>("id") == claveUnidad
                    select fila.Field<string>("nombre")
                    ).FirstOrDefault();

                objBE.ids_conceptos += $"{Convert.ToInt32(row["id_factura_detalle"])}¬";
                objBE.concepto += $"{row["concepto"]}¬";
                objBE.clave_producto_servicio += $"{claveProductoServicio}¬";
                objBE.ProductosServiciosTexto += $"{productoServicios}¬";
                objBE.claves_unidades += $"{claveUnidad}¬";
                objBE.UnidadesTexto += $"{unidad}¬";
                objBE.cantidad += $"{row["cantidad"]}¬";
                objBE.precio_unitario += $"{row["precio_unitario"]}¬";
                objBE.importe += $"{row["importe"]}¬";
                objBE.ivaD += $"{row["ivaD"]}¬";
            }

            DesactivarBotones();
            Desactivar();
            ActivarBarraProgreso();
            backgroundWorker1.RunWorkerAsync("guardar");
        }

        private async void TimbrarFactura()
        {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs
            {
                Caption = "Error al facturar",
                Buttons = new DialogResult[] { DialogResult.OK, },
                Icon = SystemIcons.Error,
                MessageBeepSound = MessageBeepSound.Error
            };

            modo = 0;
            splashScreenManager1.ShowWaitForm();
            splashScreenManager1.SetWaitFormCaption("Guardando Factura");
            splashScreenManager1.SetWaitFormDescription("Cargando.....");

            DataTable dtDatosEmpresa = Modulo.cBP.Seleccionar("CALL SP_EMPRESA_SELECCIONAR()");

            DataRowView drFormaPago = (DataRowView)cmbFormaPago.GetSelectedDataRow();
            DataRowView drMetodoPago = (DataRowView)cmbMetodoPago.GetSelectedDataRow();
            DataRowView drTipoComprobante = (DataRowView)cmbTipoComprobante.GetSelectedDataRow();

            DocumentoFactura objBE = new DocumentoFactura
            {
                api_token = "36648228bf20062c55bcde7b60aa178bab7dfc6357a93fa1272d7e15ab4dec39",
                serie = "A",
                folio = txtNoFactura.Text,
                formaPagoClave = drFormaPago["forma_pago"].ToString(),
                formaPagoNombre = drFormaPago["descripcion"].ToString(),
                metodoPagoClave = drMetodoPago["metodo_pago"].ToString(),
                metodoPagoNombre = drMetodoPago["descripcion"].ToString(),
                lugarExpedicion = dtDatosEmpresa.Rows[0]["codigo_postal"].ToString(),
                subTotal = Modulo.ConvertDecimal(txtSubTotal.Text),
                totalImpuestosTrasladados = Modulo.ConvertDecimal(txtIva.Text),
                moneda = txtMoneda.Text,
                TipoCambio = 1,
                total = Modulo.ConvertDecimal(txtTotal.Text),
                tipoDeComprobanteClave = drTipoComprobante["tipo_comprobante"].ToString(),
                receptor_rfc = Regex.Replace(txtRFC.Text, "\\s+", ""),
                receptor_nombre = Regex.Replace(cmbCliente.Text, @"\s+", " "),
                receptor_usoCFDI = cmbUsoCFDI.Text,

                conceptos_detalle = new List<DocumentoFactura.DetalleSat>(),
                impuestos_detalle = new List<DocumentoFactura.ImpuestosSat>()
            };

            for (int i = 0; i < grvConceptos.DataRowCount; i++)
            {
                DocumentoFactura.DetalleSat detalle = new DocumentoFactura.DetalleSat();
                DataRowView drUnidadMedida = (DataRowView)cmbUnidad.GetRowByKeyValue(Modulo.ConvertInt(grvConceptos.GetRowCellValue(i, cUnidad).ToString()));
                DataRowView drClaveUnidad = (DataRowView)cmbProductoServicio.GetRowByKeyValue(Modulo.ConvertInt(grvConceptos.GetRowCellValue(i, cClaveProductos).ToString()));

                detalle.informacion.claveProdServ = drClaveUnidad["clave_producto"].ToString();
                detalle.informacion.cantidad = Modulo.ConvertDecimal(grvConceptos.GetRowCellValue(i, cCantidad).ToString());
                detalle.informacion.claveUnidad = detalle.informacion.unidad = drUnidadMedida["clave_unidad"].ToString();
                //detalle.informacion.unidad = drUnidadMedida["nombre"].ToString();
                detalle.informacion.noIdentificacion = drUnidadMedida["clave_unidad"].ToString();
                detalle.informacion.descripcion = grvConceptos.GetRowCellValue(i, cConcepto).ToString().TrimEnd().TrimStart();
                detalle.informacion.valorUnitario = Modulo.ConvertDecimal(grvConceptos.GetRowCellValue(i, cPrecio).ToString());
                detalle.informacion.importe = Modulo.ConvertDecimal(grvConceptos.GetRowCellValue(i, cImporte).ToString());

                detalle.impuestos_trasladados = new List<DocumentoFactura.ImpuestosSat>();

                DocumentoFactura.ImpuestosSat impuesto = new DocumentoFactura.ImpuestosSat();
                impuesto.base_ = Modulo.ConvertDecimal(grvConceptos.GetRowCellValue(i, cImporte).ToString());
                impuesto.impuesto = "002";
                impuesto.tipoFactor = "Tasa";
                impuesto.TasaOCuota = porcentajeIva.ToString("N6");
                impuesto.importe = Modulo.ConvertDecimal(grvConceptos.GetRowCellValue(i, cImporte).ToString()) - (Modulo.ConvertDecimal(grvConceptos.GetRowCellValue(i, cImporte).ToString()) * Modulo.ConvertDecimal("0.84"));
                //se adjunta a la lista impuestos traslados
                detalle.impuestos_trasladados.Add(impuesto);
                objBE.conceptos_detalle.Add(detalle);

            }

            DocumentoFactura.ImpuestosSat impuesto_trasladado = new DocumentoFactura.ImpuestosSat();
            impuesto_trasladado.base_ = Modulo.ConvertDecimal(txtSubTotal.EditValue.ToString());
            impuesto_trasladado.impuesto = "002";
            impuesto_trasladado.tipoFactor = "Tasa";
            impuesto_trasladado.TasaOCuota = porcentajeIva.ToString("N6");
            impuesto_trasladado.importe = Modulo.ConvertDecimal(txtSubTotal.EditValue.ToString()) * Modulo.ConvertDecimal("0.16");
            objBE.impuestos_detalle.Add(impuesto_trasladado);

            objBE.conceptos = JsonConvert.SerializeObject(objBE.conceptos_detalle);
            objBE.impuestos = JsonConvert.SerializeObject(objBE.impuestos_detalle);
            objBE.exportacion = 01;
            objBE.c_periodicidad = 02;
            objBE.receptor_domicilioFiscal = txtCPFiscal.Text;
            objBE.receptor_regimenFiscal = Modulo.ConvertInt(cmbRegimenFiscal.Text);
            string json = JsonConvert.SerializeObject(objBE);
            json = json.Replace("base_", "base");

            Uri u = new Uri("http://factura-test.sdib.com.mx/public/api/facturacion/create");

            HttpContent c = new StringContent(json, Encoding.UTF8, "application/json");

            splashScreenManager1.SetWaitFormCaption("Timbrando Factura");

            using (var client = new HttpClient())
            {
                HttpResponseMessage result = await client.PostAsync(u, c);
                if (result.IsSuccessStatusCode)
                {
                    //Validamos el response_flag
                    var response = await result.Content.ReadAsStringAsync();
                    RespuestaServidor respuesta = JsonConvert.DeserializeObject<RespuestaServidor>(response);
                    if (respuesta.response_flag == 1)
                    {
                        BE.FacturasBE objBE1 = new BE.FacturasBE();
                        BP.FacturasBP objBP = new BP.FacturasBP();

                        objBE1.cadena_original_sat = respuesta.response.data.cadenaOriginalSAT;
                        objBE1.certificado_sat = respuesta.response.data.noCertificadoSAT;
                        objBE1.certificado_cfdi = respuesta.response.data.noCertificadoCFDI;
                        objBE1.uuid = respuesta.response.data.uuid;
                        objBE1.sello_sat = respuesta.response.data.selloSAT;
                        objBE1.sello_cfdi = respuesta.response.data.selloCFDI;
                        objBE1.fecha_timbrado = respuesta.response.data.fechaTimbrado;
                        objBE1.qr_code = respuesta.response.data.qrCode;
                        objBE1.cfdi = respuesta.response.data.cfdi;
                        objBE1.id = intId;

                        objBP.TimbrarFactura(objBE1);
                        splashScreenManager1.CloseWaitForm();
                        Close();
                    }
                    else
                    {
                        //ocurrioErrorTimbrando = true;
                        //MessageBox.Show($"OCURRIO UN ERROR AL TIMBRAR EL XML {respuesta.trace.ToUpper()}", "FACTURACIÓN");

                        if (splashScreenManager1.IsSplashFormVisible)
                        {
                            splashScreenManager1.CloseWaitForm();
                        }
                        args.Text = $"OCURRIO UN ERROR AL TIMBRAR EL XML {respuesta.trace.ToUpper()}";
                    }
                }
                else
                {
                    //ocurrioErrorTimbrando = true;

                    //MessageBox.Show("OCURRIO UN ERROR AL TIMBRAR EL XML", "FACTURACIÓN");
                    if (splashScreenManager1.IsSplashFormVisible)
                    {
                        splashScreenManager1.CloseWaitForm();
                    }
                    args.Text = $"OCURRIO UN ERROR AL TIMBRAR EL XML. NOT_SUCCESSFUL";
                }
            }

            if (!string.IsNullOrWhiteSpace(args.Text))
            {
                XtraMessageBox.Show(args);
            }
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!dxValidationProvider1.Validate()) return;

            //if (dtDatosConceptos.Rows.Count == 0)
            //{
            //    Modulo.ShowError("No se ingresaron detalles.");
            //    return;
            //}

            Guardar();
        }

        private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            modo = 2;
            Desactivar();
            DesactivarBotones();
            //guardar();
        }

        private void SimpleButtonEditarCliente_Click(object sender, EventArgs e)
        {
            if (cmbCliente.EditValue is null)
            {
                Modulo.ShowAviso("No se ha seleccionado un cliente");
                return;
            }

            clienteId = Convert.ToInt32(cmbCliente.EditValue);

            frmClientesD frmClientesD = new frmClientesD();
            if (frmClientesD.EditarDetalle(clienteId, 7))
            {
                DesactivarBotones();
                Desactivar();
                ActivarBarraProgreso();
                backgroundWorker1.RunWorkerAsync("cliente_editado");
            }
        }

        private void btnGenerarFactura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!dxValidationProvider1.Validate()) return;

            if (dtDatosConceptos.Rows.Count == 0)
            {
                Modulo.ShowError("No se ingresaron detalles.");
                return;
            }

            int miModo = modo;
            modo = -1;
            DesactivarBotones();
            Desactivar();
            ActivarBarraProgreso();
            modo = miModo;

            backgroundWorker1.RunWorkerAsync("guardar_timbrar");

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            e.Result = e.Argument;

            switch (e.Argument.ToString())
            {
                case "inicializar":
                    ObtenerCombos();
                    break;
                case "cargar":
                    ObtenerDetallesDatos();
                    break;
                case "guardar":
                case "guardar_timbrar":
                    if (modo == 0)
                    {
                        objBE.id = 0;
                        intId = new BP.FacturasBP().Insertar(objBE);
                    }
                    else if (modo == 2)
                    {
                        objBE.id = intId;
                        new BP.FacturasBP().Modificar(objBE);
                    }
                    break;
                case "eliminar_detalle":
                    EliminarDetalle();
                    break;
                case "cliente_editado":

                    ObtenerClientes();
                    break;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            ActivarBarraProgreso();

            if (e.Error != null)
            {
                Modulo.ShowCatch(e.Error);
                return;
            }

            grvConceptos.FocusedRowHandle = dtDatosConceptos.Rows.Count > 0 ? 0 : GridControl.InvalidRowHandle;

            switch (e.Result.ToString())
            {
                case "inicializar": //inicializar
                    ColocarCombos();
                    CrearTabla();
                    switch (modo)
                    {
                        case 0:
                            txtFechaFactura.EditValue = DateTime.Now;
                            txtMoneda.Text = "MXN";
                            Desactivar();
                            DesactivarBotones();
                            break;
                        case 1:
                            ActivarBarraProgreso();
                            backgroundWorker1.RunWorkerAsync("cargar");
                            break;
                        case 2:
                            Desactivar();
                            break;
                    }
                    break;
                case "cargar":
                    ColocarDetalleDatos();
                    CalcularSubTotal();
                    //Desactivar();
                    break;
                case "guardar":
                case "guardar_timbrar":

                    if (e.Result.ToString().Equals("guardar_timbrar"))
                    {
                        TimbrarFactura();
                        return;
                    }

                    if (modo == 0)
                    {
                        Modulo.Alertar.MuestraAlerta(1, this);
                        Close();
                    }
                    else if (modo == 2)
                    {
                        Modulo.Alertar.MuestraAlertaModificar(this);
                        //Desactivar();
                        //DesactivarBotones();
                    }
                    break;
                case "eliminar_detalle":
                    grvConceptos.DeleteRow(grvConceptos.FocusedRowHandle);
                    Desactivar();
                    DesactivarBotones();
                    break;
                case "cliente_editado":
                    Desactivar();
                    DesactivarBotones();
                    cmbCliente.EditValue = null;
                    cmbCliente.Properties.DataSource = dtClientes;
                    cmbCliente.EditValue = clienteId;
                    break;
            }
        }

        private void ActivarBarraProgreso()
        {
            if (barEditItem1.Visibility == DevExpress.XtraBars.BarItemVisibility.Always)
            {
                barEditItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            else
            {
                barEditItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }

        private void ObtenerCombos()
        {
            //Métodos de pago
            dtMetodosPago = Modulo.GetDataTable("CALL SP_METODOS_PAGO_SELECCIONAR()");
            //Formas de pago
            dtFormasPago = Modulo.GetDataTable("CALL SP_FORMAS_PAGO_SELECCIONAR()");
            //Tipo de comprobante
            dtTiposComprobante = Modulo.GetDataTable("CALL SP_TIPOS_COMPROBANTE_SELECCIONAR()");
            ObtenerClientes();
            //RegimenFiscal
            dtRegimenesFiscales = Modulo.GetDataTable("CALL SP_REGIMENES_FISCAL_SELECCIONAR()");
            //Unidad de medida
            dtUnidadesMedidas = Modulo.GetDataTable("CALL SP_UNIDADES_SELECCIONAR()");
            //Productos o servicios
            dtProductosServicios = Modulo.GetDataTable("CALL SP_PRODUCTOS_SERVICIO_SELECCIONAR()");
        }

        private void ObtenerClientes()
        {
            //Cliente
            dtClientes = Modulo.cBP.Seleccionar("CALL SP_CLIENTES_FACTURAS_SELECCIONAR()");
        }

        private void ObtenerDetallesDatos()
        {
            dtsDatos = Modulo.GetDataSet($"CALL SP_FACTURAS_SELECCIONAR({intId})");
            //dtDatosFacturacion = Modulo.GetDataTable($"CALL SP_FACTURAS_SELECCIONAR({intId})");
        }

        private void ColocarCombos()
        {
            //Métodos de pago
            cmbMetodoPago.Properties.DataSource = dtMetodosPago;
            //Formas de pago
            cmbFormaPago.Properties.DataSource = dtFormasPago;
            //Tipo de comprobante
            cmbTipoComprobante.Properties.DataSource = dtTiposComprobante;
            //Cliente
            cmbCliente.Properties.DataSource = dtClientes;
            //RegimenFiscal
            cmbRegimenFiscal.Properties.DataSource = dtRegimenesFiscales;
            //Unidad de medida
            cmbUnidad.DataSource = dtUnidadesMedidas;
            //Productos o servicios
            cmbProductoServicio.DataSource = dtProductosServicios;
        }

        private void ColocarDetalleDatos()
        {
            //if (dtDatosFacturacion.Rows.Count == 0) return;

            DataRow rowDatosFacturacion = dtsDatos.Tables[0].Rows[0];

            txtNoFactura.EditValue = Convert.ToInt32(rowDatosFacturacion["no_factura"]);
            txtFechaFactura.EditValue = Convert.ToDateTime(rowDatosFacturacion["fecha"]);
            cmbMetodoPago.EditValue = Convert.ToInt32(rowDatosFacturacion["metodo_pago"]);
            cmbFormaPago.EditValue = Convert.ToInt32(rowDatosFacturacion["forma_pago"]);
            cmbTipoComprobante.EditValue = Convert.ToInt32(rowDatosFacturacion["tipo_comprobante"]);
            txtMoneda.EditValue = Convert.ToString(rowDatosFacturacion["moneda"]);
            txtObservacion.EditValue = rowDatosFacturacion["observaciones"] == DBNull.Value ? null : rowDatosFacturacion["observaciones"].ToString();
            cmbCliente.EditValue = Convert.ToInt32(rowDatosFacturacion["cliente"]);
            cmbRegimenFiscal.EditValue = Convert.ToInt32(rowDatosFacturacion["regimen_fiscal"]);
            // uso_cfdi= Modulo.ConvertInt(rowDatosFacturacion["uso_cfdi"].ToString());
            cmbUsoCFDI.EditValue = Convert.ToInt32(rowDatosFacturacion["uso_cfdi"]);

            dtDatosConceptos = dtsDatos.Tables[1].Copy();

            //foreach (DataRow row in dtDatosFacturacion.Rows)
            //{
            //    DataRow newRow = dtDatosConceptos.NewRow();
            //    newRow["id_factura_detalle"] = Modulo.ConvertInt(row["id_factura_detalle"].ToString());
            //    newRow["concepto"] = row["concepto"].ToString();
            //    newRow["clave_producto"] = row["clave_producto_servicio"].ToString();
            //    newRow["unidad"] = row["unidad"].ToString();
            //    newRow["cantidad"] = Modulo.ConvertDecimal(row["cantidad"].ToString());
            //    newRow["precio_unitario"] = Modulo.ConvertDecimal(row["precio_unitario"].ToString());
            //    newRow["importe"] = Modulo.ConvertDecimal(row["importe"].ToString());
            //    newRow["ivaD"] = Modulo.ConvertDecimal(row["ivaD"].ToString());

            //    dtDatosConceptos.Rows.Add(newRow);
            //}

            grdConceptos.DataSource = dtDatosConceptos;
            grvConceptos.BestFitColumns();

        }

        private void EliminarDetalle()
        {
            new BP.FacturasBP().EliminarDetalle(conceptoId);
        }

    }
}