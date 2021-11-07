// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.KeyboardAcceleratorInvokedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Provides event data for the Invoked event.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class KeyboardAcceleratorInvokedEventArgs : 
    IKeyboardAcceleratorInvokedEventArgs,
    IKeyboardAcceleratorInvokedEventArgs2
  {
    /// <summary>Gets or sets a value that marks the event as handled.</summary>
    /// <returns>**true** to mark the event handled; **false** to leave the event unhandled, which permits the event to potentially route further. The default is **false**.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the object associated with the keyboard shortcut (or accelerator).</summary>
    /// <returns>A reference to the object associated with the keyboard shortcut (or accelerator).</returns>
    public extern DependencyObject Element { [MethodImpl] get; }

    /// <summary>Gets the keyboard shortcut (or accelerator) object associated with the Invoked event.</summary>
    /// <returns>
    /// </returns>
    public extern KeyboardAccelerator KeyboardAccelerator { [MethodImpl] get; }
  }
}
