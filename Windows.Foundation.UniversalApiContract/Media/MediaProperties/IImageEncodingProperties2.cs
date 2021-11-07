// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IImageEncodingProperties2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(3360989919, 51491, 18075, 172, 142, 106, 159, 60, 28, 217, 227)]
  [ExclusiveTo(typeof (ImageEncodingProperties))]
  internal interface IImageEncodingProperties2
  {
    ImageEncodingProperties Copy();
  }
}
