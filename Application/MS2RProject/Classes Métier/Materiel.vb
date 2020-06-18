Public Class Materiel
    Private m_Code_Mat As Integer
    Private m_Lib_Mat As String
    Private m_Px_Achat_Mat As Decimal
    Private m_garantie_An_Mat As Date
    Private m_Description_Mat As String
    Private m_Type_Mat As String

    'Constructeur
    Public Sub New(ByRef code As Integer, ByRef Libelle As String, ByRef Prix As Decimal, ByRef Garantie As Date, ByRef Description As String, _
                  ByRef Type As String)
        m_Code_Mat = code
        m_Lib_Mat = Libelle
        m_Px_Achat_Mat = Prix
        m_garantie_An_Mat = Garantie
        m_Description_Mat = Description
        m_Type_Mat = Type
    End Sub

    Public Sub SuppressionMat(num As Integer)
        'De la collectionMatériel MAIS AUSSI de la collection correspondant à son type
        For Each unMat In CollectionMatériel
            'Si le matériel de la collection est bien égale au matériel
            If unMat.CodeMat = num Then
                CollectionMatériel.Remove(unMat)

                'On l'enlève aussi des collections spécifiant les types précis
                If unMat.TypeMat = "PC" Then
                    For Each unPC In CollectionPC
                        If unPC.CodeMat = num Then
                            CollectionPC.Remove(unPC)
                            Exit For
                        End If
                    Next
                ElseIf unMat.TypeMat = "Tablette" Then
                    For Each uneTablette In CollectionTab
                        If uneTablette.CodeMat = num Then
                            CollectionTab.Remove(uneTablette)
                            Exit For
                        End If
                    Next
                ElseIf unMat.TypeMat = "Ecran" Then
                    For Each unEcran In CollectionEcran
                        If unEcran.CodeMat = num Then
                            CollectionEcran.Remove(unEcran)
                            Exit For
                        End If
                    Next
                End If
                Exit For
            End If
        Next
    End Sub
    Sub ModifMat(ByRef Libelle As String, ByRef Prix As Decimal, ByRef Garantie As Date, ByRef Description As String, _
                  ByRef Type As String)
        m_Lib_Mat = Libelle
        m_Px_Achat_Mat = Prix
        m_garantie_An_Mat = Garantie
        m_Description_Mat = Description
        m_Type_Mat = Type
    End Sub

    Property CodeMat
        Get
            Return m_Code_Mat
        End Get
        Set(value)
            CollectionMatériel = value
        End Set
    End Property
    Property LibMat
        Get
            Return m_Lib_Mat
        End Get
        Set(value)
            m_Lib_Mat = value
        End Set
    End Property
    Property Prix
        Get
            Return m_Px_Achat_Mat
        End Get
        Set(value)
            m_Px_Achat_Mat = value
        End Set
    End Property

    Property garantie
        Get
            Return m_garantie_An_Mat
        End Get
        Set(value)
            m_garantie_An_Mat = value
        End Set
    End Property

    Property description
        Get
            Return m_Description_Mat
        End Get
        Set(value)
            m_Description_Mat = value
        End Set
    End Property

    Property TypeMat
        Get
            Return m_Type_Mat
        End Get
        Set(value)
            m_Type_Mat = value
        End Set
    End Property
End Class
