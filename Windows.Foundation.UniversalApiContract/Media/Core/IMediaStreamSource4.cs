// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSource4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(487390379, 33549, 16764, 163, 169, 36, 84, 253, 100, 21, 199)]
  [ExclusiveTo(typeof (MediaStreamSource))]
  internal interface IMediaStreamSource4 : IMediaStreamSource, IMediaSource
  {
    bool IsLive { set; get; }
  }
}
