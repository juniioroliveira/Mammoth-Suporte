Imports MySql.Data.MySqlClient

Public Class frmUsuários


    '========STRING DE CONEXÃO PARA CARREGAR DADOS EM GRID =========================
    Sub PCarregaDadosMYSQL_Usuários()                                            '|
        Try                                                                     '|
            newConn()                                                           '| ABRE CONEXÃO
            Dim _MySQL As String = "SELECT *FROM usuarios" '| SELECIONA A TABELA
            cmd = New MySqlCommand(_MySQL, conn)                                '| 
            adap = New MySqlDataAdapter(cmd)                                    '|
            dt = New DataTable                                                  '|
            adap.Fill(dt)                                                       '|
            DgvUsuarios.DataSource = dt                                         '| PREENCHE DATAGRIDVIEW
        Catch ex As Exception                                                   '|

            Exit Sub
        Finally                                                                 '|
            conn.Close()                                                        '|

        End Try                                                                 '|
    End Sub                                                                     '|

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PCarregaDadosMYSQL_Usuários()
    End Sub
    '==================================================================================
End Class