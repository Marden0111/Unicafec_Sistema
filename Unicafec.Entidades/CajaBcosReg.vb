Public Class CajaBcosReg

    Private _IdCajBco As String
    Private _Modulo As String
    Private _Codigo As String
    Private _Nombre As String
    Private _NumCta As String
    Private _IdBcos As String
    Private _IdMoneda As String
    Private _Cajero As String
    Private _IdCtaCont As String
    Private _IdSucursal As String
    Private _UserIngr As String
    Private _FechaIngre As Date
    Private _UserModif As String
    Private _FechaModif As Date



    Public Property IdCajBco As String
        Get
            Return _IdCajBco
        End Get
        Set(value As String)
            _IdCajBco = value
        End Set
    End Property

    Public Property Modulo As String
        Get
            Return _Modulo
        End Get
        Set(value As String)
            _Modulo = value
        End Set
    End Property

    Public Property Codigo As String
        Get
            Return _Codigo
        End Get
        Set(value As String)
            _Codigo = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property NumCta As String
        Get
            Return _NumCta
        End Get
        Set(value As String)
            _NumCta = value
        End Set
    End Property

    Public Property IdBcos As String
        Get
            Return _IdBcos
        End Get
        Set(value As String)
            _IdBcos = value
        End Set
    End Property

    Public Property IdMoneda As String
        Get
            Return _IdMoneda
        End Get
        Set(value As String)
            _IdMoneda = value
        End Set
    End Property

    Public Property Cajero As String
        Get
            Return _Cajero
        End Get
        Set(value As String)
            _Cajero = value
        End Set
    End Property

    Public Property IdCtaCont As String
        Get
            Return _IdCtaCont
        End Get
        Set(value As String)
            _IdCtaCont = value
        End Set
    End Property

    Public Property IdSucursal As String
        Get
            Return _IdSucursal
        End Get
        Set(value As String)
            _IdSucursal = value
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
