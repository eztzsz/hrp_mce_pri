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

            PROVIDER_ID: "",
            PROVIDER_ID_NAME: "",

            USER_ID: "",
            USER_ID_NAME: "",

            CREATE_DATE: "",

            STOCK_ID: "",
            STOCK_ID_NAME: "",

            TOTAL_MONEY: 0,

            COMMENTS: "",

            STATE: 0,
            STATE_NAME: "",
        };
        $scope.tableRows = [];
        $scope.deleteIDs = [];

        $scope.InputschangeState = InputschangeState;
        $scope.InputschangeState.states = {
            prv: false,
            user: false,
            stock:false
        };



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
            $scope.headInfo.STOCK_ID = n.stock.trim();
            $scope.headInfo.STOCK_ID_NAME = $scope.stock.param.condition;
        }, true);


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
                url: $rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_GetMCEAssetsUserInfo.ashx?code_type=MceSalesReturn"
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
                url: $rootScope.baseUrl + "service/mce/MCE_STOCKDATA/Srv_MCE_GetMCESalesReturnDetail.ashx?id=" + $scope.paramObj.id
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.tableRows = data.Message.rows;
                    for (var i = 0; i < $scope.tableRows.length; i++) {
                        $scope.tableRows[i].checked = false
                    }
                    $scope.headInfo.ID = data.Message.head.ID;
                    $scope.headInfo.CODE = data.Message.head.CODE;

                    $scope.headInfo.PROVIDER_ID = data.Message.head.PROVIDER_ID;
                    $scope.headInfo.PROVIDER_ID_NAME = data.Message.head.PROVIDER_ID_NAME;
                    $scope.prv.param.condition = data.Message.head.PROVIDER_ID_NAME;

                    $scope.headInfo.USER_ID = data.Message.head.USER_ID;
                    $scope.headInfo.USER_ID_NAME = data.Message.head.USER_ID_NAME;
                    $scope.user.param.condition = data.Message.head.USER_ID_NAME;

                    $scope.headInfo.STOCK_ID = data.Message.head.STOCK_ID;
                    $scope.headInfo.STOCK_ID_NAME = data.Message.head.STOCK_ID_NAME;
                    $scope.stock.param.condition = data.Message.head.STOCK_ID_NAME;

                    $scope.headInfo.CREATE_DATE = data.Message.head.CREATE_DATE;
                  
                    $scope.headInfo.TOTAL_MONEY = data.Message.head.TOTAL_MONEY;
                    
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

                AMOUNT: 1,
                MONEY:0,
                PRD_DATE:"",
                PRICE:0,
                PRD_ID:"",
                PRD_ID_NAME: "",

                SPEC: "",
                COMMENTS:"",

                REF_TAB_ID: "",
                REF_TAB_NAME: "",
                checked: false,
                showMceState: false
            }
        };
     

        $scope.paramSalesReturnObj = {
            status: "3",
            prv: "",
            code: ""
        };
        $scope.modelSalesReturnList = [];
        $scope.mainSalesReturnPager = ParamService.getPager();

        //Asset列表查询
        $scope.getModelSalesReturnList = function (curIndex) {


            $scope.paramSalesReturnObj.prv = $scope.headInfo.PROVIDER_ID;

            var param = ParamService.comParam(curIndex, $scope.mainSalesReturnPager.pageSize, $scope.paramSalesReturnObj);
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mce/mce_outstock/Srv_MCE_GetMCEBackList.ashx" + param
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.modelSalesReturnList = data.Message.rows;
                    $scope.mainSalesReturnPager.setDataNum(data.Message.total);
                    $scope.mainSalesReturnPager.setCurIndex(curIndex);
                    for (var i = 0; i < $scope.modelSalesReturnList.length; i++) {
                        $scope.modelSalesReturnList[i].checked = false;

                    }
                }
            })
        };


        $scope.newState = {
            state: false
        };

        $scope.openNew = function () {
            if ($scope.prv.param.condition == null || $scope.prv.param.condition == "")
            {
                alert("请选择供应商");
                return;
            }

            $scope.paramSalesReturnObj.code = "";
            $scope.getModelSalesReturnList();
            for (var i = 0; i < $scope.modelSalesReturnList.length; i++) {
                $scope.modelSalesReturnList[i].checked = false;
            }

            $scope.newState.state = true;
        };


        $scope.checkAssetSate = {
            state: false
        };

        $scope.checkAllAssett = function () {
            $scope.checkAssetSate.state = !$scope.checkAssetSate.state
            for (var i = 0; i < $scope.modelSalesReturnList.length; i++) {
                $scope.modelSalesReturnList[i].checked = $scope.checkAssetSate.state
            }
        };

        $scope.addInfo = function () {
            var added = 0;
            var vIDs = "";
            for (var i = 0; i < $scope.modelSalesReturnList.length; i++) {
                if ($scope.modelSalesReturnList[i].checked == true) {
                    added = added + 1;
                    vIDs = vIDs + $scope.modelSalesReturnList[i].ID + ",";
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
                    url: $rootScope.baseUrl + "service/mce/MCE_STOCKDATA/Srv_MCE_GetMCEBackReturnList.ashx?ids=" + vIDs
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

                                vModal.MONEY = data.Message[i].ORIGINAL_VALUE;
                                vModal.PRD_DATE = data.Message[i].PRD_DATE;
                                vModal.PRICE = data.Message[i].PRICE;
                                vModal.PRD_ID = data.Message[i].PRD_ID;
                                vModal.PRD_ID_NAME = data.Message[i].PRD_ID_NAME;
                             

                                vModal.REF_TAB_ID = data.Message[i].BACK_D_ID;
                                vModal.REF_TAB_NAME = "MCE_B_ASSETS_BACK";
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



        //begin add asset

        $scope.paramAssetObj = {
            condition: "",
            use_state: "00540002",//闲置
            cust_condition: " and MCE_B_ASSETS.assets_state <>'00530004'",//资产状态不能是退货
            prv: "",
            needTotal: "0"
        };
        $scope.modelAssetList = [];
        $scope.mainAssetPager = ParamService.getPager();

        //Asset列表查询
        $scope.getModelAssetList = function (curIndex) {
            $scope.paramAssetObj.prv = $scope.headInfo.PROVIDER_ID;
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


        $scope.newAssetState = {
            state: false
        };

        $scope.openAssetNew = function () {
            if ($scope.prv.param.condition == null || $scope.prv.param.condition == "") {
                alert("请选择供应商");
                return;
            }

            $scope.paramAssetObj.condition = "";
            $scope.getModelAssetList();
            for (var i = 0; i < $scope.modelAssetList.length; i++) {
                $scope.modelAssetList[i].checked = false;
            }

            $scope.newAssetState.state = true;
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

        $scope.addAssetInfo = function () {
            var added = 0;
            for (var i = 0; i < $scope.modelAssetList.length; i++) {
                if ($scope.modelAssetList[i].checked == true) {
                    added = added + 1;


                    var vExist = false;
                    for (var k = 0; k< $scope.tableRows.length; k++) {
                        if ($scope.tableRows[k].ASSETS_ID == $scope.modelAssetList[i].ID)
                        {
                            var vExist = true;
                            break;
                        }
                    }

                    if (vExist == false) {
                        var vModal = $scope.creatModel();
                       
                        vModal.ASSETS_ID = $scope.modelAssetList[i].ID;
                        vModal.ASSETS_NAME = $scope.modelAssetList[i].ASSETS_NAME;
                        vModal.ASSETS_CODE = $scope.modelAssetList[i].ASSETS_CODE;
                        vModal.SPEC = $scope.modelAssetList[i].SPEC;

                        vModal.MONEY = $scope.modelAssetList[i].ORIGINAL_VALUE;
                        vModal.PRD_DATE = $scope.modelAssetList[i].PRD_DATE;
                        vModal.PRICE = $scope.modelAssetList[i].ORIGINAL_VALUE;
                        vModal.PRD_ID = $scope.modelAssetList[i].PRD_ID;
                        vModal.PRD_ID_NAME = $scope.modelAssetList[i].PRD_ID_NAME;

                        vModal.REF_TAB_ID = $scope.modelAssetList[i].ID;
                        vModal.REF_TAB_NAME = "MCE_B_ASSETS";


                        $scope.tableRows.push(vModal);
                    }
                }
            }
            if (added == 0) {
                alert("请选择");
                return false
            }
            else {
                $scope.newAssetState.state = false;
                //alert("添加成功");
            }


        }
        //end add assert



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
                $http.post($rootScope.baseUrl + "service/mce/MCE_STOCKDATA/Srv_MCE_MCESalesReturnOperate.ashx?oType=submit", list).success(function (data) {
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
                $http.post($rootScope.baseUrl + "service/mce/MCE_STOCKDATA/Srv_MCE_MCESalesReturnOperate.ashx?oType=audit", list).success(function (data) {
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
                PROVIDER_ID: "",
               
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

                    AMOUNT: 1,
                    MONEY: 0,
                    PRD_DATE: "",
                    PRICE: 0,
                    PRD_ID: "",
                 
                    COMMENTS: ""
                }
            }
            if ($scope.headInfo.PROVIDER_ID == "") {
                alert("请选择供应商");
                return
            }
            if ($scope.headInfo.USER_ID == "") {
                alert("请选退货人");
                return
            }
       
            data.ID = $scope.headInfo.ID;
            data.CODE = $scope.headInfo.CODE;
            data.PROVIDER_ID = $scope.headInfo.PROVIDER_ID;
          
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

                data.children[i].AMOUNT = $scope.tableRows[i].AMOUNT;
                data.children[i].MONEY = $scope.tableRows[i].MONEY;
                data.children[i].PRD_DATE = $scope.tableRows[i].PRD_DATE;
                data.children[i].PRICE = $scope.tableRows[i].PRICE;
                data.children[i].PRD_ID = $scope.tableRows[i].PRD_ID;
                
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
                url: $rootScope.baseUrl + "service/mce/MCE_STOCKDATA/Srv_MCE_MCESalesReturnSave.ashx",
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
            window.location.replace("PageMceSalesReturnList.html")
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