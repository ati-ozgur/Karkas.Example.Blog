DECLARE @UsersTypeNo int = 4
DECLARE @TypeName varchar(100) = 'Deneme'

INSERT INTO [LT_COMMON].[USERS_TYPE]
           ([UsersTypeNo]
           ,[TypeName])
     VALUES
           (@UsersTypeNo
           ,@TypeName)