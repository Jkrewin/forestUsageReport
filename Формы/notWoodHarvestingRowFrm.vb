Public Class notWoodHarvestingRowFrm
    Public Property EditRow As forestUsageReport.notWoodHarvestingRow = Nothing
    Dim colError As Color = Color.MistyRose
    Function ПроверкаЗаполнения() As Boolean
        Dim b As Boolean = True
        If area.Value = 0 Then area.BackColor = colError : b = False
        If usageType.Text = "" Then usageType.BackColor = colError : b = False
        If b = False Then MsgBox("Основные поля не заполнены!", MsgBoxStyle.Information, "")
        Return b
    End Function

    Private Sub notWoodHarvestingRowFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        forestry.DisplayMember = "name"
        forestry.DataSource = (From tv In MyCatalor.forestry Where tv.subject.id = CType(Form1.ComboBox2.SelectedValue, DeliverCl).Id Select New DeliverCl With {.Id = tv.id, .Name = tv.name}).ToList.Cast(Of DeliverCl)

        subforestry.DisplayMember = "name"
        subforestry.DataSource = (From tv In MyCatalor.subforestry Where tv.subject.id = CType(Form1.ComboBox2.SelectedValue, DeliverCl).Id Select New DeliverCl With {.Id = tv.id, .Name = tv.name}).ToList.Cast(Of DeliverCl)

        tract.DisplayMember = "name"
        Dim ar As List(Of DeliverCl) = (From tv In MyCatalor.tract Where tv.subject.id = CType(Form1.ComboBox2.SelectedValue, DeliverCl).Id Select New DeliverCl With {.Id = tv.id, .Name = tv.name}).ToList.Cast(Of DeliverCl)
        ar.Insert(0, New DeliverCl)
        tract.DataSource = ar

        resourceType.DisplayMember = "name"
        Dim ar2 As List(Of DeliverCl) = (From tv In MyCatalor.resource Select New DeliverCl With {.Id = tv.id, .Name = tv.name, .Description = ""}).ToList.Cast(Of DeliverCl)
        ar2.Insert(0, New DeliverCl)
        resourceType.DataSource = ar2

        unitType.DisplayMember = "name"
        unitType.DataSource = (From tv In MyCatalor.unitType Select New DeliverCl With {.Id = tv.id, .Name = tv.name}).ToList.Cast(Of DeliverCl)

        usageType.DisplayMember = "name"
        usageType.DataSource = (From tv In MyCatalor.usageType Select New DeliverCl With {.Id = tv.id, .Name = tv.name}).ToList.Cast(Of DeliverCl)

    End Sub

    Private Sub AutoFull(ByRef a As forestUsageReport.notWoodHarvestingRow)
        With a
            If usageType.SelectedValue IsNot Nothing Then .usageType = DirectCast(usageType.SelectedValue, DeliverCl)
            If forestry.SelectedValue IsNot Nothing Then .location.forestry = DirectCast(forestry.SelectedValue, DeliverCl)
            If subforestry.SelectedValue IsNot Nothing Then .location.subforestry = DirectCast(subforestry.SelectedValue, DeliverCl)
            If tract.SelectedValue IsNot Nothing Then .location.tract = DirectCast(tract.SelectedValue, DeliverCl)
            If Not quarter.Text = "" Then .location.quarter = quarter.Text
            If Not taxationUnit.Text = "" Then .location.taxationUnit = taxationUnit.Text
            If resourceType.SelectedValue IsNot Nothing Then .resourceType = DirectCast(resourceType.SelectedValue, DeliverCl)
            If unitType.SelectedValue IsNot Nothing Then .unitType = DirectCast(unitType.SelectedValue, DeliverCl)
            .area = area.Text
            .volume = volume.Text
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ПроверкаЗаполнения() = False Then Exit Sub
        Dim a As New forestUsageReport.notWoodHarvestingRow
        AutoFull(a)
        myDoc.notWoodHarvesting.Add(a)
        Form1.Refreh_woodHarvesting()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If ПроверкаЗаполнения() = False Then Exit Sub
        If EditRow Is Nothing Then Exit Sub
        AutoFull(EditRow)
        Form1.Refreh_woodHarvesting()
        Me.Close()
    End Sub

    Private Sub quarter_LostFocus(sender As Object, e As EventArgs) Handles quarter.LostFocus
        ЦелоеЧисло(sender)
    End Sub

    Private Sub taxationUnit_LostFocus(sender As Object, e As EventArgs) Handles taxationUnit.LostFocus
        ЦелоеЧисло(sender)
    End Sub
End Class