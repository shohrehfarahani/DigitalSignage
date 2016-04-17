

var gridOption = {
		'gridSearchTableHeader' : '<div class="blockCustom"><table class="gridSearchCustom"><tbody><tr>',// row Header
		'gridSearchTableColBtn' : "<th class='colBtn'>&nbsp;</th>",
		'gridSearchTableFooter' : "</tr></tbody></table>",// row Footer
		'gridSearchTableHeaderChkPlace' :'<th class="rowNo"><input type="checkbox" class="myinput large"/></th>',// row chekPlace
		'gridSearchTableHeaderRowNo' : '<th class="rowNo"><a class="btnNoAction"><span class="icon" data-icon="&#xe178;"></span></a></th>',// row Number
//		'gridHeaderTable' : '<table id="gridCustomTable" class="gridCustom" role="grid"><thead><tr>',
		'gridHeaderTableRowChkPlace' : '<th class="rowNo">&nbsp;</th>',
		'gridHeaderTableRowNo' : '<th class="rowNo">&nbsp;</th>',
		'gridHeaderTableRowNo' : '<th class="rowNo">&nbsp;</th>',
		'gridHeaderTableColBtn' : "<th class='colBtn'>&nbsp;</th>",
		'gridHeaderTableFooter' : "</tr></thead>",
		'gridBodyUIHeader' : "<tbody>",
		'gridBodyUIFooter' : "</tbody></table></div>",
};
 function createGridName(gridName) {
	 var gridHeaderTable = '<table id="'+gridName+'" class="gridCustom" role="grid"><thead><tr>';
	 
	 return gridHeaderTable;
}