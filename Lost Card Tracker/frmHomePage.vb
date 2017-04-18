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
Public Class frmHomePage
     Dim _con As New MySqlConnection(ConfigurationManager.ConnectionStrings("myConnection").ConnectionString)
    Dim _cmd As MySqlCommand
    Dim logintime As String
     Dim logindate As String
     Public username As String
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub txtusergroup_TextChanged(sender As Object, e As EventArgs) Handles txtusergroup.TextChanged

    End Sub

    Private Sub timeIn_TextChanged(sender As Object, e As EventArgs) Handles timeIn.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub frmHomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _con.Open()
            Dim logoutdate As String = "LOGGED IN"
            Dim logout As String = "LOGGED IN"
            logintime= Now.ToLongTimeString
           logindate = Now.Date.ToString("dd/MM/yyyy")
            timeIn.Text = logintime
            dateIn.Text = logindate
            _cmd =
                New MySqlCommand(
                    "INSERT into LogTransactions(loginDate,loginTime,logoutDate,logoutTime,username) values ('" +
                    logindate + "','" + logintime + "','" + logoutdate + "','" + logout + "','" + lblUsername.Text +
                    "') ", _con)
            _cmd.ExecuteReader(CommandBehavior.CloseConnection)
            _cmd.Dispose()
            _con.Close()
        Catch ex As Exception
            _cmd.Dispose()
            _con.Close()
            'MsgBox(ex.Message)
        End Try
 
    End Sub

     Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        _cmd.Dispose()
        _con.Close()
        Try
            _con.Open()
           Dim logout As String = Now.ToLongTimeString
            Dim logoutdate As String = Now.Date.ToString("dd/MM/yyyy")
           _cmd =
                New mySQLCommand(
                    "UPDATE LogTransactions set logoutDate='" + logoutdate + "',logoutTime='" + logout + "' where username='" + username +
                    "' and loginDate='" + logindate + "' and loginTime='"+ logintime +"'", _con)
            _cmd.ExecuteNonQuery()
            _cmd.Dispose()
            _con.Close()

            Dispose()
        Catch ex As Exception
            _cmd.Dispose()
            _con.Close()
            MsgBox(ex.Message)
        End Try
       'FrmLogin.Show()
         
    End Sub

    Private Sub TileBarItem3_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileBarItem3.ItemClick
        if txtusergroup.Text="ADMIN"
            frmAdmin.ShowDialog()
            Else 
            MsgBox("You have no access rights to this page")
        End If
        
    End Sub

    Private Sub TileBarItem1_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileBarItem1.ItemClick
        frmCards.ShowDialog()
    End Sub

    Private Sub TileBarItem4_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileBarItem4.ItemClick
        if txtusergroup.Text="ADMIN"
             frmreportss.ShowDialog()
            Else 
            MsgBox("You have no access rights to this page")
        End If
       
    End Sub
End Class
