<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAtendimento_Agendar
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.Categoria = New System.Windows.Forms.ComboBox()
        Me.lblAssunto = New System.Windows.Forms.Label()
        Me.pAssunto = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel12 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Prazo = New System.Windows.Forms.TextBox()
        Me.lblTecnico = New System.Windows.Forms.Label()
        Me.Tecnico = New System.Windows.Forms.ComboBox()
        Me.cbReposicao = New System.Windows.Forms.CheckBox()
        Me.pProduto = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.dgvProdutos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblnSerie = New System.Windows.Forms.Label()
        Me.pNSerie = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel10 = New System.Windows.Forms.FlowLayoutPanel()
        Me.nSerie = New System.Windows.Forms.TextBox()
        Me.btnAddProduto = New System.Windows.Forms.Button()
        Me.btnRemoveProduto = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnAgendar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.pAssunto.SuspendLayout()
        Me.FlowLayoutPanel12.SuspendLayout()
        Me.pProduto.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pNSerie.SuspendLayout()
        Me.FlowLayoutPanel10.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.BackColor = System.Drawing.Color.Transparent
        Me.lblCategoria.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.lblCategoria.ForeColor = System.Drawing.Color.DimGray
        Me.lblCategoria.Location = New System.Drawing.Point(40, 78)
        Me.lblCategoria.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(56, 14)
        Me.lblCategoria.TabIndex = 18
        Me.lblCategoria.Text = "Categoria:"
        Me.lblCategoria.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Categoria
        '
        Me.Categoria.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Categoria.FormattingEnabled = True
        Me.Categoria.Items.AddRange(New Object() {"VISITA TÉCNICA", "ATEND. REMOTO"})
        Me.Categoria.Location = New System.Drawing.Point(42, 92)
        Me.Categoria.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.Categoria.Name = "Categoria"
        Me.Categoria.Size = New System.Drawing.Size(218, 21)
        Me.Categoria.TabIndex = 33
        '
        'lblAssunto
        '
        Me.lblAssunto.AutoSize = True
        Me.lblAssunto.BackColor = System.Drawing.Color.Transparent
        Me.lblAssunto.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.lblAssunto.ForeColor = System.Drawing.Color.DimGray
        Me.lblAssunto.Location = New System.Drawing.Point(39, 317)
        Me.lblAssunto.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAssunto.Name = "lblAssunto"
        Me.lblAssunto.Size = New System.Drawing.Size(38, 14)
        Me.lblAssunto.TabIndex = 18
        Me.lblAssunto.Text = "Prazo:"
        Me.lblAssunto.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pAssunto
        '
        Me.pAssunto.AutoSize = True
        Me.pAssunto.BackColor = System.Drawing.Color.DarkGray
        Me.pAssunto.Controls.Add(Me.FlowLayoutPanel12)
        Me.pAssunto.Location = New System.Drawing.Point(42, 331)
        Me.pAssunto.Margin = New System.Windows.Forms.Padding(0, 0, 5, 20)
        Me.pAssunto.Name = "pAssunto"
        Me.pAssunto.Size = New System.Drawing.Size(171, 23)
        Me.pAssunto.TabIndex = 23
        '
        'FlowLayoutPanel12
        '
        Me.FlowLayoutPanel12.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel12.Controls.Add(Me.Prazo)
        Me.FlowLayoutPanel12.Location = New System.Drawing.Point(1, 1)
        Me.FlowLayoutPanel12.Margin = New System.Windows.Forms.Padding(1)
        Me.FlowLayoutPanel12.Name = "FlowLayoutPanel12"
        Me.FlowLayoutPanel12.Size = New System.Drawing.Size(169, 21)
        Me.FlowLayoutPanel12.TabIndex = 10
        '
        'Prazo
        '
        Me.Prazo.BackColor = System.Drawing.Color.White
        Me.Prazo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Prazo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Prazo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Prazo.Location = New System.Drawing.Point(3, 3)
        Me.Prazo.Name = "Prazo"
        Me.Prazo.Size = New System.Drawing.Size(141, 13)
        Me.Prazo.TabIndex = 0
        '
        'lblTecnico
        '
        Me.lblTecnico.AutoSize = True
        Me.lblTecnico.BackColor = System.Drawing.Color.Transparent
        Me.lblTecnico.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.lblTecnico.ForeColor = System.Drawing.Color.DimGray
        Me.lblTecnico.Location = New System.Drawing.Point(40, 119)
        Me.lblTecnico.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTecnico.Name = "lblTecnico"
        Me.lblTecnico.Size = New System.Drawing.Size(48, 14)
        Me.lblTecnico.TabIndex = 18
        Me.lblTecnico.Text = "Técnico:"
        Me.lblTecnico.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Tecnico
        '
        Me.Tecnico.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Tecnico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Tecnico.FormattingEnabled = True
        Me.Tecnico.Items.AddRange(New Object() {"Alan Sales", "Junior Oliveira", "Guilherme"})
        Me.Tecnico.Location = New System.Drawing.Point(42, 133)
        Me.Tecnico.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.Tecnico.Name = "Tecnico"
        Me.Tecnico.Size = New System.Drawing.Size(218, 21)
        Me.Tecnico.TabIndex = 33
        '
        'cbReposicao
        '
        Me.cbReposicao.AutoSize = True
        Me.cbReposicao.ForeColor = System.Drawing.Color.DimGray
        Me.cbReposicao.Location = New System.Drawing.Point(42, 162)
        Me.cbReposicao.Margin = New System.Windows.Forms.Padding(107, 0, 0, 5)
        Me.cbReposicao.Name = "cbReposicao"
        Me.cbReposicao.Size = New System.Drawing.Size(125, 17)
        Me.cbReposicao.TabIndex = 31
        Me.cbReposicao.Text = "Reposição de Peças"
        Me.cbReposicao.UseVisualStyleBackColor = True
        '
        'pProduto
        '
        Me.pProduto.AutoSize = True
        Me.pProduto.BackColor = System.Drawing.Color.DarkGray
        Me.pProduto.Controls.Add(Me.FlowLayoutPanel4)
        Me.pProduto.Location = New System.Drawing.Point(42, 180)
        Me.pProduto.Margin = New System.Windows.Forms.Padding(107, 0, 0, 20)
        Me.pProduto.Name = "pProduto"
        Me.pProduto.Size = New System.Drawing.Size(312, 92)
        Me.pProduto.TabIndex = 26
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel4.Controls.Add(Me.dgvProdutos)
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(1, 1)
        Me.FlowLayoutPanel4.Margin = New System.Windows.Forms.Padding(1)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(310, 90)
        Me.FlowLayoutPanel4.TabIndex = 10
        '
        'dgvProdutos
        '
        Me.dgvProdutos.AllowUserToAddRows = False
        Me.dgvProdutos.AllowUserToDeleteRows = False
        Me.dgvProdutos.AllowUserToResizeColumns = False
        Me.dgvProdutos.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Gray
        Me.dgvProdutos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvProdutos.BackgroundColor = System.Drawing.Color.White
        Me.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.dgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Humanst521 Lt BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProdutos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvProdutos.ColumnHeadersHeight = 25
        Me.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProdutos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Humanst521 Lt BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProdutos.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvProdutos.EnableHeadersVisualStyles = False
        Me.dgvProdutos.GridColor = System.Drawing.Color.White
        Me.dgvProdutos.Location = New System.Drawing.Point(3, 3)
        Me.dgvProdutos.Name = "dgvProdutos"
        Me.dgvProdutos.ReadOnly = True
        Me.dgvProdutos.RowHeadersVisible = False
        Me.dgvProdutos.RowHeadersWidth = 60
        Me.dgvProdutos.RowTemplate.Height = 20
        Me.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProdutos.Size = New System.Drawing.Size(302, 84)
        Me.dgvProdutos.TabIndex = 29
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.HeaderText = "Produto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nº Série"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Qnt"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'lblnSerie
        '
        Me.lblnSerie.AutoSize = True
        Me.lblnSerie.BackColor = System.Drawing.Color.Transparent
        Me.lblnSerie.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.lblnSerie.ForeColor = System.Drawing.Color.DimGray
        Me.lblnSerie.Location = New System.Drawing.Point(39, 275)
        Me.lblnSerie.Margin = New System.Windows.Forms.Padding(0)
        Me.lblnSerie.Name = "lblnSerie"
        Me.lblnSerie.Size = New System.Drawing.Size(50, 14)
        Me.lblnSerie.TabIndex = 18
        Me.lblnSerie.Text = "Nº Série:"
        Me.lblnSerie.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pNSerie
        '
        Me.pNSerie.AutoSize = True
        Me.pNSerie.BackColor = System.Drawing.Color.DarkGray
        Me.pNSerie.Controls.Add(Me.FlowLayoutPanel10)
        Me.pNSerie.Location = New System.Drawing.Point(42, 289)
        Me.pNSerie.Margin = New System.Windows.Forms.Padding(0, 0, 5, 20)
        Me.pNSerie.Name = "pNSerie"
        Me.pNSerie.Size = New System.Drawing.Size(174, 23)
        Me.pNSerie.TabIndex = 23
        '
        'FlowLayoutPanel10
        '
        Me.FlowLayoutPanel10.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel10.Controls.Add(Me.nSerie)
        Me.FlowLayoutPanel10.Location = New System.Drawing.Point(1, 1)
        Me.FlowLayoutPanel10.Margin = New System.Windows.Forms.Padding(1)
        Me.FlowLayoutPanel10.Name = "FlowLayoutPanel10"
        Me.FlowLayoutPanel10.Size = New System.Drawing.Size(172, 21)
        Me.FlowLayoutPanel10.TabIndex = 10
        '
        'nSerie
        '
        Me.nSerie.BackColor = System.Drawing.Color.White
        Me.nSerie.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.nSerie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.nSerie.Location = New System.Drawing.Point(3, 3)
        Me.nSerie.Name = "nSerie"
        Me.nSerie.Size = New System.Drawing.Size(169, 13)
        Me.nSerie.TabIndex = 0
        '
        'btnAddProduto
        '
        Me.btnAddProduto.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.btnAddProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProduto.ForeColor = System.Drawing.Color.White
        Me.btnAddProduto.Location = New System.Drawing.Point(221, 289)
        Me.btnAddProduto.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.btnAddProduto.Name = "btnAddProduto"
        Me.btnAddProduto.Size = New System.Drawing.Size(68, 25)
        Me.btnAddProduto.TabIndex = 32
        Me.btnAddProduto.Text = "Adicionar"
        Me.btnAddProduto.UseVisualStyleBackColor = False
        '
        'btnRemoveProduto
        '
        Me.btnRemoveProduto.BackColor = System.Drawing.Color.Tomato
        Me.btnRemoveProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveProduto.ForeColor = System.Drawing.Color.White
        Me.btnRemoveProduto.Location = New System.Drawing.Point(289, 289)
        Me.btnRemoveProduto.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.btnRemoveProduto.Name = "btnRemoveProduto"
        Me.btnRemoveProduto.Size = New System.Drawing.Size(65, 25)
        Me.btnRemoveProduto.TabIndex = 32
        Me.btnRemoveProduto.Text = "Remover"
        Me.btnRemoveProduto.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Font = New System.Drawing.Font("Humanst521 Lt BT", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(34, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(335, 39)
        Me.Panel2.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Humanst521 Lt BT", 15.0!)
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(7, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Agendar atendimento"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Gray
        Me.Button1.Location = New System.Drawing.Point(218, 331)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 23)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Hoje"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Button4)
        Me.Panel4.Controls.Add(Me.btnAgendar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 390)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(398, 62)
        Me.Panel4.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gainsboro
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(398, 1)
        Me.Label1.TabIndex = 8
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Gainsboro
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.DimGray
        Me.Button4.Location = New System.Drawing.Point(290, 13)
        Me.Button4.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 35)
        Me.Button4.TabIndex = 32
        Me.Button4.Text = "Fechar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btnAgendar
        '
        Me.btnAgendar.BackColor = System.Drawing.Color.YellowGreen
        Me.btnAgendar.FlatAppearance.BorderSize = 0
        Me.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgendar.ForeColor = System.Drawing.Color.White
        Me.btnAgendar.Location = New System.Drawing.Point(186, 13)
        Me.btnAgendar.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.btnAgendar.Name = "btnAgendar"
        Me.btnAgendar.Size = New System.Drawing.Size(96, 35)
        Me.btnAgendar.TabIndex = 32
        Me.btnAgendar.Text = "Confirmar"
        Me.btnAgendar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Gray
        Me.Button2.Location = New System.Drawing.Point(288, 331)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 23)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Amanhã"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmAtendimento_Agendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(398, 452)
        Me.Controls.Add(Me.lblCategoria)
        Me.Controls.Add(Me.Categoria)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.lblTecnico)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Tecnico)
        Me.Controls.Add(Me.cbReposicao)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.pProduto)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblnSerie)
        Me.Controls.Add(Me.pAssunto)
        Me.Controls.Add(Me.pNSerie)
        Me.Controls.Add(Me.lblAssunto)
        Me.Controls.Add(Me.btnAddProduto)
        Me.Controls.Add(Me.btnRemoveProduto)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAtendimento_Agendar"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pAssunto.ResumeLayout(False)
        Me.FlowLayoutPanel12.ResumeLayout(False)
        Me.FlowLayoutPanel12.PerformLayout()
        Me.pProduto.ResumeLayout(False)
        Me.FlowLayoutPanel4.ResumeLayout(False)
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pNSerie.ResumeLayout(False)
        Me.FlowLayoutPanel10.ResumeLayout(False)
        Me.FlowLayoutPanel10.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCategoria As Label
    Friend WithEvents Categoria As ComboBox
    Friend WithEvents lblAssunto As Label
    Friend WithEvents pAssunto As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel12 As FlowLayoutPanel
    Friend WithEvents Prazo As TextBox
    Friend WithEvents lblTecnico As Label
    Friend WithEvents Tecnico As ComboBox
    Friend WithEvents cbReposicao As CheckBox
    Friend WithEvents pProduto As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents dgvProdutos As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents lblnSerie As Label
    Friend WithEvents pNSerie As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel10 As FlowLayoutPanel
    Friend WithEvents nSerie As TextBox
    Friend WithEvents btnAddProduto As Button
    Friend WithEvents btnRemoveProduto As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents btnAgendar As Button
End Class
