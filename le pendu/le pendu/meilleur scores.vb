Imports System.IO
Public Class meilleur_scores

    Private Sub meilleur_scores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Classement() As String = File.ReadAllLines("Scores.txt")
        Dim Nb_lignes As Integer = Classement.Length

        Array.Sort(Classement)
        Array.Reverse(Classement)


        For index = 1 To Classement.Length - 1

            Dim Resultat As New TextBox
            Dim Id_classement As New TextBox


            If index < 11 Then

                Resultat.Top = 35 + (index * 40)
                Resultat.Left = 70
                Id_classement.Top = 35 + (index * 40)
                Id_classement.Left = 25



                Resultat.Name = "Txt_" & Classement(index - 1)
                Resultat.Font = New Font("Microsoft Sans Serif", 18, FontStyle.Regular)
                Resultat.Size = New Size(210, 40)
                Resultat.BackColor = Color.Gainsboro
                Resultat.Text = Classement(index - 1)
                Resultat.Enabled = False

                Id_classement.Name = "Txt_"
                Id_classement.Font = New Font("Microsoft Sans Serif", 18, FontStyle.Regular)
                Id_classement.Size = New Size(40, 40)
                Id_classement.BackColor = Color.Gainsboro
                Id_classement.TextAlign = HorizontalAlignment.Center
                Id_classement.Text &= index
                Id_classement.Enabled = False

                Me.Controls.Add(Resultat)
                Me.Controls.Add(Id_classement)
            End If
        Next


    End Sub

End Class