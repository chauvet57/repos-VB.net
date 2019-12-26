<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Collaborateur
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Collaborateur))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Pbx_logo = New System.Windows.Forms.PictureBox()
        Me.Dgv_ListeCollabo = New System.Windows.Forms.DataGridView()
        Me.STRLIBCOURTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STRNOMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STRPRENOMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STRCODESTATUTCOLLABODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STRCODEFONCTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITELEPHONECOLLABODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STREMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSCDListeCollaboInnerRapportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjetActiveDataSet = New Active.ProjetActiveDataSet()
        Me.PS_CD_ListeCollabo_InnerRapportTableAdapter = New Active.ProjetActiveDataSetTableAdapters.PS_CD_ListeCollabo_InnerRapportTableAdapter()
        Me.Btn_NewCollabo = New System.Windows.Forms.Button()
        Me.Btn_ListeCollabo = New System.Windows.Forms.Button()
        Me.Txt_RechercheNom = New System.Windows.Forms.TextBox()
        Me.Lbl_Recherche = New System.Windows.Forms.Label()
        Me.Txt_RechercheStatut = New System.Windows.Forms.TextBox()
        Me.Txt_RechercheFonction = New System.Windows.Forms.TextBox()
        Me.Lbl_RechercheStatut = New System.Windows.Forms.Label()
        Me.Lbl_RechercheFonction = New System.Windows.Forms.Label()
        Me.Lbl_RechercheNom = New System.Windows.Forms.Label()
        Me.Btn_Retour = New System.Windows.Forms.Button()
        CType(Me.Pbx_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_ListeCollabo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSCDListeCollaboInnerRapportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjetActiveDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pbx_logo
        '
        Me.Pbx_logo.BackColor = System.Drawing.Color.Transparent
        Me.Pbx_logo.BackgroundImage = CType(resources.GetObject("Pbx_logo.BackgroundImage"), System.Drawing.Image)
        Me.Pbx_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pbx_logo.ErrorImage = Nothing
        Me.Pbx_logo.Location = New System.Drawing.Point(26, 12)
        Me.Pbx_logo.Name = "Pbx_logo"
        Me.Pbx_logo.Size = New System.Drawing.Size(160, 135)
        Me.Pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pbx_logo.TabIndex = 6
        Me.Pbx_logo.TabStop = False
        '
        'Dgv_ListeCollabo
        '
        Me.Dgv_ListeCollabo.AllowUserToAddRows = False
        Me.Dgv_ListeCollabo.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Dgv_ListeCollabo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_ListeCollabo.AutoGenerateColumns = False
        Me.Dgv_ListeCollabo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv_ListeCollabo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.Dgv_ListeCollabo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dgv_ListeCollabo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.Dgv_ListeCollabo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.Dgv_ListeCollabo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_ListeCollabo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv_ListeCollabo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ListeCollabo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STRLIBCOURTDataGridViewTextBoxColumn, Me.STRNOMDataGridViewTextBoxColumn, Me.STRPRENOMDataGridViewTextBoxColumn, Me.STRCODESTATUTCOLLABODataGridViewTextBoxColumn, Me.STRCODEFONCTIONDataGridViewTextBoxColumn, Me.ITELEPHONECOLLABODataGridViewTextBoxColumn, Me.STREMAILDataGridViewTextBoxColumn, Me.Id})
        Me.Dgv_ListeCollabo.DataSource = Me.PSCDListeCollaboInnerRapportBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv_ListeCollabo.DefaultCellStyle = DataGridViewCellStyle4
        Me.Dgv_ListeCollabo.EnableHeadersVisualStyles = False
        Me.Dgv_ListeCollabo.Location = New System.Drawing.Point(26, 163)
        Me.Dgv_ListeCollabo.Name = "Dgv_ListeCollabo"
        Me.Dgv_ListeCollabo.ReadOnly = True
        Me.Dgv_ListeCollabo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.Dgv_ListeCollabo.RowHeadersWidth = 50
        Me.Dgv_ListeCollabo.Size = New System.Drawing.Size(1570, 542)
        Me.Dgv_ListeCollabo.TabIndex = 7
        '
        'STRLIBCOURTDataGridViewTextBoxColumn
        '
        Me.STRLIBCOURTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.STRLIBCOURTDataGridViewTextBoxColumn.DataPropertyName = "STR_LIB_COURT"
        Me.STRLIBCOURTDataGridViewTextBoxColumn.FillWeight = 34.01305!
        Me.STRLIBCOURTDataGridViewTextBoxColumn.HeaderText = "Sexe"
        Me.STRLIBCOURTDataGridViewTextBoxColumn.Name = "STRLIBCOURTDataGridViewTextBoxColumn"
        Me.STRLIBCOURTDataGridViewTextBoxColumn.ReadOnly = True
        Me.STRLIBCOURTDataGridViewTextBoxColumn.Width = 66
        '
        'STRNOMDataGridViewTextBoxColumn
        '
        Me.STRNOMDataGridViewTextBoxColumn.DataPropertyName = "STR_NOM"
        Me.STRNOMDataGridViewTextBoxColumn.FillWeight = 106.0074!
        Me.STRNOMDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.STRNOMDataGridViewTextBoxColumn.Name = "STRNOMDataGridViewTextBoxColumn"
        Me.STRNOMDataGridViewTextBoxColumn.ReadOnly = True
        '
        'STRPRENOMDataGridViewTextBoxColumn
        '
        Me.STRPRENOMDataGridViewTextBoxColumn.DataPropertyName = "STR_PRENOM"
        Me.STRPRENOMDataGridViewTextBoxColumn.FillWeight = 106.0074!
        Me.STRPRENOMDataGridViewTextBoxColumn.HeaderText = "Prénom"
        Me.STRPRENOMDataGridViewTextBoxColumn.Name = "STRPRENOMDataGridViewTextBoxColumn"
        Me.STRPRENOMDataGridViewTextBoxColumn.ReadOnly = True
        '
        'STRCODESTATUTCOLLABODataGridViewTextBoxColumn
        '
        Me.STRCODESTATUTCOLLABODataGridViewTextBoxColumn.DataPropertyName = "STR_CODESTATUTCOLLABO"
        Me.STRCODESTATUTCOLLABODataGridViewTextBoxColumn.FillWeight = 55.75653!
        Me.STRCODESTATUTCOLLABODataGridViewTextBoxColumn.HeaderText = "Contrat"
        Me.STRCODESTATUTCOLLABODataGridViewTextBoxColumn.Name = "STRCODESTATUTCOLLABODataGridViewTextBoxColumn"
        Me.STRCODESTATUTCOLLABODataGridViewTextBoxColumn.ReadOnly = True
        '
        'STRCODEFONCTIONDataGridViewTextBoxColumn
        '
        Me.STRCODEFONCTIONDataGridViewTextBoxColumn.DataPropertyName = "STR_CODEFONCTION"
        Me.STRCODEFONCTIONDataGridViewTextBoxColumn.FillWeight = 159.5571!
        Me.STRCODEFONCTIONDataGridViewTextBoxColumn.HeaderText = "Fonction"
        Me.STRCODEFONCTIONDataGridViewTextBoxColumn.Name = "STRCODEFONCTIONDataGridViewTextBoxColumn"
        Me.STRCODEFONCTIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ITELEPHONECOLLABODataGridViewTextBoxColumn
        '
        Me.ITELEPHONECOLLABODataGridViewTextBoxColumn.DataPropertyName = "I_TELEPHONE_COLLABO"
        Me.ITELEPHONECOLLABODataGridViewTextBoxColumn.FillWeight = 106.0074!
        Me.ITELEPHONECOLLABODataGridViewTextBoxColumn.HeaderText = "Téléphone"
        Me.ITELEPHONECOLLABODataGridViewTextBoxColumn.Name = "ITELEPHONECOLLABODataGridViewTextBoxColumn"
        Me.ITELEPHONECOLLABODataGridViewTextBoxColumn.ReadOnly = True
        '
        'STREMAILDataGridViewTextBoxColumn
        '
        Me.STREMAILDataGridViewTextBoxColumn.DataPropertyName = "STR_EMAIL"
        Me.STREMAILDataGridViewTextBoxColumn.FillWeight = 218.47!
        Me.STREMAILDataGridViewTextBoxColumn.HeaderText = "Em@il"
        Me.STREMAILDataGridViewTextBoxColumn.Name = "STREMAILDataGridViewTextBoxColumn"
        Me.STREMAILDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Id
        '
        Me.Id.DataPropertyName = "ID_MATRICULECOLLABORATEUR"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent
        Me.Id.DefaultCellStyle = DataGridViewCellStyle3
        Me.Id.FillWeight = 8.05968!
        Me.Id.HeaderText = ""
        Me.Id.MinimumWidth = 2
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        '
        'PSCDListeCollaboInnerRapportBindingSource
        '
        Me.PSCDListeCollaboInnerRapportBindingSource.DataMember = "PS_CD_ListeCollabo_InnerRapport"
        Me.PSCDListeCollaboInnerRapportBindingSource.DataSource = Me.ProjetActiveDataSet
        '
        'ProjetActiveDataSet
        '
        Me.ProjetActiveDataSet.DataSetName = "ProjetActiveDataSet"
        Me.ProjetActiveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PS_CD_ListeCollabo_InnerRapportTableAdapter
        '
        Me.PS_CD_ListeCollabo_InnerRapportTableAdapter.ClearBeforeFill = True
        '
        'Btn_NewCollabo
        '
        Me.Btn_NewCollabo.BackColor = System.Drawing.Color.LimeGreen
        Me.Btn_NewCollabo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Btn_NewCollabo.Location = New System.Drawing.Point(1193, 49)
        Me.Btn_NewCollabo.Name = "Btn_NewCollabo"
        Me.Btn_NewCollabo.Size = New System.Drawing.Size(198, 55)
        Me.Btn_NewCollabo.TabIndex = 8
        Me.Btn_NewCollabo.Text = "Ajouter collaborateur"
        Me.Btn_NewCollabo.UseVisualStyleBackColor = False
        '
        'Btn_ListeCollabo
        '
        Me.Btn_ListeCollabo.BackColor = System.Drawing.Color.Goldenrod
        Me.Btn_ListeCollabo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Btn_ListeCollabo.Location = New System.Drawing.Point(989, 49)
        Me.Btn_ListeCollabo.Name = "Btn_ListeCollabo"
        Me.Btn_ListeCollabo.Size = New System.Drawing.Size(198, 55)
        Me.Btn_ListeCollabo.TabIndex = 9
        Me.Btn_ListeCollabo.Text = "Liste collaborateur"
        Me.Btn_ListeCollabo.UseVisualStyleBackColor = False
        '
        'Txt_RechercheNom
        '
        Me.Txt_RechercheNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Txt_RechercheNom.Location = New System.Drawing.Point(222, 95)
        Me.Txt_RechercheNom.Multiline = True
        Me.Txt_RechercheNom.Name = "Txt_RechercheNom"
        Me.Txt_RechercheNom.Size = New System.Drawing.Size(197, 42)
        Me.Txt_RechercheNom.TabIndex = 10
        Me.Txt_RechercheNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lbl_Recherche
        '
        Me.Lbl_Recherche.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Lbl_Recherche.Location = New System.Drawing.Point(425, 6)
        Me.Lbl_Recherche.Name = "Lbl_Recherche"
        Me.Lbl_Recherche.Size = New System.Drawing.Size(315, 43)
        Me.Lbl_Recherche.TabIndex = 11
        Me.Lbl_Recherche.Text = "Rechercher par"
        Me.Lbl_Recherche.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_RechercheStatut
        '
        Me.Txt_RechercheStatut.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Txt_RechercheStatut.Location = New System.Drawing.Point(480, 95)
        Me.Txt_RechercheStatut.Multiline = True
        Me.Txt_RechercheStatut.Name = "Txt_RechercheStatut"
        Me.Txt_RechercheStatut.Size = New System.Drawing.Size(197, 42)
        Me.Txt_RechercheStatut.TabIndex = 12
        Me.Txt_RechercheStatut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_RechercheFonction
        '
        Me.Txt_RechercheFonction.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Txt_RechercheFonction.Location = New System.Drawing.Point(737, 95)
        Me.Txt_RechercheFonction.Multiline = True
        Me.Txt_RechercheFonction.Name = "Txt_RechercheFonction"
        Me.Txt_RechercheFonction.Size = New System.Drawing.Size(197, 42)
        Me.Txt_RechercheFonction.TabIndex = 13
        Me.Txt_RechercheFonction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lbl_RechercheStatut
        '
        Me.Lbl_RechercheStatut.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Lbl_RechercheStatut.Location = New System.Drawing.Point(480, 49)
        Me.Lbl_RechercheStatut.Name = "Lbl_RechercheStatut"
        Me.Lbl_RechercheStatut.Size = New System.Drawing.Size(197, 43)
        Me.Lbl_RechercheStatut.TabIndex = 14
        Me.Lbl_RechercheStatut.Text = "Type contrat"
        Me.Lbl_RechercheStatut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_RechercheFonction
        '
        Me.Lbl_RechercheFonction.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Lbl_RechercheFonction.Location = New System.Drawing.Point(737, 49)
        Me.Lbl_RechercheFonction.Name = "Lbl_RechercheFonction"
        Me.Lbl_RechercheFonction.Size = New System.Drawing.Size(197, 43)
        Me.Lbl_RechercheFonction.TabIndex = 15
        Me.Lbl_RechercheFonction.Text = "Fonction"
        Me.Lbl_RechercheFonction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_RechercheNom
        '
        Me.Lbl_RechercheNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Lbl_RechercheNom.Location = New System.Drawing.Point(222, 49)
        Me.Lbl_RechercheNom.Name = "Lbl_RechercheNom"
        Me.Lbl_RechercheNom.Size = New System.Drawing.Size(197, 43)
        Me.Lbl_RechercheNom.TabIndex = 16
        Me.Lbl_RechercheNom.Text = "Nom"
        Me.Lbl_RechercheNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_Retour
        '
        Me.Btn_Retour.BackColor = System.Drawing.Color.RoyalBlue
        Me.Btn_Retour.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Btn_Retour.Location = New System.Drawing.Point(1398, 49)
        Me.Btn_Retour.Name = "Btn_Retour"
        Me.Btn_Retour.Size = New System.Drawing.Size(198, 55)
        Me.Btn_Retour.TabIndex = 17
        Me.Btn_Retour.Text = "Retour Acceuil"
        Me.Btn_Retour.UseVisualStyleBackColor = False
        '
        'Frm_Collaborateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1624, 735)
        Me.Controls.Add(Me.Btn_Retour)
        Me.Controls.Add(Me.Lbl_RechercheNom)
        Me.Controls.Add(Me.Lbl_RechercheFonction)
        Me.Controls.Add(Me.Lbl_RechercheStatut)
        Me.Controls.Add(Me.Txt_RechercheFonction)
        Me.Controls.Add(Me.Txt_RechercheStatut)
        Me.Controls.Add(Me.Lbl_Recherche)
        Me.Controls.Add(Me.Txt_RechercheNom)
        Me.Controls.Add(Me.Btn_ListeCollabo)
        Me.Controls.Add(Me.Btn_NewCollabo)
        Me.Controls.Add(Me.Dgv_ListeCollabo)
        Me.Controls.Add(Me.Pbx_logo)
        Me.Name = "Frm_Collaborateur"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste Collaborateur"
        CType(Me.Pbx_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_ListeCollabo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSCDListeCollaboInnerRapportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjetActiveDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pbx_logo As PictureBox
    Friend WithEvents Dgv_ListeCollabo As DataGridView
    Friend WithEvents ProjetActiveDataSet As ProjetActiveDataSet
    Friend WithEvents PSCDListeCollaboInnerRapportBindingSource As BindingSource
    Friend WithEvents PS_CD_ListeCollabo_InnerRapportTableAdapter As ProjetActiveDataSetTableAdapters.PS_CD_ListeCollabo_InnerRapportTableAdapter
    Friend WithEvents Btn_NewCollabo As Button
    Friend WithEvents Btn_ListeCollabo As Button
    Friend WithEvents Txt_RechercheNom As TextBox
    Friend WithEvents Lbl_Recherche As Label
    Friend WithEvents Txt_RechercheStatut As TextBox
    Friend WithEvents Txt_RechercheFonction As TextBox
    Friend WithEvents Lbl_RechercheStatut As Label
    Friend WithEvents Lbl_RechercheFonction As Label
    Friend WithEvents Lbl_RechercheNom As Label
    Friend WithEvents STRLIBCOURTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STRNOMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STRPRENOMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STRCODESTATUTCOLLABODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STRCODEFONCTIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITELEPHONECOLLABODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STREMAILDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Btn_Retour As Button
End Class
