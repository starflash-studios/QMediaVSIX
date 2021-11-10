using System.ComponentModel;
using System.Windows.Media.Imaging;

using QMediaVSIX.Converters;
using QMediaVSIX.Core.MediaSource.Hardware;
using QMediaVSIX.Environment;

using ReactiveUI;

namespace QMediaVSIX.Views;

public class MediaDeviceViewModel : NotifyPropertyChange {
	public MediaDeviceViewModel() {
		_Device = null;

		Debug.WriteLine("Constructing viewmodel...");
		PropertyChanged += ( S, E ) => {
			Debug.WriteLine($"{S.GetType().FullName}.{E.PropertyName} changed...");

			if ( _Device is not { } D ) {
				Debug.WriteLine("Ignored. (Device was null)");
				return;
			}
			switch ( E.PropertyName ) {
				case nameof(Volume):
					Debug.WriteLine($"\tNew value: {Volume}");
					_PropChangeFromSelf = true;
					D.Volume = Volume;
					break;
				case nameof(Mute):
					Debug.WriteLine($"\tNew value: {Mute}");
					_PropChangeFromSelf = true;
					D.Mute = Mute;
					break;
			}
		};
		PropertyChanging += ( S, E ) => {
			Debug.WriteLine($"{S.GetType().FullName}.{E.PropertyName} changing...");
			switch ( E.PropertyName ) {
				case nameof(Volume):
					Debug.WriteLine($"\tOld value: {_Volume}");
					break;
				case nameof(Mute):
					Debug.WriteLine($"\tOld value: {Mute}");
					break;
			}
		};
	}

	public void SetDevice( MediaDevice Device ) {
		if ( _Device is not null ) {
			throw new NotSupportedException("Unable to change device to already assigned viewmodel.");
		}
		this.Device = Device;
	}

	MediaDevice? _Device;
	public MediaDevice? Device {
		get => _Device;
		private set {
			switch ( value ) {
				//this.RaiseAndSetIfChanged(ref _Device, value);
				case null: {
					if ( _Device is not null ) {
						_Device.PropertyChanged -= Device_PropertyChanged;
						_Device.Control.IconPathChanged -= Control_IconPathChanged;
						_Device = null;
					}
					break;
				}
				case { } V when _Device is null || _Device.Identifier != V.Identifier:
					_Device = V;
					this.RaisePropertyChanged(nameof(Device));
					//if (_Device is )
					_Device.PropertyChanged += Device_PropertyChanged;
					_Device.Control.IconPathChanged += Control_IconPathChanged;

					this.RaiseAndSetIfChanged(ref _Volume, _Device.Volume, nameof(Volume));
					this.RaiseAndSetIfChanged(ref _Mute, _Device.Mute, nameof(Mute));
					//Debug.WriteLine($"Current icon '{_Device.Control.IconPath}'");
					if ( _Device.Control2.Process.MainModule.FileName is { } ProcessPath ) {
						Image = ProcessPath.GetIconToBitmapSourceCustom(32);
					}
					break;
			}
		}
	}

	void Control_IconPathChanged( object Sender, CSCore.CoreAudioAPI.AudioSessionIconPathChangedEventArgs E ) {
		Debug.WriteLine("The icon was changed!");
		//E.NewIconPath
		Image = new BitmapImage(new Uri(E.NewIconPath));
	}

	bool _PropChangeFromSelf;
	void Device_PropertyChanged( object Sender, PropertyChangedEventArgs E ) {
		if ( _PropChangeFromSelf ) { _PropChangeFromSelf = false; return; }
		Debug.WriteLine($"Property {Sender.GetTypeName(true)}.{E.PropertyName} was changed.");
		//switch ( E.PropertyName ) {
		//	case nameof(MediaDevice.Control.)
		//}
	}

	float _Volume = 0.75f;
	public float Volume {
		get => _Volume;
		set => this.RaiseAndSetIfChanged(ref _Volume, value);
	}

	bool _Mute;
	public bool Mute {
		get => _Mute;
		set => this.RaiseAndSetIfChanged(ref _Mute, value);
	}

	//string _DisplayName;
	//public string DisplayName {
	//	get => _DisplayName;
	//	set => this.RaiseAndSetIfChanged(ref _DisplayName, value);
	//}
	public string DisplayName => Device?.ToString() ?? "ERR";

	BitmapSource? _Image;
	public BitmapSource? Image {
		get => _Image;
		set {
			this.RaiseAndSetIfChanged(ref _Image, value);
			this.RaisePropertyChanged(nameof(BindingImage));
		}
	}

	public BitmapSource BindingImage => Image ?? Images.UnknownThumbnail;
}