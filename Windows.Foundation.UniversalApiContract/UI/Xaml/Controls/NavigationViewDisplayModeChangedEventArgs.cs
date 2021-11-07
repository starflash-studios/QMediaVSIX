﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.NavigationViewDisplayModeChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides data for the NavigationView.DisplayModeChanged event.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class NavigationViewDisplayModeChangedEventArgs : 
    INavigationViewDisplayModeChangedEventArgs
  {
    /// <summary>Gets the new display mode.</summary>
    /// <returns>The new display mode.</returns>
    public extern NavigationViewDisplayMode DisplayMode { [MethodImpl] get; }
  }
}