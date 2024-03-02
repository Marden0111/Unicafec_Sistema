Imports System.Reflection

Public Class frmCajaBcosReg101

    Private Sub ListarCajas()
        Try
            Dim Neg As New Negocio.NCajaBcosReg
            dgvRegistrosListado.DataSource = Neg.ListarCajas
            'Me.Dimensionar_xEnti()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CajaBcosReg101_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ListarCajas()

    End Sub

    Private Sub CajaBcosReg101_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        On Error Resume Next

        TabControl1.Location = New Point(1, 2)
        TabControl1.Size = New Size(Me.Width - 20, 30)
        TabControl1.ItemSize = New Size((TabControl1.Width - 16) / 5, 21)

        Panel2.Location = New Point(2, 24)
        Panel2.Size = New Size(Me.Width - 25, Me.Height - 110)

        'Panel3.Location = New Point(2, 26)
        'Panel3.Size = New Size(Panel2.Width, Panel2.Height)
    End Sub
End Class