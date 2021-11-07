﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.INavigationViewStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(909805255, 29402, 17440, 184, 113, 21, 217, 208, 212, 87, 86)]
  [ExclusiveTo(typeof (NavigationView))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface INavigationViewStatics
  {
    DependencyProperty IsPaneOpenProperty { get; }

    DependencyProperty CompactModeThresholdWidthProperty { get; }

    DependencyProperty ExpandedModeThresholdWidthProperty { get; }

    DependencyProperty PaneFooterProperty { get; }

    DependencyProperty HeaderProperty { get; }

    DependencyProperty HeaderTemplateProperty { get; }

    DependencyProperty DisplayModeProperty { get; }

    DependencyProperty IsSettingsVisibleProperty { get; }

    DependencyProperty IsPaneToggleButtonVisibleProperty { get; }

    DependencyProperty AlwaysShowHeaderProperty { get; }

    DependencyProperty CompactPaneLengthProperty { get; }

    DependencyProperty OpenPaneLengthProperty { get; }

    DependencyProperty PaneToggleButtonStyleProperty { get; }

    DependencyProperty MenuItemsProperty { get; }

    DependencyProperty MenuItemsSourceProperty { get; }

    DependencyProperty SelectedItemProperty { get; }

    DependencyProperty SettingsItemProperty { get; }

    DependencyProperty AutoSuggestBoxProperty { get; }

    DependencyProperty MenuItemTemplateProperty { get; }

    DependencyProperty MenuItemTemplateSelectorProperty { get; }

    DependencyProperty MenuItemContainerStyleProperty { get; }

    DependencyProperty MenuItemContainerStyleSelectorProperty { get; }
  }
}