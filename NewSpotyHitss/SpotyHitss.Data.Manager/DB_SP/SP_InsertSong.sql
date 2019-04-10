use [Spotify]

IF OBJECT_ID (N'dbo.SP_InsertSong') IS NOT NULL  
    DROP PROCEDURE SP_InsertSong;  
GO  

CREATE PROCEDURE [dbo].[SP_InsertSong](
   @Name VARCHAR(50) = 'NA',
   @ReleaseYear INT = NULL,
   @ArtistName VARCHAR(100) = 'NA',
   @FileSong VARBINARY(MAX) = NULL
   )
AS
BEGIN
	IF @ReleaseYear IS NULL
		SET @ReleaseYear = 1900

	DECLARE @Status TINYINT = 0,
			@TextResult VARCHAR(150) = 'The operation can not be complete',
			@IntResult INT = 0,
			@IdArtist INT = (SELECT [ID] FROM [Artist] WHERE [Name] = @ArtistName);

	BEGIN TRY

		IF @IdArtist IS NOT NULL
		BEGIN
			INSERT INTO [Song](
							[Name],
							[ReleaseYear]
							)
			VALUES (@Name,
					@ReleaseYear
					)

			SET @IntResult = SCOPE_IDENTITY();

			INSERT INTO [SongArtist] (
							[ID_Song],
							[ID_Artist])
			VALUES(@IntResult, 
					@IdArtist)

			SET @Status = 1
			SET @TextResult = 'Register Added'

		END

	END TRY
	BEGIN CATCH
		SELECT @IntResult = ERROR_NUMBER(),
			   @TextResult = ERROR_MESSAGE(),
			   @Status = 2
	END CATCH
	
	SELECT @Status as SPStatust,
		   @TextResult as TextResult,
		   @IntResult as IntResul
END

GO