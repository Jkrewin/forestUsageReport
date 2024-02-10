

Module main_mod
    Public Const VERXSD = "http://rosleshoz.gov.ru/xmlns/forestUsageReport/4.1" ' Изменить если появилась актуальная версия 
    Public Const VERCTYPE = "http://rosleshoz.gov.ru/xmlns/cTypes/4.3" ' Изменить если появилась актуальная версия 
    Public Const VERSTYPE = "http://rosleshoz.gov.ru/xmlns/sTypes/4.3" ' Изменить если появилась актуальная версия 
    Public Const VERCAT = "http://rosleshoz.gov.ru/xmlns/catalogs/4.1" ' Изменить если появилась актуальная версия 
    Public Const VERCATTYPE = "http://rosleshoz.gov.ru/xmlns/catalogsTypes/4.1" ' Изменить если появилась актуальная версия 



    Public ReadOnly Property MyCurDir As String = My.Application.Info.DirectoryPath ' папка где exe
    Public ReadOnly Property MyCurDirLib As String = My.Application.Info.DirectoryPath & "\sFiles\" ' накопительные файлы
    Public ReadOnly Property vbC As String = """" ' кавычки
    Public myDoc As New forestUsageReport
    Public myDataBase As New DataBase
    Public Property MyCatalor As catalog



    ''' <summary>
    ''' Отображает ошибку в программе
    ''' </summary>
    ''' <param name="a">текст ошибки</param>
    ''' <param name="view">без вывода на экран</param>
    ''' <remarks></remarks>
    Sub LogError(a As String, Optional view As Boolean = True)
        Dim ver As String = My.Application.Info.Version.ToString

        Static logTxt As String
        Static Loger As Integer

        If logTxt = a Then
            Loger += 1
        End If
        Dim deep As String = ""
        Dim fnd = FreeFile()
        logTxt = a
        If Loger = 4 Then
            Dim dd As MsgBoxResult = MsgBox("одна и таже ошибка повторяется более 4 раз остановить работу программы ?", MsgBoxStyle.OkCancel, "halt")
            If dd = MsgBoxResult.Ok Then
                FileOpen(fnd, My.Computer.FileSystem.CurrentDirectory & "/logerror.txt", OpenMode.Append)
                deep = "<table border='1' style='border-collapse: collapse' width='669' height='48'><tr><td height='12' width='669' bgcolor='#C0C0C0'>" & Now & " version " & ver & "</td>" &
            "</tr><tr><td height='28' width='669' bgcolor='#FFFF99'>Экстренное завершение программы из-за ошибки ----> " & a & "</td></tr></table>"
                Print(fnd, deep)
                FileClose(fnd)

                Exit Sub
            Else
                Loger = 0
            End If
        End If

        FileOpen(fnd, My.Computer.FileSystem.CurrentDirectory & "/logerror.html", OpenMode.Append)
        deep = "<table border='1' style='border-collapse: collapse' width='669' height='48'><tr><td height='12' width='669' bgcolor='#C0C0C0'>" & Now & " version " & ver & "</td>" &
    "</tr><tr><td height='28' width='669' bgcolor='#FFFF99'>" & a & "</td></tr></table>"
        Print(fnd, deep)
        FileClose(fnd)
        Dim I As Integer
        For I = 1 To 3
            Beep()   ' Sound a tone.
        Next I

        If view = True Then MsgBox(a, MsgBoxStyle.ApplicationModal, "error")
    End Sub
    ''' <summary>
    ''' сохраняет базу данных в файл
    ''' </summary>
    Public Sub SaveXmlDataBase()
        Dim w As New IO.StreamWriter(MyCurDir & "\DataBase.xml")
        Try
            Dim s As New Xml.Serialization.XmlSerializer(GetType(DataBase))
            s.Serialize(w, myDataBase)
        Catch ex As Exception
            LogError(ex.Message)
        Finally
            Dim dis As IDisposable = w
            dis.Dispose()
        End Try
    End Sub

    Public Function CheckINN(ByVal inn As String) As Boolean
        If inn = "" Then Return False
        Dim factor1() As Short = {2, 4, 10, 3, 5, 9, 4, 6, 8}
        Dim factor2() As Short = {7, 2, 4, 10, 3, 5, 9, 4, 6, 8}
        Dim factor3() As Short = {3, 7, 2, 4, 10, 3, 5, 9, 4, 6, 8}
        Dim i As Byte
        Dim SUM As Integer
        Dim sum2 As Integer
        Dim sINN As String

        sINN = inn

        If Len(sINN) <> 10 And Len(sINN) <> 12 Then
            Return False

            Exit Function
        Else
            If Len(sINN) = 10 Then
                SUM = 0
                For i = 0 To 8
                    SUM += CInt(Mid(sINN, i + 1, 1)) * factor1(i)
                Next i
                SUM = SUM Mod 11
                SUM = SUM Mod 10
                If (CInt(Mid(sINN, 10, 1)) = SUM) Then
                    Return True
                Else
                    Return False


                End If
            ElseIf Len(inn) = 12 Then
                SUM = 0
                For i = 0 To 9
                    SUM += CInt(Mid(sINN, i + 1, 1)) * factor2(i)
                Next i
                SUM = SUM Mod 11
                SUM = SUM Mod 10
                sum2 = 0
                For i = 0 To 10
                    sum2 += CInt(Mid(sINN, i + 1, 1)) * factor3(i)
                Next i
                sum2 = sum2 Mod 11
                sum2 = sum2 Mod 10
                If (CInt(Mid(sINN, 11, 1)) = SUM) And (CInt(Mid(sINN, 12, 1)) = sum2) Then
                    Return True
                Else
                    Return False

                End If
            End If
        End If
        Return True
    End Function

    Public Function checkOGRN(OGRNstring As String) As Boolean
        Dim Number As Long
        Try
            Number = Int64.Parse(OGRNstring)
        Catch ex As Exception
            Return False
        End Try
        If OGRNstring.Length = 13 Then
            Dim num12 As Integer = CInt(Math.Floor((CDbl(Number) / 10) Mod 11))
            Dim dgt13 As Integer = -1

            If num12 = 10 Then
                dgt13 = 0
            Else
                dgt13 = num12
            End If

            If Int32.Parse(OGRNstring.Substring(12, 1)) = dgt13 Then
                Return True
            Else
                Return False
            End If
        ElseIf OGRNstring.Length = 15 Then
            Dim num14 As Integer = CInt(Math.Floor((CDbl(Number) / 10) Mod 13))
            Dim dgt15 As Integer = num14 Mod 10

            If Int32.Parse(OGRNstring.Substring(14, 1)) = dgt15 Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' фильтрует на другие символы и создает целое число 
    ''' </summary>
    ''' <param name="a">TextBox</param>
    Public Sub ЦелоеЧисло(ByRef a As TextBox)
        Dim deep$ = ""
        For i = 1 To a.Text.Length
            Dim s As String = Mid(a.Text, i, 1)
            If s Like "[0-9]" Then deep$ &= s
        Next
        a.Text = deep$
    End Sub

    Public Function ПреобразоватьСтроку(d As Decimal) As String
        Return d.ToString.Replace(",", ".")
    End Function

    Public Sub ФильтруетИмена(ByRef a As TextBox)
        Dim deep$ = ""
        a.Text = StrConv(a.Text, VbStrConv.ProperCase)
        For i = 1 To a.Text.Length
            Dim s As String = Mid(a.Text, i, 1)
            If Not s Like "[0-9]" Then deep$ &= s
        Next
        a.Text = deep$
    End Sub

    Public Function Число00(i As Integer) As String
        Return String.Format("{0:0#}", i)
    End Function

    Public Function SetDateTimePicker(dp As DateTimePicker) As String
        Return dp.Value.Year & "-" & Число00(dp.Value.Month) & "-" & Число00(dp.Value.Day)
    End Function

    Private Function CustomAtt(tv As Reflection.PropertyInfo) As ModType
        If tv.GetCustomAttributes(False).Count <> 0 Then
            For Each cast In tv.GetCustomAttributes(False)
                Return TryCast(cast, ModType)
            Next
        End If
        Return Nothing
    End Function

    Private Function FindControl(cn As Control, name As String) As Control
        For Each cntrl As Control In cn.Controls
            If cntrl.AccessibleName IsNot Nothing Then
                If cntrl.AccessibleName.ToLower = name.ToLower Then
                    Return cntrl
                End If
            End If
        Next
        Return Nothing
    End Function

    ''' <summary>
    ''' Получает данные из класса и заполняет форму
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="obj"></param>
    ''' <param name="cn"></param>
    Public Sub ModGetDate(Of T)(obj As Object, cn As Control)
        Dim cl As T = obj
        For Each tv In cl.GetType.GetProperties
            Dim mo = CustomAtt(tv)
            Dim cntrl = FindControl(cn, tv.Name)
            If (mo IsNot Nothing) And (cntrl IsNot Nothing) Then
                If mo.Format = ModType.FormattingRule.НапрямуюTAG Then
                    'Прямой тип
                    cntrl.Tag = tv.GetValue(cl)
                    cntrl.Text = tv.GetValue(cl).ToString()
                Else
                    Select Case cntrl.GetType.Name
                        Case "TextBox"
                            Dim tbox As TextBox = cntrl
                            tbox.Text = tv.GetValue(cl)
                        Case "ComboBox"
                            Dim cbox As ComboBox = cntrl
                            Dim value As String = tv.GetValue(cl)
                            Dim de As IEnumerable(Of DeliverCl) = TryCast(cbox.DataSource, IEnumerable(Of DeliverCl))
                            For i = 0 To de.Count - 1
                                If de(i).Id = value Then
                                    cbox.SelectedItem = i
                                    Exit For
                                End If
                            Next
                        Case "NumericUpDown"
                            Dim nbox As NumericUpDown = cntrl
                            nbox.Value = tv.GetValue(cl)
                        Case "DateTimePicker"
                            Dim dtbox As DateTimePicker = cntrl
                            dtbox.Value = tv.GetValue(cl)
                        Case "Label"
                            Dim label As Label = cntrl
                            label.Text = tv.GetValue(cl)
                    End Select
                End If
            End If
        Next
    End Sub

    ''' <summary>
    ''' изменяет класс вносит данные
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="obj"></param>
    ''' <param name="cn"></param>
    ''' <returns></returns>
    Public Function ModSetDate(Of T)(obj As Object, cn As Control) As T
        Dim cl As T = obj
        For Each tv In cl.GetType.GetProperties
            Dim mo As ModType = CustomAtt(tv)
            Dim cntrl = FindControl(cn, tv.Name)
            If (mo IsNot Nothing) And (cntrl IsNot Nothing) Then
                If mo.Format = ModType.FormattingRule.НапрямуюTAG Then
                    'Прямой тип
                    If cntrl.Tag IsNot Nothing Then
                        Try
                            tv.SetValue(cl, cntrl.Tag)
                        Catch ex As Exception
                            LogError(ex.Message)
                        End Try
                    End If
                Else
                    Select Case cntrl.GetType.Name
                        Case "TextBox"
                            Dim tbox As TextBox = cntrl
                            'подборка типов обязательна тут

                            tv.SetValue(cl, tbox.Text)
                        Case "ComboBox"
                            Dim cbox As ComboBox = cntrl
                            If mo.Format = ModType.FormattingRule.ТипСправочника Then
                                'Поличаем выбранное значение как ID для типа 
                                Dim de As DeliverCl = TryCast(cbox.SelectedValue, DeliverCl)
                                If de IsNot Nothing Then
                                    tv.SetValue(cl, de.Id)
                                End If
                            Else
                                ' Просто получаем текст если нет ТипСправочника
                                tv.SetValue(cl, cbox.Text)
                            End If
                        Case "ListBox"
                            Dim lbox As ListBox = cntrl
                            tv.SetValue(cl, lbox.Text)
                        Case "NumericUpDown"
                            Dim nbox As NumericUpDown = cntrl
                            tv.SetValue(cl, nbox.Value)
                        Case "DateTimePicker"
                            Dim dtbox As DateTimePicker = cntrl
                            tv.SetValue(cl, SetDateTimePicker(dtbox))
                        Case "Label"
                            Dim label As Label = cntrl
                            tv.SetValue(cl, label.Text)
                    End Select
                End If
            End If
        Next
        Return obj
    End Function

    ''' <summary>
    ''' проверка на обязательные поля и длинну строк
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="obj"></param>
    ''' <returns>true есть ошибки</returns>
    Public Function ModCheckRule(Of T)(obj As Object, tab As Control) As Boolean
        Dim erro As Boolean = False
        Dim cl As T = obj

        For Each cntrl As Control In tab.Controls
            For Each tv In cl.GetType.GetProperties
                If cntrl.AccessibleName IsNot Nothing Then
                    Dim mo As ModType = CustomAtt(tv)
                    If mo IsNot Nothing And (cntrl.AccessibleName.ToLower = tv.Name.ToLower) Then
                        If ModType.RuleOk(cntrl, mo) = False Then erro = True
                    End If
                End If
            Next
        Next

        Return erro
    End Function
End Module
