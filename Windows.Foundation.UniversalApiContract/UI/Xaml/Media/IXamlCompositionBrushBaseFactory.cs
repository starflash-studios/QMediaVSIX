// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IXamlCompositionBrushBaseFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [ExclusiveTo(typeof (XamlCompositionBrushBase))]
  [Guid(961480739, 9297, 20184, 189, 36, 72, 129, 73, 179, 66, 141)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IXamlCompositionBrushBaseFactory
  {
    XamlCompositionBrushBase CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
