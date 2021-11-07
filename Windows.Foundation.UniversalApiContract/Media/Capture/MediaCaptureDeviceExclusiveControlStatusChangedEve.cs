// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.MediaCaptureDeviceExclusiveControlStatusChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  /// <summary>Provides data for the MediaCapture.CaptureDeviceExclusiveControlStatusChanged event.</summary>
  [DualApiPartition(version = 167772163)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class MediaCaptureDeviceExclusiveControlStatusChangedEventArgs : 
    IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs
  {
    /// <summary>Gets the device ID for the capture device for which exlusive control status has changed.</summary>
    /// <returns>The device ID for the capture device for which exlusive control status has changed.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether exclusive control of the capture device specified with the DeviceID property is available to the current app.</summary>
    /// <returns>A value indicating whether exclusive control of the device is available or if the device can only be accessed in shared mode.</returns>
    public extern MediaCaptureDeviceExclusiveControlStatus Status { [MethodImpl] get; }
  }
}
