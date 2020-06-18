Public Class Ecran
    Inherits Materiel

    Private m_Taille_Ecran As String
    Private m_Resolution_Ecran As String
    Private m_Technologie_Ecran As String

    Public Sub New(ByRef code As Integer, ByRef Libelle As String, ByRef Prix As Decimal, ByRef Garantie As Date, ByRef Description As String, _
                   ByRef Type As String, _
                   ByRef taille As String, ByRef resolution As String, ByRef Technologie As String)

        'Héritage de la classe matériels
        MyBase.New(code, Libelle, Prix, Garantie, Description, Type)

        'Polymorphisme du constructeur pour avoir plus d'attributs
        m_Taille_Ecran = taille
        m_Resolution_Ecran = resolution
        m_Technologie_Ecran = Technologie
    End Sub

    Sub ModifEcran(ByRef code As Integer, ByRef Libelle As String, ByRef Prix As Decimal, ByRef Garantie As Date, ByRef Description As String, _
                   ByRef Type As String, _
                   ByRef taille As String, ByRef resolution As String, ByRef Technologie As String)
        'Héritage de la classe matériels
        ' MyBase(code, Libelle, Prix, Garantie, Description, Type)

        'Polymorphisme du constructeur pour avoir plus d'attributs
        m_Taille_Ecran = taille
        m_Resolution_Ecran = resolution
        m_Technologie_Ecran = Technologie
    End Sub
    Property taille
        Get
            Return m_Taille_Ecran
        End Get
        Set(value)
            m_Taille_Ecran = value
        End Set
    End Property

    Property resolution
        Get
            Return m_Resolution_Ecran
        End Get
        Set(value)
            m_Resolution_Ecran = value
        End Set
    End Property

    Property technologie
        Get
            Return m_Technologie_Ecran
        End Get
        Set(value)
            m_Technologie_Ecran = value
        End Set
    End Property
    Public Sub ModifEcran(taille As String, resolution As String, technologie As String)
        m_Taille_Ecran = taille
        m_Resolution_Ecran = resolution
        m_Technologie_Ecran = technologie
    End Sub

    Public Function trouveEcran(Num As Integer) As Ecran
        For Each unEcran In CollectionEcran
            If unEcran.CodeMat = Num Then
                Return unEcran
                Exit For
            End If
        Next
    End Function
End Class
