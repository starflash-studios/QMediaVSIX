// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.PointerEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.Input;

namespace Windows.UI.Core
{
  /// <summary>Contains the arguments returned by the last pointer event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class PointerEventArgs : IPointerEventArgs, ICoreWindowEventArgs
  {
    /// <summary>Gets the pointer data of the last pointer event.</summary>
    /// <returns>Information about the state and screen position of the pointer.</returns>
    public extern PointerPoint CurrentPoint { [MethodImpl] get; }

    /// <summary>Gets the keyboard key or keys used to modify the pointer input, such as the "Ctrl" key when pressed in conjunction with another key, as in Ctrl+C.</summary>
    /// <returns>The active key modifiers.</returns>
    public extern VirtualKeyModifiers KeyModifiers { [MethodImpl] get; }

    /// <summary>Retrieves the pointer data for up to the last 64 pointer locations since the last pointer event.</summary>
    /// <returns>The data for each pointer.</returns>
    [MethodImpl]
    public extern IVector<PointerPoint> GetIntermediatePoints();

    /// <summary>Gets or sets whether the pointer event was handled.</summary>
    /// <returns>True if the pointer event has been handled by the appropriate delegate; false if it has not.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }
  }
}
