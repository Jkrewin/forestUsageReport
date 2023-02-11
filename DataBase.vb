Imports Partners = forestUsageReport_VB.forestUsageReport.headerClass.partnerClass

''' <summary>
''' Это локальня база данных для этой программы 
''' </summary>
Public Class DataBase
    Public Contract As New List(Of ContractClass)
    Public Companies As New List(Of company)

    Public DefaultCompany As company ' компания по умолчанию
    Public DefaultContract As ContractClass 'контакт по умолчанию
    Public DefaultsignerData As forestUsageReport.headerClass.signerDataClass ' кто подписал документ по умолчанию
    Public Property WinState As System.Windows.Forms.FormWindowState = FormWindowState.Normal ' текущее состояние окна программы
    Public Certificates As New CertificatesClass 'сохраняеи сведения об подписи файлов

    Public Class CertificatesClass
        ''' <summary>
        ''' Выбранная подпись по умолчанию
        ''' </summary>
        ''' <returns></returns>
        Public Property SelectSerial As String = ""
        ''' <summary>
        ''' Пин Код ЭЦП
        ''' </summary>
        ''' <returns></returns>
        Public Property PinCode As String = ""
        ''' <summary>
        ''' способ подписания файла
        ''' </summary>
        ''' <returns></returns>
        Public Property SigningMethod As SigningMethodEnum = SigningMethodEnum.EachFile
        ''' <summary>
        ''' Выводить X509Certificate2 по серийному номеру 
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property GetCertificat As System.Security.Cryptography.X509Certificates.X509Certificate2
            Get
                Dim d As System.Security.Cryptography.X509Certificates.X509Certificate2 = Nothing
                Dim store = New System.Security.Cryptography.X509Certificates.X509Store(System.Security.Cryptography.X509Certificates.StoreName.My, System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser)
                store.Open(System.Security.Cryptography.X509Certificates.OpenFlags.ReadOnly)
                For Each certificate In store.Certificates
                    If certificate.SerialNumber = SelectSerial Then
                        d = certificate
                        Exit For
                    End If
                Next
                store.Close()
                Return d
            End Get
        End Property

        ''' <summary>
        ''' Готовит строку параметров ключей для программы 
        ''' </summary>
        ''' <param name="file">место положение фалй не проверяет его наличие</param>
        ''' <returns></returns>
        Public Function Arguments(file As String) As String
            If PinCode = "" Then
                Return $"-sfsign -sign -in ""{file}"" -out ""{file}.sig"" -my ""{GetCertificat.SubjectName.Name}"" -addsigtime -add -detached"
            Else
                Return $"-sfsign -sign -in ""{file}"" -out ""{file}.sig"" -my ""{GetCertificat.SubjectName.Name}"" -addsigtime -add -detached -pinsrc=""{PinCode}"""
            End If
        End Function

        ''' <summary>
        ''' Существует или нет сертификат
        ''' </summary>
        ''' <returns>true - да есть</returns>
        Public Function CertificatExist() As Boolean
            Dim e As Boolean = False
            Dim store = New System.Security.Cryptography.X509Certificates.X509Store(System.Security.Cryptography.X509Certificates.StoreName.My, System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser)
            store.Open(System.Security.Cryptography.X509Certificates.OpenFlags.ReadOnly)
            For Each certificate In store.Certificates
                If certificate.SerialNumber = SelectSerial Then
                    e = True
                    Exit For
                End If
            Next
            store.Close()
            Return e
        End Function

        Public Enum SigningMethodEnum
            ''' <summary>
            ''' каждый файл
            ''' </summary>
            EachFile
            ''' <summary>
            ''' тьлькол архив
            ''' </summary>
            onlyZip
        End Enum
    End Class

    Public Class ContractClass
            Public Property ID As Integer = -1
            Public Property CTtype As String
            Public Property CTnumber As String
            Public Property CTdate As Date = Now
            Public Property CTregistrationNumber As String
            Public Property CTusageType As New DeliverCl
            Public Property CTapprovingProject As String
            Public Property CTapprovingDate As Date = Now
            Public Property ContractActive As Boolean = True


            Public Function toRow() As String()
                Dim a(5) As String
                a(0) = CTnumber
                a(1) = CTdate
                a(2) = CTtype
                a(3) = CTregistrationNumber
                a(5) = IIf(ContractActive, "Действует", "Закончен")
                a(4) = ID
                Return a
            End Function

            Public Shared Operator =(a As ContractClass, s As ContractClass)
            If a.CTnumber = s.CTnumber And a.CTdate.Date = s.CTdate.Date Then
                Return True
            Else
                Return False
                End If
            End Operator
            Public Shared Operator <>(a As ContractClass, s As ContractClass)
                If a.CTnumber = s.CTnumber And a.CTdate = s.CTdate Then
                    Return True
                Else
                    Return False
                End If
            End Operator
        End Class

    Public Class company
        Public Property ID As Integer = -1
        Public Property TypeCompany As ETypeCompany
        Public first_name As String
        Public last_name As String
        Public patronimic_name As String
        Public identity_document As New Partners.identity_documentClass
        Public ogrn As String
        Public inn As String
        Public name As String
        Public address As String
        Public phone As String

        Public Shared Operator =(a As company, b As company)
            If a.inn = b.inn Then
                Return True
            Else
                Return False
            End If
        End Operator
        Public Shared Operator <>(a As company, b As company)
            If a.inn = b.inn Then
                Return True
            Else
                Return False
            End If
        End Operator

        Public Function Get_individualEntrepreneurClass() As Partners.individualEntrepreneurClass
            Dim a As New Partners.individualEntrepreneurClass
            With a
                .first_name = first_name
                .last_name = last_name
                .patronimic_name = patronimic_name
                .identity_document = identity_document
                .ogrn = ogrn
                .inn = inn
            End With
            Return a
        End Function

        Public Function Get_juridicalPersonClass() As Partners.juridicalPersonClass
            Dim a As New Partners.juridicalPersonClass
            With a
                .ogrn = ogrn
                .name = name
                .address = address
                .inn = inn
            End With
            Return a
        End Function

        Public Function Get_physicalPersonClass() As Partners.physicalPersonClass
            Dim a As New Partners.physicalPersonClass
            With a
                .first_name = first_name
                .last_name = last_name
                .patronimic_name = patronimic_name
                .identity_document = identity_document
                .inn = inn
            End With
            Return a
        End Function

        Public Function toRow() As String()
            Dim a(4) As String
            a(0) = TypeCompany.ToString
            a(1) = inn
            a(2) = ogrn
            If TypeCompany = ETypeCompany.Компания Then
                a(3) = name
            Else
                a(3) = last_name & " " & Mid(first_name, 1, 1) & ". " & Mid(patronimic_name, 1, 1)
            End If
            a(4) = ID
            Return a
        End Function

        Public Enum ETypeCompany
            ИП
            Компания
            ЧастноеЛицо
        End Enum
    End Class


End Class