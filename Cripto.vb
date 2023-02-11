Imports System.IO
Imports System.Security.Cryptography.X509Certificates


Public Class Cripto
    Public Const PATCH_CSP = "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\csptest.exe"
    Private ReadOnly WordChoose As String = "(выбран) "
    Dim serial As New List(Of String)
    Private Sub Cripto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Text = myDataBase.Certificates.PinCode

        If myDataBase.Certificates.SigningMethod = DataBase.CertificatesClass.SigningMethodEnum.EachFile Then
            RadioButton1.Checked = True
        Else
            RadioButton2.Checked = True
        End If


        Dim readValue = My.Computer.Registry.GetValue(PATCH_CSP, "", Nothing)
        If readValue Is Nothing Then Exit Sub

        Label2.Visible = False
        RefrehCerf()
    End Sub


    Private Sub RefrehCerf()
        ListBox1.Items.Clear()
        Try
            Dim store = New X509Store(StoreName.My, StoreLocation.CurrentUser)
            store.Open(OpenFlags.ReadOnly)
            For Each certificate In store.Certificates
                If certificate.SubjectName.Name IsNot Nothing Then
                    Dim a As Integer = certificate.SubjectName.Name.IndexOf("CN=", 0, StringComparison.InvariantCulture)
                    Dim s As Integer = certificate.SubjectName.Name.IndexOf(",", a, StringComparison.InvariantCulture)
                    If a > 0 AndAlso s <> -1 Then
                        Dim d As String = ""
                        If Now.Date > certificate.NotAfter.Date Then d &= "(ПРОСРОЧЕН) "
                        If myDataBase.Certificates.SelectSerial = certificate.SerialNumber Then d &= WordChoose ' выбран
                        ListBox1.Items.Add(d & certificate.SubjectName.Name.Substring(a + 3, s - a) & " [" & certificate.NotBefore.Date & "-" & certificate.NotAfter.Date & "] ")
                        serial.Add(certificate.SerialNumber)
                    End If
                End If
            Next
            store.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Ошибка в программе")
            Me.Close()
        End Try
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub



    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Button2.Enabled = True
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not ListBox1.SelectedIndex = -1 Then
            myDataBase.Certificates.SelectSerial = serial.Item(ListBox1.SelectedIndex)
            RefrehCerf()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        myDataBase.Certificates.SigningMethod = DataBase.CertificatesClass.SigningMethodEnum.EachFile
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        myDataBase.Certificates.SigningMethod = DataBase.CertificatesClass.SigningMethodEnum.onlyZip
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        myDataBase.Certificates.PinCode = TextBox1.Text
    End Sub
End Class