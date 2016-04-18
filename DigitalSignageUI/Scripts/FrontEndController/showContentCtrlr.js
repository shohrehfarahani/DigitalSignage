function showContentCtrlr($scope, httpRequest) {
    $scope.weatherFun = function () {
        $.simpleWeather({
            location: 'Tehran, IR',
            woeid: '',
            unit: 'c',
            success: function (weather) {
                html = '<span class="wi"><i class="wi-' + weather.code + '"></i></span><span class="cw">' + weather.temp + '</span><span class="cc">' + '&deg;' + weather.units.temp + '</span>';

                $("#weather").html(html);
            },
            error: function (error) {
                $("#weather").html('<p>' + error + '</p>');
            }
        });
    };
    $scope.load = function () {
        $scope.imageSource = imageSource;
   
        var dataObj = new Object();
        dataObj.content_id = '20047';

        $scope.viewData = [];
        $scope.viewDataPosition_6 = [];
        $scope.viewDataPosition_2_imageList = [];
        $scope.viewDataPosition_45_TextList = [];

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
                        debugger
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

                if ($scope.viewData[posi].position == 4 || $scope.viewData[posi].position == 5) {// Text
                    for (var txt_i = 0; txt_i < $scope.viewData[posi].itemList.length; txt_i++) {
                        var contentObj = new Object();
                        debugger
                        contentObj.description = $scope.viewData[posi].itemList[txt_i].description;
                        contentObj.id = $scope.viewData[posi].id;
                        contentObj.interval = $scope.viewData[posi].interval;
                        contentObj.content_ad_id = $scope.viewData[posi].content_ad_id;
                        contentObj.title = $scope.viewData[posi].title;

                        $scope.viewDataPosition_45_TextList.push(contentObj);
                       
                    }

                }
            }
            
        });
        $scope.weatherFun();
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
        //var transitionsArray = new Array();
        ////transitionsArray.push('bars','blinds','blocks','blocks2','concentric','slide','warp','zip','bars3d','blinds3d','cube','tiles3d','turn');
        //transitionsArray.push('bars3d','blinds3d');
        //if(!flux.browser.supportsTransitions)
        //    alert("Flux Slider requires a browser that supports CSS3 transitions");
        //window.f = new flux.slider('#slider', {
        //    pagination: false,
        //    //controls: true,
        //    captions: true,
        //    transitions: transitionsArray,
        //    // delay:5000
        //});
        $('#coin-slider').coinslider({ width: 280, height: 187, navigation: false, delay: 5000, spw: 4, sph: 4 });
    }

}