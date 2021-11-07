// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IProjectionManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ExclusiveTo(typeof (ProjectionManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3059716413, 58096, 20477, 186, 149, 52, 36, 22, 71, 228, 92)]
  internal interface IProjectionManagerStatics
  {
    [Overload("StartProjectingAsync")]
    [RemoteAsync]
    IAsyncAction StartProjectingAsync(int projectionViewId, int anchorViewId);

    [RemoteAsync]
    IAsyncAction SwapDisplaysForViewsAsync(int projectionViewId, int anchorViewId);

    [RemoteAsync]
    IAsyncAction StopProjectingAsync(int projectionViewId, int anchorViewId);

    bool ProjectionDisplayAvailable { get; }

    event EventHandler<object> ProjectionDisplayAvailableChanged;
  }
}
