Public Class Ecart_Date

    Private Sub Ecart_Date_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




        For Annee = Date.Now.Year - 100 To Date.Now.Year
            Cbx_Annee_1.Items.Add(Annee)
            Cbx_Annee_2.Items.Add(Annee)
        Next

        For Jour = 1 To 31
            Cbx_Jour_1.Items.Add(Jour)
            Cbx_Jour_2.Items.Add(Jour)
        Next

        For Mois = 1 To 12
            Cbx_Mois_1.Items.Add(Mois)
            Cbx_Mois_2.Items.Add(Mois)
        Next
    End Sub



End Class
