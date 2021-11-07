// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IVideoEncodingPropertiesStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ExclusiveTo(typeof (VideoEncodingProperties))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3474898269, 18942, 19712, 181, 154, 207, 164, 223, 197, 25, 68)]
  internal interface IVideoEncodingPropertiesStatics2
  {
    VideoEncodingProperties CreateHevc();
  }
}
