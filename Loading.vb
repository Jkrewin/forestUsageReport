Imports System.IO
Imports System.Threading
Public Class Loading
    Dim csptest As String
    Dim fileTosing As List(Of String)
    Public Sub Sing(_fileTosing As List(Of String))
        If myDataBase.Certificates.CertificatExist = True Then
            csptest = CStr(My.Computer.Registry.GetValue(Cripto.PATCH_CSP, "", Nothing)) ' проверка была на существание в Cripto форма
            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = _fileTosing.Count - 1
            fileTosing = _fileTosing
            Timer1.Start()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Loading_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Enabled = True
        Form1.Select()
    End Sub

    Dim Index As Short = -1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Index += 1
        Dim psi As New ProcessStartInfo(csptest)
        psi.RedirectStandardError = True
        psi.RedirectStandardOutput = True
        psi.CreateNoWindow = False
        psi.WindowStyle = ProcessWindowStyle.Minimized
        psi.UseShellExecute = False
        psi.Arguments = myDataBase.Certificates.Arguments(fileTosing(Index))

        Dim process As Process = Process.Start(psi)
        process.Start()
        Dim reader As StreamReader = New StreamReader(process.StandardOutput.BaseStream, True) '1251 заменить на CP866
        Dim output As String = reader.ReadToEnd()
        process.WaitForExit()
        process.Dispose()
        If output.Contains("[ErrorCode 0x00000000]") = True Then
            MsgBox(output, MsgBoxStyle.Exclamation, "Ошибка Крипто ПРО")
            Me.Close()
        End If
        ProgressBar1.Value = Index
        If fileTosing.Count - 1 = Index Then
            Timer1.Stop()
            Me.Close()
        End If
    End Sub

    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100

        Timer1.Start()
    End Sub


End Class