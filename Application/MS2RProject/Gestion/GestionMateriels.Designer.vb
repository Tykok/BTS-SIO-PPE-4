<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionMateriels
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lb_service_use_mat = New System.Windows.Forms.ListBox()
        Me.btn_modif_mat = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_supp_mat = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menu_add_mat = New System.Windows.Forms.ToolStripMenuItem()
        Me.ltvMat = New System.Windows.Forms.ListView()
        Me.colonneNumMat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colonneDesignation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colonneTaux = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(148, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Matériels"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(161, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Gestion des matériels"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(329, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Le service utilisant ce matériel :"
        '
        'lb_service_use_mat
        '
        Me.lb_service_use_mat.FormattingEnabled = True
        Me.lb_service_use_mat.Location = New System.Drawing.Point(332, 232)
        Me.lb_service_use_mat.Name = "lb_service_use_mat"
        Me.lb_service_use_mat.Size = New System.Drawing.Size(168, 56)
        Me.lb_service_use_mat.TabIndex = 6
        '
        'btn_modif_mat
        '
        Me.btn_modif_mat.Location = New System.Drawing.Point(172, 477)
        Me.btn_modif_mat.Name = "btn_modif_mat"
        Me.btn_modif_mat.Size = New System.Drawing.Size(98, 37)
        Me.btn_modif_mat.TabIndex = 7
        Me.btn_modif_mat.Text = "Modifier matériels"
        Me.btn_modif_mat.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(364, 477)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(136, 38)
        Me.btn_back.TabIndex = 8
        Me.btn_back.Text = "&Retour au menu"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_supp_mat
        '
        Me.btn_supp_mat.Location = New System.Drawing.Point(47, 477)
        Me.btn_supp_mat.Name = "btn_supp_mat"
        Me.btn_supp_mat.Size = New System.Drawing.Size(98, 37)
        Me.btn_supp_mat.TabIndex = 9
        Me.btn_supp_mat.Text = "Supprimer le matériels"
        Me.btn_supp_mat.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_add_mat})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(523, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menu_add_mat
        '
        Me.menu_add_mat.Name = "menu_add_mat"
        Me.menu_add_mat.Size = New System.Drawing.Size(104, 20)
        Me.menu_add_mat.Text = "Ajouter Matériel"
        '
        'ltvMat
        '
        Me.ltvMat.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colonneNumMat, Me.colonneDesignation, Me.colonneTaux})
        Me.ltvMat.FullRowSelect = True
        Me.ltvMat.Location = New System.Drawing.Point(12, 139)
        Me.ltvMat.Name = "ltvMat"
        Me.ltvMat.Size = New System.Drawing.Size(298, 322)
        Me.ltvMat.TabIndex = 21
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
        Me.colonneDesignation.Width = 128
        '
        'colonneTaux
        '
        Me.colonneTaux.Text = "Type"
        Me.colonneTaux.Width = 43
        '
        'GestionMateriels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 527)
        Me.Controls.Add(Me.ltvMat)
        Me.Controls.Add(Me.btn_supp_mat)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_modif_mat)
        Me.Controls.Add(Me.lb_service_use_mat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "GestionMateriels"
        Me.Text = "Materiels"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lb_service_use_mat As System.Windows.Forms.ListBox
    Friend WithEvents btn_modif_mat As System.Windows.Forms.Button
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents btn_supp_mat As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menu_add_mat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ltvMat As System.Windows.Forms.ListView
    Friend WithEvents colonneDesignation As System.Windows.Forms.ColumnHeader
    Friend WithEvents colonneTaux As System.Windows.Forms.ColumnHeader
    Friend WithEvents colonneNumMat As System.Windows.Forms.ColumnHeader
End Class
