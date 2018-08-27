<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class personasForm
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
        Me.Label1Nombreyapellido = New System.Windows.Forms.Label
        Me.Direccion = New System.Windows.Forms.Label
        Me.Codigopostal = New System.Windows.Forms.Label
        Me.Provincia = New System.Windows.Forms.Label
        Me.TipodeDocumento = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Aceptar = New System.Windows.Forms.Button
        Me.Cancelar = New System.Windows.Forms.Button
        Me.Numerodedocumento = New System.Windows.Forms.Label
        Me.Id = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1Nombreyapellido
        '
        Me.Label1Nombreyapellido.AutoSize = True
        Me.Label1Nombreyapellido.Location = New System.Drawing.Point(135, 41)
        Me.Label1Nombreyapellido.Name = "Label1Nombreyapellido"
        Me.Label1Nombreyapellido.Size = New System.Drawing.Size(91, 13)
        Me.Label1Nombreyapellido.TabIndex = 0
        Me.Label1Nombreyapellido.Text = "Nombre y apellido"
        '
        'Direccion
        '
        Me.Direccion.AutoSize = True
        Me.Direccion.Location = New System.Drawing.Point(165, 76)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(52, 13)
        Me.Direccion.TabIndex = 1
        Me.Direccion.Text = "Direccion"
        '
        'Codigopostal
        '
        Me.Codigopostal.AutoSize = True
        Me.Codigopostal.Location = New System.Drawing.Point(149, 104)
        Me.Codigopostal.Name = "Codigopostal"
        Me.Codigopostal.Size = New System.Drawing.Size(68, 13)
        Me.Codigopostal.TabIndex = 2
        Me.Codigopostal.Text = "Codigopostal"
        '
        'Provincia
        '
        Me.Provincia.AutoSize = True
        Me.Provincia.Location = New System.Drawing.Point(166, 139)
        Me.Provincia.Name = "Provincia"
        Me.Provincia.Size = New System.Drawing.Size(51, 13)
        Me.Provincia.TabIndex = 3
        Me.Provincia.Text = "Provincia"
        '
        'TipodeDocumento
        '
        Me.TipodeDocumento.AutoSize = True
        Me.TipodeDocumento.Location = New System.Drawing.Point(125, 173)
        Me.TipodeDocumento.Name = "TipodeDocumento"
        Me.TipodeDocumento.Size = New System.Drawing.Size(101, 13)
        Me.TipodeDocumento.TabIndex = 4
        Me.TipodeDocumento.Text = "Tipo de Documento"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(232, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(85, 20)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(232, 69)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(79, 20)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(232, 97)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(83, 20)
        Me.TextBox3.TabIndex = 7
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(146, 311)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(109, 30)
        Me.Aceptar.TabIndex = 10
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(299, 311)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(117, 29)
        Me.Cancelar.TabIndex = 11
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Numerodedocumento
        '
        Me.Numerodedocumento.AutoSize = True
        Me.Numerodedocumento.Location = New System.Drawing.Point(111, 215)
        Me.Numerodedocumento.Name = "Numerodedocumento"
        Me.Numerodedocumento.Size = New System.Drawing.Size(115, 13)
        Me.Numerodedocumento.TabIndex = 12
        Me.Numerodedocumento.Text = "Numero de documento"
        '
        'Id
        '
        Me.Id.AutoSize = True
        Me.Id.Location = New System.Drawing.Point(189, 9)
        Me.Id.Name = "Id"
        Me.Id.Size = New System.Drawing.Size(16, 13)
        Me.Id.TabIndex = 14
        Me.Id.Text = "Id"
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(245, 6)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(86, 20)
        Me.TextBox7.TabIndex = 15
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(234, 138)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(76, 21)
        Me.ComboBox1.TabIndex = 16
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(231, 173)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(110, 21)
        Me.ComboBox2.TabIndex = 17
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(245, 215)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(108, 20)
        Me.TextBox4.TabIndex = 18
        '
        'personasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 466)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Id)
        Me.Controls.Add(Me.Numerodedocumento)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TipodeDocumento)
        Me.Controls.Add(Me.Provincia)
        Me.Controls.Add(Me.Codigopostal)
        Me.Controls.Add(Me.Direccion)
        Me.Controls.Add(Me.Label1Nombreyapellido)
        Me.Name = "personasForm"
        Me.Text = "personaform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1Nombreyapellido As System.Windows.Forms.Label
    Friend WithEvents Direccion As System.Windows.Forms.Label
    Friend WithEvents Codigopostal As System.Windows.Forms.Label
    Friend WithEvents Provincia As System.Windows.Forms.Label
    Friend WithEvents TipodeDocumento As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Aceptar As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents Numerodedocumento As System.Windows.Forms.Label
    Friend WithEvents Id As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox

End Class
