<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_FicheCollabo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_FicheCollabo))
        Me.Lbl_Telephone = New System.Windows.Forms.Label()
        Me.Lbl_Region = New System.Windows.Forms.Label()
        Me.Lbl_Departement = New System.Windows.Forms.Label()
        Me.Lbl_CodePostal = New System.Windows.Forms.Label()
        Me.Lbl_Ville = New System.Windows.Forms.Label()
        Me.Lbl_Adresse = New System.Windows.Forms.Label()
        Me.Lbl_Salaire = New System.Windows.Forms.Label()
        Me.Lbl_DateFinFonction = New System.Windows.Forms.Label()
        Me.Lbl_DateDebutFonction = New System.Windows.Forms.Label()
        Me.Lbl_Fonction = New System.Windows.Forms.Label()
        Me.Lbl_DateFinContrat = New System.Windows.Forms.Label()
        Me.Lbl_DateEmbauche = New System.Windows.Forms.Label()
        Me.Lbl_Contrat = New System.Windows.Forms.Label()
        Me.Pbx_logo = New System.Windows.Forms.PictureBox()
        Me.Cbx_Sexe = New System.Windows.Forms.ComboBox()
        Me.Txt_Salaire = New System.Windows.Forms.TextBox()
        Me.Dtpick_DebutFonction = New System.Windows.Forms.DateTimePicker()
        Me.Dtpick_FinFonction = New System.Windows.Forms.DateTimePicker()
        Me.Dtpick_FinContrat = New System.Windows.Forms.DateTimePicker()
        Me.Dtpick_Embauche = New System.Windows.Forms.DateTimePicker()
        Me.Cbx_Fonction = New System.Windows.Forms.ComboBox()
        Me.Cbx_Statut = New System.Windows.Forms.ComboBox()
        Me.Cbx_Region = New System.Windows.Forms.ComboBox()
        Me.Cbx_Departement = New System.Windows.Forms.ComboBox()
        Me.Txt_CodePostal = New System.Windows.Forms.TextBox()
        Me.Txt_Adresse = New System.Windows.Forms.TextBox()
        Me.Txt_Numero = New System.Windows.Forms.TextBox()
        Me.Txt_Prenom = New System.Windows.Forms.TextBox()
        Me.Txt_Nom = New System.Windows.Forms.TextBox()
        Me.Btn_Modifier = New System.Windows.Forms.Button()
        Me.Btn_Quitter = New System.Windows.Forms.Button()
        Me.Txt_Matricule = New System.Windows.Forms.TextBox()
        Me.Lbl_Matricule = New System.Windows.Forms.Label()
        Me.Cbx_Ville = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Txt_Telephone = New System.Windows.Forms.MaskedTextBox()
        CType(Me.Pbx_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_Telephone
        '
        Me.Lbl_Telephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lbl_Telephone.Location = New System.Drawing.Point(7, 534)
        Me.Lbl_Telephone.Name = "Lbl_Telephone"
        Me.Lbl_Telephone.Size = New System.Drawing.Size(162, 30)
        Me.Lbl_Telephone.TabIndex = 64
        Me.Lbl_Telephone.Text = "Téléphone"
        Me.Lbl_Telephone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Region
        '
        Me.Lbl_Region.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lbl_Region.Location = New System.Drawing.Point(7, 473)
        Me.Lbl_Region.Name = "Lbl_Region"
        Me.Lbl_Region.Size = New System.Drawing.Size(162, 30)
        Me.Lbl_Region.TabIndex = 63
        Me.Lbl_Region.Text = "Région"
        Me.Lbl_Region.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Departement
        '
        Me.Lbl_Departement.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lbl_Departement.Location = New System.Drawing.Point(7, 414)
        Me.Lbl_Departement.Name = "Lbl_Departement"
        Me.Lbl_Departement.Size = New System.Drawing.Size(162, 30)
        Me.Lbl_Departement.TabIndex = 62
        Me.Lbl_Departement.Text = "Département"
        Me.Lbl_Departement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_CodePostal
        '
        Me.Lbl_CodePostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lbl_CodePostal.Location = New System.Drawing.Point(7, 293)
        Me.Lbl_CodePostal.Name = "Lbl_CodePostal"
        Me.Lbl_CodePostal.Size = New System.Drawing.Size(162, 30)
        Me.Lbl_CodePostal.TabIndex = 61
        Me.Lbl_CodePostal.Text = "Code postal"
        Me.Lbl_CodePostal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Ville
        '
        Me.Lbl_Ville.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lbl_Ville.Location = New System.Drawing.Point(7, 355)
        Me.Lbl_Ville.Name = "Lbl_Ville"
        Me.Lbl_Ville.Size = New System.Drawing.Size(162, 30)
        Me.Lbl_Ville.TabIndex = 60
        Me.Lbl_Ville.Text = "Ville"
        Me.Lbl_Ville.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Adresse
        '
        Me.Lbl_Adresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lbl_Adresse.Location = New System.Drawing.Point(7, 232)
        Me.Lbl_Adresse.Name = "Lbl_Adresse"
        Me.Lbl_Adresse.Size = New System.Drawing.Size(162, 30)
        Me.Lbl_Adresse.TabIndex = 59
        Me.Lbl_Adresse.Text = "Adresse"
        Me.Lbl_Adresse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Salaire
        '
        Me.Lbl_Salaire.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lbl_Salaire.Location = New System.Drawing.Point(503, 445)
        Me.Lbl_Salaire.Name = "Lbl_Salaire"
        Me.Lbl_Salaire.Size = New System.Drawing.Size(170, 30)
        Me.Lbl_Salaire.TabIndex = 58
        Me.Lbl_Salaire.Text = "Salaire "
        Me.Lbl_Salaire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_DateFinFonction
        '
        Me.Lbl_DateFinFonction.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lbl_DateFinFonction.Location = New System.Drawing.Point(481, 369)
        Me.Lbl_DateFinFonction.Name = "Lbl_DateFinFonction"
        Me.Lbl_DateFinFonction.Size = New System.Drawing.Size(192, 30)
        Me.Lbl_DateFinFonction.TabIndex = 57
        Me.Lbl_DateFinFonction.Text = "Date fin fonction"
        Me.Lbl_DateFinFonction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_DateDebutFonction
        '
        Me.Lbl_DateDebutFonction.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lbl_DateDebutFonction.Location = New System.Drawing.Point(477, 311)
        Me.Lbl_DateDebutFonction.Name = "Lbl_DateDebutFonction"
        Me.Lbl_DateDebutFonction.Size = New System.Drawing.Size(196, 30)
        Me.Lbl_DateDebutFonction.TabIndex = 56
        Me.Lbl_DateDebutFonction.Text = "Date prise de fonction"
        Me.Lbl_DateDebutFonction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Fonction
        '
        Me.Lbl_Fonction.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lbl_Fonction.Location = New System.Drawing.Point(503, 249)
        Me.Lbl_Fonction.Name = "Lbl_Fonction"
        Me.Lbl_Fonction.Size = New System.Drawing.Size(170, 30)
        Me.Lbl_Fonction.TabIndex = 55
        Me.Lbl_Fonction.Text = "Fonction"
        Me.Lbl_Fonction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_DateFinContrat
        '
        Me.Lbl_DateFinContrat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lbl_DateFinContrat.Location = New System.Drawing.Point(503, 151)
        Me.Lbl_DateFinContrat.Name = "Lbl_DateFinContrat"
        Me.Lbl_DateFinContrat.Size = New System.Drawing.Size(170, 30)
        Me.Lbl_DateFinContrat.TabIndex = 54
        Me.Lbl_DateFinContrat.Text = "Fin de contrat"
        Me.Lbl_DateFinContrat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_DateEmbauche
        '
        Me.Lbl_DateEmbauche.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lbl_DateEmbauche.Location = New System.Drawing.Point(503, 94)
        Me.Lbl_DateEmbauche.Name = "Lbl_DateEmbauche"
        Me.Lbl_DateEmbauche.Size = New System.Drawing.Size(170, 30)
        Me.Lbl_DateEmbauche.TabIndex = 53
        Me.Lbl_DateEmbauche.Text = "Date embauche"
        Me.Lbl_DateEmbauche.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Contrat
        '
        Me.Lbl_Contrat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lbl_Contrat.Location = New System.Drawing.Point(503, 36)
        Me.Lbl_Contrat.Name = "Lbl_Contrat"
        Me.Lbl_Contrat.Size = New System.Drawing.Size(170, 30)
        Me.Lbl_Contrat.TabIndex = 52
        Me.Lbl_Contrat.Text = "Type contrat"
        Me.Lbl_Contrat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pbx_logo
        '
        Me.Pbx_logo.BackColor = System.Drawing.Color.Transparent
        Me.Pbx_logo.BackgroundImage = CType(resources.GetObject("Pbx_logo.BackgroundImage"), System.Drawing.Image)
        Me.Pbx_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pbx_logo.ErrorImage = Nothing
        Me.Pbx_logo.Location = New System.Drawing.Point(16, 13)
        Me.Pbx_logo.Name = "Pbx_logo"
        Me.Pbx_logo.Size = New System.Drawing.Size(153, 140)
        Me.Pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pbx_logo.TabIndex = 51
        Me.Pbx_logo.TabStop = False
        '
        'Cbx_Sexe
        '
        Me.Cbx_Sexe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cbx_Sexe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cbx_Sexe.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Cbx_Sexe.FormattingEnabled = True
        Me.Cbx_Sexe.Location = New System.Drawing.Point(53, 174)
        Me.Cbx_Sexe.Name = "Cbx_Sexe"
        Me.Cbx_Sexe.Size = New System.Drawing.Size(74, 33)
        Me.Cbx_Sexe.TabIndex = 50
        '
        'Txt_Salaire
        '
        Me.Txt_Salaire.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Txt_Salaire.Location = New System.Drawing.Point(673, 442)
        Me.Txt_Salaire.Multiline = True
        Me.Txt_Salaire.Name = "Txt_Salaire"
        Me.Txt_Salaire.Size = New System.Drawing.Size(174, 33)
        Me.Txt_Salaire.TabIndex = 49
        Me.Txt_Salaire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Dtpick_DebutFonction
        '
        Me.Dtpick_DebutFonction.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Dtpick_DebutFonction.Location = New System.Drawing.Point(673, 307)
        Me.Dtpick_DebutFonction.Name = "Dtpick_DebutFonction"
        Me.Dtpick_DebutFonction.Size = New System.Drawing.Size(309, 32)
        Me.Dtpick_DebutFonction.TabIndex = 47
        '
        'Dtpick_FinFonction
        '
        Me.Dtpick_FinFonction.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Dtpick_FinFonction.Location = New System.Drawing.Point(673, 369)
        Me.Dtpick_FinFonction.Name = "Dtpick_FinFonction"
        Me.Dtpick_FinFonction.Size = New System.Drawing.Size(309, 32)
        Me.Dtpick_FinFonction.TabIndex = 46
        '
        'Dtpick_FinContrat
        '
        Me.Dtpick_FinContrat.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Dtpick_FinContrat.Location = New System.Drawing.Point(673, 149)
        Me.Dtpick_FinContrat.Name = "Dtpick_FinContrat"
        Me.Dtpick_FinContrat.Size = New System.Drawing.Size(309, 32)
        Me.Dtpick_FinContrat.TabIndex = 45
        '
        'Dtpick_Embauche
        '
        Me.Dtpick_Embauche.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Dtpick_Embauche.Location = New System.Drawing.Point(673, 92)
        Me.Dtpick_Embauche.Name = "Dtpick_Embauche"
        Me.Dtpick_Embauche.Size = New System.Drawing.Size(309, 32)
        Me.Dtpick_Embauche.TabIndex = 44
        '
        'Cbx_Fonction
        '
        Me.Cbx_Fonction.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cbx_Fonction.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cbx_Fonction.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Cbx_Fonction.FormattingEnabled = True
        Me.Cbx_Fonction.Location = New System.Drawing.Point(673, 246)
        Me.Cbx_Fonction.Name = "Cbx_Fonction"
        Me.Cbx_Fonction.Size = New System.Drawing.Size(309, 33)
        Me.Cbx_Fonction.TabIndex = 43
        '
        'Cbx_Statut
        '
        Me.Cbx_Statut.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cbx_Statut.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cbx_Statut.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Cbx_Statut.FormattingEnabled = True
        Me.Cbx_Statut.Location = New System.Drawing.Point(673, 34)
        Me.Cbx_Statut.Name = "Cbx_Statut"
        Me.Cbx_Statut.Size = New System.Drawing.Size(148, 33)
        Me.Cbx_Statut.TabIndex = 42
        '
        'Cbx_Region
        '
        Me.Cbx_Region.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cbx_Region.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cbx_Region.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Cbx_Region.FormattingEnabled = True
        Me.Cbx_Region.Location = New System.Drawing.Point(167, 470)
        Me.Cbx_Region.Name = "Cbx_Region"
        Me.Cbx_Region.Size = New System.Drawing.Size(298, 33)
        Me.Cbx_Region.TabIndex = 41
        '
        'Cbx_Departement
        '
        Me.Cbx_Departement.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cbx_Departement.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cbx_Departement.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Cbx_Departement.FormattingEnabled = True
        Me.Cbx_Departement.Location = New System.Drawing.Point(167, 411)
        Me.Cbx_Departement.Name = "Cbx_Departement"
        Me.Cbx_Departement.Size = New System.Drawing.Size(330, 33)
        Me.Cbx_Departement.TabIndex = 40
        '
        'Txt_CodePostal
        '
        Me.Txt_CodePostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Txt_CodePostal.Location = New System.Drawing.Point(167, 292)
        Me.Txt_CodePostal.Multiline = True
        Me.Txt_CodePostal.Name = "Txt_CodePostal"
        Me.Txt_CodePostal.Size = New System.Drawing.Size(176, 33)
        Me.Txt_CodePostal.TabIndex = 39
        Me.Txt_CodePostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_Adresse
        '
        Me.Txt_Adresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Txt_Adresse.Location = New System.Drawing.Point(227, 230)
        Me.Txt_Adresse.Multiline = True
        Me.Txt_Adresse.Name = "Txt_Adresse"
        Me.Txt_Adresse.Size = New System.Drawing.Size(270, 32)
        Me.Txt_Adresse.TabIndex = 37
        Me.Txt_Adresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_Numero
        '
        Me.Txt_Numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Txt_Numero.Location = New System.Drawing.Point(167, 230)
        Me.Txt_Numero.Multiline = True
        Me.Txt_Numero.Name = "Txt_Numero"
        Me.Txt_Numero.Size = New System.Drawing.Size(54, 32)
        Me.Txt_Numero.TabIndex = 36
        Me.Txt_Numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_Prenom
        '
        Me.Txt_Prenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Txt_Prenom.Location = New System.Drawing.Point(314, 174)
        Me.Txt_Prenom.Multiline = True
        Me.Txt_Prenom.Name = "Txt_Prenom"
        Me.Txt_Prenom.Size = New System.Drawing.Size(183, 33)
        Me.Txt_Prenom.TabIndex = 35
        Me.Txt_Prenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_Nom
        '
        Me.Txt_Nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Txt_Nom.Location = New System.Drawing.Point(133, 174)
        Me.Txt_Nom.Multiline = True
        Me.Txt_Nom.Name = "Txt_Nom"
        Me.Txt_Nom.Size = New System.Drawing.Size(175, 33)
        Me.Txt_Nom.TabIndex = 34
        Me.Txt_Nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btn_Modifier
        '
        Me.Btn_Modifier.BackColor = System.Drawing.Color.DarkOrange
        Me.Btn_Modifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Btn_Modifier.Location = New System.Drawing.Point(507, 552)
        Me.Btn_Modifier.Name = "Btn_Modifier"
        Me.Btn_Modifier.Size = New System.Drawing.Size(155, 55)
        Me.Btn_Modifier.TabIndex = 33
        Me.Btn_Modifier.Text = "Modifier"
        Me.Btn_Modifier.UseVisualStyleBackColor = False
        '
        'Btn_Quitter
        '
        Me.Btn_Quitter.BackColor = System.Drawing.Color.RoyalBlue
        Me.Btn_Quitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Btn_Quitter.Location = New System.Drawing.Point(842, 552)
        Me.Btn_Quitter.Name = "Btn_Quitter"
        Me.Btn_Quitter.Size = New System.Drawing.Size(155, 55)
        Me.Btn_Quitter.TabIndex = 65
        Me.Btn_Quitter.Text = "Retour"
        Me.Btn_Quitter.UseVisualStyleBackColor = False
        '
        'Txt_Matricule
        '
        Me.Txt_Matricule.Enabled = False
        Me.Txt_Matricule.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Txt_Matricule.Location = New System.Drawing.Point(344, 66)
        Me.Txt_Matricule.Multiline = True
        Me.Txt_Matricule.Name = "Txt_Matricule"
        Me.Txt_Matricule.Size = New System.Drawing.Size(142, 33)
        Me.Txt_Matricule.TabIndex = 66
        Me.Txt_Matricule.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lbl_Matricule
        '
        Me.Lbl_Matricule.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Lbl_Matricule.Location = New System.Drawing.Point(194, 67)
        Me.Lbl_Matricule.Name = "Lbl_Matricule"
        Me.Lbl_Matricule.Size = New System.Drawing.Size(149, 30)
        Me.Lbl_Matricule.TabIndex = 67
        Me.Lbl_Matricule.Text = "Matricule"
        Me.Lbl_Matricule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cbx_Ville
        '
        Me.Cbx_Ville.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Cbx_Ville.FormattingEnabled = True
        Me.Cbx_Ville.Location = New System.Drawing.Point(167, 354)
        Me.Cbx_Ville.Name = "Cbx_Ville"
        Me.Cbx_Ville.Size = New System.Drawing.Size(298, 33)
        Me.Cbx_Ville.TabIndex = 68
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Button1.Location = New System.Drawing.Point(673, 552)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 55)
        Me.Button1.TabIndex = 69
        Me.Button1.Text = "Achiver"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Txt_Telephone
        '
        Me.Txt_Telephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Txt_Telephone.Location = New System.Drawing.Point(167, 532)
        Me.Txt_Telephone.Mask = "00-00-00-00-00"
        Me.Txt_Telephone.Name = "Txt_Telephone"
        Me.Txt_Telephone.Size = New System.Drawing.Size(274, 32)
        Me.Txt_Telephone.TabIndex = 70
        Me.Txt_Telephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Frm_FicheCollabo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1009, 619)
        Me.Controls.Add(Me.Txt_Telephone)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Cbx_Ville)
        Me.Controls.Add(Me.Lbl_Matricule)
        Me.Controls.Add(Me.Txt_Matricule)
        Me.Controls.Add(Me.Btn_Quitter)
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
        Me.Controls.Add(Me.Btn_Modifier)
        Me.Name = "Frm_FicheCollabo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fiche Collaborateur"
        CType(Me.Pbx_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Telephone As Label
    Friend WithEvents Lbl_Region As Label
    Friend WithEvents Lbl_Departement As Label
    Friend WithEvents Lbl_CodePostal As Label
    Friend WithEvents Lbl_Ville As Label
    Friend WithEvents Lbl_Adresse As Label
    Friend WithEvents Lbl_Salaire As Label
    Friend WithEvents Lbl_DateFinFonction As Label
    Friend WithEvents Lbl_DateDebutFonction As Label
    Friend WithEvents Lbl_Fonction As Label
    Friend WithEvents Lbl_DateFinContrat As Label
    Friend WithEvents Lbl_DateEmbauche As Label
    Friend WithEvents Lbl_Contrat As Label
    Friend WithEvents Pbx_logo As PictureBox
    Friend WithEvents Cbx_Sexe As ComboBox
    Friend WithEvents Txt_Salaire As TextBox
    Friend WithEvents Dtpick_DebutFonction As DateTimePicker
    Friend WithEvents Dtpick_FinFonction As DateTimePicker
    Friend WithEvents Dtpick_FinContrat As DateTimePicker
    Friend WithEvents Dtpick_Embauche As DateTimePicker
    Friend WithEvents Cbx_Fonction As ComboBox
    Friend WithEvents Cbx_Statut As ComboBox
    Friend WithEvents Cbx_Region As ComboBox
    Friend WithEvents Cbx_Departement As ComboBox
    Friend WithEvents Txt_CodePostal As TextBox
    Friend WithEvents Txt_Adresse As TextBox
    Friend WithEvents Txt_Numero As TextBox
    Friend WithEvents Txt_Prenom As TextBox
    Friend WithEvents Txt_Nom As TextBox
    Friend WithEvents Btn_Modifier As Button
    Friend WithEvents Btn_Quitter As Button
    Friend WithEvents Txt_Matricule As TextBox
    Friend WithEvents Lbl_Matricule As Label
    Friend WithEvents Cbx_Ville As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Txt_Telephone As MaskedTextBox
End Class
