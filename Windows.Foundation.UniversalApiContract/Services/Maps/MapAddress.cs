// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapAddress
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  /// <summary>Represents an address.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class MapAddress : IMapAddress, IMapAddress2
  {
    /// <summary>Gets or sets the building name of an address.</summary>
    /// <returns>The building name of an address.</returns>
    public extern string BuildingName { [MethodImpl] get; }

    /// <summary>Gets or sets the building floor of an address.</summary>
    /// <returns>The building floor of an address.</returns>
    public extern string BuildingFloor { [MethodImpl] get; }

    /// <summary>Gets or sets the building room of an address.</summary>
    /// <returns>The building room of an address.</returns>
    public extern string BuildingRoom { [MethodImpl] get; }

    /// <summary>Gets or sets the building wing of an address.</summary>
    /// <returns>The building wing of an address.</returns>
    public extern string BuildingWing { [MethodImpl] get; }

    /// <summary>Gets or sets the street number of an address.</summary>
    /// <returns>The street number of an address.</returns>
    public extern string StreetNumber { [MethodImpl] get; }

    /// <summary>Gets or sets the street of an address.</summary>
    /// <returns>The street of an address.</returns>
    public extern string Street { [MethodImpl] get; }

    /// <summary>Gets or sets the neighborhood of an address.</summary>
    /// <returns>The neighborhood of an address.</returns>
    public extern string Neighborhood { [MethodImpl] get; }

    /// <summary>Gets or sets the district of an address.</summary>
    /// <returns>The district of an address.</returns>
    public extern string District { [MethodImpl] get; }

    /// <summary>Gets or sets the town or city of an address.</summary>
    /// <returns>The town or city of an address.</returns>
    public extern string Town { [MethodImpl] get; }

    /// <summary>Gets or sets the region (for example, the state or province) of an address.</summary>
    /// <returns>The region (for example, the state or province) of an address.</returns>
    public extern string Region { [MethodImpl] get; }

    /// <summary>Gets or sets the code for the region (for example, the state or province) of an address.</summary>
    /// <returns>The code for the region (for example, the state or province) of an address.</returns>
    public extern string RegionCode { [MethodImpl] get; }

    /// <summary>Gets or sets the country of an address.</summary>
    /// <returns>The country of an address.</returns>
    public extern string Country { [MethodImpl] get; }

    /// <summary>Gets or sets the country code of an address.</summary>
    /// <returns>The country code of an address.</returns>
    public extern string CountryCode { [MethodImpl] get; }

    /// <summary>Gets or sets the postal code of an address.</summary>
    /// <returns>The postal code of an address.</returns>
    public extern string PostCode { [MethodImpl] get; }

    /// <summary>Gets or sets the continent of an address.</summary>
    /// <returns>The continent of an address.</returns>
    public extern string Continent { [MethodImpl] get; }

    /// <summary>Gets the complete address in string format.</summary>
    /// <returns>The complete address in string format.</returns>
    public extern string FormattedAddress { [MethodImpl] get; }
  }
}
