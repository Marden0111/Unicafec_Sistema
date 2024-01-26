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
End Class
