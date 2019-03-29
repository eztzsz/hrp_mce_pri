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
            NAME: "",
            MTN_TYPE_ID: "",
            MTN_TYPE_ID_NAME: "",

            MTN_COMPANY_ID: "",
            MTN_COMPANY_ID_NAME: "",
            EXECUTE_PERIOD: 0,

            EXECUTE_PERIOD_UNIT: "1",
            EXECUTE_PERIOD_UNIT_NAME: "",

            CREATE_DATE: "",
            ACTUAL_EXEC_DATE: "",
            NEXT_EXEC_DATE: "",

            APPLY_USER_ID: "",
            APPLY_USER_ID_NAME: "",
            COMMENTS: "",

            TOTAL_MONEY: 0,

            PLAN_STATE: 1,
            PLAN_STATE_NAME: "正常",
            STATE: 0,
            STATE_NAME: "",
        };
        $scope.tableRows = [];
        $scope.attachRows = [];

        $scope.InputschangeState = InputschangeState;
        $scope.InputschangeState.states = {
        };



        $scope.mtnTypeList = [];
        $scope.getMtnTypeListList = function () {
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=MCE_0008&limit=10000"
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.mtnTypeList = data.Message.rows
                } else {
                    alert(data.Message)
                }
            })
        };


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
                url: $rootScope.baseUrl + "service/mce/mce_mt/Srv_MCE_GetMCEMTNExecDetail.ashx?id=" + $scope.paramObj.id
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.tableRows = data.Message.rows;
                    for (var i = 0; i < $scope.tableRows.length; i++) {
                        $scope.tableRows[i].checked = false
                    }

                    $scope.attachRows = data.Message.attach;

                    $scope.headInfo.ID = data.Message.head.ID;
                    $scope.headInfo.CODE = data.Message.head.CODE;
                    $scope.headInfo.NAME = data.Message.head.NAME;

                    if (data.Message.head.MTN_TYPE_ID != null)
                    {
                        $scope.headInfo.MTN_TYPE_ID = data.Message.head.MTN_TYPE_ID.trim();
                    }
                    $scope.headInfo.MTN_TYPE_ID_NAME = data.Message.head.MTN_TYPE_ID_NAME;

                    $scope.headInfo.MTN_COMPANY_ID = data.Message.head.MTN_COMPANY_ID;
                    $scope.headInfo.MTN_COMPANY_ID_NAME = data.Message.head.MTN_COMPANY_ID_NAME;
                  
                    $scope.headInfo.APPLY_USER_ID = data.Message.head.APPLY_USER_ID;
                    $scope.headInfo.APPLY_USER_ID_NAME = data.Message.head.APPLY_USER_ID_NAME;
                    
                    $scope.headInfo.EXECUTE_PERIOD = data.Message.head.EXECUTE_PERIOD;
                    $scope.headInfo.EXECUTE_PERIOD_UNIT = data.Message.head.EXECUTE_PERIOD_UNIT;
                    $scope.headInfo.EXECUTE_PERIOD_UNIT_NAME = data.Message.head.EXECUTE_PERIOD_UNIT_NAME;

                    $scope.headInfo.CREATE_DATE = data.Message.head.CREATE_DATE;
                    $scope.headInfo.ACTUAL_EXEC_DATE = data.Message.head.ACTUAL_EXEC_DATE;
                    $scope.headInfo.NEXT_EXEC_DATE = data.Message.head.NEXT_EXEC_DATE;
                                        
                    $scope.headInfo.COMMENTS = data.Message.head.COMMENTS;

                    $scope.headInfo.PLAN_STATE = data.Message.head.PLAN_STATE;
                    $scope.headInfo.PLAN_STATE_NAME = data.Message.head.PLAN_STATE_NAME;

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
                $scope.tableRows[k].showMTItemState = false;
            })
        };




        //保养项目
        $scope.conditionMtnItemForAdd = {
            condition: ""
        };
        $scope.mtnItemList = [];
        $scope.fkMtnItemPager = ParamService.getPager();
        $scope.searcFkMtnItemListForAdd = function (curIndex, v) {
            $scope.conditionMtnItemForAdd.condition = v.ITEM_ID_NAME;
            v.showMTItemState = true;
            var param = ParamService.comParam(curIndex, $scope.fkMtnItemPager.pageSize, $scope.conditionMtnItemForAdd);
            $http.get($rootScope.baseUrl + "service/mce/mce_mt/Srv_MCE_GetMCEMTNItemList.ashx" + param).success(function (data) {
                if (data.Succeed == 1) {
                    v.showMTItemState = true;
                    $scope.mtnItemList = data.Message.rows;
                    $scope.fkMtnItemPager.setDataNum(data.Message.total);
                    $scope.fkMtnItemPager.setCurIndex(curIndex);
                }
            })
        };
        $scope.changeFkMtnItemState = function (index) {
            $scope.clearFkDetailState();
            $scope.tableRows[index].showMTItemState = true;

        };
        $scope.selectFkMtnItemForAdd = function (v, a) {
            v.showMTItemState = false;
            v.ITEM_ID = a.ID;
            v.ITEM_ID_NAME = a.NAME;
        };
        $scope.clearFkMtnItemForAdd = function (v) {
            v.ITEM_ID = "";
            v.ITEM_ID_NAME = "";
        };


        $scope.creatModel = function () {
            return {
                ID: "",
  
                ASSETS_ID:"",
                ASSETS_ID_NAME: "",
                ASSET_CODE: "",
                SPEC: "",
                DEPT_ID: "",
                DEPT_ID_NAME: "",

                SEQ_NUMBER: "",

                ITEM_ID: "",
                ITEM_ID_NAME: "",

                COMMENTS: "",
                checked: false,

                showMTItemState: false
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
                $http.post($rootScope.baseUrl + "service/mce/mce_mt/Srv_MCE_MCEMTNExecOperate.ashx?oType=submit", list).success(function (data) {
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
                $http.post($rootScope.baseUrl + "service/mce/mce_mt/Srv_MCE_MCEMTNExecOperate.ashx?oType=audit", list).success(function (data) {
                    if (data.Succeed == 1) {
                        alert("审核成功！");
                        $scope.getDetailInfo();
                    } else {
                        alert(data.Message + "审核失败！");
                    }
                })
            }
        };


        $scope.saveModel=function (vType) {
            var data={
                ID: "",
                ACTUAL_EXEC_DATE: "",
                COMMENTS: "",
                children: [],
                listAttach: []
            };

         
            function  retModel() {
                return {
                    ID: "",
                    RESULT_ID: "",
                    MONEY: 0,
         
                    COMMENTS: ""
                }
            }
    
            if ($scope.headInfo.ACTUAL_EXEC_DATE == null || $scope.headInfo.ACTUAL_EXEC_DATE == "") {
                alert("请输入执行状态");
                return
            }

            data.ID = $scope.headInfo.ID;
            data.ACTUAL_EXEC_DATE = $scope.headInfo.ACTUAL_EXEC_DATE;

            data.COMMENTS = $scope.headInfo.COMMENTS;
    
            for (var i = 0; i < $scope.tableRows.length; i++) {
      
                data.children.push(retModel());
                data.children[i].ID = $scope.tableRows[i].ID;
                data.children[i].RESULT_ID = $scope.tableRows[i].RESULT_ID;
                data.children[i].MONEY = $scope.tableRows[i].MONEY;
            
                data.children[i].COMMENTS = $scope.tableRows[i].COMMENTS;
            
                if (data.children[i].RESULT_ID == null || data.children[i].RESULT_ID == "") {
                    alert("保养结果不能为空");
                    return
                }

                if (data.children[i].MONEY != null && data.children[i].MONEY != "") {
                    if (data.children[i].MONEY * 1 <= 0 || isNaN(data.children[i].MONEY)) {
                        alert("请输入正确的保养费用");
                        return
                    }
                }

            }

            data.listAttach = $scope.attachRows;

            $http({
                method:"POST",
                url: $rootScope.baseUrl + "service/mce/mce_mt/Srv_MCE_MCEMTNExecSave.ashx",
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


        $scope.goBack = function () {
            window.location.replace("PageMceMTNExecList.html")
        };





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


        $scope.default = function () {
            $scope.getDetailId();
            $scope.getMtnTypeListList();

            if ($scope.paramObj.id != "") {
        
                $scope.getDetailInfo();

            } else {
                alert("参数错误");
               // $scope.getUserInfo();

            }

         

        };
        $scope.default();


    }])