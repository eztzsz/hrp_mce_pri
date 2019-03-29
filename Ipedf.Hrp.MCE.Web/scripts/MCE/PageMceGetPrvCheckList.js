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
	//供应商
	$scope.prvModel = ParamS($rootScope.baseUrl + "service/mce/MCE_PRV/Srv_MCE_GetPrvCheckList.ashx");
	$scope.prvModel.showTabTh = ['编号','供应商'];
    $scope.prvModel.showTabTb = ['CODE','NAME'];
    $scope.paramPrv={
        prv:""
    };
	$scope.paramObj={
        status:"",
        prvid:"",
        beginspan:"",
        endspan:""
	};
    $scope.modelList=[];
    $scope.mainPager = ParamService.getPager();
    //列表查询
    $scope.getModelList=function(curIndex){
        var param = ParamService.comParam(curIndex, $scope.mainPager.pageSize, $scope.paramObj);
    	$http({
    		method:"GET",
    		url: $rootScope.baseUrl + "service/mce/MCE_PRV/Srv_MCE_GetPrvCheckList.ashx" + param
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
         window.location.replace("PageMcePrvCheckDetail.html?id=" + id)
     };
     $scope.checkAll=function () {
         $scope.checkSate.state = !$scope.checkSate.state
         for(var i=0;i<$scope.modelList.length;i++){
            //if($scope.modelList[i].AUDIT_STATE.trim() != 'COM_1002_00'){
                $scope.modelList[i].checked = $scope.checkSate.state
            //}
         }
     };
     $scope.checkPrv=function () {
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

         $("#btnCheck").text("正在审核...");
         $("#btnCheck").attr('disabled', true);

         $http({
             method:"POST",
             url: $rootScope.baseUrl + "service/mce/MCE_PRV/Srv_MCE_SetPrvInfo.ashx",
             data:list
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
     $scope.checkPrvNo=function () {
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
         $http({
             method:"POST",
             url: $rootScope.baseUrl + "service/mce/MCE_PRV/Srv_MCE_CancelPrvAudit.ashx",
             data:list
         }).then(function (data) {
             var data = data.data;
             if(data.Succeed == 1){
                 alert("取消审核成功");
                 $scope.getModelList($scope.mainPager.curIndex)
             }else{
                 alert(data.Message)
             }
         })
     };
     $scope.getFileSrc=function (id) {
         var msg="";
         $http({
             method:"GET",
             url:$rootScope.baseUrl+"service/mtr/mtr_high_basic/Srv_MTR_High_GetPrvPicFileZip.ashx?id="+id
         }).then(function (data) {
             var data = data.data;
             if(data.Succeed == 1){
                 msg = data.Message
             }else{
                 alert(data.Message);
             }
         });
         return msg
     };
     $scope.fileDow=function () {
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
         for(var i=0;i<list.length;i++){
             $http({
                 method:"GET",
                 url:$rootScope.baseUrl+"service/mtr/mtr_high_basic/Srv_MTR_High_GetPrvPicFileZip.ashx?id="+list[i]
             }).then(function (data) {
                 var data = data.data;
                 if(data.Succeed == 1){
                     window.open(data.Message)
                 }else{
                     alert(data.Message);
                 }
             });
         }
     };

     $scope.$watch('paramPrv',function (n,o) {
         if(n != undefined){
             $scope.paramObj.prvid=n.prv
         }
     },true);
     $scope.getModelList(1)
}])