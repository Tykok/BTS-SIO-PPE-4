<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuAdmin))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_ConsultationService = New System.Windows.Forms.Button()
        Me.btn_AjoutServices = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_AjoutMat = New System.Windows.Forms.Button()
        Me.btn_ConsultationMat = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_ConsultationLog = New System.Windows.Forms.Button()
        Me.btn_AjoutLog = New System.Windows.Forms.Button()
        Me.btn_Deco = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Quitter = New System.Windows.Forms.Button()
        Me.lbl_nom = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 34)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_ConsultationService)
        Me.GroupBox1.Controls.Add(Me.btn_AjoutServices)
        Me.GroupBox1.Location = New System.Drawing.Point(71, 195)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(151, 186)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Services"
        '
        'btn_ConsultationService
        '
        Me.btn_ConsultationService.Location = New System.Drawing.Point(14, 38)
        Me.btn_ConsultationService.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_ConsultationService.Name = "btn_ConsultationService"
        Me.btn_ConsultationService.Size = New System.Drawing.Size(118, 42)
        Me.btn_ConsultationService.TabIndex = 4
        Me.btn_ConsultationService.Text = "Consultation"
        Me.btn_ConsultationService.UseVisualStyleBackColor = True
        '
        'btn_AjoutServices
        '
        Me.btn_AjoutServices.Location = New System.Drawing.Point(14, 136)
        Me.btn_AjoutServices.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_AjoutServices.Name = "btn_AjoutServices"
        Me.btn_AjoutServices.Size = New System.Drawing.Size(118, 42)
        Me.btn_AjoutServices.TabIndex = 2
        Me.btn_AjoutServices.Text = "Ajout d'un service"
        Me.btn_AjoutServices.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_AjoutMat)
        Me.GroupBox2.Controls.Add(Me.btn_ConsultationMat)
        Me.GroupBox2.Location = New System.Drawing.Point(295, 196)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(142, 185)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Matériels"
        '
        'btn_AjoutMat
        '
        Me.btn_AjoutMat.Location = New System.Drawing.Point(14, 136)
        Me.btn_AjoutMat.Name = "btn_AjoutMat"
        Me.btn_AjoutMat.Size = New System.Drawing.Size(118, 41)
        Me.btn_AjoutMat.TabIndex = 7
        Me.btn_AjoutMat.Text = "Ajout de matériel"
        Me.btn_AjoutMat.UseVisualStyleBackColor = True
        '
        'btn_ConsultationMat
        '
        Me.btn_ConsultationMat.Location = New System.Drawing.Point(14, 39)
        Me.btn_ConsultationMat.Name = "btn_ConsultationMat"
        Me.btn_ConsultationMat.Size = New System.Drawing.Size(118, 41)
        Me.btn_ConsultationMat.TabIndex = 6
        Me.btn_ConsultationMat.Text = "Consultation"
        Me.btn_ConsultationMat.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_ConsultationLog)
        Me.GroupBox3.Controls.Add(Me.btn_AjoutLog)
        Me.GroupBox3.Location = New System.Drawing.Point(522, 196)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(142, 185)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Logiciels"
        '
        'btn_ConsultationLog
        '
        Me.btn_ConsultationLog.Location = New System.Drawing.Point(14, 39)
        Me.btn_ConsultationLog.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_ConsultationLog.Name = "btn_ConsultationLog"
        Me.btn_ConsultationLog.Size = New System.Drawing.Size(118, 42)
        Me.btn_ConsultationLog.TabIndex = 4
        Me.btn_ConsultationLog.Text = "Consultation"
        Me.btn_ConsultationLog.UseVisualStyleBackColor = True
        '
        'btn_AjoutLog
        '
        Me.btn_AjoutLog.Location = New System.Drawing.Point(14, 135)
        Me.btn_AjoutLog.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_AjoutLog.Name = "btn_AjoutLog"
        Me.btn_AjoutLog.Size = New System.Drawing.Size(118, 42)
        Me.btn_AjoutLog.TabIndex = 5
        Me.btn_AjoutLog.Text = "Ajout logiciel"
        Me.btn_AjoutLog.UseVisualStyleBackColor = True
        '
        'btn_Deco
        '
        Me.btn_Deco.Location = New System.Drawing.Point(204, 456)
        Me.btn_Deco.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Deco.Name = "btn_Deco"
        Me.btn_Deco.Size = New System.Drawing.Size(117, 42)
        Me.btn_Deco.TabIndex = 12
        Me.btn_Deco.Text = "&Se déconnecter"
        Me.btn_Deco.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(182, 94)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 25)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Bienvenue"
        '
        'btn_Quitter
        '
        Me.btn_Quitter.Location = New System.Drawing.Point(409, 456)
        Me.btn_Quitter.Name = "btn_Quitter"
        Me.btn_Quitter.Size = New System.Drawing.Size(117, 42)
        Me.btn_Quitter.TabIndex = 16
        Me.btn_Quitter.Text = "Quitter l'application"
        Me.btn_Quitter.UseVisualStyleBackColor = True
        '
        'lbl_nom
        '
        Me.lbl_nom.AutoSize = True
        Me.lbl_nom.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nom.Location = New System.Drawing.Point(291, 95)
        Me.lbl_nom.Name = "lbl_nom"
        Me.lbl_nom.Size = New System.Drawing.Size(25, 24)
        Me.lbl_nom.TabIndex = 17
        Me.lbl_nom.Text = "..."
        '
        'MenuAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 532)
        Me.Controls.Add(Me.lbl_nom)
        Me.Controls.Add(Me.btn_Quitter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Deco)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MenuAdmin"
        Me.Text = "MenuAdmin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_AjoutServices As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_ConsultationService As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_ConsultationLog As System.Windows.Forms.Button
    Friend WithEvents btn_AjoutLog As System.Windows.Forms.Button
    Friend WithEvents btn_Deco As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_ConsultationMat As System.Windows.Forms.Button
    Friend WithEvents btn_AjoutMat As System.Windows.Forms.Button
    Friend WithEvents btn_Quitter As System.Windows.Forms.Button
    Friend WithEvents lbl_nom As System.Windows.Forms.Label
End Class
