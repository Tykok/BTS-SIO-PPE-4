Public Class Services
    Private m_NumServ As Integer
    Private m_NomServ As String
    Private m_Descript_Acticvite_Serv As String
    'Collection des logiciels et matériels présent dans un service
    Private m_Collection_Matériels_Services As New ArrayList
    Private m_Collection_Logiciels_Services As New ArrayList

    'Constructeur
    Public Sub New(ByRef Num As Integer, ByRef Nom As String, ByRef Description As String)
        m_NumServ = Num
        m_NomServ = Nom
        m_Descript_Acticvite_Serv = Description
    End Sub

    'Cette sub nous permettra d'ajouter un logiciel à la collection de logiciel du service qui est en privée
    Public Sub AjouterLogi(ByRef unLogiciel As Logiciel)
        m_Collection_Logiciels_Services.Add(unLogiciel)
    End Sub

    'Cette sub permet d'ajouter un matériel
    Public Sub AjouterMat(ByRef unMat As Materiel)
        m_Collection_Matériels_Services.Add(unMat)
    End Sub

    'Ici celà permet de supprimer un logiciel de la colelction
    Public Sub SupprLog(ByRef unLogiciel As Logiciel)
        m_Collection_Logiciels_Services.Remove(unLogiciel)
    End Sub

    'Pour pouvoir supprimer un matériel du service
    Public Sub SupprMat(ByRef unMat As Materiel)
        m_Collection_Matériels_Services.Remove(unMat)
    End Sub

    'Lire le numéro du service
    Public Property LireNumService As String
        Get
            Return m_NumServ
        End Get
        Set(ByVal value As String)
            m_NumServ = value
        End Set
    End Property
    'Lire le nom du service
    Public Property LireNomService As String
        Get
            Return m_NomServ
        End Get
        Set(ByVal Nom As String)
            m_NomServ = Nom
        End Set
    End Property
    'Lire la description du service
    Public Property LireDescript As String
        Get
            Return m_Descript_Acticvite_Serv
        End Get
        Set(ByVal Des As String)
            m_Descript_Acticvite_Serv = Des
        End Set
    End Property

    'Pour avoir la collection de matériel d'un service
    Property materielServ As ArrayList
        Get
            Return m_Collection_Matériels_Services
        End Get
        Set(value As ArrayList)

        End Set
    End Property


    'Pour avoir la collection de logiciel d'un service
    Property logicielServ As ArrayList
        Get
            Return m_Collection_Logiciels_Services
        End Get
        Set(value As ArrayList)

        End Set
    End Property


    ' fonction pour voir si le matériel est présent dans un service
    Public Function trouveMat(Num As Integer) As Boolean
        For Each unMateriel In m_Collection_Matériels_Services
            If Num = unMateriel.CodeMat Then
                Return True
            End If
        Next
        Return False
    End Function

    'Fonction pour voir si le logiciel est bien présent dans un service
    Public Function trouveLog(Num As Integer) As Boolean
        For Each unLogiciel In m_Collection_Logiciels_Services
            If Num = unLogiciel.NumLog Then
                Return True
            End If
        Next
        Return False
    End Function

    'Fonction qui retourne le nombre d'utilisateurs d'un logiciel dans un service (parcourir les services pour trouver le service sur lequel bossé avant)
    Public Function UserLog(Num As Integer) As Integer
        For Each unLogiciel In m_Collection_Logiciels_Services
            If Num = unLogiciel.NumLog Then
                Return unLogiciel.NbUsr
            End If
        Next
    End Function

    'retourne le matériel ndu service à l'emplacement i
    Public Function DonneMat(i As Integer) As Materiel
        Return m_Collection_Matériels_Services.Item(i)
    End Function

    'Compte le nombre de matériel d'un service
    Public Function NbrMat() As Integer
        Return m_Collection_Matériels_Services.Count()
    End Function

    'retourne le logiciel du service à l'emplacement i
    Public Function DonneLog(i As Integer) As Logiciel
        Return m_Collection_Logiciels_Services.Item(i)
    End Function

    'Compte le nombre de logiciel d'un service
    Public Function NbrLog() As Integer
        Return m_Collection_Logiciels_Services.Count()
    End Function
End Class

