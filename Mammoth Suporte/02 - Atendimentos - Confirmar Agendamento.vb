Imports MySql.Data.MySqlClient

Public Class frmAtendimento_Agendar

    Dim datahoraAtual As DateTime = Now
    Private Sub btnAgendar_Click(sender As Object, e As EventArgs) Handles btnAgendar.Click
        UpdateRegistro()
        frmAtendimentos.Close()
        FAtendimentos = New frmAtendimentos
        FAtendimentos.TopLevel = False
        FAtendimentos.Parent = tpAtendimentos
        FAtendimentos.Show()
    End Sub

    Private Sub UpdateRegistro()
        newConn()
        Try
            cmd = New MySqlCommand("UPDATE atendimentos SET status_ate = @status, categoria_ate = @categoria, situacao_ate = @situacao, tecnico_ate = @tecnico, prazo_ate = @prazo WHERE protocolo_ate = @protocolo ", conn)

            With cmd.Parameters
                .AddWithValue("@protocolo", strProtocoloSelect)
                .AddWithValue("@status", "EM ANDAMENTO")
                .AddWithValue("@categoria", Categoria.Text)
                .AddWithValue("@situacao", "1")
                .AddWithValue("@tecnico", Tecnico.Text)
                .AddWithValue("@prazo", Prazo.Text)
            End With

            If MsgBox("Deseja confirmar o agendamento?", vbYesNo) = MsgBoxResult.Yes Then
                cmd.ExecuteNonQuery()
            Else
                Exit Sub
            End If

        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub frmAtendimento_Agendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Prazo.Text = datahoraAtual.ToShortDateString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Prazo.Text = datahoraAtual.ToShortDateString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Prazo.Text = datahoraAtual.AddDays(1).ToShortDateString
    End Sub
End Class