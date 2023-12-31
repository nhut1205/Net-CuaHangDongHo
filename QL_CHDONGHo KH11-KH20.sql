CREATE DATABASE QL_CHDONGHO
go
USE QL_CHDONGHO
go
CREATE TABLE Account
(
Username VARCHAR(50) NOT NULL,
Pass VARCHAR(50),
Email varchar(100),
IsAdminID varchar(8),
Displayname NVarChar(50),
Constraint pk_tk primary key (Username)
)
go
CREATE TABLE UserDetails
(
    Username VARCHAR(50) NOT NULL PRIMARY KEY,
    Address NVARCHAR(100),
    CMND VARCHAR(12),
    PhoneNumber VARCHAR(11),
)

go
create table IsAdmin
(
IsAdminID varchar(8) not null,
NameA NVarChar(100),
Constraint pk_Quyen primary key (IsAdminID)
)
go

CREATE TABLE Categories
(
CategoryID varchar(50) not null,
Name nvarchar(100),
Constraint pk_cat primary key (CategoryID)
)
go
CREATE TABLE Vendors
(
VendorId varchar(50) not null,
Name nvarchar(50),
Constraint pk_Vendors primary key (VendorId)
)
go
create table Orders
(
OrderId varchar(50) not null,
CustomerID nvarchar(20),
Address nvarchar(100),
OrderTotal float,
OrderPlaced nvarchar(50),
Username VARCHAR(50) ,
Constraint pk_Orders primary key (OrderId)
)

alter table Orders
alter column OrderPlaced date

go
create table Customer
(
CustomerID nvarchar(20)primary key not null,
FirtName nvarchar(20),
LastName nvarchar(50),
PhoneNumber varchar(50),
Email varchar(50),
GenderID INT,
)
go
create table Gender
(
GenderID INT primary key not null ,
GenderType NVARCHAR(5),
)

go
Create table OrderDetails
(
OrderDetailId varchar(50) not null,
OrderId varchar(50),
ProductId varchar(50),
Amount int ,
Price float ,
Constraint pk_OrderDetails primary key (OrderDetailId)
)
go
Create table Products
(
ProductId varchar(50) not null,
Name nvarchar(100),
Description nvarchar(100),
Price float,
Quantity int ,
guarantee varchar(50),
CategoryId varchar(50),
VendorId varchar(50),
DiscountPercent float,
Constraint pk_Products primary key (ProductId)
)

alter table Products 
alter column guarantee int

ALTER TABLE Products
ALTER COLUMN Price DECIMAL 

go
alter table Account
add constraint fk_tk_quyen foreign key(IsAdminID) references IsAdmin(IsAdminID)
go
alter table OrderDetails
add constraint fk_OrderDetails_Orders foreign key(OrderId) references Orders(OrderId),
	constraint fk_OrderDetails_Products foreign key(ProductId) references Products(ProductId)
go
ALTER TABLE Products
add constraint fk_Products_Categories foreign key(CategoryId) references Categories(CategoryId),
	constraint fk_Products_Vendors foreign key(VendorId) references Vendors(VendorId)
go
ALTER TABLE UserDetails
add constraint fk_Username_UserDetail foreign key(Username) references Account(Username)
go
alter table Orders
add constraint fk_Order_userName foreign key(Username) references Account(Username)
go
alter table Orders
add constraint fk_Order_Customer foreign key(CustomerID) references Customer(CustomerID)
go
alter table Customer
add constraint fk_Customer_Gender foreign key(GenderID) references Gender(GenderID)
go
alter table Gender
add constraint fk_Account_Gender foreign key(GenderID) references Gender(GenderID)
--Ràng buộc
Alter table Products
ADD CONSTRAINT CHK_QUANTITY CHECK (QUANTITY>=0)

select * from Customer
--INSERT INTO ISADMIN
Insert into IsAdmin VALUES
('ad' , 'Admin'),
('sl', 'Sale')
--INSERT INTO ACCOUNT
Insert into Account VALUES 
('anhminh' ,'nguyenhai1231', 'anhmin123@gmail.com' , 'sl' , N'Anh Minh' , 1),

('vananh123' ,'vananh33', 'vananh33@gmail.com' , 'sl' , N'Trần Thị Vân Anh' , 1)

--INSERT INTO GENDER
INSERT INTO Gender VALUES
(1,N'NAM'),
(2,N'NỮ')
-- INSERT INTO CUSTOMER
Insert into Customer VALUES 
('KH01',N'Anh',N'Nguyễn Hải','0903926730',N'haianh34@gmail.com',1),
('KH02',N'Hà',N'Trần Việt','0945146730',N'tranvietha4@gmail.com',2),
('KH03',N'Hằng',N'Phan Thanh','0332922730',N'phanhang67@gmail.com',2),
('KH04',N'Biểu',N'Hứa Quang','0953931730',N'quangbieu32@gmail.com',1),
('KH05',N'Thanh',N'Nguyễn Thị','0931986730',N'thithanh23@gmail.com',2),
('KH06',N'Nhi',N'Phùng Ái','0943926734',N'nhiai@gmail.com',2),
('KH07',N'Tú',N'Bùi Anh','0343826735',N'nhuta4@gmail.com',1),
('KH08',N'Anh',N'Lâm Quang','0343912430',N'nhuta4@gmail.com',1),
('KH09',N'Anh',N'Trần Thị Vân','0321312833',N'vananh1410@gmail.com',2),
('KH10',N'Nhựt',N'Phạm Minh','0908926760',N'nhut1205@gmail.com',2),
('KH011',N'Hoà',N'Ngô Bữu','0921862343','buuhoa09@gmail.com',1),
('KH012',N'Khoa',N'Đoàn Viết','0921868745','vietkhoa021@gmail.com',1),
('KH013',N'Hân',N'Quách Gia','0922862343','giahan29@gmail.com',2),
('KH014',N'Trường',N'Tạ Quang','0361862343','quangtruong293@gmail.com',1),
('KH015',N'Nhi',N'Hồ Vân','0921332343','vannhi512@gmail.com',2),
('KH016',N'Vinh',N'Nguyễn Tấn','0921862377','tanvinh728@gmail.com',1),
('KH017',N'Hiếu',N'Nguyễn Đăng','0921861188','danghieu83@gmail.com',1),
('KH018',N'Dũng',N'Lê Công Minh','0945662343','minhdung23@gmail.com',1),
('KH019',N'Uyên',N'Bùi Mỹ','0921878123','myuyen23@gmail.com',2),
('KH020',N'Thăng',N'Nguyễn Bá Đại','0927762343','daithang22@gmail.com',1),
('KH021', N'Đạt', N'Nguyễn Thành', '0325835947', 'nguyenthanhdai0102@gmail.com', 1),
('KH022', N'Thiên', N'Nguyễn Cao', '0323755564', 'nguyencaothien0912@gmail.com', 1),
('KH023', N'Hà', N'Nguyễn Thu', '0345678936', 'nguyenthuha1204@gmail.com', 2),
('KH024', N'Lan', N'Hồ Thị', '0363595784', 'hothilan0912@gmail.com', 2),
('KH025', N'Trung', N'Trần Văn', '0395838913', 'tranvantrung1407@gmail.com', 1),
('KH026', N'Tiên', N'Lý Thị', '0872689364', 'lythitien0911@gmail.com', 2),
('KH027', N'Quyên', N'Trần Ngọc', '0892456856', 'tranngocquyen0910@gmail.com', 2),
('KH028', N'Dũng', N'La Chí', '0374680975', 'lachidung2309@gmail.com', 1),
('KH029', N'Long', N'Nguyễn Lê', '03240863574', 'nguyenlelong2212@gmail.com', 1),
('KH030', N'Xuân', N'Nguyễn Kiều', '0385082596', 'nguyenkieuxuan0909@gmail.com', 2)

-- INSERT CATEGORIES
INSERT INTO Categories 
VALUES	('CAT01',N'Đồng Hồ Cơ'),
		('CAT02',N'Đồng Hồ Thạch Anh'),
		('CAT03',N'Đồng Hồ Thông Minh'),
		('CAT04',N'Đồng Hồ Solar'),
		('CAT05',N'Đồng Hồ Điện Tử'),
		('CAT06',N'Đồng Hồ Lai'),
		('CAT07',N'Đồng Hồ Quân Đội'),
		('CAT08', N'Đồng Hồ Thể Thao'),
		('CAT09', N'Đồng Hồ Trẻ Em'),
		('CAT10', N'Đồng Hồ Dây Kim Loại'),
		('CAT11', N'Đồng Hồ Dây Cao Su'),
		('CAT12', N'Đồng Hồ Dây Da'),
		('CAT13', N'Đồng Hồ Phong Cách Vintage'),
		('CAT14', N'Đồng Hồ Nam'),
        ('CAT15', N'Đồng Hồ Nữ');
GO
-- INSERT VENDORS
INSERT INTO Vendors
VALUES	('VEN01',N'Thế Giới Di Động'),
		('VEN02',N'Tân Tân Watch'),
		('VEN03',N'VinaWatch'),
		('VEN04',N'JPWatch'),
		('VEN05',N'Duy Anh Watch'),
		('VEN06',N'ZenWatch'),
		('VEN07',N'Đồng Hồ Thịnh Phát'),
		('VEN08',N'Sokolov'),
		('VEN09',N'Orient'),
		('VEN10',N'Citizen'),
	    ('VEN11',N'Daniel Wellington (DW)'),
        ('VEN12',N'Doxa'),
	    ('VEN13',N'Tissot'),
	    ('VEN14',N'Longines'),
	    ('VEN15',N'Seiko'),
        ('VEN16',N'Fossil')
GO
-- INSERT PRODUCTS
alter table products
alter column Description nvarchar(max)
INSERT INTO Products
VALUES	('PRO01',N'Đồng hồ thông minh Microwear GT4 Max',N'Sở hữu thiết kế thời thượng, sang trọng. Cùng với các thuật toán thông minh giúp việc hoạt động hiệu quả, cung cấp sức mạnh nâng cao khả năng tính toán…',950000,10,N'2 Năm','CAT03','VEN04',20),
		('PRO02',N'Đồng Hồ Thông Minh G-Max Watch 5 Pro',N'Đồng hồ thông minh G-Max Watch 5 Pro sở hữu thiết kế đẳng cấp tuyệt đẹp, bền bỉ và nhiều tính năng ưu việt sẽ là sự lựa chọn hàng đầu cho phái mạnh',1050000,5,N'1 Năm','CAT03','VEN03',30),
		('PRO03',N'Đồng hồ thông minh DT8 Max',N'Đồng hồ thông minh DT8 Max cải thiện toàn bộ trải nghiệm của người dùng từ thiết kế đến những tính năng sức khỏe, thể thao tiện ích, bền bỉ…',750000,10,N'2 Năm','CAT03','VEN03',40),
		('PRO04',N'Đồng Hồ Thông Minh DT8 Max',N'Đồng hồ thông minh G-Max Watch 5 Pro sở hữu thiết kế đẳng cấp tuyệt đẹp, bền bỉ và nhiều tính năng ưu việt sẽ là sự lựa chọn hàng đầu cho phái mạnh',799000,20,N'2 Năm','CAT03','VEN06',30),
		('PRO05',N'Casio W-218H-3AVDF',N'Mẫu Casio W-218H-3AVDF kiểu dáng nền mặt số điện tử hiện thị đa chức năng đầy tiện ích, với phiên bản thiết kế tổng thể bằng nhựa cùng khả năng chịu nước 5 ATM tạo nên vẻ cá tính đầy mạnh mẽ.',777000,4,N'1 Năm','CAT07','VEN05',40),
		('PRO06',N'Seiko 5 Field Sports Style SRPH29K1',N'Mẫu Seiko SRPH29K1 phiên bản dây vải tone màu xanh quận đội, chi tiết kim chỉ cùng các cọc chấm tròn nhỏ được phủ dạ quang trên nền mặt số đen kích thước 39.4mm.',7100000,2,N'2 Năm','CAT07','VEN05',30),
		('PRO07',N'Seiko 5 Field Sports Style SRPD83K1',N'Mẫu Seiko SRPD83K1 vẻ ngoài trẻ trung cá tính với mẫu dây vải đen đi kèm với cọc chấm tròn đỏ phủ dạ quang nổi bật trên mặt số đen size 42,5mm.',8060000,1,N'1 Năm','CAT07','VEN03',10),
		('PRO08',N'Citizen Tsuyosa NJ0154-80H',N'Mẫu Citizen NJ0154-80H phiên bản mặt kính chất liệu kính Sapphire với kích thước nam tính 40mm, kết hợp cùng mẫu dây đeo kim loại dây vàng demi phong cách thời trang sang trọng.',12600000 ,1,N'1 Năm','CAT07','VEN03',10),
		('PRO09',N'Casio LTP-1183Q-9ADF',N'Đồng hồ thời trang dây da Casio LTP-1183Q-9ADF dành cho nữ với thiết kế sang trọng, mặt nền vàng, với 3 kim chỉ mạ vàng và 1 lịch ngày.',1036000,1,N'1 Năm','CAT07','VEN03',10),
		('PRO10',N'Saga 53766-GPZMGGE-2',N'Mẫu Saga 53766-GPZMGGE-2 dây da trắng phiên bản da trơn trẻ trung, mặt số trắng, được khảm xà cừ với hiệu ứng bắt mắt.',6720000,1,N'1 Năm','CAT07','VEN03',10),
		('PRO11',N'Doxa GrandeMetre D154RWH',N'Mẫu Doxa D154RWH phiên bản giới hạn 1000 chiếc trên toàn thế giới, sự kết hợp cách điệu giữa các vạch số cùng chữ số la mã dày dặn.',144770000,1,N'1 Năm','CAT04','VEN03',10),
		('PRO12',N'Tissot Lovely Square T058.109.11.036.00',N'Mẫu Tissot T058.109.11.036.00 phiên bản sang trọng 12 viên kim cương tương ứng với 12 múi giờ đính trên nền mặt số vuông với kích thước nhỏ 20mm.',10330000 ,1,N'1 Năm','CAT07','VEN03',10),
		('PRO13',N'Fossil ME3099 ',N'Mẫu đồng hồ Fossil ME3099 với vẻ ngoài được thiết kế theo phong cách giản dị nhưng chứa đựng vẻ độc đáo với nển mặt số chân kính lộ ra 1 phần trải nghiệm của bộ máy cơ đậm chất nam tính.',6880000 ,1,N'1 Năm','CAT07','VEN03',10),
		('PRO14',N'Calvin Klein K0K28120',N'Mẫu Calvin Klein K0K28120 thiết kế 3 núm vặn điều chỉnh các chức năng đo thời gian Chronograph hiện thị trên mặt số size 39mm.',10420000 ,1,N'1 Năm','CAT05','VEN01',10),
		('PRO15',N'Rado Coupole R22862154',N'Mẫu Rado R22862154 mặt số đen size 31mm thiết kế họa tiết trải tia nhẹ phong cách thời trang trẻ trung cùng với thiết kế mỏng trên chi tiết kim chỉ cùng cọc vạch số.',34500000 ,1,N'1 Năm','CAT07','VEN03',10),
		('PRO16',N'Casio EFR-526L-2AVUDF',N'Đồng hồ Casio EFR-526L-2AVUDF với thiết kế dành cho nam theo phong cách thời trang, kim chỉ và vạch số to rõ nổi bật trên nền số xanh thể thao, ô lịch ngày vị trí 3 giờ.',3356000 ,1,N'1 Năm','CAT07','VEN03',10),
		('PRO17',N'Daniel Wellington MOP Quadro Special Edition',N'Mẫu Daniel Wellington DW00100509 phiên bản mặt số chữ nhật được phối tone màu hồng xà cừ thời trang trẻ trung kết hợp cùng mẫu máy pin được thiết kế siêu mỏng chỉ 6mm.',4533000  ,1,N'1 Năm','CAT15','VEN03',10),
		('PRO18',N'Daniel Wellington Quadro Studio DW00100518',N'Mẫu Daniel Wellington DW00100518 phiên bản mặt số vuông đen kích thước 22mm thời trang trẻ trung kết hợp cùng mẫu dây đeo kim loại được phối tone màu vàng hồng.',5195000 ,1,N'1 Năm','CAT15','VEN03',10),
		('PRO19',N'Casio F-91W-1HDG',N'Mẫu Casio F-91W-1HDG phiên bản mặt số vuông điện tử phong cách hoài cổ, thiết kế đa chức năng kết hợp cùng mẫu dây vỏ cao su khả năng chịu va đập.',492000 ,1,N'1 Năm','CAT14','VEN03',10),
		('PRO20',N'Casio W-218H-3AVDF',N'Mẫu Casio W-218H-3AVDF kiểu dáng nền mặt số điện tử hiện thị đa chức năng đầy tiện ích, với phiên bản thiết kế tổng thể bằng nhựa cùng khả năng chịu nước 5 ATM tạo nên vẻ cá tính đầy mạnh mẽ.',777000 ,1,N'1 Năm','CAT14','VEN03',10),
		('PRO21',N'Casio HDC-700-3A3VDF',N'Mẫu Casio HDC-700-3A3VDF phiên bản cá tính với thiết kế dây vỏ nhựa chịu va đập, mặt số điện tử hiện thị đa chức năng nổi bật với khả năng chống nước lên đến 10atm.',1633000 ,1,N'1 Năm','CAT11','VEN03',10)

---------------Trigger-----------------
--1. cập nhật hóa đơn theo chi tiết hóa đơn 
CREATE TRIGGER updateOrderTotal
ON orderDetails
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @orderID INT
    DECLARE @total DECIMAL(18, 2)

    SELECT @orderID = orderID FROM inserted

    SELECT @total = SUM(amount * price) FROM orderDetails WHERE orderID = @orderID

    UPDATE [Orders] SET ordertotal = @total WHERE orderID = @orderID
END

--Sửa lại 
Go
ALTER TRIGGER updateOrderTotal
ON orderDetails
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
	UPDATE Orders
	SET OrderTotal=(SELECT SUM(ord.Amount * ord.price) FROM orderDetails ord,inserted i WHERE ord.OrderId=i.OrderId )
	From Orders ord
	where (	select i.OrderId from inserted i)=ord.OrderId


	UPDATE Orders
	SET OrderTotal=OrderTotal-(SELECT SUM(ord.amount * ord.price) FROM orderDetails ord,deleted del WHERE ord.OrderId=del.OrderId )
	From Orders ord
	where (	select del.OrderId from deleted del)=ord.OrderId
END
Go
--2.Trigger update giảm số lượng hàng trong kho khi thêm vào orderdetail
CREATE TRIGGER trg_CapNhapProduct on OrderDetails
for INSERT, UPDATE, DELETE
AS
begin 
 UPDATE Products 
    set quantity = quantity - (SELECT Amount FROM INSERTED)
    FROM Products P, INSERTED i
    WHERE P.productid = i.productid
    
    UPDATE Products 
    set quantity = quantity + (SELECT Amount FROM DELETED)
    FROM Products P, DELETED i
    WHERE P.productid = i.productid
END

--3.Trigger Cập nhật description hết sản phẩm khi số lượng về 0
CREATE TRIGGER trg_UpdateProductDescription
ON Products
AFTER UPDATE
AS
BEGIN
    IF UPDATE(Quantity)
    BEGIN
        UPDATE Products
        SET Description = N'Hết sản phẩm'
        FROM inserted i
        WHERE Products.ProductId = i.ProductId
        AND i.Quantity = 0
    END
END
GO
--4.Khi tạo account , tạo thông tin cho userDetails
CREATE TRIGGER set_undefined_address
ON Account
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Insert vào UserDetails cho mỗi dòng được chèn vào bảng Account
    INSERT INTO UserDetails (Username, Address)
    SELECT ins.Username, 'Không xác định'
    FROM inserted ins;
END;


--5.

---Hàm-------------------------
--1. LẤY HỌ TÊN, SĐT, EMAIL CỦA CUSTOMER KHI TRUYỀN VÀO CUSTOMERID
go
CREATE FUNCTION f_inTT_Customer(@CUSID VARCHAR(50))
RETURNS @TT_CUSTOMER table (HOTEN NVARCHAR(50), SDT VARCHAR(10), EMAIL VARCHAR(50))
AS
BEGIN
	if exists(select * from Customer where CustomerID = @CUSID)
		insert into @TT_CUSTOMER
			select CONCAT(LastName, ' ', FirtName), PhoneNumber, Email
			from Customer
			where CustomerID = @CUSID		
	RETURN
END
go
select * from dbo.f_inTT_Customer('KH021')
GO
--2. CHO BIẾT SỐ LƯỢNG ĐƠN HÀNG CUSTOMER ĐÃ ĐẶT KHI TRUYỀN VÀO CUSTOMERID
CREATE FUNCTION f_inSL_DH_Customer_Order(@CUSID VARCHAR(50))
RETURNS @TT_CUSTOMER table (HOTEN_KH NVARCHAR(50), SL_DONHANG INT)
AS
BEGIN
	if exists(select * from Orders where CustomerID = @CUSID)
		insert into @TT_CUSTOMER
			select CONCAT(LastName, ' ', FirtName), Count(OrderDetailId) 
			from Orders O, Customer C, OrderDetails OD
			where O.CustomerID = C.CustomerID and C.CustomerID = @CUSID and O.OrderId = OD.OrderId		
			group by CONCAT(LastName, ' ', FirtName)
	RETURN
END
go
select * from dbo.f_inSL_DH_Customer_Order('KH01')
--3.MẶT HÀNG BÁN CHẠY NHẤT

go
CREATE FUNCTION f_mathang_banchaynhat()
RETURNS NVARCHAR(50)
AS
BEGIN
    DECLARE @TENMH NVARCHAR(50)

    SELECT TOP 1 @TENMH = pro.Name
    FROM OrderDetails ord
    INNER JOIN Products pro ON pro.ProductId = ord.ProductId
    GROUP BY pro.Name
    ORDER BY SUM(ord.Amount) DESC -- Lấy sản phẩm có tổng Amount lớn nhất

    RETURN @TENMH
END

SELECT dbo.f_mathang_banchaynhat() AS TenMatHangBanChayNhat;

--4. IN DS HÓA ĐƠN KHI TRUYỀN VÀO MÃ NHÂN VIÊN
go
create function f_inDS_HoaDonDaLap(@username varchar(30))
returns @tblHD table(MaHD varchar(30))
as
begin
	insert into @tblHD
	select OrderId from Orders where Username = @username 
	return
end
go
insert into Orders(OrderId, CustomerID, Username) values('O1', 'KH022', 'vandao')
insert into Orders(OrderId, CustomerID, Username) values('O2', 'KH022', 'vandao')
insert into Orders(OrderId, CustomerID, Username) values('O3', 'KH022', 'vandao')
insert into Orders(OrderId, CustomerID, Username) values('O4', 'KH022', 'vandao')
GO
select * from dbo.f_inDS_HoaDonDaLap('vandao')
GO
--5. IN HỌ TÊN NHÂN VIÊN BÁN ĐƯỢC NHIỀU TIỀN NHẤT DỰA VÀO TỔNG TIỀN TRONG BẢNG ORDERS
create function f_InHoTenNVBanDuocNhieuDonNhat(@username varchar(30))
returns @ttnv table(HOTEN nvarchar(30), TONGTIEN FLOAT)
as
begin
	insert into @ttnv 
	select Displayname, Sum(OrderTotal) from Orders O, Account A
	where O.Username = A.Username and O.Username = @username
	group by Displayname
	return
end
go
select * from dbo.f_InHoTenNVBanDuocNhieuDonNhat('vandao')
go
--6.Tổng Số Lượng Đồng Hồ hiện có
CREATE FUNCTION f_Tong_SoLuongDongHo()
RETURNS INT 
BEGIN
	DECLARE @TONG INT
	SET @TONG=(SELECT SUM(Quantity) FROM Products)
	RETURN @TONG
END
GO
DECLARE @TONG_SoLuongDongHo INT
SET @TONG_SoLuongDongHo=dbo.f_Tong_SoLuongDongHo()
PRINT N'Tổng số lượng đồng hồ shop hiện có là : '+Convert(varchar,@TONG_SoLuongDongHo)+N' cái. '
---THỦ TỤC-------------------------------
-- 1.MẶT HÀNG BÁN CHẠY NHẤT
Create PROCEDURE p_mathang_banchaynhat
    @TenMH NVARCHAR(50) OUTPUT
AS
BEGIN
    SELECT TOP 1 @TenMH = pro.Name
    FROM OrderDetails ord
    INNER JOIN Products pro ON pro.ProductId = ord.ProductId
    GROUP BY pro.ProductId, ord.ProductId, pro.Name
    ORDER BY SUM(ord.Amount) DESC
END
-- 2.THỦ TỤC IN DS HÓA ĐƠN KHI TRUYỀN VÀO MÃ NHÂN VIÊN
create proc p_inDS_HoaDonDaLap @username varchar(30)
as
select OrderId from Orders where Username = @username
go
exec p_inDS_HoaDonDaLap 'vandao'
go
-- 3.thủ tục IN HỌ TÊN NHÂN VIÊN BÁN ĐƯỢC NHIỀU TIỀN NHẤT DỰA VÀO TỔNG TIỀN TRONG BẢNG ORDERS
create PROC p_nhanvien_banduocnhieunhat_OrderTotal
as
	DECLARE @TENNV NVARCHAR(50)
	SET @TENNV=(SELECT ac.Displayname FROM Orders ords,Account ac where ac.Username=ords.Username and ords.OrderTotal=(SELECT top 1 sum(OrderTotal) FROM Orders ords,Account ac where ac.Username=ords.Username
	GROUP BY ords.CustomerID,ac.Username))
	print @TENNV
go
exec p_nhanvien_banduocnhieunhat_OrderTotal

-- 4.Pro thêm sản phẩm 
GO
CREATE PROCEDURE InsertProduct
    @ProductId VARCHAR(50),
    @Name NVARCHAR(100),
    @Description NVARCHAR(100),
    @Price FLOAT,
    @Quantity INT,
    @Guarantee VARCHAR(50),
    @CategoryId VARCHAR(50),
    @VendorId VARCHAR(50),
    @DiscountPercent FLOAT
AS
BEGIN
    INSERT INTO Products (ProductId, Name, Description, Price, Quantity, Guarantee, CategoryId, VendorId, DiscountPercent)
    VALUES (@ProductId, @Name, @Description, @Price, @Quantity, @Guarantee, @CategoryId, @VendorId, @DiscountPercent)
END
--Thêm
EXEC InsertProduct 
    @ProductId = 'PRO123',
    @Name = 'Casio World Time AE-1200WHD',
    @Description = N'Đồng hồ nam Casio AE1200WHD có mặt đồng hồ vuông to với phong cách thể thao',
    @Price = 1373000,
    @Quantity = 10,
    @Guarantee = 12,
    @CategoryId = 'CAT14',
    @VendorId = 'VEN01',
    @DiscountPercent = 0
--5. Thủ tục xóa
go
CREATE PROCEDURE DeleteProduct
    @ProductId VARCHAR(50)
AS
BEGIN
    DELETE FROM Products
    WHERE ProductId = @ProductId
END
--Xóa
EXEC DeleteProduct @ProductId = 'PRO123'
--6.Tăng số lượng sản phẩm lên 10 khi nhập vào ID sản phẩm
go
CREATE PROC p_tangsl_len10_ID
@ProductID varchar(50)
AS
    UPDATE Products SET Quantity = Quantity + 10 where ProductId=@ProductID
GO
EXEC p_tangsl_len10_ID 'PRO06'
GO
select *from Products
--7.Lấy danh sách sản phẩm còn hàng
go
CREATE PROCEDURE p_ds_SanPham_ConHang
AS
BEGIN
    SELECT *
    FROM Products
    WHERE Quantity > 0;
END
GO
EXEC p_ds_SanPham_ConHang

-------------------------Cusor----------------------------
-- 1.Nhập vào ProductId In ra các thông tin sau CustumerId,LastName,FirstName
DECLARE @CUSTOMERID_LASTNAME_FIRSTNAME NVARCHAR(MAX)
DECLARE @CUSTOMERID VARCHAR(50)
DECLARE @FIRSTNAME NVARCHAR(50)
DECLARE @LASTNAME NVARCHAR(50)

DECLARE cursor_CUSTOMERID_LASTNAME_FIRSTNAME CURSOR FOR
SELECT cus.CustomerID,cus.FirtName,cus.LastName from Customer cus,Orders ords,OrderDetails ordd,Products pro
WHERE cus.CustomerID=ords.CustomerID AND ords.OrderId=ordd.OrderId AND ordd.ProductId=pro.ProductId AND pro.ProductId='PRO06'

OPEN cursor_CUSTOMERID_LASTNAME_FIRSTNAME

FETCH NEXT FROM cursor_CUSTOMERID_LASTNAME_FIRSTNAME INTO @CUSTOMERID, @FIRSTNAME,@LASTNAME

WHILE @@FETCH_STATUS = 0
BEGIN
    SET @CUSTOMERID_LASTNAME_FIRSTNAME = N'Mã Khách Hàng : ' + @CUSTOMERID + ' -  Tên Khách Hàng : '+ @LASTNAME+' '+ @FIRSTNAME 
    PRINT @CUSTOMERID_LASTNAME_FIRSTNAME
    FETCH NEXT FROM cursor_CUSTOMERID_LASTNAME_FIRSTNAME INTO @CUSTOMERID, @FIRSTNAME,@LASTNAME
END

CLOSE cursor_CUSTOMERID_LASTNAME_FIRSTNAME
DEALLOCATE cursor_CUSTOMERID_LASTNAME_FIRSTNAME

select *from Products
select *from OrderDetails
select *from Orders
Select *from Customer

--2.In thông tin sản phẩm từ bảng products
DECLARE @ProductId VARCHAR(50)
DECLARE @ProductName NVARCHAR(100)

DECLARE productCursor CURSOR FOR
SELECT ProductId, Name
FROM Products

OPEN productCursor

FETCH NEXT FROM productCursor INTO @ProductId, @ProductName
WHILE @@FETCH_STATUS = 0
BEGIN
    -- Do something with @ProductId and @ProductName here
    PRINT 'Product ID: ' + @ProductId + ', Product Name: ' + @ProductName

    FETCH NEXT FROM productCursor INTO @ProductId, @ProductName
END

CLOSE productCursor
--Giải phóng tài nguyên
DEALLOCATE productCursor

--3.
DECLARE @CustomerID NVARCHAR(20)
DECLARE @FirstName NVARCHAR(20)
DECLARE @LastName NVARCHAR(50)

DECLARE customerCursor CURSOR FOR
SELECT CustomerID, FirtName, LastName
FROM Customer

OPEN customerCursor

FETCH NEXT FROM customerCursor INTO @CustomerID, @FirstName, @LastName
WHILE @@FETCH_STATUS = 0
BEGIN
    -- Xử lý dữ liệu với @CustomerID, @FirstName và @LastName tại đây
    PRINT 'Customer ID: ' + @CustomerID + ', Full Name: ' + @FirstName + ' ' + @LastName

    FETCH NEXT FROM customerCursor INTO @CustomerID, @LastName, @FirstName
END

CLOSE customerCursor
DEALLOCATE customerCursor
---
--In ra username, tên nhân viên, quyền, địa chỉ của tất cả nhân viên 
DECLARE @username VARCHAR(50), 
		@displayname NVARCHAR(50), 
		@roleName NVARCHAR(50),
		@Address NVARCHAR(50)
DECLARE account_cursor CURSOR FOR
    SELECT A.username, A.displayname, I.NameA, U.Address
    FROM Account A
    LEFT JOIN isAdmin I ON A.isAdminId = I.isAdminId
    LEFT JOIN UserDetails U ON A.username = U.username;

OPEN account_cursor;

FETCH NEXT FROM account_cursor INTO @username, @displayname, @roleName, @Address;

WHILE @@FETCH_STATUS = 0
BEGIN
    -- In ra thông tin Account tại đây
    PRINT 'Username: ' + @username + ', Display Name: ' + @displayname + ',Role: ' + @roleName + ',Address: ' + @Address;

	-- Nếu không có displayname, hiển thị Chưa có
    IF @displayname IS  NULL
		PRINT 'Username: ' + @username + ', Display Name: Chưa có' + ', Role: ' + @roleName + N', Address: Không xác định';
    -- Nếu không có địa chỉ, hiển thị Không xác định
    IF @Address IS  NULL
		PRINT 'Username: ' + @username + ', Display Name: ' + @displayname + ', Role: ' + @roleName + N', Address: Không xác định';

    FETCH NEXT FROM account_cursor INTO @username, @displayname, @roleName, @Address;
END

CLOSE account_cursor;
DEALLOCATE account_cursor;

CREATE OR ALTER FUNCTION F_xuat_TT_KH_ProductID(@ProductID VARCHAR(50))
RETURNS @LCUS TABLE(THONGTIN VARCHAR(MAX))
AS
	BEGIN
		DECLARE @CUSTOMERID_LASTNAME_FIRSTNAME NVARCHAR(MAX)
		DECLARE @CUSTOMERID VARCHAR(50)
		DECLARE @FIRSTNAME NVARCHAR(50)
		DECLARE @LASTNAME NVARCHAR(50)
		-- ĐỊNH NGHĨA CURSOR
		DECLARE cursor_CUSTOMERID_LASTNAME_FIRSTNAME CURSOR FOR
		SELECT cus.CustomerID,cus.FirtName,cus.LastName from Customer cus,Orders ords,OrderDetails ordd,Products pro
		WHERE cus.CustomerID=ords.CustomerID AND ords.OrderId=ordd.OrderId AND ordd.ProductId=pro.ProductId AND pro.ProductId=@ProductID
		-- MỞ CURSOR
		OPEN cursor_CUSTOMERID_LASTNAME_FIRSTNAME
		-- XỬ LÍ DỮ LIỆU TRONG CURSOR
		FETCH NEXT FROM cursor_CUSTOMERID_LASTNAME_FIRSTNAME INTO @CUSTOMERID, @FIRSTNAME,@LASTNAME
		WHILE @@FETCH_STATUS = 0
		BEGIN
			SET @CUSTOMERID_LASTNAME_FIRSTNAME = N'Mã Khách Hàng : ' + @CUSTOMERID + N' -  Tên Khách Hàng : '+ @LASTNAME+' '+ @FIRSTNAME 
			INSERT INTO @LCUS
			select @CUSTOMERID_LASTNAME_FIRSTNAME
			FETCH NEXT FROM cursor_CUSTOMERID_LASTNAME_FIRSTNAME INTO @CUSTOMERID, @FIRSTNAME,@LASTNAME
		END

		
		-- ĐÓNG CURSOR
		CLOSE cursor_CUSTOMERID_LASTNAME_FIRSTNAME
		DEALLOCATE cursor_CUSTOMERID_LASTNAME_FIRSTNAME

		RETURN
	END

	SELECT *FROM DBO.F_xuat_TT_KH_ProductID('PRO06')