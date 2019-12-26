Imports System.Data.SqlClient

Module Variables
    Public str_Nom As String = ""
    Public str_critere As String = "%e%"
    Public dt As New DataTable
    Public adapt As New SqlDataAdapter
    Public myConn As SqlConnection
    Public myCmd As SqlCommand
    Public myReader As SqlDataReader
    Public results As String
    Public machainedeconnexion = "Initial Catalog=ProjectActive;Data Source=DESKTOP-PVJFRGN\SQLEXPRESS;Integrated Security=SSPI;"
End Module
