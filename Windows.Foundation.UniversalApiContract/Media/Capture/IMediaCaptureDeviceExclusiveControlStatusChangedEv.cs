// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [Guid(2637140493, 42376, 17350, 137, 214, 90, 211, 34, 175, 0, 106)]
  [ExclusiveTo(typeof (MediaCaptureDeviceExclusiveControlStatusChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IMediaCaptureDeviceExclusiveControlStatusChangedEventArgs
  {
    string DeviceId { get; }

    MediaCaptureDeviceExclusiveControlStatus Status { get; }
  }
}
