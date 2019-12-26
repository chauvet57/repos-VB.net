Imports System.Data.SqlClient
Public Class Frm_Collaborateur
    Public str_Valeur As Integer
    Dim Ligne As Integer
    Public Header As Boolean = False

    Private Sub Frm_Collaborateur_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_NewCollabo_Click(sender As Object, e As EventArgs) Handles Btn_NewCollabo.Click

        Frm_NouveauCollabo.Show()

    End Sub

    Public Sub Btn_ListeCollabo_Click(sender As Object, e As EventArgs) Handles Btn_ListeCollabo.Click

        'TODO: cette ligne de code charge les données dans la table 'ProjetActiveDataSet.PS_CD_ListeCollabo_InnerRapport'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.PS_CD_ListeCollabo_InnerRapportTableAdapter.Fill(Me.ProjetActiveDataSet.PS_CD_ListeCollabo_InnerRapport)

    End Sub

    Public Sub DGV_copie(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv_ListeCollabo.CellContentClick

        'Fonctionne que si une cellule contient quelquechose ou si elle n'est pas une entête
        If Me.Dgv_ListeCollabo.CurrentCell.Value <> Nothing And Header = False Then

            Ligne = Me.Dgv_ListeCollabo.CurrentCell.RowIndex()
            str_Valeur = Dgv_ListeCollabo(7, Ligne).Value
            Frm_FicheCollabo.Show()

        End If

        Header = False

    End Sub

    Private Sub Txt_Recherche_TextChanged(sender As Object, e As EventArgs) Handles Txt_RechercheNom.TextChanged

        'genere la liste complete (appel de la Sub) du datagrid
        Btn_ListeCollabo_Click(sender, e)

        'declaration variable source pour la recherche
        Dim Source As New BindingSource()

        ' recherche dans le data grid view
        Source.DataSource = Me.Dgv_ListeCollabo.DataSource

        'colonne regardé 
        Source.Filter = "STR_NOM  like '" + Txt_RechercheNom.Text + "%'"

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Txt_RechercheStatut.TextChanged

        Btn_ListeCollabo_Click(sender, e)

        'declaration variable source pour la recherche
        Dim Source As New BindingSource()

        ' recherche dans le data grid view
        Source.DataSource = Me.Dgv_ListeCollabo.DataSource

        'colonne regardé 
        Source.Filter = "STR_CODESTATUTCOLLABO  like '" + Txt_RechercheStatut.Text + "%'"
    End Sub

    Private Sub Txt_RechercheFonction_TextChanged(sender As Object, e As EventArgs) Handles Txt_RechercheFonction.TextChanged

        Btn_ListeCollabo_Click(sender, e)

        'declaration variable source pour la recherche
        Dim Source As New BindingSource()

        ' recherche dans le data grid view
        Source.DataSource = Me.Dgv_ListeCollabo.DataSource

        'colonne regardé 
        Source.Filter = "STR_CODEFONCTION  like '%" + Txt_RechercheFonction.Text + "%'"

    End Sub
    Private Sub HeaderClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Dgv_ListeCollabo.ColumnHeaderMouseClick

        Header = True

    End Sub

    Private Sub Btn_Retour_Click(sender As Object, e As EventArgs) Handles Btn_Retour.Click

        Frm_Accueil.Show()
        Me.Close()
    End Sub
End Class