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
            CODE: "",
            NAME: "",
            MTN_TYPE_ID: "",
            MTN_COMPANY_ID: "",
            MTN_COMPANY_ID_NAME: "",
            EXECUTE_PERIOD: 0,
            EXECUTE_PERIOD_UNIT:"1",
            CREATE_DATE: "",
            APPLY_USER_ID: "",
            APPLY_USER_ID_NAME: "",
            COMMENTS: "",

            PLAN_STATE: 1,
            PLAN_STATE_NAME: "正常",
            STATE: 0,
            STATE_NAME: "",
        };
        $scope.tableRows = [];
        $scope.deleteIDs = [];

        $scope.InputschangeState = InputschangeState;
        $scope.InputschangeState.states = {
            dept: false,
            user: false
        };

        //保养公司
        $scope.dept = ParamS($rootScope.baseUrl + "service/mtr/Srv_MTR_PrvList.ashx");
        $scope.dept.showTabTh = ['编号', '名称'];
        $scope.dept.showTabTb = ['code', 'name'];
        $scope.dept.param = {
            type: "00340006"
        };
        $scope.paramDept = {
            dept: ""
        };

        $scope.$watch("paramDept", function (n, o) {
            $scope.headInfo.MTN_COMPANY_ID = n.dept.trim();
            $scope.headInfo.MTN_COMPANY_ID_NAME = $scope.dept.param.condition;
        
        }, true);


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

        $scope.$watch("paramUser", function (n, o) {
            $scope.headInfo.APPLY_USER_ID = n.user.trim();
            $scope.headInfo.APPLY_USER_ID_NAME = $scope.user.param.condition;
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
                url: $rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_GetMCEAssetsUserInfo.ashx?code_type=MceMtnPlan"
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
            
                    $scope.headInfo.CREATE_DATE = data.Message.sys_date;
                    $scope.headInfo.CODE = data.Message.code;
                } else {
                    alert(data.Message)
                }
            })
        };

        //获取详情
        $scope.getDetailInfo = function () {
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mce/mce_mt/Srv_MCE_GetMCEMTNPlanDetail.ashx?id=" + $scope.paramObj.id
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.tableRows = data.Message.rows;
                    for (var i = 0; i < $scope.tableRows.length; i++) {
                        $scope.tableRows[i].checked = false
                    }

                    $scope.headInfo.ID = data.Message.head.ID;
                    $scope.headInfo.CODE = data.Message.head.CODE;
                    $scope.headInfo.NAME = data.Message.head.NAME;

                    if (data.Message.head.MTN_TYPE_ID != null)
                    {
                        $scope.headInfo.MTN_TYPE_ID = data.Message.head.MTN_TYPE_ID.trim();
                    }

                    $scope.headInfo.MTN_COMPANY_ID = data.Message.head.MTN_COMPANY_ID;
                    $scope.headInfo.MTN_COMPANY_ID_NAME = data.Message.head.MTN_COMPANY_ID_NAME;
                    $scope.dept.param.condition = data.Message.head.MTN_COMPANY_ID_NAME;

                    $scope.headInfo.APPLY_USER_ID = data.Message.head.APPLY_USER_ID;
                    $scope.headInfo.APPLY_USER_ID_NAME = data.Message.head.APPLY_USER_ID_NAME;
                    $scope.user.param.condition = data.Message.head.APPLY_USER_ID_NAME;
                    
                    $scope.headInfo.EXECUTE_PERIOD = data.Message.head.EXECUTE_PERIOD;
                    $scope.headInfo.EXECUTE_PERIOD_UNIT = data.Message.head.EXECUTE_PERIOD_UNIT;
                    $scope.headInfo.CREATE_DATE = data.Message.head.CREATE_DATE;

                    $scope.headInfo.COMMENTS = data.Message.head.COMMENTS;

                    $scope.headInfo.PLAN_STATE = data.Message.head.PLAN_STATE;
                    $scope.headInfo.PLAN_STATE_NAME = data.Message.head.PLAN_STATE_NAME;

                    $scope.headInfo.STATE = data.Message.head.STATE;
                    $scope.headInfo.STATE_NAME = data.Message.head.STATE_NAME;


                } else {
                    alert(data.Message)
                }
            })
        };
      

        $scope.clearFkDetailState = function () {
            angular.forEach($scope.tableRows, function (v, k) {
                $scope.tableRows[k].showMTItemState = false;
            })
        };




        //保养项目
        $scope.conditionMtnItemForAdd = {
            condition: ""
        };
        $scope.mtnItemList = [];
        $scope.fkMtnItemPager = ParamService.getPager();
        $scope.searcFkMtnItemListForAdd = function (curIndex, v) {
            $scope.conditionMtnItemForAdd.condition = v.ITEM_ID_NAME;
            v.showMTItemState = true;
            var param = ParamService.comParam(curIndex, $scope.fkMtnItemPager.pageSize, $scope.conditionMtnItemForAdd);
            $http.get($rootScope.baseUrl + "service/mce/mce_mt/Srv_MCE_GetMCEMTNItemList.ashx" + param).success(function (data) {
                if (data.Succeed == 1) {
                    v.showMTItemState = true;
                    $scope.mtnItemList = data.Message.rows;
                    $scope.fkMtnItemPager.setDataNum(data.Message.total);
                    $scope.fkMtnItemPager.setCurIndex(curIndex);
                }
            })
        };
        $scope.changeFkMtnItemState = function (index) {
            $scope.clearFkDetailState();
            $scope.tableRows[index].showMTItemState = true;

        };
        $scope.selectFkMtnItemForAdd = function (v, a) {
            v.showMTItemState = false;
            v.ITEM_ID = a.ID;
            v.ITEM_ID_NAME = a.NAME;
        };
        $scope.clearFkMtnItemForAdd = function (v) {
            v.ITEM_ID = "";
            v.ITEM_ID_NAME = "";
        };


        $scope.creatModel = function () {
            return {
                ID: "",
  
                ASSETS_ID:"",
                ASSETS_ID_NAME: "",
                ASSET_CODE: "",
                SPEC: "",
                DEPT_ID: "",
                DEPT_ID_NAME: "",

                SEQ_NUMBER: "",

                ITEM_ID: "",
                ITEM_ID_NAME: "",

                COMMENTS: "",
                checked: false,

                showMTItemState: false
            }
        };



        $scope.paramAssetObj = {
            assets_state: "00530002",
        //    use_state: "00540002",
            condition: "",
            needTotal:"0"
        };
        $scope.modelAssetList = [];
        $scope.mainAssetPager = ParamService.getPager();

        //Asset列表查询
        $scope.getModelAssetList = function (curIndex) {
            var param = ParamService.comParam(curIndex, $scope.mainAssetPager.pageSize, $scope.paramAssetObj);
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCEAssetsList.ashx" + param
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.modelAssetList = data.Message.rows;
                    $scope.mainAssetPager.setDataNum(data.Message.total);
                    $scope.mainAssetPager.setCurIndex(curIndex);
                    for (var i = 0; i < $scope.modelAssetList.length; i++) {
                        $scope.modelAssetList[i].checked = false;

                    }
                }
            })
        };


        $scope.newState = {
            state: false
        };

        $scope.openNew = function () {
            $scope.paramAssetObj.condition = "";
            $scope.getModelAssetList();
            for (var i = 0; i < $scope.modelAssetList.length; i++) {
                $scope.modelAssetList[i].checked = false;
            }
            
            $scope.newState.state = true;
        };


        $scope.checkAssetSate = {
            state: false
        };

        $scope.checkAllAssett = function () {
            $scope.checkAssetSate.state = !$scope.checkAssetSate.state
            for (var i = 0; i < $scope.modelAssetList.length; i++) {
                $scope.modelAssetList[i].checked = $scope.checkAssetSate.state
            }
        };

        $scope.addInfo = function () {
            var added = 0;
            for (var i = 0; i < $scope.modelAssetList.length; i++) {
                if ($scope.modelAssetList[i].checked == true) {
                    added = added + 1;

                    var vExist = false;
                    for (var k = 0; k < $scope.tableRows.length; k++) {
                        if ($scope.tableRows[k].ASSETS_ID == $scope.modelAssetList[i].ID) {
                            var vExist = true;
                            break;
                        }
                    }

                    if (vExist == false) {

                        var vModal = $scope.creatModel();
                        vModal.ASSETS_ID = $scope.modelAssetList[i].ID;
                        vModal.ASSETS_ID_NAME = $scope.modelAssetList[i].ASSETS_NAME;
                        vModal.ASSET_CODE = $scope.modelAssetList[i].ASSETS_CODE;
                        vModal.SPEC = $scope.modelAssetList[i].SPEC;

                        vModal.DEPT_ID = $scope.modelAssetList[i].SUBJECTION_DEPT_ID;
                        vModal.DEPT_ID_NAME = $scope.modelAssetList[i].SUBJECTION_DEPT_ID_NAME;

                        vModal.SEQ_NUMBER = $scope.modelAssetList[i].SEQ_NUMBER;

                        vModal.ITEM_ID = "";
                        vModal.ITEM_ID_NAME = "";

                        vModal.COMMENTS = "";

                        $scope.tableRows.push(vModal);
                    }
                }
            }
            if (added == 0) {
                alert("请选择");
                return false
            }
            else
            {
                $scope.newState.state = false;
                //alert("添加成功");
            }


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
                $http.post($rootScope.baseUrl + "service/mce/mce_mt/Srv_MCE_MCEMTNPlanOperate.ashx?oType=submit", list).success(function (data) {
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
                $http.post($rootScope.baseUrl + "service/mce/mce_mt/Srv_MCE_MCEMTNPlanOperate.ashx?oType=audit", list).success(function (data) {
                    if (data.Succeed == 1) {
                        alert("审核成功！");
                        $scope.getDetailInfo();
                    } else {
                        alert(data.Message + "审核失败！");
                    }
                })
            }
        };

        $scope.enableModel = function () {
            var flag = confirm("是否确认启用？");
            if (!flag) {
                return false
            }

            var list = [];

            if ($scope.paramObj.id == null || $scope.paramObj.id == "") {
                alert("请先保存再启用！");
                return;
            }
            else {
                list.push($scope.paramObj.id);
                $http.post($rootScope.baseUrl + "service/mce/mce_mt/Srv_MCE_MCEMTNPlanOperate.ashx?oType=enable", list).success(function (data) {
                    if (data.Succeed == 1) {
                        alert("启用成功！");
                        $scope.getDetailInfo();
                    } else {
                        alert(data.Message + "启用失败！");
                    }
                })
            }
        };

        $scope.disableModel = function () {
            var flag = confirm("是否确认停用？");
            if (!flag) {
                return false
            }

            var list = [];

            if ($scope.paramObj.id == null || $scope.paramObj.id == "") {
                alert("请先保存再停用！");
                return;
            }
            else {
                list.push($scope.paramObj.id);
                $http.post($rootScope.baseUrl + "service/mce/mce_mt/Srv_MCE_MCEMTNPlanOperate.ashx?oType=disable", list).success(function (data) {
                    if (data.Succeed == 1) {
                        alert("停用成功！");
                        $scope.getDetailInfo();
                    } else {
                        alert(data.Message + "停用失败！");
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
                    if ($scope.tableRows[i].ID != null && $scope.tableRows[i].ID != "") {
                        $scope.deleteIDs.push($scope.tableRows[i].ID);
                    }

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
                NAME: "",
                MTN_TYPE_ID: "",
                MTN_COMPANY_ID: "",
                APPLY_USER_ID: "",

                EXECUTE_PERIOD: "",
                EXECUTE_PERIOD_UNIT: "",
                CREATE_DATE: "",
 
                COMMENTS: "",

                PLAN_STATE: 1,
                STATE: 1,
                DELETEIDS:[],
                children:[]
            };

         
            function  retModel() {
                return {
                    ID: "",
                    ASSETS_ID:"",
                    ASSET_CODE: "",
                    SPEC: "",
                    DEPT_ID: "",

                    SEQ_NUMBER: "",

                    ITEM_ID: "",

                    COMMENTS: "",

                }
            }
    
            if ($scope.headInfo.PLAN_STATE == null || $scope.headInfo.PLAN_STATE == "") {
                alert("请选择项目状态");
                return
            }

            if ($scope.headInfo.EXECUTE_PERIOD * 1 <= 0 || isNaN($scope.headInfo.EXECUTE_PERIOD)) {
                alert("执行周期必须为整数，请输入正确的执行周期");
                return
            }

            data.ID = $scope.headInfo.ID;
            data.CODE = $scope.headInfo.CODE;
            data.NAME = $scope.headInfo.NAME;
       
            data.MTN_TYPE_ID = $scope.headInfo.MTN_TYPE_ID;
            data.MTN_COMPANY_ID = $scope.headInfo.MTN_COMPANY_ID;
            data.APPLY_USER_ID = $scope.headInfo.APPLY_USER_ID;

            data.EXECUTE_PERIOD = $scope.headInfo.EXECUTE_PERIOD;
            data.EXECUTE_PERIOD_UNIT = $scope.headInfo.EXECUTE_PERIOD_UNIT;
            data.CREATE_DATE = $scope.headInfo.CREATE_DATE;
            data.PLAN_STATE = $scope.headInfo.PLAN_STATE;
            data.STATE =1;

            data.COMMENTS = $scope.headInfo.COMMENTS;
            data.DELETEIDS = $scope.deleteIDs;

            for (var i = 0; i < $scope.tableRows.length; i++) {
      
                data.children.push(retModel());
                data.children[i].ID = $scope.tableRows[i].ID;
                data.children[i].ASSETS_ID = $scope.tableRows[i].ASSETS_ID;
                data.children[i].ASSET_CODE = $scope.tableRows[i].ASSET_CODE;
                data.children[i].SPEC = $scope.tableRows[i].SPEC;

                data.children[i].DEPT_ID = $scope.tableRows[i].DEPT_ID;
                data.children[i].SEQ_NUMBER = $scope.tableRows[i].SEQ_NUMBER;
                data.children[i].ITEM_ID = $scope.tableRows[i].ITEM_ID;
             
                data.children[i].COMMENTS = $scope.tableRows[i].COMMENTS;
            
                if (data.children[i].ASSETS_ID == null || data.children[i].ASSETS_ID == "") {
                    alert("设备名称不能为空");
                    return
                }


                if (data.children[i].ITEM_ID == null || data.children[i].ITEM_ID == "") {
                    alert("项目名称不能为空");
                    return
                }

            }

            $http({
                method:"POST",
                url: $rootScope.baseUrl + "service/mce/mce_mt/Srv_MCE_MCEMTNPlanSave.ashx",
                data:data
            }).then(function (data) {
                var data = data.data;
                if(data.Succeed == 1){
                    alert("保存成功");

                    if (vType == '1') {
                        $scope.paramObj.id = data.Message;
                        $scope.getDetailInfo();
                        $scope.deleteIDs = [];
                    }
                    else {
                        $scope.goBack();
                    }
                }else{
                    alert(data.Message)
                }
            })


        };


        $scope.goBack = function () {
            window.location.replace("PageMceMTNPlanList.html")
        };

        $scope.default = function () {
            $scope.getDetailId();
            $scope.getMtnTypeListList();

            if ($scope.paramObj.id != "") {
        
                $scope.getDetailInfo();

            } else {
                $scope.getUserInfo();
              //  $scope.addModel();
            }

         

        };
        $scope.default();


    }])