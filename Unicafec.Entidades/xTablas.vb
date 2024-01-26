Public Class xTablas

#Region "Pais"
    Private _IdPais As String
    Private _NomPais As String
    Private _UserIngre As String
    Private _FechaIngre As DateTime
    Private _UserModif As String
    Private _FechaModif As DateTime

    Public Property IdPais As String
        Get
            Return _IdPais
        End Get
        Set(value As String)
            _IdPais = value
        End Set
    End Property

    Public Property NomPais As String
        Get
            Return _NomPais
        End Get
        Set(value As String)
            _NomPais = value
        End Set
    End Property

    Public Property UserIngre As String
        Get
            Return _UserIngre
        End Get
        Set(value As String)
            _UserIngre = value
        End Set
    End Property

    Public Property FechaIngre As Date
        Get
            Return _FechaIngre
        End Get
        Set(value As Date)
            _FechaIngre = value
        End Set
    End Property

    Public Property UserModif As String
        Get
            Return _UserModif
        End Get
        Set(value As String)
            _UserModif = value
        End Set
    End Property

    Public Property FechaModif As Date
        Get
            Return _FechaModif
        End Get
        Set(value As Date)
            _FechaModif = value
        End Set
    End Property
#End Region

    'Departamento
    'Distrito
    'Provincia
    'Tipo Via
    'DocIden
End Class
