Friend Class DetalleFactura
    'cantidad, producto,preciounitario,preciototal
    Private _cantidad As Integer
    Private _producto As String
    Private _preciounitario As Decimal
    Private _preciototal As Decimal
     
    Public Property Cantidad As Integer
        Get
            Return _cantidad
        End Get
        Set(value As Integer)
            _cantidad = value
        End Set
    End Property
     
    Public Property Producto As String
        Get
            Return _producto
        End Get
        Set(value As String)
            _producto = value
        End Set
    End Property

    Public Property PrecioUnitario As Decimal
        Get
            Return _preciounitario
        End Get
        Set(value As Decimal)
            _preciounitario = value
        End Set
    End Property

    Public Property PrecioTotal As Decimal
        Get
            Return _preciototal
        End Get
        Set(value As Decimal)
            _preciototal = value
        End Set
    End Property
     
     

End Class
