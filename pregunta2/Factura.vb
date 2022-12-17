Public Class Factura ' factura con los siguientes campos: NIT, RazonSocial, Fecha, NumeroFactura, CUF, TipoDocumento, NombreClient     
    Private _nit As String
    Private _razonsocial As Integer
    Private _fecha As DateTime
    Private _numerofactura As Decimal
    Private _cuf As String

    Private _nombrecliente As String
    'agregar lista detallefactura
    Private _detallefactura As List(Of DetalleFactura)
    Public Property Nit As String
        Get
            Return _nit
        End Get
        Set(value As String)
            _nit = value
        End Set
    End Property

    Public Property RazonSocial As Integer
        Get
            Return _razonsocial
        End Get
        Set(value As Integer)
            _razonsocial = value
        End Set
    End Property

    Public Property Fecha As DateTime
        Get
            Return _fecha
        End Get
        Set(value As DateTime)
            _fecha = value
        End Set
    End Property

    Public Property NumeroFactura As Decimal
        Get
            Return _numerofactura
        End Get
        Set(value As Decimal)
            _numerofactura = value
        End Set
    End Property

    Public Property Cuf As String
        Get
            Return _cuf
        End Get
        Set(value As String)
            _cuf = value
        End Set
    End Property

    Private _TipoDocumento As Cliente

    'Public Function GetTipoDocumento() As Cliente
    'Return _TipoDocumento
    'End Function

    'Public Sub SetTipoDocumento(AutoPropertyValue As Cliente)
    '   _TipoDocumento = AutoPropertyValue
    'End Sub

    Public Property NombreCliente As String
        Get
            Return _nombrecliente
        End Get
        Set(value As String)
            _nombrecliente = value
        End Set
    End Property

    'Public Function GetDetalleFactura() As List(Of DetalleFactura)
    'Return _detallefactura
    'End Function

    'Public Sub SetDetalleFactura(value As List(Of DetalleFactura))
    'If value Is Nothing Then
    'Throw New ArgumentNullException(NameOf(value))
    'End If
    '
    '_detallefactura = value
    ' End Sub
End Class
