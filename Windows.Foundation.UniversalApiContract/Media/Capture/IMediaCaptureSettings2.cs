// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureSettings2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ExclusiveTo(typeof (MediaCaptureSettings))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1872657659, 64159, 19219, 156, 190, 90, 185, 79, 31, 52, 147)]
  internal interface IMediaCaptureSettings2
  {
    bool ConcurrentRecordAndPhotoSupported { get; }

    bool ConcurrentRecordAndPhotoSequenceSupported { get; }

    bool CameraSoundRequiredForRegion { get; }

    IReference<uint> Horizontal35mmEquivalentFocalLength { get; }

    IReference<int> PitchOffsetDegrees { get; }

    IReference<uint> Vertical35mmEquivalentFocalLength { get; }

    MediaCategory MediaCategory { get; }

    AudioProcessing AudioProcessing { get; }
  }
}
