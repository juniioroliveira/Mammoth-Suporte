<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAtendimentos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAtendimentos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Titulo = New System.Windows.Forms.Label()
        Me.btnNovoChamado = New System.Windows.Forms.Button()
        Me.DgvAtendimentos = New System.Windows.Forms.DataGridView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.contCancelado = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.contAndamento = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.contPendente = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.SegPlano = New System.ComponentModel.BackgroundWorker()
        Me.AtualizaTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnAgendar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GaleriaSituacao = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FiltroAguardando = New System.Windows.Forms.Button()
        Me.FiltroAgendado = New System.Windows.Forms.Button()
        Me.FiltroFinalizado = New System.Windows.Forms.Button()
        Me.FiltroCancelado = New System.Windows.Forms.Button()
        Me.FiltroTodos = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvAtendimentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Titulo)
        Me.Panel1.Font = New System.Drawing.Font("Humanst521 Lt BT", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(34, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1177, 39)
        Me.Panel1.TabIndex = 0
        '
        'Titulo
        '
        Me.Titulo.AutoSize = True
        Me.Titulo.BackColor = System.Drawing.Color.Transparent
        Me.Titulo.Font = New System.Drawing.Font("Humanst521 Lt BT", 15.0!)
        Me.Titulo.ForeColor = System.Drawing.Color.DimGray
        Me.Titulo.Location = New System.Drawing.Point(7, 7)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(118, 24)
        Me.Titulo.TabIndex = 8
        Me.Titulo.Text = "Atendimentos"
        '
        'btnNovoChamado
        '
        Me.btnNovoChamado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovoChamado.BackColor = System.Drawing.Color.LimeGreen
        Me.btnNovoChamado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNovoChamado.FlatAppearance.BorderSize = 0
        Me.btnNovoChamado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovoChamado.Font = New System.Drawing.Font("Humanst521 Lt BT", 12.0!)
        Me.btnNovoChamado.ForeColor = System.Drawing.Color.White
        Me.btnNovoChamado.Image = CType(resources.GetObject("btnNovoChamado.Image"), System.Drawing.Image)
        Me.btnNovoChamado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovoChamado.Location = New System.Drawing.Point(1026, 70)
        Me.btnNovoChamado.Name = "btnNovoChamado"
        Me.btnNovoChamado.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnNovoChamado.Size = New System.Drawing.Size(185, 39)
        Me.btnNovoChamado.TabIndex = 10
        Me.btnNovoChamado.Text = "  Novo atendimento"
        Me.btnNovoChamado.UseVisualStyleBackColor = False
        '
        'DgvAtendimentos
        '
        Me.DgvAtendimentos.AllowUserToAddRows = False
        Me.DgvAtendimentos.AllowUserToDeleteRows = False
        Me.DgvAtendimentos.AllowUserToResizeColumns = False
        Me.DgvAtendimentos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gray
        Me.DgvAtendimentos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvAtendimentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvAtendimentos.BackgroundColor = System.Drawing.Color.White
        Me.DgvAtendimentos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvAtendimentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.DgvAtendimentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Humanst521 Lt BT", 9.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvAtendimentos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvAtendimentos.ColumnHeadersHeight = 25
        Me.DgvAtendimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Humanst521 Lt BT", 9.75!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvAtendimentos.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvAtendimentos.EnableHeadersVisualStyles = False
        Me.DgvAtendimentos.GridColor = System.Drawing.Color.White
        Me.DgvAtendimentos.Location = New System.Drawing.Point(34, 115)
        Me.DgvAtendimentos.Name = "DgvAtendimentos"
        Me.DgvAtendimentos.ReadOnly = True
        Me.DgvAtendimentos.RowHeadersVisible = False
        Me.DgvAtendimentos.RowHeadersWidth = 60
        Me.DgvAtendimentos.RowTemplate.Height = 40
        Me.DgvAtendimentos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgvAtendimentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvAtendimentos.Size = New System.Drawing.Size(1177, 482)
        Me.DgvAtendimentos.TabIndex = 1
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "icons8-ponto-final-50.png")
        Me.ImageList1.Images.SetKeyName(1, "icons8-ponto-final-24 (1).png")
        Me.ImageList1.Images.SetKeyName(2, "icons8-ponto-final-24 (1).png")
        Me.ImageList1.Images.SetKeyName(3, "icons8-ponto-final-24.png")
        Me.ImageList1.Images.SetKeyName(4, "icons8-ponto-final-24 (2).png")
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(19, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 14)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Cancelado"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(74, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'contCancelado
        '
        Me.contCancelado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.contCancelado.BackColor = System.Drawing.Color.Transparent
        Me.contCancelado.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.contCancelado.ForeColor = System.Drawing.Color.Red
        Me.contCancelado.Location = New System.Drawing.Point(-2, 1)
        Me.contCancelado.Name = "contCancelado"
        Me.contCancelado.Size = New System.Drawing.Size(24, 18)
        Me.contCancelado.TabIndex = 8
        Me.contCancelado.Text = "0"
        Me.contCancelado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.contCancelado)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(244, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(96, 22)
        Me.Panel3.TabIndex = 12
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel8.Controls.Add(Me.contAndamento)
        Me.Panel8.Controls.Add(Me.Label14)
        Me.Panel8.Controls.Add(Me.PictureBox5)
        Me.Panel8.Location = New System.Drawing.Point(127, 4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(116, 22)
        Me.Panel8.TabIndex = 12
        '
        'contAndamento
        '
        Me.contAndamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.contAndamento.BackColor = System.Drawing.Color.Transparent
        Me.contAndamento.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.contAndamento.ForeColor = System.Drawing.Color.SteelBlue
        Me.contAndamento.Location = New System.Drawing.Point(0, 1)
        Me.contAndamento.Name = "contAndamento"
        Me.contAndamento.Size = New System.Drawing.Size(24, 18)
        Me.contAndamento.TabIndex = 8
        Me.contAndamento.Text = "0"
        Me.contAndamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Label14.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label14.Location = New System.Drawing.Point(22, 4)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 14)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Em andamento"
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(94, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 11
        Me.PictureBox5.TabStop = False
        '
        'Panel9
        '
        Me.Panel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel9.Controls.Add(Me.Label17)
        Me.Panel9.Controls.Add(Me.contPendente)
        Me.Panel9.Controls.Add(Me.PictureBox6)
        Me.Panel9.Location = New System.Drawing.Point(34, 4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(96, 22)
        Me.Panel9.TabIndex = 12
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Label17.ForeColor = System.Drawing.Color.Gray
        Me.Label17.Location = New System.Drawing.Point(23, 4)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 14)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Pendente"
        '
        'contPendente
        '
        Me.contPendente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.contPendente.BackColor = System.Drawing.Color.Transparent
        Me.contPendente.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.contPendente.ForeColor = System.Drawing.Color.Gray
        Me.contPendente.Location = New System.Drawing.Point(-2, 1)
        Me.contPendente.Name = "contPendente"
        Me.contPendente.Size = New System.Drawing.Size(24, 18)
        Me.contPendente.TabIndex = 8
        Me.contPendente.Text = "0"
        Me.contPendente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox6
        '
        Me.PictureBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(74, 0)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 11
        Me.PictureBox6.TabStop = False
        '
        'SegPlano
        '
        '
        'AtualizaTimer
        '
        Me.AtualizaTimer.Interval = 10000
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.Controls.Add(Me.btnAgendar)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Panel9)
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Me.Panel8)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 603)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1248, 62)
        Me.Panel4.TabIndex = 14
        '
        'btnAgendar
        '
        Me.btnAgendar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgendar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAgendar.FlatAppearance.BorderSize = 0
        Me.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgendar.ForeColor = System.Drawing.Color.White
        Me.btnAgendar.Location = New System.Drawing.Point(1133, 8)
        Me.btnAgendar.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.btnAgendar.Name = "btnAgendar"
        Me.btnAgendar.Size = New System.Drawing.Size(103, 42)
        Me.btnAgendar.TabIndex = 33
        Me.btnAgendar.Text = "Agendar atendimento"
        Me.btnAgendar.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Gainsboro
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Gray
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(1248, 1)
        Me.Label13.TabIndex = 8
        '
        'GaleriaSituacao
        '
        Me.GaleriaSituacao.ImageStream = CType(resources.GetObject("GaleriaSituacao.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.GaleriaSituacao.TransparentColor = System.Drawing.Color.Transparent
        Me.GaleriaSituacao.Images.SetKeyName(0, "aguardando.png")
        Me.GaleriaSituacao.Images.SetKeyName(1, "agendado.png")
        Me.GaleriaSituacao.Images.SetKeyName(2, "pendente.png")
        Me.GaleriaSituacao.Images.SetKeyName(3, "sttFinalizado.png")
        Me.GaleriaSituacao.Images.SetKeyName(4, "cancelado.png")
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Humanst521 Lt BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(19, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0, 8, 18, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Filtro"
        '
        'FiltroAguardando
        '
        Me.FiltroAguardando.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FiltroAguardando.BackgroundImage = CType(resources.GetObject("FiltroAguardando.BackgroundImage"), System.Drawing.Image)
        Me.FiltroAguardando.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.FiltroAguardando.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.FiltroAguardando.FlatAppearance.BorderSize = 0
        Me.FiltroAguardando.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.FiltroAguardando.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.FiltroAguardando.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FiltroAguardando.Font = New System.Drawing.Font("Humanst521 Lt BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltroAguardando.ForeColor = System.Drawing.Color.DimGray
        Me.FiltroAguardando.Location = New System.Drawing.Point(176, 5)
        Me.FiltroAguardando.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.FiltroAguardando.Name = "FiltroAguardando"
        Me.FiltroAguardando.Size = New System.Drawing.Size(100, 28)
        Me.FiltroAguardando.TabIndex = 12
        Me.FiltroAguardando.Text = "Aguardando"
        Me.FiltroAguardando.UseVisualStyleBackColor = True
        '
        'FiltroAgendado
        '
        Me.FiltroAgendado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FiltroAgendado.BackgroundImage = CType(resources.GetObject("FiltroAgendado.BackgroundImage"), System.Drawing.Image)
        Me.FiltroAgendado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.FiltroAgendado.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.FiltroAgendado.FlatAppearance.BorderSize = 0
        Me.FiltroAgendado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.FiltroAgendado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.FiltroAgendado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FiltroAgendado.Font = New System.Drawing.Font("Humanst521 Lt BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltroAgendado.ForeColor = System.Drawing.Color.DimGray
        Me.FiltroAgendado.Location = New System.Drawing.Point(276, 5)
        Me.FiltroAgendado.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.FiltroAgendado.Name = "FiltroAgendado"
        Me.FiltroAgendado.Size = New System.Drawing.Size(100, 28)
        Me.FiltroAgendado.TabIndex = 12
        Me.FiltroAgendado.Text = "Agendado"
        Me.FiltroAgendado.UseVisualStyleBackColor = True
        '
        'FiltroFinalizado
        '
        Me.FiltroFinalizado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FiltroFinalizado.BackgroundImage = CType(resources.GetObject("FiltroFinalizado.BackgroundImage"), System.Drawing.Image)
        Me.FiltroFinalizado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.FiltroFinalizado.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.FiltroFinalizado.FlatAppearance.BorderSize = 0
        Me.FiltroFinalizado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.FiltroFinalizado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.FiltroFinalizado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FiltroFinalizado.Font = New System.Drawing.Font("Humanst521 Lt BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltroFinalizado.ForeColor = System.Drawing.Color.DimGray
        Me.FiltroFinalizado.Location = New System.Drawing.Point(376, 5)
        Me.FiltroFinalizado.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.FiltroFinalizado.Name = "FiltroFinalizado"
        Me.FiltroFinalizado.Size = New System.Drawing.Size(100, 28)
        Me.FiltroFinalizado.TabIndex = 12
        Me.FiltroFinalizado.Text = "Finalizado"
        Me.FiltroFinalizado.UseVisualStyleBackColor = True
        '
        'FiltroCancelado
        '
        Me.FiltroCancelado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FiltroCancelado.BackgroundImage = CType(resources.GetObject("FiltroCancelado.BackgroundImage"), System.Drawing.Image)
        Me.FiltroCancelado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.FiltroCancelado.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.FiltroCancelado.FlatAppearance.BorderSize = 0
        Me.FiltroCancelado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.FiltroCancelado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.FiltroCancelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FiltroCancelado.Font = New System.Drawing.Font("Humanst521 Lt BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltroCancelado.ForeColor = System.Drawing.Color.DimGray
        Me.FiltroCancelado.Location = New System.Drawing.Point(476, 5)
        Me.FiltroCancelado.Margin = New System.Windows.Forms.Padding(0, 5, 8, 0)
        Me.FiltroCancelado.Name = "FiltroCancelado"
        Me.FiltroCancelado.Size = New System.Drawing.Size(100, 28)
        Me.FiltroCancelado.TabIndex = 12
        Me.FiltroCancelado.Text = "Cancelado"
        Me.FiltroCancelado.UseVisualStyleBackColor = True
        '
        'FiltroTodos
        '
        Me.FiltroTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FiltroTodos.BackgroundImage = CType(resources.GetObject("FiltroTodos.BackgroundImage"), System.Drawing.Image)
        Me.FiltroTodos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.FiltroTodos.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.FiltroTodos.FlatAppearance.BorderSize = 0
        Me.FiltroTodos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.FiltroTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.FiltroTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FiltroTodos.Font = New System.Drawing.Font("Humanst521 Lt BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltroTodos.ForeColor = System.Drawing.Color.DimGray
        Me.FiltroTodos.Location = New System.Drawing.Point(76, 5)
        Me.FiltroTodos.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.FiltroTodos.Name = "FiltroTodos"
        Me.FiltroTodos.Size = New System.Drawing.Size(100, 29)
        Me.FiltroTodos.TabIndex = 12
        Me.FiltroTodos.Text = "Todos"
        Me.FiltroTodos.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackgroundImage = CType(resources.GetObject("FlowLayoutPanel1.BackgroundImage"), System.Drawing.Image)
        Me.FlowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.FlowLayoutPanel1.Controls.Add(Me.FiltroCancelado)
        Me.FlowLayoutPanel1.Controls.Add(Me.FiltroFinalizado)
        Me.FlowLayoutPanel1.Controls.Add(Me.FiltroAgendado)
        Me.FlowLayoutPanel1.Controls.Add(Me.FiltroAguardando)
        Me.FlowLayoutPanel1.Controls.Add(Me.FiltroTodos)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(34, 70)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(584, 39)
        Me.FlowLayoutPanel1.TabIndex = 15
        '
        'frmAtendimentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1248, 665)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.btnNovoChamado)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.DgvAtendimentos)
        Me.Font = New System.Drawing.Font("Humanst521 Lt BT", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAtendimentos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgvAtendimentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Titulo As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents contCancelado As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents contAndamento As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents contPendente As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents btnNovoChamado As Button
    Friend WithEvents SegPlano As System.ComponentModel.BackgroundWorker
    Friend WithEvents AtualizaTimer As Timer
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents DgvAtendimentos As DataGridView
    Friend WithEvents btnAgendar As Button
    Friend WithEvents GaleriaSituacao As ImageList
    Friend WithEvents FiltroTodos As Button
    Friend WithEvents FiltroCancelado As Button
    Friend WithEvents FiltroFinalizado As Button
    Friend WithEvents FiltroAgendado As Button
    Friend WithEvents FiltroAguardando As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
