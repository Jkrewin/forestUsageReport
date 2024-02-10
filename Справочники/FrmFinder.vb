Public Class FrmFinder

    Private Property SelectedCBox As ComboBox

    Private Sub FrmFinder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Select()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Length > 2 Then
            Dim arr As List(Of DeliverCl) = SelectedCBox.DataSource
            Dim result = arr.FindAll(Function(x) InStr(x.Name.ToLower, TextBox1.Text.ToLower) <> 0)

            ListBox1.DataSource = result
        End If
    End Sub

    Public Sub LoadComponent(ByRef SelCBox As ComboBox)
        SelectedCBox = SelCBox
        ListBox1.DataSource = SelectedCBox.DataSource
        ListBox1.DisplayMember = "Name"
        ListBox1.ValueMember = "ID"

        If myDataBase.LastFinder.ContainsKey(SelectedCBox.Name) Then
            Button1.Visible = True
            Dim arr As List(Of DeliverCl) = SelectedCBox.DataSource
            Button1.Text = arr(myDataBase.LastFinder(SelectedCBox.Name)).Name
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedIndex = -1 Then Exit Sub
        Dim arr As List(Of DeliverCl) = SelectedCBox.DataSource
        SelectedCBox.SelectedIndex = arr.FindIndex(Function(x) x.Description = DirectCast(ListBox1.SelectedItem, DeliverCl).Description)

        If myDataBase.LastFinder.ContainsKey(SelectedCBox.Name) = False Then
            myDataBase.LastFinder.Add(SelectedCBox.Name, SelectedCBox.SelectedIndex)
        Else
            myDataBase.LastFinder(SelectedCBox.Name) = SelectedCBox.SelectedIndex
        End If
        Me.Close()
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        Button2_Click(Nothing, Nothing)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SelectedCBox.SelectedIndex = myDataBase.LastFinder(SelectedCBox.Name)
        Me.Close()
    End Sub
End Class