Public Class Homepage
    Private Sub services_tbl_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadServices()

    End Sub

    Public Sub loadServices()

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



        Dim line As String = "hi"

        Dim filePath As String = IO.Path.Combine(Application.StartupPath, "NomVC_owners.txt")

        IO.File.AppendAllText(filePath, line & Environment.NewLine)

        MessageBox.Show("Saved!")



    End Sub
End Class