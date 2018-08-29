Public Class personasgrid

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click


        personasForm.operacion = "Agregar"

        personasForm.Text = "Alta de persona"

        personasForm.Show()


    End Sub

    Private Sub modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click
        If lst.Count = 0 Then Exit Sub

        personasForm.operacion = "Modificar"

        personasForm.Text = "Modifica datos persona"

        personasForm.indice = DataGridView1.CurrentRow.Index



        LlenarForm()

        personasForm.Show()
    End Sub




    Private Sub eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click

        If lst.Count = 0 Then Exit Sub
        personasForm.operacion = "Eliminar"

        personasForm.Text = "Elimina datos de persona"

        personasForm.indice = DataGridView1.CurrentRow.Index



        LlenarForm()



        personasForm.Show()



    End Sub


    Private Sub LlenarForm()



        personasForm.TextBox7.Text = DataGridView1.CurrentRow.Cells("Id").Value.ToString
        personasForm.TextBox1.Text = DataGridView1.CurrentRow.Cells("Nombre").Value.ToString
        personasForm.TextBox3.Text = DataGridView1.CurrentRow.Cells("CodPostal").Value.ToString
        personasForm.TextBox2.Text = DataGridView1.CurrentRow.Cells("Direccion").Value.ToString
        personasForm.ComboBox1.Text = DataGridView1.CurrentRow.Cells("TipoDocumento").Value.ToString
        personasForm.TextBox4.Text = DataGridView1.CurrentRow.Cells("NumeroDocumento").Value.ToString
        personasForm.ComboBox2.Text = DataGridView1.CurrentRow.Cells("nombreProvincia").Value.ToString



    End Sub


    Private Sub personasgrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DataGridView1.DataSource = lst

    End Sub



    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click


        Me.Close()



    End Sub
End Class