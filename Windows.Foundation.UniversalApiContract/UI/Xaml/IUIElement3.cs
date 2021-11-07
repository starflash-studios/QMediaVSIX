// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUIElement3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input;
using Windows.UI.Xaml.Media.Media3D;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (UIElement))]
  [Guid(3156945137, 9970, 19115, 178, 86, 59, 83, 80, 136, 30, 55)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IUIElement3
  {
    Transform3D Transform3D { get; set; }

    bool CanDrag { get; set; }

    event TypedEventHandler<UIElement, DragStartingEventArgs> DragStarting;

    event TypedEventHandler<UIElement, DropCompletedEventArgs> DropCompleted;

    [RemoteAsync]
    IAsyncOperation<DataPackageOperation> StartDragAsync(
      PointerPoint pointerPoint);
  }
}
