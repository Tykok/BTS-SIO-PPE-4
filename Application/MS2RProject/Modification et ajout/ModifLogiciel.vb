Public Class ModifLogiciel
    'Récupération du logiciel sur lequel on travaille (celui sélectionné)
    Dim LeLogiciel = GestionLogiciel.LeLogiciel

    'Pour la validation de la modification du logiciel
    Private Sub btn_valider_Click(sender As Object, e As EventArgs) Handles btn_valider.Click

        Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
        Reponse = MessageBox.Show("Modifier les informations du logiciel ?", "Modifier", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
        If Reponse = DialogResult.Yes Then

            'Modification du logiciel
            LeLogiciel.LibLog = tb_name_logi.Text
            LeLogiciel.NumLic = tb_license.Text
            LeLogiciel.NbUsr = tb_nombre_user.Text
            LeLogiciel.DateAchatLog = date_achat.Text

            Dim Glog As New GestionLogiciel
            Glog.Show()
            'Fermeture de la fenêtre
            Me.Close()
        End If
    End Sub





    'Pour le chargement du formulaire
    Private Sub ModifLogiciel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Au chargement on met les informations dans les zones de textes
        tb_name_logi.Text = LeLogiciel.LibLog
        tb_license.Text = LeLogiciel.NumLic
        tb_nombre_user.Text = LeLogiciel.NbUsr
        date_achat.Text = LeLogiciel.DateAchatLog
    End Sub


    'Si on doit tout annuler
    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
        Reponse = MessageBox.Show("Annuler les modifications?", "Retour", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
        If Reponse = DialogResult.Yes Then Me.Close()
    End Sub
End Class