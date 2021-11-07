// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialAnchorExporterStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [Guid(3978627000, 9333, 17308, 133, 255, 127, 237, 52, 31, 220, 136)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (SpatialAnchorExporter))]
  internal interface ISpatialAnchorExporterStatics
  {
    SpatialAnchorExporter GetDefault();

    [RemoteAsync]
    IAsyncOperation<SpatialPerceptionAccessStatus> RequestAccessAsync();
  }
}
