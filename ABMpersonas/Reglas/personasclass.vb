﻿Public Class personasclass


    Dim documentos_() As String = {"DNI", "LE", "LC", "CI", "PAS"}

    Dim provincias_() As String = _
    {"Ciudad Autónoma de Buenos Aires", _
    "Buenos Aires", _
    "Catamarca", _
    "Córdoba", _
    "Corrientes", _
    "Entre Ríos", _
    "Jujuy", _
    "Mendoza", _
    "La Rioja", _
    "Salta", _
    "San Juan", _
    "San Luis", _
    "Santa Fe", _
    "Santiago del Estero", _
    "Tucumán", _
    "Chaco", _
    "Chubut", _
    "Formosa", _
    "Misiones", _
    "Neuquén", _
    "La Pampa", _
    "Río Negro", _
    "Santa Cruz", _
    "Tierra del Fuego"}

    Dim Id_, CodPostal_, NumeroDocumento_, TipoDocumento_, IdProvincia_ As Integer

    Dim Nombre_, Direccion_ As String





    Public Property Id() As Integer

        Get

            Return Id_

        End Get


        Set(ByVal value As Integer)

            Id_ = value


        End Set

    End Property




    Public Property CodPostal() As Integer

        Get

            Return CodPostal_

        End Get


        Set(ByVal value As Integer)

            CodPostal_ = value


        End Set

    End Property


    Public Property Direccion() As String

        Get

            Return Direccion_

        End Get


        Set(ByVal value As String)

            Direccion_ = value


        End Set

    End Property

    Public Property NumeroDocumento() As Integer

        Get

            Return NumeroDocumento_

        End Get


        Set(ByVal value As Integer)

            NumeroDocumento_ = value


        End Set


    End Property

    Public Property TipoDocumento() As Integer

        Get

            Return TipoDocumento_

        End Get


        Set(ByVal value As Integer)

            TipoDocumento_ = value


        End Set


    End Property

   

    Public Property Nombre() As String

        Get

            Return Nombre_

        End Get


        Set(ByVal value As String)

            Nombre_ = value


        End Set


    End Property




    Public Property IdProvincia() As Integer

        Get

            Return IdProvincia_

        End Get


        Set(ByVal value As Integer)

            IdProvincia_ = value


        End Set


    End Property


    Public ReadOnly Property documentos() As Array
        Get
            Return documentos_
        End Get
    End Property

    Public ReadOnly Property nombreDocumentos() As String
        Get
            If TipoDocumento_ <= 0 Then
                'Return ""
            End If

            Return documentos(CInt(tipoDocumento))
        End Get
    End Property

    Public ReadOnly Property provincias() As Array
        Get
            Return provincias_
        End Get
    End Property

    Public ReadOnly Property nombreProvincia() As String
        Get
            If IdProvincia_ <= 0 Then
                'Return ""
            End If

            Return provincias(CInt(idProvincia_))
        End Get
    End Property





End Class
