<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Duper
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListDriveView = New System.Windows.Forms.ListView()
        Me.ColDrive = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColNaam = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColGrootte = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColVrij = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAddSource = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LstTarget = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAddTarget = New System.Windows.Forms.Button()
        Me.btnRemoveTarget = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtSource = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Dupe = New System.Windows.Forms.Button()
        Me.lblUSB = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblRunning = New System.Windows.Forms.Label()
        Me.FormatFirst = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListDriveView
        '
        Me.ListDriveView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListDriveView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColDrive, Me.ColType, Me.ColNaam, Me.ColGrootte, Me.ColVrij})
        Me.ListDriveView.Cursor = System.Windows.Forms.Cursors.Default
        Me.ListDriveView.ForeColor = System.Drawing.Color.Black
        Me.ListDriveView.FullRowSelect = True
        Me.ListDriveView.GridLines = True
        Me.ListDriveView.HideSelection = False
        Me.ListDriveView.Location = New System.Drawing.Point(29, 36)
        Me.ListDriveView.Name = "ListDriveView"
        Me.ListDriveView.Size = New System.Drawing.Size(507, 560)
        Me.ListDriveView.TabIndex = 3
        Me.ListDriveView.UseCompatibleStateImageBehavior = False
        Me.ListDriveView.View = System.Windows.Forms.View.Details
        '
        'ColDrive
        '
        Me.ColDrive.Text = "Drive"
        Me.ColDrive.Width = 50
        '
        'ColType
        '
        Me.ColType.Text = "Type"
        Me.ColType.Width = 96
        '
        'ColNaam
        '
        Me.ColNaam.Text = "Name"
        Me.ColNaam.Width = 175
        '
        'ColGrootte
        '
        Me.ColGrootte.Text = "Size (GB)"
        Me.ColGrootte.Width = 100
        '
        'ColVrij
        '
        Me.ColVrij.Tag = ""
        Me.ColVrij.Text = "Free (GB)"
        Me.ColVrij.Width = 100
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(20, 601)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 25)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "refresh drives"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAddSource
        '
        Me.btnAddSource.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddSource.Location = New System.Drawing.Point(9, 76)
        Me.btnAddSource.Name = "btnAddSource"
        Me.btnAddSource.Size = New System.Drawing.Size(47, 23)
        Me.btnAddSource.TabIndex = 5
        Me.btnAddSource.Text = "->"
        Me.btnAddSource.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(80, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 31)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Source"
        '
        'LstTarget
        '
        Me.LstTarget.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LstTarget.FormattingEnabled = True
        Me.LstTarget.Location = New System.Drawing.Point(83, 55)
        Me.LstTarget.Name = "LstTarget"
        Me.LstTarget.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.LstTarget.Size = New System.Drawing.Size(120, 290)
        Me.LstTarget.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(52, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 31)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Destination"
        '
        'btnAddTarget
        '
        Me.btnAddTarget.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddTarget.Location = New System.Drawing.Point(10, 55)
        Me.btnAddTarget.Name = "btnAddTarget"
        Me.btnAddTarget.Size = New System.Drawing.Size(47, 23)
        Me.btnAddTarget.TabIndex = 10
        Me.btnAddTarget.Text = "->"
        Me.btnAddTarget.UseVisualStyleBackColor = True
        '
        'btnRemoveTarget
        '
        Me.btnRemoveTarget.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveTarget.Location = New System.Drawing.Point(10, 84)
        Me.btnRemoveTarget.Name = "btnRemoveTarget"
        Me.btnRemoveTarget.Size = New System.Drawing.Size(47, 23)
        Me.btnRemoveTarget.TabIndex = 11
        Me.btnRemoveTarget.Text = "<-"
        Me.btnRemoveTarget.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.TxtSource)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnAddSource)
        Me.Panel1.Location = New System.Drawing.Point(539, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(228, 108)
        Me.Panel1.TabIndex = 12
        '
        'TxtSource
        '
        Me.TxtSource.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSource.Location = New System.Drawing.Point(86, 79)
        Me.TxtSource.Name = "TxtSource"
        Me.TxtSource.ReadOnly = True
        Me.TxtSource.Size = New System.Drawing.Size(100, 20)
        Me.TxtSource.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.LstTarget)
        Me.Panel2.Controls.Add(Me.btnRemoveTarget)
        Me.Panel2.Controls.Add(Me.btnAddTarget)
        Me.Panel2.Location = New System.Drawing.Point(538, 192)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(224, 352)
        Me.Panel2.TabIndex = 13
        '
        'Dupe
        '
        Me.Dupe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dupe.Location = New System.Drawing.Point(538, 593)
        Me.Dupe.Margin = New System.Windows.Forms.Padding(2)
        Me.Dupe.Name = "Dupe"
        Me.Dupe.Size = New System.Drawing.Size(224, 47)
        Me.Dupe.TabIndex = 14
        Me.Dupe.Text = "DUPE!"
        Me.Dupe.UseVisualStyleBackColor = True
        '
        'lblUSB
        '
        Me.lblUSB.AutoSize = True
        Me.lblUSB.Location = New System.Drawing.Point(26, 10)
        Me.lblUSB.Name = "lblUSB"
        Me.lblUSB.Size = New System.Drawing.Size(29, 13)
        Me.lblUSB.TabIndex = 15
        Me.lblUSB.Text = "USB"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.USB_DUPE.My.Resources.Resources.logo_zonder_tekst
        Me.PictureBox1.Location = New System.Drawing.Point(586, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(637, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Campus Vesta 2023"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(637, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Peter Van den Broeck"
        '
        'LblRunning
        '
        Me.LblRunning.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblRunning.AutoSize = True
        Me.LblRunning.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRunning.ForeColor = System.Drawing.Color.Red
        Me.LblRunning.Location = New System.Drawing.Point(119, 604)
        Me.LblRunning.Name = "LblRunning"
        Me.LblRunning.Size = New System.Drawing.Size(60, 18)
        Me.LblRunning.TabIndex = 19
        Me.LblRunning.Text = "Ready."
        '
        'FormatFirst
        '
        Me.FormatFirst.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormatFirst.AutoSize = True
        Me.FormatFirst.Location = New System.Drawing.Point(548, 550)
        Me.FormatFirst.Name = "FormatFirst"
        Me.FormatFirst.Size = New System.Drawing.Size(108, 17)
        Me.FormatFirst.TabIndex = 20
        Me.FormatFirst.Text = "Format drives first"
        Me.FormatFirst.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(340, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Running as standard user."
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(662, 550)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(51, 17)
        Me.RadioButton1.TabIndex = 22
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "exFat"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(662, 571)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(53, 17)
        Me.RadioButton2.TabIndex = 23
        Me.RadioButton2.Text = "NTFS"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Duper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 649)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.FormatFirst)
        Me.Controls.Add(Me.LblRunning)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblUSB)
        Me.Controls.Add(Me.Dupe)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListDriveView)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Duper"
        Me.Text = "Duper"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents ListDriveView As ListView
    Private WithEvents ColDrive As ColumnHeader
    Private WithEvents ColNaam As ColumnHeader
    Private WithEvents ColGrootte As ColumnHeader
    Friend WithEvents Button1 As Button
    Friend WithEvents ColVrij As ColumnHeader
    Friend WithEvents ColType As ColumnHeader
    Friend WithEvents btnAddSource As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LstTarget As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAddTarget As Button
    Friend WithEvents btnRemoveTarget As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtSource As TextBox
    Friend WithEvents Dupe As Button
    Friend WithEvents lblUSB As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblRunning As Label
    Friend WithEvents FormatFirst As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
