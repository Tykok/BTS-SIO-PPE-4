Imports System.Security.Cryptography
Imports System.Text
Public Class Connexion
    'Variables qui contient le nom et le prénom de l'administrateur
    Public NomA As String
    Public PrenomA As String
    Public pseudo As String



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_connexion.Click
        'Variables permettant de dire si la personne qui ce connecte est ou pas un administrateur
        Dim trouve As Boolean
        For Each unAdmin In CollectionAdmin


            'On commence par crypter les données du login
            Dim Encodage() As Byte = Encoding.UTF8.GetBytes(txtB_Login.Text)
            'on définit ici une clé
            Dim Clé() As Byte = Encoding.UTF8.GetBytes("aBz0rOTy")
            Dim Crypto As New DESCryptoServiceProvider()
            Crypto.Key = Clé
            Crypto.IV = Clé
            Dim Icrypto As ICryptoTransform = Crypto.CreateEncryptor
            'On crypte le texte saisi
            Dim TxtCrypté() As Byte = Icrypto.TransformFinalBlock(Encodage, 0, Encodage.Length)

            'On convertit ici le résultat du cryptage qui ce trouve dans une collection en Base 64 afin de pour l'utiliser et le lire
            Dim LogUser = Convert.ToBase64String(TxtCrypté)


            'On termine ave le cryptage du mot de passe
            Dim Encodage1() As Byte = Encoding.UTF8.GetBytes(txtb_mdp.Text)
            'on définit ici une clé
            Dim Clé1() As Byte = Encoding.UTF8.GetBytes("ZawiU058")
            Dim Crypto1 As New DESCryptoServiceProvider()
            Crypto1.Key = Clé
            Crypto1.IV = Clé
            Dim Icrypto1 As ICryptoTransform = Crypto1.CreateEncryptor
            'On crypte le texte saisi
            Dim TxtCrypté1() As Byte = Icrypto.TransformFinalBlock(Encodage1, 0, Encodage1.Length)

            'On convertit ici le résultat du cryptage qui ce trouve dans une collection en Base 64 afin de pour l'utiliser et le lire
            Dim MdpUser = Convert.ToBase64String(TxtCrypté1)



            ' pour se faire on utilise la méthode Authentifier
            If unAdmin.Authentifier(LogUser, MdpUser) Then
                ' On passe la variable à true pour pouvoir par la suite le rediriger vers le menu
                trouve = True
                'on renseigne le nom et le prénom
                NomA = unAdmin.LireNom
                PrenomA = unAdmin.LirePrenom
                pseudo = unAdmin.Login
            End If
        Next


        'Une fois exécuté on redirige l'administrateur si il en est un
        If trouve Then
            MenuAdmin.Show()
            Me.Hide()
        Else
            txtb_mdp.Text = ""
            btn_connexion.Enabled = False
            ' sinon on affiche un message d'erreur
            MessageBox.Show("Erreur de saisie, veuillez recommencer !", "ERREUR", MessageBoxButtons.OK)
        End If
    End Sub


    Private Sub Connexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtb_mdp.Enabled = False
        btn_connexion.Enabled = False

        Dim maConnexion As New AccesBDD
        maConnexion.recuperer()
    End Sub

    Private Sub btn_Quitter_Click(sender As Object, e As EventArgs) Handles btn_Quitter.Click
        Dim maConnexion As New AccesBDD
        maConnexion.Insertion()
        End
    End Sub

    Private Sub txtB_Login_TextChanged(sender As Object, e As EventArgs) Handles txtB_Login.TextChanged
        txtb_mdp.Enabled = True
    End Sub

    Private Sub txtb_mdp_TextChanged(sender As Object, e As EventArgs) Handles txtb_mdp.TextChanged
        btn_connexion.Enabled = True
    End Sub
End Class
