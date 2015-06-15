Imports System.Runtime.InteropServices
Imports System.Drawing.Text
Public Class MainMenu

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If OptionsMenu.Musicoff.Checked Then
            My.Computer.Audio.Stop()
        Else
            My.Computer.Audio.Play(My.Resources.Main_Screen_Music_wav_file, _
AudioPlayMode.BackgroundLoop)
        End If

        gamename.Font = CustomFont.GetInstance(42, FontStyle.Regular)                   'Uses the custom font in the resources

    End Sub

    Private Sub playbutton_Click(sender As Object, e As EventArgs) Handles playbutton.Click
        TeamSelection.Show()
        Me.Hide()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        End
    End Sub

    Private Sub Optionbutton_Click(sender As Object, e As EventArgs) Handles Optionbutton.Click
        OptionsMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Aboutbutton_Click(sender As Object, e As EventArgs) Handles Aboutbutton.Click
        About.Show()
        Me.Hide()
    End Sub
End Class


Module CustomFont

    'PRIVATE FONT COLLECTION TO HOLD THE DYNAMIC FONT
    Private _pfc As PrivateFontCollection = Nothing


    Public ReadOnly Property GetInstance(ByVal Size As Single, _
                                         ByVal style As FontStyle) As Font
        Get
            'IF THIS IS THE FIRST TIME GETTING AN INSTANCE
            'LOAD THE FONT FROM RESOURCES
            If _pfc Is Nothing Then LoadFont()

            'RETURN A NEW FONT OBJECT BASED ON THE SIZE AND STYLE PASSED IN
            Return New Font(_pfc.Families(0), Size, style)

        End Get
    End Property

    Private Sub LoadFont()                              'Code to add custom font, this was taken from the internet
        Try
            'INIT THE FONT COLLECTION
            _pfc = New PrivateFontCollection

            'LOAD MEMORY POINTER FOR FONT RESOURCE
            Dim fontMemPointer As IntPtr = _
                Marshal.AllocCoTaskMem( _
                My.Resources.aircruiser.Length)

            'COPY THE DATA TO THE MEMORY LOCATION
            Marshal.Copy(My.Resources.aircruiser, _
                         0, fontMemPointer, _
                         My.Resources.aircruiser.Length)

            'LOAD THE MEMORY FONT INTO THE PRIVATE FONT COLLECTION
            _pfc.AddMemoryFont(fontMemPointer, _
                               My.Resources.aircruiser.Length)

            'FREE UNSAFE MEMORY
            Marshal.FreeCoTaskMem(fontMemPointer)
        Catch ex As Exception
            'ERROR LOADING FONT. HANDLE EXCEPTION HERE
        End Try

    End Sub

End Module