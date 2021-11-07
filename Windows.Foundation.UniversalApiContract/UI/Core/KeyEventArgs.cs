// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.KeyEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Core
{
  /// <summary>Contains the arguments returned by a virtual key event.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class KeyEventArgs : IKeyEventArgs, ICoreWindowEventArgs, IKeyEventArgs2
  {
    /// <summary>Gets the virtual key that maps to the key that was pressed.</summary>
    /// <returns>The virtual key value.</returns>
    public extern VirtualKey VirtualKey { [MethodImpl] get; }

    /// <summary>Gets the status of a key at the time the event is fired.</summary>
    /// <returns>The status of the key.</returns>
    public extern CorePhysicalKeyStatus KeyStatus { [MethodImpl] get; }

    /// <summary>Gets or sets whether the key press event was handled.</summary>
    /// <returns>True if the key press event has been handled by the appropriate delegate; false if it has not.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a unique ID for the input device that generated this key event.</summary>
    /// <returns>A unique identifier for the input device associated with the key event, or an empty string. The same device can be assigned a different ID each time it is connected.</returns>
    public extern string DeviceId { [MethodImpl] get; }
  }
}
