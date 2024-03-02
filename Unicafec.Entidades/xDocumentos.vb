Public Class xDocumentos

    Private _IdDoc As String
    Private _NomDoc As String
    Private _Abrevt As String
    Private _Vencimiento As Boolean
    Private _Referencia As Boolean
    Private _IdMePa As String
    Private _UserIngre As String
    Private _FechaIngre As DateTime
    Private _UserModif As String
    Private _FechaModif As DateTime

    Public Property IdDoc As String
        Get
            Return _IdDoc
        End Get
        Set(value As String)
            _IdDoc = value
        End Set
    End Property

    Public Property NomDoc As String
        Get
            Return _NomDoc
        End Get
        Set(value As String)
            _NomDoc = value
        End Set
    End Property

    Public Property Abrevt As String
        Get
            Return _Abrevt
        End Get
        Set(value As String)
            _Abrevt = value
        End Set
    End Property

    Public Property Vencimiento As Boolean
        Get
            Return _Vencimiento
        End Get
        Set(value As Boolean)
            _Vencimiento = value
        End Set
    End Property

    Public Property Referencia As Boolean
        Get
            Return _Referencia
        End Get
        Set(value As Boolean)
            _Referencia = value
        End Set
    End Property

    Public Property IdMePa As String
        Get
            Return _IdMePa
        End Get
        Set(value As String)
            _IdMePa = value
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
End Class
