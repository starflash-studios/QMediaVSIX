// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IVideoEncodingProperties3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(946589124, 34618, 18335, 179, 235, 86, 193, 252, 190, 198, 215)]
  [ExclusiveTo(typeof (VideoEncodingProperties))]
  internal interface IVideoEncodingProperties3
  {
    StereoscopicVideoPackingMode StereoscopicVideoPackingMode { get; }
  }
}
