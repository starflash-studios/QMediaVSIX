// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IGradientBrushFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Guid(3980884426, 17853, 16689, 182, 37, 190, 134, 224, 124, 97, 18)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (GradientBrush))]
  [WebHostHidden]
  internal interface IGradientBrushFactory
  {
    GradientBrush CreateInstance(object baseInterface, out object innerInterface);
  }
}
