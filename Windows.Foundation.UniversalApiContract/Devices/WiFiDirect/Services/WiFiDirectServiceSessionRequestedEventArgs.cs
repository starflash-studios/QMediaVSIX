// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.WiFiDirectServiceSessionRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect.Services
{
  /// <summary>Returned when a WiFiDirectServiceAdvertiser.SessionRequested event is raised.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WiFiDirectServiceSessionRequestedEventArgs : 
    IWiFiDirectServiceSessionRequestedEventArgs
  {
    /// <summary>Gets information about the session request that raised a WiFiDirectServiceAdvertiser.SessionRequested event.</summary>
    /// <returns>Information about a new session request.</returns>
    [MethodImpl]
    public extern WiFiDirectServiceSessionRequest GetSessionRequest();
  }
}
