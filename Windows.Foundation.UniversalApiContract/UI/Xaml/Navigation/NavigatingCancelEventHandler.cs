﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Navigation.NavigatingCancelEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Navigation
{
  /// <summary>Represents the method to use as the OnNavigatingFrom callback override.</summary>
  /// <param name="sender">The object where the method is implemented.</param>
  /// <param name="e">Event data that is passed through the callback.</param>
  [Guid(1977001871, 41730, 17545, 152, 152, 36, 234, 73, 24, 41, 16)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public delegate void NavigatingCancelEventHandler(object sender, NavigatingCancelEventArgs e);
}