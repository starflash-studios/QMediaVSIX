using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

using QMediaVSIX.Core.MediaSource.Hardware;
using QMediaVSIX.Core.MediaSource.Software;

namespace QMediaVSIX.Core.MediaSource.Ecosystem;

public static class MediaEcoystemExtensions {
	public static Guid Combine(this Guid A, Guid B) {
		byte[] BytesA = A.ToByteArray();
		byte[] BytesB = B.ToByteArray();
		byte[] Data = new byte[16];
		for ( int I = 0; I < 16; I++ ) {
			if ( I % 2 == 1 ) {
				Data[I] = BytesA[I];
			} else {
				Data[I] = BytesB[I];
			}
		}
		return new Guid(Data);
	}

	public static Guid Combine( this IList<Guid> Guids ) {
		int N = Guids.Count;
		int A = 0;
		IList<byte[]> GuidBytes = Guids.Select(G => G.ToByteArray()).ToList();
		byte[] Bytes = new byte[16];
		for ( int I = 0; I < 16; I++ ) {
			Bytes[I] = GuidBytes[A][I];
			A++;
			if ( A >= N ) {
				A = 0;
			}
		}
		return new Guid(Bytes);
	}

	public static Guid Combine( this Guid A, params Guid[] Others ) => Combine(A.And(Others));

	public static IList<T> And<T>( this T Item, IList<T> List ) {
		List.Insert(0, Item);
		return List;
	}

	public static IList<T> And<T>( this T Item, params T[] Items ) {
		List<T> L = new List<T>{Item};
		L.AddRange(Items);
		return L;
	}

	// ReSharper disable InconsistentNaming
	const int
		QUERYLIMITEDINFORMATION = 0x1000,
		ERROR_INSUFFICIENT_BUFFER = 0x7a,
		ERROR_SUCCESS = 0x0;
	// ReSharper disable restore InconsistentNaming

	[DllImport("kernel32.dll")]
	internal static extern IntPtr OpenProcess( int DWDesiredAccess, bool BInheritHandle, int DWProcessId );

	[DllImport("kernel32.dll")]
	static extern bool CloseHandle( IntPtr HHandle );

	[DllImport("kernel32.dll")]
	internal static extern int GetApplicationUserModelId( IntPtr HProcess, ref uint AppModelIDLength, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder SBAppUserModelID );

	internal static string? GetApplicationUserModelId( int ProcessId ) {
		string? SResult = null;
		IntPtr PtrProcess = OpenProcess(QUERYLIMITEDINFORMATION, false, ProcessId);
		if ( IntPtr.Zero != PtrProcess ) {
			uint CchLen = 130; // Currently APPLICATION_USER_MODEL_ID_MAX_LENGTH = 130
			StringBuilder SBName = new StringBuilder((int)CchLen);
			int LResult = GetApplicationUserModelId(PtrProcess, ref CchLen, SBName);
			switch ( LResult ) {
				case ERROR_SUCCESS:
					SResult = SBName.ToString();
					break;
				case ERROR_INSUFFICIENT_BUFFER: {
					SBName = new StringBuilder((int)CchLen);
					if ( ERROR_SUCCESS == GetApplicationUserModelId(PtrProcess, ref CchLen, SBName) ) {
						SResult = SBName.ToString();
					}
					break;
				}
			}
			CloseHandle(PtrProcess);
		}
		return SResult;
	}

	public static string? GetApplicationUserModelId( this Process P ) => GetApplicationUserModelId(P.Id);

	public static string? GetApplicationUserModelId( this MediaDevice MD ) {
		int Id = MD.Control2.ProcessID;
		//Process Proc = Process.GetProcessById(Id);
		//Debug.WriteLine($"Running on: {Proc} ({Proc.MainWindowTitle})");
		//Debug.WriteLine($"ID: {Id} (Self: {Environment.ProcessId})");
		return Id == Process.GetCurrentProcess().Id ? null : GetApplicationUserModelId(Id);
	}

	public static string GetApplicationUserModelId( this MediaSession MS ) => MS.Session.SourceAppUserModelId;

	public static IEnumerable<(int ProcessID, MediaSession MS, MediaDevice MD)> FindLinked( this IDictionary<Guid, MediaSession> Sessions, IDictionary<Guid, MediaDevice> Devices ) => FindLinked(Devices, Sessions);

	public static IEnumerable<(int ProcessID, MediaSession MS, MediaDevice MD)> FindLinked( this IDictionary<Guid, MediaDevice> Devices, IDictionary<Guid, MediaSession> Sessions ) => FindLinked(Devices.Values, Sessions.Values);

	public static IEnumerable<(int ProcessID, MediaSession MS, MediaDevice MD)> FindLinked( this IEnumerable<MediaDevice> Devices, IEnumerable<MediaSession> Sessions ) => FindLinked(Sessions, Devices);

	public static IEnumerable<(int ProcessID, MediaSession MS, MediaDevice MD)> FindLinked( this IEnumerable<MediaSession> Sessions, IEnumerable<MediaDevice> Devices ) {
		Dictionary<string, MediaSession> SessionsDict = Sessions.Select(S => new KeyValuePair<string, MediaSession>(S.Session.SourceAppUserModelId.TrimEnd(".exe"), S)).ToDictionary();

		foreach (MediaDevice Device in Devices ) {
			Process P = Device.Control2.Process;
			string ProcName = P.ProcessName.TrimEnd(".exe");
			Debug.WriteLine($"Does {string.Join(",", SessionsDict.Keys)} contain {ProcName}?");
			if ( SessionsDict.ContainsKey(ProcName) ) {
				yield return (P.Id, SessionsDict[ProcName], Device);
			}
		}

		//List<(int ProcessId, string? ApplicationUserModelId, MediaSession? MS, MediaDevice? MD)> L = Process.GetProcesses().Select(P => ((int ProcessId, string? ApplicationUserModelId, MediaSession? MS, MediaDevice? MD))(P.Id, GetApplicationUserModelId(P.Id), null, null)).ToList();

		//foreach ( MediaSession Session in Sessions ) {
		//	int I = L.GetIndexWith(Session.Session.SourceAppUserModelId);
		//	(int PI, string? AUMI, _, MediaDevice? D) = L[I];
		//	L[I] = (PI, AUMI, Session, D);
		//}

		//foreach ( MediaDevice Device in Devices ) {
		//	int I = L.GetIndexWith(Device.Control2.ProcessID);
		//	(int PI, string? AUMI, MediaSession? S, _) = L[I];
		//	L[I] = (PI, AUMI, S, Device);
		//}

		//foreach( (int PId, _, MediaSession? MS, MediaDevice? MD) in L ) {
		//	if ( MS is { } RS && MD is { } RD ) {
		//		yield return (PId, RS, RD);
		//	}
		//}
	}

	public static string TrimEnd(this string Str, string Trim ) {
		int L = Trim.Length;
		while ( Str.EndsWith(Trim) ) {
			Str = Str[..^L];
		}
		return Str;
	}

	public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>( this IEnumerable<KeyValuePair<TKey, TValue>> Enumerable ) where TKey : notnull {
		Dictionary<TKey, TValue> Dict = new Dictionary<TKey, TValue>();
		Dict.AddRange(Enumerable);
		return Dict;
	}

	public static void AddRange<TKey, TValue>( this IDictionary<TKey, TValue> Dict, IEnumerable<KeyValuePair<TKey, TValue>> Pairs ) {
		foreach( KeyValuePair<TKey, TValue> Pair in Pairs ) {
			Dict.Add(Pair);
		}
	}

	public static (int ProcessID, MediaSession MS, MediaDevice MD)? FindSingleLinked( this MediaSession Session, IList<MediaDevice> Devices ) {
		string SearchProcName = Session.Session.SourceAppUserModelId.TrimEnd(".exe");
		foreach ( MediaDevice Device in Devices ) {
			Process P = Device.Control2.Process;
			Debug.WriteLine($"Does {SearchProcName} == {P.ProcessName.TrimEnd(".exe")}?");
			if ( P.ProcessName.TrimEnd(".exe") == SearchProcName ) {
				return (P.Id, Session, Device);
			}
		}
		return null;

		// ReSharper disable once LoopCanBePartlyConvertedToQuery
		//foreach( Process P in Process.GetProcesses() ) {
		//	string? ApplicationUserModelId = GetApplicationUserModelId(P.Id);
		//	if ( Session.Session.SourceAppUserModelId != ApplicationUserModelId ) { continue; }

		//	int PId = P.Id;
		//	if ( Devices.FirstThat(D => D.Control2.ProcessID == PId, DR => (PId, Session, DR)) is var X ) {
		//		return X;
		//	}

		//}
		//return null;
	}

	public static (int ProcessID, MediaSession MS, MediaDevice MD)? FindSingleLinked( this MediaDevice Device, IList<MediaSession> Sessions ) {
		Process P = Device.Control2.Process;
		string SearchProcName = P.ProcessName.TrimEnd(".exe");
		// ReSharper disable once LoopCanBePartlyConvertedToQuery
		foreach(MediaSession Session in Sessions ) {
			Debug.WriteLine($"Does {SearchProcName} == {Session.Session.SourceAppUserModelId.TrimEnd(".exe")}?");
			if ( Session.Session.SourceAppUserModelId.TrimEnd(".exe") == SearchProcName ) {
				return (P.Id, Session, Device);
			}
		}
		return null;
		//int PId = Device.Control2.ProcessID;
		//string? AUMI = GetApplicationUserModelId(PId);
		//if ( AUMI is null ) { return null; }
		//return Sessions.FirstThat(M => M.Session.SourceAppUserModelId == AUMI, MS => (PId, MS, Device));
	}

	public static Process? GetProcess( string? SourceAppUserModelId ) {
		switch ( SourceAppUserModelId ) {
			case { } AUMI:
				// ReSharper disable once LoopCanBePartlyConvertedToQuery
				foreach(Process P in Process.GetProcesses() ) {
					string? PAUMI = GetApplicationUserModelId(P.Id);
					if ( PAUMI == AUMI ) {
						return P;
					}
				}
				return null;
			default:
				return null;
		}
	}

	public static IEnumerable<KeyValuePair<int, string?>> GetProcesses() {
		// ReSharper disable once LoopCanBeConvertedToQuery
		foreach ( Process P in Process.GetProcesses() ) {
			string? AUMI = GetApplicationUserModelId(P.Id);
			yield return new KeyValuePair<int, string?>(P.Id, AUMI);
		}
	}

	public static void FirstThat<T>( this IEnumerable<T> Enumerable, Predicate<T> Predicate, Action<T> Act ) {
		// ReSharper disable once LoopCanBePartlyConvertedToQuery
		foreach ( T Item in Enumerable ) {
			if ( Predicate(Item) ) {
				Act(Item);
				return;
			}
		}
	}

	public static TR? FirstThat<T, TR>( this IEnumerable<T> Enumerable, Predicate<T> Predicate, Func<T, TR> Func ) {
		// ReSharper disable once LoopCanBePartlyConvertedToQuery
		foreach ( T Item in Enumerable ) {
			if ( Predicate(Item) ) {
				return Func(Item);
			}
		}
		return default;
	}

	internal static int GetIndexWith<TA, TB, TC, TD>( this IList<(TA S, TB, TC, TD)> L, TA Search ) where TA : IEquatable<TA> {
		int C = L.Count;
		for ( int I = 0; I < C; I++ ) {
			if ( L[I].S.Equals(Search) ) {
				return I;
			}
		}
		return -1;
	}

	internal static int GetIndexWith<TA, TB, TC, TD>( this IList<(TA, TB? S, TC, TD)> L, TB Search ) where TB : IEquatable<TB> {
		int C = L.Count;
		for ( int I = 0; I < C; I++ ) {
			if ( L[I].S?.Equals(Search) ?? false ) {
				return I;
			}
		}
		return -1;
	}
}