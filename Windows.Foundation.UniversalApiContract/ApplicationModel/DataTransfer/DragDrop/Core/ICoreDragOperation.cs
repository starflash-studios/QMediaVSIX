// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DragDrop.Core.ICoreDragOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.ApplicationModel.DataTransfer.DragDrop.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3423002191, 28080, 20066, 171, 27, 167, 74, 2, 220, 109, 133)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CoreDragOperation))]
  internal interface ICoreDragOperation
  {
    DataPackage Data { get; }

    void SetPointerId(uint pointerId);

    [Overload("SetDragUIContentFromSoftwareBitmap")]
    void SetDragUIContentFromSoftwareBitmap(SoftwareBitmap softwareBitmap);

    [Overload("SetDragUIContentFromSoftwareBitmapWithAnchorPoint")]
    void SetDragUIContentFromSoftwareBitmap(SoftwareBitmap softwareBitmap, Point anchorPoint);

    CoreDragUIContentMode DragUIContentMode { get; set; }

    [RemoteAsync]
    IAsyncOperation<DataPackageOperation> StartAsync();
  }
}
