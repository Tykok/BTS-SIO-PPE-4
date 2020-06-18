<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MofifService
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
        Me.btn_valider = New System.Windows.Forms.Button()
        Me.btn_addlog = New System.Windows.Forms.Button()
        Me.btn_removeLog = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_add_Mat = New System.Windows.Forms.Button()
        Me.btn_remove_Mat = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_service = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ltvMat_Stock = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ltvMat = New System.Windows.Forms.ListView()
        Me.colonneNumMat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colonneDesignation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colonneTaux = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_qtn = New System.Windows.Forms.Label()
        Me.tb_quantite_user = New System.Windows.Forms.TextBox()
        Me.ltv_LogDispo = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ltvLog_Services = New System.Windows.Forms.ListView()
        Me.ColonneNum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColonneNomLog = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nbrUser = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tb_descript = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_valider
        '
        Me.btn_valider.Location = New System.Drawing.Point(855, 383)
        Me.btn_valider.Name = "btn_valider"
        Me.btn_valider.Size = New System.Drawing.Size(116, 38)
        Me.btn_valider.TabIndex = 28
        Me.btn_valider.Text = "Terminer"
        Me.btn_valider.UseVisualStyleBackColor = True
        '
        'btn_addlog
        '
        Me.btn_addlog.Location = New System.Drawing.Point(412, 186)
        Me.btn_addlog.Name = "btn_addlog"
        Me.btn_addlog.Size = New System.Drawing.Size(36, 27)
        Me.btn_addlog.TabIndex = 27
        Me.btn_addlog.Text = "<"
        Me.btn_addlog.UseVisualStyleBackColor = True
        '
        'btn_removeLog
        '
        Me.btn_removeLog.Location = New System.Drawing.Point(412, 116)
        Me.btn_removeLog.Name = "btn_removeLog"
        Me.btn_removeLog.Size = New System.Drawing.Size(36, 27)
        Me.btn_removeLog.TabIndex = 26
        Me.btn_removeLog.Text = ">"
        Me.btn_removeLog.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(152, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Logiciel(s) du service"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(140, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Matériel(s) du service"
        '
        'btn_add_Mat
        '
        Me.btn_add_Mat.Location = New System.Drawing.Point(401, 143)
        Me.btn_add_Mat.Name = "btn_add_Mat"
        Me.btn_add_Mat.Size = New System.Drawing.Size(36, 27)
        Me.btn_add_Mat.TabIndex = 23
        Me.btn_add_Mat.Text = "<"
        Me.btn_add_Mat.UseVisualStyleBackColor = True
        '
        'btn_remove_Mat
        '
        Me.btn_remove_Mat.Location = New System.Drawing.Point(401, 80)
        Me.btn_remove_Mat.Name = "btn_remove_Mat"
        Me.btn_remove_Mat.Size = New System.Drawing.Size(36, 27)
        Me.btn_remove_Mat.TabIndex = 22
        Me.btn_remove_Mat.Text = ">"
        Me.btn_remove_Mat.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(610, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Logiciel(s) disponible(s)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(599, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Matériel(s) disponible(s)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Service : "
        '
        'tb_service
        '
        Me.tb_service.Location = New System.Drawing.Point(120, 21)
        Me.tb_service.Name = "tb_service"
        Me.tb_service.Size = New System.Drawing.Size(140, 20)
        Me.tb_service.TabIndex = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox1.Controls.Add(Me.ltvMat_Stock)
        Me.GroupBox1.Controls.Add(Me.ltvMat)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btn_remove_Mat)
        Me.GroupBox1.Controls.Add(Me.btn_add_Mat)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(803, 256)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Matériels"
        '
        'ltvMat_Stock
        '
        Me.ltvMat_Stock.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ltvMat_Stock.FullRowSelect = True
        Me.ltvMat_Stock.Location = New System.Drawing.Point(488, 31)
        Me.ltvMat_Stock.MultiSelect = False
        Me.ltvMat_Stock.Name = "ltvMat_Stock"
        Me.ltvMat_Stock.Size = New System.Drawing.Size(298, 215)
        Me.ltvMat_Stock.TabIndex = 27
        Me.ltvMat_Stock.UseCompatibleStateImageBehavior = False
        Me.ltvMat_Stock.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "N°"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nom matériel"
        Me.ColumnHeader2.Width = 190
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Type"
        Me.ColumnHeader3.Width = 43
        '
        'ltvMat
        '
        Me.ltvMat.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colonneNumMat, Me.colonneDesignation, Me.colonneTaux})
        Me.ltvMat.FullRowSelect = True
        Me.ltvMat.Location = New System.Drawing.Point(53, 31)
        Me.ltvMat.MultiSelect = False
        Me.ltvMat.Name = "ltvMat"
        Me.ltvMat.Size = New System.Drawing.Size(298, 215)
        Me.ltvMat.TabIndex = 26
        Me.ltvMat.UseCompatibleStateImageBehavior = False
        Me.ltvMat.View = System.Windows.Forms.View.Details
        '
        'colonneNumMat
        '
        Me.colonneNumMat.Text = "N°"
        '
        'colonneDesignation
        '
        Me.colonneDesignation.Text = "Nom matériel"
        Me.colonneDesignation.Width = 191
        '
        'colonneTaux
        '
        Me.colonneTaux.Text = "Type"
        Me.colonneTaux.Width = 43
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.lbl_qtn)
        Me.GroupBox2.Controls.Add(Me.tb_quantite_user)
        Me.GroupBox2.Controls.Add(Me.ltv_LogDispo)
        Me.GroupBox2.Controls.Add(Me.ltvLog_Services)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btn_removeLog)
        Me.GroupBox2.Controls.Add(Me.btn_addlog)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 399)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(803, 338)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Logiciels"
        '
        'lbl_qtn
        '
        Me.lbl_qtn.AutoSize = True
        Me.lbl_qtn.Location = New System.Drawing.Point(401, 282)
        Me.lbl_qtn.Name = "lbl_qtn"
        Me.lbl_qtn.Size = New System.Drawing.Size(47, 13)
        Me.lbl_qtn.TabIndex = 32
        Me.lbl_qtn.Text = "Quantité"
        '
        'tb_quantite_user
        '
        Me.tb_quantite_user.Location = New System.Drawing.Point(374, 298)
        Me.tb_quantite_user.Name = "tb_quantite_user"
        Me.tb_quantite_user.Size = New System.Drawing.Size(100, 20)
        Me.tb_quantite_user.TabIndex = 31
        '
        'ltv_LogDispo
        '
        Me.ltv_LogDispo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ltv_LogDispo.FullRowSelect = True
        Me.ltv_LogDispo.Location = New System.Drawing.Point(499, 53)
        Me.ltv_LogDispo.MultiSelect = False
        Me.ltv_LogDispo.Name = "ltv_LogDispo"
        Me.ltv_LogDispo.Size = New System.Drawing.Size(298, 215)
        Me.ltv_LogDispo.TabIndex = 30
        Me.ltv_LogDispo.UseCompatibleStateImageBehavior = False
        Me.ltv_LogDispo.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "N°"
        Me.ColumnHeader4.Width = 34
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Nom logiciel"
        Me.ColumnHeader5.Width = 194
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Utilisateurs"
        Me.ColumnHeader6.Width = 65
        '
        'ltvLog_Services
        '
        Me.ltvLog_Services.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColonneNum, Me.ColonneNomLog, Me.nbrUser})
        Me.ltvLog_Services.FullRowSelect = True
        Me.ltvLog_Services.Location = New System.Drawing.Point(64, 53)
        Me.ltvLog_Services.MultiSelect = False
        Me.ltvLog_Services.Name = "ltvLog_Services"
        Me.ltvLog_Services.Size = New System.Drawing.Size(298, 215)
        Me.ltvLog_Services.TabIndex = 28
        Me.ltvLog_Services.UseCompatibleStateImageBehavior = False
        Me.ltvLog_Services.View = System.Windows.Forms.View.Details
        '
        'ColonneNum
        '
        Me.ColonneNum.Text = "N°"
        Me.ColonneNum.Width = 34
        '
        'ColonneNomLog
        '
        Me.ColonneNomLog.Text = "Nom logiciel"
        Me.ColonneNomLog.Width = 194
        '
        'nbrUser
        '
        Me.nbrUser.Text = "Utilisateurs"
        Me.nbrUser.Width = 65
        '
        'tb_descript
        '
        Me.tb_descript.Location = New System.Drawing.Point(492, 25)
        Me.tb_descript.Multiline = True
        Me.tb_descript.Name = "tb_descript"
        Me.tb_descript.Size = New System.Drawing.Size(248, 91)
        Me.tb_descript.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(434, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Description : "
        '
        'MofifService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 749)
        Me.Controls.Add(Me.tb_descript)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tb_service)
        Me.Controls.Add(Me.btn_valider)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MofifService"
        Me.Text = "Gestion des matériels et logiciels du service"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_valider As System.Windows.Forms.Button
    Friend WithEvents btn_addlog As System.Windows.Forms.Button
    Friend WithEvents btn_removeLog As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_add_Mat As System.Windows.Forms.Button
    Friend WithEvents btn_remove_Mat As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_service As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ltvMat_Stock As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ltvMat As System.Windows.Forms.ListView
    Friend WithEvents colonneNumMat As System.Windows.Forms.ColumnHeader
    Friend WithEvents colonneDesignation As System.Windows.Forms.ColumnHeader
    Friend WithEvents colonneTaux As System.Windows.Forms.ColumnHeader
    Friend WithEvents ltv_LogDispo As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ltvLog_Services As System.Windows.Forms.ListView
    Friend WithEvents ColonneNum As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColonneNomLog As System.Windows.Forms.ColumnHeader
    Friend WithEvents nbrUser As System.Windows.Forms.ColumnHeader
    Friend WithEvents tb_quantite_user As System.Windows.Forms.TextBox
    Friend WithEvents lbl_qtn As System.Windows.Forms.Label
    Friend WithEvents tb_descript As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
