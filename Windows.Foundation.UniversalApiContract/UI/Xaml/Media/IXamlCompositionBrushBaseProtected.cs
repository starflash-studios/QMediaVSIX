// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IXamlCompositionBrushBaseProtected
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(353629144, 1111, 19996, 173, 119, 17, 193, 217, 135, 151, 67)]
  [ExclusiveTo(typeof (XamlCompositionBrushBase))]
  internal interface IXamlCompositionBrushBaseProtected
  {
    CompositionBrush CompositionBrush { get; set; }
  }
}
