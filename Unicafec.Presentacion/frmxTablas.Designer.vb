<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmxTablas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmxTablas))
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle43 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle44 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle45 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle46 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle47 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle48 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvCargarDatos = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtRespuesta = New System.Windows.Forms.TextBox()
        Me.lblGuardar = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnSunat = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNomCampo = New System.Windows.Forms.TextBox()
        Me.txtIdCampo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvListado = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnTablas = New System.Windows.Forms.Button()
        Me.lblTablas = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.dgvTablas = New System.Windows.Forms.DataGridView()
        Me.lblIdTabla = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvCargarDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvTablas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "09. Modificar.ico")
        Me.ImageList1.Images.SetKeyName(1, "Nuevo.png")
        Me.ImageList1.Images.SetKeyName(2, "ver.png")
        Me.ImageList1.Images.SetKeyName(3, "Listar.png")
        Me.ImageList1.Images.SetKeyName(4, "Eliminar.png")
        Me.ImageList1.Images.SetKeyName(5, "sunat.png")
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(926, 41)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.dgvCargarDatos)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(926, 583)
        Me.Panel1.TabIndex = 23
        '
        'dgvCargarDatos
        '
        Me.dgvCargarDatos.AllowUserToAddRows = False
        Me.dgvCargarDatos.AllowUserToDeleteRows = False
        Me.dgvCargarDatos.AllowUserToOrderColumns = True
        DataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle37.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCargarDatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle37
        Me.dgvCargarDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCargarDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvCargarDatos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCargarDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgvCargarDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle38.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCargarDatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle38
        Me.dgvCargarDatos.ColumnHeadersHeight = 29
        Me.dgvCargarDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle39.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle39.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCargarDatos.DefaultCellStyle = DataGridViewCellStyle39
        Me.dgvCargarDatos.Enabled = False
        Me.dgvCargarDatos.EnableHeadersVisualStyles = False
        Me.dgvCargarDatos.Location = New System.Drawing.Point(311, 118)
        Me.dgvCargarDatos.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvCargarDatos.Name = "dgvCargarDatos"
        Me.dgvCargarDatos.ReadOnly = True
        Me.dgvCargarDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle40.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCargarDatos.RowHeadersDefaultCellStyle = DataGridViewCellStyle40
        Me.dgvCargarDatos.RowHeadersWidth = 30
        Me.dgvCargarDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle41.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle41.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle41.SelectionBackColor = System.Drawing.Color.DodgerBlue
        Me.dgvCargarDatos.RowsDefaultCellStyle = DataGridViewCellStyle41
        Me.dgvCargarDatos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCargarDatos.RowTemplate.Height = 24
        Me.dgvCargarDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCargarDatos.Size = New System.Drawing.Size(662, 46)
        Me.dgvCargarDatos.TabIndex = 18
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.Controls.Add(Me.txtRespuesta)
        Me.Panel3.Controls.Add(Me.lblGuardar)
        Me.Panel3.Controls.Add(Me.btnCancelar)
        Me.Panel3.Controls.Add(Me.btnGuardar)
        Me.Panel3.Controls.Add(Me.GroupBox4)
        Me.Panel3.Location = New System.Drawing.Point(41, 168)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1324, 381)
        Me.Panel3.TabIndex = 21
        Me.Panel3.Visible = False
        '
        'txtRespuesta
        '
        Me.txtRespuesta.Location = New System.Drawing.Point(200, 15)
        Me.txtRespuesta.Name = "txtRespuesta"
        Me.txtRespuesta.Size = New System.Drawing.Size(323, 20)
        Me.txtRespuesta.TabIndex = 8
        '
        'lblGuardar
        '
        Me.lblGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblGuardar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGuardar.Location = New System.Drawing.Point(712, 45)
        Me.lblGuardar.Name = "lblGuardar"
        Me.lblGuardar.Size = New System.Drawing.Size(88, 19)
        Me.lblGuardar.TabIndex = 7
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancelar.Location = New System.Drawing.Point(595, 158)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 32)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.Location = New System.Drawing.Point(26, 158)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(94, 32)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnSunat)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtNomCampo)
        Me.GroupBox4.Controls.Add(Me.txtIdCampo)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(26, 40)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(662, 96)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos"
        '
        'btnSunat
        '
        Me.btnSunat.ImageKey = "sunat.png"
        Me.btnSunat.ImageList = Me.ImageList1
        Me.btnSunat.Location = New System.Drawing.Point(137, 21)
        Me.btnSunat.Name = "btnSunat"
        Me.btnSunat.Size = New System.Drawing.Size(23, 23)
        Me.btnSunat.TabIndex = 69
        Me.btnSunat.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 57)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Nombre:"
        '
        'txtNomCampo
        '
        Me.txtNomCampo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomCampo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomCampo.Location = New System.Drawing.Point(75, 53)
        Me.txtNomCampo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNomCampo.MaxLength = 150
        Me.txtNomCampo.Name = "txtNomCampo"
        Me.txtNomCampo.Size = New System.Drawing.Size(564, 19)
        Me.txtNomCampo.TabIndex = 4
        '
        'txtIdCampo
        '
        Me.txtIdCampo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCampo.Location = New System.Drawing.Point(75, 23)
        Me.txtIdCampo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdCampo.MaxLength = 3
        Me.txtIdCampo.Name = "txtIdCampo"
        Me.txtIdCampo.Size = New System.Drawing.Size(55, 19)
        Me.txtIdCampo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 27)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Código:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.dgvListado)
        Me.Panel2.Location = New System.Drawing.Point(73, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(365, 70)
        Me.Panel2.TabIndex = 25
        '
        'dgvListado
        '
        Me.dgvListado.AllowUserToAddRows = False
        Me.dgvListado.AllowUserToDeleteRows = False
        Me.dgvListado.AllowUserToOrderColumns = True
        DataGridViewCellStyle42.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle42.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvListado.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle42
        Me.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle43.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle43.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle43
        Me.dgvListado.ColumnHeadersHeight = 29
        Me.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle44.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle44.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListado.DefaultCellStyle = DataGridViewCellStyle44
        Me.dgvListado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListado.EnableHeadersVisualStyles = False
        Me.dgvListado.Location = New System.Drawing.Point(0, 0)
        Me.dgvListado.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.ReadOnly = True
        DataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle45.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle45.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle45.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle45.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle45.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListado.RowHeadersDefaultCellStyle = DataGridViewCellStyle45
        Me.dgvListado.RowHeadersWidth = 30
        Me.dgvListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle46.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle46.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle46.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle46.SelectionBackColor = System.Drawing.Color.DodgerBlue
        Me.dgvListado.RowsDefaultCellStyle = DataGridViewCellStyle46
        Me.dgvListado.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvListado.RowTemplate.Height = 24
        Me.dgvListado.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListado.Size = New System.Drawing.Size(361, 66)
        Me.dgvListado.TabIndex = 21
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
        Me.TabControl1.Location = New System.Drawing.Point(2, 3)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1008, 24)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 26
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.ImageIndex = 3
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1000, 0)
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
        Me.TabPage2.Size = New System.Drawing.Size(1000, 0)
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
        Me.TabPage3.Size = New System.Drawing.Size(1000, 0)
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
        Me.TabPage4.Size = New System.Drawing.Size(1000, 0)
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
        Me.TabPage5.Size = New System.Drawing.Size(1000, 0)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Eliminar"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.btnTablas)
        Me.GroupBox1.Controls.Add(Me.lblTablas)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(213, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(639, 34)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'btnTablas
        '
        Me.btnTablas.BackColor = System.Drawing.SystemColors.Control
        Me.btnTablas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTablas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTablas.Image = CType(resources.GetObject("btnTablas.Image"), System.Drawing.Image)
        Me.btnTablas.Location = New System.Drawing.Point(370, 10)
        Me.btnTablas.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTablas.Name = "btnTablas"
        Me.btnTablas.Size = New System.Drawing.Size(17, 18)
        Me.btnTablas.TabIndex = 29
        Me.btnTablas.UseVisualStyleBackColor = False
        '
        'lblTablas
        '
        Me.lblTablas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTablas.Location = New System.Drawing.Point(5, 9)
        Me.lblTablas.Name = "lblTablas"
        Me.lblTablas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTablas.Size = New System.Drawing.Size(385, 21)
        Me.lblTablas.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(404, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "<= Use el mouse para elegir una tabla"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.White
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Turquoise
        Me.lblTitulo.Location = New System.Drawing.Point(11, 12)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(151, 18)
        Me.lblTitulo.TabIndex = 21
        Me.lblTitulo.Text = "Registro de Paises"
        '
        'dgvTablas
        '
        Me.dgvTablas.AllowUserToAddRows = False
        Me.dgvTablas.AllowUserToDeleteRows = False
        Me.dgvTablas.AllowUserToOrderColumns = True
        Me.dgvTablas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTablas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvTablas.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvTablas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgvTablas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle47.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle47.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle47.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle47.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTablas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle47
        Me.dgvTablas.ColumnHeadersHeight = 25
        Me.dgvTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvTablas.EnableHeadersVisualStyles = False
        Me.dgvTablas.Location = New System.Drawing.Point(170, 8)
        Me.dgvTablas.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvTablas.Name = "dgvTablas"
        Me.dgvTablas.ReadOnly = True
        Me.dgvTablas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle48.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle48.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle48.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTablas.RowHeadersDefaultCellStyle = DataGridViewCellStyle48
        Me.dgvTablas.RowHeadersVisible = False
        Me.dgvTablas.RowHeadersWidth = 51
        Me.dgvTablas.RowTemplate.Height = 24
        Me.dgvTablas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTablas.Size = New System.Drawing.Size(25, 25)
        Me.dgvTablas.TabIndex = 106
        Me.dgvTablas.Visible = False
        '
        'lblIdTabla
        '
        Me.lblIdTabla.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblIdTabla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIdTabla.Location = New System.Drawing.Point(2, 2)
        Me.lblIdTabla.Name = "lblIdTabla"
        Me.lblIdTabla.Size = New System.Drawing.Size(43, 13)
        Me.lblIdTabla.TabIndex = 107
        Me.lblIdTabla.Visible = False
        '
        'frmxTablas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 624)
        Me.Controls.Add(Me.lblIdTabla)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.dgvTablas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmxTablas"
        Me.Text = "Tablas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvCargarDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvTablas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgvCargarDatos As DataGridView
    Friend WithEvents lblGuardar As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNomCampo As TextBox
    Friend WithEvents txtIdCampo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvListado As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Public WithEvents TabPage2 As TabPage
    Public WithEvents TabPage3 As TabPage
    Public WithEvents TabPage4 As TabPage
    Public WithEvents TabPage5 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTablas As Label
    Friend WithEvents btnTablas As Button
    Friend WithEvents dgvTablas As DataGridView
    Friend WithEvents lblIdTabla As Label
    Friend WithEvents btnSunat As Button
    Friend WithEvents txtRespuesta As TextBox
End Class
