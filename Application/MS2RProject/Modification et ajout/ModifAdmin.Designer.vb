<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifAdmin
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
        Me.btn_Quitter = New System.Windows.Forms.Button()
        Me.btn_connexion = New System.Windows.Forms.Button()
        Me.txtb_mdp = New System.Windows.Forms.TextBox()
        Me.txtB_Login = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_Confirm = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_Quitter
        '
        Me.btn_Quitter.Location = New System.Drawing.Point(308, 217)
        Me.btn_Quitter.Name = "btn_Quitter"
        Me.btn_Quitter.Size = New System.Drawing.Size(90, 23)
        Me.btn_Quitter.TabIndex = 8
        Me.btn_Quitter.Text = "&Retour"
        Me.btn_Quitter.UseVisualStyleBackColor = True
        '
        'btn_connexion
        '
        Me.btn_connexion.Location = New System.Drawing.Point(169, 192)
        Me.btn_connexion.Name = "btn_connexion"
        Me.btn_connexion.Size = New System.Drawing.Size(90, 23)
        Me.btn_connexion.TabIndex = 7
        Me.btn_connexion.Text = "Valider"
        Me.btn_connexion.UseVisualStyleBackColor = True
        '
        'txtb_mdp
        '
        Me.txtb_mdp.Location = New System.Drawing.Point(124, 123)
        Me.txtb_mdp.Name = "txtb_mdp"
        Me.txtb_mdp.Size = New System.Drawing.Size(172, 20)
        Me.txtb_mdp.TabIndex = 6
        Me.txtb_mdp.UseSystemPasswordChar = True
        '
        'txtB_Login
        '
        Me.txtB_Login.Location = New System.Drawing.Point(124, 85)
        Me.txtB_Login.Name = "txtB_Login"
        Me.txtB_Login.Size = New System.Drawing.Size(172, 20)
        Me.txtB_Login.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Pseudo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Mot de passe"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(384, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Modification de mes informations de connexion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Confirmation"
        '
        'tb_Confirm
        '
        Me.tb_Confirm.Location = New System.Drawing.Point(124, 149)
        Me.tb_Confirm.Name = "tb_Confirm"
        Me.tb_Confirm.Size = New System.Drawing.Size(172, 20)
        Me.tb_Confirm.TabIndex = 12
        Me.tb_Confirm.UseSystemPasswordChar = True
        '
        'ModifAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 251)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_Confirm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Quitter)
        Me.Controls.Add(Me.btn_connexion)
        Me.Controls.Add(Me.txtb_mdp)
        Me.Controls.Add(Me.txtB_Login)
        Me.Name = "ModifAdmin"
        Me.Text = "ModifAdmin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Quitter As System.Windows.Forms.Button
    Friend WithEvents btn_connexion As System.Windows.Forms.Button
    Friend WithEvents txtb_mdp As System.Windows.Forms.TextBox
    Friend WithEvents txtB_Login As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_Confirm As System.Windows.Forms.TextBox
End Class
