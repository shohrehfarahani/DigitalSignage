function showContentCtrlr($scope, httpRequest) {
    $scope.load = function () {
        debugger
        alert(0)
        var dataObj = new Object();
        dataObj.position = '6';
        dataObj.content_id = '20047';
        httpRequest.post(service_loadContentsWithAdsItemDetail, dataObj, function (data) {

        });
    }
    $scope.load();

}