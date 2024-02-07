Imports Unicafec.Datos
Imports Unicafec.Entidades

Public Class NxUsua
    Function Login(Email As String, Clave As String, Usuario As String) As xUsua
        Try
            Dim Usu As New xUsua
            Dim Datos As New DxUsua
            Dim Tabla As New DataTable

            Tabla = Datos.Login(Email, Clave, Usuario)
            If (Tabla.Rows.Count > 0) Then
                Usu.IdUsuario = Tabla.Rows(0).Item(0).ToString
                Usu.IdRol = Tabla.Rows(0).Item(1).ToString
                Usu.Nombre = Tabla.Rows(0).Item(3).ToString
                Usu.Rol = Tabla.Rows(0).Item(2).ToString
                Usu.Estado = Tabla.Rows(0).Item(4).ToString
                Return Usu
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function
End Class
