// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IVideoMediaFrameFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  [Guid(1174568896, 55067, 17863, 143, 20, 109, 154, 10, 230, 4, 228)]
  [ExclusiveTo(typeof (VideoMediaFrameFormat))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IVideoMediaFrameFormat
  {
    MediaFrameFormat MediaFrameFormat { get; }

    DepthMediaFrameFormat DepthFormat { get; }

    uint Width { get; }

    uint Height { get; }
  }
}
