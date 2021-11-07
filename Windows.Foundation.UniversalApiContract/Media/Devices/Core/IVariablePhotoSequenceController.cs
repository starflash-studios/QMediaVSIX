// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.IVariablePhotoSequenceController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Devices.Core
{
  [ExclusiveTo(typeof (VariablePhotoSequenceController))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2143287424, 60812, 17405, 167, 195, 179, 88, 9, 228, 34, 154)]
  internal interface IVariablePhotoSequenceController
  {
    bool Supported { get; }

    float MaxPhotosPerSecond { get; }

    float PhotosPerSecondLimit { get; set; }

    MediaRatio GetHighestConcurrentFrameRate(IMediaEncodingProperties captureProperties);

    MediaRatio GetCurrentFrameRate();

    FrameControlCapabilities FrameCapabilities { get; }

    IVector<FrameController> DesiredFrameControllers { get; }
  }
}
