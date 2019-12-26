<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Visuel
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
        Me.Btn_Calcul = New System.Windows.Forms.Button()
        Me.Txt_Res = New System.Windows.Forms.TextBox()
        Me.Lbl_Dimension = New System.Windows.Forms.Label()
        Me.Txt_Dim = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btn_Calcul
        '
        Me.Btn_Calcul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Btn_Calcul.Location = New System.Drawing.Point(422, 503)
        Me.Btn_Calcul.Name = "Btn_Calcul"
        Me.Btn_Calcul.Size = New System.Drawing.Size(144, 65)
        Me.Btn_Calcul.TabIndex = 0
        Me.Btn_Calcul.Text = "Calculer"
        Me.Btn_Calcul.UseVisualStyleBackColor = True
        '
        'Txt_Res
        '
        Me.Txt_Res.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Txt_Res.Location = New System.Drawing.Point(12, 116)
        Me.Txt_Res.Multiline = True
        Me.Txt_Res.Name = "Txt_Res"
        Me.Txt_Res.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Txt_Res.Size = New System.Drawing.Size(554, 359)
        Me.Txt_Res.TabIndex = 3
        '
        'Lbl_Dimension
        '
        Me.Lbl_Dimension.AutoSize = True
        Me.Lbl_Dimension.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Lbl_Dimension.Location = New System.Drawing.Point(122, 50)
        Me.Lbl_Dimension.Name = "Lbl_Dimension"
        Me.Lbl_Dimension.Size = New System.Drawing.Size(128, 29)
        Me.Lbl_Dimension.TabIndex = 4
        Me.Lbl_Dimension.Text = "Dimension"
        '
        'Txt_Dim
        '
        Me.Txt_Dim.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Txt_Dim.Location = New System.Drawing.Point(256, 35)
        Me.Txt_Dim.Multiline = True
        Me.Txt_Dim.Name = "Txt_Dim"
        Me.Txt_Dim.Size = New System.Drawing.Size(146, 66)
        Me.Txt_Dim.TabIndex = 5
        Me.Txt_Dim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Visuel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 589)
        Me.Controls.Add(Me.Txt_Dim)
        Me.Controls.Add(Me.Lbl_Dimension)
        Me.Controls.Add(Me.Txt_Res)
        Me.Controls.Add(Me.Btn_Calcul)
        Me.Name = "Visuel"
        Me.Text = "Triangle de pascal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Calcul As System.Windows.Forms.Button
    Friend WithEvents Txt_Res As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Dimension As System.Windows.Forms.Label
    Friend WithEvents Txt_Dim As System.Windows.Forms.TextBox

End Class
