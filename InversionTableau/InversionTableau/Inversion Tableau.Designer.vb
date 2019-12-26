<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
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
        Me.Btn_Inversion = New System.Windows.Forms.Button()
        Me.Lbl_Valeur = New System.Windows.Forms.Label()
        Me.Lbl_Tab_Inverser = New System.Windows.Forms.Label()
        Me.Btn_Generer = New System.Windows.Forms.Button()
        Me.Txt_Tab1 = New System.Windows.Forms.TextBox()
        Me.Txt_Tab2 = New System.Windows.Forms.TextBox()
        Me.Txt_Tab3 = New System.Windows.Forms.TextBox()
        Me.Txt_Tab4 = New System.Windows.Forms.TextBox()
        Me.Txt_Tab_Inv4 = New System.Windows.Forms.TextBox()
        Me.Txt_Tab_Inv3 = New System.Windows.Forms.TextBox()
        Me.Txt_Tab_Inv2 = New System.Windows.Forms.TextBox()
        Me.Txt_Tab_Inv1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btn_Inversion
        '
        Me.Btn_Inversion.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Inversion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Btn_Inversion.Location = New System.Drawing.Point(286, 386)
        Me.Btn_Inversion.Name = "Btn_Inversion"
        Me.Btn_Inversion.Size = New System.Drawing.Size(152, 51)
        Me.Btn_Inversion.TabIndex = 0
        Me.Btn_Inversion.Text = "Inversion"
        Me.Btn_Inversion.UseVisualStyleBackColor = False
        '
        'Lbl_Valeur
        '
        Me.Lbl_Valeur.AutoSize = True
        Me.Lbl_Valeur.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Lbl_Valeur.Location = New System.Drawing.Point(41, 94)
        Me.Lbl_Valeur.Name = "Lbl_Valeur"
        Me.Lbl_Valeur.Size = New System.Drawing.Size(175, 25)
        Me.Lbl_Valeur.TabIndex = 1
        Me.Lbl_Valeur.Text = "Tableau a Inverser"
        '
        'Lbl_Tab_Inverser
        '
        Me.Lbl_Tab_Inverser.AutoSize = True
        Me.Lbl_Tab_Inverser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Lbl_Tab_Inverser.Location = New System.Drawing.Point(41, 259)
        Me.Lbl_Tab_Inverser.Name = "Lbl_Tab_Inverser"
        Me.Lbl_Tab_Inverser.Size = New System.Drawing.Size(159, 25)
        Me.Lbl_Tab_Inverser.TabIndex = 2
        Me.Lbl_Tab_Inverser.Text = "Tableau Inverser"
        Me.Lbl_Tab_Inverser.Visible = False
        '
        'Btn_Generer
        '
        Me.Btn_Generer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Generer.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Btn_Generer.Location = New System.Drawing.Point(144, 24)
        Me.Btn_Generer.Name = "Btn_Generer"
        Me.Btn_Generer.Size = New System.Drawing.Size(171, 52)
        Me.Btn_Generer.TabIndex = 5
        Me.Btn_Generer.Text = "Générer"
        Me.Btn_Generer.UseVisualStyleBackColor = False
        '
        'Txt_Tab1
        '
        Me.Txt_Tab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Txt_Tab1.Location = New System.Drawing.Point(66, 146)
        Me.Txt_Tab1.Multiline = True
        Me.Txt_Tab1.Name = "Txt_Tab1"
        Me.Txt_Tab1.Size = New System.Drawing.Size(61, 59)
        Me.Txt_Tab1.TabIndex = 6
        Me.Txt_Tab1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_Tab2
        '
        Me.Txt_Tab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Txt_Tab2.Location = New System.Drawing.Point(155, 146)
        Me.Txt_Tab2.Multiline = True
        Me.Txt_Tab2.Name = "Txt_Tab2"
        Me.Txt_Tab2.Size = New System.Drawing.Size(61, 59)
        Me.Txt_Tab2.TabIndex = 7
        Me.Txt_Tab2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_Tab3
        '
        Me.Txt_Tab3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Txt_Tab3.Location = New System.Drawing.Point(244, 146)
        Me.Txt_Tab3.Multiline = True
        Me.Txt_Tab3.Name = "Txt_Tab3"
        Me.Txt_Tab3.Size = New System.Drawing.Size(61, 59)
        Me.Txt_Tab3.TabIndex = 8
        Me.Txt_Tab3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_Tab4
        '
        Me.Txt_Tab4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Txt_Tab4.Location = New System.Drawing.Point(337, 146)
        Me.Txt_Tab4.Multiline = True
        Me.Txt_Tab4.Name = "Txt_Tab4"
        Me.Txt_Tab4.Size = New System.Drawing.Size(61, 59)
        Me.Txt_Tab4.TabIndex = 9
        Me.Txt_Tab4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_Tab_Inv4
        '
        Me.Txt_Tab_Inv4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Txt_Tab_Inv4.Location = New System.Drawing.Point(337, 303)
        Me.Txt_Tab_Inv4.Multiline = True
        Me.Txt_Tab_Inv4.Name = "Txt_Tab_Inv4"
        Me.Txt_Tab_Inv4.Size = New System.Drawing.Size(61, 59)
        Me.Txt_Tab_Inv4.TabIndex = 13
        Me.Txt_Tab_Inv4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Txt_Tab_Inv4.Visible = False
        '
        'Txt_Tab_Inv3
        '
        Me.Txt_Tab_Inv3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Txt_Tab_Inv3.Location = New System.Drawing.Point(244, 303)
        Me.Txt_Tab_Inv3.Multiline = True
        Me.Txt_Tab_Inv3.Name = "Txt_Tab_Inv3"
        Me.Txt_Tab_Inv3.Size = New System.Drawing.Size(61, 59)
        Me.Txt_Tab_Inv3.TabIndex = 12
        Me.Txt_Tab_Inv3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Txt_Tab_Inv3.Visible = False
        '
        'Txt_Tab_Inv2
        '
        Me.Txt_Tab_Inv2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Txt_Tab_Inv2.Location = New System.Drawing.Point(155, 303)
        Me.Txt_Tab_Inv2.Multiline = True
        Me.Txt_Tab_Inv2.Name = "Txt_Tab_Inv2"
        Me.Txt_Tab_Inv2.Size = New System.Drawing.Size(61, 59)
        Me.Txt_Tab_Inv2.TabIndex = 11
        Me.Txt_Tab_Inv2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Txt_Tab_Inv2.Visible = False
        '
        'Txt_Tab_Inv1
        '
        Me.Txt_Tab_Inv1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Txt_Tab_Inv1.Location = New System.Drawing.Point(66, 303)
        Me.Txt_Tab_Inv1.Multiline = True
        Me.Txt_Tab_Inv1.Name = "Txt_Tab_Inv1"
        Me.Txt_Tab_Inv1.Size = New System.Drawing.Size(61, 59)
        Me.Txt_Tab_Inv1.TabIndex = 10
        Me.Txt_Tab_Inv1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Txt_Tab_Inv1.Visible = False
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 451)
        Me.Controls.Add(Me.Txt_Tab_Inv4)
        Me.Controls.Add(Me.Txt_Tab_Inv3)
        Me.Controls.Add(Me.Txt_Tab_Inv2)
        Me.Controls.Add(Me.Txt_Tab_Inv1)
        Me.Controls.Add(Me.Txt_Tab4)
        Me.Controls.Add(Me.Txt_Tab3)
        Me.Controls.Add(Me.Txt_Tab2)
        Me.Controls.Add(Me.Txt_Tab1)
        Me.Controls.Add(Me.Btn_Generer)
        Me.Controls.Add(Me.Lbl_Tab_Inverser)
        Me.Controls.Add(Me.Lbl_Valeur)
        Me.Controls.Add(Me.Btn_Inversion)
        Me.Name = "Frm_Principal"
        Me.Text = "Inversion de tableau"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Inversion As System.Windows.Forms.Button
    Friend WithEvents Lbl_Valeur As System.Windows.Forms.Label
    Friend WithEvents Lbl_Tab_Inverser As System.Windows.Forms.Label
    Friend WithEvents Btn_Generer As System.Windows.Forms.Button
    Friend WithEvents Txt_Tab1 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Tab2 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Tab3 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Tab4 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Tab_Inv4 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Tab_Inv3 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Tab_Inv2 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Tab_Inv1 As System.Windows.Forms.TextBox

End Class
