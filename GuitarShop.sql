create database GuitarShop
GO

use GuitarShop
GO

/* 會員欄位 */
create table Members(
Member_Id int primary key IDENTITY(1001,1),
Member_Name nvarchar(50) not null,
Member_Phone nvarchar(50) not null unique,
Member_Email nvarchar(50) not null unique,
Member_Birthday date not null,
Member_Passwords varchar(50) not null,
CreatedDate DATETIME DEFAULT GETDATE()
);

/* 新增管理員與訪客 */
INSERT INTO Members(Member_Id,Member_Name,Member_Phone,Member_Email,Member_Birthday,Member_Passwords) 
VALUES
(1,'Admin','Admin','Admin','','12345678'),
(0,'訪客','0','0','','');

/* 新增會員資料 */
INSERT INTO Members (Member_Name, Member_Phone, Member_Email, Member_Birthday, Member_Passwords)
VALUES 
('邱炫銘','0979315596','s1237798s@gmail.com','1998-11-02','a7899345'),
('陳小美', '0912345671', 'xiaomei.chen@example.com', '1996-02-15', 'Pass1234'),
('王大明', '0912345672', 'daming.wang@example.com', '1994-11-20', 'Secret123'),
('林淑芬', '0912345673', 'shufen.lin@example.com', '1990-07-25', 'Hello789'),
('吳志強', '0912345674', 'zhiqiang.wu@example.com', '1992-03-10', 'Welcome456'),
('黃怡君', '0912345675', 'yijun.huang@example.com', '1988-05-30', 'SecurePwd'),
('張柏瑞', '0912345676', 'bozhui.chang@example.com', '1997-09-12', 'Frank007'),
('賴佩珊', '0912345677', 'peishan.lai@example.com', '1995-12-05', 'GracePass'),
('李建華', '0912345678', 'jianhua.lee@example.com', '1993-01-18', 'Harry2021'),
('徐麗華', '0912345679', 'lihua.hsu@example.com', '1991-04-22', 'IvySecure'),
('陳建中', '0912345680', 'jianzong.chen@example.com', '1989-06-30', 'JasonPass'),
('楊雅婷', '0912345681', 'yating.yang@example.com', '1994-08-18', 'Kelly1994'),
('孫德明', '0912345682', 'deming.sun@example.com', '1996-10-22', 'LeoLeo78'),
('周美惠', '0912345683', 'meihui.chou@example.com', '1987-12-15', 'MaggiePwd'),
('方志華', '0912345684', 'zhihua.fang@example.com', '1993-02-10', 'NickNick'),
('蔡依依', '0912345685', 'yiyi.tsai@example.com', '1995-03-20', 'Olivia99'),
('高偉傑', '0912345686', 'weijie.kao@example.com', '1990-11-11', 'PeterKao1'),
('謝淑娟', '0912345687', 'shujuan.hsieh@example.com', '1992-07-07', 'QueenieOK'),
('張銘浩', '0912345688', 'minghao.chang@example.com', '1988-10-30', 'RoyRoy77'),
('吳淑貞', '0912345689', 'shuzhen.wu@example.com', '1997-01-01', 'SandyPass'),
('林家豪', '0912345690', 'jiahao.lin@example.com', '1994-09-09', 'TomTom123');


/* 商品欄位 */
create table Products(
Product_Id int primary key IDENTITY(1,1),
Product_Name nvarchar(100) not null,
Product_Price int not null,
Product_Description nvarchar(500),
Product_Stock int NOT NULL,
Product_Category nvarchar(100) not null,
CreatedDate DATETIME DEFAULT GETDATE()
)

/* 新增商品 */
insert into Products(Product_Name,Product_Price,Product_Description,Product_Stock,Product_Category) 
Values
('Guitar1',8000,'全單玫瑰木',2,'AG'),
('Guitar2',8800,'面單玫瑰木',3,'AG'),
('Guitar3',7000,'全單雲杉木',1,'AG'),
('Guitar4',5000,'新手練習琴',5,'AG'),
('Guitar5',6000,'面單玫瑰木',5,'AG'),
('EGuitar1',10000,'Fender粉色',2,'EG'),
('EGuitar2',8800,'Fender MIJ LTD Elemental Strat HH RW NWT 日廠 白色 限量電吉他',2,'EG'),
('EGuitar3',49000,'PRS SE Santana 50th LTD Abraxas 雙雙拾音器',1,'EG'),
('EGuitar4',12000,'Gibson Les Paul Studio 酒紅色',2,'EG'),
('EGuitar5',6500,'Comet St3 新手超優惠',10,'EG');

/* 商品照片欄位 */
CREATE TABLE Images (
    Image_ID INT PRIMARY KEY IDENTITY(1,1),      -- 自動遞增的主鍵
    Product_Id  INT NOT NULL,                      -- 外鍵，連接到 Products 表
    FilePath VARCHAR(255) NOT NULL,              -- 圖片路徑
    SortOrder INT DEFAULT 1,                     -- 圖片顯示順序，預設值為 1
    FOREIGN KEY (Product_Id) REFERENCES Products(Product_Id) -- 定義外鍵
);

truncate table Images

SELECT ISNULL(MAX(SortOrder), 0) FROM Images WHERE Product_Id = 5
/* 新增照片欄位 */
INSERT INTO Images (Product_Id, FilePath, SortOrder)
VALUES
(1, 'product1-1.jpg', 1),
(1, 'product1-2.jpg', 2),
(1, 'product1-3.jpg', 3),
(1, 'product1-4.jpg', 4),
(2, 'product2-1.jpg', 1),
(2, 'product2-2.jpg', 2),
(2, 'product2-3.jpg', 3),
(2, 'product2-4.jpg', 4),
(3, 'product3-1.jpg', 1),
(3, 'product3-2.jpg', 2),
(3, 'product3-3.jpg', 3),
(3, 'product3-4.jpg', 4),
(4, 'product4-1.jpg', 1),
(4, 'product4-2.jpg', 2),
(4, 'product4-3.jpg', 3),
(5, 'product5-1.jpg', 1),
(6, 'EGproduct1-1.jpg', 1),
(7, 'EGproduct2-1.jpg', 1),
(8, 'EGproduct3-1.jpg', 1),
(9, 'EGproduct4-1.jpg', 1),
(9, 'EGproduct4-2.jpg', 2),
(10, 'EGproduct5-1.jpg', 1),
(10, 'EGproduct5-2.jpg', 2);

/* 訂單欄位 */
CREATE TABLE Orders (
    Order_Id INT IDENTITY(1,1) PRIMARY KEY,   -- 自動遞增的主鍵
    Member_Id INT NOT NULL,                   -- 外鍵，連接到會員表
	PaymentMethod NVARCHAR(20) NOT NULL,--付款方式
	name NVARCHAR(50) NOT NULL,			--訂購人姓名
	Phone VARCHAR(20) NOT NULL,			--訂購人電話
	Email VARCHAR(100) NOT NULL,		--訂購人email
	address NVARCHAR(100) NOT NULL,     --訂購人地址
    TotalAmount INT NOT NULL,     -- 訂單總價   
    CreatedDate DATETIME DEFAULT GETDATE(),  -- 訂單創建日期
	UpdateDate DATETIME,		--訂單更新日期
    FOREIGN KEY (Member_Id) REFERENCES Members(Member_Id)  -- 外鍵約束
);

/* 訂單細節欄位 */
CREATE TABLE OrdersDetails (
    OrderDetail_Id INT IDENTITY(1,1) PRIMARY KEY,   -- 自動遞增的主鍵
	Order_Id INT NOT NULL, 
	Product_Id INT not null,
	Product_Name Varchar(50) not null,
	Quantity INT not null,
	UnitPrice INT not null,
    TotalAmount INT NOT NULL,     -- 訂單總價   
    CreatedDate DATETIME DEFAULT GETDATE(),  -- 訂單創建日期
    FOREIGN KEY (Order_Id) REFERENCES Orders(Order_Id)  -- 外鍵約束
);




