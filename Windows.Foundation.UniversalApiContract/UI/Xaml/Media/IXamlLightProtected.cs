// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IXamlLightProtected
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1590632971, 4690, 17360, 151, 41, 110, 166, 146, 4, 104, 56)]
  [WebHostHidden]
  [ExclusiveTo(typeof (XamlLight))]
  internal interface IXamlLightProtected
  {
    CompositionLight CompositionLight { get; set; }
  }
}
