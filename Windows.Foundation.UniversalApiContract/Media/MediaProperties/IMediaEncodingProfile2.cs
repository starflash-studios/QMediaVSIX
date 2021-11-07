// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IMediaEncodingProfile2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.MediaProperties
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (MediaEncodingProfile))]
  [Guid(882589194, 16437, 18574, 152, 119, 133, 99, 40, 101, 237, 16)]
  internal interface IMediaEncodingProfile2
  {
    void SetAudioTracks(IIterable<AudioStreamDescriptor> value);

    IVector<AudioStreamDescriptor> GetAudioTracks();

    void SetVideoTracks(IIterable<VideoStreamDescriptor> value);

    IVector<VideoStreamDescriptor> GetVideoTracks();
  }
}
