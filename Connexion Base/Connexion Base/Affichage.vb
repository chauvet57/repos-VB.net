Imports System.Data.SqlClient

Public Class Frm_Affichage
    Dim str_Valeur As String = ""
    Dim RI As Integer
    Dim CI As Integer
    Private Sub Frm_Affichage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = str_Nom
    End Sub

    Private Sub Btn_Remplir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Remplir_Ville.Click
        Cb_Villes.Items.Clear()
        'Cb_Villes.Items.Add("Nancy")

        myConn = New SqlConnection("Initial Catalog=Active0.0;" & _
                "Data Source=DESKTOP-PVJFRGN\SQLEXPRESS;Integrated Security=SSPI;")
        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT * FROM VILLE"

        'Open the connection.
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        'Concatenate the query result into a string.
        Do While myReader.Read()
            Cb_Villes.Items.Add(myReader.GetString(2))
        Loop
        'Display results.
        'MsgBox(results)
        myReader.Close()
        myConn.Close()

    End Sub

    Private Sub Btn_AjouterVille_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_AjouterVille.Click
        myConn = New SqlConnection(machainedeconnexion)
        'Create a Command object.
        myCmd = myConn.CreateCommand
        'myCmd.CommandType = CommandType.StoredProcedure
        'myCmd.CommandText = "PS_"
        myCmd.CommandText = "INSERT INTO VILLE(ID_DEPARTEMENT,STR_NOM_VILLE) VALUES (1,'" + Txt_AjouterVille.Text + "')"
        'Open the connection.
        myConn.Open()
        myCmd.ExecuteNonQuery()
        myConn.Close()
    End Sub

    Private Sub Btn_Remplir_Region_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Remplir_Region.Click
        Cb_Regions.Items.Clear()


        myConn = New SqlConnection("Initial Catalog=Active0.1;" & _
                "Data Source=DESKTOP-PVJFRGN\SQLEXPRESS;Integrated Security=SSPI;")
        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandType = CommandType.StoredProcedure
        myCmd.CommandText = "PS_EM_Liste_Regions"

        'Open the connection.
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        'Concatenate the query result into a string.
        Do While myReader.Read()
            If IsDBNull(myReader.GetValue(0)) Then
                MsgBox("il y a une valeur nulle !")
            Else
                Cb_Regions.Items.Add(myReader.GetString(0))
            End If

        Loop
        'Display results.
        'MsgBox(results)
        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub Btn_Ajouter_Region_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Ajouter_Region.Click
        myConn = New SqlConnection(machainedeconnexion)
        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandType = CommandType.StoredProcedure
        myCmd.CommandText = "PS_EM_Insertion_Region"
        Dim unParam As SqlParameter = New SqlParameter("@NomRegion", SqlDbType.NVarChar)
        unParam.Value = Txt_Ajouter_Region.Text
        myCmd.Parameters.Add(unParam)

        'Open the connection.
        myConn.Open()
        myCmd.ExecuteNonQuery()
        myConn.Close()
    End Sub

    Private Sub Btn_Remplir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Remplir.Click

        'Objet connexion pour se connecter à la base 
        myConn = New SqlConnection(machainedeconnexion)
        'Requête SQL
        'Associer la requête à la connexion
        myCmd = myConn.CreateCommand
        'la requête est de type PS
        myCmd.CommandType = CommandType.StoredProcedure
        'le nom de la PS est PS_Liste_Projets
        myCmd.CommandText = "PS_Liste_Projets"
        ' la PS a un paramètre
        Dim unParam As SqlParameter = New SqlParameter("@Param1", SqlDbType.NVarChar)
        'unParam.DbType = SqlDbType.NVarChar
        'unParam.ParameterName = "@Param1"
        'unParam.Value = str_critere
        unParam.Value = Txt_Param.Text
        'le parametre est le parametre de la PS
        myCmd.Parameters.Add(unParam)

        'Open the connection.
        myConn.Open()
        ' définition d'une table recueillant le résulatat de la PS
        'Dim dt As New DataTable
        adapt = New SqlDataAdapter(myCmd)
        adapt.Fill(dt)

        'ma table dt est la source de la DATAGRID
        DGV_Liste_Projet.DataSource = dt

        Dim objBuilder As New SqlCommandBuilder(adapt)
        'objDA.Update(objDs, MaTable)
        'adapt.Update(dt)


        myConn.Close()

        'Requêtes SQL






    End Sub

    Private Sub DGV_Liste_Projet_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Liste_Projet.CellContentClick

    End Sub



    Private Sub DGV_copie(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Liste_Projet.CellClick
        

        If Me.DGV_Liste_Projet.CurrentCell.Value <> Nothing Then
            RI = Me.DGV_Liste_Projet.CurrentCell.RowIndex()
            CI = Me.DGV_Liste_Projet.CurrentCell.ColumnIndex()
            str_Valeur = Me.DGV_Liste_Projet.CurrentCell.Value
        End If
        Dim message As String = "RI = " & Str(RI) & "CI = " & Str(CI) & str_Valeur
        MsgBox(message)
    End Sub

    Private Sub Btn_Qui_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Qui.Click
        Dim message As String = "Vous avez sélectionné : " & str_Valeur
        If CI = 0 Then
            MsgBox(message, MsgBoxStyle.Information, "Sélection du client")
        Else
            MsgBox("Vous devez sélectionné un client dans la première colonne !", MsgBoxStyle.Critical, "Sélection du clien")
        End If

    End Sub

    Private Sub Btn_MAJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_MAJ.Click
        Dim objBuilder As New SqlCommandBuilder(adapt)
        'objDA.Update(objDs, MaTable)
        'adapt.Update(dt)

    End Sub
End Class