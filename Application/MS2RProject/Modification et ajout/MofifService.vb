Public Class MofifService
    'Récupération du  service sur lequel on travaille grâç à la fonction qui récupérera le service en fonction de la ou il y as ue information
    Dim unService = recupService()

    'Ici on effectue un test pour voir quelle service on doit récupérer 
    Public Function recupService() As Services
        If GestionServices.Service Is Nothing Then
            Dim unService = AjoutService.service
            Me.Text = "Ajout de logiciels et matériels"
            Return unService
        Else
            Dim unService = GestionServices.Service
            Me.Text = "Modification du service"
            Return unService
        End If
    End Function
    'Fonction lorsque la modification et terminer
    Public Function TerminerModif() As Integer
        If GestionServices.Service Is Nothing Then
            Return 1
        Else
            Return 2
        End If
    End Function


    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
        Reponse = MessageBox.Show("Voulez-vous vraiment tout annuler ?", "Annuler", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
        If Reponse = DialogResult.Yes Then
            Me.Close()
            Dim ConsultationServ As New GestionServices
            ConsultationServ.Show()
        End If
    End Sub

    'Bouton TERMINER (modification du nom du service)
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_valider.Click
        Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
        Reponse = MessageBox.Show("Confirmez-vous les modifications ?", "Ajout", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
        If Reponse = DialogResult.Yes Then
            'On modifie le nom du service par ce qu'il yas dans la zone de texte
            unService.LirenomService = tb_service.Text
            'Ainsi que la description de cleui-ci
            unService.LireDescript = tb_descript.Text


            'Et on ferme le formulaire avec la réouverture en même temps de la gesion des services (dépend de l'endroit de départ de l'administrateur)
            If TerminerModif() = 1 Then
                'On ferme et on renvoie sur le menu des admins
                AjoutService.Close()
                MenuAdmin.Show()
                Me.Close()
            Else
                Me.Close()
            End If
        End If
    End Sub



    'Chargement du formulaire -> tyraitement des matériels/ logiciels du service et ceux disponible et ajout dans les liste
    Private Sub MofifService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On grise tout d'abord toutes les zones à griser
        btn_add_Mat.Enabled = False
        btn_addlog.Enabled = False
        btn_remove_Mat.Enabled = False
        btn_removeLog.Enabled = False




        'NOM DU SERVICE
        'On récupére le nom du service
        tb_service.Text = unService.LireNomService
        'Et la description de celui-ci
        tb_descript.Text = unService.LireDescript

        'MATERIELS DU SERVICE
        Dim i As Integer = 0
        'On effectue un while en comptant combien de matériel possède le service
        While i < unService.NbrMat
            'on récupére le mtériel à la position i
            Dim UnMat = unService.DonneMat(i)

            'On le rajoute à la liste des matériels du service
            Dim item As ListViewItem
            item = New ListViewItem({UnMat.CodeMat, UnMat.LibMat, UnMat.TypeMat})
            Me.ltvMat.Items.Add(item)
            'on effectue une itération
            i = i + 1
        End While


        'LOGICIEL DU SERVICE
        i = 0
        'On effectue un while en comptant combien de logiciel possède le service
        While i < unService.NbrLog
            'on récupére le mtériel à la position i
            Dim UnLog = unService.DonneLog(i)

            'On le rajoute à la liste des logiciels du service
            Dim item As ListViewItem
            item = New ListViewItem({UnLog.NumLog, UnLog.Liblog, UnLog.NbUsr})
            'on ajoute ses informations à la listview des logiciels du service
            Me.ltvLog_Services.Items.Add(item)
            'on effectue une itération
            i = i + 1
        End While


        'MATERIELS DISPONIBLE
        'Par la suite on vérifie que pour chaque matériel, celui-ci n'est pas encore dans un service
        For Each unMateriel In CollectionMatériel
            Dim MatUtil As Boolean = False

            'On cherche la présence du matériel dans tout les services pour voir sa disponibilité
            For Each LeService In CollectionService
                'On crée une variable si le matériel a été trouvé dans un service
                If LeService.trouveMat(unMateriel.CodeMat) Then
                    MatUtil = True
                End If
            Next

            'On vérifie avant de l'ajouter que la variable nous donne bien la confirmation qu'il n'eest pas présent dans un service
            If MatUtil = False Then
                'On le rajoute à la liste des matériels en stock
                Dim item As ListViewItem
                item = New ListViewItem({unMateriel.CodeMat, unMateriel.LibMat, unMateriel.TypeMat})
                Me.ltvMat_Stock.Items.Add(item)
            End If
        Next


        'LOGICIEL DISPONIBLE
        For Each unLogiciel In CollectionLogiciel
            'On vérifie d'abord que tout les logiciels de notre collection ne sont pas à 0
            If unLogiciel.NbUsr > 0 Then
                'On le rajoute à la liste des logiciels disponible
                Dim item As ListViewItem
                item = New ListViewItem({unLogiciel.NumLog, unLogiciel.LibLog, unLogiciel.NbUsr})
                Me.ltv_LogDispo.Items.Add(item)
            End If
        Next

    End Sub





    'Code pour la grisage et dégrisage
    Private Sub ltvMat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ltvMat.SelectedIndexChanged
        btn_add_Mat.Enabled = False
        btn_addlog.Enabled = False
        btn_remove_Mat.Enabled = True
        btn_removeLog.Enabled = False
    End Sub
    Private Sub ltvLog_Services_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ltvLog_Services.SelectedIndexChanged
        btn_add_Mat.Enabled = False
        btn_addlog.Enabled = False
        btn_remove_Mat.Enabled = False
        btn_removeLog.Enabled = True
    End Sub
    Private Sub ltv_LogDispo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ltv_LogDispo.SelectedIndexChanged
        btn_add_Mat.Enabled = False
        btn_addlog.Enabled = True
        btn_remove_Mat.Enabled = False
        btn_removeLog.Enabled = False
    End Sub
    Private Sub ltvMat_Stock_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ltvMat_Stock.SelectedIndexChanged
        btn_add_Mat.Enabled = True
        btn_addlog.Enabled = False
        btn_remove_Mat.Enabled = False
        btn_removeLog.Enabled = False
    End Sub





    'GESTION DES MATERIELS (BOUTON)
    'Bouton pour enlever un matériel du service et le remettre en stock
    Private Sub btn_remove_Mat_Click(sender As Object, e As EventArgs) Handles btn_remove_Mat.Click
        For Each Element As ListViewItem In ltvMat.SelectedItems
            'On cherche l'élément sélectionné
            If Element.Selected = True Then
                For Each unMateriel In CollectionMatériel
                    'On cherche le matériel correspondant
                    If unMateriel.CodeMat = Element.SubItems(0).Text Then

                        'On l'ajoute à la liste des matériels en stocks
                        Dim MatStock As ListViewItem
                        MatStock = New ListViewItem({unMateriel.CodeMat, unMateriel.LibMat, unMateriel.TypeMat})
                        Me.ltvMat_Stock.Items.Add(MatStock)

                        'On refresh et on le supprime de la liste des matériemls du service
                        ltvMat_Stock.Refresh()
                        ltvMat.Items.Remove(Element)
                        'Ainsi que de la collection de matériel du service
                        unService.supprMat(unMateriel)
                        Exit For
                    End If
                Next
            End If
        Next
    End Sub
    'Bouton pour faire passer un matériel du sotkc vers les matériels du service
    Private Sub btn_add_Mat_Click(sender As Object, e As EventArgs) Handles btn_add_Mat.Click
        For Each Element As ListViewItem In ltvMat_Stock.SelectedItems
            'On cherche l'élément sélectionné
            If Element.Selected = True Then
                For Each unMateriel In CollectionMatériel
                    'On cherche le matériel correspondant
                    If unMateriel.CodeMat = Element.SubItems(0).Text Then

                        'On l'ajoute à la liste des matériels du service
                        Dim MatStock As ListViewItem
                        MatStock = New ListViewItem({unMateriel.CodeMat, unMateriel.LibMat, unMateriel.TypeMat})
                        Me.ltvMat.Items.Add(MatStock)

                        'On refresh et on le supprime de la liste des matériemls en stock
                        ltvMat.Refresh()
                        ltvMat_Stock.Items.Remove(Element)
                        'Et on l'ajoute à la collection de matériel du service
                        unService.AjouterMat(unMateriel)
                        Exit For
                    End If
                Next
            End If
        Next
    End Sub






    'GESTION DES LOGICIELS (BOUTON)
    'Bouton pour ajouter un logiciel au service
    Private Sub btn_addlog_Click(sender As Object, e As EventArgs) Handles btn_addlog.Click
        Dim i As Integer = 0
        Dim LogNonPresent As Boolean = True

        For Each Element As ListViewItem In ltv_LogDispo.SelectedItems
            'On cherche l'élément sélectionné
            If Element.Selected = True Then

                'Tou d'abord on cherche le logiciel correspondant à la sélection de l'administrateur
                While (i < CollectionLogiciel.Count And CollectionLogiciel.Item(i).NumLog <> Element.SubItems(0).Text)
                    i = i + 1
                End While
                'On récupére le logiciel pour pouvoir travailler dessus par la suite
                Dim unLogiciel = CollectionLogiciel.Item(i)


                'TRAITEMENT DE lA TEXTBOX
                'Tout d'abord on vérifie les valeurs dans la textbox
                If tb_quantite_user.Text = Nothing Then
                    'Si ce n'est pas le cas on prévient l'administrateur
                    MessageBox.Show("Veuillez saisir un nombre d'utilisateur !", "ERREUR", MessageBoxButtons.OK)
                ElseIf tb_quantite_user.Text > unLogiciel.NbUsr Then
                    'Si l'&dministrateur a saisi un nombre trop grand on le prévient
                    MessageBox.Show("Limite d'utilisateur dépassé !", "ERREUR", MessageBoxButtons.OK)
                Else
                    'Si les conditions du dessus sont fausses alors la saisie du champ a bien été respecter
                    'On pocède alors à la modification des champs

                    'MODIFICATION
                    'On recherche maintenant le logiciel correspondant dans le service
                    For Each unLogicielDuService In unService.logicielServ

                        'LOGICIEL DEJA PRESEA+NT DANS LE SERVICE
                        If unLogicielDuService.NumLog = unLogiciel.NumLog Then
                            'Si le logiciel est déjà présent, alors on travail sur celui-ci
                            LogNonPresent = False

                            'Une fois trouvé on lui ajoute les utilisateurs saisi
                            unLogicielDuService.NbUsr = unLogicielDuService.NbUsr + tb_quantite_user.Text
                            'On modifie ensuite les informations des logiciels car il faudra recharger les listview avec les nouvelles informations
                            unLogiciel.NbUsr = unLogiciel.NbUsr - tb_quantite_user.Text

                            'Ici on recharge la listview de ce qu'il y as de disponibles
                            Dim LogStock As ListViewItem
                            LogStock = New ListViewItem({unLogiciel.NumLog, unLogiciel.LibLog, unLogiciel.NbUsr})

                            'On effectue des test pour voir si le logiciel est toujours disponible ou non pour le laisser dans la listview
                            If unLogiciel.NbUsr = 0 Then
                                ltv_LogDispo.Items.Remove(Element)
                            Else
                                ltv_LogDispo.Items.Add(LogStock)
                                ltv_LogDispo.Items.Remove(Element)
                            End If
                            'On refresh le tout
                            ltv_LogDispo.Refresh()


                            'Ici on reahcarge la listview des logiciels qu'à le service
                            For Each LogDuService As ListViewItem In ltvLog_Services.Items
                                'Après avoir parcourut on recherche l'élément correspondant au numéro du logiciel sur lequel on travaille
                                If LogDuService.SubItems(0).Text = unLogiciel.NumLog Then
                                    'On remet l'élément dans la liste des logiciels du services
                                    Dim LogService As ListViewItem
                                    LogService = New ListViewItem({unLogiciel.NumLog, unLogiciel.LibLog, unService.UserLog(unLogiciel.NumLog)})
                                    'on remove l'ancien
                                    ltvLog_Services.Items.Remove(LogDuService)
                                    'On ajoute le nouveau
                                    ltvLog_Services.Items.Add(LogService)
                                    'On refresh le tout
                                    ltvLog_Services.Refresh()
                                End If
                            Next
                        End If
                    Next

                    'SI LE LOGICIEL PAS ENCORE PRESENT DANS LE SERVICE
                    If LogNonPresent Then
                        'On modifie les informations des logiciels car il faudra recharger les listview avec les nouvelles informations
                        unLogiciel.NbUsr = unLogiciel.NbUsr - tb_quantite_user.Text
                        'Ici on recharge la listview de ce qu'il y as de disponibles
                        Dim LogStock As ListViewItem
                        LogStock = New ListViewItem({unLogiciel.NumLog, unLogiciel.LibLog, unLogiciel.NbUsr})


                        'On vérifie que le logiciel est toujours disponible
                        If unLogiciel.NbUsr = 0 Then
                            'On supprime
                            ltv_LogDispo.Items.Remove(Element)
                        Else
                            'On ajoute le logiciel
                            ltv_LogDispo.Items.Remove(Element)
                            ltv_LogDispo.Items.Add(LogStock)
                        End If
                        'On refresh le tout
                        ltv_LogDispo.Refresh()

                        'On crée le logiciel pour l'ajouter à la collection des logiciels du service
                        Dim AjoutLogService As New Logiciel(unLogiciel.NumLog, unLogiciel.LibLog, unLogiciel.NumLic, tb_quantite_user.Text)
                        'On l'ajoute à la collection de service
                        unService.AjouterLogi(AjoutLogService)

                        'On l'insére dans la listview
                        Dim LogService As ListViewItem
                        LogService = New ListViewItem({unLogiciel.NumLog, unLogiciel.LibLog, unService.UserLog(unLogiciel.NumLog)})
                        ltvLog_Services.Items.Add(LogService)
                        'On refresh le tout
                        ltvLog_Services.Refresh()
                    End If
                End If
            End If
        Next
    End Sub
    'Bouton pour enlever un logiciel du service
    Private Sub btn_removeLog_Click(sender As Object, e As EventArgs) Handles btn_removeLog.Click
        Dim i As Integer = 0
        Dim LogPresent As Boolean = True

        For Each Element As ListViewItem In ltvLog_Services.SelectedItems
            'On cherche l'élément sélectionné
            If Element.Selected = True Then

                'Tou d'abord on cherche le logiciel correspondant à la sélection de l'administrateur
                While (i < CollectionLogiciel.Count And CollectionLogiciel.Item(i).NumLog <> Element.SubItems(0).Text)
                    i = i + 1
                End While
                'On récupére le logiciel pour pouvoir travailler dessus par la suite
                Dim unLogiciel = CollectionLogiciel.Item(i)


                'TRAITEMENT DE lA TEXTBOX
                'Tout d'abord on vérifie les valeurs dans la textbox
                If tb_quantite_user.Text = Nothing Then
                    'Si ce n'est pas le cas on prévient l'administrateur
                    MessageBox.Show("Veuillez saisir un nombre d'utilisateur !", "ERREUR", MessageBoxButtons.OK)
                ElseIf tb_quantite_user.Text > unService.UserLog(unLogiciel.NumLog) Then
                    'Si l'&dministrateur a saisi un nombre trop grand on le prévient
                    MessageBox.Show("Limite d'utilisateur dépassé !", "ERREUR", MessageBoxButtons.OK)
                Else
                    'Si les conditions du dessus sont fausses alors la saisie du champ a bien été respecter
                    'On pocède alors à la modification des champs

                    'MODIFICATION
                    'On recherche maintenant le logiciel correspondant dans le service
                    For Each unLogicielDuService In unService.logicielServ
                        If unLogicielDuService.NumLog = unLogiciel.NumLog Then

                            'Une fois trouvé on lui ajoute les utilisateurs saisi
                            unLogicielDuService.NbUsr = unLogicielDuService.NbUsr - tb_quantite_user.Text
                            'On modifie ensuite les informations des logiciels car il faudra recharger les listview avec les nouvelles informations
                            unLogiciel.NbUsr = unLogiciel.NbUsr + tb_quantite_user.Text

                            'Ici on recharge la listview des logiciels du services
                            Dim LogService As ListViewItem
                            LogService = New ListViewItem({unLogiciel.NumLog, unLogiciel.LibLog, unService.UserLog(unLogiciel.NumLog)})

                            'On effectue des test pour voir si le logiciel est toujours dans le service ou non
                            If unService.UserLog(unLogiciel.NumLog) = 0 Then
                                ltvLog_Services.Items.Remove(Element)
                                'On supprime le logiciel de la colelction de logiciel du service car il en devient inexistant
                                unService.supprLog(unLogicielDuService)
                            Else
                                ltvLog_Services.Items.Add(LogService)
                                ltvLog_Services.Items.Remove(Element)
                            End If
                            'On refresh le tout
                            ltvLog_Services.Refresh()


                            'Ici on reahcarge la listview des logiciels en stock
                            For Each LogDispo As ListViewItem In ltv_LogDispo.Items
                                'Après avoir parcourut on recherche l'élément correspondant au numéro du logiciel sur lequel on travaille
                                If LogDispo.SubItems(0).Text = unLogiciel.NumLog Then
                                    'On remet l'élément dans la liste des logiciels du services
                                    Dim LogStock As ListViewItem
                                    LogStock = New ListViewItem({unLogiciel.NumLog, unLogiciel.LibLog, unLogiciel.NbUsr})
                                    ltv_LogDispo.Items.Add(LogStock)
                                    ltv_LogDispo.Items.Remove(LogDispo)
                                    'Le refresh
                                    ltv_LogDispo.Refresh()
                                    LogPresent = True
                                    Exit For
                                End If
                            Next


                            'Vérification du logiciel qui ne serait plus présent en stock
                            If LogPresent = False Then
                                Dim LogStock As ListViewItem
                                LogStock = New ListViewItem({unLogiciel.NumLog, unLogiciel.LibLog, unLogiciel.NbUsr})
                                ltv_LogDispo.Items.Add(LogStock)
                                ltv_LogDispo.Refresh()
                            End If
                            Exit For
                        End If
                    Next
                    End If
                End If
        Next
    End Sub
End Class