<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionLogiciel
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_nombre_uti = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_modif_logi = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lbl_total_user = New System.Windows.Forms.Label()
        Me.lbl_nombre_uti_logi = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menu_add_logi = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_supp_logi = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ltv_Logiciel = New System.Windows.Forms.ListView()
        Me.colonneNum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColonneLibLog = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColonneNbUsr = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colonneDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ltv_Serv = New System.Windows.Forms.ListView()
        Me.ColonneNumServ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColonneNomServ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(333, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gestion des logiciels"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(215, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Liste des logiciels"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre d'utilisateur restant :"
        '
        'lbl_nombre_uti
        '
        Me.lbl_nombre_uti.AutoSize = True
        Me.lbl_nombre_uti.Location = New System.Drawing.Point(152, 28)
        Me.lbl_nombre_uti.Name = "lbl_nombre_uti"
        Me.lbl_nombre_uti.Size = New System.Drawing.Size(99, 13)
        Me.lbl_nombre_uti.TabIndex = 4
        Me.lbl_nombre_uti.Text = """Affiche le nombre"""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(569, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(172, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Le(s) service(s) utilisant ce logiciel :"
        '
        'btn_modif_logi
        '
        Me.btn_modif_logi.Location = New System.Drawing.Point(88, 413)
        Me.btn_modif_logi.Name = "btn_modif_logi"
        Me.btn_modif_logi.Size = New System.Drawing.Size(102, 30)
        Me.btn_modif_logi.TabIndex = 9
        Me.btn_modif_logi.Text = "Modifier logiciel"
        Me.btn_modif_logi.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(712, 457)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(132, 38)
        Me.btn_back.TabIndex = 10
        Me.btn_back.Text = "&Retour au menu"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'lbl_total_user
        '
        Me.lbl_total_user.AutoSize = True
        Me.lbl_total_user.Location = New System.Drawing.Point(164, 80)
        Me.lbl_total_user.Name = "lbl_total_user"
        Me.lbl_total_user.Size = New System.Drawing.Size(99, 13)
        Me.lbl_total_user.TabIndex = 8
        Me.lbl_total_user.Text = """Affiche le nombre"""
        '
        'lbl_nombre_uti_logi
        '
        Me.lbl_nombre_uti_logi.AutoSize = True
        Me.lbl_nombre_uti_logi.Location = New System.Drawing.Point(6, 80)
        Me.lbl_nombre_uti_logi.Name = "lbl_nombre_uti_logi"
        Me.lbl_nombre_uti_logi.Size = New System.Drawing.Size(152, 13)
        Me.lbl_nombre_uti_logi.TabIndex = 5
        Me.lbl_nombre_uti_logi.Text = "Nombre d'utilisateur du logiciel:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_add_logi})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(856, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menu_add_logi
        '
        Me.menu_add_logi.Name = "menu_add_logi"
        Me.menu_add_logi.Size = New System.Drawing.Size(89, 20)
        Me.menu_add_logi.Text = "Ajout logiciel"
        '
        'btn_supp_logi
        '
        Me.btn_supp_logi.Location = New System.Drawing.Point(271, 413)
        Me.btn_supp_logi.Name = "btn_supp_logi"
        Me.btn_supp_logi.Size = New System.Drawing.Size(102, 30)
        Me.btn_supp_logi.TabIndex = 12
        Me.btn_supp_logi.Text = "Supprimer logiciel"
        Me.btn_supp_logi.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbl_nombre_uti)
        Me.GroupBox1.Controls.Add(Me.lbl_nombre_uti_logi)
        Me.GroupBox1.Controls.Add(Me.lbl_total_user)
        Me.GroupBox1.Location = New System.Drawing.Point(506, 132)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(269, 116)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informations complémentaires"
        '
        'ltv_Logiciel
        '
        Me.ltv_Logiciel.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colonneNum, Me.ColonneLibLog, Me.ColonneNbUsr, Me.colonneDate})
        Me.ltv_Logiciel.FullRowSelect = True
        Me.ltv_Logiciel.Location = New System.Drawing.Point(12, 126)
        Me.ltv_Logiciel.Name = "ltv_Logiciel"
        Me.ltv_Logiciel.Size = New System.Drawing.Size(475, 281)
        Me.ltv_Logiciel.TabIndex = 14
        Me.ltv_Logiciel.UseCompatibleStateImageBehavior = False
        Me.ltv_Logiciel.View = System.Windows.Forms.View.Details
        '
        'colonneNum
        '
        Me.colonneNum.Text = "N°"
        Me.colonneNum.Width = 32
        '
        'ColonneLibLog
        '
        Me.ColonneLibLog.Text = "Nom du logiciel"
        Me.ColonneLibLog.Width = 245
        '
        'ColonneNbUsr
        '
        Me.ColonneNbUsr.Text = "Nombre d'utilisateurs"
        Me.ColonneNbUsr.Width = 111
        '
        'colonneDate
        '
        Me.colonneDate.Text = "Date"
        Me.colonneDate.Width = 81
        '
        'ltv_Serv
        '
        Me.ltv_Serv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColonneNumServ, Me.ColonneNomServ})
        Me.ltv_Serv.FullRowSelect = True
        Me.ltv_Serv.Location = New System.Drawing.Point(515, 291)
        Me.ltv_Serv.Name = "ltv_Serv"
        Me.ltv_Serv.Size = New System.Drawing.Size(275, 116)
        Me.ltv_Serv.TabIndex = 15
        Me.ltv_Serv.UseCompatibleStateImageBehavior = False
        Me.ltv_Serv.View = System.Windows.Forms.View.Details
        '
        'ColonneNumServ
        '
        Me.ColonneNumServ.Text = "N°"
        Me.ColonneNumServ.Width = 37
        '
        'ColonneNomServ
        '
        Me.ColonneNomServ.Text = "Nom du service"
        Me.ColonneNomServ.Width = 233
        '
        'GestionLogiciel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(856, 507)
        Me.Controls.Add(Me.ltv_Serv)
        Me.Controls.Add(Me.ltv_Logiciel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_supp_logi)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_modif_logi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "GestionLogiciel"
        Me.Text = "Logiciel"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre_uti As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_modif_logi As System.Windows.Forms.Button
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents lbl_total_user As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre_uti_logi As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menu_add_logi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_supp_logi As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ltv_Logiciel As System.Windows.Forms.ListView
    Friend WithEvents colonneNum As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColonneLibLog As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColonneNbUsr As System.Windows.Forms.ColumnHeader
    Friend WithEvents colonneDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents ltv_Serv As System.Windows.Forms.ListView
    Friend WithEvents ColonneNumServ As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColonneNomServ As System.Windows.Forms.ColumnHeader
End Class
