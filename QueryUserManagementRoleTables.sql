
USE [aspnet-CoreAuthentication-BE4FE1DC-1288-4515-9E4A-1B6F524F8DF7]
GO

/****** Script for SelectTopNRows command from SSMS  ******/
/*
delete FROM [dbo].[AspNetUsers]
delete FROM [dbo].[AspNetRoles]
delete FROM [dbo].[AspNetUserRoles]
delete FROM FROM [dbo].[AspNetUserLogins]
*/

SELECT * FROM [dbo].[AspNetUsers]
SELECT * FROM [dbo].[AspNetRoles]
SELECT * FROM [dbo].[AspNetUserRoles]
SELECT * FROM [dbo].[AspNetUserLogins]


SELECT * FROM [dbo].[AspNetUserTokens]
SELECT * FROM [dbo].[AspNetUserClaims]
SELECT * FROM [dbo].[AspNetRoleClaims]

/*
INSERT INTO [dbo].[AspNetUserClaims]
           ([UserId],[ClaimType],[ClaimValue]) VALUES ('135df95a-432d-4e28-81ad-c3e30878de18' ,'dob','29-July-1974');

		   
INSERT INTO [dbo].[AspNetRoleClaims] 
			([RoleId],[ClaimType],[ClaimValue]) VALUES 
			('bcf533c4-c28c-43cf-ac71-718df6c3fd40','Home','About'),
			('bcf533c4-c28c-43cf-ac71-718df6c3fd40','Home','Contact'),
			('bcf533c4-c28c-43cf-ac71-718df6c3fd40','Home','Index')
GO
*/






