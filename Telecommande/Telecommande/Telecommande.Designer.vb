<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Telecommande
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
        Me.Btn_Haut = New System.Windows.Forms.Button()
        Me.Btn_Gauche = New System.Windows.Forms.Button()
        Me.Btn_Droit = New System.Windows.Forms.Button()
        Me.Btn_Bas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Haut
        '
        Me.Btn_Haut.Font = New System.Drawing.Font("Wingdings 3", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Haut.Location = New System.Drawing.Point(114, 43)
        Me.Btn_Haut.Name = "Btn_Haut"
        Me.Btn_Haut.Size = New System.Drawing.Size(53, 52)
        Me.Btn_Haut.TabIndex = 0
        Me.Btn_Haut.Text = "p"
        Me.Btn_Haut.UseVisualStyleBackColor = True
        '
        'Btn_Gauche
        '
        Me.Btn_Gauche.Font = New System.Drawing.Font("Wingdings 3", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Gauche.Location = New System.Drawing.Point(64, 92)
        Me.Btn_Gauche.Name = "Btn_Gauche"
        Me.Btn_Gauche.Size = New System.Drawing.Size(53, 52)
        Me.Btn_Gauche.TabIndex = 1
        Me.Btn_Gauche.Text = "t"
        Me.Btn_Gauche.UseVisualStyleBackColor = True
        '
        'Btn_Droit
        '
        Me.Btn_Droit.Font = New System.Drawing.Font("Wingdings 3", 22.25!, System.Drawing.FontStyle.Bold)
        Me.Btn_Droit.Location = New System.Drawing.Point(166, 92)
        Me.Btn_Droit.Name = "Btn_Droit"
        Me.Btn_Droit.Size = New System.Drawing.Size(53, 52)
        Me.Btn_Droit.TabIndex = 2
        Me.Btn_Droit.Text = "u"
        Me.Btn_Droit.UseVisualStyleBackColor = True
        '
        'Btn_Bas
        '
        Me.Btn_Bas.Font = New System.Drawing.Font("Wingdings 3", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Bas.Location = New System.Drawing.Point(114, 141)
        Me.Btn_Bas.Name = "Btn_Bas"
        Me.Btn_Bas.Size = New System.Drawing.Size(53, 52)
        Me.Btn_Bas.TabIndex = 3
        Me.Btn_Bas.Text = "q"
        Me.Btn_Bas.UseVisualStyleBackColor = True
        '
        'Frm_Telecommande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Btn_Bas)
        Me.Controls.Add(Me.Btn_Droit)
        Me.Controls.Add(Me.Btn_Gauche)
        Me.Controls.Add(Me.Btn_Haut)
        Me.Name = "Frm_Telecommande"
        Me.Text = "Télécommande"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Haut As System.Windows.Forms.Button
    Friend WithEvents Btn_Gauche As System.Windows.Forms.Button
    Friend WithEvents Btn_Droit As System.Windows.Forms.Button
    Friend WithEvents Btn_Bas As System.Windows.Forms.Button

End Class
