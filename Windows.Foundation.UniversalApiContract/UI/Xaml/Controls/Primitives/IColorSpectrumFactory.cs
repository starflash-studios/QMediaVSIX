// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IColorSpectrumFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [Guid(2429019678, 36941, 17067, 180, 79, 230, 141, 191, 12, 222, 233)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (ColorSpectrum))]
  internal interface IColorSpectrumFactory
  {
    ColorSpectrum CreateInstance(object baseInterface, out object innerInterface);
  }
}
