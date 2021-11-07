// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialEntityStore
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(848791738, 58643, 20230, 136, 157, 27, 227, 14, 207, 67, 230)]
  [ExclusiveTo(typeof (SpatialEntityStore))]
  internal interface ISpatialEntityStore
  {
    [RemoteAsync]
    IAsyncAction SaveAsync(SpatialEntity entity);

    [RemoteAsync]
    IAsyncAction RemoveAsync(SpatialEntity entity);

    SpatialEntityWatcher CreateEntityWatcher();
  }
}
