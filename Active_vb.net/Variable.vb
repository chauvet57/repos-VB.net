Imports System.Data.SqlClient

Module Variables
    Public str_Nom As String = ""
    Public MaChaineDeConnexion = "Initial Catalog=ProjetActive;Data Source=PC-CDA07;Integrated Security=SSPI;"
    Public dt As New DataTable
    Public adapt As New SqlDataAdapter
    Public myConn As SqlConnection = New SqlConnection(MaChaineDeConnexion)
    Public myCmd As SqlCommand
    Public myReader As SqlDataReader
    Public results As String
End Module
