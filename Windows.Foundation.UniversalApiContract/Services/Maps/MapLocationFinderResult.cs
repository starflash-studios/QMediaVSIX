// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapLocationFinderResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  /// <summary>Returns the result of a MapLocationFinder query.</summary>
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MapLocationFinderResult : IMapLocationFinderResult
  {
    /// <summary>Gets the list of locations found by a MapLocationFinder query.</summary>
    /// <returns>The list of locations found by a MapLocationFinder query. This property returns a collection of MapLocation objects.</returns>
    public extern IVectorView<MapLocation> Locations { [MethodImpl] get; }

    /// <summary>Gets the status of a MapLocationFinder query.</summary>
    /// <returns>The status of a MapLocationFinder query.</returns>
    public extern MapLocationFinderStatus Status { [MethodImpl] get; }
  }
}
