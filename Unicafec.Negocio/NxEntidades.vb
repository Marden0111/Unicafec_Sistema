Imports Unicafec.Datos
Imports Unicafec.Entidades

Public Class NxEntidades
    Public Function Listar() As DataTable
        Try
            Dim Datos As New DxEnti
            Dim Tabla As New DataTable
            Tabla = Datos.Listar()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function CargarDatos(Valor As String) As DataTable
        Try
            Dim Datos As New DxEnti
            Dim Tabla As New DataTable
            Tabla = Datos.CargarDatos(Valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function BuscarDocIden(Valor As String) As DataTable
        Try
            Dim Datos As New DxEnti
            Dim Tabla As New DataTable
            Tabla = Datos.BuscarDocIden(Valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function ListarDocIden() As DataTable
        Try
            Dim Datos As New DxEnti
            Dim Tabla As New DataTable
            Tabla = Datos.ListarDocIden()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function BuscarTipVia(Valor As String) As DataTable
        Try
            Dim Datos As New DxEnti
            Dim Tabla As New DataTable
            Tabla = Datos.BuscarTipVia(Valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function ListarTipVia() As DataTable
        Try
            Dim Datos As New DxEnti
            Dim Tabla As New DataTable
            Tabla = Datos.ListarTipVia()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function BuscarPais(Valor As String) As DataTable
        Try
            Dim Datos As New DxEnti
            Dim Tabla As New DataTable
            Tabla = Datos.BuscarPais(Valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function ListarPais() As DataTable
        Try
            Dim Datos As New DxEnti
            Dim Tabla As New DataTable
            Tabla = Datos.ListarPais()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function BuscarDep(Valor As String) As DataTable
        Try
            Dim Datos As New DxEnti
            Dim Tabla As New DataTable
            Tabla = Datos.BuscarDep(Valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function ListarDep() As DataTable
        Try
            Dim Datos As New DxEnti
            Dim Tabla As New DataTable
            Tabla = Datos.ListarDep()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function BuscarProv(Valor As String) As DataTable
        Try
            Dim Datos As New DxEnti
            Dim Tabla As New DataTable
            Tabla = Datos.BuscarProv(Valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function ListarProv() As DataTable
        Try
            Dim Datos As New DxEnti
            Dim Tabla As New DataTable
            Tabla = Datos.ListarProv()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function BuscarDist(Valor As String) As DataTable
        Try
            Dim Datos As New DxEnti
            Dim Tabla As New DataTable
            Tabla = Datos.BuscarDist(Valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function ListarDist() As DataTable
        Try
            Dim Datos As New DxEnti
            Dim Tabla As New DataTable
            Tabla = Datos.ListarDist()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
