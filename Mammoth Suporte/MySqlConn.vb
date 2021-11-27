Imports MySql.Data.MySqlClient

Module MySqlConn
    Public datahoraAtual As DateTime = Now

    Public strUsuario As String = frmPrincipal.lblUsuario.Text
    Public strGrupoUsuario As String = frmPrincipal.lblGrupo.Text

    Public adap As New MySqlDataAdapter
    Public dados As New DataSet
    Public conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public dt As New DataTable
    Public strServer As String = "localhost"
    Public strPorta As String = "3306"
    Public strUser As String = "root"
    Public strSenha As String = "ti873562"
    Public _mySQL As String = "SERVER=" & strServer & "; PORT=" & strPorta & "; user id=" & strUser & "; password=" & strSenha & "; database=DBMammoth"
    '=======================================================================================================

    Sub newConn()
        Try
            conn = New MySqlConnection(_mySQL)
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public categoriaUsuario As String
    Sub Permissoes()
        newConn()
        Dim leitor As MySqlDataReader '|
        cmd = New MySqlCommand("SELECT *FROM usuarios WHERE nome_usu = '" & strUsuario & "'", conn)
        leitor = cmd.ExecuteReader()

        If leitor.HasRows Then
            leitor.Read()
            categoriaUsuario = leitor("categoria_usu").ToString()
        End If

        conn.Close()
    End Sub
End Module
