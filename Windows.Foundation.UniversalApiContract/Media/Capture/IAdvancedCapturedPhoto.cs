// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IAdvancedCapturedPhoto
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Devices;

namespace Windows.Media.Capture
{
  [Guid(4034032267, 45714, 17553, 157, 65, 153, 128, 122, 85, 11, 191)]
  [ExclusiveTo(typeof (AdvancedCapturedPhoto))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAdvancedCapturedPhoto
  {
    CapturedFrame Frame { get; }

    AdvancedPhotoMode Mode { get; }

    object Context { get; }
  }
}
