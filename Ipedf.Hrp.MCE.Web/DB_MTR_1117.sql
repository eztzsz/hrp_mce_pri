------------------------------------------------------
-- Export file for user TEST                        --
-- Created by Administrator on 2015/11/17, 13:15:53 --
------------------------------------------------------

set define off
spool DB_MTR_20151117_.log

prompt
prompt Creating table MTR_B_AOG
prompt ========================
prompt
create table MTR_B_AOG
(
  id               CHAR(36) not null,
  code             VARCHAR2(50),
  create_date      DATE,
  stock_id         CHAR(36),
  provider_id      CHAR(36),
  user_id          CHAR(36),
  state            NUMBER(3),
  comments         VARCHAR2(200),
  create_user_id   CHAR(36),
  create_dept_id   CHAR(36),
  create_time      DATE,
  modify_user_id   CHAR(36),
  modify_dept_id   CHAR(36),
  modify_time      DATE,
  data_timestamp   TIMESTAMP(6),
  data_organise_id CHAR(36)
)
tablespace USERS
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
comment on column MTR_B_AOG.code
  is '单号';
comment on column MTR_B_AOG.create_date
  is '到货日期';
comment on column MTR_B_AOG.stock_id
  is '到货仓库';
comment on column MTR_B_AOG.provider_id
  is '供货公司';
comment on column MTR_B_AOG.user_id
  is '登记人';
alter table MTR_B_AOG
  add constraint PK_MTR_B_AOG primary key (ID)
  using index 
  tablespace USERS
  pctfree 10
  initrans 2
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );

prompt
prompt Creating table MTR_B_AOG_D
prompt ==========================
prompt
create table MTR_B_AOG_D
(
  id           CHAR(36) not null,
  base_id      CHAR(36),
  mater_id     CHAR(36),
  spec         VARCHAR2(50),
  amount       NUMBER(22,4),
  pkg_amount   NUMBER(22,4),
  unit_id      CHAR(36),
  price        NUMBER(22,4),
  money        NUMBER(22,4),
  batch_code   VARCHAR2(50),
  prd_id       CHAR(36),
  prd_date     DATE,
  invalid_date DATE,
  comments     VARCHAR2(200),
  ref_tab_name VARCHAR2(50),
  ref_tab_id   CHAR(36)
)
tablespace USERS
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
comment on column MTR_B_AOG_D.mater_id
  is '物资';
comment on column MTR_B_AOG_D.spec
  is '规格';
comment on column MTR_B_AOG_D.amount
  is '数量';
comment on column MTR_B_AOG_D.pkg_amount
  is '包装数量';
comment on column MTR_B_AOG_D.unit_id
  is '单位';
comment on column MTR_B_AOG_D.price
  is '单价';
comment on column MTR_B_AOG_D.money
  is '金额';
comment on column MTR_B_AOG_D.batch_code
  is '批号';
comment on column MTR_B_AOG_D.prd_id
  is '厂家';
comment on column MTR_B_AOG_D.prd_date
  is '生产日期';
comment on column MTR_B_AOG_D.invalid_date
  is '失效日期';
comment on column MTR_B_AOG_D.comments
  is '备注';
alter table MTR_B_AOG_D
  add constraint PK_MTR_B_AOG_D primary key (ID)
  using index 
  tablespace USERS
  pctfree 10
  initrans 2
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
alter table MTR_B_AOG_D
  add constraint FK_MTR_B_AOG_D_B foreign key (BASE_ID)
  references MTR_B_AOG (ID) on delete cascade;

prompt
prompt Creating table MTR_B_INSTOCK
prompt ============================
prompt
create table MTR_B_INSTOCK
(
  id               CHAR(36) not null,
  code             VARCHAR2(50),
  create_date      DATE,
  instock_type_id  CHAR(36),
  stock_id         CHAR(36),
  provider_id      CHAR(36),
  invoice_code     VARCHAR2(50),
  invoice_date     DATE,
  user_id          CHAR(36),
  state            NUMBER(3),
  comments         VARCHAR2(200),
  create_user_id   CHAR(36),
  create_dept_id   CHAR(36),
  create_time      DATE,
  modify_user_id   CHAR(36),
  modify_dept_id   CHAR(36),
  modify_time      DATE,
  data_timestamp   TIMESTAMP(6),
  data_organise_id CHAR(36),
  use_dept_id      CHAR(36),
  use_user_id      CHAR(36)
)
tablespace USERS
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
comment on column MTR_B_INSTOCK.code
  is '单号';
comment on column MTR_B_INSTOCK.create_date
  is '入库日期';
comment on column MTR_B_INSTOCK.instock_type_id
  is '入库类型';
comment on column MTR_B_INSTOCK.stock_id
  is '入库仓库';
comment on column MTR_B_INSTOCK.provider_id
  is '供货公司';
comment on column MTR_B_INSTOCK.invoice_code
  is '发票号';
comment on column MTR_B_INSTOCK.invoice_date
  is '发票日期';
comment on column MTR_B_INSTOCK.user_id
  is '入库人';
comment on column MTR_B_INSTOCK.use_dept_id
  is '领用科室';
comment on column MTR_B_INSTOCK.use_user_id
  is '领用人';
alter table MTR_B_INSTOCK
  add constraint PK_MTR_B_INSTOCK primary key (ID)
  using index 
  tablespace USERS
  pctfree 10
  initrans 2
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );

prompt
prompt Creating table MTR_B_INSTOCK_D
prompt ==============================
prompt
create table MTR_B_INSTOCK_D
(
  id           CHAR(36) not null,
  base_id      CHAR(36),
  mater_id     CHAR(36),
  spec         VARCHAR2(50),
  amount       NUMBER(22,4),
  pkg_amount   NUMBER(22,4),
  unit_id      CHAR(36),
  price        NUMBER(22,4),
  money        NUMBER(22,4),
  batch_code   VARCHAR2(50),
  prd_id       CHAR(36),
  prd_date     DATE,
  invalid_date DATE,
  comments     VARCHAR2(200),
  ref_tab_name VARCHAR2(50),
  ref_tab_id   CHAR(36)
)
tablespace USERS
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
comment on column MTR_B_INSTOCK_D.mater_id
  is '物资';
comment on column MTR_B_INSTOCK_D.spec
  is '规格';
comment on column MTR_B_INSTOCK_D.amount
  is '数量';
comment on column MTR_B_INSTOCK_D.pkg_amount
  is '包装数量';
comment on column MTR_B_INSTOCK_D.unit_id
  is '单位';
comment on column MTR_B_INSTOCK_D.price
  is '单价';
comment on column MTR_B_INSTOCK_D.money
  is '金额';
comment on column MTR_B_INSTOCK_D.batch_code
  is '批号';
comment on column MTR_B_INSTOCK_D.prd_id
  is '厂家';
comment on column MTR_B_INSTOCK_D.prd_date
  is '生产日期';
comment on column MTR_B_INSTOCK_D.invalid_date
  is '失效日期';
comment on column MTR_B_INSTOCK_D.comments
  is '备注';
alter table MTR_B_INSTOCK_D
  add constraint PK_MTR_B_INSTOCK_D primary key (ID)
  using index 
  tablespace USERS
  pctfree 10
  initrans 2
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
alter table MTR_B_INSTOCK_D
  add constraint FK_MTR_B_INSTOCK_D_B foreign key (BASE_ID)
  references MTR_B_INSTOCK (ID) on delete cascade;

prompt
prompt Creating table MTR_B_INSTOCK_REQ
prompt ================================
prompt
create table MTR_B_INSTOCK_REQ
(
  id               CHAR(36) not null,
  create_date      DATE,
  dept_id          CHAR(36),
  user_id          CHAR(36),
  state            NUMBER(3),
  comments         VARCHAR2(200),
  create_user_id   CHAR(36),
  create_dept_id   CHAR(36),
  create_time      DATE,
  modify_user_id   CHAR(36),
  modify_dept_id   CHAR(36),
  modify_time      DATE,
  data_timestamp   TIMESTAMP(6),
  data_organise_id CHAR(36),
  code             VARCHAR2(50)
)
tablespace USERS
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
comment on column MTR_B_INSTOCK_REQ.create_date
  is '计划日期';
comment on column MTR_B_INSTOCK_REQ.dept_id
  is '计划科室';
comment on column MTR_B_INSTOCK_REQ.user_id
  is '计划人';
comment on column MTR_B_INSTOCK_REQ.code
  is '编码';
alter table MTR_B_INSTOCK_REQ
  add constraint PK_MTR_B_INSTOCK_REQ primary key (ID)
  using index 
  tablespace USERS
  pctfree 10
  initrans 2
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );

prompt
prompt Creating table MTR_B_INSTOCK_REQ_D
prompt ==================================
prompt
create table MTR_B_INSTOCK_REQ_D
(
  id              CHAR(36) not null,
  base_id         CHAR(36),
  mater_id        CHAR(36),
  spec            VARCHAR2(50),
  apply_amount    NUMBER(22,4),
  approved_amount NUMBER(22,4),
  unit_id         CHAR(36),
  pkg_amount      NUMBER(22,4),
  price           NUMBER(22,4),
  money           NUMBER(22,4),
  comments        VARCHAR2(200),
  delivery_date   DATE
)
tablespace USERS
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
comment on column MTR_B_INSTOCK_REQ_D.mater_id
  is '物资';
comment on column MTR_B_INSTOCK_REQ_D.spec
  is '规格';
comment on column MTR_B_INSTOCK_REQ_D.apply_amount
  is '计划数量';
comment on column MTR_B_INSTOCK_REQ_D.approved_amount
  is '核准数量';
comment on column MTR_B_INSTOCK_REQ_D.unit_id
  is '单位';
comment on column MTR_B_INSTOCK_REQ_D.pkg_amount
  is '包装数量';
comment on column MTR_B_INSTOCK_REQ_D.price
  is '计划价格';
comment on column MTR_B_INSTOCK_REQ_D.money
  is '计划金额';
comment on column MTR_B_INSTOCK_REQ_D.comments
  is '备注';
comment on column MTR_B_INSTOCK_REQ_D.delivery_date
  is '交货日期';
alter table MTR_B_INSTOCK_REQ_D
  add constraint PK_MTR_B_INSTOCK_REQ_D primary key (ID)
  using index 
  tablespace USERS
  pctfree 10
  initrans 2
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
alter table MTR_B_INSTOCK_REQ_D
  add constraint FK_MTR_B_INSTOCK_REQ_D_B foreign key (BASE_ID)
  references MTR_B_INSTOCK_REQ (ID) on delete cascade;

prompt
prompt Creating table MTR_B_INSTOCK_REQ_SUM
prompt ====================================
prompt
create table MTR_B_INSTOCK_REQ_SUM
(
  id               CHAR(36) not null,
  code             VARCHAR2(50),
  create_date      DATE,
  dept_id          CHAR(36),
  user_id          CHAR(36),
  state            NUMBER(3),
  comments         VARCHAR2(200),
  create_user_id   CHAR(36),
  create_dept_id   CHAR(36),
  create_time      DATE,
  modify_user_id   CHAR(36),
  modify_dept_id   CHAR(36),
  modify_time      DATE,
  data_timestamp   TIMESTAMP(6),
  data_organise_id CHAR(36)
)
tablespace USERS
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
comment on column MTR_B_INSTOCK_REQ_SUM.code
  is '编码';
comment on column MTR_B_INSTOCK_REQ_SUM.create_date
  is '计划日期';
comment on column MTR_B_INSTOCK_REQ_SUM.dept_id
  is '计划科室';
comment on column MTR_B_INSTOCK_REQ_SUM.user_id
  is '计划人';
alter table MTR_B_INSTOCK_REQ_SUM
  add constraint PK_MTR_B_INSTOCK_REQ_SUM primary key (ID)
  using index 
  tablespace USERS
  pctfree 10
  initrans 2
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );

prompt
prompt Creating table MTR_B_INSTOCK_REQ_SUM_C
prompt ======================================
prompt
create table MTR_B_INSTOCK_REQ_SUM_C
(
  id           CHAR(36) not null,
  base_id      CHAR(36),
  ref_tab_name VARCHAR2(50),
  ref_tab_id   CHAR(36)
)
tablespace USERS
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
alter table MTR_B_INSTOCK_REQ_SUM_C
  add constraint PK_MTR_B_INSTOCK_REQ_SUM_C primary key (ID)
  using index 
  tablespace USERS
  pctfree 10
  initrans 2
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
alter table MTR_B_INSTOCK_REQ_SUM_C
  add constraint FK_MTR_B_INSTOCK_REQ_SUM_C_B foreign key (BASE_ID)
  references MTR_B_INSTOCK_REQ_SUM (ID) on delete cascade;

prompt
prompt Creating table MTR_B_INSTOCK_REQ_SUM_D
prompt ======================================
prompt
create table MTR_B_INSTOCK_REQ_SUM_D
(
  id              CHAR(36) not null,
  base_id         CHAR(36),
  mater_id        CHAR(36),
  spec            VARCHAR2(50),
  apply_amount    NUMBER(22,4),
  approved_amount NUMBER(22,4),
  unit_id         CHAR(36),
  pkg_amount      NUMBER(22,4),
  price           NUMBER(22,4),
  money           NUMBER(22,4),
  comments        VARCHAR2(200),
  stock_amount    NUMBER(22,4),
  delivery_date   DATE
)
tablespace USERS
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
comment on column MTR_B_INSTOCK_REQ_SUM_D.mater_id
  is '物资';
comment on column MTR_B_INSTOCK_REQ_SUM_D.spec
  is '规格';
comment on column MTR_B_INSTOCK_REQ_SUM_D.apply_amount
  is '申请数量';
comment on column MTR_B_INSTOCK_REQ_SUM_D.approved_amount
  is '采购数量';
comment on column MTR_B_INSTOCK_REQ_SUM_D.unit_id
  is '单位';
comment on column MTR_B_INSTOCK_REQ_SUM_D.pkg_amount
  is '包装数量';
comment on column MTR_B_INSTOCK_REQ_SUM_D.price
  is '计划价格';
comment on column MTR_B_INSTOCK_REQ_SUM_D.money
  is '计划金额';
comment on column MTR_B_INSTOCK_REQ_SUM_D.comments
  is '备注';
comment on column MTR_B_INSTOCK_REQ_SUM_D.stock_amount
  is '库存数量';
comment on column MTR_B_INSTOCK_REQ_SUM_D.delivery_date
  is '交货日期';
alter table MTR_B_INSTOCK_REQ_SUM_D
  add constraint PK_MTR_B_INSTOCK_REQ_SUM_D primary key (ID)
  using index 
  tablespace USERS
  pctfree 10
  initrans 2
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
alter table MTR_B_INSTOCK_REQ_SUM_D
  add constraint FK_MTR_B_INSTOCK_REQ_SUM_D_B foreign key (BASE_ID)
  references MTR_B_INSTOCK_REQ_SUM (ID) on delete cascade;

prompt
prompt Creating table MTR_B_OUTSTOCK
prompt =============================
prompt
create table MTR_B_OUTSTOCK
(
  id               CHAR(36) not null,
  code             VARCHAR2(50),
  create_date      DATE,
  outstock_type_id CHAR(36),
  stock_id         CHAR(36),
  user_id          CHAR(36),
  use_dept_id      CHAR(36),
  use_user_id      CHAR(36),
  state            NUMBER(3),
  comments         VARCHAR2(200),
  create_user_id   CHAR(36),
  create_dept_id   CHAR(36),
  create_time      DATE,
  modify_user_id   CHAR(36),
  modify_dept_id   CHAR(36),
  modify_time      DATE,
  data_timestamp   TIMESTAMP(6),
  data_organise_id CHAR(36),
  purpose          VARCHAR2(50)
)
tablespace USERS
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
comment on column MTR_B_OUTSTOCK.code
  is '单号';
comment on column MTR_B_OUTSTOCK.create_date
  is '出库日期';
comment on column MTR_B_OUTSTOCK.outstock_type_id
  is '出库类型';
comment on column MTR_B_OUTSTOCK.stock_id
  is '出库仓库';
comment on column MTR_B_OUTSTOCK.user_id
  is '出库人';
comment on column MTR_B_OUTSTOCK.use_dept_id
  is '领用科室';
comment on column MTR_B_OUTSTOCK.use_user_id
  is '领用人';
comment on column MTR_B_OUTSTOCK.purpose
  is '用途';
alter table MTR_B_OUTSTOCK
  add constraint PK_MTR_B_OUTSTOCK primary key (ID)
  using index 
  tablespace USERS
  pctfree 10
  initrans 2
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );

prompt
prompt Creating table MTR_B_OUTSTOCK_D
prompt ===============================
prompt
create table MTR_B_OUTSTOCK_D
(
  id           CHAR(36) not null,
  base_id      CHAR(36),
  mater_id     CHAR(36),
  spec         VARCHAR2(50),
  amount       NUMBER(22,4),
  pkg_amount   NUMBER(22,4),
  unit_id      CHAR(36),
  price        NUMBER(22,4),
  money        NUMBER(22,4),
  batch_code   VARCHAR2(50),
  prd_id       CHAR(36),
  prd_date     DATE,
  invalid_date DATE,
  comments     VARCHAR2(200),
  ref_tab_name VARCHAR2(50),
  ref_tab_id   CHAR(36),
  retail_price NUMBER(22,4),
  retail_money NUMBER(22,4)
)
tablespace USERS
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
comment on column MTR_B_OUTSTOCK_D.mater_id
  is '物资';
comment on column MTR_B_OUTSTOCK_D.spec
  is '规格';
comment on column MTR_B_OUTSTOCK_D.amount
  is '数量';
comment on column MTR_B_OUTSTOCK_D.pkg_amount
  is '包装数量';
comment on column MTR_B_OUTSTOCK_D.unit_id
  is '单位';
comment on column MTR_B_OUTSTOCK_D.price
  is '单价';
comment on column MTR_B_OUTSTOCK_D.money
  is '金额';
comment on column MTR_B_OUTSTOCK_D.batch_code
  is '批号';
comment on column MTR_B_OUTSTOCK_D.prd_id
  is '厂家';
comment on column MTR_B_OUTSTOCK_D.prd_date
  is '生产日期';
comment on column MTR_B_OUTSTOCK_D.invalid_date
  is '失效日期';
comment on column MTR_B_OUTSTOCK_D.comments
  is '备注';
comment on column MTR_B_OUTSTOCK_D.retail_price
  is '零售价格';
comment on column MTR_B_OUTSTOCK_D.retail_money
  is '零售金额';
alter table MTR_B_OUTSTOCK_D
  add constraint PK_MTR_B_OUTSTOCK_D primary key (ID)
  using index 
  tablespace USERS
  pctfree 10
  initrans 2
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
alter table MTR_B_OUTSTOCK_D
  add constraint FK_MTR_B_OUTSTOCK_D_B foreign key (BASE_ID)
  references MTR_B_OUTSTOCK (ID) on delete cascade;

prompt
prompt Creating table MTR_B_PURCHASE_BILL
prompt ==================================
prompt
create table MTR_B_PURCHASE_BILL
(
  id               CHAR(36) not null,
  code             VARCHAR2(50),
  create_date      DATE,
  provider_id      CHAR(36),
  bill_type_id     CHAR(36),
  dept_id          CHAR(36),
  user_id          CHAR(36),
  state            NUMBER(3),
  comments         VARCHAR2(200),
  create_user_id   CHAR(36),
  create_dept_id   CHAR(36),
  create_time      DATE,
  modify_user_id   CHAR(36),
  modify_dept_id   CHAR(36),
  modify_time      DATE,
  data_timestamp   TIMESTAMP(6),
  data_organise_id CHAR(36)
)
tablespace USERS
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
comment on column MTR_B_PURCHASE_BILL.code
  is '单号';
comment on column MTR_B_PURCHASE_BILL.create_date
  is '订单日期';
comment on column MTR_B_PURCHASE_BILL.provider_id
  is '供应商';
comment on column MTR_B_PURCHASE_BILL.bill_type_id
  is '订单类型';
comment on column MTR_B_PURCHASE_BILL.dept_id
  is '订单科室';
comment on column MTR_B_PURCHASE_BILL.user_id
  is '订单人';
alter table MTR_B_PURCHASE_BILL
  add constraint PK_MTR_B_PURCHASE_BILL primary key (ID)
  using index 
  tablespace USERS
  pctfree 10
  initrans 2
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );

prompt
prompt Creating table MTR_B_PURCHASE_BILL_D
prompt ====================================
prompt
create table MTR_B_PURCHASE_BILL_D
(
  id            CHAR(36) not null,
  base_id       CHAR(36),
  mater_id      CHAR(36),
  spec          VARCHAR2(50),
  amount        NUMBER(22,4),
  pkg_amount    NUMBER(22,4),
  unit_id       CHAR(36),
  price         NUMBER(22,4),
  money         NUMBER(22,4),
  comments      VARCHAR2(200),
  prd_id        CHAR(36),
  delivery_date DATE
)
tablespace USERS
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
comment on column MTR_B_PURCHASE_BILL_D.mater_id
  is '物资';
comment on column MTR_B_PURCHASE_BILL_D.spec
  is '规格';
comment on column MTR_B_PURCHASE_BILL_D.amount
  is '数量';
comment on column MTR_B_PURCHASE_BILL_D.pkg_amount
  is '包装数量';
comment on column MTR_B_PURCHASE_BILL_D.unit_id
  is '单位';
comment on column MTR_B_PURCHASE_BILL_D.price
  is '单价';
comment on column MTR_B_PURCHASE_BILL_D.money
  is '金额';
comment on column MTR_B_PURCHASE_BILL_D.comments
  is '备注';
comment on column MTR_B_PURCHASE_BILL_D.prd_id
  is '生产厂家';
comment on column MTR_B_PURCHASE_BILL_D.delivery_date
  is '交货日期';
alter table MTR_B_PURCHASE_BILL_D
  add constraint PK_MTR_B_PURCHASE_BILL_D primary key (ID)
  using index 
  tablespace USERS
  pctfree 10
  initrans 2
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
alter table MTR_B_PURCHASE_BILL_D
  add constraint FK_MTR_B_PURCHASE_BILL_D_B foreign key (BASE_ID)
  references MTR_B_PURCHASE_BILL (ID) on delete cascade;

prompt
prompt Creating table MTR_B_PURCHASE_PLAN
prompt ==================================
prompt
create table MTR_B_PURCHASE_PLAN
(
  id               CHAR(36) not null,
  code             VARCHAR2(50),
  create_date      DATE,
  plan_type_id     CHAR(36),
  dept_id          CHAR(36),
  user_id          CHAR(36),
  state            NUMBER(3),
  comments         VARCHAR2(200),
  create_user_id   CHAR(36),
  create_dept_id   CHAR(36),
  create_time      DATE,
  modify_user_id   CHAR(36),
  modify_dept_id   CHAR(36),
  modify_time      DATE,
  data_timestamp   TIMESTAMP(6),
  data_organise_id CHAR(36)
)
tablespace USERS
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
comment on column MTR_B_PURCHASE_PLAN.code
  is '单号';
comment on column MTR_B_PURCHASE_PLAN.create_date
  is '计划日期';
comment on column MTR_B_PURCHASE_PLAN.plan_type_id
  is '计划类型';
comment on column MTR_B_PURCHASE_PLAN.dept_id
  is '计划科室';
comment on column MTR_B_PURCHASE_PLAN.user_id
  is '计划人';
alter table MTR_B_PURCHASE_PLAN
  add constraint PK_MTR_B_PURCHASE_PLAN primary key (ID)
  using index 
  tablespace USERS
  pctfree 10
  initrans 2
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );

prompt
prompt Creating table MTR_B_PURCHASE_PLAN_D
prompt ====================================
prompt
create table MTR_B_PURCHASE_PLAN_D
(
  id            CHAR(36) not null,
  base_id       CHAR(36),
  provider_id   CHAR(36),
  mater_id      CHAR(36),
  spec          VARCHAR2(50),
  amount        NUMBER(22,4),
  pkg_amount    NUMBER(22,4),
  unit_id       CHAR(36),
  price         NUMBER(22,4),
  money         NUMBER(22,4),
  comments      VARCHAR2(200),
  prd_id        CHAR(36),
  delivery_date DATE
)
tablespace USERS
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
comment on column MTR_B_PURCHASE_PLAN_D.provider_id
  is '供应商';
comment on column MTR_B_PURCHASE_PLAN_D.mater_id
  is '物资';
comment on column MTR_B_PURCHASE_PLAN_D.spec
  is '规格';
comment on column MTR_B_PURCHASE_PLAN_D.amount
  is '数量';
comment on column MTR_B_PURCHASE_PLAN_D.pkg_amount
  is '包装数量';
comment on column MTR_B_PURCHASE_PLAN_D.unit_id
  is '单位';
comment on column MTR_B_PURCHASE_PLAN_D.price
  is '单价';
comment on column MTR_B_PURCHASE_PLAN_D.money
  is '金额';
comment on column MTR_B_PURCHASE_PLAN_D.comments
  is '备注';
comment on column MTR_B_PURCHASE_PLAN_D.prd_id
  is '生产厂家';
comment on column MTR_B_PURCHASE_PLAN_D.delivery_date
  is '交货日期';
alter table MTR_B_PURCHASE_PLAN_D
  add constraint PK_MTR_B_PURCHASE_PLAN_D primary key (ID)
  using index 
  tablespace USERS
  pctfree 10
  initrans 2
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
alter table MTR_B_PURCHASE_PLAN_D
  add constraint FK_MTR_B_PURCHASE_PLAN_D_B foreign key (BASE_ID)
  references MTR_B_PURCHASE_PLAN (ID) on delete cascade;

prompt
prompt Creating table MTR_B_STOCK_DATA
prompt ===============================
prompt
create table MTR_B_STOCK_DATA
(
  id                 CHAR(36) not null,
  mater_id           CHAR(36),
  spec               VARCHAR2(50),
  amount             NUMBER(22,4),
  pkg_amount         NUMBER(22,4),
  unit_id            CHAR(36),
  price              NUMBER(22,4),
  money              NUMBER(22,4),
  batch_code         VARCHAR2(50),
  prd_id             CHAR(36),
  prd_date           DATE,
  invalid_date       DATE,
  stock_data_type_id CHAR(36),
  ref_tab_name       VARCHAR2(50),
  ref_tab_id         CHAR(36),
  retail_price       NUMBER(22,4),
  stock_id           CHAR(36),
  create_date        DATE
)
tablespace USERS
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
comment on column MTR_B_STOCK_DATA.mater_id
  is '物资';
comment on column MTR_B_STOCK_DATA.spec
  is '规格';
comment on column MTR_B_STOCK_DATA.amount
  is '数量';
comment on column MTR_B_STOCK_DATA.pkg_amount
  is '包装数量';
comment on column MTR_B_STOCK_DATA.unit_id
  is '单位';
comment on column MTR_B_STOCK_DATA.price
  is '单价';
comment on column MTR_B_STOCK_DATA.money
  is '金额';
comment on column MTR_B_STOCK_DATA.batch_code
  is '批号';
comment on column MTR_B_STOCK_DATA.prd_id
  is '厂家';
comment on column MTR_B_STOCK_DATA.prd_date
  is '生产日期';
comment on column MTR_B_STOCK_DATA.invalid_date
  is '失效日期';
comment on column MTR_B_STOCK_DATA.stock_data_type_id
  is '库存数据类型';
comment on column MTR_B_STOCK_DATA.ref_tab_name
  is '触发表名';
comment on column MTR_B_STOCK_DATA.ref_tab_id
  is '触发记录';
comment on column MTR_B_STOCK_DATA.retail_price
  is '零售单价';
comment on column MTR_B_STOCK_DATA.stock_id
  is '仓库';
comment on column MTR_B_STOCK_DATA.create_date
  is '日期';
alter table MTR_B_STOCK_DATA
  add constraint PK_MTR_B_STOCK_DATA primary key (ID)
  using index 
  tablespace USERS
  pctfree 10
  initrans 2
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );

prompt
prompt Creating table MTR_B_STOCK_DATA_CHECK
prompt =====================================
prompt
create table MTR_B_STOCK_DATA_CHECK
(
  id                 CHAR(36) not null,
  code               VARCHAR2(50),
  create_date        DATE,
  check_type_id      CHAR(36),
  stock_id           CHAR(36),
  user_id            CHAR(36),
  dept_id            CHAR(36),
  state              NUMBER(3),
  comments           VARCHAR2(200),
  create_user_id     CHAR(36),
  create_dept_id     CHAR(36),
  create_time        DATE,
  modify_user_id     CHAR(36),
  modify_dept_id     CHAR(36),
  modify_time        DATE,
  data_timestamp     TIMESTAMP(6),
  data_organise_id   CHAR(36),
  stock_data_type_id CHAR(36)
)
tablespace USERS
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
comment on column MTR_B_STOCK_DATA_CHECK.code
  is '单号';
comment on column MTR_B_STOCK_DATA_CHECK.create_date
  is '盘点日期';
comment on column MTR_B_STOCK_DATA_CHECK.check_type_id
  is '盘点类型';
comment on column MTR_B_STOCK_DATA_CHECK.stock_id
  is '盘点仓库';
comment on column MTR_B_STOCK_DATA_CHECK.user_id
  is '盘点人';
comment on column MTR_B_STOCK_DATA_CHECK.dept_id
  is '盘点科室';
comment on column MTR_B_STOCK_DATA_CHECK.stock_data_type_id
  is '库存类型';
alter table MTR_B_STOCK_DATA_CHECK
  add constraint PK_MTR_B_STOCK_DATA_CHECK primary key (ID)
  using index 
  tablespace USERS
  pctfree 10
  initrans 2
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );

prompt
prompt Creating table MTR_B_STOCK_DATA_CHECK_D
prompt =======================================
prompt
create table MTR_B_STOCK_DATA_CHECK_D
(
  id           CHAR(36) not null,
  base_id      CHAR(36),
  mater_id     CHAR(36),
  spec         VARCHAR2(50),
  amount       NUMBER(22,4),
  pkg_amount   NUMBER(22,4),
  unit_id      CHAR(36),
  batch_code   VARCHAR2(50),
  prd_id       CHAR(36),
  comments     VARCHAR2(200),
  check_amount NUMBER(22,4),
  diff_amount  NUMBER(22,4)
)
tablespace USERS
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
comment on column MTR_B_STOCK_DATA_CHECK_D.mater_id
  is '物资';
comment on column MTR_B_STOCK_DATA_CHECK_D.spec
  is '规格';
comment on column MTR_B_STOCK_DATA_CHECK_D.amount
  is '库存数量';
comment on column MTR_B_STOCK_DATA_CHECK_D.pkg_amount
  is '包装数量';
comment on column MTR_B_STOCK_DATA_CHECK_D.unit_id
  is '单位';
comment on column MTR_B_STOCK_DATA_CHECK_D.batch_code
  is '批号';
comment on column MTR_B_STOCK_DATA_CHECK_D.prd_id
  is '厂家';
comment on column MTR_B_STOCK_DATA_CHECK_D.comments
  is '备注';
comment on column MTR_B_STOCK_DATA_CHECK_D.check_amount
  is '盘点数量';
comment on column MTR_B_STOCK_DATA_CHECK_D.diff_amount
  is '差异数量';
alter table MTR_B_STOCK_DATA_CHECK_D
  add constraint PK_MTR_B_STOCK_DATA_CHECK_D primary key (ID)
  using index 
  tablespace USERS
  pctfree 10
  initrans 2
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
alter table MTR_B_STOCK_DATA_CHECK_D
  add constraint FK_MTR_B_STOCK_DATA_C_D_B foreign key (BASE_ID)
  references MTR_B_STOCK_DATA_CHECK (ID) on delete cascade;

prompt
prompt Creating table MTR_B_STOCK_DATA_CHECK_TYPE
prompt ==========================================
prompt
create table MTR_B_STOCK_DATA_CHECK_TYPE
(
  id      CHAR(36) not null,
  base_id CHAR(36),
  type_id CHAR(36)
)
tablespace USERS
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
comment on column MTR_B_STOCK_DATA_CHECK_TYPE.type_id
  is '物资分类';
alter table MTR_B_STOCK_DATA_CHECK_TYPE
  add constraint PK_MTR_B_STOCK_DATA_CHECK_TYPE primary key (ID)
  using index 
  tablespace USERS
  pctfree 10
  initrans 2
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
alter table MTR_B_STOCK_DATA_CHECK_TYPE
  add constraint FK_MTR_B_STOCK_DATA_CHECK_T_B foreign key (BASE_ID)
  references MTR_B_STOCK_DATA_CHECK (ID) on delete cascade;

prompt
prompt Creating table MTR_B_STOCK_DATA_MOVE
prompt ====================================
prompt
create table MTR_B_STOCK_DATA_MOVE
(
  id                 CHAR(36) not null,
  code               VARCHAR2(50),
  create_date        DATE,
  from_stock_id      CHAR(36),
  to_stock_id        CHAR(36),
  user_id            CHAR(36),
  dept_id            CHAR(36),
  state              NUMBER(3),
  comments           VARCHAR2(200),
  create_user_id     CHAR(36),
  create_dept_id     CHAR(36),
  create_time        DATE,
  modify_user_id     CHAR(36),
  modify_dept_id     CHAR(36),
  modify_time        DATE,
  data_timestamp     TIMESTAMP(6),
  data_organise_id   CHAR(36),
  purpose            VARCHAR2(50),
  stock_data_type_id CHAR(36)
)
tablespace USERS
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
comment on column MTR_B_STOCK_DATA_MOVE.code
  is '调拨单号';
comment on column MTR_B_STOCK_DATA_MOVE.create_date
  is '调拨日期';
comment on column MTR_B_STOCK_DATA_MOVE.from_stock_id
  is '出库仓库';
comment on column MTR_B_STOCK_DATA_MOVE.to_stock_id
  is '入库仓库';
comment on column MTR_B_STOCK_DATA_MOVE.user_id
  is '调拨人';
comment on column MTR_B_STOCK_DATA_MOVE.dept_id
  is '调拨科室';
comment on column MTR_B_STOCK_DATA_MOVE.purpose
  is '用途';
comment on column MTR_B_STOCK_DATA_MOVE.stock_data_type_id
  is '库存数据类型';
alter table MTR_B_STOCK_DATA_MOVE
  add constraint PK_MTR_B_STOCK_DATA_MOVE primary key (ID)
  using index 
  tablespace USERS
  pctfree 10
  initrans 2
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );

prompt
prompt Creating table MTR_B_STOCK_DATA_MOVE_D
prompt ======================================
prompt
create table MTR_B_STOCK_DATA_MOVE_D
(
  id           CHAR(36) not null,
  base_id      CHAR(36),
  mater_id     CHAR(36),
  spec         VARCHAR2(50),
  amount       NUMBER(22,4),
  pkg_amount   NUMBER(22,4),
  unit_id      CHAR(36),
  price        NUMBER(22,4),
  money        NUMBER(22,4),
  batch_code   VARCHAR2(50),
  prd_id       CHAR(36),
  prd_date     DATE,
  invalid_date DATE,
  comments     VARCHAR2(200),
  move_amount  NUMBER(22,4)
)
tablespace USERS
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
comment on column MTR_B_STOCK_DATA_MOVE_D.mater_id
  is '物资';
comment on column MTR_B_STOCK_DATA_MOVE_D.spec
  is '规格';
comment on column MTR_B_STOCK_DATA_MOVE_D.amount
  is '数量';
comment on column MTR_B_STOCK_DATA_MOVE_D.pkg_amount
  is '包装数量';
comment on column MTR_B_STOCK_DATA_MOVE_D.unit_id
  is '单位';
comment on column MTR_B_STOCK_DATA_MOVE_D.price
  is '单价';
comment on column MTR_B_STOCK_DATA_MOVE_D.money
  is '金额';
comment on column MTR_B_STOCK_DATA_MOVE_D.batch_code
  is '批号';
comment on column MTR_B_STOCK_DATA_MOVE_D.prd_id
  is '厂家';
comment on column MTR_B_STOCK_DATA_MOVE_D.prd_date
  is '生产日期';
comment on column MTR_B_STOCK_DATA_MOVE_D.invalid_date
  is '失效日期';
comment on column MTR_B_STOCK_DATA_MOVE_D.comments
  is '备注';
comment on column MTR_B_STOCK_DATA_MOVE_D.move_amount
  is '调拨数量';
alter table MTR_B_STOCK_DATA_MOVE_D
  add constraint PK_MTR_B_STOCK_DATA_MOVE_D primary key (ID)
  using index 
  tablespace USERS
  pctfree 10
  initrans 2
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
alter table MTR_B_STOCK_DATA_MOVE_D
  add constraint FK_MTR_B_STOCK_DATA_MOVE_D_B foreign key (BASE_ID)
  references MTR_B_STOCK_DATA_MOVE (ID) on delete cascade;

prompt
prompt Creating table MTR_D_MTR
prompt ========================
prompt
create table MTR_D_MTR
(
  id                 CHAR(36) not null,
  type_id            CHAR(36),
  stock_up_limit     NUMBER(22,4),
  stock_down_limit   NUMBER(22,4),
  code               VARCHAR2(50),
  name               VARCHAR2(50),
  spell_code         VARCHAR2(50),
  five_stroke_code   VARCHAR2(50),
  international_code VARCHAR2(50),
  custom_code        VARCHAR2(50),
  finance_name       VARCHAR2(50),
  finance_code       VARCHAR2(50),
  spec               VARCHAR2(50),
  price              NUMBER(22,4),
  unit_id            CHAR(36),
  pkg_amount         NUMBER(22,4),
  pkg_unit_id        CHAR(36),
  pkg_price          NUMBER(22,4),
  prd_id             CHAR(36),
  price_rule_id      CHAR(36),
  source_id          CHAR(36),
  usage_id           CHAR(36),
  is_invalid         NUMBER(3),
  is_fi_charge       NUMBER(3),
  is_valuable        NUMBER(3),
  is_spec            NUMBER(3),
  is_pkg             NUMBER(3),
  is_otp             NUMBER(3),
  is_batch           NUMBER(3),
  is_plan_instock    NUMBER(3),
  state              NUMBER(3),
  comments           VARCHAR2(200),
  create_user_id     CHAR(36),
  create_dept_id     CHAR(36),
  create_time        DATE,
  modify_user_id     CHAR(36),
  modify_dept_id     CHAR(36),
  modify_time        DATE,
  data_timestamp     TIMESTAMP(6),
  data_organise_id   CHAR(36),
  provider_id        CHAR(36)
)
tablespace USERS
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
comment on column MTR_D_MTR.id
  is '主键';
comment on column MTR_D_MTR.type_id
  is '物料类型';
comment on column MTR_D_MTR.stock_up_limit
  is '库存上限';
comment on column MTR_D_MTR.stock_down_limit
  is '库存下限';
comment on column MTR_D_MTR.code
  is '物资编码';
comment on column MTR_D_MTR.name
  is '物资名称';
comment on column MTR_D_MTR.spell_code
  is '拼音码';
comment on column MTR_D_MTR.five_stroke_code
  is '五笔码';
comment on column MTR_D_MTR.international_code
  is '国际码';
comment on column MTR_D_MTR.custom_code
  is '自定义码';
comment on column MTR_D_MTR.finance_name
  is '财务名称';
comment on column MTR_D_MTR.finance_code
  is '财务编码';
comment on column MTR_D_MTR.spec
  is '物资规格';
comment on column MTR_D_MTR.price
  is '单价';
comment on column MTR_D_MTR.unit_id
  is '单位';
comment on column MTR_D_MTR.pkg_amount
  is '包装数量';
comment on column MTR_D_MTR.pkg_unit_id
  is '包装单位';
comment on column MTR_D_MTR.pkg_price
  is '包装价格';
comment on column MTR_D_MTR.prd_id
  is '生产厂家';
comment on column MTR_D_MTR.price_rule_id
  is '加价规则';
comment on column MTR_D_MTR.source_id
  is '物资来源';
comment on column MTR_D_MTR.usage_id
  is '物资用途';
comment on column MTR_D_MTR.is_invalid
  is '是否停用';
comment on column MTR_D_MTR.is_fi_charge
  is '是否财务收费';
comment on column MTR_D_MTR.is_valuable
  is '是否高值耗材';
comment on column MTR_D_MTR.is_spec
  is '是否特殊标志';
comment on column MTR_D_MTR.is_pkg
  is '是否打包';
comment on column MTR_D_MTR.is_otp
  is '是否一次性耗材';
comment on column MTR_D_MTR.is_batch
  is '是否按批次管理';
comment on column MTR_D_MTR.is_plan_instock
  is '是否按月计划入库';
alter table MTR_D_MTR
  add constraint PK_MTR_D_MTR primary key (ID)
  using index 
  tablespace USERS
  pctfree 10
  initrans 2
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );

prompt
prompt Creating table MTR_D_MTR_FEE
prompt ============================
prompt
create table MTR_D_MTR_FEE
(
  id               CHAR(36) not null,
  mtr_id           VARCHAR2(50),
  fee_item_id      VARCHAR2(50),
  state            NUMBER(3),
  comments         VARCHAR2(200),
  create_user_id   CHAR(36),
  create_dept_id   CHAR(36),
  create_time      DATE,
  modify_user_id   CHAR(36),
  modify_dept_id   CHAR(36),
  modify_time      DATE,
  data_timestamp   TIMESTAMP(6),
  data_organise_id CHAR(36)
)
tablespace USERS
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
comment on column MTR_D_MTR_FEE.id
  is '主键';
comment on column MTR_D_MTR_FEE.mtr_id
  is '物资';
comment on column MTR_D_MTR_FEE.fee_item_id
  is '非药品收费项目';
alter table MTR_D_MTR_FEE
  add constraint PK_MTR_D_MTR_FEE primary key (ID)
  using index 
  tablespace USERS
  pctfree 10
  initrans 2
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );

prompt
prompt Creating table MTR_D_MTR_PROVIDER
prompt =================================
prompt
create table MTR_D_MTR_PROVIDER
(
  id          CHAR(36) not null,
  base_id     CHAR(36),
  provider_id CHAR(36),
  state       NUMBER(3)
)
tablespace USERS
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
comment on column MTR_D_MTR_PROVIDER.base_id
  is '物资';
comment on column MTR_D_MTR_PROVIDER.provider_id
  is '供应商';
comment on column MTR_D_MTR_PROVIDER.state
  is '是否有效';
alter table MTR_D_MTR_PROVIDER
  add constraint PK_MTR_D_MTR_PROVIDER primary key (ID)
  using index 
  tablespace USERS
  pctfree 10
  initrans 2
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
alter table MTR_D_MTR_PROVIDER
  add constraint PK_MTR_D_MTR_PROVIDER_B foreign key (BASE_ID)
  references MTR_D_MTR (ID) on delete cascade;

prompt
prompt Creating table MTR_D_MTR_PROVIDER_PRICE
prompt =======================================
prompt
create table MTR_D_MTR_PROVIDER_PRICE
(
  id         CHAR(36) not null,
  base_id    CHAR(36),
  price      NUMBER(22,4),
  begin_date DATE,
  end_date   DATE,
  state      NUMBER(3)
)
tablespace USERS
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
comment on column MTR_D_MTR_PROVIDER_PRICE.base_id
  is '物资供应商';
comment on column MTR_D_MTR_PROVIDER_PRICE.price
  is '价格';
comment on column MTR_D_MTR_PROVIDER_PRICE.begin_date
  is '开始日期';
comment on column MTR_D_MTR_PROVIDER_PRICE.end_date
  is '结束日期';
comment on column MTR_D_MTR_PROVIDER_PRICE.state
  is '是否有效';
alter table MTR_D_MTR_PROVIDER_PRICE
  add constraint PK_MTR_D_MTR_PROVIDER_PRICE primary key (ID)
  using index 
  tablespace USERS
  pctfree 10
  initrans 2
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
alter table MTR_D_MTR_PROVIDER_PRICE
  add constraint FK_MTR_D_MTR_PROVIDER_PRICE_B foreign key (BASE_ID)
  references MTR_D_MTR_PROVIDER (ID) on delete cascade;

prompt
prompt Creating table MTR_D_MTR_TYPE
prompt =============================
prompt
create table MTR_D_MTR_TYPE
(
  id                 CHAR(36) not null,
  code               VARCHAR2(50),
  name               VARCHAR2(50),
  spell_code         VARCHAR2(50),
  five_stroke_code   VARCHAR2(50),
  international_code VARCHAR2(50),
  custom_code        VARCHAR2(50),
  finance_name       VARCHAR2(50),
  finance_code       VARCHAR2(50),
  order_index        NUMBER(3),
  parent_id          CHAR(36),
  state              NUMBER(3),
  comments           VARCHAR2(200),
  create_user_id     CHAR(36),
  create_dept_id     CHAR(36),
  create_time        DATE,
  modify_user_id     CHAR(36),
  modify_dept_id     CHAR(36),
  modify_time        DATE,
  data_timestamp     TIMESTAMP(6),
  data_organise_id   CHAR(36)
)
tablespace USERS
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
comment on column MTR_D_MTR_TYPE.id
  is '主键';
comment on column MTR_D_MTR_TYPE.code
  is '编码';
comment on column MTR_D_MTR_TYPE.name
  is '名称';
comment on column MTR_D_MTR_TYPE.spell_code
  is '拼音码';
comment on column MTR_D_MTR_TYPE.five_stroke_code
  is '五笔码';
comment on column MTR_D_MTR_TYPE.international_code
  is '国际码';
comment on column MTR_D_MTR_TYPE.custom_code
  is '自定义码';
comment on column MTR_D_MTR_TYPE.finance_name
  is '财务名称';
comment on column MTR_D_MTR_TYPE.finance_code
  is '财务编码';
comment on column MTR_D_MTR_TYPE.order_index
  is '顺序号';
comment on column MTR_D_MTR_TYPE.parent_id
  is '上级';
alter table MTR_D_MTR_TYPE
  add constraint PK_MTR_D_MTR_TYPE primary key (ID)
  using index 
  tablespace USERS
  pctfree 10
  initrans 2
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );

prompt
prompt Creating table MTR_D_PRICE_RULE
prompt ===============================
prompt
create table MTR_D_PRICE_RULE
(
  id               CHAR(36) not null,
  code             VARCHAR2(50),
  name             VARCHAR2(50),
  increase_scale   NUMBER(22,4),
  state            NUMBER(3),
  comments         VARCHAR2(200),
  create_user_id   CHAR(36),
  create_dept_id   CHAR(36),
  create_time      DATE,
  modify_user_id   CHAR(36),
  modify_dept_id   CHAR(36),
  modify_time      DATE,
  data_timestamp   TIMESTAMP(6),
  data_organise_id CHAR(36)
)
tablespace USERS
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
comment on column MTR_D_PRICE_RULE.id
  is '主键';
comment on column MTR_D_PRICE_RULE.code
  is '编码';
comment on column MTR_D_PRICE_RULE.name
  is '名称';
comment on column MTR_D_PRICE_RULE.increase_scale
  is '加价比例';
alter table MTR_D_PRICE_RULE
  add constraint PK_MTR_D_PRICE_RULE primary key (ID)
  using index 
  tablespace USERS
  pctfree 10
  initrans 2
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );

prompt
prompt Creating table MTR_D_USED_DEPT
prompt ==============================
prompt
create table MTR_D_USED_DEPT
(
  id               CHAR(36) not null,
  biz_type_id      CHAR(36),
  order_index      NUMBER(3),
  dept_id          CHAR(36),
  state            NUMBER(3),
  comments         VARCHAR2(200),
  create_user_id   CHAR(36),
  create_dept_id   CHAR(36),
  create_time      DATE,
  modify_user_id   CHAR(36),
  modify_dept_id   CHAR(36),
  modify_time      DATE,
  data_timestamp   TIMESTAMP(6),
  data_organise_id CHAR(36)
)
tablespace USERS
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );
comment on column MTR_D_USED_DEPT.biz_type_id
  is '业务类型';
comment on column MTR_D_USED_DEPT.order_index
  is '顺序号';
comment on column MTR_D_USED_DEPT.dept_id
  is '科室名称';
alter table MTR_D_USED_DEPT
  add constraint PK_MTR_D_USED_DEPT primary key (ID)
  using index 
  tablespace USERS
  pctfree 10
  initrans 2
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );

prompt
prompt Creating view V_MTR_STOCK_DATA
prompt ==============================
prompt
create or replace force view v_mtr_stock_data as
select
stock_id,
mater_id,
spec,
sum(amount) as amount,
pkg_amount,
unit_id,
price,
sum(money) as money,
batch_code,
stock_data_type_id,
prd_id,
prd_date
from mtr_b_stock_data 
group by
stock_id,
mater_id,
spec,
unit_id,
price,
batch_code,
stock_data_type_id,
prd_id,
prd_date,
pkg_amount;

prompt
prompt Creating procedure SP_MTR_ARCHIVE_INSTOCK_REQ_SUM
prompt =================================================
prompt
create or replace procedure SP_mtr_Archive_instock_req_sum(p_planid in char,p_msg out varchar2,p_succeed out number )
Authid Current_User 
 as
V_DYNA_SQL clob;
V_EXEC_SQL clob;
V_STATE number(3);
V_PRE_BUDGET_YEAR char(36);
V_TEMP_TAB varchar2(50);
V_MORETHAN number(22,4);
V_BUDGET_CPN_ID char(36);
V_BUDGET_TEMPLET_ID char(36);
v_ErrorCode varchar2(1024);
v_ErrorMsg varchar2(1024);
v_CurrentUser varchar2(1024);
v_Information varchar2(1024);
v_PATTERN char(36);
V_LEVEL char(36);
/*
1、归档科室申请汇总数据（MTR_B_instock_req_sum）,
2、归档引用的科室申请（MTR_B_instock_req）
3、入库汇总数据明细中库存不足的记录，自动生成采购计划(MTR_B_purchase_plan)
*/
begin   
    --变量初始化
    V_MORETHAN := 0;
    --取所有关联的科室申请（MTR_B_instock_req_sum_c）
    for config in(
                    select
                    t.id,
                    t.ref_tab_id
                    from  Mtr_b_Instock_Req_Sum_c t
                    where t.base_id = p_planid
                  )
          loop
             --更新对应的科室申请(MTR_B_instock_req)状态为已归档
             execute immediate 'update MTR_B_instock_req t
             set t.state=4 where t.id= '''||config.ref_tab_id||'''';
          end loop;
      --更新汇总表（MTR_B_instock_req_sum）的状态为已归档
      execute immediate ' update MTR_B_instock_req_sum t set t.state=4 where t.id='''||p_planid||'''';
      --检查是否需要自动生成采购计划
      execute immediate 'select 
      sum(d.approved_amount) - sum(d.stock_amount)
      from
      MTR_B_instock_req_sum_d d
      where d.base_id ='''||p_planid||'''
      group by d.base_id
      ' into V_MORETHAN;
      if V_MORETHAN > 0 then
        begin
           --生成采购计划           
           execute immediate 'insert into MTR_B_purchase_plan
           (
             id,
             code,
             create_date,
             plan_type_id,
             dept_id,
             user_id,
             state
           )
           select 
             f.id,
             f.code,
             sysdate,
             ''00410002'',
             f.dept_id,
             f.user_id,
             1
            from MTR_B_instock_req_sum f 
            where f.id = '''||p_planid||'''';
           --生成采购计划明细
            for config in(
                select
                t.id,
                t.mater_id,
                t.spec,
                t.unit_id,
                t.pkg_amount,
                t.price,
                t.money,
                t.comments,
                t.approved_amount,
                t.stock_amount,
                t.approved_amount - t.stock_amount as plan_amount,
                m.provider_id,
                m.prd_id
                from  MTR_B_INSTOCK_REQ_SUM_d t,mtr_d_mtr m
                where t.base_id = p_planid
                and t.approved_amount > t.stock_amount
                and m.id = t.mater_id
              )
              loop  
                
                 execute immediate '
                 insert into MTR_B_purchase_plan_d(
                 id,
                 base_id,
                 mater_id,
                 spec,
                 amount,
                 pkg_amount,
                 unit_id,
                 price,
                 money,
                 provider_id,
                 prd_id,
                 comments
                 )
                 select 
                 '''||config.id||''',
                 '''||p_planid||''',
                 '''||config.mater_id||''',
                 '''||config.spec||''',
                 '||config.plan_amount||',
                 round('||config.pkg_amount||'/m.PKG_AMOUNT,2),
                 '''||config.unit_id||''',
                 '||config.price||',
                 '||(config.plan_amount * config.price)||',
                 '''||config.provider_id||''',
                 '''||config.prd_id||''',
                 '''||config.comments||'''
                 from  MTR_D_MTR m where m.id = '''||config.mater_id||'''
                 ';
                 
              end loop; 
        end;
      end if;
      commit;
      p_msg:= '';
      p_succeed := 1;--返回成功
exception
      when others
        then
        v_ErrorCode := SQLCODE;
        v_ErrorMsg := SQLERRM;
        v_CurrentUser := USER;
        v_Information := '遇到了错误 ' || TO_CHAR(SYSDATE) || ' 数据库用户 ' || v_CurrentUser;
        p_msg:= '执行错误,自动回滚.';
        dbms_output.put_line('执行错误,自动回滚.');
        p_msg:= p_msg || '详细信息:'||'错误代码:'||v_ErrorCode||',错误消息:'||v_ErrorMsg||',日志信息:'||v_Information;
        dbms_output.put_line('详细信息:'||'错误代码:'||v_ErrorCode||',错误消息:'||v_ErrorMsg||',日志信息:'||v_Information);
        /*写失败标志*/
        p_succeed := 0;
        rollback;
END SP_mtr_Archive_instock_req_sum;
/

prompt
prompt Creating procedure SP_MTR_AUDIT_INSTOCK
prompt =======================================
prompt
create or replace procedure SP_mtr_Audit_instock(p_planid in char,p_msg out varchar2,p_succeed out number )
Authid Current_User 
 as
V_DYNA_SQL clob;
V_EXEC_SQL clob;
V_STATE number(3);
V_NEWID char(36);
V_STOCK_ID char(36);
V_INSTOCK_TYPE char(36);
V_STOCK_DATA_TYPE char(36);
V_TEMP_TAB varchar2(50);
V_BUDGET_CPN_ID char(36);
V_BUDGET_TEMPLET_ID char(36);
v_ErrorCode varchar2(1024);
v_ErrorMsg varchar2(1024);
v_CurrentUser varchar2(1024);
v_Information varchar2(1024);
v_PATTERN char(36);
V_LEVEL char(36);
/*
1、更新入库单的状态为已审核（MTR_B_INSTOCK）
2、增加库存（MTR_B_STOCK_DATA）
3、生成财务凭证/成本数据(待集成实现)
4、更新引用单据状态（如果存在）
*/
begin   
      --变量初始化
      select trim(INSTOCK_TYPE_ID) into V_INSTOCK_TYPE from MTR_B_INSTOCK where id = p_planid;
      if V_INSTOCK_TYPE = '00390002' then --领用入库
         begin
            --变量初始化
            --1.库存数据类型
            V_STOCK_DATA_TYPE := '00400001'; --普通库存
            --2.仓库ID
            --判断科室仓库是否存在
            select 
            decode
            (
            ( select t.id from MDM_D_STOCK t
            where t.STOCK_TYPE_ID = '00320002'--科室仓库
            and t.DEPT_ID =(select USE_DEPT_ID from MTR_B_INSTOCK where id=p_planid))
            ,
            null,
            '',
            ( select t.id from MDM_D_STOCK t
            where t.STOCK_TYPE_ID = '00320002'--科室仓库
            and t.DEPT_ID =(select USE_DEPT_ID from MTR_B_INSTOCK where id=p_planid))
            )
            into V_STOCK_ID
            from dual;
           --不存在则创建
            if V_STOCK_ID = '' then
               begin
                  V_STOCK_ID := sys_guid();
                  insert into MDM_D_STOCK(id,STOCK_TYPE_ID,DEPT_ID,NAME,COMMENTS)
                  select V_STOCK_ID,'00320002',i.USE_DEPT_ID,d.NAME,'后台自动创建'
                  from MTR_B_INSTOCK i,COM_DEPART d
                  where i.id = p_planid
                  and d.id = i.use_dept_id;
               end;
            end if;
                        
         end;
      else --备货入库,普通入库
         begin
              --变量初始化
              --1.库存数据类型
              select case when V_INSTOCK_TYPE = '00390001' then '00400001' --普通库存
                     when V_INSTOCK_TYPE = '00390003' then '00400002' --备货库存
                     else '00400001'
              end into V_STOCK_DATA_TYPE from dual; 
              --2.仓库ID     
              select STOCK_ID into V_STOCK_ID
              from MTR_B_INSTOCK where id= p_planid;        
         end;
      end if;
      --创建指定仓库的指定库存数据类型的库存数据
      insert into MTR_B_STOCK_DATA
             (
                id,
                STOCK_ID,
                AMOUNT,
                BATCH_CODE,
                MATER_ID,
                MONEY,
                INVALID_DATE,
                PKG_AMOUNT,
                PRD_DATE,
                PRD_ID,
                PRICE,
                REF_TAB_ID,
                REF_TAB_NAME,
                SPEC,
                STOCK_DATA_TYPE_ID,
                UNIT_ID,
                CREATE_DATE
             )
             select 
                sys_guid(),
                V_STOCK_ID,--仓库变量
                t.AMOUNT,
                t.BATCH_CODE,
                t.MATER_ID,
                t.MONEY,
                t.INVALID_DATE,
                t.PKG_AMOUNT,
                t.PRD_DATE,
                t.PRD_ID,
                t.PRICE,
                t.ID,
                'MTR_B_INSTOCK_D',
                t.SPEC,   
                V_STOCK_DATA_TYPE, --库存数据类型变量            
                t.UNIT_ID,
                sysdate
               from MTR_B_INSTOCK_D t,MTR_B_INSTOCK b
               where t.base_id = p_planid  
               and b.id =t.base_id; 
      --更新关联单据的状态
      --1.采购订单引入
      update MTR_B_PURCHASE_BILL t
                           set t.state = 4
                           where t.id in
                           (
                               select base_id from MTR_B_PURCHASE_BILL_D where id in
                               (
                                 select d.REF_TAB_ID  
                                 from MTR_B_INSTOCK_D d 
                                 where d.REF_TAB_NAME = 'MTR_B_PURCHASE_BILL_D'
                                 and d.base_id =p_planid
                               )
                           );
      --2.到货通知单引入
      update MTR_B_AOG t
                           set t.state = 4
                           where t.id in
                           (
                               select base_id from MTR_B_AOG_D where id in
                               (
                                 select d.REF_TAB_ID  
                                 from MTR_B_INSTOCK_D d 
                                 where d.REF_TAB_NAME = 'MTR_B_AOG_D'
                                  and d.base_id = p_planid
                               )
                           );   
      --更新入库单状态为已审核
      update MTR_B_INSTOCK set state = 3 where id = p_planid;
      
      commit;
      p_msg:= '';
      p_succeed := 1;--返回成功
exception
      when others
        then
        v_ErrorCode := SQLCODE;
        v_ErrorMsg := SQLERRM;
        v_CurrentUser := USER;
        v_Information := '遇到了错误 ' || TO_CHAR(SYSDATE) || ' 数据库用户 ' || v_CurrentUser;
        p_msg:= '执行错误,自动回滚.';
        dbms_output.put_line('执行错误,自动回滚.');
        p_msg:= p_msg || '详细信息:'||'错误代码:'||v_ErrorCode||',错误消息:'||v_ErrorMsg||',日志信息:'||v_Information;
        dbms_output.put_line('详细信息:'||'错误代码:'||v_ErrorCode||',错误消息:'||v_ErrorMsg||',日志信息:'||v_Information);
        /*写失败标志*/
        p_succeed := 0;
        rollback;
END SP_mtr_Audit_instock;
/

prompt
prompt Creating procedure SP_MTR_AUDIT_OUTSTOCK
prompt ========================================
prompt
create or replace procedure SP_mtr_Audit_outstock(p_planid in char,p_msg out varchar2,p_succeed out number )
Authid Current_User 
 as
V_DYNA_SQL clob;
V_EXEC_SQL clob;
V_STATE number(3);
V_NEWID char(36);
V_TEMP_TAB varchar2(50);
V_REQUEST number(22,4);
V_COMPLETED number(22,4);
V_BUDGET_CPN_ID char(36);
V_BUDGET_TEMPLET_ID char(36);
v_ErrorCode varchar2(1024);
v_ErrorMsg varchar2(1024);
v_CurrentUser varchar2(1024);
v_Information varchar2(1024);
v_PATTERN char(36);
V_LEVEL char(36);
/*
1、更新出库单的状态为已审核（MTR_B_OUTSTOCK）
2、扣减库存（MTR_B_STOCK_DATA）
3、更新出库单明细(MTR_B_OUTSTOCK_D)中的零售价格和零售金额,更新凭据为物资（MTR_D_MTR）的加价规则(MTR_D_PRICE_RULE)
4、生成财务凭证/成本数据(待集成实现)
*/
begin   
      for config in(
                    select                    
                    t.ID,
                    t.AMOUNT,                    
                    t.MATER_ID, 
                    t.SPEC,  
                    t.UNIT_ID ,                
                    t.PKG_AMOUNT,                    
                    t.COMMENTS,
                    b.stock_id
                    from  MTR_B_OUTSTOCK_d t,
                    MTR_B_OUTSTOCK b
                    where t.base_id = p_planid
                    and t.base_id = b.id
                  )
              loop
                --更新零售单价
                update MTR_B_OUTSTOCK_d d
                set d.retail_price = d.retail_price * 
                (
                        select INCREASE_SCALE 
                        from MTR_D_PRICE_RULE 
                        where id =
                        (
                           select price_rule_id 
                           from MTR_D_MTR 
                           where id=config.mater_id
                         )
                )                
                where d.id = config.id;
                --更新零售金额
                update MTR_B_OUTSTOCK_d d
                set d.retail_money = d.amount * d.retail_price
                where d.id = config.id;
                --需求量
                V_REQUEST := config.AMOUNT;
                --满足量
                V_COMPLETED:=0;
                while V_COMPLETED <> V_REQUEST /*如果需求未被满足,则持续循环扣减*/
                loop  
                      --记录ID
                      V_NEWID :=sys_guid();
                      --扣减库存
                      insert into MTR_B_STOCK_DATA
                      (
                        id,
                        mater_id,
                        spec,
                        amount,
                        pkg_amount,
                        unit_id,
                        price,
                        money,
                        batch_code,
                        prd_id,
                        prd_date,
                        invalid_date,
                        stock_data_type_id,
                        ref_tab_name,
                        ref_tab_id,
                        retail_price,
                        stock_id,
                        create_date    
                      )
                      select 
                      V_NEWID,
                      t2.mater_id,
                      t2.spec,
                      --判断当前记录的库存量,如果大于等于未满足的需求量,则使用未满足需求量的值进行扣减
                      --否则,则使用当前记录的库存量进行扣减,且进入下一次循环
                      case 
                        when t2.amount >= (V_REQUEST - V_COMPLETED) then V_REQUEST * -1
                        else t2.amount * -1 
                      end,
                      t2.pkg_amount,
                      t2.unit_id,
                      t2.price,
                      t2.money,
                      t2.batch_code,
                      t2.prd_id,
                      t2.prd_date,
                      t2.invalid_date,
                      t2.stock_data_type_id,
                      'MTR_B_OUTSTOCK_D',
                      config.id,
                      t2.retail_price,
                      t2.stock_id,
                      t2.create_date
                      from 
                      (
                          select 
                          t.stock_id, 
                          t.mater_id,
                          t.unit_id,
                          t.stock_data_type_id,
                          sum(t.amount) amount,
                          t.prd_date,
                          t.batch_code,
                          t.prd_id,
                          t.price,
                          t.spec
                          from mtr_b_stock_data t 
                          where 1=1
                          group by --口径与库存视图(v_mtr_stock_data)一致
                          t.stock_id,
                          t.mater_id,
                          t.unit_id,
                          t.stock_data_type_id,
                          t.prd_date,
                          t.batch_code,
                          t.prd_id,
                          t.price,
                          t.spec
                      )
                      t1, --库存数据分组合计
                      (
                          select 
                          id,
                          mater_id,
                          spec,
                          amount,
                          pkg_amount,
                          unit_id,
                          price,
                          money,
                          batch_code,
                          prd_id,
                          prd_date,
                          invalid_date,
                          stock_data_type_id,
                          ref_tab_name,
                          ref_tab_id,
                          retail_price,
                          stock_id,
                          create_date   
                          from mtr_b_stock_data t
                          where t.amount > 0 
                          order by t.prd_date 
                      ) t2 --库存数据先进先出
                      where
                        t1.mater_id = t2.mater_id
                        and t1.stock_id = t2.stock_id
                        and t1.stock_data_type_id = t2.stock_data_type_id
                        and t1.prd_date = t2.prd_date
                        /*and t1.prd_id = t2.prd_id*/
                        /*and t1.spec = t2.spec*/
                        /*and t1.batch_code = t2.batch_code*/
                        /*and t1.unit_id = t2.unit_id*/
                        and t1.amount >0
                                              
                        and t2.stock_id = config.stock_id
                        and t2.stock_data_type_id = '00400001' --普通库存                              
                        and t2.mater_id = config.mater_id                              
                        /*and t2.spec = config.spec*/
                        /*and t2.pkg_amount = config.pkg_amount*/
                        /*and t2.unit_id = config.unit_id*/
  
                                                                    
                        and rownum = 1
                        order by t2.prd_date;
      --更新满足量
      select amount * -1 into V_COMPLETED 
      from MTR_B_STOCK_DATA 
                      where id = V_NEWID;
                end loop;
              end loop;
      
      --更新出库单状态为已审核
      update MTR_B_OUTSTOCK set state = 3 where id = p_planid;
      
      commit;
      p_msg:= '';
      p_succeed := 1;--返回成功
exception
      when others
        then
        v_ErrorCode := SQLCODE;
        v_ErrorMsg := SQLERRM;
        v_CurrentUser := USER;
        v_Information := '遇到了错误 ' || TO_CHAR(SYSDATE) || ' 数据库用户 ' || v_CurrentUser;
        p_msg:= '执行错误,自动回滚.';
        dbms_output.put_line('执行错误,自动回滚.');
        p_msg:= p_msg || '详细信息:'||'错误代码:'||v_ErrorCode||',错误消息:'||v_ErrorMsg||',日志信息:'||v_Information;
        dbms_output.put_line('详细信息:'||'错误代码:'||v_ErrorCode||',错误消息:'||v_ErrorMsg||',日志信息:'||v_Information);
        /*写失败标志*/
        p_succeed := 0;
        rollback;
END SP_mtr_Audit_outstock;
/

prompt
prompt Creating procedure SP_MTR_AUDIT_PURCHASE_PLAN
prompt =============================================
prompt
create or replace procedure SP_mtr_Audit_purchase_plan(p_planid in char,p_msg out varchar2,p_succeed out number )
Authid Current_User 
 as
V_DYNA_SQL clob;
V_EXEC_SQL clob;
V_STATE number(3);
V_PRE_BUDGET_YEAR char(36);
V_TEMP_TAB varchar2(50);
V_NEW_ID char(36);
V_PRICE number(22,4);
V_BUDGET_CPN_ID char(36);
V_BUDGET_TEMPLET_ID char(36);
v_ErrorCode varchar2(1024);
v_ErrorMsg varchar2(1024);
v_CurrentUser varchar2(1024);
v_Information varchar2(1024);
v_PATTERN char(36);
V_LEVEL char(36);
/*
1、审核采购计划（MTR_B_purchase_plan）,
2、按供应商分组生成采购订单（MTR_B_purchase_bill）
3、采购订单明细（MTR_B_purchase_bill_d）中的单价从FN_MTR_GET_MATER_PRICE获取
*/
begin   
   
    --获取供应商分组数据
    for config in(
                    select
                    t.provider_id
                    from  MTR_B_purchase_plan_d t
                    where t.base_id = p_planid
                    group by t.provider_id
                  )
          loop
             execute immediate 'select sys_guid() from dual' into V_NEW_ID;
             --创建采购订单主记录
             insert into MTR_B_PURCHASE_BILL
             (id, BILL_TYPE_ID,CREATE_DATE,DEPT_ID,USER_ID,PROVIDER_ID,CODE)
             select V_NEW_ID,'00420001',sysdate,DEPT_ID,USER_ID,config.provider_id,code
             from MTR_B_purchase_plan where id = p_planid;               
             --创建采购订单明细记录
              for dconfig in(
                    select
                    t.AMOUNT,
                    t.ID,
                    t.COMMENTS,
                    t.DELIVERY_DATE,
                    t.MATER_ID,                   
                    t.PKG_AMOUNT,
                    t.PRD_ID,
                    t.SPEC,
                    t.UNIT_ID 
                    from  MTR_B_purchase_plan_d t
                    where t.base_id = p_planid
                    and  t.provider_id = config.provider_id
                  )
              loop
                --获取价格
                V_PRICE:= FN_MTR_GET_MATER_PRICE(dconfig.mater_id,config.provider_id);
                --生成明细
                insert into MTR_B_PURCHASE_BILL_D
                (id,AMOUNT,BASE_ID,COMMENTS,DELIVERY_DATE,MATER_ID,PKG_AMOUNT,PRD_ID,PRICE,MONEY,SPEC,UNIT_ID)
                select sys_guid(),dconfig.amount,V_NEW_ID,dconfig.COMMENTS,
                dconfig.DELIVERY_DATE,dconfig.MATER_ID,dconfig.PKG_AMOUNT,
                dconfig.PRD_ID,V_PRICE,V_PRICE*dconfig.amount,dconfig.SPEC,dconfig.UNIT_ID
                from dual;
              end loop;
          end loop;
      --审核采购计划
      update MTR_B_purchase_plan t set t.state =3 where id =p_planid;
      commit;
      p_msg:= '';
      p_succeed := 1;--返回成功
exception
      when others
        then
        v_ErrorCode := SQLCODE;
        v_ErrorMsg := SQLERRM;
        v_CurrentUser := USER;
        v_Information := '遇到了错误 ' || TO_CHAR(SYSDATE) || ' 数据库用户 ' || v_CurrentUser;
        p_msg:= '执行错误,自动回滚.';
        dbms_output.put_line('执行错误,自动回滚.');
        p_msg:= p_msg || '详细信息:'||'错误代码:'||v_ErrorCode||',错误消息:'||v_ErrorMsg||',日志信息:'||v_Information;
        dbms_output.put_line('详细信息:'||'错误代码:'||v_ErrorCode||',错误消息:'||v_ErrorMsg||',日志信息:'||v_Information);
        /*写失败标志*/
        p_succeed := 0;
        rollback;
END SP_mtr_Audit_purchase_plan;
/

prompt
prompt Creating procedure SP_MTR_AUDIT_STOCKDATACHECK
prompt ==============================================
prompt
create or replace procedure SP_mtr_Audit_stockdatacheck(p_planid in char,p_msg out varchar2,p_succeed out number )
Authid Current_User 
 as
V_DYNA_SQL clob;
V_EXEC_SQL clob;
V_STATE number(3);
V_NEWID char(36);
V_TEMP_TAB varchar2(50);
V_REQUEST number(22,4);
V_COMPLETED number(22,4);
V_BUDGET_CPN_ID char(36);
V_BUDGET_TEMPLET_ID char(36);
v_ErrorCode varchar2(1024);
v_ErrorMsg varchar2(1024);
v_CurrentUser varchar2(1024);
v_Information varchar2(1024);
v_PATTERN char(36);
V_LEVEL char(36);
/*
1、更新盘点单的状态为已审核（MTR_B_STOCK_data_Check）
2、按照盘点差异值增减库存（MTR_B_STOCK_DATA）
3、生成财务凭证/成本数据(待集成实现)
*/
begin   
      for config in(
                    select                    
                    t.ID,
                    t.AMOUNT,                    
                    t.MATER_ID, 
                    t.SPEC,  
                    t.UNIT_ID ,                
                    t.PKG_AMOUNT, 
                    t.prd_id,
                    t.batch_code,               
                    t.COMMENTS,
                    t.diff_amount,
                    b.stock_id,
                    b.stock_data_type_id
                    from  MTR_B_STOCK_data_Check_d t,
                    MTR_B_STOCK_data_Check b
                    where t.base_id = p_planid
                    and t.base_id = b.id
                    and t.diff_amount <> 0
                  )
              loop
                if config.diff_amount > 0 then --盘盈，要增加库存
                  begin
                       insert into MTR_B_STOCK_DATA
                              (
                                id,
                                mater_id,
                                spec,
                                amount,
                                pkg_amount,
                                unit_id,
                                price,
                                money,
                                batch_code,
                                prd_id,
                                prd_date,
                                invalid_date,
                                stock_data_type_id,
                                ref_tab_name,
                                ref_tab_id,
                                retail_price,
                                stock_id,
                                create_date    
                              )
                              select 
                              sys_guid(),
                              t2.mater_id,
                              t2.spec,
                              config.diff_amount,--差异值（正值）
                              t2.pkg_amount,
                              t2.unit_id,
                              t2.price,
                              t2.money,
                              t2.batch_code,
                              t2.prd_id,
                              t2.prd_date,
                              t2.invalid_date,
                              t2.stock_data_type_id,
                              'MTR_B_STOCK_DATA_CHECK_D',
                              config.id,
                              t2.retail_price,
                              t2.stock_id,
                              t2.create_date
                              from 
                              (
                                  select 
                                  t.stock_id, 
                                  t.mater_id,
                                  t.unit_id,
                                  t.stock_data_type_id,
                                  sum(t.amount) amount,
                                  t.prd_date,
                                  t.batch_code,
                                  t.prd_id,
                                  t.price,
                                  t.spec
                                  from mtr_b_stock_data t 
                                  where 1=1
                                  group by --口径与库存视图(v_mtr_stock_data)一致
                                  t.stock_id,
                                  t.mater_id,
                                  t.unit_id,
                                  t.stock_data_type_id,
                                  t.prd_date,
                                  t.batch_code,
                                  t.prd_id,
                                  t.price,
                                  t.spec
                              )
                              t1, --库存数据分组合计
                              (
                                  select 
                                  id,
                                  mater_id,
                                  spec,
                                  amount,
                                  pkg_amount,
                                  unit_id,
                                  price,
                                  money,
                                  batch_code,
                                  prd_id,
                                  prd_date,
                                  invalid_date,
                                  stock_data_type_id,
                                  ref_tab_name,
                                  ref_tab_id,
                                  retail_price,
                                  stock_id,
                                  create_date   
                                  from mtr_b_stock_data t
                                  where t.amount > 0 
                                  order by t.prd_date 
                              ) t2 --库存数据先进先出
                              where
                                  t1.mater_id = t2.mater_id
                              and t1.stock_id = t2.stock_id
                              and t1.stock_data_type_id = t2.stock_data_type_id
                              and t1.prd_date = t2.prd_date
                              /*and t1.prd_id = t2.prd_id
                              and t1.spec = t2.spec
                              and t1.batch_code = t2.batch_code
                              and t1.unit_id = t2.unit_id*/
                              and t1.amount >0
                              
                              and t2.stock_id = config.stock_id
                              and t2.stock_data_type_id = config.stock_data_type_id                            
                              and t2.mater_id = config.mater_id 
   
                                                    
                              and rownum = 1
                              order by t2.prd_date;
                  end;
                else  --盘亏,要扣减库存
                  begin
                        --需求量
                        V_REQUEST := config.diff_amount * -1;--差异值（负值）
                        --满足量
                        V_COMPLETED:=0;
                        while V_COMPLETED <> V_REQUEST /*如果需求未被满足,则持续循环扣减*/
                        loop  
                              --记录ID
                              V_NEWID :=sys_guid();
                              --扣减库存
                              insert into MTR_B_STOCK_DATA
                              (
                                id,
                                mater_id,
                                spec,
                                amount,
                                pkg_amount,
                                unit_id,
                                price,
                                money,
                                batch_code,
                                prd_id,
                                prd_date,
                                invalid_date,
                                stock_data_type_id,
                                ref_tab_name,
                                ref_tab_id,
                                retail_price,
                                stock_id,
                                create_date    
                              )
                              select 
                              V_NEWID,
                              t2.mater_id,
                              t2.spec,
                              --判断当前记录的库存量,如果大于等于未满足的需求量,则使用未满足需求量的值进行扣减
                              --否则,则使用当前记录的库存量进行扣减,且进入下一次循环
                              case 
                                when t2.amount >= (V_REQUEST - V_COMPLETED) then V_REQUEST * -1
                                else t2.amount * -1 
                              end,
                              t2.pkg_amount,
                              t2.unit_id,
                              t2.price,
                              t2.money,
                              t2.batch_code,
                              t2.prd_id,
                              t2.prd_date,
                              t2.invalid_date,
                              t2.stock_data_type_id,
                              'MTR_B_STOCK_DATA_CHECK_D',
                              config.id,
                              t2.retail_price,
                              t2.stock_id,
                              t2.create_date
                              from 
                              (
                                  select 
                                  t.stock_id, 
                                  t.mater_id,
                                  t.unit_id,
                                  t.stock_data_type_id,
                                  sum(t.amount) amount,
                                  t.prd_date,
                                  t.batch_code,
                                  t.prd_id,
                                  t.price,
                                  t.spec
                                  from mtr_b_stock_data t 
                                  where 1=1
                                  group by --口径与库存视图(v_mtr_stock_data)一致
                                  t.stock_id,
                                  t.mater_id,
                                  t.unit_id,
                                  t.stock_data_type_id,
                                  t.prd_date,
                                  t.batch_code,
                                  t.prd_id,
                                  t.price,
                                  t.spec
                              )
                              t1, --库存数据分组合计
                              (
                                  select 
                                  id,
                                  mater_id,
                                  spec,
                                  amount,
                                  pkg_amount,
                                  unit_id,
                                  price,
                                  money,
                                  batch_code,
                                  prd_id,
                                  prd_date,
                                  invalid_date,
                                  stock_data_type_id,
                                  ref_tab_name,
                                  ref_tab_id,
                                  retail_price,
                                  stock_id,
                                  create_date   
                                  from mtr_b_stock_data t
                                  where t.amount > 0 
                                  order by t.prd_date 
                              ) t2 --库存数据先进先出
                              where
                                  t1.mater_id = t2.mater_id
                              and t1.stock_id = t2.stock_id
                              and t1.stock_data_type_id = t2.stock_data_type_id
                              and t1.prd_date = t2.prd_date
                              /*
                              and t1.prd_id = t2.prd_id
                              and t1.spec = t2.spec
                              and t1.batch_code = t2.batch_code
                              and t1.unit_id = t2.unit_id*/
                              and t1.amount >0
                              
                              and t2.stock_id = config.stock_id
                              and t2.stock_data_type_id = config.stock_data_type_id                             
                              and t2.mater_id = config.mater_id  
                              
                                                           
                                                    
                              and rownum = 1
                              order by t2.prd_date;
                              --更新满足量
                              select amount * -1 into V_COMPLETED 
                              from MTR_B_STOCK_DATA 
                              where id = V_NEWID;
                        end loop;
                  end;
                end if;             
              end loop;
      
      --更新出库单状态为已审核
      update MTR_B_STOCK_data_Check set state = 3 where id = p_planid;
      
      commit;
      p_msg:= '';
      p_succeed := 1;--返回成功
exception
      when others
        then
        v_ErrorCode := SQLCODE;
        v_ErrorMsg := SQLERRM;
        v_CurrentUser := USER;
        v_Information := '遇到了错误 ' || TO_CHAR(SYSDATE) || ' 数据库用户 ' || v_CurrentUser;
        p_msg:= '执行错误,自动回滚.';
        dbms_output.put_line('执行错误,自动回滚.');
        p_msg:= p_msg || '详细信息:'||'错误代码:'||v_ErrorCode||',错误消息:'||v_ErrorMsg||',日志信息:'||v_Information;
        dbms_output.put_line('详细信息:'||'错误代码:'||v_ErrorCode||',错误消息:'||v_ErrorMsg||',日志信息:'||v_Information);
        /*写失败标志*/
        p_succeed := 0;
        rollback;
END SP_mtr_Audit_stockdatacheck;
/

prompt
prompt Creating procedure SP_MTR_AUDIT_STOCKDATAMOVE
prompt =============================================
prompt
create or replace procedure SP_mtr_Audit_stockdatamove(p_planid in char,p_msg out varchar2,p_succeed out number )
Authid Current_User 
 as
V_DYNA_SQL clob;
V_EXEC_SQL clob;
V_STATE number(3);
V_NEWID char(36);
V_TEMP_TAB varchar2(50);
V_REQUEST number(22,4);
V_COMPLETED number(22,4);
V_BUDGET_CPN_ID char(36);
V_BUDGET_TEMPLET_ID char(36);
v_ErrorCode varchar2(1024);
v_ErrorMsg varchar2(1024);
v_CurrentUser varchar2(1024);
v_Information varchar2(1024);
v_PATTERN char(36);
V_LEVEL char(36);
/*
1、更新调拨单的状态为已审核（MTR_B_STOCK_data_move）
2、按照调拨数量增减库存（MTR_B_STOCK_DATA）
*/
begin   
      for config in(
                    select                    
                    t.ID,
                    t.AMOUNT,                    
                    t.MATER_ID, 
                    t.SPEC,  
                    t.UNIT_ID ,                
                    t.PKG_AMOUNT, 
                    t.prd_id,
                    t.batch_code,               
                    t.COMMENTS,
                    t.MOVE_AMOUNT,
                    b.from_stock_id,
                    b.to_stock_id,
                    b.stock_data_type_id
                    from  MTR_B_STOCK_data_move_d t,
                    MTR_B_STOCK_data_move b
                    where t.base_id = p_planid
                    and t.base_id = b.id
                    and t.MOVE_AMOUNT <> 0
                  )
              loop
                --调入库,要增加库存
                       insert into MTR_B_STOCK_DATA
                              (
                                id,
                                mater_id,
                                spec,
                                amount,
                                pkg_amount,
                                unit_id,
                                price,
                                money,
                                batch_code,
                                prd_id,
                                prd_date,
                                invalid_date,
                                stock_data_type_id,
                                ref_tab_name,
                                ref_tab_id,
                                retail_price,
                                stock_id,
                                create_date    
                              )
                              select 
                              sys_guid(),
                              t2.mater_id,
                              t2.spec,
                              config.move_amount,--调拨量
                              t2.pkg_amount,
                              t2.unit_id,
                              t2.price,
                              t2.money,
                              t2.batch_code,
                              t2.prd_id,
                              t2.prd_date,
                              t2.invalid_date,
                              t2.stock_data_type_id,
                              'MTR_B_STOCK_DATA_MOVE_D',
                              config.id,
                              t2.retail_price,
                              config.to_stock_id,--调入库
                              t2.create_date
                              from 
                              (
                                  select 
                                  t.stock_id, 
                                  t.mater_id,
                                  t.unit_id,
                                  t.stock_data_type_id,
                                  sum(t.amount) amount,
                                  t.prd_date,
                                  t.batch_code,
                                  t.prd_id,
                                  t.price,
                                  t.spec
                                  from mtr_b_stock_data t 
                                  where 1=1
                                  group by --口径与库存视图(v_mtr_stock_data)一致
                                  t.stock_id,
                                  t.mater_id,
                                  t.unit_id,
                                  t.stock_data_type_id,
                                  t.prd_date,
                                  t.batch_code,
                                  t.prd_id,
                                  t.price,
                                  t.spec
                              )
                              t1, --库存数据分组合计
                              (
                                  select 
                                  id,
                                  mater_id,
                                  spec,
                                  amount,
                                  pkg_amount,
                                  unit_id,
                                  price,
                                  money,
                                  batch_code,
                                  prd_id,
                                  prd_date,
                                  invalid_date,
                                  stock_data_type_id,
                                  ref_tab_name,
                                  ref_tab_id,
                                  retail_price,
                                  stock_id,
                                  create_date   
                                  from mtr_b_stock_data t
                                  where t.amount > 0 
                                  order by t.prd_date 
                              ) t2 --库存数据先进先出
                              where
                                  t1.mater_id = t2.mater_id
                              and t1.stock_id = t2.stock_id
                              and t1.stock_data_type_id = t2.stock_data_type_id
                              and t1.prd_date = t2.prd_date
                              /*and t1.prd_id = t2.prd_id
                              and t1.spec = t2.spec
                              and t1.batch_code = t2.batch_code
                              and t1.unit_id = t2.unit_id*/
                              and t1.amount >0
                              
                              and t2.stock_id = config.from_stock_id --从调出库取库存
                              and t2.stock_data_type_id = config.stock_data_type_id                             
                              and t2.mater_id = config.mater_id 
   
                                                    
                              and rownum = 1
                              order by t2.prd_date;
                --调出库,要扣减库存
                        --需求量
                        V_REQUEST := config.move_amount;--调拨量
                        --满足量
                        V_COMPLETED:=0;
                        while V_COMPLETED <> V_REQUEST /*如果需求未被满足,则持续循环扣减*/
                        loop  
                              --记录ID
                              V_NEWID :=sys_guid();                            
                              --扣减库存
                              insert into MTR_B_STOCK_DATA
                              (
                                id,
                                mater_id,
                                spec,
                                amount,
                                pkg_amount,
                                unit_id,
                                price,
                                money,
                                batch_code,
                                prd_id,
                                prd_date,
                                invalid_date,
                                stock_data_type_id,
                                ref_tab_name,
                                ref_tab_id,
                                retail_price,
                                stock_id,
                                create_date    
                              )
                              select 
                              V_NEWID,
                              t2.mater_id,
                              t2.spec,
                              --判断当前记录的库存量,如果大于等于未满足的需求量,则使用未满足需求量的值进行扣减
                              --否则,则使用当前记录的库存量进行扣减,且进入下一次循环
                              case 
                                when t2.amount >= (V_REQUEST - V_COMPLETED) then V_REQUEST * -1
                                else t2.amount * -1 
                              end,
                              t2.pkg_amount,
                              t2.unit_id,
                              t2.price,
                              t2.money,
                              t2.batch_code,
                              t2.prd_id,
                              t2.prd_date,
                              t2.invalid_date,
                              t2.stock_data_type_id,
                              'MTR_B_STOCK_DATA_MOVE_D',
                              config.id,
                              t2.retail_price,
                              config.from_stock_id,--调出库
                              t2.create_date
                              from 
                              (
                                  select 
                                  t.stock_id, 
                                  t.mater_id,
                                  t.unit_id,
                                  t.stock_data_type_id,
                                  sum(t.amount) amount,
                                  t.prd_date,
                                  t.batch_code,
                                  t.prd_id,
                                  t.price,
                                  t.spec
                                  from mtr_b_stock_data t 
                                  where 1=1
                                  group by --口径与库存视图(v_mtr_stock_data)一致
                                  t.stock_id,
                                  t.mater_id,
                                  t.unit_id,
                                  t.stock_data_type_id,
                                  t.prd_date,
                                  t.batch_code,
                                  t.prd_id,
                                  t.price,
                                  t.spec
                              )
                              t1, --库存数据分组合计
                              (
                                  select 
                                  id,
                                  mater_id,
                                  spec,
                                  amount,
                                  pkg_amount,
                                  unit_id,
                                  price,
                                  money,
                                  batch_code,
                                  prd_id,
                                  prd_date,
                                  invalid_date,
                                  stock_data_type_id,
                                  ref_tab_name,
                                  ref_tab_id,
                                  retail_price,
                                  stock_id,
                                  create_date   
                                  from mtr_b_stock_data t
                                  where t.amount > 0 
                                  order by t.prd_date 
                              ) t2 --库存数据先进先出
                              where
                                  t1.mater_id = t2.mater_id
                              and t1.stock_id = t2.stock_id
                              and t1.stock_data_type_id = t2.stock_data_type_id
                              and t1.prd_date = t2.prd_date
                              /*
                              and t1.prd_id = t2.prd_id
                              and t1.spec = t2.spec
                              and t1.batch_code = t2.batch_code
                              and t1.unit_id = t2.unit_id*/
                              and t1.amount >0
                              
                              and t2.stock_id = config.from_stock_id --从调出库取库存
                              and t2.stock_data_type_id = config.stock_data_type_id                             
                              and t2.mater_id = config.mater_id                              
                                                           
                                                    
                              and rownum = 1
                              order by t2.prd_date;

                              --更新满足量
                              select amount * -1 into V_COMPLETED 
                              from MTR_B_STOCK_DATA 
                              where id = V_NEWID;
                        end loop;
           
              end loop;      
      --更新出库单状态为已审核
      update MTR_B_STOCK_data_move set state = 3 where id = p_planid;
      
      commit;
      p_msg:= '';
      p_succeed := 1;--返回成功
exception
      when others
        then
        v_ErrorCode := SQLCODE;
        v_ErrorMsg := SQLERRM;
        v_CurrentUser := USER;
        v_Information := '遇到了错误 ' || TO_CHAR(SYSDATE) || ' 数据库用户 ' || v_CurrentUser;
        p_msg:= '执行错误,自动回滚.';
        dbms_output.put_line('执行错误,自动回滚.');
        p_msg:= p_msg || '详细信息:'||'错误代码:'||v_ErrorCode||',错误消息:'||v_ErrorMsg||',日志信息:'||v_Information;
        dbms_output.put_line('详细信息:'||'错误代码:'||v_ErrorCode||',错误消息:'||v_ErrorMsg||',日志信息:'||v_Information);
        /*写失败标志*/
        p_succeed := 0;
        rollback;
END SP_mtr_Audit_stockdatamove;
/

prompt
prompt Creating procedure SP_MTR_CREATE_INSTOCK_REQ_SUM
prompt ================================================
prompt
create or replace procedure SP_mtr_create_instock_req_sum(p_planid in char,p_msg out varchar2,p_succeed out number )
Authid Current_User 
 as
V_DYNA_SQL clob;
V_EXEC_SQL clob;
V_STATE number(3);
V_PRE_BUDGET_YEAR char(36);
V_TEMP_TAB varchar2(50);
V_BUDGET_CPN_ID char(36);
V_BUDGET_TEMPLET_ID char(36);
v_ErrorCode varchar2(1024);
v_ErrorMsg varchar2(1024);
v_CurrentUser varchar2(1024);
v_Information varchar2(1024);
v_PATTERN char(36);
V_LEVEL char(36);
/*
1、汇总所有已审核的部门入库计划申请（MTR_B_instock_req）
*/
begin
    --初始化变量
    execute immediate 'select ''TMP_REQ'' from dual' into V_TEMP_TAB;
    dbms_output.put_line(V_TEMP_TAB);
    --清空跟踪表
    execute immediate ' delete from MTR_B_INSTOCK_REQ_SUM_C where base_id='''||p_planid||'''';
    --清空明细表
    execute immediate ' delete from MTR_B_INSTOCK_REQ_SUM_d where base_id='''||p_planid||'''';
    --创建事务级临时表
    execute immediate 'CREATE GLOBAL TEMPORARY TABLE '||V_TEMP_TAB||'
     (
        id              CHAR(36) not null,
        mater_id        CHAR(36),
        spec            VARCHAR2(50),
        apply_amount    NUMBER(22,4),
        approved_amount NUMBER(22,4),
        unit_id         CHAR(36),
        pkg_amount      NUMBER(22,4),
        price           NUMBER(22,4),
        money           NUMBER(22,4),
        comments        VARCHAR2(200)    
     )ON COMMIT DELETE ROWS';
    --取所有已审核状态的部门入库计划申请（MTR_B_instock_req）
    for config in(
                    select
                    t.id
                    from  MTR_B_instock_req t
                    where t.state = 3
                  )
          loop
             --向临时表中插入输入
             execute immediate 'insert into '||V_TEMP_TAB||'(id,mater_id,spec,apply_amount,approved_amount,
             unit_id,pkg_amount,price,money,comments)
             select d.id,d.mater_id,d.spec,
             d.apply_amount,d.approved_amount,d.unit_id,
             d.pkg_amount,d.price,d.money,d.comments 
             from MTR_B_instock_req_d d where d.base_id = '''|| config.id||'''';
             --向跟踪表插入
             execute immediate 'insert into MTR_B_INSTOCK_REQ_SUM_C(id,base_id,ref_tab_name,ref_tab_id)
             select sys_guid(), '''||p_planid||''',''MTR_B_instock_req'','''||config.id||''' from dual';
          end loop;
          --向明细表插入          
          execute immediate 'insert into 
          MTR_B_INSTOCK_REQ_SUM_d
          (
            id,
            base_id,
            mater_id,
            spec,
            apply_amount,
            approved_amount,
            unit_id,
            pkg_amount,
            price,
            money,
            comments
            )
             select sys_guid(), 
             '''||p_planid||''',
             mater_id,
             spec,
             sum(apply_amount),
             sum(apply_amount),
             unit_id,sum(pkg_amount),
             price,sum(money),''''
             from '||V_TEMP_TAB||'
             group by '''||p_planid||''',
             mater_id,
             spec,
             unit_id,
             price';
             --删除临时表
             execute immediate 'Drop  TABLE '||V_TEMP_TAB; 
             --更新明细记录中的库存数量
             for config in(
                select
                t.id
                from  MTR_B_INSTOCK_REQ_SUM_d t
                where t.base_id = p_planid
              )
              loop  
                update MTR_B_INSTOCK_REQ_SUM_d d
                set d.stock_amount =
                (
                 select nvl(v.amount,0) from v_mtr_stock_data v
                 where v.mater_id = d.mater_id
                )
                where d.id = config.id;
              end loop;   
      commit;
      p_msg:= '';
      p_succeed := 1;--返回成功
exception
      when others
        then
        v_ErrorCode := SQLCODE;
        v_ErrorMsg := SQLERRM;
        v_CurrentUser := USER;
        v_Information := '遇到了错误 ' || TO_CHAR(SYSDATE) || ' 数据库用户 ' || v_CurrentUser;
        p_msg:= '执行错误,自动回滚.';
        dbms_output.put_line('执行错误,自动回滚.');
        p_msg:= p_msg || '详细信息:'||'错误代码:'||v_ErrorCode||',错误消息:'||v_ErrorMsg||',日志信息:'||v_Information;
        dbms_output.put_line('详细信息:'||'错误代码:'||v_ErrorCode||',错误消息:'||v_ErrorMsg||',日志信息:'||v_Information);
        /*写失败标志*/
        p_succeed := 0;
        rollback;
END SP_mtr_create_instock_req_sum;
/

prompt
prompt Creating procedure SP_MTR_CREATE_STOCKDATA_CHK_D
prompt ================================================
prompt
create or replace procedure SP_mtr_create_stockdata_chk_d(p_planid in char,p_msg out varchar2,p_succeed out number )
Authid Current_User 
 as
V_DYNA_SQL clob;
V_EXEC_SQL clob;
V_ROWCOUNT number(3);
V_PRE_BUDGET_YEAR char(36);
V_TEMP_TAB varchar2(50);
V_BUDGET_CPN_ID char(36);
V_BUDGET_TEMPLET_ID char(36);
v_ErrorCode varchar2(1024);
v_ErrorMsg varchar2(1024);
v_CurrentUser varchar2(1024);
v_Information varchar2(1024);
v_PATTERN char(36);
V_LEVEL char(36);
/*
1、生成盘点数据清单（MTR_B_STOCK_DATA_CHECK_D）
2、如果按类型盘点设置存在，则只生成指定类型的盘点数据(MTR_B_STOCK_DATA_CHECK_type)
*/
begin
      --删除记录
      delete from MTR_B_STOCK_DATA_CHECK_D where base_id=p_planid;
      --组织语句
      V_EXEC_SQL := '
      insert into MTR_B_STOCK_DATA_CHECK_D
      (
          id ,
          base_id,
          mater_id ,
          spec,
          amount,
          pkg_amount,
          unit_id,
          batch_code,
          prd_id,
          comments,
          check_amount,
          diff_amount
      )
      select sys_guid(),
      c.id,
      t.mater_id,
      t.spec,
      t.amount,
      t.pkg_amount,
      t.unit_id,
      t.batch_code,
      t.prd_id,
      null,
      0,
      0      
      from v_mtr_stock_data t,
      MTR_B_STOCK_DATA_CHECK c,
      mtr_d_mtr_type mt,
      mtr_d_mtr m
      where t.stock_id = c.stock_id
      and t.stock_data_type_id = c.stock_data_type_id
      and c.id='''||p_planid||'''
      and t.mater_id = m.id
      and m.type_id = mt.id ';
      --检查是否存在物资类型设置
      select count(*) into V_ROWCOUNT from MTR_B_STOCK_DATA_CHECK_type where base_id = p_planid;
      if V_ROWCOUNT > 0 then
         begin
            V_EXEC_SQL := V_EXEC_SQL || ' and mt.id in
      (
          select ct.type_id from MTR_B_STOCK_DATA_CHECK_type ct
          where ct.base_id = '''||p_planid||'''
      )';
         end;
      end if;
      dbms_output.put_line (V_EXEC_SQL);      
      --新增记录
      execute immediate  V_EXEC_SQL;  
      commit;
      p_msg:= '';
      p_succeed := 1;--返回成功
exception
      when others
        then
        v_ErrorCode := SQLCODE;
        v_ErrorMsg := SQLERRM;
        v_CurrentUser := USER;
        v_Information := '遇到了错误 ' || TO_CHAR(SYSDATE) || ' 数据库用户 ' || v_CurrentUser;
        p_msg:= '执行错误,自动回滚.';
        dbms_output.put_line('执行错误,自动回滚.');
        p_msg:= p_msg || '详细信息:'||'错误代码:'||v_ErrorCode||',错误消息:'||v_ErrorMsg||',日志信息:'||v_Information;
        dbms_output.put_line('详细信息:'||'错误代码:'||v_ErrorCode||',错误消息:'||v_ErrorMsg||',日志信息:'||v_Information);
        /*写失败标志*/
        p_succeed := 0;
        rollback;
END SP_mtr_create_stockdata_chk_d;
/

prompt
prompt Creating procedure SP_MTR_CREATE_STOCKDATA_MOVE_D
prompt =================================================
prompt
create or replace procedure SP_mtr_create_stockdata_move_d(p_planid in char,p_msg out varchar2,p_succeed out number )
Authid Current_User 
 as
V_DYNA_SQL clob;
V_EXEC_SQL clob;
V_ROWCOUNT number(3);
V_PRE_BUDGET_YEAR char(36);
V_TEMP_TAB varchar2(50);
V_BUDGET_CPN_ID char(36);
V_BUDGET_TEMPLET_ID char(36);
v_ErrorCode varchar2(1024);
v_ErrorMsg varchar2(1024);
v_CurrentUser varchar2(1024);
v_Information varchar2(1024);
v_PATTERN char(36);
V_LEVEL char(36);
/*
1、生成调拨数据清单（MTR_B_STOCK_DATA_MOVE_D）
*/
begin
      --删除记录
      delete from MTR_B_STOCK_DATA_MOVE_D where base_id=p_planid;
      --组织语句

      insert into MTR_B_STOCK_DATA_MOVE_D
      (
        id ,
        base_id,
        mater_id,
        spec ,
        amount,
        pkg_amount,
        unit_id,
        price,
        money ,
        batch_code,
        prd_id ,
        prd_date ,
        comments,
        move_amount 
      )
      select sys_guid(),
      b.id,
      t.mater_id,
      t.spec,
      t.amount,
      t.pkg_amount,
      t.unit_id,
      t.price,
      t.money,
      t.batch_code,
      t.prd_id,
      t.prd_date,
      null,      
      0      
      from v_mtr_stock_data t,
      MTR_B_STOCK_DATA_MOVE b,
      mtr_d_mtr_type mt,
      mtr_d_mtr m
      where t.stock_id = b.from_stock_id
      and t.stock_data_type_id = b.stock_data_type_id
      and b.id= p_planid 
      and t.mater_id = m.id
      and m.type_id = mt.id;    

      commit;
      p_msg:= '';
      p_succeed := 1;--返回成功
exception
      when others
        then
        v_ErrorCode := SQLCODE;
        v_ErrorMsg := SQLERRM;
        v_CurrentUser := USER;
        v_Information := '遇到了错误 ' || TO_CHAR(SYSDATE) || ' 数据库用户 ' || v_CurrentUser;
        p_msg:= '执行错误,自动回滚.';
        dbms_output.put_line('执行错误,自动回滚.');
        p_msg:= p_msg || '详细信息:'||'错误代码:'||v_ErrorCode||',错误消息:'||v_ErrorMsg||',日志信息:'||v_Information;
        dbms_output.put_line('详细信息:'||'错误代码:'||v_ErrorCode||',错误消息:'||v_ErrorMsg||',日志信息:'||v_Information);
        /*写失败标志*/
        p_succeed := 0;
        rollback;
END SP_mtr_create_stockdata_move_d;
/


spool off
