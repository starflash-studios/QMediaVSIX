// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.GeovisitMonitor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  /// <summary>Handles the monitoring of a user's Visits when the app is in use (not in the background).</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772164)]
  [Activatable(327680, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IGeovisitMonitorStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  public sealed class GeovisitMonitor : IGeovisitMonitor
  {
    /// <summary>Initializes an instance of GeovisitMonitor.</summary>
    [MethodImpl]
    public extern GeovisitMonitor();

    /// <summary>Gets and the scope of Visits to monitor.</summary>
    /// <returns>A VisitMonitoringScope value representing the desired scope of location changes to monitor.</returns>
    public extern VisitMonitoringScope MonitoringScope { [MethodImpl] get; }

    /// <summary>Begins monitoring for Visit-related events.</summary>
    /// <param name="value">A VisitMonitoringScope value representing the desired scope of location changes to monitor.</param>
    [MethodImpl]
    public extern void Start(VisitMonitoringScope value);

    /// <summary>Stops monitoring for Visit-related events.</summary>
    [MethodImpl]
    public extern void Stop();

    /// <summary>Raised when the user's current Visit state has changed, provided this GeovisitMonitor is currently monitoring.</summary>
    public extern event TypedEventHandler<GeovisitMonitor, GeovisitStateChangedEventArgs> VisitStateChanged;

    /// <summary>Retrieves the latest Visit-related event the user has completed.</summary>
    /// <returns>An asynchronous operation with a Geovisit instance representing the user's latest Visit.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<Geovisit> GetLastReportAsync();
  }
}
