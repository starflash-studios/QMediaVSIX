// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IXamlCompositionBrushBase
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (XamlCompositionBrushBase))]
  [WebHostHidden]
  [Guid(65286873, 45916, 19065, 129, 28, 197, 101, 32, 4, 218, 14)]
  internal interface IXamlCompositionBrushBase
  {
    Color FallbackColor { get; set; }
  }
}
