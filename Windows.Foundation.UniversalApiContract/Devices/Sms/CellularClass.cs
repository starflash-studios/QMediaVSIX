// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.CellularClass
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  /// <summary>This enumerated type defines the type of radio standard in a device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CellularClass
  {
    /// <summary>The device type corresponds to no cellular class.</summary>
    None,
    /// <summary>The device type is GSM cellular class.</summary>
    Gsm,
    /// <summary>The device type is CDMA cellular class.</summary>
    Cdma,
  }
}
