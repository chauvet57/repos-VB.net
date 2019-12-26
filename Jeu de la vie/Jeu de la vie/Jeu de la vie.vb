Public Class Frm_Vie

    Dim iTaille As Integer = 45
    Dim random As New Random()
    Dim LaVie(iTaille, iTaille) As Boolean
    Dim LaVie2(iTaille, iTaille) As Boolean
    Dim Secondes As Integer = 0


    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Affichage(LaVie)

    End Sub


    Public Sub Affichage(ByVal LaVie(,) As Boolean)
        'Génération du damier
        Dim i As Integer
        Dim j As Integer

        For j = 0 To iTaille
            For i = 0 To iTaille
                Dim Damier As New PictureBox

                Damier.Name = "MaCase1" & i & "MaCase2" & j
                Damier.BackColor = Color.Beige
                Damier.Left = 16 * i
                Damier.Top = 16 * j
                Damier.Width = 15
                Damier.Height = 15

                Controls.Add(Damier)

            Next
        Next

    End Sub

    Public Sub Evolution_Vie(ByVal LaVie(,) As Boolean)
        'maintient,mort,naissance de la vie selon les retour boolean

        For i = 0 To iTaille
            For j = 0 To iTaille

                If LaVie(i, j) = True Then
                    CType(Me.Controls("MaCase1" & i & "MaCase2" & j), PictureBox).BackColor = Color.DarkRed
                Else
                    CType(Me.Controls("MaCase1" & i & "MaCase2" & j), PictureBox).BackColor = Color.Beige
                End If

            Next
        Next
    End Sub


    Public Sub Random_Vie(ByRef LaVie(,) As Boolean)
        'génération de la vie
        For i = 0 To iTaille
            For j = 0 To iTaille
                If random.Next(0, 9) < 3.5 Then
                    LaVie(i, j) = True
                Else
                    LaVie(i, j) = False
                End If
            Next
        Next


    End Sub

    Private Sub Vie_Evolue(ByRef LaVie(,) As Boolean)
        'designation des cellules autour de la vivante par les points cardinaux
        Dim NE, N, NO, O, SO, S, SE, E As Boolean
        'Nombre de cellules libre autour
        Dim iNbrCell As Integer
        'designation des cellules mirroirs
        Dim SorS, SorN, SorE, SorO As Integer

        'teste si les cases sorte pas du cadre 
        For i = 0 To iTaille
            For j = 0 To iTaille
                iNbrCell = 0


                If i + 1 >= iTaille Then
                    SorE = 0
                Else
                    SorE = i + 1
                End If

                If i - 1 < 0 Then
                    SorO = iTaille
                Else
                    SorO = i - 1
                End If

                If j - 1 < 0 Then
                    SorN = iTaille
                Else
                    SorN = j - 1
                End If

                If j + 1 >= iTaille Then
                    SorS = 0
                Else
                    SorS = j + 1
                End If

                'Distribution des valeur au case adjacente
                NE = LaVie(SorE, SorN)
                N = LaVie(i, SorN)
                NO = LaVie(SorO, SorN)
                O = LaVie(SorO, j)
                SO = LaVie(SorO, SorS)
                S = LaVie(i, SorS)
                SE = LaVie(SorE, SorS)
                E = LaVie(SorE, j)


                If NE Then
                    iNbrCell = iNbrCell + 1
                End If
                If N Then
                    iNbrCell += 1
                End If
                If NO Then
                    iNbrCell += 1
                End If
                If O Then
                    iNbrCell += 1
                End If
                If SO Then
                    iNbrCell += 1
                End If
                If S Then
                    iNbrCell += 1
                End If
                If SE Then
                    iNbrCell += 1
                End If
                If E Then
                    iNbrCell += 1
                End If

                'si deux cases collées  les case reste en vie
                If iNbrCell = 2 Then
                    LaVie2(i, j) = LaVie(i, j)
                End If
                'Naissance  
                If iNbrCell = 3 Then

                    LaVie2(i, j) = True
                End If
                'Mort
                If iNbrCell < 2 Or iNbrCell > 3 Then
                    LaVie2(i, j) = False
                End If

            Next
        Next
        'affichage de la nouvelle génération
        For i = 0 To iTaille
            For j = 0 To iTaille
                LaVie(i, j) = LaVie2(i, j)
            Next
        Next

    End Sub


    Private Sub GénérerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GénérerToolStripMenuItem.Click
        Random_Vie(LaVie)
        Evolution_Vie(LaVie)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Secondes += 1
        If Secondes = 400 Then
            Random_Vie(LaVie)
        End If

    End Sub

    Private Sub ChangerVie() Handles Timer1.Tick

        Evolution_Vie(LaVie)
        Vie_Evolue(LaVie)

    End Sub

    Private Sub QueLaVieBougeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QueLaVieBougeToolStripMenuItem.Click
        Timer1.Start()

    End Sub

    Private Sub StopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopToolStripMenuItem.Click
        Timer1.Stop()
    End Sub
End Class
