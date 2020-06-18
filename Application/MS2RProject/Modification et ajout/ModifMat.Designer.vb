<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifMat
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.btn_valider = New System.Windows.Forms.Button()
        Me.gb_informations = New System.Windows.Forms.GroupBox()
        Me.date_garantie = New System.Windows.Forms.DateTimePicker()
        Me.gb_ecran = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gb_tablette = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cb_tablette_ecran = New System.Windows.Forms.ComboBox()
        Me.cb_tablette_ram = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cb_tablette_disque = New System.Windows.Forms.ComboBox()
        Me.cb_ecran_ecran = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cb_resolution = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_technologie = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rdb_ecran = New System.Windows.Forms.RadioButton()
        Me.rdb_PC = New System.Windows.Forms.RadioButton()
        Me.rdb_tablette = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_description = New System.Windows.Forms.TextBox()
        Me.tb_nom_materiel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_prix = New System.Windows.Forms.TextBox()
        Me.gb_pc = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_pc_micro = New System.Windows.Forms.TextBox()
        Me.cb_pc_ram = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cb_pc_disque = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gb_informations.SuspendLayout()
        Me.gb_ecran.SuspendLayout()
        Me.gb_tablette.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.gb_pc.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(197, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(164, 24)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Modifier matériel"
        '
        'btn_annuler
        '
        Me.btn_annuler.Location = New System.Drawing.Point(308, 390)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(106, 36)
        Me.btn_annuler.TabIndex = 30
        Me.btn_annuler.Text = "&Annuler"
        Me.btn_annuler.UseVisualStyleBackColor = True
        '
        'btn_valider
        '
        Me.btn_valider.Location = New System.Drawing.Point(166, 390)
        Me.btn_valider.Name = "btn_valider"
        Me.btn_valider.Size = New System.Drawing.Size(106, 36)
        Me.btn_valider.TabIndex = 29
        Me.btn_valider.Text = "Valider"
        Me.btn_valider.UseVisualStyleBackColor = True
        '
        'gb_informations
        '
        Me.gb_informations.Controls.Add(Me.date_garantie)
        Me.gb_informations.Controls.Add(Me.gb_tablette)
        Me.gb_informations.Controls.Add(Me.gb_ecran)
        Me.gb_informations.Controls.Add(Me.GroupBox5)
        Me.gb_informations.Controls.Add(Me.Label1)
        Me.gb_informations.Controls.Add(Me.tb_description)
        Me.gb_informations.Controls.Add(Me.tb_nom_materiel)
        Me.gb_informations.Controls.Add(Me.Label2)
        Me.gb_informations.Controls.Add(Me.tb_prix)
        Me.gb_informations.Controls.Add(Me.gb_pc)
        Me.gb_informations.Controls.Add(Me.Label3)
        Me.gb_informations.Controls.Add(Me.Label4)
        Me.gb_informations.Location = New System.Drawing.Point(36, 75)
        Me.gb_informations.Name = "gb_informations"
        Me.gb_informations.Size = New System.Drawing.Size(497, 293)
        Me.gb_informations.TabIndex = 28
        Me.gb_informations.TabStop = False
        Me.gb_informations.Text = "Informations"
        '
        'date_garantie
        '
        Me.date_garantie.Location = New System.Drawing.Point(61, 104)
        Me.date_garantie.Name = "date_garantie"
        Me.date_garantie.Size = New System.Drawing.Size(163, 20)
        Me.date_garantie.TabIndex = 30
        '
        'gb_ecran
        '
        Me.gb_ecran.AccessibleName = ""
        Me.gb_ecran.Controls.Add(Me.Label8)
        Me.gb_ecran.Controls.Add(Me.cb_ecran_ecran)
        Me.gb_ecran.Controls.Add(Me.Label9)
        Me.gb_ecran.Controls.Add(Me.cb_resolution)
        Me.gb_ecran.Controls.Add(Me.Label10)
        Me.gb_ecran.Controls.Add(Me.tb_technologie)
        Me.gb_ecran.Location = New System.Drawing.Point(260, 136)
        Me.gb_ecran.Name = "gb_ecran"
        Me.gb_ecran.Size = New System.Drawing.Size(231, 132)
        Me.gb_ecran.TabIndex = 24
        Me.gb_ecran.TabStop = False
        Me.gb_ecran.Text = "Ecran"
        Me.gb_ecran.Visible = False
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
        'gb_tablette
        '
        Me.gb_tablette.AccessibleName = ""
        Me.gb_tablette.Controls.Add(Me.Label13)
        Me.gb_tablette.Controls.Add(Me.cb_tablette_ecran)
        Me.gb_tablette.Controls.Add(Me.cb_tablette_ram)
        Me.gb_tablette.Controls.Add(Me.Label11)
        Me.gb_tablette.Controls.Add(Me.Label14)
        Me.gb_tablette.Controls.Add(Me.cb_tablette_disque)
        Me.gb_tablette.Location = New System.Drawing.Point(252, 152)
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
        'cb_tablette_ecran
        '
        Me.cb_tablette_ecran.FormattingEnabled = True
        Me.cb_tablette_ecran.Location = New System.Drawing.Point(100, 101)
        Me.cb_tablette_ecran.Name = "cb_tablette_ecran"
        Me.cb_tablette_ecran.Size = New System.Drawing.Size(121, 21)
        Me.cb_tablette_ecran.TabIndex = 22
        '
        'cb_tablette_ram
        '
        Me.cb_tablette_ram.FormattingEnabled = True
        Me.cb_tablette_ram.Location = New System.Drawing.Point(100, 28)
        Me.cb_tablette_ram.Name = "cb_tablette_ram"
        Me.cb_tablette_ram.Size = New System.Drawing.Size(65, 21)
        Me.cb_tablette_ram.TabIndex = 20
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
        'cb_tablette_disque
        '
        Me.cb_tablette_disque.FormattingEnabled = True
        Me.cb_tablette_disque.Location = New System.Drawing.Point(100, 64)
        Me.cb_tablette_disque.Name = "cb_tablette_disque"
        Me.cb_tablette_disque.Size = New System.Drawing.Size(121, 21)
        Me.cb_tablette_disque.TabIndex = 18
        '
        'cb_ecran_ecran
        '
        Me.cb_ecran_ecran.FormattingEnabled = True
        Me.cb_ecran_ecran.Location = New System.Drawing.Point(96, 25)
        Me.cb_ecran_ecran.Name = "cb_ecran_ecran"
        Me.cb_ecran_ecran.Size = New System.Drawing.Size(121, 21)
        Me.cb_ecran_ecran.TabIndex = 19
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
        'cb_resolution
        '
        Me.cb_resolution.FormattingEnabled = True
        Me.cb_resolution.Location = New System.Drawing.Point(96, 64)
        Me.cb_resolution.Name = "cb_resolution"
        Me.cb_resolution.Size = New System.Drawing.Size(121, 21)
        Me.cb_resolution.TabIndex = 20
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
        'tb_technologie
        '
        Me.tb_technologie.Location = New System.Drawing.Point(96, 98)
        Me.tb_technologie.Name = "tb_technologie"
        Me.tb_technologie.Size = New System.Drawing.Size(121, 20)
        Me.tb_technologie.TabIndex = 14
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom du matériel:"
        '
        'tb_description
        '
        Me.tb_description.Location = New System.Drawing.Point(20, 168)
        Me.tb_description.Multiline = True
        Me.tb_description.Name = "tb_description"
        Me.tb_description.Size = New System.Drawing.Size(161, 87)
        Me.tb_description.TabIndex = 28
        '
        'tb_nom_materiel
        '
        Me.tb_nom_materiel.Location = New System.Drawing.Point(98, 25)
        Me.tb_nom_materiel.Name = "tb_nom_materiel"
        Me.tb_nom_materiel.Size = New System.Drawing.Size(100, 20)
        Me.tb_nom_materiel.TabIndex = 11
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
        'tb_prix
        '
        Me.tb_prix.Location = New System.Drawing.Point(98, 62)
        Me.tb_prix.Name = "tb_prix"
        Me.tb_prix.Size = New System.Drawing.Size(63, 20)
        Me.tb_prix.TabIndex = 12
        '
        'gb_pc
        '
        Me.gb_pc.AccessibleName = ""
        Me.gb_pc.Controls.Add(Me.Label5)
        Me.gb_pc.Controls.Add(Me.tb_pc_micro)
        Me.gb_pc.Controls.Add(Me.cb_pc_ram)
        Me.gb_pc.Controls.Add(Me.Label6)
        Me.gb_pc.Controls.Add(Me.Label7)
        Me.gb_pc.Controls.Add(Me.cb_pc_disque)
        Me.gb_pc.Location = New System.Drawing.Point(261, 143)
        Me.gb_pc.Name = "gb_pc"
        Me.gb_pc.Size = New System.Drawing.Size(230, 132)
        Me.gb_pc.TabIndex = 23
        Me.gb_pc.TabStop = False
        Me.gb_pc.Text = "PC"
        Me.gb_pc.Visible = False
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
        'tb_pc_micro
        '
        Me.tb_pc_micro.Location = New System.Drawing.Point(100, 31)
        Me.tb_pc_micro.Name = "tb_pc_micro"
        Me.tb_pc_micro.Size = New System.Drawing.Size(100, 20)
        Me.tb_pc_micro.TabIndex = 13
        '
        'cb_pc_ram
        '
        Me.cb_pc_ram.FormattingEnabled = True
        Me.cb_pc_ram.Location = New System.Drawing.Point(100, 64)
        Me.cb_pc_ram.Name = "cb_pc_ram"
        Me.cb_pc_ram.Size = New System.Drawing.Size(65, 21)
        Me.cb_pc_ram.TabIndex = 17
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
        'cb_pc_disque
        '
        Me.cb_pc_disque.FormattingEnabled = True
        Me.cb_pc_disque.Location = New System.Drawing.Point(100, 104)
        Me.cb_pc_disque.Name = "cb_pc_disque"
        Me.cb_pc_disque.Size = New System.Drawing.Size(121, 21)
        Me.cb_pc_disque.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 109)
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
        'ModifMat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 445)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.btn_valider)
        Me.Controls.Add(Me.gb_informations)
        Me.Name = "ModifMat"
        Me.Text = "Matériel"
        Me.gb_informations.ResumeLayout(False)
        Me.gb_informations.PerformLayout()
        Me.gb_ecran.ResumeLayout(False)
        Me.gb_ecran.PerformLayout()
        Me.gb_tablette.ResumeLayout(False)
        Me.gb_tablette.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.gb_pc.ResumeLayout(False)
        Me.gb_pc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btn_annuler As System.Windows.Forms.Button
    Friend WithEvents btn_valider As System.Windows.Forms.Button
    Private WithEvents gb_informations As System.Windows.Forms.GroupBox
    Friend WithEvents gb_tablette As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cb_tablette_ecran As System.Windows.Forms.ComboBox
    Friend WithEvents cb_tablette_ram As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cb_tablette_disque As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_ecran As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_PC As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_tablette As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gb_ecran As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cb_ecran_ecran As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cb_resolution As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tb_technologie As System.Windows.Forms.TextBox
    Friend WithEvents tb_description As System.Windows.Forms.TextBox
    Friend WithEvents tb_nom_materiel As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_prix As System.Windows.Forms.TextBox
    Friend WithEvents gb_pc As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tb_pc_micro As System.Windows.Forms.TextBox
    Friend WithEvents cb_pc_ram As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cb_pc_disque As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents date_garantie As System.Windows.Forms.DateTimePicker
End Class
