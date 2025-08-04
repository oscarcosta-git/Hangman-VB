<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Hangman
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hangman))
        Me.GuessesAlready = New System.Windows.Forms.Label()
        Me.HangmanPicture = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GuessedAlready = New System.Windows.Forms.Label()
        Me.ZButton = New System.Windows.Forms.Button()
        Me.YButton = New System.Windows.Forms.Button()
        Me.AButton = New System.Windows.Forms.Button()
        Me.XButton = New System.Windows.Forms.Button()
        Me.EButton = New System.Windows.Forms.Button()
        Me.WButton = New System.Windows.Forms.Button()
        Me.DButton = New System.Windows.Forms.Button()
        Me.VButton = New System.Windows.Forms.Button()
        Me.CButton = New System.Windows.Forms.Button()
        Me.UButton = New System.Windows.Forms.Button()
        Me.BButton = New System.Windows.Forms.Button()
        Me.TButton = New System.Windows.Forms.Button()
        Me.FButton = New System.Windows.Forms.Button()
        Me.SButton = New System.Windows.Forms.Button()
        Me.JButton = New System.Windows.Forms.Button()
        Me.RButton = New System.Windows.Forms.Button()
        Me.IButton = New System.Windows.Forms.Button()
        Me.QButton = New System.Windows.Forms.Button()
        Me.HButton = New System.Windows.Forms.Button()
        Me.PButton = New System.Windows.Forms.Button()
        Me.GButton = New System.Windows.Forms.Button()
        Me.OButton = New System.Windows.Forms.Button()
        Me.KButton = New System.Windows.Forms.Button()
        Me.NButton = New System.Windows.Forms.Button()
        Me.LButton = New System.Windows.Forms.Button()
        Me.MButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.DebuggingLabel = New System.Windows.Forms.Label()
        Me.MenuButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.OutputLabel = New System.Windows.Forms.Label()
        Me.HintsLabel = New System.Windows.Forms.Label()
        CType(Me.HangmanPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GuessesAlready
        '
        Me.GuessesAlready.AutoSize = True
        Me.GuessesAlready.Font = New System.Drawing.Font("MV Boli", 12.0!)
        Me.GuessesAlready.Location = New System.Drawing.Point(2, 3)
        Me.GuessesAlready.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GuessesAlready.Name = "GuessesAlready"
        Me.GuessesAlready.Size = New System.Drawing.Size(138, 21)
        Me.GuessesAlready.TabIndex = 3
        Me.GuessesAlready.Text = "Guessed Already:"
        '
        'HangmanPicture
        '
        Me.HangmanPicture.Location = New System.Drawing.Point(10, 69)
        Me.HangmanPicture.Margin = New System.Windows.Forms.Padding(2)
        Me.HangmanPicture.Name = "HangmanPicture"
        Me.HangmanPicture.Size = New System.Drawing.Size(314, 345)
        Me.HangmanPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HangmanPicture.TabIndex = 5
        Me.HangmanPicture.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.GuessedAlready)
        Me.Panel1.Controls.Add(Me.ZButton)
        Me.Panel1.Controls.Add(Me.GuessesAlready)
        Me.Panel1.Controls.Add(Me.YButton)
        Me.Panel1.Controls.Add(Me.AButton)
        Me.Panel1.Controls.Add(Me.XButton)
        Me.Panel1.Controls.Add(Me.EButton)
        Me.Panel1.Controls.Add(Me.WButton)
        Me.Panel1.Controls.Add(Me.DButton)
        Me.Panel1.Controls.Add(Me.VButton)
        Me.Panel1.Controls.Add(Me.CButton)
        Me.Panel1.Controls.Add(Me.UButton)
        Me.Panel1.Controls.Add(Me.BButton)
        Me.Panel1.Controls.Add(Me.TButton)
        Me.Panel1.Controls.Add(Me.FButton)
        Me.Panel1.Controls.Add(Me.SButton)
        Me.Panel1.Controls.Add(Me.JButton)
        Me.Panel1.Controls.Add(Me.RButton)
        Me.Panel1.Controls.Add(Me.IButton)
        Me.Panel1.Controls.Add(Me.QButton)
        Me.Panel1.Controls.Add(Me.HButton)
        Me.Panel1.Controls.Add(Me.PButton)
        Me.Panel1.Controls.Add(Me.GButton)
        Me.Panel1.Controls.Add(Me.OButton)
        Me.Panel1.Controls.Add(Me.KButton)
        Me.Panel1.Controls.Add(Me.NButton)
        Me.Panel1.Controls.Add(Me.LButton)
        Me.Panel1.Controls.Add(Me.MButton)
        Me.Panel1.Location = New System.Drawing.Point(328, 69)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(271, 345)
        Me.Panel1.TabIndex = 6
        '
        'GuessedAlready
        '
        Me.GuessedAlready.AutoSize = True
        Me.GuessedAlready.Location = New System.Drawing.Point(4, 24)
        Me.GuessedAlready.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GuessedAlready.Name = "GuessedAlready"
        Me.GuessedAlready.Size = New System.Drawing.Size(237, 13)
        Me.GuessedAlready.TabIndex = 34
        Me.GuessedAlready.Text = "Letters you have already gussed will appear here"
        '
        'ZButton
        '
        Me.ZButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ZButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ZButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ZButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ZButton.ForeColor = System.Drawing.Color.White
        Me.ZButton.Location = New System.Drawing.Point(134, 299)
        Me.ZButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ZButton.Name = "ZButton"
        Me.ZButton.Size = New System.Drawing.Size(38, 41)
        Me.ZButton.TabIndex = 33
        Me.ZButton.Text = "Z"
        Me.ZButton.UseVisualStyleBackColor = False
        '
        'YButton
        '
        Me.YButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.YButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.YButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.YButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.YButton.ForeColor = System.Drawing.Color.White
        Me.YButton.Location = New System.Drawing.Point(92, 299)
        Me.YButton.Margin = New System.Windows.Forms.Padding(2)
        Me.YButton.Name = "YButton"
        Me.YButton.Size = New System.Drawing.Size(38, 41)
        Me.YButton.TabIndex = 32
        Me.YButton.Text = "Y"
        Me.YButton.UseVisualStyleBackColor = False
        '
        'AButton
        '
        Me.AButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.AButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.AButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AButton.ForeColor = System.Drawing.Color.White
        Me.AButton.Location = New System.Drawing.Point(8, 117)
        Me.AButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AButton.Name = "AButton"
        Me.AButton.Size = New System.Drawing.Size(38, 41)
        Me.AButton.TabIndex = 8
        Me.AButton.Text = "A"
        Me.AButton.UseVisualStyleBackColor = False
        '
        'XButton
        '
        Me.XButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.XButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.XButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.XButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.XButton.ForeColor = System.Drawing.Color.White
        Me.XButton.Location = New System.Drawing.Point(218, 254)
        Me.XButton.Margin = New System.Windows.Forms.Padding(2)
        Me.XButton.Name = "XButton"
        Me.XButton.Size = New System.Drawing.Size(38, 41)
        Me.XButton.TabIndex = 31
        Me.XButton.Text = "X"
        Me.XButton.UseVisualStyleBackColor = False
        '
        'EButton
        '
        Me.EButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.EButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.EButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EButton.ForeColor = System.Drawing.Color.White
        Me.EButton.Location = New System.Drawing.Point(176, 117)
        Me.EButton.Margin = New System.Windows.Forms.Padding(2)
        Me.EButton.Name = "EButton"
        Me.EButton.Size = New System.Drawing.Size(38, 41)
        Me.EButton.TabIndex = 12
        Me.EButton.Text = "E"
        Me.EButton.UseVisualStyleBackColor = False
        '
        'WButton
        '
        Me.WButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.WButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.WButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.WButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WButton.ForeColor = System.Drawing.Color.White
        Me.WButton.Location = New System.Drawing.Point(176, 254)
        Me.WButton.Margin = New System.Windows.Forms.Padding(2)
        Me.WButton.Name = "WButton"
        Me.WButton.Size = New System.Drawing.Size(38, 41)
        Me.WButton.TabIndex = 30
        Me.WButton.Text = "W"
        Me.WButton.UseVisualStyleBackColor = False
        '
        'DButton
        '
        Me.DButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.DButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DButton.ForeColor = System.Drawing.Color.White
        Me.DButton.Location = New System.Drawing.Point(134, 117)
        Me.DButton.Margin = New System.Windows.Forms.Padding(2)
        Me.DButton.Name = "DButton"
        Me.DButton.Size = New System.Drawing.Size(38, 41)
        Me.DButton.TabIndex = 11
        Me.DButton.Text = "D"
        Me.DButton.UseVisualStyleBackColor = False
        '
        'VButton
        '
        Me.VButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.VButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.VButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.VButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VButton.ForeColor = System.Drawing.Color.White
        Me.VButton.Location = New System.Drawing.Point(134, 254)
        Me.VButton.Margin = New System.Windows.Forms.Padding(2)
        Me.VButton.Name = "VButton"
        Me.VButton.Size = New System.Drawing.Size(38, 41)
        Me.VButton.TabIndex = 29
        Me.VButton.Text = "V"
        Me.VButton.UseVisualStyleBackColor = False
        '
        'CButton
        '
        Me.CButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.CButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CButton.ForeColor = System.Drawing.Color.White
        Me.CButton.Location = New System.Drawing.Point(92, 117)
        Me.CButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CButton.Name = "CButton"
        Me.CButton.Size = New System.Drawing.Size(38, 41)
        Me.CButton.TabIndex = 10
        Me.CButton.Text = "C"
        Me.CButton.UseVisualStyleBackColor = False
        '
        'UButton
        '
        Me.UButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.UButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UButton.ForeColor = System.Drawing.Color.White
        Me.UButton.Location = New System.Drawing.Point(92, 254)
        Me.UButton.Margin = New System.Windows.Forms.Padding(2)
        Me.UButton.Name = "UButton"
        Me.UButton.Size = New System.Drawing.Size(38, 41)
        Me.UButton.TabIndex = 28
        Me.UButton.Text = "U"
        Me.UButton.UseVisualStyleBackColor = False
        '
        'BButton
        '
        Me.BButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BButton.ForeColor = System.Drawing.Color.White
        Me.BButton.Location = New System.Drawing.Point(50, 117)
        Me.BButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BButton.Name = "BButton"
        Me.BButton.Size = New System.Drawing.Size(38, 41)
        Me.BButton.TabIndex = 9
        Me.BButton.Text = "B"
        Me.BButton.UseVisualStyleBackColor = False
        '
        'TButton
        '
        Me.TButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.TButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TButton.ForeColor = System.Drawing.Color.White
        Me.TButton.Location = New System.Drawing.Point(50, 254)
        Me.TButton.Margin = New System.Windows.Forms.Padding(2)
        Me.TButton.Name = "TButton"
        Me.TButton.Size = New System.Drawing.Size(38, 41)
        Me.TButton.TabIndex = 27
        Me.TButton.Text = "T"
        Me.TButton.UseVisualStyleBackColor = False
        '
        'FButton
        '
        Me.FButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.FButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FButton.ForeColor = System.Drawing.Color.White
        Me.FButton.Location = New System.Drawing.Point(218, 117)
        Me.FButton.Margin = New System.Windows.Forms.Padding(2)
        Me.FButton.Name = "FButton"
        Me.FButton.Size = New System.Drawing.Size(38, 41)
        Me.FButton.TabIndex = 13
        Me.FButton.Text = "F"
        Me.FButton.UseVisualStyleBackColor = False
        '
        'SButton
        '
        Me.SButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.SButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SButton.ForeColor = System.Drawing.Color.White
        Me.SButton.Location = New System.Drawing.Point(8, 254)
        Me.SButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SButton.Name = "SButton"
        Me.SButton.Size = New System.Drawing.Size(38, 41)
        Me.SButton.TabIndex = 26
        Me.SButton.Text = "S"
        Me.SButton.UseVisualStyleBackColor = False
        '
        'JButton
        '
        Me.JButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.JButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.JButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.JButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.JButton.ForeColor = System.Drawing.Color.White
        Me.JButton.Location = New System.Drawing.Point(133, 162)
        Me.JButton.Margin = New System.Windows.Forms.Padding(2)
        Me.JButton.Name = "JButton"
        Me.JButton.Size = New System.Drawing.Size(38, 41)
        Me.JButton.TabIndex = 17
        Me.JButton.Text = "J"
        Me.JButton.UseVisualStyleBackColor = False
        '
        'RButton
        '
        Me.RButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.RButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RButton.ForeColor = System.Drawing.Color.White
        Me.RButton.Location = New System.Drawing.Point(218, 208)
        Me.RButton.Margin = New System.Windows.Forms.Padding(2)
        Me.RButton.Name = "RButton"
        Me.RButton.Size = New System.Drawing.Size(38, 41)
        Me.RButton.TabIndex = 25
        Me.RButton.Text = "R"
        Me.RButton.UseVisualStyleBackColor = False
        '
        'IButton
        '
        Me.IButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.IButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.IButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.IButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IButton.ForeColor = System.Drawing.Color.White
        Me.IButton.Location = New System.Drawing.Point(92, 162)
        Me.IButton.Margin = New System.Windows.Forms.Padding(2)
        Me.IButton.Name = "IButton"
        Me.IButton.Size = New System.Drawing.Size(38, 41)
        Me.IButton.TabIndex = 16
        Me.IButton.Text = "I"
        Me.IButton.UseVisualStyleBackColor = False
        '
        'QButton
        '
        Me.QButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.QButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.QButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.QButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.QButton.ForeColor = System.Drawing.Color.White
        Me.QButton.Location = New System.Drawing.Point(176, 208)
        Me.QButton.Margin = New System.Windows.Forms.Padding(2)
        Me.QButton.Name = "QButton"
        Me.QButton.Size = New System.Drawing.Size(38, 41)
        Me.QButton.TabIndex = 24
        Me.QButton.Text = "Q"
        Me.QButton.UseVisualStyleBackColor = False
        '
        'HButton
        '
        Me.HButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.HButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.HButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HButton.ForeColor = System.Drawing.Color.White
        Me.HButton.Location = New System.Drawing.Point(50, 162)
        Me.HButton.Margin = New System.Windows.Forms.Padding(2)
        Me.HButton.Name = "HButton"
        Me.HButton.Size = New System.Drawing.Size(38, 41)
        Me.HButton.TabIndex = 15
        Me.HButton.Text = "H"
        Me.HButton.UseVisualStyleBackColor = False
        '
        'PButton
        '
        Me.PButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.PButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PButton.ForeColor = System.Drawing.Color.White
        Me.PButton.Location = New System.Drawing.Point(133, 208)
        Me.PButton.Margin = New System.Windows.Forms.Padding(2)
        Me.PButton.Name = "PButton"
        Me.PButton.Size = New System.Drawing.Size(38, 41)
        Me.PButton.TabIndex = 23
        Me.PButton.Text = "P"
        Me.PButton.UseVisualStyleBackColor = False
        '
        'GButton
        '
        Me.GButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.GButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GButton.ForeColor = System.Drawing.Color.White
        Me.GButton.Location = New System.Drawing.Point(8, 162)
        Me.GButton.Margin = New System.Windows.Forms.Padding(2)
        Me.GButton.Name = "GButton"
        Me.GButton.Size = New System.Drawing.Size(38, 41)
        Me.GButton.TabIndex = 14
        Me.GButton.Text = "G"
        Me.GButton.UseVisualStyleBackColor = False
        '
        'OButton
        '
        Me.OButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.OButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.OButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.OButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OButton.ForeColor = System.Drawing.Color.White
        Me.OButton.Location = New System.Drawing.Point(91, 208)
        Me.OButton.Margin = New System.Windows.Forms.Padding(2)
        Me.OButton.Name = "OButton"
        Me.OButton.Size = New System.Drawing.Size(38, 41)
        Me.OButton.TabIndex = 22
        Me.OButton.Text = "O"
        Me.OButton.UseVisualStyleBackColor = False
        '
        'KButton
        '
        Me.KButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.KButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.KButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.KButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KButton.ForeColor = System.Drawing.Color.White
        Me.KButton.Location = New System.Drawing.Point(176, 162)
        Me.KButton.Margin = New System.Windows.Forms.Padding(2)
        Me.KButton.Name = "KButton"
        Me.KButton.Size = New System.Drawing.Size(38, 41)
        Me.KButton.TabIndex = 18
        Me.KButton.Text = "K"
        Me.KButton.UseVisualStyleBackColor = False
        '
        'NButton
        '
        Me.NButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.NButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.NButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NButton.ForeColor = System.Drawing.Color.White
        Me.NButton.Location = New System.Drawing.Point(50, 208)
        Me.NButton.Margin = New System.Windows.Forms.Padding(2)
        Me.NButton.Name = "NButton"
        Me.NButton.Size = New System.Drawing.Size(38, 41)
        Me.NButton.TabIndex = 21
        Me.NButton.Text = "N"
        Me.NButton.UseVisualStyleBackColor = False
        '
        'LButton
        '
        Me.LButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.LButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LButton.ForeColor = System.Drawing.Color.White
        Me.LButton.Location = New System.Drawing.Point(218, 162)
        Me.LButton.Margin = New System.Windows.Forms.Padding(2)
        Me.LButton.Name = "LButton"
        Me.LButton.Size = New System.Drawing.Size(38, 41)
        Me.LButton.TabIndex = 19
        Me.LButton.Text = "L"
        Me.LButton.UseVisualStyleBackColor = False
        '
        'MButton
        '
        Me.MButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.MButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MButton.ForeColor = System.Drawing.Color.White
        Me.MButton.Location = New System.Drawing.Point(8, 208)
        Me.MButton.Margin = New System.Windows.Forms.Padding(2)
        Me.MButton.Name = "MButton"
        Me.MButton.Size = New System.Drawing.Size(38, 41)
        Me.MButton.TabIndex = 20
        Me.MButton.Text = "M"
        Me.MButton.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.AllowDrop = True
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Panel2.Location = New System.Drawing.Point(-2, -2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(617, 33)
        Me.Panel2.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 8)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(336, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hangman - Oscar Costa - Task 2 - Part B"
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Font = New System.Drawing.Font("MV Boli", 12.0!)
        Me.StatusLabel.Location = New System.Drawing.Point(332, 38)
        Me.StatusLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(141, 21)
        Me.StatusLabel.TabIndex = 34
        Me.StatusLabel.Text = "GuessStatusLabel"
        '
        'DebuggingLabel
        '
        Me.DebuggingLabel.AutoSize = True
        Me.DebuggingLabel.Font = New System.Drawing.Font("MV Boli", 12.0!)
        Me.DebuggingLabel.Location = New System.Drawing.Point(507, 38)
        Me.DebuggingLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DebuggingLabel.Name = "DebuggingLabel"
        Me.DebuggingLabel.Size = New System.Drawing.Size(84, 21)
        Me.DebuggingLabel.TabIndex = 45
        Me.DebuggingLabel.Text = "Debugging"
        '
        'MenuButton
        '
        Me.MenuButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MenuButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.MenuButton.Location = New System.Drawing.Point(10, 38)
        Me.MenuButton.Margin = New System.Windows.Forms.Padding(2)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(130, 22)
        Me.MenuButton.TabIndex = 47
        Me.MenuButton.Text = "Menu"
        Me.MenuButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ResetButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.ResetButton.Location = New System.Drawing.Point(145, 38)
        Me.ResetButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(129, 22)
        Me.ResetButton.TabIndex = 48
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'OutputLabel
        '
        Me.OutputLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputLabel.AutoSize = True
        Me.OutputLabel.Font = New System.Drawing.Font("Gill Sans MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputLabel.Location = New System.Drawing.Point(41, 426)
        Me.OutputLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.OutputLabel.Name = "OutputLabel"
        Me.OutputLabel.Size = New System.Drawing.Size(222, 45)
        Me.OutputLabel.TabIndex = 49
        Me.OutputLabel.Text = "OutputString"
        '
        'HintsLabel
        '
        Me.HintsLabel.AutoSize = True
        Me.HintsLabel.Location = New System.Drawing.Point(29, 441)
        Me.HintsLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HintsLabel.Name = "HintsLabel"
        Me.HintsLabel.Size = New System.Drawing.Size(0, 13)
        Me.HintsLabel.TabIndex = 35
        '
        'Hangman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(611, 483)
        Me.Controls.Add(Me.HintsLabel)
        Me.Controls.Add(Me.OutputLabel)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.MenuButton)
        Me.Controls.Add(Me.DebuggingLabel)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.HangmanPicture)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Hangman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hangman - Oscar Costa - YR11"
        CType(Me.HangmanPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GuessesAlready As Label
    Friend WithEvents HangmanPicture As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents AButton As Button
    Friend WithEvents EButton As Button
    Friend WithEvents DButton As Button
    Friend WithEvents CButton As Button
    Friend WithEvents BButton As Button
    Friend WithEvents FButton As Button
    Friend WithEvents LButton As Button
    Friend WithEvents KButton As Button
    Friend WithEvents JButton As Button
    Friend WithEvents IButton As Button
    Friend WithEvents HButton As Button
    Friend WithEvents GButton As Button
    Friend WithEvents RButton As Button
    Friend WithEvents QButton As Button
    Friend WithEvents PButton As Button
    Friend WithEvents OButton As Button
    Friend WithEvents NButton As Button
    Friend WithEvents MButton As Button
    Friend WithEvents XButton As Button
    Friend WithEvents WButton As Button
    Friend WithEvents VButton As Button
    Friend WithEvents UButton As Button
    Friend WithEvents TButton As Button
    Friend WithEvents SButton As Button
    Friend WithEvents ZButton As Button
    Friend WithEvents YButton As Button
    Friend WithEvents StatusLabel As Label
    Friend WithEvents GuessedAlready As Label
    Friend WithEvents DebuggingLabel As Label
    Friend WithEvents MenuButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents OutputLabel As Label
    Friend WithEvents HintsLabel As Label
End Class
