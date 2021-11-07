// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.VenueData
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  /// <summary>Represents the venue associated with a geographic location.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VenueData : IVenueData
  {
    /// <summary>Gets the identifier (ID) of the venue.</summary>
    /// <returns>The identifier (ID) of the venue.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets the identifier (ID) of the building level.</summary>
    /// <returns>The identifier (ID) of the building level.</returns>
    public extern string Level { [MethodImpl] get; }
  }
}
