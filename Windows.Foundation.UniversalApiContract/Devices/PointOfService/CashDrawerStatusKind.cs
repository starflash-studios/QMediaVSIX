// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.CashDrawerStatusKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Defines the constants that indicate the cash drawer power status.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CashDrawerStatusKind
  {
    /// <summary>The device is powered on and ready to use.</summary>
    Online,
    /// <summary>The device is powered off or detached from the terminal.</summary>
    Off,
    /// <summary>The device is powered on but is not available to respond to requests.</summary>
    Offline,
    /// <summary>The device is either off or offline, but the current state can not be distinguished.</summary>
    OffOrOffline,
    /// <summary>The device status is not any of the above states. This is available so a POS driver can provide custom notifications to the app.</summary>
    Extended,
  }
}
