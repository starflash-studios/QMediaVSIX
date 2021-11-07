// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DragDrop.Core.CoreDragOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.ApplicationModel.DataTransfer.DragDrop.Core
{
  /// <summary>Handles a drag and drop operation.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CoreDragOperation : ICoreDragOperation, ICoreDragOperation2
  {
    /// <summary>Initializes a new instance of the CoreDragOperation class.</summary>
    [MethodImpl]
    public extern CoreDragOperation();

    /// <summary>Gets the DataPackage for the drag and drop operation.</summary>
    /// <returns>The DataPackage for the drag and drop operation</returns>
    public extern DataPackage Data { [MethodImpl] get; }

    /// <summary>Sets the pointer Id.</summary>
    /// <param name="pointerId">The pointer Id.</param>
    [MethodImpl]
    public extern void SetPointerId(uint pointerId);

    /// <summary>Sets custom drag UI content using a software bitmap.</summary>
    /// <param name="softwareBitmap">The custom UI drag content.</param>
    [Overload("SetDragUIContentFromSoftwareBitmap")]
    [MethodImpl]
    public extern void SetDragUIContentFromSoftwareBitmap(SoftwareBitmap softwareBitmap);

    /// <summary>Sets custom drag UI content using a software bitmap.</summary>
    /// <param name="softwareBitmap">The custom UI drag content.</param>
    /// <param name="anchorPoint">The relative position of the drag visual from the pointer. The anchor point cannot be outside of the content. For example, if the anchor point is (50, 50) and the position of the pointer is (x, y), the top left corner for the visual will be (x - 50, y - 50).</param>
    [Overload("SetDragUIContentFromSoftwareBitmapWithAnchorPoint")]
    [MethodImpl]
    public extern void SetDragUIContentFromSoftwareBitmap(
      SoftwareBitmap softwareBitmap,
      Point anchorPoint);

    /// <summary>Gets or sets the content mode for the drag UI.</summary>
    /// <returns>The content mode for the drag UI.</returns>
    public extern CoreDragUIContentMode DragUIContentMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Starts the drag and drop operation.</summary>
    /// <returns>The data package operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DataPackageOperation> StartAsync();

    /// <summary>Gets or sets the allowed DataPackageOperations (none, move, copy, and/or link) for the drag and drop operation.</summary>
    /// <returns>The allowed operations. The default is **Copy** | **Move** | **Link**.</returns>
    public extern DataPackageOperation AllowedOperations { [MethodImpl] get; [MethodImpl] set; }
  }
}
