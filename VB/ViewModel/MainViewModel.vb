Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports RichEditBinding.Model

Namespace RichEditBinding.ViewModel


	Public Class MainViewModel
		Implements INotifyPropertyChanged
		Public Sub New()
			data_Renamed = CreateCollection()
		End Sub

		Private data_Renamed As ObservableCollection(Of Data)
		Public Property Data() As ObservableCollection(Of Data)
			Get
				Return data_Renamed
			End Get
			Set(ByVal value As ObservableCollection(Of Data))
				If value IsNot Me.data_Renamed Then
					Me.data_Renamed = value
					RaisePropertyChanged("Data")
				End If
			End Set
		End Property

		Private Function CreateCollection() As ObservableCollection(Of Data)
			Dim collection As ObservableCollection(Of Data) = New ObservableCollection(Of Data)()
			collection.Add(New Data() With {.FormatType = FormatType.Html, .Description = "<p>sample HTML text</p>"})
			collection.Add(New Data() With {.FormatType = FormatType.Rtf, .Description = "{\rtf1\ansi\ansicpg1251\deff0\deflang1049{\fonttbl{\f0\fnil\fcharset0 Calibri;}} {\*\generator Msftedit 5.41.21.2510;}\viewkind4\uc1\pard\sa200\sl276\slmult1\lang9\f0\fs22 sample RTF text\par}"})
			Return collection
		End Function

		Private selectedData_Renamed As Data
		Public Property SelectedData() As Data
			Get
				Return selectedData_Renamed
			End Get
			Set(ByVal value As Data)
				If value IsNot Me.selectedData_Renamed Then
					selectedData_Renamed = value
					RaisePropertyChanged("SelectedData")
				End If
			End Set
		End Property

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
		Private Sub RaisePropertyChanged(ByVal info As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(info))
		End Sub
	End Class
End Namespace
