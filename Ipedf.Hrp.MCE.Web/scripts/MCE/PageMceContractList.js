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



     $scope.paramObj = {
         code: "",
         name: "",
         status: "",
         contract_status:"",
         dept: "",
         contract_type_id: "",
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
             url: $rootScope.baseUrl + "service/mce/MCE_CONTRACT/Srv_MCE_GetMCEContractList.ashx" + param
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
         window.location.replace("PageMceContractNew.html?id=" + id)
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
             $http.post($rootScope.baseUrl + "service/mce/MCE_CONTRACT/Srv_MCE_MCEContractOperate.ashx?oType=delete", list).success(function (data) {
                 if (data.Succeed == 1) {
                     alert("删除成功！");
                     $scope.getModelList();
                 } else {
                     alert(data.Message + "删除失败！");
                 }
             })
         }
     };

     $scope.continueModel = function (vID) {
         var flag = confirm("是否确认续签？");
         if (!flag) {
             return false
         }

         var list = [];
         list.push(vID);
  
        $http.post($rootScope.baseUrl + "service/mce/MCE_CONTRACT/Srv_MCE_MCEContractOperate.ashx?oType=continue", list).success(function (data) {
            if (data.Succeed == 1) {
                alert("续签成功！");
                $scope.getModelList();
            } else {
                alert(data.Message + "续签失败！");
            }
        })
         
     };

 

     $scope.$watch("paramDept", function (n, o) {
         $scope.paramObj.dept = n.dept
     }, true);



     $scope.contractTypeList = [];
     $scope.getContractTypeList = function () {
         $http({
             method: "GET",
             url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=COM_1006&limit=10000"
         }).then(function (data) {
             var data = data.data;
             if (data.Succeed == 1) {
                 $scope.contractTypeList = data.Message.rows
             } else {
                 alert(data.Message)
             }
         })
     };


     $scope.getContractTypeList();
     $scope.getModelList(1)
 }])