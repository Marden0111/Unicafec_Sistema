Imports Unicafec.Datos

Public Class NxTablas

    'Tablas
    Function Listar_Tablas() As DataTable
        Try
            Dim Datos As New DxTablas
            Dim Tabla As New DataTable
            Tabla = Datos.Listar_tablas()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    'Documento de Identidad
    Function Listar_DocIden() As DataTable
        Try
            Dim Datos As New DxTablas
            Dim Tabla As New DataTable
            Tabla = Datos.Listar_DocIden()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'Pais
    Function Listar_Pais() As DataTable
        Try
            Dim Datos As New DxTablas
            Dim Tabla As New DataTable
            Tabla = Datos.Listar_Pais()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function CargarDatos_Pais(Valor As String) As DataTable
        Try
            Dim Datos As New DxTablas
            Dim Tabla As New DataTable
            Tabla = Datos.CargarDatos_Pais(Valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'Departamento
    Function Listar_Departamento() As DataTable
        Try
            Dim Datos As New DxTablas
            Dim Tabla As New DataTable
            Tabla = Datos.Listar_Departamento()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'Provincia
    Function Listar_Provincia() As DataTable
        Try
            Dim Datos As New DxTablas
            Dim Tabla As New DataTable
            Tabla = Datos.Listar_Provincia()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'Distrito
    Function Listar_Distrito() As DataTable
        Try
            Dim Datos As New DxTablas
            Dim Tabla As New DataTable
            Tabla = Datos.Listar_Distrito()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'Via Tipo
    Function Listar_TipoVia() As DataTable
        Try
            Dim Datos As New DxTablas
            Dim Tabla As New DataTable
            Tabla = Datos.Listar_TipoVia()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
