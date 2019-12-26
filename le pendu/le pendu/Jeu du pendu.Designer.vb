<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Pendu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Pendu))
        Me.Txt_Cpt_F = New System.Windows.Forms.TextBox()
        Me.Ptbx_Image = New System.Windows.Forms.PictureBox()
        Me.Img_Pendu = New System.Windows.Forms.ImageList(Me.components)
        Me.Txt_Mot = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouvellePartieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RèglesDuJeuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RègleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Lbl_Temps = New System.Windows.Forms.Label()
        Me.Txt_Nbr_Essais = New System.Windows.Forms.TextBox()
        Me.Btn_Start = New System.Windows.Forms.Button()
        CType(Me.Ptbx_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txt_Cpt_F
        '
        Me.Txt_Cpt_F.BackColor = System.Drawing.Color.Silver
        Me.Txt_Cpt_F.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Cpt_F.Enabled = False
        Me.Txt_Cpt_F.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Txt_Cpt_F.Location = New System.Drawing.Point(12, 260)
        Me.Txt_Cpt_F.Multiline = True
        Me.Txt_Cpt_F.Name = "Txt_Cpt_F"
        Me.Txt_Cpt_F.Size = New System.Drawing.Size(260, 39)
        Me.Txt_Cpt_F.TabIndex = 4
        Me.Txt_Cpt_F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Ptbx_Image
        '
        Me.Ptbx_Image.Location = New System.Drawing.Point(359, 32)
        Me.Ptbx_Image.Name = "Ptbx_Image"
        Me.Ptbx_Image.Size = New System.Drawing.Size(218, 245)
        Me.Ptbx_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ptbx_Image.TabIndex = 5
        Me.Ptbx_Image.TabStop = False
        '
        'Img_Pendu
        '
        Me.Img_Pendu.ImageStream = CType(resources.GetObject("Img_Pendu.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Img_Pendu.TransparentColor = System.Drawing.Color.Transparent
        Me.Img_Pendu.Images.SetKeyName(0, "1.png")
        Me.Img_Pendu.Images.SetKeyName(1, "2.png")
        Me.Img_Pendu.Images.SetKeyName(2, "3.png")
        Me.Img_Pendu.Images.SetKeyName(3, "4.png")
        Me.Img_Pendu.Images.SetKeyName(4, "5.png")
        Me.Img_Pendu.Images.SetKeyName(5, "6.png")
        Me.Img_Pendu.Images.SetKeyName(6, "7.png")
        Me.Img_Pendu.Images.SetKeyName(7, "8.png")
        Me.Img_Pendu.Images.SetKeyName(8, "9.png")
        Me.Img_Pendu.Images.SetKeyName(9, "10.png")
        Me.Img_Pendu.Images.SetKeyName(10, "le-pendu-1.png")
        '
        'Txt_Mot
        '
        Me.Txt_Mot.Location = New System.Drawing.Point(415, 149)
        Me.Txt_Mot.Name = "Txt_Mot"
        Me.Txt_Mot.Size = New System.Drawing.Size(70, 20)
        Me.Txt_Mot.TabIndex = 6
        Me.Txt_Mot.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.RèglesDuJeuToolStripMenuItem, Me.ScoreToolStripMenuItem, Me.AProposToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(589, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouvellePartieToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(47, 20)
        Me.ToolStripMenuItem1.Text = "Jouer"
        '
        'NouvellePartieToolStripMenuItem
        '
        Me.NouvellePartieToolStripMenuItem.Name = "NouvellePartieToolStripMenuItem"
        Me.NouvellePartieToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.NouvellePartieToolStripMenuItem.Text = "Nouvelle Partie"
        '
        'RèglesDuJeuToolStripMenuItem
        '
        Me.RèglesDuJeuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RègleToolStripMenuItem})
        Me.RèglesDuJeuToolStripMenuItem.Name = "RèglesDuJeuToolStripMenuItem"
        Me.RèglesDuJeuToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.RèglesDuJeuToolStripMenuItem.Text = "Règles du Jeu"
        '
        'RègleToolStripMenuItem
        '
        Me.RègleToolStripMenuItem.Name = "RègleToolStripMenuItem"
        Me.RègleToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.RègleToolStripMenuItem.Text = "Règles"
        '
        'ScoreToolStripMenuItem
        '
        Me.ScoreToolStripMenuItem.Name = "ScoreToolStripMenuItem"
        Me.ScoreToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.ScoreToolStripMenuItem.Text = "Meilleur Scores"
        '
        'AProposToolStripMenuItem
        '
        Me.AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        Me.AProposToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.AProposToolStripMenuItem.Text = "A Propos ..."
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Lbl_Temps
        '
        Me.Lbl_Temps.AutoSize = True
        Me.Lbl_Temps.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.Lbl_Temps.Location = New System.Drawing.Point(46, 182)
        Me.Lbl_Temps.Name = "Lbl_Temps"
        Me.Lbl_Temps.Size = New System.Drawing.Size(0, 29)
        Me.Lbl_Temps.TabIndex = 8
        '
        'Txt_Nbr_Essais
        '
        Me.Txt_Nbr_Essais.Enabled = False
        Me.Txt_Nbr_Essais.Location = New System.Drawing.Point(495, 216)
        Me.Txt_Nbr_Essais.Multiline = True
        Me.Txt_Nbr_Essais.Name = "Txt_Nbr_Essais"
        Me.Txt_Nbr_Essais.Size = New System.Drawing.Size(50, 44)
        Me.Txt_Nbr_Essais.TabIndex = 9
        Me.Txt_Nbr_Essais.Visible = False
        '
        'Btn_Start
        '
        Me.Btn_Start.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Btn_Start.Location = New System.Drawing.Point(21, 53)
        Me.Btn_Start.Name = "Btn_Start"
        Me.Btn_Start.Size = New System.Drawing.Size(164, 60)
        Me.Btn_Start.TabIndex = 10
        Me.Btn_Start.Text = "Jouer"
        Me.Btn_Start.UseVisualStyleBackColor = False
        '
        'Frm_Pendu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(589, 566)
        Me.Controls.Add(Me.Btn_Start)
        Me.Controls.Add(Me.Txt_Nbr_Essais)
        Me.Controls.Add(Me.Lbl_Temps)
        Me.Controls.Add(Me.Txt_Mot)
        Me.Controls.Add(Me.Ptbx_Image)
        Me.Controls.Add(Me.Txt_Cpt_F)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frm_Pendu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jeu du pendu"
        CType(Me.Ptbx_Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt_Cpt_F As System.Windows.Forms.TextBox
    Friend WithEvents Ptbx_Image As System.Windows.Forms.PictureBox
    Friend WithEvents Img_Pendu As System.Windows.Forms.ImageList
    Friend WithEvents Txt_Mot As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NouvellePartieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RèglesDuJeuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RègleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AProposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Lbl_Temps As System.Windows.Forms.Label
    Friend WithEvents Txt_Nbr_Essais As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Start As System.Windows.Forms.Button

End Class
