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

            dept: false,
            user: false,
            asset: false
        };

        //报修科室
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


        //报修人
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

            $scope.headInfo.ASSETS_TYPE_ID = v.MACHINE_TYPE_ID;
            $scope.headInfo.ASSETS_TYPE_ID_NAME = v.MACHINE_TYPE_ID_NAME;

            $scope.headInfo.PRD_ID = v.PRD_ID;
            $scope.headInfo.PRD_ID_NAME = v.PRD_ID_NAME;

            $scope.headInfo.MAINTENANCE_PERIOD_DATE = v.MAINTENANCE_PERIOD_DATE;
   
        };
        
        $scope.$watch("paramAsset", function (n, o) {
            if (n != undefined) {
              

                $scope.headInfo.ASSETS_ID = n.asset.trim();
                $scope.headInfo.ASSETS_ID_NAME = $scope.asset.param.condition;

                if ($scope.headInfo.ASSETS_ID == "" || $scope.headInfo.ASSETS_ID == null) {
                    $scope.headInfo.ASSETS_CODE = "";
                    $scope.headInfo.SPEC = "";
                    $scope.headInfo.ASSETS_TYPE_ID = "";
                    $scope.headInfo.ASSETS_TYPE_ID_NAME = "";
                    $scope.headInfo.PRD_ID = "";
                    $scope.headInfo.PRD_ID_NAME = "";
                    $scope.headInfo.MAINTENANCE_PERIOD_DATE = "";
                }
          
            }

        }, true);


        $scope.headInfo = {
            ID: "",
            CODE: "",

            APPLY_DEPT_ID: "",
            APPLY_DEPT_ID_NAME: "",
            APPLY_USER_ID: "",
            APPLY_USER_ID_NAME: "",

            ASSETS_ID: "",
            ASSETS_ID_NAME: "",
            ASSETS_CODE:"",
            SPEC: "",

            ASSETS_TYPE_ID: "",
            ASSETS_TYPE_ID_NAME: "",

            PRD_ID: "",
            PRD_ID_NAME: "",

            MTN_TYPE_ID:"",
            FAULT_TYPE: "",
            EMERGENCY_DEGREE: "",
            REPAIR_RESULT: "",

            CREATE_DATE: "",

            APPLY_USER_PHONE:"",
            COMPLETE_TIME:"",
            MTN_ENGINEER: "",
            MTN_TOTAL_HOURS: "",
            MAINTAIN_MONEY: "",
            INVOICE_CODE: "",
            FAULT_DESC:"",
            FAULT_ANALYSIS: "",
            FAULT_SOLUTION: "",

            COMMENTS: "",

            STATE: 0,
            STATE_NAME: "",
            listAttach: []
        };
        $scope.tableRows = [];
        $scope.deleteIDs = [];





        //获取当前用户信息
        $scope.getUserInfo = function () {
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_GetMCEAssetsUserInfo.ashx?code_type=MceMtn"
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {

                    $scope.headInfo.CREATE_DATE = data.Message.sys_date;
                    $scope.headInfo.CODE = data.Message.code;

                    $scope.headInfo.APPLY_USER_ID = data.Message.user_id;
                    $scope.headInfo.APPLY_USER_ID_NAME = data.Message.user_name;
                    $scope.user.param.condition = data.Message.user_name;

                    $scope.headInfo.APPLY_DEPT_ID = data.Message.dept_id;
                    $scope.headInfo.APPLY_DEPT_ID_NAME = data.Message.dept_name;
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
                url: $rootScope.baseUrl + "service/mce/mce_mt/Srv_MCE_GetMCEMaintainDetail.ashx?id=" + $scope.paramObj.id
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.attachRows = data.Message.attach;

                    $scope.headInfo.ID = data.Message.head.ID;
                    $scope.headInfo.CODE = data.Message.head.CODE;

                    $scope.headInfo.APPLY_DEPT_ID = data.Message.head.APPLY_DEPT_ID;
                    $scope.headInfo.APPLY_DEPT_ID_NAME = data.Message.head.APPLY_DEPT_ID_NAME;
                    $scope.dept.param.condition = data.Message.head.APPLY_DEPT_ID_NAME;

                    $scope.headInfo.APPLY_USER_ID = data.Message.head.APPLY_USER_ID;
                    $scope.headInfo.APPLY_USER_ID_NAME = data.Message.head.APPLY_USER_ID_NAME;
                    $scope.user.param.condition = data.Message.head.APPLY_USER_ID_NAME;


                    $scope.headInfo.ASSETS_ID = data.Message.head.ASSETS_ID;
                    $scope.headInfo.ASSETS_ID_NAME = data.Message.head.ASSETS_ID_NAME;
                    $scope.asset.param.name = $scope.asset.param.condition = data.Message.head.ASSETS_ID_NAME;
                    $scope.paramAsset.asset = data.Message.head.ASSETS_ID;

                    $scope.headInfo.ASSETS_CODE = data.Message.head.ASSETS_CODE;
                    $scope.headInfo.SPEC = data.Message.head.SPEC;

                    $scope.headInfo.ASSETS_TYPE_ID = data.Message.head.ASSETS_TYPE_ID;
                    $scope.headInfo.ASSETS_TYPE_ID_NAME = data.Message.head.ASSETS_TYPE_ID_NAME;
                    $scope.headInfo.PRD_ID = data.Message.head.PRD_ID;
                    $scope.headInfo.PRD_ID_NAME = data.Message.head.PRD_ID_NAME;
                    $scope.headInfo.MTN_TYPE_ID = data.Message.head.MTN_TYPE_ID;
                    $scope.headInfo.FAULT_TYPE = data.Message.head.FAULT_TYPE;
                    $scope.headInfo.EMERGENCY_DEGREE = data.Message.head.EMERGENCY_DEGREE;
                    $scope.headInfo.REPAIR_RESULT = data.Message.head.REPAIR_RESULT;
                    $scope.headInfo.APPLY_USER_PHONE = data.Message.head.APPLY_USER_PHONE;
                    $scope.headInfo.COMPLETE_TIME = data.Message.head.COMPLETE_TIME;
                    $scope.headInfo.MTN_ENGINEER = data.Message.head.MTN_ENGINEER;
                    $scope.headInfo.MTN_TOTAL_HOURS = data.Message.head.MTN_TOTAL_HOURS;
                    $scope.headInfo.MAINTAIN_MONEY = data.Message.head.MAINTAIN_MONEY;
                    $scope.headInfo.INVOICE_CODE = data.Message.head.INVOICE_CODE;
                    $scope.headInfo.FAULT_DESC = data.Message.head.FAULT_DESC;
                    $scope.headInfo.FAULT_ANALYSIS = data.Message.head.FAULT_ANALYSIS;
                    $scope.headInfo.FAULT_SOLUTION = data.Message.head.FAULT_SOLUTION;

                    
                    $scope.headInfo.CREATE_DATE = data.Message.head.CREATE_DATE;

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
                $http.post($rootScope.baseUrl + "service/mce/mce_mt/Srv_MCE_MCEMaintainOperate.ashx?oType=submit", list).success(function (data) {
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
                $http.post($rootScope.baseUrl + "service/mce/mce_mt/Srv_MCE_MCEMaintainOperate.ashx?oType=audit", list).success(function (data) {
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
                url: $rootScope.baseUrl + "service/mce/mce_mt/Srv_MCE_MCEMaintainSave.ashx",
                data: $scope.headInfo
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    alert("保存成功");

                    if (vType == '1') {
                        $scope.paramObj.id = data.Message;
                        $scope.getDetailInfo();
                        $scope.deleteIDs = [];
                    }
                    else {
                        $scope.goBack();
                    }
                } else {
                    alert(data.Message)
                }
            })
        };

        $scope.attachRows = [];


        //文件上传
        $rootScope.getFile = function (size, type1, type2) {

            $("body").off();
            $("#uploadFile").remove();
            $("body").append('<input type="file" id="uploadFile" style="position:absolute;top:-10000px">');
            $("#uploadFile").trigger("click");
            $("body").on("change", "#uploadFile", function (event) {
                var uploadFile = $("#uploadFile")[0].files[0];
                var vTarget = event.target || event.srcElement;
                var files = vTarget.files;
                var fileType = files[0].name.split(".")[files[0].name.split(".").length - 1];
                if (size && files[0].size > size * 1024) {
                    alert("文件大小超出限制");
                    $rootScope.fileData = "";
                    return false;
                }
                if (type1 || type2) {
                    if (fileType == type1 || fileType == type2) {

                    } else {
                        alert("文件格式错误");
                        $rootScope.fileData = "";
                        return false;
                    }
                }
                //jquery获取$("#uploadFile").prop("files")[0];
                var formData = new FormData();
                // formData.append('fileTypeId', fileType);//其他需要上传的字段
                // formData.append('file', files);//文件
                var len = files.length;
                var i = 0;
                while (i < len) {
                    formData.append("Filedata", files[i]);
                    i++;
                }
                $rootScope.fileData = formData;

                $http({
                    url: $rootScope.baseUrl + "service/mce/mce_writeoff/Srv_MCE_WriteOffFileUpload.ashx",
                    method: "POST",
                    headers: { 'Content-Type': undefined },//使用angular上传一定要加上这一句，不然传给后台的是空的。
                    data: formData,
                    transformRequest: angular.identity
                }).then(function (result) {
                    var res = result.data;
                    if (res.Succeed == 1) {
                        if (res.Message.saveName) {
                            var objFile = new Object();
                            objFile.ID = "";
                            objFile.SERVER_NAME = res.Message.saveName;
                            objFile.CLIENT_NAME = res.Message.fileName;
                            objFile.CREATE_USER_ID = res.Message.userid;
                            objFile.CREATE_USER_ID_NAME = res.Message.username;
                            objFile.CREATE_TIME = res.Message.createdate;

                            $scope.attachRows.push(objFile);



                        } else {
                            alert(res.Message)
                        }
                    } else {
                        alert(res.Message)
                    }
                })

            })
        };


        $scope.FileDown = function (value) {
            window.open("../../upload/mce/" + value.SERVER_NAME)
        };

        $scope.delAttachModel = function (k) {
            var flag = confirm("是否确认删除？");
            if (!flag) {
                return false
            }

            $scope.attachRows.splice(k, 1);

        };



        $scope.goBack = function () {
            window.location.replace("PageMceMaintainList.html")
        };

        $scope.mtnTypeList = [];
        $scope.getMtnTypeList = function () {
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=MTN_1003&limit=10000"
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.mtnTypeList = data.Message.rows
                } else {
                    alert(data.Message)
                }
            })
        };


        $scope.faultTypeList = [];
        $scope.getfaultTypeList = function () {
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=MCE_0005&limit=10000"
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.faultTypeList = data.Message.rows
                } else {
                    alert(data.Message)
                }
            })
        };


        $scope.emergencyDegreeList = [];
        $scope.getEmergencyDegreeList = function () {
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=MCE_0006&limit=10000"
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.emergencyDegreeList = data.Message.rows
                } else {
                    alert(data.Message)
                }
            })
        };


        $scope.repairResultList = [];
        $scope.getRepairResultList = function () {
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=MCE_0007&limit=10000"
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.repairResultList = data.Message.rows
                } else {
                    alert(data.Message)
                }
            })
        };

       

        $scope.default = function () {
            $scope.getDetailId();
            $scope.getMtnTypeList();
            $scope.getfaultTypeList();
            $scope.getEmergencyDegreeList();
            $scope.getRepairResultList();

            if ($scope.paramObj.id != "") {

                $scope.getDetailInfo();

            } else {
                $scope.getUserInfo();
                //  $scope.addModel();
            }


        };
        $scope.default();


    }])