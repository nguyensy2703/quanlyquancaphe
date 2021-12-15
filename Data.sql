CREATE DATABASE QUANLYQUANCAFE
GO

USE QUANLYQUANCAFE
GO


--BÀN ĂN
--ACCOUNT
--MÓN ĂN
--LOẠI MÓN (nước, đồ nhậu, đồ ăn vặt,...)
--HÓA ĐƠN
--THÔNG TIN HÓA ĐƠN

CREATE TABLE BAN_AN
(
	id_table INT IDENTITY PRIMARY KEY,
	name_table NVARCHAR(50) NOT NULL,
	status_table INT NOT NULL DEFAULT 0
)


CREATE TABLE ACCOUNT
(
	user_name NVARCHAR(50) NOT NULL PRIMARY KEY,
	password NVARCHAR(50) NOT NULL,
	display_name NVARCHAR(50) NOT NULL DEFAULT N'Người dùng',
	birthday DATE,
	address NVARCHAR(100),
	type INT NOT NULL
)

CREATE TABLE LOAI_MON
(
	id_foodcategory INT IDENTITY PRIMARY KEY ,
	foodcategory_name NVARCHAR(50) NOT NULL,
)



CREATE TABLE MON_AN
(
	id_food INT IDENTITY PRIMARY KEY,
	food_name NVARCHAR(50) NOT NULL,
	id_category_fk INT NOT NULL,
	price INT NOT NULL DEFAULT 0

	FOREIGN KEY (id_category_fk) REFERENCES dbo.LOAI_MON(id_foodcategory)
)

CREATE TABLE HOA_DON
(
	id_bill INT IDENTITY PRIMARY KEY,
	date_checkin DATE NOT NULL DEFAULT GETDATE(),
	date_checkout DATE,
	id_table_fk INT NOT NULL,
	status_bill INT NOT NULL,
	discount INT DEFAULT 0,
	total INT DEFAULT 0
	
	FOREIGN KEY (id_table_fk) REFERENCES dbo.BAN_AN(id_table)
)

CREATE TABLE THONG_TIN_HOA_DON
(
	id_billinfor INT IDENTITY PRIMARY KEY,
	id_bill_fk INT NOT NULL,
	id_food_fk INT NOT NULL,
	count INT NOT NULL DEFAULT 0

	FOREIGN KEY (id_bill_fk) REFERENCES dbo.HOA_DON(id_bill),
	FOREIGN KEY (id_food_fk) REFERENCES dbo.MON_AN(id_food)
)
GO

INSERT INTO dbo.ACCOUNT
(
    user_name,
    password,
    display_name,
    birthday,
    address,
    type
)
VALUES
(   N'admin',       -- user_name - nvarchar(50)
    N'admin',       -- password - nvarchar(50)
    N'Nguyễn Thanh Sỹ',       -- display_name - nvarchar(50)
    NULL, -- birthday - date
    N'Hà Nội',       -- address - nvarchar(100)
    1          -- type - int
    )
INSERT INTO dbo.ACCOUNT
(
    user_name,
    password,
    display_name,
    birthday,
    address,
    type
)
VALUES
(   N'staff',       -- user_name - nvarchar(50)
    N'staff',       -- password - nvarchar(50)
    N'Đỗ Chí Hùng',       -- display_name - nvarchar(50)
    NULL, -- birthday - date
    N'Yên Bái',       -- address - nvarchar(100)
    0          -- type - int
    )



INSERT INTO dbo.LOAI_MON
(
    foodcategory_name
)
VALUES
(N'Bia' -- foodcategory_name - nvarchar(50)
    )
INSERT INTO dbo.LOAI_MON
(
    foodcategory_name
)
VALUES
(N'Cafe' -- foodcategory_name - nvarchar(50)
    )
INSERT INTO dbo.LOAI_MON
(
    foodcategory_name
)
VALUES
(N'Trà Sữa' -- foodcategory_name - nvarchar(50)
    )


INSERT INTO dbo.MON_AN
(
    food_name,
    id_category_fk,
    price
)
VALUES
(   N'Heineken', -- food_name - nvarchar(50)
    1,   -- id_category_fk - int
    30000    -- price - int
    )
INSERT INTO dbo.MON_AN
(
    food_name,
    id_category_fk,
    price
)
VALUES
(   N'Bia Hà Nội', -- food_name - nvarchar(50)
    1,   -- id_category_fk - int
    15000    -- price - int
    )
INSERT INTO dbo.MON_AN
(
    food_name,
    id_category_fk,
    price
)
VALUES
(   N'Tiger', -- food_name - nvarchar(50)
    1,   -- id_category_fk - int
    15000    -- price - int
    )
INSERT INTO dbo.MON_AN
(
    food_name,
    id_category_fk,
    price
)
VALUES
(   N'Machiato', -- food_name - nvarchar(50)
    2,   -- id_category_fk - int
    20000    -- price - int
    )
INSERT INTO dbo.MON_AN
(
    food_name,
    id_category_fk,
    price
)
VALUES
(   N'Cappuccino', -- food_name - nvarchar(50)
    2,   -- id_category_fk - int
    20000    -- price - int
    )

INSERT INTO dbo.MON_AN
(
    food_name,
    id_category_fk,
    price
)
VALUES
(   N'Sữa tươi trân châu đường đen', -- food_name - nvarchar(50)
    3,   -- id_category_fk - int
    20000    -- price - int
    )
INSERT INTO dbo.MON_AN
(
    food_name,
    id_category_fk,
    price
)
VALUES
(   N'Trà đào cam sả', -- food_name - nvarchar(50)
    3,   -- id_category_fk - int
    20000    -- price - int
    )
INSERT INTO dbo.MON_AN
(
    food_name,
    id_category_fk,
    price
)
VALUES
(   N'Trà chanh truyền thống', -- food_name - nvarchar(50)
    3,   -- id_category_fk - int
    10000    -- price - int
    )


INSERT INTO dbo.BAN_AN
(
    name_table,
    status_table
)
VALUES
(   N'Bàn số 1', -- name_table - nvarchar(50)
    0    -- status_table - int
    )
INSERT INTO dbo.BAN_AN
(
    name_table,
    status_table
)
VALUES
(   N'Bàn số 2', -- name_table - nvarchar(50)
    0    -- status_table - int
    )
INSERT INTO dbo.BAN_AN
(
    name_table,
    status_table
)
VALUES
(   N'Bàn số 3', -- name_table - nvarchar(50)
    0    -- status_table - int
    )
INSERT INTO dbo.BAN_AN
(
    name_table,
    status_table
)
VALUES
(   N'Bàn số 4', -- name_table - nvarchar(50)
    0    -- status_table - int
)
INSERT INTO dbo.BAN_AN
(
    name_table,
    status_table
)
VALUES
(   N'Bàn số 5', -- name_table - nvarchar(50)
    0    -- status_table - int
    )
INSERT INTO dbo.BAN_AN
(
    name_table,
    status_table
)
VALUES
(   N'Bàn số 6', -- name_table - nvarchar(50)
    0    -- status_table - int
    )
GO
INSERT INTO dbo.BAN_AN
(
    name_table,
    status_table
)
VALUES
(   N'Bàn số 7', -- name_table - nvarchar(50)
    0    -- status_table - int
    )
GO
INSERT INTO dbo.BAN_AN
(
    name_table,
    status_table
)
VALUES
(   N'Bàn số 8', -- name_table - nvarchar(50)
    0    -- status_table - int
    )
GO
INSERT INTO dbo.BAN_AN
(
    name_table,
    status_table
)
VALUES
(   N'Bàn số 9', -- name_table - nvarchar(50)
    0    -- status_table - int
    )
GO
INSERT INTO dbo.BAN_AN
(
    name_table,
    status_table
)
VALUES
(   N'Bàn số 10', -- name_table - nvarchar(50)
    0    -- status_table - int
    )
GO



CREATE PROCEDURE USP_Account
@User_name nvarchar(50)
AS
BEGIN
	SELECT*FROM dbo.ACCOUNT WHERE user_name=@User_name
END
GO

CREATE PROCEDURE USP_Login
@Username nvarchar(50), @Password NVARCHAR(50)
AS
BEGIN
	SELECT*FROM dbo.ACCOUNT WHERE user_name= @Username AND password= @Password
END
GO



CREATE PROCEDURE USP_TableList
AS
BEGIN
	SELECT*FROM dbo.BAN_AN
END
GO




--SELECT food_name, foodcategory_name, price,  count 
--FROM dbo.HOA_DON,dbo.MON_AN,dbo.THONG_TIN_HOA_DON,dbo.LOAI_MON 
--WHERE dbo.HOA_DON.id_bill= dbo.THONG_TIN_HOA_DON.id_bill_fk 
--AND dbo.MON_AN.id_food=dbo.THONG_TIN_HOA_DON.id_food_fk
--AND dbo.MON_AN.id_category_fk=dbo.LOAI_MON.id_foodcategory
--AND id_table_fk=1
--AND status_bill=0




CREATE PROC USP_InsertBill
@idTable INT
AS
BEGIN

	INSERT INTO dbo.HOA_DON
	(
	    date_checkin,
	    date_checkout,
	    id_table_fk,
	    status_bill,
	    discount,
	    total
	)
	VALUES
	(   GETDATE(), -- date_checkin - date
	    NULL, -- date_checkout - date
	    @idTable,         -- id_table_fk - int
	    0,         -- status_bill - int
	    0,         -- discount - int
	    0          -- total - int
	    )

END
GO



CREATE PROC USP_InsertBillInfor
@id_Bill INT, @id_Food INT, @count INT
AS
BEGIN
	
	DECLARE @CheckBill INT;
	DECLARE @FoodCount INT;

	SELECT @CheckBill=id_billinfor, @FoodCount=count 
	FROM dbo.THONG_TIN_HOA_DON 
	WHERE id_bill_fk=@id_Bill AND id_food_fk=@id_Food

	IF (@CheckBill>0)
		BEGIN

			IF(@FoodCount+@count >0)
				UPDATE dbo.THONG_TIN_HOA_DON 
				SET count=count+@count
				WHERE id_bill_fk=@id_Bill AND id_food_fk=@id_Food
			ELSE
				DELETE dbo.THONG_TIN_HOA_DON WHERE id_bill_fk=@id_Bill AND id_food_fk=@id_Food

		END
	ELSE
		BEGIN
		IF (@count>0)
			INSERT INTO dbo.THONG_TIN_HOA_DON
			(
				id_bill_fk,
				id_food_fk,
				count
			)
			VALUES
			(   @id_Bill, -- id_bill_fk - int
				@id_Food, -- id_food_fk - int
				@count  -- count - int
			)


		END

END
GO



CREATE TRIGGER TG_UpdateBillInfor
ON dbo.THONG_TIN_HOA_DON FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	SELECT @idBill = Inserted.id_bill_fk FROM Inserted

	DECLARE @idTable INT
	SELECT @idTable=id_table_fk FROM dbo.HOA_DON WHERE id_bill=@idBill AND status_bill=0

	UPDATE dbo.BAN_AN SET status_table=1 WHERE id_table=@idTable


END
GO



CREATE TRIGGER TG_UpdateBill
ON dbo.HOA_DON FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	SELECT @idBill=Inserted.id_bill FROM Inserted


	DECLARE @idTable INT
	SELECT @idTable= id_table_fk FROM dbo.HOA_DON WHERE id_bill=@idBill 
	
	DECLARE @count INT=0
	SELECT @count=COUNT(*) FROM dbo.HOA_DON WHERE id_table_fk=@idTable AND status_bill=0

	IF(@count=0)
	UPDATE dbo.BAN_AN SET status_table=0 WHERE id_table=@idTable


	--DECLARE @idTable INT
	--SELECT @idTable= id_table_fk FROM update 

END
GO





CREATE PROC USP_Report
@TimeFrom DATE, @TimeTo DATE
AS
BEGIN
	SELECT id_bill AS N'Số hóa đơn',name_table AS N'Bàn đặt', total AS N'Tổng tiền', discount AS N'Giảm giá', date_checkin AS N'Check in', date_checkout AS N'Check out'  
	FROM dbo.HOA_DON, dbo.BAN_AN 
	WHERE id_table=id_table_fk AND status_bill=1
	AND date_checkin>=@TimeFrom AND date_checkout <=@TimeTo
END
GO

CREATE PROC USP_Total
@TimeFrom DATE, @TimeTo DATE
AS
BEGIN
	SELECT SUM(total)  
	FROM dbo.HOA_DON, dbo.BAN_AN 
	WHERE id_table=id_table_fk AND status_bill=1
	AND date_checkin>=@TimeFrom AND date_checkout <=@TimeTo
END
GO

CREATE PROC USP_UpdateAccountInfor
@displayname NVARCHAR(50), @birthday DATE, @address NVARCHAR(100), @username NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.ACCOUNT SET display_name=@displayname, birthday=@birthday, address=@address WHERE user_name=@username
END
GO

CREATE PROC USP_CheckUsername
@username NVARCHAR(50)
AS
BEGIN
	SELECT*FROM dbo.ACCOUNT WHERE user_name= @username
END
GO

CREATE PROC USP_UpdateAccount
@user NVARCHAR(50), @pass NVARCHAR(50), @reuser NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.ACCOUNT SET user_name=@reuser, password=@pass WHERE user_name=@user 
END
GO

CREATE PROC USP_InsertFood
@name NVARCHAR(50) , @idCategory INT, @price INT
AS
BEGIN
	INSERT INTO dbo.MON_AN
(
    food_name,
    id_category_fk,
    price
)
VALUES
(   @name, -- food_name - nvarchar(50)
    @idCategory,   -- id_category_fk - int
    @price    -- price - int
    )
END
GO

CREATE PROC USP_EditFood
@id INT, @name NVARCHAR(50) , @idCategory INT, @price INT
AS
BEGIN
	UPDATE dbo.MON_AN SET food_name=@name, id_category_fk=@idCategory, price=@price WHERE id_food=@id
END
GO

CREATE PROC USP_DeleteFood
@id INT 
AS
BEGIN
	DELETE FROM dbo.MON_AN WHERE id_food=@id
END
GO




CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO

CREATE PROC USP_SearchFood
@search NVARCHAR(50)
AS
BEGIN
	SELECT 
	id_food AS N'ID Food', 
	food_name AS N'Tên món', 
	foodcategory_name AS N'Loại món', 
	price AS N'Giá tiền'  
	FROM dbo.MON_AN, dbo.LOAI_MON 
    WHERE id_foodcategory=id_category_fk 
	AND
	dbo.fuConvertToUnsign1(food_name)  LIKE N'%'+dbo.fuConvertToUnsign1(@search)+N'%'
END
GO

CREATE PROC USP_ReportFood
@checkin DATE, @checkout DATE
AS
BEGIN
	SELECT food_name, SUM(count) AS N'count' 
	FROM dbo.THONG_TIN_HOA_DON,dbo.MON_AN, dbo.HOA_DON 
	WHERE id_food=id_food_fk 
	AND id_bill=id_bill_fk 
	AND date_checkin>=@checkin
	AND date_checkout<=@checkout
	GROUP BY food_name 
	ORDER BY SUM(count) DESC
END
GO


CREATE PROC USP_InsertCategory
@name NVARCHAR(50) 
AS
BEGIN
	INSERT dbo.LOAI_MON
	(
	    foodcategory_name
	)
	VALUES
	( @name -- foodcategory_name - nvarchar(50)
	    )
END
GO

CREATE PROC USP_DeleteCategory
@id INT 
AS
BEGIN
	DELETE FROM dbo.LOAI_MON WHERE id_foodcategory=@id
END
GO

CREATE PROC USP_EditCategory
@id INT, @name NVARCHAR(50) 
AS
BEGIN
	UPDATE dbo.LOAI_MON SET foodcategory_name=@name WHERE id_foodcategory=@id
END
GO





CREATE PROC USP_InsertTable
@name NVARCHAR(50) 
AS
BEGIN
	INSERT dbo.BAN_AN
	(
	    name_table,
	    status_table
	)
	VALUES
	(   @name, -- name_table - nvarchar(50)
	    0    -- status_table - int
	    )
END
GO

CREATE PROC USP_DeleteTable
@id INT 
AS
BEGIN
	DELETE FROM dbo.BAN_AN WHERE id_table=@id
END
GO

CREATE PROC USP_EditTable
@id INT, @name NVARCHAR(50) 
AS
BEGIN
	UPDATE dbo.BAN_AN SET name_table=@name WHERE id_table=@id
END
GO

CREATE PROC USP_SearchTable
@search NVARCHAR(50)
AS
BEGIN
	SELECT id_table AS N'ID',name_table AS N'Tên bàn' 
	FROM dbo.BAN_AN
	WHERE dbo.fuConvertToUnsign1(name_table) LIKE N'%'+dbo.fuConvertToUnsign1(@search)+N'%'
END
GO

CREATE PROC USP_InsertAccount
@user NVARCHAR(50), @name NVARCHAR(50),
@type INT, @position NVARCHAR(50)
AS
BEGIN
	INSERT dbo.ACCOUNT
	(
	    user_name,
	    password,
	    display_name,
	    birthday,
	    address,
	    type,
	    position
	)
	VALUES
	(   @user,       -- user_name - nvarchar(50)
	    @user,       -- password - nvarchar(50)
	    @name,       -- display_name - nvarchar(50)
	    NULL, -- birthday - date
	    N'',       -- address - nvarchar(100)
	    @type,         -- type - int
	    @position        -- position - nvarchar(50)
	    )
END
GO

CREATE PROC USP_EditAccount
@user NVARCHAR(50), @type INT, @position NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.ACCOUNT SET type=@type, position=@position WHERE user_name=@user
END
GO
                          
                           
CREATE PROC USP_DeleteAccount
@user NVARCHAR(50)
AS
BEGIN
	DELETE FROM dbo.ACCOUNT WHERE user_name=@user
END
GO
                        
CREATE PROC USP_SearchAccount
@search NVARCHAR(50)
AS
BEGIN
	SELECT user_name AS N'Tài khoản', display_name AS N'Họ tên', CONVERT( NVARCHAR(10),birthday, 103) AS N'Ngày sinh', address AS N'Địa chỉ', CONVERT( NVARCHAR(2),type) AS N'Loại tài khoản', position AS N'Chức vụ' 
	FROM dbo.ACCOUNT
	WHERE dbo.fuConvertToUnsign1(display_name) LIKE N'%'+ dbo.fuConvertToUnsign1(@search)+N'%'
END
GO


