// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialInteractionSource4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.People;

namespace Windows.UI.Input.Spatial
{
  [Guid(7584845, 57190, 23185, 162, 186, 206, 163, 229, 197, 138, 25)]
  [ExclusiveTo(typeof (SpatialInteractionSource))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface ISpatialInteractionSource4
  {
    HandMeshObserver TryCreateHandMeshObserver();

    [RemoteAsync]
    IAsyncOperation<HandMeshObserver> TryCreateHandMeshObserverAsync();
  }
}
