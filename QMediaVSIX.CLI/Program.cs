using System.Security.Cryptography;
using System.Text;

using QMediaVSIX.Core.MediaSource;
using QMediaVSIX.Core.MediaSource.Ecosystem;
using QMediaVSIX.Core.MediaSource.Hardware;
using QMediaVSIX.Core.MediaSource.Software;

//using QMediaVSIX.Core.MediaSource.Hardware.CoreAudio;

namespace QMediaVSIX.CLI;

public class Program {
	public static void Main( string[] Args ) {
		//Disable clearing of the Output window.
		QDebug.Listeners.DiagnosticsListener.SetClearEnabledGlobal(false);

		//MediaSessionManager.AcquiredSessionManager += MediaSessionManager_AcquiredSessionManager;
		//MediaSessionManager.SessionConnected += MediaSessionManager_NewSession;

		//while ( true ) {
		//	Console.ReadKey();
		//	Console.Clear();
		//	MediaSessionManager.RefreshSessions();
		//}

		//_ = MediaSessionManager.Sessions;
		//_ = MediaDeviceManager.Devices;
		MediaSourceManager.Initialise();

		//MediaSessionManager.Sessions.KeyAdded += (_, _) => Change();
		//MediaSessionManager.Sessions.KeyRemoved += ( _, _, _ ) => Change();
		//MediaDeviceManager.Devices.KeyAdded += ( _, _ ) => Change();
		//MediaDeviceManager.Devices.KeyRemoved += ( _, _, _ ) => Change();
		//MediaSourceManager.Ecosystems.KeyAdded += ( _, _ ) => Change();
		//MediaSourceManager.Ecosystems.KeyRemoved += ( _, _, _ ) => Change();
		MediaSessionManager.SessionConnected += ( _, _ ) => Change();
		MediaDeviceManager.DeviceConnected += ( _, _ ) => Change();
		MediaSourceManager.EcosystemConnected += ( _, _ ) => Change();
		MediaSessionManager.SessionDisconnected += _ => Change();
		MediaDeviceManager.DeviceDisconnected += _ => Change();
		MediaSourceManager.EcosystemDisconnected += (_, _) => Change();

		void Change() {
			Debug.Clear();
			Debug.WriteLine("Ecosystems---");
			foreach ( (Guid Guid, MediaEcosystem Ecosystem) in MediaSourceManager.Ecosystems ) {
				Debug.WriteLine($"\t{Guid} :: {Ecosystem}");
				Debug.WriteLine($"\t\t{Ecosystem.Session}");
				Debug.WriteLine($"\t\t{Ecosystem.Device}");
			}
			Debug.WriteLine("-------------\n");
			Debug.WriteLine("Sessions-----");
			foreach ( (Guid Guid, MediaSession Session) in MediaSessionManager.Sessions ) {
				Debug.WriteLine($"\t{Guid} :: {Session}");
				Debug.WriteLine($"\t\t{Session.GetApplicationUserModelId()}");
			}
			Debug.WriteLine("-------------\n");
			Debug.WriteLine("Devices------");
			foreach ( (Guid Guid, MediaDevice Device) in MediaDeviceManager.Devices ) {
				Debug.WriteLine($"\t{Guid} :: {Device}");
				//Debug.WriteLine($"\t\t{Device.Control2.Process.ProcessName}");
				//{ProcessName}.exe == Session.Session.SourceAppUserModelId
				//Debug.WriteLine($"\t\t{Device.Control2.Process.MainWindowTitle}");
				//Debug.WriteLine($"\t\t{Device.GetApplicationUserModelId()}");
			}
			Debug.WriteLine("-------------");
		}

		Console.WriteLine(GenerateUniqueGuid());
		while ( true ) {
			Change();
			Console.ReadKey();
			//QDebug.Listeners.DiagnosticsListener.SetClearEnabledGlobal(true);
		}

		// ReSharper disable once FunctionNeverReturns
	}

	public static Guid GenerateUniqueGuid( string Unique = "guidDynamicMenuPackageCmdSet" ) {
		const string NM = "QMediaVSIX";
		return Combine(Generate(Unique), Generate(NM));
	}

	internal static Guid Generate( string Str ) {
		using ( MD5 Md = MD5.Create() ) {
			byte[] Bytes = Encoding.Default.GetBytes(Str);
			byte[] CryptoBytes = Md.ComputeHash(Bytes);
			return new Guid(CryptoBytes);
		}
	}

	internal static Guid Combine( Guid A, Guid B ) {
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
}