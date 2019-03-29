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
            FINANCE_CYCLE: "",

            WRITE_OFF_TYPE_ID: "",
            WRITE_OFF_TYPE_ID_NAME: "",
            WRITE_OFF_CAUSE_ID: "",
            WRITE_OFF_CAUSE_ID_NAME: "",

            INCOME: "",
            USAGE: "",
            COMMENTS: "",

            IDENTITY_USER_ID: "",
            IDENTITY_USER_ID_NAME:"",
            IDENTITY_TIME: "",
            IDENTITY_STATE: "",

            STATE: 0,
            STATE_NAME: "",
        };


        $scope.identityInfo = {
            I01: false,
            I02: false,
            I03: false,
            I04: false,
            I05: false,
            I06: false

        };

        $scope.tableRows = [];
        $scope.attachRows = [];

        $scope.InputschangeState = InputschangeState;
        $scope.InputschangeState.states = {
            user: false
        };


        //申请人
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
            $scope.headInfo.IDENTITY_USER_ID = n.user.trim();
            $scope.headInfo.IDENTITY_USER_ID_NAME = $scope.user.param.condition;
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



        //获取详情
        $scope.getDetailInfo = function () {
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mce/mce_writeoff/Srv_MCE_GetWriteOffDetail.ashx?id=" + $scope.paramObj.id
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.tableRows = data.Message.rows;
                    for (var i = 0; i < $scope.tableRows.length; i++) {
                        $scope.tableRows[i].checked = false;
                        $scope.tableRows[i].ASSET_ID = $scope.tableRows[i].ID;
                    }

                    $scope.attachRows = data.Message.attach;

                    $scope.headInfo.ID = data.Message.head.ID;
                    $scope.headInfo.CODE = data.Message.head.CODE;
                 
                    $scope.headInfo.CREATE_DATE = data.Message.head.CREATE_DATE;

                    $scope.headInfo.DEPT_ID = data.Message.head.DEPT_ID;
                    $scope.headInfo.DEPT_ID_NAME = data.Message.head.DEPT_ID_NAME;
               
                    $scope.headInfo.USER_ID = data.Message.head.USER_ID;
                    $scope.headInfo.USER_ID_NAME = data.Message.head.USER_ID_NAME;
              
                    $scope.headInfo.FINANCE_CYCLE = data.Message.head.FINANCE_CYCLE;

                    if (data.Message.head.WRITE_OFF_TYPE_ID != null) {
                        $scope.headInfo.WRITE_OFF_TYPE_ID = data.Message.head.WRITE_OFF_TYPE_ID.trim();
                        $scope.headInfo.WRITE_OFF_TYPE_ID_NAME = data.Message.head.WRITE_OFF_TYPE_ID_NAME.trim();
                    }

                    if (data.Message.head.WRITE_OFF_CAUSE_ID != null) {
                        $scope.headInfo.WRITE_OFF_CAUSE_ID = data.Message.head.WRITE_OFF_CAUSE_ID.trim();
                        $scope.headInfo.WRITE_OFF_CAUSE_ID_NAME = data.Message.head.WRITE_OFF_CAUSE_ID_NAME.trim();
                    }

                    $scope.headInfo.INCOME = data.Message.head.INCOME;
                    $scope.headInfo.USAGE = data.Message.head.USAGE;


                    $scope.headInfo.COMMENTS = data.Message.head.COMMENTS;
              
                    $scope.headInfo.STATE = data.Message.head.STATE;
                    $scope.headInfo.STATE_NAME = data.Message.head.STATE_NAME;

                    if (data.Message.head.IDENTITY_PARAM!=null)
                    {
                        var vParam = data.Message.head.IDENTITY_PARAM.trim();
                        if(vParam.length==6)
                        {
                            $scope.identityInfo.I01 = vParam.substr(0, 1) == '1' ? true : false;
                            $scope.identityInfo.I02 = vParam.substr(1, 1) == '1' ? true : false;
                            $scope.identityInfo.I03 = vParam.substr(2, 1) == '1' ? true : false;
                            $scope.identityInfo.I04 = vParam.substr(3, 1) == '1' ? true : false;
                            $scope.identityInfo.I05 = vParam.substr(4, 1) == '1' ? true : false;
                            $scope.identityInfo.I06 = vParam.substr(5, 1) == '1' ? true : false;
                        }
                    }

                    if (data.Message.head.STATE == 2) {
                        $http({
                            method: "GET",
                            url: $rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_GetMCEAssetsUserInfo.ashx"
                        }).then(function (data) {
                            var data = data.data;
                            if (data.Succeed == 1) {
                                $scope.headInfo.IDENTITY_USER_ID = data.Message.user_id;
                                $scope.headInfo.IDENTITY_USER_ID_NAME = data.Message.user_name;
                                $scope.user.param.condition = data.Message.user_name;

                                $scope.headInfo.IDENTITY_TIME = data.Message.sys_date;

                            } else {
                                alert(data.Message)
                            }
                        })
                    }
                    else
                    {
                        $scope.headInfo.IDENTITY_USER_ID = data.Message.head.IDENTITY_USER_ID;
                        $scope.headInfo.IDENTITY_USER_ID_NAME = data.Message.head.IDENTITY_USER_ID_NAME;
                        $scope.user.param.condition = data.Message.head.IDENTITY_USER_ID_NAME;

                        $scope.headInfo.IDENTITY_TIME = data.Message.head.IDENTITY_TIME;
                        $scope.headInfo.IDENTITY_STATE = data.Message.head.IDENTITY_STATE;
                    }


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
                ASSET_ID: "",
                MACHINE_TYPE_ID_NAME:"",

                ASSETS_NAME: "",
                ASSETS_CODE: "",
                SPEC: "",
                PRD_ID: "",
                PRD_ID_NAME: "",
                STORE_ADDRESS: "",
                ORIGINAL_VALUE: "",
                NET_VALUE: "",
                RUDIMENTAL_VALUE: "",
                ENABLE_DATE: "",
              
                checked: false
            
            }
        };



        $scope.saveModel=function (vType) {
            var data={
                IDENTITY_USER_ID: "",
                IDENTITY_TIME: "",
                IDENTITY_STATE: "",
                IDENTITY_PARAM:""
            };

         

            if ($scope.headInfo.IDENTITY_TIME == null || $scope.headInfo.IDENTITY_TIME == "") {
                alert("鉴定日期不能为空");
                return
            }

            if ($scope.headInfo.IDENTITY_STATE == null || $scope.headInfo.IDENTITY_STATE == "") {
                alert("鉴定意见不能为空");
                return
            }

            if ($scope.headInfo.IDENTITY_USER_ID == null || $scope.headInfo.IDENTITY_USER_ID == "") {
                alert("鉴定人不能为空");
                return
            }

            if ($scope.identityInfo.I01 == false && $scope.identityInfo.I02 == false && $scope.identityInfo.I03 == false && $scope.identityInfo.I04 == false && $scope.identityInfo.I05 == false && $scope.identityInfo.I06 == false)
            {
                alert("请选择鉴定参数");
                return
            }

            data.ID = $scope.headInfo.ID;
            data.IDENTITY_USER_ID = $scope.headInfo.IDENTITY_USER_ID;
            data.IDENTITY_TIME = $scope.headInfo.IDENTITY_TIME;
            data.IDENTITY_STATE = $scope.headInfo.IDENTITY_STATE;
          

            data.IDENTITY_PARAM = $scope.identityInfo.I01 == true ? "1" : "0";
            data.IDENTITY_PARAM = data.IDENTITY_PARAM + "" + ($scope.identityInfo.I02 == true ? "1" : "0");
            data.IDENTITY_PARAM = data.IDENTITY_PARAM + "" + ($scope.identityInfo.I03 == true ? "1" : "0");
            data.IDENTITY_PARAM = data.IDENTITY_PARAM + "" + ($scope.identityInfo.I04 == true ? "1" : "0");
            data.IDENTITY_PARAM = data.IDENTITY_PARAM + "" + ($scope.identityInfo.I05 == true ? "1" : "0");
            data.IDENTITY_PARAM = data.IDENTITY_PARAM + "" + ($scope.identityInfo.I06 == true ? "1" : "0");
            


            $http({
                method:"POST",
                url: $rootScope.baseUrl + "service/mce/mce_writeoff/Srv_MCE_MCEWriteOffIdentity.ashx",
                data:data
            }).then(function (data) {
                var data = data.data;
                if(data.Succeed == 1){
                    alert("保存成功");

                    $scope.getDetailInfo();
            
                }else{
                    alert(data.Message)
                }
            })


        };


        $scope.FileDown = function (value) {
            window.open("../../upload/mce/" + value.SAVENAME)
        };

        $scope.goBack = function () {
            window.location.replace("PageMceWriteOffIdentitylist.html")
        };



        $scope.default = function () {
            $scope.getDetailId();
          
            if ($scope.paramObj.id != "") {
        
                $scope.getDetailInfo();

            }
         

        };
        $scope.default();


    }])