create database GuitarShop
GO

use GuitarShop
GO

/* �|����� */
create table Members(
Member_Id int primary key IDENTITY(1001,1),
Member_Name nvarchar(50) not null,
Member_Phone nvarchar(50) not null unique,
Member_Email nvarchar(50) not null unique,
Member_Birthday date not null,
Member_Passwords varchar(50) not null,
CreatedDate DATETIME DEFAULT GETDATE()
);

/* �s�W�޲z���P�X�� */
INSERT INTO Members(Member_Id,Member_Name,Member_Phone,Member_Email,Member_Birthday,Member_Passwords) 
VALUES
(1,'Admin','Admin','Admin','','12345678'),
(0,'�X��','0','0','','');

/* �s�W�|����� */
INSERT INTO Members (Member_Name, Member_Phone, Member_Email, Member_Birthday, Member_Passwords)
VALUES 
('������','0979315596','s1237798s@gmail.com','1998-11-02','a7899345'),
('���p��', '0912345671', 'xiaomei.chen@example.com', '1996-02-15', 'Pass1234'),
('���j��', '0912345672', 'daming.wang@example.com', '1994-11-20', 'Secret123'),
('�L�Q��', '0912345673', 'shufen.lin@example.com', '1990-07-25', 'Hello789'),
('�d�ӱj', '0912345674', 'zhiqiang.wu@example.com', '1992-03-10', 'Welcome456'),
('���ɧg', '0912345675', 'yijun.huang@example.com', '1988-05-30', 'SecurePwd'),
('�i�f��', '0912345676', 'bozhui.chang@example.com', '1997-09-12', 'Frank007'),
('��ج�', '0912345677', 'peishan.lai@example.com', '1995-12-05', 'GracePass'),
('���ص�', '0912345678', 'jianhua.lee@example.com', '1993-01-18', 'Harry2021'),
('�}�R��', '0912345679', 'lihua.hsu@example.com', '1991-04-22', 'IvySecure'),
('���ؤ�', '0912345680', 'jianzong.chen@example.com', '1989-06-30', 'JasonPass'),
('�����@', '0912345681', 'yating.yang@example.com', '1994-08-18', 'Kelly1994'),
('�]�w��', '0912345682', 'deming.sun@example.com', '1996-10-22', 'LeoLeo78'),
('�P���f', '0912345683', 'meihui.chou@example.com', '1987-12-15', 'MaggiePwd'),
('��ӵ�', '0912345684', 'zhihua.fang@example.com', '1993-02-10', 'NickNick'),
('���̨�', '0912345685', 'yiyi.tsai@example.com', '1995-03-20', 'Olivia99'),
('������', '0912345686', 'weijie.kao@example.com', '1990-11-11', 'PeterKao1'),
('�²Q�S', '0912345687', 'shujuan.hsieh@example.com', '1992-07-07', 'QueenieOK'),
('�i�ʯE', '0912345688', 'minghao.chang@example.com', '1988-10-30', 'RoyRoy77'),
('�d�Q�s', '0912345689', 'shuzhen.wu@example.com', '1997-01-01', 'SandyPass'),
('�L�a��', '0912345690', 'jiahao.lin@example.com', '1994-09-09', 'TomTom123');


/* �ӫ~��� */
create table Products(
Product_Id int primary key IDENTITY(1,1),
Product_Name nvarchar(100) not null,
Product_Price int not null,
Product_Description nvarchar(500),
Product_Stock int NOT NULL,
Product_Category nvarchar(100) not null,
CreatedDate DATETIME DEFAULT GETDATE()
)

/* �s�W�ӫ~ */
insert into Products(Product_Name,Product_Price,Product_Description,Product_Stock,Product_Category) 
Values
('Guitar1',8000,'���檴����',2,'AG'),
('Guitar2',8800,'���檴����',3,'AG'),
('Guitar3',7000,'���涳����',1,'AG'),
('Guitar4',5000,'�s��m�ߵ^',5,'AG'),
('Guitar5',6000,'���檴����',5,'AG'),
('EGuitar1',10000,'Fender����',2,'EG'),
('EGuitar2',8800,'Fender MIJ LTD Elemental Strat HH RW NWT ��t �զ� ���q�q�N�L',2,'EG'),
('EGuitar3',49000,'PRS SE Santana 50th LTD Abraxas �����B����',1,'EG'),
('EGuitar4',12000,'Gibson Les Paul Studio �s����',2,'EG'),
('EGuitar5',6500,'Comet St3 �s��W�u�f',10,'EG');

/* �ӫ~�Ӥ���� */
CREATE TABLE Images (
    Image_ID INT PRIMARY KEY IDENTITY(1,1),      -- �۰ʻ��W���D��
    Product_Id  INT NOT NULL,                      -- �~��A�s���� Products ��
    FilePath VARCHAR(255) NOT NULL,              -- �Ϥ����|
    SortOrder INT DEFAULT 1,                     -- �Ϥ���ܶ��ǡA�w�]�Ȭ� 1
    FOREIGN KEY (Product_Id) REFERENCES Products(Product_Id) -- �w�q�~��
);

truncate table Images

SELECT ISNULL(MAX(SortOrder), 0) FROM Images WHERE Product_Id = 5
/* �s�W�Ӥ���� */
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

/* �q����� */
CREATE TABLE Orders (
    Order_Id INT IDENTITY(1,1) PRIMARY KEY,   -- �۰ʻ��W���D��
    Member_Id INT NOT NULL,                   -- �~��A�s����|����
	PaymentMethod NVARCHAR(20) NOT NULL,--�I�ڤ覡
	name NVARCHAR(50) NOT NULL,			--�q�ʤH�m�W
	Phone VARCHAR(20) NOT NULL,			--�q�ʤH�q��
	Email VARCHAR(100) NOT NULL,		--�q�ʤHemail
	address NVARCHAR(100) NOT NULL,     --�q�ʤH�a�}
    TotalAmount INT NOT NULL,     -- �q���`��   
    CreatedDate DATETIME DEFAULT GETDATE(),  -- �q��Ыؤ��
	UpdateDate DATETIME,		--�q���s���
    FOREIGN KEY (Member_Id) REFERENCES Members(Member_Id)  -- �~�����
);

/* �q��Ӹ`��� */
CREATE TABLE OrdersDetails (
    OrderDetail_Id INT IDENTITY(1,1) PRIMARY KEY,   -- �۰ʻ��W���D��
	Order_Id INT NOT NULL, 
	Product_Id INT not null,
	Product_Name Varchar(50) not null,
	Quantity INT not null,
	UnitPrice INT not null,
    TotalAmount INT NOT NULL,     -- �q���`��   
    CreatedDate DATETIME DEFAULT GETDATE(),  -- �q��Ыؤ��
    FOREIGN KEY (Order_Id) REFERENCES Orders(Order_Id)  -- �~�����
);




