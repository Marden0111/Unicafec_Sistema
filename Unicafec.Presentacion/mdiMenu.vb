Imports System.Windows.Forms

Public Class mdiMenu
    Private _IdUsuario As String
    Private _IdRol As String
    Private _Rol As String
    Private _Nombre As String

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Public Property IdUsuario As String
        Get
            Return _IdUsuario
        End Get
        Set(value As String)
            _IdUsuario = value
        End Set
    End Property

    Public Property IdRol As String
        Get
            Return _IdRol
        End Get
        Set(value As String)
            _IdRol = value
        End Set
    End Property

    Public Property Rol As String
        Get
            Return _Rol
        End Get
        Set(value As String)
            _Rol = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Private Sub Entidades_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Entidades_ToolStripMenuItem.Click

        Dim frm As New frmxEntidades
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()

    End Sub

    Private Sub GrupoTablas_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrupoTablas_ToolStripMenuItem.Click
        Dim frm As New frmxTablas
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub tsbTablas_Click(sender As Object, e As EventArgs) Handles tsbTablas.Click
        GrupoTablas_ToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub mdiMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mdiMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles tsbEntidades.Click
        Entidades_ToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub RegistroDeDocumentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeDocumentosToolStripMenuItem.Click
        Dim frm As New frmDocumentos
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub tsbDocumentos_Click(sender As Object, e As EventArgs) Handles tsbDocumentos.Click
        RegistroDeDocumentosToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub RegistroDeCajasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeCajasToolStripMenuItem.Click
        Dim frm As New frmCajaBcosReg101
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub TiposDeMovimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeMovimientosToolStripMenuItem.Click
        Dim frm As New frmCajaBcosMov
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub
End Class
