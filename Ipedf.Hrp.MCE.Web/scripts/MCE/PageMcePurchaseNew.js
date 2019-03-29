var app = angular.module("app", ['app.directive', 'app.services']);
app.controller('index', ['$scope', '$http', '$rootScope', 'ParamService', 'ParamS', 'InputschangeState',
    function ($scope, $http, $rootScope, ParamService, ParamS, InputschangeState) {

        $rootScope.baseUrl = "../../";


        $scope.stepObj = {
            one: true,
            two: false
        };

        $scope.InputschangeState = InputschangeState;
        $scope.InputschangeState.states = {
            type: false
        };

        //设备分类
        $scope.type = ParamS($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCETypeList.ashx");
        $scope.type.showTabTh = ['分类编码', '分类名称'];
        $scope.type.showTabTb = ['CODE', 'NAME'];
        $scope.type.param = {
            status: 1
        };
        $scope.paramType = {
            type: ""
        };
        $scope.$watch("paramType", function (n, o) {
            $scope.paramObj.typeid = n.type.trim();
     
        }, true);

        $scope.assetsList = [];


        $scope.paramObj = {
            state: 1,
            typeid:"",
            name: ""
        };
      
        $scope.mainPager = ParamService.getPager();
        $scope.getAssetsList = function (curIndex) {
            var param = ParamService.comParam(curIndex, $scope.mainPager.pageSize, $scope.paramObj);
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mce/MCE_PRV/Srv_MCE_GetAssetCheckList.ashx" + param
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.assetsList = data.Message.rows;
                    $scope.mainPager.setDataNum(data.Message.total);
                    $scope.mainPager.setCurIndex(curIndex);

                    for (var i = 0; i < $scope.assetsList.length; i++) {
                        $scope.assetsList[i].CODE = "";
                        $scope.assetsList[i].TYPE_ID = $scope.assetsList[i].TYPE_ID;
                        $scope.assetsList[i].ASSET_ID = $scope.assetsList[i].ID;
                        $scope.assetsList[i].ASSET_NAME = $scope.assetsList[i].NAME;
                        $scope.assetsList[i].ID = "";
                        $scope.assetsList[i].ID = "";
                        $scope.assetsList[i].APPLY_AMOUNT = 0;
                        $scope.assetsList[i].APPLY_MONEY = 0;
                        $scope.assetsList[i].APPLY_PRICE = $scope.assetsList[i].PRICE;
                        $scope.assetsList[i].PURCHASE_TYPE_ID = "";
                        $scope.assetsList[i].COMMENTS = "";
                    }
                } else {
                    alert(data.Message)
                }
            })
        };




        $scope.assetModel = {
            NAME: "",
            SPEC: "",
            APPLY_MONEY:0
        };
        $scope.goStepTwo = function (v) {

            if (v.APPLY_AMOUNT * 1 <= 0 || isNaN(v.APPLY_AMOUNT * 1))
            {
                alert("请输入正确的申购数量");
                return;
            }

            $scope.purchaseTypeList = [];
            $scope.getPurchaseTypeList();


            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_GetMCEAssetsUserInfo.ashx?code_type=McePurchase"
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    v.CODE = data.Message.code;
                    $scope.assetModel = v;
                    $scope.stepObj.one = false;
                    $scope.stepObj.two = true;
                } else {
                    alert(data.Message)
                }
            })
   
        };


        $scope.goSteOne = function () {
            $scope.stepObj.one = true;
            $scope.stepObj.two = false;
        };

        $scope.saveModel = function (v) {
          
            if (v.APPLY_MONEY * 1 <= 0 || isNaN(v.APPLY_MONEY * 1)) {
                alert("请输入正确的预算金额");
                return;
            }
        

            $http({
                method: "POST",
                url: $rootScope.baseUrl + "service/mce/mce_plan/Srv_MCE_MCEPurchaseSave.ashx",
                data: v
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    alert("保存成功");

                    $scope.goBack();
                    
                } else {
                    alert(data.Message)
                }
            })


        };


        $scope.goBack = function () {
            window.location.replace("PageMcePurchaseList.html")
        };


        //获得购置类型
        $scope.purchaseTypeList = [];
        $scope.getPurchaseTypeList = function () {
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=0055&limit=10000"
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.purchaseTypeList = data.Message.rows
                } else {
                    alert(data.Message)
                }
            })
        };


        $scope.getAssetsList(1);
       
  

    }])