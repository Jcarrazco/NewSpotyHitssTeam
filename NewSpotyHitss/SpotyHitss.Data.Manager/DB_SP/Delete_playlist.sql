USE [Spotify]
GO

/****** Object:  StoredProcedure [dbo].[borrar_playlist]    Script Date: 4/19/2019 10:55:22 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[borrar_playlist] @playlist int
as
	delete from Playlist where ID = @playlist 
 

GO

