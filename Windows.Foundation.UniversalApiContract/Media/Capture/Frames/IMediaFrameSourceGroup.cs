// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IMediaFrameSourceGroup
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  [Guid(2137021319, 18482, 19295, 174, 61, 65, 47, 170, 179, 125, 52)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaFrameSourceGroup))]
  internal interface IMediaFrameSourceGroup
  {
    string Id { get; }

    string DisplayName { get; }

    IVectorView<MediaFrameSourceInfo> SourceInfos { get; }
  }
}
