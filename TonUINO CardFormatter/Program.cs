using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ElKanzo.TonuinoCardFormatter.Properties;
using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;

namespace ElKanzo.TonuinoCardFormatter
{
	static class Program
	{
		// Class variables
		private static readonly ILog m_logger = LogManager.GetLogger(typeof(Program));


		/// <summary>Program entry point.</summary>
		[STAThread]
		static void Main()
		{
			try
			{
				// Start logging
				InitEventLog();

				m_logger.Info("========== Program started ==========");
				m_logger.InfoFormat("{0} {1}", Application.ProductName, Application.ProductVersion);

				// Check settings and set default values.
				if (Settings.Default.UpgradeRequired)
				{
					Settings.Default.Upgrade();
					Settings.Default.UpgradeRequired = false;
					Settings.Default.Save();
				}
				if (String.IsNullOrEmpty(Settings.Default.DB))
				{
					Settings.Default.DB = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TonuinoCardFormatter", "Library.db");
					Settings.Default.Save();
				}
				if (String.IsNullOrEmpty(Settings.Default.LogFilePath))
				{
					Settings.Default.LogFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TonuinoCardFormatter", "Log.txt");
					Settings.Default.Save();
				}
				if (String.IsNullOrEmpty(Settings.Default.LogLevel))
				{
					Settings.Default.LogLevel = "INFO";
					Settings.Default.Save();
				}

				// Start GUI
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new MainForm());
			}
			catch (Exception ex)
			{
				m_logger.Error("Unhandled exception in program!", ex);
			}
			finally
			{
				m_logger.Info("Program closed.");
			}
		}


		// Private helperfunctions

		/// <summary>Init log4net.</summary>
		private static void InitEventLog()
		{
			try
			{
				Level eventLogThreshold = GetEventLogThreshold();

				// Log to file
				RollingFileAppender rollingFileAppender = new RollingFileAppender
				{
					Name = "ElKanzo.TonuinoCardFormatter",
					Layout = new PatternLayout("%utcdate{yyyy-MM-dd HH:mm:ss};%t;%p;%c;%m%n"),
					File = Settings.Default.LogFilePath,
					AppendToFile = true,
					Threshold = eventLogThreshold,
					RollingStyle = RollingFileAppender.RollingMode.Size,
					MaxFileSize = 10 * 1024 * 1024,  // 20 MB.
					MaxSizeRollBackups = 10  // 10 files.
				};
				rollingFileAppender.ActivateOptions();
				BasicConfigurator.Configure(rollingFileAppender);

#if DEBUG
				// Log to debug window
				DebugAppender debugAppender = new DebugAppender
				{
					Name = "ElKanzo.TonuinoCardFormatter",
					Layout = new PatternLayout("%utcdate{HH:mm:ss};%m%n"),
					Threshold = eventLogThreshold,
					ImmediateFlush = true
				};
				debugAppender.ActivateOptions();
				BasicConfigurator.Configure(debugAppender);
#endif
			}
			catch (Exception ex)
			{
				m_logger.Error("Problem during log4net setup!", ex);
			}
		}

		/// <summary>Gets the LogLevel from the according program setting.</summary>
		/// <returns></returns>
		public static Level GetEventLogThreshold()
		{
			var loggerRepository = LoggerManager.GetAllRepositories().FirstOrDefault();
			Level level = loggerRepository?.LevelMap[Settings.Default.LogLevel];

			if (level == null)
				level = Level.Info;

			return level;
		}
	}
}
