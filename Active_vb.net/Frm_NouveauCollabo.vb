Imports System.Data.SqlClient
Public Class Frm_NouveauCollabo
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'appel  des sub pour remplissage des combo box
        ListeStatut()
        ListeFonction()
        ListeSexe()

        Dtpick_FinContrat.Visible = False
        Dtpick_FinFonction.Visible = False



    End Sub

    Private Sub Btn_Valider_Click(sender As Object, e As EventArgs) Handles Btn_Valider.Click

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandType = CommandType.StoredProcedure

        myCmd.CommandText = "PS_CD_NouveauCollaborateur"

        'Open the connection.
        myConn.Open()

        'collecte des parametre d'entrée pour la procedure stocké

        myCmd.Parameters.Add("@Region", SqlDbType.VarChar).Value = Cbx_Region.Text
        myCmd.Parameters.Add("@Departement", SqlDbType.VarChar).Value = Cbx_Departement.Text
        myCmd.Parameters.Add("@Ville", SqlDbType.VarChar).Value = Cbx_Ville.Text
        myCmd.Parameters.Add("@Code_Postal", SqlDbType.Int).Value = Txt_CodePostal.Text
        myCmd.Parameters.Add("@Numero_Adresse", SqlDbType.Int).Value = Txt_Numero.Text
        myCmd.Parameters.Add("@Adresse", SqlDbType.VarChar).Value = Txt_Adresse.Text
        myCmd.Parameters.Add("@SEXE", SqlDbType.VarChar).Value = Cbx_Sexe.Text
        myCmd.Parameters.Add("@NOM", SqlDbType.VarChar).Value = Txt_Nom.Text
        myCmd.Parameters.Add("@PRENOM", SqlDbType.VarChar).Value = Txt_Prenom.Text
        myCmd.Parameters.Add("@STATUTCOLLABO", SqlDbType.VarChar).Value = Cbx_Statut.Text
        myCmd.Parameters.Add("@FONCTION", SqlDbType.VarChar).Value = Cbx_Fonction.Text
        myCmd.Parameters.Add("@DateEmbauche", SqlDbType.Date).Value = Dtpick_Embauche.Value
        myCmd.Parameters.Add("@DateFinContrat", SqlDbType.Date).Value = Dtpick_FinContrat.Value
        myCmd.Parameters.Add("@DateDebutFonction", SqlDbType.Date).Value = Dtpick_DebutFonction.Value
        myCmd.Parameters.Add("@DateFinFonction", SqlDbType.Date).Value = Dtpick_FinFonction.Value
        myCmd.Parameters.Add("@Telephone", SqlDbType.Int).Value = Txt_Telephone.Text
        myCmd.Parameters.Add("@Salaire", SqlDbType.Int).Value = Txt_Salaire.Text

        myCmd.ExecuteNonQuery()

        myConn.Close()

        MsgBox("Insertion réussi : " + Cbx_Sexe.Text + " " + Txt_Nom.Text + " " + Txt_Prenom.Text + " a été ajouté", vbOK + vbInformation, "Nouveau collaborateur")

        'rechargement de la liste mise a jour
        Frm_Collaborateur.Btn_ListeCollabo_Click(sender, e)
        Me.Close()

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

    Private Sub Txt_Nom_TextChanged(sender As Object, e As EventArgs) Handles Txt_Nom.TextChanged

    End Sub

    Private Sub Lbl_DateFinContrat_Click(sender As Object, e As EventArgs) Handles Lbl_DateFinContrat.Click

        Dtpick_FinContrat.Visible = True

    End Sub

    Private Sub Lbl_DateFinFonction_Click(sender As Object, e As EventArgs) Handles Lbl_DateFinFonction.Click

        Dtpick_FinFonction.Visible = True

    End Sub

    Private Sub Txt_CodePostal_TextChanged(sender As Object, e As EventArgs) Handles Txt_CodePostal.KeyPress

        'vide la liste des items des combo box , mise a jour a chaque lettre pressé
        Cbx_Ville.Items.Clear()
        Cbx_Departement.Items.Clear()
        Cbx_Region.Items.Clear()

        'génération des items combobox par rapport au code postal entrée
        ListeVilleCp()
        ListeRegion_DepartementCp()
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

    Private Sub Txt_CodePostal_TextChanged_1(sender As Object, e As EventArgs) Handles Txt_CodePostal.GotFocus

        'vide les champs texte des combobox
        Cbx_Ville.Text = ""
        Cbx_Departement.Text = ""
        Cbx_Region.Text = ""

        'vide les items des combobox
        Cbx_Ville.Items.Clear()
        Cbx_Departement.Items.Clear()
        Cbx_Region.Items.Clear()
    End Sub

    Private Sub Cbx_Ville_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbx_Ville.GotFocus

        'vide les items des combobox
        Cbx_Ville.Items.Clear()
        Cbx_Departement.Items.Clear()
        Cbx_Region.Items.Clear()

        'génération des items combobox par rapport au code postal entrée
        ListeVilleCp()
        ListeRegion_DepartementCp()

    End Sub

End Class