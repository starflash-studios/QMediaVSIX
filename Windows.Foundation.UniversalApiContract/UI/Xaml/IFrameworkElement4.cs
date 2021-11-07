// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IFrameworkElement4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml
{
  [Guid(1802918835, 64419, 17412, 189, 238, 26, 69, 209, 202, 95, 33)]
  [ExclusiveTo(typeof (FrameworkElement))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IFrameworkElement4
  {
    bool AllowFocusOnInteraction { get; set; }

    Thickness FocusVisualMargin { get; set; }

    Thickness FocusVisualSecondaryThickness { get; set; }

    Thickness FocusVisualPrimaryThickness { get; set; }

    Brush FocusVisualSecondaryBrush { get; set; }

    Brush FocusVisualPrimaryBrush { get; set; }

    bool AllowFocusWhenDisabled { get; set; }
  }
}
