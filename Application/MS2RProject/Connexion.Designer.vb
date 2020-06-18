<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Connexion
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
        Me.txtB_Login = New System.Windows.Forms.TextBox()
        Me.txtb_mdp = New System.Windows.Forms.TextBox()
        Me.btn_connexion = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Quitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtB_Login
        '
        Me.txtB_Login.Location = New System.Drawing.Point(149, 82)
        Me.txtB_Login.Name = "txtB_Login"
        Me.txtB_Login.Size = New System.Drawing.Size(172, 20)
        Me.txtB_Login.TabIndex = 0
        '
        'txtb_mdp
        '
        Me.txtb_mdp.Location = New System.Drawing.Point(149, 120)
        Me.txtb_mdp.Name = "txtb_mdp"
        Me.txtb_mdp.Size = New System.Drawing.Size(172, 20)
        Me.txtb_mdp.TabIndex = 1
        Me.txtb_mdp.UseSystemPasswordChar = True
        '
        'btn_connexion
        '
        Me.btn_connexion.Location = New System.Drawing.Point(191, 178)
        Me.btn_connexion.Name = "btn_connexion"
        Me.btn_connexion.Size = New System.Drawing.Size(90, 23)
        Me.btn_connexion.TabIndex = 2
        Me.btn_connexion.Text = "Se connecter"
        Me.btn_connexion.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Authentification pour l'espace administrateur MS2R"
        '
        'btn_Quitter
        '
        Me.btn_Quitter.Location = New System.Drawing.Point(348, 223)
        Me.btn_Quitter.Name = "btn_Quitter"
        Me.btn_Quitter.Size = New System.Drawing.Size(90, 23)
        Me.btn_Quitter.TabIndex = 4
        Me.btn_Quitter.Text = "&Quitter"
        Me.btn_Quitter.UseVisualStyleBackColor = True
        '
        'Connexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 258)
        Me.Controls.Add(Me.btn_Quitter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_connexion)
        Me.Controls.Add(Me.txtb_mdp)
        Me.Controls.Add(Me.txtB_Login)
        Me.Name = "Connexion"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtB_Login As System.Windows.Forms.TextBox
    Friend WithEvents txtb_mdp As System.Windows.Forms.TextBox
    Friend WithEvents btn_connexion As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Quitter As System.Windows.Forms.Button

End Class
