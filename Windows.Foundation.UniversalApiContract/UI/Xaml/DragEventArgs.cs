// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.DragEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.DataTransfer;
using Windows.ApplicationModel.DataTransfer.DragDrop;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Provides data for drag-and-drop events.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DragEventArgs : 
    RoutedEventArgs,
    IDragEventArgs,
    IDragEventArgs2,
    IDragEventArgs3
  {
    /// <summary>Gets or sets a value that indicates the present state of the event handling for a routed event as it travels the route.</summary>
    /// <returns>**true** if the event is marked handled; otherwise, **false**. The default value is **false**.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a data object (DataPackage ) that contains the data associated with the corresponding drag event. This value is not useful in all event cases; specifically, the event must be handled by a valid drop target.</summary>
    /// <returns>The data object that contains data payload that is associated with the corresponding drag event.</returns>
    public extern DataPackage Data { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Returns a drop point that is relative to a specified UIElement.</summary>
    /// <param name="relativeTo">The UIElement for which to get a relative drop point.</param>
    /// <returns>A point in the coordinate system that is relative to the element specified in *relativeTo*.</returns>
    [MethodImpl]
    public extern Point GetPosition(UIElement relativeTo);

    /// <summary>Gets a read-only copy of the Data object.</summary>
    /// <returns>A read-only copy of the Data object.</returns>
    public extern DataPackageView DataView { [MethodImpl] get; }

    /// <summary>Gets the visual representation of the data being dragged.</summary>
    /// <returns>The visual representation of the data being dragged. The default is **null**.</returns>
    public extern DragUIOverride DragUIOverride { [MethodImpl] get; }

    /// <summary>Gets a flag enumeration indicating the current state of the SHIFT, CTRL, and ALT keys, as well as the state of the mouse buttons.</summary>
    /// <returns>One or more members of the DragDropModifiers flag enumeration.</returns>
    public extern DragDropModifiers Modifiers { [MethodImpl] get; }

    /// <summary>Gets or sets a value that specifies which operations are allowed by the originator of the drag event.</summary>
    /// <returns>A member of the DataPackageOperation enumeration that specifies which operations are allowed by the originator of the drag event.</returns>
    public extern DataPackageOperation AcceptedOperation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Supports asynchronous drag-and-drop operations by creating and returning a DragOperationDeferral object.</summary>
    /// <returns>A deferral object that you can use to identify when the generation of the data package is complete.</returns>
    [MethodImpl]
    public extern DragOperationDeferral GetDeferral();

    /// <summary>Gets the allowed data package operations (none, move, copy, and/or link) for the drag and drop operation.</summary>
    /// <returns>The allowed data operations.</returns>
    public extern DataPackageOperation AllowedOperations { [MethodImpl] get; }
  }
}
