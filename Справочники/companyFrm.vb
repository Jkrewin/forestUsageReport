Imports System.ComponentModel

Public Class companyFrm
    Dim tmpCompanyClass As DataBase.company

    Private Sub companyFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox4.Location = New Point(20, 100)
        GroupBox5.Location = New Point(20, 100)

        Panel1.Dock = DockStyle.Fill

        Dim i As Integer = -1
        i = i + 1
        With DataGridView1
            .Columns.Add("A1", "Тип")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 150
            i = i + 1
            .Columns.Add("A2", "ИНН")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 100
            i = i + 1
            .Columns.Add("A3", "ОГРН")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 100
            i = i + 1
            .Columns.Add("A4", "Название")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 200
            i = i + 1
            .Columns.Add("A4", "ID")
            .Columns(i).Visible = False
            .Columns(i).Width = 40
        End With
        Refreh()
    End Sub

    Sub Refreh()
        Dim sb = Sub(a As DataBase.company)
                     DataGridView1.Rows.Add(a.toRow())
                     If CheckINN(a.inn) = False Then DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Style.BackColor = Color.Red
                     If checkOGRN(a.ogrn) = False Then DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(2).Style.BackColor = Color.Red
                 End Sub
        DataGridView1.Rows.Clear()
        myDataBase.Companies.ForEach(sb)
    End Sub

    Private Sub AutoFull(c As DataBase.company)
        Dim fn = Function(a As List(Of DataBase.company)) As Integer ' создает уникальный ID для строки 
                     Dim i As Integer = a.Count + 1
                     While a.Exists(Function(x) x.ID = i) = True
                         i += 1
                     End While
                     Return i
                 End Function
        If RadioButton1.Checked = True Then 'ип 
            With tmpCompanyClass
                .TypeCompany = DataBase.company.ETypeCompany.ИП
                .first_name = TextBox2.Text
                .inn = TextBox8.Text
                .last_name = TextBox3.Text
                .ogrn = TextBox9.Text
                .patronimic_name = TextBox4.Text
                .identity_document = New forestUsageReport.headerClass.partnerClass.identity_documentClass
                .identity_document.name = ComboBox2.Text
                .identity_document.number = TextBox5.Text
                .identity_document.series = TextBox6.Text
                .phone = TextBox1.Text
            End With
        ElseIf RadioButton2.Checked = True Then ' компания 
            With tmpCompanyClass
                .TypeCompany = DataBase.company.ETypeCompany.Компания
                .name = TextBox13.Text
                .address = TextBox14.Text
                .inn = TextBox11.Text
                .ogrn = TextBox12.Text
                .phone = TextBox10.Text
            End With
        ElseIf RadioButton3.Checked = True Then ' ЧЛ
            With tmpCompanyClass
                .TypeCompany = DataBase.company.ETypeCompany.ЧастноеЛицо
                .first_name = TextBox19.Text
                .inn = TextBox16.Text
                .last_name = TextBox18.Text
                .patronimic_name = TextBox17.Text
                .identity_document = New forestUsageReport.headerClass.partnerClass.identity_documentClass
                .identity_document.name = ComboBox1.Text
                .identity_document.number = TextBox20.Text
                .identity_document.series = TextBox21.Text
                .phone = TextBox15.Text
            End With
        End If
        If tmpCompanyClass.ID = -1 Then tmpCompanyClass.ID = fn(myDataBase.Companies)

    End Sub

    Private Sub FillForm()
        With tmpCompanyClass
            If .TypeCompany = DataBase.company.ETypeCompany.ИП Then
                RadioButton1.Checked = True
                TextBox2.Text = .first_name
                TextBox8.Text = .inn
                TextBox3.Text = .last_name
                TextBox9.Text = .ogrn
                TextBox4.Text = .patronimic_name
                ComboBox2.Text = .identity_document.name
                TextBox5.Text = .identity_document.number
                TextBox6.Text = .identity_document.series
                TextBox1.Text = .phone
            ElseIf .TypeCompany = DataBase.company.ETypeCompany.Компания Then
                RadioButton2.Checked = True
                .TypeCompany = DataBase.company.ETypeCompany.Компания
                TextBox13.Text = .name
                TextBox14.Text = .address
                TextBox11.Text = .inn
                TextBox12.Text = .ogrn
                TextBox10.Text = .phone
            Else
                RadioButton3.Checked = True
                .TypeCompany = DataBase.company.ETypeCompany.ЧастноеЛицо
                TextBox19.Text = .first_name
                TextBox16.Text = .inn
                TextBox18.Text = .last_name
                TextBox17.Text = .patronimic_name
                ComboBox1.Text = .identity_document.name
                TextBox20.Text = .identity_document.number
                TextBox21.Text = .identity_document.series
                TextBox15.Text = .phone
            End If
        End With
    End Sub

    Public Sub SelectCompany(a As DataBase.company)

        Form1.GroupBox5.Visible = False
        Form1.GroupBox8.Visible = False
        Form1.GroupBox9.Visible = False
        myDoc.header.partner.individualEntrepreneur = Nothing
        myDoc.header.partner.juridicalPerson = Nothing
        myDoc.header.partner.physicalPerson = Nothing

        If a.TypeCompany = DataBase.company.ETypeCompany.ИП Then
            myDoc.header.partner.individualEntrepreneur = New forestUsageReport.headerClass.partnerClass.individualEntrepreneurClass
            With myDoc.header.partner.individualEntrepreneur
                .first_name = a.first_name
                .inn = a.inn
                .last_name = a.last_name
                .ogrn = a.ogrn
                .patronimic_name = a.patronimic_name
                .identity_document = New forestUsageReport.headerClass.partnerClass.identity_documentClass
                .identity_document.name = a.identity_document.name
                .identity_document.number = a.identity_document.number
                .identity_document.series = a.identity_document.series
            End With
            Form1.GroupBox5.Visible = True
        ElseIf a.TypeCompany = DataBase.company.ETypeCompany.Компания Then
            myDoc.header.partner.juridicalPerson = New forestUsageReport.headerClass.partnerClass.juridicalPersonClass
            With myDoc.header.partner.juridicalPerson
                .name = a.name
                .address = a.address
                .inn = a.inn
                .ogrn = a.ogrn
            End With
            Form1.GroupBox8.Visible = True
        Else
            myDoc.header.partner.physicalPerson = New forestUsageReport.headerClass.partnerClass.physicalPersonClass
            With myDoc.header.partner.physicalPerson
                .first_name = a.first_name
                .inn = a.inn
                .last_name = a.last_name
                .patronimic_name = a.patronimic_name
                .identity_document = New forestUsageReport.headerClass.partnerClass.identity_documentClass
                .identity_document.name = a.identity_document.name
                .identity_document.number = a.identity_document.number
                .identity_document.series = a.identity_document.series
            End With
            Form1.GroupBox9.Visible = True
        End If
        myDoc.header.partner.phone = a.phone
    End Sub

    '-=-=-=-=-==-=-=-==-=-=-==-=-=-=-==-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=--=-=-=-=-=-=-=-=-=--=-=-=-=-=-=--=-=-=-=-=-

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If myDataBase.Companies.Exists(Function(x) tmpCompanyClass = x) Then
            MsgBox("Такая организация уже существует ", MsgBoxStyle.Exclamation, "Совпадение")
            Exit Sub
        End If
        AutoFull(tmpCompanyClass)
        myDataBase.Companies.Add(tmpCompanyClass)
        Refreh()
        Panel1.Visible = True
    End Sub


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        GroupBox1.Visible = True
        GroupBox5.Visible = False
        GroupBox4.Visible = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        GroupBox1.Visible = False
        GroupBox5.Visible = False
        GroupBox4.Visible = True
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        GroupBox1.Visible = False
        GroupBox5.Visible = True
        GroupBox4.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Visible = False
        tmpCompanyClass = New DataBase.company
        Button1.Visible = False
        Button10.Visible = True
        FillForm()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AutoFull(tmpCompanyClass)
        Refreh()
        Panel1.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If IsNothing(DataGridView1.CurrentCell) Then Exit Sub

        Panel1.Visible = False
        tmpCompanyClass = myDataBase.Companies.Find(Function(x) x.ID = DataGridView1.CurrentRow.Cells(4).Value)
        Button1.Visible = True
        Button10.Visible = False
        FillForm()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If IsNothing(DataGridView1.CurrentCell) Then Exit Sub
        If MsgBox("Удалить строку ?", MsgBoxStyle.OkCancel, "") = MsgBoxResult.Cancel Then Exit Sub
        myDataBase.Companies.RemoveAt(myDataBase.Companies.FindIndex(Function(x) x.ID = DataGridView1.CurrentRow.Cells(4).Value))
        Refreh()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If IsNothing(DataGridView1.CurrentCell) Then Exit Sub
        tmpCompanyClass = myDataBase.Companies.Find(Function(x) x.ID = DataGridView1.CurrentRow.Cells(4).Value)
        SelectCompany(tmpCompanyClass)
        myDataBase.DefaultCompany = tmpCompanyClass
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub companyFrm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SaveXmlDataBase()
        Form1.Enabled = True
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        ЦелоеЧисло(sender)
    End Sub

    Private Sub TextBox10_LostFocus(sender As Object, e As EventArgs) Handles TextBox10.LostFocus
        ЦелоеЧисло(sender)
    End Sub

    Private Sub TextBox15_LostFocus(sender As Object, e As EventArgs) Handles TextBox15.LostFocus
        ЦелоеЧисло(sender)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel1.Visible = True
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        ФильтруетИмена(sender)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.LostFocus
        ФильтруетИмена(sender)
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.LostFocus
        ФильтруетИмена(sender)
    End Sub

    Private Sub TextBox19_TextChanged(sender As Object, e As EventArgs) Handles TextBox19.LostFocus
        ФильтруетИмена(sender)
    End Sub

    Private Sub TextBox18_TextChanged(sender As Object, e As EventArgs) Handles TextBox18.LostFocus
        ФильтруетИмена(sender)
    End Sub

    Private Sub TextBox17_TextChanged(sender As Object, e As EventArgs) Handles TextBox17.LostFocus
        ФильтруетИмена(sender)
    End Sub

    Private Sub TextBox9_LostFocus(sender As Object, e As EventArgs) Handles TextBox9.LostFocus
        ЦелоеЧисло(sender)
    End Sub

    Private Sub TextBox8_LostFocus(sender As Object, e As EventArgs) Handles TextBox8.LostFocus
        ЦелоеЧисло(sender)
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.LostFocus
        ЦелоеЧисло(sender)
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.LostFocus
        ЦелоеЧисло(sender)
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.LostFocus
        ЦелоеЧисло(sender)
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.LostFocus
        ЦелоеЧисло(sender)
    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.LostFocus
        ЦелоеЧисло(sender)
    End Sub

    Private Sub TextBox21_TextChanged(sender As Object, e As EventArgs) Handles TextBox21.LostFocus
        ЦелоеЧисло(sender)
    End Sub

    Private Sub TextBox20_TextChanged(sender As Object, e As EventArgs) Handles TextBox20.LostFocus
        ЦелоеЧисло(sender)
    End Sub


End Class