// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.UnifiedPosErrorReason
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Defines the constants that indicates the reason for the error event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum UnifiedPosErrorReason
  {
    /// <summary>Unknown reason.</summary>
    UnknownErrorReason,
    /// <summary>Cannot communicate with the device, possibly due to a configuration error.</summary>
    NoService,
    /// <summary>The device is not enabled.</summary>
    Disabled,
    /// <summary>The operation is not supported or not available on the device.</summary>
    Illegal,
    /// <summary>The device is not connected or not powered on.</summary>
    NoHardware,
    /// <summary>The device is closed.</summary>
    Closed,
    /// <summary>The device is offline.</summary>
    Offline,
    /// <summary>The operation failed although the device was connected and powered on.</summary>
    Failure,
    /// <summary>The operation timed out while waiting for a response from the device.</summary>
    Timeout,
    /// <summary>The device is busy.</summary>
    Busy,
    /// <summary>The operation failed and returned a vendor specific error information.</summary>
    Extended,
  }
}
