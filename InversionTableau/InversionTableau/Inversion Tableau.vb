Public Class Frm_Principal

    Private Sub Btn_Inversion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Inversion.Click

        Lbl_Tab_Inverser.Visible = True
        Txt_Tab_Inv1.Visible = True
        Txt_Tab_Inv2.Visible = True
        Txt_Tab_Inv3.Visible = True
        Txt_Tab_Inv4.Visible = True

        Txt_Tab_Inv4.Text = Txt_Tab1.Text
        Txt_Tab_Inv3.Text = Txt_Tab2.Text
        Txt_Tab_Inv2.Text = Txt_Tab3.Text
        Txt_Tab_Inv1.Text = Txt_Tab4.Text


    End Sub

    
    Private Sub Btn_Generer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Generer.Click

        Lbl_Tab_Inverser.Visible = False
        Txt_Tab_Inv1.Visible = False
        Txt_Tab_Inv2.Visible = False
        Txt_Tab_Inv3.Visible = False
        Txt_Tab_Inv4.Visible = False

        Dim aTab(4) As Integer
        Dim random As New Random(), rndnbr As Integer

        rndnbr = random.Next(0, 9)
        Txt_Tab1.Text = random.Next(0, 9)
        Txt_Tab2.Text = random.Next(0, 9)
        Txt_Tab3.Text = random.Next(0, 9)
        Txt_Tab4.Text = random.Next(0, 9)


    End Sub

    Private Sub Txt_Tab_A_Inverser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub
End Class
