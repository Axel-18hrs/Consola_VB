Public Class Contacto
    Inherits Persona

    Private _telefono As String
    Private _correo As String
    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value.Replace(" ", "").Replace("-", "")
        End Set
    End Property
    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)

            _correo = value
        End Set
    End Property
    Public Sub New()
        MyBase.New()
        _telefono = String.Empty
    End Sub

    Public Sub New(ByVal _name As String, ByVal _fechaNacimiento As DateTime?, ByVal _telefono As String)
        MyBase.New(_name, _fechaNacimiento)
        Me._telefono = _telefono
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString() & " " & _telefono & " " & _correo
    End Function
End Class