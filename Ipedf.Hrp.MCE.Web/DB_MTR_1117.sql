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
  is '����';
comment on column MTR_B_AOG.create_date
  is '��������';
comment on column MTR_B_AOG.stock_id
  is '�����ֿ�';
comment on column MTR_B_AOG.provider_id
  is '������˾';
comment on column MTR_B_AOG.user_id
  is '�Ǽ���';
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
  is '����';
comment on column MTR_B_AOG_D.spec
  is '���';
comment on column MTR_B_AOG_D.amount
  is '����';
comment on column MTR_B_AOG_D.pkg_amount
  is '��װ����';
comment on column MTR_B_AOG_D.unit_id
  is '��λ';
comment on column MTR_B_AOG_D.price
  is '����';
comment on column MTR_B_AOG_D.money
  is '���';
comment on column MTR_B_AOG_D.batch_code
  is '����';
comment on column MTR_B_AOG_D.prd_id
  is '����';
comment on column MTR_B_AOG_D.prd_date
  is '��������';
comment on column MTR_B_AOG_D.invalid_date
  is 'ʧЧ����';
comment on column MTR_B_AOG_D.comments
  is '��ע';
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
  is '����';
comment on column MTR_B_INSTOCK.create_date
  is '�������';
comment on column MTR_B_INSTOCK.instock_type_id
  is '�������';
comment on column MTR_B_INSTOCK.stock_id
  is '���ֿ�';
comment on column MTR_B_INSTOCK.provider_id
  is '������˾';
comment on column MTR_B_INSTOCK.invoice_code
  is '��Ʊ��';
comment on column MTR_B_INSTOCK.invoice_date
  is '��Ʊ����';
comment on column MTR_B_INSTOCK.user_id
  is '�����';
comment on column MTR_B_INSTOCK.use_dept_id
  is '���ÿ���';
comment on column MTR_B_INSTOCK.use_user_id
  is '������';
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
  is '����';
comment on column MTR_B_INSTOCK_D.spec
  is '���';
comment on column MTR_B_INSTOCK_D.amount
  is '����';
comment on column MTR_B_INSTOCK_D.pkg_amount
  is '��װ����';
comment on column MTR_B_INSTOCK_D.unit_id
  is '��λ';
comment on column MTR_B_INSTOCK_D.price
  is '����';
comment on column MTR_B_INSTOCK_D.money
  is '���';
comment on column MTR_B_INSTOCK_D.batch_code
  is '����';
comment on column MTR_B_INSTOCK_D.prd_id
  is '����';
comment on column MTR_B_INSTOCK_D.prd_date
  is '��������';
comment on column MTR_B_INSTOCK_D.invalid_date
  is 'ʧЧ����';
comment on column MTR_B_INSTOCK_D.comments
  is '��ע';
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
  is '�ƻ�����';
comment on column MTR_B_INSTOCK_REQ.dept_id
  is '�ƻ�����';
comment on column MTR_B_INSTOCK_REQ.user_id
  is '�ƻ���';
comment on column MTR_B_INSTOCK_REQ.code
  is '����';
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
  is '����';
comment on column MTR_B_INSTOCK_REQ_D.spec
  is '���';
comment on column MTR_B_INSTOCK_REQ_D.apply_amount
  is '�ƻ�����';
comment on column MTR_B_INSTOCK_REQ_D.approved_amount
  is '��׼����';
comment on column MTR_B_INSTOCK_REQ_D.unit_id
  is '��λ';
comment on column MTR_B_INSTOCK_REQ_D.pkg_amount
  is '��װ����';
comment on column MTR_B_INSTOCK_REQ_D.price
  is '�ƻ��۸�';
comment on column MTR_B_INSTOCK_REQ_D.money
  is '�ƻ����';
comment on column MTR_B_INSTOCK_REQ_D.comments
  is '��ע';
comment on column MTR_B_INSTOCK_REQ_D.delivery_date
  is '��������';
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
  is '����';
comment on column MTR_B_INSTOCK_REQ_SUM.create_date
  is '�ƻ�����';
comment on column MTR_B_INSTOCK_REQ_SUM.dept_id
  is '�ƻ�����';
comment on column MTR_B_INSTOCK_REQ_SUM.user_id
  is '�ƻ���';
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
  is '����';
comment on column MTR_B_INSTOCK_REQ_SUM_D.spec
  is '���';
comment on column MTR_B_INSTOCK_REQ_SUM_D.apply_amount
  is '��������';
comment on column MTR_B_INSTOCK_REQ_SUM_D.approved_amount
  is '�ɹ�����';
comment on column MTR_B_INSTOCK_REQ_SUM_D.unit_id
  is '��λ';
comment on column MTR_B_INSTOCK_REQ_SUM_D.pkg_amount
  is '��װ����';
comment on column MTR_B_INSTOCK_REQ_SUM_D.price
  is '�ƻ��۸�';
comment on column MTR_B_INSTOCK_REQ_SUM_D.money
  is '�ƻ����';
comment on column MTR_B_INSTOCK_REQ_SUM_D.comments
  is '��ע';
comment on column MTR_B_INSTOCK_REQ_SUM_D.stock_amount
  is '�������';
comment on column MTR_B_INSTOCK_REQ_SUM_D.delivery_date
  is '��������';
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
  is '����';
comment on column MTR_B_OUTSTOCK.create_date
  is '��������';
comment on column MTR_B_OUTSTOCK.outstock_type_id
  is '��������';
comment on column MTR_B_OUTSTOCK.stock_id
  is '����ֿ�';
comment on column MTR_B_OUTSTOCK.user_id
  is '������';
comment on column MTR_B_OUTSTOCK.use_dept_id
  is '���ÿ���';
comment on column MTR_B_OUTSTOCK.use_user_id
  is '������';
comment on column MTR_B_OUTSTOCK.purpose
  is '��;';
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
  is '����';
comment on column MTR_B_OUTSTOCK_D.spec
  is '���';
comment on column MTR_B_OUTSTOCK_D.amount
  is '����';
comment on column MTR_B_OUTSTOCK_D.pkg_amount
  is '��װ����';
comment on column MTR_B_OUTSTOCK_D.unit_id
  is '��λ';
comment on column MTR_B_OUTSTOCK_D.price
  is '����';
comment on column MTR_B_OUTSTOCK_D.money
  is '���';
comment on column MTR_B_OUTSTOCK_D.batch_code
  is '����';
comment on column MTR_B_OUTSTOCK_D.prd_id
  is '����';
comment on column MTR_B_OUTSTOCK_D.prd_date
  is '��������';
comment on column MTR_B_OUTSTOCK_D.invalid_date
  is 'ʧЧ����';
comment on column MTR_B_OUTSTOCK_D.comments
  is '��ע';
comment on column MTR_B_OUTSTOCK_D.retail_price
  is '���ۼ۸�';
comment on column MTR_B_OUTSTOCK_D.retail_money
  is '���۽��';
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
  is '����';
comment on column MTR_B_PURCHASE_BILL.create_date
  is '��������';
comment on column MTR_B_PURCHASE_BILL.provider_id
  is '��Ӧ��';
comment on column MTR_B_PURCHASE_BILL.bill_type_id
  is '��������';
comment on column MTR_B_PURCHASE_BILL.dept_id
  is '��������';
comment on column MTR_B_PURCHASE_BILL.user_id
  is '������';
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
  is '����';
comment on column MTR_B_PURCHASE_BILL_D.spec
  is '���';
comment on column MTR_B_PURCHASE_BILL_D.amount
  is '����';
comment on column MTR_B_PURCHASE_BILL_D.pkg_amount
  is '��װ����';
comment on column MTR_B_PURCHASE_BILL_D.unit_id
  is '��λ';
comment on column MTR_B_PURCHASE_BILL_D.price
  is '����';
comment on column MTR_B_PURCHASE_BILL_D.money
  is '���';
comment on column MTR_B_PURCHASE_BILL_D.comments
  is '��ע';
comment on column MTR_B_PURCHASE_BILL_D.prd_id
  is '��������';
comment on column MTR_B_PURCHASE_BILL_D.delivery_date
  is '��������';
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
  is '����';
comment on column MTR_B_PURCHASE_PLAN.create_date
  is '�ƻ�����';
comment on column MTR_B_PURCHASE_PLAN.plan_type_id
  is '�ƻ�����';
comment on column MTR_B_PURCHASE_PLAN.dept_id
  is '�ƻ�����';
comment on column MTR_B_PURCHASE_PLAN.user_id
  is '�ƻ���';
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
  is '��Ӧ��';
comment on column MTR_B_PURCHASE_PLAN_D.mater_id
  is '����';
comment on column MTR_B_PURCHASE_PLAN_D.spec
  is '���';
comment on column MTR_B_PURCHASE_PLAN_D.amount
  is '����';
comment on column MTR_B_PURCHASE_PLAN_D.pkg_amount
  is '��װ����';
comment on column MTR_B_PURCHASE_PLAN_D.unit_id
  is '��λ';
comment on column MTR_B_PURCHASE_PLAN_D.price
  is '����';
comment on column MTR_B_PURCHASE_PLAN_D.money
  is '���';
comment on column MTR_B_PURCHASE_PLAN_D.comments
  is '��ע';
comment on column MTR_B_PURCHASE_PLAN_D.prd_id
  is '��������';
comment on column MTR_B_PURCHASE_PLAN_D.delivery_date
  is '��������';
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
  is '����';
comment on column MTR_B_STOCK_DATA.spec
  is '���';
comment on column MTR_B_STOCK_DATA.amount
  is '����';
comment on column MTR_B_STOCK_DATA.pkg_amount
  is '��װ����';
comment on column MTR_B_STOCK_DATA.unit_id
  is '��λ';
comment on column MTR_B_STOCK_DATA.price
  is '����';
comment on column MTR_B_STOCK_DATA.money
  is '���';
comment on column MTR_B_STOCK_DATA.batch_code
  is '����';
comment on column MTR_B_STOCK_DATA.prd_id
  is '����';
comment on column MTR_B_STOCK_DATA.prd_date
  is '��������';
comment on column MTR_B_STOCK_DATA.invalid_date
  is 'ʧЧ����';
comment on column MTR_B_STOCK_DATA.stock_data_type_id
  is '�����������';
comment on column MTR_B_STOCK_DATA.ref_tab_name
  is '��������';
comment on column MTR_B_STOCK_DATA.ref_tab_id
  is '������¼';
comment on column MTR_B_STOCK_DATA.retail_price
  is '���۵���';
comment on column MTR_B_STOCK_DATA.stock_id
  is '�ֿ�';
comment on column MTR_B_STOCK_DATA.create_date
  is '����';
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
  is '����';
comment on column MTR_B_STOCK_DATA_CHECK.create_date
  is '�̵�����';
comment on column MTR_B_STOCK_DATA_CHECK.check_type_id
  is '�̵�����';
comment on column MTR_B_STOCK_DATA_CHECK.stock_id
  is '�̵�ֿ�';
comment on column MTR_B_STOCK_DATA_CHECK.user_id
  is '�̵���';
comment on column MTR_B_STOCK_DATA_CHECK.dept_id
  is '�̵����';
comment on column MTR_B_STOCK_DATA_CHECK.stock_data_type_id
  is '�������';
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
  is '����';
comment on column MTR_B_STOCK_DATA_CHECK_D.spec
  is '���';
comment on column MTR_B_STOCK_DATA_CHECK_D.amount
  is '�������';
comment on column MTR_B_STOCK_DATA_CHECK_D.pkg_amount
  is '��װ����';
comment on column MTR_B_STOCK_DATA_CHECK_D.unit_id
  is '��λ';
comment on column MTR_B_STOCK_DATA_CHECK_D.batch_code
  is '����';
comment on column MTR_B_STOCK_DATA_CHECK_D.prd_id
  is '����';
comment on column MTR_B_STOCK_DATA_CHECK_D.comments
  is '��ע';
comment on column MTR_B_STOCK_DATA_CHECK_D.check_amount
  is '�̵�����';
comment on column MTR_B_STOCK_DATA_CHECK_D.diff_amount
  is '��������';
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
  is '���ʷ���';
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
  is '��������';
comment on column MTR_B_STOCK_DATA_MOVE.create_date
  is '��������';
comment on column MTR_B_STOCK_DATA_MOVE.from_stock_id
  is '����ֿ�';
comment on column MTR_B_STOCK_DATA_MOVE.to_stock_id
  is '���ֿ�';
comment on column MTR_B_STOCK_DATA_MOVE.user_id
  is '������';
comment on column MTR_B_STOCK_DATA_MOVE.dept_id
  is '��������';
comment on column MTR_B_STOCK_DATA_MOVE.purpose
  is '��;';
comment on column MTR_B_STOCK_DATA_MOVE.stock_data_type_id
  is '�����������';
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
  is '����';
comment on column MTR_B_STOCK_DATA_MOVE_D.spec
  is '���';
comment on column MTR_B_STOCK_DATA_MOVE_D.amount
  is '����';
comment on column MTR_B_STOCK_DATA_MOVE_D.pkg_amount
  is '��װ����';
comment on column MTR_B_STOCK_DATA_MOVE_D.unit_id
  is '��λ';
comment on column MTR_B_STOCK_DATA_MOVE_D.price
  is '����';
comment on column MTR_B_STOCK_DATA_MOVE_D.money
  is '���';
comment on column MTR_B_STOCK_DATA_MOVE_D.batch_code
  is '����';
comment on column MTR_B_STOCK_DATA_MOVE_D.prd_id
  is '����';
comment on column MTR_B_STOCK_DATA_MOVE_D.prd_date
  is '��������';
comment on column MTR_B_STOCK_DATA_MOVE_D.invalid_date
  is 'ʧЧ����';
comment on column MTR_B_STOCK_DATA_MOVE_D.comments
  is '��ע';
comment on column MTR_B_STOCK_DATA_MOVE_D.move_amount
  is '��������';
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
  is '����';
comment on column MTR_D_MTR.type_id
  is '��������';
comment on column MTR_D_MTR.stock_up_limit
  is '�������';
comment on column MTR_D_MTR.stock_down_limit
  is '�������';
comment on column MTR_D_MTR.code
  is '���ʱ���';
comment on column MTR_D_MTR.name
  is '��������';
comment on column MTR_D_MTR.spell_code
  is 'ƴ����';
comment on column MTR_D_MTR.five_stroke_code
  is '�����';
comment on column MTR_D_MTR.international_code
  is '������';
comment on column MTR_D_MTR.custom_code
  is '�Զ�����';
comment on column MTR_D_MTR.finance_name
  is '��������';
comment on column MTR_D_MTR.finance_code
  is '�������';
comment on column MTR_D_MTR.spec
  is '���ʹ��';
comment on column MTR_D_MTR.price
  is '����';
comment on column MTR_D_MTR.unit_id
  is '��λ';
comment on column MTR_D_MTR.pkg_amount
  is '��װ����';
comment on column MTR_D_MTR.pkg_unit_id
  is '��װ��λ';
comment on column MTR_D_MTR.pkg_price
  is '��װ�۸�';
comment on column MTR_D_MTR.prd_id
  is '��������';
comment on column MTR_D_MTR.price_rule_id
  is '�Ӽ۹���';
comment on column MTR_D_MTR.source_id
  is '������Դ';
comment on column MTR_D_MTR.usage_id
  is '������;';
comment on column MTR_D_MTR.is_invalid
  is '�Ƿ�ͣ��';
comment on column MTR_D_MTR.is_fi_charge
  is '�Ƿ�����շ�';
comment on column MTR_D_MTR.is_valuable
  is '�Ƿ��ֵ�Ĳ�';
comment on column MTR_D_MTR.is_spec
  is '�Ƿ������־';
comment on column MTR_D_MTR.is_pkg
  is '�Ƿ���';
comment on column MTR_D_MTR.is_otp
  is '�Ƿ�һ���ԺĲ�';
comment on column MTR_D_MTR.is_batch
  is '�Ƿ����ι���';
comment on column MTR_D_MTR.is_plan_instock
  is '�Ƿ��¼ƻ����';
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
  is '����';
comment on column MTR_D_MTR_FEE.mtr_id
  is '����';
comment on column MTR_D_MTR_FEE.fee_item_id
  is '��ҩƷ�շ���Ŀ';
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
  is '����';
comment on column MTR_D_MTR_PROVIDER.provider_id
  is '��Ӧ��';
comment on column MTR_D_MTR_PROVIDER.state
  is '�Ƿ���Ч';
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
  is '���ʹ�Ӧ��';
comment on column MTR_D_MTR_PROVIDER_PRICE.price
  is '�۸�';
comment on column MTR_D_MTR_PROVIDER_PRICE.begin_date
  is '��ʼ����';
comment on column MTR_D_MTR_PROVIDER_PRICE.end_date
  is '��������';
comment on column MTR_D_MTR_PROVIDER_PRICE.state
  is '�Ƿ���Ч';
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
  is '����';
comment on column MTR_D_MTR_TYPE.code
  is '����';
comment on column MTR_D_MTR_TYPE.name
  is '����';
comment on column MTR_D_MTR_TYPE.spell_code
  is 'ƴ����';
comment on column MTR_D_MTR_TYPE.five_stroke_code
  is '�����';
comment on column MTR_D_MTR_TYPE.international_code
  is '������';
comment on column MTR_D_MTR_TYPE.custom_code
  is '�Զ�����';
comment on column MTR_D_MTR_TYPE.finance_name
  is '��������';
comment on column MTR_D_MTR_TYPE.finance_code
  is '�������';
comment on column MTR_D_MTR_TYPE.order_index
  is '˳���';
comment on column MTR_D_MTR_TYPE.parent_id
  is '�ϼ�';
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
  is '����';
comment on column MTR_D_PRICE_RULE.code
  is '����';
comment on column MTR_D_PRICE_RULE.name
  is '����';
comment on column MTR_D_PRICE_RULE.increase_scale
  is '�Ӽ۱���';
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
  is 'ҵ������';
comment on column MTR_D_USED_DEPT.order_index
  is '˳���';
comment on column MTR_D_USED_DEPT.dept_id
  is '��������';
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
1���鵵��������������ݣ�MTR_B_instock_req_sum��,
2���鵵���õĿ������루MTR_B_instock_req��
3��������������ϸ�п�治��ļ�¼���Զ����ɲɹ��ƻ�(MTR_B_purchase_plan)
*/
begin   
    --������ʼ��
    V_MORETHAN := 0;
    --ȡ���й����Ŀ������루MTR_B_instock_req_sum_c��
    for config in(
                    select
                    t.id,
                    t.ref_tab_id
                    from  Mtr_b_Instock_Req_Sum_c t
                    where t.base_id = p_planid
                  )
          loop
             --���¶�Ӧ�Ŀ�������(MTR_B_instock_req)״̬Ϊ�ѹ鵵
             execute immediate 'update MTR_B_instock_req t
             set t.state=4 where t.id= '''||config.ref_tab_id||'''';
          end loop;
      --���»��ܱ�MTR_B_instock_req_sum����״̬Ϊ�ѹ鵵
      execute immediate ' update MTR_B_instock_req_sum t set t.state=4 where t.id='''||p_planid||'''';
      --����Ƿ���Ҫ�Զ����ɲɹ��ƻ�
      execute immediate 'select 
      sum(d.approved_amount) - sum(d.stock_amount)
      from
      MTR_B_instock_req_sum_d d
      where d.base_id ='''||p_planid||'''
      group by d.base_id
      ' into V_MORETHAN;
      if V_MORETHAN > 0 then
        begin
           --���ɲɹ��ƻ�           
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
           --���ɲɹ��ƻ���ϸ
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
      p_succeed := 1;--���سɹ�
exception
      when others
        then
        v_ErrorCode := SQLCODE;
        v_ErrorMsg := SQLERRM;
        v_CurrentUser := USER;
        v_Information := '�����˴��� ' || TO_CHAR(SYSDATE) || ' ���ݿ��û� ' || v_CurrentUser;
        p_msg:= 'ִ�д���,�Զ��ع�.';
        dbms_output.put_line('ִ�д���,�Զ��ع�.');
        p_msg:= p_msg || '��ϸ��Ϣ:'||'�������:'||v_ErrorCode||',������Ϣ:'||v_ErrorMsg||',��־��Ϣ:'||v_Information;
        dbms_output.put_line('��ϸ��Ϣ:'||'�������:'||v_ErrorCode||',������Ϣ:'||v_ErrorMsg||',��־��Ϣ:'||v_Information);
        /*дʧ�ܱ�־*/
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
1��������ⵥ��״̬Ϊ����ˣ�MTR_B_INSTOCK��
2�����ӿ�棨MTR_B_STOCK_DATA��
3�����ɲ���ƾ֤/�ɱ�����(������ʵ��)
4���������õ���״̬��������ڣ�
*/
begin   
      --������ʼ��
      select trim(INSTOCK_TYPE_ID) into V_INSTOCK_TYPE from MTR_B_INSTOCK where id = p_planid;
      if V_INSTOCK_TYPE = '00390002' then --�������
         begin
            --������ʼ��
            --1.�����������
            V_STOCK_DATA_TYPE := '00400001'; --��ͨ���
            --2.�ֿ�ID
            --�жϿ��Ҳֿ��Ƿ����
            select 
            decode
            (
            ( select t.id from MDM_D_STOCK t
            where t.STOCK_TYPE_ID = '00320002'--���Ҳֿ�
            and t.DEPT_ID =(select USE_DEPT_ID from MTR_B_INSTOCK where id=p_planid))
            ,
            null,
            '',
            ( select t.id from MDM_D_STOCK t
            where t.STOCK_TYPE_ID = '00320002'--���Ҳֿ�
            and t.DEPT_ID =(select USE_DEPT_ID from MTR_B_INSTOCK where id=p_planid))
            )
            into V_STOCK_ID
            from dual;
           --�������򴴽�
            if V_STOCK_ID = '' then
               begin
                  V_STOCK_ID := sys_guid();
                  insert into MDM_D_STOCK(id,STOCK_TYPE_ID,DEPT_ID,NAME,COMMENTS)
                  select V_STOCK_ID,'00320002',i.USE_DEPT_ID,d.NAME,'��̨�Զ�����'
                  from MTR_B_INSTOCK i,COM_DEPART d
                  where i.id = p_planid
                  and d.id = i.use_dept_id;
               end;
            end if;
                        
         end;
      else --�������,��ͨ���
         begin
              --������ʼ��
              --1.�����������
              select case when V_INSTOCK_TYPE = '00390001' then '00400001' --��ͨ���
                     when V_INSTOCK_TYPE = '00390003' then '00400002' --�������
                     else '00400001'
              end into V_STOCK_DATA_TYPE from dual; 
              --2.�ֿ�ID     
              select STOCK_ID into V_STOCK_ID
              from MTR_B_INSTOCK where id= p_planid;        
         end;
      end if;
      --����ָ���ֿ��ָ������������͵Ŀ������
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
                V_STOCK_ID,--�ֿ����
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
                V_STOCK_DATA_TYPE, --����������ͱ���            
                t.UNIT_ID,
                sysdate
               from MTR_B_INSTOCK_D t,MTR_B_INSTOCK b
               where t.base_id = p_planid  
               and b.id =t.base_id; 
      --���¹������ݵ�״̬
      --1.�ɹ���������
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
      --2.����֪ͨ������
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
      --������ⵥ״̬Ϊ�����
      update MTR_B_INSTOCK set state = 3 where id = p_planid;
      
      commit;
      p_msg:= '';
      p_succeed := 1;--���سɹ�
exception
      when others
        then
        v_ErrorCode := SQLCODE;
        v_ErrorMsg := SQLERRM;
        v_CurrentUser := USER;
        v_Information := '�����˴��� ' || TO_CHAR(SYSDATE) || ' ���ݿ��û� ' || v_CurrentUser;
        p_msg:= 'ִ�д���,�Զ��ع�.';
        dbms_output.put_line('ִ�д���,�Զ��ع�.');
        p_msg:= p_msg || '��ϸ��Ϣ:'||'�������:'||v_ErrorCode||',������Ϣ:'||v_ErrorMsg||',��־��Ϣ:'||v_Information;
        dbms_output.put_line('��ϸ��Ϣ:'||'�������:'||v_ErrorCode||',������Ϣ:'||v_ErrorMsg||',��־��Ϣ:'||v_Information);
        /*дʧ�ܱ�־*/
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
1�����³��ⵥ��״̬Ϊ����ˣ�MTR_B_OUTSTOCK��
2���ۼ���棨MTR_B_STOCK_DATA��
3�����³��ⵥ��ϸ(MTR_B_OUTSTOCK_D)�е����ۼ۸�����۽��,����ƾ��Ϊ���ʣ�MTR_D_MTR���ļӼ۹���(MTR_D_PRICE_RULE)
4�����ɲ���ƾ֤/�ɱ�����(������ʵ��)
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
                --�������۵���
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
                --�������۽��
                update MTR_B_OUTSTOCK_d d
                set d.retail_money = d.amount * d.retail_price
                where d.id = config.id;
                --������
                V_REQUEST := config.AMOUNT;
                --������
                V_COMPLETED:=0;
                while V_COMPLETED <> V_REQUEST /*�������δ������,�����ѭ���ۼ�*/
                loop  
                      --��¼ID
                      V_NEWID :=sys_guid();
                      --�ۼ����
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
                      --�жϵ�ǰ��¼�Ŀ����,������ڵ���δ�����������,��ʹ��δ������������ֵ���пۼ�
                      --����,��ʹ�õ�ǰ��¼�Ŀ�������пۼ�,�ҽ�����һ��ѭ��
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
                          group by --�ھ�������ͼ(v_mtr_stock_data)һ��
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
                      t1, --������ݷ���ϼ�
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
                      ) t2 --��������Ƚ��ȳ�
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
                        and t2.stock_data_type_id = '00400001' --��ͨ���                              
                        and t2.mater_id = config.mater_id                              
                        /*and t2.spec = config.spec*/
                        /*and t2.pkg_amount = config.pkg_amount*/
                        /*and t2.unit_id = config.unit_id*/
  
                                                                    
                        and rownum = 1
                        order by t2.prd_date;
      --����������
      select amount * -1 into V_COMPLETED 
      from MTR_B_STOCK_DATA 
                      where id = V_NEWID;
                end loop;
              end loop;
      
      --���³��ⵥ״̬Ϊ�����
      update MTR_B_OUTSTOCK set state = 3 where id = p_planid;
      
      commit;
      p_msg:= '';
      p_succeed := 1;--���سɹ�
exception
      when others
        then
        v_ErrorCode := SQLCODE;
        v_ErrorMsg := SQLERRM;
        v_CurrentUser := USER;
        v_Information := '�����˴��� ' || TO_CHAR(SYSDATE) || ' ���ݿ��û� ' || v_CurrentUser;
        p_msg:= 'ִ�д���,�Զ��ع�.';
        dbms_output.put_line('ִ�д���,�Զ��ع�.');
        p_msg:= p_msg || '��ϸ��Ϣ:'||'�������:'||v_ErrorCode||',������Ϣ:'||v_ErrorMsg||',��־��Ϣ:'||v_Information;
        dbms_output.put_line('��ϸ��Ϣ:'||'�������:'||v_ErrorCode||',������Ϣ:'||v_ErrorMsg||',��־��Ϣ:'||v_Information);
        /*дʧ�ܱ�־*/
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
1����˲ɹ��ƻ���MTR_B_purchase_plan��,
2������Ӧ�̷������ɲɹ�������MTR_B_purchase_bill��
3���ɹ�������ϸ��MTR_B_purchase_bill_d���еĵ��۴�FN_MTR_GET_MATER_PRICE��ȡ
*/
begin   
   
    --��ȡ��Ӧ�̷�������
    for config in(
                    select
                    t.provider_id
                    from  MTR_B_purchase_plan_d t
                    where t.base_id = p_planid
                    group by t.provider_id
                  )
          loop
             execute immediate 'select sys_guid() from dual' into V_NEW_ID;
             --�����ɹ���������¼
             insert into MTR_B_PURCHASE_BILL
             (id, BILL_TYPE_ID,CREATE_DATE,DEPT_ID,USER_ID,PROVIDER_ID,CODE)
             select V_NEW_ID,'00420001',sysdate,DEPT_ID,USER_ID,config.provider_id,code
             from MTR_B_purchase_plan where id = p_planid;               
             --�����ɹ�������ϸ��¼
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
                --��ȡ�۸�
                V_PRICE:= FN_MTR_GET_MATER_PRICE(dconfig.mater_id,config.provider_id);
                --������ϸ
                insert into MTR_B_PURCHASE_BILL_D
                (id,AMOUNT,BASE_ID,COMMENTS,DELIVERY_DATE,MATER_ID,PKG_AMOUNT,PRD_ID,PRICE,MONEY,SPEC,UNIT_ID)
                select sys_guid(),dconfig.amount,V_NEW_ID,dconfig.COMMENTS,
                dconfig.DELIVERY_DATE,dconfig.MATER_ID,dconfig.PKG_AMOUNT,
                dconfig.PRD_ID,V_PRICE,V_PRICE*dconfig.amount,dconfig.SPEC,dconfig.UNIT_ID
                from dual;
              end loop;
          end loop;
      --��˲ɹ��ƻ�
      update MTR_B_purchase_plan t set t.state =3 where id =p_planid;
      commit;
      p_msg:= '';
      p_succeed := 1;--���سɹ�
exception
      when others
        then
        v_ErrorCode := SQLCODE;
        v_ErrorMsg := SQLERRM;
        v_CurrentUser := USER;
        v_Information := '�����˴��� ' || TO_CHAR(SYSDATE) || ' ���ݿ��û� ' || v_CurrentUser;
        p_msg:= 'ִ�д���,�Զ��ع�.';
        dbms_output.put_line('ִ�д���,�Զ��ع�.');
        p_msg:= p_msg || '��ϸ��Ϣ:'||'�������:'||v_ErrorCode||',������Ϣ:'||v_ErrorMsg||',��־��Ϣ:'||v_Information;
        dbms_output.put_line('��ϸ��Ϣ:'||'�������:'||v_ErrorCode||',������Ϣ:'||v_ErrorMsg||',��־��Ϣ:'||v_Information);
        /*дʧ�ܱ�־*/
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
1�������̵㵥��״̬Ϊ����ˣ�MTR_B_STOCK_data_Check��
2�������̵����ֵ������棨MTR_B_STOCK_DATA��
3�����ɲ���ƾ֤/�ɱ�����(������ʵ��)
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
                if config.diff_amount > 0 then --��ӯ��Ҫ���ӿ��
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
                              config.diff_amount,--����ֵ����ֵ��
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
                                  group by --�ھ�������ͼ(v_mtr_stock_data)һ��
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
                              t1, --������ݷ���ϼ�
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
                              ) t2 --��������Ƚ��ȳ�
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
                else  --�̿�,Ҫ�ۼ����
                  begin
                        --������
                        V_REQUEST := config.diff_amount * -1;--����ֵ����ֵ��
                        --������
                        V_COMPLETED:=0;
                        while V_COMPLETED <> V_REQUEST /*�������δ������,�����ѭ���ۼ�*/
                        loop  
                              --��¼ID
                              V_NEWID :=sys_guid();
                              --�ۼ����
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
                              --�жϵ�ǰ��¼�Ŀ����,������ڵ���δ�����������,��ʹ��δ������������ֵ���пۼ�
                              --����,��ʹ�õ�ǰ��¼�Ŀ�������пۼ�,�ҽ�����һ��ѭ��
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
                                  group by --�ھ�������ͼ(v_mtr_stock_data)һ��
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
                              t1, --������ݷ���ϼ�
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
                              ) t2 --��������Ƚ��ȳ�
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
                              --����������
                              select amount * -1 into V_COMPLETED 
                              from MTR_B_STOCK_DATA 
                              where id = V_NEWID;
                        end loop;
                  end;
                end if;             
              end loop;
      
      --���³��ⵥ״̬Ϊ�����
      update MTR_B_STOCK_data_Check set state = 3 where id = p_planid;
      
      commit;
      p_msg:= '';
      p_succeed := 1;--���سɹ�
exception
      when others
        then
        v_ErrorCode := SQLCODE;
        v_ErrorMsg := SQLERRM;
        v_CurrentUser := USER;
        v_Information := '�����˴��� ' || TO_CHAR(SYSDATE) || ' ���ݿ��û� ' || v_CurrentUser;
        p_msg:= 'ִ�д���,�Զ��ع�.';
        dbms_output.put_line('ִ�д���,�Զ��ع�.');
        p_msg:= p_msg || '��ϸ��Ϣ:'||'�������:'||v_ErrorCode||',������Ϣ:'||v_ErrorMsg||',��־��Ϣ:'||v_Information;
        dbms_output.put_line('��ϸ��Ϣ:'||'�������:'||v_ErrorCode||',������Ϣ:'||v_ErrorMsg||',��־��Ϣ:'||v_Information);
        /*дʧ�ܱ�־*/
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
1�����µ�������״̬Ϊ����ˣ�MTR_B_STOCK_data_move��
2�����յ�������������棨MTR_B_STOCK_DATA��
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
                --�����,Ҫ���ӿ��
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
                              config.move_amount,--������
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
                              config.to_stock_id,--�����
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
                                  group by --�ھ�������ͼ(v_mtr_stock_data)һ��
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
                              t1, --������ݷ���ϼ�
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
                              ) t2 --��������Ƚ��ȳ�
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
                              
                              and t2.stock_id = config.from_stock_id --�ӵ�����ȡ���
                              and t2.stock_data_type_id = config.stock_data_type_id                             
                              and t2.mater_id = config.mater_id 
   
                                                    
                              and rownum = 1
                              order by t2.prd_date;
                --������,Ҫ�ۼ����
                        --������
                        V_REQUEST := config.move_amount;--������
                        --������
                        V_COMPLETED:=0;
                        while V_COMPLETED <> V_REQUEST /*�������δ������,�����ѭ���ۼ�*/
                        loop  
                              --��¼ID
                              V_NEWID :=sys_guid();                            
                              --�ۼ����
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
                              --�жϵ�ǰ��¼�Ŀ����,������ڵ���δ�����������,��ʹ��δ������������ֵ���пۼ�
                              --����,��ʹ�õ�ǰ��¼�Ŀ�������пۼ�,�ҽ�����һ��ѭ��
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
                              config.from_stock_id,--������
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
                                  group by --�ھ�������ͼ(v_mtr_stock_data)һ��
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
                              t1, --������ݷ���ϼ�
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
                              ) t2 --��������Ƚ��ȳ�
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
                              
                              and t2.stock_id = config.from_stock_id --�ӵ�����ȡ���
                              and t2.stock_data_type_id = config.stock_data_type_id                             
                              and t2.mater_id = config.mater_id                              
                                                           
                                                    
                              and rownum = 1
                              order by t2.prd_date;

                              --����������
                              select amount * -1 into V_COMPLETED 
                              from MTR_B_STOCK_DATA 
                              where id = V_NEWID;
                        end loop;
           
              end loop;      
      --���³��ⵥ״̬Ϊ�����
      update MTR_B_STOCK_data_move set state = 3 where id = p_planid;
      
      commit;
      p_msg:= '';
      p_succeed := 1;--���سɹ�
exception
      when others
        then
        v_ErrorCode := SQLCODE;
        v_ErrorMsg := SQLERRM;
        v_CurrentUser := USER;
        v_Information := '�����˴��� ' || TO_CHAR(SYSDATE) || ' ���ݿ��û� ' || v_CurrentUser;
        p_msg:= 'ִ�д���,�Զ��ع�.';
        dbms_output.put_line('ִ�д���,�Զ��ع�.');
        p_msg:= p_msg || '��ϸ��Ϣ:'||'�������:'||v_ErrorCode||',������Ϣ:'||v_ErrorMsg||',��־��Ϣ:'||v_Information;
        dbms_output.put_line('��ϸ��Ϣ:'||'�������:'||v_ErrorCode||',������Ϣ:'||v_ErrorMsg||',��־��Ϣ:'||v_Information);
        /*дʧ�ܱ�־*/
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
1��������������˵Ĳ������ƻ����루MTR_B_instock_req��
*/
begin
    --��ʼ������
    execute immediate 'select ''TMP_REQ'' from dual' into V_TEMP_TAB;
    dbms_output.put_line(V_TEMP_TAB);
    --��ո��ٱ�
    execute immediate ' delete from MTR_B_INSTOCK_REQ_SUM_C where base_id='''||p_planid||'''';
    --�����ϸ��
    execute immediate ' delete from MTR_B_INSTOCK_REQ_SUM_d where base_id='''||p_planid||'''';
    --����������ʱ��
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
    --ȡ���������״̬�Ĳ������ƻ����루MTR_B_instock_req��
    for config in(
                    select
                    t.id
                    from  MTR_B_instock_req t
                    where t.state = 3
                  )
          loop
             --����ʱ���в�������
             execute immediate 'insert into '||V_TEMP_TAB||'(id,mater_id,spec,apply_amount,approved_amount,
             unit_id,pkg_amount,price,money,comments)
             select d.id,d.mater_id,d.spec,
             d.apply_amount,d.approved_amount,d.unit_id,
             d.pkg_amount,d.price,d.money,d.comments 
             from MTR_B_instock_req_d d where d.base_id = '''|| config.id||'''';
             --����ٱ����
             execute immediate 'insert into MTR_B_INSTOCK_REQ_SUM_C(id,base_id,ref_tab_name,ref_tab_id)
             select sys_guid(), '''||p_planid||''',''MTR_B_instock_req'','''||config.id||''' from dual';
          end loop;
          --����ϸ�����          
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
             --ɾ����ʱ��
             execute immediate 'Drop  TABLE '||V_TEMP_TAB; 
             --������ϸ��¼�еĿ������
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
      p_succeed := 1;--���سɹ�
exception
      when others
        then
        v_ErrorCode := SQLCODE;
        v_ErrorMsg := SQLERRM;
        v_CurrentUser := USER;
        v_Information := '�����˴��� ' || TO_CHAR(SYSDATE) || ' ���ݿ��û� ' || v_CurrentUser;
        p_msg:= 'ִ�д���,�Զ��ع�.';
        dbms_output.put_line('ִ�д���,�Զ��ع�.');
        p_msg:= p_msg || '��ϸ��Ϣ:'||'�������:'||v_ErrorCode||',������Ϣ:'||v_ErrorMsg||',��־��Ϣ:'||v_Information;
        dbms_output.put_line('��ϸ��Ϣ:'||'�������:'||v_ErrorCode||',������Ϣ:'||v_ErrorMsg||',��־��Ϣ:'||v_Information);
        /*дʧ�ܱ�־*/
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
1�������̵������嵥��MTR_B_STOCK_DATA_CHECK_D��
2������������̵����ô��ڣ���ֻ����ָ�����͵��̵�����(MTR_B_STOCK_DATA_CHECK_type)
*/
begin
      --ɾ����¼
      delete from MTR_B_STOCK_DATA_CHECK_D where base_id=p_planid;
      --��֯���
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
      --����Ƿ����������������
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
      --������¼
      execute immediate  V_EXEC_SQL;  
      commit;
      p_msg:= '';
      p_succeed := 1;--���سɹ�
exception
      when others
        then
        v_ErrorCode := SQLCODE;
        v_ErrorMsg := SQLERRM;
        v_CurrentUser := USER;
        v_Information := '�����˴��� ' || TO_CHAR(SYSDATE) || ' ���ݿ��û� ' || v_CurrentUser;
        p_msg:= 'ִ�д���,�Զ��ع�.';
        dbms_output.put_line('ִ�д���,�Զ��ع�.');
        p_msg:= p_msg || '��ϸ��Ϣ:'||'�������:'||v_ErrorCode||',������Ϣ:'||v_ErrorMsg||',��־��Ϣ:'||v_Information;
        dbms_output.put_line('��ϸ��Ϣ:'||'�������:'||v_ErrorCode||',������Ϣ:'||v_ErrorMsg||',��־��Ϣ:'||v_Information);
        /*дʧ�ܱ�־*/
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
1�����ɵ��������嵥��MTR_B_STOCK_DATA_MOVE_D��
*/
begin
      --ɾ����¼
      delete from MTR_B_STOCK_DATA_MOVE_D where base_id=p_planid;
      --��֯���

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
      p_succeed := 1;--���سɹ�
exception
      when others
        then
        v_ErrorCode := SQLCODE;
        v_ErrorMsg := SQLERRM;
        v_CurrentUser := USER;
        v_Information := '�����˴��� ' || TO_CHAR(SYSDATE) || ' ���ݿ��û� ' || v_CurrentUser;
        p_msg:= 'ִ�д���,�Զ��ع�.';
        dbms_output.put_line('ִ�д���,�Զ��ع�.');
        p_msg:= p_msg || '��ϸ��Ϣ:'||'�������:'||v_ErrorCode||',������Ϣ:'||v_ErrorMsg||',��־��Ϣ:'||v_Information;
        dbms_output.put_line('��ϸ��Ϣ:'||'�������:'||v_ErrorCode||',������Ϣ:'||v_ErrorMsg||',��־��Ϣ:'||v_Information);
        /*дʧ�ܱ�־*/
        p_succeed := 0;
        rollback;
END SP_mtr_create_stockdata_move_d;
/


spool off
