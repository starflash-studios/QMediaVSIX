// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IAdvancedVideoCaptureDeviceController3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Devices.Core;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (VideoDeviceController))]
  [Guid(2844495668, 60941, 18188, 185, 240, 66, 41, 196, 187, 208, 137)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAdvancedVideoCaptureDeviceController3
  {
    VariablePhotoSequenceController VariablePhotoSequenceController { get; }

    PhotoConfirmationControl PhotoConfirmationControl { get; }

    ZoomControl ZoomControl { get; }
  }
}
