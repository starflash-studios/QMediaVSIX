﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.ManipulationStartingEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Represents the method that will handle the ManipulationStarting event.</summary>
  /// <param name="sender">The object where the event handler is attached.</param>
  /// <param name="e">Event data for the event.</param>
  [Guid(282112078, 49124, 17099, 130, 60, 63, 236, 216, 119, 14, 248)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public delegate void ManipulationStartingEventHandler(
    object sender,
    ManipulationStartingRoutedEventArgs e);
}