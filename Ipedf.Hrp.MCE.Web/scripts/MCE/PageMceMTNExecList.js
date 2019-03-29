var app = angular.module("app", ['app.directive', 'app.services']);
app.controller('index', ['$scope', '$http', '$rootScope', 'ParamService', 'ParamS', 'InputschangeState',
 function ($scope, $http, $rootScope, ParamService, ParamS, InputschangeState) {

     $scope.checkSate = {
         state: false
     };
     $rootScope.baseUrl = "../../";
     $scope.InputschangeState = InputschangeState;
     $scope.InputschangeState.states = {
         user:false
     };

     //负责人
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

     var date = new Date;
     var year = date.getFullYear();
     var month = date.getMonth() + 1;
     month = (month < 10 ? "0" + month : month);

     var vDate = date.getDate() ;
     vDate = (vDate < 10 ? "0" + vDate : vDate);

     var mydate = (year.toString() + "-" + month.toString() + "-" + vDate.toString());

     $scope.paramObj = {
         code: "",
         name: "",
         status: "1",
         user: "",
         mtn_type_id: "",
         beginspan: mydate
     };
     $scope.modelList = [];
     $scope.mainPager = ParamService.getPager();
     //列表查询
     $scope.getModelList = function (curIndex) {
         var param = ParamService.comParam(curIndex, $scope.mainPager.pageSize, $scope.paramObj);
         $http({
             method: "GET",
             url: $rootScope.baseUrl + "service/mce/mce_mt/Srv_MCE_GetMCEMTNExecList.ashx" + param
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
         window.location.replace("PageMceMTNExecNew.html?id=" + id)
     };

     $scope.checkAll = function () {
         $scope.checkSate.state = !$scope.checkSate.state
         for (var i = 0; i < $scope.modelList.length; i++) {
             if($scope.modelList[i].STATE<=1){
             $scope.modelList[i].checked = $scope.checkSate.state
             }
         }
     };
   


     $scope.$watch("paramUser", function (n, o) {
         $scope.paramObj.user = n.user
     }, true);



     $scope.mtnTypeList = [];
     $scope.getMtnTypeListList = function () {
         $http({
             method: "GET",
             url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=MCE_0008&limit=10000"
         }).then(function (data) {
             var data = data.data;
             if (data.Succeed == 1) {
                 $scope.mtnTypeList = data.Message.rows
             } else {
                 alert(data.Message)
             }
         })
     };


     $scope.getMtnTypeListList();

     $scope.getModelList(1)
 }])