<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaisirValeur
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
        Me.BtnGo = New System.Windows.Forms.Button()
        Me.TxtRes = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnGo
        '
        Me.BtnGo.Location = New System.Drawing.Point(125, 38)
        Me.BtnGo.Name = "BtnGo"
        Me.BtnGo.Size = New System.Drawing.Size(158, 91)
        Me.BtnGo.TabIndex = 0
        Me.BtnGo.Text = "Go !!"
        Me.BtnGo.UseVisualStyleBackColor = True
        '
        'TxtRes
        '
        Me.TxtRes.Location = New System.Drawing.Point(55, 165)
        Me.TxtRes.Multiline = True
        Me.TxtRes.Name = "TxtRes"
        Me.TxtRes.Size = New System.Drawing.Size(295, 165)
        Me.TxtRes.TabIndex = 1
        '
        'SaisirValeur
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(411, 379)
        Me.Controls.Add(Me.TxtRes)
        Me.Controls.Add(Me.BtnGo)
        Me.Name = "SaisirValeur"
        Me.Text = "Saisir une valeur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnGo As System.Windows.Forms.Button
    Friend WithEvents TxtRes As System.Windows.Forms.TextBox

End Class
