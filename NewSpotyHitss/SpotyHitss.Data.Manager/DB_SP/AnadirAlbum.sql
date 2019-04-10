/**********************************************************************************
Date Creation(YY/MM/DD)   : 19 04 04
Author                    : Olmedo Garcia Oscar Renato
Description               : Store Procedure for DataBaseSpotify 
 ***********************************************************************************/

IF ( OBJECT_ID('dbo.sp_Insertar_Album') IS NOT NULL ) 
   DROP PROCEDURE dbo.sp_Insertar_Album
GO

CREATE PROCEDURE dbo.sp_Insertar_Album
       @Name                     VARCHAR(100)      , 
       @ReleaseYear              INT                                 
AS 
BEGIN 
     SET NOCOUNT ON 

     INSERT INTO [dbo].[Album]
          ( 
            Name                   ,
            ReleaseYear                
          ) 
     VALUES 
          ( 
		  @Name  ,
		  @ReleaseYear
          ) 

END 

GO
 --                              Name      Year
 --EXEC dbo.sp_Insertar_Album 'NameAlbum' '0000'