using System.Diagnostics;
using System.Runtime.InteropServices;

namespace QMediaVSIX.Core.MediaSource.Hardware.CoreAudio;

/// <inheritdoc cref="AudioUtilities"/>
public sealed class AudioSession : IDisposable {
	AudioUtilities.IAudioSessionControl2? _Ctl;
	Process? _Process;

	internal AudioSession( AudioUtilities.IAudioSessionControl2 Ctl, Process? Process = null ) {
		_Ctl = Ctl;
		_Process = Process;
	}

	public Process? Process {
		get {
			if ( _Process == null && ProcessId != 0 ) {
				try {
					_Process = Process.GetProcessById(ProcessId);
				} catch {
					// do nothing
				}
			}
			return _Process;
		}
	}

	public int ProcessId {
		get {
			CheckDisposed();
			if (_Ctl is null ) { throw new ArgumentNullException(nameof(_Ctl)); }
			_Ctl.GetProcessId(out int I);
			return I;
		}
	}

	public string Identifier {
		get {
			CheckDisposed();
			if ( _Ctl is null ) { throw new ArgumentNullException(nameof(_Ctl)); }
			_Ctl.GetSessionIdentifier(out string S);
			return S;
		}
	}

	public string InstanceIdentifier {
		get {
			CheckDisposed();
			if ( _Ctl is null ) { throw new ArgumentNullException(nameof(_Ctl)); }
			_Ctl.GetSessionInstanceIdentifier(out string S);
			return S;
		}
	}

	public AudioSessionState State {
		get {
			CheckDisposed();
			if ( _Ctl is null ) { throw new ArgumentNullException(nameof(_Ctl)); }
			_Ctl.GetState(out AudioSessionState S);
			return S;
		}
	}

	public Guid GroupingParam {
		get {
			CheckDisposed();
			if ( _Ctl is null ) { throw new ArgumentNullException(nameof(_Ctl)); }
			_Ctl.GetGroupingParam(out Guid G);
			return G;
		}
		set {
			CheckDisposed();
			if ( _Ctl is null ) { throw new ArgumentNullException(nameof(_Ctl)); }
			_Ctl.SetGroupingParam(value, Guid.Empty);
		}
	}

	public string DisplayName {
		get {
			CheckDisposed();
			if ( _Ctl is null ) { throw new ArgumentNullException(nameof(_Ctl)); }
			_Ctl.GetDisplayName(out string S);
			return S;
		}
		set {
			CheckDisposed();
			if ( _Ctl is null ) { throw new ArgumentNullException(nameof(_Ctl)); }
			_Ctl.GetDisplayName(out string S);
			if ( S != value ) {
				_Ctl.SetDisplayName(value, Guid.Empty);
			}
		}
	}

	public string IconPath {
		get {
			CheckDisposed();
			if ( _Ctl is null ) { throw new ArgumentNullException(nameof(_Ctl)); }
			_Ctl.GetIconPath(out string S);
			return S;
		}
		set {
			CheckDisposed();
			if ( _Ctl is null ) { throw new ArgumentNullException(nameof(_Ctl)); }
			_Ctl.GetIconPath(out string S);
			if ( S != value ) {
				_Ctl.SetIconPath(value, Guid.Empty);
			}
		}
	}

	void CheckDisposed() {
		if ( _Ctl is null ) {
			throw new ObjectDisposedException("Control");
		}
	}

	public override string ToString() {
		string S = DisplayName;
		if ( !string.IsNullOrEmpty(S) ) {
			return "DisplayName: " + S;
		}

		if ( Process != null ) {
			return "Process: " + Process.ProcessName;
		}

		return "Pid: " + ProcessId;
	}

	public void Dispose() {
		if ( _Ctl is not null ) {
			Marshal.ReleaseComObject(_Ctl);
			_Ctl = null;
		}
	}
}