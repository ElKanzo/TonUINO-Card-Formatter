using System;
using System.Collections.Generic;
using System.Linq;
using ElKanzo.TonuinoCardFormatter.Properties;
using LiteDB;

namespace ElKanzo.TonuinoCardFormatter
{
	public static class Library
	{
		static Library()
		{
			var mapper = BsonMapper.Global;
			mapper.Entity<SdCard>().DbRef(x => x.Folders, "folders").Id(x => x.Id);
			mapper.Entity<Folder>().DbRef(x => x.Albums, "albums").DbRef(x => x.SdCard, "sdCards").Id(x => x.Id);
			mapper.Entity<Album>().DbRef(x => x.Tracks, "tracks").Id(x => x.Id);
			mapper.Entity<Track>().Id(x => x.Id);
		}


		public static void CreateTestData()
		{
			SdCard card = new SdCard { Name = "TestCard01", Directory = @"c:\temp\SD", Folders = new List<Folder>() };
			for (Byte x = 1; x <= 99; x++)
			{
				Folder folder = new Folder { Number = x, Albums = new List<Album>(), SdCard = card };
				card.Folders.Add(folder);
				for (Byte y = 1; y <= 10; y++)
				{
					Album album = new Album { Title = $"Album No. {y}", Image = new byte[] { 0x00, 0x01, 0x02 }, Tracks = new List<Track>(), CardId = $"{x:00}-{y:00}", Folder = folder };
					folder.Albums.Add(album);
					for (Byte z = 1; z <= 25; z++)
					{
						Track track = new Track { Title = $"Track No. {z:00}", TrackNo = z, Album = album };
						album.Tracks.Add(track);
					}
				}
			}


			using (LiteDatabase db = new LiteDatabase(Settings.Default.DB))
			{
				var sdCards = db.GetCollection<SdCard>("sdCards");
				var folders = db.GetCollection<Folder>("folders");
				var albums = db.GetCollection<Album>("albums");
				var tracks = db.GetCollection<Track>("tracks");

				foreach (Folder folder in card.Folders)
				{
					foreach (Album album in folder.Albums)
					{
						tracks.Insert(album.Tracks);
					}
					albums.Insert(folder.Albums);
				}
				folders.Insert(card.Folders);
				sdCards.Insert(card);
				folders.Update(card.Folders);
				albums.Update(card.Folders.SelectMany(t => t.Albums));
				tracks.Update(card.Folders.SelectMany(t => t.Albums).SelectMany(t => t.Tracks));
				albums.EnsureIndex(t => t.CardId);
			}
		}

		public static void ReadTest()
		{
			using (LiteDatabase db = new LiteDatabase(Settings.Default.DB))
			{
				var sdCards = db.GetCollection<SdCard>("sdCards");
				var folders = db.GetCollection<Folder>("folders");
				var albums = db.GetCollection<Album>("albums");
				var tracks = db.GetCollection<Track>("tracks");

				//foreach (SdCard sdCard in sdCards.FindAll())
				//{
				//	Console.WriteLine($"{sdCard.Name} {sdCard.Id}");

				//	foreach (Int32 folderId in sdCard.Folders.Select(t => t.Id))
				//	{
				//		Folder folder = folders.FindById(folderId);
				//		Console.WriteLine($"->{folder.Number} {folder.Id}");

				//		foreach (Int32 albumId in folder.Albums.Select(t => t.Id))
				//		{
				//			Album album = albums.FindById(albumId);
				//			Console.WriteLine($"->->{album.Title} {album.CardId} {album.Id}");

				//			foreach (Int32 trackId in album.Tracks.Select(t => t.Id))
				//			{
				//				Track track = tracks.FindById(trackId);
				//				Console.WriteLine($"->->->{track.Title} {track.TrackNo} {track.Id}");
				//			}
				//		}
				//	}
				//}



				Album single = albums.Include(t => t.Folder).Include(t => t.Tracks).FindOne(t => t.CardId == "17-09");
				if (single != null)
				{
					Folder test = folders.FindAll().FirstOrDefault(t => t.Albums.Any(x => x.Id == single.Id));
					Console.WriteLine(test.ToString());
				}
			}
		}
	}
	public class SdCard
	{
		public Int32 Id { get; set; }
		public String Name { get; set; }
		public String Directory { get; set; }
		public List<Folder> Folders { get; set; }
	}

	public class Folder
	{
		public Int32 Id { get; set; }
		public Byte Number { get; set; }
		public List<Album> Albums { get; set; }
		public SdCard SdCard { get; set; }
	}

	public class Album
	{
		public Int32 Id { get; set; }
		public String CardId { get; set; }
		public String Title { get; set; }
		public Byte[] Image { get; set; }
		public List<Track> Tracks { get; set; }
		public Folder Folder { get; set; }
	}

	public class Track
	{
		public Int32 Id { get; set; }
		public String Title { get; set; }
		public Int16 TrackNo { get; set; }
		public Album Album { get; set; }
	}
}
