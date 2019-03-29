var app = angular.module("app", ['app.directive', 'app.services']);
app.controller('index', ['$scope', '$http', '$rootScope', 'ParamService', 'ParamS', 'InputschangeState',
    function ($scope, $http, $rootScope, ParamService, ParamS, InputschangeState) {

        $rootScope.baseUrl = "../../";

  
        $scope.paramObj = {
            id: ""
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

            var par = urlArgs();
            if (par.id) {
                $scope.paramObj.id = par.id;
            }

        };
        $scope.headInfo = {
            ID: "",
            CODE:"",
            DEPT_ID: "",
            DEPT_ID_NAME: "",
            CREATE_DATE: "",
            USER_ID: "",
            USER_ID_NAME: "",

            CHECK_TYPE_ID: "",
            CHECK_TYPE_ID_NAME: "",

            COMMENTS: "",

            STATE: 0,
            STATE_NAME: "",
        };
        $scope.tableRows = [];
     
        $scope.InputschangeState = InputschangeState;
        $scope.InputschangeState.states = {
            dept: false,
            user: false
        };

        //盘点科室
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

        $scope.$watch("paramDept", function (n, o) {
            $scope.headInfo.USING_DEPT_ID = n.dept.trim();
            $scope.headInfo.USING_DEPT_ID_NAME = $scope.dept.param.condition;
        
        }, true);


        //盘点人
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

        $scope.$watch("paramUser", function (n, o) {
            $scope.headInfo.USING_USER_ID = n.user.trim();
            $scope.headInfo.USING_USER_ID_NAME = $scope.user.param.condition;
        }, true);



        //盘点类型
        $scope.checkTypeList = [];
        $scope.getCheckTypeList = function () {
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=0044&limit=10000"
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.checkTypeList = data.Message.rows
                } else {
                    alert(data.Message)
                }
            })
        };



        //盘点状态
        $scope.checkStateList = [];
        $scope.getCheckStateList = function () {
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=0053&limit=10000"
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.checkStateList = data.Message.rows
                } else {
                    alert(data.Message)
                }
            })
        };


        $scope.checkState = {
            state: false
        };
        $scope.checkAll = function () {
            $scope.checkState.state = !$scope.checkState.state;
            for (var i = 0; i < $scope.tableRows.length; i++) {
                $scope.tableRows[i].checked = $scope.checkState.state
            }
        };


        //获取当前用户信息
        $scope.getUserInfo = function () {
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_GetMCEAssetsUserInfo.ashx?code_type=MceCheck"
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
            
                    $scope.headInfo.CREATE_DATE = data.Message.sys_date;
                    $scope.headInfo.CODE = data.Message.code;

                    $scope.headInfo.USER_ID = data.Message.user_id;
                    $scope.headInfo.USER_ID_NAME = data.Message.user_name;
                    $scope.user.param.condition = data.Message.user_name;

                    $scope.headInfo.DEPT_ID = data.Message.dept_id;
                    $scope.headInfo.DEPT_ID_NAME = data.Message.dept_name;
                    $scope.dept.param.condition = data.Message.dept_name;

                    if ($scope.checkTypeList != null && $scope.checkTypeList.length > 0) {
                        $scope.headInfo.CHECK_TYPE_ID = $scope.checkTypeList[0].id;
                        $scope.headInfo.CHECK_TYPE_ID_NAME = $scope.checkTypeList[0].name;
                    }

                } else {
                    alert(data.Message)
                }
            })
        };

        //获取详情
        $scope.getDetailInfo = function () {
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mce/MCE_STOCKDATA/Srv_MCE_GetMCECheckDetail.ashx?id=" + $scope.paramObj.id
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.tableRows = data.Message.rows;
                    for (var i = 0; i < $scope.tableRows.length; i++) {
                        $scope.tableRows[i].checked = false
                        if ($scope.tableRows[i].NEW_ASSETS_STATE != null) {
                            $scope.tableRows[i].NEW_ASSETS_STATE = $scope.tableRows[i].NEW_ASSETS_STATE.trim();
                        }
                        else
                        {
                            $scope.tableRows[i].NEW_ASSETS_STATE = "";
                        }
                    }
                    $scope.headInfo.ID = data.Message.head.ID;
                    $scope.headInfo.CODE = data.Message.head.CODE;
                  
                    $scope.headInfo.CREATE_DATE = data.Message.head.CREATE_DATE;

                    $scope.headInfo.DEPT_ID = data.Message.head.DEPT_ID;
                    $scope.headInfo.DEPT_ID_NAME = data.Message.head.DEPT_ID_NAME;
                    $scope.dept.param.condition = data.Message.head.DEPT_ID_NAME;

                    $scope.headInfo.USER_ID = data.Message.head.USER_ID;
                    $scope.headInfo.USER_ID_NAME = data.Message.head.USER_ID_NAME;
                    $scope.user.param.condition = data.Message.head.USER_ID_NAME;

                    if (data.Message.head.CHECK_TYPE_ID != null) {
                        $scope.headInfo.CHECK_TYPE_ID = data.Message.head.CHECK_TYPE_ID.trim();
                        $scope.headInfo.CHECK_TYPE_ID_NAME = data.Message.head.CHECK_TYPE_ID_NAME;
                    }

                    $scope.headInfo.COMMENTS = data.Message.head.COMMENTS;
                
                    $scope.headInfo.STATE = data.Message.head.STATE;
                    $scope.headInfo.STATE_NAME = data.Message.head.STATE_NAME;


                } else {
                    alert(data.Message)
                }
            })
        };
      

        $scope.clearFkDetailState = function () {
            angular.forEach($scope.tableRows, function (v, k) {
    
            })
        };


        $scope.checkAssetTypeState = {
            state: false
        };
        $scope.checkAssetTypeAll = function () {
            $scope.checkAssetTypeState.state = !$scope.checkAssetTypeState.state;
            for (var i = 0; i < $scope.modelAssetTypeList.length; i++) {
                $scope.modelAssetTypeList[i].checked = $scope.checkAssetTypeState.state
            }
        };

        $scope.modelAssetTypeList = [];
     
        //Asset列表查询
        $scope.getModelAssetTypeList = function (curIndex) {

            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mce/MCE_STOCKDATA/Srv_MCE_GetMCECheckType.ashx?id=" + $scope.paramObj.id
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.modelAssetTypeList = data.Message;
        
                    
                    for (var i = 0; i < $scope.modelAssetTypeList.length; i++) {
                        $scope.modelAssetTypeList[i].showMceTypeState = false;
                        $scope.modelAssetTypeList[i].checked = false;
                    }
                    
                }
                else
                {
                    alert(data.Message );
                }
            })
        };


        $scope.newState = {
            state: false
        };

        $scope.openNew = function () {

            if ($scope.paramObj.id == null || $scope.paramObj.id == "") {
                alert("请先保存！");
                return;
            }

            $scope.getModelAssetTypeList();
            for (var i = 0; i < $scope.modelAssetTypeList.length; i++) {
                $scope.modelAssetTypeList[i].showMceTypeState = false;
            }
            
            $scope.newState.state = true;
        };


        $scope.clearFkAssetTypeDetailState = function () {
            angular.forEach($scope.modelAssetTypeList, function (v, k) {
                $scope.modelAssetTypeList[k].showMceTypeState = false;

            })
        };


        $scope.conditionMceTypeForAdd = {
            status: 1,
            condition: ""
        };
        $scope.mceTypeList = [];
        $scope.fkMceTypePager = ParamService.getPager();
        $scope.searcFkMCeTypeListForAdd = function (curIndex, v) {
            $scope.conditionMceTypeForAdd.condition = v.NAME;
            v.showMceTypeState = true;
            var param = ParamService.comParam(curIndex, $scope.fkMceTypePager.pageSize, $scope.conditionMceTypeForAdd);
            $http.get($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCETypeList.ashx" + param).success(function (data) {
                if (data.Succeed == 1) {
                    v.showMceTypeState = true;
                    $scope.mceTypeList = data.Message.rows;
                    $scope.fkMceTypePager.setDataNum(data.Message.total);
                    $scope.fkMceTypePager.setCurIndex(curIndex);
                }
            })
        };
        $scope.changeFkMceTypeState = function (index) {
            angular.forEach($scope.modelAssetTypeList, function (v, k) {
                $scope.clearFkAssetTypeDetailState();
                if (index == k) {
                    $scope.modelAssetTypeList[k].showMceTypeState = true;
                }
            })
        };
        $scope.selectFkMceTypeForAdd = function (v, a) {
            v.showMceTypeState = false;
            v.ID = a.ID;
            v.CODE = a.CODE;
            v.NAME = a.NAME;
        };
        $scope.clearFkMceTypeForAdd = function (v) {
            v.ID = "";
            v.CODE = "";
            v.NAME = "";
        };



        $scope.creatAssetTypeModel = function () {
            return {
                ID: "",
                NAME: "",
                CODE: "",
                SPEC: "",
                checked: false,
                showMceTypeState: false
         
            }
        };
        $scope.addAssetTypeModel = function () {
            $scope.modelAssetTypeList.push($scope.creatAssetTypeModel())
        };


        $scope.delAssetTypeModel = function () {
            var flag = confirm("是否确认删除？");
            if (!flag) {
                return false
            }

            var list = [];
            for (var i = 0; i < $scope.modelAssetTypeList.length; i++) {
                if ($scope.modelAssetTypeList[i].checked) {
                    list.push(i)             
                }
            }
            if (list.length == 0) {
                alert("请选择");
                return false
            }
            for (var i = list.length - 1; i >= 0; i--) {
                $scope.modelAssetTypeList.splice(list[i], 1)
            }
        };


        
        $scope.saveAssetTypeModel = function () {
            var list = [];
            for (var i = 0; i < $scope.modelAssetTypeList.length; i++) {
                list.push($scope.modelAssetTypeList[i].ID);
            }

            $http.post($rootScope.baseUrl + "service/mce/MCE_STOCKDATA/Srv_MCE_MCECheckTypeSave.ashx?baseid=" + $scope.paramObj.id, list).success(function (data) {
                if (data.Succeed == 1) {
                    alert("保存成功！");
                    $scope.newState.state = false;
                } else {
                    alert(data.Message + "提交失败！");
                }
            })

        }
        

        $scope.submitModel = function () {
            var flag = confirm("是否确认提交？");
            if (!flag) {
                return false
            }

            var list = [];

            if ($scope.paramObj.id == null || $scope.paramObj.id == "") {
                alert("请先保存再提交！");
                return;
            }
            else {
                list.push($scope.paramObj.id);
                $http.post($rootScope.baseUrl + "service/mce/MCE_STOCKDATA/Srv_MCE_MCECheckOperate.ashx?oType=submit", list).success(function (data) {
                    if (data.Succeed == 1) {
                        alert("提交成功！");
                        $scope.getDetailInfo();
                    } else {
                        alert(data.Message + "提交失败！");
                    }
                })
            }
        };

        $scope.auditModel = function () {
            var flag = confirm("是否确认审核？");
            if (!flag) {
                return false
            }

            var list = [];

            if ($scope.paramObj.id == null || $scope.paramObj.id == "") {
                alert("请先保存再提交、审核！");
                return;
            }
            else {
                list.push($scope.paramObj.id);
                $http.post($rootScope.baseUrl + "service/mce/MCE_STOCKDATA/Srv_MCE_MCECheckOperate.ashx?oType=audit", list).success(function (data) {
                    if (data.Succeed == 1) {
                        alert("审核成功！");
                        $scope.getDetailInfo();
                    } else {
                        alert(data.Message + "审核失败！");
                    }
                })
            }
        };


        $scope.delModel = function () {
            var flag = confirm("是否确认删除？");
            if (!flag) {
                return false
            }

            var list = [];
            for (var i = 0; i < $scope.tableRows.length; i++) {
                if ($scope.tableRows[i].checked) {
                    list.push(i)
          
                }
            }
            if (list.length == 0) {
                alert("请选择");
                return false
            }
            for (var i = list.length - 1; i >= 0; i--) {
     
                $scope.tableRows.splice(list[i], 1)

               
            }
        };

        $scope.saveModel=function (vType) {
            var data={
                ID: "",
                CODE: "",
                CREATE_DATE: "",
                DEPT_ID: "",
                USER_ID: "",
                CHECK_TYPE_ID: "",

                COMMENTS: "",
                STATE: 1,
                children:[]
            };
            function  retModel() {
                return {
                    ID: "",
                    ASSETS_ID: "",
                    ASSETS_CODE: "",
                    SPEC: "",

                    USING_DEPT_ID: "",
                
                    OLD_ASSETS_STATE: "",
                  
                    NEW_ASSETS_STATE: ""
                 
                }
            }
         
            data.ID = $scope.headInfo.ID;
            data.CODE = $scope.headInfo.CODE;
         
            data.CREATE_DATE = $scope.headInfo.CREATE_DATE;
            data.DEPT_ID = $scope.headInfo.DEPT_ID;
            data.USER_ID = $scope.headInfo.USER_ID;
            data.CHECK_TYPE_ID = $scope.headInfo.CHECK_TYPE_ID;

            data.COMMENTS = $scope.headInfo.COMMENTS;
        
            for (var i = 0; i < $scope.tableRows.length; i++) {
      
                data.children.push(retModel());
                data.children[i].ID = $scope.tableRows[i].ID;
                data.children[i].ASSETS_ID = $scope.tableRows[i].ASSETS_ID;
                data.children[i].ASSETS_CODE = $scope.tableRows[i].ASSETS_CODE;
                data.children[i].SPEC = $scope.tableRows[i].SPEC;
                data.children[i].USING_DEPT_ID = $scope.tableRows[i].USING_DEPT_ID;
                data.children[i].OLD_ASSETS_STATE = $scope.tableRows[i].OLD_ASSETS_STATE;
                data.children[i].NEW_ASSETS_STATE = $scope.tableRows[i].NEW_ASSETS_STATE;
              
                if (data.children[i].ASSETS_ID == null || data.children[i].ASSETS_ID == "") {
                    alert("设备名称不能为空");
                    return
                }


            }

            $http({
                method:"POST",
                url: $rootScope.baseUrl + "service/mce/MCE_STOCKDATA/Srv_MCE_MCECheckSave.ashx",
                data:data
            }).then(function (data) {
                var data = data.data;
                if(data.Succeed == 1){
                    alert("保存成功");

                    if (vType == '1') {
                        $scope.paramObj.id = data.Message;
                        $scope.getDetailInfo();
                    }
                    else {
                        $scope.goBack();
                    }
                }else{
                    alert(data.Message)
                }
            })


        };



        $scope.generateModel = function () {

            if ($scope.paramObj.id == null || $scope.paramObj.id == "") {
                alert("请先保存！");
                return;
            }

            $http({
                method: "POST",
                url: $rootScope.baseUrl + "service/mce/MCE_STOCKDATA/Srv_MCE_MCEGenerate_Detail.ashx",
                data: $scope.paramObj.id
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    alert("生成成功");

                    $scope.getDetailInfo();


                } else {
                    alert(data.Message)
                }
            })


        };


        $scope.goBack = function () {
            window.location.replace("PageMceCheckList.html")
        };

        $scope.default = function () {
            $scope.getDetailId();
            $scope.getCheckTypeList();
            $scope.getCheckStateList();

            if ($scope.paramObj.id != "") {
        
                $scope.getDetailInfo();

            } else {
                $scope.getUserInfo();
              //  $scope.addModel();
            }

         

        };
        $scope.default();


    }])