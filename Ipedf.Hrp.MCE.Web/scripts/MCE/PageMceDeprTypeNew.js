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
        $scope.headInfo = {
            ID: "",
            CODE:"",
            NAME: "",
            YEARLY_SCALE: 0,
            MONTHLY_SCALE: 0,

            STATE: 1
        };
 

        $scope.InputschangeState = InputschangeState;
        $scope.InputschangeState.states = {
      
        };


        //获取详情
        $scope.getDetailInfo = function () {
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mce/MCE_DEPR/Srv_MCE_GetMCEDeprTypeDetail.ashx?id=" + $scope.paramObj.id
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
            
                    $scope.headInfo.ID = data.Message.head.ID;
                    $scope.headInfo.CODE = data.Message.head.CODE;
                    $scope.headInfo.NAME = data.Message.head.NAME;
                    $scope.headInfo.YEARLY_SCALE = data.Message.head.YEARLY_SCALE;
                    $scope.headInfo.MONTHLY_SCALE = data.Message.head.MONTHLY_SCALE;
                  

                    $scope.headInfo.STATE = data.Message.head.STATE;
         



                } else {
                    alert(data.Message)
                }
            })
        };
      
        $scope.saveModel=function (vType) {
          
          
            if ($scope.headInfo.CODE == "") {
                alert("请输入编码");
                return
            }
            if ($scope.headInfo.NAME == "") {
                alert("请输入名称");
                return
            }
     


            $http({
                method:"POST",
                url: $rootScope.baseUrl + "service/mce/MCE_DEPR/Srv_MCE_MCEDeprTypeSave.ashx",
                data: $scope.headInfo
            }).then(function (data) {
                var data = data.data;
                if(data.Succeed == 1){
                    alert("保存成功");

                    if (vType == '1') {
                        $scope.paramObj.id = data.Message;
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

        $scope.getMonthScale = function () {
            var vMonth = $scope.headInfo.YEARLY_SCALE / 12.0000;
            $scope.headInfo.MONTHLY_SCALE = vMonth.toFixed(4);
        };


        $scope.goBack = function () {
            window.location.replace("PageMceDeprTypeList.html")
        };

        $scope.default = function () {
            $scope.getDetailId();
          
            if ($scope.paramObj.id != "") {
        
                $scope.getDetailInfo();

            }


        };
        $scope.default();


    }])