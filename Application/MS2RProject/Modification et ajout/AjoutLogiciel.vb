Public Class AjoutLogiciel

    'Bouton pour valider 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_valider.Click
        Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
        Reponse = MessageBox.Show("Êtes-vous vraiment sûr de vouloir ajouté ce logiciel ?", "Ajouter", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
        If Reponse = DialogResult.Yes Then
            'On instancie un logiciel avec les informations rentrée
            Dim unLogiciel As New Logiciel(GenereCodeLog, tb_name_logi.Text, tb_license.Text, tb_nombre_user.Text, date_achat.Text)
            'On l'ajoute à la collection
            CollectionLogiciel.Add(unLogiciel)
            'On ferme la fenêtre d'ajout
            Me.Close()
        End If
    End Sub


    'Bouton pour annuler et revenir en arrière
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
        Reponse = MessageBox.Show("Voulez-vous vraiment tout annuler ?", "Annuler", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
        If Reponse = DialogResult.Yes Then Me.Close()
    End Sub


    Private Sub AjoutLogiciel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_license.Clear()
        tb_name_logi.Clear()
        tb_nombre_user.Clear()
    End Sub
End Class