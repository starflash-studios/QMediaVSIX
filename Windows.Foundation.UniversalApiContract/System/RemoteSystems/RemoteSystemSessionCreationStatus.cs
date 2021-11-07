// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemSessionCreationStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Describes the status of an attempt to create a remote session.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum RemoteSystemSessionCreationStatus
  {
    /// <summary>The remote session was created successfully.</summary>
    Success,
    /// <summary>The remote session was not created because this device is already a participant in the maximum allowed number of sessions.</summary>
    SessionLimitsExceeded,
    /// <summary>The creation attempt failed for an unknown reason.</summary>
    OperationAborted,
  }
}
