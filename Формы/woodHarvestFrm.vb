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
            If tree.SelectedValue IsNot Nothing Then .tree = DirectCast(tree.SelectedValue, DeliverCl)
        End With
    End Sub

    Dim colError As Color = Color.MistyRose


    Private Sub woodHarvestFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        typeCutting.DisplayMember = "name"
        typeCutting.DataSource = (From tv In MyCatalor.typeCutting Select New DeliverCl With {.Id = tv.id, .Name = tv.name}).ToList.Cast(Of DeliverCl)
        wood.DisplayMember = "description"
        wood.DataSource = (From tv In MyCatalor.wood Select New DeliverCl With {.Id = tv.id, .Name = tv.name, .Description = tv.okpd & " " & tv.name}).ToList.Cast(Of DeliverCl)

        forestry.DisplayMember = "name"
        forestry.DataSource = (From tv In MyCatalor.forestry Where tv.subject.id = CType(Form1.ComboBox2.SelectedValue, DeliverCl).Id Select New DeliverCl With {.Id = tv.id, .Name = tv.name}).ToList.Cast(Of DeliverCl)

        subforestry.DisplayMember = "name"
        subforestry.DataSource = (From tv In MyCatalor.subforestry Where tv.subject.id = CType(Form1.ComboBox2.SelectedValue, DeliverCl).Id Select New DeliverCl With {.Id = tv.id, .Name = tv.name}).ToList.Cast(Of DeliverCl)

        sortiment.DisplayMember = "name"
        '    Dim arr As List(Of DeliverCl) = (From tv In MyCatalor.wood Where Not tv.tnved = "" Select New DeliverCl With {.id = tv.id, .name = tv.okpd & " " & tv.name}).ToArray.Cast(Of DeliverCl)
        '   arr.Insert(0, New DeliverCl)
        ' sortiment.DataSource = arr

        tree.DisplayMember = "name"
        Dim arr As List(Of DeliverCl) = (From tv In MyCatalor.tree Select New DeliverCl With {.Id = tv.id, .Name = tv.name & "-" & tv.abbreviation, .Description = tv.abbreviation}).ToList.Cast(Of DeliverCl)
        arr.Insert(0, New DeliverCl)
        tree.DataSource = arr

        tract.DisplayMember = "name"
        Dim ar As List(Of DeliverCl) = (From tv In MyCatalor.tract Where tv.subject.id = CType(Form1.ComboBox2.SelectedValue, DeliverCl).Id Select New DeliverCl With {.Id = tv.id, .Name = tv.name}).ToList.Cast(Of DeliverCl)
        ar.Insert(0, New DeliverCl)
        tract.DataSource = ar

        'formCutting.Items.Clear()
        'formCutting.Items.AddRange(myDataBase.TypeCutting.ToArray)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim k As Boolean = False
        Dim mTBox(1) As TextBox
        mTBox(0) = quarter
        mTBox(1) = taxationUnit
        'mTBox(2) = cuttingArea
        For i = 0 To mTBox.Length - 1
            If mTBox(i).Text = "" Or mTBox(i).Text = "0" Then
                mTBox(i).BackColor = Color.LightSalmon
                k = True
            Else
                mTBox(i).BackColor = Color.WhiteSmoke
            End If
        Next
        'Dim mNum(1) As NumericUpDown
        'mNum(0) = areaSquare
        'mNum(1) = areaCutting
        'For i = 0 To mNum.Length - 1
        '    If CInt(mNum(i).Value) = 0 Then
        '        mNum(i).BackColor = Color.LightSalmon
        '        k = True
        '    Else
        '        mNum(i).BackColor = Color.WhiteSmoke
        '    End If
        'Next
        Dim mCBox(2) As ComboBox
        mCBox(0) = farm
        mCBox(1) = formCutting
        mCBox(2) = wood
        For i = 0 To mCBox.Length - 1
            If mCBox(i).Text = "" Then
                mCBox(i).SelectedIndex = 0
            End If
        Next
        If k = True Then
            MsgBox("Проверте. Обязательные поля не заполнены.", MsgBoxStyle.Information, "")
            Exit Sub
        End If

        Dim a As New forestUsageReport.woodHarvestingRow
        AutoFull(a)
        myDoc.woodHarvesting.Add(a)
        Form1.Refreh_woodHarvesting()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
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

    Private Sub cuttingArea_LostFocus(sender As Object, e As EventArgs) Handles cuttingArea.LostFocus
        ЦелоеЧисло(sender)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If myDoc.attachments.Count <> 0 Then
            Dim d$ = Join((myDoc.attachments.Select(Of String)(Function(x) x.name)).Cast(Of String).ToArray, "; ")
            note.Text = $"Прикрепленные файлы всего: {myDoc.attachments.Count}. {d}"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmFinder.Show()
        FrmFinder.LoadComponent(tree)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrmFinder.Show()
        FrmFinder.LoadComponent(wood)
    End Sub

    Private Sub formCutting_SelectedIndexChanged(sender As Object, e As EventArgs) Handles formCutting.SelectedIndexChanged

    End Sub

    Private Sub formCutting_LostFocus(sender As Object, e As EventArgs) Handles formCutting.LostFocus
        myDataBase.ExistTypeCutting(formCutting)
    End Sub
End Class