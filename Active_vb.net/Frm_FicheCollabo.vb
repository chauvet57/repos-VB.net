Public Class Frm_FicheCollabo
    Private Sub Frm_FicheCollabo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'recuperation de l'id collaborateur 
        Txt_Matricule.Text = My.Forms.Frm_Collaborateur.str_Valeur

        myConn.Close()
        myConn.Open()


        myCmd = myConn.CreateCommand
        myCmd.CommandType = CommandType.StoredProcedure

        myCmd.CommandText = "PS_CD_FicheCollaborateur"


        myCmd.Parameters.Add("@Matricule", SqlDbType.Int).Value = My.Forms.Frm_Collaborateur.str_Valeur

        myCmd.ExecuteNonQuery()

        'Open the connection.
        myReader = myCmd.ExecuteReader()

        'Concatenate the query result into a string.
        myReader.Read()

        'ecriture de tout les renseignements d'un collaborateur dans les different champs
        Cbx_Sexe.Text = myReader.GetString(0)
        Txt_Nom.Text = myReader.GetString(1)
        Txt_Prenom.Text = myReader.GetString(2)
        Txt_Numero.Text = myReader.GetString(3)
        Txt_Adresse.Text = myReader.GetString(4)
        Cbx_Ville.Text = myReader.GetString(5)
        Txt_CodePostal.Text = myReader.GetSqlSingle(6)
        Cbx_Departement.Text = myReader.GetString(7)
        Cbx_Region.Text = myReader.GetString(8)
        Txt_Telephone.Text = myReader.GetString(9)
        Cbx_Statut.Text = myReader.GetString(10)
        Dtpick_Embauche.Text = myReader.GetSqlDateTime(11)
        Dtpick_FinContrat.Text = myReader.GetSqlDateTime(12)
        Cbx_Fonction.Text = myReader.GetString(13)
        Dtpick_DebutFonction.Text = myReader.GetSqlDateTime(14)
        Dtpick_FinFonction.Text = myReader.GetDateTime(15)
        Txt_Salaire.Text = myReader.GetSqlMoney(16)


        myReader.Close()
        myConn.Close()

        'generation des combobox
        ListeStatut()
        ListeFonction()
        ListeSexe()

    End Sub
    Public Sub ListeStatut()


        'Create a Command object.
        myConn.Close()
        myConn.Open()

        myCmd = myConn.CreateCommand
        myCmd.CommandType = CommandType.StoredProcedure

        myCmd.CommandText = "PS_CD_ListeStatut"

        'Open the connection.
        myReader = myCmd.ExecuteReader()
        'Concatenate the query result into a string.
        Do While myReader.Read()
            Cbx_Statut.Items.Add(myReader.GetString(1))
        Loop

        myReader.Close()
        myConn.Close()

    End Sub
    Public Sub ListeFonction()


        'Create a Command object.
        myConn.Close()
        myConn.Open()
        myCmd = myConn.CreateCommand
        myCmd.CommandType = CommandType.StoredProcedure
        myCmd.CommandText = "PS_CD_ListeFonction"

        'Open the connection.
        myReader = myCmd.ExecuteReader()
        'Concatenate the query result into a string.
        Do While myReader.Read()
            Cbx_Fonction.Items.Add(myReader.GetString(1))
        Loop

        myReader.Close()
        myConn.Close()

    End Sub

    Public Sub ListeSexe()

        'Create a Command object.
        myConn.Close()
        myConn.Open()
        myCmd = myConn.CreateCommand
        myCmd.CommandType = CommandType.StoredProcedure
        myCmd.CommandText = "PS_CD_ListeSexe"

        'Open the connection.
        myReader = myCmd.ExecuteReader()
        'Concatenate the query result into a string.
        Do While myReader.Read()
            Cbx_Sexe.Items.Add(myReader.GetString(2))
        Loop

        myReader.Close()
        myConn.Close()

    End Sub

    Private Sub Txt_CodePostal_TextChanged(sender As Object, e As EventArgs) Handles Txt_CodePostal.GotFocus

        'vide les champs texte des combobox
        Cbx_Ville.Text = ""
        Cbx_Departement.Text = ""
        Cbx_Region.Text = ""

        'vide les items des combobox
        Cbx_Ville.Items.Clear()
        Cbx_Departement.Items.Clear()
        Cbx_Region.Items.Clear()

    End Sub

    Public Sub ListeVilleCp()

        'Create a Command object.
        myConn.Close()
        myConn.Open()


        myCmd = myConn.CreateCommand
        myCmd.CommandType = CommandType.StoredProcedure
        myCmd.CommandText = "PS_CD_ListeVilleCp"
        myCmd.Parameters.Add("@Cp", SqlDbType.VarChar).Value = Txt_CodePostal.Text

        'Open the connection.
        myReader = myCmd.ExecuteReader()
        'Concatenate the query result into a string.

        Do While myReader.Read()

            Cbx_Ville.Items.Add(myReader.GetString(0))

        Loop

        myReader.Close()
        myConn.Close()

    End Sub

    Public Sub ListeRegion_DepartementCp()


        'Create a Command object.
        myConn.Close()
        myConn.Open()


        myCmd = myConn.CreateCommand
        myCmd.CommandType = CommandType.StoredProcedure

        myCmd.CommandText = "PS_CD_ListeRegionDepatementCp"

        myCmd.Parameters.Add("@CpDpRg", SqlDbType.VarChar).Value = Txt_CodePostal.Text

        'Open the connection.
        myReader = myCmd.ExecuteReader()
        'Concatenate the query result into a string.

        Do While myReader.Read()

            Cbx_Departement.Items.Add(myReader.GetString(0))
            Cbx_Region.Items.Add(myReader.GetString(1))
        Loop

        myReader.Close()
        myConn.Close()

    End Sub

    Private Sub Cbx_Ville_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbx_Ville.GotFocus

        'vide les combobox avant remplissage 
        Cbx_Ville.Items.Clear()
        Cbx_Departement.Items.Clear()
        Cbx_Region.Items.Clear()

        'remplissage des combobox par rapport a la nouveau valeur code postal
        ListeVilleCp()
        ListeRegion_DepartementCp()

    End Sub

    Private Sub Btn_Quitter_Click(sender As Object, e As EventArgs) Handles Btn_Quitter.Click

        Frm_Collaborateur.Show()
        Me.Hide()

    End Sub

    Private Sub Btn_Modifier_Click(sender As Object, e As EventArgs) Handles Btn_Modifier.Click

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandType = CommandType.StoredProcedure

        myCmd.CommandText = "PS_CD_UpdateFormCollabo"

        'Open the connection.
        myConn.Open()

        'collecte des parametres d'entrée  de la procédure stockée
        myCmd.Parameters.Add("@Sexe", SqlDbType.VarChar).Value = Cbx_Sexe.Text
        myCmd.Parameters.Add("@Nom", SqlDbType.VarChar).Value = Txt_Nom.Text
        myCmd.Parameters.Add("@Prenom", SqlDbType.VarChar).Value = Txt_Prenom.Text
        myCmd.Parameters.Add("@Statut", SqlDbType.VarChar).Value = Cbx_Statut.Text
        myCmd.Parameters.Add("@Fonction", SqlDbType.VarChar).Value = Cbx_Fonction.Text
        myCmd.Parameters.Add("@Matricule", SqlDbType.Int).Value = Txt_Matricule.Text
        myCmd.Parameters.Add("@Salaire", SqlDbType.Money).Value = Txt_Salaire.Text
        myCmd.Parameters.Add("@Telephone", SqlDbType.VarChar).Value = Txt_Telephone.Text
        myCmd.Parameters.Add("@DateEmbauche", SqlDbType.DateTime).Value = Dtpick_Embauche.Value
        myCmd.Parameters.Add("@DateFinContrat", SqlDbType.DateTime).Value = Dtpick_FinContrat.Value
        myCmd.Parameters.Add("@DateDebutFonction", SqlDbType.DateTime).Value = Dtpick_DebutFonction.Value
        myCmd.Parameters.Add("@DateFinFonction", SqlDbType.DateTime).Value = Dtpick_FinFonction.Value
        myCmd.Parameters.Add("@Adresse", SqlDbType.VarChar).Value = Txt_Adresse.Text
        myCmd.Parameters.Add("@Numero", SqlDbType.Int).Value = Txt_Numero.Text
        myCmd.Parameters.Add("@NomVille", SqlDbType.VarChar).Value = Cbx_Ville.Text
        myCmd.Parameters.Add("@CodePostal", SqlDbType.Int).Value = Txt_CodePostal.Text

        myCmd.ExecuteNonQuery()

        myConn.Close()
        Frm_Collaborateur.Btn_ListeCollabo_Click(sender, e)

        MsgBox("Modification réussi : " + Cbx_Sexe.Text + " " + Txt_Nom.Text + " " + Txt_Prenom.Text + " a été mis à jour", vbOK + vbInformation, "Modification")

        Me.Close()
    End Sub

End Class