Imports System.Security.Cryptography
Imports System.Text
Public Class ModifAdmin
    Dim LogAdmin = Connexion.pseudo
    Dim Ladmin


    Private Sub btn_Quitter_Click(sender As Object, e As EventArgs) Handles btn_Quitter.Click
        Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
        Reponse = MessageBox.Show("Voulez-vous vraiment tout annuler ?", "Annuler", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
        If Reponse = DialogResult.Yes Then Me.Close()
    End Sub

    Private Sub btn_connexion_Click(sender As Object, e As EventArgs) Handles btn_connexion.Click
        If txtb_mdp.Text <> tb_Confirm.Text Then
            MessageBox.Show("Les mots de passe ne correspondent pas!", "ERREUR", MessageBoxButtons.OK)
        Else

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
            Dim LoginText = txtB_Login.Text
            LoginText = Convert.ToBase64String(TxtCrypté)
            'On modifie par la suite e login de l'administrateur
            Ladmin.login = LoginText


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
            Dim PassText = txtb_mdp.Text
            PassText = Convert.ToBase64String(TxtCrypté1)
            'On modifie le mot de passe de l'administrateur
            Ladmin.MDP = PassText


            MessageBox.Show("Vos informations ont été modifiés", "Succés", MessageBoxButtons.OK)
            Me.Close()
        End If
    End Sub

    'On charge les informations lors du load du formulaire
    Private Sub ModifAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        While i < CollectionAdmin.Count And CollectionAdmin.Item(i).Login <> LogAdmin
            i = i + 1
        End While
        Ladmin = CollectionAdmin.Item(i)



        'Tou d'abord on décrypte les données provenant de la collection
        'On Commence avec le LOGIN
        Dim ResultatBytes() As Byte = Convert.FromBase64String(Ladmin.Login)
        'On reprend la clé de cryptage
        Dim Clé() As Byte = Encoding.UTF8.GetBytes("aBz0rOTy")
        Dim Crypto As New DESCryptoServiceProvider()
        Crypto.Key = Clé
        Crypto.IV = Clé
        'On crée une varibale permettant de crypter
        Dim Icrypto As ICryptoTransform = Crypto.CreateDecryptor()
        'On crypte les données
        Dim Décode() As Byte = Icrypto.TransformFinalBlock(ResultatBytes, 0, ResultatBytes.Length)
        Dim LogUser = Encoding.UTF8.GetString(Décode)



        'On termine avec le MOT DE PASSE
        Dim ResultatBytes1() As Byte = Convert.FromBase64String(Ladmin.MDP)
        'On reprend la clé de cryptage
        Dim Clé1() As Byte = Encoding.UTF8.GetBytes("ZawiU058")
        Dim Crypto1 As New DESCryptoServiceProvider()
        Crypto1.Key = Clé1
        Crypto1.IV = Clé1
        'On crée une varibale permettant de crypter
        Dim Icrypto1 As ICryptoTransform = Crypto.CreateDecryptor()
        'On crypte les données
        Dim Décode1() As Byte = Icrypto.TransformFinalBlock(ResultatBytes1, 0, ResultatBytes1.Length)
        Dim MdpUser = Encoding.UTF8.GetString(Décode1)



        txtB_Login.Text = LogUser
        txtb_mdp.Text = MdpUser
    End Sub
End Class