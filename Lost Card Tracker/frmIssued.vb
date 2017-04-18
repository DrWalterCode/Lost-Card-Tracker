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
Public Class frmIssued
     Dim _con As New MySqlConnection(ConfigurationManager.ConnectionStrings("myConnection").ConnectionString)
    Dim _cmd As MySqlCommand

    Private Sub frmCards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         Loadgrid()
       i5.Text=frmHomePage.lblUsername.Text
        
       End Sub

    Private Sub Loadgrid()
        _con.Close()
        Try
            _con.Open()
            _cmd = New mysqlCommand("select * from cards where status='Pending' ", _con)
            Dim myda2 As mysqlDataAdapter = New mysqlDataAdapter(_cmd)
            Dim mydataset2 As DataSet = New DataSet
            myda2.Fill(mydataset2, "cards")
            DataGridView1.DataSource = mydataset2.Tables("cards").DefaultView
             DataGridView1.FirstDisplayedScrollingRowIndex=DataGridView1.RowCount-1
            DataGridView1.Rows(DataGridView1.RowCount-1).Selected=True
            DataGridView1.CurrentCell=DataGridView1.Rows(DataGridView1.RowCount-1).Cells(0)
            _con.Close()
        Catch ex As Exception
            _con.Close()
           ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        If i1.Text=""
            MsgBox("Select report first")
            Exit Sub
        End If
        Try
             _con.Close()
          _con.Open()
            _cmd =
                New MySqlCommand(
                    "update cards set status='Issued',date_issued='"+ Now.ToShortDateString()+"' ,issued_by='"+ i5.Text+"' where date='"+ i1.Text+"' and time='"+ i2.Text+"' and cell='"+ i3.Text+"' and account='"+ i4.Text+"' ", _con)
            _cmd.ExecuteNonQuery()
            _cmd.Dispose()
            _con.Close()
            MsgBox("Card Report Details Updated Successfully", vbInformation, "Success")
            cleartxt
             Loadgrid()
        Catch ex As Exception

        End Try
    End Sub
    Private  sub cleartxt
         i3.Text=""
         i4.Text=""
         i1.Text=""
         i2.Text=""
       End sub
     Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) _
        Handles DataGridView1.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            i1.Text = dr.Cells(1).Value.ToString
            i2.Text = dr.Cells(2).Value.ToString
            i3.Text = dr.Cells(3).Value.ToString
            i4.Text = dr.Cells(4).Value.ToString
           Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmIssued_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub
End Class
