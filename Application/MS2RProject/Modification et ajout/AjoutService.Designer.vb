<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AjoutService
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
        Me.tb_new_service = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_plustard = New System.Windows.Forms.RadioButton()
        Me.rb_ajout = New System.Windows.Forms.RadioButton()
        Me.btn_valider = New System.Windows.Forms.Button()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.tb_description = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(189, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Création d'un nouveau service"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nom du nouveau service"
        '
        'tb_new_service
        '
        Me.tb_new_service.Location = New System.Drawing.Point(156, 95)
        Me.tb_new_service.Name = "tb_new_service"
        Me.tb_new_service.Size = New System.Drawing.Size(171, 20)
        Me.tb_new_service.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Description du service"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_plustard)
        Me.GroupBox1.Controls.Add(Me.rb_ajout)
        Me.GroupBox1.Location = New System.Drawing.Point(421, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(185, 95)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ajout de(s) logiciel(s) et matériel(s)"
        '
        'rb_plustard
        '
        Me.rb_plustard.AutoSize = True
        Me.rb_plustard.Location = New System.Drawing.Point(21, 55)
        Me.rb_plustard.Name = "rb_plustard"
        Me.rb_plustard.Size = New System.Drawing.Size(101, 17)
        Me.rb_plustard.TabIndex = 1
        Me.rb_plustard.TabStop = True
        Me.rb_plustard.Text = "Ajouter plus tard"
        Me.rb_plustard.UseVisualStyleBackColor = True
        '
        'rb_ajout
        '
        Me.rb_ajout.AutoSize = True
        Me.rb_ajout.Location = New System.Drawing.Point(21, 31)
        Me.rb_ajout.Name = "rb_ajout"
        Me.rb_ajout.Size = New System.Drawing.Size(107, 17)
        Me.rb_ajout.TabIndex = 0
        Me.rb_ajout.TabStop = True
        Me.rb_ajout.Text = "Procéder à l'ajout"
        Me.rb_ajout.UseVisualStyleBackColor = True
        '
        'btn_valider
        '
        Me.btn_valider.Location = New System.Drawing.Point(177, 253)
        Me.btn_valider.Name = "btn_valider"
        Me.btn_valider.Size = New System.Drawing.Size(126, 39)
        Me.btn_valider.TabIndex = 6
        Me.btn_valider.Text = "Valider"
        Me.btn_valider.UseVisualStyleBackColor = True
        '
        'btn_annuler
        '
        Me.btn_annuler.Location = New System.Drawing.Point(343, 253)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(126, 39)
        Me.btn_annuler.TabIndex = 7
        Me.btn_annuler.Text = "&Annuler"
        Me.btn_annuler.UseVisualStyleBackColor = True
        '
        'tb_description
        '
        Me.tb_description.Location = New System.Drawing.Point(156, 132)
        Me.tb_description.Multiline = True
        Me.tb_description.Name = "tb_description"
        Me.tb_description.Size = New System.Drawing.Size(181, 91)
        Me.tb_description.TabIndex = 8
        '
        'AjoutService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 315)
        Me.Controls.Add(Me.tb_description)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.btn_valider)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_new_service)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AjoutService"
        Me.Text = "Service"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_new_service As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_valider As System.Windows.Forms.Button
    Friend WithEvents btn_annuler As System.Windows.Forms.Button
    Friend WithEvents tb_description As System.Windows.Forms.TextBox
    Friend WithEvents rb_plustard As System.Windows.Forms.RadioButton
    Friend WithEvents rb_ajout As System.Windows.Forms.RadioButton
End Class
