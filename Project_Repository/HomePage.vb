Public Class HomePage

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
    End Sub

    Private Sub testBtn_Click(sender As Object, e As EventArgs) Handles testBtn.Click

        Dim id As String = Guid.NewGuid().ToString("D")

        If nameTb.Text = "" Then
            MessageBox.Show("Enter Repository Name.")
        ElseIf deptCb.SelectedItem = Nothing Then
            MessageBox.Show("Select Department")
        ElseIf yearLvlCb.SelectedItem = Nothing Then
            MessageBox.Show("Select Year Level")
        ElseIf nameTb.Text = nameTb.Text And deptCb.SelectedItem.ToString = deptCb.SelectedItem.ToString And yearLvlCb.SelectedItem.ToString = yearLvlCb.SelectedItem.ToString Then
            ListView1.Items.Add(New ListViewItem(New String() {id, nameTb.Text, deptCb.SelectedItem.ToString, yearLvlCb.SelectedItem.ToString, Now}))
            MessageBox.Show("Repository created")
        Else
            MessageBox.Show("Insufficient Data Provided. Try Again")

        End If

    End Sub

End Class
