Public Class woodHarvestFrm
    Public Property EditRow As forestUsageReport.woodHarvestingRow = Nothing
    Private Sub AutoFull(ByRef a As forestUsageReport.woodHarvestingRow)
        With a
            .areaCutting = areaCutting.Value
            .areaSquare = areaSquare.Value
            .farm = farm.Text
            .formCutting = formCutting.Text
            .value = value_n.Value
            .note = note.Text
            If Not taxationUnit.Text = "" Then .location.taxationUnit = taxationUnit.Text
            If Not cuttingArea.Text = "" Then .location.cuttingArea = cuttingArea.Text
            If forestry.SelectedValue IsNot Nothing Then .location.forestry = DirectCast(forestry.SelectedValue, DeliverCl)
            If Not quarter.Text = "" Then .location.quarter = quarter.Text
            If subforestry.SelectedValue IsNot Nothing Then .location.subforestry = DirectCast(subforestry.SelectedValue, DeliverCl)
            If tract.SelectedValue IsNot Nothing Then .location.tract = DirectCast(tract.SelectedValue, DeliverCl)
            If sortiment.SelectedValue IsNot Nothing Then .sortiment = DirectCast(sortiment.SelectedValue, DeliverCl)
            If typeCutting.SelectedValue IsNot Nothing Then .typeCutting = DirectCast(typeCutting.SelectedValue, DeliverCl)
            If wood.SelectedValue IsNot Nothing Then .wood = DirectCast(wood.SelectedValue, DeliverCl)
        End With
    End Sub

    Dim colError As Color = Color.MistyRose
    Function ПроверкаЗаполнения() As Boolean
        Dim b As Boolean = True
        If areaSquare.Value = 0 Then areaSquare.BackColor = colError : b = False
        If areaCutting.Value = 0 Then areaCutting.BackColor = colError : b = False
        If farm.Text = "" Then farm.BackColor = colError : b = False
        If formCutting.Text = "" Then formCutting.BackColor = colError : b = False
        If typeCutting.Text = "" Then typeCutting.BackColor = colError : b = False
        If wood.Text = "" Then wood.BackColor = colError : b = False
        If b = False Then MsgBox("Основные поля не заполнены!", MsgBoxStyle.Information, "")
        Return b
    End Function

    Private Sub woodHarvestFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        typeCutting.DisplayMember = "name"
        typeCutting.DataSource = (From tv In MyCatalor.typeCutting Select New DeliverCl With {.id = tv.id, .name = tv.name}).ToList.Cast(Of DeliverCl)
        wood.DisplayMember = "description"
        wood.DataSource = (From tv In MyCatalor.wood Select New DeliverCl With {.id = tv.id, .name = tv.name, .description = tv.okpd & " " & tv.name}).ToList.Cast(Of DeliverCl)

        forestry.DisplayMember = "name"
        forestry.DataSource = (From tv In MyCatalor.forestry Where tv.subject.id = CType(Form1.ComboBox2.SelectedValue, DeliverCl).id Select New DeliverCl With {.id = tv.id, .name = tv.name}).ToList.Cast(Of DeliverCl)

        subforestry.DisplayMember = "name"
        subforestry.DataSource = (From tv In MyCatalor.subforestry Where tv.subject.id = CType(Form1.ComboBox2.SelectedValue, DeliverCl).id Select New DeliverCl With {.id = tv.id, .name = tv.name}).ToList.Cast(Of DeliverCl)

        sortiment.DisplayMember = "name"
        '    Dim arr As List(Of DeliverCl) = (From tv In MyCatalor.wood Where Not tv.tnved = "" Select New DeliverCl With {.id = tv.id, .name = tv.okpd & " " & tv.name}).ToArray.Cast(Of DeliverCl)
        '   arr.Insert(0, New DeliverCl)
        ' sortiment.DataSource = arr

        tract.DisplayMember = "name"
        Dim ar As List(Of DeliverCl) = (From tv In MyCatalor.tract Where tv.subject.id = CType(Form1.ComboBox2.SelectedValue, DeliverCl).id Select New DeliverCl With {.id = tv.id, .name = tv.name}).ToList.Cast(Of DeliverCl)
        ar.Insert(0, New DeliverCl)
        tract.DataSource = ar
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As New forestUsageReport.woodHarvestingRow
        AutoFull(a)
        myDoc.woodHarvesting.Add(a)
        Form1.ref_woodHarvesting()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If EditRow Is Nothing Then Exit Sub
        AutoFull(EditRow)
        Form1.ref_woodHarvesting()
        Me.Close()
    End Sub

    Private Sub quarter_LostFocus(sender As Object, e As EventArgs) Handles quarter.LostFocus
        ЦелоеЧисло(sender)
    End Sub

    Private Sub taxationUnit_LostFocus(sender As Object, e As EventArgs) Handles taxationUnit.LostFocus
        ЦелоеЧисло(sender)
    End Sub

    Private Sub cuttingArea_LostFocus(sender As Object, e As EventArgs) Handles cuttingArea.LostFocus
        ЦелоеЧисло(sender)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If myDoc.attachments.Count <> 0 Then
            Dim d$ = Join((myDoc.attachments.Select(Of String)(Function(x) x.name)).Cast(Of String).ToArray, "; ")
            note.Text = $"Прикрепленные файлы всего: {myDoc.attachments.Count}. {d}"
        End If
    End Sub
End Class