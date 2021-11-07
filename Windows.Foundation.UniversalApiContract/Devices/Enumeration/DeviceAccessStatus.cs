// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DeviceAccessStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  /// <summary>Indicates the status of the access to a device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum DeviceAccessStatus
  {
    /// <summary>The device access is not specified.</summary>
    Unspecified,
    /// <summary>Access to the device is allowed.</summary>
    Allowed,
    /// <summary>Access to the device has been disallowed by the user.</summary>
    DeniedByUser,
    /// <summary>Access to the device has been disallowed by the system.</summary>
    DeniedBySystem,
  }
}
