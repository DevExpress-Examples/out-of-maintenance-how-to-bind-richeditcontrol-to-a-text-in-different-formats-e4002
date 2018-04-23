Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports RichEditBinding.ViewModel
Imports System.ComponentModel

Namespace RichEditBinding.Model

	Public Enum FormatType
		Undefined
		Html
		Rtf
	End Enum

	Public Class Data
		Implements INotifyPropertyChanged
		Public Sub New()
		End Sub

		Private description_Renamed As String = String.Empty
		Private formatType_Renamed As FormatType = FormatType.Undefined

		Public Property Description() As String
			Get
				Return description_Renamed
			End Get
			Set(ByVal value As String)
				If value <> Me.description_Renamed Then
					Me.description_Renamed = value
					NotifyPropertyChanged("Description")
				End If
			End Set
		End Property

		Public Property FormatType() As FormatType
			Get
				Return formatType_Renamed
			End Get
			Set(ByVal value As FormatType)
				If value <> Me.formatType_Renamed Then
					Me.formatType_Renamed = value
					NotifyPropertyChanged("FormatType")
				End If
			End Set
		End Property

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

		Private Sub NotifyPropertyChanged(ByVal info As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(info))
		End Sub
	End Class
End Namespace
