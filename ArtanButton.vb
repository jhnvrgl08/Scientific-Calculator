Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class ArtanButton
        Inherits Button

        'Fields
        Private borderSize As Integer = 0
        Private borderRadius As Integer = 50
    Private borderColor As Color = Color.FromArgb(32, 32, 32)


    'Properties
    Public Function GetBorderSize() As Integer
            Return borderSize
        End Function

        Public Sub SetBorderSize(value As Integer)
            borderSize = value
            Invalidate()
        End Sub

        Public Function GetBorderRadius() As Integer
            Return borderRadius
        End Function

        Public Sub SetBorderRadius(value As Integer)
            Dim radius = If(value <= Height, value, Height)
            borderRadius = radius
            Invalidate()
        End Sub

        Public Property BackgroundColor As Color
            Get
                Return BackColor
            End Get
            Set(value As Color)
                BackColor = value
            End Set
        End Property

        Public Property TextColor As Color
            Get
                Return ForeColor
            End Get
            Set(value As Color)
                ForeColor = value
            End Set
        End Property

        'Constructor
        Public Sub New()
            Size = New Size(200, 100)
            FlatAppearance.BorderSize = 0
            FlatStyle = FlatStyle.Flat
            ForeColor = Color.White


            AddHandler Resize, AddressOf button_Resize
        End Sub

        Private Sub button_Resize(sender As Object, e As EventArgs)
            If GetBorderRadius() > Height Then
                SetBorderRadius(Height)
            End If
        End Sub

        'Methods
        Private Function GetFigurePath(rectangle As RectangleF, radius As Single) As GraphicsPath
            Dim graphicsPath As New GraphicsPath()
            graphicsPath.StartFigure()
            graphicsPath.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90)
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90)
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90)
            graphicsPath.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90)
            graphicsPath.CloseFigure()

            Return graphicsPath
        End Function

        Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
            MyBase.OnPaint(pevent)
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias

            Dim rectangleSurface As New RectangleF(0, 0, Width, Height)
            Dim rectangleBorder As New RectangleF(1, 1, Width - 1.5F, Height - 1)

            If GetBorderRadius() > 1 Then
                Using graphicsPathSurface As GraphicsPath = GetFigurePath(rectangleSurface, GetBorderRadius()),
                      graphicsPathBorder As GraphicsPath = GetFigurePath(rectangleBorder, GetBorderRadius() - 1.0F),
                      penSurface As New Pen(Parent.BackColor, 2),
                      penBorder As New Pen(borderColor, GetBorderSize())
                    penBorder.Alignment = PenAlignment.Inset
                    Region = New Region(graphicsPathSurface)
                    pevent.Graphics.DrawPath(penBorder, graphicsPathSurface)

                    If GetBorderSize() >= 1 Then
                        pevent.Graphics.DrawPath(penBorder, graphicsPathBorder)
                    End If
                End Using
            Else
                Region = New Region(rectangleSurface)
                If GetBorderSize() >= 1 Then
                    Using penBorder As New Pen(borderColor, GetBorderSize())
                        penBorder.Alignment = PenAlignment.Inset
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1)
                    End Using
                End If

            End If
        End Sub
        Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
            MyBase.OnHandleCreated(e)
            AddHandler Parent.BackColorChanged, AddressOf Container_Back
        End Sub

        Private Sub Container_Back(ByVal sender As Object, ByVal e As EventArgs)
            Throw New NotImplementedException()
        End Sub

    End Class

