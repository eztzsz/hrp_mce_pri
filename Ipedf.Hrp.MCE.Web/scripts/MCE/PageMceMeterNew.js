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



        $scope.InputschangeState = InputschangeState;
        $scope.InputschangeState.states = {
            user: false,
            asset: false
        };

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
            $scope.headInfo.HEAD_USER_ID = n.user.trim();
            $scope.headInfo.HEAD_USER_ID_NAME = $scope.user.param.condition;
        }, true);



        //设备
        $scope.asset = ParamS($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCEAssetsList.ashx");
        $scope.asset.showTabTh = ['设备编号', '设备名称', '规格'];
        $scope.asset.showTabTb = ['ASSETS_CODE', 'NAME', 'SPEC'];
        $scope.asset.param = {
            assets_state: "00530002",
         //   use_state: "00540002",
            condition: "",
            needTotal: "0",
            dropdown: "1"
        };
        $scope.paramAsset = {
            asset: ""
        };
        
     
        $scope.asset.select = function (v, paramObj, str) {

            paramObj[str] = v.ID;
            
            this.param.condition = v.ASSETS_NAME;
            this.param.code =  v.ASSETS_CODE;
            this.param.name = v.name || v.ASSETS_NAME;

            $scope.headInfo.ASSETS_CODE = v.ASSETS_CODE;
            $scope.headInfo.SPEC = v.SPEC;

            $scope.headInfo.PRD_ID = v.PRD_ID;
            $scope.headInfo.PRD_ID_NAME = v.PRD_ID_NAME;

            $scope.headInfo.UNIT_ID = v.UNIT_ID;
            $scope.headInfo.UNIT_ID_NAME = v.UNIT_ID_NAME;

            $scope.headInfo.USING_DEPT_ID = v.USING_DEPT_ID;
            $scope.headInfo.USING_DEPT_ID_NAME = v.USING_DEPT_ID_NAME;

            $scope.headInfo.PRD_CODE = v.PRD_CODE;
   
        };
        
        $scope.$watch("paramAsset", function (n, o) {
            if (n != undefined) {

                $scope.headInfo.ASSETS_ID = n.asset.trim();
                $scope.headInfo.ASSETS_ID_NAME = $scope.asset.param.condition;

                if ($scope.headInfo.ASSETS_ID == "" || $scope.headInfo.ASSETS_ID == null) {
                    $scope.headInfo.ASSETS_CODE = "";
                    $scope.headInfo.SPEC = "";

                    $scope.headInfo.PRD_ID = "";
                    $scope.headInfo.PRD_ID_NAME = "";

                    $scope.headInfo.UNIT_ID = "";
                    $scope.headInfo.UNIT_ID_NAME = "";

                    $scope.headInfo.USING_DEPT_ID = "";
                    $scope.headInfo.USING_DEPT_ID_NAME = "";

                    $scope.headInfo.PRD_CODE = "";
                }
          
            }

        }, true);


        $scope.headInfo = {
            ID: "",
            CODE: "",

            ASSETS_ID: "",
            ASSETS_ID_NAME: "",
            ASSETS_CODE:"",
            SPEC: "",

            PRD_ID: "",
            PRD_ID_NAME: "",

            UNIT_ID: "",
            UNIT_ID_NAME: "",

            USING_DEPT_ID: "",
            USING_DEPT_ID_NAME: "",

            PRD_CODE: "",

            IDENTIFICATION_CYCLE:"",

            METER_TYPE: "",

            HEAD_USER_ID: "",
            HEAD_USER_ID_NAME:"",

            IDENTIFICATION_TYPE:"",
            IS_FORCE_SENSE: "",
            NEXT_IDENTIFICATION: "",
            EARLY_WARNING_DAYS:"",

            COMMENTS: "",

            STATE: 0,
            STATE_NAME: ""
        };
    


        //获取当前用户信息
        $scope.getUserInfo = function () {
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_GetMCEAssetsUserInfo.ashx?code_type=MceMeter"
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {

                    $scope.headInfo.NEXT_IDENTIFICATION = data.Message.sys_date;
                    $scope.headInfo.CODE = data.Message.code;

                    $scope.headInfo.HEAD_USER_ID = data.Message.user_id;
                    $scope.headInfo.HEAD_USER_ID_NAME = data.Message.user_name;
                    $scope.user.param.condition = data.Message.user_name;


                } else {
                    alert(data.Message)
                }
            })
        };

        //获取详情
        $scope.getDetailInfo = function () {
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mce/mce_meter/Srv_MCE_GetMCEMeterDetail.ashx?id=" + $scope.paramObj.id
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                 
                    $scope.headInfo.ID = data.Message.head.ID;
                    $scope.headInfo.CODE = data.Message.head.CODE;

                    $scope.headInfo.ASSETS_ID = data.Message.head.ASSETS_ID;
                    $scope.headInfo.ASSETS_ID_NAME = data.Message.head.ASSETS_ID_NAME;
                    $scope.asset.param.name = $scope.asset.param.condition = data.Message.head.ASSETS_ID_NAME;
                    $scope.paramAsset.asset = data.Message.head.ASSETS_ID;

                    $scope.headInfo.ASSETS_CODE = data.Message.head.ASSETS_CODE;
                    $scope.headInfo.SPEC = data.Message.head.SPEC;

                    $scope.headInfo.PRD_ID = data.Message.head.PRD_ID;
                    $scope.headInfo.PRD_ID_NAME = data.Message.head.PRD_ID_NAME;

                    $scope.headInfo.UNIT_ID = data.Message.head.UNIT_ID;
                    $scope.headInfo.UNIT_ID_NAME = data.Message.head.UNIT_ID_NAME;


                    $scope.headInfo.USING_DEPT_ID = data.Message.head.USING_DEPT_ID;
                    $scope.headInfo.USING_DEPT_ID_NAME = data.Message.head.USING_DEPT_ID_NAME;
                  
                    $scope.headInfo.PRD_CODE = data.Message.head.PRD_CODE;

                    $scope.headInfo.IDENTIFICATION_CYCLE = data.Message.head.IDENTIFICATION_CYCLE;
                    $scope.headInfo.METER_TYPE = data.Message.head.METER_TYPE;
                 
                    $scope.headInfo.HEAD_USER_ID = data.Message.head.HEAD_USER_ID;
                    $scope.headInfo.HEAD_USER_ID_NAME = data.Message.head.HEAD_USER_ID_NAME;
                    $scope.user.param.condition = data.Message.head.HEAD_USER_ID_NAME;

                    $scope.headInfo.IDENTIFICATION_TYPE = data.Message.head.IDENTIFICATION_TYPE;
                    $scope.headInfo.IS_FORCE_SENSE = data.Message.head.IS_FORCE_SENSE;
                    $scope.headInfo.NEXT_IDENTIFICATION = data.Message.head.NEXT_IDENTIFICATION;
                    $scope.headInfo.EARLY_WARNING_DAYS = data.Message.head.EARLY_WARNING_DAYS;



                    $scope.headInfo.COMMENTS = data.Message.head.COMMENTS;

                    $scope.headInfo.STATE = data.Message.head.STATE;
                    $scope.headInfo.STATE_NAME = data.Message.head.STATE_NAME;




                } else {
                    alert(data.Message)
                }
            })
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
                $http.post($rootScope.baseUrl + "service/mce/mce_meter/Srv_MCE_MCEMeterOperate.ashx?oType=submit", list).success(function (data) {
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
                $http.post($rootScope.baseUrl + "service/mce/mce_meter/Srv_MCE_MCEMeterOperate.ashx?oType=audit", list).success(function (data) {
                    if (data.Succeed == 1) {
                        alert("审核成功！");
                        $scope.getDetailInfo();
                    } else {
                        alert(data.Message + "审核失败！");
                    }
                })
            }
        };



        $scope.saveModel = function (vType) {
            
            $scope.headInfo.listAttach = $scope.attachRows;

            $http({
                method: "POST",
                url: $rootScope.baseUrl + "service/mce/mce_meter/Srv_MCE_MCEMeterSave.ashx",
                data: $scope.headInfo
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    alert("保存成功");

                    if (vType == '1') {
                        $scope.paramObj.id = data.Message;
                        $scope.getDetailInfo();
                    }
                    else {
                        $scope.goBack();
                    }
                } else {
                    alert(data.Message)
                }
            })
        };




        $scope.goBack = function () {
            window.location.replace("PageMceMeterList.html")
        };

        $scope.meterTypeList = [];
        $scope.getMeterTypeList = function () {
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mce/mce_meter/Srv_MCE_GetMCEMeterTypeList.ashx?status=1&limit=10000"
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.meterTypeList = data.Message.rows
                } else {
                    alert(data.Message)
                }
            })
        };

       

        $scope.default = function () {
            $scope.getDetailId();
            $scope.getMeterTypeList();
       
            if ($scope.paramObj.id != "") {

                $scope.getDetailInfo();

            } else {
                $scope.getUserInfo();
              
            }


        };
        $scope.default();


    }])