use [Spotify]


--****************************************************
-- Autor: Luis Xavier Pérez Torres
-- Create Date : 04/04/2019
-- Description: SP_Select_Songs_By_Artist
-- Change: 05\04\2019 - added search by artist
--****************************************************

if OBJECT_ID('SP_Select_By_Artist') IS NULL
	EXEC('CREATE PROCEDURE SP_Select_By_Artist AS SET NOCOUNT ON;') -- DUMMY SP
	GO

ALTER PROCEDURE SP_Select_By_Artist 
				@Artist_2List varchar(100)
AS
BEGIN

	SET NOCOUNT ON;
	declare @ArtistID as int

	set @ArtistID = (
		select top 1 Artist.ID from Artist
		where Artist.Name = @Artist_2List

	)

	select Artist. ID, Artist.Name as 'Artista', Song.ID, Song.Name as 'Cancion' 
	from Artist
	inner join SongArtist
		on SongArtist.ID_Artist = Artist.ID 
	inner join Song
		on SongArtist.ID_Song = Song.ID
		where SongArtist.ID_Artist = @ArtistID
	order by Artista

END
GO

-- exec SP_Select_By_Artist @Artist_2List = 'Coldplay'
-- select Artist.ID, Artist.Name from Artist where Artist.Name = 'Coldplay'
