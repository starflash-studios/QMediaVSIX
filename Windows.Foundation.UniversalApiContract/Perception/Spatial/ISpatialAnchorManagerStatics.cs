// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialAnchorManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2296581803, 62391, 16907, 176, 134, 138, 128, 192, 125, 145, 13)]
  [ExclusiveTo(typeof (SpatialAnchorManager))]
  internal interface ISpatialAnchorManagerStatics
  {
    [RemoteAsync]
    IAsyncOperation<SpatialAnchorStore> RequestStoreAsync();
  }
}
