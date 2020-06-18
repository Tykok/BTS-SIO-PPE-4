Public Class Tablette
    Inherits Materiel

    Private m_Ram_Tab As String
    Private m_DD_Tab As String
    Private m_Taille_Ecran_Tab As String

    Public Sub New(ByRef code As Integer, ByRef Libelle As String, ByRef Prix As Decimal, ByRef Garantie As Date, ByRef Description As String, _
                   ByRef Type As String, _
                    Ram As String, DisqueDur As String, ByRef taille As String)

        'Héritage de la classe matériels 
        MyBase.New(code, Libelle, Prix, Garantie, Description, Type)

        'Polymorphisme 
        m_Ram_Tab = Ram
        m_DD_Tab = DisqueDur
        m_Taille_Ecran_Tab = taille
    End Sub

    Property ram
        Get
            Return m_Ram_Tab
        End Get
        Set(value)
            m_Ram_Tab = value
        End Set
    End Property

    Property DisqueD
        Get
            Return m_DD_Tab
        End Get
        Set(value)
            m_DD_Tab = value
        End Set
    End Property

    Property TaileE
        Get
            Return m_Taille_Ecran_Tab
        End Get
        Set(value)
            m_Taille_Ecran_Tab = value
        End Set
    End Property
    Public Sub ModifTab(ram As String, dd As String, taille As String)
        m_Ram_Tab = ram
        m_DD_Tab = dd
        m_Taille_Ecran_Tab = taille
    End Sub
End Class
