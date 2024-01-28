Public Class xTablas

    'Campos De Tablas
    Private _Orden As String
    Private _IdTabla As String
    Private _NomTabla As String

    'Campos de Tabla xPais
    Private _IdPais As String
    Private _NomPais As String
    Private _UserIngre As String
    Private _FechaIngre As DateTime
    Private _UserModif As String
    Private _FechaModif As DateTime

    'Campos de Tabla xDocIden
    Private _IdDocIden As String
    Private _NomDocIden As String
    Private _Abrevt As String

    'Campos de Tabla xDepartamento
    Private _IdDep As String
    Private _NomDep As String

    'Campos de Tabla xProvincia
    Private _IdProv As String
    Private _NomProv As String

    'Campos de Tabla xDistrito
    Private _IdDist As String
    Private _NomDist As String

    'Campos de Tabla xTipo Via
    Private _IdTipVia As String
    Private _NomVia As String



    Public Property Orden As String
        Get
            Return _Orden
        End Get
        Set(value As String)
            _Orden = value
        End Set
    End Property

    Public Property IdTabla As String
        Get
            Return _IdTabla
        End Get
        Set(value As String)
            _IdTabla = value
        End Set
    End Property

    Public Property NomTabla As String
        Get
            Return _NomTabla
        End Get
        Set(value As String)
            _NomTabla = value
        End Set
    End Property

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

    Public Property IdDep As String
        Get
            Return _IdDep
        End Get
        Set(value As String)
            _IdDep = value
        End Set
    End Property

    Public Property NomDep As String
        Get
            Return _NomDep
        End Get
        Set(value As String)
            _NomDep = value
        End Set
    End Property

    Public Property IdProv As String
        Get
            Return _IdProv
        End Get
        Set(value As String)
            _IdProv = value
        End Set
    End Property

    Public Property NomProv As String
        Get
            Return _NomProv
        End Get
        Set(value As String)
            _NomProv = value
        End Set
    End Property

    Public Property IdDist As String
        Get
            Return _IdDist
        End Get
        Set(value As String)
            _IdDist = value
        End Set
    End Property

    Public Property NomDist As String
        Get
            Return _NomDist
        End Get
        Set(value As String)
            _NomDist = value
        End Set
    End Property

    Public Property IdTipVia As String
        Get
            Return _IdTipVia
        End Get
        Set(value As String)
            _IdTipVia = value
        End Set
    End Property

    Public Property NomVia As String
        Get
            Return _NomVia
        End Get
        Set(value As String)
            _NomVia = value
        End Set
    End Property
End Class
