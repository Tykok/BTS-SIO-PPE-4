<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AjoutLogiciel
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
        Me.lbl_titre = New System.Windows.Forms.Label()
        Me.tb_name_logi = New System.Windows.Forms.TextBox()
        Me.tb_license = New System.Windows.Forms.TextBox()
        Me.btn_valider = New System.Windows.Forms.Button()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.date_achat = New System.Windows.Forms.DateTimePicker()
        Me.tb_nombre_user = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom du logiciel :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numéro de licence :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date d'achat :"
        '
        'lbl_titre
        '
        Me.lbl_titre.AutoSize = True
        Me.lbl_titre.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titre.Location = New System.Drawing.Point(50, 21)
        Me.lbl_titre.Name = "lbl_titre"
        Me.lbl_titre.Size = New System.Drawing.Size(252, 24)
        Me.lbl_titre.TabIndex = 5
        Me.lbl_titre.Text = "Ajout d'un nouveau logiciel"
        '
        'tb_name_logi
        '
        Me.tb_name_logi.Location = New System.Drawing.Point(115, 73)
        Me.tb_name_logi.Name = "tb_name_logi"
        Me.tb_name_logi.Size = New System.Drawing.Size(134, 20)
        Me.tb_name_logi.TabIndex = 7
        '
        'tb_license
        '
        Me.tb_license.Location = New System.Drawing.Point(131, 114)
        Me.tb_license.Name = "tb_license"
        Me.tb_license.Size = New System.Drawing.Size(198, 20)
        Me.tb_license.TabIndex = 8
        '
        'btn_valider
        '
        Me.btn_valider.Location = New System.Drawing.Point(86, 239)
        Me.btn_valider.Name = "btn_valider"
        Me.btn_valider.Size = New System.Drawing.Size(75, 23)
        Me.btn_valider.TabIndex = 12
        Me.btn_valider.Text = "Valider"
        Me.btn_valider.UseVisualStyleBackColor = True
        '
        'btn_annuler
        '
        Me.btn_annuler.Location = New System.Drawing.Point(188, 239)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(75, 23)
        Me.btn_annuler.TabIndex = 13
        Me.btn_annuler.Text = "&Annuler"
        Me.btn_annuler.UseVisualStyleBackColor = True
        '
        'date_achat
        '
        Me.date_achat.Location = New System.Drawing.Point(115, 154)
        Me.date_achat.Name = "date_achat"
        Me.date_achat.Size = New System.Drawing.Size(200, 20)
        Me.date_achat.TabIndex = 14
        '
        'tb_nombre_user
        '
        Me.tb_nombre_user.Location = New System.Drawing.Point(145, 193)
        Me.tb_nombre_user.Name = "tb_nombre_user"
        Me.tb_nombre_user.Size = New System.Drawing.Size(66, 20)
        Me.tb_nombre_user.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nombre d'utilisateur(s) : "
        '
        'AjoutLogiciel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 274)
        Me.Controls.Add(Me.tb_nombre_user)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.date_achat)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.btn_valider)
        Me.Controls.Add(Me.tb_license)
        Me.Controls.Add(Me.tb_name_logi)
        Me.Controls.Add(Me.lbl_titre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AjoutLogiciel"
        Me.Text = "Logiciel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_titre As System.Windows.Forms.Label
    Friend WithEvents tb_name_logi As System.Windows.Forms.TextBox
    Friend WithEvents tb_license As System.Windows.Forms.TextBox
    Friend WithEvents btn_valider As System.Windows.Forms.Button
    Friend WithEvents btn_annuler As System.Windows.Forms.Button
    Friend WithEvents date_achat As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_nombre_user As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
