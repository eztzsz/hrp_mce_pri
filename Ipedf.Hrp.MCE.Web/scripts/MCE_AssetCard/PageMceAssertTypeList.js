var app = angular.module("app", ['app.directive', 'app.services', 'treeControl']);
app.controller("index",["$scope",'$http','$rootScope','ParamService','ParamS','InputschangeState',
    function($scope,$http,$rootScope,ParamService,ParamS,InputschangeState){

        $rootScope.baseUrl="../../";

        $scope.paramObj = {
            parent_id: "",
            code:"",
            name:"",
            status:""
        };


        $scope.checkSate = {
            state: false
        };
        $scope.checkAll = function () {
            $scope.checkSate.state = !$scope.checkSate.state
            for (var i = 0; i < $scope.modelList.length; i++) {
                if($scope.modelList[i].STATE == 2){
                $scope.modelList[i].checked = $scope.checkSate.state
                }
            }
        };

        $scope.modelList=[];
        $scope.mainPager = ParamService.getPager();
        //列表查询
        $scope.getModelList=function(curIndex){
            var param = ParamService.comParam(curIndex, $scope.mainPager.pageSize, $scope.paramObj);
            $http({
                method:"GET",
                url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCETypeList.ashx" + param
            }).then(function(data){
                var data = data.data;
                if(data.Succeed == 1){
                    $scope.modelList=data.Message.rows;
                    $scope.mainPager.setDataNum(data.Message.total);
                    $scope.mainPager.setCurIndex(curIndex);
                    for(var i=0;i<$scope.modelList.length;i++){
                        $scope.modelList[i].checked = false
                    }
                    
                }
            })
        };
     ;
        $scope.delModel=function () {
            var list = [];
            for(var i=0;i<$scope.modelList.length;i++){
                if($scope.modelList[i].checked){
                    list.push($scope.modelList[i].ID)
                }
            }
            if(list.length==0){
                alert("请选择");
                return false
            }

            var flag = confirm("是否确认删除？");
            if (!flag) {
                return false
            }

            $http({
                method:"POST",
                url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCETypeDelete.ashx",
                data:list
            }).then(function (data) {
                var data =data.data;
                if(data.Succeed == 1){
                    alert("删除成功");
                    $scope.getModelList(1);
                }else{
                    alert(data.Message)
                }
            })
        };

    
        $scope.goDetail = function (id) {
            var html = window.location.pathname.split('/');
            window.location.replace('PageMceAssertTypeDetail.html?history=' + html[html.length - 1] + '&id=' + id)
        };

        $scope.goAssertTypeDept = function (id) {
            var html = window.location.pathname.split('/');
            window.location.replace('PageMceAssertTypeDept.html?history=' + html[html.length - 1] + '&mcetype_id=' + id)
        };

        $scope.dataForTheTree = [];
        $scope.showSelected = function (node, selected) {
            $scope.paramObj.parent_id = node.id;
            $scope.getModelList(1);     
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

        $scope.getModelList(1);


    }])