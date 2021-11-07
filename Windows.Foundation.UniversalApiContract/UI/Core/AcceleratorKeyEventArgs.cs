// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.AcceleratorKeyEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Core
{
  /// <summary>Provides the arguments returned by an accelerator key event callback.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class AcceleratorKeyEventArgs : 
    IAcceleratorKeyEventArgs,
    ICoreWindowEventArgs,
    IAcceleratorKeyEventArgs2
  {
    /// <summary>Gets the type of the accelerator key event that invoked the callback.</summary>
    /// <returns>The type of the accelerator key event that invoked the callback.</returns>
    public extern CoreAcceleratorKeyEventType EventType { [MethodImpl] get; }

    /// <summary>Gets the virtual key code for the keypress in the accelerator key event.</summary>
    /// <returns>The virtual key code of the key that was pressed.</returns>
    public extern VirtualKey VirtualKey { [MethodImpl] get; }

    /// <summary>Gets the status of the accelerator key for which the event was raised.</summary>
    /// <returns>The status of the accelerator key.</returns>
    public extern CorePhysicalKeyStatus KeyStatus { [MethodImpl] get; }

    /// <summary>Gets or sets whether the accelerator key event was handled or not.</summary>
    /// <returns>True if the accelerator key event has been handled; false if it has not.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a unique ID for the input device that generated this key event.</summary>
    /// <returns>A unique identifier for the input device associated with the key event, or an empty string. The same device can be assigned a different ID each time it is connected.</returns>
    public extern string DeviceId { [MethodImpl] get; }
  }
}
