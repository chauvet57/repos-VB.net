<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class meilleur_scores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(meilleur_scores))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Lbl_Classement = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Lbl_Classement
        '
        Me.Lbl_Classement.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Lbl_Classement.Location = New System.Drawing.Point(56, 24)
        Me.Lbl_Classement.Name = "Lbl_Classement"
        Me.Lbl_Classement.Size = New System.Drawing.Size(221, 38)
        Me.Lbl_Classement.TabIndex = 0
        Me.Lbl_Classement.Text = "Scores      Nom"
        Me.Lbl_Classement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'meilleur_scores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(320, 489)
        Me.Controls.Add(Me.Lbl_Classement)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "meilleur_scores"
        Me.Text = "meilleur_scores"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Lbl_Classement As System.Windows.Forms.Label
End Class
