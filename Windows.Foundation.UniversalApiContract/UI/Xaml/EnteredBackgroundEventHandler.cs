﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.EnteredBackgroundEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Represents the method that will handle the Application.EnteredBackground event.</summary>
  /// <param name="sender">The object where the handler is attached.</param>
  /// <param name="e">Event data for the event.</param>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2477348526, 7551, 17291, 183, 184, 34, 125, 150, 182, 9, 192)]
  public delegate void EnteredBackgroundEventHandler(object sender, EnteredBackgroundEventArgs e);
}