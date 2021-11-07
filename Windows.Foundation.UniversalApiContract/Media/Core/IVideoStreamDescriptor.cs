// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IVideoStreamDescriptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VideoStreamDescriptor))]
  [Guid(317590869, 39979, 17472, 128, 87, 44, 122, 144, 240, 203, 236)]
  internal interface IVideoStreamDescriptor : IMediaStreamDescriptor
  {
    VideoEncodingProperties EncodingProperties { get; }
  }
}
