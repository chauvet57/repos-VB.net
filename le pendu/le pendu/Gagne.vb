Public Class Gagne
    Dim Nbr_essais As Integer
    Dim secondes As Integer

    Private Sub Gagne_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        My.Computer.Audio.Play("cri_gagnez.wav")
        Nbr_essais = My.Forms.Frm_Pendu.Txt_Nbr_Essais.Text
        Dim Str_Nom As String
        Dim Scores As Integer
       
        'calcul du score + affichage
        secondes = My.Forms.Frm_Pendu.Lbl_Temps.Text
        Scores = ((Nbr_essais * 100) + (60 - secondes))
        Txt_Nbr_Essais.Text = Txt_Nbr_Essais.Text & "Il vous restait  " & Nbr_essais & "  Essais Bravo !!! " & vbCrLf & vbCrLf & "Avec un temps de " & secondes & " secondes" & vbCrLf & vbCrLf & "Votre Score : " & Scores




        Str_Nom = InputBox("Félicitation entrez votre nom !!!" & vbCrLf & "Votre Score est : " & Scores)


        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("Scores.txt", True)

        file.WriteLine(" " & Scores & "             " & Str_Nom)

        file.Close()

    End Sub

    Private Sub Btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_New.Click

        Frm_Pendu.NouvellePartieToolStripMenuItem_Click(sender, e)
        Me.Close()

    End Sub

    Private Sub Btn_End_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_End.Click

        End

    End Sub

 
End Class