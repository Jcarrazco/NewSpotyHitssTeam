USE [Spotify]
GO

/****** Object:  StoredProcedure [dbo].[SP_Compartir_Playlist]    Script Date: 4/19/2019 11:38:46 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_Compartir_Playlist]
	@User_ID int, @Playlist_ID int
AS
BEGIN

	SET NOCOUNT ON;
	IF EXISTS (SELECT * FROM UserPlaylist where ID_User = @User_ID  and ID_Playlist = @Playlist_ID)
	BEGIN
	PRINT 'Ese Usuario Ya tiene la Playlist';
	END 

	ELSE
	insert into UserPlaylist(ID_User,ID_Playlist) values (@User_ID,@Playlist_ID)
	

END
GO

