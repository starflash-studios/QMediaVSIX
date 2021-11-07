﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITwoPaneView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(458034613, 5293, 22822, 187, 138, 91, 10, 92, 0, 133, 240)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (TwoPaneView))]
  internal interface ITwoPaneView
  {
    UIElement Pane1 { get; set; }

    UIElement Pane2 { get; set; }

    GridLength Pane1Length { get; set; }

    GridLength Pane2Length { get; set; }

    TwoPaneViewPriority PanePriority { get; set; }

    TwoPaneViewMode Mode { get; }

    TwoPaneViewWideModeConfiguration WideModeConfiguration { get; set; }

    TwoPaneViewTallModeConfiguration TallModeConfiguration { get; set; }

    double MinWideModeWidth { get; set; }

    double MinTallModeHeight { get; set; }

    event TypedEventHandler<TwoPaneView, object> ModeChanged;
  }
}