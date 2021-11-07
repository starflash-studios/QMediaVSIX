// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IVideoTrackSupportInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (VideoTrackSupportInfo))]
  [Guid(1270166688, 64607, 17677, 143, 240, 119, 141, 89, 4, 134, 222)]
  internal interface IVideoTrackSupportInfo
  {
    MediaDecoderStatus DecoderStatus { get; }

    MediaSourceStatus MediaSourceStatus { get; }
  }
}
