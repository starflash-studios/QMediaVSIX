// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.KeyRoutedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.Core;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Provides event data for the KeyUp and KeyDown routed events.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class KeyRoutedEventArgs : 
    RoutedEventArgs,
    IKeyRoutedEventArgs,
    IKeyRoutedEventArgs2,
    IKeyRoutedEventArgs3
  {
    /// <summary>Gets the virtual key associated with the event.</summary>
    /// <returns>A system value that indicates the code for the key referenced by the event.</returns>
    public extern VirtualKey Key { [MethodImpl] get; }

    /// <summary>Gets a structure value that reports various system-detected characteristics of the key press, including repeat count and menu status.</summary>
    /// <returns>A structure value with flags that report status.</returns>
    public extern CorePhysicalKeyStatus KeyStatus { [MethodImpl] get; }

    /// <summary>Gets or sets a value that marks the routed event as handled. A **true** value for **Handled** prevents most handlers along the event route from handling the same event again.</summary>
    /// <returns>**true** to mark the routed event handled; **false** to leave the routed event unhandled, which permits the event to potentially route further. The default is **false**.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the original, unmapped virtual key associated with the event.</summary>
    /// <returns>A system value that indicates the code for the key referenced by the event.</returns>
    public extern VirtualKey OriginalKey { [MethodImpl] get; }

    /// <summary>Gets a unique ID for the input device that generated this key event.</summary>
    /// <returns>A unique identifier for the input device associated with the key event, or an empty string for an unsupported device. The same device can be assigned a different ID each time it is connected.</returns>
    public extern string DeviceId { [MethodImpl] get; }
  }
}
