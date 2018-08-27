
Imports System.ComponentModel

Imports System.Text


Public Class personascollection



    Inherits BindingList(Of personasclass)


    Public Sub New()

        Me.TraerPersonas()
    End Sub


    Public Function TraerPersonas() As personascollection



        Dim objBaseDatos As New BaseDatosClass

        Dim MiDataTable As New DataTable
        Dim MiPersona As personasclass


        objBaseDatos.objTabla = "Personas"


        MiDataTable = objBaseDatos.Consultar



        For Each dr As DataRow In MiDataTable.Rows



            MiPersona = New personasclass



            MiPersona.Id = CInt(dr("Id"))
            MiPersona.Nombre = dr("Nombre")
            MiPersona.Direccion = dr("Direccion")
            MiPersona.CodPostal = dr("CodPostal")
            MiPersona.IdProvincia = CInt(dr("IdProvincia"))
            MiPersona.TipoDocumento = CInt(dr("TipoDocumento"))
            MiPersona.NumeroDocumento = CInt(dr("NumeroDocumento"))


            Me.Add(MiPersona)

        Next


        Return Me


    End Function

    Public Sub insertarPersona(ByVal Mipersona As personasclass)

        Dim ObjBasedato As New BaseDatosClass


        ObjBasedato.objTabla = "Personas"



        Dim VSQL As New StringBuilder


        'VSQL.Append("(Id")
        VSQL.Append("(Nombre")
        VSQL.Append(",Direccion")
        VSQL.Append(",CodPostal")
        VSQL.Append(",IdProvincia")
        VSQL.Append(",TipoDocumento")
        VSQL.Append(",NumeroDocumento)")



        VSQL.Append(" VALUES ")

        'VSQL.Append("('" & Mipersona.Id.ToString & "'")
        VSQL.Append("( '" & Mipersona.Nombre & "'")
        VSQL.Append(", '" & Mipersona.Direccion & "'")
        VSQL.Append(", '" & Mipersona.CodPostal & "'")
        VSQL.Append(", '" & Mipersona.IdProvincia & "'")
        VSQL.Append(", '" & Mipersona.TipoDocumento & "'")
        VSQL.Append(", '" & Mipersona.NumeroDocumento & "')")

        Mipersona.Id = ObjBasedato.Insertar(VSQL.ToString)

        Me.Add(Mipersona)


    End Sub


    Protected Overrides ReadOnly Property SupportsSearchingCore() As Boolean
        Get
            Return True
        End Get
    End Property

    Protected Overrides Function FindCore(ByVal prop As PropertyDescriptor, ByVal key As Object) As Integer
        For Each carrera In Me
            If prop.GetValue(carrera).Equals(key) Then
                Return Me.IndexOf(carrera)
            End If
        Next

        Return -1
    End Function


    Public Sub EliminarPersona(ByVal MiPersona As personasclass)

        'Instancio el el Objeto BaseDatosClass para acceder al la base personas.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "personas"

        'Ejecuta el método base eliminar.
        Dim resultado As Boolean
        resultado = objBaseDatos.Eliminar(MiPersona.Id)

        If resultado Then

            'Creates a new collection and assign it the properties for modulo.
            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiPersona)

            'Sets an PropertyDescriptor to the specific property Id.
            Dim myProperty As PropertyDescriptor = properties.Find("Id", False)

            Me.RemoveAt(Me.FindCore(myProperty, MiPersona.Id))
        Else
            MessageBox.Show("No fue posible eliminar el registro.")
        End If

    End Sub

    Public Sub ActualizarPersona(ByVal MiPersona As personasclass)

        'Instancio el el Objeto BaseDatosClass para acceder al la base personas.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "personas"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        'vSQL.Append("Id='" & MiPersona.Id.ToString & "'")
        vSQL.Append(",TipoDocumento='" & MiPersona.tipoDocumento & "'")
        vSQL.Append(",NumeroDocumento='" & MiPersona.numeroDocumento.ToString & "'")
        vSQL.Append(",Nombre='" & MiPersona.nombre & "'")
        vSQL.Append(",Direccion='" & MiPersona.direccion & "'")
        vSQL.Append(",IdProvincia='" & MiPersona.idProvincia.ToString & "'")
        vSQL.Append(",CodPostal='" & MiPersona.codPostal.ToString & "'")

        'Actualizo la tabla personas con el Id.
        Dim resultado As Boolean
        'El método actualizar es una función que devuelve True o False
        'Según como haya resultado la operación sobre la tabla SQL.
        resultado = objBaseDatos.Actualizar(vSQL.ToString, MiPersona.Id)

        If resultado Then
            'El código a continuación sirve para localizar el ítem en la lista
            'en este caso un persona.
            ' Creates a new collection and assign it the properties for modulo.
            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiPersona)

            'Sets an PropertyDescriptor to the specific property Id.
            Dim myProperty As PropertyDescriptor = properties.Find("Id", False)
            Me.Items.Item(Me.FindCore(myProperty, MiPersona.Id)) = MiPersona
        Else
            MessageBox.Show("No fue posible modificar el registro.")
        End If

    End Sub


End Class
