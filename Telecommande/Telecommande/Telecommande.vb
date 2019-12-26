Public Class Frm_Telecommande

    Private Sub Frm_Telecommande_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Size = New Size(300, 300)
        Me.Top = 400
        Me.Left = 700

    End Sub


    Private Sub Btn_Haut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Haut.Click

        Me.Top = Me.Top - 5

    End Sub


    Private Sub Btn_Bas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Bas.Click

        Me.Top = Me.Top + 5

    End Sub

    Private Sub Btn_Gauche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Gauche.Click

        Me.Left = Me.Left - 5

    End Sub


    Private Sub Btn_Droit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Droit.Click

        Me.Left = Me.Left + 5

    End Sub


End Class
