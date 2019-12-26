<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Règles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Règles))
        Me.Lbl_Titre = New System.Windows.Forms.Label()
        Me.LstBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Lbl_Titre
        '
        Me.Lbl_Titre.AutoSize = True
        Me.Lbl_Titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Titre.Location = New System.Drawing.Point(52, 30)
        Me.Lbl_Titre.Name = "Lbl_Titre"
        Me.Lbl_Titre.Size = New System.Drawing.Size(480, 33)
        Me.Lbl_Titre.TabIndex = 0
        Me.Lbl_Titre.Text = "Comment jouer au jeu du Pendu :"
        '
        'LstBox
        '
        Me.LstBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LstBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LstBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LstBox.FormattingEnabled = True
        Me.LstBox.ItemHeight = 20
        Me.LstBox.Items.AddRange(New Object() {"Le but du jeu est simple : deviner toute les lettres qui doivent composer un ", "mot, éventuellement avec un nombre limité de tentatives et des thèmes", " fixés à l'avance.", " A chaque fois que le joueur devine une lettre, celle-ci est affichée. ", "", "Dans le cas contraire, le dessin d'un pendu se met à apparaître…", "", "Chacun des joueurs joue à tour de rôle et le gagnant est celui qui aura deviné ", "le plus grand nombre de mots, en suivant les règles établies. ", "", "Des versions en ligne existent, tout en gardant le même principe, mais en y", " introduisant quelques variantes. Certaines versions proposent de deviner non ", "pas un seul mot, mais une phrase, un titre de film, de chanson ou de livre, ou ", "encore une citation.", "", "", "", "", "                                                Bonne Chance et Bon jeu !!!!"})
        Me.LstBox.Location = New System.Drawing.Point(22, 112)
        Me.LstBox.Name = "LstBox"
        Me.LstBox.Size = New System.Drawing.Size(570, 400)
        Me.LstBox.TabIndex = 1
        '
        'Règles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 541)
        Me.Controls.Add(Me.LstBox)
        Me.Controls.Add(Me.Lbl_Titre)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Règles"
        Me.Text = "Règles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Titre As System.Windows.Forms.Label
    Friend WithEvents LstBox As System.Windows.Forms.ListBox
End Class
