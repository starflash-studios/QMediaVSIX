// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DragDrop.Core.ICoreDropOperationTarget
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer.DragDrop.Core
{
  /// <summary>Contains methods required for supporting drag and drop.</summary>
  [Guid(3641860502, 19547, 16765, 187, 55, 118, 56, 29, 239, 141, 180)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public interface ICoreDropOperationTarget
  {
    /// <summary>Called when the dragged item enters the drop area.</summary>
    /// <param name="dragInfo">The core drag information.</param>
    /// <param name="dragUIOverride">Overrides to default the drag UI.</param>
    /// <returns>When this method completes, it returns the data package operation.</returns>
    [RemoteAsync]
    IAsyncOperation<DataPackageOperation> EnterAsync(
      CoreDragInfo dragInfo,
      CoreDragUIOverride dragUIOverride);

    /// <summary>Called when the dragged item is over the drop area.</summary>
    /// <param name="dragInfo">The core drag information.</param>
    /// <param name="dragUIOverride">Overrides to default the drag UI.</param>
    /// <returns>When this method completes, it returns the data package operation.</returns>
    [RemoteAsync]
    IAsyncOperation<DataPackageOperation> OverAsync(
      CoreDragInfo dragInfo,
      CoreDragUIOverride dragUIOverride);

    /// <summary>Called when a dragged item leaves the target drop area.</summary>
    /// <param name="dragInfo">The core drag information.</param>
    /// <returns>This method does not return an object or value.</returns>
    [RemoteAsync]
    IAsyncAction LeaveAsync(CoreDragInfo dragInfo);

    /// <summary>Called when a dragged item is dropped.</summary>
    /// <param name="dragInfo">The core drag information.</param>
    /// <returns>The data package operation.</returns>
    [RemoteAsync]
    IAsyncOperation<DataPackageOperation> DropAsync(
      CoreDragInfo dragInfo);
  }
}
