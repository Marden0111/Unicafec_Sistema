Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmLogin
    'Verificacion del usuario
    Private Sub Cargar()
        Dim Email As String, Clave As String
        Dim Obj As New Entidades.xUsua
        Dim Neg As New Negocio.NxUsua

        Email = LCase(TxtEmail.Text)
        Clave = txtClave.Text
        Obj = Neg.Login(Email, Clave, Email)
        'Mientras tanto
        If (Obj Is Nothing) Then
            MsgBox("No existe un usuario registrado con estos datos", vbOKOnly + vbCritical, "Datos incorrectos")
        Else
            If (Obj.Estado = False) Then
                MsgBox("El usuario no esta activo", vbOKOnly + vbCritical, "El usuario no tiene acceso")
            Else
                Me.Hide()
                mdiMenu.IdUsuario = Obj.IdUsuario
                Variables.IdUsuario = Obj.IdUsuario
                mdiMenu.IdRol = Obj.IdRol
                mdiMenu.Rol = Obj.Rol
                mdiMenu.Nombre = Obj.Nombre
                mdiMenu.Show()
            End If
        End If
    End Sub

    'Botones
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btbIngresar_Click(sender As Object, e As EventArgs) Handles btbIngresar.Click
        Me.Cargar()
    End Sub

    'Eventos de los texbox
    Private Sub TxtClave_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClave.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Cargar()
        End If
    End Sub

    Private Sub TxtEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtEmail.KeyDown
        If e.KeyCode = Keys.Enter Then

            txtClave.Focus()
        End If
    End Sub

End Class