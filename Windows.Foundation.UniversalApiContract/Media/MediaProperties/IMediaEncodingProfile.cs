// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IMediaEncodingProfile
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3889952168, 7609, 18307, 135, 107, 61, 254, 18, 172, 253, 179)]
  [ExclusiveTo(typeof (MediaEncodingProfile))]
  internal interface IMediaEncodingProfile
  {
    AudioEncodingProperties Audio { set; get; }

    VideoEncodingProperties Video { set; get; }

    ContainerEncodingProperties Container { set; get; }
  }
}
