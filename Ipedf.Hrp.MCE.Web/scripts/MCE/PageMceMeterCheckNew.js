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
        };


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
            METER_TYPE_NAME: "",

            HEAD_USER_ID: "",
            HEAD_USER_ID_NAME:"",

            IDENTIFICATION_TYPE: "",
            IDENTIFICATION_TYPE_NAME: "",

            IS_FORCE_SENSE: "",

            PLAN_IDENTIFICATION: "",
            ACTUAL_IDENTIFICATION: "",
            NEXT_IDENTIFICATION: "",

            RESULT_ID: "",
            CERTIFICATE_CODE: "",
            MONEY: "",
            CHECK_PERSON: "",

            EARLY_WARNING_DAYS:"",

            COMMENTS: "",

            STATE: 0,
            STATE_NAME: "",

            listAttach: []
        };
    

        //获取详情
        $scope.getDetailInfo = function () {
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mce/mce_meter/Srv_MCE_GetMCEMeterCheckDetail.ashx?id=" + $scope.paramObj.id
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                 
                    $scope.attachRows = data.Message.attach;

                    $scope.headInfo.ID = data.Message.head.ID;
                    $scope.headInfo.CODE = data.Message.head.CODE;

                    $scope.headInfo.ASSETS_ID = data.Message.head.ASSETS_ID;
                    $scope.headInfo.ASSETS_ID_NAME = data.Message.head.ASSETS_ID_NAME;
                 
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
                    $scope.headInfo.METER_TYPE_NAME = data.Message.head.METER_TYPE_NAME;
                 
                    $scope.headInfo.HEAD_USER_ID = data.Message.head.HEAD_USER_ID;
                    $scope.headInfo.HEAD_USER_ID_NAME = data.Message.head.HEAD_USER_ID_NAME;
                 
                    $scope.headInfo.IDENTIFICATION_TYPE = data.Message.head.IDENTIFICATION_TYPE;
                    $scope.headInfo.IDENTIFICATION_TYPE_NAME = data.Message.head.IDENTIFICATION_TYPE_NAME;

                    $scope.headInfo.IS_FORCE_SENSE = data.Message.head.IS_FORCE_SENSE;

                    $scope.headInfo.PLAN_IDENTIFICATION = data.Message.head.PLAN_IDENTIFICATION;
                    $scope.headInfo.ACTUAL_IDENTIFICATION = data.Message.head.ACTUAL_IDENTIFICATION;
                    $scope.headInfo.NEXT_IDENTIFICATION = data.Message.head.NEXT_IDENTIFICATION;


                    $scope.headInfo.RESULT_ID = data.Message.head.RESULT_ID;
                    $scope.headInfo.CERTIFICATE_CODE = data.Message.head.CERTIFICATE_CODE;
                    $scope.headInfo.MONEY = data.Message.head.MONEY;
                    $scope.headInfo.CHECK_PERSON = data.Message.head.CHECK_PERSON;

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
                $http.post($rootScope.baseUrl + "service/mce/mce_meter/Srv_MCE_MCEMeterCheckOperate.ashx?oType=submit", list).success(function (data) {
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
                $http.post($rootScope.baseUrl + "service/mce/mce_meter/Srv_MCE_MCEMeterCheckOperate.ashx?oType=audit", list).success(function (data) {
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
                url: $rootScope.baseUrl + "service/mce/mce_meter/Srv_MCE_MCEMeterCheckSave.ashx",
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
            window.location.replace("PageMceMeterCheckList.html")
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
                alert(参数错误);
              
            }


        };
        $scope.default();


    }])