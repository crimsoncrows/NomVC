Imports System.IO
Imports System.Text.RegularExpressions
Imports Guna.UI2.WinForms

Public Class Homepage
    Private Sub services_tbl_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadOwner()




    End Sub

    Public Sub loadOwner()
        Dim loadOwnerTbl As String = IO.Path.Combine(Application.StartupPath, "..\..\Resources\Text Files\NomVC_owners.txt")
        Dim ownerInfos As String() = IO.File.ReadAllLines(loadOwnerTbl)
        For Each line As String In ownerInfos
            Dim fields As String() = line.Split("|"c)
            If fields.Length >= 5 Then
                tblOwners.Rows.Add(fields(0), fields(1), fields(2), fields(3), fields(4))
            End If
        Next
    End Sub





    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnClearRec.Click

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles tabOwners.Click

    End Sub

    Private Sub Guna2TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2TabControl1.SelectedIndexChanged

    End Sub

    Private Sub tabcreateApp_Click(sender As Object, e As EventArgs) Handles tabcreateApp.Click

    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Application.Exit()
    End Sub

    Private Sub btnAddRec_Click(sender As Object, e As EventArgs) Handles btnAddRec.Click

        Dim regex1 As New Regex("^[0-9+\-()\s]+$")
        If regex1.IsMatch(txtOwnerID.Text) Then

            Dim found As Boolean = False

            For i As Integer = 0 To tblOwners.Rows.Count - 1
                If tblOwners.Rows(i).Cells(0).Value IsNot Nothing AndAlso
                 tblOwners.Rows(i).Cells(0).Value.ToString() = txtOwnerID.Text Then

                    MessageBox.Show("Same owner id found: " &
                            tblOwners.Rows(i).Cells(1).Value.ToString())
                    tblOwners.CurrentCell = tblOwners.Rows(i).Cells(0)
                    found = True
                    Exit For
                End If
            Next

            If Not found Then
                Dim ownerDetails As String = txtOwnerID.Text + "|" + txtOwnerName.Text + "|" + numOwnerAge.Value.ToString + "|" + cmbSex.Text + "|" + txtAddress.Text
                'READS AND WRITES DIRECTLY TO SOLUTION EXPLORER FILE, NOT LOCALLY STORED FILE (WILL CAUSE ERROR)'
                Dim projectFilePath As String = IO.Path.Combine(Application.StartupPath, "..\..\Resources\Text Files\NomVC_owners.txt")
                IO.File.AppendAllText(projectFilePath, ownerDetails & Environment.NewLine)
                tblOwners.Rows.Clear()
                loadOwner()
            End If

        Else
            NomVcMessageBox.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error
            NomVcMessageBox.Show("Invalid input or empty fields.", "Error")
        End If

















    End Sub

    Private Sub btnSearchOwner_Click(sender As Object, e As EventArgs) Handles btnSearchOwner.Click

    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtPetID.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkHasOwner.CheckedChanged

        'avoid duplicate owner entries'
        If chkHasOwner.Checked = True Then

            txtAddress.Visible = False
            txtOwnerName.Visible = False
            numOwnerAge.Visible = False
            cmbSex.Visible = False
            lblSex.Visible = False
            lblAgeO.Visible = False

        Else

            txtAddress.Visible = True
            txtOwnerName.Visible = True
            cmbSex.Visible = True
            lblSex.Visible = True
            lblAgeO.Visible = True
            numOwnerAge.Visible = False

        End If

    End Sub
End Class