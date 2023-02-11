Imports System.Xml.Serialization

<XmlRoot([Namespace]:=VERXSD, IsNullable:=True)>
Public Class forestUsageReport

    ''' <summary>
    ''' Указывает то что нужно (True) или нет фильтровать пробелы в reference так как в Базе данных НСИ есть пробелы в ID 
    ''' Поэтому некоторые программы удаляют пробелы другие нет 
    ''' </summary>
    <XmlIgnore> Public Shared ReadOnly Property TRIM_REFERENCE As Boolean
        Get
            Return Form1.CheckBox3.Checked
        End Get
    End Property

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
            Return New DeliverCl With {.id = id, .description = description, .name = name}
        End Function
    End Class

    <XmlTypeAttribute([Namespace]:=VERCTYPE)>
    Public Class serviceInfoClass
        Public provider As String = "Document ForestUsageReport" '
        Public version As String = "3.2"
        Public name As String = "forestUsageReport"
        Public guid As String = System.Guid.NewGuid.ToString() ' "51a51362-192a-45c6-8947-33e97f420dbf"
    End Class

    Public Class headerClass
        Public Property executiveAuthority As reference
            Get
                Dim v As DeliverCl = Form1.ComboBox1.SelectedValue
                Return IIf(IsNothing(v), Nothing, New reference With {.id = v.id, .description = v.description, .name = v.name})
            End Get
            Set(value As reference)
                Dim a As catalog.mainClass.element = MyCatalor.executiveAuthority.Find(Function(x) x.id = value.id)
                If IsNothing(a) Then                ' если такого значения не существует вообще в каталоге
                    Form1.ComboBox2.SelectedIndex = 0
                    Form1.ComboBox2.Items.Clear()
                    Form1.ComboBox1.Enabled = False
                Else                                ' если есть то должен быть верно выбран пункт субъекта страны 
                    Dim s As List(Of DeliverCl) = Form1.ComboBox2.DataSource
                    Form1.ComboBox2.SelectedIndex = s.FindIndex(Function(x) x.id = a.subject.id)
                    ' загружаем списик лесхозов
                    s = Form1.ComboBox1.DataSource
                    Form1.ComboBox1.SelectedIndex = s.FindIndex(Function(x) x.id = value.id)
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
                    Return Form1.DateTimePicker1.Value.Year & "-" & Число00(Form1.DateTimePicker1.Value.Month) & "-" & Число00(Form1.DateTimePicker1.Value.Day)
                End Get
                Set(value As String)
                    Form1.DateTimePicker1.Value = value
                End Set
            End Property

            Public Property [end] As String
                Get
                    Return Form1.DateTimePicker2.Value.Year & "-" & Число00(Form1.DateTimePicker2.Value.Month) & "-" & Число00(Form1.DateTimePicker2.Value.Day)
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
                    Return Form1.DateTimePicker3.Value.Year & "-" & Число00(Form1.DateTimePicker3.Value.Month) & "-" & Число00(Form1.DateTimePicker3.Value.Day)
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
                    Return Form1.DateTimePicker4.Value.Year & "-" & Число00(Form1.DateTimePicker4.Value.Month) & "-" & Число00(Form1.DateTimePicker4.Value.Day)
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

                Public Property phone As String 'new
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
        Function toXml() As String
        Function toHtml() As String
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
            h.Add(wood.description)
            h.Add(sortiment.name)
            h.Add(value)
            h.Add(note)

            Return h.ToArray
        End Function

        Public Function toXml() As String Implements IRow.toXml
            Dim deep As String = ""

            deep = "		<row>" & vbCr &
             "			<location>" & vbCr &
                      "				<ct:forestry" & location.forestry.ToString & vbCr &
                      "				<ct:subforestry" & location.subforestry.ToString & vbCr &
                      "				<ct:tract" & location.tract.ToString & vbCr &
                     $"				<ct:quarter>{location.quarter}</ct:quarter>" & vbCr &
                     $"				<ct:taxationUnit>{location.taxationUnit}</ct:taxationUnit>" & vbCr &
                     $"				<ct:cuttingArea>{location.cuttingArea}</ct:cuttingArea>" & vbCr &
             "			</location>" & vbCr &
            $"			<areaSquare>{ПреобразоватьСтроку(areaSquare)}</areaSquare>" & vbCr &
            $"			<areaCutting>{ПреобразоватьСтроку(areaCutting)}</areaCutting>" & vbCr &
            $"			<farm>{farm}</farm>" & vbCr &
            $"			<formCutting>{formCutting}</formCutting>" & vbCr &
             "			<typeCutting" & typeCutting.ToString & vbCr &
             "			<wood" & wood.ToString & vbCr &
             "			<sortiment" & sortiment.ToString & vbCr &
            $"			<value>{ПреобразоватьСтроку(value)}</value>" & vbCr &
            $"			<note>{note}</note>" & vbCr &
          "		</row>"

            Return deep
        End Function

        Public Function toHtml() As String Implements IRow.toHtml
            Dim deep$ = ""

            deep = $"<tr>
  <td width=132 colspan=2 valign=top style='width:99.25pt;border:solid windowtext 1.0pt;
  border-top:none;padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{location.forestry.name}</p>
  </td>
  <td width=106 colspan=4 valign=top style='width:79.15pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{location.subforestry.name}</p>
  </td>
  <td width=127 colspan=4 valign=top style='width:95.05pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{location.tract.name}</p>
  </td>
  <td width=70 colspan=3 valign=top style='width:52.6pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{location.quarter}</p>
  </td>
  <td width=140 colspan=5 valign=top style='width:105.2pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{location.taxationUnit}</p>
  </td>
  <td width=79 colspan=4 valign=top style='width:59.05pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{location.cuttingArea}</p>
  </td>
  <td width=115 colspan=4 valign=top style='width:86.15pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{ПреобразоватьСтроку(areaSquare)}</p>
  </td>
  <td width=80 valign=top style='width:59.75pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{areaCutting}</p>
  </td>
  <td width=104 colspan=6 valign=top style='width:78.15pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{farm}</p>
  </td>
  <td width=86 colspan=5 valign=top style='width:64.4pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{formCutting}</p>
  </td>
  <td width=70 colspan=4 valign=top style='width:52.5pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{typeCutting.name}</p>
  </td>
  <td width=114 colspan=4 valign=top style='width:85.45pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{wood.description }</p>
  </td>
  <td width=109 colspan=5 valign=top style='width:81.6pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{sortiment.name }</p>
  </td>
  <td width=103 colspan=4 valign=top style='width:77.1pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{value}</p>
  </td>
  <td width=127 colspan=3 valign=top style='width:95.45pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal style='margin-bottom:0cm;line-height:normal'>{note}</p>
  </td>
  <td style='border:none;padding:0cm 0cm 0cm 0cm' width=0><p class='MsoNormal'>&nbsp;</td>
 </tr>"

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
        Public Function toXml() As String Implements IRow.toXml
            Dim deep As String = ""

            deep = "		<row>" & vbCr &
                $"          <usageType>{usageType}</usageType>" & vbCr &
                 " 			<location>" & vbCr &
                          "				<ct:forestry" & location.forestry.ToString & vbCr &
                          "				<ct:subforestry" & location.subforestry.ToString & vbCr &
                          "				<ct:tract" & location.tract.ToString & vbCr &
                         $"				<ct:quarter>{location.quarter}</ct:quarter>" & vbCr &
                         $"				<ct:taxationUnit>{location.taxationUnit}</ct:taxationUnit>" & vbCr &
                         $"				<ct:cuttingArea>{location.cuttingArea}</ct:cuttingArea>" & vbCr &
                 "			</location>" & vbCr &
                $"			<area>{ПреобразоватьСтроку(area)}</area>" & vbCr &
                $"			<resourceType>{resourceType}</resourceType>" & vbCr &
                $"			<unitType>{unitType}</unitType>" & vbCr &
                $"			<volume>{volume}</volume>" & vbCr &
                 "		</row>"

            Return deep
        End Function
        Public Function toHtml() As String Implements IRow.toHtml
            Dim deep$ = ""

            deep$ = $"<tr> 	
 	<td width=196 colspan=5 valign=top style='width:147.05pt;border:solid windowtext 1.0pt;
  border-top:none;padding:0cm 5.4pt 0cm 5.4pt'>
 		<p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{usageType.name }</p>
 	</td>
 	<td width=120 colspan=4 valign=top style='width:90.25pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
 		<p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{location.forestry.name}</p>
 	</td>
 	<td width=142 colspan=5 valign=top style='width:106.5pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
 		<p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'><span>{location.subforestry.name}</span></p>
 	</td>
 	<td width=128 colspan=6 valign=top style='width:95.75pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
 		<p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'><span>{location.tract.name}</span></p>
 	</td>
 	<td width=97 colspan=3 valign=top style='width:72.7pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
 		<p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{location.quarter}</p>
 	</td>
 	<td width=166 colspan=5 valign=top style='width:124.45pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
 		<p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{location.taxationUnit}</p>
 	</td>
 	<td width=79 valign=top style='width:59.25pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
 		<p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{area}</p>
 	</td>
 	<td width=248 colspan=16 valign=top style='width:185.85pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
 		<p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{resourceType.name}</p>
 	</td>
 	<td width=85 colspan=4 valign=top style='width:64.1pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
 		<p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{unitType.name}</p>
 	</td>
 	<td width=300 colspan=9 valign=top style='width:224.95pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
 		<p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{volume}</p>
 	</td>
 	<td style='border:none;padding:0cm 0cm 0cm 0cm' width=0><p class='MsoNormal'>&nbsp;</td>
 </tr>"

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

        Public Function toXml() As String Implements IRow.toXml
            Dim deep As String = ""

            deep = "		<row>" & vbCr &
               $"			<ct:measure>{measure.ToString}</ct:measure>" & vbCr &
               $"			<ct:object>{[object].ToString}</ct:object>" & vbCr &
                "			<location>" & vbCr &
                         "				<ct:forestry" & location.forestry.ToString & vbCr &
                         "				<ct:subforestry" & location.subforestry.ToString & vbCr &
                         "				<ct:tract" & location.tract.ToString & vbCr &
                        $"				<ct:quarter>{location.quarter}</ct:quarter>" & vbCr &
                        $"				<ct:taxationUnit>{location.taxationUnit}</ct:taxationUnit>" & vbCr &
                        $"				<ct:cuttingArea>{location.cuttingArea}</ct:cuttingArea>" & vbCr &
                "			</location>" & vbCr &
               $"			<area>{ПреобразоватьСтроку(area)}</area>" & vbCr &
               $"			<farm>{farm}</farm>" & vbCr &
               $"			<formCutting>{formCutting}</formCutting>" & vbCr &
               $"			<ct:typeCutting>{typeCutting.ToString}</ct:typeCutting>" & vbCr &
                " 			<ct:wood" & wood.ToString & vbCr &
                "			<ct:sortiment" & sortiment.ToString & vbCr &
               $"			<value>{ПреобразоватьСтроку(value)}</value>" & vbCr &
               $"			<commercialValue>{ПреобразоватьСтроку(commercialValue)}</commercialValue>" & vbCr &
                "		</row>"

            Return deep
        End Function

        Public Function toHtml() As String Implements IRow.toHtml
            Dim deep$ = ""

            deep$ = $"<tr>
  <td style='border:none;padding:0cm 0cm 0cm 0cm' width=0><p class='MsoNormal'>&nbsp;</td>
  <td width=178 colspan=3 valign=top style='width:133.25pt;border:solid windowtext 1.0pt;
  border-top:none;padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{measure.name}</p>
  </td>
  <td width=128 colspan=4 valign=top style='width:95.8pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{[object].name}</p>
  </td>
  <td width=113 colspan=4 valign=top style='width:84.8pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{location.forestry.name}</p>
  </td>
  <td width=121 colspan=5 valign=top style='width:91.1pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{location.subforestry.name}</p>
  </td>
  <td width=109 colspan=4 valign=top style='width:81.4pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{location.tract.name}</p>
  </td>
  <td width=101 colspan=3 valign=top style='width:75.8pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{location.quarter}</p>
  </td>
  <td width=98 colspan=3 valign=top style='width:73.55pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{location.taxationUnit}</p>
  </td>
  <td width=87 colspan=4 valign=top style='width:64.9pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{location.cuttingArea}</p>
  </td>
  <td width=72 colspan=5 valign=top style='width:53.95pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{area}></p>
  </td>
  <td width=79 colspan=5 valign=top style='width:59.1pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{farm}></p>
  </td>
  <td width=81 colspan=3 valign=top style='width:60.4pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{formCutting}</p>
  </td>
  <td width=71 colspan=3 valign=top style='width:53.35pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{typeCutting.name}</p>
  </td>
  <td width=84 colspan=3 valign=top style='width:62.75pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{wood.name}</p>
  </td>
  <td width=108 colspan=4 valign=top style='width:80.75pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{sortiment.name}</p>
  </td>
  <td width=65 colspan=3 valign=top style='width:48.65pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'>{value}</p>
  </td>
  <td width=68 colspan=2 valign=top style='width:51.25pt;border-top:none;
  border-left:none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt'>
  <p class=MsoNormal align=center style='margin-bottom:0cm;text-align:center;
  line-height:normal'><span >{commercialValue}</span></p>
  </td>
 </tr>"

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


