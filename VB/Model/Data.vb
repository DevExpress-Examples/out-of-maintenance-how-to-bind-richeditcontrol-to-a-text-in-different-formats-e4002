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

'INSTANT VB NOTE: The field description was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private description_Conflict As String = String.Empty
'INSTANT VB NOTE: The field formatType was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private formatType_Conflict As FormatType = FormatType.Undefined

		Public Property Description() As String
			Get
				Return description_Conflict
			End Get
			Set(ByVal value As String)
				If value <> Me.description_Conflict Then
					Me.description_Conflict = value
					NotifyPropertyChanged("Description")
				End If
			End Set
		End Property

		Public Property FormatType() As FormatType
			Get
				Return formatType_Conflict
			End Get
			Set(ByVal value As FormatType)
				If value <> Me.formatType_Conflict Then
					Me.formatType_Conflict = value
					NotifyPropertyChanged("FormatType")
				End If
			End Set
		End Property

		Public Event PropertyChanged As PropertyChangedEventHandler

		Private Sub NotifyPropertyChanged(ByVal info As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(info))
		End Sub
	End Class
End Namespace
