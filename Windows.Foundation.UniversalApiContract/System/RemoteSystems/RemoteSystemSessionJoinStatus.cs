// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemSessionJoinStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Contains values which describe the result of this device's attempt to join a remote session.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum RemoteSystemSessionJoinStatus
  {
    /// <summary>The join attempt was successful.</summary>
    Success,
    /// <summary>The join request failed because this device is already a participant in the maximum allowed number of sessions.</summary>
    SessionLimitsExceeded,
    /// <summary>The join attempt failed for an unknown reason.</summary>
    OperationAborted,
    /// <summary>The connection to the remote session was lost.</summary>
    SessionUnavailable,
    /// <summary>The join request was rejected by the device controlling this session.</summary>
    RejectedByController,
  }
}
