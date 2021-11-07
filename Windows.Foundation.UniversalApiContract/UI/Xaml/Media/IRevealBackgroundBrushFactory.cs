// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IRevealBackgroundBrushFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [Guid(2354494634, 677, 20293, 133, 6, 141, 57, 34, 143, 93, 63)]
  [ExclusiveTo(typeof (RevealBackgroundBrush))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IRevealBackgroundBrushFactory
  {
    RevealBackgroundBrush CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
