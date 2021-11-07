// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IImageEncodingPropertiesStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [Guid(1223983437, 41727, 18652, 142, 160, 233, 6, 128, 102, 54, 86)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (ImageEncodingProperties))]
  internal interface IImageEncodingPropertiesStatics3
  {
    ImageEncodingProperties CreateHeif();
  }
}
