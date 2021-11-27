Imports System.Data
Module EventosMenus

    '===============DESTACA PAGINA SELCIONADA=================================================================
    'EVENTO DISPARADO EM CHAMADA HANDLE DE CADA BOTAO
    Public botaoselecionado, botaocloseselecionado As String
    Sub btnSelect()
        For Each P As Panel In frmPrincipal.FlowLayoutPanel2.Controls
            For Each ctrl As Button In P.Controls
                'MsgBox("BOTÃO SELECIONADO: " & botaoselecionado & "/////" & ctrl.Name & " - " & ctrl.GetType.ToString)
                If ctrl.Name.Contains(botaoselecionado) Or ctrl.Name.Contains(botaocloseselecionado) Then
                    ctrl.BackColor = Color.White
                    ctrl.FlatAppearance.MouseOverBackColor = Color.White
                Else
                    ctrl.BackColor = Color.Gainsboro
                    ctrl.FlatAppearance.MouseOverBackColor = Color.Gainsboro

                End If
            Next
        Next
        botaocloseselecionado = ""
        botaoselecionado = ""
    End Sub
    '============================================================================================================

    '=========EVENTO CLICK DOS BOTÕES DE NAVEGAÇÃO DAS ABAS CRIADAS EM TEMPO DE EXECUÇÃO
    Public tpAtendimentos, tpUsuarios As TabPage

    Public FAtendimentos As frmAtendimentos
    Public FUsuarios As frmUsuários

    '=================================EVENTO ABRIR/FECHAR Atendimentos===========================
    Sub btnAbaAtendimentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPrincipal.tcHome.SelectedTab = tpAtendimentos

        botaoselecionado = "btnAtendimentos"
        botaocloseselecionado = "btnCloseAtendimentos"
        btnSelect()
    End Sub
    Sub btnAbaAtendimentosClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With frmPrincipal
            FAtendimentos.Close()
            .tcHome.SelectedTab = tpAtendimentos
            .tcHome.SelectedIndex = tpAtendimentos.TabIndex - 1
            .FlowLayoutPanel2.Controls.RemoveByKey("pTabAtendimentos")
            .tcHome.TabPages.RemoveByKey("tAtendimentos")
        End With
    End Sub
    '========================================================================================

    '=================================EVENTO ABRIR/FECHAR Atendimentos===========================
    Sub btnAbaUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPrincipal.tcHome.SelectedTab = tpUsuarios

        botaoselecionado = "btnUsuarios"
        botaocloseselecionado = "btnCloseUsuarios"
        btnSelect()
    End Sub
    Sub btnAbaUsuariosClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With frmPrincipal
            FUsuarios.Close()
            .tcHome.SelectedTab = tpUsuarios
            .tcHome.SelectedIndex = tpUsuarios.TabIndex - 1
            .FlowLayoutPanel2.Controls.RemoveByKey("pTabUsuarios")
            .tcHome.TabPages.RemoveByKey("tUsuarios")
        End With
    End Sub
    '========================================================================================

End Module

