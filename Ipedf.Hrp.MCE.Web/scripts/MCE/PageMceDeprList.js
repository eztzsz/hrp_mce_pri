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
         user:false
     };
  
    
     //计提科室
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


     //计提人
     $scope.user = ParamS($rootScope.baseUrl + "service/mtr/mtr_high_basic/Srv_MTR_High_GetUserList.ashx");
     $scope.user.showTabTh = ['用户名', '姓名'];
     $scope.user.showTabTb = ['ACCOUNT', 'NAME'];
     $scope.user.param = {
         name: "",
         condition: ""
     };
     $scope.paramUser = {
         user: ""
     };


     $scope.paramObj = {
         code: "",
         status: "",
         finance_cycle: "",
         dept: "",
         user: "",
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
             url: $rootScope.baseUrl + "service/mce/MCE_DEPR/Srv_MCE_GetMCEDeprList.ashx" + param
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
         window.location.replace("PageMceDeprNew.html?id=" + id)
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
             $http.post($rootScope.baseUrl + "service/mce/MCE_DEPR/Srv_MCE_MCEDeprOperate.ashx?oType=delete", list).success(function (data) {
                 if (data.Succeed == 1) {
                     alert("删除成功！");
                     $scope.getModelList();
                 } else {
                     alert(data.Message + "删除失败！");
                 }
             })
         }
     };

  
     $scope.$watch("paramDept", function (n, o) {
         $scope.paramObj.dept = n.dept
     }, true);


     $scope.$watch("paramUser", function (n, o) {
         $scope.paramObj.user = n.user
     }, true);

     $scope.getModelList(1)
 }])