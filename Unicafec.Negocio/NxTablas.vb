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

End Class
