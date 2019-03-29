



var app = angular.module("app", ['ui.router', 'app.directive', 'app.services']);

//路由
app.config(function ($stateProvider) {
	$stateProvider
		.state("main", { //首页
			url: "",
			templateUrl: "page/baseInfo.html",
			redirectTo: "/baseInfo"
		})
		.state("baseInfo", { //基本信息
			url: "/baseInfo",
			templateUrl: "page/baseInfo.html"
		})
		.state("enclosure", { //附件信息
			url: "/enclosure",
			templateUrl: "page/enclosure.html"
		})
		.state("capital", { //资金信息
			url: "/capital",
			templateUrl: "page/capital.html"
		})
		.state("depreciation", { //折旧信息
			url: "/depreciation",
			templateUrl: "page/depreciation.html"
		})
		.state("imported", { //进口信息
			url: "/imported",
			templateUrl: "page/imported.html"
		})
		.state("contract", { //合同信息
			url: "/contract",
			templateUrl: "page/contract.html"
		})
		.state("insurance", { //保险信息
			url: "/insurance",
			templateUrl: "page/insurance.html"
		})
		.state("maintenance", { //维保信息
			url: "/maintenance",
			templateUrl: "page/maintenance.html"
		})
		.state("circulation", { //流转信息
			url: "/circulation",
			templateUrl: "page/circulation.html"
		})
		.state("metering", { //计量信息
			url: "/metering",
			templateUrl: "page/metering.html"
		})
		.state("inspection", { //强检信息
			url: "/inspection",
			templateUrl: "page/inspection.html"
		})
		.state("scrap", { //报废信息
			url: "/scrap",
			templateUrl: "page/scrap.html"
		})
		.state("records", { //案卷信息
			url: "/records",
			templateUrl: "page/records.html"
		})
		.state("records/relation", { //案卷信息
		    url: "/records/relation?id&audit_state",
			templateUrl: "page/recordsRelation.html"
		})
		.state("records/fileList", { //案卷信息
		    url: "/records/fileList?id&audit_state",
			templateUrl: "page/fileList.html"
		})
		.state("records/fileModel", { //案卷信息
			url: "/records/fileModel",
			templateUrl: "page/fileModel.html"
		})
})
	.run(['$rootScope', '$location', function ($rootScope, $location) {
	
		$rootScope.$on('$locationChangeStart', function (event, newUrl, currentUrl) {


		});
		$rootScope.$on('$locationChangeSuccess', function (event, newUrl, currentUrl) {
			var path = $location.path().split("/")[1] ? $location.path().split("/")[1] : "baseInfo";
			angular.forEach($rootScope.routerSel, function (v, k) {
				$rootScope.routerSel[k] = k == path ? true : false
			})
		});
	}]);
app.controller("index", ['$scope', '$http', '$rootScope', '$location', function ($scope, $http, $rootScope, $location) {

	$rootScope.baseUrl = "../../";

	$scope.paramObj = {
	    id: "",
	    history: ""
	};

	$rootScope.fileData = "";

	//路由选中
	$rootScope.routerSel = {
		baseInfo: true,
		enclosure: false,
		capital: false,
		depreciation: false,
		imported: false,
		contract: false,
		insurance: false,
		maintenance: false,
		circulation: false,
		metering: false,
		inspection: false,
		scrap: false,
		records: false

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

	    $scope.paramObj = urlArgs();

	};

	//文件上传
	$rootScope.getFile = function (value,func,size, type1, type2) {

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
			    url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_FileUpload.ashx",
			    method: "POST",
			    headers: { 'Content-Type': undefined },//使用angular上传一定要加上这一句，不然传给后台的是空的。
			    data: formData,
			    transformRequest: angular.identity
			}).then(function (result) {
			    var res = result.data;
			    if (res.Succeed == 1) {
			        if (res.Message.saveName) {
			            var objFile = new Object();
			            objFile.saveName = res.Message.saveName;
			            objFile.fileName = res.Message.fileName;

			            if (func == "baseinfo")
			            {
			                value.picture = objFile.saveName;
			            }
			            else if (func == "rollfile")
			            {
			                value.filename = objFile.saveName;
			            }
			            else if (func == "capital" || func == "affix" || func == "depr" || func == "import" || func == "contract" || func == "insurance" || func == "meter" || func == "writeoff") {
			                value.listFileName.push(objFile);
			            }
			          
                     
			        } else {
			            alert(res.Message)
			        }
			    } else {
			        alert(res.Message)
			    }
			})

		})
	};
	$rootScope.upFile = function (succeed) {
		if (!$rootScope.fileData) {
			alert("请选择文件");
			return false
		}
		$http({
			url: $rootScope.baseUrl + "service/prv/PRV_BASIC/Srv_PRV_FileUpload.ashx",
			method: "POST",
			headers: {'Content-Type': undefined},//使用angular上传一定要加上这一句，不然传给后台的是空的。
			data: $rootScope.fileData,
			transformRequest: angular.identity
		}).then(function (result) {
			var res = result.data;
			if (res.Succeed == 1) {
				if (res.Message.saveName) {
					//

				} else {
					alert(res.Message)
				}
			} else {
				alert(res.Message)
			}
		})
	};

	$scope.FileDown = function (value) {

	    window.open("../../upload/mce/" + value.saveName)

	};

	$scope.getDetailId();

}])
	.controller("base", ['$scope', '$http', '$rootScope', '$location', "ParamS", "ParamService", "InputschangeState",
		function ($scope, $http, $rootScope, $location, ParamS, ParamService, InputschangeState) {
            
            
			//基本信息
			$scope.defaultImg = "../../images/icon/imgDefault.png";
			$scope.printImg = "../../images/icon/imgDefault.png";

			$scope.InputschangeState = InputschangeState;
			$scope.InputschangeState.states = {
			    type: false,
			    unit: false,
                dept:false,
			    prd: false,
			    prv: false,
			    less: false
			};


			$scope.printCode = function () {
				$(".downFile").print({
					globalStyles: true,
					mediaPrint: false,
					stylesheet: null,
					noPrintSelector: ".no-print",
					iframe: true,
					append: null,
					prepend: null,
					manuallyCopyFormValues: true,
					deferred: $.Deferred(),
					timeout: 1000,
					title: null,
					doctype: '<!doctype html>'
				})
			};

			$scope.paramBaseObj = {
			    id: "",
                state:1,
			    assets_code: "",
			    assets_name: "",
			    seq_number:'',
			    spec: '',
			    machine_type_id: "",
			    purchase_date: "",

			    en_name: '',
			    card_code: '',
			    card_type_id: '',
			    unit_id: "",

			    assets_state:"",
			    enable_date: "",
			    is_in_account: "2",
			    in_account_date:"",
			    out_account_date:"",
			    store_address: "",
			    maintain_period: "",

			    is_assets: "1",
			    is_depr: "2",
			    is_large_me:"2",
			    is_affix:"2",
			    is_metering: "2",
			    is_self_restraint:"2",

			    ownership_type_id: "",
			    subjection_dept_id:"",
			    custody_dept_id_name: "",
			    custody_user_id_name:"",
			    custody_level_id:"",
			    using_dept_id_name: "",
			    using_user_id_name:"",
			    use_state:"",
			    biz_type_id: "",

			    operating_machine_type_id: "",
			    machine_manage_type_id: "",
			    spell_code: "",
			    five_stroke_code: "",
			    international_code: "",
			    custom_code: "",

			    call_code: "",
			    file_code: "",
			    contract_code: "",
			    licence_code: "",
			    maintain_contact: "",
			    original_value: "",
			    net_value: "",
			    net_amount: "",
			    rudimental_value:"",
			    rudimental_value_ratio: "",
			    predict_net_rudimental_value : "",
			    add_value: "",
			    depr_type_id: "",
			    depr_year_amount: "",

			    acquire_ownership_type_id: "",
			    acquire_use_type_id: "",
			    value_type_id: "",
			    finance_type_id: "",
			    ref_dept_id: "",
			    ref_price: "",

			    economic_use_type_id: "",
			    purchase_type_id: "",
			    capital_source_type_id: "",
			    prd_date: "",
			    maintenance_period_date: "",
			    vehicle_code: "",
			    vehicle_use_type_id: "",
			    energy_type_id: "",
			    brand_name: "",

			    prd_id: "",
			    prd_code : "",
			    provider_id: "",
			    prd_place_type_id : "",
			    nationality_id: "",

			    picture:"",
                printImg:""

			};



			$scope.getBaseInfo = function () {
			    $http({
			        method: "GET",
			        url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCEAssetsDetail.ashx?id=" + $scope.paramObj.id
			    }).then(function (data) {
			        var data = data.data;
			        if (data.Succeed == 1) {
			            $scope.paramBaseObj.id = data.Message.ID;
			            $scope.paramBaseObj.state = data.Message.STATE;
			            $scope.paramBaseObj.assets_code = data.Message.ASSETS_CODE;
			            $scope.paramBaseObj.assets_name = data.Message.ASSETS_NAME;
			            $scope.paramBaseObj.seq_number = data.Message.SEQ_NUMBER;
			            $scope.paramBaseObj.spec = data.Message.SPEC;
			            $scope.paramBaseObj.machine_type_id = data.Message.MACHINE_TYPE_ID;
			            $scope.type.param.name = $scope.type.param.condition = data.Message.MACHINE_TYPE_ID_NAME;

			            $scope.paramBaseObj.purchase_date = data.Message.PURCHASE_DATE;
			            $scope.paramBaseObj.en_name = data.Message.EN_NAME;
			            $scope.paramBaseObj.card_code = data.Message.CARD_CODE;
			            $scope.paramBaseObj.card_type_id =data.Message.CARD_TYPE_ID==null?"": data.Message.CARD_TYPE_ID.trim();		            
			            $scope.paramBaseObj.unit_id = data.Message.UNIT_ID;                       
			            $scope.unit.param.name = $scope.unit.param.condition = data.Message.UNIT_ID_NAME;
                        
			            $scope.paramBaseObj.assets_state = data.Message.ASSETS_STATE==null?"": data.Message.ASSETS_STATE.trim();
			            $scope.paramBaseObj.enable_date = data.Message.ENABLE_DATE;
			            $scope.paramBaseObj.service_life = data.Message.SERVICE_LIFE;
			            $scope.paramBaseObj.is_in_account = data.Message.IS_IN_ACCOUNT;
			            $scope.paramBaseObj.in_account_date = data.Message.IN_ACCOUNT_DATE;
			            $scope.paramBaseObj.out_account_date = data.Message.OUT_ACCOUNT_DATE;
			            $scope.paramBaseObj.store_address = data.Message.STORE_ADDRESS;
			            $scope.paramBaseObj.maintain_period = data.Message.MAINTAIN_PERIOD;

			            $scope.paramBaseObj.is_assets = data.Message.IS_ASSETS;
			            $scope.paramBaseObj.is_depr = data.Message.IS_DEPR;
			            $scope.paramBaseObj.is_large_me = data.Message.IS_LARGE_ME;
			            $scope.paramBaseObj.is_affix = data.Message.IS_AFFIX;
			            $scope.paramBaseObj.is_metering = data.Message.IS_METERING;
			            $scope.paramBaseObj.is_self_restraint = data.Message.IS_SELF_RESTRAINT;

			            $scope.paramBaseObj.ownership_type_id = data.Message.OWNERSHIP_TYPE_ID==null?"": data.Message.OWNERSHIP_TYPE_ID.trim();
			            $scope.paramBaseObj.subjection_dept_id = data.Message.SUBJECTION_DEPT_ID;
			            $scope.dept.param.name = $scope.dept.param.condition = data.Message.SUBJECTION_DEPT_ID_NAME;
			            $scope.paramBaseObj.custody_dept_id_name = data.Message.CUSTODY_DEPT_ID_NAME;
			            $scope.paramBaseObj.custody_user_id_name = data.Message.CUSTODY_USER_ID_NAME;
			            $scope.paramBaseObj.custody_level_id =data.Message.CUSTODY_LEVEL_ID==null?"": data.Message.CUSTODY_LEVEL_ID.trim();
			            $scope.paramBaseObj.using_dept_id_name = data.Message.USING_DEPT_ID_NAME;
			            $scope.paramBaseObj.using_user_id_name = data.Message.USING_USER_ID_NAME;
			            $scope.paramBaseObj.use_state = data.Message.USE_STATE==null?"":data.Message.USE_STATE.trim();
			            $scope.paramBaseObj.biz_type_id =data.Message.BIZ_TYPE_ID==null?"": data.Message.BIZ_TYPE_ID.trim();

			            $scope.paramBaseObj.operating_machine_type_id = data.Message.OPERATING_MACHINE_TYPE_ID==null?"":data.Message.OPERATING_MACHINE_TYPE_ID.trim();
			            $scope.paramBaseObj.machine_manage_type_id =data.Message.MACHINE_MANAGE_TYPE_ID==null?"": data.Message.MACHINE_MANAGE_TYPE_ID.trim();
			            $scope.paramBaseObj.spell_code = data.Message.SPELL_CODE;
			            $scope.paramBaseObj.five_stroke_code = data.Message.FIVE_STROKE_CODE;
			            $scope.paramBaseObj.international_code = data.Message.INTERNATIONAL_CODE;
			            $scope.paramBaseObj.custom_code = data.Message.CUSTOM_CODE;

			            $scope.paramBaseObj.call_code = data.Message.CALL_CODE;
			            $scope.paramBaseObj.file_code = data.Message.FILE_CODE;
			            $scope.paramBaseObj.contract_code = data.Message.CONTRACT_CODE;
			            $scope.paramBaseObj.licence_code = data.Message.LICENCE_CODE;
			            $scope.paramBaseObj.maintain_contact = data.Message.MAINTAIN_CONTACT;
			            $scope.paramBaseObj.original_value = data.Message.ORIGINAL_VALUE;
			            $scope.paramBaseObj.net_value = data.Message.NET_VALUE;
			            $scope.paramBaseObj.net_amount = data.Message.NET_AMOUNT;
			            $scope.paramBaseObj.rudimental_value = data.Message.RUDIMENTAL_VALUE;
			            $scope.paramBaseObj.rudimental_value_ratio = data.Message.RUDIMENTAL_VALUE_RATIO;
			            $scope.paramBaseObj.predict_net_rudimental_value = data.Message.PREDICT_NET_RUDIMENTAL_VALUE;
			            $scope.paramBaseObj.add_value = data.Message.ADD_VALUE;
			            $scope.paramBaseObj.depr_type_id =data.Message.DEPR_TYPE_ID==null?"": data.Message.DEPR_TYPE_ID.trim();
			            $scope.paramBaseObj.depr_year_amount = data.Message.DEPR_YEAR_AMOUNT;


			            $scope.paramBaseObj.acquire_ownership_type_id =data.Message.ACQUIRE_OWNERSHIP_TYPE_ID==null?"": data.Message.ACQUIRE_OWNERSHIP_TYPE_ID.trim();
			            $scope.paramBaseObj.acquire_use_type_id =data.Message.ACQUIRE_USE_TYPE_ID==null?"": data.Message.ACQUIRE_USE_TYPE_ID.trim();
			            $scope.paramBaseObj.value_type_id = data.Message.VALUE_TYPE_ID==null?"": data.Message.VALUE_TYPE_ID.trim();
			            $scope.paramBaseObj.finance_type_id =data.Message.FINANCE_TYPE_ID==null?"": data.Message.FINANCE_TYPE_ID.trim();
			            $scope.paramBaseObj.ref_dept_id = data.Message.REF_DEPT_ID;
			            $scope.less.param.name = $scope.less.param.condition = data.Message.REF_DEPT_ID_NAME;
			            $scope.paramBaseObj.ref_price = data.Message.REF_PRICE;

			            $scope.paramBaseObj.economic_use_type_id =data.Message.ECONOMIC_USE_TYPE_ID==null?"": data.Message.ECONOMIC_USE_TYPE_ID.trim();
			            $scope.paramBaseObj.purchase_type_id =data.Message.PURCHASE_TYPE_ID==null?"": data.Message.PURCHASE_TYPE_ID.trim();
			            $scope.paramBaseObj.capital_source_type_id =data.Message.CAPITAL_SOURCE_TYPE_ID==null?"": data.Message.CAPITAL_SOURCE_TYPE_ID.trim();
			            $scope.paramBaseObj.prd_date = data.Message.PRD_DATE;
			            $scope.paramBaseObj.maintenance_period_date = data.Message.MAINTENANCE_PERIOD_DATE;
			            $scope.paramBaseObj.vehicle_code = data.Message.VEHICLE_CODE;
			            $scope.paramBaseObj.vehicle_use_type_id = data.Message.VEHICLE_USE_TYPE_ID==null?"": data.Message.VEHICLE_USE_TYPE_ID.trim();
			            $scope.paramBaseObj.energy_type_id =data.Message.ENERGY_TYPE_ID==null?"": data.Message.ENERGY_TYPE_ID.trim();
			            $scope.paramBaseObj.brand_name = data.Message.BRAND_NAME;

                        
			            $scope.paramBaseObj.prd_id = data.Message.PRD_ID;
			            $scope.prd.param.name = $scope.prd.param.condition = data.Message.PRD_ID_NAME;
			            $scope.paramBaseObj.prd_code = data.Message.PRD_CODE;
			            $scope.paramBaseObj.provider_id = data.Message.PROVIDER_ID;
			            $scope.prv.param.name = $scope.prv.param.condition = data.Message.PROVIDER_ID_NAME;
			            $scope.paramBaseObj.prd_place_type_id =data.Message.PRD_PLACE_TYPE_ID==null?"": data.Message.PRD_PLACE_TYPE_ID.trim();
			            $scope.paramBaseObj.nationality_id =data.Message.NATIONALITY_ID==null?"": data.Message.NATIONALITY_ID.trim();

			            $scope.paramBaseObj.picture = data.Message.PICTURE;
			            $scope.paramBaseObj.printImg = data.Message.COMMENTS;

			        } else {
			            alert(data.Message)
			        }
			    })
			};


			$scope.saveBaseModel = function () {
			    if ($scope.paramBaseObj.assets_name == "" || $scope.paramBaseObj.assets_name == null) {
			        alert("请输入资产名称");
			        return;
			    }


			    $http({
			        method: "POST",
			        url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetseSave.ashx",
			        data: $scope.paramBaseObj
			    }).then(function (data) {
			        var data = data.data;
			        if (data.Succeed == 1) {
			            alert("保存成功");
			            $scope.paramObj.id = data.Message;
			            $scope.getBaseInfo();
			  
			        } else {
			            alert(data.Message)
			        }
			    })
			};


			$scope.auditBaseModel = function (v) {
			    var flag = confirm("是否确认审核？");
			    if (!flag) {
			        return false
			    }

			    if (v.id == "") {
			        alert("请先保存再审核！");
			        return;
			    }
			    else {
			        var list = [];
			        list.push(v.id);

			        $http({
			            method:"POST",
			            url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetseAudit.ashx",
			            data:list
			        }).then(function (data) {
			            var data =data.data;
			            if(data.Succeed == 1){
			                alert("审核成功");
			                $scope.getBaseInfo();
			            }else{
			                alert(data.Message)
			            }
			        })

			  
			    }
			}

			$scope.goBack = function () {
			    window.location.replace($scope.paramObj.history)
			};




           //设备类型
			$scope.type = ParamS($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCETypeList.ashx");
			$scope.type.showTabTh = ['分类编号', '分类名称'];
			$scope.type.showTabTb = ['CODE', 'NAME'];
			$scope.type.param = {
			    condition: ""
			};
			$scope.ParamObjType = {
			    type: ""
			};
			$scope.$watch('ParamObjType', function (n, o) {
			    if (n != undefined) {
			        $scope.paramBaseObj.machine_type_id = n.type;

			    }
			}, true);
           
            //单位
			$scope.unit = ParamS($rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx");
			$scope.unit.showTabTh = ['编号', '名称'];
			$scope.unit.showTabTb = ['code', 'name'];
			$scope.unit.param = {
			    parent: "MCE_0004"
			};

			$scope.ParamObjUnit = {
			    unit: ""
			};
			$scope.$watch('ParamObjUnit', function (n, o) {
			    if (n != undefined) {
			        $scope.paramBaseObj.unit_id = n.unit;

			    }
			}, true);


		    //所属部门
			$scope.dept = ParamS($rootScope.baseUrl + "service/mtr/Srv_MTR_DeptList.ashx");
			$scope.dept.showTabTh = ['编号', '名称', '院区'];
			$scope.dept.showTabTb = ['code', 'name', 'areaName'];
			$scope.dept.param = {
			    is_area: "1",
			    condition: ""
			};

			$scope.ParamObjDept = {
			    dept: ""
			};
			$scope.$watch('ParamObjDept', function (n, o) {
			    if (n != undefined) {
			        $scope.paramBaseObj.subjection_dept_id = n.dept;

			    }
			}, true);



		    //生产厂家
			$scope.prd = ParamS($rootScope.baseUrl + "service/mtr/Srv_MTR_PrvList.ashx");
			$scope.prd.showTabTh = ['编号', '名称'];
			$scope.prd.showTabTb = ['code', 'name'];
			$scope.prd.param = {
			    type: "00340003"
			};
			$scope.ParamObjPrd = {
			    prd: ""
			};
			$scope.$watch('ParamObjPrd', function (n, o) {
			    if (n != undefined) {
			        $scope.paramBaseObj.prd_id = n.prd;

			    }
			}, true);



		    //供应商
			$scope.prv = ParamS($rootScope.baseUrl + "service/mtr/Srv_MTR_PrvList.ashx");
			$scope.prv.showTabTh = ['编号', '名称'];
			$scope.prv.showTabTb = ['code', 'name'];
			$scope.prv.param = {
			    type: "00340005"
			};
			$scope.ParamObjPrv = {
			    prv: ""
			};
			$scope.$watch('ParamObjPrv', function (n, o) {
			    if (n != undefined) {
			        $scope.paramBaseObj.provider_id = n.prv;

			    }
			}, true);



		    //出租方/出借方
			$scope.less = ParamS($rootScope.baseUrl + "service/mtr/Srv_MTR_PrvList.ashx");
			$scope.less.showTabTh = ['编号', '名称'];
			$scope.less.showTabTb = ['code', 'name'];
	
			$scope.ParamObjLess = {
			    less: ""
			};
			$scope.$watch('ParamObjLess', function (n, o) {
			    if (n != undefined) {
			        $scope.paramBaseObj.ref_dept_id = n.less;

			    }
			}, true);

            //资产状态
			$scope.assetStateList = [];
			$scope.getAssetStateList = function () {
			    $http({
			        method: "GET",
			        url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=0053&limit=10000"
			    }).then(function (data) {
			        var data = data.data;
			        if (data.Succeed == 1) {
			            $scope.assetStateList = data.Message.rows
			        } else {
			            alert(data.Message)
			        }
			    })
			};

            //卡片类型
			$scope.cardTypeList = [];
			$scope.getCardTypeList = function () {
			    $http({
			        method: "GET",
			        url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=0068&limit=10000"
			    }).then(function (data) {
			        var data = data.data;
			        if (data.Succeed == 1) {
			            $scope.cardTypeList = data.Message.rows
			        } else {
			            alert(data.Message)
			        }
			    })
			};


		    //使用状态
			$scope.useStateList = [];
			$scope.getUseStateList = function () {
			    $http({
			        method: "GET",
			        url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=0054&limit=10000"
			    }).then(function (data) {
			        var data = data.data;
			        if (data.Succeed == 1) {
			            $scope.useStateList = data.Message.rows
			        } else {
			            alert(data.Message)
			        }
			    })
			};



		    //权属发信
			$scope.ownerShipList = [];
			$scope.getOwnerShipList = function () {
			    $http({
			        method: "GET",
			        url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=0059&limit=10000"
			    }).then(function (data) {
			        var data = data.data;
			        if (data.Succeed == 1) {
			            $scope.ownerShipList = data.Message.rows
			        } else {
			            alert(data.Message)
			        }
			    })
			};


		    //保管等级
			$scope.custodyLevelList = [];
			$scope.getCustodyLevelList = function () {
			    $http({
			        method: "GET",
			        url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=0048&limit=10000"
			    }).then(function (data) {
			        var data = data.data;
			        if (data.Succeed == 1) {
			            $scope.custodyLevelList = data.Message.rows
			        } else {
			            alert(data.Message)
			        }
			    })
			};

		    //业务类型
			$scope.bizTypeList = [];
			$scope.getBizTypeList = function () {
			    $http({
			        method: "GET",
			        url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=0051&limit=10000"
			    }).then(function (data) {
			        var data = data.data;
			        if (data.Succeed == 1) {
			            $scope.bizTypeList = data.Message.rows
			        } else {
			            alert(data.Message)
			        }
			    })
			};


		    //经营设备类型
			$scope.operatingMachineTypeList = [];
			$scope.getOperatingMachineTypeList = function () {
			    $http({
			        method: "GET",
			        url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=0050&limit=10000"
			    }).then(function (data) {
			        var data = data.data;
			        if (data.Succeed == 1) {
			            $scope.operatingMachineTypeList = data.Message.rows
			        } else {
			            alert(data.Message)
			        }
			    })
			};

		    //设备管理类型
			$scope.machineManageTypeList = [];
			$scope.getMachineManageTypeList = function () {
			    $http({
			        method: "GET",
			        url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=0049&limit=10000"
			    }).then(function (data) {
			        var data = data.data;
			        if (data.Succeed == 1) {
			            $scope.machineManageTypeList = data.Message.rows
			        } else {
			            alert(data.Message)
			        }
			    })
			};

		    //获得使用权方式
			$scope.ownerShipTpeList = [];
			$scope.getOwnerShipTpeList = function () {
			    $http({
			        method: "GET",
			        url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=0061&limit=10000"
			    }).then(function (data) {
			        var data = data.data;
			        if (data.Succeed == 1) {
			            $scope.ownerShipTpeList = data.Message.rows
			        } else {
			            alert(data.Message)
			        }
			    })
			};


		    //使用方式
			$scope.useTpeList = [];
			$scope.getUseTpeList = function () {
			    $http({
			        method: "GET",
			        url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=0060&limit=10000"
			    }).then(function (data) {
			        var data = data.data;
			        if (data.Succeed == 1) {
			            $scope.useTpeList = data.Message.rows
			        } else {
			            alert(data.Message)
			        }
			    })
			};


		    //价值类型
			$scope.valueTpeList = [];
			$scope.getValueTpeList = function () {
			    $http({
			        method: "GET",
			        url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=0052&limit=10000"
			    }).then(function (data) {
			        var data = data.data;
			        if (data.Succeed == 1) {
			            $scope.valueTpeList = data.Message.rows
			        } else {
			            alert(data.Message)
			        }
			    })
			};

		    //财政编制类型
			$scope.financeTypeList = [];
			$scope.getFinanceTypeList = function () {
			    $http({
			        method: "GET",
			        url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=0063&limit=10000"
			    }).then(function (data) {
			        var data = data.data;
			        if (data.Succeed == 1) {
			            $scope.financeTypeList = data.Message.rows
			        } else {
			            alert(data.Message)
			        }
			    })
			};

		    //用途
			$scope.economicUseTypeList = [];
			$scope.getEconomicUseTypeList = function () {
			    $http({
			        method: "GET",
			        url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=0047&limit=10000"
			    }).then(function (data) {
			        var data = data.data;
			        if (data.Succeed == 1) {
			            $scope.economicUseTypeList = data.Message.rows
			        } else {
			            alert(data.Message)
			        }
			    })
			};


		    //购入方式
			$scope.purchaseTypeList = [];
			$scope.getPurchaseTypeList = function () {
			    $http({
			        method: "GET",
			        url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=0055&limit=10000"
			    }).then(function (data) {
			        var data = data.data;
			        if (data.Succeed == 1) {
			            $scope.purchaseTypeList = data.Message.rows
			        } else {
			            alert(data.Message)
			        }
			    })
			};


		    //购入方式
			$scope.purchaseTypeList = [];
			$scope.getPurchaseTypeList = function () {
			    $http({
			        method: "GET",
			        url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=0063&limit=10000"
			    }).then(function (data) {
			        var data = data.data;
			        if (data.Succeed == 1) {
			            $scope.purchaseTypeList = data.Message.rows
			        } else {
			            alert(data.Message)
			        }
			    })
			};

            //资金来源
			$scope.capitalResourceList = [];
			$scope.getCapitalResourceList = function () {
			    $http({
			        method: "GET",
			        url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=0056&limit=10000"
			    }).then(function (data) {
			        var data = data.data;
			        if (data.Succeed == 1) {
			            $scope.capitalResourceList = data.Message.rows
			        } else {
			            alert(data.Message)
			        }
			    })
			};


		    //车辆用途
			$scope.vehicleUseTypeList = [];
			$scope.getVehicleUseTypeList = function () {
			    $http({
			        method: "GET",
			        url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=0064&limit=10000"
			    }).then(function (data) {
			        var data = data.data;
			        if (data.Succeed == 1) {
			            $scope.vehicleUseTypeList = data.Message.rows
			        } else {
			            alert(data.Message)
			        }
			    })
			};


		    //能源类型
			$scope.energyTypList = [];
			$scope.getEnergyTypList = function () {
			    $http({
			        method: "GET",
			        url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=0062&limit=10000"
			    }).then(function (data) {
			        var data = data.data;
			        if (data.Succeed == 1) {
			            $scope.energyTypList = data.Message.rows
			        } else {
			            alert(data.Message)
			        }
			    })
			};



		    //国别地区
			$scope.nationalityList = [];
			$scope.getNationalityListList = function () {
			    $http({
			        method: "GET",
			        url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=0065&limit=10000"
			    }).then(function (data) {
			        var data = data.data;
			        if (data.Succeed == 1) {
			            $scope.nationalityList = data.Message.rows
			        } else {
			            alert(data.Message)
			        }
			    })
			};


		    //设备产地
			$scope.prdPlaceTypeList = [];
			$scope.getPrdPlaceTypeList = function () {
			    $http({
			        method: "GET",
			        url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=0057&limit=10000"
			    }).then(function (data) {
			        var data = data.data;
			        if (data.Succeed == 1) {
			            $scope.prdPlaceTypeList = data.Message.rows
			        } else {
			            alert(data.Message)
			        }
			    })
			};

		    //折旧方式
			$scope.deprTypeeList = [];
			$scope.getDeprTypeeList = function () {
			    $http({
			        method: "GET",
			        url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCEAssetsDeprTypeList.ashx"
			    }).then(function (data) {
			        var data = data.data;
			        if (data.Succeed == 1) {
			            $scope.deprTypeeList = data.Message
			        } else {
			            alert(data.Message)
			        }
			    })
			};


			$scope.getAssetStateList();
			$scope.getCardTypeList();
			$scope.getUseStateList();
			$scope.getOwnerShipList();
			//$scope.getCustodyLevelList
			$scope.getBizTypeList();
			$scope.getOperatingMachineTypeList();
			$scope.getMachineManageTypeList();
			$scope.getOwnerShipTpeList();
			$scope.getCustodyLevelList();
			$scope.getUseTpeList();
			$scope.getValueTpeList();
			$scope.getFinanceTypeList();
			$scope.getEconomicUseTypeList()
			$scope.getPurchaseTypeList();
			$scope.getCapitalResourceList();
			$scope.getVehicleUseTypeList();
			$scope.getEnergyTypList();
			$scope.getNationalityListList();
			$scope.getPrdPlaceTypeList();
			$scope.getDeprTypeeList();

			if ($scope.paramObj.id != '' && $scope.paramObj.id != null) {
			    $scope.getBaseInfo();
			}

		}])
	.controller("enclosure", ['$scope', '$http', '$rootScope', '$location', "ParamS", "ParamService", "InputschangeState",
		function ($scope, $http, $rootScope, $location, ParamS, ParamService, InputschangeState) {
		    //	附件信息

		    if ($scope.paramObj.id == null || $scope.paramObj.id == '') {
		        alert("请先录入并保存基本信息");
		        document.getElementById("menuBaseInfo").click();
		        return;
		    }

		    var vAsset_ID = $scope.paramObj.id;


		    $scope.affixList = [];


		    $scope.createAffixModel = function () {
		        return {
		            id: "",
		            assets_id: vAsset_ID,
		            code: "",
		            name: "",
		            spec: "",
		            amount: "",
		            comments: "",
		            barcode: "",
		            audit_state: 1,
		            listFileName: []
		        }
		    };

		    $scope.paramAffixObj = {
		        id: vAsset_ID,
		        condition: ""
		    };
		 
		    $scope.getAffixList = function () {
		        var param = ParamService.comParam(1, 10000, $scope.paramAffixObj);
		        $http({
		            method: "GET",
		            url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCEAssetsAffixList.ashx" + param
		        }).then(function (data) {
		            var data = data.data;
		            if (data.Succeed == 1) {
		                $scope.affixList = [];
		                for (var i = 0; i < data.Message.length; i++) {
		                    $scope.affixList.push($scope.createAffixModel());
		                    $scope.affixList[i].id = data.Message[i].ID;
		                    $scope.affixList[i].assets_id = data.Message[i].ASSETS_ID;
		                    $scope.affixList[i].code = data.Message[i].CODE;
		                    $scope.affixList[i].name = data.Message[i].NAME;
		                    $scope.affixList[i].spec = data.Message[i].SPEC;
		                    $scope.affixList[i].amount = data.Message[i].AMOUNT;
		                    $scope.affixList[i].comments = data.Message[i].COMMENTS;
		                    $scope.affixList[i].barcode = data.Message[i].BACKUP2;
		                    $scope.affixList[i].audit_state = data.Message[i].AUDIT_STATE;

		                    if (data.Message[i].BACKUP1 != "") {
		                        var arrAttachFile = data.Message[i].BACKUP1.split(',');
		                        if (arrAttachFile.length > 0) {
		                            for (var j = 0; j < arrAttachFile.length; j++) {
		                                var arrFullFile = arrAttachFile[j].split('/');

		                                var objFile = new Object();
		                                objFile.saveName = arrFullFile[0];
		                                objFile.fileName = arrFullFile[1];

		                                $scope.affixList[i].listFileName.push(objFile);
		                            }
		                        }
		                    }

		                }

		                if ($scope.affixList.length == 0) {
		                    $scope.affixList.push($scope.createAffixModel());
		                }
		             
		            } else {
		                alert(data.Message)
		            }
		        })
		    };


		    $scope.addModel = function () {
		        $scope.affixList.push($scope.createAffixModel());

		    }


		    $scope.saveModel = function (v) {
		        if (v.name == "" || v.name == null) {
		            alert("请输入名称")
		            return false
		        }

		        if (v.spec == "" || v.spec == null) {
		            alert("请输入规格")
		            return false
		        }

		        if (v.amount * 1 < 0 || isNaN(v.amount * 1)) {
		            alert('请输入正确的数量');
		            return false
		        }

		        //验证
		        $http.post($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetsAffixSave.ashx", v).success(function (data) {
		            if (data.Succeed == 1) {
		                alert("保存成功！");
		                $scope.getAffixList();
		            } else {
		                alert(data.Message + "保存失败！");
		            }
		        })
		    };

		    $scope.delModel = function (v) {
		        var flag = confirm("是否确认删除？");
		        if (!flag) {
		            return false
		        }

		        if (v.id == "") {
		            $scope.getAffixList();
		        }
		        else {
		            $http.post($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetsAffixDelete.ashx", v.id).success(function (data) {
		                if (data.Succeed == 1) {
		                    alert("删除成功！");
		                    $scope.getAffixList();
		                } else {
		                    alert(data.Message + "删除失败！");
		                }
		            })
		        }
		    }



		    $scope.auditModel = function (v) {
		        var flag = confirm("是否确认审核？");
		        if (!flag) {
		            return false
		        }

		        if (v.id == "") {
		            alert("请先保存再审核！");
		            return;
		        }
		        else {
		            $http.post($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetsAffixAudit.ashx", v.id).success(function (data) {
		                if (data.Succeed == 1) {
		                    alert("审核成功！");
		                    $scope.getAffixList();
		                } else {
		                    alert(data.Message + "审核失败！");
		                }
		            })
		        }
		    }

		    $scope.printCode = function () {
		        $(".img").print({
		            globalStyles: true,
		            mediaPrint: false,
		            stylesheet: null,
		            noPrintSelector: ".no-print",
		            iframe: true,
		            append: null,
		            prepend: null,
		            manuallyCopyFormValues: true,
		            deferred: $.Deferred(),
		            timeout: 1000,
		            title: null,
		            doctype: '<!doctype html>'
		        })
		    };

		    $scope.getAffixList();

		}])


	.controller("capital", ['$scope', '$http', '$rootScope', '$location', "ParamS", "ParamService", "InputschangeState", '$timeout',
		function ($scope, $http, $rootScope, $location, ParamS, ParamService, InputschangeState, $timeout) {
			//	资金信息
		  
		    if ($scope.paramObj.id == null || $scope.paramObj.id == '')
		    {
		        alert("请先录入并保存基本信息");
		        document.getElementById("menuBaseInfo").click();
		        return;
		    }

		    var vAsset_ID = $scope.paramObj.id;

         
			$scope.capitalList = [];
            
			$scope.createCapitalModel = function () {
			    return {
			        id: "",
			        assets_id: vAsset_ID,
			        capital_source_type_id: "",
			        ratio: "",
			        allot_money: "",
			        comments: "",
                    audit_state:1,
			        listFileName: []
			    }
			};

			$scope.paramCapitalObj = {
			    id: vAsset_ID,
			    condition: ""
			};
		//	$scope.mainPager = ParamService.getPager();

			$scope.getCapitalList = function () {
			    var param = ParamService.comParam(1, 10000, $scope.paramCapitalObj);
			    $http({
			        method: "GET",
			        url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCEAssetsCapitalList.ashx" + param
			    }).then(function (data) {
			        var data = data.data;
			        if (data.Succeed == 1) {
			            $scope.capitalList = [];
			            for (var i = 0; i < data.Message.length; i++) {
			                $scope.capitalList.push($scope.createCapitalModel());
			                $scope.capitalList[i].id = data.Message[i].ID;
			                $scope.capitalList[i].assets_id = data.Message[i].ASSETS_ID;
			                $scope.capitalList[i].capital_source_type_id =  data.Message[i].CAPITAL_SOURCE_TYPE_ID.trim();
			                $scope.capitalList[i].ratio = data.Message[i].RATIO;
			                $scope.capitalList[i].allot_money = data.Message[i].ALLOT_MONEY;
			                $scope.capitalList[i].comments = data.Message[i].COMMENTS;
			                $scope.capitalList[i].audit_state = data.Message[i].AUDIT_STATE;
                            
			                if(data.Message[i].BACKUP1!="")
			                {
			                    var arrAttachFile = data.Message[i].BACKUP1.split(',');
			                    if(arrAttachFile.length>0)
			                    {
			                        for (var j = 0; j < arrAttachFile.length; j++) {
			                            var arrFullFile = arrAttachFile[j].split('/');

			                            var objFile = new Object();
			                            objFile.saveName = arrFullFile[0];
			                            objFile.fileName = arrFullFile[1];

			                            $scope.capitalList[i].listFileName.push(objFile);
			                        }
			                    }
			                }
                            
			            }

			            if ($scope.capitalList.length == 0) {
			                $scope.addModel();
			            }
			            else {
			                $timeout(function () {

			                    //   var demo = document.getElementsByName("capitalEChart");
			                    var demo = $(".capitalEChart");
			                    //初始化实例

			                    for (var i = 0; i < demo.length; i++) {

			                        //图表数据
			                        $scope.EChartsOption = function () {
			                            var option = {
			                                tooltip: {
			                                    trigger: 'item',
			                                    formatter: "{a} <br/>{b} : {c} ({d}%)"
			                                },
			                                series: [{
			                                    name: '资金分配',
			                                    type: 'pie',
			                                    label: {
			                                        normal: {
			                                            show: false
			                                        }
			                                    },
			                                    data: [
                                                    { value: $scope.capitalList[i].ratio, name: '当前选择' },
                                                    { value: 100 - $scope.capitalList[i].ratio, name: '其他' }
			                                    ]
			                                }]
			                            };
			                            return option
			                        };

			                        var EChart = echarts.init(demo[i]);
			                        //实例配置options
			                        EChart.setOption($scope.EChartsOption());
			                    }
			                }, 200)
			            }

                        
			        } else {
			            alert(data.Message)
			        }
			    })
			};
            

			$scope.capitalResourceList = [];
			$scope.getCapitalResourceList = function () {
			    $http({
			        method: "GET",
			        url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=0056&limit=10000"
			    }).then(function (data) {
			        var data = data.data;
			        if (data.Succeed == 1) {
			            $scope.capitalResourceList = data.Message.rows
			        } else {
			            alert(data.Message)
			        }
			    })
			};

			$scope.addModel = function () {
			    $scope.capitalList.push($scope.createCapitalModel());


			    $timeout(function () {

			        // var demo = document.getElementsByName("capitalEChart");
			        var demo = $(".capitalEChart");
			        //初始化实例

			            //图表数据
			            $scope.EChartsOption = function () {
			                var option = {
			                    tooltip: {
			                        trigger: 'item',
			                        formatter: "{a} <br/>{b} : {c} ({d}%)"
			                    },
			                    series: [{
			                        name: '资金分配',
			                        type: 'pie',
			                        label: {
			                            normal: {
			                                show: false
			                            }
			                        },
			                        data: [
                                        { value: 0, name: '当前选择' },
                                        { value: 100 , name: '其他' }
			                        ]
			                    }]
			                };
			                return option
			            };

			            var EChart = echarts.init(demo[demo.length - 1]);
			            //实例配置options
			            EChart.setOption($scope.EChartsOption());
			        
			    }, 200)

			}

			$scope.delModel = function (v) {
			    var flag = confirm("是否确认删除？");
			    if (!flag) {
			        return false
			    }

			    if(v.id=="")
			    {
			        $scope.getCapitalList();
			    }
			    else
			    {
			        $http.post($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetsCapitalDelete.ashx", v.id).success(function (data) {
			            if (data.Succeed == 1) {
			                alert("删除成功！");
			                $scope.getCapitalList();
			            } else {
			                alert(data.Message + "删除失败！");
			            }
			        })
			    }
			}


			$scope.auditModel = function (v) {
			    var flag = confirm("是否确认审核？");
			    if (!flag) {
			        return false
			    }

			    if (v.id == "") {
			        alert("请先保存再审核！");
			        return;
			    }
			    else {
			        $http.post($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetsCapitalAudit.ashx", v.id).success(function (data) {
			            if (data.Succeed == 1) {
			                alert("审核成功！");
			                $scope.getCapitalList();
			            } else {
			                alert(data.Message + "审核失败！");
			            }
			        })
			    }
			}

			$scope.saveModel = function (v) {
			    if (v.capital_source_type_id == "" || v.capital_source_type_id == undefined) {
			        alert("请选择资金来源")
			        return false
			    }

			    if (v.ratio * 1 < 0 || isNaN(v.ratio * 1)) {
			        alert('请输入正确的分配比例');
			        return false
			    }

			    if (v.allot_money * 1 < 0 || isNaN(v.allot_money * 1)) {
			        alert('请输入正确的分配金额');
			        return false
			    }

			    //验证
			    $http.post($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetsCapitalSave.ashx", v).success(function (data) {
			        if (data.Succeed == 1) {
			            alert("保存成功！");
			            $scope.getCapitalList();
			        } else {
			            alert(data.Message + "保存失败！");
			        }
			    })
			};

			$scope.getCapitalList();
			$scope.getCapitalResourceList();
	



			//获取标签
			//var demo = document.getElementById("capitalEChart");

                
		}])
	.controller("depreciation", ['$scope', '$http', '$rootScope', '$location', "ParamS", "ParamService", "InputschangeState", '$timeout',
		function ($scope, $http, $rootScope, $location, ParamS, ParamService, InputschangeState, $timeout) {
			//	折旧信息

		    if ($scope.paramObj.id == null || $scope.paramObj.id == '') {
		        alert("请先录入并保存基本信息");
		        document.getElementById("menuBaseInfo").click();
		        return;
		    }

		    var vAsset_ID = $scope.paramObj.id;



		    $scope.paramBaseObj = {
		        using_dept_id: "",
		        using_dept_id_name: "",
		        original_value: 0,
		        net_value: 0,
		        depr_value: 0,
		    };



		    $scope.getBaseInfo = function () {
		        $http({
		            method: "GET",
		            url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCEAssetsDetail.ashx?id=" + $scope.paramObj.id
		        }).then(function (data) {
		            var data = data.data;
		            if (data.Succeed == 1) {
		                $scope.paramBaseObj.using_dept_id = data.Message.USING_DEPT_ID;
		                $scope.paramBaseObj.using_dept_id_name = data.Message.USING_DEPT_ID_NAME;
		           
		                $scope.paramBaseObj.original_value = data.Message.ORIGINAL_VALUE;
		                $scope.paramBaseObj.net_value = data.Message.NET_VALUE;

		                $scope.paramBaseObj.depr_value = $scope.paramBaseObj.original_value - $scope.paramBaseObj.net_value;



		                //折旧合计
		                $scope.EChartsLineOption = function () {
		                    var option = {
		                        tooltip: {
		                            trigger: 'axis',
		                            axisPointer: {            // 坐标轴指示器，坐标轴触发有效
		                                type: 'shadow'        // 默认为直线，可选为：'line' | 'shadow'
		                            }
		                        },
		                        legend: {
		                            data: ['累计折旧', '设备净值']
		                        },
		                        grid: {
		                            left: '3%',
		                            right: '4%',
		                            bottom: '3%',
		                            containLabel: true
		                        },
		                        xAxis: [
                                    {
                                        type: 'value',
                                        axisLabel: {
                                            show: true,
                                            interval: 'auto',
                                            formatter: function (value, index) {
                                                //	console.log(value);
                                                return value;
                                            }
                                        }
                                    }
		                        ],
		                        yAxis: [
                                    {
                                        type: 'category',
                                        axisTick: { show: false },
                                        data: [$scope.paramBaseObj.original_value, '元']
                                    }
		                        ],
		                        series: [
                                    {
                                        name: '设备净值',
                                        type: 'bar',
                                        stack: '总量',
                                        label: {
                                            normal: {
                                                show: true
                                            }
                                        },
                                        data: [$scope.paramBaseObj.net_value]
                                    },
                                    {
                                        name: '累计折旧',
                                        type: 'bar',
                                        stack: '总量',
                                        label: {
                                            normal: {
                                                show: true,
                                                position: 'left'
                                            }
                                        },
                                        data: [$scope.paramBaseObj.depr_value]
                                    }
		                        ]
		                    };
		                    return option
		                };
		                //获取标签
		                var demo1 = document.getElementById("depreciationAdd");
		                //初始化实例
		                var EChart1 = echarts.init(demo1);
		                //实例配置options
		                EChart1.setOption($scope.EChartsLineOption());


		            } else {
		                alert(data.Message)
		            }
		        })
		    };


		    //所属部门
		    $scope.conditionObjDept = {
		        condition: "",
		        is_area: 1
		    }
		    $scope.fkDeptPager = ParamService.getPager();
		    //查询
		    $scope.searcFkDeptList = function (curIndex,dept_name) {
		        $scope.conditionObjDept.condition = dept_name;
		        var param = ParamService.comParam(curIndex, $scope.fkDeptPager.pageSize, $scope.conditionObjDept);
		        $http.get($rootScope.baseUrl + "service/mtr/Srv_MTR_DeptList.ashx" + param).success(function (data) {
		            if (data.Succeed == 1) {
		                $scope.deptList = data.Message.rows;
		                $scope.fkDeptPager.setDataNum(data.Message.total);
		                $scope.fkDeptPager.setCurIndex(curIndex);
		            }
		        })
		    };
		    //选择模糊查询条件
		    $scope.selectDept = function (v,vDept) {
		        v.showList = false;
		        v.dept_id = vDept.id;
		        v.dept_name = vDept.name;
		    };

		    $scope.changeFkState = function () {
		        for (var i = 0; i < $scope.deprList.length; i++) {
		            $scope.deprList[i].showList = false;
		        }
		    }


		    $scope.deprList = [];

		    $scope.createDeprModel = function () {
		        return {
		            id: "",
		            assets_id: vAsset_ID,
		            dept_id: "",
		            dept_name: "",
                    showList:false,
		            ratio: "",
		            comments: "",

		            audit_state: 1,
		            listFileName: []
		        }
		    };

		    $scope.paramDeprObj = {
		        id: vAsset_ID,
		        condition: ""
		    };
		 
		    $scope.getDeprList = function () {
		        var param = ParamService.comParam(1, 10000, $scope.paramDeprObj);
		        $http({
		            method: "GET",
		            url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCEAssetsDeprAllocList.ashx" + param
		        }).then(function (data) {
		            var data = data.data;
		            if (data.Succeed == 1) {
		                $scope.deprList = [];
		                for (var i = 0; i < data.Message.length; i++) {
		                    $scope.deprList.push($scope.createDeprModel());
		                    $scope.deprList[i].id = data.Message[i].ID;
		                    $scope.deprList[i].assets_id = data.Message[i].ASSETS_ID;
		                    $scope.deprList[i].dept_id = data.Message[i].DEPT_ID.trim();
		                    $scope.deprList[i].dept_name = data.Message[i].DEPT_ID_NAME.trim();
		                    $scope.deprList[i].ratio = data.Message[i].RATIO;
		                    $scope.deprList[i].comments = data.Message[i].COMMENTS;
		                    $scope.deprList[i].audit_state = data.Message[i].AUDIT_STATE;


		                    if (data.Message[i].BACKUP1 != "") {
		                        var arrAttachFile = data.Message[i].BACKUP1.split(',');
		                        if (arrAttachFile.length > 0) {
		                            for (var j = 0; j < arrAttachFile.length; j++) {
		                                var arrFullFile = arrAttachFile[j].split('/');

		                                var objFile = new Object();
		                                objFile.saveName = arrFullFile[0];
		                                objFile.fileName = arrFullFile[1];

		                                $scope.deprList[i].listFileName.push(objFile);
		                            }
		                        }
		                    }

		                }

		                if ($scope.deprList.length == 0) {
		                    $scope.addModel();
		                }
		                else {
		                    $timeout(function () {

		                    //    var demo = document.getElementsByName("depreciationEChart");
		                        var demo = $(".depreciationEChart");
		                        //初始化实例

		                        for (var i = 0; i < demo.length; i++) {

		                            //图表数据
		                            $scope.EChartsOption = function () {
		                                var option = {
		                                    tooltip: {
		                                        trigger: 'item',
		                                        formatter: "{a} <br/>{b} : {c} ({d}%)"
		                                    },
		                                    series: [{
		                                        name: '折旧分配',
		                                        type: 'pie',
		                                        label: {
		                                            normal: {
		                                                show: false
		                                            }
		                                        },
		                                        data: [
                                                    { value: $scope.deprList[i].ratio, name: '当前选择' },
                                                    { value: 100 - $scope.deprList[i].ratio, name: '其他' }
		                                        ]
		                                    }]
		                                };
		                                return option
		                            };

		                            var EChart = echarts.init(demo[i]);
		                            //实例配置options
		                            EChart.setOption($scope.EChartsOption());
		                        }
		                    }, 200)
		                }


		            } else {
		                alert(data.Message)
		            }
		        })
		    };


		    $scope.conditionObjDeprHistory = {
		        id: vAsset_ID,
		    }
		    $scope.fkDeprHistoryPager = ParamService.getPager();
		    //查询
		    $scope.searcFkDeprHistoryList = function (curIndex, dept_name) {
		        var param = ParamService.comParam(curIndex, $scope.fkDeprHistoryPager.pageSize, $scope.conditionObjDeprHistory);
		        $http.get($rootScope.baseUrl + "service/mce/MCE_DEPR/Srv_MCE_GetMCEAssetsDeprHistoryList.ashx" + param).success(function (data) {
		            if (data.Succeed == 1) {
		                $scope.deprHistoryList = data.Message.rows;
		                $scope.fkDeprHistoryPager.setDataNum(data.Message.total);
		                $scope.fkDeprHistoryPager.setCurIndex(curIndex);
		            }
		        })
		    };


		    $scope.saveModel = function (v) {
		        if (v.dept_id == "" || v.dept_id == undefined) {
		            alert("请选择分配部门")
		            return false
		        }

		        if (v.ratio * 1 < 0 || isNaN(v.ratio * 1)) {
		            alert('请输入正确的分配比例');
		            return false
		        }

		        //验证
		        $http.post($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetsDeprAllocSave.ashx", v).success(function (data) {
		            if (data.Succeed == 1) {
		                alert("保存成功！");
		                $scope.getDeprList();
		            } else {
		                alert(data.Message + "保存失败！");
		            }
		        })
		    }



		    $scope.addModel = function () {
		        $scope.deprList.push($scope.createDeprModel());


		        $timeout(function () {

		           // var demo = document.getElementsByName("depreciationEChart");
		            var demo = $(".depreciationEChart");
		            //初始化实例

		            //图表数据
		            $scope.EChartsOption = function () {
		                var option = {
		                    tooltip: {
		                        trigger: 'item',
		                        formatter: "{a} <br/>{b} : {c} ({d}%)"
		                    },
		                    series: [{
		                        name: '折旧分配',
		                        type: 'pie',
		                        label: {
		                            normal: {
		                                show: false
		                            }
		                        },
		                        data: [
                                    { value: 0, name: '当前选择' },
                                    { value: 100, name: '其他' }
		                        ]
		                    }]
		                };
		                return option
		            };

		            var EChart = echarts.init(demo[demo.length - 1]);
		            //实例配置options
		            EChart.setOption($scope.EChartsOption());

		        }, 200)
		    }



		    $scope.delModel = function (v) {
		        var flag = confirm("是否确认删除？");
		        if (!flag) {
		            return false
		        }

		        if (v.id == "") {
		            $scope.getDeprList();
		        }
		        else {
		            $http.post($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetsDeprAllocDelete.ashx", v.id).success(function (data) {
		                if (data.Succeed == 1) {
		                    alert("删除成功！");
		                    $scope.getDeprList();
		                } else {
		                    alert(data.Message + "删除失败！");
		                }
		            })
		        }
		    }


		    $scope.auditModel = function (v) {
		        var flag = confirm("是否确认审核？");
		        if (!flag) {
		            return false
		        }

		        if (v.id == "") {
		            alert("请先保存再审核！");
		            return;
		        }
		        else {
		            $http.post($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetsDeprAllocAudit.ashx", v.id).success(function (data) {
		                if (data.Succeed == 1) {
		                    alert("审核成功！");
		                    $scope.getDeprList();
		                } else {
		                    alert(data.Message + "审核失败！");
		                }
		            })
		        }
		    }
            

			$scope.getBaseInfo();
			$scope.getDeprList();
			$scope.searcFkDeprHistoryList(1);
		}])
	.controller("imported", ['$scope', '$http', '$rootScope', '$location', "ParamS", "ParamService", "InputschangeState",
		function ($scope, $http, $rootScope, $location, ParamS, ParamService, InputschangeState) {
		    //	进口信息

		    if ($scope.paramObj.id == null || $scope.paramObj.id == '') {
		        alert("请先录入并保存基本信息");
		        document.getElementById("menuBaseInfo").click();
		        return;
		    }

		    var vAsset_ID = $scope.paramObj.id;


		    $scope.importList = [];


		    $scope.createImportModel = function () {
		        return {
		            id: "",
		            assets_id: vAsset_ID,

		            country_id: "",
		            purchase_money: "",
		            currency_id: "",
		            customs: "",
		            exemption_code: "",
		            approve_file_code: "",
		            foreign_currency_rate: "",
		            foreign_currency_source_id: "",

		            comments: "",
		            audit_state: 1,
		            listFileName: []
		        }
		    };

		    $scope.paramImportObj = {
		        id: vAsset_ID,
		        condition: ""
		    };

		    $scope.getImportist = function () {
		        var param = ParamService.comParam(1, 10000, $scope.paramImportObj);
		        $http({
		            method: "GET",
		            url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCEAssetsImportionList.ashx" + param
		        }).then(function (data) {
		            var data = data.data;
		            if (data.Succeed == 1) {
		                $scope.importList = [];
		                for (var i = 0; i < data.Message.length; i++) {
		                    $scope.importList.push($scope.createImportModel());
		                    $scope.importList[i].id = data.Message[i].ID;
		                    $scope.importList[i].assets_id = data.Message[i].ASSETS_ID;

		                    $scope.importList[i].country_id = data.Message[i].COUNTRY_ID.trim();
		                    $scope.importList[i].purchase_money = data.Message[i].PURCHASE_MONEY;
		                    $scope.importList[i].currency_id = data.Message[i].CURRENCY_ID.trim();
		                    $scope.importList[i].customs = data.Message[i].CUSTOMS;
		                    $scope.importList[i].exemption_code = data.Message[i].EXEMPTION_CODE;
		                    $scope.importList[i].approve_file_code = data.Message[i].APPROVE_FILE_CODE;
		                    $scope.importList[i].foreign_currency_rate = data.Message[i].FOREIGN_CURRENCY_RATE;
		                    $scope.importList[i].foreign_currency_source_id = data.Message[i].FOREIGN_CURRENCY_SOURCE_ID.trim();

		                    $scope.importList[i].comments = data.Message[i].COMMENTS;		                  
		                    $scope.importList[i].audit_state = data.Message[i].AUDIT_STATE;

		                    if (data.Message[i].BACKUP1 != "") {
		                        var arrAttachFile = data.Message[i].BACKUP1.split(',');
		                        if (arrAttachFile.length > 0) {
		                            for (var j = 0; j < arrAttachFile.length; j++) {
		                                var arrFullFile = arrAttachFile[j].split('/');

		                                var objFile = new Object();
		                                objFile.saveName = arrFullFile[0];
		                                objFile.fileName = arrFullFile[1];

		                                $scope.importList[i].listFileName.push(objFile);
		                            }
		                        }
		                    }

		                }

		                if ($scope.importList.length == 0) {
		                    $scope.importList.push($scope.createImportModel());
		                }

		            } else {
		                alert(data.Message)
		            }
		        })
		    };



		    $scope.countryList = [];
		    $scope.getCountryList = function () {
		        $http({
		            method: "GET",
		            url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=0065&limit=10000"
		        }).then(function (data) {
		            var data = data.data;
		            if (data.Succeed == 1) {
		                $scope.countryList = data.Message.rows
		            } else {
		                alert(data.Message)
		            }
		        })
		    };

		    $scope.currencyList = [];
		    $scope.getCurrencyList = function () {
		        $http({
		            method: "GET",
		            url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=0066&limit=10000"
		        }).then(function (data) {
		            var data = data.data;
		            if (data.Succeed == 1) {
		                $scope.currencyList = data.Message.rows
		            } else {
		                alert(data.Message)
		            }
		        })
		    };

		    $scope.fcsourceList = [];
		    $scope.getFcsourceList = function () {
		        $http({
		            method: "GET",
		            url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=0067&limit=10000"
		        }).then(function (data) {
		            var data = data.data;
		            if (data.Succeed == 1) {
		                $scope.fcsourceList = data.Message.rows
		            } else {
		                alert(data.Message)
		            }
		        })
		    };


		    $scope.saveModel = function (v) {
		        if (v.country_id == "" || v.country_id == undefined) {
		            alert("请选择贸易国别")
		            return false
		        }


		        //验证
		        $http.post($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetsIMPORTATIONSave.ashx", v).success(function (data) {
		            if (data.Succeed == 1) {
		                alert("保存成功！");
		                $scope.getImportist();
		            } else {
		                alert(data.Message + "保存失败！");
		            }
		        })
		    };


		    $scope.addModel = function () {
		        $scope.importList.push($scope.createImportModel());
		    }


		    $scope.delModel = function (v) {
		        var flag = confirm("是否确认删除？");
		        if (!flag) {
		            return false
		        }

		        if (v.id == "") {
		            $scope.getImportist();
		        }
		        else {
		            $http.post($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetsIMPORTATIONDelete.ashx", v.id).success(function (data) {
		                if (data.Succeed == 1) {
		                    alert("删除成功！");
		                    $scope.getImportist();
		                } else {
		                    alert(data.Message + "删除失败！");
		                }
		            })
		        }
		    }


		    $scope.auditModel = function (v) {
		        var flag = confirm("是否确认审核？");
		        if (!flag) {
		            return false
		        }

		        if (v.id == "") {
		            alert("请先保存再审核！");
		            return;
		        }
		        else {
		            $http.post($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetsIMPORTATIONAudit.ashx", v.id).success(function (data) {
		                if (data.Succeed == 1) {
		                    alert("审核成功！");
		                    $scope.getImportist();
		                } else {
		                    alert(data.Message + "审核失败！");
		                }
		            })
		        }
		    }


		    $scope.getImportist();
		    $scope.getCountryList();
		    $scope.getCurrencyList();
		    $scope.getFcsourceList();

		}])
	.controller("contract", ['$scope', '$http', '$rootScope', '$location', "ParamS", "ParamService", "InputschangeState",
		function ($scope, $http, $rootScope, $location, ParamS, ParamService, InputschangeState) {
		    //	合同信息
		    if ($scope.paramObj.id == null || $scope.paramObj.id == '') {
		        alert("请先录入并保存基本信息");
		        document.getElementById("menuBaseInfo").click();
		        return;
		    }

		    var vAsset_ID = $scope.paramObj.id;


		    $scope.contractList = [];


		    $scope.createContractModel = function () {
		        return {
		            id: "",
		            assets_id: vAsset_ID,

		            code: "",
		            name: "",
		            type_id: "",
		            money: 0,
		            first_party: "",
		            first_party_name: "",
		            showDeptList: false,
		            second_party: "",
		            second_party_name: "",
		            showPrvList:false,
		            sign_date: "",
		            expire_date: "",
		            state: 1,
		            state_name: "",

		            comments: "",
		            audit_state: 1,
		            listFileName: []
		        }
		    };

		    $scope.paramContractObj = {
		        id: vAsset_ID,
		        condition: ""
		    };

		    $scope.getContractist = function () {
		        var param = ParamService.comParam(1, 10000, $scope.paramContractObj);
		        $http({
		            method: "GET",
		            url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCEAssetsComtractList.ashx" + param
		        }).then(function (data) {
		            var data = data.data;
		            if (data.Succeed == 1) {
		                $scope.contractList = [];
		                for (var i = 0; i < data.Message.length; i++) {
		                    $scope.contractList.push($scope.createContractModel());
		                    $scope.contractList[i].id = data.Message[i].ID;
		                    $scope.contractList[i].assets_id = data.Message[i].ASSETS_ID;

		                    $scope.contractList[i].code = data.Message[i].CODE;
		                    $scope.contractList[i].name = data.Message[i].NAME;

		                    if (data.Message[i].TYPE_ID != null) {
		                        $scope.contractList[i].type_id = data.Message[i].TYPE_ID.trim();
		                    }
		                    $scope.contractList[i].money = data.Message[i].MONEY;
		                    $scope.contractList[i].first_party = data.Message[i].FIRST_PARTY;
		                    $scope.contractList[i].first_party_name = data.Message[i].FIRST_PARTY_NAME;

		                    $scope.contractList[i].second_party = data.Message[i].SECOND_PARTY;
		                    $scope.contractList[i].second_party_name = data.Message[i].SECOND_PARTY_NAME;

		                    $scope.contractList[i].sign_date = data.Message[i].SIGN_DATE;
		                    $scope.contractList[i].expire_date = data.Message[i].EXPIRE_DATE;
		                    $scope.contractList[i].state = data.Message[i].STATE;
		                    $scope.contractList[i].state_name = data.Message[i].STATE_NAME;

		                    $scope.contractList[i].comments = data.Message[i].COMMENTS;
		                    $scope.contractList[i].audit_state = data.Message[i].AUDIT_STATE;

		                    if (data.Message[i].BACKUP1 != "") {
		                        var arrAttachFile = data.Message[i].BACKUP1.split(',');
		                        if (arrAttachFile.length > 0) {
		                            for (var j = 0; j < arrAttachFile.length; j++) {
		                                var arrFullFile = arrAttachFile[j].split('/');

		                                var objFile = new Object();
		                                objFile.saveName = arrFullFile[0];
		                                objFile.fileName = arrFullFile[1];

		                                $scope.contractList[i].listFileName.push(objFile);
		                            }
		                        }
		                    }

		                }

		                if ($scope.contractList.length == 0) {
		                    $scope.contractList.push($scope.createContractModel());
		                }

		            } else {
		                alert(data.Message)
		            }
		        })
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


		    $scope.deptList = [];
		    //合同甲方
		    $scope.conditionObjDept = {
		        condition: "",
		        is_area: 1
		    }
		    $scope.fkDeptPager = ParamService.getPager();
		    //查询
		    $scope.searcFkDeptList = function (curIndex, dept_name) {
		        $scope.conditionObjDept.condition = dept_name;
		        var param = ParamService.comParam(curIndex, $scope.fkDeptPager.pageSize, $scope.conditionObjDept);
		        $http.get($rootScope.baseUrl + "service/mtr/Srv_MTR_DeptList.ashx" + param).success(function (data) {
		            if (data.Succeed == 1) {
		                $scope.deptList = data.Message.rows;
		                $scope.fkDeptPager.setDataNum(data.Message.total);
		                $scope.fkDeptPager.setCurIndex(curIndex);
		            }
		        })
		    };
		    //选择模糊查询条件
		    $scope.selectDept = function (v, vDept) {
		        v.showDeptList = false;
		        v.first_party = vDept.id;
		        v.first_party_name = vDept.name;
		    };

		    $scope.changeFkState = function () {
		        for (var i = 0; i < $scope.contractList.length; i++) {
		            $scope.contractList[i].showDeptList = false;
		        }
		    }


		    $scope.prvList = [];
		    //合同乙方
		    $scope.conditionObjPrv = {
		        condition: "",
		        type: "00340005"
		    }
		    $scope.fkPrvPager = ParamService.getPager();
		    //查询
		    $scope.searcFkPrvList = function (curIndex, prv_name) {
		        $scope.conditionObjPrv.condition = prv_name;
		        var param = ParamService.comParam(curIndex, $scope.fkPrvPager.pageSize, $scope.conditionObjPrv);
		        $http.get($rootScope.baseUrl + "service/mtr/Srv_MTR_PrvList.ashx" + param).success(function (data) {
		            if (data.Succeed == 1) {
		                $scope.prvList = data.Message.rows;
		                $scope.fkPrvPager.setDataNum(data.Message.total);
		                $scope.fkPrvPager.setCurIndex(curIndex);
		            }
		        })
		    };
		    //选择模糊查询条件
		    $scope.selectPrv = function (v, vPrv) {
		        v.showPrvList = false;
		        v.second_party = vPrv.id;
		        v.second_party_name = vPrv.name;
		    };

		    $scope.changeFkState = function () {
		        for (var i = 0; i < $scope.contractList.length; i++) {
		            $scope.contractList[i].showDeptList = false;
		            $scope.contractList[i].showPrvList = false;
		        }
		    }


		    $scope.saveModel = function (v) {
                /*
		        if (v.code == "" || v.code == undefined) {
		            alert("请输入合同编号")
		            return false
		        }
                */
		        if (v.name == "" || v.name == undefined) {
		            alert("请输入合同名称")
		            return false
		        }
		        if (v.first_party == "" || v.first_party == undefined) {
		            alert("请选择合同甲方")
		            return false
		        }
		        if (v.second_party == "" || v.second_party == undefined) {
		            alert("请选择合同乙方")
		            return false
		        }
		        if (v.money * 1 < 0 || isNaN(v.money * 1)) {
		            alert('请输入正确的合同金额');
		            return false
		        }

		        //验证
		        $http.post($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetsComtractSave.ashx", v).success(function (data) {
		            if (data.Succeed == 1) {
		                alert("保存成功！");
		                $scope.getContractist();
		            } else {
		                alert(data.Message + "保存失败！");
		            }
		        })
		    }


		    $scope.addModel = function () {
		        $scope.contractList.push($scope.createContractModel());
		    }


		    $scope.delModel = function (v) {
		        var flag = confirm("是否确认删除？");
		        if (!flag) {
		            return false
		        }

		        if (v.id == "") {
		            $scope.getContractist();
		        }
		        else {
		            $http.post($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetsComtractDelete.ashx", v.id).success(function (data) {
		                if (data.Succeed == 1) {
		                    alert("删除成功！");
		                    $scope.getContractist();
		                } else {
		                    alert(data.Message + "删除失败！");
		                }
		            })
		        }
		    }


		    $scope.auditModel = function (v) {
		        var flag = confirm("是否确认审核？");
		        if (!flag) {
		            return false
		        }

		        if (v.id == "") {
		            alert("请先保存再审核！");
		            return;
		        }
		        else {
		            $http.post($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetsComtractAudit.ashx", v.id).success(function (data) {
		                if (data.Succeed == 1) {
		                    alert("审核成功！");
		                    $scope.getContractist();
		                } else {
		                    alert(data.Message + "审核失败！");
		                }
		            })
		        }
		    }


		    $scope.stopModel = function (v) {
		        var flag = confirm("是否确认终止合同？");
		        if (!flag) {
		            return false
		        }

		        if (v.id == "") {
		            alert("请先保存再终止！");
		            return;
		        }
		        else {
		            $http.post($rootScope.baseUrl + "service/mce/mce_dict//Srv_MCE_MCEAssetsComtractStop.ashx", v.id).success(function (data) {
		                if (data.Succeed == 1) {
		                    alert("终止合同成功！");
		                    $scope.getContractist();
		                } else {
		                    alert(data.Message + "终止合同失败！");
		                }
		            })
		        }
		    }

		    $scope.continueModel = function (v) {
		        var flag = confirm("是否确认续签合同？");
		        if (!flag) {
		            return false
		        }

		        if (v.id == "") {
		            alert("请先保存再续签合同！");
		            return;
		        }
		        else {
		            $http.post($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetsComtractContinue.ashx", v.id).success(function (data) {
		                if (data.Succeed == 1) {
		                    alert("续签合同成功！");
		                    $scope.getContractist();
		                } else {
		                    alert(data.Message + "续签合同失败！");
		                }
		            })
		        }
		    }

		    $scope.getContractist();
		    $scope.getContractTypeList();
		  
		}])
	.controller("insurance", ['$scope', '$http', '$rootScope', '$location', "ParamS", "ParamService", "InputschangeState",
		function ($scope, $http, $rootScope, $location, ParamS, ParamService, InputschangeState) {
		    //	保险信息
		    if ($scope.paramObj.id == null || $scope.paramObj.id == '') {
		        alert("请先录入并保存基本信息");
		        document.getElementById("menuBaseInfo").click();
		        return;
		    }

		    var vAsset_ID = $scope.paramObj.id;


		    $scope.insuranceList = [];


		    $scope.createInsuranceModel = function () {
		        return {
		            id: "",
		            assets_id: vAsset_ID,

		            code: "",
		            name: "",
		            mater: "",
		            insurance_money: 0,
		            fee_money: 0,
		            insurance_unit: "",
		            insurance_unit_name: "",
		            showPrvList: false,
		            effect_date: "",
		            expire_date: "",
		            state: 1,
		            state_name: "",

		            comments: "",
		            audit_state: 1,
		            listFileName: []
		        }
		    };

		    $scope.paramInsuranceObj = {
		        id: vAsset_ID,
		        condition: ""
		    };

		    $scope.getInsuranceList = function () {
		        var param = ParamService.comParam(1, 10000, $scope.paramInsuranceObj);
		        $http({
		            method: "GET",
		            url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCEAssetsInsuranceList.ashx" + param
		        }).then(function (data) {
		            var data = data.data;
		            if (data.Succeed == 1) {
		                $scope.insuranceList = [];
		                for (var i = 0; i < data.Message.length; i++) {
		                    $scope.insuranceList.push($scope.createInsuranceModel());
		                    $scope.insuranceList[i].id = data.Message[i].ID;
		                    $scope.insuranceList[i].assets_id = data.Message[i].ASSETS_ID;

		                    $scope.insuranceList[i].code = data.Message[i].CODE;
		                    $scope.insuranceList[i].name = data.Message[i].NAME;
		                    $scope.insuranceList[i].mater = data.Message[i].MATER;

		                    $scope.insuranceList[i].insurance_money = data.Message[i].INSURANCE_MONEY;
		                    $scope.insuranceList[i].fee_money = data.Message[i].FEE_MONEY;

		                    $scope.insuranceList[i].insurance_unit = data.Message[i].INSURANCE_UNIT;
		                    $scope.insuranceList[i].insurance_unit_name = data.Message[i].INSURANCE_UNIT_NAME;

		                    $scope.insuranceList[i].effect_date = data.Message[i].EFFECT_DATE;
		                    $scope.insuranceList[i].expire_date = data.Message[i].EXPIRE_DATE;
		                    $scope.insuranceList[i].state = data.Message[i].STATE;
		                    $scope.insuranceList[i].state_name = data.Message[i].STATE_NAME;

		                    $scope.insuranceList[i].comments = data.Message[i].COMMENTS;
		                    $scope.insuranceList[i].audit_state = data.Message[i].AUDIT_STATE;

		                    if (data.Message[i].BACKUP1 != "") {
		                        var arrAttachFile = data.Message[i].BACKUP1.split(',');
		                        if (arrAttachFile.length > 0) {
		                            for (var j = 0; j < arrAttachFile.length; j++) {
		                                var arrFullFile = arrAttachFile[j].split('/');

		                                var objFile = new Object();
		                                objFile.saveName = arrFullFile[0];
		                                objFile.fileName = arrFullFile[1];

		                                $scope.insuranceList[i].listFileName.push(objFile);
		                            }
		                        }
		                    }
                            
		                }

		                if ($scope.insuranceList.length == 0) {
		                    $scope.insuranceList.push($scope.createInsuranceModel());
		                }

		            } else {
		                alert(data.Message)
		            }
		        })
		    };



		    $scope.prvList = [];
		    //承保单位
		    $scope.conditionObjPrv = {
		        condition: "",
		        type: "00340005"
		    }
		    $scope.fkPrvPager = ParamService.getPager();
		    //查询
		    $scope.searcFkPrvList = function (curIndex, prv_name) {
		        $scope.conditionObjPrv.condition = prv_name;
		        var param = ParamService.comParam(curIndex, $scope.fkPrvPager.pageSize, $scope.conditionObjPrv);
		        $http.get($rootScope.baseUrl + "service/mtr/Srv_MTR_PrvList.ashx" + param).success(function (data) {
		            if (data.Succeed == 1) {
		                $scope.prvList = data.Message.rows;
		                $scope.fkPrvPager.setDataNum(data.Message.total);
		                $scope.fkPrvPager.setCurIndex(curIndex);
		            }
		        })
		    };
		    //选择模糊查询条件
		    $scope.selectPrv = function (v, vPrv) {
		        v.showPrvList = false;
		        v.insurance_unit = vPrv.id;
		        v.insurance_unit_name = vPrv.name;
		    };

		    $scope.changeFkState = function () {
		        for (var i = 0; i < $scope.insuranceList.length; i++) {
		            $scope.insuranceList[i].showPrvList = false;
		        }
		    }


		    $scope.saveModel = function (v) {
		     /*
		        if (v.code == "" || v.code == undefined) {
		            alert("请输入保险单号")
		            return false
		        }
                */
		        if (v.name == "" || v.name == undefined) {
		            alert("请输入投保险种")
		            return false
		        }

		        if (v.insurance_money * 1 < 0 || isNaN(v.insurance_money * 1)) {
		            alert('请输入正确的保险金额');
		            return false
		        }

		        //验证
		        $http.post($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetsInsuranceSave.ashx", v).success(function (data) {
		            if (data.Succeed == 1) {
		                alert("保存成功！");
		                $scope.getInsuranceList();
		            } else {
		                alert(data.Message + "保存失败！");
		            }
		        })
		    }


		    $scope.addModel = function () {
		        $scope.insuranceList.push($scope.createInsuranceModel());
		    }


		    $scope.delModel = function (v) {
		        var flag = confirm("是否确认删除？");
		        if (!flag) {
		            return false
		        }

		        if (v.id == "") {
		            $scope.getInsuranceList();
		        }
		        else {
		            $http.post($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetsInsuranceDelete.ashx", v.id).success(function (data) {
		                if (data.Succeed == 1) {
		                    alert("删除成功！");
		                    $scope.getInsuranceList();
		                } else {
		                    alert(data.Message + "删除失败！");
		                }
		            })
		        }
		    }
            
		    $scope.auditModel = function (v) {
		        var flag = confirm("是否确认审核？");
		        if (!flag) {
		            return false
		        }

		        if (v.id == "") {
		            alert("请先保存再审核！");
		            return;
		        }
		        else {
		            $http.post($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetsInsuranceAudit.ashx", v.id).success(function (data) {
		                if (data.Succeed == 1) {
		                    alert("审核成功！");
		                    $scope.getInsuranceList();
		                } else {
		                    alert(data.Message + "审核失败！");
		                }
		            })
		        }
		    }


		    $scope.stopModel = function (v) {
		        var flag = confirm("是否确认过期？");
		        if (!flag) {
		            return false
		        }

		        if (v.id == "") {
		            alert("请先保存再过期止！");
		            return;
		        }
		        else {
		            $http.post($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetsInsuranceExpire.ashx", v.id).success(function (data) {
		                if (data.Succeed == 1) {
		                    alert("过期成功！");
		                    $scope.getInsuranceList();
		                } else {
		                    alert(data.Message + "过期失败！");
		                }
		            })
		        }
		    }

		    $scope.continueModel = function (v) {
		        var flag = confirm("是否确认续保？");
		        if (!flag) {
		            return false
		        }

		        if (v.id == "") {
		            alert("请先保存再续保！");
		            return;
		        }
		        else {
		            $http.post($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetsInsuranceContinue.ashx", v.id).success(function (data) {
		                if (data.Succeed == 1) {
		                    alert("续保成功！");
		                    $scope.getInsuranceList();
		                } else {
		                    alert(data.Message + "续保失败！");
		                }
		            })
		        }
		    }


		    $scope.getInsuranceList();

		}])
	.controller("circulation", ['$scope', '$http', '$rootScope', '$location', "ParamS", "ParamService", "InputschangeState",
		function ($scope, $http, $rootScope, $location, ParamS, ParamService, InputschangeState) {
		    //	流转信息
		    //	保险信息
		    if ($scope.paramObj.id == null || $scope.paramObj.id == '') {
		        alert("请先录入并保存基本信息");
		        document.getElementById("menuBaseInfo").click();
		        return;
		    }

		    var vAsset_ID = $scope.paramObj.id;

		    $scope.searchCirculation = function () {
		        $http.get($rootScope.baseUrl + "service/mce/MCE_STOCKDATA/Srv_MCE_GetMCEAssetsCirculation_Info.ashx?id=" + vAsset_ID).success(function (data) {
		            if (data.Succeed == 1) {
		                $scope.circulationInfo = data.Message;
		            }
		        })
		    };

		    $scope.searchCirculation();

		}])
	.controller("metering", ['$scope', '$http', '$rootScope', '$location', "ParamS", "ParamService", "InputschangeState",
		function ($scope, $http, $rootScope, $location, ParamS, ParamService, InputschangeState) {
		    //	计量信息
		    if ($scope.paramObj.id == null || $scope.paramObj.id == '') {
		        alert("请先录入并保存基本信息");
		        document.getElementById("menuBaseInfo").click();
		        return;
		    }

		    var vAsset_ID = $scope.paramObj.id;


		    $scope.meterList = [];


		    $scope.createMeterModel = function () {
		        return {
		            id: "",
		            assets_id: vAsset_ID,

		            code: "",
		            accuracy_class: "",
		            meter_class: "",
		            meter_type: "",
		            measure_range: "",
		            divid_value: "",
		            identification_cycle: 0,
		            next_identification: "",
		            time_zone: "",
		            is_force_sense: "",

		            state: 1,
		            state_name: "",

		            comments: "",
		            audit_state: 1,
		            listFileName: []
		        }
		    };

		    $scope.paramMeterObj = {
		        id: vAsset_ID,
		        condition: ""
		    };

		    $scope.getMeterList = function () {
		        var param = ParamService.comParam(1, 10000, $scope.paramMeterObj);
		        $http({
		            method: "GET",
		            url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCEAssetsMeterList.ashx" + param
		        }).then(function (data) {
		            var data = data.data;
		            if (data.Succeed == 1) {
		                $scope.meterList = [];
		                for (var i = 0; i < data.Message.length; i++) {
		                    $scope.meterList.push($scope.createMeterModel());
		                    $scope.meterList[i].id = data.Message[i].ID;
		                    $scope.meterList[i].assets_id = data.Message[i].ASSETS_ID;

		                    $scope.meterList[i].code = data.Message[i].CODE;
		                    $scope.meterList[i].accuracy_class = data.Message[i].ACCURACY_CLASS;
		                    $scope.meterList[i].meter_class =data.Message[i].METER_CLASS==null ?"": data.Message[i].METER_CLASS.trim();

		                    $scope.meterList[i].meter_type = data.Message[i].METER_TYPE == null ? "" : data.Message[i].METER_TYPE.trim();
		                    $scope.meterList[i].measure_range = data.Message[i].MEASURE_RANGE;

		                    $scope.meterList[i].divid_value = data.Message[i].DIVID_VALUE;
		                    $scope.meterList[i].identification_cycle = data.Message[i].IDENTIFICATION_CYCLE;

		                    $scope.meterList[i].next_identification = data.Message[i].NEXT_IDENTIFICATION;
		                    $scope.meterList[i].time_zone = data.Message[i].TIME_ZONE;
		                    $scope.meterList[i].is_force_sense = data.Message[i].IS_FORCE_SENSE;
		                 
		                    $scope.meterList[i].state = data.Message[i].STATE;
		                    $scope.meterList[i].state_name = data.Message[i].STATE_NAME;

		                    $scope.meterList[i].comments = data.Message[i].COMMENTS;
		                    $scope.meterList[i].audit_state = data.Message[i].AUDIT_STATE;

		                    if (data.Message[i].BACKUP1 != "") {
		                        var arrAttachFile = data.Message[i].BACKUP1.split(',');
		                        if (arrAttachFile.length > 0) {
		                            for (var j = 0; j < arrAttachFile.length; j++) {
		                                var arrFullFile = arrAttachFile[j].split('/');

		                                var objFile = new Object();
		                                objFile.saveName = arrFullFile[0];
		                                objFile.fileName = arrFullFile[1];

		                                $scope.meterList[i].listFileName.push(objFile);
		                            }
		                        }
		                    }

		                }

		                if ($scope.meterList.length == 0) {
		                    $scope.meterList.push($scope.createMeterModel());
		                }

		            } else {
		                alert(data.Message)
		            }
		        })
		    };


		    $scope.meterClassList = [];
		    $scope.getMeterClassList = function () {
		        $http({
		            method: "GET",
		            url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=COM_1007&limit=10000"
		        }).then(function (data) {
		            var data = data.data;
		            if (data.Succeed == 1) {
		                $scope.meterClassList = data.Message.rows
		            } else {
		                alert(data.Message)
		            }
		        })
		    };

		    $scope.meterTypeList = [];
		    $scope.getMeterTypeList = function () {
		        $http({
		            method: "GET",
		            url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=COM_1008&limit=10000"
		        }).then(function (data) {
		            var data = data.data;
		            if (data.Succeed == 1) {
		                $scope.meterTypeList = data.Message.rows
		            } else {
		                alert(data.Message)
		            }
		        })
		    };


		    $scope.saveModel = function (v) {
                /*
		        if (v.code == "" || v.code == undefined) {
		            alert("请输入计量编号")
		            return false
		        }
		       */

		        //验证
		        $http.post($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetsMeterSave.ashx", v).success(function (data) {
		            if (data.Succeed == 1) {
		                alert("保存成功！");
		                $scope.getMeterList();
		            } else {
		                alert(data.Message + "保存失败！");
		            }
		        })
		    }


		    $scope.addModel = function () {
		        $scope.meterList.push($scope.createMeterModel());
		    }


		    $scope.delModel = function (v) {
		        var flag = confirm("是否确认删除？");
		        if (!flag) {
		            return false
		        }

		        if (v.id == "") {
		            $scope.getMeterList();
		        }
		        else {
		            $http.post($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetsMeterDelete.ashx", v.id).success(function (data) {
		                if (data.Succeed == 1) {
		                    alert("删除成功！");
		                    $scope.getMeterList();
		                } else {
		                    alert(data.Message + "删除失败！");
		                }
		            })
		        }
		    }


		    $scope.auditModel = function (v) {
		        var flag = confirm("是否确认审核？");
		        if (!flag) {
		            return false
		        }

		        if (v.id == "") {
		            alert("请先保存再审核！");
		            return;
		        }
		        else {
		            $http.post($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetsMeterAudit.ashx", v.id).success(function (data) {
		                if (data.Succeed == 1) {
		                    alert("审核成功！");
		                    $scope.getMeterList();
		                } else {
		                    alert(data.Message + "审核失败！");
		                }
		            })
		        }
		    }


		    $scope.expireModel = function (v) {
		        var flag = confirm("是否确认过期？");
		        if (!flag) {
		            return false
		        }

		        if (v.id == "") {
		            alert("请先保存再过期！");
		            return;
		        }
		        else {
		            $http.post($rootScope.baseUrl + "service/mce/mce_dict//Srv_MCE_MCEAssetsMeterExpire.ashx", v.id).success(function (data) {
		                if (data.Succeed == 1) {
		                    alert("过期成功！");
		                    $scope.getMeterList();
		                } else {
		                    alert(data.Message + "过期失败！");
		                }
		            })
		        }
		    }

		    $scope.continueModel = function (v) {
		        var flag = confirm("是否确认续检？");
		        if (!flag) {
		            return false
		        }

		        if (v.id == "") {
		            alert("请先保存再续检！");
		            return;
		        }
		        else {
		            $http.post($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetsMeterContinue.ashx", v.id).success(function (data) {
		                if (data.Succeed == 1) {
		                    alert("续检成功！");
		                    $scope.getMeterList();
		                } else {
		                    alert(data.Message + "续检失败！");
		                }
		            })
		        }
		    }


		    $scope.getMeterList();
		    $scope.getMeterClassList();
		    $scope.getMeterTypeList();

		}])
	.controller("scrap", ['$scope', '$http', '$rootScope', '$location', "ParamS", "ParamService", "InputschangeState",
		function ($scope, $http, $rootScope, $location, ParamS, ParamService, InputschangeState) {
		    //	报废信息
		    if ($scope.paramObj.id == null || $scope.paramObj.id == '') {
		        alert("请先录入并保存基本信息");
		        document.getElementById("menuBaseInfo").click();
		        return;
		    }

		    var vAsset_ID = $scope.paramObj.id;

            /*
		    var vOriginal_value = 0;
		    var vNet_value = 0;

		    $scope.getBaseInfo = function () {
		        $http({
		            method: "GET",
		            url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCEAssetsDetail.ashx?id=" + $scope.paramObj.id
		        }).then(function (data) {
		            var data = data.data;
		            if (data.Succeed == 1) {
		              
		                vOriginal_value = data.Message.ORIGINAL_VALUE;
		                vNet_value = data.Message.NET_VALUE;

		            } else {
		                alert(data.Message)
		            }
		        })
		    };
            */

		    $scope.writeOffList = [];


		    $scope.createWriteOffModel = function () {
		        return {
		            id: "",
		            assets_id: vAsset_ID,

		            code: "",
		            finance_cycle: "",
		            create_date: "",
		            write_off_type_id: "",
		            write_off_cause_id: "",
		            original_value: 0,
		            net_value: 0,
		            rudimental_value: "",
		            income: "",
		          
		            comments: "",
		            audit_state: 1,
		            listFileName: []
		        }
		    };
            

		    $scope.paramWriteOfObj = {
		        id: vAsset_ID,
		        condition: ""
		    };

		    $scope.getWriteOffList = function () {
		        var param = ParamService.comParam(1, 10000, $scope.paramWriteOfObj);
		        $http({
		            method: "GET",
		            url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCEAssetsWriteOffList.ashx" + param
		        }).then(function (data) {
		            var data = data.data;
		            if (data.Succeed == 1) {
		                $scope.writeOffList = [];
		                for (var i = 0; i < data.Message.length; i++) {
		                    $scope.writeOffList.push($scope.createWriteOffModel());
		                    $scope.writeOffList[i].id = data.Message[i].ID;
		                    $scope.writeOffList[i].assets_id = data.Message[i].ASSETS_ID;

		                    $scope.writeOffList[i].code = data.Message[i].CODE;
		                    $scope.writeOffList[i].finance_cycle = data.Message[i].FINANCE_CYCLE;
		                    $scope.writeOffList[i].create_date = data.Message[i].CREATE_DATE;
		                 
		                    $scope.writeOffList[i].write_off_type_id = data.Message[i].WRITE_OFF_TYPE_ID == null ? "" : data.Message[i].WRITE_OFF_TYPE_ID.trim();

		                    $scope.writeOffList[i].write_off_cause_id = data.Message[i].WRITE_OFF_CAUSE_ID == null ? "" : data.Message[i].WRITE_OFF_CAUSE_ID.trim();
		                    $scope.writeOffList[i].original_value = data.Message[i].ORIGINAL_VALUE;

		                    $scope.writeOffList[i].net_value = data.Message[i].NET_VALUE;
		                    $scope.writeOffList[i].rudimental_value = data.Message[i].RUDIMENTAL_VALUE;

		                    $scope.writeOffList[i].income = data.Message[i].INCOME;
		                  
		                    $scope.writeOffList[i].comments = data.Message[i].COMMENTS;
		                    $scope.writeOffList[i].audit_state = data.Message[i].AUDIT_STATE;

		                    if (data.Message[i].BACKUP1 != "") {
		                        var arrAttachFile = data.Message[i].BACKUP1.split(',');
		                        if (arrAttachFile.length > 0) {
		                            for (var j = 0; j < arrAttachFile.length; j++) {
		                                var arrFullFile = arrAttachFile[j].split('/');

		                                var objFile = new Object();
		                                objFile.saveName = arrFullFile[0];
		                                objFile.fileName = arrFullFile[1];

		                                $scope.writeOffList[i].listFileName.push(objFile);
		                            }
		                        }
		                    }

		                }

		                if ($scope.writeOffList.length == 0) {
		                    $scope.writeOffList.push($scope.createWriteOffModel());
		                }

		            } else {
		                alert(data.Message)
		            }
		        })
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


		    $scope.saveModel = function (v) {
                /*
		        if (v.code == "" || v.code == undefined) {
		            alert("请输入报废单号")
		            return false
		        }
                */

		        if (v.finance_cycle == "" || v.finance_cycle == undefined) {
		            alert("请输入财务月份")
		            return false
		        }


		        //验证
		        $http.post($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetsWriteOffSave.ashx", v).success(function (data) {
		            if (data.Succeed == 1) {
		                alert("保存成功！");
		                $scope.getWriteOffList();
		            } else {
		                alert(data.Message + "保存失败！");
		            }
		        })
		    }


		    $scope.addModel = function () {
		        $scope.writeOffList.push($scope.createWriteOffModel());
		    }


		    $scope.delModel = function (v) {
		        var flag = confirm("是否确认删除？");
		        if (!flag) {
		            return false
		        }

		        if (v.id == "") {
		            $scope.getWriteOffList();
		        }
		        else {
		            $http.post($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetsWriteOffDelete.ashx", v.id).success(function (data) {
		                if (data.Succeed == 1) {
		                    alert("删除成功！");
		                    $scope.getWriteOffList();
		                } else {
		                    alert(data.Message + "删除失败！");
		                }
		            })
		        }
		    }


		    $scope.auditModel = function (v) {
		        var flag = confirm("是否确认审核？");
		        if (!flag) {
		            return false
		        }

		        if (v.id == "") {
		            alert("请先保存再审核！");
		            return;
		        }
		        else {
		            $http.post($rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_MCEAssetsWriteOffAudit.ashx", v.id).success(function (data) {
		                if (data.Succeed == 1) {
		                    alert("审核成功！");
		                    $scope.getWriteOffList();
		                } else {
		                    alert(data.Message + "审核失败！");
		                }
		            })
		        }
		    }

		  //  $scope.getBaseInfo();
		    $scope.getWriteOffList();
		    $scope.getWriteOffTypeListList();
		    $scope.getWriteOffCauseListList();

		}])
	.controller("maintenance", ['$scope', '$http', '$rootScope', '$location', "ParamS", "ParamService", "InputschangeState", '$timeout',
		function ($scope, $http, $rootScope, $location, ParamS, ParamService, InputschangeState,$timeout) {
			//	维保信息

		    if ($scope.paramObj.id == null || $scope.paramObj.id == '') {
		        alert("请先录入并保存基本信息");
		        document.getElementById("menuBaseInfo").click();
		        return;
		    }

           
		    var vAsset_ID = $scope.paramObj.id;


		    var vMtnFee = 0;
		    $scope.getBaseInfo = function () {
		        var vOriginal_value = 0;
		        var vNet_value = 0;

		        $http({
		            method: "GET",
		            url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCEAssetsDetail.ashx?id=" + $scope.paramObj.id
		        }).then(function (data) {
		            var data = data.data;
		            if (data.Succeed == 1) {
		          
		                vOriginal_value = data.Message.ORIGINAL_VALUE;
		                vNet_value = data.Message.NET_VALUE;



                        
		                $timeout(function () {
		                    //折旧合计
		                    $scope.EChartsLineOption = function () {
		                        var option = {
		                            color: ['#3398DB'],
		                            title: {
		                                text: '维保费用累计',
		                                textStyle: {
		                                    align: 'center'
		                                }
		                            },
		                            tooltip: {
		                                trigger: 'axis',
		                                axisPointer: {            // 坐标轴指示器，坐标轴触发有效
		                                    type: 'shadow'        // 默认为直线，可选为：'line' | 'shadow'
		                                }
		                            },
		                            grid: {
		                                left: '3%',
		                                right: '4%',
		                                bottom: '3%',
		                                containLabel: true
		                            },
		                            xAxis: [
                                        {
                                            type: 'category',
                                            data: ['原值', '净值', '维保费用'],
                                            axisTick: {
                                                alignWithLabel: true
                                            }
                                        }
		                            ],
		                            yAxis: [
                                        {
                                            type: 'value'
                                        }
		                            ],
		                            series: [
                                        {
                                            name: '直接访问',
                                            type: 'bar',
                                            barWidth: '60%',
                                            data: [vOriginal_value, vNet_value, vMtnFee]
                                        }
		                            ]
		                        };
		                        return option
		                    };
		                    //获取标签
		                    var demo1 = document.getElementById("depreciationAdd");
		                    //初始化实例
		                    var EChart1 = echarts.init(demo1);
		                    //实例配置options
		                    EChart1.setOption($scope.EChartsLineOption());

		                }, 500)
                        

		            } else {
		                alert(data.Message)
		            }
		        })
		    };


		    $scope.mtnlList = [];
		    $scope.paramMtnObj = {
		        id:vAsset_ID,
		        condition: ""
		    };

		    $scope.getMtnList = function () {
		        var param = ParamService.comParam(1, 10000, $scope.paramMtnObj);
		        $http({
		            method: "GET",
		            url: $rootScope.baseUrl + "service/mce/mce_mt/Srv_MCE_GetMCEAssetsMtnList.ashx" + param
		        }).then(function (data) {
		            var data = data.data;
		            if (data.Succeed == 1) {
		                $scope.mtnlList = data.Message;
		                if( $scope.mtnlList!=null &&  $scope.mtnlList.length>0)
		                {
		                    for(var i=0;i< $scope.mtnlList.length;i++)
		                    {
		                        vMtnFee = vMtnFee + $scope.mtnlList[i].MAINTAIN_MONEY;
		                    }
		                }

		            } else {
		                alert(data.Message)
		            }
		        })
		    };


		    $scope.deprHistoryList = [];
		    $scope.conditionObjDeprHistory = {
		        id: vAsset_ID,
		    }
		    $scope.fkDeprHistoryPager = ParamService.getPager();
		    //查询
		    $scope.searcFkDeprHistoryList = function (curIndex, dept_name) {
		        var param = ParamService.comParam(curIndex, $scope.fkDeprHistoryPager.pageSize, $scope.conditionObjDeprHistory);
		        $http.get($rootScope.baseUrl + "service/mce/MCE_MT/Srv_MCE_GetMCEAssetsMtnHistoryList.ashx" + param).success(function (data) {
		            if (data.Succeed == 1) {
		                $scope.deprHistoryList = data.Message.rows;
		                $scope.fkDeprHistoryPager.setDataNum(data.Message.total);
		                $scope.fkDeprHistoryPager.setCurIndex(curIndex);
		            }
		        })
		    };

		    $scope.getMtnList();
		    $scope.getBaseInfo();
		
		    $scope.searcFkDeprHistoryList(1);
		}])

	.controller("records", ['$scope', '$http', '$rootScope', '$location', "ParamS", "ParamService", "InputschangeState",
		function ($scope, $http, $rootScope, $location, ParamS, ParamService, InputschangeState) {
		    //	案卷信息
		    if ($scope.paramObj.id == null || $scope.paramObj.id == '') {
		        alert("请先录入并保存基本信息");
		        document.getElementById("menuBaseInfo").click();
		        return;
		    }

		    var vAsset_ID = $scope.paramObj.id;

		    var vAssets_name = "";
		    var vUser_name = "";

		    $scope.getBaseInfo = function () {
		        $http({
		            method: "GET",
		            url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCEAssetsDetail.ashx?id=" + $scope.paramObj.id
		        }).then(function (data) {
		            var data = data.data;
		            if (data.Succeed == 1) {

		                vAssets_name = data.Message.ASSETS_NAME;

		            } else {
		                alert(data.Message)
		            }
		        })
		    };

		    $scope.getUserInfo = function () {
		        $http({
		            method: "GET",
		            url: $rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_GetMCEAssetsUserInfo.ashx"
		        }).then(function (data) {
		            var data = data.data;
		            if (data.Succeed == 1) {

		                vUser_name = data.Message.user_name;

		            } else {
		                alert(data.Message)
		            }
		        })
		    };



		    $scope.rollList = [];


		    $scope.createRollModel = function () {
		        return {
		            id: "",
		            assets_id: vAsset_ID,

		            code: "",
		            name: vAssets_name,
		            savelimit: "",
		            create_user_id:"",
		            create_user_name: vUser_name,
		            create_time: "",
		            plan_type: "",
		            roll_type: "",
		            roll_property: "",
		          
		            comments: "",
		            audit_state: 1,
		            listFileName: []
		        }
		    };

		    $scope.paramRollObj = {
		        id: vAsset_ID,
		        condition: ""
		    };

		    $scope.getRollList = function () {
		        var param = ParamService.comParam(1, 10000, $scope.paramRollObj);
		        $http({
		            method: "GET",
		            url: $rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_GetMCEAssetsRollList.ashx" + param
		        }).then(function (data) {
		            var data = data.data;
		            if (data.Succeed == 1) {
		                $scope.rollList = [];
		                for (var i = 0; i < data.Message.length; i++) {
		                    $scope.rollList.push($scope.createRollModel());
		                    $scope.rollList[i].id = data.Message[i].ID;
		                    $scope.rollList[i].assets_id = data.Message[i].ASSETS_ID;

		                    $scope.rollList[i].code = data.Message[i].CODE;
		                    $scope.rollList[i].name = data.Message[i].NAME;
		                    $scope.rollList[i].savelimit = data.Message[i].SAVELIMIT==null ?"": data.Message[i].SAVELIMIT.trim();
		                    $scope.rollList[i].create_user_id = data.Message[i].CREATE_USER_ID;
		                    $scope.rollList[i].create_user_name = data.Message[i].CREATE_USER_ID_NAME;
		                    $scope.rollList[i].create_time = data.Message[i].CREATE_TIME;

		                    $scope.rollList[i].plan_type = data.Message[i].PLAN_TYPE == null ? "" : data.Message[i].PLAN_TYPE.trim();
		                    $scope.rollList[i].roll_type = data.Message[i].ROLL_TYPE == null ? "" : data.Message[i].ROLL_TYPE.trim();
		                    $scope.rollList[i].roll_property = data.Message[i].ROLL_PROPERTY == null ? "" : data.Message[i].ROLL_PROPERTY.trim();

		                    $scope.rollList[i].comments = data.Message[i].COMMENTS;
		                    $scope.rollList[i].audit_state = data.Message[i].AUDIT_STATE;


		                }

		                if ($scope.rollList.length == 0) {
		                    $scope.rollList.push($scope.createRollModel());
		                }

		            } else {
		                alert(data.Message)
		            }
		        })
		    };


		    $scope.saveLimitList = [];
		    $scope.getSaveLimitList = function () {
		        $http({
		            method: "GET",
		            url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=COM_1009&limit=10000"
		        }).then(function (data) {
		            var data = data.data;
		            if (data.Succeed == 1) {
		                $scope.saveLimitList = data.Message.rows
		            } else {
		                alert(data.Message)
		            }
		        })
		    };


		    $scope.planTypeList = [];
		    $scope.getPlanTypeList = function () {
		        $http({
		            method: "GET",
		            url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=COM_1010&limit=10000"
		        }).then(function (data) {
		            var data = data.data;
		            if (data.Succeed == 1) {
		                $scope.planTypeList = data.Message.rows
		            } else {
		                alert(data.Message)
		            }
		        })
		    };


		    $scope.rollTypeList = [];
		    $scope.getRollTypeList = function () {
		        $http({
		            method: "GET",
		            url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=COM_1012&limit=10000"
		        }).then(function (data) {
		            var data = data.data;
		            if (data.Succeed == 1) {
		                $scope.rollTypeList = data.Message.rows
		            } else {
		                alert(data.Message)
		            }
		        })
		    };

		    $scope.rollPropertyList = [];
		    $scope.getRollPropertyList = function () {
		        $http({
		            method: "GET",
		            url: $rootScope.baseUrl + "service/mtr/Srv_MTR_CT_DropDownList.ashx?parent=COM_1011&limit=10000"
		        }).then(function (data) {
		            var data = data.data;
		            if (data.Succeed == 1) {
		                $scope.rollPropertyList = data.Message.rows
		            } else {
		                alert(data.Message)
		            }
		        })
		    };


		    $scope.saveModel = function (v) {
                /*
		        if (v.code == "" || v.code == undefined) {
		            alert("请输入案卷单号")
		            return false
		        }
                */
		        if (v.name == "" || v.name == undefined) {
		            alert("请输入案卷名称")
		            return false
		        }


		        //验证
		        $http.post($rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_MCEAssetsRollSave.ashx", v).success(function (data) {
		            if (data.Succeed == 1) {
		                alert("保存成功！");
		                $scope.getRollList();
		            } else {
		                alert(data.Message + "保存失败！");
		            }
		        })
		    }


		    $scope.addModel = function () {
		        $scope.rollList.push($scope.createRollModel());
		    }


		    $scope.delModel = function (v) {
		        var flag = confirm("是否确认删除？");
		        if (!flag) {
		            return false
		        }

		        if (v.id == "") {
		            $scope.getRollList();
		        }
		        else {
		            $http.post($rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_MCEAssetsRollDelete.ashx", v.id).success(function (data) {
		                if (data.Succeed == 1) {
		                    alert("删除成功！");
		                    $scope.getRollList();
		                } else {
		                    alert(data.Message + "删除失败！");
		                }
		            })
		        }
		    }


		    $scope.auditModel = function (v) {
		        var flag = confirm("是否确认审核？");
		        if (!flag) {
		            return false
		        }

		        if (v.id == "") {
		            alert("请先保存再审核！");
		            return;
		        }
		        else {
		            $http.post($rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_MCEAssetsRollAudit.ashx", v).success(function (data) {
		                if (data.Succeed == 1) {
		                    alert("审核成功！");
		                    $scope.getRollList();
		                } else {
		                    alert(data.Message + "审核失败！");
		                }
		            })
		        }
		    }



		    $scope.getBaseInfo();
		    $scope.getUserInfo();
		    $scope.getRollList();
		    $scope.getSaveLimitList();
		    $scope.getPlanTypeList();
		    $scope.getRollTypeList();
		    $scope.getRollPropertyList();

		}])
	.controller("recordsRelation", ['$scope', '$http', '$rootScope', '$location', '$stateParams', "ParamS", "ParamService", "InputschangeState",
		function ($scope, $http, $rootScope, $location, $stateParams, ParamS, ParamService, InputschangeState) {
		    //	案卷信息/设备关联

		    var vID = $stateParams.id;

		    if (vID == "" || vID == null || vID == undefined) {
		        alert("参数错误,请先录入并保存案卷信息");
		        document.getElementById("mnuRollRecordInfo").click();
		        return;
		    }

		    $scope.rollAudit = $stateParams.audit_state;

		    $scope.paramRollEquipObj = {
		        condition: "",
		        needTotal: "0"
		    };
		    $scope.mainRollEquipPager = ParamService.getPager();
		    $scope.mainRollEquipList = [];
		    //模板列表查询
		    $scope.getRollEquipList = function (curIndex) {
		        var param = ParamService.comParam(curIndex, $scope.mainRollEquipPager.pageSize, $scope.paramRollEquipObj);
		        $http({
		            method: "GET",
		            url: $rootScope.baseUrl + "service/mce/mce_dict/Srv_MCE_GetMCEAssetsList.ashx" + param
		        }).then(function (data) {
		            var data = data.data;
		            if (data.Succeed == 1) {
		                $scope.mainRollEquipList = data.Message.rows;
		                $scope.mainRollEquipPager.setDataNum(data.Message.total);
		                $scope.mainRollEquipPager.setCurIndex(curIndex);
		            
		            }
		            else
		            {
		                alert(data.Message);
		            }
		        })
		    };


		    $scope.mainRealtionEquipList = [];
		    //模板列表查询
		    $scope.getRollRelationEquipList = function () {
		        $http({
		            method: "GET",
		            url: $rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_GetMCEAssetsRollEquipList.ashx?assetsid=" + $scope.paramObj.id + "&rollid="+vID
		        }).then(function (data) {
		            var data = data.data;
		            if (data.Succeed == 1) {
		                $scope.mainRealtionEquipList = data.Message;
		            }
		            else {
		                alert(data.Message);
		            }
		        })
		    };


		    $scope.addRealtion = function (assertsID) {
		        if (assertsID == "" || assertsID == null) {
		            alert("参数错误")
		            return false
		        }

		        var vEquipRelation = {
		            rollid: vID,
		            assetsid: assertsID
		        };

		        //验证
		        $http.post($rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_MCEAssetsRollEquipSave.ashx", vEquipRelation).success(function (data) {
		            if (data.Succeed == 1) {
		                alert("添加成功！");
		                $scope.getRollRelationEquipList();
		            } else {
		                alert(data.Message + "保存失败！");
		            }
		        })
		    }


		    $scope.delRealtion = function (vRelationID) {
		  
		        if (vRelationID == null || vRelationID=="") {
		            alert("请选择");
		            return false
		        }

		        var flag = confirm("是否确认取消关联？");
		        if (!flag) {
		            return false
		        }

		        $http({
		            method: "POST",
		            url: $rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_MCEAssetsRollEquipDelete.ashx",
		            data: vRelationID
		        }).then(function (data) {
		            var data = data.data;
		            if (data.Succeed == 1) {
		                alert("删除成功");
		                $scope.getRollRelationEquipList(1);
		            } else {
		                alert(data.Message)
		            }
		        })
		    };


		    $scope.getRollEquipList(1);
		    $scope.getRollRelationEquipList();

		}])
	.controller("fileList", ['$scope', '$http', '$rootScope', '$location', '$stateParams', "ParamS", "ParamService", "InputschangeState",
		function ($scope, $http, $rootScope, $location, $stateParams, ParamS, ParamService, InputschangeState) {
		    //	案卷信息/文件列表 
		    var vID = $stateParams.id;

            if(vID=="" || vID==null || vID==undefined)
            {
                alert("参数错误,请先录入并保存案卷信息");
                document.getElementById("mnuRollRecordInfo").click();
                return false;
            }

            $scope.rollAudit = $stateParams.audit_state;

		    $scope.rollFileList = [];


		    $scope.getRollFileList = function () {
		       
		        $http({
		            method: "GET",
		            url: $rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_GetMCEAssetsRollFillList.ashx?id=" + vID
		        }).then(function (data) {
		            var data = data.data;
		            if (data.Succeed == 1) {
		                $scope.rollFileList = data.Message;		        
		                if( $scope.rollFileList!=null &&  $scope.rollFileList.length>0)
		                {
		                    for (var i = 0; i < $scope.rollFileList.length; i++) {
		                        $scope.rollFileList[i].checked = false
		                    }
		                }

		            } else {
		                alert(data.Message)
		            }
		        })
		    };



		    $scope.checkRollFileSate = {
		        state: false
		    };
		    $scope.checkRollFileAll = function () {
		        $scope.checkRollFileSate.state = !$scope.checkRollFileSate.state
		        for (var i = 0; i < $scope.rollFileList.length; i++) {
		            $scope.rollFileList[i].checked = $scope.checkRollFileSate.state
		        }
		    };

  
		    $scope.delRollFileModel = function () {
		        var list = [];
		        for (var i = 0; i < $scope.rollFileList.length; i++) {
		            if ($scope.rollFileList[i].checked) {
		                list.push($scope.rollFileList[i].ID)
		            }
		        }
		        if (list.length == 0) {
		            alert("请选择");
		            return false
		        }

		        var flag = confirm("是否确认删除？");
		        if (!flag) {
		            return false
		        }

		        $http({
		            method: "POST",
		            url: $rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_MCEAssetsRollFileDelete.ashx",
		            data: list
		        }).then(function (data) {
		            var data = data.data;
		            if (data.Succeed == 1) {
		                alert("删除成功");
		                $scope.getRollFileList(1);
		            } else {
		                alert(data.Message)
		            }
		        })
		    };


		    $scope.newRollFileState = {
		        state: false
		    };

		    $scope.rollFileTemplateState = {
		        state: false
		    };

		    $scope.rollFileTempDataState = {
		        state: false
		    };

		    $scope.rollFileTemplateInfo = {
		        rollid: vID,
		        name: "",
		        comments:""
		    };

		    $scope.goRollFileTemplate = function () {
		        $scope.rollFileTemplateState.state = true;
		        $scope.rollFileTemplateInfo.rollid = vID;
		        $scope.rollFileTemplateInfo.name = "";
		        $scope.rollFileTemplateInfo.comments = "";
		    };



		    $scope.saveRollFileTemplate = function (v) {
		        if (v.name == "" || v.name == undefined) {
		            alert("请输入模板名称")
		            return false
		        }

		        $http.post($rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_MCEAssetsRollFileSaveAsTemplate.ashx", v).success(function (data) {
		            if (data.Succeed == 1) {
		                alert("保存成功！");
		                $scope.rollFileTemplateState.state = false;
		            } else {
		                alert(data.Message + "保存失败！");
		            }
		        })
		    }



		    $scope.paramTempDataObj = {
		        condition: ""
		    };
		    $scope.mainTempDataPager = ParamService.getPager();
		    $scope.modelTempDataList = [];
		    //模板列表查询
		    $scope.getTempDatatList = function (curIndex) {
		        var param = ParamService.comParam(curIndex, $scope.mainTempDataPager.pageSize, $scope.paramTempDataObj);
		        $http({
		            method: "GET",
		            url: $rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_GetMCEAssetsRollTemplateList.ashx" + param
		        }).then(function (data) {
		            var data = data.data;
		            if (data.Succeed == 1) {
		                $scope.modelTempDataList = data.Message.rows;
		                $scope.mainTempDataPager.setDataNum(data.Message.total);
		                $scope.mainTempDataPager.setCurIndex(curIndex);
		                for (var i = 0; i < $scope.modelTempDataList.length; i++) {
		                    $scope.modelTempDataList[i].checked = false;
		                }
		            }
		        })
		    };



		    $scope.selectTempData = function (v) {
		        for (var i = 0; i < $scope.modelTempDataList.length; i++) {
		            $scope.modelTempDataList[i].checked = false;
		        }
		        v.checked = true;
		    };



		    $scope.saveRollFilebyTempData = function () {
		        var vTempID = "";
		        for (var i = 0; i < $scope.modelTempDataList.length; i++) {
		            if( $scope.modelTempDataList[i].checked == true)
		            {
		                vTempID = $scope.modelTempDataList[i].ID
		            }
		        }


		        if (vTempID == "" || vTempID == undefined) {
		            alert("请选择模板")
		            return false
		        }

		        $http({
		            method: "GET",
		            url: $rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_GetMCEAssetsRollTemplateDetail.ashx?id=" + vTempID
		        }).then(function (data) {
		            var data = data.data;
		            if (data.Succeed == 1) {
		                if (data.Message == null || data.Message.length==0)
		                {
		                    alert("没有模板明细数据")
		                    return false
		                }

		                $scope.addRollFileModelList = [];

		                $scope.templateDetaillList = data.Message;
		     
		                for (var i = 0; i < $scope.templateDetaillList.length; i++) {
		                   var rollFileModel = $scope.createRollFileModel();
		                   rollFileModel.code = $scope.templateDetaillList[i].CODE;
		                   rollFileModel.name = $scope.templateDetaillList[i].NAME;
		                   $scope.addRollFileModelList.push(rollFileModel);
		                }


		                //验证
		                $http.post($rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_MCEAssetsRollFileSave.ashx", $scope.addRollFileModelList).success(function (data) {
		                    if (data.Succeed == 1) {
		                        alert("保存成功！");
		                        $scope.rollFileTempDataState.state = false;
		                        $scope.getRollFileList();
		                    } else {
		                        alert(data.Message + "保存失败！");
		                    }
		                })


		            } else {
		                alert(data.Message)
		            }
		        })
		    }


		    $scope.goRollFileTempData = function () {

		        $scope.rollFileTempDataState.state = true;
		        $scope.getTempDatatList(1);
		    };

		    $scope.createRollFileModel = function () {
		        return {
		            id: "",
		            base_id: vID,
		            code: "",
		            name: "",
		            create_date: "",
		            page_num: "",
		            summarys: "",
		            comments: "",
		            filename: ""
		        }
		    };


		    $scope.goRollFileDetail = function (vFileID) {
		        $scope.newRollFileState.state = true;

		        $scope.rollFileModel = $scope.createRollFileModel();

		        if(vFileID!=null && vFileID!="")
		        {

		            $http({
		                method: "GET",
		                url: $rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_GetMCEAssetsRollFileDetail.ashx?id=" + vFileID
		            }).then(function (data) {
		                var data = data.data;
		                if (data.Succeed == 1) {
		                    $scope.rollFileModel.id = data.Message.ID;
		                    $scope.rollFileModel.code = data.Message.CODE;
		                    $scope.rollFileModel.name = data.Message.NAME;
		                    $scope.rollFileModel.create_date = data.Message.CREATE_DATE;
		                    $scope.rollFileModel.page_num = data.Message.PAGE_NUM;
		                    $scope.rollFileModel.summarys = data.Message.SUMMARYS;
		                    $scope.rollFileModel.comments = data.Message.COMMENTS;
		                    $scope.rollFileModel.filename = data.Message.BACKUP1;
		                } else {
		                    alert(data.Message)
		                }
		            })
		        }
		    };



		    $scope.saveRollFileModel = function (v) {
		        if (v.code == "" || v.code == undefined) {
		            alert("请输入文件编号")
		            return false
		        }

		        if (v.name == "" || v.name == undefined) {
		            alert("请输入文件名称")
		            return false
		        }

		        $scope.addRollFileModelList = [];
		        $scope.addRollFileModelList.push(v);
		        //验证
		        $http.post($rootScope.baseUrl + "service/mce/mce_roll/Srv_MCE_MCEAssetsRollFileSave.ashx", $scope.addRollFileModelList).success(function (data) {
		            if (data.Succeed == 1) {
		                alert("保存成功！");
		                $scope.newRollFileState.state = false;
		                $scope.getRollFileList();
		            } else {
		                alert(data.Message + "保存失败！");
		            }
		        })
		    }


		    $scope.RollFileDown = function (value) {

		        if (value == null || value == "" || value == undefined) {
		            alert("没有找到附件！");
		        }
		        else {
		            window.open("../../upload/mce/" + value)
		        }
		    };

		    $scope.getRollFileList();

		}])
	.controller("fileModel", ['$scope', '$http', '$rootScope', '$location', "ParamS", "ParamService", "InputschangeState",
		function ($scope, $http, $rootScope, $location, ParamS, ParamService, InputschangeState) {
			//	案卷信息/案卷模版
		}]);
        
