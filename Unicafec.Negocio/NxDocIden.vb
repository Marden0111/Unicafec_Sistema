Imports System.Data.SqlClient
Imports Unicafec.Datos
Imports Unicafec.Entidades

Public Class NxDocIden
    Public Function Listar() As DataTable
        Try
            Dim Datos As New DxDocIden
            Dim Tabla As New DataTable
            Tabla = Datos.Listar()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
