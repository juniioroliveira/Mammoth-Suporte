Imports MySql.Data.MySqlClient

Public Class frmChamados_NovoRegistro
    Dim datahoraAtual As DateTime = Now
    Dim protocoloAtual As Integer

    Dim organizacao As String = ""

    Private Sub RetornaOrganizacao()
        Dim leitor As MySqlDataReader '|
        newConn()
        cmd = New MySqlCommand("SELECT *FROM usuarios WHERE nome_usu = '" & unidade.Text & "'", conn)
        leitor = cmd.ExecuteReader()

        If leitor.HasRows Then
            leitor.Read()
            organizacao = leitor("grupo_usu").ToString
            'MsgBox(organizacao & " - - - - " & leitor("grupo_usu").ToString)
        End If

        conn.Close()
    End Sub
    Private Sub AddNovoAtendimento()

        newConn()

        Try
            cmd = New MySqlCommand("INSERT INTO atendimentos(status_ate, assunto_ate, departamento_ate, organizacao_ate, unidade_ate, categoria_ate, data_ate, situacao_ate, tecnico_ate) VALUES (@status, @assunto, @departamento, @organizacao, @unidade, @categoria, @data, @situacao, @tecnico)", conn)
            '                                               
            With cmd.Parameters
                .AddWithValue("@status", "PENDENTE") 'Data.Text & " " & datahoraAtual.ToShortTimeString)
                .AddWithValue("@assunto", Assunto.Text)
                .AddWithValue("@departamento", Departamento.Text)
                .AddWithValue("@organizacao", organizacao)
                .AddWithValue("@unidade", unidade.Text)
                .AddWithValue("@categoria", Categoria.Text)
                .AddWithValue("@data", datahoraAtual.ToShortDateString & " " & datahoraAtual.ToShortTimeString)
                .AddWithValue("@situacao", "0")
                .AddWithValue("@tecnico", Tecnico.Text)
            End With

            cmd.ExecuteNonQuery()
            protocoloAtual = cmd.LastInsertedId.ToString
            cmd.Dispose()


            MsgBox("Dados gravados!")

        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub AddNovaMensagem()

        conn.Close()

        newConn()

        Try
            cmd = New MySqlCommand("INSERT INTO mensagens(protocolo_msg, data_msg, usuario_msg, grupo_msg, mensagem_msg) VALUES (@protocolo, @data, @usuario, @grupo, @mensagem)", conn)
            '                                               
            With cmd.Parameters
                .AddWithValue("@protocolo", protocoloAtual) 'Data.Text & " " & datahoraAtual.ToShortTimeString)
                .AddWithValue("@data", datahoraAtual.ToShortDateString & " " & datahoraAtual.ToShortTimeString)
                .AddWithValue("@usuario", strUsuario)
                .AddWithValue("@grupo", strGrupoUsuario)
                .AddWithValue("@mensagem", Mensagem.Text)
            End With

            cmd.ExecuteNonQuery()
            cmd.Dispose()

            'MsgBox("Dados gravados!")

        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub AddCheckList()
        Try
            ' 
            newConn()
            cmd = New MySqlCommand("INSERT INTO checklist(status_che, protocolo_che, checklist_che) VALUES (@status, @protocolo, @checklist)", conn)


            With cmd.Parameters
                .AddWithValue("@status", False)
                .AddWithValue("@protocolo", protocoloAtual)
                .AddWithValue("@checklist", "")
            End With

            cmd.ExecuteNonQuery()
            cmd.Dispose()


        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
        conn.Close()


    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub btnAgendar_Click(sender As Object, e As EventArgs) Handles btnAgendar.Click
        RetornaOrganizacao()
        AddNovoAtendimento()
        AddCheckList()

        If Mensagem.TextLength > 0 Then
            AddNovaMensagem()
        End If

        frmAtendimentos.Close()
        FAtendimentos = New frmAtendimentos
        FAtendimentos.TopLevel = False
        FAtendimentos.Parent = tpAtendimentos
        FAtendimentos.Show()
    End Sub

    Private Sub btnIncluirProd_Click(sender As Object, e As EventArgs) Handles btnAddProduto.Click
        newConn()
        Dim leitor As MySqlDataReader '|
        cmd = New MySqlCommand("SELECT *FROM produtos WHERE nserie_prod = '" & nSerie.Text & "'", conn)
        leitor = cmd.ExecuteReader()

        If leitor.HasRows Then
            leitor.Read()

            dgvProdutos.Rows.Add(leitor("produto_prod").ToString, leitor("nserie_prod").ToString, leitor("qnt_prod").ToString)
        Else
            MsgBox("Produto não encontrado!")

        End If

        conn.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnRemoveProduto.Click

    End Sub

    Private Sub frmChamados_NovoRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        unidade.Text = strUsuario

        If categoriaUsuario = "ADMINISTRATIVO" Then
            Label3.Text = "Adicionar novo atendimento"
            lblUnidade.Visible = True
            unidade.Visible = True
            unidade.Enabled = True
            lblDepartamento.Visible = True
            btnAddUnidade.Visible = True
            Departamento.Visible = True
            lblCategoria.Visible = True
            Categoria.Visible = True
            lblAssunto.Visible = True
            pAssunto.Visible = True
            lblMensagem.Visible = True
            pMensagem.Visible = True
            lblTecnico.Visible = True
            Tecnico.Visible = True
            cbReposicao.Visible = True
            pProduto.Visible = True
            lblnSerie.Visible = True
            pNSerie.Visible = True
            btnAddProduto.Visible = True
            btnRemoveProduto.Visible = True
        ElseIf categoriaUsuario = "ATENDIMENTO" Then
            Label3.Text = "Adicionar novo chamado"
            lblUnidade.Visible = True
            unidade.Visible = True
            unidade.Enabled = False
            lblDepartamento.Visible = True
            btnAddUnidade.Visible = False
            Departamento.Visible = True
            lblCategoria.Visible = False
            Categoria.Visible = False
            lblAssunto.Visible = True
            pAssunto.Visible = True
            lblMensagem.Visible = True
            pMensagem.Visible = True
            lblTecnico.Visible = False
            Tecnico.Visible = False
            cbReposicao.Visible = False
            pProduto.Visible = False
            lblnSerie.Visible = False
            pNSerie.Visible = False
            btnAddProduto.Visible = False
            btnRemoveProduto.Visible = False

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dgvCheckList.Rows.Add(False, TextBox1.Text)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim linha As String = dgvCheckList.Rows(e.RowIndex).Cells(0).Value

        If dgvCheckList.Rows(e.RowIndex).Cells(0).Selected = True Then
            If dgvCheckList.Rows(e.RowIndex).Cells(0).Value = False Then
                dgvCheckList.Rows(e.RowIndex).Cells(0).Value = True
            Else
                dgvCheckList.Rows(e.RowIndex).Cells(0).Value = False
            End If
        End If
    End Sub

    Private Sub dgvCheckList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If Panel5.Size = New Size(417, 41) Then
            Panel5.Size = New Size(417, 202)
        Else
            Panel5.Size = New Size(417, 41)
        End If


    End Sub
End Class