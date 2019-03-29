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
            WRITE_OFF_CAUSE_ID: "",

            INCOME: "",
            USAGE: "",
            COMMENTS: "",
            STATE: 0,
            STATE_NAME: "",
        };


        $scope.tableRows = [];
        $scope.attachRows = [];

        $scope.InputschangeState = InputschangeState;
        $scope.InputschangeState.states = {
            dept: false,
            user: false
        };

        //申请科室
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
                url: $rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_GetMCEAssetsUserInfo.ashx?code_type=MceWriteOff"
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.headInfo.USER_ID = data.Message.user_id;
                    $scope.headInfo.USER_ID_NAME = data.Message.user_name;
                    $scope.user.param.condition = data.Message.user_name;

                    $scope.headInfo.DEPT_ID = data.Message.dept_id;
                    $scope.headInfo.DEPT_ID_NAME = data.Message.dept_name;
                    $scope.dept.param.condition = data.Message.dept_name;

                    $scope.headInfo.FINANCE_CYCLE = data.Message.finance_cycle;
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
                    $scope.dept.param.condition = data.Message.head.DEPT_ID_NAME;

                    $scope.headInfo.USER_ID = data.Message.head.USER_ID;
                    $scope.headInfo.USER_ID_NAME = data.Message.head.USER_ID_NAME;
                    $scope.user.param.condition = data.Message.head.USER_ID_NAME;

                    $scope.headInfo.FINANCE_CYCLE = data.Message.head.FINANCE_CYCLE;

                    if (data.Message.head.WRITE_OFF_TYPE_ID != null) {
                        $scope.headInfo.WRITE_OFF_TYPE_ID = data.Message.head.WRITE_OFF_TYPE_ID.trim();
                    }

                    if (data.Message.head.WRITE_OFF_CAUSE_ID != null) {
                        $scope.headInfo.WRITE_OFF_CAUSE_ID = data.Message.head.WRITE_OFF_CAUSE_ID.trim();
                    }

                    $scope.headInfo.INCOME = data.Message.head.INCOME;
                    $scope.headInfo.USAGE = data.Message.head.USAGE;


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



        $scope.paramAssetObj = {
            assets_state: "00530002",
    //        use_state: "00540002",
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

                    var vExist = false;
                    for (var k = 0; k < $scope.tableRows.length; k++)
                    {
                        if( $scope.tableRows[k].ASSET_ID==$scope.modelAssetList[i].ID)
                        {
                            vExist = true;
                            break;
                        }
                    }

                    if (vExist == false) {
                        var vModal = $scope.creatModel();
                        vModal.MACHINE_TYPE_ID_NAME = $scope.modelAssetList[i].MACHINE_TYPE_ID_NAME;
                        vModal.ASSET_ID = $scope.modelAssetList[i].ID;
                        vModal.ASSETS_NAME = $scope.modelAssetList[i].ASSETS_NAME;
                        vModal.ASSETS_CODE = $scope.modelAssetList[i].ASSETS_CODE;
                        vModal.SPEC = $scope.modelAssetList[i].SPEC;

                        vModal.PRD_ID = $scope.modelAssetList[i].PRD_ID;
                        vModal.PRD_ID_NAME = $scope.modelAssetList[i].PRD_ID_NAME;

                        vModal.STORE_ADDRESS = $scope.modelAssetList[i].STORE_ADDRESS;
                        vModal.ORIGINAL_VALUE = $scope.modelAssetList[i].ORIGINAL_VALUE;
                        vModal.NET_VALUE = $scope.modelAssetList[i].NET_VALUE;
                        vModal.RUDIMENTAL_VALUE = $scope.modelAssetList[i].RUDIMENTAL_VALUE;
                        vModal.ENABLE_DATE = $scope.modelAssetList[i].ENABLE_DATE;

                        $scope.tableRows.push(vModal);
                    }
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
                $http.post($rootScope.baseUrl + "service/mce/mce_writeoff/Srv_MCE_MCEWriteOffOperate.ashx?oType=submit", list).success(function (data) {
                    if (data.Succeed == 1) {
                        alert("提交成功！");
                        $scope.getDetailInfo();
                    } else {
                        alert(data.Message + "提交失败！");
                    }
                })
            }
        };

        /*
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
        */

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
                CREATE_DATE: "",
                DEPT_ID: "",
                USER_ID: "",

                FINANCE_CYCLE: "",

                WRITE_OFF_TYPE_ID: "",
                WRITE_OFF_CAUSE_ID: "",

                INCOME: "",
                USAGE: "",

                COMMENTS: "",
                STATE: 1,

                children: [],
                listAttach: []
            };
            function  retModel() {
                return {
                    ID: "",
                    ASSETS_ID: ""
                }
            }
         

            if ($scope.headInfo.CREATE_DATE == null || $scope.headInfo.CREATE_DATE == "") {
                alert("申请日期不能为空");
                return
            }

            if ($scope.headInfo.DEPT_ID == null || $scope.headInfo.DEPT_ID == "") {
                alert("申请科室不能为空");
                return
            }

            if ($scope.headInfo.USER_ID == null || $scope.headInfo.USER_ID == "") {
                alert("申请人不能为空");
                return
            }

            if ($scope.headInfo.FINANCE_CYCLE == null || $scope.headInfo.FINANCE_CYCLE == "") {
                alert("财务月份不能为空");
                return
            }
            data.ID = $scope.headInfo.ID;
            data.CODE = $scope.headInfo.CODE;
        
            data.CREATE_DATE = $scope.headInfo.CREATE_DATE;
            data.DEPT_ID = $scope.headInfo.DEPT_ID;
            data.USER_ID = $scope.headInfo.USER_ID;

            data.FINANCE_CYCLE = $scope.headInfo.FINANCE_CYCLE;
            data.WRITE_OFF_TYPE_ID = $scope.headInfo.WRITE_OFF_TYPE_ID;
            data.WRITE_OFF_CAUSE_ID = $scope.headInfo.WRITE_OFF_CAUSE_ID;
            data.INCOME = $scope.headInfo.INCOME;
            data.USAGE = $scope.headInfo.USAGE;

            data.COMMENTS = $scope.headInfo.COMMENTS;
        
            for (var i = 0; i < $scope.tableRows.length; i++) {
      
                data.children.push(retModel());
                data.children[i].ID = $scope.tableRows[i].ID;
                data.children[i].ASSET_ID = $scope.tableRows[i].ASSET_ID;
              
         
                if (data.children[i].ASSET_ID == null || data.children[i].ASSET_ID == "") {
                    alert("设备名称不能为空");
                    return
                }
            }

            data.listAttach = $scope.attachRows;

            $http({
                method:"POST",
                url: $rootScope.baseUrl + "service/mce/mce_writeoff/Srv_MCE_MCEWriteOffSave.ashx",
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
            window.location.replace("PageMceWriteOffList.html")
        };



        //文件上传
        $rootScope.getFile = function ( size, type1, type2) {

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
                            objFile.SAVENAME = res.Message.saveName;
                            objFile.FILE_NAME = res.Message.fileName;
                            objFile.USER_ID = res.Message.userid;
                            objFile.USER_ID_NAME = res.Message.username;
                            objFile.CREATE_DATE = res.Message.createdate;
  
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
            window.open("../../upload/mce/" + value.SAVENAME)
        };

        $scope.delAttachModel = function (k) {
            var flag = confirm("是否确认删除？");
            if (!flag) {
                return false
            }

            $scope.attachRows.splice(k,1);

        };

        $scope.writeOffTypeList = [];
        $scope.getWriteOffTypeListList = function () {
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=0302&limit=10000"
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.writeOffTypeList = data.Message.rows
                } else {
                    alert(data.Message)
                }
            })
        };

        $scope.writeOffCauseList = [];
        $scope.getWriteOffCauseListList = function () {
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=0301&limit=10000"
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.writeOffCauseList = data.Message.rows
                } else {
                    alert(data.Message)
                }
            })
        };


        $scope.default = function () {
            $scope.getDetailId();
            $scope.getWriteOffTypeListList();
            $scope.getWriteOffCauseListList();

            if ($scope.paramObj.id != "") {
        
                $scope.getDetailInfo();

            } else {
                $scope.getUserInfo();
              //  $scope.addModel();
            }

         

        };
        $scope.default();


    }])