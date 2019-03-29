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
            USING_DEPT_ID: "",
            USING_DEPT_ID_NAME: "",
            CREATE_DATE: "",
            USING_USER_ID: "",
            USING_USER_ID_NAME: "",
            COMMENTS: "",
            TOTAL_MONEY: 0,
            STATE: 0,
            STATE_NAME: "",
        };
        $scope.tableRows = [];
        $scope.deleteIDs = [];

        $scope.InputschangeState = InputschangeState;
        $scope.InputschangeState.states = {
            dept: false,
            stock: false,
            user: false
        };

        //使用科室
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


        //领用人
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
                url: $rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_GetMCEAssetsUserInfo.ashx?code_type=MceOutstock"
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
                url: $rootScope.baseUrl + "service/mce/mce_outstock/Srv_MCE_GetMCEOutstockDetail.ashx?id=" + $scope.paramObj.id
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.tableRows = data.Message.rows;
                    for (var i = 0; i < $scope.tableRows.length; i++) {
                        $scope.tableRows[i].checked = false
                    }
                    $scope.headInfo.ID = data.Message.head.ID;
                    $scope.headInfo.CODE = data.Message.head.CODE;
                    $scope.headInfo.WAREHOUSE_ID = data.Message.head.STOCK_ID;
                    $scope.headInfo.WAREHOUSE_ID_NAME = data.Message.head.STOCK_ID_NAME;
                    $scope.stock.param.condition = data.Message.head.STOCK_ID_NAME;
                    
                    $scope.headInfo.CREATE_DATE = data.Message.head.CREATE_DATE;

                    $scope.headInfo.USING_DEPT_ID = data.Message.head.USING_DEPT_ID;
                    $scope.headInfo.USING_DEPT_ID_NAME = data.Message.head.USING_DEPT_ID_NAME;
                    $scope.dept.param.condition = data.Message.head.USING_DEPT_ID_NAME;

                    $scope.headInfo.USING_USER_ID = data.Message.head.USING_USER_ID;
                    $scope.headInfo.USING_USER_ID_NAME = data.Message.head.USING_USER_ID_NAME;
                    $scope.user.param.condition = data.Message.head.USING_USER_ID_NAME;

                    $scope.headInfo.COMMENTS = data.Message.head.COMMENTS;
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
    
                $scope.tableRows[k].showPrdState = false;
                $scope.tableRows[k].showUnitState = false;
                $scope.tableRows[k].showCountryState = false;
                $scope.tableRows[k].showUseState = false;
            })
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


        //用途
        $scope.conditionUseForAdd = {
            parent: "0047",
            condition: ""
        };
        $scope.useList = [];
        $scope.fkUsePager = ParamService.getPager();
        $scope.searcFkUseListForAdd = function (curIndex, v) {
            $scope.conditionUseForAdd.condition = v.ECONOMIC_USE_TYPE_ID_NAME;
            v.showUseState = true;
            var param = ParamService.comParam(curIndex, $scope.fkUsePager.pageSize, $scope.conditionUseForAdd);
            $http.get($rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx" + param).success(function (data) {
                if (data.Succeed == 1) {
                    v.showUseState = true;
                    $scope.useList = data.Message.rows;
                    $scope.fkUsePager.setDataNum(data.Message.total);
                    $scope.fkUsePager.setCurIndex(curIndex);
                }
            })
        };
        $scope.changeFkUseState = function (index) {
            $scope.clearFkDetailState();
            $scope.tableRows[index].showUseState = true;

        };
        $scope.selectFkUseForAdd = function (v, a) {
            v.showUseState = false;
            v.ECONOMIC_USE_TYPE_ID = a.id;
            v.ECONOMIC_USE_TYPE_ID_NAME = a.name;
        };
        $scope.clearFkUseForAdd = function (v) {
            v.ECONOMIC_USE_TYPE_ID = "";
            v.ECONOMIC_USE_TYPE_ID_NAME = "";
        };


        $scope.creatModel = function () {
            return {
                ID: "",
             

                ASSET_TYPE_ID: "",
                ASSET_TYPE_ID_NAME: "",
                ASSETS_ID:"",
                ASSETS_NAME: "",
                ASSETS_CODE: "",
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
                USE_DATE: "",

                ECONOMIC_USE_TYPE_ID: "",
                ECONOMIC_USE_TYPE_ID_NAME: "",

                REF_TAB_ID: "",
                REF_TAB_NAME: "",

                checked: false,
            
                showPrdState: false,
                showUnitState: false,
                showCountryState: false,
                showUseState: false
            }
        };



        $scope.paramAssetObj = {
            assets_state: "00530001",
            use_state: "00540002",
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
                    var vModal = $scope.creatModel();
                    vModal.ASSET_TYPE_ID = $scope.modelAssetList[i].MACHINE_TYPE_ID;
                    vModal.ASSET_TYPE_ID_NAME = $scope.modelAssetList[i].MACHINE_TYPE_ID_NAME;
                    vModal.ASSETS_ID = $scope.modelAssetList[i].ID;
                    vModal.ASSETS_NAME = $scope.modelAssetList[i].ASSETS_NAME;
                    vModal.ASSETS_CODE = $scope.modelAssetList[i].ASSETS_CODE;
                    vModal.SPEC = $scope.modelAssetList[i].SPEC;

                    vModal.UNIT_ID = $scope.modelAssetList[i].UNIT_ID;
                    vModal.UNIT_ID_NAME = $scope.modelAssetList[i].UNIT_ID_NAME;

                    vModal.PRD_ID = $scope.modelAssetList[i].PRD_ID;
                    vModal.PRD_ID_NAME = $scope.modelAssetList[i].PRD_ID_NAME;

                    vModal.PRICE = $scope.modelAssetList[i].ORIGINAL_VALUE; 

                    vModal.REF_TAB_ID = $scope.modelAssetList[i].ID;
                    vModal.REF_TAB_NAME = "MCE_B_ASSETS";

                    $scope.tableRows.push(vModal);
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
                $http.post($rootScope.baseUrl + "service/mce/mce_outstock/Srv_MCE_MCEOutstockOperate.ashx?oType=submit", list).success(function (data) {
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
                $http.post($rootScope.baseUrl + "service/mce/mce_outstock/Srv_MCE_MCEOutstockOperate.ashx?oType=audit", list).success(function (data) {
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
                CREATE_DATE: "",
                USING_DEPT_ID: "",
                USING_USER_ID: "",
                COMMENTS: "",
                STATE: 1,
                DELETEIDS:[],
                children:[]
            };
            function  retModel() {
                return {
                    ID: "",
                    ASSET_TYPE_ID: "",
                    ASSETS_ID: "",
                    ASSETS_NAME: "",
                    ASSETS_CODE: "",
                    SPEC: "",
                    PRD_ID: "",
                    PRICE: 0,
                    AMOUNT: 0,
                    MONEY: 0,
                    UNIT_ID: "",
                    COUNTRY: "",
                    USE_DATE: "",
                    ECONOMIC_USE_TYPE_ID: "",
                    REF_TAB_ID: "",
                    REF_TAB_NAME: ""
                }
            }
         
            data.ID = $scope.headInfo.ID;
            data.CODE = $scope.headInfo.CODE;
            data.WAREHOUSE_ID = $scope.headInfo.WAREHOUSE_ID;
       
            data.CREATE_DATE = $scope.headInfo.CREATE_DATE;
            data.USING_DEPT_ID = $scope.headInfo.USING_DEPT_ID;
            data.USING_USER_ID = $scope.headInfo.USING_USER_ID;

            data.COMMENTS = $scope.headInfo.COMMENTS;
            data.DELETEIDS = $scope.deleteIDs;

            for (var i = 0; i < $scope.tableRows.length; i++) {
      
                data.children.push(retModel());
                data.children[i].ID = $scope.tableRows[i].ID;
                data.children[i].ASSET_TYPE_ID = $scope.tableRows[i].ASSET_TYPE_ID;
                data.children[i].ASSETS_ID = $scope.tableRows[i].ASSETS_ID;
                data.children[i].ASSETS_NAME = $scope.tableRows[i].ASSETS_NAME;
                data.children[i].ASSETS_CODE = $scope.tableRows[i].ASSETS_CODE;

                data.children[i].SPEC = $scope.tableRows[i].SPEC;
                data.children[i].PRD_ID = $scope.tableRows[i].PRD_ID;
                data.children[i].PRICE = $scope.tableRows[i].PRICE;
                data.children[i].AMOUNT = $scope.tableRows[i].AMOUNT;
                data.children[i].MONEY = $scope.tableRows[i].MONEY;
                data.children[i].UNIT_ID = $scope.tableRows[i].UNIT_ID;
                data.children[i].COUNTRY = $scope.tableRows[i].COUNTRY;
                data.children[i].USE_DATE = $scope.tableRows[i].USE_DATE;
                data.children[i].ECONOMIC_USE_TYPE_ID = $scope.tableRows[i].ECONOMIC_USE_TYPE_ID;

                data.children[i].REF_TAB_ID = $scope.tableRows[i].REF_TAB_ID;
                data.children[i].REF_TAB_NAME = $scope.tableRows[i].REF_TAB_NAME;
         
                if (data.children[i].ASSETS_NAME == null || data.children[i].ASSETS_NAME == "") {
                    alert("设备名称不能为空");
                    return
                }

                //if (data.children[i].SPEC == null || data.children[i].SPEC == "") {
                //    alert("请输入设备规格");
                //    return
                //}

                if (data.children[i].AMOUNT * 1 <= 0 || isNaN(data.children[i].AMOUNT)) {
                    alert("请输入正确的数量");
                    return
                }
                if (data.children[i].PRICE * 1 <= 0 || isNaN(data.children[i].PRICE)) {
                    alert("价格不正确");
                    return
                }
                if (data.children[i].UNIT_ID == null || data.children[i].UNIT_ID == "") {
                    alert("单位不能为空");
                    return
                }

            }

            $http({
                method:"POST",
                url: $rootScope.baseUrl + "service/mce/mce_outstock/Srv_MCE_MCEOutstockSave.ashx",
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
            window.location.replace("PageMceOutstockList.html")
        };

        $scope.default = function () {
            $scope.getDetailId();
          
            if ($scope.paramObj.id != "") {
        
                $scope.getDetailInfo();

            } else {
                $scope.getUserInfo();
              //  $scope.addModel();
            }

         

        };
        $scope.default();


    }])