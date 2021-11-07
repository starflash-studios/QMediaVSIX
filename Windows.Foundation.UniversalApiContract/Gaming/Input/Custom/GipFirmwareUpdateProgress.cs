// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.GipFirmwareUpdateProgress
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  /// <summary>Indicates the progress of a firmware update operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public struct GipFirmwareUpdateProgress
  {
    /// <summary>Percentage of the operation that is complete.</summary>
    public double PercentCompleted;
    /// <summary>The ID of the current component being updated.</summary>
    public uint CurrentComponentId;
  }
}
