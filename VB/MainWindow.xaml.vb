Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports System.Windows.Data
Imports DevExpress.XtraScheduler

Namespace SchedulerBindLimitIntervalWpf
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class

	Public Class IntervalConverter
		Implements IMultiValueConverter
		Public Function Convert(ByVal values() As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IMultiValueConverter.Convert
			Dim start As DateTime = CDate(values(0))
			Dim [end] As DateTime = CDate(values(1))

			If start > [end] Then
				start = [end]
			End If

			Return New TimeInterval(start, [end])
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetTypes() As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object() Implements IMultiValueConverter.ConvertBack
			Throw New NotImplementedException()
		End Function
	End Class

End Namespace
