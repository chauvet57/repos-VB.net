<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Accueil
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Accueil))
        Me.Pbx_logo = New System.Windows.Forms.PictureBox()
        Me.Lbl_Bienvenue = New System.Windows.Forms.Label()
        Me.Lbl_Connect_Fonction = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollaborateurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.Pbx_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pbx_logo
        '
        Me.Pbx_logo.BackColor = System.Drawing.Color.Transparent
        Me.Pbx_logo.BackgroundImage = CType(resources.GetObject("Pbx_logo.BackgroundImage"), System.Drawing.Image)
        Me.Pbx_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pbx_logo.ErrorImage = Nothing
        Me.Pbx_logo.Location = New System.Drawing.Point(230, 69)
        Me.Pbx_logo.Name = "Pbx_logo"
        Me.Pbx_logo.Size = New System.Drawing.Size(160, 135)
        Me.Pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pbx_logo.TabIndex = 5
        Me.Pbx_logo.TabStop = False
        '
        'Lbl_Bienvenue
        '
        Me.Lbl_Bienvenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!)
        Me.Lbl_Bienvenue.Location = New System.Drawing.Point(9, 204)
        Me.Lbl_Bienvenue.Name = "Lbl_Bienvenue"
        Me.Lbl_Bienvenue.Size = New System.Drawing.Size(617, 96)
        Me.Lbl_Bienvenue.TabIndex = 6
        Me.Lbl_Bienvenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Connect_Fonction
        '
        Me.Lbl_Connect_Fonction.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!)
        Me.Lbl_Connect_Fonction.Location = New System.Drawing.Point(9, 312)
        Me.Lbl_Connect_Fonction.Name = "Lbl_Connect_Fonction"
        Me.Lbl_Connect_Fonction.Size = New System.Drawing.Size(617, 159)
        Me.Lbl_Connect_Fonction.TabIndex = 7
        Me.Lbl_Connect_Fonction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AToolStripMenuItem, Me.ClientToolStripMenuItem, Me.CollaborateurToolStripMenuItem, Me.ProjetToolStripMenuItem, Me.AdminToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(8, 20)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(737, 45)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(113, 41)
        Me.AToolStripMenuItem.Text = "Accueil"
        '
        'ClientToolStripMenuItem
        '
        Me.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem"
        Me.ClientToolStripMenuItem.Size = New System.Drawing.Size(98, 41)
        Me.ClientToolStripMenuItem.Text = "Client"
        '
        'CollaborateurToolStripMenuItem
        '
        Me.CollaborateurToolStripMenuItem.Checked = True
        Me.CollaborateurToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CollaborateurToolStripMenuItem.Name = "CollaborateurToolStripMenuItem"
        Me.CollaborateurToolStripMenuItem.Size = New System.Drawing.Size(192, 41)
        Me.CollaborateurToolStripMenuItem.Text = "Collaborateur"
        '
        'ProjetToolStripMenuItem
        '
        Me.ProjetToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ProjetToolStripMenuItem.Name = "ProjetToolStripMenuItem"
        Me.ProjetToolStripMenuItem.Size = New System.Drawing.Size(99, 41)
        Me.ProjetToolStripMenuItem.Text = "Projet"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(107, 41)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'Frm_Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(634, 544)
        Me.Controls.Add(Me.Lbl_Connect_Fonction)
        Me.Controls.Add(Me.Lbl_Bienvenue)
        Me.Controls.Add(Me.Pbx_logo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frm_Accueil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accueil"
        CType(Me.Pbx_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pbx_logo As PictureBox
    Friend WithEvents Lbl_Bienvenue As Label
    Friend WithEvents Lbl_Connect_Fonction As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CollaborateurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProjetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
End Class
