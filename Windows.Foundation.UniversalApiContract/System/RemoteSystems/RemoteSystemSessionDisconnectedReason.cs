// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemSessionDisconnectedReason
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Contains values that describe the reason that a device may be disconnected from a remote session.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum RemoteSystemSessionDisconnectedReason
  {
    /// <summary>The connection to the remote session was lost.</summary>
    SessionUnavailable,
    /// <summary>The device controlling the remote session removed this device as a participant.</summary>
    RemovedByController,
    /// <summary>The device controlling the remote session ended the session.</summary>
    SessionClosed,
  }
}
