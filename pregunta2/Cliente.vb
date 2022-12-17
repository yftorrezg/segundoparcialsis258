Friend Class Cliente
    'nit , ci

    Private _nit As String
    Private _ci As String
     
    Public Property Nit As String
        Get
            Return _nit
        End Get
        Set(value As String)
            _nit = value
        End Set
    End Property

    Public Property Ci As String
        Get
            Return _ci
        End Get
        Set(value As String)
            _ci = value
        End Set
    End Property
End Class
