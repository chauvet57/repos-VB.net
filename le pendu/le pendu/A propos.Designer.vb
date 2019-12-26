<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class A_propos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(A_propos))
        Me.Ptb_logo = New System.Windows.Forms.PictureBox()
        Me.Lbl_titre = New System.Windows.Forms.Label()
        Me.Lbl_version = New System.Windows.Forms.Label()
        Me.Lbl_copyright = New System.Windows.Forms.Label()
        Me.Lbl_droit = New System.Windows.Forms.Label()
        CType(Me.Ptb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ptb_logo
        '
        Me.Ptb_logo.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.pendu
        Me.Ptb_logo.Location = New System.Drawing.Point(12, 15)
        Me.Ptb_logo.Name = "Ptb_logo"
        Me.Ptb_logo.Size = New System.Drawing.Size(161, 186)
        Me.Ptb_logo.TabIndex = 0
        Me.Ptb_logo.TabStop = False
        '
        'Lbl_titre
        '
        Me.Lbl_titre.AutoSize = True
        Me.Lbl_titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Lbl_titre.Location = New System.Drawing.Point(241, 25)
        Me.Lbl_titre.Name = "Lbl_titre"
        Me.Lbl_titre.Size = New System.Drawing.Size(101, 25)
        Me.Lbl_titre.TabIndex = 1
        Me.Lbl_titre.Text = "Le Pendu "
        '
        'Lbl_version
        '
        Me.Lbl_version.AutoSize = True
        Me.Lbl_version.Location = New System.Drawing.Point(190, 92)
        Me.Lbl_version.Name = "Lbl_version"
        Me.Lbl_version.Size = New System.Drawing.Size(75, 13)
        Me.Lbl_version.TabIndex = 2
        Me.Lbl_version.Text = "Version   1.2.1"
        '
        'Lbl_copyright
        '
        Me.Lbl_copyright.AutoSize = True
        Me.Lbl_copyright.Location = New System.Drawing.Point(179, 166)
        Me.Lbl_copyright.Name = "Lbl_copyright"
        Me.Lbl_copyright.Size = New System.Drawing.Size(203, 13)
        Me.Lbl_copyright.TabIndex = 3
        Me.Lbl_copyright.Text = "Copyright (C) 1999 2019 Dada production"
        '
        'Lbl_droit
        '
        Me.Lbl_droit.AutoSize = True
        Me.Lbl_droit.Location = New System.Drawing.Point(226, 179)
        Me.Lbl_droit.Name = "Lbl_droit"
        Me.Lbl_droit.Size = New System.Drawing.Size(105, 13)
        Me.Lbl_droit.TabIndex = 4
        Me.Lbl_droit.Text = "Tous droits réservés."
        '
        'A_propos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 213)
        Me.Controls.Add(Me.Lbl_droit)
        Me.Controls.Add(Me.Lbl_copyright)
        Me.Controls.Add(Me.Lbl_version)
        Me.Controls.Add(Me.Lbl_titre)
        Me.Controls.Add(Me.Ptb_logo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "A_propos"
        Me.Text = "A_propos"
        CType(Me.Ptb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ptb_logo As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_titre As System.Windows.Forms.Label
    Friend WithEvents Lbl_version As System.Windows.Forms.Label
    Friend WithEvents Lbl_copyright As System.Windows.Forms.Label
    Friend WithEvents Lbl_droit As System.Windows.Forms.Label
End Class
