Public Class personasForm

    Dim operacion_ As String
    Dim Mipersona As New personasclass

    Public Property operacion() As String


        Get
            Return operacion_


        End Get

        Set(ByVal value As String)

            operacion_ = value

        End Set


    End Property

    Dim indice_ As Byte

    Public Property indice() As String
        Get
            Return indice_

        End Get


        Set(ByVal value As String)
            indice_ = value

        End Set

    End Property
    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click

        Me.Close()

    End Sub


    Private Sub Aceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Aceptar.Click



        Mipersona.Id = CInt(TextBox7.Text)
        Mipersona.Nombre = TextBox1.Text
        Mipersona.Direccion = TextBox2.Text
        Mipersona.CodPostal = CInt(TextBox3.Text)
        Mipersona.IdProvincia = ComboBox1.SelectedIndex
        Mipersona.TipoDocumento = ComboBox2.SelectedIndex
        Mipersona.NumeroDocumento = TextBox4.Text

        'ComboBox2.DataSource = 

        Select Case operacion_

            Case "Agregar"

                lst.insertarPersona(Mipersona)

            Case "Eliminar"


                lst.EliminarPersona(Mipersona)

            Case "Modificar"

                lst.ActualizarPersona(Mipersona)



                personasgrid.DataGridView1.Refresh()



        End Select

        Me.Close()


    End Sub




    Private Sub personasForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ComboBox1.DataSource = Mipersona.provincias
        ComboBox2.DataSource = Mipersona.documentos



        ComboBox1.SelectedIndex = 0

        ComboBox2.SelectedIndex = 0



    End Sub
End Class
