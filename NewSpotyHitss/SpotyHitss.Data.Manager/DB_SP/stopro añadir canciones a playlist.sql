USE [Spotify]
GO
/****** Object:  StoredProcedure [dbo].[Añadir_reproducciones]    Script Date: 4/5/2019 11:49:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Añadir_canciones_a_playlist]
  
AS 
Declare @Playlist int
Declare @Song int
DECLARE @COUNT INT

SET @COUNT=0
WHILE (@COUNT<20)
BEGIN
SET @Playlist =FLOOR(RAND()*(5-1)+1);
SET @Song =FLOOR(RAND()*(21-1)+1);
SET @COUNT=@COUNT+1;
insert into[dbo].[PlaylistSong]  (ID_Playlist, ID_Song)
values (@Playlist, @Song)
END 