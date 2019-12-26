Imports System.Data.SqlClient

Public Class Frm_Admin

    Dim Ligne As Integer
    Public Header As Boolean = False
    Private Sub Frm_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'ProjetActiveDataSet3.PS_CD_ListingPStockée'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.PS_CD_ListingPStockéeTableAdapter.Fill(Me.ProjetActiveDataSet3.PS_CD_ListingPStockée)
        'TODO: cette ligne de code charge les données dans la table 'ProjetActiveDataSet3.PS_CD_ListingPStockée'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.PS_CD_ListingPStockéeTableAdapter.Fill(Me.ProjetActiveDataSet3.PS_CD_ListingPStockée)


    End Sub

    Public Sub DGV_copie(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv_ListeProcedure.CellContentClick

        'Fonctionne que si une cellule contient quelquechose ou si elle n'est pas une entête
        If Me.Dgv_ListeProcedure.CurrentCell.Value <> Nothing And Header = False Then

            Ligne = Me.Dgv_ListeProcedure.CurrentCell.RowIndex()
            Txt_Procedure.Text = Dgv_ListeProcedure(0, Ligne).Value
            Txt_Text.Text = Dgv_ListeProcedure(1, Ligne).Value

            myCmd = myConn.CreateCommand
            myCmd.CommandType = CommandType.StoredProcedure

            myCmd.CommandText = "PS_CD_DetailProcedure"

            'Open the connection.
            myConn.Open()

            myCmd.Parameters.Add("@Text", SqlDbType.NVarChar).Value = Txt_Text.Text
            myCmd.Parameters.Add("@Procedure", SqlDbType.NVarChar).Value = Txt_Procedure.Text


            myCmd.ExecuteNonQuery()

            myReader = myCmd.ExecuteReader()
            myReader.Read()

            Txt_Text.Text = myReader.GetString(0)


            myConn.Close()

            myCmd = myConn.CreateCommand
            myCmd.CommandType = CommandType.StoredProcedure

            myCmd.CommandText = "PS_CD_DetailProcedureCode"

            'Open the connection.
            myConn.Open()

            myCmd.Parameters.Add("@TextCode", SqlDbType.NVarChar).Value = Txt_Text.Text
            myCmd.Parameters.Add("@ProcedureCode", SqlDbType.NVarChar).Value = Txt_Procedure.Text


            myCmd.ExecuteNonQuery()

            myReader = myCmd.ExecuteReader()
            myReader.Read()

            Txt_TextCode.Text = myReader.GetString(0)


            myConn.Close()

        End If

        Header = False

    End Sub

    Private Sub Btn_Retour_Click(sender As Object, e As EventArgs) Handles Btn_Retour.Click

        Frm_Accueil.Show()
        Me.Close()
    End Sub
End Class