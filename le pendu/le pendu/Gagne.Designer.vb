<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gagne
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gagne))
        Me.Llb_5 = New System.Windows.Forms.Label()
        Me.Llb_3 = New System.Windows.Forms.Label()
        Me.Llb_4 = New System.Windows.Forms.Label()
        Me.Llb_2 = New System.Windows.Forms.Label()
        Me.Llb_1 = New System.Windows.Forms.Label()
        Me.Btn_New = New System.Windows.Forms.Button()
        Me.Btn_End = New System.Windows.Forms.Button()
        Me.Txt_Nbr_Essais = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Llb_5
        '
        Me.Llb_5.AutoSize = True
        Me.Llb_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Llb_5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Llb_5.Location = New System.Drawing.Point(452, 59)
        Me.Llb_5.Name = "Llb_5"
        Me.Llb_5.Size = New System.Drawing.Size(76, 73)
        Me.Llb_5.TabIndex = 9
        Me.Llb_5.Text = "E"
        '
        'Llb_3
        '
        Me.Llb_3.AutoSize = True
        Me.Llb_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Llb_3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Llb_3.Location = New System.Drawing.Point(254, 59)
        Me.Llb_3.Name = "Llb_3"
        Me.Llb_3.Size = New System.Drawing.Size(83, 73)
        Me.Llb_3.TabIndex = 8
        Me.Llb_3.Text = "G"
        '
        'Llb_4
        '
        Me.Llb_4.AutoSize = True
        Me.Llb_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Llb_4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Llb_4.Location = New System.Drawing.Point(355, 105)
        Me.Llb_4.Name = "Llb_4"
        Me.Llb_4.Size = New System.Drawing.Size(79, 73)
        Me.Llb_4.TabIndex = 7
        Me.Llb_4.Text = "N"
        '
        'Llb_2
        '
        Me.Llb_2.AutoSize = True
        Me.Llb_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Llb_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Llb_2.Location = New System.Drawing.Point(160, 105)
        Me.Llb_2.Name = "Llb_2"
        Me.Llb_2.Size = New System.Drawing.Size(76, 73)
        Me.Llb_2.TabIndex = 6
        Me.Llb_2.Text = "A"
        '
        'Llb_1
        '
        Me.Llb_1.AutoSize = True
        Me.Llb_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Llb_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Llb_1.Location = New System.Drawing.Point(57, 59)
        Me.Llb_1.Name = "Llb_1"
        Me.Llb_1.Size = New System.Drawing.Size(83, 73)
        Me.Llb_1.TabIndex = 5
        Me.Llb_1.Text = "G"
        '
        'Btn_New
        '
        Me.Btn_New.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_New.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_New.Location = New System.Drawing.Point(63, 435)
        Me.Btn_New.Name = "Btn_New"
        Me.Btn_New.Size = New System.Drawing.Size(441, 51)
        Me.Btn_New.TabIndex = 12
        Me.Btn_New.Text = "Nouvelle partie ?"
        Me.Btn_New.UseVisualStyleBackColor = False
        '
        'Btn_End
        '
        Me.Btn_End.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_End.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Btn_End.Location = New System.Drawing.Point(63, 503)
        Me.Btn_End.Name = "Btn_End"
        Me.Btn_End.Size = New System.Drawing.Size(441, 51)
        Me.Btn_End.TabIndex = 13
        Me.Btn_End.Text = "Quitter"
        Me.Btn_End.UseVisualStyleBackColor = False
        '
        'Txt_Nbr_Essais
        '
        Me.Txt_Nbr_Essais.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Txt_Nbr_Essais.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Nbr_Essais.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Nbr_Essais.Location = New System.Drawing.Point(-2, 203)
        Me.Txt_Nbr_Essais.Multiline = True
        Me.Txt_Nbr_Essais.Name = "Txt_Nbr_Essais"
        Me.Txt_Nbr_Essais.Size = New System.Drawing.Size(589, 212)
        Me.Txt_Nbr_Essais.TabIndex = 14
        Me.Txt_Nbr_Essais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Gagne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 566)
        Me.Controls.Add(Me.Txt_Nbr_Essais)
        Me.Controls.Add(Me.Btn_End)
        Me.Controls.Add(Me.Btn_New)
        Me.Controls.Add(Me.Llb_5)
        Me.Controls.Add(Me.Llb_3)
        Me.Controls.Add(Me.Llb_4)
        Me.Controls.Add(Me.Llb_2)
        Me.Controls.Add(Me.Llb_1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Gagne"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gagne"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Llb_5 As System.Windows.Forms.Label
    Friend WithEvents Llb_3 As System.Windows.Forms.Label
    Friend WithEvents Llb_4 As System.Windows.Forms.Label
    Friend WithEvents Llb_2 As System.Windows.Forms.Label
    Friend WithEvents Llb_1 As System.Windows.Forms.Label
    Friend WithEvents Btn_New As System.Windows.Forms.Button
    Friend WithEvents Btn_End As System.Windows.Forms.Button
    Friend WithEvents Txt_Nbr_Essais As System.Windows.Forms.TextBox
End Class
