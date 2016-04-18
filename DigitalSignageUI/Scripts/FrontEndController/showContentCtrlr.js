function showContentCtrlr($scope, httpRequest) {
    $scope.load = function () {
        $scope.imageSource = imageSource;

        var dataObj = new Object();
        dataObj.position = '6';
        dataObj.content_id = '20047';

        $scope.viewData = [];
        $scope.viewDataPosition_6 = [];
        $scope.viewDataPosition_2_imageList = [];

        httpRequest.post(service_loadContentsWithAdsItemDetail, dataObj, function (data) {
            $scope.viewData = data.resultSet;
            for (var posi = 0; posi < $scope.viewData.length; posi++) {
                if ($scope.viewData[posi].position == 6) {// video
                    $scope.viewDataPosition_6 = $scope.viewData[posi];
                    $scope.runPlayer($scope.viewDataPosition_6.itemList);
                }

                if ($scope.viewData[posi].position == 2) {// slideShow_1
                    for (var img_i = 0; img_i < $scope.viewData[posi].itemList.length; img_i++) {
                        var contentObj = new Object();

                        contentObj.file_name = $scope.viewData[posi].itemList[img_i].file_name;
                        contentObj.id = $scope.viewData[posi].id;
                        contentObj.interval = $scope.viewData[posi].interval;
                        contentObj.content_ad_id = $scope.viewData[posi].content_ad_id;
                        contentObj.title = $scope.viewData[posi].title;

                        $scope.viewDataPosition_2_imageList.push(contentObj);
                        if ($scope.viewData[posi].itemList.length - 1 == img_i) {
                            setTimeout(function () {
                                $scope.slider();
                            }, 1000);
                        }
                    }
                }
            }
        });
    }
    $scope.load();

    $scope.runPlayer = function (itemList) {
        $f("player", flowPlayerSWF, {
            clip: {
                url: videoSource + itemList[0].file_name,
                scaling: 'fit',
                live: false,
                autoPlay: true,
                accelerated: true,
                autoBuffering: true
            },
        });

    };
    $scope.slider = function () {
        var transitionsArray = new Array();
        //transitionsArray.push('bars','blinds','blocks','blocks2','concentric','slide','warp','zip','bars3d','blinds3d','cube','tiles3d','turn');
        transitionsArray.push('bars3d','blinds3d');
        if(!flux.browser.supportsTransitions)
            alert("Flux Slider requires a browser that supports CSS3 transitions");
        window.f = new flux.slider('#slider', {
            pagination: false,
            //controls: true,
            captions: true,
            transitions: transitionsArray,
            // delay:5000
        });

    }

}