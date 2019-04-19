USE [Spotify]
GO
/****** Object:  StoredProcedure [dbo].[Añadir_reproducciones]    Script Date: 4/5/2019 11:49:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Cancion_mas_sonada]
  
AS 

BEGIN

select top 1 ID_Song, count(ID_Song) as Cancion from PlaylistSong
group by ID_Song
order by Cancion desc

END 


