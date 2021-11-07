// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.VisibilityChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  /// <summary>Contains the arguments returned by the event fired when a CoreWindow instance's visibility changes.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class VisibilityChangedEventArgs : IVisibilityChangedEventArgs, ICoreWindowEventArgs
  {
    /// <summary>Gets whether the window is visible or not.</summary>
    /// <returns>True if the window is visible; otherwise, false.</returns>
    public extern bool Visible { [MethodImpl] get; }

    /// <summary>Gets or sets a value indicating whether the VisibilityChanged event was handled.</summary>
    /// <returns>True if the event is handled; otherwise, false.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }
  }
}
