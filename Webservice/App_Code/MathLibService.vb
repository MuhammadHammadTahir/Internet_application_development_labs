Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
<System.Web.Script.Services.ScriptService()>
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class MathLibService
    Inherits System.Web.Services.WebService

    <WebMethod()>
    Public Function AddNumbers(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 + num2
    End Function

    <WebMethod()>
    Public Function SubtractNumbers(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 - num2
    End Function

    <WebMethod()>
    Public Function MultiplyNumbers(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 * num2
    End Function

    <WebMethod()>
    Public Function DivideNumbers(ByVal num1 As Double, ByVal num2 As Double) As Double
        If num2 = 0 Then
            Throw New ArgumentException("Division by zero is not allowed.")
        End If
        Return num1 / num2
    End Function

End Class