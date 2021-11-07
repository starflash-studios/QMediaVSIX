﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.INavigationViewTemplateSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (NavigationViewTemplateSettings))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  [Guid(693554116, 1320, 21973, 178, 209, 234, 232, 7, 174, 166, 218)]
  internal interface INavigationViewTemplateSettings
  {
    double TopPadding { get; }

    Visibility OverflowButtonVisibility { get; }

    Visibility PaneToggleButtonVisibility { get; }

    Visibility BackButtonVisibility { get; }

    Visibility TopPaneVisibility { get; }

    Visibility LeftPaneVisibility { get; }

    bool SingleSelectionFollowsFocus { get; }
  }
}