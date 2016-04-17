var application = angular.module('application', []);


//-----------------------------------factory for http request---------------------------//
application.factory('httpRequest', ['$http', function ($http) {
    var service = {};
    service.get = function (url, success, error) {
        $http.get(url)
		.success(function (data) {
		    if (data.result)
		        if (data.result.state == "error") {
		            //	Loader.setLoader(false);
		            //	FoundationApi.publish('main-notifications', { title: Error_Title, content: data.result.message ,autoclose:"3000", color:"warning"});
		            return;
		        }
		    if (typeof (data) != 'string' && (data.resultSet != undefined || data.result.state == "success")) {
		        success(data);
		        return;
		    }
		    else if (data.indexOf("MOHAJER_MAINPAGE") != -1) {
		        freeCatch();
		        location.href = "login.html";
		        return;
		    }

		}, function (err) {
		    //Loader.setLoader(false);
		});
    };
    service.getByParam = function (url, param, success, error) {
        $http.get(url + '/' + param)
		.success(function (data) {
		    if (data.result)
		        if (data.result.state == "error") {
		            //	Loader.setLoader(false);
		            //	FoundationApi.publish('main-notifications', { title: Error_Title, content: data.result.message ,autoclose:"3000", color:"warning"});
		            return;
		        }
		    if (typeof (data) != 'string' && (data.resultSet != undefined || data.result.state == "success")) {
		        success(data);
		        return;
		    }
		    else if (data.indexOf("MOHAJER_MAINPAGE") != -1) {
		        freeCatch();
		        location.href = "login.html";
		        return;
		    }
		}, function (err) {
		    //Loader.setLoader(false);
		    //	FoundationApi.publish('main-notifications', { title: Error_Title, content: err ,autoclose:"3000", color:"warning"});
		});

    };
    service.post = function (url, data, success, error) {
        $http({
            url: url,
            method: "POST",
            data: convertObjectToJSON(data),
            contentType: "application/json; charset=utf-8",
            dataType: "json"
        }).success(function (data, status, headers, config) {
            
            if (status == 200) {
                if (data.result)
                    if (data.result.state == "error") {
                        //	Loader.setLoader(false);
                        //FoundationApi.publish('main-notifications', { title: Error_Title, content: data.result.message ,autoclose:"3000", color:"warning"});
                        return;
                    }
                if (typeof (data) != 'string' && (data.resultSet != undefined || data.result.state == "success")) {
                    success(data);
                    return;
                }
                else if (data.indexOf("MOHAJER_MAINPAGE")) {
                    //freeCatch();
                    location.href = "login.html";
                    return;
                } else {
                    //	Loader.setLoader(false);
                }
            }
        }).error(function (err, status, headers, config) {
            
            //Loader.setLoader(false);
            //FoundationApi.publish('main-notifications', { title: Error_Title, content: "Ø®Ø·Ø§ Ø¯Ø± Ø³Ù…Øª Ø³Ø±ÙˆØ±"+'  status: '+status ,autoclose:"3000", color:"warning"});
        });
    },
	service.postForm = function (url, data, UIform, success, error) {
	    var isValid = true;
	    var form = $(document.getElementsByName(UIform));
	    form.find("input,textarea,select").css('border', '1px solid #aaa');
	    form.find(".errBlock").hide();
	    $(".alert-box").remove();
	    $(".alert-box").attr("style", "");

	    form.find("input,textarea,select").each(function () {
	        // Check Require Validation
	        if ($(this).attr("data-validation-require") == "true" && ($(this).val() == "" || $(this).val() == null) && !$(this).attr("disabled") && $(this).is(":visible")) {
	            $(this).css('border', '1px solid red').focus();
	            isValid = false;
	            return false;
	        }


	    });
	    if (!isValid)
	        return;
	    $http({
	        url: url,
	        method: "POST",
	        data: convertObjectToJSON(data),
	        contentType: "application/json; charset=utf-8",
	        dataType: "json"
	    }).success(function (data, status, headers, config) {

	        if (status == 200) {
	            if (data.result)
	                if (data.result.state == "error") {
	                    //	Loader.setLoader(false);
	                    //	FoundationApi.publish('main-notifications', { title: Error_Title, content: data.result.message ,autoclose:"3000", color:"warning"});
	                    return;
	                }
	            if (typeof (data) != 'string' && (data.resultSet != undefined || data.result.state == "success")) {
	                success(data);
	                return;
	            }
	            else if (data.indexOf("MOHAJER_MAINPAGE")) {
	                freeCatch();
	                location.href = "login.html";
	                return;
	            } else {
	                //	Loader.setLoader(false);
	            }
	        }
	    }).error(function (err, status, headers, config) {
	        //			FoundationApi.publish('main-notifications', { title: Error_Title, content: err+'  status: '+status ,autoclose:"3000", color:"warning"});
	        //	Loader.setLoader(false);
	    });
	};
    return service;
}]);
