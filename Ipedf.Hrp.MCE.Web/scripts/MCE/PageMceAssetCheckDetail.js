var app = angular.module('app', []);
app.controller('index', ['$scope', '$http', '$rootScope', function ($scope, $http, $rootScope) {
    $rootScope.baseUrl = "../../";

    $scope.mceModel = {
        id: "",

        name: "",
        en_name: "",
        spec: "",
        type_id: "",
        type_id_name: "",
        brand_name: "",
        prd_id: "",
        prd_id_name: "",
        prd_code: "",
        unit_id: "",
        licence_code: "",
        price: "",
        prd_date: "",
        prd_place_type_id: "",
        prd_place_type_id_name: "",
        international_code: "",
        technical_para: "",
        configuration: "",
        usage: "",
        picture: "",

        state: -1
    };

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
   
    $scope.getDetailInfo = function () {
        $http({
            method: "GET",
            url: $rootScope.baseUrl + "service/mce/MCE_PRV/Srv_MCE_GetAssetCheckDetail.ashx?id=" + $scope.paramObj.id
        }).then(function (data) {
            var data = data.data;
            if (data.Succeed == 1) {
                $scope.mceModel.id = data.Message.ID;
                $scope.mceModel.state = data.Message.STATE;
                $scope.mceModel.name = data.Message.NAME;
                $scope.mceModel.en_name = data.Message.EN_NAME;
                $scope.mceModel.spec = data.Message.SPEC;

                $scope.mceModel.type_id = data.Message.TYPE_ID;
                $scope.mceModel.type_id_name = data.Message.TYPE_ID_NAME;

                $scope.mceModel.brand_name = data.Message.BRAND_NAME;

                $scope.mceModel.prd_id = data.Message.PRD_ID;
                $scope.mceModel.prd_id_name = data.Message.PRD_ID_NAME;
              
                $scope.mceModel.prd_code = data.Message.PRD_CODE;


                $scope.mceModel.unit_id = data.Message.UNIT_ID
                $scope.mceModel.unit_id_name = data.Message.UNIT_ID_NAME;

                $scope.mceModel.licence_code = data.Message.LICENCE_CODE;
                $scope.mceModel.price = data.Message.PRICE;
                $scope.mceModel.prd_date = data.Message.PRD_DATE;

                $scope.mceModel.prd_place_type_id = data.Message.PRD_PLACE_TYPE_ID;
                $scope.mceModel.prd_place_type_id_name = data.Message.PRD_PLACE_TYPE_ID_NAME;
              
                $scope.mceModel.international_code = data.Message.INTERNATIONAL_CODE;
                $scope.mceModel.technical_para = data.Message.TECHNICAL_PARA;
                $scope.mceModel.configuration = data.Message.CONFIGURATION;
                $scope.mceModel.usage = data.Message.USAGE;
                $scope.mceModel.picture = data.Message.PICTURE;
            } else {
                alert(data.Message)
            }
        })
    };
   
    $scope.goBack = function () {
        window.location.replace("PageMceGetAssetCheckList.html")
    };

    //审核

    $scope.paramAssetObj = {
        idList: [],
        State: "",
        Reason: ""
    };

    $scope.checkAsset = function () {
        var list = [];
        list.push($scope.paramObj.id);
  

        $scope.paramAssetObj.idList = list;
        $scope.paramAssetObj.State = "1";
        $scope.paramAssetObj.Reason = "";

        $("#btnCheck").text("正在审核...");
        $("#btnCheck").attr('disabled', true);

        $http({
            method: "POST",
            url: $rootScope.baseUrl + "service/mce/MCE_PRV/Srv_MCE_SetAssetCheckStatus.ashx",
            data: $scope.paramAssetObj
        }).then(function (data) {
            $("#btnCheck").text("审核");
            $("#btnCheck").attr('disabled', false);

            var data = data.data;
            if (data.Succeed == 1) {
                alert("审核成功");
                $scope.goBack();
            } else {
                alert(data.Message)
            }
        })
    };

    $scope.checkAssetNo = function () {
        var list = [];
        list.push($scope.paramObj.id);


        $scope.paramAssetObj.idList = list;
        $scope.paramAssetObj.State = "2";
        if ($scope.paramAssetObj.Reason == null || $scope.paramAssetObj.Reason == "") {
            alert("请填定拒绝原因");
            return false
        }
        $scope.paramAssetObj.Reason = "";

        $("#btnRefuseCheck").text("正在拒绝审核...");
        $("#btnRefuseCheck").attr('disabled', true);

        $http({
            method: "POST",
            url: $rootScope.baseUrl + "service/mce/MCE_PRV/Srv_MCE_SetAssetCheckStatus.ashx",
            data: $scope.paramAssetObj
        }).then(function (data) {
            $("#btnRefuseCheck").text("拒绝审核");
            $("#btnRefuseCheck").attr('disabled', false);

            var data = data.data;
            if (data.Succeed == 1) {

                alert("拒绝审核成功");
                $scope.newState.state = false;
                $scope.goBack();
            } else {
                alert(data.Message)
            }
        })
    };



    $scope.newState = {
        state: false
    };

    $scope.openNew = function () {

        $scope.newState.state = true;

    };


    $scope.getDetailId();
    $scope.getDetailInfo();
}])