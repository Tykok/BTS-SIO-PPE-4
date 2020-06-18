Public Class Admin
    Private m_login As String
    Private m_password As String
    Private m_NomA As String
    Private m_PrenomA As String

    Sub New(log As String, mdp As String, NomA As String, PrenomA As String)
        m_login = log
        m_password = mdp
        m_NomA = NomA
        m_PrenomA = PrenomA
    End Sub

    'Ici on as rajouter une fonction d'uthentification pour les administraeurs
    Public Function Authentifier(ByRef login As String, ByRef mdp As String) As Boolean
        If m_login = login And m_password = mdp Then
            Return True
        Else
            Return False
        End If
    End Function

    Property LirePrenom
        Get
            Return m_PrenomA
        End Get
        Set(value)
            m_PrenomA = value
        End Set
    End Property

    Property LireNom
        Get
            Return m_NomA
        End Get
        Set(value)
            m_NomA = value
        End Set
    End Property

    Property MDP
        Get
            Return m_password
        End Get
        Set(value)
            m_password = value
        End Set
    End Property

    Property Login
        Get
            Return m_login
        End Get
        Set(value)
            m_login = value
        End Set
    End Property
End Class
