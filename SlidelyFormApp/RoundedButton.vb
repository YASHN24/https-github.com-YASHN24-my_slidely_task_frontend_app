Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class RoundedButton
    Public Shared Sub RoundButtonCorners(button As Button, radius As Integer)
        Dim path As New GraphicsPath()
        Dim borderWidth As Integer = 2 ' Adjust this value based on your border width
        path.StartFigure()
        path.AddArc(New Rectangle(borderWidth, borderWidth, radius, radius), 180, 90)
        path.AddArc(New Rectangle(button.Width - radius - borderWidth, borderWidth, radius, radius), -90, 90)
        path.AddArc(New Rectangle(button.Width - radius - borderWidth, button.Height - radius - borderWidth, radius, radius), 0, 90)
        path.AddArc(New Rectangle(borderWidth, button.Height - radius - borderWidth, radius, radius), 90, 90)
        path.CloseFigure()
        button.Region = New Region(path)

        ' Hook up the Paint event to draw the custom border
        AddHandler button.Paint, Sub(sender, e)
                                     e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
                                     Using pen As New Pen(Color.Black, borderWidth)
                                         e.Graphics.DrawPath(pen, path)
                                     End Using
                                 End Sub
    End Sub
End Class
