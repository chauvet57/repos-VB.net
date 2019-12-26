Public Class SaisirValeur

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRes.TextChanged

    End Sub

    Private Sub BtnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGo.Click
        Dim ivaleur As Integer = 5
        Dim iPlusGgrand As Integer = -999
        Dim iPlusPetit As Integer = 999
        Dim iSomme As Integer = 0
        Dim iCpt As Integer = 0
        Dim fMoyenne As Integer = 0

        Do Until (ivaleur = 0)
            ivaleur = InputBox("Entrez la valeur")
            If (ivaleur <> 0) Then
                If (ivaleur > iPlusGgrand) Then
                    iPlusGgrand = ivaleur
                ElseIf (ivaleur < iPlusPetit) Then
                    iPlusPetit = ivaleur
                End If

                iCpt = iCpt + 1
                iSomme = iSomme + ivaleur
                fMoyenne = iSomme / iCpt

            End If
            TxtRes.Text = "Le nombre de valeur saisi est :" & iCpt & " " & vbCrLf & "La somme des valeur est :" & iSomme & " " & vbCrLf & "La valeur la plus petite est : " & iPlusPetit & " " & vbCrLf & "La valeur la plus grande est : " & iPlusGgrand & " " & vbCrLf & "La moyenne des valeur est égal a :" & fMoyenne
        Loop

    End Sub
End Class
