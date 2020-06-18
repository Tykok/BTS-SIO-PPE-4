Public Class AjoutMateriel

    'Code de validation après la saisie des champs pour un matériel
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Valider.Click
        Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
        Reponse = MessageBox.Show("Êtes-vous vraiment sûr de vouloir ajouté ce matériel ?", "Ajouter", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
        If Reponse = DialogResult.Yes Then

            'Si il as cliqué sur "OUI" alors on effectue des test pour vérifier la saisie des champs
            If rdb_ecran.Checked = True Then
                Dim CodeDuMat = GenereCodeMat()
                'On instancie l'objet matériel
                Dim unMateriel As New Materiel(CodeDuMat, txtb_NomMat.Text, txtb_Prix.Text, date_Garantie.Text, txtb_Description.Text, _
                 "Ecran")
                'Enfin on l'instancie aussi pour l'avoir dans la colelction des écrans
                Dim unEcran As New Ecran(CodeDuMat, txtb_NomMat.Text, txtb_Prix.Text, date_Garantie.Text, txtb_Description.Text, _
                 "Ecran", cb_tailleEcran.Text, cb_Resolution.Text, txtb_TechnologieEcran.Text)
                'Enfin on ajoute ses deux objets aux collections respective
                CollectionMatériel.Add(unMateriel)
                CollectionEcran.Add(unEcran)

            ElseIf rdb_PC.Checked = True Then
                Dim CodeDuMat = GenereCodeMat()
                'On instancie l'objet matériel
                Dim unMateriel As New Materiel(CodeDuMat, txtb_NomMat.Text, txtb_Prix.Text, date_Garantie.Text, txtb_Description.Text, _
                 "PC")
                'Enfin on l'instancie aussi pour l'avoir dans la colelction des PC
                Dim unPC As New PC(CodeDuMat, txtb_NomMat.Text, txtb_Prix.Text, date_Garantie.Text, txtb_Description.Text, _
                 "PC", txtb_Micro.Text, cb_Ram.Text, cb_DDPc.Text)
                'Enfin on ajoute ses deux objets aux collections respective
                CollectionMatériel.Add(unMateriel)
                CollectionPC.Add(unPC)

            ElseIf rdb_tablette.Checked = True Then

                'On instancie l'objet matériel
                Dim CodeDuMat = GenereCodeMat()
                Dim unMateriel As New Materiel(CodeDuMat, txtb_NomMat.Text, txtb_Prix.Text, date_Garantie.Text, txtb_Description.Text, _
                 "Tablette")
                'Enfin on l'instancie aussi pour l'avoir dans la colelction des écrans
                Dim uneTablette As New Tablette(CodeDuMat, txtb_NomMat.Text, txtb_Prix.Text, date_Garantie.Text, txtb_Description.Text, _
                 "Tablette", cb_RamTab.Text, cb_DDTab.Text, cb_TailleTab.Text)
                'Enfin on ajoute ses deux objets aux collections respective
                CollectionMatériel.Add(unMateriel)
                CollectionTab.Add(uneTablette)

            Else
                MessageBox.Show("Veuillez saisir un type de matériel", "Erreur", MessageBoxButtons.OK)
            End If
        End If
        Me.Close()
    End Sub
    'Code pour quitter et annuler la saisie
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_Supprimer.Click
        Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
        Reponse = MessageBox.Show("Voulez-vous vraiment tout annuler ?", "Annuler", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
        If Reponse = DialogResult.Yes Then Me.Close()
    End Sub
    'Code pour les radios boutons (visible/invisible) en fonction de ce que l'on aura cocher
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_PC.CheckedChanged
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



    Private Sub AjoutMateriel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_tailleEcran.Items.Add("1000")
        cb_tailleEcran.Items.Add("1000")
        cb_tailleEcran.Items.Add("1000")
        cb_tailleEcran.Items.Add("1000")
        cb_tailleEcran.Items.Add("1000")

        cb_Resolution.Items.Add("4K")
        cb_Resolution.Items.Add("1080P")
        cb_Resolution.Items.Add("480P")
        cb_Resolution.Items.Add("960P")
        cb_Resolution.Items.Add("128P")

        cb_DDPc.Items.Add("1To")
        cb_DDPc.Items.Add("2To")
        cb_DDPc.Items.Add("1To SSD")
        cb_DDPc.Items.Add("500Go")
        cb_DDPc.Items.Add("250Go")

        cb_Ram.Items.Add("2Go")
        cb_Ram.Items.Add("4Go")
        cb_Ram.Items.Add("8Go")
        cb_Ram.Items.Add("16Go")
        cb_Ram.Items.Add("32Go")
        cb_Ram.Items.Add("64Go")
        cb_Ram.Items.Add("128Go")

        cb_RamTab.Items.Add("2Go")
        cb_RamTab.Items.Add("4Go")
        cb_RamTab.Items.Add("8Go")
        cb_RamTab.Items.Add("16Go")
        cb_RamTab.Items.Add("32Go")
        cb_RamTab.Items.Add("64Go")
        cb_RamTab.Items.Add("128Go")

        cb_TailleTab.Items.Add("4K")
        cb_TailleTab.Items.Add("1080P")
        cb_TailleTab.Items.Add("480P")
        cb_TailleTab.Items.Add("960P")
        cb_TailleTab.Items.Add("128P")

        cb_DDTab.Items.Add("1To")
        cb_DDTab.Items.Add("2To")
        cb_DDTab.Items.Add("1To SSD")
        cb_DDTab.Items.Add("500Go")
        cb_DDTab.Items.Add("250Go")

        txtb_Description.Clear()
        txtb_Micro.Clear()
        txtb_NomMat.Clear()
        txtb_Prix.Clear()
        txtb_TechnologieEcran.Clear()
    End Sub


End Class