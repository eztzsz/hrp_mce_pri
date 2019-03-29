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

            RETURN_DEPT_ID: "",
            RETURN_DEPT_ID_NAME: "",
            RETURN_USER_ID: "",
            RETURN_USER_ID_NAME: "",

            DEPT_ID: "",
            DEPT_ID_NAME: "",
            USER_ID: "",
            USER_ID_NAME: "",

            CREATE_DATE: "",

            STOCK_ID: "",
            STOCK_ID_NAME: "",

            COMMENTS: "",

            STATE: 0,
            STATE_NAME: "",
        };
        $scope.tableRows = [];
        $scope.deleteIDs = [];

        $scope.InputschangeState = InputschangeState;
        $scope.InputschangeState.states = {
            returndept: false,
            returnuser: false,
            dept: false,
            user: false,
            stock:false
        };


        //退库科室
        $scope.returndept = ParamS($rootScope.baseUrl + "service/mtr/Srv_MTR_DeptList.ashx");
        $scope.returndept.showTabTh = ['编号', '名称', "院区"];
        $scope.returndept.showTabTb = ['code', 'name', "areaName"];
        $scope.returndept.param = {
            is_area: "0",
            condition: ""
        };
        $scope.paramReturnDept = {
            returndept: ""
        };

        $scope.$watch("paramReturnDept", function (n, o) {
            $scope.headInfo.RETURN_DEPT_ID = n.returndept.trim();
            $scope.headInfo.RETURN_DEPT_ID_NAME = $scope.returndept.param.condition;
        }, true);


        //退库人
        $scope.returnuser = ParamS($rootScope.baseUrl + "service/mtr/mtr_high_basic/Srv_MTR_High_GetUserList.ashx");
        $scope.returnuser.showTabTh = ['用户名', '姓名'];
        $scope.returnuser.showTabTb = ['ACCOUNT', 'NAME'];
        $scope.returnuser.param = {
            name: "",
            condition: ""
        };
        $scope.paramReturnUser = {
            returnuser: ""
        };

        $scope.$watch("paramReturnUser", function (n, o) {
            $scope.headInfo.RETURN_USER_ID = n.returnuser.trim();
            $scope.headInfo.RETURN_USER_ID_NAME = $scope.returnuser.param.condition;
        }, true);


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
            $scope.headInfo.DEPT_ID = n.dept.trim();
            $scope.headInfo.DEPT_ID_NAME = $scope.dept.param.condition;
        }, true);


        //使用人
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
            $scope.headInfo.USER_ID = n.user.trim();
            $scope.headInfo.USER_ID_NAME = $scope.user.param.condition;
        }, true);



        //入库仓库
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
            $scope.headInfo.STOCK_ID = n.stock.trim();
            $scope.headInfo.STOCK_ID_NAME = $scope.stock.param.condition;
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
                url: $rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_GetMCEAssetsUserInfo.ashx?code_type=MceBack"
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
                url: $rootScope.baseUrl + "service/mce/mce_outstock/Srv_MCE_GetMCEBackDetail.ashx?id=" + $scope.paramObj.id
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.tableRows = data.Message.rows;
                    for (var i = 0; i < $scope.tableRows.length; i++) {
                        $scope.tableRows[i].checked = false
                    }
                    $scope.headInfo.ID = data.Message.head.ID;
                    $scope.headInfo.CODE = data.Message.head.CODE;

                    $scope.headInfo.RETURN_DEPT_ID = data.Message.head.RETURN_DEPT_ID;
                    $scope.headInfo.RETURN_DEPT_ID_NAME = data.Message.head.RETURN_DEPT_ID_NAME;
                    $scope.returndept.param.condition = data.Message.head.RETURN_DEPT_ID_NAME;

                    $scope.headInfo.RETURN_USER_ID = data.Message.head.RETURN_USER_ID;
                    $scope.headInfo.RETURN_USER_ID_NAME = data.Message.head.RETURN_USER_ID_NAME;
                    $scope.returnuser.param.condition = data.Message.head.RETURN_USER_ID_NAME;


                    $scope.headInfo.DEPT_ID = data.Message.head.DEPT_ID;
                    $scope.headInfo.DEPT_ID_NAME = data.Message.head.DEPT_ID_NAME;
                    $scope.dept.param.condition = data.Message.head.DEPT_ID_NAME;

                    $scope.headInfo.USER_ID = data.Message.head.USER_ID;
                    $scope.headInfo.USER_ID_NAME = data.Message.head.USER_ID_NAME;
                    $scope.user.param.condition = data.Message.head.USER_ID_NAME;

                    $scope.headInfo.STOCK_ID = data.Message.head.STOCK_ID;
                    $scope.headInfo.STOCK_ID_NAME = data.Message.head.STOCK_ID_NAME;
                    $scope.stock.param.condition = data.Message.head.STOCK_ID_NAME;


                    $scope.headInfo.CREATE_DATE = data.Message.head.CREATE_DATE;
                  
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
                    $scope.tableRows[k].showMceState = false;
 
            })
        };


        $scope.creatModel = function () {
            return {
                ID: "",
                ASSETS_ID: "",
                ASSETS_CODE: "",
                ASSETS_NAME: "",
                SPEC: "",
                COMMENTS:"",

                REF_TAB_ID: "",
                REF_TAB_NAME: "",
                checked: false,
                showMceState: false
            }
        };
     

        $scope.paramOutStockObj = {
            status: "3",
            dept: "",
            code: ""
        };
        $scope.modelOutStockList = [];
        $scope.mainOutStockPager = ParamService.getPager();

        //Asset列表查询
        $scope.getModelOutStockList = function (curIndex) {


            $scope.paramOutStockObj.dept = $scope.headInfo.RETURN_DEPT_ID;

            var param = ParamService.comParam(curIndex, $scope.mainOutStockPager.pageSize, $scope.paramOutStockObj);
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mce/mce_outstock/Srv_MCE_GetMCEOutstockList.ashx" + param
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.modelOutStockList = data.Message.rows;
                    $scope.mainOutStockPager.setDataNum(data.Message.total);
                    $scope.mainOutStockPager.setCurIndex(curIndex);
                    for (var i = 0; i < $scope.modelOutStockList.length; i++) {
                        $scope.modelOutStockList[i].checked = false;

                    }
                }
            })
        };


        $scope.newState = {
            state: false
        };

        $scope.openNew = function () {
            if ($scope.returndept.param.condition == null || $scope.returndept.param.condition == "")
            {
                alert("请选择退库科室");
                return;
            }

            $scope.paramOutStockObj.code = "";
            $scope.getModelOutStockList();
            for (var i = 0; i < $scope.modelOutStockList.length; i++) {
                $scope.modelOutStockList[i].checked = false;
            }

            $scope.newState.state = true;
        };


        $scope.checkAssetSate = {
            state: false
        };

        $scope.checkAllAssett = function () {
            $scope.checkAssetSate.state = !$scope.checkAssetSate.state
            for (var i = 0; i < $scope.modelOutStockList.length; i++) {
                $scope.modelOutStockList[i].checked = $scope.checkAssetSate.state
            }
        };

        $scope.addInfo = function () {
            var added = 0;
            var vIDs = "";
            for (var i = 0; i < $scope.modelOutStockList.length; i++) {
                if ($scope.modelOutStockList[i].checked == true) {
                    added = added + 1;
                    vIDs = vIDs + $scope.modelOutStockList[i].ID + ",";
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
                    url: $rootScope.baseUrl + "service/mce/mce_outstock/Srv_MCE_GetMCEOutStockBackList.ashx?ids=" + vIDs
                }).then(function (data) {
                    var data = data.data;
                    if (data.Succeed == 1) {
                      

                        for (var i = 0; i < data.Message.length; i++) {

                            var vExist = false;
                            for (var k = 0; k< $scope.tableRows.length; k++) {
                                if ($scope.tableRows[k].ASSETS_ID == data.Message[i].ID)
                                {
                                    var vExist = true;
                                    break;
                                }
                            }

                            if (vExist == false) {
                                var vModal = $scope.creatModel();
                                vModal.ID = "";
                                vModal.ASSETS_ID = data.Message[i].ID;
                                vModal.ASSETS_NAME = data.Message[i].ASSETS_NAME;
                                vModal.ASSETS_CODE = data.Message[i].ASSETS_CODE;
                                vModal.SPEC = data.Message[i].SPEC;
                                vModal.REF_TAB_ID = data.Message[i].OUT_D_ID;
                                vModal.REF_TAB_NAME = "MCE_B_ASSETS_OUTSTOCK_D";
                                $scope.tableRows.push(vModal);
                            }
                        }

                    }
                    else
                    {
                        alert(data.Message)
                    }
                })


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
                $http.post($rootScope.baseUrl + "service/mce/mce_outstock/Srv_MCE_MCEBackOperate.ashx?oType=submit", list).success(function (data) {
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
                $http.post($rootScope.baseUrl + "service/mce/mce_outstock/Srv_MCE_MCEBackOperate.ashx?oType=audit", list).success(function (data) {
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
           
                CODE:"",
                TRANSFER_DEPT_ID: "",
                TRANSFER_USER_ID: "",
             
                DEPT_ID: "",
                USER_ID: "",
                STOCK_ID: "",

                COMMENTS: "",

                STATE: 1,
                DELETEIDS:[],
                children:[]
            };
            function  retModel() {
                return {
                    ID: "",
                    ASSETS_ID: "",
                    ASSETS_CODE: "",
                    ASSETS_NAME: "",
                    SPEC: "",
                    COMMENTS: ""
                }
            }
            if ($scope.headInfo.RETURN_DEPT_ID == "") {
                alert("请选择退库科室");
                return
            }
            if ($scope.headInfo.DEPT_ID == "") {
                alert("请选当前入库科室");
                return
            }
       
            data.ID = $scope.headInfo.ID;
            data.CODE = $scope.headInfo.CODE;
            data.RETURN_DEPT_ID = $scope.headInfo.RETURN_DEPT_ID;
            data.RETURN_USER_ID = $scope.headInfo.RETURN_USER_ID;

            data.DEPT_ID = $scope.headInfo.DEPT_ID;
            data.USER_ID = $scope.headInfo.USER_ID;

            data.STOCK_ID = $scope.headInfo.STOCK_ID;

            data.CREATE_DATE = $scope.headInfo.CREATE_DATE;
     
            data.COMMENTS = $scope.headInfo.COMMENTS;
    
            data.DELETEIDS = $scope.deleteIDs;

            for (var i = 0; i < $scope.tableRows.length; i++) {
      
                data.children.push(retModel());
                data.children[i].ID = $scope.tableRows[i].ID;
 
                data.children[i].ASSETS_ID = $scope.tableRows[i].ASSETS_ID;
                data.children[i].ASSETS_CODE = $scope.tableRows[i].ASSETS_CODE;
                data.children[i].ASSETS_NAME = $scope.tableRows[i].ASSETS_NAME;
                data.children[i].SPEC = $scope.tableRows[i].SPEC;

                data.children[i].REF_TAB_ID = $scope.tableRows[i].REF_TAB_ID;
                data.children[i].REF_TAB_NAME = $scope.tableRows[i].REF_TAB_NAME;

                data.children[i].COMMENTS = $scope.tableRows[i].COMMENTS;

                if (data.children[i].ASSETS_ID == null || data.children[i].ASSETS_ID == "") {
                    alert("请选择设备名称");
                    return
                }

                if (data.children[i].ASSETS_NAME == null || data.children[i].ASSETS_NAME == "") {
                    alert("请选择设备名称");
                    return
                }


                if (data.children[i].ASSETS_CODE == null || data.children[i].ASSETS_CODE == "") {
                    alert("请输入设备名称");
                    return
                }

            }

            $http({
                method:"POST",
                url: $rootScope.baseUrl + "service/mce/mce_outstock/Srv_MCE_MCEBackSave.ashx",
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
            window.location.replace("PageMceBackList.html")
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