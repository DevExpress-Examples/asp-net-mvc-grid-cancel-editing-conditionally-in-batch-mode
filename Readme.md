<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/BatchEditCancel/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/BatchEditCancel/Controllers/HomeController.vb))
* [GridViewPartial.cshtml](./CS/BatchEditCancel/Views/Home/GridViewPartial.cshtml)
* **[Index.cshtml](./CS/BatchEditCancel/Views/Home/Index.cshtml)**
<!-- default file list end -->
# GridView - Batch Editing - How to cancel editing or disable the editor conditionally


<p>This example demonstrates how to cancel editing or disable the editor conditionally for the grid when batch editing is in use. It is possible to execute your logic either on the client or server side for a complex business model.<br />Then, handle the grid's client-side <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewScriptsASPxClientGridView_BatchEditStartEditingtopic">BatchEditStartEditing</a> event to either cancel the edit operation using the e.cancel property:</p>


```js
if (condition) e.cancel = true;

```


<p> or disable the editor by obtaining its client instance:</p>


```js
var editor = s.GetEditor(e.focusedColumn.fieldName);
editor.SetEnabled(condition);

```


<p> The custom server-side logic can be executed in the CustomJSProperties event handler:</p>


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


<p><strong><br />See Also:</strong><br /><a href="https://www.devexpress.com/Support/Center/p/T115144">ASPxGridView - Batch Editing - How to cancel editing or disable the editor conditionally</a></p>

<br/>


