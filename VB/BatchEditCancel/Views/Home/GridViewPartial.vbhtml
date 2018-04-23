@Html.DevExpress().GridView(
    Sub(settings)
            settings.Name = "gridView"
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "GridViewPartial"}

            settings.KeyFieldName = "ID"
            settings.SettingsEditing.Mode = GridViewEditingMode.Batch

            settings.CustomJSProperties = Sub(s, e)
                                                  Dim clientData = New Dictionary(Of Integer, Object)()
                                                  Dim grid = TryCast(s, MVCxGridView)
                                                  For i As Integer = 0 To grid.VisibleRowCount - 1
                                                      Dim rowValues = TryCast(grid.GetRowValues(i, New String() {"ID", "ServerSideExample"}), Object())

                                                      Dim key = Convert.ToInt32(rowValues(0))
                                                      If key Mod 2 <> 0 Then
                                                          clientData.Add(key, "ServerSideExample")
                                                      End If
                                                  Next
                                                  e.Properties("cp_cellsToDisable") = clientData

                                          End Sub
    
    
            settings.ClientSideEvents.BatchEditStartEditing = "OnBatchStartEdit"
    End Sub).Bind(Model).GetHtml()