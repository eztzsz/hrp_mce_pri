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

            SIGN_DATE: "",
            EXPIRE_DATE: "",

            TYPE_ID: "",

            FIRST_PARTY: "",
            FIRST_PARTY_NAME: "",

            SECOND_PARTY: "",
            SECOND_PARTY_NAME: "",

            SECOND_LINK_PERSON: "",
            SECOND_LINK_PHONE: "",

            MONEY: 0,

            ARCHIVE_NO: "",
            CHECK_DATE: "",

            ARCHIVIST: "",
            ARCHIVIST_NAME: "",

            INPUT_PERSON: "",
            INPUT_PERSON_NAME: "",
            
            CONTRACT_CONTENT: "",
            STATE: 0,
            STATE_NAME: "",

            CONTRACT_STATE: 1,
        };


        $scope.tableRows = [];
        $scope.payRows = [];
        $scope.attachRows = [];

        $scope.InputschangeState = InputschangeState;
        $scope.InputschangeState.states = {
            dept: false,
            second:false,
            user: false
        };

        //甲方单位
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
            $scope.headInfo.FIRST_PARTY = n.dept.trim();
            $scope.headInfo.FIRST_PARTY_NAME = $scope.dept.param.condition;
        
        }, true);



        //合同乙方
        $scope.second = ParamS($rootScope.baseUrl + "service/mtr/Srv_MTR_PrvList.ashx");
        $scope.second.showTabTh = ['编号', '名称'];
        $scope.second.showTabTb = ['code', 'name'];
        $scope.second.param = {
            condition: "",
            type: "00340005"
        };
        $scope.paramSecond = {
            second: ""
        };


        $scope.$watch("paramSecond", function (n, o) {
            $scope.headInfo.SECOND_PARTY = n.second.trim();
            $scope.headInfo.SECOND_PARTY_NAME = $scope.second.param.condition;

        }, true);


        //档案管理员
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
            $scope.headInfo.ARCHIVIST = n.user.trim();
            $scope.headInfo.ARCHIVIST_NAME = $scope.user.param.condition;
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
                url: $rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_GetMCEAssetsUserInfo.ashx?code_type=MceContract"
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.headInfo.INPUT_PERSON = data.Message.user_id;
                    $scope.headInfo.INPUT_PERSON_NAME = data.Message.user_name;
                   
                    $scope.headInfo.FIRST_PARTY = data.Message.dept_id;
                    $scope.headInfo.FIRST_PARTY_NAME = data.Message.dept_name;
                    $scope.dept.param.condition = data.Message.dept_name;

                    $scope.headInfo.SIGN_DATE = data.Message.sys_date;

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
                url: $rootScope.baseUrl + "service/mce/MCE_CONTRACT/Srv_MCE_GetMCEContractDetail.ashx?id=" + $scope.paramObj.id
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                  
                    $scope.tableRows = data.Message.rows;
                    for (var i = 0; i < $scope.tableRows.length; i++) {
                        $scope.tableRows[i].checked = false;
                        $scope.tableRows[i].ASSET_ID = $scope.tableRows[i].ID;
                    }
                    
                    $scope.payRows = data.Message.payRows;
                    $scope.attachRows = data.Message.attach;
                    
                    $scope.headInfo.ID = data.Message.head.ID;
                    $scope.headInfo.CODE = data.Message.head.CODE;
                    $scope.headInfo.NAME = data.Message.head.NAME;

                    $scope.headInfo.SIGN_DATE = data.Message.head.SIGN_DATE;
                    $scope.headInfo.EXPIRE_DATE = data.Message.head.EXPIRE_DATE;

                    
                    if (data.Message.head.TYPE_ID != null) {
                        $scope.headInfo.TYPE_ID = data.Message.head.TYPE_ID.trim();
                    }

                    $scope.headInfo.FIRST_PARTY = data.Message.head.FIRST_PARTY;
                    $scope.headInfo.FIRST_PARTY_NAME = data.Message.head.FIRST_PARTYD_NAME;
                    $scope.dept.param.condition = data.Message.head.FIRST_PARTY_NAME;

                    $scope.headInfo.SECOND_PARTY = data.Message.head.SECOND_PARTY;
                    $scope.headInfo.SECOND_PARTY_NAME = data.Message.head.SECOND_PARTY_NAME;
                    $scope.second.param.condition = data.Message.head.SECOND_PARTY_NAME;

                    $scope.headInfo.SECOND_LINK_PERSON = data.Message.head.SECOND_LINK_PERSON;
                    $scope.headInfo.SECOND_LINK_PHONE = data.Message.head.SECOND_LINK_PHONE;
                    $scope.headInfo.MONEY = data.Message.head.MONEY;
                    $scope.headInfo.ARCHIVE_NO = data.Message.head.ARCHIVE_NO;
                    $scope.headInfo.CHECK_DATE = data.Message.head.CHECK_DATE;

                    $scope.headInfo.ARCHIVIST = data.Message.head.ARCHIVIST;
                    $scope.headInfo.ARCHIVIST_NAME = data.Message.head.ARCHIVIST_NAME;
                    $scope.user.param.condition = data.Message.head.ARCHIVIST_NAME;
                    
                    $scope.headInfo.INPUT_PERSON = data.Message.head.INPUT_PERSON;
                    $scope.headInfo.INPUT_PERSON_NAME = data.Message.head.INPUT_PERSON_NAME;

                    $scope.headInfo.CONTRACT_CONTENT = data.Message.head.CONTRACT_CONTENT;
            
                    $scope.headInfo.STATE = data.Message.head.STATE;
                    $scope.headInfo.STATE_NAME = data.Message.head.STATE_NAME;

                    $scope.headInfo.CONTRACT_STATE = data.Message.head.CONTRACT_STATE;

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

                SUBJECTION_DEPT_ID_NAME: "",
                USING_DEPT_ID_NAME: "",
                PURCHASE_DATE: "",
              
                checked: false
            
            }
        };


        $scope.creatPayModel = function () {
            return {
                ID: "",
                PERIODS: 0,
                MONEY: 0,

                PLAN_PAY_DATE: "",
                ACTUAL_PAY_DATE: "",
                STATE: 2,
                STATE_NAME: "未付款"
              
            }
        };


        $scope.addPayModal = function () {
            $scope.payRows.push($scope.creatPayModel())

            for (var i = 0; i < $scope.payRows.length; i++) {
                $scope.payRows[i].PERIODS = i + 1;
            }
        };

        $scope.delPayModel = function (k) {
            var flag = confirm("是否确认删除？");
            if (!flag) {
                return false
            }

            $scope.payRows.splice(k, 1);

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

                        vModal.SUBJECTION_DEPT_ID_NAME = $scope.modelAssetList[i].SUBJECTION_DEPT_ID_NAME;
                        vModal.USING_DEPT_ID_NAME = $scope.modelAssetList[i].USING_DEPT_ID_NAME;
                        vModal.PURCHASE_DATE = $scope.modelAssetList[i].PURCHASE_DATE;

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
                $http.post($rootScope.baseUrl + "service/mce/MCE_CONTRACT/Srv_MCE_MCEContractOperate.ashx?oType=submit", list).success(function (data) {
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
                $http.post($rootScope.baseUrl + "service/mce/MCE_CONTRACT/Srv_MCE_MCEContractOperate.ashx?oType=audit", list).success(function (data) {
                    if (data.Succeed == 1) {
                        alert("审核成功！");
                        $scope.getDetailInfo();
                    } else {
                        alert(data.Message + "审核失败！");
                    }
                })
            }
        };
        


        $scope.stopModel = function () {
            var flag = confirm("是否确认终止？");
            if (!flag) {
                return false
            }

            var list = [];

            if ($scope.paramObj.id == null || $scope.paramObj.id == "") {
                alert("请先保存再终止！");
                return;
            }
            else {
                list.push($scope.paramObj.id);
                $http.post($rootScope.baseUrl + "service/mce/MCE_CONTRACT/Srv_MCE_MCEContractOperate.ashx?oType=stop", list).success(function (data) {
                    if (data.Succeed == 1) {
                        alert("审核成功！");
                        $scope.getDetailInfo();
                    } else {
                        alert(data.Message + "终止失败！");
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
                NAME: "",

                SIGN_DATE: "",
                EXPIRE_DATE: "",
                TYPE_ID: "",
                FIRST_PARTY: "",
                SECOND_PARTY: "",
                SECOND_LINK_PERSON: "",
                SECOND_LINK_PHONE: "",
                "MONEY": 0,
                ARCHIVE_NO: "",
                CHECK_DATE: "",
                ARCHIVIST: "",          
                INPUT_PERSON: "",
                INPUT_PERSON_NAME: "",
                CONTRACT_CONTENT: "",

                STATE: 1,

                children: [],
                listPay: [],
                listAttach: []
            };
            function  retModel() {
                return {
                    ID: "",
                    ASSETS_ID: ""
                }
            }
         

            data.ID = $scope.headInfo.ID;
            data.CODE = $scope.headInfo.CODE;
            data.NAME = $scope.headInfo.NAME;

            data.SIGN_DATE = $scope.headInfo.SIGN_DATE;
            data.EXPIRE_DATE = $scope.headInfo.EXPIRE_DATE;

            data.TYPE_ID = $scope.headInfo.TYPE_ID;
            data.FIRST_PARTY = $scope.headInfo.FIRST_PARTY;

            data.SECOND_PARTY = $scope.headInfo.SECOND_PARTY;
            data.SECOND_LINK_PERSON = $scope.headInfo.SECOND_LINK_PERSON;
            data.SECOND_LINK_PHONE = $scope.headInfo.SECOND_LINK_PHONE;
            data.MONEY = $scope.headInfo.MONEY;
            data.ARCHIVE_NO = $scope.headInfo.ARCHIVE_NO;

            data.CHECK_DATE = $scope.headInfo.CHECK_DATE;
            data.ARCHIVIST = $scope.headInfo.ARCHIVIST;
            data.INPUT_PERSON = $scope.headInfo.INPUT_PERSON;
         
            data.CONTRACT_CONTENT = $scope.headInfo.CONTRACT_CONTENT;
       
       

          
            for (var i = 0; i < $scope.tableRows.length; i++) {
      
                data.children.push(retModel());
                data.children[i].ID = $scope.tableRows[i].ID;
                data.children[i].ASSET_ID = $scope.tableRows[i].ASSET_ID;
              
         
                if (data.children[i].ASSET_ID == null || data.children[i].ASSET_ID == "") {
                    alert("设备名称不能为空");
                    return
                }
            }

            data.listPay = $scope.payRows;
            data.listAttach = $scope.attachRows;
            

            $http({
                method:"POST",
                url: $rootScope.baseUrl + "service/mce/MCE_CONTRACT/Srv_MCE_MCEContractSave.ashx",
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
            window.location.replace("PageMceContractList.html")
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

            $scope.attachRows.splice(k,1);

        };

        $scope.contractTypeList = [];
        $scope.getContractTypeList = function () {
            $http({
                method: "GET",
                url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=COM_1006&limit=10000"
            }).then(function (data) {
                var data = data.data;
                if (data.Succeed == 1) {
                    $scope.contractTypeList = data.Message.rows
                } else {
                    alert(data.Message)
                }
            })
        };

    


        $scope.default = function () {
            $scope.getDetailId();
            $scope.getContractTypeList();
          
            if ($scope.paramObj.id != "") {
        
                $scope.getDetailInfo();

            } else {
                $scope.getUserInfo();
              //  $scope.addModel();
            }

         

        };
        $scope.default();


    }])