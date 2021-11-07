// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeovisitMonitorStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [Guid(3170465447, 48114, 19677, 149, 207, 85, 76, 130, 237, 251, 135)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (GeovisitMonitor))]
  internal interface IGeovisitMonitorStatics
  {
    [RemoteAsync]
    IAsyncOperation<Geovisit> GetLastReportAsync();
  }
}
