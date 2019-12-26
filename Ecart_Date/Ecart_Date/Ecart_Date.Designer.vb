<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ecart_Date
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
        Me.Cbx_Jour_1 = New System.Windows.Forms.ComboBox()
        Me.Cbx_Mois_1 = New System.Windows.Forms.ComboBox()
        Me.Cbx_Annee_1 = New System.Windows.Forms.ComboBox()
        Me.Lbl_jour = New System.Windows.Forms.Label()
        Me.Lbl_Mois = New System.Windows.Forms.Label()
        Me.Lbl_Annee = New System.Windows.Forms.Label()
        Me.Cbx_Jour_2 = New System.Windows.Forms.ComboBox()
        Me.Cbx_Mois_2 = New System.Windows.Forms.ComboBox()
        Me.Cbx_Annee_2 = New System.Windows.Forms.ComboBox()
        Me.Txt_Res = New System.Windows.Forms.TextBox()
        Me.Btn_Valider = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Cbx_Jour_1
        '
        Me.Cbx_Jour_1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.Cbx_Jour_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbx_Jour_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Cbx_Jour_1.FormattingEnabled = True
        Me.Cbx_Jour_1.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Cbx_Jour_1.IntegralHeight = False
        Me.Cbx_Jour_1.ItemHeight = 31
        Me.Cbx_Jour_1.Location = New System.Drawing.Point(45, 52)
        Me.Cbx_Jour_1.Name = "Cbx_Jour_1"
        Me.Cbx_Jour_1.Size = New System.Drawing.Size(62, 39)
        Me.Cbx_Jour_1.TabIndex = 1
        '
        'Cbx_Mois_1
        '
        Me.Cbx_Mois_1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.Cbx_Mois_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbx_Mois_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Cbx_Mois_1.FormattingEnabled = True
        Me.Cbx_Mois_1.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Cbx_Mois_1.IntegralHeight = False
        Me.Cbx_Mois_1.Location = New System.Drawing.Point(141, 52)
        Me.Cbx_Mois_1.Name = "Cbx_Mois_1"
        Me.Cbx_Mois_1.Size = New System.Drawing.Size(62, 39)
        Me.Cbx_Mois_1.TabIndex = 2
        '
        'Cbx_Annee_1
        '
        Me.Cbx_Annee_1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.Cbx_Annee_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbx_Annee_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Cbx_Annee_1.FormattingEnabled = True
        Me.Cbx_Annee_1.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Cbx_Annee_1.IntegralHeight = False
        Me.Cbx_Annee_1.Location = New System.Drawing.Point(243, 52)
        Me.Cbx_Annee_1.Name = "Cbx_Annee_1"
        Me.Cbx_Annee_1.Size = New System.Drawing.Size(100, 39)
        Me.Cbx_Annee_1.TabIndex = 3
        '
        'Lbl_jour
        '
        Me.Lbl_jour.AutoSize = True
        Me.Lbl_jour.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_jour.Enabled = False
        Me.Lbl_jour.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Lbl_jour.Location = New System.Drawing.Point(40, 9)
        Me.Lbl_jour.Name = "Lbl_jour"
        Me.Lbl_jour.Size = New System.Drawing.Size(65, 26)
        Me.Lbl_jour.TabIndex = 9
        Me.Lbl_jour.Text = "Jours"
        '
        'Lbl_Mois
        '
        Me.Lbl_Mois.AutoSize = True
        Me.Lbl_Mois.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Mois.Enabled = False
        Me.Lbl_Mois.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Lbl_Mois.Location = New System.Drawing.Point(136, 9)
        Me.Lbl_Mois.Name = "Lbl_Mois"
        Me.Lbl_Mois.Size = New System.Drawing.Size(58, 26)
        Me.Lbl_Mois.TabIndex = 10
        Me.Lbl_Mois.Text = "Mois"
        '
        'Lbl_Annee
        '
        Me.Lbl_Annee.AutoSize = True
        Me.Lbl_Annee.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Annee.Enabled = False
        Me.Lbl_Annee.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Lbl_Annee.Location = New System.Drawing.Point(238, 9)
        Me.Lbl_Annee.Name = "Lbl_Annee"
        Me.Lbl_Annee.Size = New System.Drawing.Size(86, 26)
        Me.Lbl_Annee.TabIndex = 11
        Me.Lbl_Annee.Text = "Années"
        '
        'Cbx_Jour_2
        '
        Me.Cbx_Jour_2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.Cbx_Jour_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbx_Jour_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Cbx_Jour_2.FormattingEnabled = True
        Me.Cbx_Jour_2.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Cbx_Jour_2.IntegralHeight = False
        Me.Cbx_Jour_2.Location = New System.Drawing.Point(45, 127)
        Me.Cbx_Jour_2.Name = "Cbx_Jour_2"
        Me.Cbx_Jour_2.Size = New System.Drawing.Size(62, 39)
        Me.Cbx_Jour_2.TabIndex = 12
        '
        'Cbx_Mois_2
        '
        Me.Cbx_Mois_2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.Cbx_Mois_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbx_Mois_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Cbx_Mois_2.FormattingEnabled = True
        Me.Cbx_Mois_2.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Cbx_Mois_2.IntegralHeight = False
        Me.Cbx_Mois_2.Location = New System.Drawing.Point(141, 127)
        Me.Cbx_Mois_2.Name = "Cbx_Mois_2"
        Me.Cbx_Mois_2.Size = New System.Drawing.Size(62, 39)
        Me.Cbx_Mois_2.TabIndex = 13
        '
        'Cbx_Annee_2
        '
        Me.Cbx_Annee_2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.Cbx_Annee_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbx_Annee_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Cbx_Annee_2.FormattingEnabled = True
        Me.Cbx_Annee_2.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Cbx_Annee_2.IntegralHeight = False
        Me.Cbx_Annee_2.Location = New System.Drawing.Point(243, 127)
        Me.Cbx_Annee_2.Name = "Cbx_Annee_2"
        Me.Cbx_Annee_2.Size = New System.Drawing.Size(100, 39)
        Me.Cbx_Annee_2.TabIndex = 14
        '
        'Txt_Res
        '
        Me.Txt_Res.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Txt_Res.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.Txt_Res.Location = New System.Drawing.Point(47, 207)
        Me.Txt_Res.Multiline = True
        Me.Txt_Res.Name = "Txt_Res"
        Me.Txt_Res.Size = New System.Drawing.Size(296, 54)
        Me.Txt_Res.TabIndex = 15
        Me.Txt_Res.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btn_Valider
        '
        Me.Btn_Valider.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Valider.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Btn_Valider.Location = New System.Drawing.Point(224, 302)
        Me.Btn_Valider.Name = "Btn_Valider"
        Me.Btn_Valider.Size = New System.Drawing.Size(119, 43)
        Me.Btn_Valider.TabIndex = 16
        Me.Btn_Valider.Text = "Valider"
        Me.Btn_Valider.UseVisualStyleBackColor = False
        '
        'Ecart_Date
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 366)
        Me.Controls.Add(Me.Btn_Valider)
        Me.Controls.Add(Me.Txt_Res)
        Me.Controls.Add(Me.Cbx_Annee_2)
        Me.Controls.Add(Me.Cbx_Mois_2)
        Me.Controls.Add(Me.Cbx_Jour_2)
        Me.Controls.Add(Me.Lbl_Annee)
        Me.Controls.Add(Me.Lbl_Mois)
        Me.Controls.Add(Me.Lbl_jour)
        Me.Controls.Add(Me.Cbx_Annee_1)
        Me.Controls.Add(Me.Cbx_Mois_1)
        Me.Controls.Add(Me.Cbx_Jour_1)
        Me.Name = "Ecart_Date"
        Me.Text = "Ecart entre deux dates"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cbx_Jour_1 As System.Windows.Forms.ComboBox
    Friend WithEvents Cbx_Mois_1 As System.Windows.Forms.ComboBox
    Friend WithEvents Cbx_Annee_1 As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_jour As System.Windows.Forms.Label
    Friend WithEvents Lbl_Mois As System.Windows.Forms.Label
    Friend WithEvents Lbl_Annee As System.Windows.Forms.Label
    Friend WithEvents Cbx_Jour_2 As System.Windows.Forms.ComboBox
    Friend WithEvents Cbx_Mois_2 As System.Windows.Forms.ComboBox
    Friend WithEvents Cbx_Annee_2 As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_Res As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Valider As System.Windows.Forms.Button

End Class
