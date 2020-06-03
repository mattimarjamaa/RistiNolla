Option Strict Off
Option Explicit On
Friend Class PL
	Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
		If m_vb6FormDefInstance Is Nothing Then
			If m_InitializingDefInstance Then
				m_vb6FormDefInstance = Me
			Else
				Try 
					'For the start-up form, the first instance created is the default instance.
					If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
						m_vb6FormDefInstance = Me
					End If
				Catch
				End Try
			End If
		End If
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents C_KonePeli As System.Windows.Forms.PictureBox
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents _Pic_2 As System.Windows.Forms.PictureBox
	Public WithEvents _Pic_3 As System.Windows.Forms.PictureBox
	Public WithEvents _Pic_0 As System.Windows.Forms.PictureBox
	Public WithEvents _Pic_1 As System.Windows.Forms.PictureBox
	Public WithEvents Score As System.Windows.Forms.Label
	Public WithEvents Vuorossa_Pic As System.Windows.Forms.Panel
	Public WithEvents T_Pic As System.Windows.Forms.PictureBox
	Public WithEvents _Merkki_8 As System.Windows.Forms.PictureBox
	Public WithEvents _Merkki_7 As System.Windows.Forms.PictureBox
	Public WithEvents _Merkki_6 As System.Windows.Forms.PictureBox
	Public WithEvents _Merkki_5 As System.Windows.Forms.PictureBox
	Public WithEvents _Merkki_4 As System.Windows.Forms.PictureBox
	Public WithEvents _Merkki_3 As System.Windows.Forms.PictureBox
	Public WithEvents _Merkki_2 As System.Windows.Forms.PictureBox
	Public WithEvents _Merkki_1 As System.Windows.Forms.PictureBox
	Public WithEvents _Merkki_0 As System.Windows.Forms.PictureBox
	Public WithEvents Logo As System.Windows.Forms.PictureBox
	Public WithEvents C_UusiPeli As System.Windows.Forms.PictureBox
	Public WithEvents Exit_Renamed As System.Windows.Forms.PictureBox
	Public WithEvents Line4 As System.Windows.Forms.Label
	Public WithEvents Line1 As System.Windows.Forms.Label
	Public WithEvents Line2 As System.Windows.Forms.Label
	Public WithEvents Line3 As System.Windows.Forms.Label
	Public WithEvents Merkki As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
	Public WithEvents Pic As Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PL))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.C_KonePeli = New System.Windows.Forms.PictureBox
		Me.Timer1 = New System.Windows.Forms.Timer(components)
		Me._Pic_2 = New System.Windows.Forms.PictureBox
		Me._Pic_3 = New System.Windows.Forms.PictureBox
		Me._Pic_0 = New System.Windows.Forms.PictureBox
		Me._Pic_1 = New System.Windows.Forms.PictureBox
		Me.Vuorossa_Pic = New System.Windows.Forms.Panel
		Me.Score = New System.Windows.Forms.Label
		Me.T_Pic = New System.Windows.Forms.PictureBox
		Me._Merkki_8 = New System.Windows.Forms.PictureBox
		Me._Merkki_7 = New System.Windows.Forms.PictureBox
		Me._Merkki_6 = New System.Windows.Forms.PictureBox
		Me._Merkki_5 = New System.Windows.Forms.PictureBox
		Me._Merkki_4 = New System.Windows.Forms.PictureBox
		Me._Merkki_3 = New System.Windows.Forms.PictureBox
		Me._Merkki_2 = New System.Windows.Forms.PictureBox
		Me._Merkki_1 = New System.Windows.Forms.PictureBox
		Me._Merkki_0 = New System.Windows.Forms.PictureBox
		Me.Logo = New System.Windows.Forms.PictureBox
		Me.C_UusiPeli = New System.Windows.Forms.PictureBox
		Me.Exit_Renamed = New System.Windows.Forms.PictureBox
		Me.Line4 = New System.Windows.Forms.Label
		Me.Line1 = New System.Windows.Forms.Label
		Me.Line2 = New System.Windows.Forms.Label
		Me.Line3 = New System.Windows.Forms.Label
		Me.Merkki = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(components)
		Me.Pic = New Microsoft.VisualBasic.Compatibility.VB6.PictureBoxArray(components)
		CType(Me.Merkki, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Pic, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Text = "Form1"
		Me.ClientSize = New System.Drawing.Size(450, 435)
		Me.Location = New System.Drawing.Point(0, 0)
		Me.ControlBox = False
		Me.Font = New System.Drawing.Font("Comic Sans MS", 24!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.AutoScaleBaseSize = New System.Drawing.Size(17, 45)
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "PL"
		Me.C_KonePeli.BackColor = System.Drawing.Color.Black
		Me.C_KonePeli.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.C_KonePeli.ForeColor = System.Drawing.SystemColors.WindowText
		Me.C_KonePeli.Size = New System.Drawing.Size(152, 52)
		Me.C_KonePeli.Location = New System.Drawing.Point(243, 90)
		Me.C_KonePeli.Image = CType(resources.GetObject("C_KonePeli.Image"), System.Drawing.Image)
		Me.C_KonePeli.TabIndex = 19
		Me.C_KonePeli.Dock = System.Windows.Forms.DockStyle.None
		Me.C_KonePeli.CausesValidation = True
		Me.C_KonePeli.Enabled = True
		Me.C_KonePeli.Cursor = System.Windows.Forms.Cursors.Default
		Me.C_KonePeli.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.C_KonePeli.TabStop = True
		Me.C_KonePeli.Visible = True
		Me.C_KonePeli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.C_KonePeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.C_KonePeli.Name = "C_KonePeli"
		Me.Timer1.Enabled = False
		Me.Timer1.Interval = 1000
		Me._Pic_2.BackColor = System.Drawing.SystemColors.Window
		Me._Pic_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Pic_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Pic_2.Size = New System.Drawing.Size(50, 50)
		Me._Pic_2.Location = New System.Drawing.Point(369, 315)
		Me._Pic_2.Image = CType(resources.GetObject("_Pic_2.Image"), System.Drawing.Image)
		Me._Pic_2.TabIndex = 18
		Me._Pic_2.Visible = False
		Me._Pic_2.Dock = System.Windows.Forms.DockStyle.None
		Me._Pic_2.CausesValidation = True
		Me._Pic_2.Enabled = True
		Me._Pic_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._Pic_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Pic_2.TabStop = True
		Me._Pic_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me._Pic_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Pic_2.Name = "_Pic_2"
		Me._Pic_3.BackColor = System.Drawing.SystemColors.Window
		Me._Pic_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Pic_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Pic_3.Size = New System.Drawing.Size(50, 50)
		Me._Pic_3.Location = New System.Drawing.Point(18, 297)
		Me._Pic_3.Image = CType(resources.GetObject("_Pic_3.Image"), System.Drawing.Image)
		Me._Pic_3.TabIndex = 17
		Me._Pic_3.Visible = False
		Me._Pic_3.Dock = System.Windows.Forms.DockStyle.None
		Me._Pic_3.CausesValidation = True
		Me._Pic_3.Enabled = True
		Me._Pic_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._Pic_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Pic_3.TabStop = True
		Me._Pic_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me._Pic_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Pic_3.Name = "_Pic_3"
		Me._Pic_0.BackColor = System.Drawing.SystemColors.Window
		Me._Pic_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Pic_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Pic_0.Size = New System.Drawing.Size(50, 50)
		Me._Pic_0.Location = New System.Drawing.Point(396, 36)
		Me._Pic_0.Image = CType(resources.GetObject("_Pic_0.Image"), System.Drawing.Image)
		Me._Pic_0.TabIndex = 1
		Me._Pic_0.Dock = System.Windows.Forms.DockStyle.None
		Me._Pic_0.CausesValidation = True
		Me._Pic_0.Enabled = True
		Me._Pic_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._Pic_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Pic_0.TabStop = True
		Me._Pic_0.Visible = True
		Me._Pic_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me._Pic_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Pic_0.Name = "_Pic_0"
		Me._Pic_1.BackColor = System.Drawing.SystemColors.Window
		Me._Pic_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Pic_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._Pic_1.Size = New System.Drawing.Size(50, 50)
		Me._Pic_1.Location = New System.Drawing.Point(9, 36)
		Me._Pic_1.Image = CType(resources.GetObject("_Pic_1.Image"), System.Drawing.Image)
		Me._Pic_1.TabIndex = 2
		Me._Pic_1.Dock = System.Windows.Forms.DockStyle.None
		Me._Pic_1.CausesValidation = True
		Me._Pic_1.Enabled = True
		Me._Pic_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._Pic_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Pic_1.TabStop = True
		Me._Pic_1.Visible = True
		Me._Pic_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me._Pic_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Pic_1.Name = "_Pic_1"
		Me.Vuorossa_Pic.BackColor = System.Drawing.SystemColors.Window
		Me.Vuorossa_Pic.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Vuorossa_Pic.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Vuorossa_Pic.Size = New System.Drawing.Size(350, 50)
		Me.Vuorossa_Pic.Location = New System.Drawing.Point(45, 378)
		Me.Vuorossa_Pic.BackgroundImage = CType(resources.GetObject("Vuorossa_Pic.BackgroundImage"), System.Drawing.Image)
		Me.Vuorossa_Pic.TabIndex = 15
		Me.Vuorossa_Pic.Dock = System.Windows.Forms.DockStyle.None
		Me.Vuorossa_Pic.CausesValidation = True
		Me.Vuorossa_Pic.Enabled = True
		Me.Vuorossa_Pic.Cursor = System.Windows.Forms.Cursors.Default
		Me.Vuorossa_Pic.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Vuorossa_Pic.TabStop = True
		Me.Vuorossa_Pic.Visible = True
		Me.Vuorossa_Pic.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Vuorossa_Pic.Name = "Vuorossa_Pic"
		Me.Score.BackColor = System.Drawing.Color.Transparent
		Me.Score.Text = "0"
		Me.Score.Font = New System.Drawing.Font("Arial", 24!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Score.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Score.Size = New System.Drawing.Size(91, 37)
		Me.Score.Location = New System.Drawing.Point(216, 9)
		Me.Score.TabIndex = 16
		Me.Score.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Score.Enabled = True
		Me.Score.Cursor = System.Windows.Forms.Cursors.Default
		Me.Score.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Score.UseMnemonic = True
		Me.Score.Visible = True
		Me.Score.AutoSize = False
		Me.Score.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Score.Name = "Score"
		Me.T_Pic.BackColor = System.Drawing.SystemColors.Window
		Me.T_Pic.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.T_Pic.ForeColor = System.Drawing.SystemColors.WindowText
		Me.T_Pic.Size = New System.Drawing.Size(50, 50)
		Me.T_Pic.Location = New System.Drawing.Point(360, 252)
		Me.T_Pic.Image = CType(resources.GetObject("T_Pic.Image"), System.Drawing.Image)
		Me.T_Pic.TabIndex = 11
		Me.T_Pic.Visible = False
		Me.T_Pic.Dock = System.Windows.Forms.DockStyle.None
		Me.T_Pic.CausesValidation = True
		Me.T_Pic.Enabled = True
		Me.T_Pic.Cursor = System.Windows.Forms.Cursors.Default
		Me.T_Pic.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.T_Pic.TabStop = True
		Me.T_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.T_Pic.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.T_Pic.Name = "T_Pic"
		Me._Merkki_8.BackColor = System.Drawing.SystemColors.Window
		Me._Merkki_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Merkki_8.ForeColor = System.Drawing.Color.Yellow
		Me._Merkki_8.Size = New System.Drawing.Size(50, 50)
		Me._Merkki_8.Location = New System.Drawing.Point(261, 306)
		Me._Merkki_8.Image = CType(resources.GetObject("_Merkki_8.Image"), System.Drawing.Image)
		Me._Merkki_8.TabIndex = 10
		Me._Merkki_8.Dock = System.Windows.Forms.DockStyle.None
		Me._Merkki_8.CausesValidation = True
		Me._Merkki_8.Enabled = True
		Me._Merkki_8.Cursor = System.Windows.Forms.Cursors.Default
		Me._Merkki_8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Merkki_8.TabStop = True
		Me._Merkki_8.Visible = True
		Me._Merkki_8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me._Merkki_8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Merkki_8.Name = "_Merkki_8"
		Me._Merkki_7.BackColor = System.Drawing.SystemColors.Window
		Me._Merkki_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Merkki_7.ForeColor = System.Drawing.Color.Yellow
		Me._Merkki_7.Size = New System.Drawing.Size(50, 50)
		Me._Merkki_7.Location = New System.Drawing.Point(189, 306)
		Me._Merkki_7.Image = CType(resources.GetObject("_Merkki_7.Image"), System.Drawing.Image)
		Me._Merkki_7.TabIndex = 9
		Me._Merkki_7.Dock = System.Windows.Forms.DockStyle.None
		Me._Merkki_7.CausesValidation = True
		Me._Merkki_7.Enabled = True
		Me._Merkki_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._Merkki_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Merkki_7.TabStop = True
		Me._Merkki_7.Visible = True
		Me._Merkki_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me._Merkki_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Merkki_7.Name = "_Merkki_7"
		Me._Merkki_6.BackColor = System.Drawing.SystemColors.Window
		Me._Merkki_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Merkki_6.ForeColor = System.Drawing.Color.Yellow
		Me._Merkki_6.Size = New System.Drawing.Size(50, 50)
		Me._Merkki_6.Location = New System.Drawing.Point(117, 306)
		Me._Merkki_6.Image = CType(resources.GetObject("_Merkki_6.Image"), System.Drawing.Image)
		Me._Merkki_6.TabIndex = 8
		Me._Merkki_6.Dock = System.Windows.Forms.DockStyle.None
		Me._Merkki_6.CausesValidation = True
		Me._Merkki_6.Enabled = True
		Me._Merkki_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._Merkki_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Merkki_6.TabStop = True
		Me._Merkki_6.Visible = True
		Me._Merkki_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me._Merkki_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Merkki_6.Name = "_Merkki_6"
		Me._Merkki_5.BackColor = System.Drawing.SystemColors.Window
		Me._Merkki_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Merkki_5.ForeColor = System.Drawing.Color.Yellow
		Me._Merkki_5.Size = New System.Drawing.Size(50, 50)
		Me._Merkki_5.Location = New System.Drawing.Point(261, 234)
		Me._Merkki_5.Image = CType(resources.GetObject("_Merkki_5.Image"), System.Drawing.Image)
		Me._Merkki_5.TabIndex = 7
		Me._Merkki_5.Dock = System.Windows.Forms.DockStyle.None
		Me._Merkki_5.CausesValidation = True
		Me._Merkki_5.Enabled = True
		Me._Merkki_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._Merkki_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Merkki_5.TabStop = True
		Me._Merkki_5.Visible = True
		Me._Merkki_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me._Merkki_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Merkki_5.Name = "_Merkki_5"
		Me._Merkki_4.BackColor = System.Drawing.SystemColors.Window
		Me._Merkki_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Merkki_4.ForeColor = System.Drawing.Color.Yellow
		Me._Merkki_4.Size = New System.Drawing.Size(50, 50)
		Me._Merkki_4.Location = New System.Drawing.Point(189, 234)
		Me._Merkki_4.Image = CType(resources.GetObject("_Merkki_4.Image"), System.Drawing.Image)
		Me._Merkki_4.TabIndex = 6
		Me._Merkki_4.Dock = System.Windows.Forms.DockStyle.None
		Me._Merkki_4.CausesValidation = True
		Me._Merkki_4.Enabled = True
		Me._Merkki_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._Merkki_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Merkki_4.TabStop = True
		Me._Merkki_4.Visible = True
		Me._Merkki_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me._Merkki_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Merkki_4.Name = "_Merkki_4"
		Me._Merkki_3.BackColor = System.Drawing.SystemColors.Window
		Me._Merkki_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Merkki_3.ForeColor = System.Drawing.Color.Yellow
		Me._Merkki_3.Size = New System.Drawing.Size(50, 50)
		Me._Merkki_3.Location = New System.Drawing.Point(117, 234)
		Me._Merkki_3.Image = CType(resources.GetObject("_Merkki_3.Image"), System.Drawing.Image)
		Me._Merkki_3.TabIndex = 5
		Me._Merkki_3.Dock = System.Windows.Forms.DockStyle.None
		Me._Merkki_3.CausesValidation = True
		Me._Merkki_3.Enabled = True
		Me._Merkki_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._Merkki_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Merkki_3.TabStop = True
		Me._Merkki_3.Visible = True
		Me._Merkki_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me._Merkki_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Merkki_3.Name = "_Merkki_3"
		Me._Merkki_2.BackColor = System.Drawing.SystemColors.Window
		Me._Merkki_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Merkki_2.ForeColor = System.Drawing.Color.Yellow
		Me._Merkki_2.Size = New System.Drawing.Size(50, 50)
		Me._Merkki_2.Location = New System.Drawing.Point(261, 162)
		Me._Merkki_2.Image = CType(resources.GetObject("_Merkki_2.Image"), System.Drawing.Image)
		Me._Merkki_2.TabIndex = 4
		Me._Merkki_2.Dock = System.Windows.Forms.DockStyle.None
		Me._Merkki_2.CausesValidation = True
		Me._Merkki_2.Enabled = True
		Me._Merkki_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._Merkki_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Merkki_2.TabStop = True
		Me._Merkki_2.Visible = True
		Me._Merkki_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me._Merkki_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Merkki_2.Name = "_Merkki_2"
		Me._Merkki_1.BackColor = System.Drawing.SystemColors.Window
		Me._Merkki_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Merkki_1.ForeColor = System.Drawing.Color.Yellow
		Me._Merkki_1.Size = New System.Drawing.Size(50, 50)
		Me._Merkki_1.Location = New System.Drawing.Point(189, 162)
		Me._Merkki_1.Image = CType(resources.GetObject("_Merkki_1.Image"), System.Drawing.Image)
		Me._Merkki_1.TabIndex = 3
		Me._Merkki_1.Dock = System.Windows.Forms.DockStyle.None
		Me._Merkki_1.CausesValidation = True
		Me._Merkki_1.Enabled = True
		Me._Merkki_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._Merkki_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Merkki_1.TabStop = True
		Me._Merkki_1.Visible = True
		Me._Merkki_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me._Merkki_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Merkki_1.Name = "_Merkki_1"
		Me._Merkki_0.BackColor = System.Drawing.SystemColors.Window
		Me._Merkki_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Merkki_0.ForeColor = System.Drawing.Color.Yellow
		Me._Merkki_0.Size = New System.Drawing.Size(50, 50)
		Me._Merkki_0.Location = New System.Drawing.Point(117, 162)
		Me._Merkki_0.Image = CType(resources.GetObject("_Merkki_0.Image"), System.Drawing.Image)
		Me._Merkki_0.TabIndex = 0
		Me._Merkki_0.Dock = System.Windows.Forms.DockStyle.None
		Me._Merkki_0.CausesValidation = True
		Me._Merkki_0.Enabled = True
		Me._Merkki_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._Merkki_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Merkki_0.TabStop = True
		Me._Merkki_0.Visible = True
		Me._Merkki_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me._Merkki_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Merkki_0.Name = "_Merkki_0"
		Me.Logo.BackColor = System.Drawing.SystemColors.Window
		Me.Logo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Logo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Logo.Size = New System.Drawing.Size(348, 49)
		Me.Logo.Location = New System.Drawing.Point(54, 36)
		Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
		Me.Logo.TabIndex = 14
		Me.Logo.Dock = System.Windows.Forms.DockStyle.None
		Me.Logo.CausesValidation = True
		Me.Logo.Enabled = True
		Me.Logo.Cursor = System.Windows.Forms.Cursors.Default
		Me.Logo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Logo.TabStop = True
		Me.Logo.Visible = True
		Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.Logo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Logo.Name = "Logo"
		Me.C_UusiPeli.BackColor = System.Drawing.SystemColors.Window
		Me.C_UusiPeli.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.C_UusiPeli.ForeColor = System.Drawing.SystemColors.WindowText
		Me.C_UusiPeli.Size = New System.Drawing.Size(150, 50)
		Me.C_UusiPeli.Location = New System.Drawing.Point(63, 90)
		Me.C_UusiPeli.Image = CType(resources.GetObject("C_UusiPeli.Image"), System.Drawing.Image)
		Me.C_UusiPeli.TabIndex = 13
		Me.C_UusiPeli.Dock = System.Windows.Forms.DockStyle.None
		Me.C_UusiPeli.CausesValidation = True
		Me.C_UusiPeli.Enabled = True
		Me.C_UusiPeli.Cursor = System.Windows.Forms.Cursors.Default
		Me.C_UusiPeli.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.C_UusiPeli.TabStop = True
		Me.C_UusiPeli.Visible = True
		Me.C_UusiPeli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.C_UusiPeli.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.C_UusiPeli.Name = "C_UusiPeli"
		Me.Exit_Renamed.BackColor = System.Drawing.Color.Black
		Me.Exit_Renamed.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Exit_Renamed.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Exit_Renamed.Size = New System.Drawing.Size(22, 22)
		Me.Exit_Renamed.Location = New System.Drawing.Point(423, 9)
		Me.Exit_Renamed.Image = CType(resources.GetObject("Exit.Image"), System.Drawing.Image)
		Me.Exit_Renamed.TabIndex = 12
		Me.Exit_Renamed.Dock = System.Windows.Forms.DockStyle.None
		Me.Exit_Renamed.CausesValidation = True
		Me.Exit_Renamed.Enabled = True
		Me.Exit_Renamed.Cursor = System.Windows.Forms.Cursors.Default
		Me.Exit_Renamed.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Exit_Renamed.TabStop = True
		Me.Exit_Renamed.Visible = True
		Me.Exit_Renamed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.Exit_Renamed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Exit_Renamed.Name = "Exit_Renamed"
		Me.Line4.BackColor = System.Drawing.Color.FromARGB(192, 192, 0)
		Me.Line4.Visible = True
		Me.Line4.Location = New System.Drawing.Point(99, 297)
		Me.Line4.Width = 234
		Me.Line4.Height = 1
		Me.Line4.Name = "Line4"
		Me.Line1.BackColor = System.Drawing.Color.FromARGB(192, 192, 0)
		Me.Line1.Visible = True
		Me.Line1.Location = New System.Drawing.Point(180, 144)
		Me.Line1.Width = 1
		Me.Line1.Height = 234
		Me.Line1.Name = "Line1"
		Me.Line2.BackColor = System.Drawing.Color.FromARGB(192, 192, 0)
		Me.Line2.Visible = True
		Me.Line2.Location = New System.Drawing.Point(252, 144)
		Me.Line2.Width = 1
		Me.Line2.Height = 234
		Me.Line2.Name = "Line2"
		Me.Line3.BackColor = System.Drawing.Color.FromARGB(192, 192, 0)
		Me.Line3.Visible = True
		Me.Line3.Location = New System.Drawing.Point(99, 225)
		Me.Line3.Width = 234
		Me.Line3.Height = 1
		Me.Line3.Name = "Line3"
		Me.Controls.Add(C_KonePeli)
		Me.Controls.Add(_Pic_2)
		Me.Controls.Add(_Pic_3)
		Me.Controls.Add(_Pic_0)
		Me.Controls.Add(_Pic_1)
		Me.Controls.Add(Vuorossa_Pic)
		Me.Controls.Add(T_Pic)
		Me.Controls.Add(_Merkki_8)
		Me.Controls.Add(_Merkki_7)
		Me.Controls.Add(_Merkki_6)
		Me.Controls.Add(_Merkki_5)
		Me.Controls.Add(_Merkki_4)
		Me.Controls.Add(_Merkki_3)
		Me.Controls.Add(_Merkki_2)
		Me.Controls.Add(_Merkki_1)
		Me.Controls.Add(_Merkki_0)
		Me.Controls.Add(Logo)
		Me.Controls.Add(C_UusiPeli)
		Me.Controls.Add(Exit_Renamed)
		Me.Controls.Add(Line4)
		Me.Controls.Add(Line1)
		Me.Controls.Add(Line2)
		Me.Controls.Add(Line3)
		Me.Vuorossa_Pic.Controls.Add(Score)
		Me.Merkki.SetIndex(_Merkki_8, CType(8, Short))
		Me.Merkki.SetIndex(_Merkki_7, CType(7, Short))
		Me.Merkki.SetIndex(_Merkki_6, CType(6, Short))
		Me.Merkki.SetIndex(_Merkki_5, CType(5, Short))
		Me.Merkki.SetIndex(_Merkki_4, CType(4, Short))
		Me.Merkki.SetIndex(_Merkki_3, CType(3, Short))
		Me.Merkki.SetIndex(_Merkki_2, CType(2, Short))
		Me.Merkki.SetIndex(_Merkki_1, CType(1, Short))
		Me.Merkki.SetIndex(_Merkki_0, CType(0, Short))
		Me.Pic.SetIndex(_Pic_2, CType(2, Short))
		Me.Pic.SetIndex(_Pic_3, CType(3, Short))
		Me.Pic.SetIndex(_Pic_0, CType(0, Short))
		Me.Pic.SetIndex(_Pic_1, CType(1, Short))
		CType(Me.Pic, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Merkki, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As PL
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As PL
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New PL()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	
	Private Sub Exit_Renamed_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Exit_Renamed.Click
		End
	End Sub
	
	Private Sub PL_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Alkuarvot()
	End Sub
	
	Private Sub Merkki_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Merkki.Click
		Dim Index As Short = Merkki.GetIndex(eventSender)
		If GameOver Or Vuorossa = Kone Then Exit Sub
		Y = Index / 4
		X = Index - Y * 3
		If K(X, Y) <> -1 Then Exit Sub
		Aseta(X, Y, Index)
		TarkistaSiirto()
		For I = 1 To 8
			If A(I, Vuorossa) = 3 Then N‰yt‰Suora(I) : GameOver = True : Exit For
		Next I
		If Not GameOver Then SeuraavaPelaaja()
	End Sub
	
	Private Sub C_KonePeli_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles C_KonePeli.Click
		UusiKonepeli()
	End Sub
	
	Private Sub C_UusiPeli_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles C_UusiPeli.Click
		UusiPeli()
	End Sub
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
		Timer1.Enabled = False
		KoneenSiirto()
		TarkistaSiirto()
		For I = 1 To 8
			If A(I, Vuorossa) = 3 Then N‰yt‰Suora(I) : GameOver = True : Exit For
		Next I
		If Not GameOver Then SeuraavaPelaaja()
	End Sub
End Class