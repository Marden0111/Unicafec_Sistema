Imports Unicafec.Datos

Public Class NCajaBcosMov

    Public Function ListarMovIngresos() As DataTable
        Try
            Dim Datos As New DCajaBcosMov
            Dim Tabla As New DataTable
            Tabla = Datos.ListarMovIngresos()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function ListarMovEgresos() As DataTable
        Try
            Dim Datos As New DCajaBcosMov
            Dim Tabla As New DataTable
            Tabla = Datos.ListarMovEgresos()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
