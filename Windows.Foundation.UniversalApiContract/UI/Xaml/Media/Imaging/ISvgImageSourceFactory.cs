// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.ISvgImageSourceFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (SvgImageSource))]
  [WebHostHidden]
  [Guid(3348425191, 53027, 19826, 191, 26, 223, 170, 22, 216, 234, 82)]
  internal interface ISvgImageSourceFactory
  {
    SvgImageSource CreateInstance(object baseInterface, out object innerInterface);

    SvgImageSource CreateInstanceWithUriSource(
      Uri uriSource,
      object baseInterface,
      out object innerInterface);
  }
}
