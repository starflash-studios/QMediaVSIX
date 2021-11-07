// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.Preview.GazeDeviceConfigurationStatePreview
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input.Preview
{
  /// <summary>Specifies the possible configuration states of an eye-tracking device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum GazeDeviceConfigurationStatePreview
  {
    /// <summary>The eye-tracker device state is unknown. Calibration might resolve this state.</summary>
    Unknown,
    /// <summary>The eye-tracker device is ready to start eye and head tracking.</summary>
    Ready,
    /// <summary>The eye-tracker device is currently being configured.</summary>
    Configuring,
    /// <summary>The display device is not configured correctly. Calibration might resolve this state.</summary>
    ScreenSetupNeeded,
    /// <summary>The eye-tracker device needs to be calibrated.</summary>
    UserCalibrationNeeded,
  }
}
