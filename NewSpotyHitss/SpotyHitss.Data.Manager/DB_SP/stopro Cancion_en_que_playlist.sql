USE [Spotify]
GO
/****** Object:  StoredProcedure [dbo].[Cancion_en_que_playlist]    Script Date: 4/9/2019 2:00:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Cancion_en_que_playlist]

@Song int
  
AS 

BEGIN

select Name from [dbo].[Playlist]
inner join [dbo].[PlaylistSong]
on Playlist.ID=PlaylistSong.ID_Playlist 
where ID_Song = @Song


END 