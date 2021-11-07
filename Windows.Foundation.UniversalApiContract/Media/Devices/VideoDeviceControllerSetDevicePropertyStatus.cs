// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.VideoDeviceControllerSetDevicePropertyStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Specifies the status of an operation to set the value of a video device controller driver property.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum VideoDeviceControllerSetDevicePropertyStatus
  {
    /// <summary>The operation completed successfully.</summary>
    Success,
    /// <summary>The operation failed due to an unknown failure.</summary>
    UnknownFailure,
    /// <summary>The operation failed because the specified property is not supported by the device.</summary>
    NotSupported,
    /// <summary>The operation failed because the specified property value is invalid.</summary>
    InvalidValue,
    /// <summary>The operation failed because the device is not available.</summary>
    DeviceNotAvailable,
    /// <summary>The operation failed because the app does not have exclusive control of the video capture device and is therefore not currently permitted to change the device settings. For more information, see MediaCaptureInitializationSettings.SharingMode.</summary>
    NotInControl,
  }
}
