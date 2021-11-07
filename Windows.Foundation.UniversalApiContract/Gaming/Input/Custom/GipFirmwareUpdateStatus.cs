// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.GipFirmwareUpdateStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  /// <summary>Indicates the state of a firmware update operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum GipFirmwareUpdateStatus
  {
    /// <summary>The update is complete.</summary>
    Completed,
    /// <summary>The firmware is already up to date.</summary>
    UpToDate,
    /// <summary>The update failed.</summary>
    Failed,
  }
}
