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
    

     //合同乙方
     $scope.dept = ParamS($rootScope.baseUrl + "service/mtr/Srv_MTR_PrvList.ashx");
     $scope.dept.showTabTh = ['编号', '名称'];
     $scope.dept.showTabTb = ['code', 'name'];
     $scope.dept.param = {
         condition: "",
         type: "00340005"
     };
     $scope.paramDept = {
         dept: ""
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
         name: "",
         status: "2",
         dept: "",
         beginspan: mydate
     };
     $scope.modelList = [];
     $scope.mainPager = ParamService.getPager();
     //列表查询
     $scope.getModelList = function (curIndex) {
         var param = ParamService.comParam(curIndex, $scope.mainPager.pageSize, $scope.paramObj);
         $http({
             method: "GET",
             url: $rootScope.baseUrl + "service/mce/MCE_CONTRACT/Srv_MCE_GetMCEContractPayList.ashx" + param
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

     $scope.checkAll = function () {
         $scope.checkSate.state = !$scope.checkSate.state
         for (var i = 0; i < $scope.modelList.length; i++) {
             if($scope.modelList[i].STATE==2){
             $scope.modelList[i].checked = $scope.checkSate.state
             }
         }
     };
   

     $scope.$watch('paramDept', function (n, o) {
         if (n != undefined) {
             $scope.paramObj.dept = n.dept
         }
     }, true);




     $scope.payModel = function () {
         var flag = confirm("是否确认付款？");
         if (!flag) {
             return false
         }

         var list = [];

         for (var i = 0; i < $scope.modelList.length; i++) {
             if ($scope.modelList[i].STATE === 2 && $scope.modelList[i].checked == true) {
                 list.push($scope.modelList[i].ID);
             }
         }

         if (list == null || list.length == 0) {
             alert("请选择要付款的数据！");
             return;
         }
         else {
             $http.post($rootScope.baseUrl + "service/mce/MCE_CONTRACT/Srv_MCE_MCEContractPay.ashx", list).success(function (data) {
                 if (data.Succeed == 1) {
                     alert("付款成功！");
                     $scope.getModelList();
                 } else {
                     alert(data.Message + "付款失败！");
                 }
             })
         }
     };


     $scope.getModelList(1)
 }])