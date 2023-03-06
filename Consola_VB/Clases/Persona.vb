Public Class Persona
    Protected _nombre As String
    Protected _fechaNacimiento As DateTime?

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    Public Property FechaNacimiento As DateTime?
        Get
            Return _fechaNacimiento
        End Get
        Set(ByVal value As DateTime?)
            _fechaNacimiento = value
        End Set
    End Property
    Public ReadOnly Property Edad As Int16
        Get
            Dim _edad As Integer
            Try
                _edad = (DateTime.Now.Year - FechaNacimiento.Value.Year)
                Return _edad
            Catch ex As Exception

            End Try

        End Get
    End Property
    Public Sub New()
        _nombre = String.Empty
        FechaNacimiento = Nothing
    End Sub
    Public Sub New(_nombre As String, _fechaNacimiento As DateTime?)
        Me._nombre = _nombre
        Me._fechaNacimiento = _fechaNacimiento
    End Sub
    Public Overrides Function ToString() As String
        Return _nombre.ToUpper() & " " & Edad
    End Function
End Class