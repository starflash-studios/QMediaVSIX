// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IGeovisitTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(1209593258, 1249, 16679, 154, 76, 25, 53, 27, 138, 128, 164)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (GeovisitTrigger))]
  internal interface IGeovisitTrigger : IBackgroundTrigger
  {
    VisitMonitoringScope MonitoringScope { get; set; }
  }
}
