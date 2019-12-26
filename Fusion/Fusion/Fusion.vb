Public Class Fusion

    Private Sub Btn_Generer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Generer.Click

        Dim Tab_A_1(4) As Integer
        Dim Tab_A_2(4) As Integer
        Dim random As New Random()
        Dim i As Integer

        For i = 0 To 3
            Tab_A_1(i) = random.Next(0, 9)
            Tab_A_2(i) = random.Next(0, 9)
        Next i

        Tab_a1.Text = Tab_A_1(0)
        Tab_a2.Text = Tab_A_1(1)
        Tab_a3.Text = Tab_A_1(2)
        Tab_a4.Text = Tab_A_1(3)

        Tab_b1.Text = Tab_A_2(0)
        Tab_b2.Text = Tab_A_2(1)
        Tab_b3.Text = Tab_A_2(2)
        Tab_b4.Text = Tab_A_2(3)

    End Sub

    Private Sub Btn_Tri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Tri.Click
        Dim Tab_A_1(4) As Integer
        Dim Tab_A_2(4) As Integer
        Dim iTemp As Integer

        Tab_A_1(0) = Tab_a1.Text
        Tab_A_1(1) = Tab_a2.Text
        Tab_A_1(2) = Tab_a3.Text
        Tab_A_1(3) = Tab_a4.Text

        Tab_A_2(0) = Tab_b1.Text
        Tab_A_2(1) = Tab_b2.Text
        Tab_A_2(2) = Tab_b3.Text
        Tab_A_2(3) = Tab_b4.Text

        'Array.Sort(Tab_A_1)
        'Array.Sort(Tab_A_2)

        For index = 1 To 5
            For iCpt = 0 To 2
                If Tab_A_1(iCpt) > Tab_A_1(iCpt + 1) Then
                    iTemp = Tab_A_1(iCpt)
                    Tab_A_1(iCpt) = Tab_A_1(iCpt + 1)
                    Tab_A_1(iCpt + 1) = iTemp
                End If
            Next
        Next
        For index = 1 To 5
            For iCpt = 0 To 2
                If Tab_A_2(iCpt) > Tab_A_2(iCpt + 1) Then
                    iTemp = Tab_A_2(iCpt)
                    Tab_A_2(iCpt) = Tab_A_2(iCpt + 1)
                    Tab_A_2(iCpt + 1) = iTemp
                End If
            Next
        Next

        Tab_a1.Text = Tab_A_1(0)
        Tab_a2.Text = Tab_A_1(1)
        Tab_a3.Text = Tab_A_1(2)
        Tab_a4.Text = Tab_A_1(3)

        Tab_b1.Text = Tab_A_2(0)
        Tab_b2.Text = Tab_A_2(1)
        Tab_b3.Text = Tab_A_2(2)
        Tab_b4.Text = Tab_A_2(3)

    End Sub

    Private Sub Btn_Range_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Range.Click
        Dim Tab_A_1(4) As Integer
        Dim Tab_A_2(4) As Integer
        Dim Tab_Fusion(8) As Integer
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim k As Integer = 0

        Tab_A_1(0) = Tab_a1.Text
        Tab_A_1(1) = Tab_a2.Text
        Tab_A_1(2) = Tab_a3.Text
        Tab_A_1(3) = Tab_a4.Text

        Tab_A_2(0) = Tab_b1.Text
        Tab_A_2(1) = Tab_b2.Text
        Tab_A_2(2) = Tab_b3.Text
        Tab_A_2(3) = Tab_b4.Text

        Do While i < 4 And j < 4

            If Tab_A_1(i) <= Tab_A_2(j) Then
                Tab_Fusion(k) = Tab_A_1(i)
                i = i + 1
                k = k + 1
            Else : Tab_Fusion(k) = Tab_A_2(j)
                j = j + 1
                k = k + 1

            End If

        Loop

        For l = j To 3
            Tab_Fusion(k) = Tab_A_2(l)
            k = k + 1
        Next


        For m = i To 3
            Tab_Fusion(k) = Tab_A_1(m)
            k = k + 1
        Next

        Tab_Res_1.Text = Tab_Fusion(0)
        Tab_Res_2.Text = Tab_Fusion(1)
        Tab_Res_3.Text = Tab_Fusion(2)
        Tab_Res_4.Text = Tab_Fusion(3)
        Tab_Res_5.Text = Tab_Fusion(4)
        Tab_Res_6.Text = Tab_Fusion(5)
        Tab_Res_7.Text = Tab_Fusion(6)
        Tab_Res_8.Text = Tab_Fusion(7)

    End Sub
End Class
