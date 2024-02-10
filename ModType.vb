<System.AttributeUsage(System.AttributeTargets.Property)>
Public Class ModType
    Inherits System.Attribute

    Public MaxLen As Integer = 0
    Public MinLen As Integer = 0
    Public Format As FormattingRule = FormattingRule.Любое



    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="minlen_">минимальная длинна, если больше 0 тогда это поле обязательное </param>
    ''' <param name="maxlen_">максимальная длинна</param>
    ''' <param name="format_">тип правил</param>
    Sub New(minlen_ As Integer, maxlen_ As Integer, format_ As FormattingRule)
        MinLen = minlen_
        MaxLen = maxlen_
        Format = format_
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="format_">Формат ввода</param>
    ''' <param name="required">Обязательное поле или нет </param>
    Sub New(format_ As FormattingRule, required As Boolean)
        Format = format_
        If required = True Then MinLen = 1
    End Sub

    Sub New(minlen_ As Integer, maxlen_ As Integer)
        MinLen = minlen_
        MaxLen = maxlen_
    End Sub

    ''' <summary>
    ''' правил проверки
    ''' </summary>
    Public Enum FormattingRule
        НапрямуюTAG
        ТипСправочника
        ИНН
        ОГРН
        ОГРИП
        ФИО
        ТолькоЧисла
        ПочтаЭ
        Любое
        Дата
    End Enum



    Public Shared Function RuleOk(ByRef cntr As Control, mo As ModType) As Boolean

        Dim str As String = ""
        If cntr.GetType.Name = "TextBox" Then
            str = DirectCast(cntr, TextBox).Text
        ElseIf cntr.GetType.Name = "ComboBox" Then
            str = DirectCast(cntr, ComboBox).Text
        ElseIf cntr.GetType.Name = "NumericUpDown" Then
            str = DirectCast(cntr, NumericUpDown).Value
        End If

        cntr.BackColor = Color.WhiteSmoke
        Dim col = Color.LightSalmon

        If mo.Format = FormattingRule.НапрямуюTAG And mo.MinLen >= 1 And IsNothing(cntr) Then
            cntr.BackColor = col
            Return False
        End If

        If mo.MinLen >= 1 And str = "" Then
            cntr.BackColor = col
            Return False
        End If

        If mo.MaxLen <> 0 Then
            If mo.MaxLen <= str.Length Then
                cntr.BackColor = col
                Return False
            End If
        End If

        If mo.Format = FormattingRule.ИНН AndAlso CheckINN(str) = False Then
            cntr.BackColor = col
            Return False
        End If

        If mo.Format = FormattingRule.ОГРН AndAlso checkOGRN(str) = False Then
            cntr.BackColor = col
            Return False
        End If

        Return True
    End Function

End Class