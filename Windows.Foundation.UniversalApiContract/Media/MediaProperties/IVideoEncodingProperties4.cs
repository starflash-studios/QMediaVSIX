// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IVideoEncodingProperties4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ExclusiveTo(typeof (VideoEncodingProperties))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1917775892, 49420, 16626, 157, 114, 62, 225, 59, 69, 250, 142)]
  internal interface IVideoEncodingProperties4
  {
    SphericalVideoFrameFormat SphericalVideoFrameFormat { get; }
  }
}
