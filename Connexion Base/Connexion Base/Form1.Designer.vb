<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_princ
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
        Me.Btn_Connexion = New System.Windows.Forms.Button()
        Me.lbl_Login = New System.Windows.Forms.Label()
        Me.Txt_Login = New System.Windows.Forms.TextBox()
        Me.Txt_MDP = New System.Windows.Forms.TextBox()
        Me.Lbl_MDP = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_Connexion
        '
        Me.Btn_Connexion.Location = New System.Drawing.Point(174, 233)
        Me.Btn_Connexion.Name = "Btn_Connexion"
        Me.Btn_Connexion.Size = New System.Drawing.Size(195, 63)
        Me.Btn_Connexion.TabIndex = 0
        Me.Btn_Connexion.Text = "Connexion"
        Me.Btn_Connexion.UseVisualStyleBackColor = True
        '
        'lbl_Login
        '
        Me.lbl_Login.AutoSize = True
        Me.lbl_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Login.Location = New System.Drawing.Point(59, 47)
        Me.lbl_Login.Name = "lbl_Login"
        Me.lbl_Login.Size = New System.Drawing.Size(84, 25)
        Me.lbl_Login.TabIndex = 1
        Me.lbl_Login.Text = "Login :"
        '
        'Txt_Login
        '
        Me.Txt_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Login.Location = New System.Drawing.Point(251, 42)
        Me.Txt_Login.Multiline = True
        Me.Txt_Login.Name = "Txt_Login"
        Me.Txt_Login.Size = New System.Drawing.Size(164, 30)
        Me.Txt_Login.TabIndex = 2
        Me.Txt_Login.Text = "EM"
        Me.Txt_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_MDP
        '
        Me.Txt_MDP.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_MDP.Location = New System.Drawing.Point(251, 127)
        Me.Txt_MDP.Multiline = True
        Me.Txt_MDP.Name = "Txt_MDP"
        Me.Txt_MDP.Size = New System.Drawing.Size(164, 30)
        Me.Txt_MDP.TabIndex = 4
        Me.Txt_MDP.Text = "MDP"
        Me.Txt_MDP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lbl_MDP
        '
        Me.Lbl_MDP.AutoSize = True
        Me.Lbl_MDP.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_MDP.Location = New System.Drawing.Point(59, 132)
        Me.Lbl_MDP.Name = "Lbl_MDP"
        Me.Lbl_MDP.Size = New System.Drawing.Size(168, 25)
        Me.Lbl_MDP.TabIndex = 3
        Me.Lbl_MDP.Text = "Mot de passe :"
        '
        'Frm_princ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 327)
        Me.Controls.Add(Me.Txt_MDP)
        Me.Controls.Add(Me.Lbl_MDP)
        Me.Controls.Add(Me.Txt_Login)
        Me.Controls.Add(Me.lbl_Login)
        Me.Controls.Add(Me.Btn_Connexion)
        Me.Name = "Frm_princ"
        Me.Text = "Connexion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Connexion As System.Windows.Forms.Button
    Friend WithEvents lbl_Login As System.Windows.Forms.Label
    Friend WithEvents Txt_Login As System.Windows.Forms.TextBox
    Friend WithEvents Txt_MDP As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_MDP As System.Windows.Forms.Label

End Class
