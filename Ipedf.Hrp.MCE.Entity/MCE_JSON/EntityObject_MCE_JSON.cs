using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ipedf.Web.Entity
{
    public class JsonMceType
    {
        public string id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string parent_id { get; set; }
        public int state { get; set; }
        public List<string> listDeptID { get; set; }
    }


    public class JsonMceAssets
    {
        public string id { get; set; }

        public string assets_name { get; set; }//资产名称
        public string assets_code { get; set; }//资产编号

        public string seq_number { get; set; }//资产条码
        public string spec { get; set; }//规格型号
        public string machine_type_id { get; set; }//资产分类
        public string purchase_date { get; set; }//购买日期
        public string en_name { get; set; }//英文名称
        public string card_code { get; set; }//卡片编号
        public string card_type_id { get; set; }//卡片类型
        public string unit_id { get; set; }//计量单位
        public string assets_state { get; set; }//资产状态
        public string enable_date { get; set; }//启用日期
        public string service_life { get; set; }//使用期限(月)
        public int is_in_account { get; set; }//是否财务入账
        public string in_account_date { get; set; }//财务入账日期
        public string out_account_date { get; set; }//财务消账日期
        public string store_address { get; set; }//存放地址
        public string maintain_period { get; set; }//保养周期（天）
        public int is_assets { get; set; }//是否固定资产
        public int is_depr { get; set; }//是否折旧
        public int is_large_me { get; set; }//是否大型医用设备
        public int is_affix { get; set; }//是否附件
        public int is_metering { get; set; }//是否计量
        public int is_self_restraint { get; set; }//是否自制

        public string depr_type_id { get; set; }//折旧方式
        public string depr_year_amount { get; set; }//折旧年限

        public string ownership_type_id { get; set; }//权属信息
        public string subjection_dept_id { get; set; }//所属部门
        public string custody_dept_id { get; set; }//保管科室
        public string custody_user_id { get; set; }//保管人
        public string custody_level_id { get; set; }//保管等级
        public string using_dept_id { get; set; }//领用科室
        public string using_user_id { get; set; }//领用人
        public string use_state { get; set; }//使用状态
        public string biz_type_id { get; set; }//业务类型
        public string operating_machine_type_id { get; set; }//经营设备类型
        public string machine_manage_type_id { get; set; }//设备管理类别
        public string spell_code { get; set; }//拼音码
        public string five_stroke_code { get; set; }//五笔码
        public string international_code { get; set; }//国际码
        public string custom_code { get; set; }//自定义码
        public string call_code { get; set; }//招标编号
        public string file_code { get; set; }//案卷编号
        public string contract_code { get; set; }//合同编号
        public string licence_code { get; set; }//许可证号
        public string maintain_contact { get; set; }//发票号
        public string original_value { get; set; }//原值
        public string net_value { get; set; }//净值
        public string net_amount { get; set; }//净额
        public string rudimental_value_ratio { get; set; }//残值率
        public string predict_net_rudimental_value { get; set; }//预计净残值率
        public string add_value { get; set; }//设备增值
        public string acquire_ownership_type_id { get; set; }//取得所有权方式
        public string acquire_use_type_id { get; set; }//获得使用方式
        public string value_type_id { get; set; }//价值类型
        public string finance_type_id { get; set; }//财政编制类型
        public string ref_dept_id { get; set; }//出租(借)方
        public string ref_price { get; set; }//有偿使用费(元/年)
        public string economic_use_type_id { get; set; }//用途
        public string purchase_type_id { get; set; }//购入方式
        public string capital_source_type_id { get; set; }//资金来源
        public string prd_date { get; set; }//生产日期
        public string maintenance_period_date { get; set; }//保修到期日期
        public string vehicle_code { get; set; }//车辆牌号
        public string vehicle_use_type_id { get; set; }//车辆用途
        public string energy_type_id { get; set; }//能源类型
        public string brand_name { get; set; }//品牌名称
        public string prd_id { get; set; }//生产厂家
        public string prd_code { get; set; }//出厂编号
        public string provider_id { get; set; }//供应商
        public string prd_place_type_id { get; set; }//设备产地
        public string nationality_id { get; set; }//国别地区
        public string picture { get; set; }//图片地址

    }


    public class JsonMceAssersFix
    {
        public string id { get; set; }
        public string assets_id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string amount { get; set; }
        public string comments { get; set; }
        public string spec { get; set; }
        public int audit_state { get; set; }
        public List<JsonMceAssetsFileInfo> listFileName { get; set; }

    }


    public class JsonMceAssetsCapitalAllot
    {
        public string id { get; set; }
        public string assets_id { get; set; }
        public string capital_source_type_id { get; set; }
        public string ratio { get; set; }
        public string allot_money { get; set; }
        public string comments { get; set; }
        public int audit_state { get; set; }
        public List<JsonMceAssetsFileInfo> listFileName { get; set; }

    }

    public class JsonMceAssetsFileInfo
    {
        public string saveName { get; set; }
        public string fileName { get; set; }


    }


    public class JsonMceAssetsDeprAllot
    {
        public string id { get; set; }
        public string assets_id { get; set; }
        public string dept_id { get; set; }
        public string ratio { get; set; }
        public string depr_years { get; set; }
        public string depr_id { get; set; }
        public string comments { get; set; }
        public int audit_state { get; set; }
        public List<JsonMceAssetsFileInfo> listFileName { get; set; }
    }



    public class JsonMceAssetsImportation//进口信息
    {
        public string id { get; set; }
        public string assets_id { get; set; }
        public string country_id { get; set; }
        public string currency_id { get; set; }
        public string purchase_money { get; set; }
        public string foreign_currency_rate { get; set; }
        public string foreign_currency_source_id { get; set; }
        public string approve_file_code { get; set; }
        public string exemption_code { get; set; }
        
        public string customs { get; set; }

        public string comments { get; set; }
        public int audit_state { get; set; }
        public List<JsonMceAssetsFileInfo> listFileName { get; set; }

    }


    public class JsonMceAssetsContract//合同信息
    {
        public string id { get; set; }
        public string assets_id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string type_id { get; set; }
        public string money { get; set; }
        public string first_party { get; set; }
        public string second_party { get; set; }
        public string sign_date { get; set; }
        public string expire_date { get; set; }
        public string state { get; set; }
        public string comments { get; set; }
        public int audit_state { get; set; }
        public List<JsonMceAssetsFileInfo> listFileName { get; set; }

    }


    public class JsonMceAssetsInsurance//保险信息
    {
        public string id { get; set; }
        public string assets_id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string mater { get; set; }
        public string insurance_money { get; set; }
        public string fee_money { get; set; }
        public string insurance_unit { get; set; }
        public string effect_date { get; set; }
        public string expire_date { get; set; }

        public string state { get; set; }
        public string comments { get; set; }
        public int audit_state { get; set; }
        public List<JsonMceAssetsFileInfo> listFileName { get; set; }

    }



    public class JsonMceAssetsMeter//计量信息
    {
        public string id { get; set; }
        public string assets_id { get; set; }
        public string code { get; set; }
        public string accuracy_class { get; set; }
        public string meter_class { get; set; }
        public string meter_type { get; set; }
        public string measure_range { get; set; }
        public string divid_value { get; set; }
        public string identification_cycle { get; set; }
        public string next_identification { get; set; }
        public string time_zone { get; set; }
        public string is_force_sense { get; set; }
          
        public string state { get; set; }
        public string comments { get; set; }
        public int audit_state { get; set; }
        public List<JsonMceAssetsFileInfo> listFileName { get; set; }

    }



    public class JsonMceAssetsWriteOff//报废信息
    {
        public string id { get; set; }
        public string assets_id { get; set; }
        public string code { get; set; }
        public string finance_cycle { get; set; }
        public string create_date { get; set; }
        public string write_off_type_id { get; set; }
        public string write_off_cause_id { get; set; }
        public string original_value { get; set; }
        public string net_value { get; set; }
        public string rudimental_value { get; set; }
        public string income { get; set; }
        public string comments { get; set; }
        public int audit_state { get; set; }
        public List<JsonMceAssetsFileInfo> listFileName { get; set; }
    }


    public class JsonMceAssetsUserInfo//用户信息
    {
        public string user_id { get; set; }
        public string user_name { get; set; }

        public string dept_id { get; set; }
        public string dept_name { get; set; }

        public string sys_date { get; set; }
        public string finance_cycle { get; set; }
        public string code { get; set; }
    }


    public class JsonMceAssetsRoll//案卷信息
    {
        public string id { get; set; }
        public string assets_id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string savelimit { get; set; }
        public string create_user_id { get; set; }
        public string create_time { get; set; }
        public string plan_type { get; set; }
        public string roll_type { get; set; }
        public string roll_property { get; set; }
        public string comments { get; set; }
        public int audit_state { get; set; }
        
    }



    public class JsonMceAssetsRollFile//案卷文件信息
    {
        public string id { get; set; }
        public string base_id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string create_date { get; set; }
        public string page_num { get; set; }
        public string summarys { get; set; }
        public string comments { get; set; }

        public string filename { get; set; }
    }



    public class JsonMceAssetsRollEquip//案卷关联设备
    {
        public string rollid { get; set; }
        public string assetsid { get; set; }
      
    }


    public class JsonMceAssetsRollFileTemplate//文件模板
    {
        public string rollid { get; set; }
        public string name { get; set; }
        public string comments { get; set; }

    }


    
    public class JsonMceTypeTree
    {
        public string id { get; set; }
        public string text { get; set; }
        public string state { get; set; }
        public List<JsonMceTypeTree> children { get; set; }
    }

}
