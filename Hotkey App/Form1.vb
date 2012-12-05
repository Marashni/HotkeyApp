'Author: Taylor Hawkins
Public Class Form1
    Dim PID As Integer
    Dim PID1 As Integer
    Dim PID2 As Integer
    Dim PID3 As Integer
    Dim PID4 As Integer
    Dim PID5 As Integer
    Dim Hotkey1 As String
    Dim Hotkey2 As String
    Dim Hotkey3 As String
    Dim Hotkey4 As String
    Dim Hotkey5 As String
    Dim Hotkey6 As String
    Dim Hotkey7 As String
    Dim Hotkey8 As String
    Dim Hotkey9 As String
    Dim Hotkey10 As String
    Dim Hotkey11 As String
    Dim Hotkey12 As String
    Dim Hotkey13 As String
    Dim Path As String
    Dim Flag As Boolean

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Flag = False
        Try
            AppActivate(PID)
            Flag = True
        Catch ex As Exception
            ErrorProvider1.SetError(Label3, "Error: " & ex.Message)
            With Label3
                .Text = ex.Message
            End With
        End Try

        If Flag Then My.Computer.Keyboard.SendKeys("%{F4}")

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Flag = False
        Try
            AppActivate(PID)
            Flag = True
        Catch ex As Exception
            ErrorProvider1.SetError(Label3, "Error: " & ex.Message)
            With Label3
                .Text = ex.Message
            End With
        End Try

        If Flag Then My.Computer.Keyboard.SendKeys(Hotkey1)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Flag = False
        Try
            AppActivate(PID)
            Flag = True
        Catch ex As Exception
            ErrorProvider1.SetError(Label3, "Error: " & ex.Message)
            With Label3
                .Text = ex.Message
            End With
        End Try

        If Flag Then My.Computer.Keyboard.SendKeys(Hotkey2)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Flag = False
        Try
            AppActivate(PID)
            Flag = True
        Catch ex As Exception
            ErrorProvider1.SetError(Label3, "Error: " & ex.Message)
            With Label3
                .Text = ex.Message
            End With
        End Try

        If Flag Then My.Computer.Keyboard.SendKeys(Hotkey3)
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Flag = False
        Try
            AppActivate(PID)
            Flag = True
        Catch ex As Exception
            ErrorProvider1.SetError(Label3, "Error: " & ex.Message)
            With Label3
                .Text = ex.Message
            End With
        End Try

        If Flag Then My.Computer.Keyboard.SendKeys(Hotkey4)
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Flag = False
        Try
            AppActivate(PID)
            Flag = True
        Catch ex As Exception
            ErrorProvider1.SetError(Label3, "Error: " & ex.Message)
            With Label3
                .Text = ex.Message
            End With
        End Try

        If Flag Then My.Computer.Keyboard.SendKeys(Hotkey5)
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Flag = False
        Try
            AppActivate(PID)
            Flag = True
        Catch ex As Exception
            ErrorProvider1.SetError(Label3, "Error: " & ex.Message)
            With Label3
                .Text = ex.Message
            End With
        End Try

        If Flag Then My.Computer.Keyboard.SendKeys(Hotkey6)
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Flag = False
        Try
            AppActivate(PID)
            Flag = True
        Catch ex As Exception
            ErrorProvider1.SetError(Label3, "Error: " & ex.Message)
            With Label3
                .Text = ex.Message
            End With
        End Try

        If Flag Then My.Computer.Keyboard.SendKeys(Hotkey7)
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Flag = False
        Try
            AppActivate(PID)
            Flag = True
        Catch ex As Exception
            ErrorProvider1.SetError(Label3, "Error: " & ex.Message)
            With Label3
                .Text = ex.Message
            End With
        End Try

        If Flag Then My.Computer.Keyboard.SendKeys(Hotkey8)
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Flag = False
        Try
            AppActivate(PID)
            Flag = True
        Catch ex As Exception
            ErrorProvider1.SetError(Label3, "Error: " & ex.Message)
            With Label3
                .Text = ex.Message
            End With
        End Try

        If Flag Then My.Computer.Keyboard.SendKeys(Hotkey9)
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        Flag = False
        Try
            AppActivate(PID)
            Flag = True
        Catch ex As Exception
            ErrorProvider1.SetError(Label3, "Error: " & ex.Message)
            With Label3
                .Text = ex.Message
            End With
        End Try

        If Flag Then My.Computer.Keyboard.SendKeys(Hotkey10)
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        Flag = False
        Try
            AppActivate(PID)
            Flag = True
        Catch ex As Exception
            ErrorProvider1.SetError(Label3, "Error: " & ex.Message)
            With Label3
                .Text = ex.Message
            End With
        End Try

        If Flag Then My.Computer.Keyboard.SendKeys(Hotkey11)
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        Flag = False
        Try
            AppActivate(PID)
            Flag = True
        Catch ex As Exception
            ErrorProvider1.SetError(Label3, "Error: " & ex.Message)
            With Label3
                .Text = ex.Message
            End With
        End Try

        If Flag Then My.Computer.Keyboard.SendKeys(Hotkey12)
    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        Flag = False
        Try
            AppActivate(PID)
            Flag = True
        Catch ex As Exception
            ErrorProvider1.SetError(Label3, "Error: " & ex.Message)
            With Label3
                .Text = ex.Message
            End With
        End Try

        If Flag Then My.Computer.Keyboard.SendKeys(Hotkey13)
    End Sub

    Private Sub SculptrisToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SculptrisToolStripMenuItem.Click

        ErrorProvider1.Clear()
        Label3.Text = " "

        Try
            Dim reader As New System.IO.StreamReader(CurDir() & "\" & "sculptris_values.txt")
            Hotkey1 = reader.ReadLine()
            Hotkey2 = reader.ReadLine()
            Hotkey3 = reader.ReadLine()
            Hotkey4 = reader.ReadLine()
            Hotkey5 = reader.ReadLine()
            Hotkey6 = reader.ReadLine()
            Hotkey7 = reader.ReadLine()
            Hotkey8 = reader.ReadLine()
            Hotkey9 = reader.ReadLine()
            Hotkey10 = reader.ReadLine()
            Hotkey11 = reader.ReadLine()
            Hotkey12 = reader.ReadLine()
            Hotkey13 = reader.ReadLine()
            Button2.Text = reader.ReadLine()
            Button3.Text = reader.ReadLine()
            Button4.Text = reader.ReadLine()
            Button5.Text = reader.ReadLine()
            Button6.Text = reader.ReadLine()
            Button7.Text = reader.ReadLine()
            Button8.Text = reader.ReadLine()
            Button9.Text = reader.ReadLine()
            Button10.Text = reader.ReadLine()
            Button11.Text = reader.ReadLine()
            Button12.Text = reader.ReadLine()
            Button13.Text = reader.ReadLine()
            Button14.Text = reader.ReadLine()
            Path = reader.ReadLine()
        Catch ex As Exception
            ErrorProvider1.SetError(Label3, "Error: " & ex.Message)
            With Label3
                .Text = ex.Message
            End With
        End Try

        If PID1 = 0 Then PID1 = Shell(Path, AppWinStyle.NormalFocus)
        PID = PID1
        Label1.Text = "Sculptris"

    End Sub

    Private Sub ZBrushToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ZBrushToolStripMenuItem.Click

        ErrorProvider1.Clear()
        Label3.Text = " "

        Try
            Dim reader As New System.IO.StreamReader(CurDir() & "\" & "zbrush_values.txt")
            Hotkey1 = reader.ReadLine()
            Hotkey2 = reader.ReadLine()
            Hotkey3 = reader.ReadLine()
            Hotkey4 = reader.ReadLine()
            Hotkey5 = reader.ReadLine()
            Hotkey6 = reader.ReadLine()
            Hotkey7 = reader.ReadLine()
            Hotkey8 = reader.ReadLine()
            Hotkey9 = reader.ReadLine()
            Hotkey10 = reader.ReadLine()
            Hotkey11 = reader.ReadLine()
            Hotkey12 = reader.ReadLine()
            Hotkey13 = reader.ReadLine()
            Button2.Text = reader.ReadLine()
            Button3.Text = reader.ReadLine()
            Button4.Text = reader.ReadLine()
            Button5.Text = reader.ReadLine()
            Button6.Text = reader.ReadLine()
            Button7.Text = reader.ReadLine()
            Button8.Text = reader.ReadLine()
            Button9.Text = reader.ReadLine()
            Button10.Text = reader.ReadLine()
            Button11.Text = reader.ReadLine()
            Button12.Text = reader.ReadLine()
            Button13.Text = reader.ReadLine()
            Button14.Text = reader.ReadLine()
            Path = reader.ReadLine()
        Catch ex As Exception
            ErrorProvider1.SetError(Label3, "Error: " & ex.Message)
            With Label3
                .Text = ex.Message
            End With
        End Try

        If PID2 = 0 Then PID2 = Shell(Path, AppWinStyle.NormalFocus)
        PID = PID2
        Label1.Text = "Zbrush"
        
    End Sub

    Private Sub BlenderToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BlenderToolStripMenuItem.Click

        ErrorProvider1.Clear()
        Label3.Text = " "

        Try
            Dim reader As New System.IO.StreamReader(CurDir() & "\" & "blender_values.txt")
            Hotkey1 = reader.ReadLine()
            Hotkey2 = reader.ReadLine()
            Hotkey3 = reader.ReadLine()
            Hotkey4 = reader.ReadLine()
            Hotkey5 = reader.ReadLine()
            Hotkey6 = reader.ReadLine()
            Hotkey7 = reader.ReadLine()
            Hotkey8 = reader.ReadLine()
            Hotkey9 = reader.ReadLine()
            Hotkey10 = reader.ReadLine()
            Hotkey11 = reader.ReadLine()
            Hotkey12 = reader.ReadLine()
            Hotkey13 = reader.ReadLine()
            Button2.Text = reader.ReadLine()
            Button3.Text = reader.ReadLine()
            Button4.Text = reader.ReadLine()
            Button5.Text = reader.ReadLine()
            Button6.Text = reader.ReadLine()
            Button7.Text = reader.ReadLine()
            Button8.Text = reader.ReadLine()
            Button9.Text = reader.ReadLine()
            Button10.Text = reader.ReadLine()
            Button11.Text = reader.ReadLine()
            Button12.Text = reader.ReadLine()
            Button13.Text = reader.ReadLine()
            Button14.Text = reader.ReadLine()
            Path = reader.ReadLine()
        Catch ex As Exception
            ErrorProvider1.SetError(Label3, "Error: " & ex.Message)
            With Label3
                .Text = ex.Message
            End With
        End Try

        If PID3 = 0 Then PID3 = Shell(Path, AppWinStyle.NormalFocus)
        PID = PID3
        Label1.Text = "Blender"
    End Sub

    Private Sub DSMaxToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DSMaxToolStripMenuItem.Click
        
        ErrorProvider1.Clear()
        Label3.Text = " "

        Try
            Dim reader As New System.IO.StreamReader(CurDir() & "\" & "3dsmax_values.txt")
            Hotkey1 = reader.ReadLine()
            Hotkey2 = reader.ReadLine()
            Hotkey3 = reader.ReadLine()
            Hotkey4 = reader.ReadLine()
            Hotkey5 = reader.ReadLine()
            Hotkey6 = reader.ReadLine()
            Hotkey7 = reader.ReadLine()
            Hotkey8 = reader.ReadLine()
            Hotkey9 = reader.ReadLine()
            Hotkey10 = reader.ReadLine()
            Hotkey11 = reader.ReadLine()
            Hotkey12 = reader.ReadLine()
            Hotkey13 = reader.ReadLine()
            Button2.Text = reader.ReadLine()
            Button3.Text = reader.ReadLine()
            Button4.Text = reader.ReadLine()
            Button5.Text = reader.ReadLine()
            Button6.Text = reader.ReadLine()
            Button7.Text = reader.ReadLine()
            Button8.Text = reader.ReadLine()
            Button9.Text = reader.ReadLine()
            Button10.Text = reader.ReadLine()
            Button11.Text = reader.ReadLine()
            Button12.Text = reader.ReadLine()
            Button13.Text = reader.ReadLine()
            Button14.Text = reader.ReadLine()
            Path = reader.ReadLine()
        Catch ex As Exception
            ErrorProvider1.SetError(Label3, "Error: " & ex.Message)
            With Label3
                .Text = ex.Message
            End With
        End Try

        If PID4 = 0 Then PID4 = Shell(Path, AppWinStyle.NormalFocus)
        PID = PID4
        Label1.Text = "3ds Max"
    End Sub

    Private Sub Foobar2000ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Foobar2000ToolStripMenuItem.Click
        
        ErrorProvider1.Clear()
        Label3.Text = " "

        Try
            Dim reader As New System.IO.StreamReader(CurDir() & "\" & "foobar2000_values.txt")
            Hotkey1 = reader.ReadLine()
            Hotkey2 = reader.ReadLine()
            Hotkey3 = reader.ReadLine()
            Hotkey4 = reader.ReadLine()
            Hotkey5 = reader.ReadLine()
            Hotkey6 = reader.ReadLine()
            Hotkey7 = reader.ReadLine()
            Hotkey8 = reader.ReadLine()
            Hotkey9 = reader.ReadLine()
            Hotkey10 = reader.ReadLine()
            Hotkey11 = reader.ReadLine()
            Hotkey12 = reader.ReadLine()
            Hotkey13 = reader.ReadLine()
            Button2.Text = reader.ReadLine()
            Button3.Text = reader.ReadLine()
            Button4.Text = reader.ReadLine()
            Button5.Text = reader.ReadLine()
            Button6.Text = reader.ReadLine()
            Button7.Text = reader.ReadLine()
            Button8.Text = reader.ReadLine()
            Button9.Text = reader.ReadLine()
            Button10.Text = reader.ReadLine()
            Button11.Text = reader.ReadLine()
            Button12.Text = reader.ReadLine()
            Button13.Text = reader.ReadLine()
            Button14.Text = reader.ReadLine()
            Path = reader.ReadLine()
        Catch ex As Exception
            ErrorProvider1.SetError(Label3, "Error: " & ex.Message)
            With Label3
                .Text = ex.Message
            End With
        End Try

        If PID5 = 0 Then PID5 = Shell(Path, AppWinStyle.NormalFocus)

        PID = PID5
        Label1.Text = "Foobar2000"
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InfoToolStripMenuItem.Click
        Dim MessageString As String
        Dim reader As New System.IO.StreamReader(CurDir() & "\" & "readme.txt")
        MessageString = reader.ReadToEnd
        MessageBox.Show(MessageString, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.TopMost = True

        Try
            Dim reader As New System.IO.StreamReader(CurDir() & "\" & "applications.txt")
            SculptrisToolStripMenuItem.Text = reader.ReadLine()
            ZBrushToolStripMenuItem.Text = reader.ReadLine()
            BlenderToolStripMenuItem.Text = reader.ReadLine()
            DSMaxToolStripMenuItem.Text = reader.ReadLine()
            Foobar2000ToolStripMenuItem.Text = reader.ReadLine()
        Catch ex As Exception
            ErrorProvider1.SetError(Label3, "Error: " & ex.Message)
            With Label3
                .Text = ex.Message
            End With
        End Try

        SculptrisToolStripMenuItem1.Text = SculptrisToolStripMenuItem.Text
        ZBrushToolStripMenuItem1.Text = ZBrushToolStripMenuItem.Text
        BlenderToolStripMenuItem1.Text = BlenderToolStripMenuItem.Text
        DsMaxToolStripMenuItem1.Text = DSMaxToolStripMenuItem.Text
        Foobar2000ToolStripMenuItem1.Text = Foobar2000ToolStripMenuItem.Text

        PID1 = 0
        PID2 = 0
        PID3 = 0
        PID4 = 0
        PID5 = 0

    End Sub

    Private Sub SculptrisToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles SculptrisToolStripMenuItem1.Click
        System.Diagnostics.Process.Start("Notepad.Exe", (CurDir() & "\" & "sculptris_values.txt"))
    End Sub

    Private Sub ZBrushToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ZBrushToolStripMenuItem1.Click
        System.Diagnostics.Process.Start("Notepad.Exe", (CurDir() & "\" & "zbrush_values.txt"))
    End Sub

    Private Sub BlenderToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles BlenderToolStripMenuItem1.Click
        System.Diagnostics.Process.Start("Notepad.Exe", (CurDir() & "\" & "blender_values.txt"))
    End Sub

    Private Sub DsMaxToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles DsMaxToolStripMenuItem1.Click
        System.Diagnostics.Process.Start("Notepad.Exe", (CurDir() & "\" & "3dsmax_values.txt"))
    End Sub

    Private Sub Foobar2000ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles Foobar2000ToolStripMenuItem1.Click
        System.Diagnostics.Process.Start("Notepad.Exe", (CurDir() & "\" & "foobar2000_values.txt"))
    End Sub

    Private Sub ReadMeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        System.Diagnostics.Process.Start("Notepad.Exe", (CurDir() & "\" & "readme.txt"))
    End Sub

    Private Sub ApplicationNamesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ApplicationNamesToolStripMenuItem.Click
        System.Diagnostics.Process.Start("Notepad.Exe", (CurDir() & "\" & "applications.txt"))
    End Sub
End Class