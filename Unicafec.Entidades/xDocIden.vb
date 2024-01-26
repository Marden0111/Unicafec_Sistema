Public Class xDocIden
    Private _IdDocIden As String
    Private _NomDocIden As String
    Private _Abrevt As String
    Private _UserIngr As String
    Private _FechaIngre As Date
    Private _UserModif As String
    Private _FechaModif As Date

    Public Property IdDocIden As String
        Get
            Return _IdDocIden
        End Get
        Set(value As String)
            _IdDocIden = value
        End Set
    End Property

    Public Property NomDocIden As String
        Get
            Return _NomDocIden
        End Get
        Set(value As String)
            _NomDocIden = value
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

    Public Property UserIngr As String
        Get
            Return _UserIngr
        End Get
        Set(value As String)
            _UserIngr = value
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
