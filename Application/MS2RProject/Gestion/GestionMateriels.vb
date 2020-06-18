Public Class GestionMateriels
    Public LeNumMat As Integer

    'Code pour quitter la gestion des matériel et revenir au menu
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Close()
    End Sub
    'Code pour l'ajout d'un matériel
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles menu_add_mat.Click
        AjoutMateriel.ShowDialog()
    End Sub

    'Code pour le bouton de la modification d'un maériel
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_modif_mat.Click
        For Each Element As ListViewItem In ltvMat.SelectedItems
            If Element.Selected = True Then
                LeNumMat = Element.SubItems(0).Text
            End If
        Next
        Dim formUpdate As New ModifMat
        formUpdate.Show()
    End Sub

    'Code pour le bouton suppression d'un matériel
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_supp_mat.Click
        Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
        Reponse = MessageBox.Show("Attention ce matériel va être définitivement supprimé", "Supprimer", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
        If Reponse = DialogResult.Yes Then
            'Si l'adminitrateur clique sur "Oui" alors on effectue la suppression du matériel en recherchant tout d'abord l'élément sélectionné
            For Each Element As ListViewItem In ltvMat.SelectedItems
                'Lorsque on l'a trouver on l'enlève
                If Element.Selected = True Then
                    For Each unMat In CollectionMatériel
                        'Si le matériel de la collection est bien égale au matériel
                        If unMat.CodeMat = Element.SubItems(0).Text Then

                            Dim MaterielStock As Boolean = True

                            'On cherche tout d'abord dans les services pour vérifier que le matériel n'est pas présent dans un service et en prévenir
                            'l'administrateur
                            For Each unService In CollectionService
                                Dim i As Integer = 0
                                i = 0
                                While i < unService.materielServ.Count

                                    'on vérifie avant de continuer le while que le matériel ne correspond pas
                                    If unService.materielServ.item(i).CodeMat = unMat.CodeMat Then
                                        'Sinon on met le matérielstock à false
                                        MaterielStock = False
                                        Exit While
                                    End If
                                    i = i + 1
                                End While

                                'Si le matériel est présent dans un service on demande confirmation
                                If MaterielStock = False Then
                                    Dim Suppr As DialogResult 'Déclaration de la variavle "Reponse" en local
                                    Suppr = MessageBox.Show("Attention ce matériel est présent dans un service!" + vbCr + "Le supprimer?", "Supprimer", _
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
                                    If Suppr = DialogResult.Yes Then

                                        'On récupére le matriel dans la collection de matériel du service
                                        Dim MaterielDuService = unService.materielServ.item(i)
                                        'On le supprime de la colelction de matériel du service
                                        unService.SupprMat(MaterielDuService)

                                        'Et de la collection de matériel
                                        CollectionMatériel.Remove(unMat)


                                        'Puis de la listview
                                        ltvMat.Items.Remove(Element)
                                        ltvMat.Refresh()
                                        Exit For
                                    Else
                                        Exit For
                                    End If
                                End If
                            Next

                            'si le matériel n'est pas en stock alors on effectue tout simplement la suppression du stock
                            If MaterielStock Then
                                'On supprime l'élément de la collection
                                unMat.SuppressionMat(Element.SubItems(0).Text)
                                'Puis de la listview
                                ltvMat.Items.Remove(Element)
                                ltvMat.Refresh()
                            End If
                            Exit For
                        End If
                    Next
                End If
            Next
            Me.Show()
        End If
    End Sub


    'Code pour le chargement lorsque les boutons doivent être grisé et que la listview doit être remplie
    Private Sub GestionMateriels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On grise les boutons pour ne pas générer d'erreur avant la sélection d'un matériel
        btn_modif_mat.Enabled = False
        btn_supp_mat.Enabled = False
        lb_service_use_mat.Items.Clear()

        'On supprime les anciens matériels en parcourant la listview et notre collection pour supprimer ceux qui sont similaires (une sorte de raffraichissement)
        For Each suppr As ListViewItem In ltvMat.Items
            For Each unMat In CollectionMatériel
                If suppr.SubItems(0).Text = unMat.CodeMat Then
                    ltvMat.Items.Remove(suppr)
                End If
            Next
        Next

        'On ajoute les matériels de la collection
        For Each uneMateriel In CollectionMatériel
            Dim item As ListViewItem
            item = New ListViewItem({uneMateriel.CodeMat, uneMateriel.LibMat, uneMateriel.TypeMat})
            Me.ltvMat.Items.Add(item)
        Next
    End Sub

    'Code pour le double clique dans la listeview
    Private Sub ltvMat_DoubleClick(sender As Object, e As EventArgs) Handles ltvMat.DoubleClick
        'Tout d'abord on efface la listbox au cas ou il y aurait eu des précédents remplissage
        lb_service_use_mat.Items.Clear()

        'Ensuite pour chaque service on cherche dans sa collection de matériel si il posséde le matériel
        For Each unService In CollectionService
            'En recherchant l'élément sélectionné dans la listview
            For Each Element As ListViewItem In ltvMat.SelectedItems
                'Si celui-ci est trouvé 
                If Element.Selected = True Then
                    'On vérifie que les deux numéros correspondent bien (Méthode dans services) avant de l'ajouter à la listbox
                    If unService.trouveMat(Element.SubItems(0).Text) = True Then
                        lb_service_use_mat.Items.Add(unService.LireNomService)
                    End If
                End If
            Next
        Next

        'Si par ailleurs aucun service n'a été trouvé alors on informe l'administrateur que ce matériel n'appartient à aucun service
        If lb_service_use_mat.Items.Count = 0 Then
            lb_service_use_mat.Items.Add("Ce matériel n'appartient à aucun service")
        End If

    End Sub

    'Code pour les boutons lorsque qu'un matériel a été selectionné
    Private Sub ltvMat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ltvMat.SelectedIndexChanged
        btn_modif_mat.Enabled = True
        btn_supp_mat.Enabled = True
    End Sub
End Class