using System;

namespace ElKanzo.TonuinoCardFormatter
{
	public static class ResourceHelper
	{
		public static String GetText<T>(T value)
		{
			if (value is Version version)
				return GetText(version);
			if (value is Mode mode)
				return GetText(mode);

			return "?";
		}


		public static String GetText(Version version)
		{
			switch (version)
			{
				case Version.V1:
					return "V1";
				default:
					return "V?";
			}
		}


		public static String GetText(Mode mode)
		{
			switch (mode)
			{
				case Mode.None:
					return "---";
				case Mode.Radioplay:
					return "Hörspiel";
				case Mode.Album:
					return "Album";
				case Mode.Party:
					return "Party";
				case Mode.SingleTrack:
					return "EinzelTitel";
				case Mode.Audiobook:
					return "Hörbuch";
				case Mode.Admin:
					return "Admin";
				case Mode.RadioplayRandom:
					return "Hörspiel R";
				case Mode.SpezialVonBis:
					return "Spezial Von Bis";
				case Mode.PartyRandom:
					return "Party R";
				default:
					return "?";
			}
		}
	}
}
