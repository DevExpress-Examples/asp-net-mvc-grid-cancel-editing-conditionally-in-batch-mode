# GridView for MVC - How to cancel editing conditionally in batch edit mode

<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t115116/)**
<!-- run online end -->

You can cancel grid data editing in batch edit mode either on the client or server side.

In this example, users can modify data only in even rows (except the **ID** column). Every column is protected in different way, listed below.

On the client, handle handle the [BatchEditStartEditing](https://docs.devexpress.com/AspNet/js-ASPxClientGridView.BatchEditStartEditing) event and set its [e.cancel](https://docs.devexpress.com/AspNet/js-ASPxClientCancelEventArgs.cancel) property to `true` to cancel the editing:

```js
function OnBatchStartEdit(s, e) {
    if (condition) e.cancel = true;
}
```

Another way to cancel editing is to use an editor's [SetReadOnly](https://docs.devexpress.com/AspNet/js-ASPxClientEdit.SetReadOnly%28readOnly%29) method. The code sample below demonstrates how to disable an editor conditionally:

 ```js
function OnBatchStartEdit(s, e) {
    if (condition) {
        editor = s.GetEditor(e.focusedColumn.fieldName); 
        editor.SetReadOnly(true);
  }
```


You can implement a custom server-side logic in the [CustomJSProperties](https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.GridViewSettings.CustomJSProperties) event handler:


```cs
settings.CustomJSProperties += (s, e) => {
    var clientData = new Dictionary<int,object>();
    var grid = s as MVCxGridView;
    for (int i = 0; i < grid.VisibleRowCount; i++) {
        var rowValues = grid.GetRowValues(i, new string[] {"ID", "ServerSideExample"}) as object[];
        
        var key = Convert.ToInt32(rowValues[0]);
        if (key % 2 != 0)
            clientData.Add(key, "ServerSideExample");            
    }
    e.Properties["cp_cellsToDisable"] = clientData;
};
```

## Files to Look At
<!-- default file list -->
- [Index.cshtml](./CS/BatchEditCancel/Views/Home/Index.cshtml)
- [GridViewPartial.cshtml](./CS/BatchEditCancel/Views/Home/GridViewPartial.cshtml)
<!-- default file list end -->

## More Examples

- [GridView for Web Forms - Cancel editor/row editing in the client FocusedCellChanging event in batch edit mode](https://github.com/DevExpress-Examples/aspxgridview-batch-edit-cancel-editor-row-editing-in-the-client-focusedcellchanging-event-t496531)