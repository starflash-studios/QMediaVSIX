// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemConnectionInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.AppService;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Provides information about a connection to a remote system. For example, the type of connection.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Static(typeof (IRemoteSystemConnectionInfoStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RemoteSystemConnectionInfo : IRemoteSystemConnectionInfo
  {
    /// <summary>Gets whether the associated remote system connection is a proximal connection or not.</summary>
    /// <returns>**True** if the connection is proximal, **False** otherwise.</returns>
    public extern bool IsProximal { [MethodImpl] get; }

    /// <summary>Creates an instance of this class corresponding to the given app service connection.</summary>
    /// <param name="connection">The AppServiceConnection instance for which the underlying remote system connection's information should be obtained.</param>
    /// <returns>**RemoteSystemConnectionInfo **</returns>
    [Overload("TryCreateFromAppServiceConnection")]
    [MethodImpl]
    public static extern RemoteSystemConnectionInfo TryCreateFromAppServiceConnection(
      AppServiceConnection connection);
  }
}
