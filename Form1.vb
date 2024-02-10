Imports System.ComponentModel
Imports System.IO.Compression
Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization


Public Class Form1
    ''' <summary>
    '''  каталог поумолчанию где ранее был сохранен файл 
    ''' </summary>
    Dim DefDir As String = ""
    Dim ErrorHub As String = ""
    Private Const F_NAME_SHOW = "Файл для просмотра"
    Private Const REAL_CH As String = vbCr
    Public Property PhoneTv As String = ""

    Public Property seriesTV
        Get
            Return TextBox24.Text
        End Get
        Set(value)
            TextBox24.Text = value
            TextBox6.Text = value
        End Set
    End Property
    Public Property NameTV
        Get
            Return TextBox7.Text
        End Get
        Set(value)
            TextBox7.Text = value
            TextBox25.Text = value
        End Set
    End Property
    Public Property numberTV
        Get
            Return TextBox23.Text
        End Get
        Set(value)
            TextBox23.Text = value
            TextBox5.Text = value
        End Set
    End Property

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text &= VERXSD

        'Dim get_last_ver As String = Split(VERXSD, "/").Last
        'Dim fileXSD As String = MyCurDir & "\Upload\forestUsageReport\" & get_last_ver & "\forestUsageReport.xsd"
        'If IO.File.Exists(fileXSD) = False Then
        '    LogError("Нет схемы, важно обновить схему '" & VERXSD & "' с сайта https://rosleshoz.gov.ru/")
        'Else
        '    Dim xsdDoc As XmlDocument = New XmlDocument()
        '    xsdDoc.Load(fileXSD)
        '    Dim schemaElement As XmlElement = xsdDoc.DocumentElement

        '    Dim simpleTypeNodes As XmlNodeList = schemaElement.GetElementsByTagName("xs:import")


        '    For Each item As XmlNode In simpleTypeNodes
        '        Dim m = item.Attributes("namespace").Value
        '    Next
        'End If


        If IO.Directory.Exists(MyCurDir & "\Upload") = False Then IO.Directory.CreateDirectory(MyCurDir & "\Upload")

        GroupBox8.Location = GroupBox5.Location
        GroupBox9.Location = GroupBox5.Location

        Dim rr As New IO.StreamReader(MyCurDirLib & "\commons.xml")
        Try
            Dim ss As New XmlSerializer(GetType(catalog))
            MyCatalor = ss.Deserialize(rr)
            rr.Close()
        Catch ex As Exception
            LogError(ex.Message)
        Finally
            rr.Dispose()
        End Try

        If IO.File.Exists(MyCurDir & "\DataBase.xml") = True Then
            Dim r As New IO.StreamReader(MyCurDir & "\DataBase.xml")
            Try
                Dim s As New XmlSerializer(GetType(DataBase))
                myDataBase = s.Deserialize(r)
            Catch ex As Exception
                LogError(ex.Message)
            Finally
                r.Dispose()
            End Try
        End If


        ComboBox2.DisplayMember = "name"
        Dim var As List(Of DeliverCl) = (From tv In MyCatalor.subject Select New DeliverCl With {.Id = tv.id, .Name = tv.name}).ToList.Cast(Of DeliverCl)
        var.Insert(0, New DeliverCl With {.Id = 0, .Name = " <Сначало выбирете регион> "})
        ComboBox2.DataSource = var

        ComboBox1.DisplayMember = "name"

        ' подготовка таблиц
        Dim i As Integer = -1
        With DataGridView1
            i += 1
            .Columns.Add("A1", "Наименование лесничества")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 100
            i += 1
            .Columns.Add("A2", "Участковое лесничество")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 100
            i += 1
            .Columns.Add("A3", "Урочища")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 60
            i += 1
            .Columns.Add("A5", "Кв")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 40
            i += 1
            .Columns.Add("A6", "Выд.")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 40
            i += 1
            .Columns.Add("A7", "Л.Выд.")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 50
            i += 1
            .Columns.Add("A8", "Га.Выд.")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 60
            i += 1
            .Columns.Add("A9", "Га.рубка")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 60
            i += 1
            .Columns.Add("A10", "Хозяйство")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 120
            i += 1
            .Columns.Add("A11", "Форма рубки")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 120
            i += 1
            .Columns.Add("A12", "Вид рубки")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 120
            i += 1
            .Columns.Add("A17", "Дерево")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 80
            i += 1
            .Columns.Add("A13", "породный")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 130
            i += 1
            .Columns.Add("A14", "сортиментный")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 140
            i += 1
            .Columns.Add("A15", "Объем")
            .Columns(i).ReadOnly = False
            .Columns(i).DefaultCellStyle.BackColor = Color.LightYellow
            .Columns(i).Width = 60
            i += 1
            .Columns.Add("A16", "Заметки")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 80
        End With

        With DataGridView2
            i = 0
            .Columns.Add("A1", "Вид использования лесов")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 300
            i += 1
            .Columns.Add("A2", "Наименование лесничества")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 100
            i += 1
            .Columns.Add("A3", "Участковое лесничество")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 100
            i += 1
            .Columns.Add("A4", "Урочища")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 60
            i += 1
            .Columns.Add("A5", "Кв")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 40
            i += 1
            .Columns.Add("A6", "Выд.")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 40
            i += 1
            .Columns.Add("A7", "Площадь га")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 50
            i += 1
            .Columns.Add("A8", "Вид ресурсов")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 150
            i += 1
            .Columns.Add("A9", "Ед. измер")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 60
            i += 1
            .Columns.Add("A10", "Объем")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 80
        End With

        With DataGridView3
            i = 0
            .Columns.Add("A1", "Наименование мероприятия")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 150
            i += 1
            .Columns.Add("A2", "Вид объекта")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 150
            i += 1
            .Columns.Add("A3", "Наименование лесничества")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 100
            i += 1
            .Columns.Add("A4", "Наименование участкового лесничества")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 100
            i += 1
            .Columns.Add("A5", "Наименование урочища ")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 100
            i += 1
            .Columns.Add("A6", "Кв")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 50
            i += 1
            .Columns.Add("A7", "Выдел")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 50
            i += 1
            .Columns.Add("A8", "Номер")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 50
            i += 1
            .Columns.Add("A9", "Площадь га")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 60
            i += 1
            .Columns.Add("A10", "Хозяйство")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 120
            i += 1
            .Columns.Add("A11", "Форма рубки")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 120
            i += 1
            .Columns.Add("A12", "вид рубки")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 120
            i += 1
            .Columns.Add("A13", "видовой")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 120
            i += 1
            .Columns.Add("A14", "сортиментный")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 120
            i += 1
            .Columns.Add("A15", "всего")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 50
            i += 1
            .Columns.Add("A15", "деловой")
            .Columns(i).ReadOnly = True
            .Columns(i).Width = 50
        End With

        ' начальные настройки базы данных
        If myDataBase.TypeCutting.Count = 0 Then myDataBase.TypeCutting = New List(Of String) From {{"Сплошная рубка"}, {"Выборочная рубка"}}

        'загрузка по умолчанию
        Me.WindowState = myDataBase.WinState
        If myDataBase.DefaultCompany IsNot Nothing Then companyFrm.SelectCompany(myDataBase.DefaultCompany)
        If myDataBase.DefaultContract IsNot Nothing Then contractFrm.SelectContract(myDataBase.DefaultContract)

        If Not myDataBase.DefaultSubject > ComboBox2.Items.Count - 1 Then ComboBox2.SelectedIndex = myDataBase.DefaultSubject
        If Not myDataBase.DefaultExecutiveAuthority > ComboBox1.Items.Count - 1 Then ComboBox1.SelectedIndex = myDataBase.DefaultExecutiveAuthority

        updateInfo()
    End Sub

    ''' <summary>
    ''' обновляет таблици  для заготовки древесины
    ''' </summary>
    Public Sub Refreh_woodHarvesting()
        Dim aa As Decimal = 0
        Dim ss As Decimal = 0
        Dim dd As Decimal = 0
        DataGridView1.Rows.Clear()
        For Each tv In myDoc.woodHarvesting
            DataGridView1.Rows.Add(tv.ToRow())
            aa += tv.areaSquare
            ss += tv.areaCutting
            dd += tv.value
        Next

        LabelSum.Text = $"Общая площадь лесосеки: {aa} Общая га рубки: {ss}  Общая объем м/куб:{dd}"

        DataGridView2.Rows.Clear()
        For Each tv In myDoc.notWoodHarvesting
            DataGridView2.Rows.Add(tv.ToRow())
        Next
        Label39.Text = $"Общий объем: {myDoc.notWoodHarvesting.Sum(Function(x) x.volume)}"

        DataGridView3.Rows.Clear()
        For Each tv In myDoc.measure
            DataGridView3.Rows.Add(tv.ToRow())
        Next
        Label38.Text = $"Общий объем древесины: {myDoc.measure.Sum(Function(x) x.value)} и общей деловой {myDoc.measure.Sum(Function(x) x.commercialValue)}"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If CheckBox4.Checked = True And myDataBase.Certificates.SelectSerial = "" Then MsgBox("ЭЦП отсутствует. Выберите в настройках ЭЦП или отключите подписание файлов.", MsgBoxStyle.Information, "") : Exit Sub

        If CheckForest() = False Then Exit Sub

        If myDoc.notWoodHarvesting.Count = 0 And myDoc.measure.Count = 0 And myDoc.woodHarvesting.Count = 0 Then MsgBox("Заполните табличную часть документа.", MsgBoxStyle.Information, "") : Exit Sub
        If DateTimePicker1.Value > DateTimePicker2.Value Then MsgBox("У вас неверно указан период.", MsgBoxStyle.Information, "") : Exit Sub
        If TextBox9.ForeColor = Color.Red Or TextBox8.ForeColor = Color.Red Then
            If MsgBox("У вас не верно указан ИНН или ОГРН/ОГРНИП, продолжить работу ?", MsgBoxStyle.OkCancel, "") = MsgBoxResult.Cancel Then Exit Sub
        End If

        Dim cntr As New DataBase.ContractClass
        With cntr
            .CTtype = TextBox12.Text
            .CTnumber = TextBox11.Text
            .CTdate = DateTimePicker3.Value
            .CTregistrationNumber = TextBox13.Text
        End With

        If IsNothing(myDataBase.Contract.Find(Function(x) x = cntr)) Then
            If MsgBox($"Договора с номером {cntr.CTnumber} от {cntr.CTdate.Date} не существует в общей базе данных. Хотите добавить ?", MsgBoxStyle.OkCancel, "") = MsgBoxResult.Ok Then
                myDataBase.Contract.Add(cntr)
            End If
        End If

        '***********************************************************
        SaveFileDialog1.FileName = myDoc.serviceInfo.name
        If SaveFileDialog1.ShowDialog() = DialogResult.Cancel Then Exit Sub
        Dim sfile As String = SaveFileDialog1.FileName
        DefDir = IO.Path.GetDirectoryName(sfile)


        Dim xmlns = New XmlSerializerNamespaces()
        xmlns.Add("ns1", VERCTYPE)
        xmlns.Add("ns", VERSTYPE)
        xmlns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance")

        Dim ss As New XmlSerializer(GetType(forestUsageReport))
        Dim w As New IO.StreamWriter(sfile)
        ss.Serialize(w, myDoc, xmlns)
        w.Close()

        ' тут подготока и копирование файлов в каталог 
        If CheckBox2.Checked = True Then IO.File.WriteAllText(Mid(sfile, 1, sfile.Length - 4) & ".html", GeneratorReport, System.Text.Encoding.Default)

        Dim FiletoSing As New List(Of String) From {sfile} 'на подписание файлы

        'сохранение дополнительных файлов
        If myDoc.attachments.Count <> 0 Then
            Dim dir_select As String = IO.Path.GetDirectoryName(sfile) & "\files\"
            If IO.Directory.Exists(dir_select) = False Then IO.Directory.CreateDirectory(dir_select) ' документация (стр. 13) требует создание папки  files
            For Each Tv In myDoc.attachments
                If Tv.patchFile <> "" Then
                    Dim thisdir As String = dir_select & Tv.name
                    If IO.File.Exists(thisdir) = False Then
                        If IO.File.Exists(Tv.patchFile) = True Then
                            IO.File.Copy(Tv.patchFile, thisdir)
                            FiletoSing.Add(thisdir)
                        Else
                            MsgBox($"Файл необходимый для копирования отсутствует ({Tv.patchFile})", MsgBoxStyle.Information, "")
                        End If
                    End If
                End If
            Next
        End If

        'направление на подписание
        If CheckBox4.Checked = True Then
            Me.Enabled = False
            Loading.Show()
            System.Threading.Thread.Sleep(500)
            Loading.Sing(FiletoSing)
        End If

        ': forestDeclaration-000000004_00037.zip
        If CheckBox1.Checked = True Then ' добовляет в zip
            Using oFileStream As IO.FileStream = IO.File.Open(sfile, IO.FileMode.Open)
                Using cFileStream As IO.FileStream = IO.File.Create(sfile & ".zip")
                    Using compressor = New GZipStream(cFileStream, CompressionMode.Compress)
                        oFileStream.CopyTo(compressor)
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub updateInfo()
        With myDoc.serviceInfo
            Label42.Text = .guid
            Label41.Text = .name
            Label40.Text = .provider
            Label43.Text = .version
        End With
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If Not OpenFileDialog1.ShowDialog() = DialogResult.OK Then Exit Sub
        Dim sFile As String = OpenFileDialog1.FileName

        'очистка необязтельных полей
        myDoc.header.signerData.employee.first_name = ""
        myDoc.header.signerData.employee.last_name = ""
        myDoc.header.signerData.employee.patronimic_name = ""
        myDoc.header.signerData.employee.post = ""
        myDoc.header.signerData.employee.basisAuthority = ""
        myDoc.header.contract.registrationNumber = ""


        Dim s As New XmlSerializer(GetType(forestUsageReport))
        Dim r As New IO.StreamReader(sFile)
        Try
            myDoc = s.Deserialize(r)
            r.Close()
            Refreh_woodHarvesting()
            updateInfo()
            companyFrm.SelectCompany(myDoc.header.partner) ' обновить компании так как группа контролов может быть не видна 
            refreh_ListView1() ' обновим список файлов
        Catch ex As Exception
            LogError(ex.Message)
        Finally
            r.Dispose()
        End Try

    End Sub

    ''' <summary>
    ''' выбор нужного элемента в списке
    ''' </summary>
    ''' <param name="a"></param>
    ''' <param name="s"></param>
    Sub CheclCB(a As ComboBox, s As DeliverCl)
        If s.IsNull Then Exit Sub
        Dim aa As List(Of DeliverCl) = a.DataSource
        Dim i As Integer = aa.FindIndex(Function(x) x.Id.Trim = s.Id.Trim)
        a.SelectedIndex = i
        If i = -1 Then MsgBox("Не соотвествие каталогов. Значение [" & s.ToStr & "] не найдено!", MsgBoxStyle.Exclamation, "")

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If IsNothing(DataGridView1.CurrentCell) Then Exit Sub
        myDoc.woodHarvesting.RemoveAt(DataGridView1.CurrentCell.RowIndex)
        Refreh_woodHarvesting()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If CheckForest() = False Then Exit Sub

        woodHarvestFrm.Show()
        woodHarvestFrm.Button2.Visible = True
        woodHarvestFrm.Button7.Visible = False
    End Sub

    Private Sub Open_woodHarvestFrm(woodHarvestFrm As woodHarvestFrm)
        With woodHarvestFrm
            .areaCutting.Value = .EditRow.areaCutting
            .areaSquare.Value = .EditRow.areaSquare
            .farm.Text = .EditRow.farm
            .formCutting.Text = .EditRow.formCutting
            .note.Text = .EditRow.note
            .value_n.Text = .EditRow.value
            CheclCB(.typeCutting, .EditRow.typeCutting.ToDeliverCl)
            REM  CheclCB(.sortiment, woodHarvestFrm.EditRow.sortiment, MyCatalor .subforestry  DB.sortimentList)
            CheclCB(.forestry, .EditRow.location.forestry.ToDeliverCl)
            CheclCB(.subforestry, .EditRow.location.subforestry.ToDeliverCl)
            CheclCB(.tract, .EditRow.location.tract.ToDeliverCl)
            CheclCB(.wood, .EditRow.wood.ToDeliverCl)
            CheclCB(.tree, .EditRow.tree.ToDeliverCl)
            .cuttingArea.Text = .EditRow.location.cuttingArea
            .quarter.Text = .EditRow.location.quarter
            .taxationUnit.Text = .EditRow.location.taxationUnit
        End With
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        If CheckForest() = False Then Exit Sub


        If IsNothing(DataGridView1.CurrentCell) Then Exit Sub
        woodHarvestFrm.EditRow = myDoc.woodHarvesting.Item(DataGridView1.CurrentCell.RowIndex)
        woodHarvestFrm.Show()
        woodHarvestFrm.Button7.Visible = True

        Open_woodHarvestFrm(woodHarvestFrm)

        woodHarvestFrm.Button2.Visible = False
        woodHarvestFrm.Button7.Visible = True
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If CheckForest() = False Then Exit Sub

        woodHarvestFrm.Show()
        If IsNothing(DataGridView1.CurrentCell) Then Exit Sub
        woodHarvestFrm.EditRow = myDoc.woodHarvesting.Item(DataGridView1.CurrentCell.RowIndex)
        Open_woodHarvestFrm(woodHarvestFrm)
    End Sub

    Private Sub TextBox8_LostFocus(sender As Object, e As EventArgs) Handles TextBox8.LostFocus
        ЦелоеЧисло(sender)
    End Sub

    Private Sub TextBox9_LostFocus(sender As Object, e As EventArgs) Handles TextBox9.LostFocus
        ЦелоеЧисло(sender)
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        ЦелоеЧисло(sender)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If CType(ComboBox2.SelectedValue, DeliverCl).Id = "0" Then Exit Sub
        ComboBox1.Enabled = True
        ComboBox1.DataSource = (From tv In MyCatalor.executiveAuthority Where tv.subject.id = CType(ComboBox2.SelectedValue, DeliverCl).Id Select New DeliverCl With {.Id = tv.id, .Name = tv.name}).ToList.Cast(Of DeliverCl)
        myDataBase.DefaultSubject = ComboBox2.SelectedIndex
    End Sub

    Private Function GeneratorReport() As String
        Dim deep As String = "Error: string"
        Try
            deep = IO.File.ReadAllText(MyCurDirLib & "Fprint.htm", System.Text.Encoding.Default)
            Dim dic As New Dictionary(Of String, String) From {{"!A1", myDoc.header.executiveAuthority.name}, {"!B11", myDoc.header.partner.phone}}

            If myDoc.header.partner.individualEntrepreneur IsNot Nothing Then
                dic.Add("!B2", myDoc.header.partner.individualEntrepreneur.last_name)
                dic.Add("!B3", myDoc.header.partner.individualEntrepreneur.first_name)
                dic.Add("!B4", myDoc.header.partner.individualEntrepreneur.patronimic_name)
                dic.Add("!B5", myDoc.header.partner.individualEntrepreneur.identity_document.name)
                dic.Add("!B6", myDoc.header.partner.individualEntrepreneur.identity_document.series)
                dic.Add("!B7", myDoc.header.partner.individualEntrepreneur.identity_document.number)
                dic.Add("!B8", myDoc.header.partner.individualEntrepreneur.ogrn)
                dic.Add("!B9", myDoc.header.partner.individualEntrepreneur.inn)
                dic.Add("!B10", "") 'для юр лиц
                dic.Add("!B1", "ИП")
            ElseIf myDoc.header.partner.juridicalPerson IsNot Nothing Then
                dic.Add("!B2", "")
                dic.Add("!B3", "")
                dic.Add("!B4", "")
                dic.Add("!B5", "")
                dic.Add("!B6", "")
                dic.Add("!B7", "")
                dic.Add("!B8", myDoc.header.partner.juridicalPerson.ogrn)
                dic.Add("!B9", myDoc.header.partner.juridicalPerson.inn)
                dic.Add("!B10", myDoc.header.partner.juridicalPerson.address)
                dic.Add("!B1", myDoc.header.partner.juridicalPerson.name) 'для юр лиц
            ElseIf myDoc.header.partner.physicalPerson IsNot Nothing Then
                dic.Add("!B2", myDoc.header.partner.physicalPerson.last_name)
                dic.Add("!B3", myDoc.header.partner.physicalPerson.first_name)
                dic.Add("!B4", myDoc.header.partner.physicalPerson.patronimic_name)
                dic.Add("!B5", myDoc.header.partner.physicalPerson.identity_document.name)
                dic.Add("!B6", myDoc.header.partner.physicalPerson.identity_document.series)
                dic.Add("!B7", myDoc.header.partner.physicalPerson.identity_document.number)
                dic.Add("!B8", "")
                dic.Add("!B9", myDoc.header.partner.physicalPerson.inn)
                dic.Add("!B10", "") 'для юр лиц
                dic.Add("!B1", "")
            End If

            dic.Add("!C1", myDoc.header.contract.type)
            dic.Add("!C2", myDoc.header.contract.number)
            dic.Add("!C3", myDoc.header.contract.registrationNumber)
            dic.Add("!C4", myDoc.header.contract.date)

            dic.Add("!Q1", MonthName(myDoc.header.period.begin.Split("-")(1), False) & "-" & MonthName(myDoc.header.period.end.Split("-")(1), False) & " " & myDoc.header.period.end.Split("-")(0))

            Dim head, down, midle As String

            head = Mid(deep, 1, InStr(deep, "<TD010>") - 1)
            down = Mid(deep, InStr(deep, "</TD010>") + 8)
            midle = Mid(deep, head.Length + 8, deep.Length - head.Length - down.Length - 15)

            Dim tr01 As String = ""
            For Each tv In myDoc.woodHarvesting
                tr01 &= tv.toHtml(midle)
            Next
            deep = head & tr01 & down

            dic.Add("sumD7hl", myDoc.woodHarvesting.Sum(Function(x) x.areaSquare)) 'areaSquare
            dic.Add("sumD7", myDoc.woodHarvesting.Sum(Function(x) x.areaSquare))
            dic.Add("sumD8hl", myDoc.woodHarvesting.Sum(Function(x) x.areaCutting)) 'areaCutting
            dic.Add("sumD8", myDoc.woodHarvesting.Sum(Function(x) x.areaCutting))
            dic.Add("sumD14hl", myDoc.woodHarvesting.Sum(Function(x) x.value))
            dic.Add("sumD14", myDoc.woodHarvesting.Sum(Function(x) x.value))

            head = Mid(deep, 1, InStr(deep, "<TD020>") - 1)
            down = Mid(deep, InStr(deep, "</TD020>") + 8)
            midle = Mid(deep, head.Length + 8, deep.Length - head.Length - down.Length - 15)
            Dim tr02 As String = ""
            For Each tv In myDoc.notWoodHarvesting
                tr02 &= tv.toHtml(midle)
            Next
            deep = head & tr02 & down

            dic.Add("sumG10", myDoc.notWoodHarvesting.Sum(Function(x) x.volume))

            head = Mid(deep, 1, InStr(deep, "<TD030>") - 1)
            down = Mid(deep, InStr(deep, "</TD030>") + 8)
            midle = Mid(deep, head.Length + 8, deep.Length - head.Length - down.Length - 15)
            Dim tr03 As String = ""
            For Each tv In myDoc.measure
                tr03 &= tv.toHtml(midle)
            Next
            deep = head & tr03 & down

            dic.Add("sumH15", myDoc.measure.Sum(Function(x) x.value))
            dic.Add("sumH16", myDoc.measure.Sum(Function(x) x.commercialValue))

            dic.Add("!N1", myDoc.header.signerData.employee.post & " " & myDoc.header.signerData.employee.first_name & " " & myDoc.header.signerData.employee.last_name & " " & myDoc.header.signerData.employee.basisAuthority)
            dic.Add("!N2", myDoc.header.partner.phone)
            dic.Add("!N3", myDoc.header.signerData.date)

            For Each tv In dic
                deep = Replace(deep, tv.Key, tv.Value)
            Next
        Catch ex As Exception
            LogError(ex.Message)
        End Try
        Return deep
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckForest() = False Then Exit Sub
        PrintForm.Show()
        PrintForm.WebBrowser1.DocumentText = GeneratorReport()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        contractFrm.Show()
        Me.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckForest() = False Then Exit Sub
        notWoodHarvestingRowFrm.Show()
        notWoodHarvestingRowFrm.Button2.Visible = True
        notWoodHarvestingRowFrm.Button7.Visible = False
    End Sub

    Function CheckForest() As Boolean
        If ComboBox1.SelectedValue Is Nothing Then
            MsgBox("Важно указать название органа (Наименование органа государственной власти, органа местного самоуправления)", MsgBoxStyle.Information, "")
            TabControl1.SelectedTab = TabControl1.TabPages(0)
            ComboBox2.Select()
            Return False
        End If
        Return True
    End Function

    Private Sub Open_notWoodHarvestingRowFrm(notWoodHarvestingRowFrm As notWoodHarvestingRowFrm)
        With notWoodHarvestingRowFrm
            CheclCB(.usageType, .EditRow.usageType.ToDeliverCl)
            CheclCB(.forestry, .EditRow.location.forestry.ToDeliverCl)
            CheclCB(.subforestry, .EditRow.location.subforestry.ToDeliverCl)
            CheclCB(.tract, .EditRow.location.tract.ToDeliverCl)
            .quarter.Text = .EditRow.location.quarter
            .taxationUnit.Text = .EditRow.location.taxationUnit
            .area.Text = .EditRow.area
            CheclCB(.resourceType, .EditRow.resourceType.ToDeliverCl)
            CheclCB(.unitType, .EditRow.unitType.ToDeliverCl)
            .volume.Text = .EditRow.volume
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If CheckForest() = False Then Exit Sub
        If IsNothing(DataGridView2.CurrentCell) Then Exit Sub
        notWoodHarvestingRowFrm.EditRow = myDoc.notWoodHarvesting.Item(DataGridView2.CurrentCell.RowIndex)
        notWoodHarvestingRowFrm.Show()
        notWoodHarvestingRowFrm.Button7.Visible = True

        Open_notWoodHarvestingRowFrm(notWoodHarvestingRowFrm)

        notWoodHarvestingRowFrm.Button2.Visible = False
        notWoodHarvestingRowFrm.Button7.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If IsNothing(DataGridView2.CurrentCell) Then Exit Sub
        myDoc.notWoodHarvesting.RemoveAt(DataGridView2.CurrentCell.RowIndex)
        Refreh_woodHarvesting()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        notWoodHarvestingRowFrm.Show()
        If IsNothing(DataGridView2.CurrentCell) Then Exit Sub
        notWoodHarvestingRowFrm.EditRow = myDoc.notWoodHarvesting.Item(DataGridView2.CurrentCell.RowIndex)
        Open_notWoodHarvestingRowFrm(notWoodHarvestingRowFrm)

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        companyFrm.Visible = True
        Me.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If CheckForest() = False Then Exit Sub
        measureRowFrm.Show()
        measureRowFrm.Button2.Visible = True
        measureRowFrm.Button7.Visible = False
    End Sub

    Private Sub Open_measureRowFrm(measureRowFrm As measureRowFrm)
        With measureRowFrm
            CheclCB(.measure, .EditRow.measure.ToDeliverCl)
            CheclCB(.objectCB, .EditRow.object.ToDeliverCl)
            CheclCB(.forestry, .EditRow.location.forestry.ToDeliverCl)
            CheclCB(.subforestry, .EditRow.location.subforestry.ToDeliverCl)
            CheclCB(.tract, .EditRow.location.tract.ToDeliverCl)
            .quarter.Text = .EditRow.location.quarter
            .taxationUnit.Text = .EditRow.location.taxationUnit
            .area.Text = .EditRow.area
            .farm.Text = .EditRow.farm
            .formCutting.Text = .EditRow.formCutting
            CheclCB(.typeCutting, .EditRow.typeCutting.ToDeliverCl)
            CheclCB(.wood, .EditRow.wood.ToDeliverCl)
            CheclCB(.tree, .EditRow.tree.ToDeliverCl)
            CheclCB(.sortiment, .EditRow.sortiment.ToDeliverCl)
            .value_n.Value = .EditRow.value
            .commercialValue.Value = .EditRow.commercialValue
        End With
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If CheckForest() = False Then Exit Sub
        If IsNothing(DataGridView3.CurrentCell) Then Exit Sub
        measureRowFrm.EditRow = myDoc.measure.Item(DataGridView3.CurrentCell.RowIndex)
        measureRowFrm.Show()
        measureRowFrm.Button7.Visible = True

        Open_measureRowFrm(measureRowFrm)

        measureRowFrm.Button2.Visible = False
        measureRowFrm.Button7.Visible = True
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If IsNothing(DataGridView3.CurrentCell) Then Exit Sub
        myDoc.measure.RemoveAt(DataGridView3.CurrentCell.RowIndex)
        Refreh_woodHarvesting()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        measureRowFrm.Show()
        If IsNothing(DataGridView3.CurrentCell) Then Exit Sub
        measureRowFrm.EditRow = myDoc.measure.Item(DataGridView3.CurrentCell.RowIndex)
        Open_measureRowFrm(measureRowFrm)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        PhoneTv = TextBox1.Text
    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged
        PhoneTv = TextBox16.Text
    End Sub

    Private Sub TextBox16_LostFocus(sender As Object, e As EventArgs) Handles TextBox16.LostFocus
        ЦелоеЧисло(sender)
    End Sub

    Private Sub TextBox30_TextChanged(sender As Object, e As EventArgs) Handles TextBox30.TextChanged
        PhoneTv = TextBox30.Text
    End Sub

    Private Sub TextBox30_LostFocus(sender As Object, e As EventArgs) Handles TextBox30.LostFocus
        ЦелоеЧисло(sender)
    End Sub

    Private Sub Button17_Click_1(sender As Object, e As EventArgs)
        myDoc.header.partner.individualEntrepreneur = New forestUsageReport.headerClass.partnerClass.individualEntrepreneurClass
        MsgBox(myDoc.header.partner.individualEntrepreneur.identity_document.name)
    End Sub

    Private Sub TextBox24_TextChanged(sender As Object, e As EventArgs) Handles TextBox24.TextChanged
        seriesTV = TextBox24.Text
    End Sub

    Private Sub TextBox23_TextChanged(sender As Object, e As EventArgs) Handles TextBox23.TextChanged
        numberTV = TextBox23.Text
    End Sub

    Private Sub TextBox29_LostFocus(sender As Object, e As EventArgs) Handles TextBox29.LostFocus
        ЦелоеЧисло(sender)
    End Sub

    Private Sub TextBox24_LostFocus(sender As Object, e As EventArgs) Handles TextBox24.LostFocus
        ЦелоеЧисло(sender)
    End Sub

    Private Sub TextBox23_LostFocus(sender As Object, e As EventArgs) Handles TextBox23.LostFocus
        ЦелоеЧисло(sender)
    End Sub

    Private Sub TextBox17_LostFocus(sender As Object, e As EventArgs) Handles TextBox17.LostFocus
        ЦелоеЧисло(sender)
    End Sub

    Private Sub TextBox15_LostFocus(sender As Object, e As EventArgs) Handles TextBox15.LostFocus
        ЦелоеЧисло(sender)
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        seriesTV = TextBox6.Text
    End Sub

    Private Sub TextBox6_LostFocus(sender As Object, e As EventArgs) Handles TextBox6.LostFocus
        ЦелоеЧисло(sender)
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        numberTV = TextBox5.Text
    End Sub

    Private Sub TextBox5_LostFocus(sender As Object, e As EventArgs) Handles TextBox5.LostFocus
        ЦелоеЧисло(sender)
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        NameTV = TextBox7.Text
    End Sub

    Private Sub TextBox21_TextChanged(sender As Object, e As EventArgs) Handles TextBox21.LostFocus
        ФильтруетИмена(sender)
    End Sub

    Private Sub TextBox20_TextChanged(sender As Object, e As EventArgs) Handles TextBox20.LostFocus
        ФильтруетИмена(sender)
    End Sub

    Private Sub TextBox19_TextChanged(sender As Object, e As EventArgs) Handles TextBox19.LostFocus
        ФильтруетИмена(sender)
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

    Private Sub TextBox28_TextChanged(sender As Object, e As EventArgs) Handles TextBox28.LostFocus
        ФильтруетИмена(sender)
    End Sub

    Private Sub TextBox27_TextChanged(sender As Object, e As EventArgs) Handles TextBox27.LostFocus
        ФильтруетИмена(sender)
    End Sub

    Private Sub TextBox26_TextChanged(sender As Object, e As EventArgs) Handles TextBox26.LostFocus
        ФильтруетИмена(sender)
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Button8_Click_1(Nothing, Nothing)
    End Sub

    Private Sub DataGridView2_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView2.DoubleClick
        Button3_Click(Nothing, Nothing)
    End Sub

    Private Sub DataGridView3_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView3.DoubleClick
        Button7_Click(Nothing, Nothing)
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If e.ColumnIndex = 13 Then
            Dim v As String = myDoc.woodHarvesting.Item(e.RowIndex).value
            Try
                v = Decimal.Parse(DirectCast(sender, DataGridView).Item(e.ColumnIndex, e.RowIndex).Value)
            Catch
                DirectCast(sender, DataGridView).Item(e.ColumnIndex, e.RowIndex).Value = "#ошибка"
            End Try
            myDoc.woodHarvesting.Item(e.RowIndex).value = v
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        myDataBase.WinState = Me.WindowState
        myDataBase.DefaultsignerData = myDoc.header.signerData
        SaveXmlDataBase()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        OpenFileForAdd.Multiselect = True
        OpenFileForAdd.Title = "Добавить файл к документу"
        If Not OpenFileForAdd.ShowDialog() = DialogResult.OK Then Exit Sub
        Dim sfile() As String = OpenFileForAdd.FileNames
        For Each tv In sfile
            If myDoc.attachments.Exists(Function(x) x.name = IO.Path.GetFileName(tv)) Then
                MsgBox("Такой файл c таким название, был ранее добавлен уже.", MsgBoxStyle.Information, "")
            Else
                myDoc.attachments.Add(forestUsageReport.file.AddFile(tv))
            End If
        Next
        refreh_ListView1()
    End Sub

    Private Sub refreh_ListView1()
        If myDoc.attachments Is Nothing Then Exit Sub
        ListView1.Items.Clear()
        If CheckBox2.Checked = True Then
            ListView1.Items.Add(New ListViewItem With {.Text = F_NAME_SHOW, .ImageIndex = 1})
        End If
        For Each n In myDoc.attachments
            Dim Tv As New ListViewItem
            With Tv
                .Text = n.name
                .Tag = n.patchFile
                If n.extension = "sig" Then
                    .ImageIndex = 0
                Else
                    .ImageIndex = 2
                End If
            End With
            ListView1.Items.Add(Tv)
        Next
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim f As forestUsageReport.file
        Dim s As ListView.SelectedListViewItemCollection = ListView1.SelectedItems
        For Each Tv In s
            f = myDoc.attachments.Find(Function(x) x.name = Tv.text)
            If f IsNot Nothing Then
                myDoc.attachments.Remove(f)
            ElseIf Tv.text = F_NAME_SHOW Then
                CheckBox2.Checked = False
            End If
        Next
        refreh_ListView1()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        refreh_ListView1()
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Cripto.Show()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs)
        Loading.Show()
    End Sub

    Private Sub XSDErrors(ByVal o As Object, ByVal e As ValidationEventArgs)
        ErrorHub = ErrorHub & "<p><b>" & e.Message.Replace(VERXSD, "XSD") & "</b></p>" & vbCr
    End Sub

    Private Sub Button20_Click_1(sender As Object, e As EventArgs) Handles Button20.Click
        OpenFileXmlDialog.InitialDirectory = DefDir
        If OpenFileXmlDialog.ShowDialog = DialogResult.Cancel Then Exit Sub

        Dim f$ = GetShemaforestUsageReport()
        If Mid(f, 1, 3) = "(X)" Then
            Dim deep As String = IO.File.ReadAllText(MyCurDirLib & "sampler.htm", System.Text.Encoding.Default)
            deep = Replace(deep, "[2]", "<a href='file:///" & MyCurDir & "/Upload/" & "'>[Сюда скопировать]</a>")
            deep = Replace(deep, "[3]", "<b>Отсутствуют нужные схемы в каталоге " & GetShemaforestUsageReport() & "</b>")
            IO.File.WriteAllText(Environ("TMP") & "\tmp.html", deep, System.Text.Encoding.Default)
            GoTo Err
        End If

        Dim schemas As XmlSchemaSet = New XmlSchemaSet()
        Try
            schemas.Add(VERXSD, f)
        Catch ex As Exception
            IO.File.WriteAllText(Environ("TMP") & "\tmp.html", "<html><body><pre><red>" & ex.Message, System.Text.Encoding.Default)
            GoTo Err
        End Try
        ErrorHub = ""
        XDocument.Load(OpenFileXmlDialog.FileName).Validate(schemas, AddressOf XSDErrors)
        If ErrorHub = "" Then MsgBox("Ошибок не обнаружено.", MsgBoxStyle.Information, "Проверка на ошибки завершена") : Exit Sub
        IO.File.WriteAllText(Environ("TMP") & "\tmp.html", "<h1>Обнаружено несоответствие схеме</h1>" & ErrorHub, System.Text.Encoding.Default)

Err:
        Process.Start("file:///" & Environ("TMP") & "\tmp.html")

    End Sub

    Private Function GetShemaforestUsageReport() As String
        Dim la As New SortedList(Of Single, String)
        If IO.Directory.Exists(MyCurDir & "\Upload\forestUsageReport\") = False Then Return "(X) Нет схемы (forestUsageReport) в каталоге"
        If IO.Directory.Exists(MyCurDir & "\Upload\commonTypes\") = False Then Return "(X) Нет схемы (commonTypes) в каталоге"
        For Each tv As String In IO.Directory.GetDirectories(MyCurDir & "\Upload\forestUsageReport\")
            la.Add(Mid(tv, InStrRev(tv, "\") + 1).Replace(".", ","), tv) '  номер версии 
        Next
        If la.Count = 0 Then Return "(X) Нет версий схем в каталоге"
        Return la.Last.Value & "\forestUsageReport.xsd"
    End Function

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://github.com/Jkrewin/forestUsageReport")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        myDataBase.DefaultExecutiveAuthority = ComboBox1.SelectedIndex
    End Sub
End Class



Public Class DeliverCl
    Public Property Id As String = ""
    Public Property Name As String = ""
    Public Property Description As String = ""


    ''' <summary>
    ''' true - означает пустое значение
    ''' </summary>
    ''' <returns></returns>
    Public Function IsNull() As Boolean
        Return Id = "" And Name = ""
    End Function

    Public Function ToStr() As String
        Return " id=""" & Id & """ name=""" & Name & """ description=""" & Description & """/>"
    End Function

    Public Shared Widening Operator CType(ByVal val As DeliverCl) As forestUsageReport.reference
        Return New forestUsageReport.reference With {.id = val.Id, .description = val.Description, .name = val.Name}
    End Operator

    Public Shared Operator =(a As DeliverCl, s As DeliverCl)
        If a.Id = s.Id And a.Name = s.Name And a.Description = s.Description Then
            Return True
        Else
            Return False
        End If
    End Operator
    Public Shared Operator <>(a As DeliverCl, s As DeliverCl)
        If a.Id = s.Id And a.Name = s.Name And a.Description = s.Description Then
            Return True
        Else
            Return False
        End If
    End Operator
End Class


