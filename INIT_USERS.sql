-- data source		qqqsales.mssql.somee.com
-- user				swagmav_SQLLogin_1
-- pwd				m1vbu3gz7c

CREATE TABLE Users(
		id INT IDENTITY NOT NULL,
		username VARCHAR(30) DEFAULT(''),
		code CHAR(6) NOT NULL,
		password NVARCHAR(30) NOT NULL,
		branch TINYINT NOT NULL DEFAULT(0),
		is_admin BIT NOT NULL DEFAULT(0),
		CONSTRAINT UN_Users_code UNIQUE(code),
		CONSTRAINT PK_Users_id PRIMARY KEY(id)
);