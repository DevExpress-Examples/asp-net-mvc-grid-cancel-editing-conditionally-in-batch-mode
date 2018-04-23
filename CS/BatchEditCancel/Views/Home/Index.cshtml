<script type="text/javascript">
    function OnBatchStartEdit(s, e) {
        //client processing
        var keyIndex = s.GetColumnByField("ID").index;
        var key = e.rowValues[keyIndex].value;

        var condition = key % 2 == 0;

        if (e.focusedColumn.fieldName == "ClientSideCancel") //cancel example
            if (!condition) e.cancel = true;
        if (e.focusedColumn.fieldName == "ClientSideReadOnly") {
            var editor = s.GetEditor(e.focusedColumn.fieldName); //disable example
            editor.SetEnabled(condition);
        }

        //server preprocessing
        if (typeof s.cp_cellsToDisable[key] != "undefined" && s.cp_cellsToDisable[key] == e.focusedColumn.fieldName)
            e.cancel = true;
    }
</script>
@Html.Action("GridViewPartial")