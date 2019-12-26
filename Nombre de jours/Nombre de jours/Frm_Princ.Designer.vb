<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Princ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Princ))
        Me.Lbl_Date1 = New System.Windows.Forms.Label()
        Me.Lbl_Slash = New System.Windows.Forms.Label()
        Me.Lbl_Slash2 = New System.Windows.Forms.Label()
        Me.Lbl_Slash4 = New System.Windows.Forms.Label()
        Me.Lbl_Slash3 = New System.Windows.Forms.Label()
        Me.Lbl_Date2 = New System.Windows.Forms.Label()
        Me.Txt_Res = New System.Windows.Forms.TextBox()
        Me.Btn_Calculer = New System.Windows.Forms.Button()
        Me.DTP_1 = New System.Windows.Forms.DateTimePicker()
        Me.DTP_2 = New System.Windows.Forms.DateTimePicker()
        Me.Btn_Verifie = New System.Windows.Forms.Button()
        Me.Txt_j1 = New System.Windows.Forms.ComboBox()
        Me.Txt_m1 = New System.Windows.Forms.ComboBox()
        Me.Txt_a1 = New System.Windows.Forms.ComboBox()
        Me.Txt_a2 = New System.Windows.Forms.ComboBox()
        Me.Txt_m2 = New System.Windows.Forms.ComboBox()
        Me.Txt_j2 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Lbl_Date1
        '
        Me.Lbl_Date1.AutoSize = True
        Me.Lbl_Date1.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Date1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Lbl_Date1.Location = New System.Drawing.Point(63, 31)
        Me.Lbl_Date1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Lbl_Date1.Name = "Lbl_Date1"
        Me.Lbl_Date1.Size = New System.Drawing.Size(87, 25)
        Me.Lbl_Date1.TabIndex = 0
        Me.Lbl_Date1.Text = "Date 1 :"
        '
        'Lbl_Slash
        '
        Me.Lbl_Slash.AutoSize = True
        Me.Lbl_Slash.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Slash.Location = New System.Drawing.Point(238, 31)
        Me.Lbl_Slash.Name = "Lbl_Slash"
        Me.Lbl_Slash.Size = New System.Drawing.Size(18, 25)
        Me.Lbl_Slash.TabIndex = 2
        Me.Lbl_Slash.Text = "/"
        '
        'Lbl_Slash2
        '
        Me.Lbl_Slash2.AutoSize = True
        Me.Lbl_Slash2.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Slash2.Location = New System.Drawing.Point(330, 31)
        Me.Lbl_Slash2.Name = "Lbl_Slash2"
        Me.Lbl_Slash2.Size = New System.Drawing.Size(18, 25)
        Me.Lbl_Slash2.TabIndex = 4
        Me.Lbl_Slash2.Text = "/"
        '
        'Lbl_Slash4
        '
        Me.Lbl_Slash4.AutoSize = True
        Me.Lbl_Slash4.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Slash4.Location = New System.Drawing.Point(330, 130)
        Me.Lbl_Slash4.Name = "Lbl_Slash4"
        Me.Lbl_Slash4.Size = New System.Drawing.Size(18, 25)
        Me.Lbl_Slash4.TabIndex = 10
        Me.Lbl_Slash4.Text = "/"
        '
        'Lbl_Slash3
        '
        Me.Lbl_Slash3.AutoSize = True
        Me.Lbl_Slash3.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Slash3.Location = New System.Drawing.Point(238, 130)
        Me.Lbl_Slash3.Name = "Lbl_Slash3"
        Me.Lbl_Slash3.Size = New System.Drawing.Size(18, 25)
        Me.Lbl_Slash3.TabIndex = 8
        Me.Lbl_Slash3.Text = "/"
        '
        'Lbl_Date2
        '
        Me.Lbl_Date2.AutoSize = True
        Me.Lbl_Date2.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Date2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Lbl_Date2.Location = New System.Drawing.Point(63, 130)
        Me.Lbl_Date2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Lbl_Date2.Name = "Lbl_Date2"
        Me.Lbl_Date2.Size = New System.Drawing.Size(87, 25)
        Me.Lbl_Date2.TabIndex = 6
        Me.Lbl_Date2.Text = "Date 2 :"
        '
        'Txt_Res
        '
        Me.Txt_Res.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Txt_Res.Location = New System.Drawing.Point(12, 281)
        Me.Txt_Res.Multiline = True
        Me.Txt_Res.Name = "Txt_Res"
        Me.Txt_Res.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Txt_Res.Size = New System.Drawing.Size(582, 104)
        Me.Txt_Res.TabIndex = 12
        Me.Txt_Res.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btn_Calculer
        '
        Me.Btn_Calculer.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Calculer.Location = New System.Drawing.Point(215, 404)
        Me.Btn_Calculer.Name = "Btn_Calculer"
        Me.Btn_Calculer.Size = New System.Drawing.Size(187, 52)
        Me.Btn_Calculer.TabIndex = 13
        Me.Btn_Calculer.Text = "Calculer"
        Me.Btn_Calculer.UseVisualStyleBackColor = False
        '
        'DTP_1
        '
        Me.DTP_1.Location = New System.Drawing.Point(170, 67)
        Me.DTP_1.Name = "DTP_1"
        Me.DTP_1.Size = New System.Drawing.Size(303, 31)
        Me.DTP_1.TabIndex = 14
        '
        'DTP_2
        '
        Me.DTP_2.Location = New System.Drawing.Point(170, 166)
        Me.DTP_2.Name = "DTP_2"
        Me.DTP_2.Size = New System.Drawing.Size(303, 31)
        Me.DTP_2.TabIndex = 15
        '
        'Btn_Verifie
        '
        Me.Btn_Verifie.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Verifie.Location = New System.Drawing.Point(438, 404)
        Me.Btn_Verifie.Name = "Btn_Verifie"
        Me.Btn_Verifie.Size = New System.Drawing.Size(104, 52)
        Me.Btn_Verifie.TabIndex = 16
        Me.Btn_Verifie.Text = "Vérifier"
        Me.Btn_Verifie.UseVisualStyleBackColor = False
        '
        'Txt_j1
        '
        Me.Txt_j1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.Txt_j1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Txt_j1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Txt_j1.FormattingEnabled = True
        Me.Txt_j1.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Txt_j1.IntegralHeight = False
        Me.Txt_j1.ItemHeight = 31
        Me.Txt_j1.Location = New System.Drawing.Point(170, 22)
        Me.Txt_j1.Name = "Txt_j1"
        Me.Txt_j1.Size = New System.Drawing.Size(62, 39)
        Me.Txt_j1.TabIndex = 17
        '
        'Txt_m1
        '
        Me.Txt_m1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.Txt_m1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Txt_m1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Txt_m1.FormattingEnabled = True
        Me.Txt_m1.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Txt_m1.IntegralHeight = False
        Me.Txt_m1.Location = New System.Drawing.Point(262, 22)
        Me.Txt_m1.Name = "Txt_m1"
        Me.Txt_m1.Size = New System.Drawing.Size(62, 39)
        Me.Txt_m1.TabIndex = 18
        '
        'Txt_a1
        '
        Me.Txt_a1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.Txt_a1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Txt_a1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Txt_a1.FormattingEnabled = True
        Me.Txt_a1.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Txt_a1.IntegralHeight = False
        Me.Txt_a1.Location = New System.Drawing.Point(354, 22)
        Me.Txt_a1.Name = "Txt_a1"
        Me.Txt_a1.Size = New System.Drawing.Size(119, 39)
        Me.Txt_a1.TabIndex = 19
        '
        'Txt_a2
        '
        Me.Txt_a2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.Txt_a2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Txt_a2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Txt_a2.FormattingEnabled = True
        Me.Txt_a2.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Txt_a2.IntegralHeight = False
        Me.Txt_a2.Location = New System.Drawing.Point(354, 121)
        Me.Txt_a2.Name = "Txt_a2"
        Me.Txt_a2.Size = New System.Drawing.Size(119, 39)
        Me.Txt_a2.TabIndex = 20
        '
        'Txt_m2
        '
        Me.Txt_m2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.Txt_m2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Txt_m2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Txt_m2.FormattingEnabled = True
        Me.Txt_m2.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Txt_m2.IntegralHeight = False
        Me.Txt_m2.Location = New System.Drawing.Point(262, 121)
        Me.Txt_m2.Name = "Txt_m2"
        Me.Txt_m2.Size = New System.Drawing.Size(62, 39)
        Me.Txt_m2.TabIndex = 21
        '
        'Txt_j2
        '
        Me.Txt_j2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.Txt_j2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Txt_j2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Txt_j2.FormattingEnabled = True
        Me.Txt_j2.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Txt_j2.IntegralHeight = False
        Me.Txt_j2.ItemHeight = 31
        Me.Txt_j2.Location = New System.Drawing.Point(170, 121)
        Me.Txt_j2.Name = "Txt_j2"
        Me.Txt_j2.Size = New System.Drawing.Size(62, 39)
        Me.Txt_j2.TabIndex = 22
        '
        'Frm_Princ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(606, 468)
        Me.Controls.Add(Me.Txt_j2)
        Me.Controls.Add(Me.Txt_m2)
        Me.Controls.Add(Me.Txt_a2)
        Me.Controls.Add(Me.Txt_a1)
        Me.Controls.Add(Me.Txt_m1)
        Me.Controls.Add(Me.Txt_j1)
        Me.Controls.Add(Me.Btn_Verifie)
        Me.Controls.Add(Me.DTP_2)
        Me.Controls.Add(Me.DTP_1)
        Me.Controls.Add(Me.Btn_Calculer)
        Me.Controls.Add(Me.Txt_Res)
        Me.Controls.Add(Me.Lbl_Slash4)
        Me.Controls.Add(Me.Lbl_Slash3)
        Me.Controls.Add(Me.Lbl_Date2)
        Me.Controls.Add(Me.Lbl_Slash2)
        Me.Controls.Add(Me.Lbl_Slash)
        Me.Controls.Add(Me.Lbl_Date1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Frm_Princ"
        Me.Text = "Nombre de jours entre 2 dates"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Date1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Slash As System.Windows.Forms.Label
    Friend WithEvents Lbl_Slash2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Slash4 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Slash3 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Date2 As System.Windows.Forms.Label
    Friend WithEvents Txt_Res As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Calculer As System.Windows.Forms.Button
    Friend WithEvents DTP_1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP_2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Btn_Verifie As System.Windows.Forms.Button
    Friend WithEvents Txt_j1 As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_m1 As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_a1 As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_a2 As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_m2 As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_j2 As System.Windows.Forms.ComboBox

End Class
