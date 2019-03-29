var app = angular.module("app",['app.directive', 'app.services']);
app.controller('index', ['$scope','$http','$rootScope','ParamService','ParamS','InputschangeState',
 function($scope,$http,$rootScope,ParamService,ParamS,InputschangeState){

    $scope.checkSate={
        state:false
    };

    $scope.checkDeptSate = {
        state: false
    };

	$rootScope.baseUrl="../../";

	$scope.getHosList = function () {
	    $http({
	        method: "GET",
	        url: $rootScope.baseUrl + "service//mtr/Srv_MTR_HospitalAreaList.ashx"
	    }).then(function (data) {
	        var data = data.data;
	        if (data.Succeed == 1) {
	            $scope.hosList = data.Message;
	            $scope.hosList.unshift({ id: "", name: "--院区选择--" });
	            for (var i = 0; i < $scope.hosList.length; i++) {
	                $scope.hosList[i].id = $scope.hosList[i].id.trim()
	            }
	        } else {
	            alert(data.Message)
	        }
	    })
	};


	$scope.paramObj = {
	    mcetype_id: "",
        area:"",
        condition: "",
        history: ""
	};

	$scope.paramDeptObj = {
	    area: "",
	    condition: ""
	};

	$scope.modelList = [];
	$scope.modelDeptList = [];
	$scope.mainPager = ParamService.getPager();
	$scope.mainDeptPager = ParamService.getPager();

     //列表查询
	$scope.getModelList = function (curIndex) {
	    var param = ParamService.comParam(curIndex, $scope.mainPager.pageSize, $scope.paramObj);
	    $http({
	        method: "GET",
	        url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCETypeDeptList.ashx" + param
	    }).then(function (data) {
	        var data = data.data;
	        if (data.Succeed == 1) {
	            $scope.modelList = data.Message.rows;
	            $scope.mainPager.setDataNum(data.Message.total);
	            $scope.mainPager.setCurIndex(curIndex);
	            for (var i = 0; i < $scope.modelList.length; i++) {
	                $scope.modelList[i].checked = false;

	                $scope.modelList[i].onsel = false;
	            }
	        }
	    })
	};


    //Dept列表查询
    $scope.getModelDeptList=function(curIndex){
        var param = ParamService.comParam(curIndex, $scope.mainDeptPager.pageSize, $scope.paramDeptObj);
    	$http({
    		method:"GET",
    		url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCETypeDeptList.ashx" + param
    	}).then(function(data){
    		var data = data.data;
    		if(data.Succeed == 1){
    		    $scope.modelDeptList = data.Message.rows;
    		    $scope.mainDeptPager.setDataNum(data.Message.total);
    		    $scope.mainDeptPager.setCurIndex(curIndex);
                for (var i = 0; i < $scope.modelDeptList.length; i++) {
                    $scope.modelDeptList[i].checked = false;
              
                }
    		}
    	})
    };

     $scope.changeOnSel=function(index){
         for(var i=0;i<$scope.modelList.length;i++){
             $scope.modelList[i].onsel = false;
         }
         $scope.modelList[index].onsel = true;
     };

     $scope.checkAll=function () {
         $scope.checkSate.state = !$scope.checkSate.state
         for(var i=0;i<$scope.modelList.length;i++){
                $scope.modelList[i].checked = $scope.checkSate.state
         }
     };

     $scope.checkAllDept = function () {
         $scope.checkDeptSate.state = !$scope.checkDeptSate.state
         for (var i = 0; i < $scope.modelDeptList.length; i++) {
             $scope.modelDeptList[i].checked = $scope.checkDeptSate.state
         }
     };

     $scope.paramObjDept = {
         id: "",
         listDeptID: []
     };
     $scope.addInfo = function () {
         var list=[];
         for (var i = 0; i < $scope.modelDeptList.length; i++) {
             if ($scope.modelDeptList[i].checked == true) {
                 list.push($scope.modelDeptList[i].id)
            }
         }
         if(list.length == 0){
             alert("请选择");
             return false
         }

         $scope.paramObjDept.id = $scope.paramObj.mcetype_id;
         $scope.paramObjDept.listDeptID = list;

         $http({
             method:"POST",
             url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCETypeDeptSave.ashx",
             data: $scope.paramObjDept
         }).then(function (data) {
             var data = data.data;
             if(data.Succeed == 1){
                 alert("保存成功");
                 $scope.getModelList(1);
                 $scope.newState.state = false;
             }else{
                 alert(data.Message)
             }
         })
     };

     $scope.delInfo = function () {
         var list = [];
         for (var i = 0; i < $scope.modelList.length; i++) {
             if ($scope.modelList[i].checked) {
                 list.push($scope.modelList[i].id)
             }
         }
         if (list.length == 0) {
             alert("请选择");
             return false
         }

         $scope.paramObjDept.id = $scope.paramObj.mcetype_id;
         $scope.paramObjDept.listDeptID = list;

         var flag = confirm("是否确认删除？");
         if (!flag) {
             return false
         }

         $http({
             method: "POST",
             url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCETypeDeptDelete.ashx",
             data: $scope.paramObjDept
         }).then(function (data) {
             var data = data.data;
             if (data.Succeed == 1) {
                 alert("删除成功");
                 $scope.getModelList(1);
             } else {
                 alert(data.Message)
             }
         })
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

     $scope.newState = {
         state: false
     };

     $scope.openNew = function () {

         for (var i = 0; i < $scope.modelDeptList.length; i++) {
             $scope.modelDeptList[i].checked = false;
         }

         $scope.newState.state = true;
  
     };

     $scope.goBack = function () {
         window.location.replace($scope.paramObj.history)
     };

     $scope.getDetailId();
   //  $scope.getDetailInfo();
     $scope.getHosList();
     $scope.getModelList(1);
     $scope.getModelDeptList(1);
}])