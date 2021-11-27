Imports MySql.Data.MySqlClient

Public Class frmPrincipal

    Private Sub MenuChamados_Click(sender As Object, e As EventArgs) Handles MenuChamados.Click, ContadorChamados.Click, TituloChamados.Click, DescChamados.Click

        Dim pTabMenu As New Panel           '|
        Dim btn, btnClose As New Button     '|  Define variaveis para criar subPages e menus do tabcontrol


        If Application.OpenForms.OfType(Of frmAtendimentos)().Count() > 0 Then '|*
            Exit Sub
        Else

            tpAtendimentos = New TabPage                     '|*

            Dim rButton As String = "   Atendimentos"        '|  DEFINE ROTULO DO BOTÃO
            Dim nButton As String = "btnAtendimentos"        '|  DEFINE NAME DO BOTÃO PARA ACIONAR EVENTO CLICK
            Dim nPanel As String = "pTabAtendimentos"        '|  DEFINE NOME DO PAINEL PARA VALIDAR COMANDO DE FECHAMENTO DA ABA
            Dim rClose As String = "btnCloseAtendimentos"    '|  DEFINE ROTULO DE BOTÃO CLOSE PARA ACIONAR EVENTO CLICK
            Dim rPage As String = "tAtendimentos"            '|  DEFINE ROTULO DE PAGINA PARA ACIONAR EVENTO CLOSE
            Dim nPage As String = "Atendimentos"             '|  DEFINE NOME DA PAGINA

            Dim lButton As Integer = 93                 '|  LARGURA BOTÃO
            Dim aButton As Integer = 30                 '|  ALTURA BOTÃO
            Dim lPanel As Integer = 110                 '|  LARGURA PAINEL
            Dim aPanel As Integer = 30                  '|  ALTURA PAINEL
            Dim mlButton As Integer = 83                '|  MARGEM BOTÃO CLOSE LATERAL
            Dim maButton As Integer = 8                 '|  MARGEM BOTÃO CLOSE ALTURA


            With pTabMenu                               '|
                .AutoSize = True                        '|
                .MinimumSize = New Size(lPanel, aPanel) '|  DEFINIÇÕES DO PANEL PARA 
                .BackColor = Color.White
                .Margin = New Padding(0, 0, 0, 0)       '|  RECEBER OS BOTOES DE NAVEGAÇÃO
                .Name = nPanel                          '|  DA TABCONTROL.
            End With                                    '|

            With btn                                                    '|
                .Size = New Size(lButton, aButton)                      '|
                .Margin = New Padding(0, 2, 0, 0)                       '|
                .BackColor = Color.White                                '|  DEFININDO AS PROPRIEDADES
                .ForeColor = Color.DimGray                              '|  DOS BOTÕES DE NAVEGAÇÃO
                .FlatAppearance.BorderColor = Color.Gainsboro           '|  QUE SERÃO INSERIDOS DENTRO
                .FlatAppearance.BorderSize = 0                          '|  DO PAINEL 'pTabMenu
                .FlatAppearance.MouseDownBackColor = Color.White        '|
                .FlatAppearance.MouseOverBackColor = Color.White        '|
                .FlatStyle = FlatStyle.Flat                             '|
                .Location = New Point(0, 1)                             '|
                .TextAlign = ContentAlignment.MiddleLeft                '|
                .Text = rButton                                         '|
                .Name = nButton                                         '|
            End With                                                    '|

            With btnClose
                .Size = New Size(15, 15)                                '|
                .Margin = New Padding(0, 2, 2, 0)                       '|
                .BackColor = Color.White                                '|
                .ForeColor = Color.DimGray                              '|
                .FlatAppearance.BorderColor = Color.DimGray             '|
                .FlatAppearance.BorderSize = 0                          '|  DEFININDO AS PROPRIEDADES
                .BackColor = Color.White                                '|
                .ImageList = ImageList1                                 '|
                .ImageIndex = 0                                         '|
                .FlatAppearance.MouseDownBackColor = Color.White        '|  DOS BOTÕES DE FECHAMENTO
                .FlatAppearance.MouseOverBackColor = Color.White        '|  DE ABAS DO TABCONTROL
                .FlatStyle = FlatStyle.Flat                             '|
                .Location = New Point(mlButton, maButton)               '|
                .TextAlign = ContentAlignment.MiddleCenter              '|
                '.Text = "X"                                            '|
                .Name = rClose                                          '|
            End With                                                    '|

            tpAtendimentos.Name = rPage              '|  DEFINE ROTULO DE TABPAGE
            tpAtendimentos.Text = nPage              '|  DEFINE NOME DA PAGINA
            tcHome.TabPages.Add(tpAtendimentos)      '|  INSERE PAGINA À TABCONTROL
            tcHome.SelectedTab = tpAtendimentos      '|  SELECIONA A PAGINA QUE FOI INSERIDA

            pTabMenu.Controls.Add(btnClose)             '|  ADICIONA O BOTÃO CLOSE
            pTabMenu.Controls.Add(btn)                  '|  ADICIONA O BOTÃO DE NAVEGAÇÃO DE PAGINAS DENTRO DO PAINEL DE MENU
            FlowLayoutPanel2.Controls.Add(pTabMenu)     '|  ADICIONA O PAINEL DE MENUS DENTRO DO FLOWLAYOUTPANEL

            AddHandler btn.Click, AddressOf btnAbaAtendimentos_Click            '|  Cria o botão de navegação da tabControl
            AddHandler btnClose.Click, AddressOf btnAbaAtendimentosClose_Click  '|  Cria o botão para fechar as abas

            botaoselecionado = nButton
            botaocloseselecionado = rClose
            btnSelect()

            FAtendimentos = New frmAtendimentos
            FAtendimentos.TopLevel = False
            FAtendimentos.Parent = tpAtendimentos
            FAtendimentos.Show()
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click, Panel19.Click, Panel11.Click, Label30.Click, Label29.Click, Label28.Click
        Dim pTabMenu As New Panel           '|
        Dim btn, btnClose As New Button     '|  Define variaveis para criar subPages e menus do tabcontrol


        If Application.OpenForms.OfType(Of frmUsuários)().Count() > 0 Then '|*
            Exit Sub
        Else

            tpUsuarios = New TabPage                     '|*

            Dim rButton As String = "   Usuários"        '|  DEFINE ROTULO DO BOTÃO
            Dim nButton As String = "btnUsuarios"        '|  DEFINE NAME DO BOTÃO PARA ACIONAR EVENTO CLICK
            Dim nPanel As String = "pTabUsuarios"        '|  DEFINE NOME DO PAINEL PARA VALIDAR COMANDO DE FECHAMENTO DA ABA
            Dim rClose As String = "btnCloseUsuarios"    '|  DEFINE ROTULO DE BOTÃO CLOSE PARA ACIONAR EVENTO CLICK
            Dim rPage As String = "tUsuarios"            '|  DEFINE ROTULO DE PAGINA PARA ACIONAR EVENTO CLOSE
            Dim nPage As String = "Usuarios"             '|  DEFINE NOME DA PAGINA

            Dim lButton As Integer = 93                 '|  LARGURA BOTÃO
            Dim aButton As Integer = 30                 '|  ALTURA BOTÃO
            Dim lPanel As Integer = 110                 '|  LARGURA PAINEL
            Dim aPanel As Integer = 30                  '|  ALTURA PAINEL
            Dim mlButton As Integer = 83                '|  MARGEM BOTÃO CLOSE LATERAL
            Dim maButton As Integer = 8                 '|  MARGEM BOTÃO CLOSE ALTURA


            With pTabMenu                               '|
                .AutoSize = True                        '|
                .MinimumSize = New Size(lPanel, aPanel) '|  DEFINIÇÕES DO PANEL PARA 
                .BackColor = Color.White
                .Margin = New Padding(0, 0, 0, 0)       '|  RECEBER OS BOTOES DE NAVEGAÇÃO
                .Name = nPanel                          '|  DA TABCONTROL.
            End With                                    '|

            With btn                                                    '|
                .Size = New Size(lButton, aButton)                      '|
                .Margin = New Padding(0, 2, 0, 0)                       '|
                .BackColor = Color.White                                '|  DEFININDO AS PROPRIEDADES
                .ForeColor = Color.DimGray                              '|  DOS BOTÕES DE NAVEGAÇÃO
                .FlatAppearance.BorderColor = Color.Gainsboro           '|  QUE SERÃO INSERIDOS DENTRO
                .FlatAppearance.BorderSize = 0                          '|  DO PAINEL 'pTabMenu
                .FlatAppearance.MouseDownBackColor = Color.White        '|
                .FlatAppearance.MouseOverBackColor = Color.White        '|
                .FlatStyle = FlatStyle.Flat                             '|
                .Location = New Point(0, 1)                             '|
                .TextAlign = ContentAlignment.MiddleLeft                '|
                .Text = rButton                                         '|
                .Name = nButton                                         '|
            End With                                                    '|

            With btnClose
                .Size = New Size(15, 15)                                '|
                .Margin = New Padding(0, 2, 2, 0)                       '|
                .BackColor = Color.White                                '|
                .ForeColor = Color.DimGray                              '|
                .FlatAppearance.BorderColor = Color.DimGray             '|
                .FlatAppearance.BorderSize = 0                          '|  DEFININDO AS PROPRIEDADES
                .BackColor = Color.White                                '|
                .ImageList = ImageList1                                 '|
                .ImageIndex = 0                                         '|
                .FlatAppearance.MouseDownBackColor = Color.White        '|  DOS BOTÕES DE FECHAMENTO
                .FlatAppearance.MouseOverBackColor = Color.White        '|  DE ABAS DO TABCONTROL
                .FlatStyle = FlatStyle.Flat                             '|
                .Location = New Point(mlButton, maButton)               '|
                .TextAlign = ContentAlignment.MiddleCenter              '|
                '.Text = "X"                                            '|
                .Name = rClose                                          '|
            End With                                                    '|

            tpUsuarios.Name = rPage              '|  DEFINE ROTULO DE TABPAGE
            tpUsuarios.Text = nPage              '|  DEFINE NOME DA PAGINA
            tcHome.TabPages.Add(tpUsuarios)      '|  INSERE PAGINA À TABCONTROL
            tcHome.SelectedTab = tpUsuarios     '|  SELECIONA A PAGINA QUE FOI INSERIDA

            pTabMenu.Controls.Add(btnClose)             '|  ADICIONA O BOTÃO CLOSE
            pTabMenu.Controls.Add(btn)                  '|  ADICIONA O BOTÃO DE NAVEGAÇÃO DE PAGINAS DENTRO DO PAINEL DE MENU
            FlowLayoutPanel2.Controls.Add(pTabMenu)     '|  ADICIONA O PAINEL DE MENUS DENTRO DO FLOWLAYOUTPANEL

            AddHandler btn.Click, AddressOf btnAbaUsuarios_Click            '|  Cria o botão de navegação da tabControl
            AddHandler btnClose.Click, AddressOf btnAbaUsuariosClose_Click  '|  Cria o botão para fechar as abas

            botaoselecionado = nButton
            botaocloseselecionado = rClose
            btnSelect()

            FUsuarios = New frmUsuários
            FUsuarios.TopLevel = False
            FUsuarios.Parent = tpUsuarios
            FUsuarios.Show()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            lblUsuario.Text = strUsuario

            CheckForIllegalCrossThreadCalls = False 'ELIMINA MENSAGEM DE ERRO DAS THREADS
            Atualizacoes()  'Cham evento a primeira vez para iniciar sistema
            AtualizaTimer.Enabled = True 'Ativa time para verificar atualizações em loop

            newConn()
            Dim leitor As MySqlDataReader '|
            cmd = New MySqlCommand("SELECT *FROM usuarios WHERE nome_usu = '" & strUsuario & "'", conn)
            leitor = cmd.ExecuteReader()

            If leitor.HasRows Then
                leitor.Read()
                Dim i As Integer = leitor("foto_usu").ToString
                lblGrupo.Text = leitor("grupo_usu").ToString
                strGrupoUsuario = leitor("grupo_usu").ToString
                strUsuario = leitor("nome_usu").ToString
                Panel23.BackgroundImage = Galeria.Images(i)
                Panel23.BackgroundImageLayout = ImageLayout.Zoom
            End If
        Catch ex As Exception

        End Try




    End Sub

    Private Sub SegPlano_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles SegPlano.DoWork
        Atualizacoes() 'Chama evento para verificar atualizações
    End Sub

    Private Sub AtualizaTimer_Tick(sender As Object, e As EventArgs) Handles AtualizaTimer.Tick
        SegPlano.RunWorkerAsync()   'Busca atualizações em segundo plano
    End Sub

    '-============================PROCEDIMENTOS PARA ATUALIZAR STATUS========================================================
    Sub Atualizacoes()
        Try
            newConn()

            cmd = New MySqlCommand("SELECT COUNT(protocolo_ate) as quantidade FROM atendimentos WHERE status_ate = 'PENDENTE' OR status_ate = 'EM ANDAMENTO'", conn)
            Dim i As Integer = cmd.ExecuteScalar()
            cmd = Nothing
            conn.Close()
            ContadorChamados.Text = i
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
    '==========================================================================================================================
End Class
