Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Media

Namespace AnnotationSample

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class

    Public Class TextAndImage

        Public Property Text As String

        Public Property ImageSource As ImageSource
    End Class
End Namespace
