Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports System.Configuration.ConfigurationManager
Imports System.Management
Imports Microsoft.Win32
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.DirectoryServices
Imports System.Net
Imports System.IO
Public Class frmreportss
     Dim _con As New MySqlConnection(ConfigurationManager.ConnectionStrings("myConnection").ConnectionString)
    Dim _cmd As MySqlCommand

    Private Sub frmCards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub frmreportss_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
         Dispose()
    End Sub
End Class
