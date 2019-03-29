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
            WAREHOUSE_ID: "",
            WAREHOUSE_ID_NAME: "",
            PROVIDER_ID: "",
            PROVIDER_ID_NAME:"",
            CREATE_DATE: "",
            USER_ID: "",
            USER_ID_NAME: "",
            COMMENTS: "",
            INVOICE_CODE: "",
            TOTAL_MONEY: 0,
            STATE: 0,
            STATE_NAME: "",
        };
        $scope.tableRows = [];
        $scope.deleteIDs = [];

        $scope.InputschangeState = InputschangeState;
        $scope.InputschangeState.states = {
            prv: false,
            stock: false,
            audit: false
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
            $scope.headInfo.PROVIDER_ID = n.prv.trim();
            $scope.headInfo.PROVIDER_ID_NAME = $scope.prv.param.condition;
            //$scope.conditionMtrForAdd.stock = n.stock.trim();

        }, true);



        //仓库
        $scope.stock = ParamS($rootScope.baseUrl + "service/mce/mce_instock/Srv_MCE_GetMCEStockList.ashx");
        $scope.stock.showTabTh = ['编号', '名称', "院区"];
        $scope.stock.showTabTb = ['code', 'name', "deptName"];
        $scope.stock.param = {
            is_area: "0",
            is_use: "1",
            condition: ""
        };
        $scope.paramStock = {
            stock: ""
        };

        $scope.$watch("paramStock", function (n, o) {
            $scope.headInfo.WAREHOUSE_ID = n.stock.trim();
            $scope.headInfo.WAREHOUSE_ID_NAME = $scope.stock.param.condition;
        }, true);


        //入库人
        $scope.audit = ParamS($rootScope.baseUrl + "service/mtr/mtr_high_basic/Srv_MTR_High_GetUserList.ashx");
        $scope.audit.showTabTh = ['用户名', '姓名'];
        $scope.audit.showTabTb = ['ACCOUNT', 'NAME'];
        $scope.audit.param = {
            name: "",
            condition: ""
        };
        $scope.paramAudit = {
            audit: ""
        };

        $scope.$watch("paramAudit", function (n, o) {
            $scope.headInfo.USER_ID = n.audit.trim();
            $scope.headInfo.USER_ID_NAME = $scope.audit.param.condition;
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
                url: $rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_GetMCEAssetsUserInfo.ashx?code_type=MceInstock"
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.headInfo.USER_ID = data.Message.user_id;
                    $scope.headInfo.USER_ID_NAME = data.Message.user_name;
                    $scope.audit.param.condition = data.Message.user_name;

                  
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
                url: $rootScope.baseUrl + "service/mce/mce_instock/Srv_MCE_GetMCEInstockDetail.ashx?id=" + $scope.paramObj.id
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.tableRows = data.Message.rows;
                    for (var i = 0; i < $scope.tableRows.length; i++) {
                        $scope.tableRows[i].checked = false
                    }
                    $scope.headInfo.ID = data.Message.head.ID;
                    $scope.headInfo.CODE = data.Message.head.CODE;
                    $scope.headInfo.WAREHOUSE_ID = data.Message.head.WAREHOUSE_ID;
                    $scope.headInfo.WAREHOUSE_ID_NAME = data.Message.head.WAREHOUSE_ID_NAME;
                    $scope.stock.param.condition = data.Message.head.WAREHOUSE_ID_NAME;

                    $scope.headInfo.PROVIDER_ID = data.Message.head.PROVIDER_ID;
                    $scope.headInfo.PROVIDER_ID_NAME = data.Message.head.PROVIDER_ID_NAME;
                    $scope.prv.param.condition = data.Message.head.PROVIDER_ID_NAME;

                    $scope.headInfo.CREATE_DATE = data.Message.head.CREATE_DATE;
                    $scope.headInfo.USER_ID = data.Message.head.USER_ID;
                    $scope.headInfo.USER_ID_NAME = data.Message.head.USER_ID_NAME;
                    $scope.audit.param.condition = data.Message.head.USER_ID_NAME;

                    $scope.headInfo.COMMENTS = data.Message.head.COMMENTS;
                    $scope.headInfo.INVOICE_CODE = data.Message.head.INVOICE_CODE;
                    $scope.headInfo.TOTAL_MONEY = data.Message.head.TOTAL_MONEY;

                    $scope.headInfo.STATE = data.Message.head.STATE;
                    $scope.headInfo.STATE_NAME = data.Message.head.STATE_NAME;



                } else {
                    alert(data.Message)
                }
            })
        };
      

        $scope.clearFkDetailState = function () {
            angular.forEach($scope.tableRows, function (v, k) {
                $scope.tableRows[k].showDeptState = false;
                $scope.tableRows[k].showMceTypeState = false;
                $scope.tableRows[k].showPrdState = false;
                $scope.tableRows[k].showUnitState = false;
                $scope.tableRows[k].showCountryState = false;
                $scope.tableRows[k].showDeprState = false;
            })
        };


        //领用科室
        $scope.conditionDeptForAdd = {
            is_area: "0",
            condition: ""
        };
        $scope.deptList = [];
        $scope.fkDeptPager = ParamService.getPager();
        $scope.searcFkDeptListForAdd = function (curIndex, v) {
            $scope.conditionDeptForAdd.condition = v.USING_DEPT_ID_NAME;
            v.showDeptState = true;
            var param = ParamService.comParam(curIndex, $scope.fkDeptPager.pageSize, $scope.conditionDeptForAdd);
            $http.get($rootScope.baseUrl + "service/mtr/Srv_MTR_DeptList.ashx" + param).success(function (data) {
                if (data.Succeed == 1) {
                    v.showDeptState = true;
                    $scope.deptList = data.Message.rows;
                    $scope.fkDeptPager.setDataNum(data.Message.total);
                    $scope.fkDeptPager.setCurIndex(curIndex);
                }
            })
        };
        $scope.changeFkDeptState = function (index) {
            $scope.clearFkDetailState();
            $scope.tableRows[index].showDeptState = true;
        };
        $scope.selectFkDeptForAdd = function (v, a) {
            v.showDeptState = false;
            v.USING_DEPT_ID = a.id;
            v.USING_DEPT_ID_NAME = a.name;
        };
        $scope.clearFkDeptForAdd = function (v) {
            v.USING_DEPT_ID = "";
            v.USING_DEPT_ID_NAME = "";
        };


        //分类
        $scope.conditionMceTypeForAdd = {
            status:1,
            condition: ""
        };
        $scope.mceTypeList = [];
        $scope.fkMceTypePager = ParamService.getPager();
        $scope.searcFkMCeTypeListForAdd = function (curIndex, v) {
            $scope.conditionMceTypeForAdd.condition = v.ASSET_TYPE_ID_NAME;
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
            $scope.clearFkDetailState();
            $scope.tableRows[index].showMceTypeState = true;
        };
        $scope.selectFkMceTypeForAdd = function (v, a) {
            v.showMceTypeState = false;
            v.ASSET_TYPE_ID = a.ID;
            v.ASSET_TYPE_ID_NAME = a.NAME;
        };
        $scope.clearFkMceTypeForAdd = function (v) {
            v.ASSET_TYPE_ID = "";
            v.ASSET_TYPE_ID_NAME = "";
        };



        //生产厂家
        $scope.conditionPrdForAdd = {
            type: "00340003",
            condition: ""
        };
        $scope.prdList = [];
        $scope.fkPrdPager = ParamService.getPager();
        $scope.searcFkPrdListForAdd = function (curIndex, v) {
            $scope.conditionPrdForAdd.condition = v.PRD_ID_NAME;
            v.showPrdState = true;
            var param = ParamService.comParam(curIndex, $scope.fkPrdPager.pageSize, $scope.conditionPrdForAdd);
            $http.get($rootScope.baseUrl + "service/mtr/Srv_MTR_PrvList.ashx" + param).success(function (data) {
                if (data.Succeed == 1) {
                    v.showPrdState = true;
                    $scope.prdList = data.Message.rows;
                    $scope.fkPrdPager.setDataNum(data.Message.total);
                    $scope.fkPrdPager.setCurIndex(curIndex);
                }
            })
        };
        $scope.changeFkPrdState = function (index) {
            $scope.clearFkDetailState();
            $scope.tableRows[index].showPrdState = true;
        };
        $scope.selectFkPrdForAdd = function (v, a) {
            v.showPrdState = false;
            v.PRD_ID = a.id;
            v.PRD_ID_NAME = a.name;
        };
        $scope.clearFkPrdForAdd = function (v) {
            v.PRD_ID = "";
            v.PRD_ID_NAME = "";
        };



        //单位
        $scope.conditionUnitForAdd = {
            parent:"MCE_0004",
            condition: ""
        };
        $scope.unitList = [];
        $scope.fkUnitPager = ParamService.getPager();
        $scope.searcFkUnitListForAdd = function (curIndex, v) {
            $scope.conditionUnitForAdd.condition = v.UNIT_ID_NAME;
            v.showUnitState = true;
            var param = ParamService.comParam(curIndex, $scope.fkUnitPager.pageSize, $scope.conditionUnitForAdd);
            $http.get($rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx" + param).success(function (data) {
                if (data.Succeed == 1) {
                    v.showUnitState = true;
                    $scope.unitList = data.Message.rows;
                    $scope.fkUnitPager.setDataNum(data.Message.total);
                    $scope.fkUnitPager.setCurIndex(curIndex);
                }
            })
        };
        $scope.changeFkUnitState = function (index) {
            $scope.clearFkDetailState();
            $scope.tableRows[index].showUnitState = true;

        };
        $scope.selectFkUnitForAdd = function (v, a) {
            v.showUnitState = false;
            v.UNIT_ID = a.id;
            v.UNIT_ID_NAME = a.name;
        };
        $scope.clearFkUnitForAdd = function (v) {
            v.UNIT_ID = "";
            v.UNIT_ID_NAME = "";
        };



        //折旧方式
        $scope.conditionDeprForAdd = {
            parent: "MCE_0004",
            condition: ""
        };
        $scope.deprList = [];
        $scope.fkDeprPager = ParamService.getPager();
        $scope.searcFkDeprListForAdd = function (curIndex, v) {
            $scope.conditionDeprForAdd.condition = v.DEPR_TYPE_ID_NAME;
            v.showDeprState = true;
            var param = ParamService.comParam(curIndex, $scope.fkDeprPager.pageSize, $scope.conditionDeprForAdd);
            $http.get($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCEAssetsDeprTypeList.ashx" + param).success(function (data) {
                if (data.Succeed == 1) {
                    v.showDeprState = true;
                    $scope.deprList = data.Message;
                    $scope.fkDeprPager.setDataNum(data.Message.length);
                    $scope.fkDeprPager.setCurIndex(curIndex);
                }
            })
        };
        $scope.changeFkDeprState = function (index) {
            $scope.clearFkDetailState();
            $scope.tableRows[index].showDeprState = true;

        };
        $scope.selectFkDeprForAdd = function (v, a) {
            v.showDeprState = false;
            v.DEPR_TYPE_ID = a.ID;
            v.DEPR_TYPE_ID_NAME = a.NAME;
        };
        $scope.clearFkDeprForAdd = function (v) {
            v.DEPR_TYPE_ID = "";
            v.DEPR_TYPE_ID_NAME = "";
        };


        //国家
        $scope.conditionCountryForAdd = {
            parent: "0065",
            condition: ""
        };
        $scope.countryList = [];
        $scope.fkCountryPager = ParamService.getPager();
        $scope.searcFkCountryListForAdd = function (curIndex, v) {
            $scope.conditionCountryForAdd.condition = v.COUNTRY_NAME;
            v.showCountryState = true;
            var param = ParamService.comParam(curIndex, $scope.fkCountryPager.pageSize, $scope.conditionCountryForAdd);
            $http.get($rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx" + param).success(function (data) {
                if (data.Succeed == 1) {
                    v.showCountryState = true;
                    $scope.countryList = data.Message.rows;
                    $scope.fkCountryPager.setDataNum(data.Message.total);
                    $scope.fkCountryPager.setCurIndex(curIndex);
                }
            })
        };
        $scope.changeFkCountryState = function (index) {
            $scope.clearFkDetailState();
            $scope.tableRows[index].showCountryState = true;

        };
        $scope.selectFkCountryForAdd = function (v, a) {
            v.showCountryState = false;
            v.COUNTRY = a.id;
            v.COUNTRY_NAME = a.name;
        };
        $scope.clearFkCountryForAdd = function (v) {
            v.COUNTRY = "";
            v.COUNTRY_NAME = "";
        };


        $scope.creatModel = function () {
            return {
                ID: "",
                USING_DEPT_ID: "",
                USING_DEPT_ID_NAME: "",
                ASSET_ID: "",
                ASSET_TYPE_ID: "",
                ASSET_TYPE_ID_NAME: "",
                ASSETS_NAME: "",
                SPEC: "",
                PRD_ID: "",
                PRD_ID_NAME: "",
                PRICE: 0,
                AMOUNT: 0,
                MONEY: 0,
                UNIT_ID: "",
                UNIT_ID_NAME: "",
                COUNTRY: "",
                COUNTRY_NAME: "",
                DEPR_YEAR_AMOUNT: 0,

                DEPR_TYPE_ID: "",
                DEPR_TYPE_ID_NAME: "",

                REF_TAB_ID: "",
                REF_TAB_NAME: "",

                checked: false,
                showDeptState: false,
                showMceTypeState: false,
                showPrdState: false,
                showUnitState: false,
                showCountryState: false,
                showDeprState: false
            }
        };
        $scope.addModel = function () {
            $scope.tableRows.push($scope.creatModel())
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
                $http.post($rootScope.baseUrl + "service/mce/mce_instock/Srv_MCE_MCEInstockOperate.ashx?oType=submit", list).success(function (data) {
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
                $http.post($rootScope.baseUrl + "service/mce/mce_instock/Srv_MCE_MCEInstockOperate.ashx?oType=audit", list).success(function (data) {
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
                WAREHOUSE_ID: "",
                PROVIDER_ID: "",
                CREATE_DATE: "",
                USE_USER_ID: "",
                COMMENTS: "",
                INVOICE_CODE: "",
                STATE: 1,
                DELETEIDS:[],
                children:[]
            };
            function  retModel() {
                return {
                    ID: "",
                    USING_DEPT_ID: "",
                    ASSET_ID: "",
                    ASSET_TYPE_ID: "",
                    ASSETS_NAME: "",
                    SPEC: "",
                    PRD_ID: "",
                    PRICE: 0,
                    AMOUNT: 0,
                    MONEY: 0,
                    UNIT_ID: "",
                    COUNTRY: "",
                    DEPR_YEAR_AMOUNT: "",
                    DEPR_TYPE_ID: "",
                    REF_TAB_ID: "",
                    REF_TAB_NAME: ""
                }
            }
            if ($scope.headInfo.PROVIDER_ID == "") {
                alert("请选择供应商");
                return
            }
     
            if ($scope.headInfo.INVOICE_CODE == "") {
                alert("请输入发票号");
                return
            }
            data.ID = $scope.headInfo.ID;
            data.CODE = $scope.headInfo.CODE;
            data.WAREHOUSE_ID = $scope.headInfo.WAREHOUSE_ID;
            data.PROVIDER_ID = $scope.headInfo.PROVIDER_ID;

            data.CREATE_DATE = $scope.headInfo.CREATE_DATE;
            data.USER_ID = $scope.headInfo.USER_ID;

            data.COMMENTS = $scope.headInfo.COMMENTS;
            data.INVOICE_CODE = $scope.headInfo.INVOICE_CODE;
            data.DELETEIDS = $scope.deleteIDs;

            for (var i = 0; i < $scope.tableRows.length; i++) {
      
                data.children.push(retModel());
                data.children[i].ID = $scope.tableRows[i].ID;
                data.children[i].ASSET_ID = $scope.tableRows[i].ASSET_ID;
                data.children[i].USING_DEPT_ID = $scope.tableRows[i].USING_DEPT_ID;
                data.children[i].ASSET_TYPE_ID = $scope.tableRows[i].ASSET_TYPE_ID;
                data.children[i].ASSETS_NAME = $scope.tableRows[i].ASSETS_NAME;
                data.children[i].SPEC = $scope.tableRows[i].SPEC;
                data.children[i].PRD_ID = $scope.tableRows[i].PRD_ID;
                data.children[i].PRICE = $scope.tableRows[i].PRICE;
                data.children[i].AMOUNT = $scope.tableRows[i].AMOUNT;
                data.children[i].MONEY = $scope.tableRows[i].MONEY;
                data.children[i].UNIT_ID = $scope.tableRows[i].UNIT_ID;
                data.children[i].COUNTRY = $scope.tableRows[i].COUNTRY;
                data.children[i].DEPR_YEAR_AMOUNT = $scope.tableRows[i].DEPR_YEAR_AMOUNT;
                data.children[i].DEPR_TYPE_ID = $scope.tableRows[i].DEPR_TYPE_ID;

                data.children[i].REF_TAB_ID = $scope.tableRows[i].REF_TAB_ID;
                data.children[i].REF_TAB_NAME = $scope.tableRows[i].REF_TAB_NAME;

                if (data.children[i].USING_DEPT_ID == null || data.children[i].USING_DEPT_ID == "")
                {
                    alert("请输入领用科室");
                    return
                }

                if (data.children[i].ASSET_TYPE_ID == null || data.children[i].ASSET_TYPE_ID == "") {
                    alert("请输入设备类型");
                    return
                }

                if (data.children[i].ASSETS_NAME == null || data.children[i].ASSETS_NAME == "") {
                    alert("请输入设备名称");
                    return
                }

                if (data.children[i].SPEC == null || data.children[i].SPEC == "") {
                    alert("请输入设备规格");
                    return
                }

                if (data.children[i].AMOUNT * 1 <= 0 || isNaN(data.children[i].AMOUNT)) {
                    alert("请输入正确的数量");
                    return
                }
                if (data.children[i].PRICE * 1 <= 0 || isNaN(data.children[i].PRICE)) {
                    alert("请输入正确的价格");
                    return
                }
                if (data.children[i].UNIT_ID == null || data.children[i].UNIT_ID == "") {
                    alert("请输入单位");
                    return
                }

            }

            $http({
                method:"POST",
                url: $rootScope.baseUrl + "service/mce/mce_instock/Srv_MCE_MCEInstockSave.ashx",
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
            invoicecode: "",
            prvid: "",
            code: "",
            condition: " and MCE_B_AOG.id in(select base_id from MCE_B_AOG_D where  nvl(amount,0) > nvl(ref_used_amount,0)) "
        };
        $scope.modelPurchaseList = [];
        $scope.mainPurchasePager = ParamService.getPager();

        //Asset列表查询
        $scope.getModelPurchaseList = function (curIndex) {

            $scope.paramPurchaseObj.prvid = $scope.headInfo.PROVIDER_ID;
            $scope.paramPurchaseObj.invoicecode = $scope.headInfo.INVOICE_CODE;

            var param = ParamService.comParam(curIndex, $scope.mainPurchasePager.pageSize, $scope.paramPurchaseObj);
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mce/mce_instock/Srv_MCE_GetMCEAOGList.ashx" + param
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

            if ($scope.headInfo.INVOICE_CODE == "") {
                alert("请输入发票号");
                return
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
            var vIDs = "";
            for (var i = 0; i < $scope.modelPurchaseList.length; i++) {
                if ($scope.modelPurchaseList[i].checked == true) {
                    added = added + 1;
                    vIDs = vIDs + $scope.modelPurchaseList[i].ID + ",";
                }
            }
            if (added == 0) {
                alert("请选择");
                return false
            }
            else {
                vIDs = vIDs.substr(0, vIDs.length - 1);

                $http({
                    method: "GET",
                    url: $rootScope.baseUrl + "service/mce/mce_instock/Srv_MCE_GetMCEInstockRefAOG.ashx?ids=" + vIDs
                }).then(function (data) {
                    var data = data.data;
                    if (data.Succeed == 1) {


                        for (var i = 0; i < data.Message.length; i++) {

                            var vExist = false;
                            for (var k = 0; k < $scope.tableRows.length; k++) {
                                if ($scope.tableRows[k].REF_TAB_ID == data.Message[i].ID) {
                                    var vExist = true;
                                    break;
                                }
                            }

                            if (vExist == false) {
                                var vModal = $scope.creatModel();
                                vModal.ID = "";

                                vModal.USING_DEPT_ID = data.Message[i].USING_ID;
                                vModal.USING_DEPT_ID_NAME = data.Message[i].USING_PERSON;

                                vModal.ASSET_TYPE_ID = data.Message[i].ASSET_TYPE_ID;
                                vModal.ASSET_TYPE_ID_NAME = data.Message[i].ASSET_TYPE_ID_NAME;
                                vModal.ASSET_ID = data.Message[i].ASSET_ID;
                                vModal.ASSETS_NAME = data.Message[i].ASSETS_NAME;
                                vModal.SPEC = data.Message[i].SPEC;

                                vModal.PRD_ID = data.Message[i].REF_PRD_ID;
                                vModal.PRD_ID_NAME = data.Message[i].PRD_ID_NAME;
                                vModal.PRICE = data.Message[i].PRICE;
                                vModal.AMOUNT = data.Message[i].AMOUNT;
                                vModal.MONEY = vModal.PRICE * vModal.AMOUNT;
                                vModal.UNIT_ID = data.Message[i].UNIT_ID;
                                vModal.UNIT_ID_NAME = data.Message[i].UNIT_ID_NAME;

                                vModal.REF_TAB_ID = data.Message[i].ID;
                                vModal.REF_TAB_NAME = "MCE_B_AOG_D";

                                $scope.tableRows.push(vModal);

                            }
                        }

                    }
                    else {
                        alert(data.Message)
                    }
                })


                $scope.newState.state = false;
                //alert("添加成功");
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

            /*
            if ($scope.dept.param.condition == null || $scope.dept.param.condition == "") {
                alert("请选择申购科室");
                return;
            }
            */

            $scope.paramAssetObj.name = "";
            $scope.getAssetsList(1);

            $scope.newState2.state = true;
        };


        $scope.addAssetInfo = function (v) {

            if (v.APPLY_AMOUNT * 1 <= 0 || isNaN(v.APPLY_AMOUNT * 1)) {
                alert("请输入正确的申购数量");
                return;
            }

            var vModal = $scope.creatModel();
            vModal.ID = "";
            vModal.ASSET_TYPE_ID = v.TYPE_ID;
            vModal.ASSET_TYPE_ID_NAME = v.TYPE_ID_NAME;
            vModal.ASSET_ID = v.ID;
            vModal.ASSETS_NAME = v.NAME;
            vModal.SPEC = v.SPEC;

            vModal.PRD_ID = v.PRD_ID;
            vModal.PRD_ID_NAME = v.PRD_ID_NAME;
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
            refprv: "",
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

                } else {
                    alert(data.Message)
                }
            })
        };




        $scope.goBack = function () {
            window.location.replace("PageMceInstockList.html")
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