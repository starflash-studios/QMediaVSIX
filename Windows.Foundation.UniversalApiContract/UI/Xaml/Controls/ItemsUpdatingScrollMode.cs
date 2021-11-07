﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ItemsUpdatingScrollMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify the scrolling behavior of items while updating.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ItemsUpdatingScrollMode
  {
    /// <summary>Adjusts the scroll offset to keep the first visible item in the viewport when items are added to the ItemsSource.</summary>
    KeepItemsInView,
    /// <summary>Maintains the scroll offset relative to the beginning of the list, forcing items in the viewport to move down when items are added to the ItemsSource.</summary>
    KeepScrollOffset,
    /// <summary>Adjusts the scroll offset to keep the last visible item in the viewport when items are added to the ItemsSource.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] KeepLastItemInView,
  }
}