USE [Spotify]
GO

/****** Object:  StoredProcedure [dbo].[SP_List_Gen]    Script Date: 4/4/2019 4:26:07 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		Jorge Carrazco
-- Create date: 04/04/2019
-- Description:	SP_List_Gen
-- =============================================
CREATE PROCEDURE [dbo].[SP_List_Gen]
	@Gen_to_List varchar(50)
AS
BEGIN

	SET NOCOUNT ON;
	
	--Codigo a procesar
	SELECT Song.ID, Song.Name, ReleaseYear, Genre.Name FROM Song
	INNER JOIN SongGenre
	ON Song.ID = SongGenre.ID_Song
	INNER JOIN Genre
	ON SongGenre.ID_Genre = Genre.ID
	WHERE Genre.Name =  @Gen_to_List
	ORDER BY ReleaseYear DESC

END

GO

