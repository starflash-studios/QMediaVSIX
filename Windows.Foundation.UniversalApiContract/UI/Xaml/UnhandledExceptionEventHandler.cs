﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.UnhandledExceptionEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Represents the method that will handle the UnhandledException event.</summary>
  /// <param name="sender">The object where the handler is attached.</param>
  /// <param name="e">Event data.</param>
  [Guid(2457134781, 18849, 18776, 190, 238, 208, 225, 149, 135, 182, 227)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public delegate void UnhandledExceptionEventHandler(object sender, UnhandledExceptionEventArgs e);
}