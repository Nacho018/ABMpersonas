<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class personasgrid
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(personasgrid))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Personas = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Agregar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.Modificar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.Eliminar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.Salir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumeroDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodPostal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nombreProvincia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodPostalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumeroDocumentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoDocumentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdProvinciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDocumentosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreProvinciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PersonascollectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonascollectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 68)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Personas
        '
        Me.Personas.AutoSize = True
        Me.Personas.Font = New System.Drawing.Font("Papyrus", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Personas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Personas.Location = New System.Drawing.Point(271, 10)
        Me.Personas.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Personas.Name = "Personas"
        Me.Personas.Size = New System.Drawing.Size(183, 58)
        Me.Personas.TabIndex = 1
        Me.Personas.Text = "Personas"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Personas)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1028, 66)
        Me.Panel1.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Agregar, Me.ToolStripLabel1, Me.Modificar, Me.ToolStripLabel2, Me.Eliminar, Me.ToolStripLabel3, Me.Salir, Me.ToolStripLabel4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 66)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStrip1.Size = New System.Drawing.Size(1028, 55)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Agregar
        '
        Me.Agregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Agregar.Image = CType(resources.GetObject("Agregar.Image"), System.Drawing.Image)
        Me.Agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(52, 52)
        Me.Agregar.Text = "Agregar"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(46, 52)
        Me.ToolStripLabel1.Text = "Agregar"
        '
        'Modificar
        '
        Me.Modificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Modificar.Image = CType(resources.GetObject("Modificar.Image"), System.Drawing.Image)
        Me.Modificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(52, 52)
        Me.Modificar.Text = "Modificar"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(50, 52)
        Me.ToolStripLabel2.Text = "Modificar"
        '
        'Eliminar
        '
        Me.Eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Eliminar.Image = CType(resources.GetObject("Eliminar.Image"), System.Drawing.Image)
        Me.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(52, 52)
        Me.Eliminar.Text = "Eliminar"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(43, 52)
        Me.ToolStripLabel3.Text = "Eliminar"
        '
        'Salir
        '
        Me.Salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Salir.Image = CType(resources.GetObject("Salir.Image"), System.Drawing.Image)
        Me.Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(52, 52)
        Me.Salir.Text = "Salir"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(27, 52)
        Me.ToolStripLabel4.Text = "Salir"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Nombre, Me.Direccion, Me.TipoDocumento, Me.NumeroDocumento, Me.CodPostal, Me.nombreProvincia, Me.IdDataGridViewTextBoxColumn, Me.CodPostalDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.NumeroDocumentoDataGridViewTextBoxColumn, Me.TipoDocumentoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.IdProvinciaDataGridViewTextBoxColumn, Me.NombreDocumentosDataGridViewTextBoxColumn, Me.NombreProvinciaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PersonascollectionBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 121)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1028, 628)
        Me.DataGridView1.TabIndex = 4
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Direccion
        '
        Me.Direccion.DataPropertyName = "Direccion"
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        '
        'TipoDocumento
        '
        Me.TipoDocumento.DataPropertyName = "TipoDocumento"
        Me.TipoDocumento.HeaderText = "TipoDocumento"
        Me.TipoDocumento.Name = "TipoDocumento"
        Me.TipoDocumento.ReadOnly = True
        '
        'NumeroDocumento
        '
        Me.NumeroDocumento.DataPropertyName = "NumeroDocumento"
        Me.NumeroDocumento.HeaderText = "NumeroDocumento"
        Me.NumeroDocumento.Name = "NumeroDocumento"
        Me.NumeroDocumento.ReadOnly = True
        '
        'CodPostal
        '
        Me.CodPostal.DataPropertyName = "CodPostal"
        Me.CodPostal.HeaderText = "CodPostal"
        Me.CodPostal.Name = "CodPostal"
        Me.CodPostal.ReadOnly = True
        '
        'nombreProvincia
        '
        Me.nombreProvincia.DataPropertyName = "nombreProvincia"
        Me.nombreProvincia.HeaderText = "nombreProvincia"
        Me.nombreProvincia.Name = "nombreProvincia"
        Me.nombreProvincia.ReadOnly = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodPostalDataGridViewTextBoxColumn
        '
        Me.CodPostalDataGridViewTextBoxColumn.DataPropertyName = "CodPostal"
        Me.CodPostalDataGridViewTextBoxColumn.HeaderText = "CodPostal"
        Me.CodPostalDataGridViewTextBoxColumn.Name = "CodPostalDataGridViewTextBoxColumn"
        Me.CodPostalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumeroDocumentoDataGridViewTextBoxColumn
        '
        Me.NumeroDocumentoDataGridViewTextBoxColumn.DataPropertyName = "NumeroDocumento"
        Me.NumeroDocumentoDataGridViewTextBoxColumn.HeaderText = "NumeroDocumento"
        Me.NumeroDocumentoDataGridViewTextBoxColumn.Name = "NumeroDocumentoDataGridViewTextBoxColumn"
        Me.NumeroDocumentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoDocumentoDataGridViewTextBoxColumn
        '
        Me.TipoDocumentoDataGridViewTextBoxColumn.DataPropertyName = "TipoDocumento"
        Me.TipoDocumentoDataGridViewTextBoxColumn.HeaderText = "TipoDocumento"
        Me.TipoDocumentoDataGridViewTextBoxColumn.Name = "TipoDocumentoDataGridViewTextBoxColumn"
        Me.TipoDocumentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdProvinciaDataGridViewTextBoxColumn
        '
        Me.IdProvinciaDataGridViewTextBoxColumn.DataPropertyName = "IdProvincia"
        Me.IdProvinciaDataGridViewTextBoxColumn.HeaderText = "IdProvincia"
        Me.IdProvinciaDataGridViewTextBoxColumn.Name = "IdProvinciaDataGridViewTextBoxColumn"
        Me.IdProvinciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDocumentosDataGridViewTextBoxColumn
        '
        Me.NombreDocumentosDataGridViewTextBoxColumn.DataPropertyName = "nombreDocumentos"
        Me.NombreDocumentosDataGridViewTextBoxColumn.HeaderText = "nombreDocumentos"
        Me.NombreDocumentosDataGridViewTextBoxColumn.Name = "NombreDocumentosDataGridViewTextBoxColumn"
        Me.NombreDocumentosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreProvinciaDataGridViewTextBoxColumn
        '
        Me.NombreProvinciaDataGridViewTextBoxColumn.DataPropertyName = "nombreProvincia"
        Me.NombreProvinciaDataGridViewTextBoxColumn.HeaderText = "nombreProvincia"
        Me.NombreProvinciaDataGridViewTextBoxColumn.Name = "NombreProvinciaDataGridViewTextBoxColumn"
        Me.NombreProvinciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PersonascollectionBindingSource
        '
        Me.PersonascollectionBindingSource.DataSource = GetType(ABMpersonas.personascollection)
        '
        'personasgrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 749)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "personasgrid"
        Me.Text = "personasgrid"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonascollectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Personas As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Agregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Modificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PersonascollectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodPostal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombreProvincia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodPostalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroDocumentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDocumentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProvinciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDocumentosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreProvinciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
