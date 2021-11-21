USE Northwind
--USER TABLE
CREATE TABLE "Users" (
"UserId" int IDENTITY (1, 1) NOT NULL ,
"Username" varchar(50) NOT NULL,
"_Password" varchar(50) NOT NULL,
CONSTRAINT "PK_Users" PRIMARY KEY  CLUSTERED 
	(
		"UserId"
	),
	)
--DATA
INSERT INTO Users ("Username","_Password") VALUES ('admin',12345)