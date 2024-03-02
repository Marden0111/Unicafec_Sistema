Imports Unicafec.Datos

Public Class NCajaBcosReg

    Public Function ListarCajas() As DataTable
        Try
            Dim Datos As New DCajaBcosReg
            Dim Tabla As New DataTable
            Tabla = Datos.ListarCajas()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
