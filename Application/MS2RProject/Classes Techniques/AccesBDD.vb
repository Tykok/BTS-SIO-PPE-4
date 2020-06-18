Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class AccesBDD
    'Variables de connexion à la base de données
    Private m_Connexion As MySqlConnection


    'Sub pour récupérer toutes les informations de la base de données et remplir les collections
    Public Sub recuperer()


        'Définir une chaîne de connexion 
        Dim ChaineConnexion As String
        ChaineConnexion = "server=localhost;user=root;database=ms2r_app;port=3306;password=;"
        ' Instancier la connexion 
        m_Connexion = New MySqlConnection(ChaineConnexion)
        'Ouvrir la connexion 
        Try
            m_Connexion.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



        'Variables qui contiendra toutes les requêtes
        Dim requete As String




        'remplir la collection CollectionCaissieres
        'définir la reqête
        requete = "select * from service"
        'Instancier un objet Command
        Dim cmd = New MySqlCommand
        With cmd
            'Paramétrer la commande 
            .Connection = m_Connexion
            .CommandText = requete
            .CommandType = CommandType.Text
        End With
        'créer l'objet qui reçoit le résultat de la requête 
        Dim rdr As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        While rdr.Read
            ' instancier une nouvelle caissiére 
            Dim unService As New Services(rdr.Item("NumServ"), rdr.Item("NomServ"), rdr.Item("DescripServ"))
            'la mettre dans la collection 
            CollectionService.Add(unService)
        End While
        fermer()





        'remplir la collection CollectionLogiciel
        'définir la reqête 
        requete = "select * from materiel"
        cmd = New MySqlCommand
        With cmd
            'Paramétrer la commande 
            .Connection = m_Connexion
            .CommandText = requete
            .CommandType = CommandType.Text
        End With
        m_Connexion.Open()
        Dim rdr3 As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        While rdr3.Read
            ' instancier un nouveau logiciel
            Dim unMateriel As New Materiel(rdr3.Item("CodeMat"), rdr3.Item("LibMat"), rdr3.Item("PxMat"), rdr3.Item("GarantieMat"), _
                                           rdr3.Item("DescripMat"), rdr3.Item("TypeMat"))

            'On regarde quelle type de matériel il est pour pouvoir par la suite l'ajouter à la collection du matériel
            'PC
            If rdr3.Item("TypeMat") = "PC" Then
                Dim unPC As New PC(rdr3.Item("CodeMat"), rdr3.Item("LibMat"), rdr3.Item("PxMat"), rdr3.Item("GarantieMat"), _
                                           rdr3.Item("DescripMat"), rdr3.Item("TypeMat"), _
                                           rdr3.Item("MicroPro"), rdr3.Item("Ram"), rdr3.Item("DisqueD"))
                CollectionPC.Add(unPC)
                'ECRAN
            ElseIf rdr3.Item("TypeMat") = "Ecran" Then
                Dim unEcran As New Ecran(rdr3.Item("CodeMat"), rdr3.Item("LibMat"), rdr3.Item("PxMat"), rdr3.Item("GarantieMat"), _
                           rdr3.Item("DescripMat"), rdr3.Item("TypeMat"), _
                           rdr3.Item("TailleEcran"), rdr3.Item("ResolutionEcran"), rdr3.Item("Technologie"))
                CollectionEcran.Add(unEcran)
                'TABLETTE
            ElseIf rdr3.Item("TypeMat") = "Tablette" Then
                Dim uneTablette As New Tablette(rdr3.Item("CodeMat"), rdr3.Item("LibMat"), rdr3.Item("PxMat"), rdr3.Item("GarantieMat"), _
                           rdr3.Item("DescripMat"), rdr3.Item("TypeMat"), _
                           rdr3.Item("Ram"), rdr3.Item("DisqueD"), rdr3.Item("TailleEcran"))
                CollectionTab.Add(uneTablette)
            End If

            'insérer dans la collection logiciel le matériel, peut importe son type
            CollectionMatériel.Add(unMateriel)
        End While
        fermer()





        'remplir la collection des administrateurs présents dans la BDD
        'définir la reqête 
        requete = "select * from admin"
        cmd = New MySqlCommand
        With cmd
            'Paramétrer la commande 
            .Connection = m_Connexion
            .CommandText = requete
            .CommandType = CommandType.Text
        End With
        m_Connexion.Open()
        Dim rdr4 As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        While rdr4.Read
            ' instancier un administrateur
            Dim unAdmin As New Admin(rdr4.Item("Login"), rdr4.Item("MDP"), rdr4.Item("NomA"), rdr4.Item("PrenomA"))
            'L'insérer dans la collection des administrateur
            CollectionAdmin.Add(unAdmin)
        End While
        fermer()






        'remplir la collection CollectionLogiciel
        'définir la reqête 
        requete = "SELECT * FROM logiciel"
        cmd = New MySqlCommand
        With cmd
            'Paramétrer la commande 
            .Connection = m_Connexion
            .CommandText = requete
            .CommandType = CommandType.Text
        End With
        m_Connexion.Open()
        Dim rdr2 As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        While rdr2.Read
            ' instancier un nouveau logiciel
            Dim unLogiciel As New Logiciel(rdr2.Item("CodeLogi"), rdr2.Item("LibLogi"), rdr2.Item("NumLicenceLogi"), _
                                           rdr2.Item("NbrUserLogi"), rdr2.Item("DateAchatLog"))
            'L'insérer dans la collection logiciel 
            CollectionLogiciel.Add(unLogiciel)
        End While
        fermer()


        'Ici on s'occupe de remplir les collections des services qui contiendront les informations des logiciels leurs appartenant
        requete = "SELECT * FROM service_has_logiciel"
        cmd = New MySqlCommand
        With cmd
            'Paramétrer la commande 
            .Connection = m_Connexion
            .CommandText = requete
            .CommandType = CommandType.Text
        End With
        m_Connexion.Open()
        Dim rdr5 As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        While rdr5.Read
            ' recherche du service correspondant (Num)
            Dim i As Integer = 0
            While (i < CollectionService.Count) And (CollectionService.Item(i).LireNumService <> rdr5.Item("SERVICE_NumServ"))
                i = i + 1
            End While

            'On effectue tout d'abord une condition pour voir si le logiciel ser ajouté
            If CollectionService.Item(i).LireNumService = rdr5.Item("SERVICE_NumServ") Then
                'On instancie le logiciel sélectionné
                Dim unService As Services = CollectionService.Item(i)
                'On parcourt la collection des logiciels pour retrouver celui correspondant
                For Each unLogiciel In CollectionLogiciel
                    If unLogiciel.NumLog = rdr5.Item("LOGICIEL_CodeLogi") Then

                        'On récupére le logiciel correspondant et on instancie un logiciel qui contiendra le nombre d'utilisateurs de celui-ci
                        Dim LogService As New Logiciel(unLogiciel.NumLog, unLogiciel.LibLog, unLogiciel.NumLic, rdr5.Item("Utilisateurs"))
                        'On ajoute le logiciel correspondant au service trouvé
                        unService.AjouterLogi(LogService)
                        Exit For
                    End If
                Next
            End If
        End While
        fermer()



        'Ici on s'occupe de remplir les collections des services qui contiendront les informations des matériels leurs appartenant
        requete = "SELECT * FROM materiel"
        cmd = New MySqlCommand
        With cmd
            'Paramétrer la commande 
            .Connection = m_Connexion
            .CommandText = requete
            .CommandType = CommandType.Text
        End With
        m_Connexion.Open()
        Dim rdr6 As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        While rdr6.Read
            ' instancier le matériel trouvé en fponction de la base de données et le service
            Dim i As Integer = 0
            While (i < CollectionMatériel.Count) And (CollectionMatériel.Item(i).CodeMat <> rdr6.Item("CodeMat"))
                i = i + 1
            End While
            'On instancie le matériel sélectionné
            If CollectionMatériel.Item(i).CodeMat = rdr6.Item("CodeMat") Then
                Dim unMateriel As Materiel = CollectionMatériel.Item(i)

                'On vérifie tout d'abord que le matériel appartient à un service
                If IsDBNull(rdr6.Item("NumService")) = False Then
                    'On parcourt la collection des service pour retrouver celui correspondant
                    For Each unService In CollectionService
                        If unService.LireNumService = rdr6.Item("NumService") Then
                            'On ajoute le matériel correspondant au service trouvé
                            unService.AjouterMat(unMateriel)
                            Exit For
                        End If
                    Next
                End If
            End If
        End While
        fermer()
    End Sub





    ' Sub qui permet de fermer la connexion à la BDD
    Private Sub fermer()
        Try
            m_Connexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    'Sub qui permet d'insérer les informations dans la base de données à la fermeture de l'application
    Public Sub Insertion()

        'Définir une chaîne de connexion 
        Dim ChaineConnexion As String
        ChaineConnexion = "server=localhost;user=root;database=ms2r_app;port=3306;password=;"
        ' Instancier la connexion 
        m_Connexion = New MySqlConnection(ChaineConnexion)
        'Ouvrir la connexion 
        Try
            m_Connexion.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        'Variables qui contiendra toutes les requêtes d'insertion (dans l'ordre pour aucune erreur)
        Dim requete As String

        'définir la reqête
        requete = "DELETE FROM `service_has_logiciel`; DELETE FROM `materiel`; DELETE FROM `service`; DELETE FROM `logiciel`; DELETE FROM `admin` "
        'Instancier un objet Command
        Dim cmd = New MySqlCommand
        With cmd
            'Paramétrer la commande 
            .Connection = m_Connexion
            .CommandText = requete
            .CommandType = CommandType.Text
        End With
        'éxécution de la requête
        Dim rdr As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        'fermeture de la connexion
        fermer()







        'Ouvrir la connexion 
        Try
            m_Connexion.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'On parcourt tout les sadministrateurs
        For Each unAdmin In CollectionAdmin

            'On prépapre la requête sql permettant l'insertion des données dans la base de données
            Dim insertion As New MySqlCommand("INSERT INTO `admin`(`Login`, `MDP`, `NomA`, `PrenomA`) VALUES (@Log, @MDP, @NomA, @PrenomA)", m_Connexion)

            'On renseigne les paramètres
            insertion.Parameters.AddWithValue("@Log", unAdmin.Login)
            insertion.Parameters.AddWithValue("@MDP", unAdmin.MDP)
            insertion.Parameters.AddWithValue("@NomA", unAdmin.LireNom)
            insertion.Parameters.AddWithValue("@PrenomA", unAdmin.LirePrenom)

            'On éxécute la commande SQL
            insertion.ExecuteNonQuery()
            'On enlève les données contenues dans les paramètres
            insertion.Parameters.Clear()
        Next
        'fermeture de la connexion
        fermer()




        'Ouvrir la connexion 
        Try
            m_Connexion.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'On parcourt tout les services
        For Each unService In CollectionService

            'On prépapre la requête sql permettant l'insertion des données dans la base de données
            Dim insertion As New MySqlCommand("INSERT INTO `service`(`NumServ`, `NomServ`, `DescripServ`) VALUES (@Num, @Nom, @Description)", m_Connexion)

            'On renseigne les paramètres
            insertion.Parameters.AddWithValue("@Num", unService.LireNumService)
            insertion.Parameters.AddWithValue("@Nom", unService.LireNomService)
            insertion.Parameters.AddWithValue("@Description", unService.LireDescript)

            'On éxécute la commande SQL
            insertion.ExecuteNonQuery()
            'On enlève les données contenues dans les paramètres
            insertion.Parameters.Clear()
        Next
        'fermeture de la connexion
        fermer()




        'Ouvrir la connexion 
        Try
            m_Connexion.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'On parcourt tout les logiciels
        For Each unLogiciel In CollectionLogiciel

            'On prépapre la requête sql permettant l'insertion des données dans la base de données
            Dim insertion As New MySqlCommand("INSERT INTO `logiciel`(`CodeLogi`, `LibLogi`, `NumLicenceLogi`, `NbrUserLogi`, `DateAchatLog`) VALUES (@Num, @Lib, @NumLicence, @NbUsr, @Date)", m_Connexion)

            'On renseigne les paramètres
            insertion.Parameters.AddWithValue("@Num", unLogiciel.NumLog)
            insertion.Parameters.AddWithValue("@Lib", unLogiciel.Liblog)
            insertion.Parameters.AddWithValue("@NumLicence", unLogiciel.NumLic)
            insertion.Parameters.AddWithValue("@NbUsr", unLogiciel.NbUsr)
            insertion.Parameters.AddWithValue("@Date", unLogiciel.DateAchatLog)

            'On éxécute la commande SQL
            insertion.ExecuteNonQuery()
            'On enlève les données contenues dans les paramètres
            insertion.Parameters.Clear()
        Next
        'fermeture de la connexion
        fermer()






        'Ouvrir la connexion 
        Try
            m_Connexion.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'On parcourt tout les services pour insérer le logiciel qui lui correspond ainsi que le nombre de users
        For Each unService In CollectionService
            'On parcourt ensuite les logiciels ue contient ce service pour l'insertion
            For Each LeLogiciel In unService.logicielServ

                'On prépapre la requête sql permettant l'insertion des données dans la base de données
                Dim insertion As New MySqlCommand("INSERT INTO `service_has_logiciel`(`SERVICE_NumServ`, `LOGICIEL_CodeLogi`, `Utilisateurs`) VALUES (@NumServ , @CodeLog, @User)", m_Connexion)

                'On renseigne les paramètres
                insertion.Parameters.AddWithValue("@NumServ", unService.LireNumService)
                insertion.Parameters.AddWithValue("@CodeLog", LeLogiciel.NumLog)
                insertion.Parameters.AddWithValue("@User", LeLogiciel.NbUsr)


                'On éxécute la commande SQL
                insertion.ExecuteNonQuery()
                'On enlève les données contenues dans les paramètres
                insertion.Parameters.Clear()
            Next
        Next
        'fermeture de la connexion
        fermer()








        'Tout d'abord, on parcourt la collection de matériel afin de définir ce qu'ai le matériel car l'insertion en sera différente selon le type
        For Each unMateriel In CollectionMatériel

            'Ouvrir la connexion 
            Try
                m_Connexion.Open()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Dim i As Integer
            Dim j As Integer
            Dim ServiceNull As Boolean
            i = 0
            j = 0
            'On parcourt tout les services pour trouver le matériel correpsondant
            While j < CollectionService.Count
                'On regarde si on trouve le matériel dans ce service
                If CollectionService.Item(j).trouveMat(unMateriel.CodeMat) = True Then
                    ServiceNull = False
                    Exit While
                End If

                j = j + 1

                'Lorsque tout els services ont été parcourues, cela veux dire que le matériel n'est pas encore dans un service
                If j = CollectionService.Count Then
                    ServiceNull = True
                    Exit While
                End If
            End While


            'On traite maintenant l'insertion en fonction du type de matériel
            If unMateriel.TypeMat = "PC" Then
                'PC





                'On parcourt la collection de PC pour retrouver les informations en lien avec le PC
                While i < CollectionPC.Count And CollectionPC.Item(i).CodeMat <> unMateriel.CodeMat
                    i = i + 1
                End While
                'On récupére ici le PC correspondant
                Dim unPC = CollectionPC.Item(i)



                'On prépapre la requête sql permettant l'insertion des données dans la base de données
                Dim insertion As New MySqlCommand("INSERT INTO `materiel`(`CodeMat`, `LibMat`, `PxMat`, `GarantieMat`, `DescripMat`, `MicroPro`, `Ram`, `DisqueD`, `TypeMat`, `NumService`) VALUES(@CodeMat, @LibMat ,  @PrixMat, @Garantie, @Descrip, @Micropro, @Ram, @DD, @TypeMat, @NumServ)", m_Connexion)

                If ServiceNull Then
                    'On donne les informations nécessaire à l'insertion
                    insertion.Parameters.AddWithValue("@CodeMat", unMateriel.CodeMat)
                    insertion.Parameters.AddWithValue("@LibMat", unMateriel.LibMat)
                    insertion.Parameters.AddWithValue("@PrixMat", unMateriel.Prix)
                    insertion.Parameters.AddWithValue("@Garantie", unMateriel.garantie)
                    insertion.Parameters.AddWithValue("@Descrip", unMateriel.description)
                    insertion.Parameters.AddWithValue("@Micropro", unPC.MicroPro)
                    insertion.Parameters.AddWithValue("@Ram", unPC.Ram)
                    insertion.Parameters.AddWithValue("@DD", unPC.DisqueD)
                    insertion.Parameters.AddWithValue("@TypeMat", unMateriel.TypeMat)
                    insertion.Parameters.AddWithValue("@NumServ", DBNull.Value)
                Else
                    'On récupére le service
                    Dim unService = CollectionService.Item(j)

                    'On donne les informations nécessaire à l'insertion
                    insertion.Parameters.AddWithValue("@CodeMat", unMateriel.CodeMat)
                    insertion.Parameters.AddWithValue("@LibMat", unMateriel.LibMat)
                    insertion.Parameters.AddWithValue("@PrixMat", unMateriel.Prix)
                    insertion.Parameters.AddWithValue("@Garantie", unMateriel.garantie)
                    insertion.Parameters.AddWithValue("@Descrip", unMateriel.description)
                    insertion.Parameters.AddWithValue("@Micropro", unPC.MicroPro)
                    insertion.Parameters.AddWithValue("@Ram", unPC.Ram)
                    insertion.Parameters.AddWithValue("@DD", unPC.DisqueD)
                    insertion.Parameters.AddWithValue("@TypeMat", unMateriel.TypeMat)
                    insertion.Parameters.AddWithValue("@NumServ", unService.LireNumService)
                End If


                'On éxécute la commande SQL
                insertion.ExecuteNonQuery()
                'On enlève les données contenues dans les paramètres
                insertion.Parameters.Clear()


                'fermeture de la connexion
                fermer()


            ElseIf unMateriel.TypeMat = "Tablette" Then
                'TABLETTE

                'On prépapre la requête sql permettant l'insertion des données dans la base de données
                Dim insertion As New MySqlCommand("INSERT INTO `materiel`(`CodeMat`, `LibMat`, `PxMat`, `GarantieMat`, `DescripMat`,  `Ram`, `DisqueD`, `TailleEcran`, `TypeMat`, `NumService`) VALUES (@CodeMat, @LibMat, @PrixMat, @Garantie, @Descrip, @Ram, @DD, @TailleEcran, @TypeMat, @NumServ)", m_Connexion)

                'On parcourt la collection de PC pour retrouver les informations en lien avec le PC
                While i < CollectionTab.Count And CollectionTab.Item(i).CodeMat <> unMateriel.CodeMat
                    i = i + 1
                End While
                'On récupére ici le PC correspondant
                Dim uneTablette = CollectionTab.Item(i)

                If ServiceNull Then
                    'On donne les informations nécessaire à l'insertion
                    insertion.Parameters.AddWithValue("@CodeMat", unMateriel.CodeMat)
                    insertion.Parameters.AddWithValue("@LibMat", unMateriel.LibMat)
                    insertion.Parameters.AddWithValue("@PrixMat", unMateriel.Prix)
                    insertion.Parameters.AddWithValue("@Garantie", unMateriel.garantie)
                    insertion.Parameters.AddWithValue("@Descrip", unMateriel.description)
                    insertion.Parameters.AddWithValue("@TailleEcran", uneTablette.TaileE)
                    insertion.Parameters.AddWithValue("@Ram", uneTablette.Ram)
                    insertion.Parameters.AddWithValue("@DD", uneTablette.DisqueD)
                    insertion.Parameters.AddWithValue("@TypeMat", unMateriel.TypeMat)
                    insertion.Parameters.AddWithValue("@NumServ", DBNull.Value)
                Else
                    'On récupére le service
                    Dim unService = CollectionService.Item(j)
                    'On donne les informations nécessaire à l'insertion
                    insertion.Parameters.AddWithValue("@CodeMat", unMateriel.CodeMat)
                    insertion.Parameters.AddWithValue("@LibMat", unMateriel.LibMat)
                    insertion.Parameters.AddWithValue("@PrixMat", unMateriel.Prix)
                    insertion.Parameters.AddWithValue("@Garantie", unMateriel.garantie)
                    insertion.Parameters.AddWithValue("@Descrip", unMateriel.description)
                    insertion.Parameters.AddWithValue("@TailleEcran", uneTablette.TaileE)
                    insertion.Parameters.AddWithValue("@Ram", uneTablette.Ram)
                    insertion.Parameters.AddWithValue("@DD", uneTablette.DisqueD)
                    insertion.Parameters.AddWithValue("@TypeMat", unMateriel.TypeMat)
                    insertion.Parameters.AddWithValue("@NumServ", unService.LireNumService)
                End If
               

                'On éxécute la commande SQL
                insertion.ExecuteNonQuery()
                'On enlève les données contenues dans les paramètres
                insertion.Parameters.Clear()

                'fermeture de la connexion
                fermer()

            ElseIf unMateriel.TypeMat = "Ecran" Then
                'Ecran

                'On prépapre la requête sql permettant l'insertion des données dans la base de données
                Dim insertion As New MySqlCommand("INSERT INTO `materiel`(`CodeMat`, `LibMat`, `PxMat`, `GarantieMat`, `DescripMat`, `TailleEcran`, `ResolutionEcran`, `Technologie`, `TypeMat`, `NumService`) VALUES (@CodeMat, @LibMat, @PrixMat, @Garantie, @Descrip, @Taille, @Resolution, @Technologie, @TypeMat, @NumServ)", m_Connexion)


                'On parcourt la collection de PC pour retrouver les informations en lien avec le PC
                While i < CollectionEcran.Count And CollectionEcran.Item(i).CodeMat <> unMateriel.CodeMat
                    i = i + 1
                End While
                'On récupére ici le PC correspondant
                Dim unEcran = CollectionEcran.Item(i)

                If ServiceNull Then
                    'On donne les informations nécessaire à l'insertion
                    insertion.Parameters.AddWithValue("@CodeMat", unMateriel.CodeMat)
                    insertion.Parameters.AddWithValue("@LibMat", unMateriel.LibMat)
                    insertion.Parameters.AddWithValue("@PrixMat", unMateriel.Prix)
                    insertion.Parameters.AddWithValue("@Garantie", unMateriel.garantie)
                    insertion.Parameters.AddWithValue("@Descrip", unMateriel.description)
                    insertion.Parameters.AddWithValue("@Taille", unEcran.taille)
                    insertion.Parameters.AddWithValue("@Resolution", unEcran.resolution)
                    insertion.Parameters.AddWithValue("@Technologie", unEcran.technologie)
                    insertion.Parameters.AddWithValue("@TypeMat", unMateriel.TypeMat)
                    insertion.Parameters.AddWithValue("@NumServ", DBNull.Value)
                Else
                    'On récupére le service
                    Dim unService = CollectionService.Item(j)
                    'On donne les informations nécessaire à l'insertion
                    insertion.Parameters.AddWithValue("@CodeMat", unMateriel.CodeMat)
                    insertion.Parameters.AddWithValue("@LibMat", unMateriel.LibMat)
                    insertion.Parameters.AddWithValue("@PrixMat", unMateriel.Prix)
                    insertion.Parameters.AddWithValue("@Garantie", unMateriel.garantie)
                    insertion.Parameters.AddWithValue("@Descrip", unMateriel.description)
                    insertion.Parameters.AddWithValue("@Taille", unEcran.taille)
                    insertion.Parameters.AddWithValue("@Resolution", unEcran.resolution)
                    insertion.Parameters.AddWithValue("@Technologie", unEcran.technologie)
                    insertion.Parameters.AddWithValue("@TypeMat", unMateriel.TypeMat)
                    insertion.Parameters.AddWithValue("@NumServ", unService.LireNumService)
                End If



                'On éxécute la commande SQL
                insertion.ExecuteNonQuery()
                'On enlève les données contenues dans les paramètres
                insertion.Parameters.Clear()


                'fermeture de la connexion
                fermer()
            End If
        Next

   
    End Sub
End Class
