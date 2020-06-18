Public Class ModifMat
    'On récupére la variable donnée dans le formulaire de gestion des matériels
    Dim leMat = GestionMateriels.LeNumMat

    'Code pour la validation d'une modification d'un objet
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_valider.Click
        Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
        Reponse = MessageBox.Show("Êtes-vous vraiment sûr de vouloir valider ?", "Valider", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
        If Reponse = DialogResult.Yes Then

            'On recherche tout d'abord le matériel ui va être modifié
            For Each unMat In CollectionMatériel
                'Lorsque que l'on as trouvé le matériel on procéde à la modification
                If leMat = unMat.CodeMat Then
                    'On vérifie quelle radio bouton a été coché pour pouvoir modifié les informations en conséquences
                    If rdb_ecran.Checked = True Then
                        'On recherche un ecran dans la collection des écrans
                        For Each unEcran In CollectionEcran
                            If unMat.CodeMat = unEcran.CodeMat Then

                                'On modifie le matériel avec ses informations
                                unMat.ModifMat(tb_nom_materiel.Text, tb_prix.Text, date_garantie.Text, tb_description.Text, "Ecran")


                                'On modifie ensuite l'écran en utilisant la même méthode précédente
                                unEcran.ModifMat(tb_nom_materiel.Text, tb_prix.Text, date_garantie.Text, tb_description.Text, "Ecran")
                                'Et on modifie aussi par la suite les descriptions spécifique à un écran
                                unEcran.ModifEcran(cb_ecran_ecran.Text, cb_resolution.Text, tb_technologie.Text)
                            End If
                        Next
                    ElseIf rdb_PC.Checked = True Then
                        'On recherche le PC dans la collection des PC que l'on as
                        For Each unPc In CollectionPC
                            If unMat.CodeMat = unPc.CodeMat Then
                                'On modifie le matériel avec ses informations
                                unMat.ModifMat(tb_nom_materiel.Text, tb_prix.Text, date_garantie.Text, tb_description.Text, "PC")


                                'On modifie ensuite le PC en utilisant la même méthode précédente
                                unPc.ModifMat(tb_nom_materiel.Text, tb_prix.Text, date_garantie.Text, tb_description.Text, "PC")
                                'Et on modifie aussi par la suite les descriptions spécifique à un PC
                                unPc.ModifPC(tb_pc_micro.Text, cb_pc_ram.Text, cb_pc_disque.Text)
                            End If
                        Next
                    ElseIf rdb_tablette.Checked = True Then
                        'On recherche la tablette dans la colelction des tablettes
                        For Each uneTablette In CollectionTab
                            If unMat.CodeMat = uneTablette.CodeMat Then
                                'On modifie le matériel avec ses informations
                                unMat.ModifMat(tb_nom_materiel.Text, tb_prix.Text, date_garantie.Text, tb_description.Text, "Tablette")


                                'On modifie ensuite la tablette en utilisant la même méthode précédente
                                uneTablette.ModifMat(tb_nom_materiel.Text, tb_prix.Text, date_garantie.Text, tb_description.Text, "Tablette")
                                'Et on modifie aussi par la suite les descriptions spécifique à une tablette
                                uneTablette.ModifTab(cb_tablette_ram.Text, cb_tablette_disque.Text, cb_tablette_ecran.Text)
                            End If
                        Next
                    End If
                End If
            Next
            Me.Close()
        End If
    End Sub

    'Code pour l'annulation et le retour à la gestion des matériels
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
        Reponse = MessageBox.Show("Êtes-vous vraiment sûr de vouloir annuler ?", "Annuler", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
        If Reponse = DialogResult.Yes Then Me.Close()
    End Sub

    'Code pour les radio boutons (visible/invisible) 
    Private Sub rdb_PC_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_PC.CheckedChanged
        If rdb_PC.Enabled = True Then
            gb_pc.Visible = True
            gb_ecran.Visible = False
            gb_tablette.Visible = False
        End If
    End Sub
    Private Sub rdb_tablette_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_tablette.CheckedChanged
        If rdb_tablette.Enabled = True Then
            gb_pc.Visible = False
            gb_ecran.Visible = False
            gb_tablette.Visible = True
        End If
    End Sub
    Private Sub rdb_ecran_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_ecran.CheckedChanged
        If rdb_ecran.Enabled = True Then
            gb_pc.Visible = False
            gb_ecran.Visible = True
            gb_tablette.Visible = False
        End If
    End Sub




    'Code pour le chargement du formulaire lors de l'affichage des informations dans les zones de textes
    Private Sub ModifMat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On remplit tout d'abord les combobox
        cb_ecran_ecran.Items.Add("1000 Pouces")
        cb_ecran_ecran.Items.Add("2000 Pouces")
        cb_ecran_ecran.Items.Add("3000 Pouces")
        cb_ecran_ecran.Items.Add("500 Pouces")
        cb_ecran_ecran.Items.Add("950 Pouces")

        cb_resolution.Items.Add("4K")
        cb_resolution.Items.Add("1080P")
        cb_resolution.Items.Add("480P")
        cb_resolution.Items.Add("960P")
        cb_resolution.Items.Add("128P")

        cb_pc_disque.Items.Add("1To")
        cb_pc_disque.Items.Add("2To")
        cb_pc_disque.Items.Add("1To SSD")
        cb_pc_disque.Items.Add("500Go")
        cb_pc_disque.Items.Add("250Go")

        cb_pc_ram.Items.Add("2Go")
        cb_pc_ram.Items.Add("4Go")
        cb_pc_ram.Items.Add("8Go")
        cb_pc_ram.Items.Add("16Go")
        cb_pc_ram.Items.Add("32Go")
        cb_pc_ram.Items.Add("64Go")
        cb_pc_ram.Items.Add("128Go")

        cb_tablette_ram.Items.Add("2Go")
        cb_tablette_ram.Items.Add("4Go")
        cb_tablette_ram.Items.Add("8Go")
        cb_tablette_ram.Items.Add("16Go")
        cb_tablette_ram.Items.Add("32Go")
        cb_tablette_ram.Items.Add("64Go")
        cb_tablette_ram.Items.Add("128Go")

        cb_tablette_ecran.Items.Add("4K")
        cb_tablette_ecran.Items.Add("1080P")
        cb_tablette_ecran.Items.Add("480P")
        cb_tablette_ecran.Items.Add("960P")
        cb_tablette_ecran.Items.Add("128P")

        cb_tablette_ram.Items.Add("1To")
        cb_tablette_ram.Items.Add("2To")
        cb_tablette_ram.Items.Add("1To SSD")
        cb_tablette_ram.Items.Add("500Go")
        cb_tablette_ram.Items.Add("250Go")


        'On rehcerhce tout d'abord le matériel par son numéro
        For Each unMat In CollectionMatériel
            If leMat = unMat.CodeMat Then
                'on remplit tout d'abord les zones de texte des informations du matériels
                tb_nom_materiel.Text = unMat.LibMat
                tb_prix.Text = unMat.Prix
                date_garantie.Text = unMat.garantie
                tb_description.Text = unMat.description

                'Ensuite on regarde à quelle type il appartient
                If unMat.TypeMat = "PC" Then
                    rdb_PC.Checked = True
                    rdb_ecran.Enabled = False
                    rdb_tablette.Enabled = False
                    'On recherche le PC dans la collection des PC que l'on as
                    For Each unPc In CollectionPC
                        If unMat.CodeMat = unPc.CodeMat Then
                            cb_pc_disque.Text = unPc.DisqueD
                            tb_pc_micro.Text = unPc.MicroPro
                            cb_pc_ram.Text = unPc.Ram
                        End If
                    Next
                ElseIf unMat.TypeMat = "Tablette" Then
                    rdb_tablette.Checked = True
                    rdb_PC.Enabled = False
                    rdb_ecran.Enabled = False
                    For Each uneTablette In CollectionTab
                        If unMat.CodeMat = uneTablette.CodeMat Then
                            cb_tablette_disque.Text = uneTablette.DisqueD
                            cb_tablette_ecran.Text = uneTablette.TaileE
                            cb_tablette_ram.Text = uneTablette.Ram
                        End If
                    Next
                ElseIf unMat.TypeMat = "Ecran" Then
                    rdb_ecran.Checked = True
                    rdb_tablette.Enabled = False
                    rdb_PC.Enabled = False
                    For Each unEcran In CollectionEcran
                        If unMat.CodeMat = unEcran.CodeMat Then
                            cb_ecran_ecran.Text = unEcran.Taille
                            cb_resolution.Text = unEcran.Taille
                            tb_technologie.Text = unEcran.Resolution
                        End If
                    Next
                End If
            End If
        Next
    End Sub
End Class