// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.WiFiDirectServiceAutoAcceptSessionConnectedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.WiFiDirect.Services
{
  /// <summary>Returned when a WiFiDirectServiceAdvertiser.AutoAcceptSessionConnected event is raised.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class WiFiDirectServiceAutoAcceptSessionConnectedEventArgs : 
    IWiFiDirectServiceAutoAcceptSessionConnectedEventArgs
  {
    /// <summary>Gets the WiFiDirectServiceSession that was created when the connection was automatically accepted.</summary>
    /// <returns>The session object corresponding to this automatically accepted connection.</returns>
    public extern WiFiDirectServiceSession Session { [MethodImpl] get; }

    /// <summary>Gets the session information buffer that corresponds to this automatically accepted connection.</summary>
    /// <returns>Service-specific session information, up to 144 bytes. Can be NULL if the service provides no session information.</returns>
    public extern IBuffer SessionInfo { [MethodImpl] get; }
  }
}
