Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports BatchEditCancel.Models

Namespace BatchEditCancel.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			Return View()
		End Function

		Public Function GridViewPartial() As ActionResult
			Return PartialView(DataProvider.GetData())
		End Function
	End Class
End Namespace