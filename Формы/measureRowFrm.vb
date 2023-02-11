Public Class measureRowFrm
    Public Property EditRow As forestUsageReport.measureRow = Nothing



    Dim colError As Color = Color.MistyRose
    Function ПроверкаЗаполнения() As Boolean
        Dim b As Boolean = True
        If area.Value = 0 Then area.BackColor = colError : b = False
        If objectCB.Text = "" Then objectCB.BackColor = colError : b = False
        If measure.Text = "" Then measure.BackColor = colError : b = False
        If b = False Then MsgBox("Основные поля не заполнены!", MsgBoxStyle.Information, "")
        Return b
    End Function

    Private Sub measureRowFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        measure.DisplayMember = "name"
        measure.DataSource = (From tv In MyCatalor.measure Select New DeliverCl With {.id = tv.id, .name = tv.name}).ToList.Cast(Of DeliverCl)

        objectCB.DisplayMember = "name"
        objectCB.DataSource = (From tv In MyCatalor.object Select New DeliverCl With {.id = tv.id, .name = tv.name}).ToList.Cast(Of DeliverCl)

        typeCutting.DisplayMember = "name"
        typeCutting.DataSource = (From tv In MyCatalor.typeCutting Select New DeliverCl With {.id = tv.id, .name = tv.name}).ToList.Cast(Of DeliverCl)

        wood.DisplayMember = "description"
        wood.DataSource = (From tv In MyCatalor.wood Select New DeliverCl With {.id = tv.id, .name = tv.name, .description = tv.okpd & " " & tv.name}).ToList.Cast(Of DeliverCl)

        forestry.DisplayMember = "name"
        forestry.DataSource = (From tv In MyCatalor.forestry Where tv.subject.id = CType(Form1.ComboBox2.SelectedValue, DeliverCl).id Select New DeliverCl With {.id = tv.id, .name = tv.name}).ToList.Cast(Of DeliverCl)

        subforestry.DisplayMember = "name"
        subforestry.DataSource = (From tv In MyCatalor.subforestry Where tv.subject.id = CType(Form1.ComboBox2.SelectedValue, DeliverCl).id Select New DeliverCl With {.id = tv.id, .name = tv.name}).ToList.Cast(Of DeliverCl)
    End Sub
    Private Sub AutoFull(ByRef a As forestUsageReport.measureRow)
        With a
            If measure.SelectedValue IsNot Nothing Then .measure = DirectCast(measure.SelectedValue, DeliverCl)
            If objectCB.SelectedValue IsNot Nothing Then .object = DirectCast(objectCB.SelectedValue, DeliverCl)
            If forestry.SelectedValue IsNot Nothing Then .location.forestry = DirectCast(forestry.SelectedValue, DeliverCl)
            If subforestry.SelectedValue IsNot Nothing Then .location.subforestry = DirectCast(subforestry.SelectedValue, DeliverCl)
            If tract.SelectedValue IsNot Nothing Then .location.tract = DirectCast(tract.SelectedValue, DeliverCl)
            If Not quarter.Text = "" Then .location.quarter = quarter.Text
            If Not taxationUnit.Text = "" Then .location.taxationUnit = taxationUnit.Text
            .area = area.Text
            .farm = farm.Text
            .formCutting = formCutting.Text
            If typeCutting.SelectedValue IsNot Nothing Then .typeCutting = DirectCast(typeCutting.SelectedValue, DeliverCl)
            If wood.SelectedValue IsNot Nothing Then .wood = DirectCast(wood.SelectedValue, DeliverCl)
            If sortiment.SelectedValue IsNot Nothing Then .sortiment = DirectCast(sortiment.SelectedValue, DeliverCl)
            .value = value_n.Text
            .commercialValue = commercialValue.Text
        End With
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ПроверкаЗаполнения() = False Then Exit Sub
        Dim a As New forestUsageReport.measureRow
        AutoFull(a)
        myDoc.measure.Add(a)
        Form1.ref_woodHarvesting()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If ПроверкаЗаполнения() = False Then Exit Sub
        If EditRow Is Nothing Then Exit Sub
        AutoFull(EditRow)
        Form1.ref_woodHarvesting()
        Me.Close()
    End Sub
End Class