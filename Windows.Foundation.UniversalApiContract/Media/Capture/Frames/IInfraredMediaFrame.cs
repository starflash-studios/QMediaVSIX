// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IInfraredMediaFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  [Guid(1070675203, 75, 20238, 145, 172, 70, 82, 153, 180, 22, 88)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (InfraredMediaFrame))]
  internal interface IInfraredMediaFrame
  {
    MediaFrameReference FrameReference { get; }

    VideoMediaFrame VideoMediaFrame { get; }

    bool IsIlluminated { get; }
  }
}
