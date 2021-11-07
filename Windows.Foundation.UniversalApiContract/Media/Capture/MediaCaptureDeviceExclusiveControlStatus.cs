// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.MediaCaptureDeviceExclusiveControlStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  /// <summary>Specifies the exclusive control status of the media capture device. Exclusive control is required to modify the settings of the capture device, but is not required to obtain media frames from the device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum MediaCaptureDeviceExclusiveControlStatus
  {
    /// <summary>The current app can initialize the capture device with exclusive control.</summary>
    ExclusiveControlAvailable,
    /// <summary>Another app has exclusive control of the capture device, so the current app can't obtain exclusive control.</summary>
    SharedReadOnlyAvailable,
  }
}
