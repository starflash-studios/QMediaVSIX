// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.ESimProfileMetadataState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Defines constants that specify the state of eSIM profile metadata.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum ESimProfileMetadataState
  {
    /// <summary>Indicates that the state of the eSIM profile metadata is not known.</summary>
    Unknown,
    /// <summary>Indicates that the eSIM profile metadata is waiting to be installed.</summary>
    WaitingForInstall,
    /// <summary>Indicates that the eSIM profile metadata is being downloaded.</summary>
    Downloading,
    /// <summary>Indicates that the eSIM profile metadata is being installed.</summary>
    Installing,
    /// <summary>Indicates that the eSIM profile metadata has expired.</summary>
    Expired,
    /// <summary>Indicates that download of the eSIM profile metadata is being rejected.</summary>
    RejectingDownload,
    /// <summary>Indicates that the eSIM profile metadata is no longer available.</summary>
    NoLongerAvailable,
    /// <summary>Indicates that the eSIM profile metadata has been denied by policy.</summary>
    DeniedByPolicy,
  }
}
