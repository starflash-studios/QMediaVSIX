// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IMediaFrameFormat2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Capture.Frames
{
  [Guid(1669686080, 24199, 19472, 134, 209, 109, 240, 151, 166, 198, 168)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (MediaFrameFormat))]
  internal interface IMediaFrameFormat2
  {
    AudioEncodingProperties AudioEncodingProperties { get; }
  }
}
