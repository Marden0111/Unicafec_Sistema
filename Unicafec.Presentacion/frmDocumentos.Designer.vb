<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDocumentos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocumentos))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblFechaModif = New System.Windows.Forms.Label()
        Me.lblUserModif = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblFechaIngre = New System.Windows.Forms.Label()
        Me.lblUserIngre = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.gvoMedioPago = New System.Windows.Forms.GroupBox()
        Me.btnMedioPago = New System.Windows.Forms.PictureBox()
        Me.txtNomMedioPago = New System.Windows.Forms.TextBox()
        Me.txtIdMePa = New System.Windows.Forms.TextBox()
        Me.gvoDocLleva = New System.Windows.Forms.GroupBox()
        Me.chbVencimiento = New System.Windows.Forms.CheckBox()
        Me.chbReferencia = New System.Windows.Forms.CheckBox()
        Me.gvoDatosDoc = New System.Windows.Forms.GroupBox()
        Me.txtAbrevt = New System.Windows.Forms.TextBox()
        Me.txtNomDoc = New System.Windows.Forms.TextBox()
        Me.txtIdDoc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblBuscarID = New System.Windows.Forms.Label()
        Me.lblGuardar = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvRegistrosListado = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gvoMedioPago.SuspendLayout()
        CType(Me.btnMedioPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gvoDocLleva.SuspendLayout()
        Me.gvoDatosDoc.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvRegistrosListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1370, 41)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Turquoise
        Me.Label1.Location = New System.Drawing.Point(11, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Registro de Documentos"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "modificar.png")
        Me.ImageList1.Images.SetKeyName(1, "Nuevo.png")
        Me.ImageList1.Images.SetKeyName(2, "detalle.png")
        Me.ImageList1.Images.SetKeyName(3, "Listar.png")
        Me.ImageList1.Images.SetKeyName(4, "Eliminar.png")
        Me.ImageList1.Images.SetKeyName(5, "flecha-hacia-abajo.png")
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 708)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.gvoMedioPago)
        Me.Panel3.Controls.Add(Me.gvoDocLleva)
        Me.Panel3.Controls.Add(Me.gvoDatosDoc)
        Me.Panel3.Controls.Add(Me.lblBuscarID)
        Me.Panel3.Controls.Add(Me.lblGuardar)
        Me.Panel3.Location = New System.Drawing.Point(14, 115)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1324, 565)
        Me.Panel3.TabIndex = 0
        Me.Panel3.Visible = False
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.lblFechaModif)
        Me.Panel5.Controls.Add(Me.lblUserModif)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Location = New System.Drawing.Point(760, 174)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(145, 131)
        Me.Panel5.TabIndex = 89
        Me.Panel5.Visible = False
        '
        'lblFechaModif
        '
        Me.lblFechaModif.BackColor = System.Drawing.Color.White
        Me.lblFechaModif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFechaModif.Location = New System.Drawing.Point(10, 93)
        Me.lblFechaModif.Name = "lblFechaModif"
        Me.lblFechaModif.Size = New System.Drawing.Size(125, 19)
        Me.lblFechaModif.TabIndex = 18
        Me.lblFechaModif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUserModif
        '
        Me.lblUserModif.BackColor = System.Drawing.Color.White
        Me.lblUserModif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUserModif.Location = New System.Drawing.Point(10, 48)
        Me.lblUserModif.Name = "lblUserModif"
        Me.lblUserModif.Size = New System.Drawing.Size(125, 19)
        Me.lblUserModif.TabIndex = 17
        Me.lblUserModif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 75)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Fecha:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 30)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Usuario:"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(0, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(143, 20)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "MODIFICADO POR:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lblFechaIngre)
        Me.Panel4.Controls.Add(Me.lblUserIngre)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Location = New System.Drawing.Point(760, 23)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(145, 131)
        Me.Panel4.TabIndex = 88
        Me.Panel4.Visible = False
        '
        'lblFechaIngre
        '
        Me.lblFechaIngre.BackColor = System.Drawing.Color.White
        Me.lblFechaIngre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFechaIngre.Location = New System.Drawing.Point(10, 93)
        Me.lblFechaIngre.Name = "lblFechaIngre"
        Me.lblFechaIngre.Size = New System.Drawing.Size(125, 19)
        Me.lblFechaIngre.TabIndex = 18
        Me.lblFechaIngre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUserIngre
        '
        Me.lblUserIngre.BackColor = System.Drawing.Color.White
        Me.lblUserIngre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUserIngre.Location = New System.Drawing.Point(10, 48)
        Me.lblUserIngre.Name = "lblUserIngre"
        Me.lblUserIngre.Size = New System.Drawing.Size(125, 19)
        Me.lblUserIngre.TabIndex = 17
        Me.lblUserIngre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 75)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 30)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Usuario:"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "INGRESADO POR:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 240)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(698, 65)
        Me.GroupBox1.TabIndex = 84
        Me.GroupBox1.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancelar.Location = New System.Drawing.Point(588, 20)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 32)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.Location = New System.Drawing.Point(15, 20)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(94, 32)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'gvoMedioPago
        '
        Me.gvoMedioPago.Controls.Add(Me.btnMedioPago)
        Me.gvoMedioPago.Controls.Add(Me.txtNomMedioPago)
        Me.gvoMedioPago.Controls.Add(Me.txtIdMePa)
        Me.gvoMedioPago.Location = New System.Drawing.Point(279, 157)
        Me.gvoMedioPago.Name = "gvoMedioPago"
        Me.gvoMedioPago.Size = New System.Drawing.Size(445, 66)
        Me.gvoMedioPago.TabIndex = 83
        Me.gvoMedioPago.TabStop = False
        Me.gvoMedioPago.Text = "Medio de Pago:"
        '
        'btnMedioPago
        '
        Me.btnMedioPago.BackColor = System.Drawing.SystemColors.Window
        Me.btnMedioPago.Image = Global.Unicafec.Presentacion.My.Resources.Resources.flecha_hacia_abajo
        Me.btnMedioPago.Location = New System.Drawing.Point(408, 31)
        Me.btnMedioPago.Name = "btnMedioPago"
        Me.btnMedioPago.Size = New System.Drawing.Size(18, 17)
        Me.btnMedioPago.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnMedioPago.TabIndex = 116
        Me.btnMedioPago.TabStop = False
        '
        'txtNomMedioPago
        '
        Me.txtNomMedioPago.BackColor = System.Drawing.SystemColors.Window
        Me.txtNomMedioPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomMedioPago.Location = New System.Drawing.Point(75, 30)
        Me.txtNomMedioPago.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNomMedioPago.MaxLength = 75
        Me.txtNomMedioPago.Name = "txtNomMedioPago"
        Me.txtNomMedioPago.ReadOnly = True
        Me.txtNomMedioPago.Size = New System.Drawing.Size(352, 20)
        Me.txtNomMedioPago.TabIndex = 115
        '
        'txtIdMePa
        '
        Me.txtIdMePa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdMePa.Location = New System.Drawing.Point(15, 30)
        Me.txtIdMePa.MaxLength = 3
        Me.txtIdMePa.Name = "txtIdMePa"
        Me.txtIdMePa.Size = New System.Drawing.Size(50, 20)
        Me.txtIdMePa.TabIndex = 0
        Me.txtIdMePa.Text = "000"
        Me.txtIdMePa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gvoDocLleva
        '
        Me.gvoDocLleva.Controls.Add(Me.chbVencimiento)
        Me.gvoDocLleva.Controls.Add(Me.chbReferencia)
        Me.gvoDocLleva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvoDocLleva.Location = New System.Drawing.Point(26, 157)
        Me.gvoDocLleva.Name = "gvoDocLleva"
        Me.gvoDocLleva.Size = New System.Drawing.Size(236, 66)
        Me.gvoDocLleva.TabIndex = 82
        Me.gvoDocLleva.TabStop = False
        Me.gvoDocLleva.Text = "Documento lleva:"
        '
        'chbVencimiento
        '
        Me.chbVencimiento.AutoSize = True
        Me.chbVencimiento.Location = New System.Drawing.Point(15, 30)
        Me.chbVencimiento.Margin = New System.Windows.Forms.Padding(2)
        Me.chbVencimiento.Name = "chbVencimiento"
        Me.chbVencimiento.Size = New System.Drawing.Size(84, 17)
        Me.chbVencimiento.TabIndex = 0
        Me.chbVencimiento.Text = "Vencimiento"
        Me.chbVencimiento.UseVisualStyleBackColor = True
        '
        'chbReferencia
        '
        Me.chbReferencia.AutoSize = True
        Me.chbReferencia.Location = New System.Drawing.Point(130, 30)
        Me.chbReferencia.Margin = New System.Windows.Forms.Padding(2)
        Me.chbReferencia.Name = "chbReferencia"
        Me.chbReferencia.Size = New System.Drawing.Size(78, 17)
        Me.chbReferencia.TabIndex = 78
        Me.chbReferencia.Text = "Referencia"
        Me.chbReferencia.UseVisualStyleBackColor = True
        '
        'gvoDatosDoc
        '
        Me.gvoDatosDoc.Controls.Add(Me.txtAbrevt)
        Me.gvoDatosDoc.Controls.Add(Me.txtNomDoc)
        Me.gvoDatosDoc.Controls.Add(Me.txtIdDoc)
        Me.gvoDatosDoc.Controls.Add(Me.Label7)
        Me.gvoDatosDoc.Controls.Add(Me.Label3)
        Me.gvoDatosDoc.Controls.Add(Me.Label2)
        Me.gvoDatosDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvoDatosDoc.Location = New System.Drawing.Point(26, 16)
        Me.gvoDatosDoc.Margin = New System.Windows.Forms.Padding(2)
        Me.gvoDatosDoc.Name = "gvoDatosDoc"
        Me.gvoDatosDoc.Padding = New System.Windows.Forms.Padding(2)
        Me.gvoDatosDoc.Size = New System.Drawing.Size(698, 124)
        Me.gvoDatosDoc.TabIndex = 81
        Me.gvoDatosDoc.TabStop = False
        '
        'txtAbrevt
        '
        Me.txtAbrevt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbrevt.Location = New System.Drawing.Point(80, 85)
        Me.txtAbrevt.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAbrevt.MaxLength = 4
        Me.txtAbrevt.Name = "txtAbrevt"
        Me.txtAbrevt.Size = New System.Drawing.Size(60, 19)
        Me.txtAbrevt.TabIndex = 15
        '
        'txtNomDoc
        '
        Me.txtNomDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomDoc.Location = New System.Drawing.Point(80, 55)
        Me.txtNomDoc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNomDoc.MaxLength = 75
        Me.txtNomDoc.Name = "txtNomDoc"
        Me.txtNomDoc.Size = New System.Drawing.Size(600, 19)
        Me.txtNomDoc.TabIndex = 11
        '
        'txtIdDoc
        '
        Me.txtIdDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdDoc.Location = New System.Drawing.Point(80, 25)
        Me.txtIdDoc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdDoc.MaxLength = 2
        Me.txtIdDoc.Name = "txtIdDoc"
        Me.txtIdDoc.Size = New System.Drawing.Size(60, 19)
        Me.txtIdDoc.TabIndex = 10
        Me.txtIdDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 88)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Abreviatura:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 58)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Código:"
        '
        'lblBuscarID
        '
        Me.lblBuscarID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBuscarID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBuscarID.Location = New System.Drawing.Point(941, 55)
        Me.lblBuscarID.Name = "lblBuscarID"
        Me.lblBuscarID.Size = New System.Drawing.Size(70, 19)
        Me.lblBuscarID.TabIndex = 80
        Me.lblBuscarID.Visible = False
        '
        'lblGuardar
        '
        Me.lblGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblGuardar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGuardar.Location = New System.Drawing.Point(941, 23)
        Me.lblGuardar.Name = "lblGuardar"
        Me.lblGuardar.Size = New System.Drawing.Size(70, 19)
        Me.lblGuardar.TabIndex = 78
        Me.lblGuardar.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.dgvRegistrosListado)
        Me.Panel2.Location = New System.Drawing.Point(12, 45)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(447, 34)
        Me.Panel2.TabIndex = 5
        '
        'dgvRegistrosListado
        '
        Me.dgvRegistrosListado.AllowUserToAddRows = False
        Me.dgvRegistrosListado.AllowUserToDeleteRows = False
        Me.dgvRegistrosListado.AllowUserToOrderColumns = True
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRegistrosListado.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvRegistrosListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRegistrosListado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvRegistrosListado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRegistrosListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRegistrosListado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvRegistrosListado.ColumnHeadersHeight = 29
        Me.dgvRegistrosListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRegistrosListado.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvRegistrosListado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRegistrosListado.EnableHeadersVisualStyles = False
        Me.dgvRegistrosListado.Location = New System.Drawing.Point(0, 0)
        Me.dgvRegistrosListado.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvRegistrosListado.Name = "dgvRegistrosListado"
        Me.dgvRegistrosListado.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRegistrosListado.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvRegistrosListado.RowHeadersWidth = 30
        Me.dgvRegistrosListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DodgerBlue
        Me.dgvRegistrosListado.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvRegistrosListado.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRegistrosListado.RowTemplate.Height = 24
        Me.dgvRegistrosListado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvRegistrosListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRegistrosListado.Size = New System.Drawing.Size(443, 30)
        Me.dgvRegistrosListado.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.ItemSize = New System.Drawing.Size(263, 25)
        Me.TabControl1.Location = New System.Drawing.Point(1, 2)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1370, 38)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.ImageIndex = 3
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1362, 5)
        Me.TabPage1.TabIndex = 5
        Me.TabPage1.Text = "Lista"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.ImageIndex = 2
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(1362, 5)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Detalle"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.ImageIndex = 1
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Size = New System.Drawing.Size(1362, 5)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Nuevo"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage4.ForeColor = System.Drawing.Color.Chartreuse
        Me.TabPage4.ImageIndex = 0
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage4.Size = New System.Drawing.Size(1362, 5)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Modificar"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage5.ImageIndex = 4
        Me.TabPage5.Location = New System.Drawing.Point(4, 29)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage5.Size = New System.Drawing.Size(1362, 5)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Eliminar"
        '
        'frmDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmDocumentos"
        Me.Text = "Documentos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.gvoMedioPago.ResumeLayout(False)
        Me.gvoMedioPago.PerformLayout()
        CType(Me.btnMedioPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gvoDocLleva.ResumeLayout(False)
        Me.gvoDocLleva.PerformLayout()
        Me.gvoDatosDoc.ResumeLayout(False)
        Me.gvoDatosDoc.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvRegistrosListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Public WithEvents TabPage2 As TabPage
    Public WithEvents TabPage3 As TabPage
    Public WithEvents TabPage4 As TabPage
    Public WithEvents TabPage5 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvRegistrosListado As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblGuardar As Label
    Friend WithEvents lblBuscarID As Label
    Friend WithEvents gvoDatosDoc As GroupBox
    Friend WithEvents txtAbrevt As TextBox
    Friend WithEvents txtNomDoc As TextBox
    Friend WithEvents txtIdDoc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chbVencimiento As CheckBox
    Friend WithEvents chbReferencia As CheckBox
    Friend WithEvents gvoDocLleva As GroupBox
    Friend WithEvents gvoMedioPago As GroupBox
    Friend WithEvents txtIdMePa As TextBox
    Friend WithEvents btnMedioPago As PictureBox
    Friend WithEvents txtNomMedioPago As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblUserIngre As Label
    Friend WithEvents lblFechaIngre As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblFechaModif As Label
    Friend WithEvents lblUserModif As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
