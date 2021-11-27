Imports MySql.Data.MySqlClient

Public Class frmAtendimentosDetalhes



    Private Sub frmAtendimentosDetalhes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        titulo.Text = "Detalhes do atendimento: #" & strProtocoloSelect & " - " & strAssuntoSelect

        unidade.Text = strUnidadeSelect
        organizacao.Text = strOrganizacaoSelect
        tecnico.Text = strTecnicoSelect
        departamento.Text = strDepartamentoSelect
        categoria.Text = strCategoriaSelect
        criadoEm.Text = strCriadoSelect
        assunto.Text = strAssuntoSelect
        data.Text = strDataSelect
        agendado.Text = strAgendadoSelect

        msgUsuario.Text = mUsuario
        msgDepartamento.Text = mDepartamento
        pngSituacao.BackgroundImage = GaleriaSituacao.Images(pSituacao)

        LoadMensagem()
        PCarregaDadosMYSQL_Atendimentos()
        Filtro()
    End Sub

    Private Sub btnAgendar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub



    Dim Foto As New Panel
    Dim lblUsuario As Label
    Dim lblGrupo As Label
    Dim lblData As Label
    Dim lblMensagem As Label
    Dim flpNewMensagem As FlowLayoutPanel
    Dim Moldura As PictureBox
    Sub LoadMensagem()

        'Layout Estrutura=======================
        flpNewMensagem = New FlowLayoutPanel
        Dim flpFotoMensagem As New FlowLayoutPanel
        Dim flpCorpoMensagem As New FlowLayoutPanel

        Dim flpTopo As New FlowLayoutPanel
        Dim flpData As New FlowLayoutPanel
        Dim flpMensagem As New FlowLayoutPanel

        Dim pSeparador As New Panel

        Foto = New Panel
        Moldura = New PictureBox

        lblUsuario = New Label
        lblGrupo = New Label
        lblData = New Label
        lblMensagem = New Label


        '=====Propriedade Estrutura====================
        '=========PROPRIEDADES
        With flpNewMensagem
            .Size = New Size(671, 100)
            .Margin = New Padding(0, 0, 0, 0)
        End With

        With flpFotoMensagem
            .Size = New Size(49, 94)
            .Margin = New Padding(3, 3, 0, 3)
        End With

        With flpCorpoMensagem
            .Size = New Size(611, 94)
            .Margin = New Padding(3, 3, 0, 3)
        End With

        With flpTopo
            .Size = New Size(472, 31)
            .Margin = New Padding(0, 0, 0, 0)
        End With

        With flpData
            .Size = New Size(139, 31)
            .Margin = New Padding(0, 0, 0, 0)
            .FlowDirection = FlowDirection.RightToLeft
        End With

        With flpMensagem
            .Size = New Size(591, 58)
            .Margin = New Padding(0, 0, 0, 0)
        End With

        With pSeparador
            .Size = New Size(609, 1)
            .Margin = New Padding(0, 0, 0, 0)
            .BackColor = Color.LightGray
        End With

        With Moldura
            .Size = New Size(40, 40)
            .Margin = New Padding(0, 0, 0, 0)
            .BackColor = Color.Transparent
            .BackgroundImage = Galeria.Images(1)
            .BackgroundImageLayout = ImageLayout.Zoom
        End With

        With Foto
            .Size = New Size(40, 40)
            .Margin = New Padding(0, 0, 0, 0)
            .BackgroundImageLayout = ImageLayout.Zoom
        End With

        '==============================================


        '======Inserindo Estrutura==================

        flpNewMensagem.Controls.Add(flpFotoMensagem)
        flpNewMensagem.Controls.Add(flpCorpoMensagem)

        flpFotoMensagem.Controls.Add(Foto)
        Foto.Controls.Add(Moldura)

        flpCorpoMensagem.Controls.Add(flpTopo)
        flpCorpoMensagem.Controls.Add(flpData)
        flpCorpoMensagem.Controls.Add(flpMensagem)
        flpCorpoMensagem.Controls.Add(pSeparador)
        '===========================================



        'Conteudo================================
        With lblUsuario
            .Font = New Font("Arial Narrow", 9.75, FontStyle.Bold)
            .ForeColor = Color.DimGray
            .Margin = New Padding(0, 0, 0, 0)
            .AutoSize = True
        End With

        With lblGrupo
            .Font = New Font("Arial Narrow", 9.75, FontStyle.Regular)
            .ForeColor = Color.LightGray
            .Margin = New Padding(0, 0, 0, 0)
            .AutoSize = True
        End With

        With lblData
            .Font = New Font("Arial Narrow", 9.75, FontStyle.Regular)
            .ForeColor = Color.LightGray
            .Margin = New Padding(0, 0, 0, 0)
            .AutoSize = True
        End With

        With lblMensagem
            .Font = New Font("Arial Narrow", 9.75, FontStyle.Regular)
            .ForeColor = Color.DimGray
            .AutoSize = True
        End With

        '========Inserindo Conteudo==============
        flpFotoMensagem.Controls.Add(Foto)
        flpTopo.Controls.Add(lblUsuario)
        flpTopo.Controls.Add(lblGrupo)
        flpData.Controls.Add(lblData)
        flpMensagem.Controls.Add(lblMensagem)

    End Sub

    Dim GridVirtual As DataGridView
    '========STRING DE CONEXÃO PARA CARREGAR DADOS EM GRID =========================
    Sub PCarregaDadosMYSQL_Atendimentos()
        GridVirtual = New DataGridView '|
        Try                                                                     '|
            newConn()                                                           '| ABRE CONEXÃO
            Dim _MySQL As String = "SELECT *FROM mensagens ORDER BY id_msg DESC" '| SELECIONA A TABELA
            cmd = New MySqlCommand(_MySQL, conn)                                '| 
            adap = New MySqlDataAdapter(cmd)                                    '|
            dt = New DataTable                                                  '|
            adap.Fill(dt)                                                       '|
            DataGridView1.DataSource = dt                                         '| PREENCHE DATAGRIDVIEW
        Catch ex As Exception                                                   '|

            Exit Sub
        Finally                                                                 '|
            conn.Close()                                                        '|
        End Try



    End Sub                                                                     '|

    Sub Filtro()
        newConn()
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        da = New MySqlDataAdapter("SELECT * FROM mensagens WHERE protocolo_msg = '" & strProtocoloSelect & "' ORDER BY id_msg DESC", conn)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt


        conn.Close()
        da.Dispose()

        For Each colunas As DataGridViewRow In DataGridView1.Rows
            If strProtocoloSelect = colunas.Cells("protocolo_msg").Value Then

                newConn()
                Dim leitor As MySqlDataReader '|
                cmd = New MySqlCommand("SELECT *FROM usuarios WHERE nome_usu = '" & colunas.Cells("usuario_msg").Value & "'", conn)
                leitor = cmd.ExecuteReader()

                If leitor.HasRows Then
                    leitor.Read()
                    Dim i As Integer = leitor("foto_usu").ToString
                    Foto.BackgroundImage = Galeria.Images(i)
                End If

                lblUsuario.Text = colunas.Cells("usuario_msg").Value
                lblGrupo.Text = colunas.Cells("grupo_msg").Value
                lblData.Text = colunas.Cells("data_msg").Value
                lblMensagem.Text = colunas.Cells("mensagem_msg").Value

                conn.Close()

                GridMensagens.Controls.Add(flpNewMensagem)
                LoadMensagem()
            Else
                Exit Sub
            End If
        Next
    End Sub


    '==================================================================================

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        UpdateRegistro()
        Me.Close()
        frmAtendimentos.Close()
        FAtendimentos = New frmAtendimentos
        FAtendimentos.TopLevel = False
        FAtendimentos.Parent = tpAtendimentos
        FAtendimentos.Show()
    End Sub

    Private Sub UpdateRegistro()
        newConn()
        Try
            cmd = New MySqlCommand("UPDATE atendimentos SET status_ate = @status, situacao_ate = @situacao, finalizado_ate = @finalizado WHERE protocolo_ate = @protocolo ", conn)

            With cmd.Parameters
                .AddWithValue("@protocolo", strProtocoloSelect)
                .AddWithValue("@status", "CONCLUÍDO")
                .AddWithValue("@situacao", "3")
                .AddWithValue("@finalizado", datahoraAtual.ToShortDateString & " " & datahoraAtual.ToShortTimeString)
            End With

            If MsgBox("Deseja finalizar este atendimento?", vbYesNo) = MsgBoxResult.Yes Then
                cmd.ExecuteNonQuery()
                Refresh_Atendimentos()
            Else
                Exit Sub
            End If

        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddNovaMensagem()

        newConn()
        Dim leitor As MySqlDataReader '|
        cmd = New MySqlCommand("SELECT *FROM usuarios WHERE nome_usu = '" & strUsuario & "'", conn)
        leitor = cmd.ExecuteReader()

        If leitor.HasRows Then
            leitor.Read()
            strGrupoUsuario = leitor("grupo_usu").ToString
        End If
        conn.Close()

        newConn()

        Try
            cmd = New MySqlCommand("INSERT INTO mensagens(protocolo_msg, data_msg, usuario_msg, grupo_msg, mensagem_msg) VALUES (@protocolo, @data, @usuario, @grupo, @mensagem); UPDATE atendimentos SET status_ate = @status WHERE protocolo_ate = @protocoloUp", conn)
            '                                               
            With cmd.Parameters
                .AddWithValue("@protocoloUp", strProtocoloSelect)
                .AddWithValue("@status", "EM ANDAMENTO")
                .AddWithValue("@protocolo", strProtocoloSelect) 'Data.Text & " " & datahoraAtual.ToShortTimeString)
                .AddWithValue("@data", datahoraAtual.ToShortDateString & " " & datahoraAtual.ToShortTimeString)
                .AddWithValue("@usuario", strUsuario)
                .AddWithValue("@grupo", strGrupoUsuario)
                .AddWithValue("@mensagem", txtEnviarMensagem.Text)
            End With

            cmd.ExecuteNonQuery()
            cmd.Dispose()

        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Sub

    '========STRING DE CONEXÃO PARA CARREGAR DADOS EM GRID =========================
    Sub Refresh_Atendimentos()                                            '|

        adap.Fill(dt)                                                       '|
        frmAtendimentos.DgvAtendimentos.DataSource = dt                     '| PREENCHE DATAGRIDVIEW

    End Sub                                                                     '|

    Private Sub btnResponder_Click(sender As Object, e As EventArgs) Handles btnResponder.Click
        EnviarMensagem.Visible = True
        txtEnviarMensagem.Focus()
    End Sub

    Private Sub btnEnviarMensagem_Click(sender As Object, e As EventArgs) Handles btnEnviarMensagem.Click
        AddNovaMensagem()



        EnviarMensagem.Visible = False
        Me.Close()
        Dim F2 As New frmAtendimentosDetalhes
        F2.TopLevel = False
        F2.Parent = tpAtendimentos
        F2.Show()
    End Sub
End Class