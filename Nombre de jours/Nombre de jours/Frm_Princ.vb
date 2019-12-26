Public Class Frm_Princ
    Dim iNbJours As Integer = 0
    Private Sub Frm_Princ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DTP_1.Visible = False
        DTP_2.Visible = False
        Btn_Verifie.Visible = False

        For Annee = Date.Now.Year - 100 To Date.Now.Year
            Txt_a1.Items.Add(Annee)
            Txt_a2.Items.Add(Annee)
        Next

        For Jour = 1 To 31
            Txt_j1.Items.Add(Jour)
            Txt_j2.Items.Add(Jour)
        Next

        For Mois = 1 To 12
            Txt_m1.Items.Add(Mois)
            Txt_m2.Items.Add(Mois)
        Next

    End Sub

    Private Sub Btn_Calculer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Calculer.Click
       

        'Variables
        Dim j1, m1, a1 As Integer
        Dim j2, m2, a2 As Integer
        Dim iNbJours As Integer = 0
        Dim bDateValide1 As Boolean = True
        Dim bDateValide2 As Boolean = True
        Dim str_MessageErreur As String = ""
        Dim aNbJoursMois() As Integer = {0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
        Dim aNomMois() As String = {"", "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Décembre"}
        Txt_Res.Text = ""

        'Initialisation
        j1 = Txt_j1.Text
        m1 = Txt_m1.Text
        a1 = Txt_a1.Text
        j2 = Txt_j2.Text
        m2 = Txt_m2.Text
        a2 = Txt_a2.Text

       

        ' Vérification
        If ((j1 >= 1) And (j1 <= 31)) Then
            If ((m1 >= 1) And (m1 <= 12)) Then
                If (j1 <= aNbJoursMois(m1)) Then
                    If ((m1 = 2) And (j1 = 29) And (EstBissextille(a1) = False)) Then

                        str_MessageErreur = str_MessageErreur & "L'année " & a1 & " n'était pas bissextile ! (date 1)" & vbCrLf
                        bDateValide1 = False
                    End If
                Else
                    bDateValide1 = False
                    str_MessageErreur = str_MessageErreur & "Il n'y a que " & aNbJoursMois(m1) & " jours dans le mois de " & aNomMois(m1) & " ! (date 1)" & vbCrLf
                    
                End If
            Else
                bDateValide1 = False
                str_MessageErreur = str_MessageErreur & "Il y a 12 mois dans une année ! (date 1)" & vbCrLf
            End If
        Else
            bDateValide1 = False
            str_MessageErreur = str_MessageErreur & "Un mois a 1 jour minimum et 31 jours maximum ! (date 1)" & vbCrLf
        End If
        If ((j2 >= 1) And (j2 <= 31)) Then
            If ((m2 >= 1) And (m2 <= 12)) Then
                If (j2 <= aNbJoursMois(m2)) Then

                    If ((m2 = 2) And (j2 = 29) And (EstBissextille(a2) = False)) Then
                        str_MessageErreur = str_MessageErreur & "L'année " & a2 & " n'était pas bissextile ! (date 2)" & vbCrLf
                        bDateValide2 = False
                    End If
                Else
                    bDateValide2 = False
                    str_MessageErreur = str_MessageErreur & "Il n'y a que " & aNbJoursMois(m2) & " jours dans le mois de " & aNomMois(m2) & " ! (date 2)" & vbCrLf

                End If
            Else
                bDateValide2 = False
                str_MessageErreur = str_MessageErreur & "Il y a 12 mois dans une année ! (date 2)" & vbCrLf
            End If
        Else
            bDateValide2 = False
            str_MessageErreur = str_MessageErreur & "Un mois a 1 jour minimum  et 31 jours maximum ! (date 2)" & vbCrLf
        End If


        
        If ((a1 >= 1900) And (a1 <= 2100)) Then
            'c bon
        Else
            bDateValide1 = False
            str_MessageErreur = str_MessageErreur & "Année comprise entre 1900 et 2100 ! (date 1)" & vbCrLf
        End If
        If ((a2 >= 1900) And (a2 <= 2100)) Then
            'c bon
        Else
            bDateValide2 = False
            str_MessageErreur = str_MessageErreur & "Année comprise entre 1900 et 2100 ! (date 2)" & vbCrLf
        End If

        'Si date non valide le programme stop
        If bDateValide1 And bDateValide2 = True Then


            DTP_1.Value = j1 & "/" & m1 & "/" & a1
            DTP_2.Value = j2 & "/" & m2 & "/" & a2



            Inversion(Txt_j1.Text, Txt_m1.Text, Txt_a1.Text, Txt_j2.Text, Txt_m2.Text, Txt_a2.Text)

            'Initialisation
            j1 = Txt_j1.Text
            m1 = Txt_m1.Text
            a1 = Txt_a1.Text
            j2 = Txt_j2.Text
            m2 = Txt_m2.Text
            a2 = Txt_a2.Text


            'Calcul effectif
            'de la date à la fin du mois
            iNbJours += aNbJoursMois(m1) - j1

            ' tous les mois jusqu'à la fin de l'année
            For index = (m1 + 1) To 12
                iNbJours += aNbJoursMois(index)
            Next
            If ((m1 = 1) Or ((m1 = 2) And (j1 <= 29))) Then
                If (EstBissextille(a1)) Then
                    iNbJours += 1
                End If
            End If

            ' toutes les années entières entre a1 et a2
            If a1 < a2 Then
                For index = a1 + 1 To a2 - 1

                    If EstBissextille(index) Then
                        iNbJours += 366
                    Else
                        iNbJours += 365
                    End If

                Next
            End If

            ' tous les mois du début de l'année à m2-1
            For index = 1 To m2 - 1
                iNbJours += aNbJoursMois(index)
            Next
            If ((m2 > 2) Or ((m2 = 2) And (j2 = 29))) Then
                If (EstBissextille(a2)) Then
                    ' rien
                Else
                    iNbJours -= 1
                End If
            End If

            If m1 > 2 Then
                iNbJours += 1
            End If

            ' tous les jours du début du mois m2 à j2
            iNbJours += j2 - 1


            If a1 = a2 Then
                If EstBissextille(a1) Then
                    iNbJours -= 366
                Else
                    iNbJours -= 365
                End If
            End If

            Txt_Res.Text &= "il y a " & iNbJours & " jour(s) entre " & j1 & "/" & m1 & "/" & a1 & " et " & j2 & "/" & m2 & "/" & a2 & vbCrLf

            Btn_Verifie.Visible = True
        Else
            Txt_Res.Text = str_MessageErreur
        End If
    End Sub

    Public Function EstBissextille(ByVal iMonAnnee As Integer) As Boolean
        Dim bRes As Boolean
        If (((iMonAnnee Mod 4 = 0) And (iMonAnnee Mod 100 <> 0)) Or (iMonAnnee Mod 400 = 0)) Then
            bRes = True
        Else
            bRes = False
        End If
        Return bRes
        ' Return (((iMonAnnee Mod 4 = 0) And (iMonAnnee Mod 100 <> 0)) Or (iMonAnnee Mod 400 = 0))
    End Function

    Public Sub Inversion(ByRef ijour1 As Integer, ByRef imois1 As Integer, ByRef iannee1 As Integer, ByRef ijour2 As Integer, ByRef imois2 As Integer, ByRef iannee2 As Integer)

        Dim bInversion As Boolean = False
        Dim iTemp As Integer
        Dim DtTemp As Date

        If (iannee1 < iannee2) Then
            'date 1 < date 2
        ElseIf (iannee1 > iannee2) Then
            bInversion = True
        ElseIf (imois1 < imois2) Then
            'date 1 < date 2
        ElseIf (imois1 > imois2) Then
            bInversion = True
        ElseIf (ijour1 < ijour2) Then
            'date 1 < date 2
        ElseIf (ijour1 > ijour2) Then
            bInversion = True
        Else

        End If

        If (bInversion = True) Then
            iTemp = ijour1
            ijour1 = ijour2
            ijour2 = iTemp
            iTemp = imois1
            imois1 = imois2
            imois2 = iTemp
            iTemp = iannee1
            iannee1 = iannee2
            iannee2 = iTemp
            DtTemp = DTP_1.Value
            DTP_1.Value = DTP_2.Value
            DTP_2.Value = DtTemp
        End If

    End Sub
   

    Private Sub Txt_Res_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Res.TextChanged

    End Sub

    Private Sub Btn_Verifie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Verifie.Click
        DTP_1.Visible = True
        DTP_2.Visible = True
        iNbJours = (DTP_2.Value - DTP_1.Value).TotalDays
        Txt_Res.Text &= vbCrLf & "nb jours = " & iNbJours
        DTP_1.Visible = False
        DTP_2.Visible = False
        Btn_Verifie.Visible = False
    End Sub
End Class
