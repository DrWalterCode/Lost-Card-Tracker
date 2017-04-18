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
Public Class frmCards
     Dim _con As New MySqlConnection(ConfigurationManager.ConnectionStrings("myConnection").ConnectionString)
    Dim _cmd As MySqlCommand

    Private Sub frmCards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         Loadgrid()
        c1.Text = Now.Date.ToString("dd/MM/yyyy")
        c8.Text=frmHomePage.lblUsername.Text
        
       End Sub

    Private Sub Loadgrid()
        _con.Close()
        Try
            _con.Open()
            _cmd = New mysqlCommand("select * from cards ", _con)
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
        Try
             _con.Close()
          _con.Open()
            _cmd =
                New MySqlCommand(
                    "INSERT into cards(date,time,cell,account,report_type,account_balance,account_balance_after,operator) values ('" +
                    c1.Text + "','" + c2.Text + "','" + c3.Text + "','" + c4.Text +
                    "','" + c5.Text + "','" + c6.Text + "','" + c7.Text + "','" +
                    c8.Text + "')", _con)
            _cmd.ExecuteNonQuery()
            _cmd.Dispose()
            _con.Close()
            MsgBox("Card Report Details Saved Successfully", vbInformation, "Success")
            cleartxt
             Loadgrid()
        Catch ex As Exception

        End Try
    End Sub
    Private  sub cleartxt
         c3.Text=""
         c4.Text=""
         c5.SelectedIndex=-1
         c6.Text=""
         c7.Text=""
       End sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        c2.Text = Now.ToShortTimeString()
    End Sub

    Private Sub TileBarItem1_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileBarItem1.ItemClick
          _con.Close()
        Try
            _con.Open()
            _cmd = New mysqlCommand("select * from cards where report_type='Lost Card' ", _con)
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

    Private Sub TileBarItem2_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileBarItem2.ItemClick
         _con.Close()
        Try
            _con.Open()
            _cmd = New mysqlCommand("select * from cards where report_type='Stolen Card' ", _con)
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

    Private Sub TileBarItem3_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileBarItem3.ItemClick
         _con.Close()
        Try
            _con.Open()
            _cmd = New mysqlCommand("select * from cards where report_type='Damaged Card' ", _con)
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

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        MsgBox("Facity temporarily disabled")
    End Sub

    Private Sub frmCards_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
         Dispose()
    End Sub
End Class
