﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.RateChangedRoutedEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Represents the method that will handle the RateChanged event. This event fires when PlaybackRate or DefaultPlaybackRate change either via user interaction or from code.</summary>
  /// <param name="sender">The object where the handler is attached.</param>
  /// <param name="e">The event data.</param>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(149529175, 44549, 18587, 136, 57, 40, 198, 34, 93, 35, 73)]
  [WebHostHidden]
  public delegate void RateChangedRoutedEventHandler(object sender, RateChangedRoutedEventArgs e);
}