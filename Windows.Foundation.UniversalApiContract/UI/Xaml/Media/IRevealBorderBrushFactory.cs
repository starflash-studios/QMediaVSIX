// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IRevealBorderBrushFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (RevealBorderBrush))]
  [Guid(2495763096, 62968, 17538, 162, 92, 103, 88, 80, 26, 134, 38)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IRevealBorderBrushFactory
  {
    RevealBorderBrush CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
