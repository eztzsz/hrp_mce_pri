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
            FINANCE_CYCLE: "",
            CREATE_DATE: "",
            USER_ID: "",
            USER_ID_NAME: "",
            COMMENTS: "",
            STATE: 0,
            STATE_NAME: "",
        };
        $scope.tableRows = [];
     
        $scope.InputschangeState = InputschangeState;
        $scope.InputschangeState.states = {
            dept: false,
            stock: false,
            user: false
        };

        //计提科室
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


        //计提人
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
                url: $rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_GetMCEAssetsUserInfo.ashx?code_type=MceDepr"
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
            
                    $scope.headInfo.FINANCE_CYCLE = data.Message.sys_date.substr(0, 4) + data.Message.sys_date.substr(5, 2);
                    $scope.headInfo.CREATE_DATE = data.Message.sys_date;
                    $scope.headInfo.CODE = data.Message.code;

                    $scope.headInfo.USER_ID = data.Message.user_id;
                    $scope.headInfo.USER_ID_NAME = data.Message.user_name;
                    $scope.user.param.condition = data.Message.user_name;

                    $scope.headInfo.DEPT_ID = data.Message.dept_id;
                    $scope.headInfo.DEPT_ID_NAME = data.Message.dept_name;
                    $scope.dept.param.condition = data.Message.dept_name;

                } else {
                    alert(data.Message)
                }
            })
        };

        //获取详情
        $scope.getDetailInfo = function () {
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mce/MCE_DEPR/Srv_MCE_GetMCEDeprDetail.ashx?id=" + $scope.paramObj.id
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.tableRows = data.Message.rows;
                    for (var i = 0; i < $scope.tableRows.length; i++) {
                        $scope.tableRows[i].ASSETS_NAME = $scope.tableRows[i].ASSETS_ID_NAME;
                        $scope.tableRows[i].ASSETS_CODE = $scope.tableRows[i].ASSETS_CODE;
                        $scope.tableRows[i].TOTAL_MONEY = ($scope.tableRows[i].ORIGINAL_VALUE - $scope.tableRows[i].NEW_NET_VALUE).toFixed(2);
                        $scope.tableRows[i].checked = false
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

                    $scope.headInfo.COMMENTS = data.Message.head.COMMENTS;
                    $scope.headInfo.FINANCE_CYCLE = data.Message.head.FINANCE_CYCLE;

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



        $scope.creatModel = function () {
            return {
                ID: "",
                ASSETS_ID:"",
                ASSETS_NAME: "",
                ASSETS_CODE: "",
                ORIGINAL_VALUE: 0,
                NET_VALUE: 0,
      
                MONEY: 0,
                NEW_NET_VALUE: 0,
              
                CURRENCY_ID: "",
                CURRENCY_ID_NAME: "",
 
                checked: false,
           
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
                $http.post($rootScope.baseUrl + "service/mce/MCE_DEPR/Srv_MCE_MCEDeprOperate.ashx?oType=submit", list).success(function (data) {
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
                $http.post($rootScope.baseUrl + "service/mce/MCE_DEPR/Srv_MCE_MCEDeprOperate.ashx?oType=audit", list).success(function (data) {
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
                FINANCE_CYCLE: "",
                CREATE_DATE: "",
                DEPT_ID: "",
                USER_ID: "",
                COMMENTS: "",
                STATE: 1,
                children:[]
            };
            function  retModel() {
                return {
                    ID: "",
                    ASSETS_ID: "",
                    CURRENCY_ID: "",
                 
                    ORIGINAL_VALUE: 0,
                    NET_VALUE: 0,
                    MONEY: 0,
                    NEW_NET_VALUE: 0
                }
            }
         
            data.ID = $scope.headInfo.ID;
            data.CODE = $scope.headInfo.CODE;
            data.FINANCE_CYCLE = $scope.headInfo.FINANCE_CYCLE;
       
            data.CREATE_DATE = $scope.headInfo.CREATE_DATE;
            data.DEPT_ID = $scope.headInfo.DEPT_ID;
            data.USER_ID = $scope.headInfo.USER_ID;
            data.COMMENTS = $scope.headInfo.COMMENTS;
      
            for (var i = 0; i < $scope.tableRows.length; i++) {
      
                data.children.push(retModel());
                data.children[i].ID = $scope.tableRows[i].ID;
                data.children[i].ASSETS_ID = $scope.tableRows[i].ASSETS_ID;
                data.children[i].ASSETS_CODE = $scope.tableRows[i].ASSETS_CODE;
                data.children[i].CURRENCY_ID = $scope.tableRows[i].CURRENCY_ID;

                data.children[i].ORIGINAL_VALUE = $scope.tableRows[i].ORIGINAL_VALUE;
                data.children[i].NET_VALUE = $scope.tableRows[i].NET_VALUE;
                data.children[i].MONEY = $scope.tableRows[i].MONEY;
           
                data.children[i].NEW_NET_VALUE = $scope.tableRows[i].NEW_NET_VALUE;
            
         
                if (data.children[i].ASSETS_ID == null || data.children[i].ASSETS_ID == "") {
                    alert("设备不能为空");
                    return
                }

            }

            $http({
                method:"POST",
                url: $rootScope.baseUrl + "service/mce/MCE_DEPR/Srv_MCE_MCEDeprSave.ashx",
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


        $scope.calcDepr = function () {
           
            if ($scope.headInfo.DEPT_ID == null || $scope.headInfo.DEPT_ID == "") {
                alert("请选择计提科室");
                return false
            }

            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mce/MCE_DEPR/Srv_MCE_GetMCEDeprCalc.ashx?dept=" + $scope.headInfo.DEPT_ID
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.tableRows = data.Message;
                    for (var i = 0; i < $scope.tableRows.length; i++) {
                        $scope.tableRows[i].TOTAL_MONEY =( $scope.tableRows[i].ORIGINAL_VALUE - $scope.tableRows[i].NEW_NET_VALUE).toFixed(2);
                        $scope.tableRows[i].checked = false
                    }
                } else {
                    alert(data.Message)
                }
            })


        };

        $scope.goBack = function () {
            window.location.replace("PageMceDeprList.html")
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