// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.LosingFocusEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Provides data for the FocusManager.LosingFocus and UIElement.LosingFocus events.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  public sealed class LosingFocusEventArgs : 
    RoutedEventArgs,
    ILosingFocusEventArgs,
    ILosingFocusEventArgs2,
    ILosingFocusEventArgs3
  {
    /// <summary>Gets the last focused object.</summary>
    /// <returns>The last focused object.</returns>
    public extern DependencyObject OldFocusedElement { [MethodImpl] get; }

    /// <summary>Gets the most recent focused object.</summary>
    /// <returns>The most recent focused object.</returns>
    public extern DependencyObject NewFocusedElement { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the input mode through which an element obtained focus.</summary>
    /// <returns>How the element obtained focus.</returns>
    public extern FocusState FocusState { [MethodImpl] get; }

    /// <summary>Gets the direction that focus moved from element to element within the app UI.</summary>
    /// <returns>The direction of focus movement.</returns>
    public extern FocusNavigationDirection Direction { [MethodImpl] get; }

    /// <summary>Gets or sets a value that marks the routed event as handled. A **true** value for **Handled** prevents most handlers along the event route from handling the same event again.</summary>
    /// <returns>**true** to mark the routed event handled. **false** to leave the routed event unhandled, which permits the event to potentially route further and be acted on by other handlers. The default is **false**.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the input device type from which input events are received.</summary>
    /// <returns>The input device type.</returns>
    public extern FocusInputDeviceKind InputDevice { [MethodImpl] get; }

    /// <summary>Gets or sets whether focus navigation should be canceled.</summary>
    /// <returns>**true** if focus navigation should be canceled. Otherwise, **false**.</returns>
    public extern bool Cancel { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Attempts to cancel the ongoing focus action.</summary>
    /// <returns>True, if the focus action is canceled; otherwise, false.</returns>
    [MethodImpl]
    public extern bool TryCancel();

    /// <summary>Attempts to redirect focus from the targeted element to the specified element.</summary>
    /// <param name="element">The object on which to set focus.</param>
    /// <returns>True, if the focus action is redirected; otherwise, false.</returns>
    [MethodImpl]
    public extern bool TrySetNewFocusedElement(DependencyObject element);

    /// <summary>Gets the unique ID generated when a focus movement event is initiated.</summary>
    /// <returns>The unique ID, if any. Otherwise, **null**.</returns>
    public extern Guid CorrelationId { [MethodImpl] get; }
  }
}
