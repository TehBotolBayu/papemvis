Imports System
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.ComponentModel

Public Class RadiusCombo
    Inherits ComboBox
    <DllImport("gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal left As Integer,
                                               ByVal top As Integer,
                                               ByVal right As Integer,
                                               ByVal bottom As Integer,
                                               ByVal height As Integer,
                                               ByVal width As Integer) As IntPtr

    End Function
    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        Me.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, Me.Width, Me.Height, 15, 15))
    End Sub
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Me.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, Me.Width, Me.Height, 15, 15))
    End Sub
End Class