var app = angular.module("app", ['app.directive', 'app.services']);
app.controller('index', ['$scope', '$http', '$rootScope', 'ParamService', 'ParamS', 'InputschangeState',
    function ($scope, $http, $rootScope, ParamService, ParamS, InputschangeState) {

        $rootScope.baseUrl = "../../";

  
        $scope.paramObj = {
            id: ""
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

            var par = urlArgs();
            if (par.id) {
                $scope.paramObj.id = par.id;
            }

        };
        $scope.assetModel = {
        };
      
        $scope.InputschangeState = InputschangeState;
        $scope.InputschangeState.states = {
    
        };


        //获取详情
        $scope.getDetailInfo = function () {
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mce/mce_plan/Srv_MCE_GetPurchaseDetail.ashx?id=" + $scope.paramObj.id
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
             
                    $scope.assetModel = data.Message;
                    if($scope.assetModel.PURCHASE_TYPE_ID!=null)
                    {
                        $scope.assetModel.PRD_ID_NAME = $scope.assetModel.PRD_NAME;
                        $scope.assetModel.PRV_ID_NAME = $scope.assetModel.PRV_NAME;
                        $scope.assetModel.PURCHASE_TYPE_ID = $scope.assetModel.PURCHASE_TYPE_ID.trim();
                        $scope.assetModel.UNIT_ID_NAME = $scope.assetModel.UNIT_NAME;
                    }

                } else {
                    alert(data.Message)
                }
            })
        };
      

        $scope.submitModel = function () {
            var flag = confirm("是否确认提交？");
            if (!flag) {
                return false
            }

            var list = [];

            if ($scope.paramObj.id == null || $scope.paramObj.id == "") {
                alert("请先保存再提交！");
                return;
            }
            else {
                list.push($scope.paramObj.id);
                $http.post($rootScope.baseUrl + "service/mce/mce_plan/Srv_MCE_MCEPurchaseOperate.ashx?oType=submit", list).success(function (data) {
                    if (data.Succeed == 1) {
                        alert("提交成功！");
                        $scope.getDetailInfo();
                    } else {
                        alert(data.Message + "提交失败！");
                    }
                })
            }
        };

        $scope.auditModel = function () {
            var flag = confirm("是否确认审核？");
            if (!flag) {
                return false
            }

            var list = [];

            if ($scope.paramObj.id == null || $scope.paramObj.id == "") {
                alert("请先保存再提交、审核！");
                return;
            }
            else {
                list.push($scope.paramObj.id);
                $http.post($rootScope.baseUrl + "service/mce/mce_plan/Srv_MCE_MCEPurchaseOperate.ashx?oType=audit", list).success(function (data) {
                    if (data.Succeed == 1) {
                        alert("审核成功！");
                        $scope.getDetailInfo();
                    } else {
                        alert(data.Message + "审核失败！");
                    }
                })
            }
        };


        $scope.saveModel=function (vType) {
         
            if ($scope.assetModel.APPLY_MONEY * 1 <= 0 || isNaN($scope.assetModel.APPLY_MONEY * 1)) {
                alert("请输入正确的预算金额");
                return;
            }
           

            $http({
                method:"POST",
                url: $rootScope.baseUrl + "service/mce/mce_plan/Srv_MCE_MCEPurchaseSave.ashx",
                data: $scope.assetModel
            }).then(function (data) {
                var data = data.data;
                if(data.Succeed == 1){
                    alert("保存成功");

                    if (vType == '1') {
                        $scope.getDetailInfo();
                    }
                    else {
                        $scope.goBack();
                    }
                }else{
                    alert(data.Message)
                }
            })


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


        $scope.goBack = function () {
            window.location.replace("PageMcePurchaseList.html")
        };

        $scope.default = function () {
            $scope.getDetailId();
            $scope.getPurchaseTypeList();
            $scope.getDetailInfo();
        };

        $scope.default();


    }])