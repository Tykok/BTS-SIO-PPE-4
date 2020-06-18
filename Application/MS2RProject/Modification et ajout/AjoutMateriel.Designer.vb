<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AjoutMateriel
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtb_NomMat = New System.Windows.Forms.TextBox()
        Me.txtb_Prix = New System.Windows.Forms.TextBox()
        Me.txtb_Micro = New System.Windows.Forms.TextBox()
        Me.txtb_TechnologieEcran = New System.Windows.Forms.TextBox()
        Me.cb_Ram = New System.Windows.Forms.ComboBox()
        Me.cb_DDPc = New System.Windows.Forms.ComboBox()
        Me.cb_tailleEcran = New System.Windows.Forms.ComboBox()
        Me.cb_Resolution = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.date_Garantie = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rdb_ecran = New System.Windows.Forms.RadioButton()
        Me.rdb_PC = New System.Windows.Forms.RadioButton()
        Me.rdb_tablette = New System.Windows.Forms.RadioButton()
        Me.gb_ecran = New System.Windows.Forms.GroupBox()
        Me.gb_tablette = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cb_TailleTab = New System.Windows.Forms.ComboBox()
        Me.cb_RamTab = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cb_DDTab = New System.Windows.Forms.ComboBox()
        Me.txtb_Description = New System.Windows.Forms.TextBox()
        Me.gb_pc = New System.Windows.Forms.GroupBox()
        Me.btn_Valider = New System.Windows.Forms.Button()
        Me.btn_Supprimer = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.gb_ecran.SuspendLayout()
        Me.gb_tablette.SuspendLayout()
        Me.gb_pc.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom du matériel:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Prix:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Garantie:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Description:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Microprocesseur:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(62, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Ram:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Disque Dur:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Taille de l'écran:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Résolution:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Technologie:"
        '
        'txtb_NomMat
        '
        Me.txtb_NomMat.Location = New System.Drawing.Point(98, 25)
        Me.txtb_NomMat.Name = "txtb_NomMat"
        Me.txtb_NomMat.Size = New System.Drawing.Size(100, 20)
        Me.txtb_NomMat.TabIndex = 11
        '
        'txtb_Prix
        '
        Me.txtb_Prix.Location = New System.Drawing.Point(98, 62)
        Me.txtb_Prix.Name = "txtb_Prix"
        Me.txtb_Prix.Size = New System.Drawing.Size(63, 20)
        Me.txtb_Prix.TabIndex = 12
        '
        'txtb_Micro
        '
        Me.txtb_Micro.Location = New System.Drawing.Point(100, 31)
        Me.txtb_Micro.Name = "txtb_Micro"
        Me.txtb_Micro.Size = New System.Drawing.Size(100, 20)
        Me.txtb_Micro.TabIndex = 13
        '
        'txtb_TechnologieEcran
        '
        Me.txtb_TechnologieEcran.Location = New System.Drawing.Point(96, 98)
        Me.txtb_TechnologieEcran.Name = "txtb_TechnologieEcran"
        Me.txtb_TechnologieEcran.Size = New System.Drawing.Size(121, 20)
        Me.txtb_TechnologieEcran.TabIndex = 14
        '
        'cb_Ram
        '
        Me.cb_Ram.FormattingEnabled = True
        Me.cb_Ram.Location = New System.Drawing.Point(100, 64)
        Me.cb_Ram.Name = "cb_Ram"
        Me.cb_Ram.Size = New System.Drawing.Size(65, 21)
        Me.cb_Ram.TabIndex = 17
        '
        'cb_DDPc
        '
        Me.cb_DDPc.FormattingEnabled = True
        Me.cb_DDPc.Location = New System.Drawing.Point(100, 104)
        Me.cb_DDPc.Name = "cb_DDPc"
        Me.cb_DDPc.Size = New System.Drawing.Size(121, 21)
        Me.cb_DDPc.TabIndex = 18
        '
        'cb_tailleEcran
        '
        Me.cb_tailleEcran.FormattingEnabled = True
        Me.cb_tailleEcran.Location = New System.Drawing.Point(96, 25)
        Me.cb_tailleEcran.Name = "cb_tailleEcran"
        Me.cb_tailleEcran.Size = New System.Drawing.Size(121, 21)
        Me.cb_tailleEcran.TabIndex = 19
        '
        'cb_Resolution
        '
        Me.cb_Resolution.FormattingEnabled = True
        Me.cb_Resolution.Location = New System.Drawing.Point(96, 64)
        Me.cb_Resolution.Name = "cb_Resolution"
        Me.cb_Resolution.Size = New System.Drawing.Size(121, 21)
        Me.cb_Resolution.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.date_Garantie)
        Me.GroupBox1.Controls.Add(Me.gb_tablette)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.gb_ecran)
        Me.GroupBox1.Controls.Add(Me.txtb_Description)
        Me.GroupBox1.Controls.Add(Me.txtb_NomMat)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtb_Prix)
        Me.GroupBox1.Controls.Add(Me.gb_pc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(497, 293)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informations"
        '
        'date_Garantie
        '
        Me.date_Garantie.Location = New System.Drawing.Point(98, 109)
        Me.date_Garantie.Name = "date_Garantie"
        Me.date_Garantie.Size = New System.Drawing.Size(200, 20)
        Me.date_Garantie.TabIndex = 30
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rdb_ecran)
        Me.GroupBox5.Controls.Add(Me.rdb_PC)
        Me.GroupBox5.Controls.Add(Me.rdb_tablette)
        Me.GroupBox5.Location = New System.Drawing.Point(330, 25)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(84, 99)
        Me.GroupBox5.TabIndex = 29
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Type"
        '
        'rdb_ecran
        '
        Me.rdb_ecran.AccessibleName = ""
        Me.rdb_ecran.AutoSize = True
        Me.rdb_ecran.Location = New System.Drawing.Point(9, 67)
        Me.rdb_ecran.Name = "rdb_ecran"
        Me.rdb_ecran.Size = New System.Drawing.Size(53, 17)
        Me.rdb_ecran.TabIndex = 31
        Me.rdb_ecran.TabStop = True
        Me.rdb_ecran.Text = "Ecran"
        Me.rdb_ecran.UseVisualStyleBackColor = True
        '
        'rdb_PC
        '
        Me.rdb_PC.AccessibleName = ""
        Me.rdb_PC.AutoSize = True
        Me.rdb_PC.Location = New System.Drawing.Point(9, 19)
        Me.rdb_PC.Name = "rdb_PC"
        Me.rdb_PC.Size = New System.Drawing.Size(39, 17)
        Me.rdb_PC.TabIndex = 29
        Me.rdb_PC.TabStop = True
        Me.rdb_PC.Text = "PC"
        Me.rdb_PC.UseVisualStyleBackColor = True
        '
        'rdb_tablette
        '
        Me.rdb_tablette.AccessibleName = ""
        Me.rdb_tablette.AutoSize = True
        Me.rdb_tablette.Location = New System.Drawing.Point(9, 43)
        Me.rdb_tablette.Name = "rdb_tablette"
        Me.rdb_tablette.Size = New System.Drawing.Size(64, 17)
        Me.rdb_tablette.TabIndex = 30
        Me.rdb_tablette.TabStop = True
        Me.rdb_tablette.Text = "Tablette"
        Me.rdb_tablette.UseVisualStyleBackColor = True
        '
        'gb_ecran
        '
        Me.gb_ecran.AccessibleName = ""
        Me.gb_ecran.Controls.Add(Me.Label8)
        Me.gb_ecran.Controls.Add(Me.cb_tailleEcran)
        Me.gb_ecran.Controls.Add(Me.Label9)
        Me.gb_ecran.Controls.Add(Me.cb_Resolution)
        Me.gb_ecran.Controls.Add(Me.Label10)
        Me.gb_ecran.Controls.Add(Me.txtb_TechnologieEcran)
        Me.gb_ecran.Location = New System.Drawing.Point(249, 142)
        Me.gb_ecran.Name = "gb_ecran"
        Me.gb_ecran.Size = New System.Drawing.Size(231, 132)
        Me.gb_ecran.TabIndex = 24
        Me.gb_ecran.TabStop = False
        Me.gb_ecran.Text = "Ecran"
        Me.gb_ecran.Visible = False
        '
        'gb_tablette
        '
        Me.gb_tablette.AccessibleName = ""
        Me.gb_tablette.Controls.Add(Me.Label13)
        Me.gb_tablette.Controls.Add(Me.cb_TailleTab)
        Me.gb_tablette.Controls.Add(Me.cb_RamTab)
        Me.gb_tablette.Controls.Add(Me.Label11)
        Me.gb_tablette.Controls.Add(Me.Label14)
        Me.gb_tablette.Controls.Add(Me.cb_DDTab)
        Me.gb_tablette.Location = New System.Drawing.Point(249, 142)
        Me.gb_tablette.Name = "gb_tablette"
        Me.gb_tablette.Size = New System.Drawing.Size(230, 132)
        Me.gb_tablette.TabIndex = 24
        Me.gb_tablette.TabStop = False
        Me.gb_tablette.Text = "Tablette"
        Me.gb_tablette.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Taille de l'écran:"
        '
        'cb_TailleTab
        '
        Me.cb_TailleTab.FormattingEnabled = True
        Me.cb_TailleTab.Location = New System.Drawing.Point(100, 101)
        Me.cb_TailleTab.Name = "cb_TailleTab"
        Me.cb_TailleTab.Size = New System.Drawing.Size(121, 21)
        Me.cb_TailleTab.TabIndex = 22
        '
        'cb_RamTab
        '
        Me.cb_RamTab.FormattingEnabled = True
        Me.cb_RamTab.Location = New System.Drawing.Point(100, 28)
        Me.cb_RamTab.Name = "cb_RamTab"
        Me.cb_RamTab.Size = New System.Drawing.Size(65, 21)
        Me.cb_RamTab.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(62, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Ram:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(31, 67)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Disque Dur:"
        '
        'cb_DDTab
        '
        Me.cb_DDTab.FormattingEnabled = True
        Me.cb_DDTab.Location = New System.Drawing.Point(100, 64)
        Me.cb_DDTab.Name = "cb_DDTab"
        Me.cb_DDTab.Size = New System.Drawing.Size(121, 21)
        Me.cb_DDTab.TabIndex = 18
        '
        'txtb_Description
        '
        Me.txtb_Description.Location = New System.Drawing.Point(20, 168)
        Me.txtb_Description.Multiline = True
        Me.txtb_Description.Name = "txtb_Description"
        Me.txtb_Description.Size = New System.Drawing.Size(161, 87)
        Me.txtb_Description.TabIndex = 28
        '
        'gb_pc
        '
        Me.gb_pc.AccessibleName = ""
        Me.gb_pc.Controls.Add(Me.Label5)
        Me.gb_pc.Controls.Add(Me.txtb_Micro)
        Me.gb_pc.Controls.Add(Me.cb_Ram)
        Me.gb_pc.Controls.Add(Me.Label6)
        Me.gb_pc.Controls.Add(Me.Label7)
        Me.gb_pc.Controls.Add(Me.cb_DDPc)
        Me.gb_pc.Location = New System.Drawing.Point(249, 142)
        Me.gb_pc.Name = "gb_pc"
        Me.gb_pc.Size = New System.Drawing.Size(230, 132)
        Me.gb_pc.TabIndex = 23
        Me.gb_pc.TabStop = False
        Me.gb_pc.Text = "PC"
        Me.gb_pc.Visible = False
        '
        'btn_Valider
        '
        Me.btn_Valider.Location = New System.Drawing.Point(167, 392)
        Me.btn_Valider.Name = "btn_Valider"
        Me.btn_Valider.Size = New System.Drawing.Size(106, 36)
        Me.btn_Valider.TabIndex = 25
        Me.btn_Valider.Text = "Valider"
        Me.btn_Valider.UseVisualStyleBackColor = True
        '
        'btn_Supprimer
        '
        Me.btn_Supprimer.Location = New System.Drawing.Point(302, 392)
        Me.btn_Supprimer.Name = "btn_Supprimer"
        Me.btn_Supprimer.Size = New System.Drawing.Size(106, 36)
        Me.btn_Supprimer.TabIndex = 26
        Me.btn_Supprimer.Text = "&Annuler"
        Me.btn_Supprimer.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(205, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(138, 24)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Ajout matériel"
        '
        'AjoutMateriel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 444)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btn_Supprimer)
        Me.Controls.Add(Me.btn_Valider)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AjoutMateriel"
        Me.Text = "Matériel"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.gb_ecran.ResumeLayout(False)
        Me.gb_ecran.PerformLayout()
        Me.gb_tablette.ResumeLayout(False)
        Me.gb_tablette.PerformLayout()
        Me.gb_pc.ResumeLayout(False)
        Me.gb_pc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtb_NomMat As System.Windows.Forms.TextBox
    Friend WithEvents txtb_Prix As System.Windows.Forms.TextBox
    Friend WithEvents txtb_Micro As System.Windows.Forms.TextBox
    Friend WithEvents txtb_TechnologieEcran As System.Windows.Forms.TextBox
    Friend WithEvents cb_Ram As System.Windows.Forms.ComboBox
    Friend WithEvents cb_DDPc As System.Windows.Forms.ComboBox
    Friend WithEvents cb_tailleEcran As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Resolution As System.Windows.Forms.ComboBox
    Friend WithEvents gb_pc As System.Windows.Forms.GroupBox
    Friend WithEvents gb_ecran As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Valider As System.Windows.Forms.Button
    Friend WithEvents btn_Supprimer As System.Windows.Forms.Button
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtb_Description As System.Windows.Forms.TextBox
    Friend WithEvents gb_tablette As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cb_TailleTab As System.Windows.Forms.ComboBox
    Friend WithEvents cb_RamTab As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cb_DDTab As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_ecran As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_PC As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_tablette As System.Windows.Forms.RadioButton
    Friend WithEvents date_Garantie As System.Windows.Forms.DateTimePicker
End Class
