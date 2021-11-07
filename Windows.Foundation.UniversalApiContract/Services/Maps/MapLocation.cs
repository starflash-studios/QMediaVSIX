// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapLocation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  /// <summary>Represents a geographic location.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class MapLocation : IMapLocation
  {
    /// <summary>Gets the coordinates of a geographic location.</summary>
    /// <returns>The coordinates of a geographic location.</returns>
    public extern Geopoint Point { [MethodImpl] get; }

    /// <summary>Gets the display name of a geographic location.</summary>
    /// <returns>The display name of a geographic location.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets the description of a geographic location.</summary>
    /// <returns>The description of a geographic location.</returns>
    public extern string Description { [MethodImpl] get; }

    /// <summary>Gets the address of a geographic location.</summary>
    /// <returns>The address of a geographic location.</returns>
    public extern MapAddress Address { [MethodImpl] get; }
  }
}
