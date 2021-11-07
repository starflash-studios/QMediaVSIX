// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.GeovisitTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents an event that triggers a Visits-related background task.</summary>
  [Activatable(327680, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public sealed class GeovisitTrigger : IGeovisitTrigger, IBackgroundTrigger
  {
    /// <summary>Initializes a new GeovisitTrigger instance.</summary>
    [MethodImpl]
    public extern GeovisitTrigger();

    /// <summary>Gets and sets the scope of Visits to monitor.</summary>
    /// <returns>A VisitMonitoringScope value representing the scope of location monitoring.</returns>
    public extern VisitMonitoringScope MonitoringScope { [MethodImpl] get; [MethodImpl] set; }
  }
}
