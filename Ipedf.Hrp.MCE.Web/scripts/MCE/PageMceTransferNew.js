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

            TRANSFER_DEPT_ID: "",
            TRANSFER_DEPT_ID_NAME: "",
            TRANSFER_USER_ID: "",
            TRANSFER_USER_ID_NAME: "",

            DEPT_ID: "",
            DEPT_ID_NAME: "",
            USER_ID: "",
            USER_ID_NAME: "",

            CREATE_DATE: "",

            COMMENTS: "",

            STATE: 0,
            STATE_NAME: "",
        };
        $scope.tableRows = [];
        $scope.deleteIDs = [];

        $scope.InputschangeState = InputschangeState;
        $scope.InputschangeState.states = {
            outdept: false,
            outuser: false,
            dept: false,
            user: false
        };


        //转移科室
        $scope.outdept = ParamS($rootScope.baseUrl + "service/mtr/Srv_MTR_DeptList.ashx");
        $scope.outdept.showTabTh = ['编号', '名称', "院区"];
        $scope.outdept.showTabTb = ['code', 'name', "areaName"];
        $scope.outdept.param = {
            is_area: "0",
            condition: ""
        };
        $scope.paramOutDept = {
            outdept: ""
        };

        $scope.$watch("paramOutDept", function (n, o) {
            $scope.headInfo.TRANSFER_DEPT_ID = n.outdept.trim();
            $scope.headInfo.TRANSFER_DEPT_ID_NAME = $scope.outdept.param.condition;
        }, true);


        //转移人
        $scope.outuser = ParamS($rootScope.baseUrl + "service/mtr/mtr_high_basic/Srv_MTR_High_GetUserList.ashx");
        $scope.outuser.showTabTh = ['用户名', '姓名'];
        $scope.outuser.showTabTb = ['ACCOUNT', 'NAME'];
        $scope.outuser.param = {
            name: "",
            condition: ""
        };
        $scope.paramOutUser = {
            outuser: ""
        };

        $scope.$watch("paramOutUser", function (n, o) {
            $scope.headInfo.TRANSFER_USER_ID = n.outuser.trim();
            $scope.headInfo.TRANSFER_USER_ID_NAME = $scope.outuser.param.condition;
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
                url: $rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_GetMCEAssetsUserInfo.ashx?code_type=MceTransfer"
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
                url: $rootScope.baseUrl + "service/mce/mce_outstock/Srv_MCE_GetMCETransferDetail.ashx?id=" + $scope.paramObj.id
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.tableRows = data.Message.rows;
                    for (var i = 0; i < $scope.tableRows.length; i++) {
                        $scope.tableRows[i].checked = false
                    }
                    $scope.headInfo.ID = data.Message.head.ID;
                    $scope.headInfo.CODE = data.Message.head.CODE;

                    $scope.headInfo.TRANSFER_DEPT_ID = data.Message.head.TRANSFER_DEPT_ID;
                    $scope.headInfo.TRANSFER_DEPT_ID_NAME = data.Message.head.TRANSFER_DEPT_ID_NAME;
                    $scope.outdept.param.condition = data.Message.head.TRANSFER_DEPT_ID_NAME;

                    $scope.headInfo.TRANSFER_USER_ID = data.Message.head.TRANSFER_USER_ID;
                    $scope.headInfo.TRANSFER_USER_ID_NAME = data.Message.head.TRANSFER_USER_ID_NAME;
                    $scope.outuser.param.condition = data.Message.head.TRANSFER_USER_ID_NAME;


                    $scope.headInfo.DEPT_ID = data.Message.head.DEPT_ID;
                    $scope.headInfo.DEPT_ID_NAME = data.Message.head.DEPT_ID_NAME;
                    $scope.dept.param.condition = data.Message.head.DEPT_ID_NAME;

                    $scope.headInfo.USER_ID = data.Message.head.USER_ID;
                    $scope.headInfo.USER_ID_NAME = data.Message.head.USER_ID_NAME;
                    $scope.user.param.condition = data.Message.head.USER_ID_NAME;

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

        //设备
        $scope.conditionMceForAdd = {
            condition: "",
            needTotal: "0"
        };
        $scope.mceList = [];
        $scope.fkMcePager = ParamService.getPager();
        $scope.searcFkMceListForAdd = function (curIndex, v) {
            $scope.conditionMceForAdd.condition = v.ASSETS_NAME;
            v.showMceState = true;
            var param = ParamService.comParam(curIndex, $scope.fkMcePager.pageSize, $scope.conditionMceForAdd);
            $http.get($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCEAssetsList.ashx" + param).success(function (data) {
                if (data.Succeed == 1) {
                    v.showMceState = true;
                    $scope.mceList = data.Message.rows;
                    $scope.fkMcePager.setDataNum(data.Message.total);
                    $scope.fkMcePager.setCurIndex(curIndex);
                }
            })
        };
        $scope.changeFkMceState = function (index) {
            angular.forEach($scope.tableRows, function (v, k) {
                $scope.clearFkDetailState();
                if (index == k) {
                    $scope.tableRows[k].showMceState = true;
                }
            })
        };
        $scope.selectFkMceForAdd = function (v, a) {
            v.showMceState = false;
            v.ASSETS_ID = a.ID;
            v.ASSETS_CODE = a.ASSETS_CODE;
            v.ASSETS_NAME = a.ASSETS_NAME;
            v.SPEC = a.SPEC;
        };
        $scope.clearFkMceForAdd = function (v) {
            v.ASSETS_ID = "";
            v.ASSETS_CODE = "";
            v.ASSETS_NAME = "";
            v.SPEC = "";
        };

        $scope.creatModel = function () {
            return {
                ID: "",
                ASSETS_ID: "",
                ASSETS_CODE: "",
                ASSETS_NAME: "",
                SPEC: "",
                COMMENTS:"",

                checked: false,
                showMceState: false
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
                $http.post($rootScope.baseUrl + "service/mce/mce_outstock/Srv_MCE_MCETransferOperate.ashx?oType=submit", list).success(function (data) {
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
                $http.post($rootScope.baseUrl + "service/mce/mce_outstock/Srv_MCE_MCETransferOperate.ashx?oType=audit", list).success(function (data) {
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
            if ($scope.headInfo.TRANSFER_DEPT_ID == "") {
                alert("请选择转移科室");
                return
            }
            if ($scope.headInfo.DEPT_ID == "") {
                alert("请选当前使用科室");
                return
            }
       
            data.ID = $scope.headInfo.ID;
            data.CODE = $scope.headInfo.CODE;
            data.TRANSFER_DEPT_ID = $scope.headInfo.TRANSFER_DEPT_ID;
            data.TRANSFER_USER_ID = $scope.headInfo.TRANSFER_USER_ID;

            data.DEPT_ID = $scope.headInfo.DEPT_ID;
            data.USER_ID = $scope.headInfo.USER_ID;

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
                url: $rootScope.baseUrl + "service/mce/mce_outstock/Srv_MCE_MCETransferSave.ashx",
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
            window.location.replace("PageMceTransferList.html")
        };

        $scope.default = function () {
            $scope.getDetailId();
          
            if ($scope.paramObj.id != "") {
        
                $scope.getDetailInfo();

            } else {
                $scope.getUserInfo();
                $scope.addModel();
            }


        };
        $scope.default();


    }])