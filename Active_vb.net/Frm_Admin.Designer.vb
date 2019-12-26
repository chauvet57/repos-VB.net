<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Admin))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Pbx_logo = New System.Windows.Forms.PictureBox()
        Me.Dgv_ListeProcedure = New System.Windows.Forms.DataGridView()
        Me.Txt_Text = New System.Windows.Forms.TextBox()
        Me.ProjetActiveDataSet3 = New Active.ProjetActiveDataSet3()
        Me.PSCDListingPStockéeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PS_CD_ListingPStockéeTableAdapter = New Active.ProjetActiveDataSet3TableAdapters.PS_CD_ListingPStockéeTableAdapter()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Txt_Procedure = New System.Windows.Forms.TextBox()
        Me.Btn_Retour = New System.Windows.Forms.Button()
        Me.Txt_TextCode = New System.Windows.Forms.TextBox()
        CType(Me.Pbx_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_ListeProcedure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjetActiveDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PSCDListingPStockéeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pbx_logo
        '
        Me.Pbx_logo.BackColor = System.Drawing.Color.Transparent
        Me.Pbx_logo.BackgroundImage = CType(resources.GetObject("Pbx_logo.BackgroundImage"), System.Drawing.Image)
        Me.Pbx_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pbx_logo.ErrorImage = Nothing
        Me.Pbx_logo.Location = New System.Drawing.Point(12, 12)
        Me.Pbx_logo.Name = "Pbx_logo"
        Me.Pbx_logo.Size = New System.Drawing.Size(160, 135)
        Me.Pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pbx_logo.TabIndex = 7
        Me.Pbx_logo.TabStop = False
        '
        'Dgv_ListeProcedure
        '
        Me.Dgv_ListeProcedure.AllowUserToAddRows = False
        Me.Dgv_ListeProcedure.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Dgv_ListeProcedure.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Dgv_ListeProcedure.AutoGenerateColumns = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_ListeProcedure.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Dgv_ListeProcedure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ListeProcedure.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.TextDataGridViewTextBoxColumn})
        Me.Dgv_ListeProcedure.DataSource = Me.PSCDListingPStockéeBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv_ListeProcedure.DefaultCellStyle = DataGridViewCellStyle6
        Me.Dgv_ListeProcedure.Location = New System.Drawing.Point(12, 153)
        Me.Dgv_ListeProcedure.Name = "Dgv_ListeProcedure"
        Me.Dgv_ListeProcedure.ReadOnly = True
        Me.Dgv_ListeProcedure.Size = New System.Drawing.Size(396, 446)
        Me.Dgv_ListeProcedure.TabIndex = 8
        '
        'Txt_Text
        '
        Me.Txt_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Txt_Text.Location = New System.Drawing.Point(436, 153)
        Me.Txt_Text.Multiline = True
        Me.Txt_Text.Name = "Txt_Text"
        Me.Txt_Text.Size = New System.Drawing.Size(539, 150)
        Me.Txt_Text.TabIndex = 9
        '
        'ProjetActiveDataSet3
        '
        Me.ProjetActiveDataSet3.DataSetName = "ProjetActiveDataSet3"
        Me.ProjetActiveDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PSCDListingPStockéeBindingSource
        '
        Me.PSCDListingPStockéeBindingSource.DataMember = "PS_CD_ListingPStockée"
        Me.PSCDListingPStockéeBindingSource.DataSource = Me.ProjetActiveDataSet3
        '
        'PS_CD_ListingPStockéeTableAdapter
        '
        Me.PS_CD_ListingPStockéeTableAdapter.ClearBeforeFill = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Nom de la procedure"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TextDataGridViewTextBoxColumn
        '
        Me.TextDataGridViewTextBoxColumn.DataPropertyName = "text"
        Me.TextDataGridViewTextBoxColumn.HeaderText = "text"
        Me.TextDataGridViewTextBoxColumn.Name = "TextDataGridViewTextBoxColumn"
        Me.TextDataGridViewTextBoxColumn.ReadOnly = True
        Me.TextDataGridViewTextBoxColumn.Visible = False
        '
        'Txt_Procedure
        '
        Me.Txt_Procedure.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Txt_Procedure.Location = New System.Drawing.Point(436, 88)
        Me.Txt_Procedure.Multiline = True
        Me.Txt_Procedure.Name = "Txt_Procedure"
        Me.Txt_Procedure.Size = New System.Drawing.Size(542, 47)
        Me.Txt_Procedure.TabIndex = 10
        Me.Txt_Procedure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btn_Retour
        '
        Me.Btn_Retour.BackColor = System.Drawing.Color.RoyalBlue
        Me.Btn_Retour.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Btn_Retour.Location = New System.Drawing.Point(780, 12)
        Me.Btn_Retour.Name = "Btn_Retour"
        Me.Btn_Retour.Size = New System.Drawing.Size(198, 55)
        Me.Btn_Retour.TabIndex = 18
        Me.Btn_Retour.Text = "Retour Acceuil"
        Me.Btn_Retour.UseVisualStyleBackColor = False
        '
        'Txt_TextCode
        '
        Me.Txt_TextCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Txt_TextCode.Location = New System.Drawing.Point(436, 325)
        Me.Txt_TextCode.Multiline = True
        Me.Txt_TextCode.Name = "Txt_TextCode"
        Me.Txt_TextCode.Size = New System.Drawing.Size(539, 274)
        Me.Txt_TextCode.TabIndex = 19
        '
        'Frm_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1044, 619)
        Me.Controls.Add(Me.Txt_TextCode)
        Me.Controls.Add(Me.Btn_Retour)
        Me.Controls.Add(Me.Txt_Procedure)
        Me.Controls.Add(Me.Txt_Text)
        Me.Controls.Add(Me.Dgv_ListeProcedure)
        Me.Controls.Add(Me.Pbx_logo)
        Me.Name = "Frm_Admin"
        Me.Text = "Admin"
        CType(Me.Pbx_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_ListeProcedure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjetActiveDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PSCDListingPStockéeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pbx_logo As PictureBox
    Friend WithEvents Dgv_ListeProcedure As DataGridView
    Friend WithEvents Txt_Text As TextBox
    Friend WithEvents ProjetActiveDataSet3 As ProjetActiveDataSet3
    Friend WithEvents PSCDListingPStockéeBindingSource As BindingSource
    Friend WithEvents PS_CD_ListingPStockéeTableAdapter As ProjetActiveDataSet3TableAdapters.PS_CD_ListingPStockéeTableAdapter
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Txt_Procedure As TextBox
    Friend WithEvents Btn_Retour As Button
    Friend WithEvents Txt_TextCode As TextBox
End Class
