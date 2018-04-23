Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace BatchEditCancel.Models
	Public Class SampleModel
		Private privateID As Integer
		Public Property ID() As Integer
			Get
				Return privateID
			End Get
			Set(ByVal value As Integer)
				privateID = value
			End Set
		End Property
		Private privateClientSideCancel As String
		Public Property ClientSideCancel() As String
			Get
				Return privateClientSideCancel
			End Get
			Set(ByVal value As String)
				privateClientSideCancel = value
			End Set
		End Property
		Private privateClientSideReadOnly As String
		Public Property ClientSideReadOnly() As String
			Get
				Return privateClientSideReadOnly
			End Get
			Set(ByVal value As String)
				privateClientSideReadOnly = value
			End Set
		End Property
		Private privateServerSideExample As Integer
		Public Property ServerSideExample() As Integer
			Get
				Return privateServerSideExample
			End Get
			Set(ByVal value As Integer)
				privateServerSideExample = value
			End Set
		End Property
	End Class
	Public NotInheritable Class DataProvider
		Private Sub New()
		End Sub
		Public Shared Function GetData() As IEnumerable(Of SampleModel)
			Return Enumerable.Range(0, 10).Select(Function(i) New SampleModel With {.ID = i, .ClientSideCancel = "Example " & i, .ClientSideReadOnly = "Sample data " & i, .ServerSideExample = i * 123})
		End Function
	End Class
End Namespace