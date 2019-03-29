var app = angular.module("app", ['app.directive', 'app.services', 'treeControl']);
app.controller("index",["$scope",'$http','$rootScope','ParamService','ParamS','InputschangeState',
    function($scope,$http,$rootScope,ParamService,ParamS,InputschangeState){

        $rootScope.baseUrl="../../";


        $scope.paramObj = {
            id: "",
            history: ""
        };

        $scope.assertTypeModel = {
            id: "",
            name: "",
            code: "",
            state: 1,
            parent_id: ""
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



        $scope.getDetailInfo = function () {
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCETypeDetail.ashx?id=" + $scope.paramObj.id
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.assertTypeModel.id = data.Message.head.ID;
                    $scope.assertTypeModel.name = data.Message.head.NAME;
                    $scope.assertTypeModel.code = data.Message.head.CODE;
                    $scope.assertTypeModel.state = data.Message.head.STATE;
                    $scope.assertTypeModel.parent_id = data.Message.head.PARENT_ID;

                } else {
                    alert(data.Message)
                }
            })
        };


        $scope.saveModel = function () {
            if ($scope.assertTypeModel.parent_id == "" || $scope.assertTypeModel.parent_id == null) {
                alert("请选择父类");
                return;
            }

            if ($scope.assertTypeModel.name == "" || $scope.assertTypeModel.name == null) {
                alert("请输入分类名称");
                return;
            }

            if ($scope.assertTypeModel.code == "" || $scope.assertTypeModel.code == null) {
                alert("请输入分类编码");
                return;
            }

            if ($scope.assertTypeModel.state == "" || $scope.assertTypeModel.state == null) {
                alert("请选择状态");
                return;
            }


            $http({
                method: "POST",
                url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCETypeSave.ashx",
                data: $scope.assertTypeModel
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
            window.location.replace($scope.paramObj.history)
        };


        $scope.dataForTheTree = [];
        $scope.showSelected = function (node, selected) {

            if ($scope.paramObj.id == '' || $scope.paramObj.id == null) {
                $scope.assertTypeModel.parent_id = node.id;
            }
        };

        $scope.getMceTypeTree = function () {
            $http({
                url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCETypeTree.ashx",
                method: "GET"
            }).then(function (data) {
                if (data.data.Succeed == 1) {
                    $scope.dataForTheTree = data.data.Message
                }
            })
        };


        $scope.getMceTypeTree();

        $scope.getDetailId();
        
        if ($scope.paramObj.id != null && $scope.paramObj.id != '') {
            $scope.getDetailInfo();
        }

    }])