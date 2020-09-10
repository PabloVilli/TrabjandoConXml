Imports System.Xml
Imports System.IO
Imports System.Data.SqlClient

Public Class Form1

    Dim conn As SqlConnection = New SqlConnection("Data Source=DSA-PC5\DSA5COMPAC;Initial Catalog=OPENXMLTesting;User ID=sa;Password=dsa")
    Dim a As String
    Dim table As New DataTable
    Dim column As DataColumn
    Dim row, row1, row2 As DataRow
    Dim importeDoc, importeConcep As Double
    Dim rutaInicial As String = "C:\Users\dsa5\Desktop\Compartir\Migracion_Cat\Xml_Facturas\"
    Dim rutaFinal As String = "C:\Users\dsa5\Desktop\Compartir\Migracion_Cat\Xml_Facturas\3_3\"
    Dim rutaFinal1 As String = "C:\Users\dsa5\Desktop\Compartir\Migracion_Cat\Xml_Facturas\3_2\"

    Public Sub MoverArchivos(ByVal archivo As String)

        Dim rutI As String = rutaInicial + archivo
        Dim rutF3 As String = rutaFinal + archivo
        Dim rutF2 As String = rutaFinal1 + archivo

        Dim Version_xml1 As String
        On Error Resume Next
        Dim DocumentoXML As XmlDocument = New XmlDocument()

        Dim VarManager As XmlNamespaceManager = New XmlNamespaceManager(DocumentoXML.NameTable)

        DocumentoXML.Load(rutI)  'Aqui puedes definir la ruta del archivo mediante un OpenFileDialog o  algun otro metodo para especificar la ubicacion del XML

        VarManager.AddNamespace("cfdi", "http://www.sat.gob.mx/cfd/3")
        VarManager.AddNamespace("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital")
        VarManager.AddNamespace("implocal", "http://www.sat.gob.mx/implocal")

        Version_xml1 = DocumentoXML.SelectSingleNode("/cfdi:Comprobante/@Version", VarManager).InnerText

        If Version_xml1 = "3.3" Then

            File.Move(rutI, rutF3)
            
        Else

            File.Move(rutI, rutF2)

        End If

    End Sub

    Public Sub IniciarTable()

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "cfdiUsoCFDI"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "ResidenciaFiscal"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "Email"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "nombre"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "IdExterno"
        table.Columns.Add(column)
       
        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "RFC"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "calle"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "noExterior"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "noInterior"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "colonia"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "localidad"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "municipio"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "estado"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "codigoPostal"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "pais"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "FechaReferencia"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "cfdiFormaPago"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "cfdiMetodoPago"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "TipoCambio"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "Moneda"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "SubTotal"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "Total"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "Observaciones"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "condicionPago"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "LugarExpedicion"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "FolioReferencia"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "Codigo"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "DocPago"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "IvaImporte"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "PUnitario"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "Importe"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "cfdiClaveUnidad"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "cfdiClaveProdServ"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "Cantidad"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "Concepto"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "Renglon"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "cfdiTasaOCuota"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "cfdiTipoFactor"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "cfdiImporte"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "cfdiBase"
        table.Columns.Add(column)

        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "cfdiImpuesto"
        table.Columns.Add(column)

    End Sub

    Public Sub Importar(ByVal aa As String)

        Dim rute As String

        Dim Version_xml As String

        Dim _cfdiUsoCFDI As String
        Dim _ResidenciaFiscal As String
        Dim _Email As String
        Dim _nombre As String
        Dim _IdExterno As String
        Dim _RFC As String
        Dim _calle As String
        Dim _noExterior As String
        Dim _noInterior As String
        Dim _colonia As String
        Dim _localidad As String
        Dim _municipio As String
        Dim _estado As String
        Dim _codigoPostal As String
        Dim _pais As String
        Dim _FechaReferencia As String
        Dim _cfdiFormaPago As String
        Dim _cfdiMetodoPago As String
        Dim _TipoCambio As String
        Dim _Moneda As String
        Dim _SubTotal As String
        Dim _Total As String
        Dim _Observaciones As String
        Dim _condicionPago As String
        Dim _LugarExpedicion As String
        Dim _FolioReferencia As String
        Dim _Codigo As String
        Dim _DocPago As String
        Dim _IvaImporte As String
        Dim _PUnitario As String
        Dim _Importe As String
        Dim _cfdiClaveUnidad As String
        Dim _cfdiClaveProdServ As String
        Dim _Cantidad As String
        Dim _Concepto As String
        Dim _Renglon As String
        Dim _cfdiTasaOCuota As String
        Dim _cfdiTipoFactor As String
        Dim _cfdiImporte As String
        Dim _cfdiBase As String
        Dim _cfdiImpuesto As String
        Dim VarConceptos, VarImpuestos As XmlNodeList
        On Error Resume Next
        Dim DocumentoXML As XmlDocument = New XmlDocument()
        Dim VarManager As XmlNamespaceManager = New XmlNamespaceManager(DocumentoXML.NameTable)

        rute = rutaFinal + aa

        DocumentoXML.Load(rute)  'Aqui puedes definir la ruta del archivo mediante un OpenFileDialog o  algun otro metodo para especificar la ubicacion del XML
        VarManager.AddNamespace("cfdi", "http://www.sat.gob.mx/cfd/3")
        VarManager.AddNamespace("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital")
        VarManager.AddNamespace("implocal", "http://www.sat.gob.mx/implocal")

        Version_xml = DocumentoXML.SelectSingleNode("/cfdi:Comprobante/@Version", VarManager).InnerText

        If Version_xml = "3.3" Then

            Dim nsCFDi As XNamespace = "http://www.sat.gob.mx/cfd/3" 'para que pueda identificar el prefijo CFDI
            Dim archivoXML As XDocument = XDocument.Load(rute) 'selecciona y abre la factura electrónica xml
            Dim importe As Integer = 0 'contador para saber cuantos conceptos tiene la factura

            For Each lconcepto As XElement In archivoXML.Descendants(nsCFDi + "Comprobante").Elements(nsCFDi + "Conceptos").Elements(nsCFDi + "Concepto") 'ciclo que recorre todos los conceptos de la factura

                row = table.NewRow

                _cfdiUsoCFDI = DocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Receptor/@UsoCFDI", VarManager).InnerText
                row("cfdiUsoCFDI") = _cfdiUsoCFDI

                _ResidenciaFiscal = DocumentoXML.SelectSingleNode("", VarManager).InnerText
                row("ResidenciaFiscal") = _ResidenciaFiscal

                _Email = DocumentoXML.SelectSingleNode("", VarManager).InnerText
                row("Email") = _Email

                _nombre = DocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Receptor/@Nombre", VarManager).InnerText
                row("nombre") = _nombre

                _IdExterno = DocumentoXML.SelectSingleNode("", VarManager).InnerText
                row("IdExterno") = _IdExterno

                _RFC = DocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Receptor/@Rfc", VarManager).InnerText
                row("RFC") = _RFC

                _calle = DocumentoXML.SelectSingleNode("", VarManager).InnerText
                row("calle") = _calle

                _noExterior = DocumentoXML.SelectSingleNode("", VarManager).InnerText
                row("noExterior") = _noExterior

                _noInterior = DocumentoXML.SelectSingleNode("", VarManager).InnerText
                row("noInterior") = _noInterior

                _colonia = DocumentoXML.SelectSingleNode("", VarManager).InnerText
                row("colonia") = _colonia

                _localidad = DocumentoXML.SelectSingleNode("", VarManager).InnerText
                row("localidad") = _localidad

                _municipio = DocumentoXML.SelectSingleNode("", VarManager).InnerText
                row("municipio") = _municipio

                _estado = DocumentoXML.SelectSingleNode("", VarManager).InnerText
                row("estado") = _estado

                _codigoPostal = DocumentoXML.SelectSingleNode("", VarManager).InnerText
                row("codigoPostal") = _codigoPostal

                _pais = DocumentoXML.SelectSingleNode("", VarManager).InnerText
                row("pais") = _pais

                _FechaReferencia = DocumentoXML.SelectSingleNode("/cfdi:Comprobante/@Fecha", VarManager).InnerText
                row("FechaReferencia") = _FechaReferencia

                _cfdiFormaPago = DocumentoXML.SelectSingleNode("/cfdi:Comprobante/@FormaPago", VarManager).InnerText
                row("cfdiFormaPago") = _cfdiFormaPago

                _cfdiMetodoPago = DocumentoXML.SelectSingleNode("/cfdi:Comprobante/@MetodoPago", VarManager).InnerText
                row("cfdiMetodoPago") = _cfdiMetodoPago

                _TipoCambio = DocumentoXML.SelectSingleNode("/cfdi:Comprobante/@TipoCambio", VarManager).InnerText
                row("TipoCambio") = _TipoCambio

                _Moneda = DocumentoXML.SelectSingleNode("/cfdi:Comprobante/@Moneda", VarManager).InnerText
                row("Moneda") = _Moneda

                _SubTotal = DocumentoXML.SelectSingleNode("/cfdi:Comprobante/@SubTotal", VarManager).InnerText
                row("SubTotal") = _SubTotal

                _Total = DocumentoXML.SelectSingleNode("/cfdi:Comprobante/@Total", VarManager).InnerText
                row("Total") = _Total

                _Observaciones = DocumentoXML.SelectSingleNode("", VarManager).InnerText
                row("Observaciones") = _Observaciones

                _condicionPago = DocumentoXML.SelectSingleNode("", VarManager).InnerText
                row("condicionPago") = _condicionPago

                _LugarExpedicion = DocumentoXML.SelectSingleNode("/cfdi:Comprobante/@LugarExpedicion", VarManager).InnerText
                row("LugarExpedicion") = _LugarExpedicion

                _FolioReferencia = DocumentoXML.SelectSingleNode("", VarManager).InnerText
                row("FolioReferencia") = _FolioReferencia

                _Codigo = DocumentoXML.SelectSingleNode("", VarManager).InnerText
                row("Codigo") = _Codigo

                _DocPago = DocumentoXML.SelectSingleNode("", VarManager).InnerText
                row("DocPago") = _DocPago

                _IvaImporte = DocumentoXML.SelectSingleNode("", VarManager).InnerText
                row("IvaImporte") = _IvaImporte

                '-----------------------------------------------------------------------------------------------------------------------------------'

                _cfdiClaveProdServ = lconcepto.Attribute("ClaveProdServ").Value
                row("cfdiClaveProdServ") = _cfdiClaveProdServ

                _Cantidad = lconcepto.Attribute("Cantidad")
                row("Cantidad") = _Cantidad

                _cfdiClaveUnidad = lconcepto.Attribute("ClaveUnidad")
                row("cfdiClaveUnidad") = _cfdiClaveUnidad

                _Concepto = lconcepto.Attribute("Descripcion").Value
                row("Concepto") = _Concepto

                _PUnitario = lconcepto.Attribute("ValorUnitario").Value
                row("PUnitario") = _PUnitario

                _Importe = lconcepto.Attribute("Importe")
                row("Importe") = _Importe

                importeDoc = Double.Parse(_Importe)

                importe = importe + 1

                If lconcepto.HasAttributes = True Then

                    For Each lImpuestos As XElement In archivoXML.Descendants(nsCFDi + "Comprobante").Elements(nsCFDi + "Conceptos").Elements(nsCFDi + "Concepto").Elements(nsCFDi + "Impuestos").Elements(nsCFDi + "Traslados").Elements(nsCFDi + "Traslado")

                        _cfdiBase = lImpuestos.Attribute("Base").Value

                        importeConcep = Double.Parse(_cfdiBase)

                        If importeDoc = importeConcep Then

                            _cfdiBase = lImpuestos.Attribute("Base").Value
                            row("cfdiBase") = _cfdiBase

                            _cfdiImpuesto = lImpuestos.Attribute("Impuesto").Value
                            row("cfdiImpuesto") = _cfdiImpuesto

                            _cfdiTipoFactor = lImpuestos.Attribute("TipoFactor").Value
                            row("cfdiTipoFactor") = _cfdiTipoFactor

                            _cfdiTasaOCuota = lImpuestos.Attribute("TasaOCuota").Value
                            row("cfdiTasaOCuota") = _cfdiTasaOCuota

                            _cfdiImporte = lImpuestos.Attribute("Importe").Value
                            row("cfdiImporte") = _cfdiImporte

                        End If
                    Next
                    table.Rows.Add(row)
                End If
                table.Rows.Add(row)
            Next
            lb1.Text = (importe & "  conceptos ")
        Else
            MsgBox("Archivo XML no es una factura version 3.3")
        End If

        dgv1.DataSource = table

    End Sub

    Private Sub LeerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LeerToolStripMenuItem1.Click

        Dim openFile As New OpenFileDialog()
        openFile.InitialDirectory = "C:\Users\dsa5\Desktop\Compartir\Migracion_cAT\Xml_Facturas"
        openFile.Filter = "Xml Files | *.xml"
        openFile.CheckFileExists = True
        openFile.Multiselect = True
        openFile.RestoreDirectory = False
        table.Clear()
        If (openFile.ShowDialog() = Windows.Forms.DialogResult.OK) Then

            For i As Integer = 0 To openFile.SafeFileNames.Count() - 1

                Importar(openFile.SafeFileNames(i))

            Next
            MessageBox.Show("Terminado :D")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IniciarTable()
    End Sub
    
    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Application.Exit()
    End Sub
   
    Private Sub MoverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoverToolStripMenuItem.Click
        Dim openFile As New OpenFileDialog()
        openFile.InitialDirectory = "C:\Users\dsa5\Desktop\Compartir\Migracion_cAT\Xml_Facturas"
        openFile.Filter = "Xml Files | *.xml"
        openFile.CheckFileExists = True
        openFile.Multiselect = True
        openFile.RestoreDirectory = False
        If (openFile.ShowDialog() = Windows.Forms.DialogResult.OK) Then

            For i As Integer = 0 To openFile.SafeFileNames.Count() - 1

                MoverArchivos(openFile.SafeFileNames(i))

            Next
            MessageBox.Show("Terminado :D")
        End If
    End Sub

End Class