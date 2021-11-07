// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IVideoEncodingProperties5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (VideoEncodingProperties))]
  [Guid(1230571535, 10031, 20174, 164, 223, 192, 204, 219, 51, 216, 64)]
  internal interface IVideoEncodingProperties5
  {
    VideoEncodingProperties Copy();
  }
}
