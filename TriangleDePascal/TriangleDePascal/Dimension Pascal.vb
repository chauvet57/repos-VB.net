Public Class Visuel

    Private Sub Btn_Calcul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Calcul.Click

        Dim aLigne(100) As Integer
        Dim aLigneSuivante(100) As Integer
        Dim iNombre As Integer
        Dim iCpt1 As Integer
        Dim iCpt2 As Integer
        Txt_Res.Text = ""
        'iNombre = InputBox("Entrer une limite de ligne : ")
        iNombre = Txt_Dim.Text

        If iNombre >= 2 Then
            aLigne(0) = 1
            aLigne(1) = 1


            For iCpt1 = 1 To iNombre - 1
                aLigneSuivante(0) = 1
                Txt_Res.Text = Txt_Res.Text & aLigneSuivante(0)


                For iCpt2 = 1 To iCpt1 - 1
                    aLigneSuivante(iCpt2) = aLigne(iCpt2 - 1) + aLigne(iCpt2)

                Next

                aLigneSuivante(iCpt1 + 1) = 1

                For iCpt2 = 2 To iCpt1
                    aLigne(iCpt2) = aLigneSuivante(iCpt2)
                    Txt_Res.Text = Txt_Res.Text & " -|- " & aLigne(iCpt2)

                Next

                Txt_Res.Text = Txt_Res.Text & vbCrLf

            Next

        End If

    End Sub

    Private Sub Txt_Dim_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Dim.TextChanged

    End Sub

    Private Sub Lbl_Dimension_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbl_Dimension.Click

    End Sub
End Class
