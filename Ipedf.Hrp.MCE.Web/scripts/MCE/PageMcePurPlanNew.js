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
            APPLY_DEPT_ID: "",
            APPLY_DEPT_ID_NAME: "",
            PRV_ID: "",
            PRV_NAME:"",
            CREATE_DATE: "",
            APPLY_USER_ID: "",
            APPLY_USER_ID_NAME: "",
            PURCHASE_DEPT_ID: "",
            PURCHASE_DEPT_ID_NAME: "",

            COMMENTS: "",
            APPLY_MONEY: 0,
            STATE: 0,
            STATE_NAME: "",
        };
        $scope.tableRows = [];
        $scope.deleteIDs = [];

        $scope.InputschangeState = InputschangeState;
        $scope.InputschangeState.states = {
            prv: false,
            dept: false,
            user: false,
            purdept: false,
            type: false
        };

        //供应商
        $scope.prv = ParamS($rootScope.baseUrl + "service/mtr/Srv_MTR_PrvList.ashx");
        $scope.prv.showTabTh = ['编号', '名称'];
        $scope.prv.showTabTb = ['code', 'name'];
        $scope.prv.param = {
            type: "00340005"
        };
        $scope.paramPrv = {
            prv: ""
        };

        $scope.$watch("paramPrv", function (n, o) {
            $scope.headInfo.PRV_ID = n.prv.trim();
            $scope.headInfo.PRV_NAME = $scope.prv.param.condition;
          

        }, true);



        //计划科室
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
            $scope.headInfo.APPLY_DEPT_ID = n.dept.trim();
            $scope.headInfo.APPLY_DEPT_ID_NAME = $scope.dept.param.condition;
        }, true);


        //计划人
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



        //采购科室
        $scope.purdept = ParamS($rootScope.baseUrl + "service/mtr/Srv_MTR_DeptList.ashx");
        $scope.purdept.showTabTh = ['编号', '名称', "院区"];
        $scope.purdept.showTabTb = ['code', 'name', "areaName"];
        $scope.purdept.param = {
            is_area: "0",
            condition: ""
        };
        $scope.paramPurDept = {
            purdept: ""
        };

        $scope.$watch("paramPurDept", function (n, o) {
            $scope.headInfo.PURCHASE_DEPT_ID = n.purdept.trim();
            $scope.headInfo.PURCHASE_DEPT_ID_NAME = $scope.purdept.param.condition;
        }, true);

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
                url: $rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_GetMCEAssetsUserInfo.ashx?code_type=McePurPlan"
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.headInfo.APPLY_USER_ID = data.Message.user_id;
                    $scope.headInfo.APPLY_USER_ID_NAME = data.Message.user_name;
                    $scope.user.param.condition = data.Message.user_name;

                    $scope.headInfo.APPLY_DEPT_ID = data.Message.dept_id;
                    $scope.headInfo.APPLY_DEPT_ID_NAME = data.Message.dept_name;
                    $scope.dept.param.condition = data.Message.dept_name;

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
                url: $rootScope.baseUrl + "service/mce/mce_plan/Srv_MCE_GetMCEPurPlanDetail.ashx?id=" + $scope.paramObj.id
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.tableRows = data.Message.rows;
                    for (var i = 0; i < $scope.tableRows.length; i++) {
                        $scope.tableRows[i].checked = false
                    }
                    $scope.headInfo.ID = data.Message.head.ID;
                    $scope.headInfo.CODE = data.Message.head.CODE;

                    $scope.headInfo.APPLY_DEPT_ID = data.Message.head.APPLY_DEPT_ID;
                    $scope.headInfo.APPLY_DEPT_ID_NAME = data.Message.head.APPLY_DEPT_ID_NAME;
                    $scope.dept.param.condition = data.Message.head.APPLY_DEPT_ID_NAME;

                    $scope.headInfo.PRV_ID = data.Message.head.PRV_ID;
                    $scope.headInfo.PRV_NAME = data.Message.head.PRV_NAME;
                    $scope.prv.param.condition = data.Message.head.PRV_NAME;

                    $scope.headInfo.CREATE_DATE = data.Message.head.CREATE_DATE;

                    $scope.headInfo.APPLY_USER_ID = data.Message.head.APPLY_USER_ID;
                    $scope.headInfo.APPLY_USER_ID_NAME = data.Message.head.APPLY_USER_ID_NAME;
                    $scope.user.param.condition =        data.Message.head.APPLY_USER_ID_NAME;


                    $scope.headInfo.PURCHASE_DEPT_ID = data.Message.head.PURCHASE_DEPT_ID;
                    $scope.headInfo.PURCHASE_DEPT_ID_NAME = data.Message.head.PURCHASE_DEPT_ID_NAME;
                    $scope.purdept.param.condition = data.Message.head.PURCHASE_DEPT_ID_NAME;

                    $scope.headInfo.COMMENTS = data.Message.head.COMMENTS;
                
                    $scope.headInfo.APPLY_MONEY = data.Message.head.APPLY_MONEY;

                    $scope.headInfo.STATE = data.Message.head.STATE;
                    $scope.headInfo.STATE_NAME = data.Message.head.STATE_NAME;



                } else {
                    alert(data.Message)
                }
            })
        };
      
        $scope.clearFkDetailState = function () {
      
        };



        $scope.creatModel = function () {
            return {
                ID: "",
                TYPE_ID: "",
                TYPE_ID_NAME: "",
                ASSETS_ID: "",
                ASSET_NAME: "",
                SPEC: "",
                PRD_ID: "",
                PRD_NAME: "",
                PRICE: 0,
                AMOUNT: 0,
                MONEY: 0,
                UNIT_ID: "",
                UNIT_ID_NAME: "",
                REF_TAB_ID:"",
                REF_TAB_NAME:""
            }
        };

     

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
                $http.post($rootScope.baseUrl + "service/mce/mce_plan/Srv_MCE_MCEPurPlanOperate.ashx?oType=submit", list).success(function (data) {
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
                $http.post($rootScope.baseUrl + "service/mce/mce_plan/Srv_MCE_MCEPurPlanOperate.ashx?oType=audit", list).success(function (data) {
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
                APPLY_DEPT_ID: "",
                PRV_ID: "",
                PRV_NAME: "",
                CREATE_DATE: "",
                APPLY_USER_ID: "",
                PURCHASE_DEPT_ID: "",

                COMMENTS: "",
                APPLY_MONEY: 0,

                STATE: 1,
                DELETEIDS:[],
                children:[]
            };
            function  retModel() {
                return {
                    ID: "",
                    TYPE_ID: "",
                    ASSETS_ID: "",
                    ASSET_NAME: "",
                    SPEC: "",
                    PRD_ID: "",
                    PRD_NAME: "",
                    PRICE: 0,
                    AMOUNT: 0,
                    MONEY: 0,
                    UNIT_ID: "",
                    REF_TAB_ID: "",
                    REF_TAB_NAME: ""
                }
            }
            if ($scope.headInfo.PRV_ID == "") {
                alert("请选择供应商");
                return
            }
            if ($scope.headInfo.PURCHASE_DEPT_ID == "") {
                alert("请选采购科室");
                return
            }
      
            data.ID = $scope.headInfo.ID;
            data.CODE = $scope.headInfo.CODE;
            data.APPLY_DEPT_ID = $scope.headInfo.APPLY_DEPT_ID;
            data.PRV_ID = $scope.headInfo.PRV_ID;
            data.PRV_NAME = $scope.headInfo.PRV_NAME;
            data.PURCHASE_DEPT_ID = $scope.headInfo.PURCHASE_DEPT_ID;

            data.CREATE_DATE = $scope.headInfo.CREATE_DATE;
            data.APPLY_USER_ID = $scope.headInfo.APPLY_USER_ID;
            data.APPLY_MONEY = $scope.headInfo.APPLY_MONEY;

            data.COMMENTS = $scope.headInfo.COMMENTS;

            data.DELETEIDS = $scope.deleteIDs;

            for (var i = 0; i < $scope.tableRows.length; i++) {
      
                data.children.push(retModel());
                data.children[i].ID = $scope.tableRows[i].ID;
                data.children[i].TYPE_ID = $scope.tableRows[i].TYPE_ID;
                data.children[i].ASSETS_ID = $scope.tableRows[i].ASSETS_ID;
                data.children[i].ASSET_NAME = $scope.tableRows[i].ASSET_NAME;
                data.children[i].SPEC = $scope.tableRows[i].SPEC;
                data.children[i].PRD_ID = $scope.tableRows[i].PRD_ID;
                data.children[i].PRD_NAME = $scope.tableRows[i].PRD_NAME;
                data.children[i].PRICE = $scope.tableRows[i].PRICE;
                data.children[i].AMOUNT = $scope.tableRows[i].AMOUNT;
                data.children[i].MONEY = $scope.tableRows[i].MONEY;
                data.children[i].UNIT_ID = $scope.tableRows[i].UNIT_ID;
                data.children[i].REF_TAB_ID = $scope.tableRows[i].REF_TAB_ID;
                data.children[i].REF_TAB_NAME = $scope.tableRows[i].REF_TAB_NAME;

                if (data.children[i].TYPE_ID == null || data.children[i].TYPE_ID == "")
                {
                    alert("设备类型不能为空");
                    return
                }

                if (data.children[i].ASSET_NAME == null || data.children[i].ASSET_NAME == "") {
                    alert("设备名称不能为空");
                    return
                }


                if (data.children[i].AMOUNT * 1 <= 0 || isNaN(data.children[i].AMOUNT)) {
                    alert("请输入正确的数量");
                    return
                }
              

            }

            $http({
                method:"POST",
                url: $rootScope.baseUrl + "service/mce/mce_plan/Srv_MCE_MCEPurPlanSave.ashx",
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



        $scope.paramPurchaseObj = {
            status: "3",
            dept: "",
            prv: "",
            code: "",
            condition: " and nvl(MCE_B_ASSETS_PURCHASE.apply_amount,0) > nvl(MCE_B_ASSETS_PURCHASE.ref_used_amount,0) "
        };
        $scope.modelPurchaseList = [];
        $scope.mainPurchasePager = ParamService.getPager();

        //Asset列表查询
        $scope.getModelPurchaseList = function (curIndex) {

            $scope.paramPurchaseObj.prv = $scope.headInfo.PRV_ID;
            $scope.paramPurchaseObj.dept = $scope.headInfo.PURCHASE_DEPT_ID;

            var param = ParamService.comParam(curIndex, $scope.mainPurchasePager.pageSize, $scope.paramPurchaseObj);
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mce/mce_plan/Srv_MCE_GetMCEPurchaseList.ashx" + param
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.modelPurchaseList = data.Message.rows;
                    $scope.mainPurchasePager.setDataNum(data.Message.total);
                    $scope.mainPurchasePager.setCurIndex(curIndex);
                    for (var i = 0; i < $scope.modelPurchaseList.length; i++) {
                        $scope.modelPurchaseList[i].checked = false;

                    }
                }
            })
        };


        $scope.newState = {
            state: false
        };

        $scope.openNew = function () {
            if ($scope.prv.param.condition == null || $scope.prv.param.condition == "") {
                alert("请选择供应商");
                return;
            }

            if ($scope.purdept.param.condition == null || $scope.purdept.param.condition == "") {
                alert("请选择申购科室");
                return;
            }
            
            $scope.paramPurchaseObj.code = "";
            $scope.getModelPurchaseList();
            for (var i = 0; i < $scope.modelPurchaseList.length; i++) {
                $scope.modelPurchaseList[i].checked = false;
            }
            

            $scope.newState.state = true;
        };


        $scope.checkPurchaseSate = {
            state: false
        };

        $scope.checkAllPurchase = function () {
            $scope.checkPurchaseSate.state = !$scope.checkPurchaseSate.state
            for (var i = 0; i < $scope.modelPurchaseList.length; i++) {
                $scope.modelPurchaseList[i].checked = $scope.checkPurchaseSate.state
            }
        };



        $scope.refPurchaseInfo = function () {
            var added = 0;
           
            for (var i = 0; i < $scope.modelPurchaseList.length; i++) {
                if ($scope.modelPurchaseList[i].checked == true) {
                    added = added + 1;
                  

                    var vExist = false;
                    for (var k = 0; k < $scope.tableRows.length; k++) {
                        if ($scope.tableRows[k].REF_TAB_ID == $scope.modelPurchaseList[i].ID) {
                            var vExist = true;
                            break;
                        }
                    }

                    if (vExist == false) {
                        var vModal = $scope.creatModel();
                        vModal.ID = "";
                        vModal.TYPE_ID = $scope.modelPurchaseList[i].TYPE_ID;
                        vModal.TYPE_ID_NAME = $scope.modelPurchaseList[i].TYPE_ID_NAME;
                        vModal.ASSETS_ID = $scope.modelPurchaseList[i].ASSET_ID;
                        vModal.ASSET_NAME = $scope.modelPurchaseList[i].ASSET_NAME;
                        vModal.SPEC = $scope.modelPurchaseList[i].SPEC;

                        vModal.PRD_ID = $scope.modelPurchaseList[i].REF_PRD_ID;
                        vModal.PRD_NAME = $scope.modelPurchaseList[i].PRD_NAME;
                        vModal.PRICE = $scope.modelPurchaseList[i].APPLY_PRICE;
                        vModal.AMOUNT = $scope.modelPurchaseList[i].APPLY_AMOUNT;
                        vModal.MONEY = vModal.PRICE * vModal.AMOUNT;
                        vModal.UNIT_ID = $scope.modelPurchaseList[i].UNIT_ID;
                        vModal.UNIT_ID_NAME = $scope.modelPurchaseList[i].UNIT_NAME;

                        vModal.REF_TAB_ID = $scope.modelPurchaseList[i].ID;
                        vModal.REF_TAB_NAME = "MCE_B_ASSETS_PURCHASE";
                        $scope.tableRows.push(vModal);
                    }

                }
            }
            if (added == 0) {
                alert("请选择");
                return false;
            }
            else
            {
                $scope.newState.state = false;
            }
        }





        $scope.newState2 = {
            state: false
        };

        $scope.openNew2 = function () {
            if ($scope.prv.param.condition == null || $scope.prv.param.condition == "") {
                alert("请选择供应商");
                return;
            }

            if ($scope.purdept.param.condition == null || $scope.purdept.param.condition == "") {
                alert("请选择申购科室");
                return;
            }

            $scope.paramAssetObj.name = "";
            $scope.getAssetsList(1);
      
            $scope.newState2.state = true;
        };


        $scope.addPurPlanInfo = function (v) {

            if (v.APPLY_AMOUNT * 1 <= 0 || isNaN(v.APPLY_AMOUNT * 1)) {
                alert("请输入正确的申购数量");
                return;
            }

            var vModal = $scope.creatModel();
            vModal.ID = "";
            vModal.TYPE_ID =v.TYPE_ID;
            vModal.TYPE_ID_NAME = v.TYPE_ID_NAME;
            vModal.ASSETS_ID = v.ID;
            vModal.ASSET_NAME = v.NAME;
            vModal.SPEC = v.SPEC;

            vModal.PRD_ID =v.PRD_ID;
            vModal.PRD_NAME = v.PRD_ID_NAME;
            vModal.PRICE = v.PRICE;
            vModal.AMOUNT = v.APPLY_AMOUNT;
            vModal.MONEY = vModal.PRICE * vModal.AMOUNT;
            vModal.UNIT_ID = v.UNIT_ID;
            vModal.UNIT_ID_NAME = v.UNIT_ID_NAME;

            vModal.REF_TAB_ID = v.ID;
            vModal.REF_TAB_NAME = "PRV_B_ASSET";
            $scope.tableRows.push(vModal);
         
            $scope.newState2.state = false;
        };

   
        //设备分类
        $scope.type = ParamS($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCETypeList.ashx");
        $scope.type.showTabTh = ['分类编码', '分类名称'];
        $scope.type.showTabTb = ['CODE', 'NAME'];
        $scope.type.param = {
            status: 1
        };
        $scope.paramType = {
            type: ""
        };
        $scope.$watch("paramType", function (n, o) {
            $scope.paramAssetObj.typeid = n.type.trim();

        }, true);
        
        $scope.assetsList = [];


        $scope.paramAssetObj = {
            state: 1,
            typeid: "",
            refprv:"",
            name: ""
        };

        $scope.mainAssetPager = ParamService.getPager();
        $scope.getAssetsList = function (curIndex) {
            $scope.paramAssetObj.refprv = $scope.headInfo.PRV_ID;
            var param = ParamService.comParam(curIndex, $scope.mainAssetPager.pageSize, $scope.paramAssetObj);
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mce/MCE_PRV/Srv_MCE_GetAssetCheckList.ashx" + param
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.assetsList = data.Message.rows;
                    $scope.mainAssetPager.setDataNum(data.Message.total);
                    $scope.mainAssetPager.setCurIndex(curIndex);
                    /*
                    for (var i = 0; i < $scope.assetsList.length; i++) {
                        $scope.assetsList[i].CODE = "";
                        $scope.assetsList[i].ASSET_ID = $scope.assetsList[i].ID;
                        $scope.assetsList[i].ASSET_NAME = $scope.assetsList[i].NAME;
                        $scope.assetsList[i].APPLY_AMOUNT = 0;
                        $scope.assetsList[i].APPLY_MONEY = 0;
                        $scope.assetsList[i].APPLY_PRICE = $scope.assetsList[i].PRICE;
                        $scope.assetsList[i].PURCHASE_TYPE_ID = "";
                        $scope.assetsList[i].COMMENTS = "";
                    }
                    */
                } else {
                    alert(data.Message)
                }
            })
        };

         

        $scope.goBack = function () {
            window.location.replace("PageMcePurPlanList.html")
        };

        $scope.default = function () {
            $scope.getDetailId();
          
            if ($scope.paramObj.id != "") {
        
                $scope.getDetailInfo();

            } else {
                $scope.getUserInfo();
               // $scope.addModel();
            }


        };
        $scope.default();


    }])