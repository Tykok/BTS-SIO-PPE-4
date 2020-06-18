Public Class GestionServices
    'Variables contenant le Numéro du service que l'on modifiera au préalable
    Public Service As Services

    'Bouton pour supprimer un service
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_supp_service.Click
        Dim i As Integer


        Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
        Reponse = MessageBox.Show("Êtes-vous vraiment sûr de vouloir supprimer ce service?", "Supprimer", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
        If Reponse = DialogResult.Yes Then
            'Si l'adminitrateur clique sur "Oui" alors on effectue la suppression du matériel en recherchant tout d'abord l'élément sélectionné
            For Each Element As ListViewItem In lv_service.SelectedItems
                'Lorsque on l'a trouver on l'enlève
                If Element.Selected = True Then
                    For Each unService In CollectionService
                        'Si le numéro du service est bien égale à celui u'on as sélectionné
                        If unService.LireNumService = Element.SubItems(0).Text Then

                            'Comme on supprime le service il faut rediriger tout les matériel vers le stock
                            For Each MatDuservice In unService.materielServ
                                CollectionMatériel.Add(MatDuservice)
                            Next

                            'Ensuite commence le traitement pour les logiciels
                            For Each LogDuService In unService.logicielServ

                                'On récupére le logiciel correspondant
                                i = 0
                                While i < CollectionLogiciel.Count And CollectionLogiciel.Item(i).NumLog <> LogDuService.NumLog
                                    i = i + 1
                                End While
                                Dim LeLogiciel = CollectionLogiciel.Item(i)

                                'On réajoute les nombres d'utilisateur au logiciel
                                LeLogiciel.NbUsr = LeLogiciel.NbUsr + LogDuService.NbUsr
                            Next


                            'On supprime l'élément de la collection de service
                            CollectionService.Remove(unService)
                            'Puis de la listview
                            lv_service.Items.Remove(Element)
                            lv_service.Refresh()

                            Exit For
                        End If
                    Next
                End If
            Next
        End If
    End Sub

    'Bouton modifier un service
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_modif_service.Click
        'On rcherche tout d'abord le service sélectionné dans la liste des services
        For Each Element As ListViewItem In lv_service.SelectedItems
            'Lorsque on l'a trouver on récupère son numéro
            If Element.Selected = True Then
                For Each unService In CollectionService
                    'Si le numéro du service est bien égale à celui qu'on as sélectionné
                    If unService.LireNumService = Element.SubItems(0).Text Then
                        'On récupére son numéro dans la variable
                        Service = unService
                        Dim ServiceModif As New MofifService
                        ServiceModif.ShowDialog()
                        Exit For
                    End If
                Next
            End If
        Next
    End Sub

    'Bouton retour
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_retour.Click
        MenuAdmin.Show()
        Me.Close()
    End Sub

    'Barre de menu pour accèder à l'ajout d'un service
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles menu_add_service.Click
        Me.Close()
        AjoutService.Show()
    End Sub



    'Chargement du formulaire avec les informations
    Private Sub GestionServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On supprime les anciens services en parcourant la listview et notre collection pour supprimer ceux qui sont similaires (une sorte de raffraichissement)
        For Each suppr As ListViewItem In lv_service.Items
            For Each unService In CollectionService
                If suppr.SubItems(0).Text = unService.LireNumService Then
                    lv_service.Items.Remove(suppr)
                End If
            Next
        Next

        'On ajoute les services de la collection
        For Each unService In CollectionService
            Dim item As ListViewItem
            item = New ListViewItem({unService.LireNumService, unService.LireNomService})
            Me.lv_service.Items.Add(item)
        Next

        'On grise les boutons qui ce dégriseront lorsque qu'un service aura été sélectionné
        btn_modif_service.Enabled = False
        btn_supp_service.Enabled = False
    End Sub


    'Double clic pour l'affichage des infos du service
    Private Sub lv_service_DoubleClick(sender As Object, e As EventArgs) Handles lv_service.DoubleClick

        'En recherchant l'élément sélectionné dans la listview
        For Each Element As ListViewItem In lv_service.SelectedItems
            'Si celui-ci est trouvé 
            If Element.Selected = True Then
                'On recherche dans la colelction des services l'lélement sélectionné
                For Each unService In CollectionService
                    'En comparant le numéro
                    If unService.LireNumService = Element.SubItems(0).Text Then
                        'Une foi trouvé on ajoute les logiciels
                        For Each unLogiciel In unService.logicielServ
                            lb_logiciels.Items.Add(unLogiciel.Liblog)
                        Next
                        ' Et matériel de ce service
                        For Each unMateriel In unService.materielServ
                            lb_materiels.Items.Add(unMateriel.LibMat)
                        Next

                        'Description du service
                        tb_descrip.Text = unService.LireDescript
                    End If
                Next
            End If
        Next
    End Sub


    'Dégrisage des boutons pour la suppression / modification et effacement des info des listbox
    Private Sub lv_service_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_service.SelectedIndexChanged
        'A chaque fois que l'index change on enlève les informations des listbox qui ne correspondent pas forcément
        lb_materiels.Items.Clear()
        lb_logiciels.Items.Clear()
        'On dégrise aussi par ailleurs les boutons 
        btn_modif_service.Enabled = True
        btn_supp_service.Enabled = True
    End Sub
End Class