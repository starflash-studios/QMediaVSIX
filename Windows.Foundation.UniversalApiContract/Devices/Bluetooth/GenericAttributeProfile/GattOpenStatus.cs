// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattOpenStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>The status of GattDeviceService.OpenAsync.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum GattOpenStatus
  {
    /// <summary>Unspecified error.</summary>
    Unspecified,
    /// <summary>The GATT device service was successfully opened.</summary>
    Success,
    /// <summary>The GATT device service is already opened.</summary>
    AlreadyOpened,
    /// <summary>The GATT device service was not found.</summary>
    NotFound,
    /// <summary>There was a sharing violation.</summary>
    SharingViolation,
    /// <summary>Access is denied.</summary>
    AccessDenied,
  }
}
