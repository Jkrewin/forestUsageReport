Imports System.Xml.Serialization

<XmlRoot([Namespace]:=VERXSD, IsNullable:=True)>
Public Class forestUsageReport



    ''' <summary>
    ''' Указывает то что нужно (True) или нет фильтровать пробелы в reference так как в Базе данных НСИ есть пробелы в ID 
    ''' Поэтому некоторые программы удаляют пробелы другие нет 
    ''' </summary>
    <XmlIgnore> Public Shared ReadOnly Property TRIM_REFERENCE As Boolean = False


    Public serviceInfo As New serviceInfoClass
    Public header As New headerClass

    <XmlArrayItemAttribute("row", IsNullable:=False)>
    Public woodHarvesting As New List(Of woodHarvestingRow)
    <XmlArrayItemAttribute("row", IsNullable:=False)>
    Public notWoodHarvesting As New List(Of notWoodHarvestingRow)
    <XmlArrayItemAttribute("row", IsNullable:=False)>
    Public measure As New List(Of measureRow)

    Public attachments As New List(Of file)

    <XmlTypeAttribute([Namespace]:=VERCTYPE)>
    Public Class reference
        <XmlAttribute("id")>
        Public Property id As String = ""
        <XmlAttribute("name")>
        Public Property name As String = ""
        <XmlAttribute("description")>
        Public Property description As String = ""

        Public Shadows Function ToString() As String
            If id = "" And name = "" Then
                Return " name="""" description=""""/>"
            Else
                If TRIM_REFERENCE = True Then
                    Return " id=""" & id.Trim & """ name=""" & name & """ description=""" & description & """/>"
                Else
                    Return " id=""" & id & """ name=""" & name & """ description=""" & description & """/>"
                End If
            End If
        End Function

        Public Function ToDeliverCl() As DeliverCl
            Return New DeliverCl With {.Id = id, .Description = description, .Name = name}
        End Function

    End Class

    <XmlTypeAttribute([Namespace]:=VERCTYPE)>
    Public Class serviceInfoClass
        Public provider As String = "Document ForestUsageReport" '
        Public version As String = VERXSD.Split("/").Last
        Public name As String = "forestUsageReport"
        Public guid As String = System.Guid.NewGuid.ToString() ' "51a51362-192a-45c6-8947-33e97f420dbf"
    End Class

    Public Class headerClass
        Public Property executiveAuthority As reference
            Get
                Dim v As DeliverCl = Form1.ComboBox1.SelectedValue
                Return IIf(IsNothing(v), Nothing, New reference With {.id = v.Id, .description = v.Description, .name = v.Name})
            End Get
            Set(value As reference)
                Dim a As catalog.mainClass.element = MyCatalor.executiveAuthority.Find(Function(x) x.id = value.id)
                If IsNothing(a) Then                ' если такого значения не существует вообще в каталоге
                    Form1.ComboBox2.SelectedIndex = 0
                    Form1.ComboBox2.Items.Clear()
                    Form1.ComboBox1.Enabled = False
                Else                                ' если есть то должен быть верно выбран пункт субъекта страны 
                    Dim s As List(Of DeliverCl) = Form1.ComboBox2.DataSource
                    Form1.ComboBox2.SelectedIndex = s.FindIndex(Function(x) x.Id = a.subject.id)
                    ' загружаем списик лесхозов
                    s = Form1.ComboBox1.DataSource
                    Form1.ComboBox1.SelectedIndex = s.FindIndex(Function(x) x.Id = value.id)
                End If
            End Set
        End Property
        Public Property forestry As reference
            Get
                Dim r As reference
                If Not myDoc.woodHarvesting.Count = 0 Then
                    r = myDoc.woodHarvesting.First.location.forestry
                ElseIf Not myDoc.notWoodHarvesting.Count = 0 Then
                    r = myDoc.notWoodHarvesting.First.location.forestry
                ElseIf Not myDoc.measure.Count = 0 Then
                    r = myDoc.measure.First.location.forestry
                Else
                    r = New reference
                End If
                Return r
            End Get
            Set(value As reference)
                ' тут нет ничего так как не будет появляться в xml если не будет set 
            End Set
        End Property
        Public Property partner As New partnerClass
        Public Property period As New periodClass
        Public Property contract As New contractClass
        Public Property signerData As New signerDataClass

        <XmlTypeAttribute([Namespace]:=VERCTYPE)>
        Public Class partnerClass
            ' new не вызывать будет несколько 
            Public Property juridicalPerson As juridicalPersonClass
            Public Property physicalPerson As physicalPersonClass
            Public Property individualEntrepreneur As individualEntrepreneurClass

            ''' <summary>
            ''' Версия 4.1 отменяет этот тег 
            ''' </summary>
            ''' <returns></returns>
            <XmlIgnore>
            Public Property phone As String
                Get
                    Return Form1.PhoneTv
                End Get
                Set(value As String)
                    Form1.TextBox1.Text = value
                    Form1.TextBox16.Text = value
                    Form1.TextBox30.Text = value
                End Set
            End Property

            <XmlTypeAttribute([Namespace]:=VERCTYPE)>
            Public Class individualEntrepreneurClass

                Public Property first_name As String
                    Get
                        Return Form1.TextBox2.Text
                    End Get
                    Set(value As String)
                        Form1.TextBox2.Text = value
                    End Set
                End Property

                Public Property last_name As String
                    Get
                        Return Form1.TextBox3.Text
                    End Get
                    Set(value As String)
                        Form1.TextBox3.Text = value
                    End Set
                End Property

                Public Property patronimic_name As String
                    Get
                        Return Form1.TextBox4.Text
                    End Get
                    Set(value As String)
                        Form1.TextBox4.Text = value
                    End Set
                End Property

                Public Property identity_document As New identity_documentClass

                Public Property ogrn As String
                    Get
                        Return Form1.TextBox9.Text
                    End Get
                    Set(value As String)
                        Form1.TextBox9.Text = value
                    End Set
                End Property

                Public Property inn As String
                    Get
                        Return Form1.TextBox8.Text
                    End Get
                    Set(value As String)
                        Form1.TextBox8.Text = value
                    End Set
                End Property
            End Class

            <XmlTypeAttribute([Namespace]:=VERCTYPE)>
            Public Class physicalPersonClass

                Public Property first_name As String
                    Get
                        Return Form1.TextBox28.Text
                    End Get
                    Set(value As String)
                        Form1.TextBox28.Text = value
                    End Set
                End Property

                Public Property last_name As String
                    Get
                        Return Form1.TextBox27.Text
                    End Get
                    Set(value As String)
                        Form1.TextBox27.Text = value
                    End Set
                End Property

                Public Property patronimic_name As String
                    Get
                        Return Form1.TextBox26.Text
                    End Get
                    Set(value As String)
                        Form1.TextBox26.Text = value
                    End Set
                End Property

                Public Property identity_document As New identity_documentClass

                Public Property inn As String
                    Get
                        Return Form1.TextBox29.Text
                    End Get
                    Set(value As String)
                        Form1.TextBox29.Text = value
                    End Set
                End Property
            End Class

            <XmlTypeAttribute([Namespace]:=VERCTYPE)>
            Public Class juridicalPersonClass
                Public Property name As String
                    Get
                        Return Form1.TextBox10.Text
                    End Get
                    Set(value As String)
                        Form1.TextBox10.Text = value
                    End Set
                End Property

                Public Property inn As String
                    Get
                        Return Form1.TextBox15.Text
                    End Get
                    Set(value As String)
                        Form1.TextBox15.Text = value
                    End Set
                End Property

                Public Property ogrn As String
                    Get
                        Return Form1.TextBox17.Text
                    End Get
                    Set(value As String)
                        Form1.TextBox17.Text = value
                    End Set
                End Property

                Public Property address As String
                    Get
                        Return Form1.TextBox14.Text
                    End Get
                    Set(value As String)
                        Form1.TextBox14.Text = value
                    End Set
                End Property
            End Class
            <XmlTypeAttribute([Namespace]:=VERCTYPE)>
            Public Class identity_documentClass
                Public Property name As String
                    Get
                        Return Form1.NameTV
                    End Get
                    Set(value As String)
                        Form1.NameTV = value
                    End Set
                End Property

                Public Property series As String
                    Get
                        Return Form1.seriesTV
                    End Get
                    Set(value As String)
                        Form1.seriesTV = value
                    End Set
                End Property

                Public Property number As String
                    Get
                        Return Form1.numberTV
                    End Get
                    Set(value As String)
                        Form1.numberTV = value
                    End Set
                End Property
            End Class

            Public Shared Widening Operator CType(h As partnerClass) As DataBase.company
                Dim a As New DataBase.company
                With h
                    If .individualEntrepreneur IsNot Nothing Then
                        a.TypeCompany = DataBase.company.ETypeCompany.ИП
                        a.first_name = .individualEntrepreneur.first_name
                        a.last_name = .individualEntrepreneur.last_name
                        a.patronimic_name = .individualEntrepreneur.patronimic_name
                        a.inn = .individualEntrepreneur.inn
                        a.ogrn = .individualEntrepreneur.ogrn
                        a.identity_document = .individualEntrepreneur.identity_document
                    ElseIf .juridicalPerson IsNot Nothing Then
                        a.TypeCompany = DataBase.company.ETypeCompany.Компания
                        a.address = .juridicalPerson.address
                        a.inn = .juridicalPerson.inn
                        a.name = .juridicalPerson.name
                        a.ogrn = .juridicalPerson.ogrn
                    ElseIf .physicalPerson IsNot Nothing Then
                        a.TypeCompany = DataBase.company.ETypeCompany.ЧастноеЛицо
                        a.first_name = .physicalPerson.first_name
                        a.last_name = .physicalPerson.last_name
                        a.patronimic_name = .physicalPerson.patronimic_name
                        a.inn = .physicalPerson.inn
                        a.identity_document = .physicalPerson.identity_document
                    End If
                    a.phone = .phone
                End With
                Return a
            End Operator


        End Class

        <XmlTypeAttribute([Namespace]:=VERCTYPE)>
        Public Class periodClass

            Public Property begin As String
                Get
                    Return SetDateTimePicker(Form1.DateTimePicker1)
                End Get
                Set(value As String)
                    Form1.DateTimePicker1.Value = value
                End Set
            End Property

            Public Property [end] As String
                Get
                    Return SetDateTimePicker(Form1.DateTimePicker2)
                End Get
                Set(value As String)
                    Form1.DateTimePicker2.Value = value
                End Set
            End Property
        End Class

        <XmlTypeAttribute([Namespace]:=VERCTYPE)>
        Public Class contractClass

            Public Property type As String
                Get
                    Return Form1.TextBox12.Text
                End Get
                Set(value As String)
                    Form1.TextBox12.Text = value
                End Set
            End Property

            Public Property number As String
                Get
                    Return Form1.TextBox11.Text
                End Get
                Set(value As String)
                    Form1.TextBox11.Text = value
                End Set
            End Property

            Public Property [date] As String
                Get
                    Return SetDateTimePicker(Form1.DateTimePicker3)
                End Get
                Set(value As String)
                    Form1.DateTimePicker3.Value = value
                End Set
            End Property

            ''' <summary>
            '''   (необязательное) Вид использования лесов
            ''' </summary>
            ''' <returns></returns>

            Public Property usageType As reference 'New

            Public Property registrationNumber As String
                Get
                    Return Form1.TextBox13.Text
                End Get
                Set(value As String)
                    Form1.TextBox13.Text = value
                End Set
            End Property

            ''' <summary>
            ''' (необязательное) Организация, утвердившая проект освоения лесов
            ''' </summary>
            ''' <returns></returns>
            Public Property approvingProject As String ' New

            ''' <summary>
            '''  (необязательное) Дата Организация, утвердившая проект освоения лесов
            ''' </summary>
            ''' <returns></returns>
            Public Property approvingDate As String  'New

        End Class

        <XmlTypeAttribute([Namespace]:=VERCTYPE)>
        Public Class signerDataClass

            Public employee As New employeeClass
            Public Property [date] As String
                Get
                    Return SetDateTimePicker(Form1.DateTimePicker4)
                End Get
                Set(value As String)
                    Form1.DateTimePicker4.Value = value
                End Set
            End Property

            ''' <summary>
            ''' Организация (необязательное поле)
            ''' </summary>
            ''' <returns></returns>
            Public Property organization As String 'new

            <XmlTypeAttribute([Namespace]:=VERCTYPE)>
            Public Class employeeClass
                Public Property first_name As String
                    Get
                        Return Form1.TextBox21.Text
                    End Get
                    Set(value As String)
                        Form1.TextBox21.Text = value
                    End Set
                End Property

                Public Property last_name As String
                    Get
                        Return Form1.TextBox20.Text
                    End Get
                    Set(value As String)
                        Form1.TextBox20.Text = value
                    End Set
                End Property

                Public Property patronimic_name As String
                    Get
                        Return Form1.TextBox19.Text
                    End Get
                    Set(value As String)
                        Form1.TextBox19.Text = value
                    End Set
                End Property

                Public Property post As String
                    Get
                        Return Form1.TextBox18.Text
                    End Get
                    Set(value As String)
                        Form1.TextBox18.Text = value
                    End Set
                End Property

                Public Property basisAuthority As String
                    Get
                        Return Form1.TextBox22.Text
                    End Get
                    Set(value As String)
                        Form1.TextBox22.Text = value
                    End Set
                End Property

                ''' <summary>
                ''' Телефон (необязательное поле)
                ''' </summary>
                ''' <returns></returns>
                Public Property phone As String
                    Get
                        Return Form1.TextBox31.Text
                    End Get
                    Set(value As String)
                        Form1.TextBox31.Text = value
                    End Set
                End Property
            End Class
        End Class

    End Class

    <XmlTypeAttribute([Namespace]:=VERCTYPE)>
    Public Class locationClass
        Public Property forestry As New reference
        Public Property subforestry As New reference
        Public Property tract As New reference
        Public Property quarter As Integer = 1
        Public Property taxationUnit As Integer = 1
        Public Property cuttingArea As Integer = 0
    End Class

    Public Interface IRow
        Function ToRow() As String()
        Function toHtml(html As String) As String
    End Interface

    <XmlTypeAttribute([Namespace]:=VERXSD)>
    Public Class woodHarvestingRow
        Implements IRow
        Public Property location As New locationClass
        Public Property areaSquare As Decimal = 0.0000
        Public Property areaCutting As Decimal = 0.0000
        Public Property farm As String
        Public Property formCutting As String
        Public Property typeCutting As New reference
        Public Property tree As New reference
        Public Property wood As New reference
        Public Property sortiment As New reference
        Public Property value As Decimal
        Public Property note As String

        Public Function ToRow() As String() Implements IRow.ToRow
            Dim h As New List(Of String)

            h.Add(location.forestry.name)
            h.Add(location.subforestry.name)
            h.Add(location.tract.name)
            h.Add(location.quarter)
            h.Add(location.taxationUnit)
            h.Add(location.cuttingArea)
            h.Add(areaSquare)
            h.Add(areaCutting)
            h.Add(farm)
            h.Add(formCutting)
            h.Add(typeCutting.name)
            h.Add(tree.description)
            h.Add(wood.description)
            h.Add(sortiment.name)
            h.Add(value)
            h.Add(note)

            Return h.ToArray
        End Function


        Public Function toHtml(html As String) As String Implements IRow.toHtml
            Dim deep As String = html
            Dim dic As New Dictionary(Of String, String) From {
                {"!D10", formCutting},
                {"!D11", typeCutting.name},
                {"!D22", tree.description},
                {"!D12", wood.description},
                {"!D13", sortiment.name},
                {"!D14", value},
                {"!D15", note},
                {"!D1", location.forestry.name},
                {"!D2", location.subforestry.name},
                {"!D3", location.tract.name},
                {"!D4", location.quarter},
                {"!D5", location.taxationUnit},
                {"!D6", location.cuttingArea},
                {"!D7", ПреобразоватьСтроку(areaSquare)},
                {"!D8", areaCutting},
                {"!D9", farm}}

            For Each tv In dic
                deep = Replace(deep, tv.Key, tv.Value)
            Next

            Return deep
        End Function

    End Class

    <XmlTypeAttribute([Namespace]:=VERXSD)>
    Public Class notWoodHarvestingRow
        Implements IRow
        Public Property usageType As New reference
        Public Property location As New locationClass
        Public Property area As Decimal = 0.0
        Public Property resourceType As New reference
        Public Property unitType As New reference
        Public Property volume As Decimal = 0.0

        Public Function ToRow() As String() Implements IRow.ToRow
            Dim h As New List(Of String)
            h.Add(usageType.name)
            h.Add(location.forestry.name)
            h.Add(location.subforestry.name)
            h.Add(location.tract.name)
            h.Add(location.quarter)
            h.Add(location.taxationUnit)
            h.Add(area)
            h.Add(resourceType.name)
            h.Add(unitType.name)
            h.Add(volume)
            Return h.ToArray
        End Function

        Public Function toHtml(html As String) As String Implements IRow.toHtml
            Dim deep As String = html
            Dim dic As New Dictionary(Of String, String) From {
                {"!G10", volume},
                {"!G1", usageType.name},
                {"!G2", location.forestry.name},
                {"!G3", location.subforestry.name},
                {"!G4", location.tract.name},
                {"!G5", location.quarter},
                {"!G6", location.taxationUnit},
                {"!G7", area},
                {"!G8", resourceType.name},
                {"!G9", unitType.name}
                }
            For Each tv In dic
                deep = Replace(deep, tv.Key, tv.Value)
            Next

            Return deep
        End Function
    End Class

    <XmlTypeAttribute([Namespace]:=VERXSD)>
    Public Class measureRow
        Implements IRow
        Public Property measure As New reference
        Public Property [object] As New reference
        Public Property location As New locationClass
        Public Property area As Decimal = 0.0
        Public Property farm As String
        Public Property formCutting As String
        Public Property typeCutting As New reference
        Public Property tree As New reference
        Public Property wood As New reference
        Public Property sortiment As New reference
        Public Property value As Decimal
        Public Property commercialValue As Decimal = 0.0

        Public Function ToRow() As String() Implements IRow.ToRow
            Dim h As New List(Of String)

            h.Add(measure.name)
            h.Add([Object].name)
            h.Add(location.forestry.name)
            h.Add(location.subforestry.name)
            h.Add(location.tract.name)
            h.Add(location.quarter)
            h.Add(location.taxationUnit)
            h.Add(location.cuttingArea)
            h.Add(area)
            h.Add(formCutting)
            h.Add(typeCutting.name)
            h.Add(wood.name)
            h.Add(sortiment.name)
            h.Add(value)
            h.Add(commercialValue)

            Return h.ToArray
        End Function

        Public Function toHtml(html As String) As String Implements IRow.toHtml

            Dim deep As String = html
            Dim dic As New Dictionary(Of String, String) From {
                {"!H10", farm},
                {"!H11", formCutting},
                {"!H22", tree.description},
                {"!H13", typeCutting.name},
                {"!H14", wood.name},
                {"!H15", sortiment.name},
                {"!H16", value},
                {"!H17", commercialValue},
                {"!H1", measure.name},
                {"!H2", [object].name},
                {"!H3", location.forestry.name},
                {"!H4", location.subforestry.name},
                {"!H5", location.tract.name},
                {"!H6", location.quarter},
                {"!H7", location.taxationUnit},
                {"!H8", location.cuttingArea},
                {"!H9", area}
                }

            For Each tv In dic
                deep = Replace(deep, tv.Key, tv.Value)
            Next

            Return deep
        End Function
    End Class

    <XmlTypeAttribute([Namespace]:=VERCTYPE)>
    Public Class file
        Public id As String ' Уникальный идентификатор файла в архиве
        Public name As String 'Оригинальное наименование файла (имя.расширение)
        Public extension As String ' Расширение оригинального файла
        <XmlElementAttribute(DataType:="base64Binary")>
        Public signature() As Byte 'Необязательный
        <XmlIgnore> Public Property patchFile As String

        Public Shared Function AddFile(sFile As String) As file
            Dim a As New file

            a.id = md5(sFile)
            a.name = IO.Path.GetFileName(sFile)
            a.extension = IO.Path.GetExtension(sFile)
            a.patchFile = sFile

            Return a
        End Function

        Private Shared Function md5(ByVal file As String) As String
            Dim h = Security.Cryptography.MD5.Create()
            Dim str$ = ""
            Using fileStream As IO.FileStream = IO.File.OpenRead(file)
                fileStream.Position = 0
                Dim value() As Byte = h.ComputeHash(fileStream)
                Dim i As Integer
                For i = 0 To value.Length - 1
                    str$ += value(i).ToString("X2")
                Next i
                str$ = str$.ToLower
            End Using
            Return str$
        End Function

        Public Function toXml() As String
            Dim deep$
            deep = "		<file>" & vbCr &
            $"			<ct:id>{id}</ct:id>" & vbCr &
            $"			<ct:name>{name}</ct:name>" & vbCr &
            $"			<ct:extension>{extension}</ct:extension>" & vbCr &
            $"			<ct:signature/>" & vbCr & ' не требуеться
             "		</file>"
            Return deep
        End Function
    End Class
End Class


