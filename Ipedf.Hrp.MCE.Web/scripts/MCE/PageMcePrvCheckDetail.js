var app = angular.module('app', []);
app.controller('index', ['$scope', '$http', '$rootScope', function ($scope, $http, $rootScope) {


    $scope.imgArea={
        _h:300
    };
    $scope.largeImg=function(){
        $scope.imgArea._h = $scope.imgArea._h * 1.1;
    };
    $scope.smallImg=function(){
        $scope.imgArea._h = $scope.imgArea._h / 1.1;
    };
    $rootScope.baseUrl = "../../";
    $scope.certImgUrl="";

    $scope.paramObj = {};
    $scope.step = {
        one: true,
        two: false,
        three: false
    };
    $scope.infoOne = {
        "code": "",
        "userName": "",
        "phone": "",
        "password": "",
        "email": ""
    };
    $scope.infoTwo = {
        "name": "",
        "proviceCode": "",
        "cityCode": "",
        "districtCode":"",
        "proviceName": "",
        "cityName": "",
        "districtName": "",
        "address": "",
        "balance_type_id": "",
        "balance_type_name": "",
        "register_fund": "",
        "establish_Date": "",
        "link_Person": "",
		law_Person:"",
		services :""
    };
    $scope.infoThree = [];
    $scope.getDetailId = function () {
        function urlArgs() {
            var args = {};
            var query = location.search.substring(1);
            var pairs = query.split("&");
            for (var i = 0; i < pairs.length; i++) {
                var pos = pairs[i].indexOf("=");
                if (pos == -1) continue;
                var name = pairs[i].substring(0, pos);
                var value = pairs[i].substring(pos + 1);
                value = decodeURIComponent(value);
                args[name] = value;
            }
            return args;
        }

        $scope.paramObj = urlArgs();
    };
    //获取详细信息
    $scope.getDetailInfoOne = function () {
        $http({
            method: "GET",
            url: $rootScope.baseUrl + "service/MCE/MCE_PRV/Srv_MCE_GetAccountInfo.ashx?id=" + $scope.paramObj.id
        }).then(function (data) {
            var data = data.data;
            if (data.Succeed == 1) {
                $scope.infoOne.code = data.Message.code;
                $scope.infoOne.userName = data.Message.userName;
                $scope.infoOne.phone = data.Message.phone;
                $scope.infoOne.password = data.Message.password;
                $scope.infoOne.email = data.Message.email;
            } else {
                alert(data.Message)
            }
        })
    };
    $scope.getDetailInfoTwo = function () {
        $http({
            method: "GET",
            url: $rootScope.baseUrl + "service/mce/MCE_PRV/Srv_MCE_GetEnterPriseInfo.ashx?id=" + $scope.paramObj.id
        }).then(function (data) {
            var data = data.data;
            if (data.Succeed == 1) {
                $scope.infoTwo.name = data.Message.name;
                $scope.infoTwo.proviceCode = data.Message.proviceCode;
                $scope.infoTwo.cityCode = data.Message.cityCode;
                $scope.infoTwo.districtCode = data.Message.districtCode;
                $scope.infoTwo.proviceName = data.Message.proviceName;
                $scope.infoTwo.cityName = data.Message.cityName;
                $scope.infoTwo.districtName = data.Message.districtName;
                $scope.infoTwo.address = data.Message.address;
                $scope.infoTwo.balance_type_id = data.Message.balance_type_id;
                $scope.infoTwo.balance_type_name = data.Message.balance_type_name;
                $scope.infoTwo.register_fund = data.Message.register_fund;
                $scope.infoTwo.establish_Date = data.Message.establish_Date;
                $scope.infoTwo.link_Person = data.Message.link_Person;
				$scope.infoTwo.law_Person = data.Message.law_Person;
				$scope.infoTwo.services  = data.Message.services ;
            } else {
                alert(data.Message)
            }
        })
    };
    $scope.getDetailInfoThree = function () {
        $http({
            method: "GET",
            url: $rootScope.baseUrl + "service/mce/MCE_PRV/Srv_MCE_GetPrvCertList.ashx?id=" + $scope.paramObj.id
        }).then(function (data) {
            var data = data.data;
            if (data.Succeed == 1) {
                $scope.infoThree = data.Message
            } else {
                alert(data.Message)
            }
        })
    };
    $scope.changeStep=function (str) {
        angular.forEach($scope.step,function (value,key) {
            $scope.step[key] = str == key? true : false
        })
    };
    $scope.goStepOne = function () {
        $scope.step.one = true;
        $scope.step.two = false;
        $scope.step.three = false;
    };
    $scope.goStepTwo = function () {
        $scope.step.one = false;
        $scope.step.two = true;
        $scope.step.three = false;
        $scope.getDetailInfoTwo();
    };
    $scope.goStepThree = function () {
        $scope.step.one = false;
        $scope.step.two = false;
        $scope.step.three = true;
        $scope.getDetailInfoThree();
    };
    $scope.goBack = function () {
        window.location.replace("PageMceGetPrvCheckList.html")
    };
    $scope.showImg = function (value) {
        $scope.certImgUrl = value.SAVE_NAME;
        // $scope.certImgUrl = "../../upload/prv/" + value.SAVE_NAME;
        $(".img_bg").show();
        $(".img").show()
    };
    $scope.closeImg = function () {
        $(".img_bg").hide();
        $(".img").hide()
    };
    //审核
    $scope.prvCheck = function () {
        $http({
            method:"POST",
            url: $rootScope.baseUrl + "service/mce/MCE_PRV/Srv_MCE_SetPrvInfo.ashx",
            data:[$scope.paramObj.id]
        }).then(function (data) {
            var data = data.data;
            if(data.Succeed == 1){
                alert("审核成功");
                $scope.goBack();
            }else{
                alert(data.Message)
            }
        })
    };
    $scope.getDetailId();
    $scope.getDetailInfoOne();
}])