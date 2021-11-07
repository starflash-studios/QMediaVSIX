// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.VideoDeviceControllerGetDevicePropertyStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Specifies the status of an operation to get the value of a video device controller driver property.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum VideoDeviceControllerGetDevicePropertyStatus
  {
    /// <summary>The operation completed successfully.</summary>
    Success,
    /// <summary>The operation failed due to an unknown failure.</summary>
    UnknownFailure,
    /// <summary>The operation failed because the buffer containing the extended ID data for the property was smaller than expected by the device driver.</summary>
    BufferTooSmall,
    /// <summary>The operation failed because the specified property is not supported by the device.</summary>
    NotSupported,
    /// <summary>The operation failed because the device is not available.</summary>
    DeviceNotAvailable,
    /// <summary>The operation failed because the specified maximum property value size is too small for the property value. You can retry the operation with a larger maximum property value size.</summary>
    MaxPropertyValueSizeTooSmall,
    /// <summary>The operation failed because a maximum property value size is required for the specified property.</summary>
    MaxPropertyValueSizeRequired,
  }
}
