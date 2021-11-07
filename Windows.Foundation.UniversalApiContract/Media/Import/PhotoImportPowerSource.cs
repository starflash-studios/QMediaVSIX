// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportPowerSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  /// <summary>Specifies the current power source of the source device containing items to be imported.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PhotoImportPowerSource
  {
    /// <summary>The current power source is unknown.</summary>
    Unknown,
    /// <summary>The current power source is a battery.</summary>
    Battery,
    /// <summary>The current power source is external.</summary>
    External,
  }
}
