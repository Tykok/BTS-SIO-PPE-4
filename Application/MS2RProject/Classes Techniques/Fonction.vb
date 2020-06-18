Module Fonction
    'Cette fonction permettra de prendre le dernier code du matériel et rajoutera +1 de manière à ce que chaque matériel soit unique
    Public Function GenereCodeMat() As Integer
        Dim i As Integer
        For Each unMat In CollectionMatériel
            If unMat.CodeMat > i Then
                i = unMat.CodeMat
            End If
        Next
        Return i + 1
    End Function
    'Cette fonction permet de trouver le matériel que l'on recherche
    Public Function trouveMat(num As Integer) As Materiel
        For Each unMateriel In CollectionMatériel
            If unMateriel.CodeMat = num Then
                Return unMateriel
            End If
        Next
    End Function

    'Fonction de génération d'un numéro unique pour service
    Public Function GenereCodeServ() As Integer
        Dim i As Integer
        For Each unService In CollectionService
            If unService.LireNumService > i Then
                i = unService.LireNumService
            End If
        Next
        Return i + 1
    End Function

    'Génération d'un code pour le logiciel
    Public Function GenereCodeLog() As Integer
        Dim i As Integer
        For Each unLogiciel In CollectionLogiciel
            If unLogiciel.NumLog > i Then
                i = unLogiciel.NumLog
            End If
        Next
        Return i + 1
    End Function



    'Sub pour vider toutes les collections
    Public Sub Deco()
        CollectionService.Clear()
        CollectionMatériel.Clear()
        CollectionLogiciel.Clear()
        CollectionAdmin.Clear()
        CollectionPC.Clear()
        CollectionEcran.Clear()
        CollectionTab.Clear()
    End Sub
End Module
