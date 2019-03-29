var app = angular.module("app", ['app.directive', 'app.services']);
app.controller('index', ['$scope', '$http', '$rootScope', 'ParamService', 'ParamS', 'InputschangeState',
 function ($scope, $http, $rootScope, ParamService, ParamS, InputschangeState) {

     $scope.checkSate = {
         state: false
     };
     $rootScope.baseUrl = "../../";
     $scope.InputschangeState = InputschangeState;
     $scope.InputschangeState.states = {
         dept: false
     };

    
     //报废科室
     $scope.dept = ParamS($rootScope.baseUrl + "service/mtr/Srv_MTR_DeptList.ashx");
     $scope.dept.showTabTh = ['编号', '名称', "院区"];
     $scope.dept.showTabTb = ['code', 'name', "areaName"];
     $scope.dept.param = {
         is_area: "0",
         condition: ""
     };
     $scope.paramDept = {
         dept: ""
     };



     $scope.paramObj = {
         code: "",
         status: "",
         finance_cycle: "",
         dept: "",
         write_off_type_id: "",
         beginspan: "",
         endspan: "",
         condition: " and (MCE_B_ASSETS_WRITE_OFF.state=3 or  MCE_B_ASSETS_WRITE_OFF.state=5 or  MCE_B_ASSETS_WRITE_OFF.state=6)"
     };
     $scope.modelList = [];
     $scope.mainPager = ParamService.getPager();
     //列表查询
     $scope.getModelList = function (curIndex) {
         var param = ParamService.comParam(curIndex, $scope.mainPager.pageSize, $scope.paramObj);
         $http({
             method: "GET",
             url: $rootScope.baseUrl + "service/mce/mce_writeoff/Srv_MCE_GetMCEWriteOffList.ashx" + param
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

     $scope.goDetail = function (id) {
         window.location.replace("PageMceWriteOffAuditNew.html?id=" + id)
     };


     $scope.$watch("paramDept", function (n, o) {
         $scope.paramObj.dept = n.dept
     }, true);



     $scope.writeOffTypeList = [];
     $scope.getWriteOffTypeListList = function () {
         $http({
             method: "GET",
             url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=0302&limit=10000"
         }).then(function (data) {
             var data = data.data;
             if (data.Succeed == 1) {
                 $scope.writeOffTypeList = data.Message.rows
             } else {
                 alert(data.Message)
             }
         })
     };


     $scope.getWriteOffTypeListList();
     $scope.getModelList(1)
 }])