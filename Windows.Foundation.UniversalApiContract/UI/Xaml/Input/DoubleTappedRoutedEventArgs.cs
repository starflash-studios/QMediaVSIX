// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Provides event data for the DoubleTapped event.</summary>
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class DoubleTappedRoutedEventArgs : RoutedEventArgs, IDoubleTappedRoutedEventArgs
  {
    /// <summary>Initializes a new instance of the DoubleTappedRoutedEventArgs class.</summary>
    [MethodImpl]
    public extern DoubleTappedRoutedEventArgs();

    /// <summary>Gets the PointerDeviceType for the pointer device that initiated the associated input event.</summary>
    /// <returns>The PointerDeviceType for this event occurrence.</returns>
    public extern PointerDeviceType PointerDeviceType { [MethodImpl] get; }

    /// <summary>Gets or sets a value that marks the routed event as handled. A **true** value for **Handled** prevents most handlers along the event route from handling the same event again.</summary>
    /// <returns>**true** to mark the routed event handled. **false** to leave the routed event unhandled, which permits the event to potentially route further and be acted on by other handlers. The default is **false**.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Returns the x- and y-coordinates of the pointer position, optionally evaluated against a coordinate origin of a supplied UIElement.</summary>
    /// <param name="relativeTo">Any UIElement -derived object that is connected to the same object tree. To specify the object relative to the overall coordinate system, use a *relativeTo*  value of **null**.</param>
    /// <returns>A Point that represents the current x- and y-coordinates of the mouse pointer position. If **null** was passed as *relativeTo*, this coordinate is for the overall window. If a *relativeTo* value other than **null** was passed, this coordinate is relative to the object referenced by *relativeTo*.</returns>
    [MethodImpl]
    public extern Point GetPosition(UIElement relativeTo);
  }
}
