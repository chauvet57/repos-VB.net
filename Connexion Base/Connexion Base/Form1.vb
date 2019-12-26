Imports System.Data.SqlClient

Public Class Frm_princ
    
    Private Sub Btn_Connexion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Connexion.Click
        myConn = New SqlConnection("Initial Catalog=Active0.0;" & _
                "Data Source=DESKTOP-PVJFRGN\SQLEXPRESS;Integrated Security=SSPI;")
        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT * FROM ACCES"

        'Open the connection.
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        'Concatenate the query result into a string.
        Do While myReader.Read()
            'results = results & myReader.GetString(2) & vbTab & myReader.GetString(3) & vbLf
            If (myReader.GetString(2) = Txt_Login.Text And myReader.GetString(3) = Txt_MDP.Text) Then
                str_Nom = "Bienvenue " + Txt_Login.Text
                Me.Hide()
                Frm_Affichage.Show()

            End If
        Loop
        'Display results.
        'MsgBox(results)
        myReader.Close()
        myConn.Close()
    End Sub
End Class
