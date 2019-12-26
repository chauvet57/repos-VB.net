Imports System.IO
Public Class Frm_Pendu
    'creation des tableaux
    Public alphabet() As String = {"A", "Z", "E", "R", "T", "Y", "U", "I", "O", "P", "Q", "S", "D", "F", "G", "H", "J", "K", "L", "M", "W", "X", "C", "V", "B", "N"}
    'Public Liste = New String() {"MEPRIS", "DEGENERER", "JARDIN", "DIFFORME", "MINUSCULE", "MECHANT", "SOUDAIN", "GRAPPLER", "BATAILLON", "DONNANT", "MONTAGNE", "DESTIN", "BIBERONNER", "PLANTATION", "PARADIS", "FIXATION", "CHAISE", "MUSCLE", "PEINDRE", "TELESCOPE", "ENCADREMENT", "TOBOGGAN", "BALANCE", "PLACARD", "BIERE", "BOUTEILLE", "ASSIETTE", "CONSOLE", "PANIER", "TELEVISION"}
    Public Tab_Temp As Char()
    Dim random As New Random()
    Dim Cpt_Faux As Boolean
    Dim Cpt_Vrai As Integer = 0
    Dim Cpt_Erreur As Integer = 10
    Dim caract_chercher As Char = "."
    Dim secondes As Integer


    Private Sub letterClicked(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'recupération du bouton cliqué
        If TypeOf sender Is Button Then

            'rendre le bouton cliqué en non cliquable
            CType(sender, Button).Enabled = False
            Cpt_Faux = False

            For index = 1 To Tab_Temp.Length
                'compteur de mauvaise réponse

                If Tab_Temp(index - 1) = CType(sender, Button).Text Then
                    CType(Me.Controls("Txt_" & index), TextBox).Visible = True
                    CType(sender, Button).BackColor = Color.Green
                    Cpt_Faux = True
                    Cpt_Vrai = Cpt_Vrai + 1

                End If

            Next

            Txt_Cpt_F.Text = ""
            'si mauvais réponse envoie des image du pendu

            If Cpt_Faux = False Then

                Ptbx_Image.Image = Img_Pendu.Images(10 - Cpt_Erreur)
                CType(sender, Button).BackColor = Color.Red

                Cpt_Erreur = Cpt_Erreur - 1

                If Cpt_Erreur > 0 Then
                    My.Computer.Audio.Play("Marteau_clou.wav")
                End If

                If Cpt_Erreur = 0 Then

                    Timer1.Stop()
                    Perdu.Show()

                End If
            End If

            If Cpt_Vrai = Tab_Temp.Length Then

                Timer1.Stop()
                Gagne.Show()

            End If
            'affichage du nombre essais restant
            Txt_Cpt_F.Text = Txt_Cpt_F.Text & "Il vous reste " & Cpt_Erreur & " essais"
            Txt_Nbr_Essais.Text = Cpt_Erreur
        End If

    End Sub

    Public Sub Frm_Pendu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'initialisation du compteur essais
        Txt_Cpt_F.Text = "Il vous reste 10 essais"
        'génération du clavier 
        For index = 0 To 25
            Dim button As New Button
            If index < 10 Then
                button.Top = 380
                button.Left = 50 + (index * 50)
            ElseIf index < 20 Then
                button.Top = 440
                button.Left = 50 + (index * 50) - 10 * 50
            Else
                button.Top = 500
                button.Left = 50 + (index * 50) - 18 * 50
            End If
            button.Name = "btn_" & alphabet(index)
            button.Font = New Font("Microsoft Sans Serif", 25, FontStyle.Regular)
            button.Text = alphabet(index).ToUpper()
            button.Size = New Size(45, 50)
            button.BackColor = Color.Gainsboro
            button.Visible = False

            AddHandler button.Click, AddressOf letterClicked
            Me.Controls.Add(button)
        Next
        'mise en place de l'image déco
        Ptbx_Image.Image = Img_Pendu.Images(10)

        'recuperation d'un mot aleatoire dans le fichier text
        Dim lines() As String = File.ReadAllLines("Mot_pendu.txt")
        Dim rand As Random = New Random
        Dim randomLine = lines(random.Next(lines.Length))


        'récupération d'un mot aléatoire dans le tableau liste
        Txt_Mot.Text = randomLine
        'comptage dans caratere 
        Dim Nbr_Char As Integer = Len(Txt_Mot.Text)
        'convertion de chaine de caractere en caractere
        Tab_Temp = Txt_Mot.Text.ToCharArray
        'génération des txtBox et des label , remplissage avec le mot selectionné
        For index = 1 To Nbr_Char
            Dim Txt_Mot_A_Trouver As New TextBox
            Dim Lbl_Tiret As New Label

            Txt_Mot_A_Trouver.Top = 320
            Txt_Mot_A_Trouver.Left = 20 + (index * 40)
            Txt_Mot_A_Trouver.Name = "Txt_" & index
            Txt_Mot_A_Trouver.Font = New Font("Microsoft Sans Serif", 25, FontStyle.Bold)
            Txt_Mot_A_Trouver.Size = New Size(45, 50)
            Txt_Mot_A_Trouver.BackColor = Color.Silver
            Txt_Mot_A_Trouver.BorderStyle = BorderStyle.None
            Txt_Mot_A_Trouver.TextAlign = HorizontalAlignment.Center
            Txt_Mot_A_Trouver.Text = Tab_Temp(index - 1)
            Txt_Mot_A_Trouver.Visible = False
            Me.Controls.Add(Txt_Mot_A_Trouver)

            Lbl_Tiret.Top = 340
            Lbl_Tiret.Left = 20 + (index * 40)
            Lbl_Tiret.Size = New Size(35, 3)
            Lbl_Tiret.BackColor = Color.Black
            Me.Controls.Add(Lbl_Tiret)

        Next


    End Sub

    Public Sub NouvellePartieToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NouvellePartieToolStripMenuItem.Click

        'reset pour démarrer une nouvelle partie
        Me.Controls.Clear()
        InitializeComponent()
        Frm_Pendu_Load(sender, e)
        secondes = 0
        Cpt_Erreur = 10
        Cpt_Vrai = 0

    End Sub

    Private Sub RègleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RègleToolStripMenuItem.Click
        Règles.Show()
    End Sub


    Private Sub AProposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AProposToolStripMenuItem.Click
        A_propos.Show()
    End Sub

    Public Sub Frm_Princ_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown


        caract_chercher = Char.ConvertFromUtf32(e.KeyValue)


        For index = 0 To 25
            If caract_chercher = alphabet(index) Then

                If CType(Me.Controls("Btn_" & caract_chercher), Button).Enabled = True Then

                    Cpt_Faux = False

                    For i_Temp = 1 To Tab_Temp.Length
                        'compteur de mauvaise réponse

                        If Tab_Temp(i_Temp - 1) = caract_chercher Then

                            'affichage de la lettre si  présente dans le mot
                            CType(Me.Controls("Txt_" & i_Temp), TextBox).Visible = True

                            'recherche du bouton dans la form , changement de couleur du bouton et non cliquable
                            CType(Me.Controls("Btn_" & caract_chercher), Button).Enabled = False
                            CType(Me.Controls("Btn_" & caract_chercher), Button).BackColor = Color.Green

                            Cpt_Faux = True
                            Cpt_Vrai = Cpt_Vrai + 1

                        End If

                    Next
                    Txt_Cpt_F.Text = ""

                    'si mauvais réponse envoie des image du pendu
                    If Cpt_Faux = False Then

                        'recherche du bouton dans la form , changement de couleur du bouton et non cliquable
                        CType(Me.Controls("Btn_" & caract_chercher), Button).Enabled = False
                        CType(Me.Controls("Btn_" & caract_chercher), Button).BackColor = Color.Red
                        Ptbx_Image.Image = Img_Pendu.Images(10 - Cpt_Erreur)

                        Cpt_Erreur = Cpt_Erreur - 1

                        If Cpt_Erreur > 0 Then
                            My.Computer.Audio.Play("Marteau_clou.wav")
                        End If

                        If Cpt_Erreur = 0 Then

                            Timer1.Stop()
                            Perdu.Show()

                        End If
                    End If

                    If Cpt_Vrai = Tab_Temp.Length Then

                        Timer1.Stop()
                        Gagne.Show()

                    End If
                    'affichage du nombre essais restant
                    Txt_Cpt_F.Text = Txt_Cpt_F.Text & "Il vous reste " & Cpt_Erreur & " essais"
                    Txt_Nbr_Essais.Text = Cpt_Erreur
                End If


            End If
        Next

    End Sub

    Private Sub Frm_Princ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub


    Public Sub tim_Chrono_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        secondes += 1
        Lbl_Temps.Text = secondes
    End Sub


    Private Sub ScoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScoreToolStripMenuItem.Click
        meilleur_scores.Show()
    End Sub

    Public Sub Btn_Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Start.Click
        Timer1.Start()
        Dim index As Integer

        For index = 0 To 25

            CType(Me.Controls("Btn_" & alphabet(index)), Button).Visible = True
        Next
    End Sub
End Class