Public Class GestionLogiciel
    'Variable public car de logiciel
    Public LeLogiciel As Logiciel

    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    'bouton pour la modification d'un logiciels
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_modif_logi.Click
        'En recherchant l'élément sélectionné dans la listview
        For Each Element As ListViewItem In ltv_Logiciel.SelectedItems
            'Une fois trouvé
            If Element.Selected = True Then

                Dim i As Integer = 0
                ' On cherche le logiciel correspondant dans la collction de logiciels
                While (i < CollectionLogiciel.Count And CollectionLogiciel.Item(i).NumLog <> Element.SubItems(0).Text)
                    i = i + 1
                End While
                'On récupére le logiciel à l'emplacement i pour pouvoir travailler dessus par la suite
                Dim unLogiciel = CollectionLogiciel.Item(i)
                'On renseigne le logiciel en public pour l'utiliser ailleurs aussi
                LeLogiciel = unLogiciel
                ModifLogiciel.Show()
                Me.Close()
            End If
        Next
    End Sub
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    'Retour vers le menu administrateurs
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Close()
    End Sub
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    'Chargement du formulaire pour remplir la liste des logiciels
    Private Sub GestionLogiciel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On supprime les anciens logiciels en parcourant la listview et notre collection pour supprimer ceux qui sont similaires (une sorte de raffraichissement)
        For Each suppr As ListViewItem In ltv_Logiciel.Items
            For Each unLogiciel In CollectionLogiciel
                If suppr.SubItems(0).Text = unLogiciel.NumLog Then
                    ltv_Logiciel.Items.Remove(suppr)
                End If
            Next
        Next

        'On ajoute les logiciels de la collection
        For Each unLogiciel In CollectionLogiciel
            Dim item As ListViewItem
            item = New ListViewItem({unLogiciel.NumLog, unLogiciel.LibLog, unLogiciel.NbUsr, unLogiciel.DateAchatLog})
            ltv_Logiciel.Items.Add(item)
        Next

        'On grise les boutons qui ce dégriseront lorsque qu'un service aura été sélectionné
        btn_modif_logi.Enabled = False
        btn_supp_logi.Enabled = False
    End Sub
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    'DOUBLE CLIC
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    'Lors d'un double clic pour avoir les infos du logiciel
    Private Sub ltv_Logiciel_DoubleClick(sender As Object, e As EventArgs) Handles ltv_Logiciel.DoubleClick

        'En recherchant l'élément sélectionné dans la listview
        For Each Element As ListViewItem In ltv_Logiciel.SelectedItems
            'Une fois trouvé
            If Element.Selected = True Then
                'Varibles qui va servir à retrouver l'emplacement du logiciel
                Dim i As Integer = 0
                'Variables qui va prendre le total des utilisateurs
                Dim total As Integer = 0


                ' On cherche le logiciel correspondant dans la collction de logiciels
                While (i < CollectionLogiciel.Count And CollectionLogiciel.Item(i).NumLog <> Element.SubItems(0).Text)
                    i = i + 1
                End While
                'On récupére le logiciel à l'emplacement i pour pouvoir travailler dessus par la suite
                Dim unLogiciel = CollectionLogiciel.Item(i)
                'On renseigne le logiciel en public pour l'utiliser ailleurs aussi
                LeLogiciel = unLogiciel

                'On affiche ici le nombre de logiciels restant
                lbl_nombre_uti.Text = unLogiciel.NbUsr

                'On supprime d'abord chaque élément de la listview
                i = 0
                While i < ltv_Serv.Items.Count
                    ltv_Serv.Items.RemoveAt(i)
                End While




                'On parcourt maintenant tout les services à la recherche du logiciels sélectionné
                For Each unService In CollectionService
                    'Une fois le logiciel trouvé dans un service on récupére les informations
                    If unService.TrouveLog(unLogiciel.NumLog) Then
                        'On incrémente le nombre d'utilisateurs pour en avoir le total qui l'utilise
                        total = total + unService.UserLog(unLogiciel.NumLog)


                        'On ajoute aussi le nom du service à la liste view
                        Dim item As ListViewItem
                        item = New ListViewItem({unService.LireNumService, unService.LireNomService})
                        ltv_Serv.Items.Add(item)

                    End If
                Next
                'Une fois la boucle terminé on change la valeur du label
                lbl_total_user.Text = total
            End If
        Next
    End Sub
    'Ici c'est le double clic pour les infos du nombre d'utilisateurs du logiciel dans un service précis et sélectionné
    Private Sub ltv_Serv_DoubleClick(sender As Object, e As EventArgs) Handles ltv_Serv.DoubleClick
        'En recherchant l'élément sélectionné dans la listview des services
        For Each Element As ListViewItem In ltv_Serv.SelectedItems
            'Une fois trouvé
            If Element.Selected = True Then

                'On parcourt maintenant tout les services à la recherche de celui qu'on as sélectionné
                For Each unService In CollectionService
                    'Une fois le le service trouvé on affiche un message
                    If unService.LireNumService = Element.SubItems(0).Text Then

                        'On affiche alors le message avec l'information
                        Dim message As String = "Ce service utilise " + unService.UserLog(LeLogiciel.NumLog).ToString + " licence."
                        MessageBox.Show(message, "Informations", MessageBoxButtons.OK)
                    End If
                Next
            End If
        Next

    End Sub
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    'Bouton pour la suppression d'un logiciel
    Private Sub btn_supp_logi_Click(sender As Object, e As EventArgs) Handles btn_supp_logi.Click
        Dim i As Integer = 0

        Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
        Reponse = MessageBox.Show("Êtes-vous vraiment sûr de vouloir supprimer ce logiciel?", "Supprimer", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
        If Reponse = DialogResult.Yes Then

            For Each Element As ListViewItem In ltv_Logiciel.SelectedItems
                'Lorsque on l'a trouver on l'enlève
                If Element.Selected = True Then
                    For Each unLogiciel In CollectionLogiciel
                        'Si le numéro du logiciel est bien égale à celui u'on as sélectionné
                        If unLogiciel.NumLog = Element.SubItems(0).Text Then

                            Dim LogUtilisé As Boolean = False

                            'On vérifie tout d'abord que le logiciel n'est pas présent dans un ou plusieurs services
                            For Each unService In CollectionService
                                'si il y en as un
                                If unService.trouveLog(unLogiciel.NumLog) Then
                                    LogUtilisé = True

                                    'on parcourt tout les logiciels du services pour trouver le bon
                                    While i < unService.logicielServ.Count And unService.logicielServ.Item(i).NumLog <> unLogiciel.NumLog
                                        i = i + 1
                                    End While
                                    'On le récupére par la suite
                                    Dim LogDuService = unService.logicielServ.Item(i)

                                    Dim suppr As DialogResult 'Déclaration de la variavle "Reponse" en local
                                    suppr = MessageBox.Show("Ce logiciel est présent dans un/plusieurs services!" + vbCr + _
                                                            "Êtes-vous vraiment sûr de vouloir supprimer ce logiciel?", "Supprimer", _
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
                                    If suppr = DialogResult.Yes Then
                                        'On supprime l'élément de la collection
                                        CollectionService.Remove(unLogiciel)
                                        'Et ensuite de la collection de logiciel du service
                                        unService.supprLog(LogDuService)
                                        'Puis de la listview
                                        ltv_Logiciel.Items.Remove(Element)
                                        ltv_Logiciel.Refresh()
                                    Else
                                        Exit For
                                    End If
                                End If
                            Next

                            'ici on fait tout simplement la suppression dans la collection de logiciel car celui-ci n'est présent dans aucun services
                            If LogUtilisé = False Then
                                'On supprime l'élément de la collection
                                CollectionService.Remove(unLogiciel)
                                'Puis de la listview
                                ltv_Logiciel.Items.Remove(Element)
                                ltv_Logiciel.Refresh()
                            End If
                            Exit For
                        End If
                    Next
                End If
            Next
        End If
    End Sub
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    'Dégrisage des boutons
    Private Sub ltv_Logiciel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ltv_Logiciel.SelectedIndexChanged
        btn_supp_logi.Enabled = True
        btn_modif_logi.Enabled = True
    End Sub
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

End Class