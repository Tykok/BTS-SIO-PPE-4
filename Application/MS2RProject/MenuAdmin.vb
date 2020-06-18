Public Class MenuAdmin
    Dim ConnexionBDD As New AccesBDD
   
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_ConsultationService.Click
        Me.Close()
        GestionServices.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_AjoutServices.Click
        AjoutService.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_ConsultationMat.Click
        GestionMateriels.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn_AjoutMat.Click
        AjoutMateriel.ShowDialog()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btn_AjoutLog.Click
        AjoutLogiciel.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_Quitter.Click
        Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
        Reponse = MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Quitter", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
        If Reponse = DialogResult.Yes Then
            ConnexionBDD.Insertion()
            End
        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btn_ConsultationLog.Click
        GestionLogiciel.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btn_Deco.Click
        Dim Connex As New Connexion
        Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
        Reponse = MessageBox.Show("Êtes-vous vraiment sûr de vouloir vous déconnectez ?", "Quitter", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
        If Reponse = DialogResult.Yes Then
            'On insére les modifications
            ConnexionBDD.Insertion()

            'On vide toute les colelctions pour les recharger à la connexion (si changement)
            Deco()
            'On ferme le formulaire
            Me.Close()
            Connex.Show()
        End If

    End Sub

    Private Sub MenuAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_nom.Text = Connexion.NomA + " " + Connexion.PrenomA
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ModifAdmin.ShowDialog()
    End Sub
End Class