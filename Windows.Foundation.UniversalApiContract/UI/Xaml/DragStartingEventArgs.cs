// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.DragStartingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Provides event data for the DragStarting event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DragStartingEventArgs : 
    RoutedEventArgs,
    IDragStartingEventArgs,
    IDragStartingEventArgs2
  {
    /// <summary>Gets or sets a value that indicates whether the drag action should be canceled.</summary>
    /// <returns>**true** to cancel the drag action; otherwise, **false**. The default is **false**.</returns>
    public extern bool Cancel { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the data payload associated with a drag action.</summary>
    /// <returns>The data payload. The default is an empty DataPackage.</returns>
    public extern DataPackage Data { [MethodImpl] get; }

    /// <summary>Gets the visual representation of the data being dragged.</summary>
    /// <returns>The visual representation of the data being dragged.</returns>
    public extern DragUI DragUI { [MethodImpl] get; }

    /// <summary>Supports asynchronous drag-and-drop operations by creating and returning a DragOperationDeferral object.</summary>
    /// <returns>A deferral object that you can use to identify when the generation of the data package is complete.</returns>
    [MethodImpl]
    public extern DragOperationDeferral GetDeferral();

    /// <summary>Returns a drop point that is relative to a specified UIElement.</summary>
    /// <param name="relativeTo">The UIElement for which to get a relative drop point.</param>
    /// <returns>A point in the coordinate system that is relative to the element specified in *relativeTo*.</returns>
    [MethodImpl]
    public extern Point GetPosition(UIElement relativeTo);

    /// <summary>Gets or sets the allowed data package operations (none, move, copy, and/or link) for the drag and drop operation.</summary>
    /// <returns>The allowed data operations.</returns>
    public extern DataPackageOperation AllowedOperations { [MethodImpl] get; [MethodImpl] set; }
  }
}
