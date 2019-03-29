var app = angular.module("app", ['app.directive', 'app.services', 'treeControl']);
app.controller("index",["$scope",'$http','$rootScope','ParamService','ParamS','InputschangeState',
    function($scope,$http,$rootScope,ParamService,ParamS,InputschangeState){

        $rootScope.baseUrl="../../";

        $scope.paramObj = {
            type_id: "",
            code:"",
            name:"",
            spec:"",
            status:""
        };

        /*
        $scope.mceTypeList = [];
        $scope.mceTypePager = {
            limit: 15,
            offset: 1,
            total: 0,
            page:0,
            condition:""
        };
   
        $scope.getMceTypeList = function (curIndex) {
            $http({
                method:"GET",
                url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCETypeList.ashx?limit=15&offset="
                +$scope.mceTypePager.offset+"&name="+$scope.mceTypePager.condition
            }).then(function (data) {
                var data = data.data;
                if(data.Succeed == 1){
                    $scope.mceTypeList = data.Message.rows;

                    $scope.mceTypePager.total = data.Message.total;
                    $scope.mceTypePager.page = Math.ceil($scope.mceTypePager.total*1 / $scope.mceTypePager.limit);
                    for(var i=0;i<$scope.mceTypeList.length;i++){
                        $scope.mceTypeList.onsel = false;
                    }
                }else{
                    alert(data.Message)
                }
            })
        };
        $scope.changeMceTypeSel=function (value) {
            if(value.onsel){
                value.onsel = false;
                $scope.paramObj.type_id = "";
            }else{
                for(var i=0;i<$scope.mceTypeList.length;i++){
                    $scope.mceTypeList[i].onsel = false
                }
                value.onsel = true;
                $scope.paramObj.type_id = value.ID
            }
            $scope.getModelList(1)
        };
        $scope.nextPage=function () {
            $scope.mceTypePager.offset += 1;
            $scope.getMceTypeList();
        };
        $scope.curPage=function () {
            $scope.mceTypePager.offset -= 1;
            $scope.getMceTypeList();
        };
        $scope.firstPage=function () {
            $scope.mceTypePager.offset=1;
            $scope.getMceTypeList();
        };
        $scope.lastPage=function () {
            $scope.mceTypePager.offset=$scope.mceTypePager.page;
            $scope.getMceTypeList();
        };
        */
        

        $scope.checkSate = {
            state: false
        };
        $scope.checkAll = function () {
            $scope.checkSate.state = !$scope.checkSate.state
            for (var i = 0; i < $scope.modelList.length; i++) {
                if($scope.modelList[i].STATE == 1){
                $scope.modelList[i].checked = $scope.checkSate.state
                }
            }
        };

        /*
        $scope.InputschangeState = InputschangeState;
        $scope.InputschangeState.states = {
            dept:false,
            stock:false,
            user:false,
            audit:false
        };

        $scope.dept = ParamS($rootScope.baseUrl + "service/mtr/Srv_MTR_DeptList.ashx");
        $scope.dept.showTabTh = ['编号','名称',"院区"];
        $scope.dept.showTabTb = ['code','name',"areaName"];
        $scope.dept.param = {
            is_area: "0",
            condition: ""
        };
        $scope.paramDept={
            dept:""
        };
       */

        $scope.modelList=[];
        $scope.mainPager = ParamService.getPager();
        //列表查询
        $scope.getModelList=function(curIndex){
            var param = ParamService.comParam(curIndex, $scope.mainPager.pageSize, $scope.paramObj);
            $http({
                method:"GET",
                url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCEAssetsList.ashx" + param
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
                url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetseDelete.ashx",
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
            window.location.replace('assetCard.html?history=' + html[html.length - 1] + '&id=' +id)


           // window.location.replace("assetCard.html?id=" + id)
        };


        $scope.dataForTheTree = [];
        $scope.showSelected = function (node, selected) {
            $scope.paramObj.type_id = node.id;
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

       // $scope.getMceTypeList();

        $scope.getModelList(1);


    }])