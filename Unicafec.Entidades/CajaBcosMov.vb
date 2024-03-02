Public Class CajaBcosMov

    Private _IdReg As Integer
    Private _IdCajBco As String
    Private _Modulo As String
    Private _Codigo As String
    Private _TipMov As String
    Private _IdTipMov As String
    Private _IdSubTipMov As String
    Private _Fecha As Date
    Private _Dia As String
    Private _Mes As String
    Private _Periodo As String
    Private _IdDoc As String
    Private _SerieDoc As String
    Private _NumDoc As String
    Private _Agrupado As String
    Private _IdDocRef As String
    Private _SerieRef As String
    Private _NumRef As String
    Private _IdEnti As String
    Private _Ingreso As Decimal
    Private _Egreso As Decimal
    Private _Moneda As String
    Private _Cambio As String
    Private _TipoCambio As Double
    Private _IngresoMN As Double
    Private _EgresoMN As Double
    Private _IngresoME As Double
    Private _EgresoME As Double
    Private _TipoVoucher As String
    Private _NumVoucher As String
    Private _TipoNumVouc As String
    Private _Orden As String
    Private _UserIngre As String
    Private _FechaIngre As Date
    Private _UserModif As String
    Private _FechaModif As Date

    Public Property IdReg As Integer
        Get
            Return _IdReg
        End Get
        Set(value As Integer)
            _IdReg = value
        End Set
    End Property

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

    Public Property TipMov As String
        Get
            Return _TipMov
        End Get
        Set(value As String)
            _TipMov = value
        End Set
    End Property

    Public Property IdTipMov As String
        Get
            Return _IdTipMov
        End Get
        Set(value As String)
            _IdTipMov = value
        End Set
    End Property

    Public Property IdSubTipMov As String
        Get
            Return _IdSubTipMov
        End Get
        Set(value As String)
            _IdSubTipMov = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(value As Date)
            _Fecha = value
        End Set
    End Property

    Public Property Dia As String
        Get
            Return _Dia
        End Get
        Set(value As String)
            _Dia = value
        End Set
    End Property

    Public Property Mes As String
        Get
            Return _Mes
        End Get
        Set(value As String)
            _Mes = value
        End Set
    End Property

    Public Property Periodo As String
        Get
            Return _Periodo
        End Get
        Set(value As String)
            _Periodo = value
        End Set
    End Property

    Public Property IdDoc As String
        Get
            Return _IdDoc
        End Get
        Set(value As String)
            _IdDoc = value
        End Set
    End Property

    Public Property SerieDoc As String
        Get
            Return _SerieDoc
        End Get
        Set(value As String)
            _SerieDoc = value
        End Set
    End Property

    Public Property NumDoc As String
        Get
            Return _NumDoc
        End Get
        Set(value As String)
            _NumDoc = value
        End Set
    End Property

    Public Property Agrupado As String
        Get
            Return _Agrupado
        End Get
        Set(value As String)
            _Agrupado = value
        End Set
    End Property

    Public Property IdDocRef As String
        Get
            Return _IdDocRef
        End Get
        Set(value As String)
            _IdDocRef = value
        End Set
    End Property

    Public Property SerieRef As String
        Get
            Return _SerieRef
        End Get
        Set(value As String)
            _SerieRef = value
        End Set
    End Property

    Public Property NumRef As String
        Get
            Return _NumRef
        End Get
        Set(value As String)
            _NumRef = value
        End Set
    End Property

    Public Property IdEnti As String
        Get
            Return _IdEnti
        End Get
        Set(value As String)
            _IdEnti = value
        End Set
    End Property

    Public Property Ingreso As Decimal
        Get
            Return _Ingreso
        End Get
        Set(value As Decimal)
            _Ingreso = value
        End Set
    End Property

    Public Property Egreso As Decimal
        Get
            Return _Egreso
        End Get
        Set(value As Decimal)
            _Egreso = value
        End Set
    End Property

    Public Property Moneda As String
        Get
            Return _Moneda
        End Get
        Set(value As String)
            _Moneda = value
        End Set
    End Property

    Public Property Cambio As String
        Get
            Return _Cambio
        End Get
        Set(value As String)
            _Cambio = value
        End Set
    End Property

    Public Property TipoCambio As Double
        Get
            Return _TipoCambio
        End Get
        Set(value As Double)
            _TipoCambio = value
        End Set
    End Property

    Public Property IngresoMN As Double
        Get
            Return _IngresoMN
        End Get
        Set(value As Double)
            _IngresoMN = value
        End Set
    End Property

    Public Property EgresoMN As Double
        Get
            Return _EgresoMN
        End Get
        Set(value As Double)
            _EgresoMN = value
        End Set
    End Property

    Public Property IngresoME As Double
        Get
            Return _IngresoME
        End Get
        Set(value As Double)
            _IngresoME = value
        End Set
    End Property

    Public Property EgresoME As Double
        Get
            Return _EgresoME
        End Get
        Set(value As Double)
            _EgresoME = value
        End Set
    End Property

    Public Property TipoVoucher As String
        Get
            Return _TipoVoucher
        End Get
        Set(value As String)
            _TipoVoucher = value
        End Set
    End Property

    Public Property NumVoucher As String
        Get
            Return _NumVoucher
        End Get
        Set(value As String)
            _NumVoucher = value
        End Set
    End Property

    Public Property TipoNumVouc As String
        Get
            Return _TipoNumVouc
        End Get
        Set(value As String)
            _TipoNumVouc = value
        End Set
    End Property

    Public Property Orden As String
        Get
            Return _Orden
        End Get
        Set(value As String)
            _Orden = value
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
