// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IVideoStreamDescriptorFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1229911761, 47989, 17362, 158, 94, 123, 121, 163, 175, 206, 212)]
  [ExclusiveTo(typeof (VideoStreamDescriptor))]
  internal interface IVideoStreamDescriptorFactory
  {
    VideoStreamDescriptor Create(VideoEncodingProperties encodingProperties);
  }
}
