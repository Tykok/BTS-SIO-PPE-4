Public Class AjoutService
    'Variables public qui sera rcupérer sur le formulaire d'ajout logiciels et matériels
    Public service As Services

    'Bouton valider (traitement de la demande)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_valider.Click

        'Tout d'abord on ajoute les informations entrer du service (nom, description, génération d'un numéro unique)
        Dim unService As New Services(GenereCodeServ, tb_new_service.Text, tb_description.Text)
        'On l'ajoute ensuite à la collection de services
        CollectionService.Add(unService)

        'Ensuite on traite la demande de l'utilisateur à propos de l'ajout du matériel
        If rb_ajout.Checked = True Then
            'On renseigne le service qu'on as ajouter en global
            service = unService
            'On ouvre ici le formulaire qui va permettre de lui ajouter les matériels et logiciels
            MofifService.ShowDialog()
        Else
            Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
            Reponse = MessageBox.Show("Êtes-vous vraiment sûr de vouloir créer ce service ?", "Créer", _
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
            If Reponse = DialogResult.Yes Then Me.Close()
        End If
    End Sub

    'Bouton annuler (retour et effacement des informations)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
        Reponse = MessageBox.Show("Voulez-vous vraiment tout annuler ?", "Annuler", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
        If Reponse = DialogResult.Yes Then Me.Close()
    End Sub



    'Chargement du formulaire
    Private Sub AjoutService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rb_plustard.Checked = True
        tb_description.Clear()
        tb_new_service.Clear()
    End Sub
End Class