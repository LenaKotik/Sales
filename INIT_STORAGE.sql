﻿CREATE TABLE Storage
(
	branch TINYINT NOT NULL,
	material_name NVARCHAR(30) NOT NULL,
	amount SMALLINT NOT NULL DEFAULT(0)
);