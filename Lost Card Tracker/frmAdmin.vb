﻿Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports System.Configuration.ConfigurationManager
Imports System.Management
Imports Microsoft.Win32
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.DirectoryServices
Imports System.Net
Imports System.IO
Public Class frmAdmin
     Dim _con As New MySqlConnection(ConfigurationManager.ConnectionStrings("myConnection").ConnectionString)
    Dim _cmd As MySqlCommand

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         Loadgrid()
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
         If txtUsername.Text = "" Or txtPassword.Text = "" Or TextBox1.Text = "" Then
            MsgBox("missing parameters")
            Exit Sub
        End If

        if txtUsername.Enabled=True
             Try
           _con.Open()
            _cmd = New mysqlCommand("INSERT into users(usergroup,UserName,Password,Email,Surname,Forename,Phone) values ('" & txtgroup.Text & "','" & txtUsername.Text & "', '" & txtPassword.Text & "','" + Email_addressTextBox.Text.ToLower + "', '" & txtsurname.Text.ToString.Replace("'", "''") & "', '" & txtforename.Text.ToString.Replace("'", "''") & "', '" & txtphonenumber.Text & "')", _con)
            _cmd.ExecuteReader(CommandBehavior.CloseConnection)
            _cmd.Dispose()
            _con.Close()
            MsgBox("User Details Saved")
            loadgrid()
            Catch ex As Exception
            _cmd.Dispose()
            _con.Close()
            MessageBox.Show(ex.Message, "Error")
        End Try
            Else 
           Try
            _con.Open()
            _cmd = New mysqlcommand("update users set usergroup='" + txtgroup.Text + "', Email='" + Email_addressTextBox.Text + "',Surname='" + txtsurname.Text + "',Forename='" + txtforename.Text + "',Phone='" + txtphonenumber.Text + "',password='" + txtPassword.Text + "' where UserName='" + txtUsername.Text + "' ", _con)
            _cmd.ExecuteReader(CommandBehavior.CloseConnection)
            _cmd.Dispose()
            _con.Close()
            MessageBox.Show("Record Updated")
                txtUsername.Enabled=True
                 SimpleButton6.Enabled = False
           loadgrid()
                 Catch ex As Exception
             _cmd.Dispose()
            _con.Close()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        End If
        txtgroup.Text = ""
            txtUsername.Text = ""
            txtPassword.Text = ""
            TextBox1.Text = ""
            Email_addressTextBox.Text = ""
            txtforename.Text = ""
            txtsurname.Text =""
            txtphonenumber.Text = ""
            
       End Sub
     Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            txtgroup.Text = dr.Cells(1).Value.ToString
            txtUsername.Text = dr.Cells(2).Value.ToString
            txtPassword.Text = dr.Cells(3).Value.ToString
            TextBox1.Text = dr.Cells(3).Value.ToString
            Email_addressTextBox.Text = dr.Cells(4).Value.ToString
            txtforename.Text = dr.Cells(6).Value.ToString
            txtsurname.Text = dr.Cells(5).Value.ToString
            txtphonenumber.Text = dr.Cells(7).Value.ToString
            txtUsername.Enabled = False
            SimpleButton7.Enabled = True
            Catch ex As Exception
        End Try
    End Sub
      Private Sub Loadgrid()
        _con.Close()
        Try
            _con.Open()
            _cmd = New mysqlCommand("select * from users ", _con)
            Dim myda2 As mysqlDataAdapter = New mysqlDataAdapter(_cmd)
            Dim mydataset2 As DataSet = New DataSet
            myda2.Fill(mydataset2, "users")
            DataGridView1.DataSource = mydataset2.Tables("users").DefaultView
             DataGridView1.FirstDisplayedScrollingRowIndex=DataGridView1.RowCount-1
            DataGridView1.Rows(DataGridView1.RowCount-1).Selected=True
            DataGridView1.CurrentCell=DataGridView1.Rows(DataGridView1.RowCount-1).Cells(0)
            _con.Close()
        Catch ex As Exception
            _con.Close()
           ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TileBarItem1_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileBarItem1.ItemClick
        If (Not System.IO.Directory.Exists("C:\SystemBackups")) Then
            System.IO.Directory.CreateDirectory("C:\SystemBackups")
        End If
        _cmd.Connection = _con
        _con.Open
        Dim mb As MySqlBackup = New MySqlBackup(_cmd)
        Dim filename as String="C:\SystemBackups\backup" & Now.ToShortDateString() &".sql"
        mb.ExportToFile(filename)
        _con.Close
        MsgBox("Backup Successful check C:\SystemBackups for backedup file")
    End Sub

    Private Sub TileBarItem2_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileBarItem2.ItemClick
         If (Not System.IO.Directory.Exists("C:\SystemBackups")) Then
            System.IO.Directory.CreateDirectory("C:\SystemBackups")
        End If
        _cmd.Connection = _con
        _con.Open
        Dim mb As MySqlBackup = New MySqlBackup(_cmd)
        Dim ofd As New OpenFileDialog
        dim filename as String
        If ofd.ShowDialog = DialogResult.OK AndAlso ofd.FileName <> "" Then
            filename= ofd.FileName
            End If
        mb.ImportFromFile(filename)
        _con.Close
        MsgBox("Restore Successful")
    End Sub

    Private Sub TileBarItem3_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileBarItem3.ItemClick
        MsgBox("Facility has been temporarily disabled")
    End Sub
End Class
