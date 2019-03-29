var app = angular.module("app",['app.directive', 'app.services']);
app.controller('index', ['$scope','$http','$rootScope','ParamService','ParamS','InputschangeState',
 function($scope,$http,$rootScope,ParamService,ParamS,InputschangeState){

    $scope.fileSrc="";
    $scope.checkSate={
        state:false
    };
	$rootScope.baseUrl="../../";
	$scope.InputschangeState = InputschangeState;
	$scope.InputschangeState.states={
		prv:false
	};

	$scope.paramObj={
	    state: "",
	    prd: "",
	    name: ""
	};
    $scope.modelList=[];
    $scope.mainPager = ParamService.getPager();
    //列表查询
    $scope.getModelList=function(curIndex){
        var param = ParamService.comParam(curIndex, $scope.mainPager.pageSize, $scope.paramObj);
    	$http({
    		method:"GET",
    		url: $rootScope.baseUrl + "service/mce/MCE_PRV/Srv_MCE_GetAssetCheckList.ashx" + param
    	}).then(function(data){
    		var data = data.data;
    		if(data.Succeed == 1){
    			$scope.modelList=data.Message.rows;
    			$scope.mainPager.setDataNum(data.Message.total);
                $scope.mainPager.setCurIndex(curIndex);
                for(var i=0;i<$scope.modelList.length;i++){
                    $scope.modelList[i].modelList = false;
                    $scope.modelList[i].onsel = false
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
     $scope.goDetail=function (id) {
         window.location.replace("PageMceAssetCheckDetail.html?id=" + id)
     };
     $scope.checkAll=function () {
         $scope.checkSate.state = !$scope.checkSate.state
         for(var i=0;i<$scope.modelList.length;i++){
            //if($scope.modelList[i].AUDIT_STATE.trim() != 'COM_1002_00'){
                $scope.modelList[i].checked = $scope.checkSate.state
            //}
         }
     };

     $scope.paramAssetObj = {
         idList: [],
         State: "",
         Reason: ""
     };

     $scope.checkAsset=function () {
         var list=[];
         for(var i=0;i<$scope.modelList.length;i++){
            if($scope.modelList[i].checked == true){
                list.push($scope.modelList[i].ID)
            }
         }
         if(list.length == 0){
             alert("请选择");
             return false
         }

         $scope.paramAssetObj.idList = list;
         $scope.paramAssetObj.State = "1";
         $scope.paramAssetObj.Reason = "";

         $("#btnCheck").text("正在审核...");
         $("#btnCheck").attr('disabled', true);

         $http({
             method:"POST",
             url: $rootScope.baseUrl + "service/mce/MCE_PRV/Srv_MCE_SetAssetCheckStatus.ashx",
             data: $scope.paramAssetObj
         }).then(function (data) {
             $("#btnCheck").text("审核");
             $("#btnCheck").attr('disabled', false);

             var data = data.data;
             if(data.Succeed == 1){
                 alert("审核成功");
                 $scope.getModelList($scope.mainPager.curIndex)
             }else{
                 alert(data.Message)
             }
         })
     };
     $scope.checkAssetNo = function () {
         var list=[];
         for(var i=0;i<$scope.modelList.length;i++){
             if($scope.modelList[i].checked == true){
                 list.push($scope.modelList[i].ID)
             }
         }
         if(list.length == 0){
             alert("请选择");
             return false
         }
   

         $scope.paramAssetObj.idList = list;
         $scope.paramAssetObj.State = "2";
         if ($scope.paramAssetObj.Reason == null || $scope.paramAssetObj.Reason == "")
         {
             alert("请填定拒绝原因");
             return false
         }
         $scope.paramAssetObj.Reason = "";

         $("#btnRefuseCheck").text("正在拒绝审核...");
         $("#btnRefuseCheck").attr('disabled', true);

         $http({
             method: "POST",
             url: $rootScope.baseUrl + "service/mce/MCE_PRV/Srv_MCE_SetAssetCheckStatus.ashx",
             data: $scope.paramAssetObj
         }).then(function (data) {
             $("#btnRefuseCheck").text("拒绝审核");
             $("#btnRefuseCheck").attr('disabled', false);

             var data = data.data;
             if (data.Succeed == 1) {
                
                 alert("拒绝审核成功");
                 $scope.newState.state = false;
                 $scope.getModelList($scope.mainPager.curIndex)
             } else {
                 alert(data.Message)
             }
         })
     };
   

     $scope.newState = {
         state: false
     };

     $scope.openNew = function () {

         $scope.newState.state = true;

     };


     $scope.getModelList(1)
}])