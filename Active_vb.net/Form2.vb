Public Class Form2




    Public Sub ListeVille()

        'myConn = New SqlConnection(MaChaineDeConnexion)
        'Create a Command object.
        myConn.Close()
        myConn.Open()


        myCmd = myConn.CreateCommand
        myCmd.CommandType = CommandType.StoredProcedure
        myCmd.CommandText = "PS_CD_ListeVilleCp"
        myCmd.Parameters.Add("@Cp", SqlDbType.VarChar).Value = TextBox1.Text

        'Open the connection.
        myReader = myCmd.ExecuteReader()
        'Concatenate the query result into a string.

        Do While myReader.Read()

            ComboBox1.Items.Add(myReader.GetString(0))

        Loop


        myReader.Read()

        ComboBox2.Items.Add(myReader.GetString(1))
        ComboBox3.Items.Add(myReader.GetString(2))

        'Display results.
        'MsgBox(results)
        myReader.Close()
        myConn.Close()

    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()

        ListeVille()
    End Sub
End Class