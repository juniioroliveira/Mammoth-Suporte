Public Class frmLogin
    Private WM_NCHITTEST As Integer = &H84
    Private HTCLIENT As Integer = &H1
    Private HTCAPTION As Integer = &H2

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)

        Select Case m.Msg
            Case WM_NCHITTEST
                If m.Result = New IntPtr(HTCLIENT) Then
                    m.Result = New IntPtr(HTCAPTION)
                End If
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        strUsuario = TextBox1.Text
        frmPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub _0___Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class