// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.WiFiDirectServiceSessionDeferredEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.WiFiDirect.Services
{
  /// <summary>Returned when a WiFiDirectService.SessionDeferred event is raised.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WiFiDirectServiceSessionDeferredEventArgs : 
    IWiFiDirectServiceSessionDeferredEventArgs
  {
    /// <summary>Gets the service-defined session information returned by the service when it sends a deferral in response to a connection request. Note that a deferral does not indicate that the connection is refused. Rather, it indicates that the server is performing a time-consuming operation such as requesting user input. A seeker should implement a 120-second timeout after getting a deferral before giving up on the request.</summary>
    /// <returns>A byte sequence of deferred session information, up to 144 bytes. Format is defined by the service.</returns>
    public extern IBuffer DeferredSessionInfo { [MethodImpl] get; }
  }
}
