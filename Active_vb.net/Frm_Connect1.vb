Imports System.Data.SqlClient
Public Class Frm_Connect

    Private Sub Btn_Connexion_Click(sender As Object, e As EventArgs) Handles Btn_Connexion.Click


        If String.IsNullOrWhiteSpace(Txt_Login.Text) OrElse String.IsNullOrWhiteSpace(Txt_Mdp.Text) Then
            MessageBox.Show("Veuillez entrer le login ainsi que le mot de passe", "Mot de passe Et Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            'Create a Command object.
            myConn.Open()
            myCmd = myConn.CreateCommand
            myCmd.CommandType = CommandType.StoredProcedure

            myCmd.CommandText = "PS_CD_Connexion"

            'Open the connection.
            myReader = myCmd.ExecuteReader()
            'Concatenate the query result into a string.
            While myReader.Read()

                If (myReader.GetString(2) = Txt_Login.Text And myReader.GetString(3) = Txt_Mdp.Text) Then
                    str_Nom = "Bienvenue " + Txt_Login.Text
                    Me.Hide()
                    Frm_Accueil.Show()
                    myReader.Close()
                    myConn.Close()
                    Exit While
                Else
                    MessageBox.Show("Identification incorrecte" & vbCrLf & "Verifier Login et/ou Mot de passe", "Mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    myReader.Close()
                    myConn.Close()
                    Exit While
                End If

            End While

        End If

    End Sub


End Class
