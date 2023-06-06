Imports System.IO
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Diagnostics
Imports System.Security.Principal
Imports System.Runtime.InteropServices
Imports System.Diagnostics.Eventing.Reader
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports System.ComponentModel.Design
Imports System.Windows.Forms.VisualStyles
Imports System.Security.Cryptography

Public Class Duper

    Public aantalformatteringen As Integer = 0


    Public intNumberOfTasksRunning As Integer
    Public Structure Thread_Data
        Dim txtSource As String
        Dim txtDestination As String
        Dim blnQuiet As Boolean
        Dim blnRealTask As Boolean
    End Structure

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.MinimumSize = Me.Size
        Me.Checkdrives()
        If IsRunAsAdmin() = True Then
            Me.Label6.Text = "Running as Administrator"
        Else
            Me.Label6.Text = "Running as standard user"
        End If
    End Sub


    Public Function IsRunAsAdmin() As Boolean
        Dim identity As WindowsIdentity = WindowsIdentity.GetCurrent()
        Dim principal As WindowsPrincipal = New WindowsPrincipal(identity)
        Return principal.IsInRole(WindowsBuiltInRole.Administrator)
    End Function


    Sub New()

        InitializeComponent()
        lblUSB.BackColor = Color.LimeGreen
        lblUSB.Text = "USB changed"
        lblUSB.Parent = Me
    End Sub

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)
        If m.Msg = &H219 Then
            Console.WriteLine(m.ToString)
            If lblUSB.BackColor = Color.LimeGreen Then
                lblUSB.BackColor = Color.Red
            Else
                lblUSB.BackColor = Color.LimeGreen
            End If

            Me.Checkdrives()


        End If
    End Sub


    Private Sub Checkdrives()

        ListDriveView.Items.Clear()

        ' ListDriveView.Clear()
        Dim txtSize, txtFree As String
        Dim intTeller As Integer = 0
        Dim txtVolumeLabel As String
        Dim txtType As String = ""

        Dim allDrives() As DriveInfo = DriveInfo.GetDrives()
        Dim d As DriveInfo
        For Each d In allDrives
            Try
                txtSize = Math.Round((d.TotalSize / 1073741824), 2).ToString
            Catch
                txtSize = "unknown"
            End Try

            Try
                txtFree = Math.Round((d.AvailableFreeSpace / 1073741824), 2).ToString
            Catch
                txtFree = "unknown"
            End Try

            Try
                txtVolumeLabel = (d.VolumeLabel)
            Catch
                txtVolumeLabel = "unknown"
            End Try

            If d.DriveType = 0 Then
                txtType = "unknown"
            ElseIf d.DriveType = 1 Then
                txtType = "no RootDir"
            ElseIf d.DriveType = 2 Then
                txtType = "Removable"
            ElseIf d.DriveType = 3 Then
                txtType = "Harddisk / SSD"
            ElseIf d.DriveType = 4 Then
                txtType = "Network"
            ElseIf d.DriveType = 5 Then
                txtType = "CD / DVD"
            ElseIf d.DriveType = 6 Then
                txtType = "Ramdisk"
            End If

            Console.WriteLine(d.Name)

            ListDriveView.Items.Add(d.Name)
            ListDriveView.Items(intTeller).SubItems.Add(txtType)
            ListDriveView.Items(intTeller).SubItems.Add(txtVolumeLabel)
            ListDriveView.Items(intTeller).SubItems.Add(txtSize)
            ListDriveView.Items(intTeller).SubItems.Add(txtFree)

            intTeller += 1

        Next

        Me.Refresh()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Checkdrives()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAddSource.Click

        If ListDriveView.SelectedItems.Count > 0 Then
            TxtSource.Text = ListDriveView.SelectedItems.Item(0).Text
        End If
    End Sub

    Private Sub BtnAddTarget_Click(sender As Object, e As EventArgs) Handles btnAddTarget.Click

        If ListDriveView.SelectedItems.Count > 0 Then
            Dim itemNummer As Integer = 0

            For Each selectedItem In ListDriveView.SelectedItems

                'Al in de lijst? 
                If LstTarget.Items.Count > 0 Then
                    ' zoek of die al in target zit
                    If Not LstTarget.Items.Contains(ListDriveView.SelectedItems.Item(itemNummer).Text) Then
                        LstTarget.Items.Add(ListDriveView.SelectedItems.Item(itemNummer).Text)
                    End If
                Else
                    LstTarget.Items.Add(ListDriveView.SelectedItems.Item(itemNummer).Text)
                End If
                itemNummer += 1
            Next
            itemNummer = Nothing
        End If

    End Sub

    Private Sub BtnRemoveTarget_Click(sender As Object, e As EventArgs) Handles btnRemoveTarget.Click
        If LstTarget.SelectedItems.Count > 0 Then
            Do While LstTarget.SelectedItems.Count > 0
                LstTarget.Items.Remove(LstTarget.SelectedItems(0))
            Loop
        End If
    End Sub

    Private Sub Dupe_Click(sender As Object, e As EventArgs) Handles Dupe.Click
        Dim totalcopies As Integer
        totalcopies = LstTarget.Items.Count()
        intNumberOfTasksRunning = 0

        If FormatFirst.Checked Then
            If IsRunAsAdmin() Then

                Dim clsThreadsf As New Generic.List(Of System.Threading.Thread)

                Dim StThreadDataf(totalcopies) As Thread_Data

                For i As Integer = 0 To LstTarget.Items.Count - 1
                    clsThreadsf.Add(New System.Threading.Thread(AddressOf formatdrive))
                    StThreadDataf(i).blnQuiet = False
                    StThreadDataf(i).txtDestination = LstTarget.Items.Item(i)
                    intNumberOfTasksRunning += 1

                    clsThreadsf.Item(i).Start(StThreadDataf(i))
                    'CopyDirectory(StThreadData(i))

                Next

                Do While intNumberOfTasksRunning > 0
                    intNumberOfTasksRunning = 0
                    For teller As Integer = 0 To clsThreadsf.Count - 1
                        If clsThreadsf.Item(teller).IsAlive Then
                            intNumberOfTasksRunning += 1
                        End If
                    Next

                    Me.LblRunning.Text = "Patience: " & Str(intNumberOfTasksRunning) & " formatting tasks running. "
                    Me.LblRunning.Refresh()

                    Thread.Sleep(250)
                Loop

            Else
                MessageBox.Show("To format drives first, you must run this program as Administrator")
            End If
        End If

        If totalcopies > 0 Then

            Dim clsThreads As New Generic.List(Of System.Threading.Thread)

            Dim StThreadData(totalcopies) As Thread_Data

            For i As Integer = 0 To LstTarget.Items.Count - 1
                clsThreads.Add(New System.Threading.Thread(AddressOf CopyDirectory))
                StThreadData(i).blnQuiet = False
                StThreadData(i).txtDestination = LstTarget.Items.Item(i)
                StThreadData(i).txtSource = Me.TxtSource.Text
                intNumberOfTasksRunning += 1

                clsThreads.Item(i).Start(StThreadData(i))
                'CopyDirectory(StThreadData(i))

            Next


            intNumberOfTasksRunning = 1

            Do While intNumberOfTasksRunning > 0
                intNumberOfTasksRunning = 0
                For teller As Integer = 0 To clsThreads.Count - 1
                    If clsThreads.Item(teller).IsAlive Then
                        intNumberOfTasksRunning += 1
                    End If
                Next

                Me.LblRunning.Text = "Patience: " & Str(intNumberOfTasksRunning) & " copy tasks running. "
                Me.LblRunning.Refresh()

                Thread.Sleep(250)
            Loop


        End If

        Me.LblRunning.Text = "Ready."
        Me.LblRunning.Refresh()



    End Sub


    Public Sub formatdrive(trDataf)

        Dim drvletter As String = trDataf.txtDestination
        drvletter = drvletter.Substring(0, 2)


        Dim mcommand As String = ""
        Dim file As System.IO.StreamWriter

        Dim driveInfo As DriveInfo = New DriveInfo(drvletter)


        If driveInfo.DriveType = DriveType.Removable Then
            'create batch file  to format drive
            Dim filename As String = System.Guid.NewGuid.ToString() + ".cmd"
            Dim filepath As String = Path.GetTempPath
            Dim fullFile As String = filepath + filename
            Dim fullFile2 As String = filepath + System.Guid.NewGuid.ToString()

            file = My.Computer.FileSystem.OpenTextFileWriter(fullFile, True)
            If RadioButton1.Checked Then
                mcommand = "FORMAT " + drvletter.Substring(0, 2) + " /FS:exfat /v:USB /Q <" + fullFile2
            Else
                mcommand = "FORMAT " + drvletter.Substring(0, 2) + " /FS:NTFS /v:USB /Q <" + fullFile2
            End If
            file.WriteLine()
            file.WriteLine(mcommand)
            'file.WriteLine("pause")
            file.Close()

            file = My.Computer.FileSystem.OpenTextFileWriter(fullFile2, True)
            file.WriteLine()
            file.WriteLine()

            file.Close()

            Dim proc As System.Diagnostics.Process = New System.Diagnostics.Process()

            proc.EnableRaisingEvents = False

            proc.StartInfo.FileName = fullFile
            proc.StartInfo.Arguments = ""
            proc.Start()
            proc.WaitForExit()


            My.Computer.FileSystem.DeleteFile(fullFile)

            My.Computer.FileSystem.DeleteFile(fullFile2)


        Else
            MessageBox.Show($"Disk {drvletter} is not removable. Will NOT format.")
        End If

    End Sub


    Public Sub CopyDirectory(ByVal trd_data As Thread_Data)

        'SrcPath As String, ByVal DestPath As String, Optional ByVal bQuiet As Boolean = False)

        Dim SrcPath As String = trd_data.txtSource
        Dim DestPath As String = trd_data.txtDestination
        Dim bQuiet As Boolean = trd_data.blnQuiet
        Dim bRealTask As Boolean = trd_data.blnRealTask

        If Not System.IO.Directory.Exists(SrcPath) Then
            Throw New System.IO.DirectoryNotFoundException("Directory " & SrcPath & " not found.")
        End If

        If DestPath.Substring(DestPath.Length - 1, 1) <> System.IO.Path.DirectorySeparatorChar Then
            DestPath += System.IO.Path.DirectorySeparatorChar
        End If
        If Not System.IO.Directory.Exists(DestPath) Then System.IO.Directory.CreateDirectory(DestPath)
        Dim Files As String()
        Try
            Files = System.IO.Directory.GetFileSystemEntries(SrcPath)
            Dim element As String
            For Each element In Files
                If System.IO.Directory.Exists(element) Then
                    Dim strParm As Thread_Data
                    strParm.txtDestination = DestPath & System.IO.Path.GetFileName(element)
                    strParm.txtSource = element
                    strParm.blnQuiet = False
                    strParm.blnRealTask = False
                    CopyDirectory(strParm)

                Else
                    'the current FileSystemEntry is a file so just copy it
                    System.IO.File.Copy(element, DestPath & System.IO.Path.GetFileName(element), True)
                End If
            Next

            If bRealTask Then
                intNumberOfTasksRunning -= 1

            End If
        Catch
            'no files
        End Try
    End Sub



    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            RadioButton1.Checked = False
        Else
            RadioButton1.Checked = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            RadioButton2.Checked = False
        Else
            RadioButton2.Checked = True
        End If
    End Sub
End Class