<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fenetre
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
        Me.btn_parfait = New System.Windows.Forms.Button()
        Me.btn_ami = New System.Windows.Forms.Button()
        Me.Txt_Res = New System.Windows.Forms.TextBox()
        Me.Btn_Nbr_Premier = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_parfait
        '
        Me.btn_parfait.Location = New System.Drawing.Point(73, 75)
        Me.btn_parfait.Name = "btn_parfait"
        Me.btn_parfait.Size = New System.Drawing.Size(142, 55)
        Me.btn_parfait.TabIndex = 0
        Me.btn_parfait.Text = "Nombre Parfait"
        Me.btn_parfait.UseVisualStyleBackColor = True
        '
        'btn_ami
        '
        Me.btn_ami.Location = New System.Drawing.Point(73, 149)
        Me.btn_ami.Name = "btn_ami"
        Me.btn_ami.Size = New System.Drawing.Size(142, 55)
        Me.btn_ami.TabIndex = 1
        Me.btn_ami.Text = "Nombre Amis"
        Me.btn_ami.UseVisualStyleBackColor = True
        '
        'Txt_Res
        '
        Me.Txt_Res.Location = New System.Drawing.Point(34, 220)
        Me.Txt_Res.Multiline = True
        Me.Txt_Res.Name = "Txt_Res"
        Me.Txt_Res.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_Res.Size = New System.Drawing.Size(214, 124)
        Me.Txt_Res.TabIndex = 2
        '
        'Btn_Nbr_Premier
        '
        Me.Btn_Nbr_Premier.Location = New System.Drawing.Point(73, 1)
        Me.Btn_Nbr_Premier.Name = "Btn_Nbr_Premier"
        Me.Btn_Nbr_Premier.Size = New System.Drawing.Size(142, 55)
        Me.Btn_Nbr_Premier.TabIndex = 3
        Me.Btn_Nbr_Premier.Text = "Nombre Premier"
        Me.Btn_Nbr_Premier.UseVisualStyleBackColor = True
        '
        'fenetre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 356)
        Me.Controls.Add(Me.Btn_Nbr_Premier)
        Me.Controls.Add(Me.Txt_Res)
        Me.Controls.Add(Me.btn_ami)
        Me.Controls.Add(Me.btn_parfait)
        Me.Name = "fenetre"
        Me.Text = "Fenetre"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_parfait As System.Windows.Forms.Button
    Friend WithEvents btn_ami As System.Windows.Forms.Button
    Friend WithEvents Txt_Res As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Nbr_Premier As System.Windows.Forms.Button

End Class
