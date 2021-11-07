// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IRevealBrushStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (RevealBrush))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(420423205, 29193, 19778, 168, 71, 26, 196, 187, 187, 52, 153)]
  internal interface IRevealBrushStatics
  {
    DependencyProperty ColorProperty { get; }

    DependencyProperty TargetThemeProperty { get; }

    DependencyProperty AlwaysUseFallbackProperty { get; }

    DependencyProperty StateProperty { get; }

    void SetState(UIElement element, RevealBrushState value);

    RevealBrushState GetState(UIElement element);
  }
}
