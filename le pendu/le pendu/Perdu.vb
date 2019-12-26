Public Class Perdu

    Private Sub Perdu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("cri_perdu.wav")
        Lbl_Solution.Text = My.Forms.Frm_Pendu.Txt_Mot.Text

    End Sub

    Private Sub Btn_End_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_End.Click

        End
    End Sub

    Private Sub Btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_New.Click

        Frm_Pendu.NouvellePartieToolStripMenuItem_Click(sender, e)
        Me.Close()
    End Sub

End Class