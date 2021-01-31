using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using NfoSharp;

namespace NfoSharp.NfoDtos
{
	[XmlRoot(ElementName="movie")]
	public class Movie {
		[XmlElement(ElementName="title")]
		public string Title { get; set; }
		[XmlElement(ElementName="originaltitle")]
		public string Originaltitle { get; set; }
		[XmlElement(ElementName="sorttitle")]
		public string Sorttitle { get; set; }
		[XmlArray(ElementName="ratings")]
		[XmlArrayItem(ElementName="rating")]
		public List<Rating> Ratings { get; set; }
		[XmlElement(ElementName="userrating")]
		public string Userrating { get; set; }
		[XmlElement(ElementName="top250")]
		public string Top250 { get; set; }
		[XmlElement(ElementName="outline")]
		public string Outline { get; set; }
		[XmlElement(ElementName="plot")]
		public string Plot { get; set; }
		[XmlElement(ElementName="tagline")]
		public string Tagline { get; set; }
		[XmlElement(ElementName="runtime")]
		public string Runtime { get; set; }
		[XmlElement(ElementName="thumb")]
		public List<Thumb> Thumb { get; set; }
		[XmlArray(ElementName="fanart")]
		[XmlArrayItem(ElementName="thumb")]
		public List<Thumb> Fanart { get; set; }
		[XmlElement(ElementName="mpaa")]
		public string Mpaa { get; set; }
		[XmlElement(ElementName="playcount")]
		public string Playcount { get; set; }
		[XmlElement(ElementName="lastplayed")]
		public string Lastplayed { get; set; }
		[XmlElement(ElementName="id")]
		public string Id { get; set; }
		[XmlElement(ElementName="uniqueid")]
		public List<Uniqueid> Uniqueid { get; set; }
		[XmlElement(ElementName="genre")]
		public List<string> Genre { get; set; }
		[XmlElement(ElementName="country")]
		public List<string> Country { get; set; }
		[XmlElement(ElementName="set")]
		public Set Set { get; set; }
		[XmlElement(ElementName="tag")]
		public List<string> Tag { get; set; }
		[XmlElement(ElementName="credits")]
		public List<string> Credits { get; set; }
		[XmlElement(ElementName="director")]
		public List<string> Director { get; set; }
		[XmlElement(ElementName="premiered")]
		public string Premiered { get; set; }
		[XmlElement(ElementName="year")]
		public string Year { get; set; }
		[XmlElement(ElementName="status")]
		public string Status { get; set; }
		[XmlElement(ElementName="code")]
		public string Code { get; set; }
		[XmlElement(ElementName="aired")]
		public string Aired { get; set; }
		[XmlElement(ElementName="studio")]
		public List<string> Studio { get; set; }
		[XmlElement(ElementName="trailer")]
		public string Trailer { get; set; }
		[XmlElement(ElementName="fileinfo")]
		public List<Fileinfo> Fileinfo { get; set; }
		[XmlElement(ElementName="actor")]
		public List<Actor> Actor { get; set; }
		[XmlElement(ElementName="showlink")]
		public string Showlink { get; set; }
		[XmlElement(ElementName="resume")]
		public Resume Resume { get; set; }
		[XmlElement(ElementName="dateadded")]
		public string Dateadded { get; set; }
	}

	[XmlRoot(ElementName="tvshow")]
	public class Tvshow {
		[XmlElement(ElementName="title")]
		public string Title { get; set; }
		[XmlElement(ElementName="originaltitle")]
		public string Originaltitle { get; set; }
		[XmlElement(ElementName="showtitle")]
		public string Showtitle { get; set; }
		[XmlElement(ElementName="sorttitle")]
		public string Sorttitle { get; set; }
		[XmlArray(ElementName="ratings")]
		[XmlArrayItem(ElementName="rating")]
		public List<Rating> Ratings { get; set; }
		[XmlElement(ElementName="userrating")]
		public string Userrating { get; set; }
		[XmlElement(ElementName="top250")]
		public string Top250 { get; set; }
		[XmlElement(ElementName="season")]
                public string Season { get; set; }
		[XmlElement(ElementName="episode")]
		public string Episode { get; set; }
		[XmlElement(ElementName="displayepisode")]
		public string Displayepisode { get; set; }
		[XmlElement(ElementName="displayseason")]
		public string Displayseason { get; set; }
		[XmlElement(ElementName="namedseason")]
		public List<Namedseason> Namedseason { get; set; }
		[XmlElement(ElementName="outline")]
		public string Outline { get; set; }
		[XmlElement(ElementName="plot")]
		public string Plot { get; set; }
		[XmlElement(ElementName="tagline")]
		public string Tagline { get; set; }
		[XmlElement(ElementName="runtime")]
		public string Runtime { get; set; }
		[XmlElement(ElementName="thumb")]
		public List<Thumb> Thumb { get; set; }
		[XmlArray(ElementName="fanart")]
		[XmlArrayItem(ElementName="thumb")]
		public List<Thumb> Fanart { get; set; }
		[XmlElement(ElementName="mpaa")]
		public string Mpaa { get; set; }
		[XmlElement(ElementName="playcount")]
		public string Playcount { get; set; }
		[XmlElement(ElementName="lastplayed")]
		public string Lastplayed { get; set; }
		[XmlElement(ElementName="episodeguide")]
		public Episodeguide Episodeguide { get; set; }
		[XmlElement(ElementName="id")]
		public string Id { get; set; }
		[XmlElement(ElementName="uniqueid")]
		public List<Uniqueid> Uniqueid { get; set; }
		[XmlElement(ElementName="genre")]
		public List<string> Genre { get; set; }
		[XmlElement(ElementName="tag")]
		public List<string> Tag { get; set; }
		[XmlElement(ElementName="premiered")]
		public string Premiered { get; set; }
		[XmlElement(ElementName="year")]
		public string Year { get; set; }
		[XmlElement(ElementName="status")]
		public string Status { get; set; }
		[XmlElement(ElementName="code")]
		public string Code { get; set; }
		[XmlElement(ElementName="aired")]
		public string Aired { get; set; }
		[XmlElement(ElementName="studio")]
		public List<string> Studio { get; set; }
		[XmlElement(ElementName="trailer")]
		public string Trailer { get; set; }
		[XmlElement(ElementName="actor")]
		public List<Actor> Actor { get; set; }
		[XmlElement(ElementName="resume")]
		public Resume Resume { get; set; }
		[XmlElement(ElementName="dateadded")]
		public string Dateadded { get; set; }
	}

	[XmlRoot(ElementName="episodedetails")]
	public class Episodedetails {
		[XmlElement(ElementName="title")]
		public string Title { get; set; }
		[XmlElement(ElementName="originaltitle")]
		public string Originaltitle { get; set; }
		[XmlElement(ElementName="showtitle")]
		public string Showtitle { get; set; }
		[XmlArray(ElementName="ratings")]
		[XmlArrayItem(ElementName="rating")]
		public List<Rating> Ratings { get; set; }
		[XmlElement(ElementName="userrating")]
		public string Userrating { get; set; }
		[XmlElement(ElementName="top250")]
		public string Top250 { get; set; }
		[XmlElement(ElementName="season")]
		public string Season { get; set; }
		[XmlElement(ElementName="episode")]
		public string Episode { get; set; }
		[XmlElement(ElementName="displayepisode")]
		public string Displayepisode { get; set; }
		[XmlElement(ElementName="displayseason")]
		public string Displayseason { get; set; }
		[XmlElement(ElementName="outline")]
		public string Outline { get; set; }
		[XmlElement(ElementName="plot")]
		public string Plot { get; set; }
		[XmlElement(ElementName="tagline")]
		public string Tagline { get; set; }
		[XmlElement(ElementName="runtime")]
		public string Runtime { get; set; }
		[XmlElement(ElementName="thumb")]
		public List<string> Thumb { get; set; }
		[XmlElement(ElementName="mpaa")]
		public string Mpaa { get; set; }
		[XmlElement(ElementName="playcount")]
		public string Playcount { get; set; }
		[XmlElement(ElementName="lastplayed")]
		public string Lastplayed { get; set; }
		[XmlElement(ElementName="id")]
		public string Id { get; set; }
		[XmlElement(ElementName="uniqueid")]
		public List<Uniqueid> Uniqueid { get; set; }
		[XmlElement(ElementName="genre")]
		public List<string> Genre { get; set; }
		[XmlElement(ElementName="credits")]
		public List<string> Credits { get; set; }
		[XmlElement(ElementName="director")]
		public List<string> Director { get; set; }
		[XmlElement(ElementName="premiered")]
		public string Premiered { get; set; }
		[XmlElement(ElementName="year")]
		public string Year { get; set; }
		[XmlElement(ElementName="status")]
		public string Status { get; set; }
		[XmlElement(ElementName="code")]
		public string Code { get; set; }
		[XmlElement(ElementName="aired")]
		public string Aired { get; set; }
		[XmlElement(ElementName="studio")]
		public List<string> Studio { get; set; }
		[XmlElement(ElementName="trailer")]
		public string Trailer { get; set; }
		[XmlElement(ElementName="episodebookmark")]
		public Episodebookmark Episodebookmark { get; set; }
		[XmlElement(ElementName="fileinfo")]
		public List<Fileinfo> Fileinfo { get; set; }
		[XmlElement(ElementName="actor")]
		public List<Actor> Actor { get; set; }
		[XmlElement(ElementName="resume")]
		public Resume Resume { get; set; }
		[XmlElement(ElementName="dateadded")]
		public string Dateadded { get; set; }
	}

	[XmlRoot(ElementName="musicvideo")]
	public class Musicvideo {
		[XmlElement(ElementName="title")]
		public string Title { get; set; }
		[XmlElement(ElementName="userrating")]
		public string Userrating { get; set; }
		[XmlElement(ElementName="top250")]
		public string Top250 { get; set; }
		[XmlElement(ElementName="track")]
		public string Track { get; set; }
		[XmlElement(ElementName="album")]
		public string Album { get; set; }
		[XmlElement(ElementName="outline")]
		public string Outline { get; set; }
		[XmlElement(ElementName="plot")]
		public string Plot { get; set; }
		[XmlElement(ElementName="tagline")]
		public string Tagline { get; set; }
		[XmlElement(ElementName="runtime")]
		public string Runtime { get; set; }
		[XmlElement(ElementName="thumb")]
		public List<Thumb> Thumb { get; set; }
		[XmlElement(ElementName="mpaa")]
		public string Mpaa { get; set; }
		[XmlElement(ElementName="playcount")]
		public string Playcount { get; set; }
		[XmlElement(ElementName="id")]
		public string Id { get; set; }
		[XmlElement(ElementName="genre")]
		public List<string> Genre { get; set; }
		[XmlElement(ElementName="tag")]
		public List<string> Tag { get; set; }
		[XmlElement(ElementName="director")]
		public List<string> Director { get; set; }
		[XmlElement(ElementName="year")]
		public string Year { get; set; }
		[XmlElement(ElementName="status")]
		public string Status { get; set; }
		[XmlElement(ElementName="code")]
		public string Code { get; set; }
		[XmlElement(ElementName="aired")]
		public string Aired { get; set; }
		[XmlElement(ElementName="studio")]
		public List<string> Studio { get; set; }
		[XmlElement(ElementName="trailer")]
		public string Trailer { get; set; }
		[XmlElement(ElementName="fileinfo")]
		public Fileinfo Fileinfo { get; set; }
		[XmlElement(ElementName="artist")]
		public List<string> Artist { get; set; }
		[XmlElement(ElementName="resume")]
		public Resume Resume { get; set; }
		[XmlElement(ElementName="dateadded")]
		public string Dateadded { get; set; }
	}

	[XmlRoot(ElementName="artist")]
	public class Artist {
		[XmlElement(ElementName="name")]
		public string Name { get; set; }
		[XmlElement(ElementName="musicBrainzArtistID")]
		public string MusicBrainzArtistID { get; set; }
		[XmlElement(ElementName="sortname")]
		public string Sortname { get; set; }
		[XmlElement(ElementName="type")]
		public string Type { get; set; }
		[XmlElement(ElementName="gender")]
		public string Gender { get; set; }
		[XmlElement(ElementName="disambiguation")]
		public string Disambiguation { get; set; }
		[XmlElement(ElementName="genre")]
		public List<string> Genre { get; set; }
		[XmlElement(ElementName="style")]
		public List<string> Style { get; set; }
		[XmlElement(ElementName="mood")]
		public List<string> Mood { get; set; }
		[XmlElement(ElementName="yearsactive")]
		public List<string> Yearsactive { get; set; }
		[XmlElement(ElementName="instruments")]
		public List<string> Instruments { get; set; }
		[XmlElement(ElementName="born")]
		public string Born { get; set; }
		[XmlElement(ElementName="formed")]
		public string Formed { get; set; }
		[XmlElement(ElementName="biography")]
		public string Biography { get; set; }
		[XmlElement(ElementName="died")]
		public string Died { get; set; }
		[XmlElement(ElementName="disbanded")]
		public string Disbanded { get; set; }
		[XmlElement(ElementName="thumb")]
		public List<Thumb> Thumb { get; set; }
		[XmlElement(ElementName="path")]
		public string Path { get; set; }
		[XmlArray(ElementName="fanart")]
		[XmlArrayItem(ElementName="thumb")]
		public List<Thumb> Fanart { get; set; }
		[XmlElement(ElementName="album")]
		public List<Album> Album { get; set; }
	}

	[XmlRoot(ElementName="album")]
	public class Album {
		[XmlElement(ElementName="title")]
		public string Title { get; set; }
		[XmlElement(ElementName="year")]
		public string Year { get; set; }
		[XmlElement(ElementName="musicBrainzAlbumID")]
		public string MusicBrainzAlbumID { get; set; }
		[XmlElement(ElementName="musicbrainzreleasegroupid")]
		public string Musicbrainzreleasegroupid { get; set; }
		[XmlElement(ElementName="scrapedmbid")]
		public string Scrapedmbid { get; set; }
		[XmlElement(ElementName="artistdesc")]
		public string Artistdesc { get; set; }
		[XmlElement(ElementName="genre")]
		public List<string> Genre { get; set; }
		[XmlElement(ElementName="style")]
		public List<string> Style { get; set; }
		[XmlElement(ElementName="mood")]
		public List<string> Mood { get; set; }
		[XmlElement(ElementName="theme")]
		public List<string> Theme { get; set; }
		[XmlElement(ElementName="compilation")]
		public string Compilation { get; set; }
		[XmlElement(ElementName="review")]
		public string Review { get; set; }
		[XmlElement(ElementName="type")]
		public string Type { get; set; }
		[XmlElement(ElementName="releasedate")]
		public string Releasedate { get; set; }
		[XmlElement(ElementName="label")]
		public string Label { get; set; }
		[XmlElement(ElementName="thumb")]
		public List<Thumb> Thumb { get; set; }
		[XmlElement(ElementName="path")]
		public string Path { get; set; }
		[XmlElement(ElementName="rating")]
		public Rating Rating { get; set; }
		[XmlElement(ElementName="userrating")]
		public Userrating Userrating { get; set; }
		[XmlElement(ElementName="votes")]
		public string Votes { get; set; }
		[XmlElement(ElementName="albumArtistCredits")]
		public List<AlbumArtistCredits> AlbumArtistCredits { get; set; }
		[XmlElement(ElementName="releasetype")]
		public string Releasetype { get; set; }
	}

	[XmlRoot(ElementName="rating")]
	public class Rating {
		[XmlElement(ElementName="value")]
		public string Value { get; set; }
		[XmlElement(ElementName="votes")]
		public string Votes { get; set; }
		[XmlAttribute(AttributeName="name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName="max")]
		public string Max { get; set; }
		[XmlAttribute(AttributeName="default")]
		public bool Default { get; set; }
	}

	[XmlRoot(ElementName="thumb")]
	public class Thumb {
		[XmlAttribute(AttributeName="aspect")]
		public string Aspect { get; set; }
		[XmlAttribute(AttributeName="preview")]
		public string Preview { get; set; }
		[XmlAttribute(AttributeName="type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName="season")]
		public string Season { get; set; }
                [XmlText]
                public string ThumbLocation { get; set; }
	}

	[XmlRoot(ElementName="uniqueid")]
	public class Uniqueid {
		[XmlAttribute(AttributeName="type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName="default")]
		public bool Default { get; set; }
                [XmlText]
                public string Id {get; set; }

                public Uniqueid Generate(string type = null)=> 
                    new Uniqueid(){
                        Id = Guid.NewGuid().ToString,
                        Type = type ?? NfoSharp.UniqueidType;
                        Default = true 
                    };
                
	}

	[XmlRoot(ElementName="set")]
	public class Set {
		[XmlElement(ElementName="name")]
		public string Name { get; set; }
		[XmlElement(ElementName="overview")]
		public string Overview { get; set; }
	}

	[XmlRoot(ElementName="video")]
	public class Video {
		[XmlElement(ElementName="codec")]
		public string Codec { get; set; }
		[XmlElement(ElementName="aspect")]
		public string Aspect { get; set; }
		[XmlElement(ElementName="width")]
		public string Width { get; set; }
		[XmlElement(ElementName="height")]
		public string Height { get; set; }
		[XmlElement(ElementName="durationinseconds")]
		public string Durationinseconds { get; set; }
		[XmlElement(ElementName="stereomode")]
		public string Stereomode { get; set; }
	}

	[XmlRoot(ElementName="audio")]
	public class Audio {
		[XmlElement(ElementName="codec")]
		public string Codec { get; set; }
		[XmlElement(ElementName="language")]
		public string Language { get; set; }
		[XmlElement(ElementName="channels")]
		public string Channels { get; set; }
	}

	[XmlRoot(ElementName="subtitle")]
	public class Subtitle {
		[XmlElement(ElementName="language")]
		public string Language { get; set; }
	}

	[XmlRoot(ElementName="streamdetails")]
	public class Streamdetails {
		[XmlElement(ElementName="video")]
		public Video Video { get; set; }
		[XmlElement(ElementName="audio")]
		public List<Audio> Audio { get; set; }
		[XmlElement(ElementName="subtitle")]
		public List<Subtitle> Subtitle { get; set; }
	}

	[XmlRoot(ElementName="fileinfo")]
	public class Fileinfo {
		[XmlElement(ElementName="streamdetails")]
		public Streamdetails Streamdetails { get; set; }
	}

	[XmlRoot(ElementName="actor")]
	public class Actor {
		[XmlElement(ElementName="name")]
		public string Name { get; set; }
		[XmlElement(ElementName="role")]
		public string Role { get; set; }
		[XmlElement(ElementName="order")]
		public string Order { get; set; }
		[XmlElement(ElementName="thumb")]
		public string Thumb { get; set; }
	}

	[XmlRoot(ElementName="resume")]
	public class Resume {
		[XmlElement(ElementName="position")]
		public string Position { get; set; }
		[XmlElement(ElementName="total")]
		public string Total { get; set; }
	}

	[XmlRoot(ElementName="namedseason")]
	public class Namedseason {
		[XmlAttribute(AttributeName="number")]
		public string Number { get; set; }
                [XmlText]
                public string Name { get; set; }
	}

	[XmlRoot(ElementName="url")]
	public class Url {
		[XmlAttribute(AttributeName="cache")]
		public string Cache { get; set; }
                [XmlText]
                public string Address { get; set; }
	}

	[XmlRoot(ElementName="episodeguide")]
	public class Episodeguide {
		[XmlElement(ElementName="url")]
		public Url Url { get; set; }
	}

	[XmlRoot(ElementName="episodebookmark")]
	public class Episodebookmark {
		[XmlElement(ElementName="position")]
		public string Position { get; set; }
	}

	[XmlRoot(ElementName="userrating")]
	public class Userrating {
		[XmlAttribute(AttributeName="max")]
		public string Max { get; set; }
                [XmlText]
                public string Rating { get; set; }
	}

	[XmlRoot(ElementName="albumArtistCredits")]
	public class AlbumArtistCredits {
		[XmlElement(ElementName="artist")]
		public string Artist { get; set; }
		[XmlElement(ElementName="musicBrainzArtistID")]
		public string MusicBrainzArtistID { get; set; }
	}

}
