Imports System.ComponentModel

Public Class contractFrm
    Dim tmpContractClass As DataBase.ContractClass

    Private Sub contractFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Dock = DockStyle.Fill
        CtusageType.DisplayMember = "name"
        Dim jj As List(Of DeliverCl) = (From tv In MyCatalor.usageType Select New DeliverCl With {.Id = tv.id, .Name = tv.name}).ToList.Cast(Of DeliverCl)
        jj.Insert(0, New DeliverCl)
        CtusageType.DataSource = jj

        Dim i As Integer = -1
        i = i + 1
        With DataGridView1
            .Columns.Add("A1", "Номер")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 100
            i = i + 1
            .Columns.Add("A2", "Дата")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 80
            i = i + 1
            .Columns.Add("A3", "Договор")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 200
            i = i + 1
            .Columns.Add("A4", "№ гос.регистрации")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 100
            i = i + 1
            .Columns.Add("A5", "Id")
            .Columns(i).Visible = False
            .Columns(i).Width = 100
            i = i + 1
            .Columns.Add("A6", "Состояние")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 100
            Refreh()
        End With
        Button4.Visible = True
        Button3.Visible = True
        Button5.Visible = True
    End Sub



    Function CheckTextBox() As Boolean
        If ctnumber.Text = "" Or cttype.Text = "" Then
            MsgBox("Проверте у вас некоторые поля не заполнены.", MsgBoxStyle.Exclamation, "")
            Return False
        End If
        If myDataBase.Contract.Exists(Function(x) (ctnumber.Text = x.CTnumber And ctdate.Value = x.CTdate)) Then
            MsgBox("Похожий котнтракт с таким номером и датой уже существует ", MsgBoxStyle.Exclamation, "Совпадение")
            Return False
        End If
        Return True
    End Function

    Private Sub FillForm()
        With tmpContractClass
            ID.Text = .ID
            ContractActive.Checked = .ContractActive
            ctapprovingDate.Value = .CTapprovingDate
            ctapprovingProject.Text = .CTapprovingProject
            ctdate.Value = .CTdate
            ctnumber.Text = .CTnumber
            ctregistrationNumber.Text = .CTregistrationNumber
            cttype.Text = .CTtype
            Dim a As List(Of DeliverCl) = CtusageType.DataSource
            CtusageType.SelectedIndex = a.FindIndex(Function(x) x = .CTusageType)
        End With
    End Sub

    Private Sub AutoFull(c As DataBase.ContractClass)
        Dim fn = Function(a As List(Of DataBase.ContractClass)) As Integer ' создает уникальный ID дял строки 
                     Dim i As Integer = a.Count + 1
                     While a.Exists(Function(x) x.ID = i) = True
                         i += 1
                     End While
                     Return i
                 End Function
        With c
            If .ID = -1 Then .ID = fn(myDataBase.Contract)
            .CTapprovingDate = ctapprovingDate.Value
            .CTapprovingProject = ctapprovingProject.Text
            .CTdate = ctdate.Value
            .CTnumber = ctnumber.Text
            .CTregistrationNumber = ctregistrationNumber.Text
            .CTtype = cttype.Text
            .CTusageType = DirectCast(CtusageType.SelectedValue, DeliverCl)
            .ContractActive = ContractActive.Checked
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckTextBox() = False Then Exit Sub
        AutoFull(tmpContractClass)
        Refreh()
        Panel1.Visible = True
    End Sub

    Sub Refreh()
        DataGridView1.Rows.Clear()
        myDataBase.Contract.ForEach(Sub(tv) DataGridView1.Rows.Add(tv.toRow()))
    End Sub

    Public Sub SelectContract(a As DataBase.ContractClass)
        With Form1
            myDoc.header.contract.type = a.CTtype
            myDoc.header.contract.number = a.CTnumber
            myDoc.header.contract.date = a.CTdate
            myDoc.header.contract.registrationNumber = a.CTregistrationNumber
        End With
    End Sub

    '-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=--=-==-=-=-=-=-==-=-=-=-==-=-=-=-==-=--=-=-=-=--=-=-=--=-=--=-=-=--=-=-=+-

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If CheckTextBox() = False Then Exit Sub
        AutoFull(tmpContractClass)
        myDataBase.Contract.Add(tmpContractClass)
        Refreh()
        Panel1.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Visible = False
        tmpContractClass = New DataBase.ContractClass
        Button1.Visible = False
        Button10.Visible = True
        FillForm()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If IsNothing(DataGridView1.CurrentCell) Then Exit Sub

        Panel1.Visible = False
        tmpContractClass = myDataBase.Contract.Find(Function(x) x.ID = DataGridView1.CurrentRow.Cells(4).Value)
        Button1.Visible = True
        Button10.Visible = False
        FillForm()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If IsNothing(DataGridView1.CurrentCell) Then Exit Sub
        If MsgBox("Удалить строку ?", MsgBoxStyle.OkCancel, "") = MsgBoxResult.Cancel Then Exit Sub
        myDataBase.Contract.RemoveAt(myDataBase.Contract.FindIndex(Function(x) x.ID = DataGridView1.CurrentRow.Cells(4).Value))
        Refreh()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If IsNothing(DataGridView1.CurrentCell) Then Exit Sub
        tmpContractClass = myDataBase.Contract.Find(Function(x) x.ID = DataGridView1.CurrentRow.Cells(4).Value)
        SelectContract(tmpContractClass)
        myDataBase.DefaultContract = tmpContractClass
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub contractFrm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SaveXmlDataBase()
        Form1.Enabled = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel1.Visible = True
    End Sub

End Class