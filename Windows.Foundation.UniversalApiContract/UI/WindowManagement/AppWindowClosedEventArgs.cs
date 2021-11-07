﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.AppWindowClosedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  /// <summary>Provides data for the AppWindow.Closed event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public sealed class AppWindowClosedEventArgs : IAppWindowClosedEventArgs
  {
    /// <summary>Gets a value that indicates how the closing of the app window was initiated.</summary>
    /// <returns>A value of the enumeration that indicates how the closing of the app window was initiated.</returns>
    public extern AppWindowClosedReason Reason { [MethodImpl] get; }
  }
}