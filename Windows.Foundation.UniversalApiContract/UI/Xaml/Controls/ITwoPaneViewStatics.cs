// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITwoPaneViewStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1513472905, 34244, 22004, 171, 177, 151, 69, 27, 195, 45, 113)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (TwoPaneView))]
  [WebHostHidden]
  internal interface ITwoPaneViewStatics
  {
    DependencyProperty Pane1Property { get; }

    DependencyProperty Pane2Property { get; }

    DependencyProperty Pane1LengthProperty { get; }

    DependencyProperty Pane2LengthProperty { get; }

    DependencyProperty PanePriorityProperty { get; }

    DependencyProperty ModeProperty { get; }

    DependencyProperty WideModeConfigurationProperty { get; }

    DependencyProperty TallModeConfigurationProperty { get; }

    DependencyProperty MinWideModeWidthProperty { get; }

    DependencyProperty MinTallModeHeightProperty { get; }
  }
}
