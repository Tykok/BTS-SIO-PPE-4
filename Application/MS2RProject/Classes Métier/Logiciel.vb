Public Class Logiciel
    Private m_Code_Log As Integer
    Private m_Lib_Log As String
    Private m_Num_Licence_Log As String
    Private m_Nb_User_Log As Integer
    Private m_Date_Achat_Log As Date


    'Constructeur pour un logiciel
    Public Sub New(ByRef code As Integer, ByRef Libelle As String, ByRef NumLicence As String, ByRef NbUser As Integer, ByRef DateAchat As Date)
        m_Code_Log = Code
        m_Lib_Log = Libelle
        m_Num_Licence_Log = NumLicence
        m_Nb_User_Log = NbUser
        m_Date_Achat_Log = DateAchat
    End Sub

    'Constructeur pour le logiciel à insérer dans le service
    Public Sub New(ByRef code As Integer, ByRef Libelle As String, ByRef NumLicence As String, ByRef Utilisateurs As Integer)
        m_Code_Log = code
        m_Lib_Log = Libelle
        m_Num_Licence_Log = NumLicence
        m_Nb_User_Log = Utilisateurs
    End Sub

    Property NumLog
        Get
            Return m_Code_Log
        End Get
        Set(value)
            m_Code_Log = value
        End Set
    End Property
    Property Liblog
        Get
            Return m_Lib_Log
        End Get
        Set(value)
            m_Lib_Log = value
        End Set
    End Property
    Property NumLic
        Get
            Return m_Num_Licence_Log
        End Get
        Set(value)
            m_Num_Licence_Log = value
        End Set
    End Property

    Property NbUsr
        Get
            Return m_Nb_User_Log
        End Get
        Set(value)
            m_Nb_User_Log = value
        End Set
    End Property

    Property DateAchatLog
        Get
            Return m_Date_Achat_Log
        End Get
        Set(value)
            m_Date_Achat_Log = value
        End Set
    End Property


End Class
