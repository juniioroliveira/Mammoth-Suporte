Imports MySql.Data.MySqlClient

Public Class frmAtendimentos

    Dim datahoraAtual As DateTime = Now

    Private Sub frmChamados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Permissoes()

        If categoriaUsuario = "ATENDIMENTO" Then
            Titulo.Text = "Meus chamados"
            btnNovoChamado.Text = "Abrir chamado"
            btnAgendar.Visible = False
        ElseIf categoriaUsuario = "ADMINISTRATIVO" Then
            Titulo.Text = "Atendimentos"
            btnNovoChamado.Text = "Novo atendimento"
            btnAgendar.Visible = True
        End If
        PCarregaDadosMYSQL_Atendimentos()
        CheckForIllegalCrossThreadCalls = False 'ELIMINA MENSAGEM DE ERRO DAS THREADS

        If categoriaUsuario <> "ADMINISTRATIVO" Then
            newConn()
            Dim da As MySqlDataAdapter
            Dim dt As DataTable
            da = New MySqlDataAdapter("SELECT * FROM atendimentos WHERE unidade = '" & strUsuario & "' ORDER BY protocolo DESC", conn)
            dt = New DataTable
            da.Fill(dt)
            DgvAtendimentos.DataSource = dt
            IdentificaStatusRegistro()
        End If

    End Sub
    Private Sub SegPlano_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles SegPlano.DoWork
        'ContadorRegistros_Atendimentos()
        PCarregaDadosMYSQL_Atendimentos()
    End Sub

    Private Sub AtualizaTimer_Tick(sender As Object, e As EventArgs) Handles AtualizaTimer.Tick

        SegPlano.RunWorkerAsync()   'Busca atualizações em segundo plano
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnNovoChamado.Click

        Dim F2 As New frmChamados_NovoRegistro
        F2.TopLevel = False
        F2.Parent = tpAtendimentos
        F2.Show()

    End Sub


    Private Sub DgvAtendimentos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvAtendimentos.CellDoubleClick
        Try
            strProtocoloSelect = DgvAtendimentos.Rows(e.RowIndex).Cells("protocolo").Value
            strUnidadeSelect = DgvAtendimentos.Rows(e.RowIndex).Cells("unidade").Value
            strOrganizacaoSelect = DgvAtendimentos.Rows(e.RowIndex).Cells("organizacao").Value
            strTecnicoSelect = DgvAtendimentos.Rows(e.RowIndex).Cells("tecnico").Value
            strDepartamentoSelect = DgvAtendimentos.Rows(e.RowIndex).Cells("departamento").Value
            strCategoriaSelect = DgvAtendimentos.Rows(e.RowIndex).Cells("categoria").Value
            strCriadoSelect = DgvAtendimentos.Rows(e.RowIndex).Cells("data").Value
            strAssuntoSelect = DgvAtendimentos.Rows(e.RowIndex).Cells("assunto").Value
            strDataSelect = DgvAtendimentos.Rows(e.RowIndex).Cells("data").Value
            If DgvAtendimentos.Rows(e.RowIndex).Cells("prazo").Value IsNot DBNull.Value Then
                strAgendadoSelect = DgvAtendimentos.Rows(e.RowIndex).Cells("prazo").Value
            End If
            mUsuario = DgvAtendimentos.Rows(e.RowIndex).Cells("unidade").Value
            mDepartamento = DgvAtendimentos.Rows(e.RowIndex).Cells("organizacao").Value

            pSituacao = DgvAtendimentos.Rows(e.RowIndex).Cells("situacao").Value

            Dim F2 As New frmAtendimentosDetalhes
            F2.TopLevel = False
            F2.Parent = tpAtendimentos
            F2.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    '=================================================================================


    '========STRING DE CONEXÃO PARA CARREGAR DADOS EM GRID =========================
    Sub PCarregaDadosMYSQL_Atendimentos()                                            '|
        Try                                                                     '|
            newConn()                                                           '| ABRE CONEXÃO
            Dim _MySQL As String = "SELECT *FROM atendimentos ORDER BY protocolo DESC" '| SELECIONA A TABELA
            cmd = New MySqlCommand(_MySQL, conn)                                '| 
            adap = New MySqlDataAdapter(cmd)                                    '|
            dt = New DataTable                                                  '|
            adap.Fill(dt)                                                       '|
            DgvAtendimentos.DataSource = dt                                         '| PREENCHE DATAGRIDVIEW
        Catch ex As Exception                                                   '|

            Exit Sub
        Finally                                                                 '|
            conn.Close()                                                        '|
            ContadorRegistros_Atendimentos()
            IdentificaStatusRegistro()
            StyleDgv_Atendimentos()
        End Try                                                                 '|
    End Sub                                                                     '|
    '==================================================================================

    '================ESTILO DA GRID====================================================
    Sub StyleDgv_Atendimentos()


        With DgvAtendimentos.Columns("icon")
            .Visible = True
            .DisplayIndex = 0
            .Width = 20
            .HeaderText = ""
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With

        With DgvAtendimentos.Columns("status")
            .Visible = False
            .DisplayIndex = 1
            .Width = 100
            .HeaderText = "STATUS"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With

        With DgvAtendimentos.Columns("protocolo")
            .Visible = True
            .DisplayIndex = 2
            .Width = 90
            .HeaderText = "PROTOCOLO"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With

        With DgvAtendimentos.Columns("assunto")
            .Visible = True
            .DisplayIndex = 3
            .MinimumWidth = 170
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .HeaderText = "ASSUNTO"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With

        With DgvAtendimentos.Columns("departamento")
            .Visible = True
            .DisplayIndex = 4
            .MinimumWidth = 120
            '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .HeaderText = "DEPARTAMENTO"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With

        With DgvAtendimentos.Columns("unidade")
            .Visible = True
            .DisplayIndex = 5
            .MinimumWidth = 90
            '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .HeaderText = "UNIDADE"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With

        With DgvAtendimentos.Columns("organizacao")
            .Visible = False
            .DisplayIndex = 6
            .MinimumWidth = 115
            '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .HeaderText = "ORGANIZAÇÃO"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With

        With DgvAtendimentos.Columns("categoria")
            .Visible = True
            .DisplayIndex = 7
            .MinimumWidth = 120
            '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .HeaderText = "CATEGORIA"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With

        With DgvAtendimentos.Columns("data")
            .Visible = True
            .DisplayIndex = 8
            .Width = 120
            .HeaderText = "DATA"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With

        With DgvAtendimentos.Columns("situacao")
            .Visible = False
            .DisplayIndex = 12
            .Width = 90
            .HeaderText = "SITUAÇÃO"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With

        With DgvAtendimentos.Columns("tecnico")
            .Visible = True
            .DisplayIndex = 10
            .Width = 85
            .HeaderText = "TÉCNICO"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With

        With DgvAtendimentos.Columns("finalizado")
            .Visible = False
            .DisplayIndex = 11
            .Width = 100
            .HeaderText = "FINALIZADO"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With

        With DgvAtendimentos.Columns("icoSituacao")
            .Visible = True
            .DisplayIndex = 9
            .Width = 100
            .HeaderText = "SITUAÇÃO"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With

        With DgvAtendimentos.Columns("prazo")
            .Visible = False
            .DisplayIndex = 13
            .Width = 50
            .HeaderText = ""
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With

    End Sub
    '=================================================================================

    '========================CONTADOR DE REGISTROS===================================
    Sub ContadorRegistros_Atendimentos()
        Try
            newConn()
            cmd = New MySqlCommand("SELECT COUNT(protocolo) as quantidade FROM Atendimentos WHERE status = 'PENDENTE'", conn)
            Dim a As Integer = cmd.ExecuteScalar()
            cmd = Nothing
            'conn.Close()
            contPendente.Text = a

            'newConn()
            cmd = New MySqlCommand("SELECT COUNT(protocolo) as quantidade FROM Atendimentos WHERE status = 'EM ANDAMENTO' AND tecnico is NULL", conn)
            Dim b As Integer = cmd.ExecuteScalar()
            cmd = Nothing
            'conn.Close()
            contAndamento.Text = b

            'newConn()
            cmd = New MySqlCommand("SELECT COUNT(protocolo) as quantidade FROM Atendimentos WHERE status = 'CANCELADO'", conn)
            Dim c As Integer = cmd.ExecuteScalar()
            cmd = Nothing
            conn.Close()
            contCancelado.Text = c


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    '================================================================================

    '===================IDENTIFICAR STATUS DO CHAMADO=================================
    Sub IdentificaStatusRegistro()
        'REFERENCIAS SITUAÇÃO
        '0 - Aguardando
        '1 - Agendado
        '2 - Atrasado
        '3 - Finalizado
        '4 - Concluido
        '5 - Cancelado
        Try
            For i As Integer = 0 To DgvAtendimentos.Rows.Count - 1

                Dim situacao As Integer = DgvAtendimentos.Rows(i).Cells("situacao").Value
                DgvAtendimentos.Rows(i).Cells("icoSituacao").Value = GaleriaSituacao.Images(situacao)
                DgvAtendimentos.Rows(i).Cells("icon").Value = ImageList1.Images(situacao)


                If DgvAtendimentos.Rows(i).Cells("situacao").Value <> 3 Then
                    Dim prazo As Date
                    Dim hoje As Date = datahoraAtual.ToShortDateString


                    If DgvAtendimentos.Rows(i).Cells("prazo").Value IsNot DBNull.Value Then
                        prazo = DgvAtendimentos.Rows(i).Cells("prazo").Value

                        If DateTime.Compare(prazo, hoje) = "-1" Then
                            DgvAtendimentos.Rows(i).Cells("icosituacao").Value = GaleriaSituacao.Images(2)
                        End If
                    End If
                End If

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btnAgendar_Click(sender As Object, e As EventArgs) Handles btnAgendar.Click
        If strProtocoloSelect > 0 Then
            If pSituacao = 3 Then
                MsgBox("Não é possível reagendar este atendimento. O mesmo já foi finalizado")
            Else
                With frmAtendimento_Agendar
                    .Text = "Agendar atendimento #" & strProtocoloSelect
                    .ShowDialog()
                End With
                PCarregaDadosMYSQL_Atendimentos()
            End If
        Else
            MsgBox("Selecione um chamado para ser baixado!")
        End If

    End Sub

    Private Sub DgvAtendimentos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvAtendimentos.CellClick
        Try
            strProtocoloSelect = DgvAtendimentos.Rows(e.RowIndex).Cells("protocolo").Value
            pSituacao = DgvAtendimentos.Rows(e.RowIndex).Cells("situacao").Value
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'REFERENCIAS SITUAÇÃO
    '0 - Aguardando
    '1 - Agendado
    '2 - Atrasado
    '3 - Finalizado
    '4 - Concluido
    '5 - Cancelado
    Private Sub FiltroTodos_Click(sender As Object, e As EventArgs) Handles FiltroTodos.Click
        If categoriaUsuario = "ADMINISTRATIVO" Then
            PCarregaDadosMYSQL_Atendimentos()
            IdentificaStatusRegistro()
        Else
            newConn()
            Dim da As MySqlDataAdapter
            Dim dt As DataTable
            da = New MySqlDataAdapter("SELECT * FROM atendimentos WHERE unidade = '" & strUsuario & "' ORDER BY protocolo DESC", conn)
            dt = New DataTable
            da.Fill(dt)
            DgvAtendimentos.DataSource = dt
            IdentificaStatusRegistro()
        End If

    End Sub

    Private Sub FiltroAguardando_Click(sender As Object, e As EventArgs) Handles FiltroAguardando.Click
        If categoriaUsuario = "ADMINISTRATIVO" Then
            newConn()
            Dim da As MySqlDataAdapter
            Dim dt As DataTable
            da = New MySqlDataAdapter("SELECT * FROM atendimentos WHERE situacao = '" & "0" & "' ORDER BY protocolo DESC", conn)
            dt = New DataTable
            da.Fill(dt)
            DgvAtendimentos.DataSource = dt
            IdentificaStatusRegistro()
        Else
            newConn()
            Dim da As MySqlDataAdapter
            Dim dt As DataTable
            da = New MySqlDataAdapter("SELECT * FROM atendimentos WHERE situacao = '" & "0" & "' AND  unidade = '" & strUsuario & "' ORDER BY protocolo DESC", conn)
            dt = New DataTable
            da.Fill(dt)
            DgvAtendimentos.DataSource = dt
            IdentificaStatusRegistro()
        End If
    End Sub

    Private Sub FiltroAgendado_Click(sender As Object, e As EventArgs) Handles FiltroAgendado.Click

        If categoriaUsuario = "ADMINISTRATIVO" Then
            newConn()
            Dim da As MySqlDataAdapter
            Dim dt As DataTable
            da = New MySqlDataAdapter("SELECT * FROM atendimentos WHERE situacao = '" & "1" & "' ORDER BY protocolo DESC", conn)
            dt = New DataTable
            da.Fill(dt)
            DgvAtendimentos.DataSource = dt
            IdentificaStatusRegistro()
        Else
            newConn()
            Dim da As MySqlDataAdapter
            Dim dt As DataTable
            da = New MySqlDataAdapter("SELECT * FROM atendimentos WHERE situacao = '" & "1" & "' AND  unidade = '" & strUsuario & "' ORDER BY protocolo DESC", conn)
            dt = New DataTable
            da.Fill(dt)
            DgvAtendimentos.DataSource = dt
            IdentificaStatusRegistro()
        End If
    End Sub

    Private Sub FiltroFinalizado_Click(sender As Object, e As EventArgs) Handles FiltroFinalizado.Click
        If categoriaUsuario = "ADMINISTRATIVO" Then
            newConn()
            Dim da As MySqlDataAdapter
            Dim dt As DataTable
            da = New MySqlDataAdapter("SELECT * FROM atendimentos WHERE situacao = '" & "3" & "' ORDER BY protocolo DESC", conn)
            dt = New DataTable
            da.Fill(dt)
            DgvAtendimentos.DataSource = dt
            IdentificaStatusRegistro()
        Else
            newConn()
            Dim da As MySqlDataAdapter
            Dim dt As DataTable
            da = New MySqlDataAdapter("SELECT * FROM atendimentos WHERE situacao = '" & "3" & "' AND  unidade = '" & strUsuario & "' ORDER BY protocolo DESC", conn)
            dt = New DataTable
            da.Fill(dt)
            DgvAtendimentos.DataSource = dt
            IdentificaStatusRegistro()
        End If
    End Sub

    Private Sub FiltroCancelado_Click(sender As Object, e As EventArgs) Handles FiltroCancelado.Click
        If categoriaUsuario = "ADMINISTRATIVO" Then
            newConn()
            Dim da As MySqlDataAdapter
            Dim dt As DataTable
            da = New MySqlDataAdapter("SELECT * FROM atendimentos WHERE situacao = '" & "4" & "' ORDER BY protocolo DESC", conn)
            dt = New DataTable
            da.Fill(dt)
            DgvAtendimentos.DataSource = dt
            IdentificaStatusRegistro()
        Else
            newConn()
            Dim da As MySqlDataAdapter
            Dim dt As DataTable
            da = New MySqlDataAdapter("SELECT * FROM atendimentos WHERE situacao = '" & "4" & "' AND  unidade = '" & strUsuario & "' ORDER BY protocolo DESC", conn)
            dt = New DataTable
            da.Fill(dt)
            DgvAtendimentos.DataSource = dt
            IdentificaStatusRegistro()
        End If
    End Sub
End Class