<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Connect
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Connect))
        Me.Txt_Login = New System.Windows.Forms.TextBox()
        Me.Txt_Mdp = New System.Windows.Forms.TextBox()
        Me.Lbl_Login = New System.Windows.Forms.Label()
        Me.Lbl_Mdp = New System.Windows.Forms.Label()
        Me.Btn_Connexion = New System.Windows.Forms.Button()
        Me.Lbl_Mdp_Oublie = New System.Windows.Forms.Label()
        Me.Pbx_logo = New System.Windows.Forms.PictureBox()
        CType(Me.Pbx_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txt_Login
        '
        Me.Txt_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Txt_Login.Location = New System.Drawing.Point(107, 236)
        Me.Txt_Login.Multiline = True
        Me.Txt_Login.Name = "Txt_Login"
        Me.Txt_Login.Size = New System.Drawing.Size(291, 53)
        Me.Txt_Login.TabIndex = 0
        Me.Txt_Login.Text = "dada"
        Me.Txt_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_Mdp
        '
        Me.Txt_Mdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Txt_Mdp.Location = New System.Drawing.Point(107, 355)
        Me.Txt_Mdp.Multiline = True
        Me.Txt_Mdp.Name = "Txt_Mdp"
        Me.Txt_Mdp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Mdp.Size = New System.Drawing.Size(291, 50)
        Me.Txt_Mdp.TabIndex = 1
        Me.Txt_Mdp.Text = "1234"
        Me.Txt_Mdp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lbl_Login
        '
        Me.Lbl_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Lbl_Login.Location = New System.Drawing.Point(154, 189)
        Me.Lbl_Login.Name = "Lbl_Login"
        Me.Lbl_Login.Size = New System.Drawing.Size(191, 44)
        Me.Lbl_Login.TabIndex = 2
        Me.Lbl_Login.Text = "Login"
        Me.Lbl_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Mdp
        '
        Me.Lbl_Mdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Lbl_Mdp.Location = New System.Drawing.Point(129, 303)
        Me.Lbl_Mdp.Name = "Lbl_Mdp"
        Me.Lbl_Mdp.Size = New System.Drawing.Size(244, 49)
        Me.Lbl_Mdp.TabIndex = 3
        Me.Lbl_Mdp.Text = "Mot de passe"
        Me.Lbl_Mdp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_Connexion
        '
        Me.Btn_Connexion.BackColor = System.Drawing.Color.LimeGreen
        Me.Btn_Connexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Btn_Connexion.Location = New System.Drawing.Point(136, 462)
        Me.Btn_Connexion.Name = "Btn_Connexion"
        Me.Btn_Connexion.Size = New System.Drawing.Size(237, 54)
        Me.Btn_Connexion.TabIndex = 4
        Me.Btn_Connexion.Text = "Connexion"
        Me.Btn_Connexion.UseVisualStyleBackColor = False
        '
        'Lbl_Mdp_Oublie
        '
        Me.Lbl_Mdp_Oublie.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lbl_Mdp_Oublie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Lbl_Mdp_Oublie.Location = New System.Drawing.Point(174, 408)
        Me.Lbl_Mdp_Oublie.Name = "Lbl_Mdp_Oublie"
        Me.Lbl_Mdp_Oublie.Size = New System.Drawing.Size(151, 25)
        Me.Lbl_Mdp_Oublie.TabIndex = 5
        Me.Lbl_Mdp_Oublie.Text = "Mot de passe oublié ?"
        Me.Lbl_Mdp_Oublie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pbx_logo
        '
        Me.Pbx_logo.BackColor = System.Drawing.Color.Transparent
        Me.Pbx_logo.BackgroundImage = CType(resources.GetObject("Pbx_logo.BackgroundImage"), System.Drawing.Image)
        Me.Pbx_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pbx_logo.ErrorImage = Nothing
        Me.Pbx_logo.Location = New System.Drawing.Point(178, 32)
        Me.Pbx_logo.Name = "Pbx_logo"
        Me.Pbx_logo.Size = New System.Drawing.Size(153, 140)
        Me.Pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pbx_logo.TabIndex = 23
        Me.Pbx_logo.TabStop = False
        '
        'Frm_Connect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(499, 545)
        Me.Controls.Add(Me.Pbx_logo)
        Me.Controls.Add(Me.Lbl_Mdp_Oublie)
        Me.Controls.Add(Me.Btn_Connexion)
        Me.Controls.Add(Me.Lbl_Mdp)
        Me.Controls.Add(Me.Lbl_Login)
        Me.Controls.Add(Me.Txt_Mdp)
        Me.Controls.Add(Me.Txt_Login)
        Me.Name = "Frm_Connect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connexion"
        CType(Me.Pbx_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_Login As TextBox
    Friend WithEvents Txt_Mdp As TextBox
    Friend WithEvents Lbl_Login As Label
    Friend WithEvents Lbl_Mdp As Label
    Friend WithEvents Btn_Connexion As Button
    Friend WithEvents Lbl_Mdp_Oublie As Label
    Friend WithEvents Pbx_logo As PictureBox
End Class
