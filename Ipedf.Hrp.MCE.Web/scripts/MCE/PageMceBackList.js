var app = angular.module("app", ['app.directive', 'app.services']);
app.controller('index', ['$scope', '$http', '$rootScope', 'ParamService', 'ParamS', 'InputschangeState',
 function ($scope, $http, $rootScope, ParamService, ParamS, InputschangeState) {

     $scope.checkSate = {
         state: false
     };
     $rootScope.baseUrl = "../../";
     $scope.InputschangeState = InputschangeState;
     $scope.InputschangeState.states = {
         returndept: false,
         returnuser: false,
     };
     //转出科室
     $scope.returndept = ParamS($rootScope.baseUrl + "service/mtr/Srv_MTR_DeptList.ashx");
     $scope.returndept.showTabTh = ['编号', '名称', "院区"];
     $scope.returndept.showTabTb = ['code', 'name', "areaName"];
     $scope.returndept.param = {
         is_area: "0",
         condition: ""
     };
     $scope.paramReturnDept = {
         returndept: ""
     };

     //退库人
     $scope.returnuser = ParamS($rootScope.baseUrl + "service/mtr/mtr_high_basic/Srv_MTR_High_GetUserList.ashx");
     $scope.returnuser.showTabTh = ['用户名', '姓名'];
     $scope.returnuser.showTabTb = ['ACCOUNT', 'NAME'];
     $scope.returnuser.param = {
         name: "",
         condition: ""
     };
     $scope.paramReturnUser = {
         returnuser: ""
     };

     $scope.paramObj = {
         code: "",
         status: "",
         returnuser: "",
         returndept: "",
         beginspan: "",
         endspan: ""
     };
     $scope.modelList = [];
     $scope.mainPager = ParamService.getPager();
     //列表查询
     $scope.getModelList = function (curIndex) {
         var param = ParamService.comParam(curIndex, $scope.mainPager.pageSize, $scope.paramObj);
         $http({
             method: "GET",
             url: $rootScope.baseUrl + "service/mce/mce_outstock/Srv_MCE_GetMCEBackList.ashx" + param
         }).then(function (data) {
             var data = data.data;
             if (data.Succeed == 1) {
                 $scope.modelList = data.Message.rows;
                 $scope.mainPager.setDataNum(data.Message.total);
                 $scope.mainPager.setCurIndex(curIndex);
                 for (var i = 0; i < $scope.modelList.length; i++) {
                     $scope.modelList[i].checked = false;
                     $scope.modelList[i].onsel = false
                 }
             }
         })
     };
     $scope.changeOnSel = function (index) {
         for (var i = 0; i < $scope.modelList.length; i++) {
             $scope.modelList[i].onsel = false;
         }
         $scope.modelList[index].onsel = true;
     };
     $scope.goDetail = function (id) {
         window.location.replace("PageMceBackNew.html?id=" + id)
     };
     $scope.checkAll = function () {
         $scope.checkSate.state = !$scope.checkSate.state
         for (var i = 0; i < $scope.modelList.length; i++) {
             if($scope.modelList[i].STATE<=1){
             $scope.modelList[i].checked = $scope.checkSate.state
             }
         }
     };
   
     $scope.deleteModel = function () {
         var flag = confirm("是否确认删除？");
         if (!flag) {
             return false
         }

         var list = [];

         for (var i = 0; i < $scope.modelList.length; i++) {
             if ($scope.modelList[i].STATE <= 1 && $scope.modelList[i].checked==true) {
                 list.push($scope.modelList[i].ID);
             }
         }

         if (list == null || list.length == 0) {
             alert("请选择要删除的数据！");
             return;
         }
         else {
             $http.post($rootScope.baseUrl + "service/mce/mce_outstock/Srv_MCE_MCEBackOperate.ashx?oType=delete", list).success(function (data) {
                 if (data.Succeed == 1) {
                     alert("删除成功！");
                     $scope.getModelList();
                 } else {
                     alert(data.Message + "删除失败！");
                 }
             })
         }
     };

     $scope.$watch('paramReturnDept', function (n, o) {
         if (n != undefined) {
             $scope.paramObj.returndept = n.returndept
         }
     }, true);


     $scope.$watch("paramReturnUser", function (n, o) {
         $scope.paramObj.returnuser = n.returnuser
     }, true);

     $scope.getModelList(1)
 }])