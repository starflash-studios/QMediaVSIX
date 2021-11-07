// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IMediaFrameSourceInfo2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  [ExclusiveTo(typeof (MediaFrameSourceInfo))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(425359445, 25687, 17094, 167, 105, 25, 182, 91, 211, 46, 110)]
  internal interface IMediaFrameSourceInfo2
  {
    string ProfileId { get; }

    IVectorView<MediaCaptureVideoProfileMediaDescription> VideoProfileMediaDescription { get; }
  }
}
