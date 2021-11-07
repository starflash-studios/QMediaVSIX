// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.GeovisitTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  /// <summary>Manages the details of a trigger for a Visits-related background task.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [DualApiPartition(version = 167772164)]
  public sealed class GeovisitTriggerDetails : IGeovisitTriggerDetails
  {
    /// <summary>Gets a list of Visit-related state changes that the user has logged since they were last queried.</summary>
    /// <returns>An IVectorView of Geovisit instances representing the user's Visit-related state changes.</returns>
    [MethodImpl]
    public extern IVectorView<Geovisit> ReadReports();
  }
}
