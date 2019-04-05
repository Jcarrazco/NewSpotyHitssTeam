IF OBJECT_ID (N'dbo.SP_InsertSong', N'FN') IS NOT NULL  
    DROP FUNCTION SP_InsertSong;  
GO  

CREATE PROCEDURE [dbo].[SP_InsertSong](
   @Name VARCHAR(50) = 'NA',
   @ReleaseYear DATE = NULL,
   @ArtistName VARCHAR(100) = 'NA'
   )
AS
BEGIN
	IF @ReleaseYear IS NULL
		SET @ReleaseYear = GETDATE()

	DECLARE @Status INT = 0,
			@TextResult VARCHAR(150) = 'The operation can not be complete',
			@IntResult INT = 0,
			@IdArtist INT = (SELECT [ID] FROM [Artist] WHERE [Name] = @ArtistName);

	BEGIN TRY

		IF @IdArtist IS NOT NULL
		BEGIN
			INSERT INTO [Song](
							[Name],
							[ReleaseYear])
			VALUES (@Name,
					@ReleaseYear)

			SET @IntResult = SCOPE_IDENTITY();

			INSERT INTO [SongArtist] (
							[Song_ID],
							[Artist_ID])
			VALUES(@IntResult, 
					@IdArtist)

			SET @Status = 1
			SET @TextResult = 'Register inserter'

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