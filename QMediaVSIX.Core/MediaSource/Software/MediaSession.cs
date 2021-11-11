using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

using Windows.Foundation;

using QMediaVSIX.Core.Collections;

using Windows.Media;
using Windows.Media.Control;
using Windows.Storage.Streams;

namespace QMediaVSIX.Core.MediaSource.Software;

public class MediaSession : NotifyPropertyChange, IMediaSession {
	public WMCSession Session { get; }

	public MediaSession( WMCSession Session ) {
		AsyncRunner = FakeAsync;
		PropertyChanged += ( _, E ) => {
			switch ( E.PropertyName ) {
				case nameof(Controls):
					Session_PlaybackInfo_ControlsChanged();
					break;
			}
		};

		this.Session = Session;
		Session.MediaPropertiesChanged += Session_MediaPropertiesChanged;
		Session.PlaybackInfoChanged += Session_PlaybackInfoChanged;
		Session.TimelinePropertiesChanged += Session_TimelinePropertiesChanged;

		Identifier = GetIdentifier(Session);
	}

	#region Background Asynchronous Delegators

	//internal static async void FakeAsync( Task Tk ) => await Tk;
	//internal static async void FakeAsync( IAsyncAction Aa ) => await Aa;
	//internal static async void FakeAsync<T>( IAsyncOperation<T> Ao ) => _ = await Ao;
	////internal static async void FakeAsync( Func<Task> FuncTk ) => await FuncTk();
	////internal static async void FakeAsync( Func<IAsyncAction> FuncAa ) => await FuncAa();
	//internal static async void FakeAsync<T>( Func<IAsyncOperation<T>> FuncAo ) => _ = await FuncAo();
	////internal static async void FakeAsync<T>( T Val, Func<T, IAsyncOperation<T>> FuncAo ) => _ = await FuncAo(Val);
	////internal static async void FakeAsync<T>( Task<T> Tk, Action<T> Act ) {
	////	await Tk.ContinueWith(Completed => {
	////		Act.Invoke(Completed.Result);
	////	});
	////}
	////internal static async void FakeAsync<T>( IAsyncOperation<T> Ao, Action<T> Act ) {
	////	await Ao.AsTask().ContinueWith(Completed => {
	////		Act.Invoke(Completed.Result);
	////	});
	////}
	//internal static async void FakeAsync<T>( T? Val, Func<T, IAsyncOperation<bool>> Act ) where T : class {
	//	if ( Val is null ) { throw new NullVal(nameof(Val)); }
	//	_ = await Act(Val);
	//}

	//internal static async void FakeAsync<T>( T? Val, Func<T, IAsyncOperation<bool>> Act ) where T : struct {
	//	if ( Val is null ) { throw new NullVal(nameof(Val)); }
	//	_ = await Act(Val.Value);
	//}

	#endregion

	public Action<Func<Task>> AsyncRunner;

	public void RunAsyncMethod( Task Tk ) {
		Task GetTk() => Task.FromResult(Tk);
		AsyncRunner(GetTk);
	}

	public void RunAsyncMethod<T>( IAsyncOperation<T> Tk ) => RunAsyncMethod(Tk.AsTask);

	public void RunAsyncMethod<T>( Func<IAsyncOperation<T>> Tk ) {
		Func<Task> GetTk() => () => Tk.Invoke().AsTask();
		RunAsyncMethod(GetTk());
	}

	public void RunAsyncMethod( Func<Task> Tk ) => AsyncRunner(Tk);

	protected internal static async void FakeAsync( Func<Task> Tk ) => await Tk.Invoke();

	#region Timeline Properties

	#region TimelineProperties Property

	WMCTimelineProperties _TimelineProperties = null!;
	public WMCTimelineProperties TimelineProperties {
		get => _TimelineProperties;
		private set => SetValue(ref _TimelineProperties, value);
	}

	#endregion

	#region EndTime Property

	TimeSpan _EndTime = TimeSpan.Zero;
	public TimeSpan EndTime {
		get => _EndTime;
		private set => SetValue(ref _EndTime, value);
	}

	#endregion

	#region LastUpdatedTime Property

	DateTimeOffset _LastUpdatedTime = DateTimeOffset.MinValue;
	public DateTimeOffset LastUpdatedTime {
		get => _LastUpdatedTime;
		private set => SetValue(ref _LastUpdatedTime, value);
	}

	#endregion

	#region MaxSeekTime Property

	TimeSpan _MaxSeekTime = TimeSpan.Zero;
	public TimeSpan MaxSeekTime {
		get => _MaxSeekTime;
		private set => SetValue(ref _MaxSeekTime, value);
	}

	#endregion

	#region MinSeekTime Property

	TimeSpan _MinSeekTime = TimeSpan.Zero;
	public TimeSpan MinSeekTime {
		get => _MinSeekTime;
		private set => SetValue(ref _MinSeekTime, value);
	}

	#endregion

	#region Position Property

	TimeSpan _Position = TimeSpan.Zero;
	public TimeSpan Position {
		get => _Position;
		//private set => SetValue(ref _Position, value);
		set => SetPosition(value.Ticks);
	}

	#endregion

	void Session_TimelinePropertiesChanged( WMCSession Sender, TimelinePropertiesChangedEventArgs Args ) {
		TimelineProperties = Session.GetTimelineProperties();
		EndTime = TimelineProperties.EndTime;
		LastUpdatedTime = TimelineProperties.LastUpdatedTime;
		MaxSeekTime = TimelineProperties.MaxSeekTime;
		MinSeekTime = TimelineProperties.MinSeekTime;
		//Position = TimelineProperties.Position;
		SetValue(ref _Position, TimelineProperties.Position, nameof(Position));
	}

	#region Method Invocations

	public void SetPosition( long Ticks ) => RunAsyncMethod(Session.TryChangePlaybackPositionAsync(Ticks));

	#endregion

	#endregion

	#region PlaybackInfo Properties

	#region PlaybackInfo Property

	WMCPlaybackInfo _PlaybackInfo = null!;
	public WMCPlaybackInfo PlaybackInfo {
		get => _PlaybackInfo;
		private set => SetValue(ref _PlaybackInfo, value);
	}

	#endregion

	#region AutoRepeatMode Property

	MediaPlaybackAutoRepeatMode? _AutoRepeatMode;
	public MediaPlaybackAutoRepeatMode? AutoRepeatMode {
		get => _AutoRepeatMode;
		set {
			async Task Set() {
				await Session.TryChangeAutoRepeatModeAsync(value ?? throw new NullVal(nameof(value)));
			}

			RunAsyncMethod(Set);
		}
	}

	#endregion

	#region Controls Property

	WMCPlaybackControls _Controls = null!;
	public WMCPlaybackControls Controls {
		get => _Controls;
		private set => SetValue(ref _Controls, value);
	}

	#endregion

	#region IsShuffleActive Property

	bool? _IsShuffleActive;

	public bool? IsShuffleActive {
		get => _IsShuffleActive;
		set {
			async Task Set() {
				await Session.TryChangeShuffleActiveAsync(value ?? throw new NullVal(nameof(value)));
			}

			RunAsyncMethod(Set);
		}
	}

	#endregion

	#region PlaybackRate Property

	double? _PlaybackRate;
	public double? PlaybackRate {
		get => _PlaybackRate;
		set { 
			async Task Set() {
				await Session.TryChangePlaybackRateAsync(value ?? throw new NullVal(nameof(value)));
			}

			RunAsyncMethod(Set);
		}
	}

	#endregion

	#region PlaybackStatus Property

	WMCPlaybackStatus _PlaybackStatus = default;
	public WMCPlaybackStatus PlaybackStatus {
		get => _PlaybackStatus;
		set {
			switch ( value ) {
				case GlobalSystemMediaTransportControlsSessionPlaybackStatus.Closed:
				case GlobalSystemMediaTransportControlsSessionPlaybackStatus.Opened:
				case GlobalSystemMediaTransportControlsSessionPlaybackStatus.Changing:
					throw new NotSupportedException($"Changing session status type to {value} is unsupported.");
				case GlobalSystemMediaTransportControlsSessionPlaybackStatus.Stopped:
					RunAsyncMethod(Session.TryStopAsync);
					break;
				case GlobalSystemMediaTransportControlsSessionPlaybackStatus.Playing:
					RunAsyncMethod(Session.TryPlayAsync);
					break;
				case GlobalSystemMediaTransportControlsSessionPlaybackStatus.Paused:
					RunAsyncMethod(Session.TryPauseAsync);
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(value), value, null);
			}
		}
	}

	#endregion

	#region PlaybackType Property

	MediaPlaybackType? _PlaybackType;
	public MediaPlaybackType? PlaybackType {
		get => _PlaybackType;
		private set => SetValue(ref _PlaybackType, value);
	}

	#endregion

	void Session_PlaybackInfoChanged( WMCSession Sender, PlaybackInfoChangedEventArgs Args ) {
		PlaybackInfo = Sender.GetPlaybackInfo();
		//---
		SetValue(ref _AutoRepeatMode,  PlaybackInfo.AutoRepeatMode,  nameof(AutoRepeatMode));
		Controls = PlaybackInfo.Controls;
		SetValue(ref _IsShuffleActive, PlaybackInfo.IsShuffleActive, nameof(IsShuffleActive));
		SetValue(ref _PlaybackRate,    PlaybackInfo.PlaybackRate,    nameof(PlaybackRate));
		SetValue(ref _PlaybackStatus,  PlaybackInfo.PlaybackStatus,  nameof(PlaybackStatus));
		PlaybackType = PlaybackInfo.PlaybackType;
	}

	#endregion

	#region PlaybackInfo.Controls Properties

	#region IsChannelDownEnabled Property

	bool _IsChannelDownEnabled;
	public bool IsChannelDownEnabled {
		get => _IsChannelDownEnabled;
		private set => SetValue(ref _IsChannelDownEnabled, value);
	}

	#endregion

	#region IsChannelUpEnabled Property

	bool _IsChannelUpEnabled;
	public bool IsChannelUpEnabled {
		get => _IsChannelUpEnabled;
		private set => SetValue(ref _IsChannelUpEnabled, value);
	}

	#endregion

	#region IsFastForwardEnabled Property

	bool _IsFastForwardEnabled;
	public bool IsFastForwardEnabled {
		get => _IsFastForwardEnabled;
		private set => SetValue(ref _IsFastForwardEnabled, value);
	}

	#endregion

	#region IsNextEnabled Property

	bool _IsNextEnabled;
	public bool IsNextEnabled {
		get => _IsNextEnabled;
		private set => SetValue(ref _IsNextEnabled, value);
	}

	#endregion

	#region IsPauseEnabled Property

	bool _IsPauseEnabled;
	public bool IsPauseEnabled {
		get => _IsPauseEnabled;
		private set => SetValue(ref _IsPauseEnabled, value);
	}

	#endregion

	#region IsPlaybackPositionEnabled Property

	bool _IsPlaybackPositionEnabled;
	public bool IsPlaybackPositionEnabled {
		get => _IsPlaybackPositionEnabled;
		private set => SetValue(ref _IsPlaybackPositionEnabled, value);
	}

	#endregion

	#region IsPlaybackRateEnabled Property

	bool _IsPlaybackRateEnabled;
	public bool IsPlaybackRateEnabled {
		get => _IsPlaybackRateEnabled;
		private set => SetValue(ref _IsPlaybackRateEnabled, value);
	}

	#endregion

	#region IsPlayEnabled Property

	bool _IsPlayEnabled;
	public bool IsPlayEnabled {
		get => _IsPlayEnabled;
		private set => SetValue(ref _IsPlayEnabled, value);
	}

	#endregion

	#region IsPlayPauseToggleEnabled Property

	bool _IsPlayPauseToggleEnabled;
	public bool IsPlayPauseToggleEnabled {
		get => _IsPlayPauseToggleEnabled;
		private set => SetValue(ref _IsPlayPauseToggleEnabled, value);
	}

	#endregion

	#region IsPreviousEnabled Property

	bool _IsPreviousEnabled;
	public bool IsPreviousEnabled {
		get => _IsPreviousEnabled;
		private set => SetValue(ref _IsPreviousEnabled, value);
	}

	#endregion

	#region IsRecordEnabled Property

	bool _IsRecordEnabled;
	public bool IsRecordEnabled {
		get => _IsRecordEnabled;
		private set => SetValue(ref _IsRecordEnabled, value);
	}

	#endregion

	#region IsRepeatEnabled Property

	bool _IsRepeatEnabled;
	public bool IsRepeatEnabled {
		get => _IsRepeatEnabled;
		private set => SetValue(ref _IsRepeatEnabled, value);
	}

	#endregion

	#region IsRewindEnabled Property

	bool _IsRewindEnabled;
	public bool IsRewindEnabled {
		get => _IsRewindEnabled;
		private set => SetValue(ref _IsRewindEnabled, value);
	}

	#endregion

	#region IsShuffleEnabled Property

	bool _IsShuffleEnabled;
	public bool IsShuffleEnabled {
		get => _IsShuffleEnabled;
		private set => SetValue(ref _IsShuffleEnabled, value);
	}

	#endregion

	#region IsStopEnabled Property

	bool _IsStopEnabled;
	public bool IsStopEnabled {
		get => _IsStopEnabled;
		private set => SetValue(ref _IsStopEnabled, value);
	}

	#endregion

	void Session_PlaybackInfo_ControlsChanged() {
		IsChannelDownEnabled = Controls.IsChannelDownEnabled;
		IsChannelUpEnabled = Controls.IsChannelUpEnabled;
		IsFastForwardEnabled = Controls.IsFastForwardEnabled;
		IsNextEnabled = Controls.IsNextEnabled;
		IsPauseEnabled = Controls.IsPauseEnabled;
		IsPlaybackPositionEnabled = Controls.IsPlaybackPositionEnabled;
		IsPlaybackRateEnabled = Controls.IsPlaybackRateEnabled;
		IsPlayEnabled = Controls.IsPlayEnabled;
		IsPlayPauseToggleEnabled = Controls.IsPlayPauseToggleEnabled;
		IsPreviousEnabled = Controls.IsPreviousEnabled;
		IsRecordEnabled = Controls.IsRecordEnabled;
		IsRepeatEnabled = Controls.IsRepeatEnabled;
		IsRewindEnabled = Controls.IsRewindEnabled;
		IsShuffleEnabled = Controls.IsShuffleEnabled;
		IsStopEnabled = Controls.IsStopEnabled;
	}

	#region Method Invocations

	public void ChannelDown() => RunAsyncMethod(Session.TryChangeChannelDownAsync());
	public void ChannelUp() => RunAsyncMethod(Session.TryChangeChannelUpAsync());
	public void FastForward() => RunAsyncMethod(Session.TryFastForwardAsync());
	public void Record() => RunAsyncMethod(Session.TryRecordAsync());
	public void Rewind() => RunAsyncMethod(Session.TryRewindAsync());
	public void SkipNext() => RunAsyncMethod(Session.TrySkipNextAsync());
	public void SkipPrevious() => RunAsyncMethod(Session.TrySkipPreviousAsync());
	public void Play() => RunAsyncMethod(Session.TryPlayAsync());
	public void Pause() => RunAsyncMethod(Session.TryPauseAsync());
	public void Stop() => RunAsyncMethod(Session.TryStopAsync());
	public void TogglePlayPause() => RunAsyncMethod(Session.TryTogglePlayPauseAsync());

	#endregion

	#endregion

	#region Media Properties

	#region MediaProperties Property

	WMCMediaProperties? _MediaProperties;
	public WMCMediaProperties? MediaProperties {
		get => _MediaProperties;
		private set => SetValue(ref _MediaProperties, value);
	}

	#endregion

	#region AlbumArtist Property

	string _AlbumArtist = string.Empty;
	public string AlbumArtist {
		get => _AlbumArtist;
		private set => SetValue(ref _AlbumArtist, value);
	}

	#endregion

	#region AlbumTitle Property

	string _AlbumTitle = string.Empty;
	public string AlbumTitle {
		get => _AlbumTitle;
		private set => SetValue(ref _AlbumTitle, value);
	}

	#endregion

	#region AlbumTrackCount Property

	int _AlbumTrackCount = 0;
	public int AlbumTrackCount {
		get => _AlbumTrackCount;
		private set => SetValue(ref _AlbumTrackCount, value);
	}

	#endregion

	#region Artist Property

	string _Artist = string.Empty;
	public string Artist {
		get => _Artist;
		private set => SetValue(ref _Artist, value);
	}

	#endregion

	#region Genres Property

	public ObservableCollection<string> Genres { get; } = new ObservableCollection<string>();

	#endregion

	#region Subtitle Property

	string _Subtitle = string.Empty;
	public string Subtitle {
		get => _Subtitle;
		private set => SetValue(ref _Subtitle, value);
	}

	#endregion

	#region Thumbnail Property

	IRandomAccessStreamReference? _Thumbnail;
	public IRandomAccessStreamReference? Thumbnail {
		get => _Thumbnail;
		private set => SetValue(ref _Thumbnail, value);
	}

	#endregion

	#region Title Property

	string _Title = string.Empty;
	public string Title {
		get => _Title;
		private set => SetValue(ref _Title, value);
	}

	#endregion

	#region TrackNumber Property

	int _TrackNumber = 0;
	public int TrackNumber {
		get => _TrackNumber;
		private set => SetValue(ref _TrackNumber, value);
	}

	#endregion

	async void Session_MediaPropertiesChanged( WMCSession Sender, MediaPropertiesChangedEventArgs Args ) {
		MediaProperties = await Sender.TryGetMediaPropertiesAsync();
		AlbumArtist = MediaProperties.AlbumArtist;
		AlbumTitle = MediaProperties.AlbumTitle;
		AlbumTrackCount = MediaProperties.AlbumTrackCount;
		Artist = MediaProperties.Artist;
		lock ( Genres ) {
			Genres.Clear();
			Genres.AddRange(MediaProperties.Genres);
		}
		//PlaybackType = MediaProperties.PlaybackType;
		Subtitle = MediaProperties.Subtitle;
		Thumbnail = MediaProperties.Thumbnail;
		Title = MediaProperties.Title;
		TrackNumber = MediaProperties.TrackNumber;
	}

	#endregion

	#region Exceptions

	public class NullVal : ArgumentNullException {
		public NullVal( [CallerMemberName] string? PropertyName = "value" ) : base(PropertyName, "Provided value may not be null.") { }
	}

	#endregion

	public static Guid GetIdentifier( WMCSession Session ) => Session.SourceAppUserModelId.GetGuid();
	//public static Guid GetIdentifier(MediaSession Session) => Session.Session.SourceAppUserModelId.GetGuid();
	public readonly Guid Identifier;

	public override string ToString() => Session.SourceAppUserModelId;
}