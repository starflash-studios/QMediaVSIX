// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.ProcessKeyboardAcceleratorEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Provides event data for the ProcessKeyboardAccelerators event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public sealed class ProcessKeyboardAcceleratorEventArgs : IProcessKeyboardAcceleratorEventArgs
  {
    /// <summary>Gets the virtual key (used in conjunction with one or more modifier keys) for a keyboard shortcut (accelerator).</summary>
    /// <returns>The virtual key.</returns>
    public extern VirtualKey Key { [MethodImpl] get; }

    /// <summary>Gets the virtual key used to modify another keypress for a keyboard shortcut (accelerator). </summary>
    /// <returns>The virtual key.</returns>
    public extern VirtualKeyModifiers Modifiers { [MethodImpl] get; }

    /// <summary>Gets or sets a value that marks the event as handled.</summary>
    /// <returns>**true** to mark the event handled. **false** to leave the event unhandled. The default is **false**.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }
  }
}
