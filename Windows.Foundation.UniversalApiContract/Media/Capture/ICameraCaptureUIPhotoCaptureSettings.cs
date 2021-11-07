// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.ICameraCaptureUIPhotoCaptureSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ExclusiveTo(typeof (CameraCaptureUIPhotoCaptureSettings))]
  [Guid(3119890071, 13426, 18088, 138, 158, 4, 206, 66, 204, 201, 125)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICameraCaptureUIPhotoCaptureSettings
  {
    CameraCaptureUIPhotoFormat Format { get; set; }

    CameraCaptureUIMaxPhotoResolution MaxResolution { get; set; }

    Size CroppedSizeInPixels { get; set; }

    Size CroppedAspectRatio { get; set; }

    bool AllowCropping { get; set; }
  }
}
