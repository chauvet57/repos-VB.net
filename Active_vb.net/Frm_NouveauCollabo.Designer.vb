<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_NouveauCollabo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_NouveauCollabo))
        Me.Btn_Valider = New System.Windows.Forms.Button()
        Me.Txt_Nom = New System.Windows.Forms.TextBox()
        Me.Txt_Prenom = New System.Windows.Forms.TextBox()
        Me.Txt_Numero = New System.Windows.Forms.TextBox()
        Me.Txt_Adresse = New System.Windows.Forms.TextBox()
        Me.Txt_CodePostal = New System.Windows.Forms.TextBox()
        Me.Cbx_Departement = New System.Windows.Forms.ComboBox()
        Me.Cbx_Region = New System.Windows.Forms.ComboBox()
        Me.Cbx_Statut = New System.Windows.Forms.ComboBox()
        Me.Cbx_Fonction = New System.Windows.Forms.ComboBox()
        Me.Dtpick_Embauche = New System.Windows.Forms.DateTimePicker()
        Me.Dtpick_FinContrat = New System.Windows.Forms.DateTimePicker()
        Me.Dtpick_FinFonction = New System.Windows.Forms.DateTimePicker()
        Me.Dtpick_DebutFonction = New System.Windows.Forms.DateTimePicker()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Txt_Salaire = New System.Windows.Forms.TextBox()
        Me.Cbx_Sexe = New System.Windows.Forms.ComboBox()
        Me.Pbx_logo = New System.Windows.Forms.PictureBox()
        Me.Lbl_Contrat = New System.Windows.Forms.Label()
        Me.Lbl_DateEmbauche = New System.Windows.Forms.Label()
        Me.Lbl_DateFinContrat = New System.Windows.Forms.Label()
        Me.Lbl_Fonction = New System.Windows.Forms.Label()
        Me.Lbl_DateDebutFonction = New System.Windows.Forms.Label()
        Me.Lbl_DateFinFonction = New System.Windows.Forms.Label()
        Me.Lbl_Salaire = New System.Windows.Forms.Label()
        Me.Lbl_Adresse = New System.Windows.Forms.Label()
        Me.Lbl_Ville = New System.Windows.Forms.Label()
        Me.Lbl_CodePostal = New System.Windows.Forms.Label()
        Me.Lbl_Departement = New System.Windows.Forms.Label()
        Me.Lbl_Region = New System.Windows.Forms.Label()
        Me.Lbl_Telephone = New System.Windows.Forms.Label()
        Me.Cbx_Ville = New System.Windows.Forms.ComboBox()
        Me.Txt_Telephone = New System.Windows.Forms.MaskedTextBox()
        CType(Me.Pbx_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Valider
        '
        Me.Btn_Valider.BackColor = System.Drawing.Color.LimeGreen
        Me.Btn_Valider.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Btn_Valider.Location = New System.Drawing.Point(846, 543)
        Me.Btn_Valider.Name = "Btn_Valider"
        Me.Btn_Valider.Size = New System.Drawing.Size(151, 55)
        Me.Btn_Valider.TabIndex = 0
        Me.Btn_Valider.Text = "Valider"
        Me.Btn_Valider.UseVisualStyleBackColor = False
        '
        'Txt_Nom
        '
        Me.Txt_Nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Txt_Nom.Location = New System.Drawing.Point(129, 173)
        Me.Txt_Nom.Multiline = True
        Me.Txt_Nom.Name = "Txt_Nom"
        Me.Txt_Nom.Size = New System.Drawing.Size(175, 33)
        Me.Txt_Nom.TabIndex = 2
        Me.Txt_Nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_Prenom
        '
        Me.Txt_Prenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Txt_Prenom.Location = New System.Drawing.Point(310, 173)
        Me.Txt_Prenom.Multiline = True
        Me.Txt_Prenom.Name = "Txt_Prenom"
        Me.Txt_Prenom.Size = New System.Drawing.Size(183, 33)
        Me.Txt_Prenom.TabIndex = 3
        Me.Txt_Prenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_Numero
        '
        Me.Txt_Numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Txt_Numero.Location = New System.Drawing.Point(163, 229)
        Me.Txt_Numero.Multiline = True
        Me.Txt_Numero.Name = "Txt_Numero"
        Me.Txt_Numero.Size = New System.Drawing.Size(54, 32)
        Me.Txt_Numero.TabIndex = 4
        Me.Txt_Numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_Adresse
        '
        Me.Txt_Adresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Txt_Adresse.Location = New System.Drawing.Point(223, 229)
        Me.Txt_Adresse.Multiline = True
        Me.Txt_Adresse.Name = "Txt_Adresse"
        Me.Txt_Adresse.Size = New System.Drawing.Size(270, 32)
        Me.Txt_Adresse.TabIndex = 5
        Me.Txt_Adresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_CodePostal
        '
        Me.Txt_CodePostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Txt_CodePostal.Location = New System.Drawing.Point(163, 293)
        Me.Txt_CodePostal.Multiline = True
        Me.Txt_CodePostal.Name = "Txt_CodePostal"
        Me.Txt_CodePostal.Size = New System.Drawing.Size(192, 33)
        Me.Txt_CodePostal.TabIndex = 7
        Me.Txt_CodePostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cbx_Departement
        '
        Me.Cbx_Departement.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cbx_Departement.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cbx_Departement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbx_Departement.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Cbx_Departement.FormattingEnabled = True
        Me.Cbx_Departement.Location = New System.Drawing.Point(163, 410)
        Me.Cbx_Departement.Name = "Cbx_Departement"
        Me.Cbx_Departement.Size = New System.Drawing.Size(330, 33)
        Me.Cbx_Departement.TabIndex = 8
        '
        'Cbx_Region
        '
        Me.Cbx_Region.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cbx_Region.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cbx_Region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbx_Region.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Cbx_Region.FormattingEnabled = True
        Me.Cbx_Region.Location = New System.Drawing.Point(163, 469)
        Me.Cbx_Region.Name = "Cbx_Region"
        Me.Cbx_Region.Size = New System.Drawing.Size(298, 33)
        Me.Cbx_Region.TabIndex = 9
        '
        'Cbx_Statut
        '
        Me.Cbx_Statut.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cbx_Statut.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cbx_Statut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbx_Statut.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Cbx_Statut.FormattingEnabled = True
        Me.Cbx_Statut.Location = New System.Drawing.Point(669, 33)
        Me.Cbx_Statut.Name = "Cbx_Statut"
        Me.Cbx_Statut.Size = New System.Drawing.Size(148, 33)
        Me.Cbx_Statut.TabIndex = 10
        '
        'Cbx_Fonction
        '
        Me.Cbx_Fonction.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cbx_Fonction.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cbx_Fonction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbx_Fonction.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Cbx_Fonction.FormattingEnabled = True
        Me.Cbx_Fonction.Location = New System.Drawing.Point(669, 245)
        Me.Cbx_Fonction.Name = "Cbx_Fonction"
        Me.Cbx_Fonction.Size = New System.Drawing.Size(309, 33)
        Me.Cbx_Fonction.TabIndex = 11
        '
        'Dtpick_Embauche
        '
        Me.Dtpick_Embauche.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Dtpick_Embauche.Location = New System.Drawing.Point(669, 91)
        Me.Dtpick_Embauche.Name = "Dtpick_Embauche"
        Me.Dtpick_Embauche.Size = New System.Drawing.Size(309, 32)
        Me.Dtpick_Embauche.TabIndex = 12
        '
        'Dtpick_FinContrat
        '
        Me.Dtpick_FinContrat.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Dtpick_FinContrat.Location = New System.Drawing.Point(669, 148)
        Me.Dtpick_FinContrat.Name = "Dtpick_FinContrat"
        Me.Dtpick_FinContrat.Size = New System.Drawing.Size(309, 32)
        Me.Dtpick_FinContrat.TabIndex = 13
        '
        'Dtpick_FinFonction
        '
        Me.Dtpick_FinFonction.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Dtpick_FinFonction.Location = New System.Drawing.Point(669, 368)
        Me.Dtpick_FinFonction.Name = "Dtpick_FinFonction"
        Me.Dtpick_FinFonction.Size = New System.Drawing.Size(309, 32)
        Me.Dtpick_FinFonction.TabIndex = 14
        '
        'Dtpick_DebutFonction
        '
        Me.Dtpick_DebutFonction.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Dtpick_DebutFonction.Location = New System.Drawing.Point(669, 306)
        Me.Dtpick_DebutFonction.Name = "Dtpick_DebutFonction"
        Me.Dtpick_DebutFonction.Size = New System.Drawing.Size(309, 32)
        Me.Dtpick_DebutFonction.TabIndex = 15
        '
        'Txt_Salaire
        '
        Me.Txt_Salaire.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Txt_Salaire.Location = New System.Drawing.Point(669, 441)
        Me.Txt_Salaire.Multiline = True
        Me.Txt_Salaire.Name = "Txt_Salaire"
        Me.Txt_Salaire.Size = New System.Drawing.Size(174, 33)
        Me.Txt_Salaire.TabIndex = 17
        Me.Txt_Salaire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cbx_Sexe
        '
        Me.Cbx_Sexe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cbx_Sexe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cbx_Sexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbx_Sexe.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Cbx_Sexe.FormattingEnabled = True
        Me.Cbx_Sexe.Location = New System.Drawing.Point(49, 173)
        Me.Cbx_Sexe.Name = "Cbx_Sexe"
        Me.Cbx_Sexe.Size = New System.Drawing.Size(74, 33)
        Me.Cbx_Sexe.TabIndex = 18
        '
        'Pbx_logo
        '
        Me.Pbx_logo.BackColor = System.Drawing.Color.Transparent
        Me.Pbx_logo.BackgroundImage = CType(resources.GetObject("Pbx_logo.BackgroundImage"), System.Drawing.Image)
        Me.Pbx_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pbx_logo.ErrorImage = Nothing
        Me.Pbx_logo.Location = New System.Drawing.Point(12, 12)
        Me.Pbx_logo.Name = "Pbx_logo"
        Me.Pbx_logo.Size = New System.Drawing.Size(153, 140)
        Me.Pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pbx_logo.TabIndex = 19
        Me.Pbx_logo.TabStop = False
        '
        'Lbl_Contrat
        '
        Me.Lbl_Contrat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lbl_Contrat.Location = New System.Drawing.Point(499, 35)
        Me.Lbl_Contrat.Name = "Lbl_Contrat"
        Me.Lbl_Contrat.Size = New System.Drawing.Size(170, 30)
        Me.Lbl_Contrat.TabIndex = 20
        Me.Lbl_Contrat.Text = "Type contrat"
        Me.Lbl_Contrat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_DateEmbauche
        '
        Me.Lbl_DateEmbauche.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lbl_DateEmbauche.Location = New System.Drawing.Point(499, 93)
        Me.Lbl_DateEmbauche.Name = "Lbl_DateEmbauche"
        Me.Lbl_DateEmbauche.Size = New System.Drawing.Size(170, 30)
        Me.Lbl_DateEmbauche.TabIndex = 21
        Me.Lbl_DateEmbauche.Text = "Date embauche"
        Me.Lbl_DateEmbauche.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_DateFinContrat
        '
        Me.Lbl_DateFinContrat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lbl_DateFinContrat.Location = New System.Drawing.Point(499, 150)
        Me.Lbl_DateFinContrat.Name = "Lbl_DateFinContrat"
        Me.Lbl_DateFinContrat.Size = New System.Drawing.Size(170, 30)
        Me.Lbl_DateFinContrat.TabIndex = 22
        Me.Lbl_DateFinContrat.Text = "Fin de contrat"
        Me.Lbl_DateFinContrat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Fonction
        '
        Me.Lbl_Fonction.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lbl_Fonction.Location = New System.Drawing.Point(499, 248)
        Me.Lbl_Fonction.Name = "Lbl_Fonction"
        Me.Lbl_Fonction.Size = New System.Drawing.Size(170, 30)
        Me.Lbl_Fonction.TabIndex = 23
        Me.Lbl_Fonction.Text = "Fonction"
        Me.Lbl_Fonction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_DateDebutFonction
        '
        Me.Lbl_DateDebutFonction.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lbl_DateDebutFonction.Location = New System.Drawing.Point(473, 310)
        Me.Lbl_DateDebutFonction.Name = "Lbl_DateDebutFonction"
        Me.Lbl_DateDebutFonction.Size = New System.Drawing.Size(196, 30)
        Me.Lbl_DateDebutFonction.TabIndex = 24
        Me.Lbl_DateDebutFonction.Text = "Date prise de fonction"
        Me.Lbl_DateDebutFonction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_DateFinFonction
        '
        Me.Lbl_DateFinFonction.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lbl_DateFinFonction.Location = New System.Drawing.Point(477, 368)
        Me.Lbl_DateFinFonction.Name = "Lbl_DateFinFonction"
        Me.Lbl_DateFinFonction.Size = New System.Drawing.Size(192, 30)
        Me.Lbl_DateFinFonction.TabIndex = 25
        Me.Lbl_DateFinFonction.Text = "Date fin fonction"
        Me.Lbl_DateFinFonction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Salaire
        '
        Me.Lbl_Salaire.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lbl_Salaire.Location = New System.Drawing.Point(499, 444)
        Me.Lbl_Salaire.Name = "Lbl_Salaire"
        Me.Lbl_Salaire.Size = New System.Drawing.Size(170, 30)
        Me.Lbl_Salaire.TabIndex = 26
        Me.Lbl_Salaire.Text = "Salaire "
        Me.Lbl_Salaire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Adresse
        '
        Me.Lbl_Adresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lbl_Adresse.Location = New System.Drawing.Point(3, 231)
        Me.Lbl_Adresse.Name = "Lbl_Adresse"
        Me.Lbl_Adresse.Size = New System.Drawing.Size(162, 30)
        Me.Lbl_Adresse.TabIndex = 27
        Me.Lbl_Adresse.Text = "Adresse"
        Me.Lbl_Adresse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Ville
        '
        Me.Lbl_Ville.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lbl_Ville.Location = New System.Drawing.Point(3, 352)
        Me.Lbl_Ville.Name = "Lbl_Ville"
        Me.Lbl_Ville.Size = New System.Drawing.Size(162, 30)
        Me.Lbl_Ville.TabIndex = 28
        Me.Lbl_Ville.Text = "Ville"
        Me.Lbl_Ville.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_CodePostal
        '
        Me.Lbl_CodePostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lbl_CodePostal.Location = New System.Drawing.Point(3, 295)
        Me.Lbl_CodePostal.Name = "Lbl_CodePostal"
        Me.Lbl_CodePostal.Size = New System.Drawing.Size(162, 30)
        Me.Lbl_CodePostal.TabIndex = 29
        Me.Lbl_CodePostal.Text = "Code postal"
        Me.Lbl_CodePostal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Departement
        '
        Me.Lbl_Departement.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lbl_Departement.Location = New System.Drawing.Point(3, 413)
        Me.Lbl_Departement.Name = "Lbl_Departement"
        Me.Lbl_Departement.Size = New System.Drawing.Size(162, 30)
        Me.Lbl_Departement.TabIndex = 30
        Me.Lbl_Departement.Text = "Département"
        Me.Lbl_Departement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Region
        '
        Me.Lbl_Region.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lbl_Region.Location = New System.Drawing.Point(3, 472)
        Me.Lbl_Region.Name = "Lbl_Region"
        Me.Lbl_Region.Size = New System.Drawing.Size(162, 30)
        Me.Lbl_Region.TabIndex = 31
        Me.Lbl_Region.Text = "Région"
        Me.Lbl_Region.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Telephone
        '
        Me.Lbl_Telephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lbl_Telephone.Location = New System.Drawing.Point(3, 533)
        Me.Lbl_Telephone.Name = "Lbl_Telephone"
        Me.Lbl_Telephone.Size = New System.Drawing.Size(162, 30)
        Me.Lbl_Telephone.TabIndex = 32
        Me.Lbl_Telephone.Text = "Téléphone"
        Me.Lbl_Telephone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cbx_Ville
        '
        Me.Cbx_Ville.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbx_Ville.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Cbx_Ville.FormattingEnabled = True
        Me.Cbx_Ville.Location = New System.Drawing.Point(163, 352)
        Me.Cbx_Ville.Name = "Cbx_Ville"
        Me.Cbx_Ville.Size = New System.Drawing.Size(298, 33)
        Me.Cbx_Ville.TabIndex = 33
        '
        'Txt_Telephone
        '
        Me.Txt_Telephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Txt_Telephone.Location = New System.Drawing.Point(163, 531)
        Me.Txt_Telephone.Mask = "00-00-00-00-00"
        Me.Txt_Telephone.Name = "Txt_Telephone"
        Me.Txt_Telephone.Size = New System.Drawing.Size(274, 32)
        Me.Txt_Telephone.TabIndex = 34
        Me.Txt_Telephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Frm_NouveauCollabo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1009, 619)
        Me.Controls.Add(Me.Txt_Telephone)
        Me.Controls.Add(Me.Cbx_Ville)
        Me.Controls.Add(Me.Lbl_Telephone)
        Me.Controls.Add(Me.Lbl_Region)
        Me.Controls.Add(Me.Lbl_Departement)
        Me.Controls.Add(Me.Lbl_CodePostal)
        Me.Controls.Add(Me.Lbl_Ville)
        Me.Controls.Add(Me.Lbl_Adresse)
        Me.Controls.Add(Me.Lbl_Salaire)
        Me.Controls.Add(Me.Lbl_DateFinFonction)
        Me.Controls.Add(Me.Lbl_DateDebutFonction)
        Me.Controls.Add(Me.Lbl_Fonction)
        Me.Controls.Add(Me.Lbl_DateFinContrat)
        Me.Controls.Add(Me.Lbl_DateEmbauche)
        Me.Controls.Add(Me.Lbl_Contrat)
        Me.Controls.Add(Me.Pbx_logo)
        Me.Controls.Add(Me.Cbx_Sexe)
        Me.Controls.Add(Me.Txt_Salaire)
        Me.Controls.Add(Me.Dtpick_DebutFonction)
        Me.Controls.Add(Me.Dtpick_FinFonction)
        Me.Controls.Add(Me.Dtpick_FinContrat)
        Me.Controls.Add(Me.Dtpick_Embauche)
        Me.Controls.Add(Me.Cbx_Fonction)
        Me.Controls.Add(Me.Cbx_Statut)
        Me.Controls.Add(Me.Cbx_Region)
        Me.Controls.Add(Me.Cbx_Departement)
        Me.Controls.Add(Me.Txt_CodePostal)
        Me.Controls.Add(Me.Txt_Adresse)
        Me.Controls.Add(Me.Txt_Numero)
        Me.Controls.Add(Me.Txt_Prenom)
        Me.Controls.Add(Me.Txt_Nom)
        Me.Controls.Add(Me.Btn_Valider)
        Me.Name = "Frm_NouveauCollabo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nouveau Collaborateur"
        CType(Me.Pbx_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Valider As Button
    Friend WithEvents Txt_Nom As TextBox
    Friend WithEvents Txt_Prenom As TextBox
    Friend WithEvents Txt_Numero As TextBox
    Friend WithEvents Txt_Adresse As TextBox
    Friend WithEvents Txt_CodePostal As TextBox
    Friend WithEvents Cbx_Departement As ComboBox
    Friend WithEvents Cbx_Region As ComboBox
    Friend WithEvents Cbx_Statut As ComboBox
    Friend WithEvents Cbx_Fonction As ComboBox
    Friend WithEvents Dtpick_Embauche As DateTimePicker
    Friend WithEvents Dtpick_FinContrat As DateTimePicker
    Friend WithEvents Dtpick_FinFonction As DateTimePicker
    Friend WithEvents Dtpick_DebutFonction As DateTimePicker
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Txt_Salaire As TextBox
    Friend WithEvents Cbx_Sexe As ComboBox
    Friend WithEvents Pbx_logo As PictureBox
    Friend WithEvents Lbl_Contrat As Label
    Friend WithEvents Lbl_DateEmbauche As Label
    Friend WithEvents Lbl_DateFinContrat As Label
    Friend WithEvents Lbl_Fonction As Label
    Friend WithEvents Lbl_DateDebutFonction As Label
    Friend WithEvents Lbl_DateFinFonction As Label
    Friend WithEvents Lbl_Salaire As Label
    Friend WithEvents Lbl_Adresse As Label
    Friend WithEvents Lbl_Ville As Label
    Friend WithEvents Lbl_CodePostal As Label
    Friend WithEvents Lbl_Departement As Label
    Friend WithEvents Lbl_Region As Label
    Friend WithEvents Lbl_Telephone As Label
    Friend WithEvents Cbx_Ville As ComboBox
    Friend WithEvents Txt_Telephone As MaskedTextBox
End Class
