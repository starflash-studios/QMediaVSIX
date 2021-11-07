﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SwipeItemInvokedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides event data for the SwipeItem.Invoked event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class SwipeItemInvokedEventArgs : ISwipeItemInvokedEventArgs
  {
    /// <summary>Gets the SwipeControl that owns the invoked item.</summary>
    /// <returns>The SwipeControl that owns the invoked item.</returns>
    public extern SwipeControl SwipeControl { [MethodImpl] get; }
  }
}