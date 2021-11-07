// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.GeovisitStateChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  /// <summary>Contains information about a VisitStateChanged event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772164)]
  public sealed class GeovisitStateChangedEventArgs : IGeovisitStateChangedEventArgs
  {
    /// <summary>Gets the Visit-related event corresponding to a VisitStateChanged event that was raised.</summary>
    /// <returns>A Geovisit instance representing the Visit-related event that denotes a change in state.</returns>
    public extern Geovisit Visit { [MethodImpl] get; }
  }
}
