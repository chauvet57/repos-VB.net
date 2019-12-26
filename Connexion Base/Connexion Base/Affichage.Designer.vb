<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Affichage
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
        Me.Cb_Villes = New System.Windows.Forms.ComboBox()
        Me.Btn_Remplir_Ville = New System.Windows.Forms.Button()
        Me.Lbl_AjouterVille = New System.Windows.Forms.Label()
        Me.Txt_AjouterVille = New System.Windows.Forms.TextBox()
        Me.Btn_AjouterVille = New System.Windows.Forms.Button()
        Me.Btn_Ajouter_Region = New System.Windows.Forms.Button()
        Me.Txt_Ajouter_Region = New System.Windows.Forms.TextBox()
        Me.Lbl_Ajouter_Region = New System.Windows.Forms.Label()
        Me.Btn_Remplir_Region = New System.Windows.Forms.Button()
        Me.Cb_Regions = New System.Windows.Forms.ComboBox()
        Me.DGV_Liste_Projet = New System.Windows.Forms.DataGridView()
        Me.Btn_Remplir = New System.Windows.Forms.Button()
        Me.Txt_Param = New System.Windows.Forms.TextBox()
        Me.Lbl_Critere = New System.Windows.Forms.Label()
        Me.Btn_Qui = New System.Windows.Forms.Button()
        Me.Btn_MAJ = New System.Windows.Forms.Button()
        CType(Me.DGV_Liste_Projet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cb_Villes
        '
        Me.Cb_Villes.FormattingEnabled = True
        Me.Cb_Villes.Location = New System.Drawing.Point(114, 28)
        Me.Cb_Villes.Name = "Cb_Villes"
        Me.Cb_Villes.Size = New System.Drawing.Size(225, 21)
        Me.Cb_Villes.TabIndex = 0
        '
        'Btn_Remplir_Ville
        '
        Me.Btn_Remplir_Ville.Location = New System.Drawing.Point(161, 64)
        Me.Btn_Remplir_Ville.Name = "Btn_Remplir_Ville"
        Me.Btn_Remplir_Ville.Size = New System.Drawing.Size(128, 47)
        Me.Btn_Remplir_Ville.TabIndex = 1
        Me.Btn_Remplir_Ville.Text = "Remplir Combo"
        Me.Btn_Remplir_Ville.UseVisualStyleBackColor = True
        '
        'Lbl_AjouterVille
        '
        Me.Lbl_AjouterVille.AutoSize = True
        Me.Lbl_AjouterVille.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_AjouterVille.Location = New System.Drawing.Point(57, 151)
        Me.Lbl_AjouterVille.Name = "Lbl_AjouterVille"
        Me.Lbl_AjouterVille.Size = New System.Drawing.Size(86, 29)
        Me.Lbl_AjouterVille.TabIndex = 2
        Me.Lbl_AjouterVille.Text = "Ville : "
        '
        'Txt_AjouterVille
        '
        Me.Txt_AjouterVille.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_AjouterVille.Location = New System.Drawing.Point(167, 150)
        Me.Txt_AjouterVille.Multiline = True
        Me.Txt_AjouterVille.Name = "Txt_AjouterVille"
        Me.Txt_AjouterVille.Size = New System.Drawing.Size(222, 30)
        Me.Txt_AjouterVille.TabIndex = 3
        '
        'Btn_AjouterVille
        '
        Me.Btn_AjouterVille.Location = New System.Drawing.Point(161, 212)
        Me.Btn_AjouterVille.Name = "Btn_AjouterVille"
        Me.Btn_AjouterVille.Size = New System.Drawing.Size(122, 49)
        Me.Btn_AjouterVille.TabIndex = 4
        Me.Btn_AjouterVille.Text = "Ajouter Ville"
        Me.Btn_AjouterVille.UseVisualStyleBackColor = True
        '
        'Btn_Ajouter_Region
        '
        Me.Btn_Ajouter_Region.Location = New System.Drawing.Point(642, 212)
        Me.Btn_Ajouter_Region.Name = "Btn_Ajouter_Region"
        Me.Btn_Ajouter_Region.Size = New System.Drawing.Size(122, 49)
        Me.Btn_Ajouter_Region.TabIndex = 9
        Me.Btn_Ajouter_Region.Text = "Ajouter Region"
        Me.Btn_Ajouter_Region.UseVisualStyleBackColor = True
        '
        'Txt_Ajouter_Region
        '
        Me.Txt_Ajouter_Region.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Ajouter_Region.Location = New System.Drawing.Point(648, 150)
        Me.Txt_Ajouter_Region.Multiline = True
        Me.Txt_Ajouter_Region.Name = "Txt_Ajouter_Region"
        Me.Txt_Ajouter_Region.Size = New System.Drawing.Size(222, 30)
        Me.Txt_Ajouter_Region.TabIndex = 8
        '
        'Lbl_Ajouter_Region
        '
        Me.Lbl_Ajouter_Region.AutoSize = True
        Me.Lbl_Ajouter_Region.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Ajouter_Region.Location = New System.Drawing.Point(538, 151)
        Me.Lbl_Ajouter_Region.Name = "Lbl_Ajouter_Region"
        Me.Lbl_Ajouter_Region.Size = New System.Drawing.Size(118, 29)
        Me.Lbl_Ajouter_Region.TabIndex = 7
        Me.Lbl_Ajouter_Region.Text = "Region : "
        '
        'Btn_Remplir_Region
        '
        Me.Btn_Remplir_Region.Location = New System.Drawing.Point(642, 64)
        Me.Btn_Remplir_Region.Name = "Btn_Remplir_Region"
        Me.Btn_Remplir_Region.Size = New System.Drawing.Size(128, 47)
        Me.Btn_Remplir_Region.TabIndex = 6
        Me.Btn_Remplir_Region.Text = "Remplir Combo"
        Me.Btn_Remplir_Region.UseVisualStyleBackColor = True
        '
        'Cb_Regions
        '
        Me.Cb_Regions.FormattingEnabled = True
        Me.Cb_Regions.Location = New System.Drawing.Point(595, 28)
        Me.Cb_Regions.Name = "Cb_Regions"
        Me.Cb_Regions.Size = New System.Drawing.Size(225, 21)
        Me.Cb_Regions.TabIndex = 5
        '
        'DGV_Liste_Projet
        '
        Me.DGV_Liste_Projet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Liste_Projet.Location = New System.Drawing.Point(43, 282)
        Me.DGV_Liste_Projet.Name = "DGV_Liste_Projet"
        Me.DGV_Liste_Projet.Size = New System.Drawing.Size(721, 199)
        Me.DGV_Liste_Projet.TabIndex = 10
        '
        'Btn_Remplir
        '
        Me.Btn_Remplir.Location = New System.Drawing.Point(821, 342)
        Me.Btn_Remplir.Name = "Btn_Remplir"
        Me.Btn_Remplir.Size = New System.Drawing.Size(121, 73)
        Me.Btn_Remplir.TabIndex = 11
        Me.Btn_Remplir.Text = "Remplissage"
        Me.Btn_Remplir.UseVisualStyleBackColor = True
        '
        'Txt_Param
        '
        Me.Txt_Param.Location = New System.Drawing.Point(841, 289)
        Me.Txt_Param.Name = "Txt_Param"
        Me.Txt_Param.Size = New System.Drawing.Size(91, 20)
        Me.Txt_Param.TabIndex = 12
        Me.Txt_Param.Text = "%e%"
        '
        'Lbl_Critere
        '
        Me.Lbl_Critere.AutoSize = True
        Me.Lbl_Critere.Location = New System.Drawing.Point(792, 292)
        Me.Lbl_Critere.Name = "Lbl_Critere"
        Me.Lbl_Critere.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_Critere.TabIndex = 13
        Me.Lbl_Critere.Text = "Critère :"
        '
        'Btn_Qui
        '
        Me.Btn_Qui.Location = New System.Drawing.Point(844, 435)
        Me.Btn_Qui.Name = "Btn_Qui"
        Me.Btn_Qui.Size = New System.Drawing.Size(77, 45)
        Me.Btn_Qui.TabIndex = 14
        Me.Btn_Qui.Text = "Qui ?"
        Me.Btn_Qui.UseVisualStyleBackColor = True
        '
        'Btn_MAJ
        '
        Me.Btn_MAJ.Location = New System.Drawing.Point(344, 222)
        Me.Btn_MAJ.Name = "Btn_MAJ"
        Me.Btn_MAJ.Size = New System.Drawing.Size(131, 38)
        Me.Btn_MAJ.TabIndex = 15
        Me.Btn_MAJ.Text = "Mise à Jour"
        Me.Btn_MAJ.UseVisualStyleBackColor = True
        '
        'Frm_Affichage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 493)
        Me.Controls.Add(Me.Btn_MAJ)
        Me.Controls.Add(Me.Btn_Qui)
        Me.Controls.Add(Me.Lbl_Critere)
        Me.Controls.Add(Me.Txt_Param)
        Me.Controls.Add(Me.Btn_Remplir)
        Me.Controls.Add(Me.DGV_Liste_Projet)
        Me.Controls.Add(Me.Btn_Ajouter_Region)
        Me.Controls.Add(Me.Txt_Ajouter_Region)
        Me.Controls.Add(Me.Lbl_Ajouter_Region)
        Me.Controls.Add(Me.Btn_Remplir_Region)
        Me.Controls.Add(Me.Cb_Regions)
        Me.Controls.Add(Me.Btn_AjouterVille)
        Me.Controls.Add(Me.Txt_AjouterVille)
        Me.Controls.Add(Me.Lbl_AjouterVille)
        Me.Controls.Add(Me.Btn_Remplir_Ville)
        Me.Controls.Add(Me.Cb_Villes)
        Me.Name = "Frm_Affichage"
        Me.Text = "Affichage"
        CType(Me.DGV_Liste_Projet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cb_Villes As System.Windows.Forms.ComboBox
    Friend WithEvents Btn_Remplir_Ville As System.Windows.Forms.Button
    Friend WithEvents Lbl_AjouterVille As System.Windows.Forms.Label
    Friend WithEvents Txt_AjouterVille As System.Windows.Forms.TextBox
    Friend WithEvents Btn_AjouterVille As System.Windows.Forms.Button
    Friend WithEvents Btn_Ajouter_Region As System.Windows.Forms.Button
    Friend WithEvents Txt_Ajouter_Region As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Ajouter_Region As System.Windows.Forms.Label
    Friend WithEvents Btn_Remplir_Region As System.Windows.Forms.Button
    Friend WithEvents Cb_Regions As System.Windows.Forms.ComboBox
    Friend WithEvents DGV_Liste_Projet As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_Remplir As System.Windows.Forms.Button
    Friend WithEvents Txt_Param As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Critere As System.Windows.Forms.Label
    Friend WithEvents Btn_Qui As System.Windows.Forms.Button
    Friend WithEvents Btn_MAJ As System.Windows.Forms.Button
End Class
