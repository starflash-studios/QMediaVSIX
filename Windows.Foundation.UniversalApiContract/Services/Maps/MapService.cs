// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapService
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  /// <summary>Communicates with the online map services.</summary>
  [Static(typeof (IMapServiceStatics4), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMapServiceStatics3), 131072, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IMapServiceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMapServiceStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public static class MapService
  {
    /// <summary>Gets or sets an object that specifies whether to use offline or online map data.</summary>
    /// <returns>An object that specifies whether to use offline or online map data.</returns>
    public static extern MapServiceDataUsagePreference DataUsagePreference { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the data provider for the mapping services.</summary>
    /// <returns>The data provider for the mapping services.</returns>
    public static extern string DataAttributions { [MethodImpl] get; }

    /// <summary>Gets the three digit country code used by the Map service, based on the ISO 3166-1 alpha-3 codes.</summary>
    /// <returns>The three digit country code used by the Map service, based on the ISO 3166-1 alpha-3 codes.</returns>
    public static extern string WorldViewRegionCode { [MethodImpl] get; }

    /// <summary>Gets or sets the application ID and the authentication token required for use of the online mapping services.</summary>
    /// <returns>The application ID and the authentication token required for use of the online mapping services.</returns>
    public static extern string ServiceToken { [MethodImpl] set; [MethodImpl] get; }
  }
}
