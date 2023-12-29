<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128549632/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T115116)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/BatchEditCancel/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/BatchEditCancel/Controllers/HomeController.vb))
* [GridViewPartial.cshtml](./CS/BatchEditCancel/Views/Home/GridViewPartial.cshtml)
* **[Index.cshtml](./CS/BatchEditCancel/Views/Home/Index.cshtml)**
<!-- default file list end -->
# GridView - Batch Editing - How to cancel editing or disable the editor conditionally


<p>This example demonstrates how to cancel editing conditionally for the grid when batch editing is in use. It is possible to execute your logic either on the client or server side for a complex business model.<br />Then, handle the grid's client-side <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewScriptsASPxClientGridView_BatchEditStartEditingtopic">BatchEditStartEditing</a> event to cancel the edit operation using the e.cancel property:</p>


```js
if (condition) e.cancel = true;

``` 
<p> The custom server-side logic can be executed in the CustomJSProperties event handler:</p>


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


