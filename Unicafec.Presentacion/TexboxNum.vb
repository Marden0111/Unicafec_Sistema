Imports System.Drawing

Public Class TexboxNum
    Private _bordercolor As Color = Color.MediumSlateBlue
    Private _borderSize As Integer = 2
    Private _underlinedStyle As Boolean = False

    Private _valor As Double
    Private _simbolo As String

    Public Property Valor As Double
        Get
            Return _valor
        End Get
        Set(value As Double)
            _valor = value
            TextBox1.Text = _simbolo & FormatNumber(_valor)
        End Set
    End Property

    Public Property Simbolo As String
        Get
            Return _simbolo
        End Get
        Set(value As String)
            _simbolo = value
            TextBox1.Text = _simbolo & " " & FormatNumber(_valor)
        End Set
    End Property





    'Diseño del texbox  
    Public Property Bordercolor As Color
        Get
            Return _bordercolor
        End Get
        Set(value As Color)
            _bordercolor = value
            Me.Invalidate()
        End Set
    End Property

    Public Property BorderSize As Integer
        Get
            Return _borderSize
        End Get
        Set(value As Integer)
            _borderSize = value
            Me.Invalidate()
        End Set
    End Property

    Public Property UnderlinedStyle As Boolean
        Get
            Return _underlinedStyle
        End Get
        Set(value As Boolean)
            _underlinedStyle = value
            Me.Invalidate()
        End Set
    End Property

    'Anular metodos de evento
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim graph As Graphics = e.Graphics

        'Dibujar borde
        Using penborder As New Pen(Bordercolor, BorderSize)
            ' Aquí debes agregar el código para dibujar el borde
            ' Por ejemplo:
            penborder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset

            If UnderlinedStyle Then
                graph.DrawLine(penborder, 0, Me.Height - 1, Me.Width, Me.Height - 1)
            Else
                graph.DrawRectangle(penborder, 0, 0, Me.Width - 0.5F, Me.Height - 0.5F)
            End If
        End Using
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        If Me.DesignMode Then
            UpdateControlHeight()
        End If
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        UpdateControlHeight()
    End Sub

    'Metodos privados
    Private Sub UpdateControlHeight()
        If TextBox1.Multiline = False Then
            Dim txtHeigth As Integer = TextRenderer.MeasureText("Text", Me.Font).Height + 1
            TextBox1.Multiline = True
            TextBox1.MinimumSize = New Size(0, txtHeigth)
            TextBox1.Multiline = False

            Me.Height = TextBox1.Height + Me.Padding.Top + Me.Padding.Bottom
        End If
    End Sub
End Class
