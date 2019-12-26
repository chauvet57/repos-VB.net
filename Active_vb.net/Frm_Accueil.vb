Imports System.Data.SqlClient
Public Class Frm_Accueil


    Private Sub Frm_Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' recuperation du login 
        Me.Text = str_Nom


        Lbl_Bienvenue.Text = str_Nom
        Lbl_Connect_Fonction.Text = "Vous êtes connecté en tant que :"

    End Sub




    Private Sub CollaborateurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CollaborateurToolStripMenuItem.Click

        Frm_Collaborateur.Show()
        Me.Hide()

    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click

        Frm_Admin.Show()

    End Sub
End Class