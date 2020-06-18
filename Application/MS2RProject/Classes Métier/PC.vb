Public Class PC
    Inherits Materiel
    Private m_MicroProc_PC As String
    Private m_Ram_PC As String
    Private m_DD_PC As String

    Public Sub New(ByRef code As Integer, ByRef Libelle As String, ByRef Prix As Decimal, ByRef Garantie As Date, ByRef Description As String, _
                  ByRef Type As String, _
                   ByRef Micro As String, ByRef Ram As String, ByRef DisqueDur As String)

        'Héritage de la classe matériels
        MyBase.New(code, Libelle, Prix, Garantie, Description, Type)

        'Polymorphisme de la classe pour plus d'attributs en lien avec les PC
        m_MicroProc_PC = Micro
        m_Ram_PC = Ram
        m_DD_PC = DisqueDur
    End Sub

    Property MicroPro
        Get
            Return m_MicroProc_PC
        End Get
        Set(value)
            m_MicroProc_PC = value
        End Set
    End Property

    Property Ram
        Get
            Return m_Ram_PC
        End Get
        Set(value)
            m_Ram_PC = value
        End Set
    End Property

    Property DisqueD
        Get
            Return m_DD_PC
        End Get
        Set(value)
            m_DD_PC = value
        End Set
    End Property

    Public Sub ModifPC(micro As String, ram As String, dd As String)
        m_MicroProc_PC = micro
        m_Ram_PC = ram
        m_DD_PC = dd
    End Sub

    Public Sub EnleverPC(Num As Integer)
        'CollectionPC
        'Enlever le pc
    End Sub
End Class
