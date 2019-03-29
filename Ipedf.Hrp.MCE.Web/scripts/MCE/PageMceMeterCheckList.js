var app = angular.module("app", ['app.directive', 'app.services']);
app.controller('index', ['$scope', '$http', '$rootScope', 'ParamService', 'ParamS', 'InputschangeState',
 function ($scope, $http, $rootScope, ParamService, ParamS, InputschangeState) {

     $scope.checkSate = {
         state: false
     };
     $rootScope.baseUrl = "../../";
     $scope.InputschangeState = InputschangeState;
     $scope.InputschangeState.states = {
         dept: false,
         asset: false
     };
     //报修科室
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

     //设备
     $scope.asset = ParamS($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCEAssetsList.ashx");
     $scope.asset.showTabTh = ['设备编号', '设备名称','规格'];
     $scope.asset.showTabTb = ['ASSETS_CODE', 'NAME', 'SPEC'];
     $scope.asset.param = {
         assets_state: "00530002",
         condition: "",
         needTotal: "0",
         dropdown:"1"
     };
     $scope.paramAsset = {
         asset: ""
     };


     var date = new Date;
     var year = date.getFullYear();
     var month = date.getMonth() + 1;
     month = (month < 10 ? "0" + month : month);

     var vDate = date.getDate();
     vDate = (vDate < 10 ? "0" + vDate : vDate);

     var mydate = (year.toString() + "-" + month.toString() + "-" + vDate.toString());

     $scope.paramObj = {
         code: "",
         status: "1",
         asset: "",
         dept: "",
         meter_type: "",
         beginspan: mydate
     };
     $scope.modelList = [];
     $scope.mainPager = ParamService.getPager();
     //列表查询
     $scope.getModelList = function (curIndex) {
         var param = ParamService.comParam(curIndex, $scope.mainPager.pageSize, $scope.paramObj);
         $http({
             method: "GET",
             url: $rootScope.baseUrl + "service/mce/mce_meter/Srv_MCE_GetMCEMeterCheckList.ashx" + param
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
         window.location.replace("PageMceMeterCheckNew.html?id=" + id)
     };
     $scope.checkAll = function () {
         $scope.checkSate.state = !$scope.checkSate.state
         for (var i = 0; i < $scope.modelList.length; i++) {
             if($scope.modelList[i].STATE<=1){
             $scope.modelList[i].checked = $scope.checkSate.state
             }
         }
     };
   

     $scope.$watch('paramDept', function (n, o) {
         if (n != undefined) {
             $scope.paramObj.dept = n.dept
         }
     }, true);


     $scope.$watch("paramAsset", function (n, o) {
         $scope.paramObj.asset = n.asset
     }, true);



     $scope.meterTypeList = [];
     $scope.getMeterTypeList = function () {
         $http({
             method: "GET",
             url: $rootScope.baseUrl + "service/mce/mce_meter/Srv_MCE_GetMCEMeterTypeList.ashx?status=1&limit=10000"
         }).then(function (data) {
             var data = data.data;
             if (data.Succeed == 1) {
                 $scope.meterTypeList = data.Message.rows
             } else {
                 alert(data.Message)
             }
         })
     };


     $scope.getMeterTypeList();

     $scope.getModelList(1)
 }])