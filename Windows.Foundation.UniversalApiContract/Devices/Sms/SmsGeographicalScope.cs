// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsGeographicalScope
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  /// <summary>Values that describe the geographical scope of a cell broadcast message.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SmsGeographicalScope
  {
    /// <summary>An undefined or unknown geographical scope.</summary>
    None,
    /// <summary>Scope is a single cell tower, with immediate display.</summary>
    CellWithImmediateDisplay,
    /// <summary>Scope is a Location Area.</summary>
    LocationArea,
    /// <summary>Scope is the entire Public Land Mobile Network (PLMN).</summary>
    Plmn,
    /// <summary>Scope is a single cell tower.</summary>
    Cell,
  }
}
