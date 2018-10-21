using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LiveTubeReport {

	[XmlRoot("option")]
	public class Option {
		[XmlElement("general")]
		public General General { get; set; }
		[XmlElement("notice")]
		public Notice Notice { get; set; }

		public Option() {
			General = new General();
			Notice = new Notice();
		}
	}

	public class General {
		[XmlElement("api_key")]
		public string ApiKey { get; set; }
		[XmlElement("channel_max_count")]
		public int ChannelMaxCount { get; set; }
		[XmlElement("check_interval_min")]
		public int CheckInterval { get; set; }

		public General() {
			ApiKey = "";
		}
	}

	public class Notice {
		[XmlElement("sound")]
		public SoundNotice Sound { get; set; }
		[XmlElement("web")]
		public WebNotice Web { get; set; }
		[XmlElement("balloon")]
		public BalloonNotice Balloon { get; set; }
		[XmlElement("popup")]
		public PopupNotice PopUp { get; set; }
		[XmlElement("app")]
		public AppNotice App { get; set; }

		public Notice() {
			PopUp = new PopupNotice();
			Balloon = new BalloonNotice();
			Sound = new SoundNotice();
			Web = new WebNotice();
			App = new AppNotice();
		}
	}

	public class AppNotice {
		[XmlElement("enable")]
		public bool Enable { get; set; }
		[XmlElement("item")]
		public BindingList<AppItem> AppItems { get; set; }

		public AppNotice() {
			AppItems = new BindingList<AppItem>();
		}

		public class AppItem {
			[XmlElement("enable")]
			public bool Enable { get; set; }
			[XmlElement("name")]
			public String Name { get; set; }
			[XmlElement("file_path")]
			public String FilePath { get; set; }
			[XmlElement("arg")]
			public String Argument { get; set; }

			public AppItem() {
				Name = "";
				FilePath = "";
				Argument = "";
			}
		}
	}

	public class WebNotice {
		[XmlElement("enable")]
		public bool Enable { get; set; }
		[XmlElement("default_browser")]
		public bool DefaultBrowser { get; set; }
		[XmlElement("file_path")]
		public String FilePath { get; set; }
		[XmlElement("arg")]
		public String Argument { get; set; }

		public WebNotice() {
			DefaultBrowser = true;
			FilePath = "";
			Argument = "";
		}
	}

	public class BalloonNotice {
		[XmlElement("enable")]
		public bool Enable { get; set; }
		[XmlElement("show_sec")]
		public double ShowSec { get; set; }
	}

	public class PopupNotice {
		[XmlElement("enable")]
		public bool Enable { get; set; }
		[XmlElement("position")]
		public int Position { get; set; }
		[XmlElement("width")]
		public int Width { get; set; }
		[XmlElement("show_sec")]
		public double ShowSec { get; set; }
	}

	public class SoundNotice : INotifyPropertyChanged{
		public event PropertyChangedEventHandler PropertyChanged;
		private void RaisePropertyChanged([CallerMemberName]string propertyName = null)
			=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

		[XmlElement("default_sound")]
		public bool DefaultSound { get; set; }
		[XmlElement("default_sound_alias")]
		public String DefaultSoundAlias { get; set; }
		private string filePath;
		[XmlElement("file_path")]
		public String FilePath {
			get => filePath;
			set {
				if (value == filePath) return;

				filePath = value;
				RaisePropertyChanged();
			}
		}

		public SoundNotice() {
			DefaultSound = true;
			DefaultSoundAlias = "";
			FilePath = "";
		}

		public void Play() {
			if (DefaultSound) {
				var prop = typeof(SystemSounds).GetProperty(DefaultSoundAlias);
				var sound = (SystemSound)prop.GetValue(null);
				sound.Play();
			}
			else {
				var sound = new SoundPlayer(FilePath);
				sound.Play();
			}
		}
	}
}
