<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        pnlTitle = New Panel()
        btnMinimize = New Button()
        btnMaximize = New Button()
        btnExit = New Button()
        pnlHistory = New Panel()
        RTBoxDisplayHistory = New RichTextBox()
        btnClearHistory = New Button()
        Panel3 = New Panel()
        btnMenu = New Button()
        btnHistory = New Button()
        txtDisplay2 = New TextBox()
        txtDisplay1 = New TextBox()
        btnBackSpace = New ArtanButton()
        ArtanButton2 = New ArtanButton()
        ArtanButton3 = New ArtanButton()
        ArtanButton4 = New ArtanButton()
        ArtanButton5 = New ArtanButton()
        ArtanButton8 = New ArtanButton()
        ArtanButton7 = New ArtanButton()
        btnPercent = New ArtanButton()
        btnCE = New ArtanButton()
        btnC = New ArtanButton()
        btnSquare = New ArtanButton()
        btnX2 = New ArtanButton()
        btn1X = New ArtanButton()
        btnDivision = New ArtanButton()
        btn6 = New ArtanButton()
        btn5 = New ArtanButton()
        btn4 = New ArtanButton()
        btnSubtract = New ArtanButton()
        btn9 = New ArtanButton()
        btn8 = New ArtanButton()
        btn7 = New ArtanButton()
        btnMultiply = New ArtanButton()
        btnDecimal = New ArtanButton()
        btn0 = New ArtanButton()
        btnPM = New ArtanButton()
        btnEquals = New ArtanButton()
        btn3 = New ArtanButton()
        btn2 = New ArtanButton()
        btn1 = New ArtanButton()
        btnAdd = New ArtanButton()
        pnlTitle.SuspendLayout()
        pnlHistory.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlTitle
        ' 
        pnlTitle.Controls.Add(btnMinimize)
        pnlTitle.Controls.Add(btnMaximize)
        pnlTitle.Controls.Add(btnExit)
        pnlTitle.Dock = DockStyle.Top
        pnlTitle.Location = New Point(0, 0)
        pnlTitle.Margin = New Padding(0)
        pnlTitle.Name = "pnlTitle"
        pnlTitle.Size = New Size(350, 40)
        pnlTitle.TabIndex = 1
        ' 
        ' btnMinimize
        ' 
        btnMinimize.Dock = DockStyle.Right
        btnMinimize.FlatAppearance.BorderSize = 0
        btnMinimize.FlatStyle = FlatStyle.Flat
        btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), Image)
        btnMinimize.Location = New Point(200, 0)
        btnMinimize.Margin = New Padding(0)
        btnMinimize.Name = "btnMinimize"
        btnMinimize.Size = New Size(50, 40)
        btnMinimize.TabIndex = 2
        btnMinimize.UseVisualStyleBackColor = True
        ' 
        ' btnMaximize
        ' 
        btnMaximize.BackColor = Color.FromArgb(CByte(32), CByte(32), CByte(32))
        btnMaximize.Dock = DockStyle.Right
        btnMaximize.FlatAppearance.BorderSize = 0
        btnMaximize.FlatStyle = FlatStyle.Flat
        btnMaximize.Image = CType(resources.GetObject("btnMaximize.Image"), Image)
        btnMaximize.Location = New Point(250, 0)
        btnMaximize.Margin = New Padding(0)
        btnMaximize.Name = "btnMaximize"
        btnMaximize.Size = New Size(50, 40)
        btnMaximize.TabIndex = 1
        btnMaximize.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.Dock = DockStyle.Right
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Image = CType(resources.GetObject("btnExit.Image"), Image)
        btnExit.Location = New Point(300, 0)
        btnExit.Margin = New Padding(0)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(50, 40)
        btnExit.TabIndex = 0
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' pnlHistory
        ' 
        pnlHistory.Controls.Add(RTBoxDisplayHistory)
        pnlHistory.Controls.Add(btnClearHistory)
        pnlHistory.Dock = DockStyle.Bottom
        pnlHistory.Location = New Point(0, 565)
        pnlHistory.Margin = New Padding(0)
        pnlHistory.Name = "pnlHistory"
        pnlHistory.Size = New Size(350, 5)
        pnlHistory.TabIndex = 2
        ' 
        ' RTBoxDisplayHistory
        ' 
        RTBoxDisplayHistory.BackColor = Color.FromArgb(CByte(32), CByte(32), CByte(32))
        RTBoxDisplayHistory.BorderStyle = BorderStyle.None
        RTBoxDisplayHistory.Dock = DockStyle.Fill
        RTBoxDisplayHistory.ForeColor = Color.Silver
        RTBoxDisplayHistory.Location = New Point(0, 0)
        RTBoxDisplayHistory.Margin = New Padding(0)
        RTBoxDisplayHistory.Name = "RTBoxDisplayHistory"
        RTBoxDisplayHistory.ScrollBars = RichTextBoxScrollBars.Horizontal
        RTBoxDisplayHistory.Size = New Size(350, 0)
        RTBoxDisplayHistory.TabIndex = 4
        RTBoxDisplayHistory.Text = "" ' 
        ' btnClearHistory
        ' 
        btnClearHistory.Dock = DockStyle.Bottom
        btnClearHistory.FlatAppearance.BorderSize = 0
        btnClearHistory.FlatStyle = FlatStyle.Flat
        btnClearHistory.Image = CType(resources.GetObject("btnClearHistory.Image"), Image)
        btnClearHistory.Location = New Point(0, -35)
        btnClearHistory.Margin = New Padding(0)
        btnClearHistory.Name = "btnClearHistory"
        btnClearHistory.Size = New Size(350, 40)
        btnClearHistory.TabIndex = 3
        btnClearHistory.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(btnMenu)
        Panel3.Controls.Add(btnHistory)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 40)
        Panel3.Margin = New Padding(0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(350, 46)
        Panel3.TabIndex = 3
        ' 
        ' btnMenu
        ' 
        btnMenu.Dock = DockStyle.Left
        btnMenu.FlatAppearance.BorderSize = 0
        btnMenu.FlatStyle = FlatStyle.Flat
        btnMenu.Image = CType(resources.GetObject("btnMenu.Image"), Image)
        btnMenu.Location = New Point(0, 0)
        btnMenu.Margin = New Padding(0)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(50, 46)
        btnMenu.TabIndex = 2
        btnMenu.UseVisualStyleBackColor = True
        ' 
        ' btnHistory
        ' 
        btnHistory.Dock = DockStyle.Right
        btnHistory.FlatAppearance.BorderSize = 0
        btnHistory.FlatStyle = FlatStyle.Flat
        btnHistory.Image = CType(resources.GetObject("btnHistory.Image"), Image)
        btnHistory.Location = New Point(300, 0)
        btnHistory.Margin = New Padding(0)
        btnHistory.Name = "btnHistory"
        btnHistory.Size = New Size(50, 46)
        btnHistory.TabIndex = 0
        btnHistory.UseVisualStyleBackColor = True
        ' 
        ' txtDisplay2
        ' 
        txtDisplay2.BackColor = Color.FromArgb(CByte(32), CByte(32), CByte(32))
        txtDisplay2.BorderStyle = BorderStyle.None
        txtDisplay2.Dock = DockStyle.Top
        txtDisplay2.Font = New Font("Gadugi", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtDisplay2.ForeColor = Color.White
        txtDisplay2.Location = New Point(0, 86)
        txtDisplay2.Margin = New Padding(0)
        txtDisplay2.Multiline = True
        txtDisplay2.Name = "txtDisplay2"
        txtDisplay2.Size = New Size(350, 30)
        txtDisplay2.TabIndex = 4
        txtDisplay2.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtDisplay1
        ' 
        txtDisplay1.BackColor = Color.FromArgb(CByte(32), CByte(32), CByte(32))
        txtDisplay1.BorderStyle = BorderStyle.None
        txtDisplay1.Dock = DockStyle.Top
        txtDisplay1.Font = New Font("Gadugi", 30.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtDisplay1.ForeColor = Color.White
        txtDisplay1.Location = New Point(0, 116)
        txtDisplay1.Margin = New Padding(0)
        txtDisplay1.Multiline = True
        txtDisplay1.Name = "txtDisplay1"
        txtDisplay1.Size = New Size(350, 50)
        txtDisplay1.TabIndex = 5
        txtDisplay1.Text = "0"
        txtDisplay1.TextAlign = HorizontalAlignment.Right
        ' 
        ' btnBackSpace
        ' 
        btnBackSpace.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btnBackSpace.BackgroundColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btnBackSpace.BackgroundImageLayout = ImageLayout.Center
        btnBackSpace.FlatAppearance.BorderSize = 0
        btnBackSpace.FlatStyle = FlatStyle.Flat
        btnBackSpace.ForeColor = Color.WhiteSmoke
        btnBackSpace.Image = CType(resources.GetObject("btnBackSpace.Image"), Image)
        btnBackSpace.Location = New Point(264, 225)
        btnBackSpace.Margin = New Padding(0)
        btnBackSpace.Name = "btnBackSpace"
        btnBackSpace.Size = New Size(85, 55)
        btnBackSpace.TabIndex = 6
        btnBackSpace.TextAlign = ContentAlignment.MiddleRight
        btnBackSpace.TextColor = Color.WhiteSmoke
        btnBackSpace.UseVisualStyleBackColor = False
        ' 
        ' ArtanButton2
        ' 
        ArtanButton2.BackColor = Color.FromArgb(CByte(32), CByte(32), CByte(32))
        ArtanButton2.BackgroundColor = Color.FromArgb(CByte(32), CByte(32), CByte(32))
        ArtanButton2.BackgroundImageLayout = ImageLayout.None
        ArtanButton2.FlatAppearance.BorderSize = 0
        ArtanButton2.FlatStyle = FlatStyle.Flat
        ArtanButton2.ForeColor = Color.DarkGray
        ArtanButton2.Location = New Point(180, 182)
        ArtanButton2.Margin = New Padding(0)
        ArtanButton2.Name = "ArtanButton2"
        ArtanButton2.Size = New Size(50, 30)
        ArtanButton2.TabIndex = 7
        ArtanButton2.Text = " M-"
        ArtanButton2.TextColor = Color.DarkGray
        ArtanButton2.TextImageRelation = TextImageRelation.ImageBeforeText
        ArtanButton2.UseVisualStyleBackColor = True
        ' 
        ' ArtanButton3
        ' 
        ArtanButton3.BackColor = Color.FromArgb(CByte(32), CByte(32), CByte(32))
        ArtanButton3.BackgroundColor = Color.FromArgb(CByte(32), CByte(32), CByte(32))
        ArtanButton3.BackgroundImageLayout = ImageLayout.None
        ArtanButton3.FlatAppearance.BorderSize = 0
        ArtanButton3.FlatStyle = FlatStyle.Flat
        ArtanButton3.ForeColor = Color.DarkGray
        ArtanButton3.Location = New Point(240, 182)
        ArtanButton3.Margin = New Padding(0)
        ArtanButton3.Name = "ArtanButton3"
        ArtanButton3.Size = New Size(50, 30)
        ArtanButton3.TabIndex = 8
        ArtanButton3.Text = " MS"
        ArtanButton3.TextColor = Color.DarkGray
        ArtanButton3.TextImageRelation = TextImageRelation.ImageBeforeText
        ArtanButton3.UseVisualStyleBackColor = True
        ' 
        ' ArtanButton4
        ' 
        ArtanButton4.BackColor = Color.FromArgb(CByte(32), CByte(32), CByte(32))
        ArtanButton4.BackgroundColor = Color.FromArgb(CByte(32), CByte(32), CByte(32))
        ArtanButton4.BackgroundImageLayout = ImageLayout.None
        ArtanButton4.FlatAppearance.BorderSize = 0
        ArtanButton4.FlatStyle = FlatStyle.Flat
        ArtanButton4.ForeColor = Color.DarkGray
        ArtanButton4.Location = New Point(300, 182)
        ArtanButton4.Margin = New Padding(0)
        ArtanButton4.Name = "ArtanButton4"
        ArtanButton4.Size = New Size(50, 30)
        ArtanButton4.TabIndex = 9
        ArtanButton4.Text = " M~"
        ArtanButton4.TextColor = Color.DarkGray
        ArtanButton4.TextImageRelation = TextImageRelation.ImageBeforeText
        ArtanButton4.UseVisualStyleBackColor = True
        ' 
        ' ArtanButton5
        ' 
        ArtanButton5.BackColor = Color.FromArgb(CByte(32), CByte(32), CByte(32))
        ArtanButton5.BackgroundColor = Color.FromArgb(CByte(32), CByte(32), CByte(32))
        ArtanButton5.BackgroundImageLayout = ImageLayout.None
        ArtanButton5.FlatAppearance.BorderSize = 0
        ArtanButton5.FlatStyle = FlatStyle.Flat
        ArtanButton5.ForeColor = Color.DarkGray
        ArtanButton5.Location = New Point(120, 182)
        ArtanButton5.Margin = New Padding(0)
        ArtanButton5.Name = "ArtanButton5"
        ArtanButton5.Size = New Size(50, 30)
        ArtanButton5.TabIndex = 10
        ArtanButton5.Text = " M+"
        ArtanButton5.TextColor = Color.DarkGray
        ArtanButton5.TextImageRelation = TextImageRelation.ImageBeforeText
        ArtanButton5.UseVisualStyleBackColor = True
        ' 
        ' ArtanButton8
        ' 
        ArtanButton8.BackColor = Color.FromArgb(CByte(32), CByte(32), CByte(32))
        ArtanButton8.BackgroundColor = Color.FromArgb(CByte(32), CByte(32), CByte(32))
        ArtanButton8.BackgroundImageLayout = ImageLayout.None
        ArtanButton8.FlatAppearance.BorderSize = 0
        ArtanButton8.FlatStyle = FlatStyle.Flat
        ArtanButton8.ForeColor = Color.DarkGray
        ArtanButton8.Location = New Point(0, 182)
        ArtanButton8.Margin = New Padding(0)
        ArtanButton8.Name = "ArtanButton8"
        ArtanButton8.Size = New Size(50, 30)
        ArtanButton8.TabIndex = 12
        ArtanButton8.Text = " MC"
        ArtanButton8.TextColor = Color.DarkGray
        ArtanButton8.TextImageRelation = TextImageRelation.ImageBeforeText
        ArtanButton8.UseVisualStyleBackColor = True
        ' 
        ' ArtanButton7
        ' 
        ArtanButton7.BackColor = Color.FromArgb(CByte(32), CByte(32), CByte(32))
        ArtanButton7.BackgroundColor = Color.FromArgb(CByte(32), CByte(32), CByte(32))
        ArtanButton7.BackgroundImageLayout = ImageLayout.None
        ArtanButton7.FlatAppearance.BorderSize = 0
        ArtanButton7.FlatStyle = FlatStyle.Flat
        ArtanButton7.ForeColor = Color.DarkGray
        ArtanButton7.Location = New Point(60, 182)
        ArtanButton7.Margin = New Padding(0)
        ArtanButton7.Name = "ArtanButton7"
        ArtanButton7.Size = New Size(50, 30)
        ArtanButton7.TabIndex = 13
        ArtanButton7.Text = " MR"
        ArtanButton7.TextColor = Color.DarkGray
        ArtanButton7.TextImageRelation = TextImageRelation.ImageBeforeText
        ArtanButton7.UseVisualStyleBackColor = True
        ' 
        ' btnPercent
        ' 
        btnPercent.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btnPercent.BackgroundColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btnPercent.BackgroundImageLayout = ImageLayout.Center
        btnPercent.FlatAppearance.BorderSize = 0
        btnPercent.FlatStyle = FlatStyle.Flat
        btnPercent.ForeColor = Color.WhiteSmoke
        btnPercent.Location = New Point(0, 225)
        btnPercent.Margin = New Padding(0)
        btnPercent.Name = "btnPercent"
        btnPercent.Size = New Size(85, 55)
        btnPercent.TabIndex = 16
        btnPercent.Text = "%"
        btnPercent.TextColor = Color.WhiteSmoke
        btnPercent.UseVisualStyleBackColor = False
        ' 
        ' btnCE
        ' 
        btnCE.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btnCE.BackgroundColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btnCE.BackgroundImageLayout = ImageLayout.Center
        btnCE.FlatAppearance.BorderSize = 0
        btnCE.FlatStyle = FlatStyle.Flat
        btnCE.ForeColor = Color.WhiteSmoke
        btnCE.Location = New Point(88, 225)
        btnCE.Margin = New Padding(0)
        btnCE.Name = "btnCE"
        btnCE.Size = New Size(85, 55)
        btnCE.TabIndex = 17
        btnCE.Text = "CE"
        btnCE.TextColor = Color.WhiteSmoke
        btnCE.UseVisualStyleBackColor = False
        ' 
        ' btnC
        ' 
        btnC.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btnC.BackgroundColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btnC.BackgroundImageLayout = ImageLayout.Center
        btnC.FlatAppearance.BorderSize = 0
        btnC.FlatStyle = FlatStyle.Flat
        btnC.ForeColor = Color.WhiteSmoke
        btnC.Location = New Point(176, 225)
        btnC.Margin = New Padding(0)
        btnC.Name = "btnC"
        btnC.Size = New Size(85, 55)
        btnC.TabIndex = 18
        btnC.Text = "C"
        btnC.TextColor = Color.WhiteSmoke
        btnC.UseVisualStyleBackColor = False
        ' 
        ' btnSquare
        ' 
        btnSquare.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btnSquare.BackgroundColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btnSquare.BackgroundImageLayout = ImageLayout.Center
        btnSquare.FlatAppearance.BorderSize = 0
        btnSquare.FlatStyle = FlatStyle.Flat
        btnSquare.ForeColor = Color.WhiteSmoke
        btnSquare.Location = New Point(176, 280)
        btnSquare.Margin = New Padding(0)
        btnSquare.Name = "btnSquare"
        btnSquare.Size = New Size(85, 55)
        btnSquare.TabIndex = 22
        btnSquare.Text = "√x"
        btnSquare.TextColor = Color.WhiteSmoke
        btnSquare.UseVisualStyleBackColor = False
        ' 
        ' btnX2
        ' 
        btnX2.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btnX2.BackgroundColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btnX2.BackgroundImageLayout = ImageLayout.Center
        btnX2.FlatAppearance.BorderSize = 0
        btnX2.FlatStyle = FlatStyle.Flat
        btnX2.ForeColor = Color.WhiteSmoke
        btnX2.Location = New Point(88, 280)
        btnX2.Margin = New Padding(0)
        btnX2.Name = "btnX2"
        btnX2.Size = New Size(85, 55)
        btnX2.TabIndex = 21
        btnX2.Text = "^2"
        btnX2.TextColor = Color.WhiteSmoke
        btnX2.UseVisualStyleBackColor = False
        ' 
        ' btn1X
        ' 
        btn1X.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btn1X.BackgroundColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btn1X.BackgroundImageLayout = ImageLayout.Center
        btn1X.FlatAppearance.BorderSize = 0
        btn1X.FlatStyle = FlatStyle.Flat
        btn1X.ForeColor = Color.WhiteSmoke
        btn1X.Location = New Point(0, 280)
        btn1X.Margin = New Padding(0)
        btn1X.Name = "btn1X"
        btn1X.Size = New Size(85, 55)
        btn1X.TabIndex = 20
        btn1X.Text = "⅟x"
        btn1X.TextColor = Color.WhiteSmoke
        btn1X.UseVisualStyleBackColor = False
        ' 
        ' btnDivision
        ' 
        btnDivision.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btnDivision.BackgroundColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btnDivision.BackgroundImageLayout = ImageLayout.Center
        btnDivision.FlatAppearance.BorderSize = 0
        btnDivision.FlatStyle = FlatStyle.Flat
        btnDivision.Font = New Font("Gadugi", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnDivision.ForeColor = Color.WhiteSmoke
        btnDivision.Location = New Point(264, 280)
        btnDivision.Margin = New Padding(0)
        btnDivision.Name = "btnDivision"
        btnDivision.Size = New Size(85, 55)
        btnDivision.TabIndex = 19
        btnDivision.Text = "÷"
        btnDivision.TextColor = Color.WhiteSmoke
        btnDivision.UseVisualStyleBackColor = False
        ' 
        ' btn6
        ' 
        btn6.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btn6.BackgroundColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btn6.BackgroundImageLayout = ImageLayout.Center
        btn6.FlatAppearance.BorderSize = 0
        btn6.FlatStyle = FlatStyle.Flat
        btn6.Font = New Font("Gadugi", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btn6.ForeColor = Color.WhiteSmoke
        btn6.Location = New Point(176, 390)
        btn6.Margin = New Padding(0)
        btn6.Name = "btn6"
        btn6.Size = New Size(85, 55)
        btn6.TabIndex = 30
        btn6.Text = "6"
        btn6.TextColor = Color.WhiteSmoke
        btn6.UseVisualStyleBackColor = False
        ' 
        ' btn5
        ' 
        btn5.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btn5.BackgroundColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btn5.BackgroundImageLayout = ImageLayout.Center
        btn5.FlatAppearance.BorderSize = 0
        btn5.FlatStyle = FlatStyle.Flat
        btn5.Font = New Font("Gadugi", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btn5.ForeColor = Color.WhiteSmoke
        btn5.Location = New Point(88, 390)
        btn5.Margin = New Padding(0)
        btn5.Name = "btn5"
        btn5.Size = New Size(85, 55)
        btn5.TabIndex = 29
        btn5.Text = "5"
        btn5.TextColor = Color.WhiteSmoke
        btn5.UseVisualStyleBackColor = False
        ' 
        ' btn4
        ' 
        btn4.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btn4.BackgroundColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btn4.BackgroundImageLayout = ImageLayout.Center
        btn4.FlatAppearance.BorderSize = 0
        btn4.FlatStyle = FlatStyle.Flat
        btn4.Font = New Font("Gadugi", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btn4.ForeColor = Color.WhiteSmoke
        btn4.Location = New Point(0, 390)
        btn4.Margin = New Padding(0)
        btn4.Name = "btn4"
        btn4.Size = New Size(85, 55)
        btn4.TabIndex = 28
        btn4.Text = "4"
        btn4.TextColor = Color.WhiteSmoke
        btn4.UseVisualStyleBackColor = False
        ' 
        ' btnSubtract
        ' 
        btnSubtract.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btnSubtract.BackgroundColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btnSubtract.BackgroundImageLayout = ImageLayout.Center
        btnSubtract.FlatAppearance.BorderSize = 0
        btnSubtract.FlatStyle = FlatStyle.Flat
        btnSubtract.Font = New Font("Gadugi", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnSubtract.ForeColor = Color.WhiteSmoke
        btnSubtract.Location = New Point(264, 390)
        btnSubtract.Margin = New Padding(0)
        btnSubtract.Name = "btnSubtract"
        btnSubtract.Size = New Size(85, 55)
        btnSubtract.TabIndex = 27
        btnSubtract.Text = "-"
        btnSubtract.TextColor = Color.WhiteSmoke
        btnSubtract.UseVisualStyleBackColor = False
        ' 
        ' btn9
        ' 
        btn9.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btn9.BackgroundColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btn9.BackgroundImageLayout = ImageLayout.Center
        btn9.FlatAppearance.BorderSize = 0
        btn9.FlatStyle = FlatStyle.Flat
        btn9.Font = New Font("Gadugi", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btn9.ForeColor = Color.WhiteSmoke
        btn9.Location = New Point(176, 335)
        btn9.Margin = New Padding(0)
        btn9.Name = "btn9"
        btn9.Size = New Size(85, 55)
        btn9.TabIndex = 26
        btn9.Text = "9"
        btn9.TextColor = Color.WhiteSmoke
        btn9.UseVisualStyleBackColor = False
        ' 
        ' btn8
        ' 
        btn8.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btn8.BackgroundColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btn8.BackgroundImageLayout = ImageLayout.Center
        btn8.FlatAppearance.BorderSize = 0
        btn8.FlatStyle = FlatStyle.Flat
        btn8.Font = New Font("Gadugi", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btn8.ForeColor = Color.WhiteSmoke
        btn8.Location = New Point(88, 335)
        btn8.Margin = New Padding(0)
        btn8.Name = "btn8"
        btn8.Size = New Size(85, 55)
        btn8.TabIndex = 25
        btn8.Text = "8"
        btn8.TextColor = Color.WhiteSmoke
        btn8.UseVisualStyleBackColor = False
        ' 
        ' btn7
        ' 
        btn7.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btn7.BackgroundColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btn7.BackgroundImageLayout = ImageLayout.Center
        btn7.FlatAppearance.BorderSize = 0
        btn7.FlatStyle = FlatStyle.Flat
        btn7.Font = New Font("Gadugi", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btn7.ForeColor = Color.WhiteSmoke
        btn7.Location = New Point(0, 335)
        btn7.Margin = New Padding(0)
        btn7.Name = "btn7"
        btn7.Size = New Size(85, 55)
        btn7.TabIndex = 24
        btn7.Text = "7"
        btn7.TextColor = Color.WhiteSmoke
        btn7.UseVisualStyleBackColor = False
        ' 
        ' btnMultiply
        ' 
        btnMultiply.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btnMultiply.BackgroundColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btnMultiply.BackgroundImageLayout = ImageLayout.Center
        btnMultiply.FlatAppearance.BorderSize = 0
        btnMultiply.FlatStyle = FlatStyle.Flat
        btnMultiply.Font = New Font("Gadugi", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnMultiply.ForeColor = Color.WhiteSmoke
        btnMultiply.Location = New Point(264, 335)
        btnMultiply.Margin = New Padding(0)
        btnMultiply.Name = "btnMultiply"
        btnMultiply.Size = New Size(85, 55)
        btnMultiply.TabIndex = 23
        btnMultiply.Text = "x"
        btnMultiply.TextColor = Color.WhiteSmoke
        btnMultiply.UseVisualStyleBackColor = False
        ' 
        ' btnDecimal
        ' 
        btnDecimal.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btnDecimal.BackgroundColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btnDecimal.BackgroundImageLayout = ImageLayout.Center
        btnDecimal.FlatAppearance.BorderSize = 0
        btnDecimal.FlatStyle = FlatStyle.Flat
        btnDecimal.Font = New Font("Gadugi", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnDecimal.ForeColor = Color.WhiteSmoke
        btnDecimal.Location = New Point(176, 500)
        btnDecimal.Margin = New Padding(0)
        btnDecimal.Name = "btnDecimal"
        btnDecimal.Size = New Size(85, 55)
        btnDecimal.TabIndex = 38
        btnDecimal.Text = "."
        btnDecimal.TextColor = Color.WhiteSmoke
        btnDecimal.UseVisualStyleBackColor = False
        ' 
        ' btn0
        ' 
        btn0.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btn0.BackgroundColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btn0.BackgroundImageLayout = ImageLayout.Center
        btn0.FlatAppearance.BorderSize = 0
        btn0.FlatStyle = FlatStyle.Flat
        btn0.Font = New Font("Gadugi", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btn0.ForeColor = Color.WhiteSmoke
        btn0.Location = New Point(88, 500)
        btn0.Margin = New Padding(0)
        btn0.Name = "btn0"
        btn0.Size = New Size(85, 55)
        btn0.TabIndex = 37
        btn0.Text = "0"
        btn0.TextColor = Color.WhiteSmoke
        btn0.UseVisualStyleBackColor = False
        ' 
        ' btnPM
        ' 
        btnPM.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btnPM.BackgroundColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btnPM.BackgroundImageLayout = ImageLayout.Center
        btnPM.FlatAppearance.BorderSize = 0
        btnPM.FlatStyle = FlatStyle.Flat
        btnPM.Font = New Font("Gadugi", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnPM.ForeColor = Color.WhiteSmoke
        btnPM.Location = New Point(0, 500)
        btnPM.Margin = New Padding(0)
        btnPM.Name = "btnPM"
        btnPM.Size = New Size(85, 55)
        btnPM.TabIndex = 36
        btnPM.Text = "±"
        btnPM.TextColor = Color.WhiteSmoke
        btnPM.UseVisualStyleBackColor = False
        ' 
        ' btnEquals
        ' 
        btnEquals.BackColor = SystemColors.Highlight
        btnEquals.BackgroundColor = SystemColors.Highlight
        btnEquals.BackgroundImageLayout = ImageLayout.Center
        btnEquals.FlatAppearance.BorderSize = 0
        btnEquals.FlatStyle = FlatStyle.Flat
        btnEquals.Font = New Font("Gadugi", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnEquals.ForeColor = Color.WhiteSmoke
        btnEquals.Location = New Point(264, 500)
        btnEquals.Margin = New Padding(0)
        btnEquals.Name = "btnEquals"
        btnEquals.Size = New Size(85, 55)
        btnEquals.TabIndex = 35
        btnEquals.Text = "="
        btnEquals.TextColor = Color.WhiteSmoke
        btnEquals.UseVisualStyleBackColor = False
        ' 
        ' btn3
        ' 
        btn3.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btn3.BackgroundColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btn3.BackgroundImageLayout = ImageLayout.Center
        btn3.FlatAppearance.BorderSize = 0
        btn3.FlatStyle = FlatStyle.Flat
        btn3.Font = New Font("Gadugi", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btn3.ForeColor = Color.WhiteSmoke
        btn3.Location = New Point(176, 445)
        btn3.Margin = New Padding(0)
        btn3.Name = "btn3"
        btn3.Size = New Size(85, 55)
        btn3.TabIndex = 34
        btn3.Text = "3"
        btn3.TextColor = Color.WhiteSmoke
        btn3.UseVisualStyleBackColor = False
        ' 
        ' btn2
        ' 
        btn2.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btn2.BackgroundColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btn2.BackgroundImageLayout = ImageLayout.Center
        btn2.FlatAppearance.BorderSize = 0
        btn2.FlatStyle = FlatStyle.Flat
        btn2.Font = New Font("Gadugi", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btn2.ForeColor = Color.WhiteSmoke
        btn2.Location = New Point(88, 445)
        btn2.Margin = New Padding(0)
        btn2.Name = "btn2"
        btn2.Size = New Size(85, 55)
        btn2.TabIndex = 33
        btn2.Text = "2"
        btn2.TextColor = Color.WhiteSmoke
        btn2.UseVisualStyleBackColor = False
        ' 
        ' btn1
        ' 
        btn1.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btn1.BackgroundColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btn1.BackgroundImageLayout = ImageLayout.Center
        btn1.FlatAppearance.BorderSize = 0
        btn1.FlatStyle = FlatStyle.Flat
        btn1.Font = New Font("Gadugi", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btn1.ForeColor = Color.WhiteSmoke
        btn1.Location = New Point(0, 445)
        btn1.Margin = New Padding(0)
        btn1.Name = "btn1"
        btn1.Size = New Size(85, 55)
        btn1.TabIndex = 32
        btn1.Text = "1"
        btn1.TextColor = Color.WhiteSmoke
        btn1.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btnAdd.BackgroundColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btnAdd.BackgroundImageLayout = ImageLayout.Center
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Gadugi", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnAdd.ForeColor = Color.WhiteSmoke
        btnAdd.Location = New Point(264, 445)
        btnAdd.Margin = New Padding(0)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(85, 55)
        btnAdd.TabIndex = 31
        btnAdd.Text = "+"
        btnAdd.TextColor = Color.WhiteSmoke
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9.0F, 19.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(32), CByte(32))
        ClientSize = New Size(350, 570)
        Controls.Add(pnlHistory)
        Controls.Add(btnDecimal)
        Controls.Add(btn0)
        Controls.Add(btnPM)
        Controls.Add(btnEquals)
        Controls.Add(btn3)
        Controls.Add(btn2)
        Controls.Add(btn1)
        Controls.Add(btnAdd)
        Controls.Add(btn6)
        Controls.Add(btn5)
        Controls.Add(btn4)
        Controls.Add(btnSubtract)
        Controls.Add(btn9)
        Controls.Add(btn8)
        Controls.Add(btn7)
        Controls.Add(btnMultiply)
        Controls.Add(btnSquare)
        Controls.Add(btnX2)
        Controls.Add(btn1X)
        Controls.Add(btnDivision)
        Controls.Add(btnC)
        Controls.Add(btnCE)
        Controls.Add(btnPercent)
        Controls.Add(ArtanButton7)
        Controls.Add(ArtanButton8)
        Controls.Add(ArtanButton5)
        Controls.Add(ArtanButton4)
        Controls.Add(ArtanButton3)
        Controls.Add(ArtanButton2)
        Controls.Add(btnBackSpace)
        Controls.Add(txtDisplay1)
        Controls.Add(txtDisplay2)
        Controls.Add(Panel3)
        Controls.Add(pnlTitle)
        Font = New Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        pnlTitle.ResumeLayout(False)
        pnlHistory.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlTitle As Panel
    Friend WithEvents pnlHistory As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnMaximize As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents txtDisplay2 As TextBox
    Friend WithEvents txtDisplay1 As TextBox
    Friend WithEvents RTBoxDisplayHistory As RichTextBox
    Friend WithEvents btnClearHistory As Button
    Friend WithEvents btnBackSpace As ArtanButton
    Friend WithEvents ArtanButton2 As ArtanButton
    Friend WithEvents ArtanButton3 As ArtanButton
    Friend WithEvents ArtanButton4 As ArtanButton
    Friend WithEvents ArtanButton5 As ArtanButton
    Friend WithEvents ArtanButton8 As ArtanButton
    Friend WithEvents ArtanButton7 As ArtanButton
    Friend WithEvents btnPercent As ArtanButton
    Friend WithEvents btnCE As ArtanButton
    Friend WithEvents btnC As ArtanButton
    Friend WithEvents btnSquare As ArtanButton
    Friend WithEvents btnX2 As ArtanButton
    Friend WithEvents btn1X As ArtanButton
    Friend WithEvents btnDivision As ArtanButton
    Friend WithEvents btn6 As ArtanButton
    Friend WithEvents btn5 As ArtanButton
    Friend WithEvents btn4 As ArtanButton
    Friend WithEvents btnSubtract As ArtanButton
    Friend WithEvents btn9 As ArtanButton
    Friend WithEvents btn8 As ArtanButton
    Friend WithEvents btn7 As ArtanButton
    Friend WithEvents btnMultiply As ArtanButton
    Friend WithEvents btnDecimal As ArtanButton
    Friend WithEvents btn0 As ArtanButton
    Friend WithEvents btnPM As ArtanButton
    Friend WithEvents btnEquals As ArtanButton
    Friend WithEvents btn3 As ArtanButton
    Friend WithEvents btn2 As ArtanButton
    Friend WithEvents btn1 As ArtanButton
    Friend WithEvents btnAdd As ArtanButton
End Class
