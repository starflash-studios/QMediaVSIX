// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialEntityStoreStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System.RemoteSystems;

namespace Windows.Perception.Spatial
{
  [Guid(1800091806, 31824, 20114, 138, 98, 77, 29, 75, 124, 205, 62)]
  [ExclusiveTo(typeof (SpatialEntityStore))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ISpatialEntityStoreStatics
  {
    bool IsSupported { get; }

    [Overload("TryGetForRemoteSystemSession")]
    SpatialEntityStore TryGet(RemoteSystemSession session);
  }
}
