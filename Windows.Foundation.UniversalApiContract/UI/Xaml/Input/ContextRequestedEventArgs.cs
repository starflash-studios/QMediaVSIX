// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.ContextRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Provides event data for the ContextRequested event.</summary>
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  public sealed class ContextRequestedEventArgs : RoutedEventArgs, IContextRequestedEventArgs
  {
    /// <summary>Initializes a new instance of the ContextRequestedEventArgs class.</summary>
    [MethodImpl]
    public extern ContextRequestedEventArgs();

    /// <summary>Gets or sets a value that marks the routed event as handled. A **true** value for **Handled** prevents most handlers along the event route from handling the same event again.</summary>
    /// <returns>**true** to mark the routed event handled. **false** to leave the routed event unhandled, which permits the event to potentially route further and be acted on by other handlers. The default is **false**.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the x- and y-coordinates of the pointer position, optionally evaluated against a coordinate origin of a supplied UIElement.</summary>
    /// <param name="relativeTo">Any UIElement -derived object that is connected to the same object tree. To specify the object relative to the overall coordinate system, use a *relativeTo*  value of **null**.</param>
    /// <param name="point">A Point that represents the current x- and y-coordinates of the mouse pointer position. If **null** was passed as *relativeTo*, this coordinate is for the overall window. If a *relativeTo* value other than **null** was passed, this coordinate is relative to the object referenced by *relativeTo*.</param>
    /// <returns>**true** if the context request was initiated by a pointer device; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool TryGetPosition(UIElement relativeTo, out Point point);
  }
}
