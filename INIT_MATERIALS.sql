CREATE TABLE Materials
(
	product NVARCHAR(50) NOT NULL,
	material_name NVARCHAR(30) NOT NULL
	CONSTRAINT U_Materials_product UNIQUE(product)
);