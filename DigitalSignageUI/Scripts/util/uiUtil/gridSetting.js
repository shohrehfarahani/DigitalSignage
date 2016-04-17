function convertDisplayNameToFarsi(fieldName , gridName) {

	switch (gridName) {
	case 'sabt':
	{
		if(Object.keys(publicDisplayNames).indexOf(fieldName) != -1){
			return publicDisplayNames[fieldName];
		}
		else if(Object.keys(sabtDisplayNames).indexOf(fieldName) != -1){
			return sabtDisplayNames[fieldName];
		}
		else{
			return fieldName;
		}
		break;
	}
	case 'transit':{
		if(Object.keys(publicDisplayNames).indexOf(fieldName) != -1){
			return publicDisplayNames[fieldName];
		}
		else if(Object.keys(transitDisplayNames).indexOf(fieldName) != -1){
			return transitDisplayNames[fieldName];
		}
		else{
			return fieldName;
		}
		break;
	}
	case 'sodour':{
		if(Object.keys(publicDisplayNames).indexOf(fieldName) != -1){
			return publicDisplayNames[fieldName];
		}
		else if(Object.keys(sodourDisplayNames).indexOf(fieldName) != -1){
			return sodourDisplayNames[fieldName];
		}
		else{
			return fieldName;
		}
		break;
	}
	
	case 'malekan':
	{
		if(Object.keys(publicDisplayNames).indexOf(fieldName) != -1){
			return publicDisplayNames[fieldName];
		}
		else if(Object.keys(malekanDisplayNames).indexOf(fieldName) != -1){
			return malekanDisplayNames[fieldName];
		}
		else{
			return fieldName;
		}
		break;
	}
	
	default:
		break;
	}
}

function createSortField(objName , gridName) {
	var sortField = objName;

	switch (gridName) {
	case 'sabt':
	{
		switch (objName) {
		case 'firstName':
			return 'nam';
			break;
		case 'lastName':
			return 'name_khanevadegi';
			break;
		case 'nationalCode':
			return 'code_melli';
			break;
		case 'sex':
			return 'sex';
			break;
		case 'fatherName':
			return 'name_pedar';
			break;
		case 'SSN':
			return 'SH_SH';
			break;
		case 'issuePlace':
			return 'MAHAL_SODOOR';
			break;
		case 'birthPlace':
			return 'MAHAL_TAVALOD';
			break;
		case 'birthDate':
			return 'TARIKH_TAVALOD';
			break;
		case 'bankName':
			return 'nam_bank';
			break;
		default:
			return sortField;
		break;
		}
		break;
	}
	case 'transit':{

		return sortField;

		break;
	}
	case 'sodour':{

		return sortField;

		break;
	}
	
	case 'malekan':{
		switch (objName) {
		case 'firstName':
			return 'nam';
			break;
		case 'lastName':
			return 'name_khanevadegi';
			break;
		case 'fatherName':
			return 'name_pedar';
			break;
		case 'codeMeli':
			return 'code_melli';
			break;
		case 'shSh':
			return 'SH_SH';
			break;
		case 'tarikhTavalod':
			return 'tarikh_tavalod';
			break;
		case 'mahaleSodor':
			return 'MAHAL_SODOOR';
			break;
		case 'codePosti':
			return 'code_posti';
			break;
		case 'mahaleTavalod':
			return 'MAHAL_TAVALOD';
			break;
		case 'address':
			return 'address';
			break;
		case 'molahezat':
			return 'molahezat';
			break;
		case 'shSim':
			return 'sh_sim';
			break;
		case 'shomareTel':
			return 'shomare_tel';
			break;
		case 'tarikhTahie':
			return 'tarikh_tahie';
			break;
		default:
			return sortField;
		break;
		}
		break;
		
	}
	default:
		return sortField;
		break;
	}


}
function createFieldValue(objName) {
	var sortField = objName;

	return sortField;
}

function createSearchField(objName , gridName) {
	switch (gridName) {
	case 'sabt':
	{

		break;
	}
	case 'transit':{

		return "searchData."+objName;

		break;
	}
	case 'sodour':{

		return "searchData."+objName;

		break;
	}
	default:
		break;
	}

}

function getDefaultSortField(gridName) {
	var sortField = 'id';
	return sortField;
}