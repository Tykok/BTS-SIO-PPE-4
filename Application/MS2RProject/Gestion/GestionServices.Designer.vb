<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionServices
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
        Me.lb_logiciels = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_modif_service = New System.Windows.Forms.Button()
        Me.btn_supp_service = New System.Windows.Forms.Button()
        Me.btn_retour = New System.Windows.Forms.Button()
        Me.lb_materiels = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menu_add_service = New System.Windows.Forms.ToolStripMenuItem()
        Me.lv_service = New System.Windows.Forms.ListView()
        Me.colonneNumMat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colonneNomServ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tb_descrip = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gestion des services"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(351, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Logiciels"
        '
        'lb_logiciels
        '
        Me.lb_logiciels.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_logiciels.FormattingEnabled = True
        Me.lb_logiciels.Location = New System.Drawing.Point(294, 129)
        Me.lb_logiciels.Name = "lb_logiciels"
        Me.lb_logiciels.Size = New System.Drawing.Size(185, 95)
        Me.lb_logiciels.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(106, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Liste services"
        '
        'btn_modif_service
        '
        Me.btn_modif_service.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_modif_service.Location = New System.Drawing.Point(30, 549)
        Me.btn_modif_service.Name = "btn_modif_service"
        Me.btn_modif_service.Size = New System.Drawing.Size(118, 28)
        Me.btn_modif_service.TabIndex = 7
        Me.btn_modif_service.Text = "Modifier un service"
        Me.btn_modif_service.UseVisualStyleBackColor = True
        '
        'btn_supp_service
        '
        Me.btn_supp_service.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_supp_service.Location = New System.Drawing.Point(148, 550)
        Me.btn_supp_service.Name = "btn_supp_service"
        Me.btn_supp_service.Size = New System.Drawing.Size(118, 26)
        Me.btn_supp_service.TabIndex = 8
        Me.btn_supp_service.Text = "Supprimer un service"
        Me.btn_supp_service.UseVisualStyleBackColor = True
        '
        'btn_retour
        '
        Me.btn_retour.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_retour.Location = New System.Drawing.Point(376, 544)
        Me.btn_retour.Name = "btn_retour"
        Me.btn_retour.Size = New System.Drawing.Size(125, 39)
        Me.btn_retour.TabIndex = 9
        Me.btn_retour.Text = "&Retour au menu"
        Me.btn_retour.UseVisualStyleBackColor = True
        '
        'lb_materiels
        '
        Me.lb_materiels.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_materiels.FormattingEnabled = True
        Me.lb_materiels.Location = New System.Drawing.Point(294, 273)
        Me.lb_materiels.Name = "lb_materiels"
        Me.lb_materiels.Size = New System.Drawing.Size(185, 95)
        Me.lb_materiels.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(351, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Matériels"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_add_service})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(513, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menu_add_service
        '
        Me.menu_add_service.Name = "menu_add_service"
        Me.menu_add_service.Size = New System.Drawing.Size(86, 20)
        Me.menu_add_service.Text = "Créer service"
        '
        'lv_service
        '
        Me.lv_service.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colonneNumMat, Me.colonneNomServ})
        Me.lv_service.FullRowSelect = True
        Me.lv_service.Location = New System.Drawing.Point(30, 129)
        Me.lv_service.Name = "lv_service"
        Me.lv_service.Size = New System.Drawing.Size(236, 402)
        Me.lv_service.TabIndex = 22
        Me.lv_service.UseCompatibleStateImageBehavior = False
        Me.lv_service.View = System.Windows.Forms.View.Details
        '
        'colonneNumMat
        '
        Me.colonneNumMat.Text = "N°"
        '
        'colonneNomServ
        '
        Me.colonneNomServ.Text = "Nom Service"
        Me.colonneNomServ.Width = 172
        '
        'tb_descrip
        '
        Me.tb_descrip.Location = New System.Drawing.Point(294, 414)
        Me.tb_descrip.Multiline = True
        Me.tb_descrip.Name = "tb_descrip"
        Me.tb_descrip.Size = New System.Drawing.Size(185, 70)
        Me.tb_descrip.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(352, 398)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Description"
        '
        'GestionServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 595)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_descrip)
        Me.Controls.Add(Me.lv_service)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lb_materiels)
        Me.Controls.Add(Me.btn_retour)
        Me.Controls.Add(Me.btn_supp_service)
        Me.Controls.Add(Me.btn_modif_service)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lb_logiciels)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "GestionServices"
        Me.Text = "Services"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lb_logiciels As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_modif_service As System.Windows.Forms.Button
    Friend WithEvents btn_supp_service As System.Windows.Forms.Button
    Friend WithEvents btn_retour As System.Windows.Forms.Button
    Friend WithEvents lb_materiels As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menu_add_service As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lv_service As System.Windows.Forms.ListView
    Friend WithEvents colonneNumMat As System.Windows.Forms.ColumnHeader
    Friend WithEvents colonneNomServ As System.Windows.Forms.ColumnHeader
    Friend WithEvents tb_descrip As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
