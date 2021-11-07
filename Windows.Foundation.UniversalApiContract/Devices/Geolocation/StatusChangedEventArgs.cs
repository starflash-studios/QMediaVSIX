// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.StatusChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  /// <summary>Provides information for the StatusChanged event.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class StatusChangedEventArgs : IStatusChangedEventArgs
  {
    /// <summary>The updated status of the Geolocator object.</summary>
    /// <returns>The updated status of the Geolocator object. The status indicates the ability of the Geolocator to provide location updates.</returns>
    public extern PositionStatus Status { [MethodImpl] get; }
  }
}
