Imports System.ComponentModel
Imports System.Web.Services
Imports System.Web.Services.Protocols

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class pregunta2
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function HelloWorld() As String
        Return "Hola a todos"
    End Function
    'metodos: SincronizarFecharHora que devuelve la fecha hora actual de impuestos
    'ObtenerCrud que recibe como parametros(idambiente,modalidad,nit) y devuelve una cadena: "AB0000345C34521"
    <WebMethod()>
    Public Function SincronizarFechaHora() As DateTime
        Return Now
    End Function

    <WebMethod()>
    Public Function ObtenerCrud(ByVal idambiente As Integer, ByVal modalidad As String, ByVal nit As String) As String
        Return "AB0000345C34521"
    End Function
    'emitirFActura que recibe como parametros: (idambiente (0 produccion 1 prueba),nit(es un entero),cufd(devuelto por el metodo anterior),modalidad(entero),Factura(objeto con los siguientes campos: NIT, RazonSocial, Fecha, NumeroFactura, CUF, TipoDocumento, NombreClient))

    <WebMethod()>
    Public Function EmitirFactura(ByVal idambiente As Integer, ByVal nit As Integer, ByVal cufd As String, ByVal modalidad As Integer, ByVal factura As Factura) As String

        'EmitirFactura devuelve una respuesta que tiene 2 campos: estado y mensaje: estado = "valido" y mensaje = "recibido correctamente" + razonsocial


        Return "valido recibido correctamente" + factura.RazonSocial
    End Function

End Class