Public Class fenetre

    Private Sub btn_parfait_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_parfait.Click
        Dim iLimite As Integer
        Dim iSommeDiv As Integer = 0
        Txt_Res.Text = ""
        iLimite = InputBox("Entrer la limite jusqu'où tester les nombres parfaits :")


        For iCpt = 1 To iLimite

            iSommeDiv = 0

            For iCpt2 = 1 To iCpt / 2

                If iCpt Mod iCpt2 = 0 Then
                    iSommeDiv = iSommeDiv + iCpt2
                End If
            Next

            If iSommeDiv = iCpt Then
                Txt_Res.Text = Txt_Res.Text & iCpt & " est un nombre parfait " & vbCrLf
            End If

        Next

    End Sub

    Private Sub btn_ami_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ami.Click

        Dim iLimite As Integer
        Dim iSommeDiv1 As Integer = 0
        Dim iSommeDiv2 As Integer = 0
        Dim iUnSurDeux As Integer = 2
        Txt_Res.Text = ""
        iLimite = InputBox("Entrer la limite jusqu'où tester les nombres amis :")


        For iCpt = 1 To iLimite

            iSommeDiv1 = 0
            iSommeDiv2 = 0

            For iCpt2 = 1 To iCpt / 2

                If iCpt Mod iCpt2 = 0 Then
                    iSommeDiv1 = iSommeDiv1 + iCpt2
                End If
            Next

            For iCpt3 = 1 To iSommeDiv1 / 2

                If iSommeDiv1 Mod iCpt3 = 0 Then
                    iSommeDiv2 = iSommeDiv2 + iCpt3
                End If
            Next

            If iSommeDiv2 = iCpt And iSommeDiv1 <> iCpt Then
                If iUnSurDeux Mod 2 = 0 Then
                    Txt_Res.Text = Txt_Res.Text & iSommeDiv1 & " " & iSommeDiv2 & " sont des nombres amis " & vbCrLf
                End If
                iUnSurDeux = iUnSurDeux + 1
            End If

        Next

    End Sub


    Private Sub Btn_Nbr_Premier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Nbr_Premier.Click
        'Déclarations des variables
        Dim iLimite As Integer
        Dim iSommeDiv As Integer
        Txt_Res.Text = ""

        'Saisie de la limite
        iLimite = InputBox("Limite : ")
        'Description de tous les entiers jusqu'a la limite
        For iCpt = 1 To iLimite
            iSommeDiv = 0
            'Calcul de la somme des diviseurs
            For iCpt2 = 1 To (iCpt / 2)
                If (iCpt Mod iCpt2 = 0) Then
                    iSommeDiv = iSommeDiv + iCpt2
                End If
            Next
            'La somme des diviseurs d'un nombre premier vaut 1
            If (iSommeDiv = 1) Then
                Txt_Res.Text = Txt_Res.Text & iCpt & " est premiers." & vbCrLf
            End If
        Next
    End Sub

End Class
