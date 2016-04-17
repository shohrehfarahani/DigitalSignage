function showContentCtrlr($scope, httpRequest) {
    $scope.load = function () {
        var dataObj = new Object();
        dataObj.position = '6';
        dataObj.content_id = '20047';

        $scope.viewData = [];
        $scope.scopeTitle = '';
        $scope.scopeContent_ad_id = '';

        httpRequest.post(service_loadContentsWithAdsItemDetail, dataObj, function (data) {
            $scope.viewData = data.resultSet;
            $scope.scopeTitle = $scope.viewData[0].title;
            $scope.scopeContent_ad_id = $scope.viewData[0].itemList[0].id;
            $scope.runPlayer($scope.viewData[0].itemList);
        });
    }
    $scope.load();

    $scope.runPlayer = function(itemList) {
        $f("player", flowPlayerSWF, {
            clip: {
                url: videoSource+itemList[0].file_name,
                scaling: 'fit',
                live: false,
                autoPlay: true,
                accelerated: true,
                autoBuffering: true
            },

        });

    }

}