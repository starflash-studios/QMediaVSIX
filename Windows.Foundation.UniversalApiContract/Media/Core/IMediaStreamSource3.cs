// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSource3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1781147462, 15837, 19935, 161, 33, 148, 4, 94, 207, 148, 64)]
  [ExclusiveTo(typeof (MediaStreamSource))]
  internal interface IMediaStreamSource3 : IMediaStreamSource, IMediaSource
  {
    IReference<double> MaxSupportedPlaybackRate { set; get; }
  }
}
