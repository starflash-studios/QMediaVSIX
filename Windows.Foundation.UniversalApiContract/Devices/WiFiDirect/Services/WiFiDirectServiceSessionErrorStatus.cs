// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.WiFiDirectServiceSessionErrorStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect.Services
{
  /// <summary>Values used in the WiFiDirectServiceSession.ErrorStatus property.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WiFiDirectServiceSessionErrorStatus
  {
    /// <summary>Session status is OK.</summary>
    Ok,
    /// <summary>The L2 connection was disassociated unexpectedly.</summary>
    Disassociated,
    /// <summary>The session was closed from the local side of the session.</summary>
    LocalClose,
    /// <summary>The session was closed from the remote side of the session.</summary>
    RemoteClose,
    /// <summary>A general system failure has occurred.</summary>
    SystemFailure,
    /// <summary>Session timed out due to no response from the remote side of the session.</summary>
    NoResponseFromRemote,
  }
}
